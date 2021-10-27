using System.Net.NetworkInformation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DotnetBakery.Models;
using Microsoft.EntityFrameworkCore;

namespace DotnetBakery.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // localhost:5000/api/breads
    public class BreadsController : ControllerBase
    {
        private readonly ApplicationContext _context;
        public BreadController(ApplicationContext context) {
            _context = context;
        }
    }
}
