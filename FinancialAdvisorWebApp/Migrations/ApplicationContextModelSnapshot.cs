// <auto-generated />
using System;
using FinancialAdvisorWebApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FinancialAdvisorWebApp.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0-rc.2.20475.6");

            modelBuilder.Entity("FinancialAdvisorWebApp.Models.CHOICE", b =>
                {
                    b.Property<int>("ID_CHOIX")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CHOIX")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ID_QUESTION")
                        .HasColumnType("int");

                    b.Property<int?>("QUESTIONID_QUESTION")
                        .HasColumnType("int");

                    b.Property<int>("WEIGHT")
                        .HasColumnType("int");

                    b.HasKey("ID_CHOIX");

                    b.HasIndex("QUESTIONID_QUESTION");

                    b.ToTable("Choices");
                });

            modelBuilder.Entity("FinancialAdvisorWebApp.Models.FACIAL_EMOTIONS", b =>
                {
                    b.Property<int>("ID_FACE_EMOTION")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ID_INVEST")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VERSION")
                        .HasColumnType("int");

                    b.Property<float>("angry")
                        .HasColumnType("real");

                    b.Property<float>("deviation")
                        .HasColumnType("real");

                    b.Property<float>("disgust")
                        .HasColumnType("real");

                    b.Property<float>("happy")
                        .HasColumnType("real");

                    b.Property<float>("neutral")
                        .HasColumnType("real");

                    b.Property<float>("sad")
                        .HasColumnType("real");

                    b.Property<float>("scared")
                        .HasColumnType("real");

                    b.Property<float>("surprised")
                        .HasColumnType("real");

                    b.HasKey("ID_FACE_EMOTION");

                    b.ToTable("Facial_Emotions");
                });

            modelBuilder.Entity("FinancialAdvisorWebApp.Models.INVESTISSEUR", b =>
                {
                    b.Property<string>("ID_INVEST")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CODE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LASTNAME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NAME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("RISK")
                        .HasColumnType("real");

                    b.HasKey("ID_INVEST");

                    b.ToTable("Investisseurs");
                });

            modelBuilder.Entity("FinancialAdvisorWebApp.Models.QUESTION", b =>
                {
                    b.Property<int>("ID_QUESTION")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CODE_QUESTION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QUEST")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID_QUESTION");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("FinancialAdvisorWebApp.Models.QUESTIONNAIRE", b =>
                {
                    b.Property<int>("ID_QUESTIONNAIRE")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("CHOICEID_CHOIX")
                        .HasColumnType("int");

                    b.Property<string>("CODE_CHOIX")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ID_CHOIX")
                        .HasColumnType("int");

                    b.Property<string>("ID_INVEST")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VERSION")
                        .HasColumnType("int");

                    b.HasKey("ID_QUESTIONNAIRE");

                    b.HasIndex("CHOICEID_CHOIX");

                    b.ToTable("Questionnaires");
                });

            modelBuilder.Entity("FinancialAdvisorWebApp.Models.QUEST_INVEST", b =>
                {
                    b.Property<string>("ID_INVEST")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ID_QUESTIONNAIRE")
                        .HasColumnType("int");

                    b.HasKey("ID_INVEST", "ID_QUESTIONNAIRE");

                    b.HasIndex("ID_QUESTIONNAIRE");

                    b.ToTable("QUEST_INVEST");
                });

            modelBuilder.Entity("FinancialAdvisorWebApp.Models.SPEECH_EMOTIONS", b =>
                {
                    b.Property<int>("ID_SPEECH_EMOTION")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ID_INVEST")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VERSION")
                        .HasColumnType("int");

                    b.Property<string>("emotion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID_SPEECH_EMOTION");

                    b.ToTable("Speech_Emotions");
                });

            modelBuilder.Entity("FinancialAdvisorWebApp.Models.CHOICE", b =>
                {
                    b.HasOne("FinancialAdvisorWebApp.Models.QUESTION", "QUESTION")
                        .WithMany("CHOICES")
                        .HasForeignKey("QUESTIONID_QUESTION");
                });

            modelBuilder.Entity("FinancialAdvisorWebApp.Models.QUESTIONNAIRE", b =>
                {
                    b.HasOne("FinancialAdvisorWebApp.Models.CHOICE", "CHOICE")
                        .WithMany()
                        .HasForeignKey("CHOICEID_CHOIX");
                });

            modelBuilder.Entity("FinancialAdvisorWebApp.Models.QUEST_INVEST", b =>
                {
                    b.HasOne("FinancialAdvisorWebApp.Models.INVESTISSEUR", "INVESTISSEUR")
                        .WithMany("Quest_Invest")
                        .HasForeignKey("ID_INVEST")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FinancialAdvisorWebApp.Models.QUESTIONNAIRE", "QUESTIONNAIRE")
                        .WithMany("Quest_Invest")
                        .HasForeignKey("ID_QUESTIONNAIRE")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
