using DessignPatternsHomework.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DessignPatternsHomework.Models
{
    public class ImageProxy : IPicture
    {
        public string URL { get; set; }
        public Image RealImage { get; set; }

        public ImageProxy()
        {

        }

        public ImageProxy(string url)
        {
            URL = url;
        }

        public Image LoadImage()
        {
            if (RealImage == null)
                RealImage = new Image(URL);

            return RealImage;
        }

        public Dimension Dim()
        {
            return RealImage != null ? RealImage.Dim() : null;
        }

        public string Url()
        {
            return URL;
        }

        public ImageContent Content()
        {
            return RealImage != null ? RealImage.Content() : null;
        }
    }
}
