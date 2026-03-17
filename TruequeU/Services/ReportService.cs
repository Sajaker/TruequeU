using global::TruequeU.Models;
using global::TruequeU.DAO;
using global::TruequeU.Interfaces;

namespace TruequeU.Services
{
    public class ReportService : IReportService
    {
        private readonly ApplicationDbContext _context;

        public ReportService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Report CreateReport(Guid reporterId, Guid? listingId, Guid? reportedUserId, string reason, string comment)
        {
            var report = new Report
            {
                ReporterId = reporterId,
                ListingId = listingId,
                ReportedUserId = reportedUserId,
                Reason = reason,
                Comment = comment,
                CreatedAt = DateTime.UtcNow,
                Status = "Pending"
            };

            _context.Reports.Add(report);
            _context.SaveChanges();

            return report;
        }

        public List<Report> GetAllReports()
        {
            return _context.Reports.ToList();
        }

        public Report GetReportById(Guid reportId)
        {
            return _context.Reports.FirstOrDefault(r => r.Id == reportId);
        }
    }
}
