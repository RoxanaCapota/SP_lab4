using DessignPatternsHomework.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DessignPatternsHomework.Interfaces
{
    public interface IPicture
    {
        string Url();
        Dimension Dim();

        ImageContent Content();

    }
}
