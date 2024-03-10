using Microsoft.EntityFrameworkCore.Migrations;

namespace TestQuest.Migrations
{
    public partial class EmployCorrect : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Letters_Employes_FromWhomId",
                table: "Letters");

            migrationBuilder.DropForeignKey(
                name: "FK_Letters_Employes_ToWhomId",
                table: "Letters");

            migrationBuilder.DropIndex(
                name: "IX_Letters_FromWhomId",
                table: "Letters");

            migrationBuilder.DropIndex(
                name: "IX_Letters_ToWhomId",
                table: "Letters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employes",
                table: "Employes");

            migrationBuilder.DropColumn(
                name: "FromWhomId",
                table: "Letters");

            migrationBuilder.DropColumn(
                name: "ToWhomId",
                table: "Letters");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Employes");

            migrationBuilder.AddColumn<string>(
                name: "FromWhomEmployeName",
                table: "Letters",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ToWhomEmployeName",
                table: "Letters",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmployeName",
                table: "Employes",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employes",
                table: "Employes",
                column: "EmployeName");

            migrationBuilder.CreateIndex(
                name: "IX_Letters_FromWhomEmployeName",
                table: "Letters",
                column: "FromWhomEmployeName");

            migrationBuilder.CreateIndex(
                name: "IX_Letters_ToWhomEmployeName",
                table: "Letters",
                column: "ToWhomEmployeName");

            migrationBuilder.AddForeignKey(
                name: "FK_Letters_Employes_FromWhomEmployeName",
                table: "Letters",
                column: "FromWhomEmployeName",
                principalTable: "Employes",
                principalColumn: "EmployeName",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Letters_Employes_ToWhomEmployeName",
                table: "Letters",
                column: "ToWhomEmployeName",
                principalTable: "Employes",
                principalColumn: "EmployeName",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Letters_Employes_FromWhomEmployeName",
                table: "Letters");

            migrationBuilder.DropForeignKey(
                name: "FK_Letters_Employes_ToWhomEmployeName",
                table: "Letters");

            migrationBuilder.DropIndex(
                name: "IX_Letters_FromWhomEmployeName",
                table: "Letters");

            migrationBuilder.DropIndex(
                name: "IX_Letters_ToWhomEmployeName",
                table: "Letters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employes",
                table: "Employes");

            migrationBuilder.DropColumn(
                name: "FromWhomEmployeName",
                table: "Letters");

            migrationBuilder.DropColumn(
                name: "ToWhomEmployeName",
                table: "Letters");

            migrationBuilder.AddColumn<int>(
                name: "FromWhomId",
                table: "Letters",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ToWhomId",
                table: "Letters",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmployeName",
                table: "Employes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Employes",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employes",
                table: "Employes",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Letters_FromWhomId",
                table: "Letters",
                column: "FromWhomId");

            migrationBuilder.CreateIndex(
                name: "IX_Letters_ToWhomId",
                table: "Letters",
                column: "ToWhomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Letters_Employes_FromWhomId",
                table: "Letters",
                column: "FromWhomId",
                principalTable: "Employes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Letters_Employes_ToWhomId",
                table: "Letters",
                column: "ToWhomId",
                principalTable: "Employes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
