using DessignPatternsHomework.Interfaces;
using DessignPatternsHomework.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DessignPatternsHomework
{
    public class ElementFactory
    {
        public static IElement GetElement(string elementType)
        {
            IElement element = null;

            switch (elementType)
            {
                case "Image": 
                    element = new Image();
                    break;
                case "Paragraph":
                    element = new Paragraph();
                    break;
                case "Table":
                    element = new Table();
                    break;
            }

            return element;
        }
    }
}
