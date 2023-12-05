using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    internal class MenuSection
    {
      
        public string sectionName { get; set; }

        public string sectionTitle { get; set; }
        public Action action { get; set; }
        public int index {  get; set; }
        public int price {  get; set; } 

        public static List<int> indexCount = new List<int>();
        public static void Index(int index) 
        
        { 
            indexCount.Add(index);
            
           // return index; 
        
        }
    }
}

