using System;
using System.Collections.Generic;
using System.Text;

namespace SisCliente
{
    public static class Repositorio
    {
        private static int _id = 0;
        private static List<Cliente> _clientes
            = new List<Cliente>();
        public static List<Cliente> _cliente
            = new List<Cliente>();
        public static void Cadastrar(
            string nome,
            DateTime dtNascimento)
        {
            _id++;
            var c = new Cliente(_id, nome, dtNascimento);
            _clientes.Add(c);
        }
        public static List<Cliente> Listar()
        {
            return _clientes;
        }
        public static List<Cliente> Consultar(int _id)
        {
            foreach (var item in _clientes)
            {
                if (item.Id == _id)
                {
                    var a = new Cliente(item.Id, item.Nome, item.DtNascimento);
                    _cliente.Add(a);
                }
            }
            return _cliente;
        }
        public static string Excluir(int _id)
        {
            foreach (var item in _clientes)
            {
                if (item.Id == _id)
                {
                    _clientes.Remove(item);
                    break;
                }
            }
            string sucesso = "Removido om sucesso!";
            return sucesso;

        }
    }
}
