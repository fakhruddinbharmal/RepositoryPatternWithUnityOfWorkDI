﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using RepositoryPatternWithUnitOfWorkDI.Core.Data;

namespace RepositoryPatternWithUnityOfWorkDI.Data.Mapping;
{
    public class BookMap : EntityTypeConfiguration<Book>
    {
        public BookMap()
        {
            HasKey(t => t.ID);
            Property(t => t.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.Title).IsRequired();
            Property(t => t.Author).IsRequired();
            Property(t => t.ISBN).IsRequired();
            Property(t => t.Published).IsRequired();
            ToTable("Books");
        }
    }
}