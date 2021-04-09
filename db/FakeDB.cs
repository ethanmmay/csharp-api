using System.Collections.Generic;
using learnAPIs.Models;

namespace learnAPIs.db
{
    public class FakeDB
    {
        public static List<Dog> Dogs { get; set; } = new List<Dog>();
    }
}