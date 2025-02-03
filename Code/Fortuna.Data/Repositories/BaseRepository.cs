using AutoMapper;
using Fortuna.Data.DbContenxt;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Data.Common;

namespace Fortuna.Data.Repositories
{
    public abstract class BaseRepository : IDisposable
    {
        protected readonly FortunaDbContext _dbContext;
        protected readonly IMapper _mapper;

        private const int DEFAULT_TIMEOUT = 600;

        public BaseRepository(FortunaDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        #region Save Operations

        /// <summary>
        /// Saves an entity to the database. This performs an upsert operation.
        /// </summary>
        /// <typeparam name="T">The type of the entity.</typeparam>
        /// <param name="entity">The entity to save.</param>
        public async Task SaveAsync<T>(T entity) where T : class
        {
            AttachOrAddEntity(entity);
            await _dbContext.SaveChangesAsync();
        }

        /// <summary>
        /// Saves multiple entities to the database.
        /// </summary>
        /// <typeparam name="T">The type of the entities.</typeparam>
        /// <param name="entities">The entities to save.</param>
        public async Task SaveRangeAsync<T>(IEnumerable<T> entities) where T : class
        {
            foreach (var entity in entities)
            {
                AttachOrAddEntity(entity);
            }
            await _dbContext.SaveChangesAsync();
        }

        private void AttachOrAddEntity<T>(T entity) where T : class
        {
            var entry = _dbContext.Entry(entity);
            // Dynamically get the primary key based on the entity type name and conventional naming
            bool isNew = CheckIfEntityIsNew(entity);

            if (isNew)
            {
                // Entity is new, add it to the context
                _dbContext.Set<T>().Add(entity);
            }
            else
            {
                // Existing entity, attach and mark as modified
                if (entry.State == EntityState.Detached)
                {
                    _dbContext.Set<T>().Attach(entity);
                    entry.State = EntityState.Modified;
                }
                else if (entry.State == EntityState.Unchanged)
                {
                    entry.State = EntityState.Modified;
                }
            }
        }

        // Generic method to check if the entity is new by looking for a primary key with a default value
        private bool CheckIfEntityIsNew<T>(T entity) where T : class
        {
            var entityType = entity.GetType();
            var keyPropertyName = entityType.Name + "Id";  // Assuming the primary key follows the convention 'EntityNameId'
            var keyProperty = entityType.GetProperty(keyPropertyName);

            if (keyProperty != null)
            {
                object value = keyProperty.GetValue(entity);
                if (value is int intValue)
                    return intValue == 0;  // Assuming the default value for a new entity's int primary key is 0
                if (value is long longValue)
                    return longValue == 0;  // Assuming long for larger datasets
                                            // Include other types as necessary based on your database schema
            }

            return false; // If no appropriate key property found, or the key property does not have a default indicating new
        }

        #endregion

        #region Delete Operations

        /// <summary>
        /// Deletes an entity from the database.
        /// </summary>
        /// <typeparam name="T">The type of the entity.</typeparam>
        /// <param name="entity">The entity to delete.</param>
        public async Task DeleteAsync<T>(T entity) where T : class
        {
            _dbContext.Set<T>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        /// <summary>
        /// Deletes a range of entities from the database.
        /// </summary>
        /// <typeparam name="T">The type of the entities.</typeparam>
        /// <param name="entities">The entities to delete.</param>
        public async Task DeleteRangeAsync<T>(IEnumerable<T> entities) where T : class
        {
            _dbContext.Set<T>().RemoveRange(entities);
            await _dbContext.SaveChangesAsync();
        }

        #endregion

        #region Stored Procedure Execution

        /// <summary>
        /// Executes a stored procedure and returns the result as a list of dictionaries.
        /// </summary>
        /// <param name="storedProcName">The name of the stored procedure.</param>
        /// <param name="parameters">The parameters for the stored procedure.</param>
        /// <returns>A list of dictionaries representing the result.</returns>
        public async Task<List<Dictionary<string, object>>> ExecuteStoredProcAsync(string storedProcName, params SqlParameter[] parameters)
        {
            using var command = _dbContext.Database.GetDbConnection().CreateCommand();
            command.CommandText = storedProcName;
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(parameters);
            await _dbContext.Database.OpenConnectionAsync();

            using var reader = await command.ExecuteReaderAsync();
            return MapReaderToDictionary(reader);
        }

        private List<Dictionary<string, object>> MapReaderToDictionary(DbDataReader reader)
        {
            var results = new List<Dictionary<string, object>>();
            while (reader.Read())
            {
                var row = new Dictionary<string, object>();
                for (var i = 0; i < reader.FieldCount; i++)
                {
                    row[reader.GetName(i)] = reader.IsDBNull(i) ? null : reader.GetValue(i);
                }
                results.Add(row);
            }
            return results;
        }

        #endregion

        #region Utility Methods

        /// <summary>
        /// Converts an enumerable of IDs to a DataTable for use with table-valued parameters.
        /// </summary>
        /// <param name="ids">The IDs.</param>
        /// <returns>A DataTable containing the IDs.</returns>
        public DataTable GetIdListDataTable(IEnumerable<long> ids)
        {
            var table = new DataTable();
            table.Columns.Add("Id", typeof(long));

            foreach (var id in ids)
            {
                table.Rows.Add(id);
            }

            return table;
        }

        #endregion

        #region Dispose

        public void Dispose()
        {
            _dbContext.Dispose();
        }

        #endregion
    }
}
