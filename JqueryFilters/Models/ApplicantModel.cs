using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JqueryFilters.Models
{
    public class ApplicantModel
    {
        public string FirstName { get; set; }

        public string LastName
        {
            get; set;

        }
        public  DateTime DateModified { get; set; }

        public ApplicantStatus Status { get; set; }

        public IEnumerable<Application> Applications { get; set; }

    }

    public class Application
    {
        public Guid Id
        {
            get; set;

        }

        public string ProviderName { get; set; }

        public ApplicantionStatus Status { get; set; }
    }


    public enum ApplicantStatus
    {
        UnAuthorised,
        Authorised,
        Rejected
    }
    public enum ApplicantionStatus
    {
        
        NotSubmitted,
        Submitted,
        Rejected,
        Cancelled,
        Offered,
        OfferAccepted,
        OffereRejected,
        Closed
    }
}
