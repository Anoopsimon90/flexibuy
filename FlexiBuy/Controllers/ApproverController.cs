using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlexiBuy.Models;
using FlexiBuy.Services;
using Microsoft.AspNetCore.Mvc;

namespace FlexiBuy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApproverController : ControllerBase
    {
        readonly IApproverService _approverService;
        public ApproverController()
        {
            _approverService = new ApproverService();
        }
       
        // GET api/Approve/5
        [HttpGet("{id}")]
        public ActionResult<ApproverDetails> GetApproverDetail(int approverId)
        {
            return _approverService.GetApproverDetails(approverId);
        }

    }
}
