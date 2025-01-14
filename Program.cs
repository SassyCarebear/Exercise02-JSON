
using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using System.Collections.Generic; // List<T>, HashSet<T> 
using System.IO; // FileStream
using static System.Console;
using System.Threading.Tasks;
using static System.Environment;
using static System.IO.Path;
//using Exercise02_JSON;
using static Shape;
//using Rectangle = Rectangle;

using Newtonsoft.Json;
using NuJson = System.Text.Json.JsonSerializer;

    var listOfShapes = new List<Shape>
            {
              new Circle { Colour = "Red", Radius = 2.5 },
              new Rectangle { Colour = "Blue", Height = 20.0, Width = 10.0 },
              new Circle { Colour = "Green", Radius = 8.0 },
              new Circle { Colour = "Purple", Radius = 12.3 },
              new Rectangle { Colour = "Blue", Height = 45.0, Width = 18.0 }
            };

    // create an object that will format as JSON 
    var jss = new Newtonsoft.Json.JsonSerializer();
    string jsonPath = Combine(CurrentDirectory, "shapes.json");
    using (StreamWriter jsonStream = File.CreateText(jsonPath))
    {

        // serialize the object graph into a string 
        jss.Serialize(jsonStream, listOfShapes);
    }
    WriteLine("Serialized JSON:");
    // Display the serialized object graph 
    WriteLine(File.ReadAllText(jsonPath));


    WriteLine();
    WriteLine("Deserialized JSON:");

    var allText = File.ReadAllText(jsonPath);
    using (FileStream jsonLoad = File.Open(jsonPath, FileMode.Open))
    {
    List<Shape> deserializedJSON = JsonConvert.DeserializeObject<List<Shape>>(allText, new JsonSerializerSettings
    {
        TypeNameHandling = TypeNameHandling.Auto,
        NullValueHandling = NullValueHandling.Ignore,
    }); 

        foreach (var item in deserializedJSON)
        {
            WriteLine("{0} is {1}."
                      , item.GetType().Name, item.Colour);
        }
    };

