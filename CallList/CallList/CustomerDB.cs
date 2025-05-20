using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CallList
{
    public static class CustomerDB
    {
        private const string Path = @"..\..\..\Customers.txt";
        private const string Delimiter = ";";
        
        

        public static void SaveLists(List<CallList> list)
        {
            string jsonString = JsonSerializer.Serialize(list);
            File.Delete(Path);
            FileStream fileStream = new FileStream(Path, FileMode.OpenOrCreate, FileAccess.Write);            
            using StreamWriter textOut = new StreamWriter(fileStream);            
            textOut.WriteLine(jsonString);
        }

        public static List<CallList> LoadLists()
        {
            List<CallList> lists = new();
            using StreamReader textIn = new StreamReader(new FileStream(Path, FileMode.OpenOrCreate, FileAccess.Read));

            while(textIn.Peek() != -1)
            {
                string row = textIn.ReadLine() ?? "";
                if(row != null)
                {
                    lists = JsonSerializer.Deserialize<List<CallList>>(row) ?? new();                    
                }               
            }            
            return lists;
        }
    }
}
