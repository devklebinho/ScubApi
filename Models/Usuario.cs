using System;

namespace ScubApi.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        public DateTime DataCadastro { get; set; }

        public string NomeCompleto { get; set; }

        public string Telefone { get; set; }

        public string CPF { get; set; }

        public string? NomeResponsavel { get; set; }

        public string? NomeEscola { get; set; }

        public DateTime DataNascimento { get; set; }

        public string Rua { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }
    }
}