using AppDevGCD0805.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppDevGCD0805.Data.Configurations
{
	
   public class TrainerCourseConfigurations : IEntityTypeConfiguration<AssignTrainerCourse>
   {
      public void Configure(EntityTypeBuilder<AssignTrainerCourse> builder)
      {
         builder.ToTable("AssignTrainerCourses");
         builder.HasKey(x => new { x.UserId, x.CourseId });

         builder.HasOne(x => x.TrainerProfile).WithMany(x => x.AssignTrainerCourses).HasForeignKey(x => x.UserId);
         builder.HasOne(x => x.Course).WithMany(x => x.AssignTrainerCourses).HasForeignKey(x => x.CourseId);
      }
   }
}
