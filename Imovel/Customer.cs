namespace Imovel
{
    public enum TipoImovel
    {
        Casa = 1,
        Apartamento = 2,
    }

    public enum TipoAcordo
    {
        Venda = 1,
        Aluguel = 2,
    }

    public class Customer
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public TipoImovel Tipo { get; set; }
        public TipoAcordo Acordo { get; set; }
    }
}
