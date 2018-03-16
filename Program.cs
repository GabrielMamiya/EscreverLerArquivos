using System;
using System.IO;

namespace LerEscreverArquivosTXT
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            using (StreamWriter writer = new StreamWriter(@"/Users/gabrieltamura/Desktop/testeWriter/arquivoDoC#", true))
                {
                writer.WriteLine("Eita escrevendo no C#");
                }

            using (StreamReader writer = new StreamReader(@"/Users/gabrieltamura/Desktop/testeWriter/arquivoDoC#"))
            {
                string s;
                while((s = writer.ReadLine()) != null)
                    Console.WriteLine(s);
            }

        }
    }
}
