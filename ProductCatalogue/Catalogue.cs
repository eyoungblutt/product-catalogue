﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace ProductCatalogue
{
    internal class Catalogue<T> where T : Product
    {
        

        public List<T> list = new List<T>();

       
        public void addProduct(T product)
        {
            list.Add(product);
        }

        public void removeProduct(int index)
        {
            list.RemoveAt(index);

        }

        public void viewCatalogue(IEnumerable<T> list)
        {
            string result = " ";
            foreach (T title in list)
            {

                result = String.Format($"Product title = {title.Title}");

                Console.WriteLine(result);
            }

        }

        public void clearCatalogue()
        {

            list.Clear();
        }

        public override string ToString()
        {

            return $"{list} ";
        }


        public double CalculateTotal(double price)
        {
            double total = 0;
            foreach (T item in list)
            {
                total += price;
                return total;
            }
            return 0;
        }


    }

  
    
}
