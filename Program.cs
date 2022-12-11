using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Data_Inventory_Management
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine(" ");
            Console.WriteLine("---Welcome To DataManagement Inventory Using JSON---");
            Console.WriteLine(" ");
            DataInventortyManagement management = new DataInventortyManagement();
            management.GetData();

        }
    }
}