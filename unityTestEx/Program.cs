using System;
using unityTestEx.Src.Ex1;
using unityTestEx.Src.Ex2;

namespace unityTestEx
{
    class Program
    {
        static bool Run = true;
        static RunFizzBuzz FizzBuzz = new RunFizzBuzz();


        static void Main(string[] args)
        {
            while(Run)
            {
                int UserInput = 0;

                Console.WriteLine("\n1) FizzBuzz\n2) Quebrar em colunas\n3\n\n0) Sair");
                if(int.TryParse(Console.ReadLine(), out UserInput))
                    SelectExercise(UserInput);
                 else
                    Console.WriteLine("Insira uma opção válida");
            }
        }

        static void SelectExercise(int UserInput)
        {
            switch(UserInput)
            {
                case 1:
                    for(int i = 0; i < 101; i++)
                        Console.WriteLine(FizzBuzz.ReturnGameResultAccordingToNumber(i));
                break;
                case 2:
                    BreakPhraseIntoLinesAccordingToColumnLimit BreakSentence = new BreakPhraseIntoLinesAccordingToColumnLimit("Um pequeno jabuti xereta viu dez cegonhas felizes.", 20);

                    Console.WriteLine(BreakSentence.GetBrokePhrase());
                break;
                case 3:
                break;
                case 0:
                    Run = false;
                break;
                default:
                    Console.WriteLine("Insira uma opção válida");
                break;
            }
        }
    }
}
