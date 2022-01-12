using DessignPatternsHomework.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DessignPatternsHomework.Models
{
    public class Paragraph : IElement
    {
        #region Properties
        public string Text { get; set; }
        #endregion

        #region Constructors
        public Paragraph()
        {

        }

        public Paragraph(string text)
        {
            Text = text;
        }
        #endregion

        #region Methods
        public void Print()
        {
            Console.WriteLine($"Paragraph: {Text}");
        }

        public void Add(IElement element)
        {
            throw new NotImplementedException();
        }

        public void Remove(IElement element)
        {
            throw new NotImplementedException();
        }

        public IElement Get(int index)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
