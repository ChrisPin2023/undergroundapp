using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace underground.api.Migrations
{
    /// <inheritdoc />
    public partial class NovaMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tb_Endereco",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NumCasa = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    Rua = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BairroDistrito = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Municipio = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Provincia = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DataCadastro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataRevisao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Endereco", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Hospital",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NomeHospital = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Servicos = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    DataCadastro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataRevisao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Hospital", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Naturalidade",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NumCasa = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Rua = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    BairroDistrito = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Municipio = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Provincia = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Pais = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    DataCadastro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataRevisao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Naturalidade", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Stock",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataEntrada = table.Column<DateTime>(type: "datetime2", maxLength: 8, nullable: false),
                    DataSaida = table.Column<DateTime>(type: "datetime2", maxLength: 8, nullable: false),
                    QtdEntrada = table.Column<int>(type: "int", nullable: false),
                    QtdSaida = table.Column<int>(type: "int", maxLength: 30, nullable: false),
                    QtdMinima = table.Column<int>(type: "int", maxLength: 30, nullable: false),
                    DataCadastro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataRevisao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Stock", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Pedido",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EstadoPedido = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Carater = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    HospitalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataCadastro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataRevisao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Pedido", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tb_Pedido_Tb_Hospital_HospitalId",
                        column: x => x.HospitalId,
                        principalTable: "Tb_Hospital",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Pessoa",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NomePessoa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumIdentificao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Idade = table.Column<int>(type: "int", nullable: false),
                    Genero = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Profissao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GrupoSanguineo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnderecoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NaturalidadeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataCadastro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataRevisao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Pessoa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tb_Pessoa_Tb_Endereco_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "Tb_Endereco",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tb_Pessoa_Tb_Naturalidade_NaturalidadeId",
                        column: x => x.NaturalidadeId,
                        principalTable: "Tb_Naturalidade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Contacto",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NumTelefonePessoal = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: true),
                    NumTelefoneTrabalho = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: true),
                    EmailPessoal = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    EmailTrabalho = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Facebook = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Instagram = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NumWatsapp = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: true),
                    PessoaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataCadastro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataRevisao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Contacto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tb_Contacto_Tb_Pessoa_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Tb_Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Dador",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CodDador = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    PessoaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataCadastro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataRevisao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Dador", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tb_Dador_Tb_Pessoa_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Tb_Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Medico",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NumOdem = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Especialidade = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    PessoaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataCadastro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataRevisao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Medico", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tb_Medico_Tb_Pessoa_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Tb_Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Paciente",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Patologia = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    PessoaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HospitalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataCadastro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataRevisao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Paciente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tb_Paciente_Tb_Hospital_HospitalId",
                        column: x => x.HospitalId,
                        principalTable: "Tb_Hospital",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tb_Paciente_Tb_Pessoa_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Tb_Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Tecnico",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FuncaoExtra = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    RefTecnico = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    PessoaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataCadastro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataRevisao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Tecnico", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tb_Tecnico_Tb_Pessoa_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Tb_Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Saida",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    QtdBolsas = table.Column<int>(type: "int", maxLength: 15, nullable: false),
                    PedidoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    StockId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MedicoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataCadastro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataRevisao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Saida", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tb_Saida_Tb_Medico_MedicoId",
                        column: x => x.MedicoId,
                        principalTable: "Tb_Medico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tb_Saida_Tb_Pedido_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Tb_Pedido",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tb_Saida_Tb_Stock_StockId",
                        column: x => x.StockId,
                        principalTable: "Tb_Stock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Entrada",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Qtd = table.Column<int>(type: "int", nullable: false),
                    Gsanguineo = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    Tipo = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    StockId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TecnicoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataCadastro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataRevisao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Entrada", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tb_Entrada_Tb_Stock_StockId",
                        column: x => x.StockId,
                        principalTable: "Tb_Stock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tb_Entrada_Tb_Tecnico_TecnicoId",
                        column: x => x.TecnicoId,
                        principalTable: "Tb_Tecnico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Contacto_PessoaId",
                table: "Tb_Contacto",
                column: "PessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Dador_PessoaId",
                table: "Tb_Dador",
                column: "PessoaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Entrada_StockId",
                table: "Tb_Entrada",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Entrada_TecnicoId",
                table: "Tb_Entrada",
                column: "TecnicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Medico_PessoaId",
                table: "Tb_Medico",
                column: "PessoaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Paciente_HospitalId",
                table: "Tb_Paciente",
                column: "HospitalId");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Paciente_PessoaId",
                table: "Tb_Paciente",
                column: "PessoaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Pedido_HospitalId",
                table: "Tb_Pedido",
                column: "HospitalId");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Pessoa_EnderecoId",
                table: "Tb_Pessoa",
                column: "EnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Pessoa_NaturalidadeId",
                table: "Tb_Pessoa",
                column: "NaturalidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Saida_MedicoId",
                table: "Tb_Saida",
                column: "MedicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Saida_PedidoId",
                table: "Tb_Saida",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Saida_StockId",
                table: "Tb_Saida",
                column: "StockId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Tecnico_PessoaId",
                table: "Tb_Tecnico",
                column: "PessoaId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tb_Contacto");

            migrationBuilder.DropTable(
                name: "Tb_Dador");

            migrationBuilder.DropTable(
                name: "Tb_Entrada");

            migrationBuilder.DropTable(
                name: "Tb_Paciente");

            migrationBuilder.DropTable(
                name: "Tb_Saida");

            migrationBuilder.DropTable(
                name: "Tb_Tecnico");

            migrationBuilder.DropTable(
                name: "Tb_Medico");

            migrationBuilder.DropTable(
                name: "Tb_Pedido");

            migrationBuilder.DropTable(
                name: "Tb_Stock");

            migrationBuilder.DropTable(
                name: "Tb_Pessoa");

            migrationBuilder.DropTable(
                name: "Tb_Hospital");

            migrationBuilder.DropTable(
                name: "Tb_Endereco");

            migrationBuilder.DropTable(
                name: "Tb_Naturalidade");
        }
    }
}
