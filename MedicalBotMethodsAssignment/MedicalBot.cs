using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalBotMethodsAssignment
{
    internal class MedicalBot
    {
        public const string BotName = "Bob";

        public static string GetBotName()
        {
            return BotName;
        }

        public void PrescribeMedication(Patient patient)
        {
            //If the patient's symptoms are a headache, prescribe ibuprofen.

            //If the patient's symptoms are skin rashes, prescribe diphenhydramine.

            //If the patient's symptoms are dizziness, check if the patient has a medical history of diabetes. If they do, prescribe metformin. Otherwise, prescribe dimenhydrinate.
            string medicineName = "hello";

            GetDosage(medicineName);

            string GetDosage(string medicine)
            {
                if (medicine.Equals("ibuprofen"))
                {
                    if (patient.Age < 18)
                    {
                        return "Dosage = 400mg";
                    }
                    else
                    {
                        return "Dosage = 800mg";
                    }
                }
                else if (medicine.Equals("diphenhydramine"))
                {
                    if(patient.Age < 18)
                    {
                        return "Dosage = 15mg";
                    }
                    else
                    {
                        return "Dosage = 300mg";
                    }
                }
                else if (medicine.Equals("dimenhydrinate"))
                {
                    if(patient.Age < 18)
                    {
                        return "Dosage = 50mg";
                    }
                    else
                    {
                        return "Dosage = 400mg";
                    }
                }
                else if (medicine.Equals("metformin"))
                {
                    return "Dosage = 500mg";
                }
                return "Invalid Medicine Supplied";
            }
        }
    }
}
