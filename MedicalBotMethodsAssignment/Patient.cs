using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalBotMethodsAssignment
{
    internal class Patient
    {
        internal string Name;

        internal int Age;

        internal string Gender;

        internal string MedicalHistory;

        internal string SymptomCode;

        internal string Prescription;


        internal string GetName()
        {
            return this.Name;
        }

        internal int GetAge()
        {
            return this.Age;
        }

        internal string GetGender()
        {
            return this.Gender;
        }

        internal string GetMedicalHistory()
        {
            return this.MedicalHistory;
        }

        internal string GetSymptom()
        {
            string symptomCode = this.SymptomCode;
            if (symptomCode == "S1" || symptomCode == "s1")
            {
                return "Headache";
            }
            else if (symptomCode == "S2" || symptomCode == "s2")
            {
                return "Skin Rashes";
            }
            else if (symptomCode == "S3" || symptomCode == "s3")
            {
                return "Dizziness";
            }
            else
            {
                return "Invalid Symptom Code";
            }
        }

        internal string GetPrescription()
        {
            return this.Prescription;
        }

    }
}
