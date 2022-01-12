using DessignPatternsHomework.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DessignPatternsHomework.Models
{
    public class SubChapter
    {
        #region Properties
        public string Name { get; set; }
        public List<IElement> Elements { get; set; }
        #endregion

        #region Constructors
        public SubChapter()
        {
            Elements = new List<IElement>();
        }

        public SubChapter(string name)
        {
            Elements = new List<IElement>();
            Name = name;
        }
        #endregion

        #region Methods
        public void CreateNewElement(IElement element)
        {
            Elements.Add(element);
        }
        public void Print() 
        {
            Console.WriteLine($"Subchapter: {Name}");

            var paragraphs = Elements.Where(element => element is Paragraph).ToList();

            paragraphs.ForEach(paragraph => paragraph.Print());

            var otherElements = Elements.Where(element => !(element is Paragraph)).ToList();

            otherElements.ForEach(element => element.Print());
        }
        #endregion
    }
}
