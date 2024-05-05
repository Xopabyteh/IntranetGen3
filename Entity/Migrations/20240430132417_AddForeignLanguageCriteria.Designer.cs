﻿// <auto-generated />
using System;
using MensaGymnazium.IntranetGen3.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MensaGymnazium.IntranetGen3.Entity.Migrations
{
    [DbContext(typeof(IntranetGen3DbContext))]
    [Migration("20240430132417_AddForeignLanguageCriteria")]
    partial class AddForeignLanguageCriteria
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Havit.Data.EntityFrameworkCore.Model.DataSeedVersion", b =>
                {
                    b.Property<string>("ProfileName")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Version")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProfileName")
                        .HasName("PK_DataSeed");

                    b.ToTable("__DataSeed", (string)null);
                });

            modelBuilder.Entity("MensaGymnazium.IntranetGen3.Model.Common.ApplicationSettings", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<DateTime?>("SubjectRegistrationAllowedFrom")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("SubjectRegistrationAllowedTo")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.ToTable("ApplicationSettings");
                });

            modelBuilder.Entity("MensaGymnazium.IntranetGen3.Model.EducationalArea", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("EducationalArea");

                    b
                        .HasAnnotation("Caching-AllKeysEnabled", true)
                        .HasAnnotation("Caching-EntitiesEnabled", true);
                });

            modelBuilder.Entity("MensaGymnazium.IntranetGen3.Model.EducationalAreaRelation", b =>
                {
                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.Property<int>("EducationalAreaId")
                        .HasColumnType("int");

                    b.HasKey("SubjectId", "EducationalAreaId");

                    b.HasIndex("EducationalAreaId");

                    b.ToTable("EducationalAreaRelation");

                    b
                        .HasAnnotation("Caching-AllKeysEnabled", true)
                        .HasAnnotation("Caching-EntitiesEnabled", true);
                });

            modelBuilder.Entity("MensaGymnazium.IntranetGen3.Model.Grade", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("AadGroupId")
                        .HasMaxLength(36)
                        .HasColumnType("nvarchar(36)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("RegistrationCriteriaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RegistrationCriteriaId");

                    b.ToTable("Grade");

                    b
                        .HasAnnotation("Caching-AllKeysEnabled", true)
                        .HasAnnotation("Caching-EntitiesEnabled", true);
                });

            modelBuilder.Entity("MensaGymnazium.IntranetGen3.Model.GradeRegistrationCriteria", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<bool>("CanUseForeignLanguageInsteadOfDonatedHours")
                        .HasColumnType("bit");

                    b.Property<int>("RequiredAmountOfDonatedHoursInAreaCspOrCp")
                        .HasColumnType("int");

                    b.Property<int>("RequiredTotalAmountOfDonatedHoursExcludingLanguage")
                        .HasColumnType("int");

                    b.Property<bool>("RequiresCspOrCpValidation")
                        .HasColumnType("bit");

                    b.Property<bool>("RequiresForeginLanguage")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("GradeRegistrationCriteria");

                    b
                        .HasAnnotation("Caching-AllKeysEnabled", true)
                        .HasAnnotation("Caching-EntitiesEnabled", true);
                });

            modelBuilder.Entity("MensaGymnazium.IntranetGen3.Model.GraduationSubject", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("GraduationSubject");

                    b
                        .HasAnnotation("Caching-AllKeysEnabled", true)
                        .HasAnnotation("Caching-EntitiesEnabled", true);
                });

            modelBuilder.Entity("MensaGymnazium.IntranetGen3.Model.GraduationSubjectRelation", b =>
                {
                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.Property<int>("GraduationSubjectId")
                        .HasColumnType("int");

                    b.HasKey("SubjectId", "GraduationSubjectId");

                    b.HasIndex("GraduationSubjectId");

                    b.ToTable("GraduationSubjectRelation");

                    b
                        .HasAnnotation("Caching-AllKeysEnabled", true)
                        .HasAnnotation("Caching-EntitiesEnabled", true);
                });

            modelBuilder.Entity("MensaGymnazium.IntranetGen3.Model.Security.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<int>("GradeId")
                        .HasColumnType("int");

                    b.Property<int?>("SeedEntityId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GradeId");

                    b.ToTable("Student");

                    b
                        .HasAnnotation("Caching-AllKeysEnabled", true)
                        .HasAnnotation("Caching-EntitiesEnabled", true);
                });

            modelBuilder.Entity("MensaGymnazium.IntranetGen3.Model.Security.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<string>("FunFact")
                        .HasMaxLength(2147483647)
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SeededEntityId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Teacher");

                    b
                        .HasAnnotation("Caching-AllKeysEnabled", true)
                        .HasAnnotation("Caching-EntitiesEnabled", true);
                });

            modelBuilder.Entity("MensaGymnazium.IntranetGen3.Model.Security.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(320)
                        .HasColumnType("nvarchar(320)");

                    b.Property<string>("Name")
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<Guid?>("Oid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("StudentId")
                        .HasColumnType("int");

                    b.Property<int?>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Oid")
                        .IsUnique()
                        .HasFilter("[Oid] IS NOT NULL");

                    b.HasIndex("StudentId")
                        .IsUnique()
                        .HasFilter("[StudentId] IS NOT NULL");

                    b.HasIndex("TeacherId")
                        .IsUnique()
                        .HasFilter("[TeacherId] IS NOT NULL");

                    b.ToTable("User");

                    b
                        .HasAnnotation("Caching-AllKeysEnabled", true)
                        .HasAnnotation("Caching-EntitiesEnabled", true);
                });

            modelBuilder.Entity("MensaGymnazium.IntranetGen3.Model.StudentSubjectRegistration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<int>("RegistrationType")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.HasIndex("SubjectId");

                    b.ToTable("StudentSubjectRegistration");
                });

            modelBuilder.Entity("MensaGymnazium.IntranetGen3.Model.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("CanRegisterRepeatedly")
                        .HasColumnType("bit");

                    b.Property<int?>("Capacity")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HoursPerWeek")
                        .HasColumnType("int");

                    b.Property<int>("MinStudentsToOpen")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("ScheduleDayOfWeek")
                        .HasColumnType("int");

                    b.Property<int>("ScheduleSlotInDay")
                        .HasColumnType("int");

                    b.Property<string>("SeedIdentifier")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Subject");

                    b
                        .HasAnnotation("Caching-AllKeysEnabled", true)
                        .HasAnnotation("Caching-EntitiesEnabled", true);
                });

            modelBuilder.Entity("MensaGymnazium.IntranetGen3.Model.SubjectCategory", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("SubjectCategory");

                    b
                        .HasAnnotation("Caching-AllKeysEnabled", true)
                        .HasAnnotation("Caching-EntitiesEnabled", true);
                });

            modelBuilder.Entity("MensaGymnazium.IntranetGen3.Model.SubjectGradeRelation", b =>
                {
                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.Property<int>("GradeId")
                        .HasColumnType("int");

                    b.HasKey("SubjectId", "GradeId");

                    b.HasIndex("GradeId");

                    b.ToTable("SubjectGradeRelation");
                });

            modelBuilder.Entity("MensaGymnazium.IntranetGen3.Model.SubjectTeacherRelation", b =>
                {
                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("SubjectId", "TeacherId");

                    b.HasIndex("TeacherId");

                    b.ToTable("SubjectTeacherRelation");
                });

            modelBuilder.Entity("MensaGymnazium.IntranetGen3.Model.EducationalAreaRelation", b =>
                {
                    b.HasOne("MensaGymnazium.IntranetGen3.Model.EducationalArea", "EducationalArea")
                        .WithMany()
                        .HasForeignKey("EducationalAreaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MensaGymnazium.IntranetGen3.Model.Subject", "Subject")
                        .WithMany("EducationalAreaRelations")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("EducationalArea");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("MensaGymnazium.IntranetGen3.Model.Grade", b =>
                {
                    b.HasOne("MensaGymnazium.IntranetGen3.Model.GradeRegistrationCriteria", "RegistrationCriteria")
                        .WithMany()
                        .HasForeignKey("RegistrationCriteriaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("RegistrationCriteria");
                });

            modelBuilder.Entity("MensaGymnazium.IntranetGen3.Model.GraduationSubjectRelation", b =>
                {
                    b.HasOne("MensaGymnazium.IntranetGen3.Model.GraduationSubject", "GraduationSubject")
                        .WithMany()
                        .HasForeignKey("GraduationSubjectId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MensaGymnazium.IntranetGen3.Model.Subject", "Subject")
                        .WithMany("GraduationSubjectRelations")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("GraduationSubject");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("MensaGymnazium.IntranetGen3.Model.Security.Student", b =>
                {
                    b.HasOne("MensaGymnazium.IntranetGen3.Model.Grade", "Grade")
                        .WithMany("Students")
                        .HasForeignKey("GradeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Grade");
                });

            modelBuilder.Entity("MensaGymnazium.IntranetGen3.Model.Security.User", b =>
                {
                    b.HasOne("MensaGymnazium.IntranetGen3.Model.Security.Student", "Student")
                        .WithOne("User")
                        .HasForeignKey("MensaGymnazium.IntranetGen3.Model.Security.User", "StudentId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("MensaGymnazium.IntranetGen3.Model.Security.Teacher", "Teacher")
                        .WithOne("User")
                        .HasForeignKey("MensaGymnazium.IntranetGen3.Model.Security.User", "TeacherId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Student");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("MensaGymnazium.IntranetGen3.Model.StudentSubjectRegistration", b =>
                {
                    b.HasOne("MensaGymnazium.IntranetGen3.Model.Security.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MensaGymnazium.IntranetGen3.Model.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("MensaGymnazium.IntranetGen3.Model.Subject", b =>
                {
                    b.HasOne("MensaGymnazium.IntranetGen3.Model.SubjectCategory", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("MensaGymnazium.IntranetGen3.Model.SubjectGradeRelation", b =>
                {
                    b.HasOne("MensaGymnazium.IntranetGen3.Model.Grade", "Grade")
                        .WithMany()
                        .HasForeignKey("GradeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MensaGymnazium.IntranetGen3.Model.Subject", "Subject")
                        .WithMany("GradeRelations")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Grade");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("MensaGymnazium.IntranetGen3.Model.SubjectTeacherRelation", b =>
                {
                    b.HasOne("MensaGymnazium.IntranetGen3.Model.Subject", "Subject")
                        .WithMany("TeacherRelations")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MensaGymnazium.IntranetGen3.Model.Security.Teacher", "Teacher")
                        .WithMany()
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Subject");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("MensaGymnazium.IntranetGen3.Model.Grade", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("MensaGymnazium.IntranetGen3.Model.Security.Student", b =>
                {
                    b.Navigation("User");
                });

            modelBuilder.Entity("MensaGymnazium.IntranetGen3.Model.Security.Teacher", b =>
                {
                    b.Navigation("User");
                });

            modelBuilder.Entity("MensaGymnazium.IntranetGen3.Model.Subject", b =>
                {
                    b.Navigation("EducationalAreaRelations");

                    b.Navigation("GradeRelations");

                    b.Navigation("GraduationSubjectRelations");

                    b.Navigation("TeacherRelations");
                });
#pragma warning restore 612, 618
        }
    }
}
