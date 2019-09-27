﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReadFileAndSaveDataToDBServer.DataAccess.Concrete.EntityFrameworkCore.Contexts;

namespace ReadFileAndSaveDataToDBServer.Migrations
{
    [DbContext(typeof(DbBallcockData))]
    partial class DbBallcockDataModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ReadFileAndSaveDataToDBServer.DataAccess.Entities.Concrete.Adcp", b =>
                {
                    b.Property<int>("Id");

                    b.Property<int>("BallcockId");

                    b.Property<string>("DateTime");

                    b.Property<int>("ProfileNo");

                    b.Property<decimal>("V1");

                    b.Property<decimal>("V10");

                    b.Property<decimal>("V11");

                    b.Property<decimal>("V2");

                    b.Property<decimal>("V3");

                    b.Property<decimal>("V4");

                    b.Property<decimal>("V5");

                    b.Property<decimal>("V6");

                    b.Property<decimal>("V7");

                    b.Property<decimal>("V8");

                    b.Property<decimal>("V9");

                    b.Property<string>("VDT");

                    b.HasKey("Id");

                    b.HasIndex("BallcockId");

                    b.ToTable("Adcps");
                });

            modelBuilder.Entity("ReadFileAndSaveDataToDBServer.DataAccess.Entities.Concrete.AdcpDetail", b =>
                {
                    b.Property<int>("Id");

                    b.Property<int>("AdcpId");

                    b.Property<int>("V1");

                    b.Property<int>("V2");

                    b.Property<int>("V3");

                    b.HasKey("Id");

                    b.HasIndex("AdcpId");

                    b.ToTable("AdcpDetails");
                });

            modelBuilder.Entity("ReadFileAndSaveDataToDBServer.DataAccess.Entities.Concrete.Ballcock", b =>
                {
                    b.Property<int>("Id");

                    b.Property<int>("BallcockNo");

                    b.HasKey("Id");

                    b.ToTable("Ballcocks");
                });

            modelBuilder.Entity("ReadFileAndSaveDataToDBServer.DataAccess.Entities.Concrete.Adcp", b =>
                {
                    b.HasOne("ReadFileAndSaveDataToDBServer.DataAccess.Entities.Concrete.Ballcock", "Ballcock")
                        .WithMany()
                        .HasForeignKey("BallcockId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ReadFileAndSaveDataToDBServer.DataAccess.Entities.Concrete.AdcpDetail", b =>
                {
                    b.HasOne("ReadFileAndSaveDataToDBServer.DataAccess.Entities.Concrete.Adcp", "Adcp")
                        .WithMany()
                        .HasForeignKey("AdcpId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
