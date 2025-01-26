using AutoMapper;
using Drivers.Models.DTO_s.Profile;
using Drivers.Models.DTO_s.Users;
using Drivers.Service;
using Microsoft.AspNetCore.Mvc;


namespace Drivers.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ProfileManagementController : ControllerBase
    {

        private readonly IMapper _mapper;

        private readonly IUserProfileService _userProfileService;


        public ProfileManagementController(
             IMapper mapper,
            IUserProfileService userProfileService

            )
        {

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


        [HttpGet]
        [Route("GetUserProfileById")]

        public async Task<IActionResult> GetUserProfileByIdAsync([FromQuery] int id)
        {
            {
                var userProfiles = await _userProfileService.GetUserProfileByIdAsync(id);

                if (userProfiles != null)
                {
                    return Ok(_mapper.Map<UserServiceModel>(userProfiles));

                }

                return BadRequest("There is no user profile");
            }

        }

        [HttpPost]
        [Route("CreateUserProfile")]
        public async Task<IActionResult> CreateUserProfile([FromBody] UserCreateDto profile)
        {
            var users = _mapper.Map<UserCreateDto>(profile);

            if (ModelState.IsValid)
            {
                var user = _mapper.Map<UserServiceModel>(profile);
                await _userProfileService.CreateUserProfileAsync(user);

                var success = _mapper.Map<UserProfileRequestResponce>(profile);

                return Ok(success);
            }

            return BadRequest(ModelState);
        }

        //[HttpPost]
        //[Route("CreateUserProfile")]
        //public async Task<ActionResult> CreateUserProfile([FromBody] UserCreateProfileRequest requestDto)
        //{
        //if (ModelState.IsValid)
        //{
        //    var existingUser = await _context.Profiles.FindAsync(requestDto);
        //}
        //var user = _mapper.Map<UserCreateProfileRequest>(requestDto);
        //    await _userProfileService.CreateUserProfileAsync(user);
        //    return BadRequest();
        //}

        //[HttpPut]
        //[Route("UpdateProfile")]

        //public async Task<IActionResult> UpdateUsersProfile(int id, [FromBody] UserCreateProfileRequest requestDto)
        //{

        //    return NoContent();
        //}
    }
}
