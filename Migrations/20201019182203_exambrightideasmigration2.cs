using Microsoft.EntityFrameworkCore.Migrations;

namespace Exam.Migrations
{
    public partial class exambrightideasmigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Idea_users_UserId",
                table: "Idea");

            migrationBuilder.DropForeignKey(
                name: "FK_Like_Idea_IdeaId",
                table: "Like");

            migrationBuilder.DropForeignKey(
                name: "FK_Like_users_UserId",
                table: "Like");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Like",
                table: "Like");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Idea",
                table: "Idea");

            migrationBuilder.RenameTable(
                name: "Like",
                newName: "likes");

            migrationBuilder.RenameTable(
                name: "Idea",
                newName: "ideas");

            migrationBuilder.RenameIndex(
                name: "IX_Like_UserId",
                table: "likes",
                newName: "IX_likes_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Like_IdeaId",
                table: "likes",
                newName: "IX_likes_IdeaId");

            migrationBuilder.RenameIndex(
                name: "IX_Idea_UserId",
                table: "ideas",
                newName: "IX_ideas_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_likes",
                table: "likes",
                column: "LikeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ideas",
                table: "ideas",
                column: "IdeaId");

            migrationBuilder.AddForeignKey(
                name: "FK_ideas_users_UserId",
                table: "ideas",
                column: "UserId",
                principalTable: "users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_likes_ideas_IdeaId",
                table: "likes",
                column: "IdeaId",
                principalTable: "ideas",
                principalColumn: "IdeaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_likes_users_UserId",
                table: "likes",
                column: "UserId",
                principalTable: "users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ideas_users_UserId",
                table: "ideas");

            migrationBuilder.DropForeignKey(
                name: "FK_likes_ideas_IdeaId",
                table: "likes");

            migrationBuilder.DropForeignKey(
                name: "FK_likes_users_UserId",
                table: "likes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_likes",
                table: "likes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ideas",
                table: "ideas");

            migrationBuilder.RenameTable(
                name: "likes",
                newName: "Like");

            migrationBuilder.RenameTable(
                name: "ideas",
                newName: "Idea");

            migrationBuilder.RenameIndex(
                name: "IX_likes_UserId",
                table: "Like",
                newName: "IX_Like_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_likes_IdeaId",
                table: "Like",
                newName: "IX_Like_IdeaId");

            migrationBuilder.RenameIndex(
                name: "IX_ideas_UserId",
                table: "Idea",
                newName: "IX_Idea_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Like",
                table: "Like",
                column: "LikeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Idea",
                table: "Idea",
                column: "IdeaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Idea_users_UserId",
                table: "Idea",
                column: "UserId",
                principalTable: "users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Like_Idea_IdeaId",
                table: "Like",
                column: "IdeaId",
                principalTable: "Idea",
                principalColumn: "IdeaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Like_users_UserId",
                table: "Like",
                column: "UserId",
                principalTable: "users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
