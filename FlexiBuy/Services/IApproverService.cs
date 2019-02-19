using FlexiBuy.Models;

namespace FlexiBuy.Services
{
    public interface IApproverService
    {
        ApproverDetails GetApproverDetails(int approverId);
        string GetApproverName(int approverId);
    }
}