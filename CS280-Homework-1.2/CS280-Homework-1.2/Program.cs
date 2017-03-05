using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS280_Homework_1._2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Pokemon pokemon = new Pokemon();
            pokemon.Height = 2.0f;
            pokemon.Weight = 18.7f;
            pokemon.Category = "Lizard";
            pokemon.Abilities = "Blaze";
            pokemon.Gender = "M";
            pokemon.Number = 4f;
            pokemon.Name = "Charmander";
            Console.WriteLine("Height:{0}, Weight:{1}lbs",
                pokemon.Height, pokemon.Weight);
            Console.WriteLine("Category:{0}, Abilities:{1},Gender:{2}",
                pokemon.Category, pokemon.Abilities, pokemon.Gender);
            Console.WriteLine("Number:{0}, Name:{1}",
                pokemon.Number, pokemon.Name);
        }
    }
}