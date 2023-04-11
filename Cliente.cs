class Cliente
{
    private static int proximoId = 1;

    public int Id { get; }
    public string Nome { get; set; }
    public string Email { get; set; }

    public Cliente(string nome, string email)
    {
        this.Id = proximoId;
        this.Nome = nome;
        this.Email = email;
        proximoId++;
    }
}