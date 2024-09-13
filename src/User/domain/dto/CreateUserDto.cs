using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.src.User.domain.dto
{
    public class CreateUserDto
    {
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
    }
}