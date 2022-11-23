using System;
using System.Collections.Generic;
using Commons;

namespace Models
{
    public class Voter : BaseEntity
    {

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string RegisterationNo { get; }
        public string DateOfBirth { get; set; }

        public PollingUnit PollingUnit { get; set; }

        public Voter(string pollingUnit)
        {
            RegisterationNo = $"{pollingUnit}-{Guid.NewGuid().ToString().Replace("-", "").Substring(0, 6)}";
        }




    }
    public class PollingUnit : BaseEntity
    {
        public string UnitNo { get; set; }

        //[RegularExpression(@"")]
        public string LocalGovernment { get; set; }
        public IList<Voter> MyProperty { get; set; }
    }
    // only classes that inherit this class can implement it
    public abstract class BaseEntity
    {
        public string id { get; }
        public DateTime CreatedOn { get; set; }

        // the ? indicates the value can be nullable
        public DateTime? ModifiedOn { get; set; }

        public BaseEntity()
        {
            id = Guid.NewGuid().ToString();
        }
    }
    public class Candidate : BaseEntity
    {
        public string Name { get; set; }

        public Party Party { get; set; }
    }
    public class Party : BaseEntity
    {
        public string name { get; set; }
        public int Votes { get; set; }

        public IList<Candidate> Candidate { get; set; }
    }

    public class Election
    {
        public ElectionType Type { get; set; }
        public string location { get; set; }
    }
}
