using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//chk for dups in a array
namespace HasDuplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            var dups = new string[5] { "mike","dave","mike", "kim", "dave" };
            HasDuplicates.HasDuplicate(dups);
        }
    }
    public class HasDuplicates
    {
        public static void HasDuplicate(string[] dups)
        {
            List<string> chk = new List<string>();

            for (int i = 0; i < dups.Length; i++)
            {
                if(chk.Contains(dups[i]))
                {
                    Console.WriteLine("Dup {0}", dups[i]);
                }
                else
                {
                    chk.Add(dups[i]);
                }
                //Console.WriteLine("\n{0}",dups[i]);

            }
        }
    }
}
