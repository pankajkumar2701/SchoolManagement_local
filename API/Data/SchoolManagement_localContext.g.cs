using Microsoft.EntityFrameworkCore;
using SchoolManagement_local.Entities;

namespace SchoolManagement_local.Data
{
    public class SchoolManagement_localContext : DbContext
    {
        protected override void OnConfiguring(Microsoft.EntityFrameworkCore.DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-GFUVFUP;Initial Catalog=T754323_SchoolManagement_local;Persist Security Info=True;user id=pankazz;password=123456;Integrated Security=false;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserInRole>().HasKey(a => a.Id);
            modelBuilder.Entity<UserToken>().HasKey(a => a.Id);
            modelBuilder.Entity<RoleEntitlement>().HasKey(a => a.Id);
            modelBuilder.Entity<Entity>().HasKey(a => a.Id);
            modelBuilder.Entity<Tenant>().HasKey(a => a.Id);
            modelBuilder.Entity<User>().HasKey(a => a.Id);
            modelBuilder.Entity<Role>().HasKey(a => a.Id);
            modelBuilder.Entity<Student>().HasKey(a => a.Id);
            modelBuilder.Entity<ParentGuardian>().HasKey(a => a.Id);
            modelBuilder.Entity<ContactInformation>().HasKey(a => a.Id);
            modelBuilder.Entity<Address>().HasKey(a => a.Id);
            modelBuilder.Entity<Course>().HasKey(a => a.Id);
            modelBuilder.Entity<Enrollment>().HasKey(a => a.Id);
            modelBuilder.Entity<Attendance>().HasKey(a => a.Id);
            modelBuilder.Entity<Grade>().HasKey(a => a.Id);
            modelBuilder.Entity<Transcript>().HasKey(a => a.Id);
            modelBuilder.Entity<Assignment>().HasKey(a => a.Id);
            modelBuilder.Entity<Exam>().HasKey(a => a.Id);
            modelBuilder.Entity<ExtraCurricularActivity>().HasKey(a => a.Id);
            modelBuilder.Entity<Schedule>().HasKey(a => a.Id);
            modelBuilder.Entity<Fee>().HasKey(a => a.Id);
            modelBuilder.Entity<Payment>().HasKey(a => a.Id);
            modelBuilder.Entity<Discount>().HasKey(a => a.Id);
            modelBuilder.Entity<Billing>().HasKey(a => a.Id);
            modelBuilder.Entity<ReportCard>().HasKey(a => a.Id);
            modelBuilder.Entity<AcademicYear>().HasKey(a => a.Id);
            modelBuilder.Entity<Semester>().HasKey(a => a.Id);
            modelBuilder.Entity<Class>().HasKey(a => a.Id);
            modelBuilder.Entity<Section>().HasKey(a => a.Id);
            modelBuilder.Entity<Classroom>().HasKey(a => a.Id);
            modelBuilder.Entity<Faculty>().HasKey(a => a.Id);
            modelBuilder.Entity<Staff>().HasKey(a => a.Id);
            modelBuilder.Entity<NoticeBoard>().HasKey(a => a.Id);
            modelBuilder.Entity<SchoolEvents>().HasKey(a => a.Id);
            modelBuilder.Entity<Library>().HasKey(a => a.Id);
            modelBuilder.Entity<DocumentTypes>().HasKey(a => a.Id);
            modelBuilder.Entity<StudentDocuments>().HasKey(a => a.Id);
            modelBuilder.Entity<Employee>().HasKey(a => a.Id);
            modelBuilder.Entity<Department>().HasKey(a => a.Id);
            modelBuilder.Entity<JobTitle>().HasKey(a => a.Id);
            modelBuilder.Entity<EmploymentStatus>().HasKey(a => a.Id);
            modelBuilder.Entity<Shift>().HasKey(a => a.Id);
            modelBuilder.Entity<TimeOffRequest>().HasKey(a => a.Id);
            modelBuilder.Entity<Leave>().HasKey(a => a.Id);
            modelBuilder.Entity<PerformanceReview>().HasKey(a => a.Id);
            modelBuilder.Entity<Payroll>().HasKey(a => a.Id);
            modelBuilder.Entity<Salary>().HasKey(a => a.Id);
            modelBuilder.Entity<Benefits>().HasKey(a => a.Id);
            modelBuilder.Entity<Skill>().HasKey(a => a.Id);
            modelBuilder.Entity<Training>().HasKey(a => a.Id);
            modelBuilder.Entity<Document>().HasKey(a => a.Id);
            modelBuilder.Entity<EmergencyContact>().HasKey(a => a.Id);
            modelBuilder.Entity<WorkAnnouncement>().HasKey(a => a.Id);
            modelBuilder.Entity<Teacher>().HasKey(a => a.Id);
            modelBuilder.Entity<Students>().HasKey(a => a.Id);
            modelBuilder.Entity<CourseSchedule>().HasKey(a => a.Id);
            modelBuilder.Entity<Instructor>().HasKey(a => a.Id);
            modelBuilder.Entity<Room>().HasKey(a => a.Id);
            modelBuilder.Entity<Building>().HasKey(a => a.Id);
            modelBuilder.Entity<Campus>().HasKey(a => a.Id);
            modelBuilder.Entity<AcademicSession>().HasKey(a => a.Id);
            modelBuilder.Entity<ClassPeriod>().HasKey(a => a.Id);
            modelBuilder.Entity<TimetableTemplate>().HasKey(a => a.Id);
            modelBuilder.Entity<Holidays>().HasKey(a => a.Id);
            modelBuilder.Entity<Breaks>().HasKey(a => a.Id);
            modelBuilder.Entity<ClassType>().HasKey(a => a.Id);
            modelBuilder.Entity<ConflictResolution>().HasKey(a => a.Id);
            modelBuilder.Entity<MeetingPattern>().HasKey(a => a.Id);
            modelBuilder.Entity<ResourceAllocation>().HasKey(a => a.Id);
            modelBuilder.Entity<TimeSlot>().HasKey(a => a.Id);
            modelBuilder.Entity<TimeConstraints>().HasKey(a => a.Id);
            modelBuilder.Entity<Resource>().HasKey(a => a.Id);
            modelBuilder.Entity<TimeLog>().HasKey(a => a.Id);
            modelBuilder.Entity<WorkSchedule>().HasKey(a => a.Id);
            modelBuilder.Entity<Absence>().HasKey(a => a.Id);
            modelBuilder.Entity<AbsenceType>().HasKey(a => a.Id);
            modelBuilder.Entity<Overtime>().HasKey(a => a.Id);
            modelBuilder.Entity<TimeOff>().HasKey(a => a.Id);
            modelBuilder.Entity<TimeOffApproval>().HasKey(a => a.Id);
            modelBuilder.Entity<LeaveBalance>().HasKey(a => a.Id);
            modelBuilder.Entity<PayPeriod>().HasKey(a => a.Id);
            modelBuilder.Entity<AttendanceReport>().HasKey(a => a.Id);
            modelBuilder.Entity<AttendancePolicy>().HasKey(a => a.Id);
            modelBuilder.Entity<LeaveType>().HasKey(a => a.Id);
            modelBuilder.Entity<FeeCategory>().HasKey(a => a.Id);
            modelBuilder.Entity<FeeItem>().HasKey(a => a.Id);
            modelBuilder.Entity<FeeSchedule>().HasKey(a => a.Id);
            modelBuilder.Entity<Invoice>().HasKey(a => a.Id);
            modelBuilder.Entity<InvoiceLineItem>().HasKey(a => a.Id);
            modelBuilder.Entity<PaymentMethod>().HasKey(a => a.Id);
            modelBuilder.Entity<Currency>().HasKey(a => a.Id);
            modelBuilder.Entity<Tax>().HasKey(a => a.Id);
            modelBuilder.Entity<BillingFrequency>().HasKey(a => a.Id);
            modelBuilder.Entity<FinancialAccount>().HasKey(a => a.Id);
            modelBuilder.Entity<AccountTransaction>().HasKey(a => a.Id);
            modelBuilder.Entity<AccountReconciliation>().HasKey(a => a.Id);
            modelBuilder.Entity<PaymentGateway>().HasKey(a => a.Id);
            modelBuilder.Entity<PaymentStatus>().HasKey(a => a.Id);
            modelBuilder.Entity<LateFee>().HasKey(a => a.Id);
            modelBuilder.Entity<Refund>().HasKey(a => a.Id);
            modelBuilder.Entity<PaymentTerms>().HasKey(a => a.Id);
            modelBuilder.Entity<BillingCycle>().HasKey(a => a.Id);
            modelBuilder.Entity<FeeAdjustment>().HasKey(a => a.Id);
            modelBuilder.Entity<School>().HasKey(a => a.Id);
            modelBuilder.Entity<Term>().HasKey(a => a.Id);
            modelBuilder.Entity<Installment>().HasKey(a => a.Id);
            modelBuilder.Entity<FeeWaiver>().HasKey(a => a.Id);
            modelBuilder.Entity<ExamSchedule>().HasKey(a => a.Id);
            modelBuilder.Entity<Result>().HasKey(a => a.Id);
            modelBuilder.Entity<ResultDetails>().HasKey(a => a.Id);
            modelBuilder.Entity<ExamSubject>().HasKey(a => a.Id);
            modelBuilder.Entity<Question>().HasKey(a => a.Id);
            modelBuilder.Entity<Answer>().HasKey(a => a.Id);
            modelBuilder.Entity<QuestionType>().HasKey(a => a.Id);
            modelBuilder.Entity<QuestionCategory>().HasKey(a => a.Id);
            modelBuilder.Entity<ExamRoom>().HasKey(a => a.Id);
            modelBuilder.Entity<GradingScale>().HasKey(a => a.Id);
            modelBuilder.Entity<Examiner>().HasKey(a => a.Id);
            modelBuilder.Entity<ExaminationBoard>().HasKey(a => a.Id);
            modelBuilder.Entity<ExamSession>().HasKey(a => a.Id);
            modelBuilder.Entity<ExamPaper>().HasKey(a => a.Id);
            modelBuilder.Entity<MarksDistribution>().HasKey(a => a.Id);
            modelBuilder.Entity<AttendanceStatus>().HasKey(a => a.Id);
            modelBuilder.Entity<Certificate>().HasKey(a => a.Id);
            modelBuilder.Entity<ExamResultNotification>().HasKey(a => a.Id);
            modelBuilder.Entity<EvaluationCriteria>().HasKey(a => a.Id);
            modelBuilder.Entity<ExamResultTemplate>().HasKey(a => a.Id);
            modelBuilder.Entity<Email>().HasKey(a => a.Id);
            modelBuilder.Entity<Chat>().HasKey(a => a.Id);
            modelBuilder.Entity<Calendar>().HasKey(a => a.Id);
            modelBuilder.Entity<Meeting>().HasKey(a => a.Id);
            modelBuilder.Entity<Event>().HasKey(a => a.Id);
            modelBuilder.Entity<Contact>().HasKey(a => a.Id);
            modelBuilder.Entity<Folder>().HasKey(a => a.Id);
            modelBuilder.Entity<Message>().HasKey(a => a.Id);
            modelBuilder.Entity<Notification>().HasKey(a => a.Id);
            modelBuilder.Entity<Project>().HasKey(a => a.Id);
            modelBuilder.Entity<Workspace>().HasKey(a => a.Id);
            modelBuilder.Entity<Content>().HasKey(a => a.Id);
            modelBuilder.Entity<KnowledgeBase>().HasKey(a => a.Id);
            modelBuilder.Entity<Comment>().HasKey(a => a.Id);
            modelBuilder.Entity<Poll>().HasKey(a => a.Id);
            modelBuilder.Entity<Survey>().HasKey(a => a.Id);
            modelBuilder.Entity<Attachment>().HasKey(a => a.Id);
            modelBuilder.Entity<Channel>().HasKey(a => a.Id);
            modelBuilder.Entity<Discussion>().HasKey(a => a.Id);
            modelBuilder.Entity<VideoConference>().HasKey(a => a.Id);
            modelBuilder.Entity<Agenda>().HasKey(a => a.Id);
            modelBuilder.Entity<Minutes>().HasKey(a => a.Id);
            modelBuilder.Entity<StatusUpdate>().HasKey(a => a.Id);
            modelBuilder.Entity<ActivityFeed>().HasKey(a => a.Id);
            modelBuilder.Entity<Tag>().HasKey(a => a.Id);
            modelBuilder.Entity<Category>().HasKey(a => a.Id);
            modelBuilder.Entity<Versioning>().HasKey(a => a.Id);
            modelBuilder.Entity<DocumentType>().HasKey(a => a.Id);
            modelBuilder.Entity<DocumentCategory>().HasKey(a => a.Id);
            modelBuilder.Entity<DocumentStatus>().HasKey(a => a.Id);
            modelBuilder.Entity<DocumentVersion>().HasKey(a => a.Id);
            modelBuilder.Entity<ResourceType>().HasKey(a => a.Id);
            modelBuilder.Entity<ResourceCategory>().HasKey(a => a.Id);
            modelBuilder.Entity<ResourceStatus>().HasKey(a => a.Id);
            modelBuilder.Entity<AccessLevel>().HasKey(a => a.Id);
            modelBuilder.Entity<Tags>().HasKey(a => a.Id);
            modelBuilder.Entity<FileStorage>().HasKey(a => a.Id);
            modelBuilder.Entity<Share>().HasKey(a => a.Id);
            modelBuilder.Entity<History>().HasKey(a => a.Id);
            modelBuilder.Entity<Permissions>().HasKey(a => a.Id);
            modelBuilder.Entity<Workflow>().HasKey(a => a.Id);
            modelBuilder.Entity<Approval>().HasKey(a => a.Id);
            modelBuilder.Entity<WorkflowStep>().HasKey(a => a.Id);
            modelBuilder.Entity<StorageProvider>().HasKey(a => a.Id);
            modelBuilder.Entity<SearchCriteria>().HasKey(a => a.Id);
            modelBuilder.Entity<DocumentTemplate>().HasKey(a => a.Id);
            modelBuilder.Entity<ResourceRequest>().HasKey(a => a.Id);
            modelBuilder.Entity<ResourceBooking>().HasKey(a => a.Id);
            modelBuilder.Entity<DocumentArchive>().HasKey(a => a.Id);
            modelBuilder.Entity<ArchiveLocation>().HasKey(a => a.Id);
            modelBuilder.Entity<RetentionSchedule>().HasKey(a => a.Id);
            modelBuilder.Entity<ReviewSchedule>().HasKey(a => a.Id);
            modelBuilder.Entity<AuditTrail>().HasKey(a => a.Id);
            modelBuilder.Entity<AutoClassification>().HasKey(a => a.Id);
            modelBuilder.Entity<Collaborator>().HasKey(a => a.Id);
            modelBuilder.Entity<UserInRole>().HasOne(a => a.TenantId_Tenant).WithMany().HasForeignKey(c => c.TenantId);
            modelBuilder.Entity<UserInRole>().HasOne(a => a.RoleId_Role).WithMany().HasForeignKey(c => c.RoleId);
            modelBuilder.Entity<UserInRole>().HasOne(a => a.UserId_User).WithMany().HasForeignKey(c => c.UserId);
            modelBuilder.Entity<UserInRole>().HasOne(a => a.CreatedBy_User).WithMany().HasForeignKey(c => c.CreatedBy);
            modelBuilder.Entity<UserInRole>().HasOne(a => a.UpdatedBy_User).WithMany().HasForeignKey(c => c.UpdatedBy);
            modelBuilder.Entity<UserToken>().HasOne(a => a.TenantId_Tenant).WithMany().HasForeignKey(c => c.TenantId);
            modelBuilder.Entity<UserToken>().HasOne(a => a.UserId_User).WithMany().HasForeignKey(c => c.UserId);
            modelBuilder.Entity<RoleEntitlement>().HasOne(a => a.TenantId_Tenant).WithMany().HasForeignKey(c => c.TenantId);
            modelBuilder.Entity<RoleEntitlement>().HasOne(a => a.RoleId_Role).WithMany().HasForeignKey(c => c.RoleId);
            modelBuilder.Entity<RoleEntitlement>().HasOne(a => a.EntityId_Entity).WithMany().HasForeignKey(c => c.EntityId);
            modelBuilder.Entity<RoleEntitlement>().HasOne(a => a.CreatedBy_User).WithMany().HasForeignKey(c => c.CreatedBy);
            modelBuilder.Entity<RoleEntitlement>().HasOne(a => a.UpdatedBy_User).WithMany().HasForeignKey(c => c.UpdatedBy);
            modelBuilder.Entity<Entity>().HasOne(a => a.TenantId_Tenant).WithMany().HasForeignKey(c => c.TenantId);
            modelBuilder.Entity<Entity>().HasOne(a => a.CreatedBy_User).WithMany().HasForeignKey(c => c.CreatedBy);
            modelBuilder.Entity<Entity>().HasOne(a => a.UpdatedBy_User).WithMany().HasForeignKey(c => c.UpdatedBy);
            modelBuilder.Entity<User>().HasOne(a => a.TenantId_Tenant).WithMany().HasForeignKey(c => c.TenantId);
            modelBuilder.Entity<Role>().HasOne(a => a.TenantId_Tenant).WithMany().HasForeignKey(c => c.TenantId);
            modelBuilder.Entity<Role>().HasOne(a => a.CreatedBy_User).WithMany().HasForeignKey(c => c.CreatedBy);
            modelBuilder.Entity<Role>().HasOne(a => a.UpdatedBy_User).WithMany().HasForeignKey(c => c.UpdatedBy);
            modelBuilder.Entity<ParentGuardian>().HasOne(a => a.ContactInformationId_ContactInformation).WithMany().HasForeignKey(c => c.ContactInformationId);
            modelBuilder.Entity<ParentGuardian>().HasOne(a => a.AddressId_Address).WithMany().HasForeignKey(c => c.AddressId);
            modelBuilder.Entity<Enrollment>().HasOne(a => a.StudentId_Student).WithMany().HasForeignKey(c => c.StudentId);
            modelBuilder.Entity<Enrollment>().HasOne(a => a.CourseId_Course).WithMany().HasForeignKey(c => c.CourseId);
            modelBuilder.Entity<Attendance>().HasOne(a => a.StudentId_Student).WithMany().HasForeignKey(c => c.StudentId);
            modelBuilder.Entity<Transcript>().HasOne(a => a.StudentId_Student).WithMany().HasForeignKey(c => c.StudentId);
            modelBuilder.Entity<Transcript>().HasOne(a => a.CourseId_Course).WithMany().HasForeignKey(c => c.CourseId);
            modelBuilder.Entity<Transcript>().HasOne(a => a.GradeId_Grade).WithMany().HasForeignKey(c => c.GradeId);
            modelBuilder.Entity<Assignment>().HasOne(a => a.CourseId_Course).WithMany().HasForeignKey(c => c.CourseId);
            modelBuilder.Entity<Schedule>().HasOne(a => a.CourseId_Course).WithMany().HasForeignKey(c => c.CourseId);
            modelBuilder.Entity<Fee>().HasOne(a => a.StudentId_Student).WithMany().HasForeignKey(c => c.StudentId);
            modelBuilder.Entity<Payment>().HasOne(a => a.BillingId_Billing).WithMany().HasForeignKey(c => c.BillingId);
            modelBuilder.Entity<Billing>().HasOne(a => a.DiscountId_Discount).WithMany().HasForeignKey(c => c.DiscountId);
            modelBuilder.Entity<ReportCard>().HasOne(a => a.ClassId_Class).WithMany().HasForeignKey(c => c.ClassId);
            modelBuilder.Entity<Semester>().HasOne(a => a.AcademicYearId_AcademicYear).WithMany().HasForeignKey(c => c.AcademicYearId);
            modelBuilder.Entity<Class>().HasOne(a => a.SemesterId_Semester).WithMany().HasForeignKey(c => c.SemesterId);
            modelBuilder.Entity<Classroom>().HasOne(a => a.SectionId_Section).WithMany().HasForeignKey(c => c.SectionId);
            modelBuilder.Entity<StudentDocuments>().HasOne(a => a.StudentId_Student).WithMany().HasForeignKey(c => c.StudentId);
            modelBuilder.Entity<StudentDocuments>().HasOne(a => a.DocumentTypeId_DocumentTypes).WithMany().HasForeignKey(c => c.DocumentTypeId);
            modelBuilder.Entity<TimeOffRequest>().HasOne(a => a.EmployeeId_Employee).WithMany().HasForeignKey(c => c.EmployeeId);
            modelBuilder.Entity<TimeOffRequest>().HasOne(a => a.LeaveId_Leave).WithMany().HasForeignKey(c => c.LeaveId);
            modelBuilder.Entity<PerformanceReview>().HasOne(a => a.EmployeeId_Employee).WithMany().HasForeignKey(c => c.EmployeeId);
            modelBuilder.Entity<Payroll>().HasOne(a => a.EmployeeId_Employee).WithMany().HasForeignKey(c => c.EmployeeId);
            modelBuilder.Entity<Payroll>().HasOne(a => a.SalaryId_Salary).WithMany().HasForeignKey(c => c.SalaryId);
            modelBuilder.Entity<Payroll>().HasOne(a => a.BenefitsId_Benefits).WithMany().HasForeignKey(c => c.BenefitsId);
            modelBuilder.Entity<Document>().HasOne(a => a.DocumentTypeId_DocumentType).WithMany().HasForeignKey(c => c.DocumentTypeId);
            modelBuilder.Entity<Document>().HasOne(a => a.DocumentCategoryId_DocumentCategory).WithMany().HasForeignKey(c => c.DocumentCategoryId);
            modelBuilder.Entity<Document>().HasOne(a => a.DocumentStatusId_DocumentStatus).WithMany().HasForeignKey(c => c.DocumentStatusId);
            modelBuilder.Entity<Document>().HasOne(a => a.DocumentVersionId_DocumentVersion).WithMany().HasForeignKey(c => c.DocumentVersionId);
            modelBuilder.Entity<EmergencyContact>().HasOne(a => a.StudentId_Student).WithMany().HasForeignKey(c => c.StudentId);
            modelBuilder.Entity<WorkAnnouncement>().HasOne(a => a.TeacherId_Teacher).WithMany().HasForeignKey(c => c.TeacherId);
            modelBuilder.Entity<WorkAnnouncement>().HasOne(a => a.CourseId_Course).WithMany().HasForeignKey(c => c.CourseId);
            modelBuilder.Entity<CourseSchedule>().HasOne(a => a.CourseId_Course).WithMany().HasForeignKey(c => c.CourseId);
            modelBuilder.Entity<CourseSchedule>().HasOne(a => a.RoomId_Room).WithMany().HasForeignKey(c => c.RoomId);
            modelBuilder.Entity<Room>().HasOne(a => a.BuildingId_Building).WithMany().HasForeignKey(c => c.BuildingId);
            modelBuilder.Entity<Building>().HasOne(a => a.CampusId_Campus).WithMany().HasForeignKey(c => c.CampusId);
            modelBuilder.Entity<ResourceAllocation>().HasOne(a => a.ResourceId_Resource).WithMany().HasForeignKey(c => c.ResourceId);
            modelBuilder.Entity<ResourceAllocation>().HasOne(a => a.TimeSlotId_TimeSlot).WithMany().HasForeignKey(c => c.TimeSlotId);
            modelBuilder.Entity<TimeConstraints>().HasOne(a => a.ResourceId_Resource).WithMany().HasForeignKey(c => c.ResourceId);
            modelBuilder.Entity<Resource>().HasOne(a => a.ResourceType_ResourceType).WithMany().HasForeignKey(c => c.ResourceType);
            modelBuilder.Entity<TimeLog>().HasOne(a => a.WorkScheduleId_WorkSchedule).WithMany().HasForeignKey(c => c.WorkScheduleId);
            modelBuilder.Entity<Absence>().HasOne(a => a.AbsenceTypeId_AbsenceType).WithMany().HasForeignKey(c => c.AbsenceTypeId);
            modelBuilder.Entity<TimeOff>().HasOne(a => a.TimeOffApprovalId_TimeOffApproval).WithMany().HasForeignKey(c => c.TimeOffApprovalId);
            modelBuilder.Entity<TimeOffApproval>().HasOne(a => a.TimeOffId_TimeOff).WithMany().HasForeignKey(c => c.TimeOffId);
            modelBuilder.Entity<LeaveBalance>().HasOne(a => a.EmployeeId_Employee).WithMany().HasForeignKey(c => c.EmployeeId);
            modelBuilder.Entity<LeaveBalance>().HasOne(a => a.LeaveTypeId_LeaveType).WithMany().HasForeignKey(c => c.LeaveTypeId);
            modelBuilder.Entity<AttendanceReport>().HasOne(a => a.EmployeeId_Employee).WithMany().HasForeignKey(c => c.EmployeeId);
            modelBuilder.Entity<FeeItem>().HasOne(a => a.FeeCategoryId_FeeCategory).WithMany().HasForeignKey(c => c.FeeCategoryId);
            modelBuilder.Entity<FeeSchedule>().HasOne(a => a.FeeItemId_FeeItem).WithMany().HasForeignKey(c => c.FeeItemId);
            modelBuilder.Entity<Invoice>().HasOne(a => a.CurrencyId_Currency).WithMany().HasForeignKey(c => c.CurrencyId);
            modelBuilder.Entity<Invoice>().HasOne(a => a.PaymentMethodId_PaymentMethod).WithMany().HasForeignKey(c => c.PaymentMethodId);
            modelBuilder.Entity<InvoiceLineItem>().HasOne(a => a.InvoiceId_Invoice).WithMany().HasForeignKey(c => c.InvoiceId);
            modelBuilder.Entity<InvoiceLineItem>().HasOne(a => a.FeeItemId_FeeItem).WithMany().HasForeignKey(c => c.FeeItemId);
            modelBuilder.Entity<AccountTransaction>().HasOne(a => a.FinancialAccountId_FinancialAccount).WithMany().HasForeignKey(c => c.FinancialAccountId);
            modelBuilder.Entity<AccountReconciliation>().HasOne(a => a.FinancialAccountId_FinancialAccount).WithMany().HasForeignKey(c => c.FinancialAccountId);
            modelBuilder.Entity<Installment>().HasOne(a => a.TermId_Term).WithMany().HasForeignKey(c => c.TermId);
            modelBuilder.Entity<ExamSchedule>().HasOne(a => a.ExamId_Exam).WithMany().HasForeignKey(c => c.ExamId);
            modelBuilder.Entity<ExamSchedule>().HasOne(a => a.ExamSubjectId_ExamSubject).WithMany().HasForeignKey(c => c.ExamSubjectId);
            modelBuilder.Entity<ResultDetails>().HasOne(a => a.ResultId_Result).WithMany().HasForeignKey(c => c.ResultId);
            modelBuilder.Entity<ResultDetails>().HasOne(a => a.ExamSubjectId_ExamSubject).WithMany().HasForeignKey(c => c.ExamSubjectId);
            modelBuilder.Entity<Question>().HasOne(a => a.ExamSubjectId_ExamSubject).WithMany().HasForeignKey(c => c.ExamSubjectId);
            modelBuilder.Entity<Answer>().HasOne(a => a.QuestionId_Question).WithMany().HasForeignKey(c => c.QuestionId);
            modelBuilder.Entity<MarksDistribution>().HasOne(a => a.ExamPaperId_ExamPaper).WithMany().HasForeignKey(c => c.ExamPaperId);
            modelBuilder.Entity<ExamResultNotification>().HasOne(a => a.ExamPaperId_ExamPaper).WithMany().HasForeignKey(c => c.ExamPaperId);
            modelBuilder.Entity<Folder>().HasOne(a => a.ParentFolderId_Folder).WithMany().HasForeignKey(c => c.ParentFolderId);
            modelBuilder.Entity<Message>().HasOne(a => a.SenderId_Workspace).WithMany().HasForeignKey(c => c.SenderId);
            modelBuilder.Entity<Message>().HasOne(a => a.RecipientId_Workspace).WithMany().HasForeignKey(c => c.RecipientId);
            modelBuilder.Entity<Notification>().HasOne(a => a.UserId_Workspace).WithMany().HasForeignKey(c => c.UserId);
            modelBuilder.Entity<Content>().HasOne(a => a.KnowledgeBaseId_KnowledgeBase).WithMany().HasForeignKey(c => c.KnowledgeBaseId);
            modelBuilder.Entity<Comment>().HasOne(a => a.ContentId_Content).WithMany().HasForeignKey(c => c.ContentId);
            modelBuilder.Entity<Attachment>().HasOne(a => a.ContentId_Content).WithMany().HasForeignKey(c => c.ContentId);
            modelBuilder.Entity<Agenda>().HasOne(a => a.StatusUpdateId_StatusUpdate).WithMany().HasForeignKey(c => c.StatusUpdateId);
            modelBuilder.Entity<Minutes>().HasOne(a => a.VideoConferenceId_VideoConference).WithMany().HasForeignKey(c => c.VideoConferenceId);
            modelBuilder.Entity<Share>().HasOne(a => a.ResourceId_FileStorage).WithMany().HasForeignKey(c => c.ResourceId);
            modelBuilder.Entity<Share>().HasOne(a => a.AccessLevelId_AccessLevel).WithMany().HasForeignKey(c => c.AccessLevelId);
            modelBuilder.Entity<Workflow>().HasOne(a => a.ApprovalId_Approval).WithMany().HasForeignKey(c => c.ApprovalId);
            modelBuilder.Entity<WorkflowStep>().HasOne(a => a.WorkflowId_Workflow).WithMany().HasForeignKey(c => c.WorkflowId);
            modelBuilder.Entity<ResourceBooking>().HasOne(a => a.ResourceRequestId_ResourceRequest).WithMany().HasForeignKey(c => c.ResourceRequestId);
            modelBuilder.Entity<DocumentArchive>().HasOne(a => a.ArchiveLocationId_ArchiveLocation).WithMany().HasForeignKey(c => c.ArchiveLocationId);
            modelBuilder.Entity<DocumentArchive>().HasOne(a => a.RetentionScheduleId_RetentionSchedule).WithMany().HasForeignKey(c => c.RetentionScheduleId);
            modelBuilder.Entity<DocumentArchive>().HasOne(a => a.ReviewScheduleId_ReviewSchedule).WithMany().HasForeignKey(c => c.ReviewScheduleId);
            modelBuilder.Entity<Collaborator>().HasOne(a => a.ProjectId_Project).WithMany().HasForeignKey(c => c.ProjectId);
        }

