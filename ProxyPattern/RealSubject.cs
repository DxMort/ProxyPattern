﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class RealSubject : ISubject
    {
        public string Request(string request)
        {
            Console.WriteLine("RS: Обработка запроса " + request);
            return "Ответ от RS для " + request;
        }
    }
}