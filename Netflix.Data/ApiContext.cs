using System;
using Microsoft.EntityFrameworkCore;

namespace Netflix.Data
{
    public class ApiContext : DbContext
    {
        public ApiContext (DbContextOptions<ApiContext> options) : base(options){ }
    }
}
