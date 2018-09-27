/*
gurmandeep singh
30008833
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }class Bird
    {
 
        string  sex, weight,name, species, bandno;


        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
        public string Sex
        {
            get { return Sex; }
            set { Sex = value; }
        }
        public string Weight
        {
            get { return weight; }
            set { weight = value; }
            
         public string Species
        {
            get { return species; }
            set { species = value; }
        }
        }
        public string Bandno
        {
            get { return bandno; }
            set { bandno = value; }
        }


        public Bird(string _name, string _species, string _sex, string _weight, string _bandno)
        {
            Name = _name
            weight = _weight;
            species = _species;
            sex = _sex;
            bandno = _bandno;
        }
        public string Birddata()
        {
            return "birdname=" + name;
        }
        public string Birdspecies()
        {
            return "species=" + species;
        }
        public string Birdsex()
        {
            return "sex=" + sex;
        }
        public string Birdweight()
        {
            return "birdweight=" + weight;
        }
        public string Birdbandno()
        {
            return "birdbandno=" + bandno;
        }
        class Program
        {
            static void main(string[] args)
            {

            }

            class program
            {
                static void Main(string[] args)
                {

                    Console.WriteLine("bird object and default data loaded");
                    //

                    Console.WriteLine("bird data");

                    //data updated for users
                    Console.WriteLine("name of the bird");
                    string Birdtype = Console.ReadLine();

                    Console.WriteLine("enter name ofspecies");
                    string species = Console.ReadLine();

                    Console.WriteLine("enter  a sex");
                    string sex = Console.ReadLine();

                    Console.WriteLine("enter the weight");
                    string weight = Console.ReadLine();

                    Console.WriteLine("enter a bandno");
                    string bandno = Console.ReadLine();

                    Console.WriteLine("))))))))))))))))))");

                    // show data
                    Bird first = new Bird(species, sex, weight, Birdtype,  bandno);

                    

                    Console.WriteLine(first.Birdspecies());
                    
                    Console.WriteLine(first.Birddata());

                    Console.WriteLine(first.Birdsex());
                    
                    Console.WriteLine(first.Birdbandno());

                    Console.WriteLine(first.Birdweight());

                    

                    Console.WriteLine("rrrrrrrrrrrrrrrrrrrr");

                    Console.ReadLine();


    }
}
