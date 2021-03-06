﻿/*
 * Author: Zachery Brunner
 * Class: DragonbornWaffleFriesTests.cs
 * Purpose: Test the DragonbornWaffleFries.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Interfaces;
using BleakwindBuffet.Data.Abstract;
using System.ComponentModel;


namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class DragonbornWaffleFriesTests
    {
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            DragonbornWaffleFries DWF = new DragonbornWaffleFries();
            Assert.Equal(Size.Small, DWF.Size);

        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            DragonbornWaffleFries DWF = new DragonbornWaffleFries();
            Assert.Equal(Size.Small, DWF.Size);

        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            DragonbornWaffleFries DWF = new DragonbornWaffleFries();
            Assert.Empty(DWF.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 0.42)]
        [InlineData(Size.Medium, 0.76)]
        [InlineData(Size.Large, 0.96)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            DragonbornWaffleFries DWF = new DragonbornWaffleFries() { 
            
                Size = size
            
            };

            Assert.Equal(price, DWF.Price);
        }

        [Theory]
        [InlineData(Size.Small, 77)]
        [InlineData(Size.Medium, 89)]
        [InlineData(Size.Large, 100)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            DragonbornWaffleFries DWF = new DragonbornWaffleFries()
            {

                Size = size

            };

            Assert.Equal(calories, DWF.Calories);

        }

        [Theory]
        [InlineData(Size.Small, "Small Dragonborn Waffle Fries")]
        [InlineData(Size.Medium, "Medium Dragonborn Waffle Fries")]
        [InlineData(Size.Large, "Large Dragonborn Waffle Fries")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            DragonbornWaffleFries DWF = new DragonbornWaffleFries()
            {

                Size = size

            };

            Assert.Equal(DWF.ToString(), name);

        }





        [Fact]
        public void ShouldBeAssignableToAbstractClass()
        {

            DragonbornWaffleFries DWF = new DragonbornWaffleFries();

            Assert.IsAssignableFrom<IOrderItem>(DWF);
            Assert.IsAssignableFrom<Side>(DWF);
            Assert.IsAssignableFrom<INotifyPropertyChanged>(DWF);

        }





    }
}