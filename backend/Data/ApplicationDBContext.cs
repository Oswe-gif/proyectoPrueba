using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.src.User.domain.entity;
using Microsoft.EntityFrameworkCore;

namespace backend.Data
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions): base(dbContextOptions)
        {
            
        }
        //
        public DbSet<UserEntity> User { get; set; }
    }
}