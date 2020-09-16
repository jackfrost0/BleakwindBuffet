﻿using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Abstract;



namespace BleakwindBuffet.Data.Drinks
{
    /*
     * Author: John Solomon
     * Class name: CandlehearthCoffee.cs
     * Purpose: To track Candlehearth Coffee
     */
    public class CandlehearthCoffee : Drink
    {

        //Special Instructions


        /// <summary>
        /// The special instuctions for Candlehearth Coffee
        /// </summary>
        public override List<String> SpecialInstructions
        {
            get
            {
                List<String> instructions = new List<String>();
                if (Ice) instructions.Add("Add Ice");
                if (RoomForCream) instructions.Add("Add Cream");

                return instructions;
            }

        }//SpecialInstructions


        //properties

        /// <summary>
        /// The size of the Candlehearth Coffee
        /// </summary>
        public override Size Size { get { return size; } set { size = value; } }
        private Size size = Size.Small;

        /// <summary>
        /// If the coffee is or is not decaf
        /// </summary>
        public bool Decaf { get; set; } //decaf
        private bool decaf = false;

        /// <summary>
        /// If there is or is not Ice in the Candlehearth Coffee
        /// </summary>
        public bool Ice { get { return ice; } set { ice = value; } }
        private bool ice = false;


        /// <summary>
        /// Indicates if there is or is not room for cream in the coffee
        /// </summary>
        public bool RoomForCream { get { return roomForCream; } set { roomForCream = value;} } //cream
        private bool roomForCream = false;

        /// <summary>
        /// The Price of the Coffee
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
                    case Size.Small: return 0.75;
                    case Size.Medium: return 1.25;
                    case Size.Large: return 1.75;
                    default: throw new NotImplementedException($"Unknown size {Size}");
                }
            }

        }//price


        /// <summary>
        /// The amount of calories in the Coffee
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
                    case Size.Small: return 7;
                    case Size.Medium: return 10;
                    case Size.Large: return 20;
                    default: throw new NotImplementedException($"Unknown size {Size}");
                }
            }
        }//calories




        //toString

        /// <summary>
        /// To string override for candlehearth coffee
        /// </summary>
        /// <returns>Candlehearth Coffee string</returns>
        public override string ToString()
        {
            if(Decaf) return (Size.ToString() + " Decaf Candlehearth Coffee");

            return (Size.ToString() + " Candlehearth Coffee");
        }


    }//class
}//namespace
