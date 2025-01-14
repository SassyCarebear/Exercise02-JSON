using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Exercise02_JSON
//{
   
    public class Shape
        {
    //[JsonConverter(typeof(Shape))]
        public Shape()
        {

        }
            public string Colour { get; set; }
            public double Area { get; set; } 


        }
        public class Circle : Shape
        {
            public Circle()
            {

            }


            public double Radius { get; set; }
        }

        public class Rectangle : Shape
        {
            public Rectangle()
            {

            }

            public double Height { get; set; }
            public double Width { get; set; }

        }
    
//}
