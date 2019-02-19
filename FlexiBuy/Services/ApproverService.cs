using FlexiBuy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlexiBuy.Services
{
    public class ApproverService : IApproverService
    {
        public string GetApproverName(int approverId)
        {
            return "John Snow";
        }

        public ApproverDetails GetApproverDetails(int approverId)
        {
            return new ApproverDetails
            {
                ApproverId= 102,
                Department = "Sales",
                Email = "approver1@flexibuy.com",
                FirstName = "John",
                LastName = "Snow",
                Role= "Manager"

            };
        }
    }
}
