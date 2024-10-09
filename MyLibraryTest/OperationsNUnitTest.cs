using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    [TestFixture]
    public class OperationsNUnitTest
    {
        [Test]
        public void Add_InputNumbers_ReturnNumber() 
        {
            // 1. Arrange
            // Operations operations = new Operations();                    // Arrange es arrancar la prueba
            // Operations operations = new();
            var operations = new Operations();
            int number1 = 2;
            int number2 = 5;
            int exceptedResult = 7;

            // 2. Act
            int result = operations.Add(number1, number2);                              // Act es resultado de la prueba

            // 3. Assert
            Assert.That(result, Is.EqualTo(exceptedResult));                            // Assert es la comprobacion de la prueba
            Assert.That(result, Is.Not.EqualTo(8));
            Assert.That(result, Is.Not.EqualTo(6));
        }

        [Test]
        [TestCase(10)]
        [TestCase(12)]
        [TestCase(14)]
        public void IsEven_InputNumber_ReturnTrue(int number)
        {
            // 1. Arrange
            Operations operations = new Operations();
            //int number = 10;

            // 2. Act
            var result = operations.Iseven(number);

            // 3. Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(10, ExpectedResult = true)]
        [TestCase(13, ExpectedResult = false)]
        [TestCase(14, ExpectedResult = true)]
        public bool IsEven_InputNumber_ReturnTrueDistinto(int number)
        {
            // 1. Arrange
            Operations operations = new Operations();
            //int number = 10;

            // 2. Act
            var result = operations.Iseven(number);
            
            // 3. Assert
            return result;
        }

        [Test]
        [TestCase(2.2, 1.2)]
        [TestCase(2.23, 1.24)]
        public void AddDecimal_InputDoubleNumbers_ReturnDoubleNumber(double number1, double number2)
        {
            // 1. Arrange
            Operations operations = new ();

            // 2. Act
            double result = operations.AddDecimal(number1, number2);

            // 3. Assert
            Assert.That (result, Is.EqualTo(3.4).Within(0.1));
        }

        [Test]
        [TestCase(1,20)]
        [TestCase(100,1000)]
        public void GetEvenNumbers_InputRange_ReturnEvenNumbers(int start, int end)
        {
            //1.Arrange
            Operations operations1 = new Operations();
            int startNumber = start % 2 == 0 ? start : start +1;
            int endNumber = end % 2 == 0 ? end : end -1;

            int middleNumber = (endNumber + startNumber) / 2;

            //2.Act
            var result = operations1.GetEvenNumbers(start, end);

            //3.Assert
            Assert.That(end - start >= 2, Is.True);
            Assert.That(result, Is.Not.Empty);
            Assert.That(result, Is.TypeOf<List<int>>());
            Assert.That(result[0], Is.TypeOf<int>());
            
            Assert.That(result, Is.Ordered);
            Assert.That(result, Has.No.All.LessThan(startNumber));
            Assert.That(result, Has.Member(startNumber));
            Assert.That(result, Has.Member(6));
            Assert.That(result, Has.Member(10));
            Assert.That(result, Has.No.Member(11));
            Assert.That(result, Has.All.InRange(0, 10));
            Assert.That(result, Has.All.GreaterThanOrEqualTo(10));
            Assert.That(result, Has.All.LessThanOrEqualTo(10));
            Assert.That(result, Is.EquivalentTo(new[] {0, 2, 4, 6, 8}));
            Assert.That(result, Is.Unique);
        }
    }
}
