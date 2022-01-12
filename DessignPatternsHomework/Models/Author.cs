using System;
using System.Collections.Generic;
using System.Text;

namespace DessignPatternsHomework
{
    public class Author
    {
        public string Name { get; set; }

        #region Constructors
        public Author()
        {
                
        }

        public Author(string name)
        {
            Name = name;
        }
        #endregion

        public void Print() 
        {
            Console.WriteLine($"Autor: {Name}\n");
        }

    }
}
