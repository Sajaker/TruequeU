using TruequeU.Models;

namespace TruequeU.Interfaces
{
    public interface IReportService
    {
        Report CreateReport(Guid reporterId, Guid? listingId, Guid? reportedUserId, string reason, string comment);

        List<Report> GetAllReports();

        Report GetReportById(Guid reportId);
    }
}
