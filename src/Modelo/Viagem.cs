using System;

namespace NetZ.Cargo.Modelo
{
    internal class Viagem : ModeloBase
    {
        public DateTime chegada { get; set; }
        public string destino { get; set; }
        public int motoristaId { get; set; }
        public string origem { get; set; }
        public DateTime saida { get; set; }
        public int veiculoId { get; set; }
    }
}