using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nunitdemo;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using Nunitdemo.NUnitDemonstration;

namespace Testclass1
{
    public class TriangleTest
    {
        // PROG8041-PRATYUSHA JAYAVARAPU-8973016-LAB 2
        [TestFixture]
        public class TriangleTest2
        {
            [Test]
            public void ValidTriangle_Input60and60and60_OutputValidTriangle()
            {
                //Arrange
                int firstAngle = 60;
                int secondAngle = 60;
                int thirdAngle = 60;

                string expected = "The triangle is valid";
                //Act 
                string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

                //Assert
                ClassicAssert.AreEqual(expected, actual);



            }
        }

    }
    }

    

