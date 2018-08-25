using System;
using System.Collections.Generic;

namespace SimpleGridView
{
    public class Prefecture
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<City> Cities { get; set; }
        public DateTime StartDate { get; set; }
    }
}
