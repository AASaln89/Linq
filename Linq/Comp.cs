using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Comp
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string CPUbrand { get; set; }
        public int MHzCPU { get; set; }
        public int RAM { get; set; }
        public int HDD { get; set; }
        public int RAM_GPU { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public static void Print(List<Comp> comps)
        {
            foreach (Comp c in comps)
            {
                Console.WriteLine($" {c.Id} {c.Brand} {c.CPUbrand} {c.MHzCPU} {c.RAM} {c.HDD} {c.RAM_GPU} {c.Price} {c.Quantity}");
            }
            Console.WriteLine();
        }
        ////Главный вопрос Можно ли сделать метод для группировки? ниже код
        //в чем ошибка?
        public static void GroupCPUbrand(List<Comp> comps)
        {
            //IEnumerable<IGrouping<string, Comp>> comps1 = comps.GroupBy(x => x.CPUbrand);
            foreach (IGrouping<string, Comp> group in comps)
            {
                Console.WriteLine(group.Key);
                foreach (Comp groupCPU in group)
                {
                    Console.WriteLine($" {groupCPU.Id} {groupCPU.Brand} {groupCPU.CPUbrand} {groupCPU.MHzCPU} {groupCPU.RAM} {groupCPU.HDD} {groupCPU.RAM_GPU} {groupCPU.Price} {groupCPU.Quantity}");
                }
            }
        }
    }
}
