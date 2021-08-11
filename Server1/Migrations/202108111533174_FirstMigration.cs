namespace Server1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Attendance",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Mark = c.Int(nullable: false),
                        StudentsId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Students", t => t.StudentsId)
                .Index(t => t.StudentsId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100, unicode: false),
                        Passw = c.Int(nullable: false),
                        Phone = c.Int(nullable: false),
                        Email = c.String(nullable: false, maxLength: 100, unicode: false),
                        GroupsId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Groups", t => t.GroupsId)
                .Index(t => t.GroupsId);
            
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        StudentList = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Exams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Day = c.DateTime(nullable: false),
                        Time = c.DateTime(nullable: false),
                        SubjectsId = c.Int(nullable: false),
                        GroupsId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Subjects", t => t.SubjectsId)
                .ForeignKey("dbo.Groups", t => t.GroupsId)
                .Index(t => t.SubjectsId)
                .Index(t => t.GroupsId);
            
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Grades",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SubjectsId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Subjects", t => t.SubjectsId)
                .Index(t => t.SubjectsId);
            
            CreateTable(
                "dbo.HomeTask",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Day = c.DateTime(nullable: false),
                        Content = c.String(nullable: false, maxLength: 100),
                        SubjectsId = c.Int(nullable: false),
                        StudentsId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Subjects", t => t.SubjectsId)
                .ForeignKey("dbo.Students", t => t.StudentsId)
                .Index(t => t.SubjectsId)
                .Index(t => t.StudentsId);
            
            CreateTable(
                "dbo.Timetable",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Day = c.DateTime(nullable: false),
                        Time = c.DateTime(nullable: false),
                        TeachersId = c.Int(nullable: false),
                        SubjectsId = c.Int(nullable: false),
                        GroupsId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teachers", t => t.TeachersId)
                .ForeignKey("dbo.Subjects", t => t.SubjectsId)
                .ForeignKey("dbo.Groups", t => t.GroupsId)
                .Index(t => t.TeachersId)
                .Index(t => t.SubjectsId)
                .Index(t => t.GroupsId);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100, unicode: false),
                        Passw = c.Int(nullable: false),
                        Phone = c.Int(nullable: false),
                        Email = c.Binary(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Theme = c.String(nullable: false, maxLength: 100),
                        Day = c.DateTime(nullable: false),
                        Time = c.DateTime(nullable: false),
                        Content = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Directors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Passw = c.Int(nullable: false),
                        Phone = c.Int(nullable: false),
                        Email = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 1000),
                        Day = c.DateTime(nullable: false),
                        Time = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Parents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100, unicode: false),
                        Passw = c.Int(nullable: false),
                        Phone = c.Int(nullable: false),
                        Email = c.String(nullable: false, maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.HomeTask", "StudentsId", "dbo.Students");
            DropForeignKey("dbo.Timetable", "GroupsId", "dbo.Groups");
            DropForeignKey("dbo.Students", "GroupsId", "dbo.Groups");
            DropForeignKey("dbo.Exams", "GroupsId", "dbo.Groups");
            DropForeignKey("dbo.Timetable", "SubjectsId", "dbo.Subjects");
            DropForeignKey("dbo.Timetable", "TeachersId", "dbo.Teachers");
            DropForeignKey("dbo.HomeTask", "SubjectsId", "dbo.Subjects");
            DropForeignKey("dbo.Grades", "SubjectsId", "dbo.Subjects");
            DropForeignKey("dbo.Exams", "SubjectsId", "dbo.Subjects");
            DropForeignKey("dbo.Attendance", "StudentsId", "dbo.Students");
            DropIndex("dbo.Timetable", new[] { "GroupsId" });
            DropIndex("dbo.Timetable", new[] { "SubjectsId" });
            DropIndex("dbo.Timetable", new[] { "TeachersId" });
            DropIndex("dbo.HomeTask", new[] { "StudentsId" });
            DropIndex("dbo.HomeTask", new[] { "SubjectsId" });
            DropIndex("dbo.Grades", new[] { "SubjectsId" });
            DropIndex("dbo.Exams", new[] { "GroupsId" });
            DropIndex("dbo.Exams", new[] { "SubjectsId" });
            DropIndex("dbo.Students", new[] { "GroupsId" });
            DropIndex("dbo.Attendance", new[] { "StudentsId" });
            DropTable("dbo.Parents");
            DropTable("dbo.Events");
            DropTable("dbo.Directors");
            DropTable("dbo.Comments");
            DropTable("dbo.Teachers");
            DropTable("dbo.Timetable");
            DropTable("dbo.HomeTask");
            DropTable("dbo.Grades");
            DropTable("dbo.Subjects");
            DropTable("dbo.Exams");
            DropTable("dbo.Groups");
            DropTable("dbo.Students");
            DropTable("dbo.Attendance");
        }
    }
}
