using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.Web.Services;
using System.Web.Services.Description;
using System.Web.Services.Protocols;
using System.Xml.Serialization;
using Services.Properties;

#pragma warning disable 1591

namespace Services.WeatherBugWebService
{
    /// <remarks/>
    [GeneratedCode("System.Web.Services", "4.0.30319.1")]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [WebServiceBinding(Name = "WeatherBugWebServicesSoap", Namespace = "http://api.wxbug.net/")]
    public class WeatherBugWebServices : SoapHttpClientProtocol
    {
        private SendOrPostCallback GetAlertsDataListOperationCompleted;
        private SendOrPostCallback GetAlertsIssueDataOperationCompleted;
        private SendOrPostCallback GetForecastByCityCodeOperationCompleted;
        private SendOrPostCallback GetForecastByUSZipCodeOperationCompleted;
        private SendOrPostCallback GetForecastIssueDetailsByCityCodeOperationCompleted;
        private SendOrPostCallback GetForecastIssueDetailsByUSZipCodeOperationCompleted;
        private SendOrPostCallback GetLiveCompactWeatherByCityCodeOperationCompleted;
        private SendOrPostCallback GetLiveCompactWeatherByStationIDOperationCompleted;
        private SendOrPostCallback GetLiveCompactWeatherByUSZipCodeOperationCompleted;
        private SendOrPostCallback GetLiveWeatherByCityCodeOperationCompleted;
        private SendOrPostCallback GetLiveWeatherByStationIDOperationCompleted;
        private SendOrPostCallback GetLiveWeatherByUSZipCodeOperationCompleted;
        private SendOrPostCallback GetLocationListOperationCompleted;
        private SendOrPostCallback GetStationListByCityCodeOperationCompleted;
        private SendOrPostCallback GetStationListByUSZipCodeOperationCompleted;
        private SendOrPostCallback GetUSWorldCityByLatLongOperationCompleted;
        private bool useDefaultCredentialsSetExplicitly;

        /// <remarks/>
        public WeatherBugWebServices()
        {
            Url = Settings.Default.Services_WeatherBugWebService_WeatherBugWebServices;
            if (IsLocalFileSystemWebService(Url))
            {
                UseDefaultCredentials = true;
                useDefaultCredentialsSetExplicitly = false;
            }
            else
            {
                useDefaultCredentialsSetExplicitly = true;
            }
        }

