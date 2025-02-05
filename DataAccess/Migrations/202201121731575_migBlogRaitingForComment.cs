﻿namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migBlogRaitingForComment : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Comments", "BlogRating", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Comments", "BlogRating");
        }
    }
}
