using System;

namespace TransaccionBancaria
{
    class Program
    {
        private delegate void MensajeDelegado(string dato);
        public static void MensajeErrorValida()
        {
            Console.WriteLine("Es posible que ingresaste un nombre incorrecto");
        }

        public static void MensajeOperacion(int opcion)
        {
            switch(opcion)
            {
                case 1:
                    Console.WriteLine("Por el momento no puedo realizar esta operación");
                    break;
                case 2:
                    Console.WriteLine("1)200\n 2)\n500 \n 3) 1000  ");
                    break;

            }
                
        }

        static void Main()
        {
            Banco miBanco = new Banco();
            miBanco.ValidaUsuario += MensajeErrorValida;
            miBanco.Operacion += MensajeOperacion;
            MensajeDelegado miDelegado = new MensajeDelegado(miBanco.MensajeBanco);
            Console.WriteLine(" Escribe tu  nombre de usuario ");
            string nombre = Console.ReadLine();

            miDelegado(nombre);
            Random funcionaAleatorio = new Random();
            int funciona = funcionaAleatorio.Next(2);


           if(funciona == 1  )
            {
                
                miBanco.DisparaValida();
            }else
            {
                miBanco.Operacion -= MensajeOperacion;
                try
                {
                    miBanco.DisparaValida();
                }
                catch(NullReferenceException error)
                {
                    Console.WriteLine("Por el momento no cuento con efectivo");
                }                    

            }
            

            miDelegado = new MensajeDelegado(SPEI.MensajeSPEI);
            miDelegado(DateTime.Now.ToString("hh:mm"));




        }
    }
}
