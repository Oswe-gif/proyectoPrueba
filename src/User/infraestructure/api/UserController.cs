using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Data;
using backend.src.User.application.mappers;
using backend.src.User.application.service;
using backend.src.User.domain.repository;
using Microsoft.AspNetCore.Mvc;

namespace backend.src.User.infraestructure.api
{
    [Route("api/user")]
    [ApiController]
    public class UserController: ControllerBase
    {
        private UserRepository _userService;

        
        public UserController(UserRepository userRepository)
        {
            _userService = userRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var users = await _userService.GetAllAsync();
            var usersList = users.Select(i => i.ToUserDto());
            return Ok(usersList);
        }

        // [HttpPost]
        // [Route("{id}")]
        // public async Task<IActionResult> Create([FromBody] CreateUserDto user)
        // {
            
        // }

        // [HttpDelete]
        // [Route("{id}")]
        // public async Task<IActionResult> Delete([FromRoute] int id)
        // {
            
        // }
    }
}