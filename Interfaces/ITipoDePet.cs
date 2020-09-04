using APIPets.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIPets.Interfaces
{
    interface ITipoDePet
    {
        List<TipoDePet> ListarTodos();
        TipoDePet Cadastrar(TipoDePet t);
        TipoDePet BuscarID(int id);
        TipoDePet Alterar(int id, TipoDePet t);
        void Excluir(int id);
    } 
}
