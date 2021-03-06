﻿using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Abstract;
using System.ComponentModel;


namespace BleakwindBuffet.Data.Entrees
{
    /*
     * Author: John Solomon
     * Class name: SmokehouseSkeleton.cs
     * Purpose: To track Smokehouse Skeleton: Put some meat on those bones with a small stack of pancakes. Includes sausage links, eggs, and hash browns on the side. Topped with the syrup of your choice.
     */
    public class SmokehouseSkeleton :Entree, INotifyPropertyChanged
    {

        // This BindingSource binds the list to the DataGridView control.
        public event PropertyChangedEventHandler PropertyChanged;

        //special instructions

        /// <summary>
        /// The special instuctions for the Smokehouse Skeleton
        /// </summary>
        public override List<String> SpecialInstructions
        {
            get
            {
                List<String> instructions = new List<String>();
                if (!SausageLink) instructions.Add("Hold sausage link");
                if (!Egg) instructions.Add("Hold egg");
                if (!HashBrowns) instructions.Add("Hold hash browns");
                if (!Pancake) instructions.Add("Hold pancakes");

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
        /// Price of the Smokehouse Skeleton
        /// </summary>
        public override double Price { get; } = 5.62;


        /// <summary>
        /// Calories of the Smokehouse Skeleton
        /// </summary>
        public override uint Calories { get; } = 602;


        /// <summary>
        /// Boolean which indicates if there is sausage on the order
        /// </summary>
        public bool SausageLink { get { return sausageLink; } set { sausageLink = value; NotifyPropertyChanged("Sausage Link"); } } 
        private bool sausageLink = true;


        /// <summary>
        /// Boolean which indicates if there is egg on the order
        /// </summary>
        public bool Egg { get { return egg; } set { egg = value; NotifyPropertyChanged("Egg"); } } 
        private bool egg = true;


        /// <summary>
        /// Boolean which indicates if there is hash browns on the order
        /// </summary>
        public bool HashBrowns { get { return hashBrowns; } set { hashBrowns = value; NotifyPropertyChanged("Hash Browns"); } }
        private bool hashBrowns = true;


        /// <summary>
        /// Boolean which indicates if there is pancake on the order
        /// </summary>
        public bool Pancake { get { return pancake; } set { pancake = value; NotifyPropertyChanged("Pancake"); } } 
        private bool pancake = true;




        /// <summary>
        /// This method sets all of the ingredients to default false, then adds ingredients back based on the provided list
        /// </summary>
        /// <param name="vs"></param>
        public override void setIngredients(BindingList<string> vs)
        {

            SausageLink = false;
            Egg = false;
            HashBrowns = false;
            Pancake = false;



            foreach (string s in vs)
            {
                if(s.Equals("Sausage Link"))
                {
                    SausageLink = true;
                }
                if (s.Equals("Egg"))
                {
                    Egg = true;
                }
                if (s.Equals("Hash Browns"))
                {
                    HashBrowns = true;
                }
                if (s.Equals("Pancake"))
                {
                    Pancake = true;
                }


            }

        }










        //to string


        /// <summary>
        /// Overriden ToString() method
        /// </summary>
        /// <returns>Smokehouse Skeleton as a string</returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }





    }//class
}//namespace
