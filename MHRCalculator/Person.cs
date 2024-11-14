using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// https://www.verywellfit.com/maximum-heart-rate-1231221
namespace MHRCalculator
{
    public enum MHR_FORMULA { FOX_F23, GULATI_F23, HUNT_F23, TANAKA_F23};
    public enum ACTIVITY_LEVEL { SEDENTARY_F23, MINIMAL_F23, SPORADIC_F23, REGULAR_F23, HIGH_INTENSITY_F23 };

    public class PersonF23
    {
        public int Age { get; set; }
        public bool IsFemale { get; set; } = true;
        public ACTIVITY_LEVEL ActivityLevel { get; set; }
        public int MaxHeartRate { get; private set; }
        public int TargetMinHR { get; private set; }
        public int TargetMaxHR { get; private set; }

        public int CalculateMaxHeartRateF23(MHR_FORMULA formula)
        {
            if (formula == MHR_FORMULA.FOX_F23)
                MaxHeartRate = 220 - Age;    // fix 200 to 220
            else if (formula == MHR_FORMULA.GULATI_F23)
                MaxHeartRate = (int)Math.Round(206 - .88 * Age);
            else if (formula == MHR_FORMULA.HUNT_F23)
                MaxHeartRate = (int)Math.Round(211 - .64 * Age);  // Fix 0.67 to 0.64
            else if (formula == MHR_FORMULA.TANAKA_F23)
                MaxHeartRate = (int)Math.Round(208 - .7 * Age);   // Fix 218 to 208

            return MaxHeartRate;
        }

        public void CalculateTargetHeartRatesF23()
        {
            if (ActivityLevel == ACTIVITY_LEVEL.SEDENTARY_F23)
            {
                TargetMinHR = (int)Math.Round(.57 * MaxHeartRate);  //Switch max and min (Fixed)
                TargetMaxHR = (int)Math.Round(.67 * MaxHeartRate);
            }
            else if (ActivityLevel == ACTIVITY_LEVEL.SPORADIC_F23)
            {
                TargetMinHR = (int)Math.Round(.74 * MaxHeartRate); // fix 0.80 to .74
                TargetMaxHR = (int)Math.Round(.84 * MaxHeartRate); //fix 0.91 to .84
            }
            else if (ActivityLevel == ACTIVITY_LEVEL.MINIMAL_F23)
            {
                TargetMinHR = (int)Math.Round(.64 * MaxHeartRate);
                TargetMaxHR = (int)Math.Round(.74 * MaxHeartRate);
            }
            else if (ActivityLevel == ACTIVITY_LEVEL.REGULAR_F23)
            {
                TargetMinHR = (int)Math.Round(.80 * MaxHeartRate);  // Fix 0.74 to .80
                TargetMaxHR = (int)Math.Round(.91 * MaxHeartRate);  //Fix 0.84 to .91  and sporadic and reegular switch
            }
            else if (ActivityLevel == ACTIVITY_LEVEL.HIGH_INTENSITY_F23)
            {
                TargetMinHR = (int)Math.Round(.84 * MaxHeartRate);
                TargetMaxHR = (int)Math.Round(.94 * MaxHeartRate);
            }
        }
    }
}
// TC1 Fox, Female, 80, minimal activity
// TC2 Tanaka, Male, 65, sedentary - no exercise
// TC3 Tanaka, Female, 60, sporadic exercise
// TC4 Fox, Male, 45, regular exercise
// TC5 Gulati, Female, 40, regular exercise
// TC6 Hunt, Male, 25, high intensity
// TC7 Hunt, Female, 20, high intensity
