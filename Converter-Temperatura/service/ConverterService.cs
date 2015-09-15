using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Converter_Temperatura.service
{
    public class ConverterService
    {
        public static double GetIndex(double celsius) 
        {
            return (celsius * 1.8) + 32;
        }
    }
}