using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoPalabrasWithList
{
    public class Word
    {
        private int id;
        private string chars;
        
        

        
        public Word(int counter, string word) // no hay ningun constructor de palabra asi que para probar uso este polimorfismo
        {
            this.id = counter;
            this.chars = word;

        }

        public int Id { get => id; set => id = value; }
        public string Chars { get => chars; set => chars = value; }

    }


}
