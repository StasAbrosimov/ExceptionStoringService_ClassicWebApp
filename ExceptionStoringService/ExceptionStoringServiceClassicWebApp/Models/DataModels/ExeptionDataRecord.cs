using ExceptionStoringServiceClassicWebApp.Exstensions;

namespace ExceptionStoringServiceClassicWebApp.Models.DataModels
{
    public class ExeptionDataRecord
    {
        public long ExeptionId { get; set; }
        public string? Name { get; set; }
        public string? StackTrase { get; set; }
        public int StackTraseHash { get; set; }

        public string? SeriaizedData { get; set; }
        public int SeriaizedDataHash { get; set; }

        public int? HResult { get; set; }

        public int? InnerExeptioId { get; set; }

        public string? Message { get; set; }
        public int MessageHash { get; set; }

        public string? Source { get; set; }
        public int SourceHash { get; set; }

        public string? StackTrace { get; set; }
        public int StackTraceHash { get; set; }

        public string? TargetSite { get; set; }
        public int? TargetSiteHash { get; set; }

        public int AppId { get; set; }
        public int AppVersionId { get; set; }
        
        public void UpdateHashes()
        {
            
        }
    }
}
