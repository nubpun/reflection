﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Framework;
namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            var files = Directory.GetFiles(@"E:\work\skb_reflection\solution\lib");
            foreach (var file in files)
            {
                var DLL = Assembly.LoadFile(file);
                var Types = DLL.DefinedTypes;
                foreach (Type type in Types)
                {                    
                    IPlugin plagin = (IPlugin)Activator.CreateInstance(type);
                    Console.WriteLine(plagin.Name);
                }
            }
        }
    }
}
