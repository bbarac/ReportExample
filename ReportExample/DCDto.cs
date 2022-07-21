namespace ReportExample
{
    public class DCDto
    {
        public int DCAreaId { get; set; }
        public string DCAreaName { get; set; }
        public List<DCData> DCRecords { get; set; }

    }

    public class DCData
    {
        public int DCId { get; set; }
        public string DCName { get; set; }
        public List<DispatcherData> DispatcherData { get; set; }
    }

    public class DispatcherData
    {
        public int DispatcherId { get; set; }
        public string DispatcherName { get; set; }

        public int EeoPermitOnEeoElement110kVCount { get; set; }
        public int EeoPermitOnEeoElement35kVCount { get; set; }
        public int EeoPermitOnEeoElement20kVCount { get; set; }
        public int EeoPermitOnEeoElement10kVCount { get; set; }
        public int EeoPermitOnEeoElement1kVCount { get; set; }
        public int EeoPermitNearEeoElement110kVCount { get; set; }
        public int EeoPermitNearEeoElement35kVCount { get; set; }
        public int EeoPermitNearEeoElement20kVCount { get; set; }
        public int EeoPermitNearEeoElement10kVCount { get; set; }
        public int EeoPermitNearEeoElement1kVCount { get; set; }
        public int EeoPermitWithSelfTerm20kVCount { get; set; }
        public int EeoPermitWithSelfTerm10kVCount { get; set; }
        public int EeoPermitWithSelfTerm1kVCount { get; set; }
        public int EeoUnplannedPermit110kVCount { get; set; }
        public int EeoUnplannedPermit35kVCount { get; set; }
        public int EeoUnplannedPermit20kVCount { get; set; }
        public int EeoUnplannedPermit10kVCount { get; set; }
        public int EeoUnplannedPermit1kVCount { get; set; }
        public int EeoExclusionStatement35kVCount { get; set; }
        public int EeoExclusionStatement20kVCount { get; set; }
        public int EeoExclusionStatement10kVCount { get; set; }
        public int EeoExclusionStatement1kVCount { get; set; }
        public int WorkWithoutSecurityPermitCount { get; set; }
        public int EntryPermissionsPlannedCount { get; set; }
        public int ManipulationOrdersCount { get; set; }
        public int InterruptsCount { get; set; }
        public int ReceivedFailureCount { get; set; }
    }
}
