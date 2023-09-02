using System;
using System.Collections;
using System.Globalization;
using System.Linq.Expressions;
using System.Reflection;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace CSharpSandbox
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Test t = new Test();
            Console.WriteLine(t.RunTest("test"));

        /*  Backtracking b = new Backtracking();
            b.CombinationSum();
            Recursion r = new Recursion();

            var count = r.SumUpNumbers2(12345);

            Console.WriteLine(count);

            var l = new List<int> { 1, 2, 3, 4, 5 };

            var count2 = r.Sum(l);

            Console.WriteLine(count2); 
            string text = "    Hello, world!";

            Regex regex = new Regex(@"\s+(?=\S)");
            MatchCollection matches = regex.Matches(text);

            foreach (Match match in matches)
            {
               Console.WriteLine(match.Value);
            }
        */

        }

    }

    



    class EntityProcessor<T>
    {
        // P. Ackerman's code goes here...

        public bool Compare(string n1, string n2)
        {
            return n1 == n2;
        }

    }

    public interface ICompareNames<T>
    {
        bool Compare(T s1, T s2);
    }

    public class Person
    {
        public Person(string fname, string lname)
        {
            FirstName = fname;
            LastName = lname;
        }

        public string FullName => FirstName + " " + LastName;
        private string FirstName { get; set; }
        private string LastName { get; set; }



    }

    public class Dog
    {
        public string Name { get; set; }
        public string Breed { get; set; }
    }

    [System.AttributeUsage(System.AttributeTargets.Class | System.AttributeTargets.Struct)]
    public class MattAttribute : System.Attribute
    {
        string Name;
        public double Version;

        public MattAttribute(string name)
        {
            Name = name;

            // Default value.
            Version = 1.0;
        }

        public string GetName() => Name;
    }

    class PropsAndTypes
    {
        public void DO()
        {
            Expression<Func<int, int, int>> adder = (x, y) => x + y;

            var a = adder.Compile();

            Console.WriteLine(adder.ToString());


            //Func<string, string> func = new Func<string, string>(_ =>
            //{
            //    return _ + "1";
            //});

            //Console.WriteLine();


            //var nameField = person.GetType();

            //var member = nameField.GetFields();


            //var person = new Person();
            //var personType = typeof(Person);
            //var properties = personType.GetProperties();
            //foreach (var item in properties)
            //{
            //    var property = personType.GetProperty(item.Name);
            //    if (property.PropertyType == typeof(string))
            //    {
            //        property.SetValue(person, "string");
            //    }
            //    else
            //    {
            //        property.SetValue(person, 0);
            //    }
            //}

            //Console.WriteLine(person.Imie + person.Id);




            //property.SetValue(person, "Mateusz");

            //Console.WriteLine(person.Imie);

            //fieldname new value

            //HandleString(nameof(person.Imie), "Mateusz")
        }

        //public static string HandleString(this string str, Type? type, Person p, string o)
        //{
        //    var property = type.GetProperty(o);

        //    return string.Empty;

        //}
    }

    class ExpressionBuilder
    {
        public void build()
        {
            ParameterExpression xParameter = Expression.Parameter(typeof(int), "x");
            ParameterExpression yParameter = Expression.Parameter(typeof(int), "y");
            Expression body = Expression.Add(xParameter, yParameter);
            ParameterExpression[] parameters = new[] { xParameter, yParameter };
            Expression<Func<int, int, int>> adder =
            Expression.Lambda<Func<int, int, int>>(body, parameters);
            Console.WriteLine(adder);
        }
    }

    class CapturedVariablesDemo
    {
        private string instanceField = "instance field";
        public Action<string> CreateAction(string methodParameter)
        {
            string methodLocal = "method local";
            string uncaptured = "uncaptured local";
            Action<string> action = lambdaParameter =>
            {
                string lambdaLocal = "lambda local";
                Console.WriteLine("Instance field: {0}", instanceField);
                Console.WriteLine("Method parameter: {0}", methodParameter);
                Console.WriteLine("Method local: {0}", methodLocal);
                Console.WriteLine("Lambda parameter: {0}", lambdaParameter);
                Console.WriteLine("Lambda local: {0}", lambdaLocal);
            };
            methodLocal = "modified method local";
            return action;
        }
    }

    class CapturedVariablesDemo2
    {
        private int instanceField = 0;
        public Func<string, string> CreateAction(string methodParameter)
        {
            int localcounter = 0;
            Func<string, string> action = lambdaParameter =>
            {
                return methodParameter + " " + lambdaParameter + " " + localcounter++ + " " + instanceField;

            };
            return action;
        }
    }

    public interface IPrintNameAndId
    {
        void PrintNameAndId();
    }

    //public class Person
    //{
    //    public string Imie { get; set; }
    //    public int Id { get; set; }  

    //    public void Switch(Person p)
    //    {
    //        Imie = p.Imie;
    //        Id = p.Id;
    //    }
    //}

}