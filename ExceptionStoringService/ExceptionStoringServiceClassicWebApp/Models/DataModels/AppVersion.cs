using System.ComponentModel.DataAnnotations;

namespace ExceptionStoringServiceClassicWebApp.Models.DataModels
{
    public class AppVersion
    {
        public int AppVersionId { get; set; }

        [Required]
        public string AppVersionName { get; set; }

        public int AppInfoId { get; set; }
        public AppInfo AppInfo { get; set; }
    }
}
