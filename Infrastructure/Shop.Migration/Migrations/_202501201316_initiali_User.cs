using FluentMigrator;

namespace Shop.Migration.Migrations;
[Migration(202501201316)]
public class _202501201316_initiali_User:FluentMigrator.Migration
{
    public override void Up()
    {
        Create.Table("Users")
            .WithColumn("UserId").AsInt32().PrimaryKey().Identity()
            .WithColumn("UserName").AsString().NotNullable()
            .WithColumn("Email").AsString().NotNullable()
            .WithColumn("Password").AsString().NotNullable()
            .WithColumn("Role").AsString().NotNullable()
            .WithColumn("CreatedAt").AsDateTime().NotNullable();
    }

    public override void Down()
    {
        Delete.Table("Users");
    }
}