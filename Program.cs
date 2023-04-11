class Program
{
    static void Main(string[] args)
    {
        // criando objetos da classe Cliente e Pedido
        Cliente cliente1 = new Cliente("João da Silva", "joao.silva@gmail.com");
        Cliente cliente2 = new Cliente("Nicolas Quintanilha", "nicolas.quintanilha@gmail.com");
        Pedido pedido1 = new Pedido(cliente1, "Pizza de Calabresa", 25.0);
        Pedido pedido2 = new Pedido(cliente2, "Pizza de 5 Queijos", 30.0);

        // exibindo informações do pedido
        Console.WriteLine("Pedido do cliente {0}:", pedido1.Cliente.Nome);
        Console.WriteLine("Produto: {0}", pedido1.Produto);
        Console.WriteLine("Valor: R$ {0:0.00}", pedido1.ValorTotal);

        Console.WriteLine("Pedido do cliente {0}:", pedido2.Cliente.Nome);
        Console.WriteLine("Produto: {0}", pedido2.Produto);
        Console.WriteLine("Valor: R$ {0:0.00}", pedido2.ValorTotal);

        // alterando o email do cliente
        cliente1.Email = "joao.silva@hotmail.com";
        cliente2.Email = "nicolas.quintanilha@gmail.com";

        // exibindo informações atualizadas do pedido
        Console.WriteLine("\nPedido atualizado do cliente {0}:", pedido1.Cliente.Nome);
        Console.WriteLine("Produto: {0}", pedido1.Produto);
        Console.WriteLine("Valor: R$ {0:0.00}", pedido1.ValorTotal);

        Console.WriteLine("\nPedido atualizado do cliente {0}:", pedido2.Cliente.Nome);
        Console.WriteLine("Produto: {0}", pedido2.Produto);
        Console.WriteLine("Valor: R$ {0:0.00}", pedido2.ValorTotal);
    }
}