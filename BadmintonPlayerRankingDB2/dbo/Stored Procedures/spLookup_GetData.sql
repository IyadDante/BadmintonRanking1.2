CREATE PROCEDURE [dbo].[spLookup_GetData]
    @TableName NVARCHAR(255),
    @ID INT
AS
BEGIN
    DECLARE @SqlQuery NVARCHAR(MAX)

    -- Build the dynamic SQL query
    SET @SqlQuery = 'SELECT * FROM ' + QUOTENAME(@TableName) + ' WHERE ID = @ID'

    -- Execute the dynamic SQL query
    EXEC sp_executesql @SqlQuery, N'@ID INT', @ID
END