using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace School.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PictureUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CourseId", "CreatedBy", "CreatedDate", "Description", "Duration", "ModifiedBy", "ModifiedDate", "Name", "PictureUrl" },
                values: new object[,]
                {
                    { new Guid("3f6195e3-1a8e-4308-984b-d6d95ba14d02"), new Guid("0fc756c7-84ac-4de1-9807-e9dcafefd1fb"), "Admin", new DateTimeOffset(new DateTime(2023, 7, 26, 14, 32, 53, 440, DateTimeKind.Unspecified).AddTicks(2251), new TimeSpan(0, 0, 0, 0, 0)), "App Services in Azure for Beginners", 9, "Admin", new DateTimeOffset(new DateTime(2023, 7, 26, 14, 32, 53, 440, DateTimeKind.Unspecified).AddTicks(2251), new TimeSpan(0, 0, 0, 0, 0)), "App Services in Azure", "https://stforeshop.blob.core.windows.net/coursesimages/AppServicesinAzure.PNG" },
                    { new Guid("84ae2acc-f092-46a7-95a5-2f90a9e5d079"), new Guid("c2f50997-de2e-4f2b-9b77-ce4c0fc3a1c4"), "Admin", new DateTimeOffset(new DateTime(2023, 7, 26, 14, 32, 53, 440, DateTimeKind.Unspecified).AddTicks(2249), new TimeSpan(0, 0, 0, 0, 0)), "gRPC in .NET 7 for Beginners", 5, "Admin", new DateTimeOffset(new DateTime(2023, 7, 26, 14, 32, 53, 440, DateTimeKind.Unspecified).AddTicks(2249), new TimeSpan(0, 0, 0, 0, 0)), "gRPC in .NET 7", "https://stforeshop.blob.core.windows.net/coursesimages/gRPCin_NET7.PNG" },
                    { new Guid("b9389e31-00be-4e7e-869d-cba82845ee30"), new Guid("4fb643a0-201a-4a3b-8c04-ed980b749975"), "Admin", new DateTimeOffset(new DateTime(2023, 7, 26, 14, 32, 53, 440, DateTimeKind.Unspecified).AddTicks(2244), new TimeSpan(0, 0, 0, 0, 0)), "Minimal API in .NET 7 for Beginners", 3, "Admin", new DateTimeOffset(new DateTime(2023, 7, 26, 14, 32, 53, 440, DateTimeKind.Unspecified).AddTicks(2244), new TimeSpan(0, 0, 0, 0, 0)), "Minimal API in .NET 7", "https://stforeshop.blob.core.windows.net/coursesimages/MinimalAPIin_NET7.PNG" },
                    { new Guid("bb069472-87e0-4661-a7de-daedd1924d7e"), new Guid("7afecaa0-206e-45c7-8681-24d8309952d3"), "Admin", new DateTimeOffset(new DateTime(2023, 7, 26, 14, 32, 53, 440, DateTimeKind.Unspecified).AddTicks(2246), new TimeSpan(0, 0, 0, 0, 0)), "Blazor WASM in .NET 7 for Beginners", 5, "Admin", new DateTimeOffset(new DateTime(2023, 7, 26, 14, 32, 53, 440, DateTimeKind.Unspecified).AddTicks(2247), new TimeSpan(0, 0, 0, 0, 0)), "Blazor WASM in .NET 7", "https://stforeshop.blob.core.windows.net/coursesimages/BlazorWASMin_NET7.PNG" },
                    { new Guid("ff0dc0b9-b8dc-4615-b9ec-7ca64183c532"), new Guid("bbeea0a9-c9fc-46ae-9f86-0710e76d75d9"), "Admin", new DateTimeOffset(new DateTime(2023, 7, 26, 14, 32, 53, 440, DateTimeKind.Unspecified).AddTicks(2228), new TimeSpan(0, 0, 0, 0, 0)), "Web API in .NET 7 for Beginners", 3, "Admin", new DateTimeOffset(new DateTime(2023, 7, 26, 14, 32, 53, 440, DateTimeKind.Unspecified).AddTicks(2229), new TimeSpan(0, 0, 0, 0, 0)), "Web API in .NET 7", "https://stforeshop.blob.core.windows.net/coursesimages/WebAPIin_NET7.PNG" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Courses");
        }
    }
}
