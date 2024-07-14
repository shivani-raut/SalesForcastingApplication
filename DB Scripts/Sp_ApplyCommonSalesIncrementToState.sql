CREATE PROCEDURE [dbo].[ApplyCommonSalesIncrementToState]
    @SelectedYear INT,
    @PercentageIncrement DECIMAL(5, 2)
AS
BEGIN
    -- Calculate total sales for the selected year and apply the percentage increment
    SELECT 
        o.State,
        SUM(op.Sales) AS TotalSales,
        SUM(op.Sales) * @PercentageIncrement / 100 AS IncrementedSales,
        SUM(op.Sales) + (SUM(op.Sales) * @PercentageIncrement / 100) AS NewSales
    FROM Orders o
    JOIN OrderProductInfo op ON o.OrderID = op.OrderID
    WHERE YEAR(o.OrderDate) = @SelectedYear
    GROUP BY o.State;
END;


