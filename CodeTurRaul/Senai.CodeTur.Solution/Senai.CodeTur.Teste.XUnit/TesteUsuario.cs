using System;
using System.Collections.Generic;
using System.Text;

namespace Senai.CodeTur.Teste.XUnit
{
    class TesteUsuario
    {
        private IUsuarioRepositorio repositorioUsuario;

        public TesteUsuario()
        {
            _repositorioUsuario = new UsuarioRepositorio();
        }
        [Fact]
        public void VerificaSeUsuarioEInvalido()
        {
            var validacao = _repositorioUsuario.EfetuarLogin("admin@gmail.com")
            Assert.Null(validacao);
        }

        [Fact]
        public void VerificarseUsuarioEValido()
        {
            
        }
        [Fact]
        public void VerificaSeUsuarioEValidoEInfoCorretas(){


        }
}
