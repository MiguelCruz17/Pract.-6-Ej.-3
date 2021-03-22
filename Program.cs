using System;

namespace Pract._6_Ej._3
{
    #region Detalles del Programa
    
    /*3.    Crear tres clases ClaseA, ClaseB, ClaseC que ClaseB herede de ClaseA y ClaseC herede de ClaseB. Definir un constructor a 
    cada clase que muestre un mensaje. Luego definir un objeto de la clase ClaseC. */

    #endregion
    public class A
    {
        public A()
        {
            Console.WriteLine("Constructor Clase A");
        }
    }

    public class B : A
    {
        public B()
        {
            Console.WriteLine("Constructor Clase B");
        }
    }

    public class C : B
    {
        public C()
        {
            Console.WriteLine("Constructor Clase C");
        }
    }

    class P
    {
        static void Main(string[] args)
        {
            C C1 = new C();

        }
    }
}

