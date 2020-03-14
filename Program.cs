using System;

namespace TRABALHO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("exibir nome completo...");
            Console.Beep();
            Console.ReadLine();
            Console.WriteLine("olá usuário:");
            string nome = "Marcos Vinícius ";
            string sobrenome = "Dias Ramos";
            string nomeCompleto = nome + " " + sobrenome;
            Console.WriteLine(nome  + sobrenome);
            Console.Beep();
            Console.ReadLine();
        }
    }
}
