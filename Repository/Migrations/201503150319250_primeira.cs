namespace Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class primeira : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.cliente",
                c => new
                    {
                        id = c.Guid(nullable: false),
                        s_nome = c.String(),
                        s_profissao = c.String(),
                        n_idade = c.Int(nullable: false),
                        d_cadastro = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.endereco",
                c => new
                    {
                        id = c.Guid(nullable: false),
                        id_cliente = c.Guid(nullable: false),
                        s_rua = c.String(),
                        s_numero = c.String(),
                        s_bairro = c.String(),
                        s_cidade = c.String(),
                        d_cadastro = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.cliente", t => t.id_cliente, cascadeDelete: true)
                .Index(t => t.id_cliente);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.endereco", "id_cliente", "dbo.cliente");
            DropIndex("dbo.endereco", new[] { "id_cliente" });
            DropTable("dbo.endereco");
            DropTable("dbo.cliente");
        }
    }
}
