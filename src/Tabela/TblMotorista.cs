using NetZ.Cargo.Modelo;
using System.Text;
using System.Text.Json;

namespace NetZ.Cargo.Tabela
{
    internal class TblMotorista : TabelaBase
    {
        protected override string getJson(ModeloBase modelo)
        {
            return JsonSerializer.Serialize(modelo as Motorista);
        }

        protected override string getLinha(ModeloBase modelo)
        {
            var motorista = modelo as Motorista;

            var resultado = new StringBuilder();

            resultado.Append(string.Format("Nome: {0}; ", motorista.nome));
            resultado.Append(string.Format("CNH: {0}; ", motorista.cnh));

            return resultado.ToString();
        }

        protected override ModeloBase getModelo(string json)
        {
            return JsonSerializer.Deserialize<Motorista>(json);
        }

        protected override string getTabela()
        {
            return nameof(Motorista);
        }
    }
}