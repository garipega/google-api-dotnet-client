// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by google-apis-code-generator 1.5.1
//     C# generator version: 1.30.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

/**
 * \brief
 *   Google Ad Experience Report API Version v1
 *
 * \section ApiInfo API Version Information
 *    <table>
 *      <tr><th>API
 *          <td><a href='https://developers.google.com/ad-experience-report/'>Google Ad Experience Report API</a>
 *      <tr><th>API Version<td>v1
 *      <tr><th>API Rev<td>20171120 (1054)
 *      <tr><th>API Docs
 *          <td><a href='https://developers.google.com/ad-experience-report/'>
 *              https://developers.google.com/ad-experience-report/</a>
 *      <tr><th>Discovery Name<td>adexperiencereport
 *    </table>
 *
 * \section ForMoreInfo For More Information
 *
 * The complete API documentation for using Google Ad Experience Report API can be found at
 * <a href='https://developers.google.com/ad-experience-report/'>https://developers.google.com/ad-experience-report/</a>.
 *
 * For more information about the Google APIs Client Library for .NET, see
 * <a href='https://developers.google.com/api-client-library/dotnet/get_started'>
 * https://developers.google.com/api-client-library/dotnet/get_started</a>
 */

namespace Google.Apis.AdExperienceReport.v1
{
    /// <summary>The AdExperienceReport Service.</summary>
    public class AdExperienceReportService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed =
            Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public AdExperienceReportService() :
            this(new Google.Apis.Services.BaseClientService.Initializer()) {}

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public AdExperienceReportService(Google.Apis.Services.BaseClientService.Initializer initializer)
            : base(initializer)
        {
            sites = new SitesResource(this);
            violatingSites = new ViolatingSitesResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features
        {
            get { return new string[0]; }
        }

        /// <summary>Gets the service name.</summary>
        public override string Name
        {
            get { return "adexperiencereport"; }
        }

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri
        {
            get { return "https://adexperiencereport.googleapis.com/"; }
        }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath
        {
            get { return ""; }
        }

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri
        {
            get { return "https://adexperiencereport.googleapis.com/batch"; }
        }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath
        {
            get { return "batch"; }
        }
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Google Ad Experience Report API.</summary>
        public class Scope
        {
            /// <summary>Test scope for access to the Zoo service</summary>
            public static string XapiZoo = "https://www.googleapis.com/auth/xapi.zoo";

        }



        private readonly SitesResource sites;

        /// <summary>Gets the Sites resource.</summary>
        public virtual SitesResource Sites
        {
            get { return sites; }
        }

        private readonly ViolatingSitesResource violatingSites;

        /// <summary>Gets the ViolatingSites resource.</summary>
        public virtual ViolatingSitesResource ViolatingSites
        {
            get { return violatingSites; }
        }
    }

    ///<summary>A base abstract class for AdExperienceReport requests.</summary>
    public abstract class AdExperienceReportBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        ///<summary>Constructs a new AdExperienceReportBaseServiceRequest instance.</summary>
        protected AdExperienceReportBaseServiceRequest(Google.Apis.Services.IClientService service)
            : base(service)
        {
        }

