using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmstrongSayıları {
    internal class Program {
        static void Main(string[] args) {
            for(int i = 0; i < 1000000; i++) {
                string str = Convert.ToString(i);
                int length = str.Length;
                char[] arr = str.ToCharArray();
                List<int> list = new List<int>();
                foreach (char c in arr) {
                    list.Add
                        ((int)Math.Pow(Convert.ToInt32(c.ToString()), length));
                }
                
                 
                if (list.Sum() == Convert.ToInt32(str)) {
                    Console.WriteLine(list.Sum());
                }
            }

            Console.ReadKey();
        }
    }
}
