using DessignPatternsHomework.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DessignPatternsHomework.Models
{
    public class Section : IElement
    {
        #region Properties
        public string Title { get; set; }
        public List<IElement> Elements { get; set; }
        #endregion

        #region Constructors
        public Section()
        {
            Elements = new List<IElement>();
        }
        public Section(string title)
        {
            Title = title;
            Elements = new List<IElement>();
        }
        #endregion

        #region Methods
        public void Print()
        {
            Console.WriteLine(Title);

            Elements.ForEach(element => element.Print());
        }

        public void Add(IElement element)
        {
            Elements.Add(element);
        }

        public void Remove(IElement element)
        {
            Elements.Remove(element);
        }

        public IElement Get(int index)
        {
            return Elements.ElementAt(index);
        }
        #endregion
    }
}
