using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    public class ProxyImage : Image
    {
        RealImage realImage;

        string _fileName;
        
        public ProxyImage(string fileName)
        {
            _fileName = fileName;
        }
        public void Display()
        {
            if (realImage==null)
            {
                realImage = new RealImage(_fileName);
            }
            realImage.Display();
        }
    }
}
