using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalApp
{
    enum TypeOfUserAccount
    {
        Administrator,
        GeneralUser
    }
    class Account
    {
        private static int lastAccountnumber = 0;

        #region Properties
        public TypeOfUserAccount AccountType { get; set; }
        public string UserName { get; set; }
        public string DriversLicenseNumber { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public int CreditCardNumber { get; set; }
        public string Address { get; set; }
        private int AccountNumber { get; set; }
        // need a reference to the class for insurance information
        #endregion
    }

}
