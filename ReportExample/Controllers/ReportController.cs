using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using System.Net.Mime;

namespace ReportExample.Controllers
{
    
    [Route("api/reports")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        private readonly ILogger<ReportController> _logger;

        public ReportController(ILogger<ReportController> logger)
        {
            _logger = logger;
        }

        [Route("/api/reports/DispatchCenters")]
        [HttpGet]
        public async Task<ActionResult> GetDispatchCenterReport(DateTime DateFrom, DateTime DateTo, bool inline = true)
        {            
            List<DCDto> dCDtos = new List<DCDto>();            
            List<DCData> dCDatas1 = new List<DCData>();
            List<DCData> dCDatas2 = new List<DCData>();
            List<DCData> dCDatas3 = new List<DCData>();
            List<DCData> dCDatas4 = new List<DCData>();
            List<DispatcherData> dispatcherDatas1 = new List<DispatcherData>();
            List<DispatcherData> dispatcherDatas2 = new List<DispatcherData>();
            List<DispatcherData> dispatcherDatas3 = new List<DispatcherData>();

            var dispatcher1 = new DispatcherData
            {
                DispatcherId = 1,
                DispatcherName = "Test 1",
                EeoPermitOnEeoElement110kVCount = 0,
                EeoPermitOnEeoElement35kVCount = 2,
                EeoPermitOnEeoElement20kVCount = 5,
                EeoPermitOnEeoElement10kVCount = 0,
                EeoPermitOnEeoElement1kVCount = 6,
                EeoPermitNearEeoElement110kVCount = 0,
                EeoPermitWithSelfTerm1kVCount = 3,
                EeoPermitNearEeoElement35kVCount = 4,
                EeoPermitNearEeoElement20kVCount = 0,
                EeoPermitNearEeoElement10kVCount = 3,
                EeoPermitNearEeoElement1kVCount = 0,
                EeoPermitWithSelfTerm20kVCount = 0,
                EeoPermitWithSelfTerm10kVCount = 0,
                EeoUnplannedPermit110kVCount = 0,
                EeoUnplannedPermit35kVCount = 1,
                EeoUnplannedPermit20kVCount = 0,
                EeoUnplannedPermit10kVCount = 7,
                EeoUnplannedPermit1kVCount = 0,
                EeoExclusionStatement35kVCount = 0,
                EeoExclusionStatement20kVCount = 3,
                EeoExclusionStatement10kVCount = 4,
                EeoExclusionStatement1kVCount = 0,
                WorkWithoutSecurityPermitCount = 0,
                EntryPermissionsPlannedCount = 3,
                ManipulationOrdersCount = 0,
                InterruptsCount = 6,
                ReceivedFailureCount = 0,
            };

            var dispatcher2 = new DispatcherData
            {
                DispatcherId = 2,
                DispatcherName = "Test 2",
                EeoPermitOnEeoElement110kVCount = 1,
                EeoPermitOnEeoElement35kVCount = 0,
                EeoPermitOnEeoElement20kVCount = 4,
                EeoPermitOnEeoElement10kVCount = 0,
                EeoPermitOnEeoElement1kVCount = 9,
                EeoPermitNearEeoElement110kVCount = 0,
                EeoPermitWithSelfTerm1kVCount = 3,
                EeoPermitNearEeoElement35kVCount = 2,
                EeoPermitNearEeoElement20kVCount = 1,
                EeoPermitNearEeoElement10kVCount = 3,
                EeoPermitNearEeoElement1kVCount = 0,
                EeoPermitWithSelfTerm20kVCount = 0,
                EeoPermitWithSelfTerm10kVCount = 0,
                EeoUnplannedPermit110kVCount = 0,
                EeoUnplannedPermit35kVCount = 1,
                EeoUnplannedPermit20kVCount = 0,
                EeoUnplannedPermit10kVCount = 7,
                EeoUnplannedPermit1kVCount = 0,
                EeoExclusionStatement35kVCount = 0,
                EeoExclusionStatement20kVCount = 3,
                EeoExclusionStatement10kVCount = 4,
                EeoExclusionStatement1kVCount = 0,
                WorkWithoutSecurityPermitCount = 2,
                EntryPermissionsPlannedCount = 0,
                ManipulationOrdersCount = 2,
                InterruptsCount = 3,
                ReceivedFailureCount = 1,
            };
            dispatcherDatas1.Add(dispatcher1);
            dispatcherDatas1.Add(dispatcher2);

            var dispatcher3 = new DispatcherData
            {
                DispatcherId = 2,
                DispatcherName = "Test 3",
                EeoPermitOnEeoElement110kVCount = 1,
                EeoPermitOnEeoElement35kVCount = 0,
                EeoPermitOnEeoElement20kVCount = 4,
                EeoPermitOnEeoElement10kVCount = 0,
                EeoPermitOnEeoElement1kVCount = 9,
                EeoPermitNearEeoElement110kVCount = 0,
                EeoPermitWithSelfTerm1kVCount = 3,
                EeoPermitNearEeoElement35kVCount = 2,
                EeoPermitNearEeoElement20kVCount = 1,
                EeoPermitNearEeoElement10kVCount = 3,
                EeoPermitNearEeoElement1kVCount = 0,
                EeoPermitWithSelfTerm20kVCount = 0,
                EeoPermitWithSelfTerm10kVCount = 0,
                EeoUnplannedPermit110kVCount = 0,
                EeoUnplannedPermit35kVCount = 1,
                EeoUnplannedPermit20kVCount = 0,
                EeoUnplannedPermit10kVCount = 7,
                EeoUnplannedPermit1kVCount = 0,
                EeoExclusionStatement35kVCount = 0,
                EeoExclusionStatement20kVCount = 3,
                EeoExclusionStatement10kVCount = 4,
                EeoExclusionStatement1kVCount = 0,
                WorkWithoutSecurityPermitCount = 2,
                EntryPermissionsPlannedCount = 0,
                ManipulationOrdersCount = 2,
                InterruptsCount = 3,
                ReceivedFailureCount = 1,
            };
            dispatcherDatas2.Add(dispatcher3);

            var dispatcher4 = new DispatcherData
            {
                DispatcherId = 2,
                DispatcherName = "Test 4",
                EeoPermitOnEeoElement110kVCount = 1,
                EeoPermitOnEeoElement35kVCount = 0,
                EeoPermitOnEeoElement20kVCount = 4,
                EeoPermitOnEeoElement10kVCount = 0,
                EeoPermitOnEeoElement1kVCount = 9,
                EeoPermitNearEeoElement110kVCount = 0,
                EeoPermitWithSelfTerm1kVCount = 3,
                EeoPermitNearEeoElement35kVCount = 2,
                EeoPermitNearEeoElement20kVCount = 1,
                EeoPermitNearEeoElement10kVCount = 3,
                EeoPermitNearEeoElement1kVCount = 0,
                EeoPermitWithSelfTerm20kVCount = 0,
                EeoPermitWithSelfTerm10kVCount = 0,
                EeoUnplannedPermit110kVCount = 5,
                EeoUnplannedPermit35kVCount = 0,
                EeoUnplannedPermit20kVCount = 2,
                EeoUnplannedPermit10kVCount = 0,
                EeoUnplannedPermit1kVCount = 6,
                EeoExclusionStatement35kVCount = 0,
                EeoExclusionStatement20kVCount = 3,
                EeoExclusionStatement10kVCount = 4,
                EeoExclusionStatement1kVCount = 0,
                WorkWithoutSecurityPermitCount = 2,
                EntryPermissionsPlannedCount = 5,
                ManipulationOrdersCount = 0,
                InterruptsCount = 9,
                ReceivedFailureCount = 1,
            };
            dispatcherDatas3.Add(dispatcher4);

            var dCData1 = new DCData
            {
                DCId = 5,
                DCName = "DDC NS",
                DispatcherData = dispatcherDatas1,
            };

            var dCData2 = new DCData
            {
                DCId = 7,
                DCName = "DDC ZR",
                DispatcherData = dispatcherDatas2,
            };

            var dCData6 = new DCData
            {
                DCId = 17,
                DCName = "PDC ZR",
                DispatcherData = new List<DispatcherData>()
            };

            var dCData3 = new DCData
            {
                DCId = 9,
                DCName = "DDC SM",
                DispatcherData = new List<DispatcherData>()
            };

            var dCData4 = new DCData
            {
                DCId = 7,
                DCName = "DDC SO",
                DispatcherData = new List<DispatcherData>()
            };

            var dCData5 = new DCData
            {
                DCId = 15,
                DCName = "PDC NS",
                DispatcherData = dispatcherDatas3,
            };

            dCDatas1.Add(dCData1);
            dCDatas1.Add(dCData5);
            dCDatas2.Add(dCData2);
            dCDatas2.Add(dCData6);
            dCDatas3.Add(dCData3);
            dCDatas4.Add(dCData4);

            var dCDto1 = new DCDto
            {
                DCAreaId = 33,
                DCAreaName = "NS Area",
                DCRecords = dCDatas1
            };

            var dCDto2 = new DCDto
            {
                DCAreaId = 77,
                DCAreaName = "ZR Area",
                DCRecords = dCDatas2
            };

            var dCDto3 = new DCDto
            {
                DCAreaId = 88,
                DCAreaName = "SM Area",
                DCRecords = dCDatas3
            };

            var dCDto4 = new DCDto
            {
                DCAreaId = 99,
                DCAreaName = "SO Area",
                DCRecords = dCDatas4
            };

            dCDtos.Add(dCDto1);
            dCDtos.Add(dCDto2);
            dCDtos.Add(dCDto3);
            dCDtos.Add(dCDto4);

            DCReport report = new DCReport
            {
                DCData = dCDtos,
                DateFrom = DateFrom,
                DateTo = DateTo
            };

            return FileResponse("Izvestaj o radu dispecarskih centara.xls", () => report.ToExcel(), inline);
        }

        [NonAction]
        public FileContentResult FileResponse(string fileName,
            Func<byte[]> getContent,
            bool inline,
            string fileType = "application/octet-stream")
        {
            var cd = new ContentDisposition
            {
                FileName = fileName,
                Inline = inline
            };

            Response.Headers[HeaderNames.ContentDisposition] = cd.ToString();

            return File(getContent(), fileType);
        }

    }
}