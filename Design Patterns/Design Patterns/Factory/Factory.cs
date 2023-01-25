using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Factory
{
    // se encarga de generar componentes, cada vez que necesitemos un componente de algun tipo se lo tendremos que pedir a la fabrica y se encargara de crearlo

    public class ProgramFactory
    {
        Factory factory = new Factory();
        public void Main() 
        {
            
            IConexion c1 = factory.GetConexion("conexion1"); // la clase Factory ahora se encarga de devolvernos una conexion segun el parametro (tipo de conexion)que usemos.
            c1.Conectar();
            IConexion c2 = factory.GetConexion("conexion2");
            c2.Conectar();
            IConexion c3 = factory.GetConexion("conexion3");
            c3.Conectar();

            Console.ReadKey();
        }
    }
    class Factory // con la interfaz Iconexion ya no es necesiro instancias una por una las clases Conexion1-2-3 ahora simplemente nos la devuelve la clase Factory
    {
        public IConexion GetConexion(string typeConexion) 
        {
            if (typeConexion == null) return null;

            if (typeConexion == "conexion1") return new Conexion1();
            else if (typeConexion == "conexion2") return new Conexion2();
            else if (typeConexion == "conexion3") return new Conexion3();
            else return null;
        }

    }

     class Conexion1 : IConexion
    {
        public void Conectar()
        {
            Console.WriteLine("Conectar conexion1");
        }

        public void Desconectar()
        {
            Console.WriteLine("Desconectar conexion1");
        }
    }
     class Conexion2 : IConexion
    {
        public void Conectar()
        {
            Console.WriteLine("Conectar conexion2");
        }

        public void Desconectar()
        {
            Console.WriteLine("Desconectar conexion2");
        }
    }
     class Conexion3 : IConexion
    {
        public void Conectar()
        {
            Console.WriteLine("Conectar conexion3");
        }

        public void Desconectar()
        {
            Console.WriteLine("Desconectar conexion3");
        }
    }

     interface IConexion 
    {
        void Conectar();
        void Desconectar();
    }
}
