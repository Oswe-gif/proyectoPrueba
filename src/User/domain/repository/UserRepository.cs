using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.src.User.domain.entity;

namespace backend.src.User.domain.repository
{
    public interface UserRepository
    {
        Task<List<UserEntity>> GetAllAsync();
        // Task<UserEntity> CreateAsync(UserEntity user);
        // Task<UserEntity?> DeleteAsync(int id);

    }
}