        public DbSet<UserInRole> UserInRole { get; set; }
        public DbSet<UserToken> UserToken { get; set; }
        public DbSet<RoleEntitlement> RoleEntitlement { get; set; }
        public DbSet<Entity> Entity { get; set; }
        public DbSet<Tenant> Tenant { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<ParentGuardian> ParentGuardian { get; set; }
        public DbSet<ContactInformation> ContactInformation { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<Enrollment> Enrollment { get; set; }
        public DbSet<Attendance> Attendance { get; set; }
        public DbSet<Grade> Grade { get; set; }
        public DbSet<Transcript> Transcript { get; set; }
        public DbSet<Assignment> Assignment { get; set; }
        public DbSet<Exam> Exam { get; set; }
        public DbSet<ExtraCurricularActivity> ExtraCurricularActivity { get; set; }
        public DbSet<Schedule> Schedule { get; set; }
        public DbSet<Fee> Fee { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<Discount> Discount { get; set; }
        public DbSet<Billing> Billing { get; set; }
        public DbSet<ReportCard> ReportCard { get; set; }
        public DbSet<AcademicYear> AcademicYear { get; set; }
        public DbSet<Semester> Semester { get; set; }
        public DbSet<Class> Class { get; set; }
        public DbSet<Section> Section { get; set; }
        public DbSet<Classroom> Classroom { get; set; }
        public DbSet<Faculty> Faculty { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<NoticeBoard> NoticeBoard { get; set; }
        public DbSet<SchoolEvents> SchoolEvents { get; set; }
        public DbSet<Library> Library { get; set; }
        public DbSet<DocumentTypes> DocumentTypes { get; set; }
        public DbSet<StudentDocuments> StudentDocuments { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<JobTitle> JobTitle { get; set; }
        public DbSet<EmploymentStatus> EmploymentStatus { get; set; }
        public DbSet<Shift> Shift { get; set; }
        public DbSet<TimeOffRequest> TimeOffRequest { get; set; }
        public DbSet<Leave> Leave { get; set; }
        public DbSet<PerformanceReview> PerformanceReview { get; set; }
        public DbSet<Payroll> Payroll { get; set; }
        public DbSet<Salary> Salary { get; set; }
        public DbSet<Benefits> Benefits { get; set; }
        public DbSet<Skill> Skill { get; set; }
        public DbSet<Training> Training { get; set; }
        public DbSet<Document> Document { get; set; }
        public DbSet<EmergencyContact> EmergencyContact { get; set; }
        public DbSet<WorkAnnouncement> WorkAnnouncement { get; set; }
        public DbSet<Teacher> Teacher { get; set; }
        public DbSet<Students> Students { get; set; }
        public DbSet<CourseSchedule> CourseSchedule { get; set; }
        public DbSet<Instructor> Instructor { get; set; }
        public DbSet<Room> Room { get; set; }
        public DbSet<Building> Building { get; set; }
        public DbSet<Campus> Campus { get; set; }
        public DbSet<AcademicSession> AcademicSession { get; set; }
        public DbSet<ClassPeriod> ClassPeriod { get; set; }
        public DbSet<TimetableTemplate> TimetableTemplate { get; set; }
        public DbSet<Holidays> Holidays { get; set; }
        public DbSet<Breaks> Breaks { get; set; }
        public DbSet<ClassType> ClassType { get; set; }
        public DbSet<ConflictResolution> ConflictResolution { get; set; }
        public DbSet<MeetingPattern> MeetingPattern { get; set; }
        public DbSet<ResourceAllocation> ResourceAllocation { get; set; }
        public DbSet<TimeSlot> TimeSlot { get; set; }
        public DbSet<TimeConstraints> TimeConstraints { get; set; }
        public DbSet<Resource> Resource { get; set; }
        public DbSet<TimeLog> TimeLog { get; set; }
        public DbSet<WorkSchedule> WorkSchedule { get; set; }
        public DbSet<Absence> Absence { get; set; }
        public DbSet<AbsenceType> AbsenceType { get; set; }
        public DbSet<Overtime> Overtime { get; set; }
        public DbSet<TimeOff> TimeOff { get; set; }
        public DbSet<TimeOffApproval> TimeOffApproval { get; set; }
        public DbSet<LeaveBalance> LeaveBalance { get; set; }
        public DbSet<PayPeriod> PayPeriod { get; set; }
        public DbSet<AttendanceReport> AttendanceReport { get; set; }
        public DbSet<AttendancePolicy> AttendancePolicy { get; set; }
        public DbSet<LeaveType> LeaveType { get; set; }
        public DbSet<FeeCategory> FeeCategory { get; set; }
        public DbSet<FeeItem> FeeItem { get; set; }
        public DbSet<FeeSchedule> FeeSchedule { get; set; }
        public DbSet<Invoice> Invoice { get; set; }
        public DbSet<InvoiceLineItem> InvoiceLineItem { get; set; }
        public DbSet<PaymentMethod> PaymentMethod { get; set; }
        public DbSet<Currency> Currency { get; set; }
        public DbSet<Tax> Tax { get; set; }
        public DbSet<BillingFrequency> BillingFrequency { get; set; }
        public DbSet<FinancialAccount> FinancialAccount { get; set; }
        public DbSet<AccountTransaction> AccountTransaction { get; set; }
        public DbSet<AccountReconciliation> AccountReconciliation { get; set; }
        public DbSet<PaymentGateway> PaymentGateway { get; set; }
        public DbSet<PaymentStatus> PaymentStatus { get; set; }
        public DbSet<LateFee> LateFee { get; set; }
        public DbSet<Refund> Refund { get; set; }
        public DbSet<PaymentTerms> PaymentTerms { get; set; }
        public DbSet<BillingCycle> BillingCycle { get; set; }
        public DbSet<FeeAdjustment> FeeAdjustment { get; set; }
        public DbSet<School> School { get; set; }
        public DbSet<Term> Term { get; set; }
        public DbSet<Installment> Installment { get; set; }
        public DbSet<FeeWaiver> FeeWaiver { get; set; }
        public DbSet<ExamSchedule> ExamSchedule { get; set; }
        public DbSet<Result> Result { get; set; }
        public DbSet<ResultDetails> ResultDetails { get; set; }
        public DbSet<ExamSubject> ExamSubject { get; set; }
        public DbSet<Question> Question { get; set; }
        public DbSet<Answer> Answer { get; set; }
        public DbSet<QuestionType> QuestionType { get; set; }
        public DbSet<QuestionCategory> QuestionCategory { get; set; }
        public DbSet<ExamRoom> ExamRoom { get; set; }
        public DbSet<GradingScale> GradingScale { get; set; }
        public DbSet<Examiner> Examiner { get; set; }
        public DbSet<ExaminationBoard> ExaminationBoard { get; set; }
        public DbSet<ExamSession> ExamSession { get; set; }
        public DbSet<ExamPaper> ExamPaper { get; set; }
        public DbSet<MarksDistribution> MarksDistribution { get; set; }
        public DbSet<AttendanceStatus> AttendanceStatus { get; set; }
        public DbSet<Certificate> Certificate { get; set; }
        public DbSet<ExamResultNotification> ExamResultNotification { get; set; }
        public DbSet<EvaluationCriteria> EvaluationCriteria { get; set; }
        public DbSet<ExamResultTemplate> ExamResultTemplate { get; set; }
        public DbSet<Email> Email { get; set; }
        public DbSet<Chat> Chat { get; set; }
        public DbSet<Calendar> Calendar { get; set; }
        public DbSet<Meeting> Meeting { get; set; }
        public DbSet<Event> Event { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<Folder> Folder { get; set; }
        public DbSet<Message> Message { get; set; }
        public DbSet<Notification> Notification { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<Workspace> Workspace { get; set; }
        public DbSet<Content> Content { get; set; }
        public DbSet<KnowledgeBase> KnowledgeBase { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<Poll> Poll { get; set; }
        public DbSet<Survey> Survey { get; set; }
        public DbSet<Attachment> Attachment { get; set; }
        public DbSet<Channel> Channel { get; set; }
        public DbSet<Discussion> Discussion { get; set; }
        public DbSet<VideoConference> VideoConference { get; set; }
        public DbSet<Agenda> Agenda { get; set; }
        public DbSet<Minutes> Minutes { get; set; }
        public DbSet<StatusUpdate> StatusUpdate { get; set; }
        public DbSet<ActivityFeed> ActivityFeed { get; set; }
        public DbSet<Tag> Tag { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Versioning> Versioning { get; set; }
        public DbSet<DocumentType> DocumentType { get; set; }
        public DbSet<DocumentCategory> DocumentCategory { get; set; }
        public DbSet<DocumentStatus> DocumentStatus { get; set; }
        public DbSet<DocumentVersion> DocumentVersion { get; set; }
        public DbSet<ResourceType> ResourceType { get; set; }
        public DbSet<ResourceCategory> ResourceCategory { get; set; }
        public DbSet<ResourceStatus> ResourceStatus { get; set; }
        public DbSet<AccessLevel> AccessLevel { get; set; }
        public DbSet<Tags> Tags { get; set; }
        public DbSet<FileStorage> FileStorage { get; set; }
        public DbSet<Share> Share { get; set; }
        public DbSet<History> History { get; set; }
        public DbSet<Permissions> Permissions { get; set; }
        public DbSet<Workflow> Workflow { get; set; }
        public DbSet<Approval> Approval { get; set; }
        public DbSet<WorkflowStep> WorkflowStep { get; set; }
        public DbSet<StorageProvider> StorageProvider { get; set; }
        public DbSet<SearchCriteria> SearchCriteria { get; set; }
        public DbSet<DocumentTemplate> DocumentTemplate { get; set; }
        public DbSet<ResourceRequest> ResourceRequest { get; set; }
        public DbSet<ResourceBooking> ResourceBooking { get; set; }
        public DbSet<DocumentArchive> DocumentArchive { get; set; }
        public DbSet<ArchiveLocation> ArchiveLocation { get; set; }
        public DbSet<RetentionSchedule> RetentionSchedule { get; set; }
        public DbSet<ReviewSchedule> ReviewSchedule { get; set; }
        public DbSet<AuditTrail> AuditTrail { get; set; }
        public DbSet<AutoClassification> AutoClassification { get; set; }
        public DbSet<Collaborator> Collaborator { get; set; }
    }
}