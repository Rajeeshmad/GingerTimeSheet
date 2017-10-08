namespace GingerTimeSheet.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class GingerTimeSheetModel : DbContext
    {
        // Your context has been configured to use a 'GingerTimeSheetModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'GingerTimeSheet.Models.GingerTimeSheetModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'GingerTimeSheetModel' 
        // connection string in the application configuration file.
        public GingerTimeSheetModel()
            : base("name=GingerTimeSheetModel")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<AccountDetail> AccountDetails { get; set; }
        public virtual DbSet<Client> ClientDetail { get; set; }
        public virtual DbSet<AccountEntry> AccountEntryDetail { get; set; }
        public virtual DbSet<EmployeeLogOnDetail> EmployeeLogOnDetails { get; set; }
        public virtual DbSet<EmployeeMain> EmployeeMainDetail { get; set; }
        public virtual DbSet<EmployeeRole> EmployeeRoleDetail { get; set; }
        public virtual DbSet<Project> ProjectDetail { get; set; }
        public virtual DbSet<ProjectEntry> ProjectEntryDetail { get; set; }
        public virtual DbSet<ProjectEntryDetail> ProjectEntryDetails { get; set; }
        public virtual DbSet<TimeSheetDue> TimeSheetDueDetail { get; set; }
        public virtual DbSet<TimeSheetDueDate> TimeSheetDueDateDetail { get; set; }
        public virtual DbSet<TimeSheetEntry> TimeSheetEntryDetail { get; set; }
        public virtual DbSet<TimeSheetWorkOrderEntry> TimeSheetWorkOrderEntryDetail { get; set; }
        public virtual DbSet<ProjectCostEntry> ProjectCostEntryDetail { get; set; }
        public virtual DbSet<WorkOrder> WorkOrderEntryDetail { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }   
}