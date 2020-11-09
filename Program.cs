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

        static void Main()
        {
            Banco miBanco = new Banco();
            miBanco.ValidaUsuario += MensajeErrorValida;
            MensajeDelegado miDelegado = new MensajeDelegado(miBanco.MensajeBanco);

            miDelegado("Carlos");
            miBanco.DisparaValida();

            miDelegado = new MensajeDelegado(SPEI.MensajeSPEI);
            miDelegado(DateTime.Now.ToString("hh:mm"));




        }
    }
}
