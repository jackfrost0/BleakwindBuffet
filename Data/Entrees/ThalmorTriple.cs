﻿using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Abstract;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    /*
     * Author: John Solomon
     * Class name: ThalmorTriple.cs
     * Purpose: To track Thalmor Triple burgers: Think you are strong enough to take on the Thalmor? Inlcudes two 1/4lb patties with a 1/2lb patty inbetween with ketchup, mustard, pickle, cheese, tomato, lettuce, mayo, bacon, and an egg.
     */
    public class ThalmorTriple:Entree, INotifyPropertyChanged
    {

        // This BindingSource binds the list to the DataGridView control.
        public event PropertyChangedEventHandler PropertyChanged;
        //specialInstructions

        /// <summary>
        /// The special instuctions for the Thalmor Triple
        /// </summary>
        public override List<String> SpecialInstructions
        {
            get
            {
                List<String> instructions = new List<String>();
                if (!Bun) instructions.Add("Hold bun");
                if (!Ketchup) instructions.Add("Hold ketchup");
                if (!Mustard) instructions.Add("Hold mustard");
                if (!Pickle) instructions.Add("Hold pickle");
                if (!Cheese) instructions.Add("Hold cheese");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Lettuce) instructions.Add("Hold lettuce");
                if (!Mayo) instructions.Add("Hold mayo");
                if (!Bacon) instructions.Add("Hold bacon");
                if (!Egg) instructions.Add("Hold egg");


                return instructions;
            }//get

        }//SpecialInstructions




        // This method is called by the Set accessor of each property.
        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }





        //properties


        /// <summary>
        /// Price of the Thalmor Triple
        /// </summary>
        public override double Price { get; } = 8.32;

        /// <summary>
        /// Calories of the Thalmor Triple
        /// </summary>
        public override uint Calories { get; } = 943;


        /// <summary>
        /// Boolean which indicates if there is a bun on the order
        /// </summary>
        public bool Bun { get { return bun; } set { bun = value; NotifyPropertyChanged("Bun"); } } //bun
        private bool bun = true;


        /// <summary>
        /// Boolean which indicates if there is ketchup on the order
        /// </summary>
        public bool Ketchup { get { return ketchup; } set { ketchup = value; NotifyPropertyChanged("Ketchup"); } }
        private bool ketchup = true;


        /// <summary>
        /// Boolean which indicates if there is mustard on the order
        /// </summary>
        public bool Mustard { get { return mustard; } set { mustard = value; NotifyPropertyChanged("Mustard"); } } //mustard
        private bool mustard = true;


        /// <summary>
        /// Boolean which indicates if there is pickle on the order
        /// </summary>
        public bool Pickle { get { return pickle; } set { pickle = value; NotifyPropertyChanged("Pickle"); } }
        private bool pickle = true;


        /// <summary>
        /// Boolean which indicates if there is cheese on the order
        /// </summary>
        public bool Cheese { get { return cheese; } set { cheese = value; NotifyPropertyChanged("Cheese"); } }
        private bool cheese = true;


        /// <summary>
        /// Boolean which indicates if there is tomato on the order
        /// </summary>
        public bool Tomato { get { return tomato; } set { tomato = value; NotifyPropertyChanged("Tomato"); } }
        private bool tomato = true;


        /// <summary>
        /// Boolean which indicates if there is Lettuce on the order
        /// </summary>
        public bool Lettuce { get { return lettuce; } set { lettuce = value; NotifyPropertyChanged("Lettuce"); } }
        private bool lettuce = true;


        /// <summary>
        /// Boolean which indicates if there is Mayo on the order
        /// </summary>
        public bool Mayo { get { return mayo; } set { mayo = value; NotifyPropertyChanged("Mayo"); } }
        private bool mayo = true;


        /// <summary>
        /// Boolean which indicates if there is bacon on the order
        /// </summary>
        public bool Bacon { get { return bacon; } set { bacon = value; NotifyPropertyChanged("Bacon"); } } 
        private bool bacon = true;


        /// <summary>
        /// Boolean which indicates if there is egg on the order
        /// </summary>
        public bool Egg { get { return egg; } set { egg = value; NotifyPropertyChanged("Egg"); } } 
        private bool egg = true;





        /// <summary>
        /// This method sets all of the ingredients to default false, then adds ingredients back based on the provided list
        /// </summary>
        /// <param name="vs"></param>
        public override void setIngredients(BindingList<string> vs)
        {
            Bun = false;
            Ketchup = false;
            Mustard = false;
            Pickle = false;
            Cheese = false;
            Tomato = false;
            Lettuce = false;
            Mayo = false;
            Bacon = false;
            Egg = false;



            foreach (string s in vs)
            {

                if (s.Equals("Bun"))
                {
                    Bun = true;
                }
                if (s.Equals("Ketchup"))
                {
                    Ketchup = true;
                }
                if (s.Equals("Mustard"))
                {
                    Mustard = true;
                }
                if (s.Equals("Pickle"))
                {
                    Pickle = true;
                }
                if (s.Equals("Cheese"))
                {
                    Cheese = true;
                }
                if (s.Equals("Tomato"))
                {
                    Tomato = true;
                }
                if (s.Equals("Lettuce"))
                {
                    Lettuce = true;
                }
                if (s.Equals("Mayo"))
                {
                    Mayo = true;
                }
                if (s.Equals("Bacon"))
                {
                    Bacon = true;
                }
                if (s.Equals("Egg"))
                {
                    Egg = true;
                }
            }

        }









        //tostring

        /// <summary>
        /// Overrides toString
        /// </summary>
        /// <returns>returns Thalmor Triple as a string</returns>
        public override string ToString()
        {
            return "Thalmor Triple";
        }





    }
}
