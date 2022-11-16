using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lecture_13_FIlters_ListVIew
{
    public partial class Form1 : Form
    {
        string[] names =
        {
            "Zack",
            "Wong",
            "Kris",
            "Sam",
            "Hannah"
        };

        List<Car> cars = new List<Car>();
        public Form1()
        {
            InitializeComponent();
            Preload();

        }


        // A linear search that returns true or false if the name is on the list

        public bool HasName(string name)
        {

            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == name)
                {
                    return true;
                }

            }
            return false;
        }



        public int NameAtIndex(string name)
        {

            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == name)
                {
                    return i;
                }

            }
            return -1;
        }

        public Car FindCar(string make)
        {
            // Loops through list of cars
            for (int i = 0; i < cars.Count; i++)
            {
                // Loops through and compares string make to car make
                if (cars[i].Make == make) 
                {
                    // If cound returns the car
                    return cars[i];
                }

            }
            // if car not found, return null
            return null;
        }

 

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool hasSpoiler = ckSpoiler.Checked;
            bool hasSunroof = ckSunRoof.Checked;
            List<Car> listOfCars = FindCarsWithFeatures(hasSunroof, hasSpoiler);

            DisplayCars(listOfCars);
            
        } // btnSearch_Click

        public void SearchBetweenRange()
        {
            string before = txtBefore.Text;
            int yearBefore = int.Parse(before);

            string after = tbSearch.Text;
            int yearAfter = int.Parse(after);

            List<Car> foundCars = FindCarsBetween(yearBefore, yearAfter);

            DisplayCars(foundCars);
        }




        public List<Car> FindCars(string make)
        {
            List<Car> temp = new List<Car>();

            // Loops through list of cars
            for (int i = 0; i < cars.Count; i++)
            {
                // Loops through and compares string make to car make
                if (cars[i].Make == make)
                {
                    // If cound returns the car
                    temp.Add(cars[i]);
                }

            }
            // if car not found, return null
            return temp;
        }

        public List<Car> FindCarsBefore(int year)
        {
            List<Car> temp = new List<Car>();

            foreach (Car car in cars)
            {
                if(car.Year <= year)
                {
                    temp.Add(car);
                }
            }

            return temp;
        }

        public List<Car> FindCarsBetween(int after, int before)
        {
            List<Car> temp = new List<Car>();

            foreach (Car car in cars)
            {
                if (car.Year >= after && car.Year <= before)
                {
                    temp.Add(car);
                }
            }

            return temp;
        }

        public List<Car> FindCarsWithFeatures(bool sunRoof, bool spoiler)
        {
            List<Car> temp = new List<Car>();

            foreach (Car car in cars)
            {

                
            }

            return temp;
        }

        public void DisplayCars(List<Car> cars)
        {
            // Clears the rich text box
            rtbDisplay.Text = "";

            foreach (Car car in cars)
            {
                rtbDisplay.Text += $"{car.Make} {car.Model} {car.Year} - Spoiler: {car.HasSpoiler} - Sunroof: {car.HasSunroof}\n";
            }
        }




        public void Preload()
        {
            cars.Add(new Car("Hyundai", "Sonata", 1983));

            cars.Add(new Car("Ford", "Escort", 2001));
            cars.Add(new Car("Ford", "Escort", 1997));
            cars.Add(new Car("Honda", "Civic", 2001));

            

            cars.Add(new Car("Hyundai", "Sonata", 2014));

            cars.Add(new Car("Honda", "Civic", 2017));
            cars.Add(new Car("Hyundai", "Sonata", 1999));
            cars.Add(new Car("Ford", "Escort", 2014));

            cars.Add(new Car("Hyundai", "Sonata", 2016));
            cars.Add(new Car("Honda", "Civic", 1995));

            cars.Add(new Car("Hyundai", "Sonata", 2014));
            cars.Add(new Car("Ford", "Escort", 2005));
            cars.Add(new Car("Honda", "Civic", 2004));

            cars[5].HasSpoiler = true;
            cars[1].HasSpoiler = true; 
            cars[9].HasSpoiler = true;

            cars[5].HasSunroof = true;

            cars[11].HasSunroof = true;
            cars[2].HasSunroof = true;

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DisplayCars(cars);
        }
    }
}
