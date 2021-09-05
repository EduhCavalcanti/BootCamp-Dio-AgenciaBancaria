using AgenciaBancaria.Dominio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaBancaria.Dominio.Repositorio
{
    public class CorrenteRepositorio : IRepositorio<ContaCorrente>
    {
        List<ContaCorrente> listaCorrrente = new List<ContaCorrente>();
        public void Criar(ContaCorrente obj)
        {
            listaCorrrente.Add(obj);
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public List<ContaCorrente> Lista()
        {
            return listaCorrrente;
        }

        public int ProximoId()
        {
            return listaCorrrente.Count();
        }

        public ContaCorrente retonarPorId(int id)
        {
            return listaCorrrente[id];
        }
    }
}
