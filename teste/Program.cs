using System.Security.Cryptography.X509Certificates;
using System.Xml;
using System.Xml.Linq;

namespace teste
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }

        public static void adicionaVeiculo(veiculo v)
        {

        }
    }

    public class veiculo
    {
        string marca { 
            get { return marca; } 
            set { marca = value; } 
        }
        int ano {
            get { return ano; }
            set { ano = value; }
        }
        string tipoCombustivel
        {
            get { return tipoCombustivel; }
            set { tipoCombustivel = value; }
        }
        string cor 
        {
            get { return cor; }
            set { cor = value; }
        }
        double preco 
        {
            get { return preco; }
            set { preco = value; }
        }
    }
    
}