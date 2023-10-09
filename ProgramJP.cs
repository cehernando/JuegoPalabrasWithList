using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoPalabrasWithList
{
    internal class ProgramJP
    {
        static void Main(string[] args)
        {
            

            Words words = new Words(40);


            int menuValue;
            do
            {
                Console.WriteLine("1) Añadir palabra");
                Console.WriteLine("2) Ver palabras disponibles");
                Console.WriteLine("3) Eliminar palabra");
                Console.WriteLine("4) Reiniciar la lista de palabras");
                Console.WriteLine("5) Coger palabra aleatoria");
                Console.WriteLine("6) Volcar en archivo");
                Console.WriteLine("7) Cargar archivo");
                Console.WriteLine("0) Salir");
                menuValue = Convert.ToInt16(Console.ReadLine());
                
                switch (menuValue)
                {
                    case 1:
                        Console.Clear();
                        Word w = words.CreateWord();
                        words.AddWordToAvailable(w);
                        Console.WriteLine(" ");
                        break;

                    case 2:
                        words.ListWords();
                        Console.WriteLine(" ");
                        break;

                    case 3:
                        Console.WriteLine("Indica el id de la palabra que quieres eliminar");
                        int wordId = Convert.ToInt16(Console.ReadLine());
                        words.RemoveWord(wordId);
                        Console.WriteLine(" ");
                        break;
                    case 4:
                        words.EmptyWords();
                        Console.Clear();
                        break;
                    case 5:
                        words.GetRandomWord();
                        Console.Clear();
                        break;
                    case 6:
                        words.SafeToFile();
                        Console.WriteLine(" ");
                        break;
                    case 7:
                        words.ReadFromFile();
                        Console.WriteLine(" ");
                        break;

                }

            } while (menuValue != 0);






            


        }
    }
}
