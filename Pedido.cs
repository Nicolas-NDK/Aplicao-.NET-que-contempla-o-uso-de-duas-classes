class Pedido
{
    public Cliente Cliente { get; set; }
    public string Produto { get; set; }
    public double ValorUnitario { get; set; }
    public int Quantidade { get; set; }

    public double ValorTotal
    {
        get { return this.ValorUnitario * this.Quantidade; }
    }

    public Pedido(Cliente cliente, string produto, double valorUnitario, int quantidade = 1)
    {
        this.Cliente = cliente;
        this.Produto = produto;
        this.ValorUnitario = valorUnitario;
        this.Quantidade = quantidade;
    }
}