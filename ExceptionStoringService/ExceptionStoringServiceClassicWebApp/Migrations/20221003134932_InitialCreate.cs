using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExceptionStoringServiceClassicWebApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppInfos",
                columns: table => new
                {
                    AppInfoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AppName = table.Column<string>(type: "TEXT", nullable: false),
                    AppGUID = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppInfos", x => x.AppInfoId);
                });

            migrationBuilder.CreateTable(
                name: "AppVersions",
                columns: table => new
                {
                    AppVersionId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AppVersionName = table.Column<string>(type: "TEXT", nullable: false),
                    AppInfoId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppVersions", x => x.AppVersionId);
                    table.ForeignKey(
                        name: "FK_AppVersions_AppInfos_AppInfoId",
                        column: x => x.AppInfoId,
                        principalTable: "AppInfos",
                        principalColumn: "AppInfoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExptionsDatas",
                columns: table => new
                {
                    ExeptionDataId = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ExeptionType = table.Column<string>(type: "TEXT", nullable: true),
                    ExeptionStackTrase = table.Column<string>(type: "TEXT", nullable: true),
                    StackTraseHash = table.Column<int>(type: "INTEGER", nullable: false),
                    SeriaizedData = table.Column<string>(type: "TEXT", nullable: true),
                    SeriaizedDataHash = table.Column<int>(type: "INTEGER", nullable: false),
                    HResult = table.Column<int>(type: "INTEGER", nullable: true),
                    InnerExeptioId = table.Column<int>(type: "INTEGER", nullable: true),
                    Message = table.Column<string>(type: "TEXT", nullable: true),
                    MessageHash = table.Column<int>(type: "INTEGER", nullable: false),
                    Source = table.Column<string>(type: "TEXT", nullable: true),
                    SourceHash = table.Column<int>(type: "INTEGER", nullable: false),
                    StackTrace = table.Column<string>(type: "TEXT", nullable: true),
                    StackTraceHash = table.Column<int>(type: "INTEGER", nullable: false),
                    InnerExeptionId = table.Column<int>(type: "INTEGER", nullable: false),
                    TargetSite = table.Column<string>(type: "TEXT", nullable: true),
                    TargetSiteHash = table.Column<int>(type: "INTEGER", nullable: true),
                    AppId = table.Column<int>(type: "INTEGER", nullable: false),
                    AppVersionId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExptionsDatas", x => x.ExeptionDataId);
                    table.ForeignKey(
                        name: "FK_ExptionsDatas_AppInfos_AppId",
                        column: x => x.AppId,
                        principalTable: "AppInfos",
                        principalColumn: "AppInfoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExptionsDatas_AppVersions_AppVersionId",
                        column: x => x.AppVersionId,
                        principalTable: "AppVersions",
                        principalColumn: "AppVersionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppVersions_AppInfoId",
                table: "AppVersions",
                column: "AppInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_ExptionsDatas_AppId",
                table: "ExptionsDatas",
                column: "AppId");

            migrationBuilder.CreateIndex(
                name: "IX_ExptionsDatas_AppVersionId",
                table: "ExptionsDatas",
                column: "AppVersionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExptionsDatas");

            migrationBuilder.DropTable(
                name: "AppVersions");

            migrationBuilder.DropTable(
                name: "AppInfos");
        }
    }
}
