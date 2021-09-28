namespace NetZ.Cargo.Modelo
{
    internal class Veiculo : ModeloBase
    {
        public int ano { get; set; }
        public int fabricanteId { get; set; }
        public string modelo { get; set; }
        public string placa { get; set; }
    }
}