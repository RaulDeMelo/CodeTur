using System;
using System.Collections.Generic;
using System.Text;
using Senai.CodeTur.Dominio.Entidades;

namespace Senai.CodeTur.Dominio.Interfaces.Repositorios
{
    class PacoteRepositorio : IPacote
    {
        public PacoteDominio BuscarPorId(int id)
        {
            using(CodeTurContext ctx = new CodeTurContext())
            {
                return ctx.Pacotes.Find(id);
            }
        }

        public PacoteDominio Cadastrar(PacoteDominio pacote)
        {
            throw new NotImplementedException();
        }

        public List<PacoteDominio> Listar(bool? todos = null)
        {
            throw new NotImplementedException();
        }
    }
}
