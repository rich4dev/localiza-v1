using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestProject1.UsuarioTest;

namespace TestProject1
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCrear()
        {
            UsuarioSVCClient proxy = new UsuarioSVCClient();

            string nombre = "Alessandra";
            string correo = "hola@gmail.com";
            string password = "zsdasd";

            Usuario result = proxy.CrearUsuario(nombre,correo,password);

            string mensaje = "Cliente " + result.Nombre + " creado";

            Assert.AreEqual("Cliente Alessandra creado", mensaje);
        }

        
    }
}
