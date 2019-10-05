using System;
using System.Linq;
using Z.EntityFramework.Plus;
using zzzexception.Entities;

namespace zzzexception
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using (var context = new DataContext())
            {
                var ids = new Guid[] {Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid()};


                context.Tests.Where(w => ids.Contains(w.TestId))
                    .Update(x => new Test
                    {
                        Text = "Success"
                    });

                var a = context.Tests.Where(x => ids.Contains(x.TestId)).Future();
                
                var b = context.Tests.Where(x => ids.Contains(x.TestId)).Future();

                var c = b.ToList();
            }
        }
    }
}