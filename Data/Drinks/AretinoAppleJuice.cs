﻿using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Abstract;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{



    /*
     * Author: John Solomon
     * Class name: AretinoAppleJuice.cs
     * Purpose: To track Aretino Apple Juice
     */
    public class AretinoAppleJuice : Drink , INotifyPropertyChanged
    {


        // This BindingSource binds the list to the DataGridView control.
        public event PropertyChangedEventHandler PropertyChanged;
        

        /// <summary>
        /// The special instuctions for Aretino Apple Juice
        /// </summary>
        public override List<String> SpecialInstructions
        {
            get
            {
                List<String> instructions = new List<String>();
                if (Ice) instructions.Add("Add Ice");

                return instructions;
            }//get

        }//SpecialInstructions





        //properties
        /// <summary>
        /// If there is or is not Ice in the Aretino Apple Juice
        /// </summary>
        public bool Ice { get { return ice; } set { ice = value; NotifyPropertyChanged("Ice"); } }
        private bool ice = false;

        /// <summary>
        /// The size of the Aretino Apple juice
        /// </summary>
        public override Size Size { get { return size; } set { size = value; NotifyPropertyChanged("Size"); } }//Size
        private Size size = Size.Small;

        
        /// <summary>
        /// The Price of the Aretino Apple Juice
        /// </summary>
        /// /// <exception cref="System.NotImplementedException">
        /// Thrown if the price for the size is not known 
        /// </exception>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 0.62;
                    case Size.Medium: return 0.87;
                    case Size.Large: return 1.01;
                    default: throw new NotImplementedException($"Unknown size {Size}");
                }
            }//getter
            
        }//price


        /// <summary>
        /// The amount of calories in Aretino Apple Juice
        /// </summary>
        /// /// <exception cref="System.NotImplementedException">
        /// Thrown if the calories for the size is not known 
        /// </exception>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 44;
                    case Size.Medium: return 88;
                    case Size.Large: return 132;
                    default: throw new NotImplementedException($"Unknown size {Size}");
                }
            }//getter
        }//calories

        /// <summary>
        /// This method sets all of the ingredients to default false, then adds ingredients back based on the provided list
        /// </summary>
        /// <param name="vs"></param>
        public override void setIngredients(BindingList<string> vs)
        {
            Ice = false;
            Size = Size.Small;



            foreach (string s in vs)
            {

                if (s.Equals("Ice"))
                {
                    Ice = true;
                }
                if (s.Equals("Small"))
                {
                    Size = Size.Small;
                }
                if (s.Equals("Medium"))
                {
                    Size = Size.Medium;
                }
                if (s.Equals("Large"))
                {
                    Size = Size.Large;
                }


            }

        }


        // This method is called by the Set accessor of each property.
        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        //toString


        /// <summary>
        /// ToString() override
        /// </summary>
        /// <returns>Aretino Apple Juice string</returns>
        public override string ToString()
        {
            return (Size.ToString() + " Aretino Apple Juice");
        }//ToString




    }//aretinoAppleJuice
}//BleakwindBuffet.Data.Drinks
