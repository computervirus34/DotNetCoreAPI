using DAL.Interfaces;
using DAL.Models;
using DAL.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        private IMember members = new MembersRepository();

        [HttpGet]
        public ActionResult<IEnumerable<Member>> GetAllMembers()
        {
            return members.GetAllMember();
        }

        [Route("[[id]]")]
        [HttpGet]
        public ActionResult<Member> GetMemberById(int id)
        {
            return members.GetMember(id);
        }
    }
}
