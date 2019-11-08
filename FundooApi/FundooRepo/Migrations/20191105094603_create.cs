using Microsoft.EntityFrameworkCore.Migrations;

namespace FundooRepo.Migrations
{
    public partial class create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Label_UserDetail_Email",
                table: "Label");

            migrationBuilder.DropIndex(
                name: "IX_Label_Email",
                table: "Label");

            migrationBuilder.AddColumn<string>(
                name: "CardType",
                table: "UserDetail",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Label",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CardType",
                table: "UserDetail");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Label",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Label_Email",
                table: "Label",
                column: "Email");

            migrationBuilder.AddForeignKey(
                name: "FK_Label_UserDetail_Email",
                table: "Label",
                column: "Email",
                principalTable: "UserDetail",
                principalColumn: "Email",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
