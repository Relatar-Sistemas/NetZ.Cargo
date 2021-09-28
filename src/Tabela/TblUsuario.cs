using NetZ.Cargo.Modelo;
using System.Text;
using System.Text.Json;

namespace NetZ.Cargo.Tabela
{
    internal class TblUsuario : TabelaBase
    {
        protected override string getJson(ModeloBase modelo)
        {
            return JsonSerializer.Serialize(modelo as Usuario);
        }

        protected override string getLinha(ModeloBase modelo)
        {
            var usuario = modelo as Usuario;

            var resultado = new StringBuilder();

            resultado.Append(string.Format("Login: {0}; ", usuario.login));
            resultado.Append(string.Format("Senha: {0}; ", usuario.senha));

            return resultado.ToString();
        }

        protected override ModeloBase getModelo(string json)
        {
            return JsonSerializer.Deserialize<Usuario>(json);
        }

        protected override string getTabela()
        {
            return nameof(Usuario);
        }
    }
}