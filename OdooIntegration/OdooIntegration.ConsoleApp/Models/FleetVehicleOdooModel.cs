using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PortaCapena.OdooJsonRpcClient.Attributes;
using PortaCapena.OdooJsonRpcClient.Converters;
using PortaCapena.OdooJsonRpcClient.Models;
using System;
using System.Runtime.Serialization;

namespace OdooIntegration.ConsoleApp.Models
{
    [OdooTableName("fleet.vehicle")]
    [JsonConverter(typeof(OdooModelConverter))]
    public class FleetVehicleOdooModel : IOdooModel
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("active")]
        public bool? Active { get; set; }

        // res.company
        [JsonProperty("company_id")]
        public long? CompanyId { get; set; }

        [JsonProperty("license_plate")]
        public string LicensePlate { get; set; }

        [JsonProperty("vin_sn")]
        public string VinSn { get; set; }

        // res.partner
        [JsonProperty("driver_id")]
        public long? DriverId { get; set; }

        // fleet.vehicle.model
        // required
        [JsonProperty("model_id")]
        public long ModelId { get; set; }

        // fleet.vehicle.model.brand
        [JsonProperty("brand_id")]
        public long? BrandId { get; set; }

        // fleet.vehicle.assignation.log
        [JsonProperty("log_drivers")]
        public long[] LogDrivers { get; set; }

        // fleet.vehicle.log.fuel
        [JsonProperty("log_fuel")]
        public long[] LogFuel { get; set; }

        // fleet.vehicle.log.services
        [JsonProperty("log_services")]
        public long[] LogServices { get; set; }

        // fleet.vehicle.log.contract
        [JsonProperty("log_contracts")]
        public long[] LogContracts { get; set; }

        [JsonProperty("cost_count")]
        public int? CostCount { get; set; }

        [JsonProperty("contract_count")]
        public int? ContractCount { get; set; }

        [JsonProperty("service_count")]
        public int? ServiceCount { get; set; }

        [JsonProperty("fuel_logs_count")]
        public int? FuelLogsCount { get; set; }

        [JsonProperty("odometer_count")]
        public int? OdometerCount { get; set; }

        [JsonProperty("acquisition_date")]
        public DateTime? AcquisitionDate { get; set; }

        [JsonProperty("first_contract_date")]
        public DateTime? FirstContractDate { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        // fleet.vehicle.state
        [JsonProperty("state_id")]
        public long? StateId { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("seats")]
        public int? Seats { get; set; }

        [JsonProperty("model_year")]
        public string ModelYear { get; set; }

        [JsonProperty("doors")]
        public int? Doors { get; set; }

        // fleet.vehicle.tag
        [JsonProperty("tag_ids")]
        public long[] TagIds { get; set; }

        [JsonProperty("odometer")]
        public double? Odometer { get; set; }

        // required
        [JsonProperty("odometer_unit")]
        public OdometerUnitFleetVehicleOdooEnum OdometerUnit { get; set; }

        [JsonProperty("transmission")]
        public TransmissionFleetVehicleOdooEnum? Transmission { get; set; }

        [JsonProperty("fuel_type")]
        public FuelTypeFleetVehicleOdooEnum? FuelType { get; set; }

        [JsonProperty("horsepower")]
        public int? Horsepower { get; set; }

        [JsonProperty("horsepower_tax")]
        public double? HorsepowerTax { get; set; }

        [JsonProperty("power")]
        public int? Power { get; set; }

        [JsonProperty("co2")]
        public double? Co2 { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("image_medium")]
        public string ImageMedium { get; set; }

        [JsonProperty("image_small")]
        public string ImageSmall { get; set; }

        [JsonProperty("contract_renewal_due_soon")]
        public bool? ContractRenewalDueSoon { get; set; }

        [JsonProperty("contract_renewal_overdue")]
        public bool? ContractRenewalOverdue { get; set; }

        [JsonProperty("contract_renewal_name")]
        public string ContractRenewalName { get; set; }

        [JsonProperty("contract_renewal_total")]
        public string ContractRenewalTotal { get; set; }

        [JsonProperty("car_value")]
        public double? CarValue { get; set; }

        [JsonProperty("residual_value")]
        public double? ResidualValue { get; set; }

        [JsonProperty("cod_auto")]
        public string CodAuto { get; set; }

        // mail.activity
        [JsonProperty("activity_ids")]
        public long[] ActivityIds { get; set; }

        [JsonProperty("activity_state")]
        public ActivityStateFleetVehicleOdooEnum? ActivityState { get; set; }

        // res.users
        [JsonProperty("activity_user_id")]
        public long? ActivityUserId { get; set; }

        // mail.activity.type
        [JsonProperty("activity_type_id")]
        public long? ActivityTypeId { get; set; }

        [JsonProperty("activity_date_deadline")]
        public DateTime? ActivityDateDeadline { get; set; }

        [JsonProperty("activity_summary")]
        public string ActivitySummary { get; set; }

        [JsonProperty("message_is_follower")]
        public bool? MessageIsFollower { get; set; }

        // mail.followers
        [JsonProperty("message_follower_ids")]
        public long[] MessageFollowerIds { get; set; }

        // res.partner
        [JsonProperty("message_partner_ids")]
        public long[] MessagePartnerIds { get; set; }

        // mail.channel
        [JsonProperty("message_channel_ids")]
        public long[] MessageChannelIds { get; set; }

        // mail.message
        [JsonProperty("message_ids")]
        public long[] MessageIds { get; set; }

        [JsonProperty("message_unread")]
        public bool? MessageUnread { get; set; }

        [JsonProperty("message_unread_counter")]
        public int? MessageUnreadCounter { get; set; }

        [JsonProperty("message_needaction")]
        public bool? MessageNeedaction { get; set; }

        [JsonProperty("message_needaction_counter")]
        public int? MessageNeedactionCounter { get; set; }

        [JsonProperty("message_has_error")]
        public bool? MessageHasError { get; set; }

        [JsonProperty("message_has_error_counter")]
        public int? MessageHasErrorCounter { get; set; }

        [JsonProperty("message_attachment_count")]
        public int? MessageAttachmentCount { get; set; }

        // ir.attachment
        [JsonProperty("message_main_attachment_id")]
        public long? MessageMainAttachmentId { get; set; }

        // mail.message
        [JsonProperty("website_message_ids")]
        public long[] WebsiteMessageIds { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        // res.users
        [JsonProperty("create_uid")]
        public long? CreateUid { get; set; }

        [JsonProperty("create_date")]
        public DateTime? CreateDate { get; set; }

        // res.users
        [JsonProperty("write_uid")]
        public long? WriteUid { get; set; }

        [JsonProperty("write_date")]
        public DateTime? WriteDate { get; set; }

        [JsonProperty("__last_update")]
        public DateTime? LastUpdate { get; set; }

        [JsonProperty("x_fleet_vehicle__fleet_diagnose_count")]
        public int? XFleetVehicleFleetDiagnoseCount { get; set; }

        [JsonProperty("x_fleet_id__fleet_diagnose_count")]
        public int? XFleetIdFleetDiagnoseCount { get; set; }

        [JsonProperty("x_fleet_id__fleet_repair_count")]
        public int? XFleetIdFleetRepairCount { get; set; }

        [JsonProperty("x_fleet_id__fleet_repair_line_count")]
        public int? XFleetIdFleetRepairLineCount { get; set; }

        [JsonProperty("x_fleet__account_invoice_count")]
        public int? XFleetAccountInvoiceCount { get; set; }

        [JsonProperty("x_vehicle_id__fleet_vehicle_revenue_count")]
        public int? XVehicleIdFleetVehicleRevenueCount { get; set; }
    }


    // Unit of the odometer
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OdometerUnitFleetVehicleOdooEnum
    {
        [EnumMember(Value = "kilometers")]
        Kilometers = 1,

        [EnumMember(Value = "miles")]
        Miles = 2,
    }


    // Transmission Used by the vehicle
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TransmissionFleetVehicleOdooEnum
    {
        [EnumMember(Value = "manual")]
        Manual = 1,

        [EnumMember(Value = "automatic")]
        Automatic = 2,
    }


    // Fuel Used by the vehicle
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FuelTypeFleetVehicleOdooEnum
    {
        [EnumMember(Value = "gasoline")]
        Gasoline = 1,

        [EnumMember(Value = "diesel")]
        Diesel = 2,

        [EnumMember(Value = "lpg")]
        LPG = 3,

        [EnumMember(Value = "electric")]
        Electric = 4,

        [EnumMember(Value = "hybrid")]
        Hybrid = 5,
    }


    // Status based on activities
    // Overdue: Due date is already passed
    // Today: Activity date is today
    // Planned: Future activities.
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ActivityStateFleetVehicleOdooEnum
    {
        [EnumMember(Value = "overdue")]
        Overdue = 1,

        [EnumMember(Value = "today")]
        Today = 2,

        [EnumMember(Value = "planned")]
        Planned = 3,
    }
}
