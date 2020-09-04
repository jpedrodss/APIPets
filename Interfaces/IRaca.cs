using APIPets.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIPets.Interfaces
{
    interface IRaca
    {
        List<Raca> ListarTodos();
        Raca Cadastrar(Raca r);
        Raca BuscarID(int id);
        Raca Alterar(int id, Raca r);
        void Excluir(int id);
    }
}
