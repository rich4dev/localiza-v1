using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestProject1.UsuarioTest;
using TestProject1.ServiceCliente;

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
            ClienteSVCClient proxy = new ClienteSVCClient();

            string nombre = "Alessandra";
            string paterno = "diaz";
            string materno = "puente";
            string genero = "F";
            string dni = "123458";
            string email = "Alessandra@gmail.com";
            string telefono = "12121212";
            string direccion = "av. aviacion 123";
            string distrito = "san borja";

            bool valida = proxy.validaDni(dni);
            if (valida == true)
            {
                Cliente result = proxy.CrearCliente(nombre, paterno, materno, genero, dni, email, telefono, direccion, distrito);

                string mensaje = "Cliente " + result.nombre + " creado";

                Assert.AreEqual("Cliente Alessandra creado", mensaje);
            }
            else
            {
                string mensaje = proxy.mensajes(1); ;

                Assert.AreEqual("La cantidad de digitos debe ser 8", mensaje);
            }
           
        }
        [TestMethod]
        public void TestValidar()
        {
            ClienteSVCClient proxy = new ClienteSVCClient();

            bool valida = proxy.validaDni("1234568");

            Assert.IsFalse(valida);
        }
        
    }
}