        /// <summary>V1 error format.</summary>
        [Google.Apis.Util.RequestParameterAttribute("$.xgafv", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<XgafvEnum> Xgafv { get; set; }

        /// <summary>V1 error format.</summary>
        public enum XgafvEnum
        {
            /// <summary>v1 error format</summary>
            [Google.Apis.Util.StringValueAttribute("1")]
            Value1,
            /// <summary>v2 error format</summary>
            [Google.Apis.Util.StringValueAttribute("2")]
            Value2,
        }

        /// <summary>OAuth access token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("access_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string AccessToken { get; set; }

        /// <summary>Data format for response.</summary>
        /// [default: json]
        [Google.Apis.Util.RequestParameterAttribute("alt", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<AltEnum> Alt { get; set; }

        /// <summary>Data format for response.</summary>
        public enum AltEnum
        {
            /// <summary>Responses with Content-Type of application/json</summary>
            [Google.Apis.Util.StringValueAttribute("json")]
            Json,
            /// <summary>Media download with context-dependent Content-Type</summary>
            [Google.Apis.Util.StringValueAttribute("media")]
            Media,
            /// <summary>Responses with Content-Type of application/x-protobuf</summary>
            [Google.Apis.Util.StringValueAttribute("proto")]
            Proto,
        }

        /// <summary>OAuth bearer token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("bearer_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string BearerToken { get; set; }

        /// <summary>JSONP</summary>
        [Google.Apis.Util.RequestParameterAttribute("callback", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Callback { get; set; }

        /// <summary>Selector specifying which fields to include in a partial response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("fields", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Fields { get; set; }

        /// <summary>API key. Your API key identifies your project and provides you with API access, quota, and reports.
        /// Required unless you provide an OAuth 2.0 token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("key", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Key { get; set; }

        /// <summary>OAuth 2.0 token for the current user.</summary>
        [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string OauthToken { get; set; }

        /// <summary>Pretty-print response.</summary>
        /// [default: true]
        [Google.Apis.Util.RequestParameterAttribute("pp", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<bool> Pp { get; set; }

        /// <summary>Returns response with indentations and line breaks.</summary>
        /// [default: true]
        [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<bool> PrettyPrint { get; set; }

        /// <summary>Available to use for quota purposes for server-side applications. Can be any arbitrary string
        /// assigned to a user, but should not exceed 40 characters.</summary>
        [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string QuotaUser { get; set; }

        /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadType { get; set; }

        /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadProtocol { get; set; }

        /// <summary>Initializes AdExperienceReport parameter list.</summary>
        protected override void InitParameters()
        {
            base.InitParameters();

            RequestParameters.Add(
                "$.xgafv", new Google.Apis.Discovery.Parameter
                {
                    Name = "$.xgafv",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "access_token", new Google.Apis.Discovery.Parameter
                {
                    Name = "access_token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "alt", new Google.Apis.Discovery.Parameter
                {
                    Name = "alt",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "json",
                    Pattern = null,
                });
            RequestParameters.Add(
                "bearer_token", new Google.Apis.Discovery.Parameter
                {
                    Name = "bearer_token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "callback", new Google.Apis.Discovery.Parameter
                {
                    Name = "callback",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "fields", new Google.Apis.Discovery.Parameter
                {
                    Name = "fields",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "key", new Google.Apis.Discovery.Parameter
                {
                    Name = "key",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "oauth_token", new Google.Apis.Discovery.Parameter
                {
                    Name = "oauth_token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "pp", new Google.Apis.Discovery.Parameter
                {
                    Name = "pp",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "true",
                    Pattern = null,
                });
            RequestParameters.Add(
                "prettyPrint", new Google.Apis.Discovery.Parameter
                {
                    Name = "prettyPrint",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "true",
                    Pattern = null,
                });
            RequestParameters.Add(
                "quotaUser", new Google.Apis.Discovery.Parameter
                {
                    Name = "quotaUser",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "uploadType", new Google.Apis.Discovery.Parameter
                {
                    Name = "uploadType",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "upload_protocol", new Google.Apis.Discovery.Parameter
                {
                    Name = "upload_protocol",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
        }
    }

    /// <summary>The "sites" collection of methods.</summary>
    public class SitesResource
    {
        private const string Resource = "sites";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public SitesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Gets a summary of the ad experience rating of a site.</summary>
        /// <param name="name">The required site name. It should be the site property whose ad experiences may have been
        /// reviewed, and it should be URL-encoded. For example, sites/https%3A%2F%2Fwww.google.com. The server will return an
        /// error of BAD_REQUEST if this field is not filled in. Note that if the site property is not yet verified in Search
        /// Console, the reportUrl field returned by the API will lead to the verification page, prompting the user to go
        /// through that process before they can gain access to the Ad Experience Report.</param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(service, name);
        }

        /// <summary>Gets a summary of the ad experience rating of a site.</summary>
        public class GetRequest : AdExperienceReportBaseServiceRequest<Google.Apis.AdExperienceReport.v1.Data.SiteSummaryResponse>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string name)
                : base(service)
            {
                Name = name;
                InitParameters();
            }


            /// <summary>The required site name. It should be the site property whose ad experiences may have been
            /// reviewed, and it should be URL-encoded. For example, sites/https%3A%2F%2Fwww.google.com. The server will
            /// return an error of BAD_REQUEST if this field is not filled in. Note that if the site property is not yet
            /// verified in Search Console, the reportUrl field returned by the API will lead to the verification page,
            /// prompting the user to go through that process before they can gain access to the Ad Experience
            /// Report.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName
            {
                get { return "get"; }
            }

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod
            {
                get { return "GET"; }
            }

            ///<summary>Gets the REST path.</summary>
            public override string RestPath
            {
                get { return "v1/{+name}"; }
            }

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^sites/[^/]+$",
                    });
            }

        }
    }

    /// <summary>The "violatingSites" collection of methods.</summary>
    public class ViolatingSitesResource
    {
        private const string Resource = "violatingSites";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ViolatingSitesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Lists sites with Ad Experience Report statuses of "Failing" or "Warning".</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>Lists sites with Ad Experience Report statuses of "Failing" or "Warning".</summary>
        public class ListRequest : AdExperienceReportBaseServiceRequest<Google.Apis.AdExperienceReport.v1.Data.ViolatingSitesResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service)
                : base(service)
            {
                InitParameters();
            }



            ///<summary>Gets the method name.</summary>
            public override string MethodName
            {
                get { return "list"; }
            }

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod
            {
                get { return "GET"; }
            }

            ///<summary>Gets the REST path.</summary>
            public override string RestPath
            {
                get { return "v1/violatingSites"; }
            }

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

            }

        }
    }
}

namespace Google.Apis.AdExperienceReport.v1.Data
{    

    /// <summary>Summary of the ad experience rating of a site for a specific platform.</summary>
    public class PlatformSummary : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The status of the site reviewed for the Better Ads Standards.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("betterAdsStatus")]
        public virtual string BetterAdsStatus { get; set; } 

        /// <summary>The date on which ad filtering begins.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enforcementTime")]
        public virtual object EnforcementTime { get; set; } 

        /// <summary>The ad filtering status of the site.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filterStatus")]
        public virtual string FilterStatus { get; set; } 

        /// <summary>The last time that the site changed status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastChangeTime")]
        public virtual object LastChangeTime { get; set; } 

        /// <summary>The assigned regions for the site and platform.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("region")]
        public virtual System.Collections.Generic.IList<string> Region { get; set; } 

        /// <summary>A link that leads to a full ad experience report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportUrl")]
        public virtual string ReportUrl { get; set; } 

        /// <summary>Whether the site is currently under review.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("underReview")]
        public virtual System.Nullable<bool> UnderReview { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Response message for GetSiteSummary.</summary>
    public class SiteSummaryResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Summary for the desktop review of the site.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("desktopSummary")]
        public virtual PlatformSummary DesktopSummary { get; set; } 

        /// <summary>Summary for the mobile review of the site.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mobileSummary")]
        public virtual PlatformSummary MobileSummary { get; set; } 

        /// <summary>The name of the site reviewed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reviewedSite")]
        public virtual string ReviewedSite { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Response message for ListViolatingSites.</summary>
    public class ViolatingSitesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of summaries of violating sites.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("violatingSites")]
        public virtual System.Collections.Generic.IList<SiteSummaryResponse> ViolatingSites { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
