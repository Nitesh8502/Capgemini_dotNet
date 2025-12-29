using System;

namespace Applicaiton
{
    public class PatientBill
    {
        public string BillId { get; set; }
        public string PatientName { get; set; }
        public bool HasInsurance { get; set; }
        public decimal ConsultationFee { get; set; }
        public decimal LabCharges { get; set; }
        public decimal MedicineCharges { get; set; }
        public decimal GrossAmount { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal FinalPayable { get; set; }
        
        public static PatientBill LastBill;
        public static bool HasLastBill = false;
    }
    public class BillingService
    {
        public static void CreateBill()
        {
            Console.Write("enter Bill Id: ");
            string billId = Console.ReadLine();
            
            if (string.IsNullOrWhiteSpace(billId))
            {
                Console.WriteLine("bill id cannot be empty.");
                return;
            }

            Console.Write("enter Patient Name: ");
            string patientName = Console.ReadLine();

            Console.Write("is the patient insured? yes or no: ");
            string insuranceInput = Console.ReadLine();
            bool hasInsurance = insuranceInput?.ToUpper() == "Y";

            Console.Write("Enter Consultation Fee: ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal consultationFee) || consultationFee <= 0)
            {
                Console.WriteLine("cnsultation Fee must be greater than 0.");
                return;
            }

            Console.Write("enter Lab charges  ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal labCharges) || labCharges < 0)
            {
                Console.WriteLine("Lab Charges must be greater than or equal to 0.");
                return;
            }

            Console.Write("enter medicine charges: ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal medicineCharges) || medicineCharges < 0)
            {
                Console.WriteLine("medicine Charges must be greater than or equal to 0.");
                return;
            }

            decimal grossAmount = consultationFee + labCharges + medicineCharges;
            decimal discountAmount = hasInsurance ? grossAmount * 0.10m : 0;
            decimal finalPayable = grossAmount - discountAmount;

            PatientBill.LastBill = new PatientBill
            {
                BillId = billId,
                PatientName = patientName,
                HasInsurance = hasInsurance,
                ConsultationFee = consultationFee,
                LabCharges = labCharges,
                MedicineCharges = medicineCharges,
                GrossAmount = grossAmount,
                DiscountAmount = discountAmount,
                FinalPayable = finalPayable
            };

            PatientBill.HasLastBill = true;

            Console.WriteLine("bill created ");
            Console.WriteLine($"grors Amount: {grossAmount}");
            Console.WriteLine($"discount Amount: {discountAmount}");
            Console.WriteLine($"final payable: {finalPayable}");
            
        }
        public static void ViewLastBill()
        {
            if (!PatientBill.HasLastBill)
            {
                Console.WriteLine("No bill available create a new bill first.");
                return;
            }

            var obj = PatientBill.LastBill;
            Console.WriteLine("----------- Last Bill -----------");
            Console.WriteLine($"billId: {obj.BillId}");
            Console.WriteLine($"patient: {obj.PatientName}");
            Console.WriteLine($"insured: {(obj.HasInsurance ? "Yes" : "No")}");
            Console.WriteLine($"consultation fee: {obj.ConsultationFee}");
            Console.WriteLine($"lab Charges: {obj.LabCharges}");
            Console.WriteLine($"mddicine Charges: {obj.MedicineCharges}");
            Console.WriteLine($"gfross amount: {obj.GrossAmount}");
            Console.WriteLine($"discount amount: {obj.DiscountAmount}");
            Console.WriteLine($"final Payable: {obj.FinalPayable}");
            
        }

        public static void ClearLastBill()
        {
            PatientBill.LastBill = null;
            PatientBill.HasLastBill = false;
            Console.WriteLine("last bill cleared.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("================== MediSure Clinic Billing ==================");
                Console.WriteLine("1. Create New Bill ==>Enter Patient Details");
                Console.WriteLine("2. View Last Bill");
                Console.WriteLine("3. Clear Last Bill");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your option: ");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        BillingService.CreateBill();
                        break;
                    case "2":
                        BillingService.ViewLastBill();
                        break;
                    case "3":
                        BillingService.ClearLastBill();
                        break;
                    case "4":
                        Console.WriteLine("Thank you. Application closed normally.");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please select a valid menu option.");
                        break;
                }
            }
        }
    }
}