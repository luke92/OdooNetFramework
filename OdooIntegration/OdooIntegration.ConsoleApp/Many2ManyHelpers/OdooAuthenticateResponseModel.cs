using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace OdooIntegration.ConsoleApp.Many2ManyHelpers
{
    public class OdooAuthenticateResponseModel
    {
        [JsonProperty("jsonrpc")]
        public string Jsonrpc { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("result")]
        public Result Result { get; set; }
    }

    public class Result
    {
        [JsonProperty("session_id")]
        public string SessionId { get; set; }

        [JsonProperty("uid")]
        public long Uid { get; set; }

        [JsonProperty("is_system")]
        public bool IsSystem { get; set; }

        [JsonProperty("is_admin")]
        public bool IsAdmin { get; set; }

        [JsonProperty("user_context")]
        public UserContext UserContext { get; set; }

        [JsonProperty("db")]
        public string Db { get; set; }

        [JsonProperty("server_version")]
        public string ServerVersion { get; set; }

        [JsonProperty("server_version_info")]
        public List<ServerVersionInfo> ServerVersionInfo { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("partner_display_name")]
        public string PartnerDisplayName { get; set; }

        [JsonProperty("company_id")]
        public long CompanyId { get; set; }

        [JsonProperty("partner_id")]
        public long PartnerId { get; set; }

        [JsonProperty("user_companies")]
        public UserCompanies UserCompanies { get; set; }

        [JsonProperty("currencies")]
        public Dictionary<string, Currency> Currencies { get; set; }

        [JsonProperty("web.base.url")]
        public Uri WebBaseUrl { get; set; }

        [JsonProperty("show_effect")]
        public string ShowEffect { get; set; }

        [JsonProperty("max_time_between_keys_in_ms")]
        public long MaxTimeBetweenKeysInMs { get; set; }

        [JsonProperty("company_currency_id")]
        public long CompanyCurrencyId { get; set; }

        [JsonProperty("warning")]
        public string Warning { get; set; }

        [JsonProperty("expiration_date")]
        public DateTimeOffset ExpirationDate { get; set; }

        [JsonProperty("expiration_reason")]
        public string ExpirationReason { get; set; }

        [JsonProperty("web_tours")]
        public List<object> WebTours { get; set; }

        [JsonProperty("odoobot_initialized")]
        public bool OdoobotInitialized { get; set; }

        [JsonProperty("ocn_token_key")]
        public bool OcnTokenKey { get; set; }

        [JsonProperty("fcm_project_id")]
        public bool FcmProjectId { get; set; }

        [JsonProperty("inbox_action")]
        public long InboxAction { get; set; }

        [JsonProperty("dbuuid")]
        public Guid Dbuuid { get; set; }

        [JsonProperty("multi_lang")]
        public bool MultiLang { get; set; }

        [JsonProperty("timesheet_uom")]
        public TimesheetUom TimesheetUom { get; set; }

        [JsonProperty("timesheet_uom_factor")]
        public long TimesheetUomFactor { get; set; }
    }

    public class Currency
    {
        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("digits")]
        public List<long> Digits { get; set; }
    }

    public class TimesheetUom
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("rounding")]
        public decimal Rounding { get; set; }

        [JsonProperty("timesheet_widget")]
        public string TimesheetWidget { get; set; }
    }

    public class UserCompanies
    {
        [JsonProperty("current_company")]
        public List<ServerVersionInfo> CurrentCompany { get; set; }

        [JsonProperty("allowed_companies")]
        public List<List<ServerVersionInfo>> AllowedCompanies { get; set; }
    }

    public class UserContext
    {
        [JsonProperty("lang")]
        public string Lang { get; set; }

        [JsonProperty("tz")]
        public string Tz { get; set; }

        [JsonProperty("uid")]
        public long Uid { get; set; }
    }

    public struct ServerVersionInfo
    {
        public long? Integer;
        public string String;

        public static implicit operator ServerVersionInfo(long Integer) => new ServerVersionInfo { Integer = Integer };
        public static implicit operator ServerVersionInfo(string String) => new ServerVersionInfo { String = String };
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                ServerVersionInfoConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class ServerVersionInfoConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ServerVersionInfo) || t == typeof(ServerVersionInfo?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                    var integerValue = serializer.Deserialize<long>(reader);
                    return new ServerVersionInfo { Integer = integerValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new ServerVersionInfo { String = stringValue };
            }
            throw new Exception("Cannot unmarshal type ServerVersionInfo");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (ServerVersionInfo)untypedValue;
            if (value.Integer != null)
            {
                serializer.Serialize(writer, value.Integer.Value);
                return;
            }
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            throw new Exception("Cannot marshal type ServerVersionInfo");
        }

        public static readonly ServerVersionInfoConverter Singleton = new ServerVersionInfoConverter();
    }
}