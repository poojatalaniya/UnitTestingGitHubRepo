﻿using System;using System.Collections.Generic;using System.Linq;using System.Text;using System.Threading.Tasks;using NUnit.Framework;using NUnit.Framework.Legacy;using PoojaLab2;namespace ClassUnitTest{
    // Pooja's Unit Test
    public class TriangleTest1    {        public class Class1        {            [Test]            public void ValidTriangle_Input60and60and60_OutputValidTriangle()            {
                // Pooja's Unit Test
                //Arrange
                int firstAngle = 60;                int secondAngle = 60;                int thirdAngle = 60;                string expected = "The triangle is valid.";

                //Act
                string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

                //Assert
                ClassicAssert.AreEqual(expected, actual);            }        }    }}