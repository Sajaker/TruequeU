using Microsoft.AspNetCore.Mvc;
using TruequeU.Interfaces;
using TruequeU.Models;

namespace TruequeU.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReportController : ControllerBase
    {
        private readonly IReportService _reportService;

        public ReportController(IReportService reportService)
        {
            _reportService = reportService;
        }

        [HttpPost]
        public ActionResult<Report> CreateReport(
            int reporterId,
            int? listingId,
            int? reportedUserId,
            string reason,
            string comment)
        {
            var report = _reportService.CreateReport(
                reporterId,
                listingId,
                reportedUserId,
                reason,
                comment);

            return Ok(report);
        }

        [HttpGet]
        public ActionResult<List<Report>> GetAllReports()
        {
            var reports = _reportService.GetAllReports();
            return Ok(reports);
        }

        [HttpGet("{id}")]
        public ActionResult<Report> GetReport(int id)
        {
            var report = _reportService.GetReportById(id);

            if (report == null)
                return NotFound();

            return Ok(report);
        }
    }
}
