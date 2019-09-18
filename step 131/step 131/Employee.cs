using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step_131
{
    public class Employee<T> 
    {
        public List<T> Things { get; set; }
        
        public void ListThings()
        {
            for (int i = 0; i < Things.Count; i++) {
                Console.WriteLine(Things[i]);
            }
            
        }


        
       
    }
}
