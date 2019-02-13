using System;
using System.Collections.Generic;
using System.Text;

namespace CreditCardApplications
{
    public class Fraudlookup
    {
        virtual public bool IsFraudRisk(CreditCardApplication application)
        {
            if (application.LastName == "Smith")
            {
                return true;
            }

            return false;
        }
    }
}
