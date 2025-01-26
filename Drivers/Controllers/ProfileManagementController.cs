using AutoMapper;
using Drivers.Data;
using Drivers.Models.DTO_s.Profile;
using Drivers.Service;
using Microsoft.AspNetCore.Mvc;
namespace Drivers.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfileManagementController : ControllerBase
    {
        private readonly ILogger<ProfileManagementController> _logger;
        private readonly ApiDbContext _context;
        private readonly IMapper _mapper;
        private readonly IUserProfileService _userProfileService;
        public ProfileManagementController(
            ILogger<ProfileManagementController> logger,
            ApiDbContext context,
             IMapper mapper,
            IUserProfileService userProfileService
            )
        {
            _logger = logger;
            _context = context;
            _mapper = mapper;
            _userProfileService = userProfileService;
        }

        [HttpGet]
        [Route("GetAllUserProfiles")]

        public async Task<IActionResult> GetAllUserProfile()
        {
            var userProfiles = await _userProfileService.GetAllUsersAsync();

            if (userProfiles != null)
            {
                return Ok(userProfiles);

            }

            return BadRequest("There is no user profile");
        }


        //[HttpGet]
        //public async Task<IActionResult> 
        //{

        //}

        //[HttpPost]
        //[Route("CreateProfile")]
        //public async Task<ActionResult<object>> CreateProfile([FromBody] UserCreateProfileRequest requestDto)
        //{

        //    var user = _mapper.Map<UserCreateProfileRequest>(requestDto);
        //    if (user !=null)
        //    {
        //     await _userRepository.CreateUserAsync(user);   
        //    }
            
        //    //await _repository.SaveChangesAsync();

        //    //var readDto = _mapper.Map<UserReadDto>(user);
        //    //return CreatedAtAction(nameof(GetUserById), new { id = user.Id }, readDto);
        //    return BadRequest();
        //}

        [HttpPut]
        [Route("UpdateProfile")]

        public async Task<IActionResult> UpdateUsersProfile(int id, [FromBody] UserCreateProfileRequest requestDto)
        {

            return NoContent();
        }


    }

}
