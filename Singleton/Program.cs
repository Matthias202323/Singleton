using Singleton.Models;
using System;

namespace Singleton
{
    static class Program
    {
        static void Main()
        {
           


            Class1 class1 = new Class1("Toto");
                    Class2 class2 = new Class2("Tutu");
            var context = DatabaseSingleton.Instance();
            context.Database.EnsureDeleted();
            
            context.Database.EnsureCreated();
            context.classes.Add(class1);
            context.classes2.Add(class2);
            context.SaveChanges();

        
            
           
            





        }
    }
}

