using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Data;
using backend.src.User.application.mappers;
using backend.src.User.domain.dto;
using backend.src.User.domain.entity;
using backend.src.User.domain.repository;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend.src.User.application.service
{
    public class UserService: UserRepository
    {
        private readonly ApplicationDBContext _context;

        public UserService(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<List<UserEntity>> GetAllAsync()
        {
            return await _context.User.ToListAsync();
        }

    }
}