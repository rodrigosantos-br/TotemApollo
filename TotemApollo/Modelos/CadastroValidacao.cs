using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotemApollo.Modelos
{
    public class CadastroValidacao
    {
        private string nome;
        private string dataNascimento;
        private string mensagemNome;
        private string mensagemDataNascimento;

        public CadastroValidacao(string nome, string dataNascimento)
        {
            this.nome = nome; 
            this.dataNascimento = dataNascimento; 
            this.ValidarNome();
            this.ValidarDataNascimento();
        }

        private void ValidarNome()
        {
            mensagemNome = "";
            // Verificar se o nome não está vazio
            if (string.IsNullOrWhiteSpace(nome))
            {
                mensagemNome = " Nome não pode ser vazio. ";
                return;
            }

            // Verificar o comprimento do nome
            if (nome.Length < 3 || nome.Length > 20)
            {
                mensagemNome = " Nome deve ter entre 3 e 20 caracteres. ";
                return;
            }

            // Transformar a primeira letra do nome em maiúscula
            nome = char.ToUpper(nome[0]) + nome.Substring(1).ToLower();
        }

        private void ValidarDataNascimento()
        {
            mensagemDataNascimento = "";
            // Verificar se a data de nascimento não está vazia
            if (string.IsNullOrWhiteSpace(dataNascimento))
            {
                mensagemDataNascimento = "Data de nascimento não pode ser vazia.";
                return;
            }

            // Outras verificações de validade da data de nascimento podem ser adicionadas aqui
        }

        public string MensagemNome { get => mensagemNome; }
        public string MensagemDataNascimento { get => mensagemDataNascimento; }
    }
}
