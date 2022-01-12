using DessignPatternsHomework.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DessignPatternsHomework.Models
{
    public class Image : IElement, IPicture
    {
        #region Properties
        public string ImageName { get; set; }
        private string URL { get; set; }
        private Dimension Dimension { get; set; }
        private ImageContent ImageContent { get; set; }
        #endregion

        #region Constructors
        public Image()
        {

        }

        public Image(string url)
        {
            URL = url;
            ImageName = URL;
            Dimension = new Dimension();
            ImageContent = new ImageContent();
        }
        #endregion

        #region Methods
        public void Print() 
        {
            Console.WriteLine($"Image with name: {ImageName}");
            Console.WriteLine($"Image Dimension: {Dimension.Width} X {Dimension.Height}");
            Console.WriteLine($"Image Content: {ImageContent.Content}");
        }

        public string Url()
        {
            return URL;
        }

        public Dimension Dim()
        {
            return Dimension;
        }

        public ImageContent Content()
        {
            return ImageContent;
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
