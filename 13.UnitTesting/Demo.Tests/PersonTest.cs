using NUnit.Framework;
using System;

namespace Demo.Tests
{
    [TestFixture]

    public class PersonTest
    {
        [Test]
        [TestCase("Stoyan")]
        [TestCase("Ivan")]
        [TestCase(null)]


        public void DoesWhatMyNameWorksProperly(string name)
        {
            // Arrange
            Person person = new Person(name, 10);

            // Act
            string expectedResult = $"My name is {name}";
            string actualResult = person.WhatsMyName();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
    }
