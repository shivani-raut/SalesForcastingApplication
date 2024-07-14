CREATE PROCEDURE CalculateYearlySalesByState
    @Year INT,
    @State VARCHAR(512)
AS
BEGIN
    -- Declare variables for total sales and total returns
    DECLARE @TotalSales FLOAT, @TotalReturns FLOAT;

    -- Calculate Year Sales
    SELECT @TotalSales = SUM(Sales)
    FROM OrderProductInfo opi
    JOIN Orders o ON opi.OrderId = o.OrderId
    WHERE YEAR(CAST(o.OrderDate AS DATE)) = @Year
      AND o.State = @State;

     SELECT @TotalReturns = SUM(Sales - (Profit + (Discount * Sales)))
    FROM OrderProductInfo opi
    JOIN Orders o ON opi.OrderId = o.OrderId
    WHERE YEAR(CAST(o.OrderDate AS DATE)) = @Year
      AND o.State = @State;

    -- Calculate Total Sales
    SET @TotalSales = @TotalSales - @TotalReturns;

    -- Output the total sales
    SELECT @TotalSales AS TotalSales;
END;