using System;
using System.Collections.Generic;
using System.Text;

namespace Filter
{
    public interface IFilter<T>
    {
        List<T> Filter(List<T> list);
    }
}
