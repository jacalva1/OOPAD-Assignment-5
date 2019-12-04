using System; 

namespace Assignment_5
{
    class Payment
    {
        //amount of THIS payment
        private double amount; 
        // date of THIS payment
        private string paymentDate; 

        ///<summary>
        /// returns the payment amount attribute
        ///</summary>
        public double getAmount()
        {
            return amount; 
        }


        public string getPaymentDate()
        {
            return paymentDate; 
        }

        ///<summary>
        ///  writes to the console the message “Payment verified“, and returns true. Need to be overloaded by derived classes if needed. 
        ///</summary>
        virtual bool verify()
        {

        }

        ///<summary>
        /// has no implementation (abstract) in this class, and it need to be implemented in all derived classes. 
        ///</summary>
        abstract string getPaymentType()
        {

        }
    }
}