using System.Collections.Generic;

namespace queteEntityFrameWorkCodeFirst
{
    public class Person
    {
        public int PersonID { get; set; }
        public string PersonName { get; set; }
        public ICollection<SavingAccount> SavingAccounts { get; set; }

    }
}