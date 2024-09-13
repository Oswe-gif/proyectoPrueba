using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.src.User.domain.dto;
using backend.src.User.domain.entity;

namespace backend.src.User.application.mappers
{
    public static class UserMappers
    {
        public static UserDto ToUserDto(this UserEntity user)
        {
            return new UserDto
            {
                Id = user.Id,
                Name = user.Name,
                Age = user.Age
            };
        }
    }
}