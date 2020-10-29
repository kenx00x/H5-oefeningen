using System;
using System.ComponentModel;
using System.Reflection;

namespace Schaakstuk
{
    class Program
    {
        enum schaakstukken
        {
            [Description("witte koning")]
            wittekoning = 0,
            [Description("zwarte koning")]
            zwartekoning = 1,
            [Description("witte pion")]
            wittepion = 2,
            [Description("zwarte pion")]
            zwartepion = 3,
            [Description("wit paard")]
            witpaard = 4,
            [Description("zwart paard")]
            zwartpaard = 5,
            [Description("witte dame")]
            wittedame = 6,
            [Description("zwarte dame")]
            zwartedame = 7,
            [Description("witte loper")]
            witteloper = 8,
            [Description("zwarte loper")]
            zwarteloper = 9,
            [Description("witte toren")]
            wittetoren = 10,
            [Description("zwarte toren")]
            zwartetoren = 11
        }
        static void Main(string[] args)
        {
            Random willekeurig = new Random();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{((schaakstukken)willekeurig.Next(0, 12)).ToDescription()}");
            }
        }
    }
    internal static class Extensions
    {
        public static string ToDescription(this Enum value)
        {
            FieldInfo field = value.GetType().GetField(value.ToString());
            DescriptionAttribute attribute = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) as DescriptionAttribute;
            return attribute == null ? value.ToString() : attribute.Description;
        }
    }
}
