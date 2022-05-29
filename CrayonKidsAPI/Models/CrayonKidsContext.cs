using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace CrayonKidsAPI.Models
{
    public partial class CrayonKidsContext : DbContext
    {
        public CrayonKidsContext()
        {
        }

        public CrayonKidsContext(DbContextOptions<CrayonKidsContext> options)
            : base(options)
        {
        }



        public virtual DbSet<Allergy> Allergies { get; set; }
        public virtual DbSet<Application> Applications { get; set; }
        public virtual DbSet<ApplicationStatus> ApplicationStatuses { get; set; }
        public virtual DbSet<AppointmentBooking> AppointmentBookings { get; set; }
        public virtual DbSet<Assessment> Assessments { get; set; }
        public virtual DbSet<BookingStatus> BookingStatuses { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<ClassClassType> ClassClassTypes { get; set; }
        public virtual DbSet<ClassType> ClassTypes { get; set; }
        public virtual DbSet<ClassTypeEmployee> ClassTypeEmployees { get; set; }
        public virtual DbSet<Complaint> Complaints { get; set; }
        public virtual DbSet<DateTable> DateTables { get; set; }
        public virtual DbSet<Emergency> Emergencies { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeType> EmployeeTypes { get; set; }
        public virtual DbSet<EmploymentStatus> EmploymentStatuses { get; set; }
        public virtual DbSet<Equipment> Equipment { get; set; }
        public virtual DbSet<EquipmentType> EquipmentTypes { get; set; }
        public virtual DbSet<Homework> Homeworks { get; set; }
        public virtual DbSet<MarkingScale> MarkingScales { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<MenuItem> MenuItems { get; set; }
        public virtual DbSet<MenuItemMenu> MenuItemMenus { get; set; }
        public virtual DbSet<OrderLine> OrderLines { get; set; }
        public virtual DbSet<ParentFeedback> ParentFeedbacks { get; set; }
        public virtual DbSet<ParentGuardian> ParentGuardians { get; set; }
        public virtual DbSet<ParentGuardianMenuItem> ParentGuardianMenuItems { get; set; }
        public virtual DbSet<ProgressCategory> ProgressCategories { get; set; }
        public virtual DbSet<Province> Provinces { get; set; }
        public virtual DbSet<ReportCard> ReportCards { get; set; }
        public virtual DbSet<ReportCardTemplate> ReportCardTemplates { get; set; }
        public virtual DbSet<Schedule> Schedules { get; set; }
        public virtual DbSet<School> Schools { get; set; }
        public virtual DbSet<SchoolFeesStatus> SchoolFeesStatuses { get; set; }
        public virtual DbSet<SchoolTerm> SchoolTerms { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<StudentAllergy> StudentAllergies { get; set; }
        public virtual DbSet<StudentClass> StudentClasses { get; set; }
        public virtual DbSet<StudentEmergency> StudentEmergencies { get; set; }
        public virtual DbSet<Subcategory> Subcategories { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<SupplierOrder> SupplierOrders { get; set; }
        public virtual DbSet<Test> Tests { get; set; }
        public virtual DbSet<Timeslot> Timeslots { get; set; }
        public virtual DbSet<TimeslotScheduleDate> TimeslotScheduleDates { get; set; }
        public virtual DbSet<Title> Titles { get; set; }
        public virtual DbSet<UserTbl> UserTbls { get; set; }
        public virtual DbSet<UserType> UserTypes { get; set; }
        public virtual DbSet<ZipCode> ZipCodes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-FM5PAB6;Database=CrayonKids;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Allergy>(entity =>
            {
                entity.ToTable("Allergy");

                entity.Property(e => e.AllergyId)
                    .ValueGeneratedNever()
                    .HasColumnName("Allergy_ID");

                entity.Property(e => e.AllergyDate)
                    .HasColumnType("date")
                    .HasColumnName("Allergy_Date");

                entity.Property(e => e.AllergyDetails)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Allergy_Details");
            });

            modelBuilder.Entity<Application>(entity =>
            {
                entity.ToTable("Application");

                entity.Property(e => e.ApplicationId)
                    .ValueGeneratedNever()
                    .HasColumnName("Application_ID");

                entity.Property(e => e.ApplicationDate)
                    .HasColumnType("date")
                    .HasColumnName("Application_Date");

                entity.Property(e => e.ApplicationStatusId).HasColumnName("Application_Status_ID");

                entity.Property(e => e.ParentGuardianId).HasColumnName("Parent_Guardian_ID");

                entity.Property(e => e.StudentId).HasColumnName("Student_ID");

                entity.HasOne(d => d.ApplicationStatus)
                    .WithMany(p => p.Applications)
                    .HasForeignKey(d => d.ApplicationStatusId)
                    .HasConstraintName("FK__Applicati__Appli__282DF8C2");

                entity.HasOne(d => d.ParentGuardian)
                    .WithMany(p => p.Applications)
                    .HasForeignKey(d => d.ParentGuardianId)
                    .HasConstraintName("FK__Applicati__Paren__2645B050");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Applications)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK__Applicati__Stude__2739D489");
            });

            modelBuilder.Entity<ApplicationStatus>(entity =>
            {
                entity.ToTable("Application_Status");

                entity.Property(e => e.ApplicationStatusId)
                    .ValueGeneratedNever()
                    .HasColumnName("Application_Status_ID");

                entity.Property(e => e.Accepted)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ApplicationId).HasColumnName("Application_ID");

                entity.Property(e => e.Pending)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Rejected)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AppointmentBooking>(entity =>
            {
                entity.ToTable("Appointment_Booking");

                entity.Property(e => e.AppointmentBookingId)
                    .ValueGeneratedNever()
                    .HasColumnName("Appointment_Booking_ID");

                entity.Property(e => e.AppointmentBookingDate)
                    .HasColumnType("date")
                    .HasColumnName("Appointment_Booking_Date");

                entity.Property(e => e.AppointmentBookingDetails)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Appointment_Booking_Details");

                entity.Property(e => e.BookingStatusId).HasColumnName("Booking_Status_ID");

                entity.HasOne(d => d.BookingStatus)
                    .WithMany(p => p.AppointmentBookings)
                    .HasForeignKey(d => d.BookingStatusId)
                    .HasConstraintName("FK__Appointme__Booki__0F624AF8");
            });

            modelBuilder.Entity<Assessment>(entity =>
            {
                entity.ToTable("Assessment");

                entity.Property(e => e.AssessmentId)
                    .ValueGeneratedNever()
                    .HasColumnName("Assessment_ID");

                entity.Property(e => e.AssessmentDetails)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Assessment_Details");

                entity.Property(e => e.ReportCardTemplateId).HasColumnName("Report_Card_Template_ID");

                entity.HasOne(d => d.ReportCardTemplate)
                    .WithMany(p => p.Assessments)
                    .HasForeignKey(d => d.ReportCardTemplateId)
                    .HasConstraintName("FK__Assessmen__Repor__68487DD7");
            });

            modelBuilder.Entity<BookingStatus>(entity =>
            {
                entity.ToTable("Booking_Status");

                entity.Property(e => e.BookingStatusId)
                    .ValueGeneratedNever()
                    .HasColumnName("Booking_Status_ID");

                entity.Property(e => e.Accepted)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Pending)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Rejected)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.ToTable("City");

                entity.Property(e => e.CityId)
                    .ValueGeneratedNever()
                    .HasColumnName("City_ID");

                entity.Property(e => e.CityDetails)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("City_Details");

                entity.Property(e => e.ProvinceId).HasColumnName("Province_ID");

                entity.HasOne(d => d.Province)
                    .WithMany(p => p.Cities)
                    .HasForeignKey(d => d.ProvinceId)
                    .HasConstraintName("FK__City__Province_I__2CF2ADDF");
            });

            modelBuilder.Entity<Class>(entity =>
            {
                entity.ToTable("Class");

                entity.Property(e => e.ClassId)
                    .ValueGeneratedNever()
                    .HasColumnName("Class_ID");

                entity.Property(e => e.ClassCapacity)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Class_Capacity");

                entity.Property(e => e.ClassName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Class_Name");
            });

            modelBuilder.Entity<ClassClassType>(entity =>
            {
                entity.HasKey(e => new { e.ClassId, e.ClassTypeId })
                    .HasName("PK__Class_Cl__B077B71534DCB7B6");

                entity.ToTable("Class_Class_Type");

                entity.Property(e => e.ClassId).HasColumnName("Class_ID");

                entity.Property(e => e.ClassTypeId).HasColumnName("Class_Type_ID");
            });

            modelBuilder.Entity<ClassType>(entity =>
            {
                entity.ToTable("Class_Type");

                entity.Property(e => e.ClassTypeId)
                    .ValueGeneratedNever()
                    .HasColumnName("Class_Type_ID");
            });

            modelBuilder.Entity<ClassTypeEmployee>(entity =>
            {
                entity.HasKey(e => new { e.ClassTypeId, e.EmployeeId })
                    .HasName("PK__Class_Ty__098A3769FFE27824");

                entity.ToTable("Class_Type_Employee");

                entity.Property(e => e.ClassTypeId).HasColumnName("Class_Type_ID");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");
            });

            modelBuilder.Entity<Complaint>(entity =>
            {
                entity.ToTable("Complaint");

                entity.Property(e => e.ComplaintId)
                    .ValueGeneratedNever()
                    .HasColumnName("Complaint_ID");

                entity.Property(e => e.ComplaintDetails)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("Complaint_details");
            });

            modelBuilder.Entity<DateTable>(entity =>
            {
                entity.HasKey(e => e.DateId)
                    .HasName("PK__DateTabl__1F9B72AB718C8542");

                entity.ToTable("DateTable");

                entity.Property(e => e.DateId)
                    .ValueGeneratedNever()
                    .HasColumnName("Date_ID");

                entity.Property(e => e.DateDetails)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Date_details");

                entity.Property(e => e.Month).HasColumnType("date");

                entity.Property(e => e.Year).HasColumnType("date");
            });

            modelBuilder.Entity<Emergency>(entity =>
            {
                entity.ToTable("Emergency");

                entity.Property(e => e.EmergencyId)
                    .ValueGeneratedNever()
                    .HasColumnName("Emergency_ID");

                entity.Property(e => e.EmergencyDate)
                    .HasColumnType("date")
                    .HasColumnName("Emergency_Date");

                entity.Property(e => e.EmergencyDetails)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Emergency_Details");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employee");

                entity.Property(e => e.EmployeeId)
                    .ValueGeneratedNever()
                    .HasColumnName("Employee_ID");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BirthDate)
                    .HasColumnType("date")
                    .HasColumnName("Birth_Date");

                entity.Property(e => e.ContactNo).HasColumnName("Contact_No");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Email_Address");

                entity.Property(e => e.EmployeeTypeId).HasColumnName("Employee_Type_ID");

                entity.Property(e => e.EmploymentStatusId).HasColumnName("Employment_Status_ID");

                entity.Property(e => e.HireDate)
                    .HasColumnType("date")
                    .HasColumnName("Hire_Date");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SchoolId).HasColumnName("School_ID");

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TitleId).HasColumnName("Title_ID");

                entity.HasOne(d => d.EmployeeType)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.EmployeeTypeId)
                    .HasConstraintName("FK__Employee__Employ__45F365D3");

                entity.HasOne(d => d.EmploymentStatus)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.EmploymentStatusId)
                    .HasConstraintName("FK__Employee__Employ__48CFD27E");

                entity.HasOne(d => d.School)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.SchoolId)
                    .HasConstraintName("FK__Employee__School__46E78A0C");

                entity.HasOne(d => d.Title)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.TitleId)
                    .HasConstraintName("FK__Employee__Title___47DBAE45");
            });

            modelBuilder.Entity<EmployeeType>(entity =>
            {
                entity.ToTable("Employee_Type");

                entity.Property(e => e.EmployeeTypeId)
                    .ValueGeneratedNever()
                    .HasColumnName("Employee_Type_ID");

                entity.Property(e => e.Administrator)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cook)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gardener)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Principal)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Teacher)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmploymentStatus>(entity =>
            {
                entity.ToTable("Employment_Status");

                entity.Property(e => e.EmploymentStatusId)
                    .ValueGeneratedNever()
                    .HasColumnName("Employment_Status_ID");

                entity.Property(e => e.Active)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Inactive)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Equipment>(entity =>
            {
                entity.Property(e => e.EquipmentId)
                    .ValueGeneratedNever()
                    .HasColumnName("Equipment_ID");

                entity.Property(e => e.EquipmentItemName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Equipment_Item_Name");

                entity.Property(e => e.EquipmentPurchaseDate)
                    .HasColumnType("date")
                    .HasColumnName("Equipment_Purchase_Date");

                entity.Property(e => e.EquipmentTypeId).HasColumnName("Equipment_Type_ID");

                entity.HasOne(d => d.EquipmentType)
                    .WithMany(p => p.Equipment)
                    .HasForeignKey(d => d.EquipmentTypeId)
                    .HasConstraintName("FK__Equipment__Equip__1AD3FDA4");
            });

            modelBuilder.Entity<EquipmentType>(entity =>
            {
                entity.ToTable("Equipment_Type");

                entity.Property(e => e.EquipmentTypeId)
                    .ValueGeneratedNever()
                    .HasColumnName("Equipment_Type_ID");

                entity.Property(e => e.EquipmentTypeDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Equipment_Type_Description");
            });

            modelBuilder.Entity<Homework>(entity =>
            {
                entity.ToTable("Homework");

                entity.Property(e => e.HomeworkId)
                    .ValueGeneratedNever()
                    .HasColumnName("Homework_ID");

                entity.Property(e => e.HomeworkDetails)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Homework_Details");

                entity.Property(e => e.ReportCardTemplateId).HasColumnName("Report_Card_Template_ID");

                entity.HasOne(d => d.ReportCardTemplate)
                    .WithMany(p => p.Homeworks)
                    .HasForeignKey(d => d.ReportCardTemplateId)
                    .HasConstraintName("FK__Homework__Report__6B24EA82");
            });

            modelBuilder.Entity<MarkingScale>(entity =>
            {
                entity.ToTable("Marking_Scale");

                entity.Property(e => e.MarkingScaleId)
                    .ValueGeneratedNever()
                    .HasColumnName("Marking_Scale_ID");

                entity.Property(e => e.MarkingScaleDetails)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Marking_Scale_Details");

                entity.Property(e => e.ReportCardTemplateId).HasColumnName("Report_Card_Template_ID");

                entity.HasOne(d => d.ReportCardTemplate)
                    .WithMany(p => p.MarkingScales)
                    .HasForeignKey(d => d.ReportCardTemplateId)
                    .HasConstraintName("FK__Marking_S__Repor__6E01572D");
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.ToTable("Menu");

                entity.Property(e => e.MenuId)
                    .ValueGeneratedNever()
                    .HasColumnName("Menu_ID");

                entity.Property(e => e.MenuDescription)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MenuItem>(entity =>
            {
                entity.ToTable("Menu_Item");

                entity.Property(e => e.MenuItemId)
                    .ValueGeneratedNever()
                    .HasColumnName("Menu_Item_ID");

                entity.Property(e => e.MenuItemDescription)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Menu_Item_Description");
            });

            modelBuilder.Entity<MenuItemMenu>(entity =>
            {
                entity.HasKey(e => new { e.MenuId, e.MenuItemId })
                    .HasName("PK__Menu_Ite__ADC4EA8EAB7A3781");

                entity.ToTable("Menu_Item_Menu");

                entity.Property(e => e.MenuId).HasColumnName("Menu_ID");

                entity.Property(e => e.MenuItemId).HasColumnName("Menu_Item_ID");
            });

            modelBuilder.Entity<OrderLine>(entity =>
            {
                entity.HasKey(e => new { e.SupplierOrderId, e.OrderTypeId, e.StationeryId, e.CleaningMaterialItemId, e.EquipmentId })
                    .HasName("PK__Order_Li__152A654CD26619D0");

                entity.ToTable("Order_Line");

                entity.Property(e => e.SupplierOrderId).HasColumnName("Supplier_Order_ID");

                entity.Property(e => e.OrderTypeId).HasColumnName("Order_Type_ID");

                entity.Property(e => e.StationeryId).HasColumnName("Stationery_ID");

                entity.Property(e => e.CleaningMaterialItemId).HasColumnName("Cleaning_Material_Item_ID");

                entity.Property(e => e.EquipmentId).HasColumnName("Equipment_ID");

                entity.Property(e => e.OrderLineItem)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Order_Line_Item");
            });

            modelBuilder.Entity<ParentFeedback>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Parent_Feedback");

                entity.Property(e => e.ParentFeedbackDetails)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Parent_Feedback_Details");

                entity.Property(e => e.ParentFeedbackId).HasColumnName("Parent_Feedback_ID");

                entity.Property(e => e.ParentGuardianId).HasColumnName("Parent_Guardian_ID");

                entity.HasOne(d => d.ParentGuardian)
                    .WithMany()
                    .HasForeignKey(d => d.ParentGuardianId)
                    .HasConstraintName("FK__Parent_Fe__Paren__403A8C7D");
            });

            modelBuilder.Entity<ParentGuardian>(entity =>
            {
                entity.ToTable("Parent_Guardian");

                entity.Property(e => e.ParentGuardianId)
                    .ValueGeneratedNever()
                    .HasColumnName("Parent_Guardian_ID");

                entity.Property(e => e.ParentContactNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Parent_Contact_No");

                entity.Property(e => e.ParentEmailAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Parent_Email_Address");

                entity.Property(e => e.ParentName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Parent_Name");

                entity.Property(e => e.ParentSurname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Parent_Surname");
            });

            modelBuilder.Entity<ParentGuardianMenuItem>(entity =>
            {
                entity.HasKey(e => new { e.ParentGuardianId, e.MenuItemId })
                    .HasName("PK__Parent_G__417D319375A9EF42");

                entity.ToTable("Parent_Guardian_Menu_Item");

                entity.Property(e => e.ParentGuardianId).HasColumnName("Parent_Guardian_ID");

                entity.Property(e => e.MenuItemId).HasColumnName("Menu_Item_ID");
            });

            modelBuilder.Entity<ProgressCategory>(entity =>
            {
                entity.ToTable("Progress_Category");

                entity.Property(e => e.ProgressCategoryId)
                    .ValueGeneratedNever()
                    .HasColumnName("Progress_Category_ID");

                entity.Property(e => e.MarkingScaleId).HasColumnName("Marking_Scale_ID");

                entity.Property(e => e.ProgressCategoryDetails)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Progress_Category_Details");

                entity.HasOne(d => d.MarkingScale)
                    .WithMany(p => p.ProgressCategories)
                    .HasForeignKey(d => d.MarkingScaleId)
                    .HasConstraintName("FK__Progress___Marki__70DDC3D8");
            });

            modelBuilder.Entity<Province>(entity =>
            {
                entity.ToTable("Province");

                entity.Property(e => e.ProvinceId)
                    .ValueGeneratedNever()
                    .HasColumnName("Province_ID");

                entity.Property(e => e.ProvinceDetails)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Province_Details");
            });

            modelBuilder.Entity<ReportCard>(entity =>
            {
                entity.ToTable("ReportCard");

                entity.Property(e => e.ReportCardId)
                    .ValueGeneratedNever()
                    .HasColumnName("Report_Card_ID");

                entity.Property(e => e.ReportCardDetails)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Report_Card_Details");

                entity.Property(e => e.StudentId).HasColumnName("Student_ID");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.ReportCards)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK__ReportCar__Stude__5AEE82B9");
            });

            modelBuilder.Entity<ReportCardTemplate>(entity =>
            {
                entity.ToTable("ReportCard_Template");

                entity.Property(e => e.ReportCardTemplateId)
                    .ValueGeneratedNever()
                    .HasColumnName("Report_Card_Template_ID");

                entity.Property(e => e.ReportCardGrade).HasColumnName("Report_Card_Grade");

                entity.Property(e => e.ReportCardId).HasColumnName("Report_Card_ID");

                entity.HasOne(d => d.ReportCard)
                    .WithMany(p => p.ReportCardTemplates)
                    .HasForeignKey(d => d.ReportCardId)
                    .HasConstraintName("FK__ReportCar__Repor__628FA481");
            });

            modelBuilder.Entity<Schedule>(entity =>
            {
                entity.ToTable("Schedule");

                entity.Property(e => e.ScheduleId)
                    .ValueGeneratedNever()
                    .HasColumnName("Schedule_ID");

                entity.Property(e => e.EventDate)
                    .HasColumnType("date")
                    .HasColumnName("Event_date");

                entity.Property(e => e.ScheduleDetails)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Schedule_details");

                entity.Property(e => e.SchoolId).HasColumnName("School_ID");

                entity.HasOne(d => d.School)
                    .WithMany(p => p.Schedules)
                    .HasForeignKey(d => d.SchoolId)
                    .HasConstraintName("FK__Schedule__School__5812160E");
            });

            modelBuilder.Entity<School>(entity =>
            {
                entity.ToTable("School");

                entity.Property(e => e.SchoolId)
                    .ValueGeneratedNever()
                    .HasColumnName("School_ID");

                entity.Property(e => e.SchoolInfoDetails)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("School_Info_Details");

                entity.Property(e => e.SchoolLocation)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("School_Location");

                entity.Property(e => e.SchoolName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("School_Name");
            });

            modelBuilder.Entity<SchoolFeesStatus>(entity =>
            {
                entity.ToTable("School_Fees_Status");

                entity.Property(e => e.SchoolFeesStatusId)
                    .ValueGeneratedNever()
                    .HasColumnName("School_Fees_Status_ID");

                entity.Property(e => e.ParentGuardianId).HasColumnName("Parent_Guardian_ID");

                entity.Property(e => e.SchoolFeesStatusDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("School_Fees_Status_Description");

                entity.HasOne(d => d.ParentGuardian)
                    .WithMany(p => p.SchoolFeesStatuses)
                    .HasForeignKey(d => d.ParentGuardianId)
                    .HasConstraintName("FK__School_Fe__Paren__123EB7A3");
            });

            modelBuilder.Entity<SchoolTerm>(entity =>
            {
                entity.ToTable("School_Term");

                entity.Property(e => e.SchoolTermId)
                    .ValueGeneratedNever()
                    .HasColumnName("School_Term_ID");

                entity.Property(e => e.ReportCardId).HasColumnName("Report_Card_ID");

                entity.Property(e => e.ScheduleId).HasColumnName("Schedule_ID");

                entity.Property(e => e.StudentId).HasColumnName("Student_ID");

                entity.Property(e => e.TermDetails)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("Term_details");

                entity.HasOne(d => d.ReportCard)
                    .WithMany(p => p.SchoolTerms)
                    .HasForeignKey(d => d.ReportCardId)
                    .HasConstraintName("FK__School_Te__Repor__5FB337D6");

                entity.HasOne(d => d.Schedule)
                    .WithMany(p => p.SchoolTerms)
                    .HasForeignKey(d => d.ScheduleId)
                    .HasConstraintName("FK__School_Te__Sched__5DCAEF64");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.SchoolTerms)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK__School_Te__Stude__5EBF139D");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("Student");

                entity.Property(e => e.StudentId)
                    .ValueGeneratedNever()
                    .HasColumnName("Student_ID");

                entity.Property(e => e.ParentGuardianId).HasColumnName("Parent_Guardian_ID");

                entity.Property(e => e.StudentGrade).HasColumnName("Student_Grade");

                entity.Property(e => e.StudentName)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Student_Name");

                entity.Property(e => e.StudentSurname)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Student_Surname");

                entity.HasOne(d => d.ParentGuardian)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.ParentGuardianId)
                    .HasConstraintName("FK__Student__Parent___4316F928");
            });

            modelBuilder.Entity<StudentAllergy>(entity =>
            {
                entity.HasKey(e => new { e.StudentId, e.AllergyId })
                    .HasName("PK__Student___C771B64585DEEB8A");

                entity.ToTable("Student_Allergy");

                entity.Property(e => e.StudentId).HasColumnName("Student_ID");

                entity.Property(e => e.AllergyId).HasColumnName("Allergy_ID");
            });

            modelBuilder.Entity<StudentClass>(entity =>
            {
                entity.HasKey(e => new { e.StudentId, e.ClassId })
                    .HasName("PK__Student___C9FD99F976B759C9");

                entity.ToTable("Student_Class");

                entity.Property(e => e.StudentId).HasColumnName("Student_ID");

                entity.Property(e => e.ClassId).HasColumnName("Class_ID");
            });

            modelBuilder.Entity<StudentEmergency>(entity =>
            {
                entity.HasKey(e => new { e.StudentId, e.EmergencyId })
                    .HasName("PK__Student___D6E6AB5C6D5B9E66");

                entity.ToTable("Student_Emergency");

                entity.Property(e => e.StudentId).HasColumnName("Student_ID");

                entity.Property(e => e.EmergencyId).HasColumnName("Emergency_ID");
            });

            modelBuilder.Entity<Subcategory>(entity =>
            {
                entity.ToTable("Subcategory");

                entity.Property(e => e.SubcategoryId)
                    .ValueGeneratedNever()
                    .HasColumnName("Subcategory_ID");

                entity.Property(e => e.ProgressCategoryId).HasColumnName("Progress_Category_ID");

                entity.Property(e => e.SubcategoryDetails)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Subcategory_Details");

                entity.HasOne(d => d.ProgressCategory)
                    .WithMany(p => p.Subcategories)
                    .HasForeignKey(d => d.ProgressCategoryId)
                    .HasConstraintName("FK__Subcatego__Progr__73BA3083");
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.ToTable("Supplier");

                entity.Property(e => e.SupplierId)
                    .ValueGeneratedNever()
                    .HasColumnName("Supplier_ID");

                entity.Property(e => e.SupplierAddress)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Supplier_Address");

                entity.Property(e => e.SupplierContactNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Supplier_Contact_No");

                entity.Property(e => e.SupplierEmailAddress)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Supplier_Email_Address");

                entity.Property(e => e.SupplierName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Supplier_Name");
            });

            modelBuilder.Entity<SupplierOrder>(entity =>
            {
                entity.ToTable("Supplier_Order");

                entity.Property(e => e.SupplierOrderId)
                    .ValueGeneratedNever()
                    .HasColumnName("Supplier_Order_ID");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.SchoolId).HasColumnName("School_ID");

                entity.Property(e => e.SupplierId).HasColumnName("Supplier_ID");

                entity.Property(e => e.SupplierOrderDetails)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Supplier_Order_Details");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.SupplierOrders)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK__Supplier___Emplo__208CD6FA");

                entity.HasOne(d => d.School)
                    .WithMany(p => p.SupplierOrders)
                    .HasForeignKey(d => d.SchoolId)
                    .HasConstraintName("FK__Supplier___Schoo__1F98B2C1");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.SupplierOrders)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK__Supplier___Suppl__2180FB33");
            });

            modelBuilder.Entity<Test>(entity =>
            {
                entity.ToTable("Test");

                entity.Property(e => e.TestId)
                    .ValueGeneratedNever()
                    .HasColumnName("Test_ID");

                entity.Property(e => e.ReportCardTemplateId).HasColumnName("Report_Card_Template_ID");

                entity.Property(e => e.TestDetails)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Test_Details");

                entity.HasOne(d => d.ReportCardTemplate)
                    .WithMany(p => p.Tests)
                    .HasForeignKey(d => d.ReportCardTemplateId)
                    .HasConstraintName("FK__Test__Report_Car__656C112C");
            });

            modelBuilder.Entity<Timeslot>(entity =>
            {
                entity.ToTable("Timeslot");

                entity.Property(e => e.TimeslotId)
                    .ValueGeneratedNever()
                    .HasColumnName("Timeslot_ID");

                entity.Property(e => e.TimeslotDetails)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Timeslot_details");
            });

            modelBuilder.Entity<TimeslotScheduleDate>(entity =>
            {
                entity.HasKey(e => new { e.TimeSlotId, e.ScheduleId, e.DateId })
                    .HasName("PK__Timeslot__9B9990FDF10D07E0");

                entity.ToTable("Timeslot_Schedule_Date");

                entity.Property(e => e.TimeSlotId).HasColumnName("TimeSlot_ID");

                entity.Property(e => e.ScheduleId).HasColumnName("Schedule_ID");

                entity.Property(e => e.DateId).HasColumnName("Date_ID");
            });

            modelBuilder.Entity<Title>(entity =>
            {
                entity.ToTable("Title");

                entity.Property(e => e.TitleId)
                    .ValueGeneratedNever()
                    .HasColumnName("Title_ID");

                entity.Property(e => e.Dr)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Mr)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Mrs)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Ms)
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserTbl>(entity =>
            {
                entity.ToTable("User_Tbl");

                entity.Property(e => e.UserTblId)
                    .ValueGeneratedNever()
                    .HasColumnName("User_Tbl_ID");

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.UserTypeId).HasColumnName("User_Type_ID");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.UserType)
                    .WithMany(p => p.UserTbls)
                    .HasForeignKey(d => d.UserTypeId)
                    .HasConstraintName("FK__User_Tbl__User_T__4F7CD00D");
            });

            modelBuilder.Entity<UserType>(entity =>
            {
                entity.ToTable("User_Type");

                entity.Property(e => e.UserTypeId)
                    .ValueGeneratedNever()
                    .HasColumnName("User_Type_ID");

                entity.Property(e => e.UserType1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("User_Type");
            });

            modelBuilder.Entity<ZipCode>(entity =>
            {
                entity.ToTable("Zip_Code");

                entity.Property(e => e.ZipCodeId)
                    .ValueGeneratedNever()
                    .HasColumnName("Zip_Code_ID");

                entity.Property(e => e.ZipCodeDetails)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Zip_Code_Details");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
