using NetZ.Cargo.Modelo;
using System.Text;
using System.Text.Json;

namespace NetZ.Cargo.Tabela
{
    internal class TblViagem : TabelaBase
    {
        protected override string getJson(ModeloBase modelo)
        {
            return JsonSerializer.Serialize(modelo as Viagem);
        }

        protected override string getLinha(ModeloBase modelo)
        {
            var viagem = modelo as Viagem;

            var resultado = new StringBuilder();

            resultado.Append(string.Format("Motorista: {0}; ", viagem.motoristaId));
            resultado.Append(string.Format("Veículo: {0}; ", viagem.veiculoId));
            resultado.Append(string.Format("Origem: {0}; ", viagem.origem));
            resultado.Append(string.Format("Destino: {0}; ", viagem.destino));
            resultado.Append(string.Format("Saída: {0}; ", viagem.saida));
            resultado.Append(string.Format("Chegada: {0}; ", viagem.chegada));

            return resultado.ToString();
        }

        protected override ModeloBase getModelo(string json)
        {
            return JsonSerializer.Deserialize<Viagem>(json);
        }

        protected override string getTabela()
        {
            return nameof(Viagem);
        }
    }
}