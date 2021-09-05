using AgenciaBancaria.Dominio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaBancaria.Dominio.Repositorio
{
    public class ClienteRepositorio : IRepositorio<Cliente>
    {
        List<Cliente> listaCliente = new List<Cliente>();

        public List<Cliente> Lista()
        {
            return listaCliente;
        }

        //Criação do cliente
        public void Criar(Cliente obj)
        {
            listaCliente.Add(obj);
        }

        //Excluir cliente
        public void Excluir(int id)
        {
            listaCliente[id].ExcluirCliente();
        }

        public int ProximoId()
        {
            return listaCliente.Count;
        }

        public Cliente retonarPorId(int id)
        {
            return listaCliente[id];
        }

    }
}
