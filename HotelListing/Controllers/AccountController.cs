using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using HotelListing.Data;
using HotelListing.IRepository;
using HotelListing.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HotelListing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<ApiUser> _userManager;
        private readonly SignInManager<ApiUser> _signInManager;
        private readonly ILogger<AccountController> _logger;
        private readonly IMapper _mapper;

        public AccountController(UserManager<ApiUser> userManager,
            SignInManager<ApiUser> signInManager,
            ILogger<AccountController> logger,
            IMapper mapper)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _mapper = mapper;
        }

        //[HttpPost]
        //public async Task<IActionResult> Register([FromBody] UserDTO userDTO)
        //{
        //    _logger.LogInformation($"RegistrationAttempt for {userDTO.Email}");
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }
        //    try
        //    {
        //        var user = _mapper.Map<ApiUser>(userDTO);
        //        var result = await _userManager.CreateAsync(user);

        //        if (!result.Succeeded)
        //        {
        //            return BadRequest($"User Registration Attempt Failed");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogInformation($"Something went wrong in the {nameof(Register)}");
        //        return Problem($"Something went wrong in the {nameof(Register)}", statusCode:500);
        //    }
        //}
    }
}