using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MaterialType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RecyclingFactory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecyclingFactory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RecyclingPoint",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecyclingPoint", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MaterialSubType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaterialTypeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialSubType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MaterialSubType_MaterialType_MaterialTypeId",
                        column: x => x.MaterialTypeId,
                        principalTable: "MaterialType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RecyclingFactoryRecyclingPoint",
                columns: table => new
                {
                    RecyclingFactoriesId = table.Column<int>(type: "int", nullable: false),
                    RecyclingPointsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecyclingFactoryRecyclingPoint", x => new { x.RecyclingFactoriesId, x.RecyclingPointsId });
                    table.ForeignKey(
                        name: "FK_RecyclingFactoryRecyclingPoint_RecyclingFactory_RecyclingFactoriesId",
                        column: x => x.RecyclingFactoriesId,
                        principalTable: "RecyclingFactory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RecyclingFactoryRecyclingPoint_RecyclingPoint_RecyclingPointsId",
                        column: x => x.RecyclingPointsId,
                        principalTable: "RecyclingPoint",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Material",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnswerId = table.Column<int>(type: "int", nullable: false),
                    MaterialSubTypeId = table.Column<int>(type: "int", nullable: false),
                    RecyclingPointId = table.Column<int>(type: "int", nullable: false),
                    RecyclingFactoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Material", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Material_MaterialSubType_MaterialSubTypeId",
                        column: x => x.MaterialSubTypeId,
                        principalTable: "MaterialSubType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Material_RecyclingFactory_RecyclingFactoryId",
                        column: x => x.RecyclingFactoryId,
                        principalTable: "RecyclingFactory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Material_RecyclingPoint_RecyclingPointId",
                        column: x => x.RecyclingPointId,
                        principalTable: "RecyclingPoint",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Property",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaterialId = table.Column<int>(type: "int", nullable: true),
                    MaterialSubTypeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Property", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Property_Material_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Material",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Property_MaterialSubType_MaterialSubTypeId",
                        column: x => x.MaterialSubTypeId,
                        principalTable: "MaterialSubType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Question",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentAnswerId = table.Column<int>(type: "int", nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Question", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Answer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentQuestionId = table.Column<int>(type: "int", nullable: false),
                    ChildQuestionId = table.Column<int>(type: "int", nullable: true),
                    MaterialId = table.Column<int>(type: "int", nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Answer_Question_ParentQuestionId",
                        column: x => x.ParentQuestionId,
                        principalTable: "Question",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answer_ParentQuestionId",
                table: "Answer",
                column: "ParentQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Material_AnswerId",
                table: "Material",
                column: "AnswerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Material_MaterialSubTypeId",
                table: "Material",
                column: "MaterialSubTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Material_RecyclingFactoryId",
                table: "Material",
                column: "RecyclingFactoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Material_RecyclingPointId",
                table: "Material",
                column: "RecyclingPointId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialSubType_MaterialTypeId",
                table: "MaterialSubType",
                column: "MaterialTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Property_MaterialId",
                table: "Property",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_Property_MaterialSubTypeId",
                table: "Property",
                column: "MaterialSubTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Question_ParentAnswerId",
                table: "Question",
                column: "ParentAnswerId",
                unique: true,
                filter: "[ParentAnswerId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_RecyclingFactoryRecyclingPoint_RecyclingPointsId",
                table: "RecyclingFactoryRecyclingPoint",
                column: "RecyclingPointsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Material_Answer_AnswerId",
                table: "Material",
                column: "AnswerId",
                principalTable: "Answer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Question_Answer_ParentAnswerId",
                table: "Question",
                column: "ParentAnswerId",
                principalTable: "Answer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answer_Question_ParentQuestionId",
                table: "Answer");

            migrationBuilder.DropTable(
                name: "Property");

            migrationBuilder.DropTable(
                name: "RecyclingFactoryRecyclingPoint");

            migrationBuilder.DropTable(
                name: "Material");

            migrationBuilder.DropTable(
                name: "MaterialSubType");

            migrationBuilder.DropTable(
                name: "RecyclingFactory");

            migrationBuilder.DropTable(
                name: "RecyclingPoint");

            migrationBuilder.DropTable(
                name: "MaterialType");

            migrationBuilder.DropTable(
                name: "Question");

            migrationBuilder.DropTable(
                name: "Answer");
        }
    }
}
