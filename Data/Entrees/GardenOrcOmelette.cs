﻿using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Abstract;
using System.ComponentModel;


namespace BleakwindBuffet.Data.Entrees
{
    /*
     * Author: John Solomon
     * Class name: GardenOrcOmelette.cs
     * Purpose: To track Garden Orc Omelette: Vegetarian. Two egg omelette packed with a mix of broccoli, mushrooms, and tomatoes. Topped with cheddar cheese.
     */
    public class GardenOrcOmelette: Entree, INotifyPropertyChanged
    {

        // This BindingSource binds the list to the DataGridView control.
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The special instuctions for the Garden Orc Omelette
        /// </summary>
        public override List<String> SpecialInstructions
        {
            get
            {
                List<String> instructions = new List<String>();
                if (!Broccoli) instructions.Add("Hold broccoli");
                if (!Mushrooms) instructions.Add("Hold mushrooms");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Cheddar) instructions.Add("Hold cheddar");

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
        /// Price of the Garden Orc Omelette
        /// </summary>
        public override double Price { get; } = 4.57;


        /// <summary>
        /// Calories of the Garden Orc Omelette
        /// </summary>
        public override uint Calories { get; } = 404;


        /// <summary>
        /// Boolean which indicates if there is broccoli on the order
        /// </summary>
        public bool Broccoli { get { return broccoli; } set { broccoli = value; NotifyPropertyChanged("Broccoli"); } }
        private bool broccoli = true;

        /// <summary>
        /// Boolean which indicates if there are mushrooms on the order
        /// </summary>
        public bool Mushrooms { get { return mushrooms; } set { mushrooms = value; NotifyPropertyChanged("Mushrooms"); } }
        private bool mushrooms = true;


        /// <summary>
        /// Boolean which indicates if there is a tomato on the order
        /// </summary>
        public bool Tomato { get { return tomato; } set { tomato = value; NotifyPropertyChanged("Tomato"); } } 
        private bool tomato = true;


        /// <summary>
        /// Boolean which indicates if there is a cheddar on the order
        /// </summary>
        public bool Cheddar { get { return cheddar; } set { cheddar = value; NotifyPropertyChanged("Cheddar"); } } 
        private bool cheddar = true;


        /// <summary>
        /// This method sets all of the ingredients to default false, then adds ingredients back based on the provided list
        /// </summary>
        /// <param name="vs"></param>
        public override void setIngredients(BindingList<string> vs)
        {
            Broccoli = false;
            Mushrooms = false;
            Tomato = false;
            Cheddar = false;



            foreach (string s in vs)
            {

                if (s.Equals("Broccoli"))
                {
                    Broccoli = true;
                }
                if (s.Equals("Mushrooms"))
                {
                    Mushrooms = true;
                }
                if (s.Equals("Tomato"))
                {
                    Tomato = true;
                }
                if (s.Equals("Cheddar"))
                {
                    Cheddar = true;
                }


            }

        }



        //to string


        /// <summary>
        /// toString override for Garden Orc Omelette
        /// </summary>
        /// <returns>Garden Orc Omelette string</returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }



    }
}
