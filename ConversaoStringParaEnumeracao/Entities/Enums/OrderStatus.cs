
namespace ConversaoStringParaEnumeracao.Entities.Enums
{
    enum OrderStatus : int // Especificando q cada valor sera INT
    {
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
