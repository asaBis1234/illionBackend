using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Illion0.Migrations
{
    public partial class AddAccountListModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CustomerAccounts",
                columns: table => new
                {
                    TaxPayerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    institution = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    user_token = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    referral_code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dataRequestLink = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerAccounts", x => x.TaxPayerId);
                });

            migrationBuilder.CreateTable(
                name: "CustomerAccount",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountHolder = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    accountNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bsb = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    balance = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    available = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    accountHolderType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    accountType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    interestRate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountsTaxPayerId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerAccount", x => x.id);
                    table.ForeignKey(
                        name: "FK_CustomerAccount_CustomerAccounts_AccountsTaxPayerId",
                        column: x => x.AccountsTaxPayerId,
                        principalTable: "CustomerAccounts",
                        principalColumn: "TaxPayerId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAccount_AccountsTaxPayerId",
                table: "CustomerAccount",
                column: "AccountsTaxPayerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerAccount");

            migrationBuilder.DropTable(
                name: "CustomerAccounts");
        }
    }
}
