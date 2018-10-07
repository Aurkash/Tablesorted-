using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JqueryFilters.Models;

namespace JqueryFilters.Factory
{
    public static class ApplicantFactory
    {
        public static IEnumerable<ApplicantModel> GetApplicantList()
        {
            var applicant = new List<ApplicantModel>();
            applicant.Add(new ApplicantModel
            {
                FirstName = "Joe",
                LastName = "Bloggs",
                DateModified = DateTime.Now,
                Status = ApplicantStatus.UnAuthorised,
                Applications = new Application[]
                {
                    new Application
                    {
                        Id = Guid.NewGuid(),
                        ProviderName = "Birmingham Uni",
                        Status = ApplicantionStatus.NotSubmitted
                    },
                    new Application
                    {
                    Id = Guid.NewGuid(),
                    ProviderName = "Ashton Uni",
                    Status = ApplicantionStatus.OffereRejected
                    },
                    new Application
                    {
                        Id = Guid.NewGuid(),
                        ProviderName = "Bath Uni",
                        Status = ApplicantionStatus.NotSubmitted
                    },
                    new Application
                    {
                        Id = Guid.NewGuid(),
                        ProviderName = "Bristol Uni",
                        Status = ApplicantionStatus.OffereRejected
                    }
                }
            });

            applicant.Add(new ApplicantModel
            {
                FirstName = "Max",
                LastName = "Smith",
                DateModified = DateTime.Now.AddDays(-2),
                Status = ApplicantStatus.Rejected,
                Applications = new Application[]
                {
                    new Application
                    {
                        Id = Guid.NewGuid(),
                        ProviderName = "London Uni",
                        Status = ApplicantionStatus.NotSubmitted
                    },
                    new Application
                    {
                        Id = Guid.NewGuid(),
                        ProviderName = "Ashton Uni",
                        Status = ApplicantionStatus.Closed
                    },
                    new Application
                    {
                    Id = Guid.NewGuid(),
                    ProviderName = "Bath Uni",
                    Status = ApplicantionStatus.Offered
                    }
                }
            });


            applicant.Add(new ApplicantModel
            {
                FirstName = "David",
                LastName = "Bloggs",
                DateModified = DateTime.Now.AddMonths(-1),
                Status = ApplicantStatus.Authorised,
                Applications = new Application[]
                {
                    new Application
                    {
                        Id = Guid.NewGuid(),
                        ProviderName = "Liverpool Uni",
                        Status = ApplicantionStatus.OfferAccepted
                    },
                    new Application
                    {
                        Id = Guid.NewGuid(),
                        ProviderName = "Ashton Uni",
                        Status = ApplicantionStatus.OffereRejected
                    }
                }
            });


            applicant.Add(new ApplicantModel
            {
                FirstName = "Joe",
                LastName = "Smith",
                DateModified = DateTime.Now,
                Status = ApplicantStatus.UnAuthorised,
                Applications = new Application[]
                {
                    new Application
                    {
                        Id = Guid.NewGuid(),
                        ProviderName = "Birmingham Uni",
                        Status = ApplicantionStatus.NotSubmitted
                    },
                    new Application
                    {
                        Id = Guid.NewGuid(),
                        ProviderName = "London Uni",
                        Status = ApplicantionStatus.OffereRejected
                    }
                }
            });

            return applicant;
        }
    }
}