        public new string Url
        {
            get { return base.Url; }
            set
            {
                if (((IsLocalFileSystemWebService(base.Url)
                      && (useDefaultCredentialsSetExplicitly == false))
                     && (IsLocalFileSystemWebService(value) == false)))
                {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }

        public new bool UseDefaultCredentials
        {
            get { return base.UseDefaultCredentials; }
            set
            {
                base.UseDefaultCredentials = value;
                useDefaultCredentialsSetExplicitly = true;
            }
        }

        /// <remarks/>
        public event GetLocationListCompletedEventHandler GetLocationListCompleted;

        /// <remarks/>
        public event GetUSWorldCityByLatLongCompletedEventHandler GetUSWorldCityByLatLongCompleted;

        /// <remarks/>
        public event GetStationListByCityCodeCompletedEventHandler GetStationListByCityCodeCompleted;

        /// <remarks/>
        public event GetStationListByUSZipCodeCompletedEventHandler GetStationListByUSZipCodeCompleted;

        /// <remarks/>
        public event GetLiveCompactWeatherByCityCodeCompletedEventHandler GetLiveCompactWeatherByCityCodeCompleted;

        /// <remarks/>
        public event GetLiveCompactWeatherByUSZipCodeCompletedEventHandler GetLiveCompactWeatherByUSZipCodeCompleted;

        /// <remarks/>
        public event GetLiveCompactWeatherByStationIDCompletedEventHandler GetLiveCompactWeatherByStationIDCompleted;

        /// <remarks/>
        public event GetLiveWeatherByCityCodeCompletedEventHandler GetLiveWeatherByCityCodeCompleted;

        /// <remarks/>
        public event GetLiveWeatherByUSZipCodeCompletedEventHandler GetLiveWeatherByUSZipCodeCompleted;

        /// <remarks/>
        public event GetLiveWeatherByStationIDCompletedEventHandler GetLiveWeatherByStationIDCompleted;

        /// <remarks/>
        public event GetAlertsDataListCompletedEventHandler GetAlertsDataListCompleted;

        /// <remarks/>
        public event GetAlertsIssueDataCompletedEventHandler GetAlertsIssueDataCompleted;

        /// <remarks/>
        public event GetForecastIssueDetailsByCityCodeCompletedEventHandler GetForecastIssueDetailsByCityCodeCompleted;

        /// <remarks/>
        public event GetForecastIssueDetailsByUSZipCodeCompletedEventHandler GetForecastIssueDetailsByUSZipCodeCompleted;

        /// <remarks/>
        public event GetForecastByCityCodeCompletedEventHandler GetForecastByCityCodeCompleted;

        /// <remarks/>
        public event GetForecastByUSZipCodeCompletedEventHandler GetForecastByUSZipCodeCompleted;

        /// <remarks/>
        [SoapDocumentMethod("http://api.wxbug.net/GetLocationList", RequestNamespace = "http://api.wxbug.net/",
            ResponseNamespace = "http://api.wxbug.net/", Use = SoapBindingUse.Literal,
            ParameterStyle = SoapParameterStyle.Wrapped)]
        public ApiLocationData[] GetLocationList(string searchString, string ACode)
        {
            object[] results = Invoke("GetLocationList", new object[]
                                                             {
                                                                 searchString,
                                                                 ACode
                                                             });
            return ((ApiLocationData[]) (results[0]));
        }

        /// <remarks/>
        public void GetLocationListAsync(string searchString, string ACode)
        {
            GetLocationListAsync(searchString, ACode, null);
        }

        /// <remarks/>
        public void GetLocationListAsync(string searchString, string ACode, object userState)
        {
            if ((GetLocationListOperationCompleted == null))
            {
                GetLocationListOperationCompleted = OnGetLocationListOperationCompleted;
            }
            InvokeAsync("GetLocationList", new object[]
                                               {
                                                   searchString,
                                                   ACode
                                               }, GetLocationListOperationCompleted, userState);
        }

        private void OnGetLocationListOperationCompleted(object arg)
        {
            if ((GetLocationListCompleted != null))
            {
                var invokeArgs = ((InvokeCompletedEventArgs) (arg));
                GetLocationListCompleted(this,
                                         new GetLocationListCompletedEventArgs(invokeArgs.Results, invokeArgs.Error,
                                                                               invokeArgs.Cancelled,
                                                                               invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [SoapDocumentMethod("http://api.wxbug.net/GetUSWorldCityByLatLong", RequestNamespace = "http://api.wxbug.net/",
            ResponseNamespace = "http://api.wxbug.net/", Use = SoapBindingUse.Literal,
            ParameterStyle = SoapParameterStyle.Wrapped)]
        public LocationUSWorldCityData GetUSWorldCityByLatLong(decimal latitude, decimal longitude, string ACode)
        {
            object[] results = Invoke("GetUSWorldCityByLatLong", new object[]
                                                                     {
                                                                         latitude,
                                                                         longitude,
                                                                         ACode
                                                                     });
            return ((LocationUSWorldCityData) (results[0]));
        }

        /// <remarks/>
        public void GetUSWorldCityByLatLongAsync(decimal latitude, decimal longitude, string ACode)
        {
            GetUSWorldCityByLatLongAsync(latitude, longitude, ACode, null);
        }

        /// <remarks/>
        public void GetUSWorldCityByLatLongAsync(decimal latitude, decimal longitude, string ACode, object userState)
        {
            if ((GetUSWorldCityByLatLongOperationCompleted == null))
            {
                GetUSWorldCityByLatLongOperationCompleted = OnGetUSWorldCityByLatLongOperationCompleted;
            }
            InvokeAsync("GetUSWorldCityByLatLong", new object[]
                                                       {
                                                           latitude,
                                                           longitude,
                                                           ACode
                                                       }, GetUSWorldCityByLatLongOperationCompleted, userState);
        }

        private void OnGetUSWorldCityByLatLongOperationCompleted(object arg)
        {
            if ((GetUSWorldCityByLatLongCompleted != null))
            {
                var invokeArgs = ((InvokeCompletedEventArgs) (arg));
                GetUSWorldCityByLatLongCompleted(this,
                                                 new GetUSWorldCityByLatLongCompletedEventArgs(invokeArgs.Results,
                                                                                               invokeArgs.Error,
                                                                                               invokeArgs.Cancelled,
                                                                                               invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [SoapDocumentMethod("http://api.wxbug.net/GetStationListByCityCode", RequestNamespace = "http://api.wxbug.net/",
            ResponseNamespace = "http://api.wxbug.net/", Use = SoapBindingUse.Literal,
            ParameterStyle = SoapParameterStyle.Wrapped)]
        public ApiStationData[] GetStationListByCityCode(string cityCode, UnitType unitType, string ACode)
        {
            object[] results = Invoke("GetStationListByCityCode", new object[]
                                                                      {
                                                                          cityCode,
                                                                          unitType,
                                                                          ACode
                                                                      });
            return ((ApiStationData[]) (results[0]));
        }

        /// <remarks/>
        public void GetStationListByCityCodeAsync(string cityCode, UnitType unitType, string ACode)
        {
            GetStationListByCityCodeAsync(cityCode, unitType, ACode, null);
        }

        /// <remarks/>
        public void GetStationListByCityCodeAsync(string cityCode, UnitType unitType, string ACode, object userState)
        {
            if ((GetStationListByCityCodeOperationCompleted == null))
            {
                GetStationListByCityCodeOperationCompleted = OnGetStationListByCityCodeOperationCompleted;
            }
            InvokeAsync("GetStationListByCityCode", new object[]
                                                        {
                                                            cityCode,
                                                            unitType,
                                                            ACode
                                                        }, GetStationListByCityCodeOperationCompleted, userState);
        }

        private void OnGetStationListByCityCodeOperationCompleted(object arg)
        {
            if ((GetStationListByCityCodeCompleted != null))
            {
                var invokeArgs = ((InvokeCompletedEventArgs) (arg));
                GetStationListByCityCodeCompleted(this,
                                                  new GetStationListByCityCodeCompletedEventArgs(invokeArgs.Results,
                                                                                                 invokeArgs.Error,
                                                                                                 invokeArgs.Cancelled,
                                                                                                 invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [SoapDocumentMethod("http://api.wxbug.net/GetStationListByUSZipCode", RequestNamespace = "http://api.wxbug.net/"
            , ResponseNamespace = "http://api.wxbug.net/", Use = SoapBindingUse.Literal,
            ParameterStyle = SoapParameterStyle.Wrapped)]
        public ApiStationData[] GetStationListByUSZipCode(string zipCode, UnitType unitType, string ACode)
        {
            object[] results = Invoke("GetStationListByUSZipCode", new object[]
                                                                       {
                                                                           zipCode,
                                                                           unitType,
                                                                           ACode
                                                                       });
            return ((ApiStationData[]) (results[0]));
        }

        /// <remarks/>
        public void GetStationListByUSZipCodeAsync(string zipCode, UnitType unitType, string ACode)
        {
            GetStationListByUSZipCodeAsync(zipCode, unitType, ACode, null);
        }

        /// <remarks/>
        public void GetStationListByUSZipCodeAsync(string zipCode, UnitType unitType, string ACode, object userState)
        {
            if ((GetStationListByUSZipCodeOperationCompleted == null))
            {
                GetStationListByUSZipCodeOperationCompleted = OnGetStationListByUSZipCodeOperationCompleted;
            }
            InvokeAsync("GetStationListByUSZipCode", new object[]
                                                         {
                                                             zipCode,
                                                             unitType,
                                                             ACode
                                                         }, GetStationListByUSZipCodeOperationCompleted, userState);
        }

        private void OnGetStationListByUSZipCodeOperationCompleted(object arg)
        {
            if ((GetStationListByUSZipCodeCompleted != null))
            {
                var invokeArgs = ((InvokeCompletedEventArgs) (arg));
                GetStationListByUSZipCodeCompleted(this,
                                                   new GetStationListByUSZipCodeCompletedEventArgs(invokeArgs.Results,
                                                                                                   invokeArgs.Error,
                                                                                                   invokeArgs.Cancelled,
                                                                                                   invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [SoapDocumentMethod("http://api.wxbug.net/GetLiveCompactWeatherByCityCode",
            RequestNamespace = "http://api.wxbug.net/", ResponseNamespace = "http://api.wxbug.net/",
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public LiveCompactWeatherData GetLiveCompactWeatherByCityCode(string cityCode, UnitType unittype, string ACode)
        {
            object[] results = Invoke("GetLiveCompactWeatherByCityCode", new object[]
                                                                             {
                                                                                 cityCode,
                                                                                 unittype,
                                                                                 ACode
                                                                             });
            return ((LiveCompactWeatherData) (results[0]));
        }

        /// <remarks/>
        public void GetLiveCompactWeatherByCityCodeAsync(string cityCode, UnitType unittype, string ACode)
        {
            GetLiveCompactWeatherByCityCodeAsync(cityCode, unittype, ACode, null);
        }

        /// <remarks/>
        public void GetLiveCompactWeatherByCityCodeAsync(string cityCode, UnitType unittype, string ACode,
                                                         object userState)
        {
            if ((GetLiveCompactWeatherByCityCodeOperationCompleted == null))
            {
                GetLiveCompactWeatherByCityCodeOperationCompleted = OnGetLiveCompactWeatherByCityCodeOperationCompleted;
            }
            InvokeAsync("GetLiveCompactWeatherByCityCode", new object[]
                                                               {
                                                                   cityCode,
                                                                   unittype,
                                                                   ACode
                                                               }, GetLiveCompactWeatherByCityCodeOperationCompleted,
                        userState);
        }

        private void OnGetLiveCompactWeatherByCityCodeOperationCompleted(object arg)
        {
            if ((GetLiveCompactWeatherByCityCodeCompleted != null))
            {
                var invokeArgs = ((InvokeCompletedEventArgs) (arg));
                GetLiveCompactWeatherByCityCodeCompleted(this,
                                                         new GetLiveCompactWeatherByCityCodeCompletedEventArgs(
                                                             invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled,
                                                             invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [SoapDocumentMethod("http://api.wxbug.net/GetLiveCompactWeatherByUSZipCode",
            RequestNamespace = "http://api.wxbug.net/", ResponseNamespace = "http://api.wxbug.net/",
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public LiveCompactWeatherData GetLiveCompactWeatherByUSZipCode(string zipCode, UnitType unittype, string ACode)
        {
            object[] results = Invoke("GetLiveCompactWeatherByUSZipCode", new object[]
                                                                              {
                                                                                  zipCode,
                                                                                  unittype,
                                                                                  ACode
                                                                              });
            return ((LiveCompactWeatherData) (results[0]));
        }

        /// <remarks/>
        public void GetLiveCompactWeatherByUSZipCodeAsync(string zipCode, UnitType unittype, string ACode)
        {
            GetLiveCompactWeatherByUSZipCodeAsync(zipCode, unittype, ACode, null);
        }

        /// <remarks/>
        public void GetLiveCompactWeatherByUSZipCodeAsync(string zipCode, UnitType unittype, string ACode,
                                                          object userState)
        {
            if ((GetLiveCompactWeatherByUSZipCodeOperationCompleted == null))
            {
                GetLiveCompactWeatherByUSZipCodeOperationCompleted =
                    OnGetLiveCompactWeatherByUSZipCodeOperationCompleted;
            }
            InvokeAsync("GetLiveCompactWeatherByUSZipCode", new object[]
                                                                {
                                                                    zipCode,
                                                                    unittype,
                                                                    ACode
                                                                }, GetLiveCompactWeatherByUSZipCodeOperationCompleted,
                        userState);
        }

        private void OnGetLiveCompactWeatherByUSZipCodeOperationCompleted(object arg)
        {
            if ((GetLiveCompactWeatherByUSZipCodeCompleted != null))
            {
                var invokeArgs = ((InvokeCompletedEventArgs) (arg));
                GetLiveCompactWeatherByUSZipCodeCompleted(this,
                                                          new GetLiveCompactWeatherByUSZipCodeCompletedEventArgs(
                                                              invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled,
                                                              invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [SoapDocumentMethod("http://api.wxbug.net/GetLiveCompactWeatherByStationID",
            RequestNamespace = "http://api.wxbug.net/", ResponseNamespace = "http://api.wxbug.net/",
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public LiveCompactWeatherData GetLiveCompactWeatherByStationID(string stationid, UnitType unittype, string ACode)
        {
            object[] results = Invoke("GetLiveCompactWeatherByStationID", new object[]
                                                                              {
                                                                                  stationid,
                                                                                  unittype,
                                                                                  ACode
                                                                              });
            return ((LiveCompactWeatherData) (results[0]));
        }

        /// <remarks/>
        public void GetLiveCompactWeatherByStationIDAsync(string stationid, UnitType unittype, string ACode)
        {
            GetLiveCompactWeatherByStationIDAsync(stationid, unittype, ACode, null);
        }

        /// <remarks/>
        public void GetLiveCompactWeatherByStationIDAsync(string stationid, UnitType unittype, string ACode,
                                                          object userState)
        {
            if ((GetLiveCompactWeatherByStationIDOperationCompleted == null))
            {
                GetLiveCompactWeatherByStationIDOperationCompleted =
                    OnGetLiveCompactWeatherByStationIDOperationCompleted;
            }
            InvokeAsync("GetLiveCompactWeatherByStationID", new object[]
                                                                {
                                                                    stationid,
                                                                    unittype,
                                                                    ACode
                                                                }, GetLiveCompactWeatherByStationIDOperationCompleted,
                        userState);
        }

        private void OnGetLiveCompactWeatherByStationIDOperationCompleted(object arg)
        {
            if ((GetLiveCompactWeatherByStationIDCompleted != null))
            {
                var invokeArgs = ((InvokeCompletedEventArgs) (arg));
                GetLiveCompactWeatherByStationIDCompleted(this,
                                                          new GetLiveCompactWeatherByStationIDCompletedEventArgs(
                                                              invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled,
                                                              invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [SoapDocumentMethod("http://api.wxbug.net/GetLiveWeatherByCityCode", RequestNamespace = "http://api.wxbug.net/",
            ResponseNamespace = "http://api.wxbug.net/", Use = SoapBindingUse.Literal,
            ParameterStyle = SoapParameterStyle.Wrapped)]
        public LiveWeatherData GetLiveWeatherByCityCode(string cityCode, UnitType unittype, string ACode)
        {
            object[] results = Invoke("GetLiveWeatherByCityCode", new object[]
                                                                      {
                                                                          cityCode,
                                                                          unittype,
                                                                          ACode
                                                                      });
            return ((LiveWeatherData) (results[0]));
        }

        /// <remarks/>
        public void GetLiveWeatherByCityCodeAsync(string cityCode, UnitType unittype, string ACode)
        {
            GetLiveWeatherByCityCodeAsync(cityCode, unittype, ACode, null);
        }

        /// <remarks/>
        public void GetLiveWeatherByCityCodeAsync(string cityCode, UnitType unittype, string ACode, object userState)
        {
            if ((GetLiveWeatherByCityCodeOperationCompleted == null))
            {
                GetLiveWeatherByCityCodeOperationCompleted = OnGetLiveWeatherByCityCodeOperationCompleted;
            }
            InvokeAsync("GetLiveWeatherByCityCode", new object[]
                                                        {
                                                            cityCode,
                                                            unittype,
                                                            ACode
                                                        }, GetLiveWeatherByCityCodeOperationCompleted, userState);
        }

        private void OnGetLiveWeatherByCityCodeOperationCompleted(object arg)
        {
            if ((GetLiveWeatherByCityCodeCompleted != null))
            {
                var invokeArgs = ((InvokeCompletedEventArgs) (arg));
                GetLiveWeatherByCityCodeCompleted(this,
                                                  new GetLiveWeatherByCityCodeCompletedEventArgs(invokeArgs.Results,
                                                                                                 invokeArgs.Error,
                                                                                                 invokeArgs.Cancelled,
                                                                                                 invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [SoapDocumentMethod("http://api.wxbug.net/GetLiveWeatherByUSZipCode", RequestNamespace = "http://api.wxbug.net/"
            , ResponseNamespace = "http://api.wxbug.net/", Use = SoapBindingUse.Literal,
            ParameterStyle = SoapParameterStyle.Wrapped)]
        public LiveWeatherData GetLiveWeatherByUSZipCode(string zipCode, UnitType unittype, string ACode)
        {
            object[] results = Invoke("GetLiveWeatherByUSZipCode", new object[]
                                                                       {
                                                                           zipCode,
                                                                           unittype,
                                                                           ACode
                                                                       });
            return ((LiveWeatherData) (results[0]));
        }

        /// <remarks/>
        public void GetLiveWeatherByUSZipCodeAsync(string zipCode, UnitType unittype, string ACode)
        {
            GetLiveWeatherByUSZipCodeAsync(zipCode, unittype, ACode, null);
        }

        /// <remarks/>
        public void GetLiveWeatherByUSZipCodeAsync(string zipCode, UnitType unittype, string ACode, object userState)
        {
            if ((GetLiveWeatherByUSZipCodeOperationCompleted == null))
            {
                GetLiveWeatherByUSZipCodeOperationCompleted = OnGetLiveWeatherByUSZipCodeOperationCompleted;
            }
            InvokeAsync("GetLiveWeatherByUSZipCode", new object[]
                                                         {
                                                             zipCode,
                                                             unittype,
                                                             ACode
                                                         }, GetLiveWeatherByUSZipCodeOperationCompleted, userState);
        }

        private void OnGetLiveWeatherByUSZipCodeOperationCompleted(object arg)
        {
            if ((GetLiveWeatherByUSZipCodeCompleted != null))
            {
                var invokeArgs = ((InvokeCompletedEventArgs) (arg));
                GetLiveWeatherByUSZipCodeCompleted(this,
                                                   new GetLiveWeatherByUSZipCodeCompletedEventArgs(invokeArgs.Results,
                                                                                                   invokeArgs.Error,
                                                                                                   invokeArgs.Cancelled,
                                                                                                   invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [SoapDocumentMethod("http://api.wxbug.net/GetLiveWeatherByStationID", RequestNamespace = "http://api.wxbug.net/"
            , ResponseNamespace = "http://api.wxbug.net/", Use = SoapBindingUse.Literal,
            ParameterStyle = SoapParameterStyle.Wrapped)]
        public LiveWeatherData GetLiveWeatherByStationID(string stationid, UnitType unittype, string ACode)
        {
            object[] results = Invoke("GetLiveWeatherByStationID", new object[]
                                                                       {
                                                                           stationid,
                                                                           unittype,
                                                                           ACode
                                                                       });
            return ((LiveWeatherData) (results[0]));
        }

        /// <remarks/>
        public void GetLiveWeatherByStationIDAsync(string stationid, UnitType unittype, string ACode)
        {
            GetLiveWeatherByStationIDAsync(stationid, unittype, ACode, null);
        }

        /// <remarks/>
        public void GetLiveWeatherByStationIDAsync(string stationid, UnitType unittype, string ACode, object userState)
        {
            if ((GetLiveWeatherByStationIDOperationCompleted == null))
            {
                GetLiveWeatherByStationIDOperationCompleted = OnGetLiveWeatherByStationIDOperationCompleted;
            }
            InvokeAsync("GetLiveWeatherByStationID", new object[]
                                                         {
                                                             stationid,
                                                             unittype,
                                                             ACode
                                                         }, GetLiveWeatherByStationIDOperationCompleted, userState);
        }

        private void OnGetLiveWeatherByStationIDOperationCompleted(object arg)
        {
            if ((GetLiveWeatherByStationIDCompleted != null))
            {
                var invokeArgs = ((InvokeCompletedEventArgs) (arg));
                GetLiveWeatherByStationIDCompleted(this,
                                                   new GetLiveWeatherByStationIDCompletedEventArgs(invokeArgs.Results,
                                                                                                   invokeArgs.Error,
                                                                                                   invokeArgs.Cancelled,
                                                                                                   invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [SoapDocumentMethod("http://api.wxbug.net/GetAlertsDataList", RequestNamespace = "http://api.wxbug.net/",
            ResponseNamespace = "http://api.wxbug.net/", Use = SoapBindingUse.Literal,
            ParameterStyle = SoapParameterStyle.Wrapped)]
        public ApiAlertData[] GetAlertsDataList(string zipCode, string ACode)
        {
            object[] results = Invoke("GetAlertsDataList", new object[]
                                                               {
                                                                   zipCode,
                                                                   ACode
                                                               });
            return ((ApiAlertData[]) (results[0]));
        }

        /// <remarks/>
        public void GetAlertsDataListAsync(string zipCode, string ACode)
        {
            GetAlertsDataListAsync(zipCode, ACode, null);
        }

        /// <remarks/>
        public void GetAlertsDataListAsync(string zipCode, string ACode, object userState)
        {
            if ((GetAlertsDataListOperationCompleted == null))
            {
                GetAlertsDataListOperationCompleted = OnGetAlertsDataListOperationCompleted;
            }
            InvokeAsync("GetAlertsDataList", new object[]
                                                 {
                                                     zipCode,
                                                     ACode
                                                 }, GetAlertsDataListOperationCompleted, userState);
        }

        private void OnGetAlertsDataListOperationCompleted(object arg)
        {
            if ((GetAlertsDataListCompleted != null))
            {
                var invokeArgs = ((InvokeCompletedEventArgs) (arg));
                GetAlertsDataListCompleted(this,
                                           new GetAlertsDataListCompletedEventArgs(invokeArgs.Results, invokeArgs.Error,
                                                                                   invokeArgs.Cancelled,
                                                                                   invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [SoapDocumentMethod("http://api.wxbug.net/GetAlertsIssueData", RequestNamespace = "http://api.wxbug.net/",
            ResponseNamespace = "http://api.wxbug.net/", Use = SoapBindingUse.Literal,
            ParameterStyle = SoapParameterStyle.Wrapped)]
        public ApiAlertIssueData GetAlertsIssueData(string zipCode, string ACode)
        {
            object[] results = Invoke("GetAlertsIssueData", new object[]
                                                                {
                                                                    zipCode,
                                                                    ACode
                                                                });
            return ((ApiAlertIssueData) (results[0]));
        }

        /// <remarks/>
        public void GetAlertsIssueDataAsync(string zipCode, string ACode)
        {
            GetAlertsIssueDataAsync(zipCode, ACode, null);
        }

        /// <remarks/>
        public void GetAlertsIssueDataAsync(string zipCode, string ACode, object userState)
        {
            if ((GetAlertsIssueDataOperationCompleted == null))
            {
                GetAlertsIssueDataOperationCompleted = OnGetAlertsIssueDataOperationCompleted;
            }
            InvokeAsync("GetAlertsIssueData", new object[]
                                                  {
                                                      zipCode,
                                                      ACode
                                                  }, GetAlertsIssueDataOperationCompleted, userState);
        }

        private void OnGetAlertsIssueDataOperationCompleted(object arg)
        {
            if ((GetAlertsIssueDataCompleted != null))
            {
                var invokeArgs = ((InvokeCompletedEventArgs) (arg));
                GetAlertsIssueDataCompleted(this,
                                            new GetAlertsIssueDataCompletedEventArgs(invokeArgs.Results,
                                                                                     invokeArgs.Error,
                                                                                     invokeArgs.Cancelled,
                                                                                     invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [SoapDocumentMethod("http://api.wxbug.net/GetForecastIssueDetailsByCityCode",
            RequestNamespace = "http://api.wxbug.net/", ResponseNamespace = "http://api.wxbug.net/",
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public ApiForecastIssueData GetForecastIssueDetailsByCityCode(string cityCode, string ACode)
        {
            object[] results = Invoke("GetForecastIssueDetailsByCityCode", new object[]
                                                                               {
                                                                                   cityCode,
                                                                                   ACode
                                                                               });
            return ((ApiForecastIssueData) (results[0]));
        }

        /// <remarks/>
        public void GetForecastIssueDetailsByCityCodeAsync(string cityCode, string ACode)
        {
            GetForecastIssueDetailsByCityCodeAsync(cityCode, ACode, null);
        }

        /// <remarks/>
        public void GetForecastIssueDetailsByCityCodeAsync(string cityCode, string ACode, object userState)
        {
            if ((GetForecastIssueDetailsByCityCodeOperationCompleted == null))
            {
                GetForecastIssueDetailsByCityCodeOperationCompleted =
                    OnGetForecastIssueDetailsByCityCodeOperationCompleted;
            }
            InvokeAsync("GetForecastIssueDetailsByCityCode", new object[]
                                                                 {
                                                                     cityCode,
                                                                     ACode
                                                                 }, GetForecastIssueDetailsByCityCodeOperationCompleted,
                        userState);
        }

        private void OnGetForecastIssueDetailsByCityCodeOperationCompleted(object arg)
        {
            if ((GetForecastIssueDetailsByCityCodeCompleted != null))
            {
                var invokeArgs = ((InvokeCompletedEventArgs) (arg));
                GetForecastIssueDetailsByCityCodeCompleted(this,
                                                           new GetForecastIssueDetailsByCityCodeCompletedEventArgs(
                                                               invokeArgs.Results, invokeArgs.Error,
                                                               invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [SoapDocumentMethod("http://api.wxbug.net/GetForecastIssueDetailsByUSZipCode",
            RequestNamespace = "http://api.wxbug.net/", ResponseNamespace = "http://api.wxbug.net/",
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public ApiForecastIssueData GetForecastIssueDetailsByUSZipCode(string zipCode, string ACode)
        {
            object[] results = Invoke("GetForecastIssueDetailsByUSZipCode", new object[]
                                                                                {
                                                                                    zipCode,
                                                                                    ACode
                                                                                });
            return ((ApiForecastIssueData) (results[0]));
        }

        /// <remarks/>
        public void GetForecastIssueDetailsByUSZipCodeAsync(string zipCode, string ACode)
        {
            GetForecastIssueDetailsByUSZipCodeAsync(zipCode, ACode, null);
        }

        /// <remarks/>
        public void GetForecastIssueDetailsByUSZipCodeAsync(string zipCode, string ACode, object userState)
        {
            if ((GetForecastIssueDetailsByUSZipCodeOperationCompleted == null))
            {
                GetForecastIssueDetailsByUSZipCodeOperationCompleted =
                    OnGetForecastIssueDetailsByUSZipCodeOperationCompleted;
            }
            InvokeAsync("GetForecastIssueDetailsByUSZipCode", new object[]
                                                                  {
                                                                      zipCode,
                                                                      ACode
                                                                  },
                        GetForecastIssueDetailsByUSZipCodeOperationCompleted, userState);
        }

        private void OnGetForecastIssueDetailsByUSZipCodeOperationCompleted(object arg)
        {
            if ((GetForecastIssueDetailsByUSZipCodeCompleted != null))
            {
                var invokeArgs = ((InvokeCompletedEventArgs) (arg));
                GetForecastIssueDetailsByUSZipCodeCompleted(this,
                                                            new GetForecastIssueDetailsByUSZipCodeCompletedEventArgs(
                                                                invokeArgs.Results, invokeArgs.Error,
                                                                invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [SoapDocumentMethod("http://api.wxbug.net/GetForecastByCityCode", RequestNamespace = "http://api.wxbug.net/",
            ResponseNamespace = "http://api.wxbug.net/", Use = SoapBindingUse.Literal,
            ParameterStyle = SoapParameterStyle.Wrapped)]
        public ApiForecastData[] GetForecastByCityCode(string cityCode, UnitType unitType, string ACode)
        {
            object[] results = Invoke("GetForecastByCityCode", new object[]
                                                                   {
                                                                       cityCode,
                                                                       unitType,
                                                                       ACode
                                                                   });
            return ((ApiForecastData[]) (results[0]));
        }

        /// <remarks/>
        public void GetForecastByCityCodeAsync(string cityCode, UnitType unitType, string ACode)
        {
            GetForecastByCityCodeAsync(cityCode, unitType, ACode, null);
        }

        /// <remarks/>
        public void GetForecastByCityCodeAsync(string cityCode, UnitType unitType, string ACode, object userState)
        {
            if ((GetForecastByCityCodeOperationCompleted == null))
            {
                GetForecastByCityCodeOperationCompleted = OnGetForecastByCityCodeOperationCompleted;
            }
            InvokeAsync("GetForecastByCityCode", new object[]
                                                     {
                                                         cityCode,
                                                         unitType,
                                                         ACode
                                                     }, GetForecastByCityCodeOperationCompleted, userState);
        }

        private void OnGetForecastByCityCodeOperationCompleted(object arg)
        {
            if ((GetForecastByCityCodeCompleted != null))
            {
                var invokeArgs = ((InvokeCompletedEventArgs) (arg));
                GetForecastByCityCodeCompleted(this,
                                               new GetForecastByCityCodeCompletedEventArgs(invokeArgs.Results,
                                                                                           invokeArgs.Error,
                                                                                           invokeArgs.Cancelled,
                                                                                           invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [SoapDocumentMethod("http://api.wxbug.net/GetForecastByUSZipCode", RequestNamespace = "http://api.wxbug.net/",
            ResponseNamespace = "http://api.wxbug.net/", Use = SoapBindingUse.Literal,
            ParameterStyle = SoapParameterStyle.Wrapped)]
        public ApiForecastData[] GetForecastByUSZipCode(string zipCode, UnitType unitType, string ACode)
        {
            object[] results = Invoke("GetForecastByUSZipCode", new object[]
                                                                    {
                                                                        zipCode,
                                                                        unitType,
                                                                        ACode
                                                                    });
            return ((ApiForecastData[]) (results[0]));
        }

        /// <remarks/>
        public void GetForecastByUSZipCodeAsync(string zipCode, UnitType unitType, string ACode)
        {
            GetForecastByUSZipCodeAsync(zipCode, unitType, ACode, null);
        }

        /// <remarks/>
        public void GetForecastByUSZipCodeAsync(string zipCode, UnitType unitType, string ACode, object userState)
        {
            if ((GetForecastByUSZipCodeOperationCompleted == null))
            {
                GetForecastByUSZipCodeOperationCompleted = OnGetForecastByUSZipCodeOperationCompleted;
            }
            InvokeAsync("GetForecastByUSZipCode", new object[]
                                                      {
                                                          zipCode,
                                                          unitType,
                                                          ACode
                                                      }, GetForecastByUSZipCodeOperationCompleted, userState);
        }

        private void OnGetForecastByUSZipCodeOperationCompleted(object arg)
        {
            if ((GetForecastByUSZipCodeCompleted != null))
            {
                var invokeArgs = ((InvokeCompletedEventArgs) (arg));
                GetForecastByUSZipCodeCompleted(this,
                                                new GetForecastByUSZipCodeCompletedEventArgs(invokeArgs.Results,
                                                                                             invokeArgs.Error,
                                                                                             invokeArgs.Cancelled,
                                                                                             invokeArgs.UserState));
            }
        }

        /// <remarks/>
        public new void CancelAsync(object userState)
        {
            base.CancelAsync(userState);
        }

        private bool IsLocalFileSystemWebService(string url)
        {
            if (((url == null)
                 || (url == string.Empty)))
            {
                return false;
            }
            var wsUri = new Uri(url);
            if (((wsUri.Port >= 1024)
                 && (string.Compare(wsUri.Host, "localHost", StringComparison.OrdinalIgnoreCase) == 0)))
            {
                return true;
            }
            return false;
        }
    }

    /// <remarks/>
    [GeneratedCode("System.Xml", "4.0.30319.233")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://api.wxbug.net/")]
    public class ApiLocationData
    {
        private string cityCodeField;
        private string cityField;

        private string cityTypeField;

        private string countryField;

        private double latitudeField;

        private double longitudeField;

        private string stateField;

        private string stationIDField;

        private string stationNameField;

        private string zipCodeField;

        /// <remarks/>
        public string City
        {
            get { return cityField; }
            set { cityField = value; }
        }

        /// <remarks/>
        public string CityCode
        {
            get { return cityCodeField; }
            set { cityCodeField = value; }
        }

        /// <remarks/>
        public string CityType
        {
            get { return cityTypeField; }
            set { cityTypeField = value; }
        }

        /// <remarks/>
        public string Country
        {
            get { return countryField; }
            set { countryField = value; }
        }

        /// <remarks/>
        public double Latitude
        {
            get { return latitudeField; }
            set { latitudeField = value; }
        }

        /// <remarks/>
        public double Longitude
        {
            get { return longitudeField; }
            set { longitudeField = value; }
        }

        /// <remarks/>
        public string State
        {
            get { return stateField; }
            set { stateField = value; }
        }

        /// <remarks/>
        public string StationID
        {
            get { return stationIDField; }
            set { stationIDField = value; }
        }

        /// <remarks/>
        public string StationName
        {
            get { return stationNameField; }
            set { stationNameField = value; }
        }

        /// <remarks/>
        public string ZipCode
        {
            get { return zipCodeField; }
            set { zipCodeField = value; }
        }
    }

    /// <remarks/>
    [GeneratedCode("System.Xml", "4.0.30319.233")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://api.wxbug.net/")]
    public class ApiForecastData
    {
        private string conditionIDField;

        private string descriptionField;

        private string iconField;

        private string imageField;

        private bool isNightField;

        private string predictionField;

        private string shortPredictionField;

        private string shortTitleField;

        private string tempHighField;

        private string tempLowField;

        private string tempUnitField;

        private string titleField;

        private string webUrlField;

        /// <remarks/>
        public string ConditionID
        {
            get { return conditionIDField; }
            set { conditionIDField = value; }
        }

        /// <remarks/>
        public string Description
        {
            get { return descriptionField; }
            set { descriptionField = value; }
        }

        /// <remarks/>
        public string Icon
        {
            get { return iconField; }
            set { iconField = value; }
        }

        /// <remarks/>
        public string Image
        {
            get { return imageField; }
            set { imageField = value; }
        }

        /// <remarks/>
        public bool IsNight
        {
            get { return isNightField; }
            set { isNightField = value; }
        }

        /// <remarks/>
        public string Prediction
        {
            get { return predictionField; }
            set { predictionField = value; }
        }

        /// <remarks/>
        public string ShortPrediction
        {
            get { return shortPredictionField; }
            set { shortPredictionField = value; }
        }

        /// <remarks/>
        public string ShortTitle
        {
            get { return shortTitleField; }
            set { shortTitleField = value; }
        }

        /// <remarks/>
        public string TempHigh
        {
            get { return tempHighField; }
            set { tempHighField = value; }
        }

        /// <remarks/>
        public string TempLow
        {
            get { return tempLowField; }
            set { tempLowField = value; }
        }

        /// <remarks/>
        public string TempUnit
        {
            get { return tempUnitField; }
            set { tempUnitField = value; }
        }

        /// <remarks/>
        public string Title
        {
            get { return titleField; }
            set { titleField = value; }
        }

        /// <remarks/>
        public string WebUrl
        {
            get { return webUrlField; }
            set { webUrlField = value; }
        }
    }

    /// <remarks/>
    [GeneratedCode("System.Xml", "4.0.30319.233")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://api.wxbug.net/")]
    public class ApiForecastIssueData
    {
        private string cityCodeField;
        private string cityField;

        private string countryField;

        private string forecastDateField;

        private string stateField;

        private string webUrlField;

        private string zipCodeField;

        private string zoneField;

        /// <remarks/>
        public string City
        {
            get { return cityField; }
            set { cityField = value; }
        }

        /// <remarks/>
        public string CityCode
        {
            get { return cityCodeField; }
            set { cityCodeField = value; }
        }

        /// <remarks/>
        public string Country
        {
            get { return countryField; }
            set { countryField = value; }
        }

        /// <remarks/>
        public string ForecastDate
        {
            get { return forecastDateField; }
            set { forecastDateField = value; }
        }

        /// <remarks/>
        public string State
        {
            get { return stateField; }
            set { stateField = value; }
        }

        /// <remarks/>
        public string WebUrl
        {
            get { return webUrlField; }
            set { webUrlField = value; }
        }

        /// <remarks/>
        public string ZipCode
        {
            get { return zipCodeField; }
            set { zipCodeField = value; }
        }

        /// <remarks/>
        public string Zone
        {
            get { return zoneField; }
            set { zoneField = value; }
        }
    }

    /// <remarks/>
    [GeneratedCode("System.Xml", "4.0.30319.233")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://api.wxbug.net/")]
    public class ApiAlertIssueData
    {
        private int alertCountField;

        private string countyField;

        private string fipsField;

        private string stateField;

        private string webUrlField;
        private string zipCodeField;

        /// <remarks/>
        public int AlertCount
        {
            get { return alertCountField; }
            set { alertCountField = value; }
        }

        /// <remarks/>
        public string County
        {
            get { return countyField; }
            set { countyField = value; }
        }

        /// <remarks/>
        public string Fips
        {
            get { return fipsField; }
            set { fipsField = value; }
        }

        /// <remarks/>
        public string State
        {
            get { return stateField; }
            set { stateField = value; }
        }

        /// <remarks/>
        public string ZipCode
        {
            get { return zipCodeField; }
            set { zipCodeField = value; }
        }

        /// <remarks/>
        public string WebUrl
        {
            get { return webUrlField; }
            set { webUrlField = value; }
        }
    }

    /// <remarks/>
    [GeneratedCode("System.Xml", "4.0.30319.233")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://api.wxbug.net/")]
    public class ApiAlertData
    {
        private DateTime expiryDateTimeField;

        private string expiryTimeZoneField;

        private string idField;

        private DateTime issueDateTimeField;

        private string issueTimeZoneField;

        private string messageField;

        private string titleField;

        private string typeField;

        private string webUrlField;
        private string zipCodeField;

        /// <remarks/>
        public DateTime ExpiryDateTime
        {
            get { return expiryDateTimeField; }
            set { expiryDateTimeField = value; }
        }

        /// <remarks/>
        public string ExpiryTimeZone
        {
            get { return expiryTimeZoneField; }
            set { expiryTimeZoneField = value; }
        }

        /// <remarks/>
        public string ID
        {
            get { return idField; }
            set { idField = value; }
        }

        /// <remarks/>
        public DateTime IssueDateTime
        {
            get { return issueDateTimeField; }
            set { issueDateTimeField = value; }
        }

        /// <remarks/>
        public string IssueTimeZone
        {
            get { return issueTimeZoneField; }
            set { issueTimeZoneField = value; }
        }

        /// <remarks/>
        public string Message
        {
            get { return messageField; }
            set { messageField = value; }
        }

        /// <remarks/>
        public string Title
        {
            get { return titleField; }
            set { titleField = value; }
        }

        /// <remarks/>
        public string Type
        {
            get { return typeField; }
            set { typeField = value; }
        }

        /// <remarks/>
        public string ZipCode
        {
            get { return zipCodeField; }
            set { zipCodeField = value; }
        }

        /// <remarks/>
        public string WebUrl
        {
            get { return webUrlField; }
            set { webUrlField = value; }
        }
    }

    /// <remarks/>
    [GeneratedCode("System.Xml", "4.0.30319.233")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://api.wxbug.net/")]
    public class LiveWeatherData
    {
        private string auxTemperatureField;

        private string auxTemperatureRateField;

        private string cityCodeField;
        private string cityField;

        private string countryField;

        private string currDescField;
        private string currIconField;

        private string dewPointField;

        private int elevationField;

        private string elevationUnitField;

        private string feelsLikeField;

        private DateTime gustTimeField;
        private string gustWindDirectionDegreesField;
        private string gustWindDirectionStringField;

        private string gustWindSpeedField;

        private string gustWindSpeedUnitField;

        private string humidityField;

        private string humidityHighField;

        private string humidityLowField;

        private string humidityRateField;
        private string humidityUnitField;
        private string indoorTemperatureField;

        private string indoorTemperatureRateField;

        private string inputLocationUrlField;
        private double latitudeField;
        private string lightField;

        private string lightRateField;
        private double longitudeField;

        private int moonPhaseField;

        private string moonPhaseImageField;
        private string obDateField;

        private DateTime obDateTimeField;

        private string pressureField;

        private string pressureHighField;

        private string pressureLowField;

        private string pressureRateField;

        private string pressureRateUnitField;
        private string pressureUnitField;

        private string rainMonthField;

        private string rainRateField;

        private string rainRateMaxField;

        private string rainRateUnitField;

        private string rainTodayField;

        private string rainUnitField;

        private string rainYearField;

        private string stateField;

        private string stationIDRequestedField;

        private string stationIDReturnedField;

        private string stationNameField;

        private string stationURLField;

        private DateTime sunriseField;

        private DateTime sunsetField;

        private string temperatureField;

        private string temperatureHighField;

        private string temperatureLowField;

        private string temperatureRateField;

        private string temperatureRateUnitField;

        private string temperatureUnitField;

        private string timeZoneField;

        private double timeZoneOffsetField;

        private string webUrlField;

        private string wetBulbField;

        private string windDirectionAvgField;

        private string windDirectionDegreesField;
        private string windDirectionField;

        private string windSpeedAvgField;
        private string windSpeedField;

        private string windSpeedUnitField;

        private string zipCodeField;

        /// <remarks/>
        public string AuxTemperature
        {
            get { return auxTemperatureField; }
            set { auxTemperatureField = value; }
        }

        /// <remarks/>
        public string AuxTemperatureRate
        {
            get { return auxTemperatureRateField; }
            set { auxTemperatureRateField = value; }
        }

        /// <remarks/>
        public string City
        {
            get { return cityField; }
            set { cityField = value; }
        }

        /// <remarks/>
        public string CityCode
        {
            get { return cityCodeField; }
            set { cityCodeField = value; }
        }

        /// <remarks/>
        public string Country
        {
            get { return countryField; }
            set { countryField = value; }
        }

        /// <remarks/>
        public string CurrIcon
        {
            get { return currIconField; }
            set { currIconField = value; }
        }

        /// <remarks/>
        public string CurrDesc
        {
            get { return currDescField; }
            set { currDescField = value; }
        }

        /// <remarks/>
        public string DewPoint
        {
            get { return dewPointField; }
            set { dewPointField = value; }
        }

        /// <remarks/>
        public int Elevation
        {
            get { return elevationField; }
            set { elevationField = value; }
        }

        /// <remarks/>
        public string ElevationUnit
        {
            get { return elevationUnitField; }
            set { elevationUnitField = value; }
        }

        /// <remarks/>
        public string FeelsLike
        {
            get { return feelsLikeField; }
            set { feelsLikeField = value; }
        }

        /// <remarks/>
        public DateTime GustTime
        {
            get { return gustTimeField; }
            set { gustTimeField = value; }
        }

        /// <remarks/>
        public string GustWindSpeed
        {
            get { return gustWindSpeedField; }
            set { gustWindSpeedField = value; }
        }

        /// <remarks/>
        public string GustWindSpeedUnit
        {
            get { return gustWindSpeedUnitField; }
            set { gustWindSpeedUnitField = value; }
        }

        /// <remarks/>
        public string GustWindDirectionString
        {
            get { return gustWindDirectionStringField; }
            set { gustWindDirectionStringField = value; }
        }

        /// <remarks/>
        public string GustWindDirectionDegrees
        {
            get { return gustWindDirectionDegreesField; }
            set { gustWindDirectionDegreesField = value; }
        }

        /// <remarks/>
        public string Humidity
        {
            get { return humidityField; }
            set { humidityField = value; }
        }

        /// <remarks/>
        public string HumidityUnit
        {
            get { return humidityUnitField; }
            set { humidityUnitField = value; }
        }

        /// <remarks/>
        public string HumidityHigh
        {
            get { return humidityHighField; }
            set { humidityHighField = value; }
        }

        /// <remarks/>
        public string HumidityLow
        {
            get { return humidityLowField; }
            set { humidityLowField = value; }
        }

        /// <remarks/>
        public string HumidityRate
        {
            get { return humidityRateField; }
            set { humidityRateField = value; }
        }

        /// <remarks/>
        public string InputLocationUrl
        {
            get { return inputLocationUrlField; }
            set { inputLocationUrlField = value; }
        }

        /// <remarks/>
        public int MoonPhase
        {
            get { return moonPhaseField; }
            set { moonPhaseField = value; }
        }

        /// <remarks/>
        public string MoonPhaseImage
        {
            get { return moonPhaseImageField; }
            set { moonPhaseImageField = value; }
        }

        /// <remarks/>
        public string Pressure
        {
            get { return pressureField; }
            set { pressureField = value; }
        }

        /// <remarks/>
        public string PressureUnit
        {
            get { return pressureUnitField; }
            set { pressureUnitField = value; }
        }

        /// <remarks/>
        public string PressureHigh
        {
            get { return pressureHighField; }
            set { pressureHighField = value; }
        }

        /// <remarks/>
        public string PressureLow
        {
            get { return pressureLowField; }
            set { pressureLowField = value; }
        }

        /// <remarks/>
        public string PressureRate
        {
            get { return pressureRateField; }
            set { pressureRateField = value; }
        }

        /// <remarks/>
        public string PressureRateUnit
        {
            get { return pressureRateUnitField; }
            set { pressureRateUnitField = value; }
        }

        /// <remarks/>
        public string Light
        {
            get { return lightField; }
            set { lightField = value; }
        }

        /// <remarks/>
        public string LightRate
        {
            get { return lightRateField; }
            set { lightRateField = value; }
        }

        /// <remarks/>
        public string IndoorTemperature
        {
            get { return indoorTemperatureField; }
            set { indoorTemperatureField = value; }
        }

        /// <remarks/>
        public string IndoorTemperatureRate
        {
            get { return indoorTemperatureRateField; }
            set { indoorTemperatureRateField = value; }
        }

        /// <remarks/>
        public double Latitude
        {
            get { return latitudeField; }
            set { latitudeField = value; }
        }

        /// <remarks/>
        public double Longitude
        {
            get { return longitudeField; }
            set { longitudeField = value; }
        }

        /// <remarks/>
        public string ObDate
        {
            get { return obDateField; }
            set { obDateField = value; }
        }

        /// <remarks/>
        public DateTime ObDateTime
        {
            get { return obDateTimeField; }
            set { obDateTimeField = value; }
        }

        /// <remarks/>
        public string RainMonth
        {
            get { return rainMonthField; }
            set { rainMonthField = value; }
        }

        /// <remarks/>
        public string RainRate
        {
            get { return rainRateField; }
            set { rainRateField = value; }
        }

        /// <remarks/>
        public string RainRateMax
        {
            get { return rainRateMaxField; }
            set { rainRateMaxField = value; }
        }

        /// <remarks/>
        public string RainRateUnit
        {
            get { return rainRateUnitField; }
            set { rainRateUnitField = value; }
        }

        /// <remarks/>
        public string RainToday
        {
            get { return rainTodayField; }
            set { rainTodayField = value; }
        }

        /// <remarks/>
        public string RainUnit
        {
            get { return rainUnitField; }
            set { rainUnitField = value; }
        }

        /// <remarks/>
        public string RainYear
        {
            get { return rainYearField; }
            set { rainYearField = value; }
        }

        /// <remarks/>
        public string State
        {
            get { return stateField; }
            set { stateField = value; }
        }

        /// <remarks/>
        public string StationIDRequested
        {
            get { return stationIDRequestedField; }
            set { stationIDRequestedField = value; }
        }

        /// <remarks/>
        public string StationIDReturned
        {
            get { return stationIDReturnedField; }
            set { stationIDReturnedField = value; }
        }

        /// <remarks/>
        public string StationName
        {
            get { return stationNameField; }
            set { stationNameField = value; }
        }

        /// <remarks/>
        public string StationURL
        {
            get { return stationURLField; }
            set { stationURLField = value; }
        }

        /// <remarks/>
        public DateTime Sunrise
        {
            get { return sunriseField; }
            set { sunriseField = value; }
        }

        /// <remarks/>
        public DateTime Sunset
        {
            get { return sunsetField; }
            set { sunsetField = value; }
        }

        /// <remarks/>
        public string Temperature
        {
            get { return temperatureField; }
            set { temperatureField = value; }
        }

        /// <remarks/>
        public string TemperatureHigh
        {
            get { return temperatureHighField; }
            set { temperatureHighField = value; }
        }

        /// <remarks/>
        public string TemperatureLow
        {
            get { return temperatureLowField; }
            set { temperatureLowField = value; }
        }

        /// <remarks/>
        public string TemperatureRate
        {
            get { return temperatureRateField; }
            set { temperatureRateField = value; }
        }

        /// <remarks/>
        public string TemperatureRateUnit
        {
            get { return temperatureRateUnitField; }
            set { temperatureRateUnitField = value; }
        }

        /// <remarks/>
        public string TemperatureUnit
        {
            get { return temperatureUnitField; }
            set { temperatureUnitField = value; }
        }

        /// <remarks/>
        public string TimeZone
        {
            get { return timeZoneField; }
            set { timeZoneField = value; }
        }

        /// <remarks/>
        public double TimeZoneOffset
        {
            get { return timeZoneOffsetField; }
            set { timeZoneOffsetField = value; }
        }

        /// <remarks/>
        public string WebUrl
        {
            get { return webUrlField; }
            set { webUrlField = value; }
        }

        /// <remarks/>
        public string WetBulb
        {
            get { return wetBulbField; }
            set { wetBulbField = value; }
        }

        /// <remarks/>
        public string WindDirection
        {
            get { return windDirectionField; }
            set { windDirectionField = value; }
        }

        /// <remarks/>
        public string WindDirectionAvg
        {
            get { return windDirectionAvgField; }
            set { windDirectionAvgField = value; }
        }

        /// <remarks/>
        public string WindDirectionDegrees
        {
            get { return windDirectionDegreesField; }
            set { windDirectionDegreesField = value; }
        }

        /// <remarks/>
        public string WindSpeed
        {
            get { return windSpeedField; }
            set { windSpeedField = value; }
        }

        /// <remarks/>
        public string WindSpeedAvg
        {
            get { return windSpeedAvgField; }
            set { windSpeedAvgField = value; }
        }

        /// <remarks/>
        public string WindSpeedUnit
        {
            get { return windSpeedUnitField; }
            set { windSpeedUnitField = value; }
        }

        /// <remarks/>
        public string ZipCode
        {
            get { return zipCodeField; }
            set { zipCodeField = value; }
        }
    }

    /// <remarks/>
    [GeneratedCode("System.Xml", "4.0.30319.233")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://api.wxbug.net/")]
    public class LiveCompactWeatherData
    {
        private string cityCodeField;
        private string cityField;

        private string countryField;

        private string currDescField;
        private string currIconField;
        private string gustWindDirectionStringField;

        private string gustWindSpeedField;

        private string gustWindSpeedUnitField;

        private string inputLocationUrlField;

        private double latitudeField;

        private double longitudeField;

        private string obDateField;

        private DateTime obDateTimeField;

        private string rainTodayField;

        private string rainUnitField;

        private string stateField;

        private string stationIDRequestedField;

        private string stationIDReturnedField;

        private string stationNameField;

        private string temperatureField;

        private string temperatureUnitField;

        private string timeZoneField;

        private double timeZoneOffsetField;

        private string webUrlField;

        private string windDirectionField;

        private string windSpeedField;

        private string windSpeedUnitField;

        private string zipCodeField;

        /// <remarks/>
        public string City
        {
            get { return cityField; }
            set { cityField = value; }
        }

        /// <remarks/>
        public string CityCode
        {
            get { return cityCodeField; }
            set { cityCodeField = value; }
        }

        /// <remarks/>
        public string Country
        {
            get { return countryField; }
            set { countryField = value; }
        }

        /// <remarks/>
        public string CurrIcon
        {
            get { return currIconField; }
            set { currIconField = value; }
        }

        /// <remarks/>
        public string CurrDesc
        {
            get { return currDescField; }
            set { currDescField = value; }
        }

        /// <remarks/>
        public string GustWindSpeed
        {
            get { return gustWindSpeedField; }
            set { gustWindSpeedField = value; }
        }

        /// <remarks/>
        public string GustWindSpeedUnit
        {
            get { return gustWindSpeedUnitField; }
            set { gustWindSpeedUnitField = value; }
        }

        /// <remarks/>
        public string GustWindDirectionString
        {
            get { return gustWindDirectionStringField; }
            set { gustWindDirectionStringField = value; }
        }

        /// <remarks/>
        public string InputLocationUrl
        {
            get { return inputLocationUrlField; }
            set { inputLocationUrlField = value; }
        }

        /// <remarks/>
        public double Latitude
        {
            get { return latitudeField; }
            set { latitudeField = value; }
        }

        /// <remarks/>
        public double Longitude
        {
            get { return longitudeField; }
            set { longitudeField = value; }
        }

        /// <remarks/>
        public string ObDate
        {
            get { return obDateField; }
            set { obDateField = value; }
        }

        /// <remarks/>
        public DateTime ObDateTime
        {
            get { return obDateTimeField; }
            set { obDateTimeField = value; }
        }

        /// <remarks/>
        public string RainToday
        {
            get { return rainTodayField; }
            set { rainTodayField = value; }
        }

        /// <remarks/>
        public string RainUnit
        {
            get { return rainUnitField; }
            set { rainUnitField = value; }
        }

        /// <remarks/>
        public string State
        {
            get { return stateField; }
            set { stateField = value; }
        }

        /// <remarks/>
        public string StationIDRequested
        {
            get { return stationIDRequestedField; }
            set { stationIDRequestedField = value; }
        }

        /// <remarks/>
        public string StationIDReturned
        {
            get { return stationIDReturnedField; }
            set { stationIDReturnedField = value; }
        }

        /// <remarks/>
        public string StationName
        {
            get { return stationNameField; }
            set { stationNameField = value; }
        }

        /// <remarks/>
        public string Temperature
        {
            get { return temperatureField; }
            set { temperatureField = value; }
        }

        /// <remarks/>
        public string TemperatureUnit
        {
            get { return temperatureUnitField; }
            set { temperatureUnitField = value; }
        }

        /// <remarks/>
        public string TimeZone
        {
            get { return timeZoneField; }
            set { timeZoneField = value; }
        }

        /// <remarks/>
        public double TimeZoneOffset
        {
            get { return timeZoneOffsetField; }
            set { timeZoneOffsetField = value; }
        }

        /// <remarks/>
        public string WebUrl
        {
            get { return webUrlField; }
            set { webUrlField = value; }
        }

        /// <remarks/>
        public string WindDirection
        {
            get { return windDirectionField; }
            set { windDirectionField = value; }
        }

        /// <remarks/>
        public string WindSpeed
        {
            get { return windSpeedField; }
            set { windSpeedField = value; }
        }

        /// <remarks/>
        public string WindSpeedUnit
        {
            get { return windSpeedUnitField; }
            set { windSpeedUnitField = value; }
        }

        /// <remarks/>
        public string ZipCode
        {
            get { return zipCodeField; }
            set { zipCodeField = value; }
        }
    }

    /// <remarks/>
    [GeneratedCode("System.Xml", "4.0.30319.233")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://api.wxbug.net/")]
    public class ApiStationData
    {
        private string cityCodeField;
        private string cityField;

        private string cityTypeField;

        private string countryField;

        private string distanceField;

        private string distanceUnitField;

        private string latitudeField;

        private string longitudeField;

        private string stateField;

        private string stationIDField;

        private string stationNameField;

        private string zipCodeField;

        /// <remarks/>
        public string City
        {
            get { return cityField; }
            set { cityField = value; }
        }

        /// <remarks/>
        public string CityCode
        {
            get { return cityCodeField; }
            set { cityCodeField = value; }
        }

        /// <remarks/>
        public string CityType
        {
            get { return cityTypeField; }
            set { cityTypeField = value; }
        }

        /// <remarks/>
        public string Country
        {
            get { return countryField; }
            set { countryField = value; }
        }

        /// <remarks/>
        public string Distance
        {
            get { return distanceField; }
            set { distanceField = value; }
        }

        /// <remarks/>
        public string DistanceUnit
        {
            get { return distanceUnitField; }
            set { distanceUnitField = value; }
        }

        /// <remarks/>
        public string Latitude
        {
            get { return latitudeField; }
            set { latitudeField = value; }
        }

        /// <remarks/>
        public string Longitude
        {
            get { return longitudeField; }
            set { longitudeField = value; }
        }

        /// <remarks/>
        public string State
        {
            get { return stateField; }
            set { stateField = value; }
        }

        /// <remarks/>
        public string StationID
        {
            get { return stationIDField; }
            set { stationIDField = value; }
        }

        /// <remarks/>
        public string StationName
        {
            get { return stationNameField; }
            set { stationNameField = value; }
        }

        /// <remarks/>
        public string ZipCode
        {
            get { return zipCodeField; }
            set { zipCodeField = value; }
        }
    }

    /// <remarks/>
    [GeneratedCode("System.Xml", "4.0.30319.233")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://api.wxbug.net/")]
    public class LocationUSWorldCityData
    {
        private string cityCodeField;
        private string cityNameField;

        private string countryCodeField;

        private bool isUSCityField;

        private decimal latitudeField;

        private decimal longitudeField;

        private string provinceField;

        private string stateField;

        private decimal timeZoneField;

        private string zipCodeField;

        /// <remarks/>
        public string CityName
        {
            get { return cityNameField; }
            set { cityNameField = value; }
        }

        /// <remarks/>
        public string CityCode
        {
            get { return cityCodeField; }
            set { cityCodeField = value; }
        }

        /// <remarks/>
        public string CountryCode
        {
            get { return countryCodeField; }
            set { countryCodeField = value; }
        }

        /// <remarks/>
        public bool isUSCity
        {
            get { return isUSCityField; }
            set { isUSCityField = value; }
        }

        /// <remarks/>
        public decimal Latitude
        {
            get { return latitudeField; }
            set { latitudeField = value; }
        }

        /// <remarks/>
        public decimal Longitude
        {
            get { return longitudeField; }
            set { longitudeField = value; }
        }

        /// <remarks/>
        public string Province
        {
            get { return provinceField; }
            set { provinceField = value; }
        }

        /// <remarks/>
        public string State
        {
            get { return stateField; }
            set { stateField = value; }
        }

        /// <remarks/>
        public decimal TimeZone
        {
            get { return timeZoneField; }
            set { timeZoneField = value; }
        }

        /// <remarks/>
        public string ZipCode
        {
            get { return zipCodeField; }
            set { zipCodeField = value; }
        }
    }

    /// <remarks/>
    [GeneratedCode("System.Xml", "4.0.30319.233")]
    [Serializable]
    [XmlType(Namespace = "http://api.wxbug.net/")]
    public enum UnitType
    {
        /// <remarks/>
        English,

        /// <remarks/>
        Metric,
    }

    /// <remarks/>
    [GeneratedCode("System.Web.Services", "4.0.30319.1")]
    public delegate void GetLocationListCompletedEventHandler(object sender, GetLocationListCompletedEventArgs e);

    /// <remarks/>
    [GeneratedCode("System.Web.Services", "4.0.30319.1")]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    public class GetLocationListCompletedEventArgs : AsyncCompletedEventArgs
    {
        private readonly object[] results;

        internal GetLocationListCompletedEventArgs(object[] results, Exception exception, bool cancelled,
                                                   object userState) :
                                                       base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public ApiLocationData[] Result
        {
            get
            {
                RaiseExceptionIfNecessary();
                return ((ApiLocationData[]) (results[0]));
            }
        }
    }

    /// <remarks/>
    [GeneratedCode("System.Web.Services", "4.0.30319.1")]
    public delegate void GetUSWorldCityByLatLongCompletedEventHandler(
        object sender, GetUSWorldCityByLatLongCompletedEventArgs e);

    /// <remarks/>
    [GeneratedCode("System.Web.Services", "4.0.30319.1")]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    public class GetUSWorldCityByLatLongCompletedEventArgs : AsyncCompletedEventArgs
    {
        private readonly object[] results;

        internal GetUSWorldCityByLatLongCompletedEventArgs(object[] results, Exception exception, bool cancelled,
                                                           object userState) :
                                                               base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public LocationUSWorldCityData Result
        {
            get
            {
                RaiseExceptionIfNecessary();
                return ((LocationUSWorldCityData) (results[0]));
            }
        }
    }

    /// <remarks/>
    [GeneratedCode("System.Web.Services", "4.0.30319.1")]
    public delegate void GetStationListByCityCodeCompletedEventHandler(
        object sender, GetStationListByCityCodeCompletedEventArgs e);

    /// <remarks/>
    [GeneratedCode("System.Web.Services", "4.0.30319.1")]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    public class GetStationListByCityCodeCompletedEventArgs : AsyncCompletedEventArgs
    {
        private readonly object[] results;

        internal GetStationListByCityCodeCompletedEventArgs(object[] results, Exception exception, bool cancelled,
                                                            object userState) :
                                                                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public ApiStationData[] Result
        {
            get
            {
                RaiseExceptionIfNecessary();
                return ((ApiStationData[]) (results[0]));
            }
        }
    }

    /// <remarks/>
    [GeneratedCode("System.Web.Services", "4.0.30319.1")]
    public delegate void GetStationListByUSZipCodeCompletedEventHandler(
        object sender, GetStationListByUSZipCodeCompletedEventArgs e);

    /// <remarks/>
    [GeneratedCode("System.Web.Services", "4.0.30319.1")]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    public class GetStationListByUSZipCodeCompletedEventArgs : AsyncCompletedEventArgs
    {
        private readonly object[] results;

        internal GetStationListByUSZipCodeCompletedEventArgs(object[] results, Exception exception, bool cancelled,
                                                             object userState) :
                                                                 base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public ApiStationData[] Result
        {
            get
            {
                RaiseExceptionIfNecessary();
                return ((ApiStationData[]) (results[0]));
            }
        }
    }

    /// <remarks/>
    [GeneratedCode("System.Web.Services", "4.0.30319.1")]
    public delegate void GetLiveCompactWeatherByCityCodeCompletedEventHandler(
        object sender, GetLiveCompactWeatherByCityCodeCompletedEventArgs e);

    /// <remarks/>
    [GeneratedCode("System.Web.Services", "4.0.30319.1")]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    public class GetLiveCompactWeatherByCityCodeCompletedEventArgs : AsyncCompletedEventArgs
    {
        private readonly object[] results;

        internal GetLiveCompactWeatherByCityCodeCompletedEventArgs(object[] results, Exception exception, bool cancelled,
                                                                   object userState) :
                                                                       base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public LiveCompactWeatherData Result
        {
            get
            {
                RaiseExceptionIfNecessary();
                return ((LiveCompactWeatherData) (results[0]));
            }
        }
    }

    /// <remarks/>
    [GeneratedCode("System.Web.Services", "4.0.30319.1")]
    public delegate void GetLiveCompactWeatherByUSZipCodeCompletedEventHandler(
        object sender, GetLiveCompactWeatherByUSZipCodeCompletedEventArgs e);

    /// <remarks/>
    [GeneratedCode("System.Web.Services", "4.0.30319.1")]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    public class GetLiveCompactWeatherByUSZipCodeCompletedEventArgs : AsyncCompletedEventArgs
    {
        private readonly object[] results;

        internal GetLiveCompactWeatherByUSZipCodeCompletedEventArgs(object[] results, Exception exception,
                                                                    bool cancelled, object userState) :
                                                                        base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public LiveCompactWeatherData Result
        {
            get
            {
                RaiseExceptionIfNecessary();
                return ((LiveCompactWeatherData) (results[0]));
            }
        }
    }

    /// <remarks/>
    [GeneratedCode("System.Web.Services", "4.0.30319.1")]
    public delegate void GetLiveCompactWeatherByStationIDCompletedEventHandler(
        object sender, GetLiveCompactWeatherByStationIDCompletedEventArgs e);

    /// <remarks/>
    [GeneratedCode("System.Web.Services", "4.0.30319.1")]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    public class GetLiveCompactWeatherByStationIDCompletedEventArgs : AsyncCompletedEventArgs
    {
        private readonly object[] results;

        internal GetLiveCompactWeatherByStationIDCompletedEventArgs(object[] results, Exception exception,
                                                                    bool cancelled, object userState) :
                                                                        base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public LiveCompactWeatherData Result
        {
            get
            {
                RaiseExceptionIfNecessary();
                return ((LiveCompactWeatherData) (results[0]));
            }
        }
    }

    /// <remarks/>
    [GeneratedCode("System.Web.Services", "4.0.30319.1")]
    public delegate void GetLiveWeatherByCityCodeCompletedEventHandler(
        object sender, GetLiveWeatherByCityCodeCompletedEventArgs e);

    /// <remarks/>
    [GeneratedCode("System.Web.Services", "4.0.30319.1")]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    public class GetLiveWeatherByCityCodeCompletedEventArgs : AsyncCompletedEventArgs
    {
        private readonly object[] results;

        internal GetLiveWeatherByCityCodeCompletedEventArgs(object[] results, Exception exception, bool cancelled,
                                                            object userState) :
                                                                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public LiveWeatherData Result
        {
            get
            {
                RaiseExceptionIfNecessary();
                return ((LiveWeatherData) (results[0]));
            }
        }
    }

    /// <remarks/>
    [GeneratedCode("System.Web.Services", "4.0.30319.1")]
    public delegate void GetLiveWeatherByUSZipCodeCompletedEventHandler(
        object sender, GetLiveWeatherByUSZipCodeCompletedEventArgs e);

    /// <remarks/>
    [GeneratedCode("System.Web.Services", "4.0.30319.1")]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    public class GetLiveWeatherByUSZipCodeCompletedEventArgs : AsyncCompletedEventArgs
    {
        private readonly object[] results;

        internal GetLiveWeatherByUSZipCodeCompletedEventArgs(object[] results, Exception exception, bool cancelled,
                                                             object userState) :
                                                                 base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public LiveWeatherData Result
        {
            get
            {
                RaiseExceptionIfNecessary();
                return ((LiveWeatherData) (results[0]));
            }
        }
    }

    /// <remarks/>
    [GeneratedCode("System.Web.Services", "4.0.30319.1")]
    public delegate void GetLiveWeatherByStationIDCompletedEventHandler(
        object sender, GetLiveWeatherByStationIDCompletedEventArgs e);

    /// <remarks/>
    [GeneratedCode("System.Web.Services", "4.0.30319.1")]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    public class GetLiveWeatherByStationIDCompletedEventArgs : AsyncCompletedEventArgs
    {
        private readonly object[] results;

        internal GetLiveWeatherByStationIDCompletedEventArgs(object[] results, Exception exception, bool cancelled,
                                                             object userState) :
                                                                 base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public LiveWeatherData Result
        {
            get
            {
                RaiseExceptionIfNecessary();
                return ((LiveWeatherData) (results[0]));
            }
        }
    }

    /// <remarks/>
    [GeneratedCode("System.Web.Services", "4.0.30319.1")]
    public delegate void GetAlertsDataListCompletedEventHandler(object sender, GetAlertsDataListCompletedEventArgs e);

    /// <remarks/>
    [GeneratedCode("System.Web.Services", "4.0.30319.1")]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    public class GetAlertsDataListCompletedEventArgs : AsyncCompletedEventArgs
    {
        private readonly object[] results;

        internal GetAlertsDataListCompletedEventArgs(object[] results, Exception exception, bool cancelled,
                                                     object userState) :
                                                         base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public ApiAlertData[] Result
        {
            get
            {
                RaiseExceptionIfNecessary();
                return ((ApiAlertData[]) (results[0]));
            }
        }
    }

    /// <remarks/>
    [GeneratedCode("System.Web.Services", "4.0.30319.1")]
    public delegate void GetAlertsIssueDataCompletedEventHandler(object sender, GetAlertsIssueDataCompletedEventArgs e);

    /// <remarks/>
    [GeneratedCode("System.Web.Services", "4.0.30319.1")]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    public class GetAlertsIssueDataCompletedEventArgs : AsyncCompletedEventArgs
    {
        private readonly object[] results;

        internal GetAlertsIssueDataCompletedEventArgs(object[] results, Exception exception, bool cancelled,
                                                      object userState) :
                                                          base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public ApiAlertIssueData Result
        {
            get
            {
                RaiseExceptionIfNecessary();
                return ((ApiAlertIssueData) (results[0]));
            }
        }
    }

    /// <remarks/>
    [GeneratedCode("System.Web.Services", "4.0.30319.1")]
    public delegate void GetForecastIssueDetailsByCityCodeCompletedEventHandler(
        object sender, GetForecastIssueDetailsByCityCodeCompletedEventArgs e);

    /// <remarks/>
    [GeneratedCode("System.Web.Services", "4.0.30319.1")]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    public class GetForecastIssueDetailsByCityCodeCompletedEventArgs : AsyncCompletedEventArgs
    {
        private readonly object[] results;

        internal GetForecastIssueDetailsByCityCodeCompletedEventArgs(object[] results, Exception exception,
                                                                     bool cancelled, object userState) :
                                                                         base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public ApiForecastIssueData Result
        {
            get
            {
                RaiseExceptionIfNecessary();
                return ((ApiForecastIssueData) (results[0]));
            }
        }
    }

    /// <remarks/>
    [GeneratedCode("System.Web.Services", "4.0.30319.1")]
    public delegate void GetForecastIssueDetailsByUSZipCodeCompletedEventHandler(
        object sender, GetForecastIssueDetailsByUSZipCodeCompletedEventArgs e);

    /// <remarks/>
    [GeneratedCode("System.Web.Services", "4.0.30319.1")]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    public class GetForecastIssueDetailsByUSZipCodeCompletedEventArgs : AsyncCompletedEventArgs
    {
        private readonly object[] results;

        internal GetForecastIssueDetailsByUSZipCodeCompletedEventArgs(object[] results, Exception exception,
                                                                      bool cancelled, object userState) :
                                                                          base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public ApiForecastIssueData Result
        {
            get
            {
                RaiseExceptionIfNecessary();
                return ((ApiForecastIssueData) (results[0]));
            }
        }
    }

    /// <remarks/>
    [GeneratedCode("System.Web.Services", "4.0.30319.1")]
    public delegate void GetForecastByCityCodeCompletedEventHandler(
        object sender, GetForecastByCityCodeCompletedEventArgs e);

    /// <remarks/>
    [GeneratedCode("System.Web.Services", "4.0.30319.1")]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    public class GetForecastByCityCodeCompletedEventArgs : AsyncCompletedEventArgs
    {
        private readonly object[] results;

        internal GetForecastByCityCodeCompletedEventArgs(object[] results, Exception exception, bool cancelled,
                                                         object userState) :
                                                             base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public ApiForecastData[] Result
        {
            get
            {
                RaiseExceptionIfNecessary();
                return ((ApiForecastData[]) (results[0]));
            }
        }
    }

    /// <remarks/>
    [GeneratedCode("System.Web.Services", "4.0.30319.1")]
    public delegate void GetForecastByUSZipCodeCompletedEventHandler(
        object sender, GetForecastByUSZipCodeCompletedEventArgs e);

    /// <remarks/>
    [GeneratedCode("System.Web.Services", "4.0.30319.1")]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    public class GetForecastByUSZipCodeCompletedEventArgs : AsyncCompletedEventArgs
    {
        private readonly object[] results;

        internal GetForecastByUSZipCodeCompletedEventArgs(object[] results, Exception exception, bool cancelled,
                                                          object userState) :
                                                              base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public ApiForecastData[] Result
        {
            get
            {
                RaiseExceptionIfNecessary();
                return ((ApiForecastData[]) (results[0]));
            }
        }
    }
}

#pragma warning restore 1591