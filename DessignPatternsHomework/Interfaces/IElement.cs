using System;
using System.Collections.Generic;
using System.Text;

namespace DessignPatternsHomework.Interfaces
{
    public interface IElement
    {
        void Print();
        void Add(IElement element);
        void Remove(IElement element);
        IElement Get(int index);

    }
}
