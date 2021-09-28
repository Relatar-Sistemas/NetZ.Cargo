using NetZ.Cargo.Modelo;
using System;
using System.Collections.Generic;
using System.IO;

namespace NetZ.Cargo.Tabela
{
    internal abstract class TabelaBase
    {
        internal string[] getLista()
        {
            var tabela = this.getTabela();
            var diretorio = Path.Combine("data", tabela);

            if (!Directory.Exists(diretorio))
            {
                return default;
            }

            var arquivos = Directory.GetFiles(diretorio);
            var resultado = new List<string>();

            foreach (var arquivo in arquivos)
            {
                var json = File.ReadAllText(arquivo);
                var modelo = this.getModelo(json);
                var linha = this.getLinha(modelo);
                resultado.Add(linha);
            }

            return resultado.ToArray();
        }

        internal void salvar(ModeloBase modelo)
        {
            if (modelo.id == default)
            {
                var novoId = Guid.NewGuid().ToString();
                modelo.id = novoId;
            }

            var json = this.getJson(modelo);
            var tabela = this.getTabela();
            var diretorio = Path.Combine("data", tabela);

            if (!Directory.Exists(diretorio))
            {
                Directory.CreateDirectory(diretorio);
            }

            var arquivo = Path.Combine(diretorio, modelo.id);

            if (File.Exists(arquivo))
            {
                File.Delete(arquivo);
            }

            File.WriteAllText(arquivo, json);
        }

        protected abstract string getJson(ModeloBase modelo);

        protected abstract string getLinha(ModeloBase modelo);

        protected abstract ModeloBase getModelo(string json);

        protected abstract string getTabela();
    }
}