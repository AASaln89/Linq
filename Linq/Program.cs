using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        { 
            List<Comp> comps = new List<Comp>()
            {
                new Comp () { Id=1, Brand="IBM", CPUbrand="AMD", MHzCPU=2000, RAM=8, HDD=256, RAM_GPU=2, Price=500, Quantity=5 },
                new Comp () { Id=2, Brand="MSI", CPUbrand="Intel", MHzCPU=2000, RAM=8, HDD=512, RAM_GPU=4, Price=600, Quantity=3 },
                new Comp () { Id=3, Brand="IBM", CPUbrand="Intel", MHzCPU=3000, RAM=8, HDD=512, RAM_GPU=4, Price=650, Quantity=4 },
                new Comp () { Id=4, Brand="Acer", CPUbrand="AMD", MHzCPU=3200, RAM=16, HDD=256, RAM_GPU=4, Price=620, Quantity=2 },
                new Comp () { Id=5, Brand="IBM", CPUbrand="AMD", MHzCPU=3000, RAM=16, HDD=1024, RAM_GPU=6, Price=590, Quantity=3 },
                new Comp () { Id=6, Brand="MSI", CPUbrand="Intel", MHzCPU=3500, RAM=32, HDD=1024, RAM_GPU=4, Price=790, Quantity=1 }
            };
            //Бренд ЦПУ
            Console.WriteLine("Введите название процессора");
            string CPUBrand = Console.ReadLine();
            List<Comp> comps1 = comps.Where(b => b.CPUbrand == CPUBrand).ToList();
            Comp.Print(comps1);
            //Объем ОЗУ 
            Console.WriteLine("Введите объем ОЗУ");
            int ram = Convert.ToInt32(Console.ReadLine());
            List<Comp> comps2 = comps.Where(r => r.RAM >= ram).ToList();
            Comp.Print(comps2);
            //Сортировка цена
            Console.WriteLine("Сортировка по цене");
            List<Comp> comps3 = comps.OrderBy(p => p.Price).ToList();
            Comp.Print(comps3);
            //Группировка ЦПУ
            //Comp.GroupCPUbrand(comps);
            Console.WriteLine("Группировка по бренду ЦПУ");
            IEnumerable<IGrouping<string, Comp>> comps4 = comps.GroupBy(x => x.CPUbrand);
            foreach (IGrouping<string, Comp> group in comps4)
            {
                Console.WriteLine(group.Key);
                foreach (Comp groupCPU in group)
                {
                    Console.WriteLine($" {groupCPU.Id} {groupCPU.Brand} {groupCPU.CPUbrand} {groupCPU.MHzCPU} {groupCPU.RAM} {groupCPU.HDD} {groupCPU.RAM_GPU} {groupCPU.Price} {groupCPU.Quantity}");
                }
            }
            Console.WriteLine("Самый дорогой");
            Comp comp = comps.OrderByDescending(x => x.Price).FirstOrDefault();
            Console.WriteLine($" {comp.Id} {comp.Brand} {comp.CPUbrand} {comp.MHzCPU} {comp.RAM} {comp.HDD} {comp.RAM_GPU} {comp.Price} {comp.Quantity}");
            Console.WriteLine("Самый дешевый");
            Comp comp1 = comps.OrderBy(x => x.Price).FirstOrDefault();
            Console.WriteLine($" {comp1.Id} {comp1.Brand} {comp1.CPUbrand} {comp1.MHzCPU} {comp1.RAM} {comp1.HDD} {comp1.RAM_GPU} {comp1.Price} {comp1.Quantity}");
            Console.WriteLine("Наличие не менее 30 штук");
            Console.WriteLine(comps.Any(x => x.Quantity >= 30));
            Console.WriteLine("Наличие не более 2 штук");
            Console.WriteLine(comps.Any(x => x.Quantity <= 2));
            Console.WriteLine("Нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
