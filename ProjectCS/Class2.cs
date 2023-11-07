using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCS
{
    public class Class2
    {

        public static List<Class1> foods = new List<Class1>()
        { 
            new Class1() {Name = "McDonalds", Category = "Food", Price = 15.95M},
            new Class1() {Name = "Starbucks", Category = "Food", Price = 15.95M},
            new Class1() {Name = "Pollo Tropical", Category = "Food", Price = 15.95M},
            new Class1() {Name = "McDonalds", Category = "Food", Price = 15.95M},
            new Class1() {Name = "Groceries Publix", Category = "Food", Price = 15.95M},
            new Class1() {Name = "Groceries Walmart", Category = "Food", Price = 15.95M},
        };
        public static List<Class1> bills = new List<Class1>()
        {
            new Class1() {Name = "Light", Category = "Bills", Price = 60.45M},
            new Class1() {Name = "Internet", Category = "Bills", Price = 55.0M},
            new Class1() {Name = "Phone", Category = "Bills", Price = 85.95M},
            new Class1() {Name = "Heat", Category = "Bills", Price = 15.95M},
            new Class1() {Name = "Water", Category = "Bills", Price = 12.32M},
            new Class1() {Name = "Gas", Category = "Bills", Price = 51.78M},
        };
        public static List<Class1> subs = new List<Class1>()
        {
            new Class1() {Name = "Hulu", Category = "Subscription", Price = 9.50M},
            new Class1() {Name = "Gym", Category = "Subscription", Price = 45.65M},
            new Class1() {Name = "Arcade", Category = "Subscription", Price = 30.00M},
            new Class1() {Name = "Disney+", Category = "Subscription", Price = 14.99M},
            new Class1() {Name = "Netflix", Category = "Subscription", Price = 13.99M},
            new Class1() {Name = "Xbox Live", Category = "Subscription", Price = 9.99M},
        };
        public static List<Class1> outings = new List<Class1>()
        {
            new Class1() {Name = "Dinner Night", Category = "Outings", Price = 68.83M},
            new Class1() {Name = "Camping", Category = "Outings", Price = 27.90M},
            new Class1() {Name = "Theme Park", Category = "Outings", Price = 155.75M},
            new Class1() {Name = "Cinema", Category = "Outings", Price = 15.95M},
            new Class1() {Name = "Musical", Category = "Outings", Price = 55.01M},
            new Class1() {Name = "Museum", Category = "Outings", Price = 5.07M},
        };

    }
}
