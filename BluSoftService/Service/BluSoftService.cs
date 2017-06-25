using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BluSoftService.Repository;

namespace BluSoftService.Service
{
    public class BluSoftService
    {
        private DatabaseConn context = new DatabaseConn();

        public List<Cliente> BuscarCliente(string tipoPesquisa, string valorPesquisa)
        {
            List<Cliente> clientes = null;

            clientes = context.Cliente.Where(s => s.Nome == valorPesquisa).ToList();

            if (clientes != null && clientes.Count > 0)
            {

            }

            return clientes;

        }

        public bool CadastrarCliente(Cliente cliente)
        {

            try
            {
                context.AddToCliente(cliente);
                context.SaveChanges();

                return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }


            

        }

    }
}
