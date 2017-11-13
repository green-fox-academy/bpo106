using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using BusListManager.Entities;

namespace BusListManager.Migrations
{
    [DbContext(typeof(ListContext))]
    partial class ListContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BusListManager.Models.Bus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Comments");

                    b.Property<DateTime>("DateOfGet");

                    b.Property<DateTime>("DateOfWithdrawal");

                    b.Property<string>("Depot");

                    b.Property<string>("FormerLicensePlate");

                    b.Property<int>("FormerNumber");

                    b.Property<bool>("IsInOperation");

                    b.Property<int>("Kilometer");

                    b.Property<string>("LicensePlate");

                    b.Property<int>("Number");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.ToTable("List");
                });
        }
    }
}
