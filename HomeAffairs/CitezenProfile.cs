using System;

namespace HomeAffairsDigitalIdentityProcessor
{
    public class CitizenProfile
    {
        public string FullName { get; set; }
        public string IDNumber { get; set; }
        public int Age { get; set; }
        public string CitizenshipStatus { get; set; }
        public string Gender { get; set; } // NEW in v2.0

        public CitizenProfile(string fullName, string idNumber, string citizenshipStatus)
        {
            FullName = fullName;
            IDNumber = idNumber;
            CitizenshipStatus = citizenshipStatus;
            Age = CalculateAge(idNumber);
            Gender = DetermineGender(idNumber); // NEW in v2.0
        }

        private int CalculateAge(string idNumber)
        {
            try
            {
                int year = int.Parse(idNumber.Substring(0, 2));
                int month = int.Parse(idNumber.Substring(2, 2));
                int day = int.Parse(idNumber.Substring(4, 2));

                int currentYear = DateTime.Now.Year;
                int century = (year <= currentYear % 100) ? 2000 : 1900;
                int fullYear = century + year;

                DateTime birthDate = new DateTime(fullYear, month, day);
                int age = currentYear - fullYear;

                if (DateTime.Now < birthDate.AddYears(age))
                    age--;

                return age;
            }
            catch
            {
                return -1;
            }
        }

        // NEW in v2.0: digits 6-9 of SA ID determine gender (0000-4999 = Female, 5000-9999 = Male)
        private string DetermineGender(string idNumber)
        {
            try
            {
                if (idNumber.Length < 10) return "Unknown";
                int genderDigits = int.Parse(idNumber.Substring(6, 4));
                return genderDigits >= 5000 ? "Male" : "Female";
            }
            catch
            {
                return "Unknown";
            }
        }

        public string ValidateID()
        {
            if (IDNumber.Length != 13)
                return "Invalid ID: Must contain exactly 13 digits.";

            foreach (char c in IDNumber)
            {
                if (!char.IsDigit(c))
                    return "Invalid ID: ID number must be fully numeric.";
            }

            if (Age < 0)
                return "Invalid ID: Could not calculate a valid age.";

            return "Valid ID. Citizen is " + Age + " years old.";
        }
    }
}