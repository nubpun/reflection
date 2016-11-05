using System;
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
                    Type inter = type.GetInterface("IPlugin");
                    if (inter == null)
                    {
                        throw new NotImplementedException("Библиотека не содержит реализации интерфейса плагина.");
                    }
                    
                    ConstructorInfo constructorInfo = type.GetConstructor(new Type[] { });
                    if (constructorInfo == null)
                    {
                        throw new NotImplementedException("Библиотека не содержит конструктора с пустыми параметрами.");
                    }

                    IPlugin plagin = (IPlugin)Activator.CreateInstance(type);
                    Console.WriteLine(plagin.Name);
                }
            }
        }
    }
}
