using System;
using System.IO;

namespace Course
{
    class Program
    {

        private static void LerArquivo(string nomeArquivo)
        {
            using StreamReader arquivo = File.OpenText(nomeArquivo);
            string linha;
            int i = 1;
            while ((linha = arquivo.ReadLine()) != null)
            {
               // Console.WriteLine(i);
                Console.WriteLine(i +" - " + linha);
                i++;
            }
        }

        static void Main(string[] args)
        {

            LerArquivo(@"C:\arquivos\arq1.txt");

        }
    }
}
