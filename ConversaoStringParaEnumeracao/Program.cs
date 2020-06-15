using ConversaoStringParaEnumeracao.Entities;
using ConversaoStringParaEnumeracao.Entities.Enums;
using System;

namespace ConversaoStringParaEnumeracao
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Instanciando um pedido:
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);
            Console.WriteLine();


            // Conversao de enumerado para String:
            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);

            // Convertendo de string para enumerado:
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);


        }
    }
}
