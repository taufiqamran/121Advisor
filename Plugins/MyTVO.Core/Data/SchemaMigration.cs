using FluentMigrator;
using Nop.Data.Migrations;

namespace MyTVO.Core.Data
{
    // SS AW: Use this code to create table using builder
    ////[SkipMigrationOnUpdate]         // Uncomment this line if there is no database update to execute
    //[NopMigration("2021/11/25 01:10:00:0000000", "MyTVO_Car - Create table")]
    //public class SchemaMigration : AutoReversingMigration
    //{
    //    protected IMigrationManager _migrationManager;

    //    public SchemaMigration(IMigrationManager migrationManager)
    //    {
    //        _migrationManager = migrationManager;
    //    }

    //    //
    //    public override void Up()
    //    {
    //        _migrationManager.BuildTable<MyTVO_Car>(Create);
    //    }
    //}


    // SS AW: User this code to create table using sql script
    //[SkipMigrationOnUpdate]   // Uncomment this line if there is no database update to execute
    [NopMigration("2021/12/17 14:53:00:0000000", "myTVO-DBScript_v103 - Create new tables")]  // This info will be written into [dbo].[MigrationVersionInfo]
    public class SchemaMigration : Migration
    {
        protected IMigrationManager _migrationManager;

        public SchemaMigration(IMigrationManager migrationManager)
        {
            _migrationManager = migrationManager;
        }

        public override void Down()
        {
            throw new System.NotImplementedException();
        }

        // Ensure sql files are in Nop.Web/Plugin/Data/Scripts folder.
        // Right click sql file, click Properties, Copy To Output Directory = Copy if newer/copy always
        // For this method to be called, do the following
        // comment [SkipMigrationOnUpdate],
        // set NopMigration date to current date and time,
        // increase plugin.json version
        public override void Up()
        {
            ExecuteScripts();
        }

        private void ExecuteScripts()
        {
            string schemaName = $"{MyTVOCoreDefaults.SchemaName}";
            string tableName = $"{MyTVOCoreDefaults.TableName_MyTVO_Car}";

            if (!this.Schema.Schema(schemaName).Table(tableName).Exists())
            {
                Execute.Script($"{MyTVOCoreDefaults.ScriptsViewPath}/MyTVO_Car-Create_v100.sql");
                Execute.Script($"{MyTVOCoreDefaults.ScriptsViewPath}/MyTVO_Car-Insert_v101.sql");
                Execute.Script($"{MyTVOCoreDefaults.ScriptsViewPath}/MyTVO_Car-Update_v102.sql");
            }

            Execute.Script($"{MyTVOCoreDefaults.ScriptsViewPath}/myTVO-DBScript_v103.sql");
        }
    }
}

