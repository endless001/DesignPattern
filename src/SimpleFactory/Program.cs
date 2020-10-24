﻿using System;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {

            var db = Factory.CreateInstance("SqlServer");
            db.Add();
        }
    }
}
