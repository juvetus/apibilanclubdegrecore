﻿using Microsoft.EntityFrameworkCore;

namespace ApiBilanClubDegre.Models
{
    public class DataContext :DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base (options) { }

        public DbSet<Question> Questions =>  Set<Question>();
    }
}
