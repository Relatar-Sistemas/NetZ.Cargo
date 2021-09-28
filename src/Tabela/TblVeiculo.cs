using NetZ.Cargo.Modelo;
using System.Text;
using System.Text.Json;

namespace NetZ.Cargo.Tabela
{
    internal class TblVeiculo : TabelaBase
    {
        protected override string getJson(ModeloBase modelo)
        {
            return JsonSerializer.Serialize(modelo as Veiculo);
        }

        protected override string getLinha(ModeloBase modelo)
        {
            var veiculo = modelo as Veiculo;

            var resultado = new StringBuilder();

            resultado.Append(string.Format("Fabricante: {0}; ", veiculo.fabricanteId));
            resultado.Append(string.Format("Modelo: {0}; ", veiculo.modelo));
            resultado.Append(string.Format("Placa: {0}; ", veiculo.placa));
            resultado.Append(string.Format("Ano: {0}; ", veiculo.ano));

            return resultado.ToString();
        }

        protected override ModeloBase getModelo(string json)
        {
            return JsonSerializer.Deserialize<Veiculo>(json);
        }

        protected override string getTabela()
        {
            return nameof(Veiculo);
        }
    }
}