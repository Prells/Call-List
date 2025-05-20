using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallList
{
    public class CallList
    {
        public CallList() 
        {
            
        }
        
        public CallList(string name)
        {
            SetName = name;
            GetList = new List<Customer>(); 
        }

        public string SetName { get; set; } = "";

        public List<Customer>? GetList { get; set; } = null;


    }
}
