using AgenciaBancaria.Dominio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaBancaria.Dominio.Repositorio
{
    public class PoupancaRepositorio : IRepositorio<ContaPoupanca>
    {
        List<ContaPoupanca> listaPoupança = new List<ContaPoupanca>();

        public void Criar(ContaPoupanca obj)
        {
            listaPoupança.Add(obj);
        }

        public void Excluir(int id)
        {
            
        }

        public List<ContaPoupanca> Lista()
        {
            return listaPoupança;
        }

        public int ProximoId()
        {
            return listaPoupança.Count;
        }

        public ContaPoupanca retonarPorId(int id)
        {
            return listaPoupança[id];
        }
    }
}
