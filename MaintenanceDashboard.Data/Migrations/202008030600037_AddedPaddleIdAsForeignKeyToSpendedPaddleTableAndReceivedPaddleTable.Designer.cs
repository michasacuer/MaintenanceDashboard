﻿// <auto-generated />
namespace MaintenanceDashboard.Data.Migrations
{
    using System.CodeDom.Compiler;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;
    using System.Resources;
    
    [GeneratedCode("EntityFramework.Migrations", "6.4.4")]
    public sealed partial class AddedPaddleIdAsForeignKeyToSpendedPaddleTableAndReceivedPaddleTable : IMigrationMetadata
    {
        private readonly ResourceManager Resources = new ResourceManager(typeof(AddedPaddleIdAsForeignKeyToSpendedPaddleTableAndReceivedPaddleTable));
        
        string IMigrationMetadata.Id
        {
            get { return "202008030600037_AddedPaddleIdAsForeignKeyToSpendedPaddleTableAndReceivedPaddleTable"; }
        }
        
        string IMigrationMetadata.Source
        {
            get { return null; }
        }
        
        string IMigrationMetadata.Target
        {
            get { return Resources.GetString("Target"); }
        }
    }
}
