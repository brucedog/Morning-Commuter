namespace BaseInterfaceLibrary.Model
{
    public interface ISettings : IBaseModel
    {
        string ZipCode { get; set; }
        
        bool UseEnglishUnits { get; set; }

        ICommute Commute { get; set; }
    }
}