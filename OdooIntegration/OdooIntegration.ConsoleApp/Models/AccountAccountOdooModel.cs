using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PortaCapena.OdooJsonRpcClient.Attributes;
using PortaCapena.OdooJsonRpcClient.Converters;
using PortaCapena.OdooJsonRpcClient.Models;
using System;
using System.Runtime.Serialization;

namespace OdooIntegration.ConsoleApp.Models
{
    [OdooTableName("account.account")]
    [JsonConverter(typeof(OdooModelConverter))]
    public class AccountAccountOdooModel : IOdooModel
    {

        /// <summary>
        /// name - char  <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// currency_id - many2one - res.currency <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Forces all moves for this account to have this account currency. <br />
        /// </summary>
        [JsonProperty("currency_id")]
        public long? CurrencyId { get; set; }

        /// <summary>
        /// code - char  <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// deprecated - boolean  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("deprecated")]
        public bool? Deprecated { get; set; }

        /// <summary>
        /// user_type_id - many2one - account.account.type <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Account Type is used for information purpose, to generate country-specific legal reports, and set the rules to close a fiscal year and generate opening entries. <br />
        /// </summary>
        [JsonProperty("user_type_id")]
        public long UserTypeId { get; set; }

        /// <summary>
        /// internal_type - selection  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// Help: The 'Internal Type' is used for features available on different types of accounts: liquidity type is for cash or bank accounts, payable/receivable is for vendor/customer accounts. <br />
        /// </summary>
        [JsonProperty("internal_type")]
        public InternalTypeAccountAccountOdooEnum? InternalType { get; set; }

        /// <summary>
        /// internal_group - selection  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// Help: The 'Internal Group' is used to filter accounts based on the internal group set on the account type. <br />
        /// </summary>
        [JsonProperty("internal_group")]
        public InternalGroupAccountAccountOdooEnum? InternalGroup { get; set; }

        /// <summary>
        /// last_time_entries_checked - datetime  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// Help: Last time the invoices & payments matching was performed on this account. It is set either if there's not at least an unreconciled debit and an unreconciled credit Or if you click the "Done" button. <br />
        /// </summary>
        [JsonProperty("last_time_entries_checked")]
        public DateTime? LastTimeEntriesChecked { get; set; }

        /// <summary>
        /// reconcile - boolean  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Check this box if this account allows invoices & payments matching of journal items. <br />
        /// </summary>
        [JsonProperty("reconcile")]
        public bool? Reconcile { get; set; }

        /// <summary>
        /// tax_ids - many2many - account.tax <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("tax_ids")]
        public long[] TaxIds { get; set; }

        /// <summary>
        /// note - text  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("note")]
        public string Note { get; set; }

        /// <summary>
        /// company_id - many2one - res.company <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("company_id")]
        public long CompanyId { get; set; }

        /// <summary>
        /// tag_ids - many2many - account.account.tag <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// Help: Optional tags you may want to assign for custom reporting <br />
        /// </summary>
        [JsonProperty("tag_ids")]
        public long[] TagIds { get; set; }

        /// <summary>
        /// group_id - many2one - account.group <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("group_id")]
        public long? GroupId { get; set; }

        /// <summary>
        /// opening_debit - monetary  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// Help: Opening debit value for this account. <br />
        /// </summary>
        [JsonProperty("opening_debit")]
        public decimal? OpeningDebit { get; set; }

        /// <summary>
        /// opening_credit - monetary  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// Help: Opening credit value for this account. <br />
        /// </summary>
        [JsonProperty("opening_credit")]
        public decimal? OpeningCredit { get; set; }

        /// <summary>
        /// currency_revaluation - boolean  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("currency_revaluation")]
        public bool? CurrencyRevaluation { get; set; }

        /// <summary>
        /// id - integer  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// display_name - char  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// create_uid - many2one - res.users <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("create_uid")]
        public long? CreateUid { get; set; }

        /// <summary>
        /// create_date - datetime  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("create_date")]
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// write_uid - many2one - res.users <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("write_uid")]
        public long? WriteUid { get; set; }

        /// <summary>
        /// write_date - datetime  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("write_date")]
        public DateTime? WriteDate { get; set; }

        /// <summary>
        /// __last_update - datetime  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("__last_update")]
        public DateTime? LastUpdate { get; set; }
    }


    /// <summary>
    /// Help: The 'Internal Type' is used for features available on different types of accounts: liquidity type is for cash or bank accounts, payable/receivable is for vendor/customer accounts.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum InternalTypeAccountAccountOdooEnum
    {
        [EnumMember(Value = "other")]
        Regular = 1,

        [EnumMember(Value = "receivable")]
        Receivable = 2,

        [EnumMember(Value = "payable")]
        Payable = 3,

        [EnumMember(Value = "liquidity")]
        Liquidity = 4,
    }


    /// <summary>
    /// Help: The 'Internal Group' is used to filter accounts based on the internal group set on the account type.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum InternalGroupAccountAccountOdooEnum
    {
        [EnumMember(Value = "equity")]
        Equity = 1,

        [EnumMember(Value = "asset")]
        Asset = 2,

        [EnumMember(Value = "liability")]
        Liability = 3,

        [EnumMember(Value = "income")]
        Income = 4,

        [EnumMember(Value = "expense")]
        Expense = 5,
    }
}
