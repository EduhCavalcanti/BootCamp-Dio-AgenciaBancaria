using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaBancaria.Dominio.Interface
{
    public interface IRepositorio<T>
    {
        //Listar 
        List<T> Lista();

        //Retorna T por id
        T retonarPorId(int id);

        //Adiciona T
        void Criar(T obj);

        //Exlcuir T
        void Excluir(int id);

        //Próximo Id
        int ProximoId();

    }
}
