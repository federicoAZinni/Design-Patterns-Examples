using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Factory_Abstract
{
    // es generar una fabrica de fabricas Se genera una class FabricaAbs que contenca los tipos de  fabricas y cada fabrica implemente el factory
    // 

    class Program
    {
        void Main()
        {
            FactoryAbs factory = FabricaProdutor.GetFactory("A");
            IConexionA cxA = factory.getA("A2");
            cxA.Conectar();
        
        }

    }

    static class FabricaProdutor
    {
        public static FactoryAbs GetFactory (string fac)
        {
            if (fac == "A") return new FactoryA();
            else if (fac == "B") return new FactoryB();
            else return null;
        }
    }

    interface FactoryAbs
    {
        IConexionA getA(string typeConexion);
        IConexionB getB(string typeConexion);
    }
    class FactoryA : FactoryAbs 
    {
        public IConexionA getA(string typeConexion) 
        {
            return GetConexion(typeConexion);
        }

        public IConexionB getB(string typeConexion) // En este caso no se aplica el principio de segregacion de interfaces de SOLID
        {
            throw new NotImplementedException();
        }

        public IConexionA GetConexion(string typeConexion)
        {
            if (typeConexion == null) return null;

            if (typeConexion == "A1") return new A1();
            else if (typeConexion == "A2") return new A2();
            else if (typeConexion == "A3") return new A3();
            else return null;
        }

    }

    class FactoryB : FactoryAbs
    {
        public IConexionA getA(string typeConexion) // En este caso no se aplica el principio de segregacion de interfaces de SOLID
        {
            throw new NotImplementedException();
        }

        public IConexionB getB(string typeConexion)
        {
            return GetConexion(typeConexion);
        }

        public IConexionB GetConexion(string typeConexion)
        {
            if (typeConexion == null) return null;

            if (typeConexion == "B1") return new B1();
            else if (typeConexion == "B2") return new B2();
            else if (typeConexion == "B3") return new B3();
            else return null;
        }

    }

    class A1 : IConexionA
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
    class A2 : IConexionA
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
    class A3 : IConexionA
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

    class B1 : IConexionB
    {
        public void Conectar()
        {
            Console.WriteLine("Conectar B1");
        }

        public void Desconectar()
        {
            Console.WriteLine("Desconectar B1");
        }
    }
    class B2 : IConexionB
    {
        public void Conectar()
        {
            Console.WriteLine("Conectar B2");
        }

        public void Desconectar()
        {
            Console.WriteLine("Desconectar B2");
        }
    }
    class B3 : IConexionB
    {
        public void Conectar()
        {
            Console.WriteLine("Conectar B3");
        }

        public void Desconectar()
        {
            Console.WriteLine("Desconectar B3");
        }
    }

    interface IConexionA
    {
        void Conectar();
        void Desconectar();
    }
    interface IConexionB
    {
        void Conectar();
        void Desconectar();
    }
}
