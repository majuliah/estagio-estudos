public class MyEnum
{
    public enum OrderStatus : int
    {
        PendingPayment = 1,
        Processing = 2,
        Shipped = 3,
        Delivered = 4
    }

    string NomeDaString = OrderStatus.PendingPayment.ToString();
    //a variável está recebendo:
                        //o enum como um tipo, chamando o status do pedido e convertendo pra string

    OrderStatus nomeDaVariavel = Enum.Parse<OrderStatus>("Delivered");
    //a variável do tipo OrderStatus 
                                //está recebendo o valor string que estamos convertendo para o tipo enum
                                //por isso o Enum.Parse<OenumQueQueremosConverter(porque pode ter mais de um enum no workspace e devemos especificar qual queremos converter)>
                                
}