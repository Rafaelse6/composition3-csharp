namespace Restaurant.Entities.Enums
{
    enum OrderStatus : int
    {
        PendingPayment = 0,
        Processig = 1,
        Shipped = 2,
        Delivered = 3
    }
}