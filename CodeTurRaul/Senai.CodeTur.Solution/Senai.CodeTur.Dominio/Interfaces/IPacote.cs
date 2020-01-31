using Senai.CodeTur.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Senai.CodeTur.Dominio.Interfaces.Repositorios
{
    interface IPacote
    {
        PacoteDominio BuscarPorId(int id);
        List<PacoteDominio> Listar(bool? todos = null);
        PacoteDominio Cadastrar(PacoteDominio pacote);
    }
}
