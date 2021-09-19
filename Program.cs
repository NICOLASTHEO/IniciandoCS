using System;

namespace treino
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é o seu nome?"); //printará a mensagem entre aspas duplas.
            Console.WriteLine("Me diga e vamos ver dia e hora deste momento exato.");
            var name = Console.ReadLine(); //o input será só lido pelo programa
            var currentDate = DateTime.Now; //o programa verificará o dia e a hora do momento.
            Console.WriteLine($"{Environment.NewLine}E aí, {name}, hoje é {currentDate:d} e são {currentDate:t}!"); // o $ permite colocar uma FUNÇÃO no Print. Neste caso Nome (input), a data (date:d) e a hora (time:t)
            Console.Write($"{Environment.NewLine}Aperte qualquer botão para sair..."); //Print automático do programa.
            Console.ReadKey(true); // se a pessoa escrevar (será verdade = true) e o programa fechará.
        }
    }
}
