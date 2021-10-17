using AppDevGCD0805.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppDevGCD0805.Data.Configurations
{
	public class TraineeCourseConfigurations: IEntityTypeConfiguration<AssignTraineeCourse>
	{
      public void Configure(EntityTypeBuilder<AssignTraineeCourse> builder)
      {
         builder.ToTable("AssignTraineeCourses");
         builder.HasKey(x => new { x.UserId, x.CourseId });

         builder.HasOne(x => x.TraineeProfile).WithMany(x => x.AssignTraineeCourses).HasForeignKey(x => x.UserId);
         builder.HasOne(x => x.Course).WithMany(x => x.AssignTraineeCourses).HasForeignKey(x => x.CourseId);
      }
   }
}
