USE Fortuna

CREATE TABLE ExpenseType (
    ExpenseTypeId INT PRIMARY KEY,
    ExpenseTypeValue NVARCHAR(255) NOT NULL,
    ExpenseTypeDisplayValue NVARCHAR(255),
    ExpenseTypeDescription NVARCHAR(500),
    SortOrder INT,
    Active BIT NOT NULL,
    UpdatedBy NVARCHAR(255),
    UpdatedDate DATETIME NOT NULL
);

-- Create the ExpenseItemType table
CREATE TABLE ExpenseItemType (
    ExpenseItemId INT PRIMARY KEY,
    ExpenseItemTypeValue NVARCHAR(255) NOT NULL,
    ExpenseItemTypeDisplayValue NVARCHAR(255),
    ExpenseItemTypeDescription NVARCHAR(500),
    SortOrder INT,
    Active BIT NOT NULL,
    UpdatedBy NVARCHAR(255),
    UpdatedDate DATETIME NOT NULL
);

-- Create the Expense table
CREATE TABLE Expense (
    ExpenseId INT PRIMARY KEY,
    ExpenseTypeId INT NOT NULL,
    ExpenseItemId INT NOT NULL,
    ExpenseAmount DECIMAL(18, 2) NOT NULL,
    ExpenseName NVARCHAR(255),
    CONSTRAINT FK_Expense_ExpenseType FOREIGN KEY (ExpenseTypeId) REFERENCES ExpenseType (ExpenseTypeId),
    CONSTRAINT FK_Expense_ExpenseItemType FOREIGN KEY (ExpenseItemId) REFERENCES ExpenseItemType (ExpenseItemId)
);


-- Create the AssetType table
CREATE TABLE AssetType (
    AssetTypeId INT PRIMARY KEY,
    AssetTypeValue NVARCHAR(255) NOT NULL,
    AssetTypeDisplayValue NVARCHAR(255),
    AssetTypeDescription NVARCHAR(500),
    SortOrder INT,
    Active BIT NOT NULL,
    UpdatedBy NVARCHAR(255),
    UpdatedDate DATETIME NOT NULL
);

-- Create the Country table
CREATE TABLE Country (
    CountryId INT PRIMARY KEY,
    CountryValue NVARCHAR(255) NOT NULL,
    CountryDisplayValue NVARCHAR(255),
    CountryDescription NVARCHAR(500),
    SortOrder INT,
    Active BIT NOT NULL,
    UpdatedBy NVARCHAR(255),
    UpdatedDate DATETIME NOT NULL
);

-- Create the Asset table
CREATE TABLE Asset (
    AssetId INT PRIMARY KEY,
    AssetTypeId INT NOT NULL,
    AssetName NVARCHAR(255) NOT NULL,
    BoughtPrice DECIMAL(18, 2),
    CurrentPrice DECIMAL(18, 2),
    CountryId INT NOT NULL,
    Year INT,
    Active BIT NOT NULL,
    UpdatedBy NVARCHAR(255),
    UpdatedDate DATETIME NOT NULL,
    CONSTRAINT FK_Asset_AssetType FOREIGN KEY (AssetTypeId) REFERENCES AssetType (AssetTypeId),
    CONSTRAINT FK_Asset_Country FOREIGN KEY (CountryId) REFERENCES Country (CountryId)
);