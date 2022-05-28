using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalogue
{
    internal class Movie : Product
    {

        private string _title { get => Title; }
        private string _director { get => Director; }
        private double _runtime { get => Runtime; }
        private string _synposis { get => Synopsis; }

        public string Title;
        public string Director;
        public double Runtime;
        public string Synopsis;


        public Movie(string title, string director, double runtime, string synopsis, double price) : base(price)
        {
            Title = title;
            Director = director;
           Runtime = runtime;
          Synopsis = synopsis;

        }
    }
}

