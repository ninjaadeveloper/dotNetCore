using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseApp.Migrations
{
    /// <inheritdoc />
    public partial class std : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_students",
                columns: table => new
                {
                    sid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sname = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    semail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sbatch = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_students", x => x.sid);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_students");
        }
    }
}
