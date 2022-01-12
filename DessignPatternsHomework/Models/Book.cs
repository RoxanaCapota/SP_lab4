using DessignPatternsHomework.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DessignPatternsHomework.Interfaces;

namespace DessignPatternsHomework
{
    public class Book
    {
        #region Properties
        public string Title { get; set; }
        public List<Author> Authors { get; set; }
        public List<IElement> Elements { get; set; }
        #endregion

        #region Constructors
        public Book()
        {
            Authors = new List<Author>();
            Elements = new List<IElement>();
        }

        public Book(string title)
        {
            Authors = new List<Author>();
            Elements = new List<IElement>();
            Title = title;
        }
        #endregion

        #region Methods
        public void AddAuthor(Author author)
        {
            Authors.Add(author);
        }

        public void AddContent(IElement element)
        {
            Elements.Add(element);
        }


        public void Print() 
        {
            Console.WriteLine($"Book: {Title}\n");
            
            Console.WriteLine("Authors:\n");
            Authors.ForEach(author => author.Print());
            
            Elements.ForEach(element => element.Print());
        }

        #endregion
    }
}
