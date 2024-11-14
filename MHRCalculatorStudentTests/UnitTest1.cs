using MHRCalculator;
using System.ComponentModel;

namespace MHRCalculatorStudentTests
{

    // TC1 Fox, Female, 80, minimal activity
    // TC2 Tanaka, Male, 65, sedentary - no exercise
    // TC3 Tanaka, Female, 60, sporadic exercise
    // TC4 Fox, Male, 45, regular exercise
    // TC5 Gulati, Female, 40, regular exercise
    // TC6 Hunt, Male, 25, high intensity
    // TC7 Hunt, Female, 20, high intensity

    [TestClass]
    public class UnitTest1
    {
        // TC1 Fox, Female, 80, minimal activity
        [TestMethod]
        public void TestMethod1()
        {   // Arrange
            PersonF23 person1 = new PersonF23();
            person1.IsFemale = true;
            person1.Age = 80;
            person1.ActivityLevel = ACTIVITY_LEVEL.MINIMAL_F23;
            MHR_FORMULA formula = MHR_FORMULA.FOX_F23;
            //Act
            person1.CalculateMaxHeartRateF23(formula);
            person1.CalculateTargetHeartRatesF23();
            // Assert
            int expected = 220 - 80;
            Assert.AreEqual(expected, person1.MaxHeartRate);
            Assert.AreEqual((int)Math.Round(.64 * person1.MaxHeartRate), person1.TargetMinHR);
            Assert.AreEqual((int)Math.Round(.74 * person1.MaxHeartRate), person1.TargetMaxHR);
            
        }

        [TestMethod]
        // TC2 Tanaka, Male, 65, sedentary - no exercise
        public void TestMethod2()
        {   // Arrange
            PersonF23 person1 = new PersonF23();
            person1.IsFemale = false;
            person1.Age = 65;
            person1.ActivityLevel = ACTIVITY_LEVEL.SEDENTARY_F23;
            MHR_FORMULA formula = MHR_FORMULA.TANAKA_F23;
            //Act
            person1.CalculateMaxHeartRateF23(formula);
            person1.CalculateTargetHeartRatesF23();
            // Assert
            int expected = (int)Math.Round(208 - (0.7 * 65));
            Assert.AreEqual(expected, person1.MaxHeartRate);
            Assert.AreEqual((int)Math.Round(.57 * person1.MaxHeartRate), person1.TargetMinHR);
            Assert.AreEqual((int)Math.Round(.67 * person1.MaxHeartRate), person1.TargetMaxHR);


        }

        [TestMethod]
        // TC3 Tanaka, Female, 60, sporadic exercise
        public void TestMethod3()
        {   // Arrange
            PersonF23 person1 = new PersonF23();
            person1.IsFemale = true;
            person1.Age = 60;
            person1.ActivityLevel = ACTIVITY_LEVEL.SPORADIC_F23;
            MHR_FORMULA formula = MHR_FORMULA.TANAKA_F23;
            //Act
            person1.CalculateMaxHeartRateF23(formula);
            person1.CalculateTargetHeartRatesF23();

            // Assert
            int expected = (int)Math.Round(208 - (0.7 * 60));
            Assert.AreEqual(expected, person1.MaxHeartRate);
            Assert.AreEqual((int)Math.Round(.74 * person1.MaxHeartRate), person1.TargetMinHR);
            Assert.AreEqual((int)Math.Round(.84 * person1.MaxHeartRate), person1.TargetMaxHR);


        }


        [TestMethod]
        // TC4 Fox, Male, 45, regular exercise
        public void TestMethod4()
        {   // Arrange
            PersonF23 person1 = new PersonF23();
            person1.IsFemale = false;
            person1.Age = 45;
            person1.ActivityLevel = ACTIVITY_LEVEL.REGULAR_F23;
            MHR_FORMULA formula = MHR_FORMULA.FOX_F23;
            //Act
            person1.CalculateMaxHeartRateF23(formula);
            person1.CalculateTargetHeartRatesF23();
            // Assert
            
            Assert.AreEqual(220 - 45, person1.MaxHeartRate);
            Assert.AreEqual((int)Math.Round(.80 * person1.MaxHeartRate), person1.TargetMinHR);
            Assert.AreEqual((int)Math.Round(.91 * person1.MaxHeartRate), person1.TargetMaxHR);


        }



        [TestMethod]
        // TC5 Gulati, Female, 40, regular exercise
        public void TestMethod5()
        {   // Arrange
            PersonF23 person1 = new PersonF23();
            person1.IsFemale = true;
            person1.Age = 40;
            person1.ActivityLevel = ACTIVITY_LEVEL.REGULAR_F23;
            MHR_FORMULA formula = MHR_FORMULA.GULATI_F23;
            //Act
            person1.CalculateMaxHeartRateF23(formula);
            person1.CalculateTargetHeartRatesF23();
            // Assert
            int expected = (int)Math.Round(206 - (0.88 * 40));
            Assert.AreEqual(expected, person1.MaxHeartRate);
            Assert.AreEqual((int)Math.Round(.80 * person1.MaxHeartRate), person1.TargetMinHR);
            Assert.AreEqual((int)Math.Round(.91 * person1.MaxHeartRate), person1.TargetMaxHR);


        }


        [TestMethod]
        // TC6 Hunt, Male, 25, high intensity
        public void TestMethod6()
        {   // Arrange
            PersonF23 person1 = new PersonF23();
            person1.IsFemale = false;
            person1.Age = 25;
            person1.ActivityLevel = ACTIVITY_LEVEL.HIGH_INTENSITY_F23;
            MHR_FORMULA formula = MHR_FORMULA.HUNT_F23;
            //Act
            person1.CalculateMaxHeartRateF23(formula);
            person1.CalculateTargetHeartRatesF23();
            // Assert
            int expected = (int)Math.Round(211 - (0.64 * 25));
            Assert.AreEqual(expected, person1.MaxHeartRate);
            Assert.AreEqual((int)Math.Round(.84 * person1.MaxHeartRate), person1.TargetMinHR);
            Assert.AreEqual((int)Math.Round(.94 * person1.MaxHeartRate), person1.TargetMaxHR);


        }

        [TestMethod]
        // TC7 Hunt, Female, 20, high intensity
        public void TestMethod7()
        {   // Arrange
            PersonF23 person1 = new PersonF23();
            person1.IsFemale = true;
            person1.Age = 20;
            person1.ActivityLevel = ACTIVITY_LEVEL.HIGH_INTENSITY_F23;
            MHR_FORMULA formula = MHR_FORMULA.HUNT_F23;
            //Act
            person1.CalculateMaxHeartRateF23(formula);
            person1.CalculateTargetHeartRatesF23();
            // Assert
            int expected = (int)Math.Round(211 - (0.64 * 20));
            Assert.AreEqual(expected, person1.MaxHeartRate);
            Assert.AreEqual((int)Math.Round(.84 * person1.MaxHeartRate), person1.TargetMinHR);
            Assert.AreEqual((int)Math.Round(.94 * person1.MaxHeartRate), person1.TargetMaxHR);


        }


    }
}