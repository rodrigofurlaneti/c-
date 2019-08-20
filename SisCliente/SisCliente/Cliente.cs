using System;
using System.Collections.Generic;
using System.Text;


namespace SisCliente
{
        public class Cliente
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public DateTime DtNascimento { get; set; }

            public Cliente(int id, string nome, DateTime dtNascimento)
            {
                Id = id;
                Nome = nome;
                DtNascimento = dtNascimento;
            }
        }
}
