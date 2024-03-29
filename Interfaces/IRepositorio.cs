using System.Collections.Generic;

namespace DIO.Series.Interfaces
{
    public interface IRepositorio<T>
    {
         List<T> Lista();
         T RetornaPorId(int id);
         void Insere(Serie objeto);
         void Exclui(int id);
         void Atualiza(int id, Serie objeto);
         int ProximoId();
    }
}