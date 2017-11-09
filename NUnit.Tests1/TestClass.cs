using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_2;

namespace NUnit.Tests1
{
    public class TestClass
    {
        Motor motor;

        [SetUp]
        public void Init()
        {
            motor = new Motor();
        }

        [Test]
        public void TestConstructorClassic()
        {
            Assert.AreEqual(0, motor.Speed);
            Assert.IsInstanceOf<WayOfRotation>(motor.CurrentDirection);
            Assert.AreEqual(WayOfRotation.Stopped, motor.CurrentDirection);
        }

        [Test]
        public void TestConstructorConstraint()
        {
            Assert.That(motor.Speed, Is.EqualTo(0));
            Assert.That(motor.CurrentDirection, Is.TypeOf<WayOfRotation>());
            Assert.That(motor.CurrentDirection, Is.EqualTo(WayOfRotation.Stopped));
        }

        [Test]
        public void TestStart()
        {
            motor.Start(WayOfRotation.Right);
            //Проверка min скорости 
            Assert.That(motor.Speed, Is.Not.EqualTo(0));
            //Проверка на генерацию исключения 
            Assert.That(() => motor.Start(WayOfRotation.Left), Throws.InvalidOperationException);
        }

        // Individual task #1
        [Test]
        public void TestStop()
        {
            motor.Start(WayOfRotation.Right);
            motor.Stop();
            Assert.That(motor.Speed, Is.EqualTo(0));
            Assert.That(motor.CurrentDirection, Is.EqualTo(WayOfRotation.Stopped));
        }

        [Test]
        public void TestSpeedUp()
        {
            motor.Start(WayOfRotation.Right);
            motor.SpeedUp(2);
            Assert.That(motor.Speed, Is.EqualTo(3));
            motor.SpeedUp(10);
            Assert.That(motor.Speed, Is.EqualTo(10));
            motor.Stop();
            Assert.That(() => motor.SpeedUp(1), Throws.InvalidOperationException);
        }

        [Test]
        public void TestSpeedDown()
        {
            motor.Start(WayOfRotation.Right);
            motor.SpeedUp(10);
            motor.SpeedDown(1);
            Assert.That(motor.Speed, Is.EqualTo(9));
            motor.SpeedDown(2);
            Assert.That(motor.Speed, Is.EqualTo(7));
            motor.SpeedDown(10);
            Assert.That(motor.Speed, Is.EqualTo(0));
            Assert.That(motor.CurrentDirection, Is.EqualTo(WayOfRotation.Stopped));
        }

        /// <summary>
        /// Variant 3
        /// </summary> 
        [Test]
        public void TestString()
        {
            string s1 = "strasse";
            string s2 = "straße";
            Assert.IsTrue(s1.Equals(s2, StringComparison.InvariantCulture));
        }

        /// <summary>
        /// Variant 5
        /// </summary>
        [Test]
        public void TestParse()
        {
            int myInt;
            string myString = "Some word";
            if (int.TryParse(myString, out myInt))
            {
                myInt = int.Parse(myString);
            }
            else
            {
                myInt = 0;
            }
        }
    }
}
