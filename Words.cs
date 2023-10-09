using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoPalabrasWithList
{
    public class Words : IWordManager
    {
        private  List<Word> availableWords = new List<Word>();
        private int limit;
        private int level;
        private int counter;

        public int Limit { get => limit; set => limit = value; }

        public Words(int limit)
        {
            this.limit = limit;
            counter = 1;

        }


        public Word CreateWord()
        {
            Console.WriteLine("Introduce la palabra que quieres añadir.");
            string txt = Console.ReadLine();
            Word w = new Word(counter, txt);
            counter++;

            return w;

        }
        public void AddWordToAvailable(Word w)
        {
            if (availableWords.Count == Limit)
            {
                Console.WriteLine("No se pueden añadir más palabras.");

            }
            else
            {
                if (w != null )
                {
                    availableWords.Add(w);
                }


            }


        }
        public void ListWords()
        {
            if (availableWords.Count != 0)
            {
                Console.WriteLine("Estas son las palabras disponibles.");

                foreach (Word w in availableWords)
                {
                    if (w != null)
                    {
                        Console.WriteLine("Id:" + w.Id + ", palabra: " + w.Chars + ".");

                    }
                }
                
            }            
            else
            {
                Console.WriteLine("No hay palabras que mostrar.");
            }
        }
        public void RemoveWord(int id)
        {

            if (availableWords.Count != 0)
            {

                int place = 0;
                bool found = false;

                while (place < availableWords.Count && found == false)
                {
                    if (id == availableWords[place].Id)
                    {
                        found = true;
                    }

                    place++;
                }

                if (!found)
                {
                    Console.WriteLine("Esa palabra ya esta borrada");
                }
                else
                {
                    availableWords.RemoveAt(place - 1);
                }


            }
            else
            {
                Console.WriteLine("No hay ninguna palabra que borrar.");
            }

        }
        public void EmptyWords()
        {
            if (availableWords.Count == 0)
            {
                Console.WriteLine("No hay ninguna palabra que eliminar");


            }
            else
            {
                availableWords.Clear();
            }
        }
        public void GetRandomWord()
        {
            Random random = new Random();

            int rndm = random.Next(availableWords.Count);
            for (int i = 0; i < availableWords.Count; i++)
            {
                if (rndm == i)
                {
                    Console.WriteLine(availableWords[i].Chars);
                }
            }
        }
        public void SafeToFile()
        {
            string path = @"C:\Users\cehernando\Desktop\listaDePalabras.txt";

            if (File.Exists(path))
            {
                File.Delete(path);
            }
            
            using (StreamWriter sw = File.CreateText(path))
            {
                foreach (Word w in availableWords)
                    sw.WriteLine(w.Id + " " + w.Chars);

            }

            


        }
        public void ReadFromFile()
        {
            string path = @"C:\Users\cehernando\Desktop\listaDePalabras.txt";

            if (!File.Exists(path))
            {
                Console.WriteLine("El archivo no existe.");
                return;
            }

            using (StreamReader sr = File.OpenText(path))
            {

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] parts = line.Split(' ');


                    if (parts.Length == 2)
                    {
                        Word w = new Word(Convert.ToInt16(parts[0]), parts[1]);
                        availableWords.Add(w);
                    }

                }
            }


        }



    }
}
