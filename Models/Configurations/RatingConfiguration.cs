﻿using Diary.Models.Domains;
using System.Data.Entity.ModelConfiguration;


namespace Diary.Models.Configurations
{
    public class RatingConfiguration : EntityTypeConfiguration<Rating>
    {
        public RatingConfiguration()
        {
            ToTable("dbp.Ratings");

            HasKey(x => x.Id);
        }
    }
}
