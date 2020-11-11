using System;
using System.Diagnostics.Eventing.Reader;

namespace TransaccionBancaria
{
    class Banco
    {
        private string nombre;
        public delegate void DelegadoValidaUsuario();
        public event DelegadoValidaUsuario ValidaUsuario;

        public delegate void DelegadoOperaciones(int operacion);
        public event DelegadoOperaciones Operacion;

        public void MensajeBanco(string Nombre)
        {
            Console.WriteLine("Bienvenido {0} a la red de tu banco", Nombre);
            nombre = Nombre;
        }

        public void DisparaValida()
        {
            if(nombre != "Armando")
            {
                Console.WriteLine("El usuario no está en el sistema");
                ValidaUsuario();
            }
            else
            {
                Console.WriteLine("Proceder a las siguientes operaciones: \n 1)Consultando estado \n2)Retirar");
                int operacion = int.Parse(Console.ReadLine());
                Operacion(operacion);
            }

        }

    }
}
