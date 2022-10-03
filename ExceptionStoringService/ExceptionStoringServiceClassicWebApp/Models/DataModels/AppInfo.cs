namespace ExceptionStoringServiceClassicWebApp.Models.DataModels
{
    public class AppInfo
    {
        public int AppInfoId { get; set; }
        public string AppName {  get; set; }
        public string AppGUID { get; set; }

        ICollection<AppVersion> Versions { get; set; }
    }
}
