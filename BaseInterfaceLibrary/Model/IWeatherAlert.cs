using System;

namespace BaseInterfaceLibrary.Model
{
    public interface IWeatherAlert : IBaseModel
    {
        DateTime Expire { get; }
        
        string ExpireTimeZone { get; }

        DateTime Issued { get; }

        string IssuedZone { get; }

        string Message { get; }

        string Title { get; }

        string Type { get; }
    }
}