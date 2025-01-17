// Walker Chesley
// Laith Alfaloujeh
// Jeniece Calva

using System;

namespace Assignment_5
{
    class Bill
    {
        public Bill(string date, string desc, double Amount )
        {
            billDate = date;
            description = desc;
            amount = Amount;
        }
        string billDate;
        string description;
        //bill total amount: 
        double amount; 

        ///<summary>
        ///  returns string contains all information in the bill including the payments. See the main() method and sample output to see what information is returned and then printed. 
        ///</summary>
        public string getBillInfo()
        {
            string billInfo = $"Date:{billDate}";
            billInfo += $"Description: {description}";
            billInfo += $"Amount Due: {amount}";
            return billInfo; 
        }
        
        ///<summary>
        ///  calculate the remaining balance by calculating the difference between the total of payments and the bill’s original amount
        ///</summary>
        public double getBalance()
        {
            return amount = amount - Payment.getAmount(); 
        }

        ///<summary>
        ///  It calls verify() method first, and if verify is successful it adds the payment to the bill payments
        ///</summary>
        public bool addPayment(Payment p)
        {
            if(p.verify())
            {
                getBalance();
                return true;
            } 
            else return false;
        }
    }
}