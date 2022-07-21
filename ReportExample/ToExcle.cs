using DevExpress.XtraPrinting;

namespace ReportExample
{
    public static  class ToExcle
    {
        private static readonly XlsExportOptions DEFAULT_EXPORT_OPTIONS = new XlsExportOptions
        {
            ExportMode = XlsExportMode.SingleFile,
            FitToPrintedPageHeight = true,
            FitToPrintedPageWidth = true
        };

        public static byte[] ToExcel(this DCReport result)
        {
            var report = new DCXtraReport();
            report.Parameters["DateFrom"].Value = result.DateFrom.ToString("dd.MM.yyyy");
            report.Parameters["DateTo"].Value = result.DateTo.ToString("dd.MM.yyyy");

            foreach (var dcDto in result.DCData)
            {
                var dcRecord = new DCData
                {
                    DCName = "Sum",
                    DispatcherData = new List<DispatcherData>()
                };

                var dispatcher = new DispatcherData
                {
                    EeoPermitOnEeoElement110kVCount = dcDto.DCRecords.Sum(x => x.DispatcherData.Sum(x => x.EeoPermitOnEeoElement110kVCount)),
                    EeoPermitOnEeoElement35kVCount = dcDto.DCRecords.Sum(x => x.DispatcherData.Sum(x => x.EeoPermitOnEeoElement35kVCount)),
                    EeoPermitOnEeoElement20kVCount = dcDto.DCRecords.Sum(x => x.DispatcherData.Sum(x => x.EeoPermitOnEeoElement20kVCount)),
                    EeoPermitOnEeoElement10kVCount = dcDto.DCRecords.Sum(x => x.DispatcherData.Sum(x => x.EeoPermitOnEeoElement10kVCount)),
                    EeoPermitOnEeoElement1kVCount = dcDto.DCRecords.Sum(x => x.DispatcherData.Sum(x => x.EeoPermitOnEeoElement1kVCount)),
                    EeoPermitNearEeoElement110kVCount = dcDto.DCRecords.Sum(x => x.DispatcherData.Sum(x => x.EeoPermitNearEeoElement110kVCount)),
                    EeoPermitNearEeoElement35kVCount = dcDto.DCRecords.Sum(x => x.DispatcherData.Sum(x => x.EeoPermitNearEeoElement35kVCount)),
                    EeoPermitNearEeoElement20kVCount = dcDto.DCRecords.Sum(x => x.DispatcherData.Sum(x => x.EeoPermitNearEeoElement20kVCount)),
                    EeoPermitNearEeoElement10kVCount = dcDto.DCRecords.Sum(x => x.DispatcherData.Sum(x => x.EeoPermitNearEeoElement10kVCount)),
                    EeoPermitNearEeoElement1kVCount = dcDto.DCRecords.Sum(x => x.DispatcherData.Sum(x => x.EeoPermitNearEeoElement1kVCount)),
                    EeoPermitWithSelfTerm20kVCount = dcDto.DCRecords.Sum(x => x.DispatcherData.Sum(x => x.EeoPermitWithSelfTerm20kVCount)),
                    EeoPermitWithSelfTerm10kVCount = dcDto.DCRecords.Sum(x => x.DispatcherData.Sum(x => x.EeoPermitWithSelfTerm10kVCount)),
                    EeoPermitWithSelfTerm1kVCount = dcDto.DCRecords.Sum(x => x.DispatcherData.Sum(x => x.EeoPermitWithSelfTerm1kVCount)),
                    EeoUnplannedPermit110kVCount = dcDto.DCRecords.Sum(x => x.DispatcherData.Sum(x => x.EeoUnplannedPermit110kVCount)),
                    EeoUnplannedPermit35kVCount = dcDto.DCRecords.Sum(x => x.DispatcherData.Sum(x => x.EeoUnplannedPermit35kVCount)),
                    EeoUnplannedPermit20kVCount = dcDto.DCRecords.Sum(x => x.DispatcherData.Sum(x => x.EeoUnplannedPermit20kVCount)),
                    EeoUnplannedPermit10kVCount = dcDto.DCRecords.Sum(x => x.DispatcherData.Sum(x => x.EeoUnplannedPermit10kVCount)),
                    EeoUnplannedPermit1kVCount = dcDto.DCRecords.Sum(x => x.DispatcherData.Sum(x => x.EeoUnplannedPermit1kVCount)),
                    EeoExclusionStatement35kVCount = dcDto.DCRecords.Sum(x => x.DispatcherData.Sum(x => x.EeoExclusionStatement35kVCount)),
                    EeoExclusionStatement20kVCount = dcDto.DCRecords.Sum(x => x.DispatcherData.Sum(x => x.EeoExclusionStatement20kVCount)),
                    EeoExclusionStatement10kVCount = dcDto.DCRecords.Sum(x => x.DispatcherData.Sum(x => x.EeoExclusionStatement10kVCount)),
                    EeoExclusionStatement1kVCount = dcDto.DCRecords.Sum(x => x.DispatcherData.Sum(x => x.EeoExclusionStatement1kVCount)),
                    WorkWithoutSecurityPermitCount = dcDto.DCRecords.Sum(x => x.DispatcherData.Sum(x => x.WorkWithoutSecurityPermitCount)),
                    EntryPermissionsPlannedCount = dcDto.DCRecords.Sum(x => x.DispatcherData.Sum(x => x.EntryPermissionsPlannedCount)),
                    ManipulationOrdersCount = dcDto.DCRecords.Sum(x => x.DispatcherData.Sum(x => x.ManipulationOrdersCount)),
                    InterruptsCount = dcDto.DCRecords.Sum(x => x.DispatcherData.Sum(x => x.InterruptsCount)),
                    ReceivedFailureCount = dcDto.DCRecords.Sum(x => x.DispatcherData.Sum(x => x.ReceivedFailureCount)),
                };

                dcRecord.DispatcherData.Add(dispatcher);
                dcDto.DCRecords.Add(dcRecord);
            }

            report.DataSource = result.DCData;

            MemoryStream ms = new MemoryStream();

            report.ExportToXls(ms, DEFAULT_EXPORT_OPTIONS);

            return ms.ToArray();
        }
    }
}
