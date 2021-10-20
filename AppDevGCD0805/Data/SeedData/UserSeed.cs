using AppDevGCD0805.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppDevGCD0805.Data.SeedData
{
    public static class UserSeed
    {
        public static void Seed(this ModelBuilder builder)
        {
            #region RoleData

            var adminRole = new IdentityRole()
            {
                Name = "Admin",
                NormalizedName = "ADMIN",
            };
            var staffRole = new IdentityRole()
            {
                Name = "Staff",
                NormalizedName = "STAFF",
            };
            var trainerRole = new IdentityRole()
            {
                Name = "Trainer",
                NormalizedName = "TRAINER",
            };
            var traineeRole = new IdentityRole()
            {
                Name = "Trainee",
                NormalizedName = "TRAINEE",
            };

            builder.Entity<IdentityRole>().HasData(
                adminRole,
                staffRole,
                trainerRole,
                traineeRole
                );

            #endregion RoleData

            #region UserData

            var hasher = new PasswordHasher<User>();
            var admin = new User()
            {
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                FullName = "Le Trung Kien",
                Email = "admin@gmail.com",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "admin@123"),
            };
            var staff = new User()
            {
                UserName = "staff",
                FullName = "Le Tran Thai Tuan",
                Email = "staff@gmail.com",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "staff@123"),
            };
            builder.Entity<User>().HasData(
                admin,
                staff
                );

            #endregion UserData

            #region UserRole

            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string> { UserId = admin.Id, RoleId = adminRole.Id },
                new IdentityUserRole<string> { UserId = staff.Id, RoleId = staffRole.Id }
                );

            #endregion UserRole
        }
    }
}
