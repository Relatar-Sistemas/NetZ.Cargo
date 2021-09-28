using NetZ.Cargo.Modelo;
using System.Text;
using System.Text.Json;

namespace NetZ.Cargo.Tabela
{
    internal class TblFabricante : TabelaBase
    {
        protected override string getJson(ModeloBase modelo)
        {
            return JsonSerializer.Serialize(modelo as Fabricante);
        }

        protected override string getLinha(ModeloBase modelo)
        {
            var fabricante = modelo as Fabricante;

            var resultado = new StringBuilder();

            resultado.Append(string.Format("Nome: {0}; ", fabricante.nome));

            return resultado.ToString();
        }

        protected override ModeloBase getModelo(string json)
        {
            return JsonSerializer.Deserialize<Fabricante>(json);
        }

        protected override string getTabela()
        {
            return nameof(Fabricante);
        }
    }
}