using TruequeU.Models;

namespace TruequeU.Interfaces
{
    public interface IReportService
    {
        Report CreateReport(int reporterId, int? listingId, int? reportedUserId, string reason, string comment);

        List<Report> GetAllReports();

        Report GetReportById(int reportId);
    }
}
