using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PortaCapena.OdooJsonRpcClient.Attributes;
using PortaCapena.OdooJsonRpcClient.Converters;
using PortaCapena.OdooJsonRpcClient.Models;
using System;
using System.Runtime.Serialization;

namespace OdooIntegration.ConsoleApp.Models
{
    [OdooTableName("crm.team")]
    [JsonConverter(typeof(OdooModelConverter))]
    public class CrmTeamOdooModel : IOdooModel
    {

        /// <summary>
        /// name - char  <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// active - boolean  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: If the active field is set to false, it will allow you to hide the Sales Team without removing it. <br />
        /// </summary>
        [JsonProperty("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// company_id - many2one - res.company <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("company_id")]
        public long? CompanyId { get; set; }

        /// <summary>
        /// currency_id - many2one - res.currency <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("currency_id")]
        public long? CurrencyId { get; set; }

        /// <summary>
        /// user_id - many2one - res.users <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("user_id")]
        public long? UserId { get; set; }

        /// <summary>
        /// member_ids - one2many - res.users (sale_team_id) <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("member_ids")]
        public long[] MemberIds { get; set; }

        /// <summary>
        /// favorite_user_ids - many2many - res.users <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("favorite_user_ids")]
        public long[] FavoriteUserIds { get; set; }

        /// <summary>
        /// is_favorite - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// Help: Favorite teams to display them in the dashboard and access them easily. <br />
        /// </summary>
        [JsonProperty("is_favorite")]
        public bool? IsFavorite { get; set; }

        /// <summary>
        /// reply_to - char  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: The email address put in the 'Reply-To' of all emails sent by Odoo about cases in this Sales Team <br />
        /// </summary>
        [JsonProperty("reply_to")]
        public string ReplyTo { get; set; }

        /// <summary>
        /// color - integer  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: The color of the channel <br />
        /// </summary>
        [JsonProperty("color")]
        public int? Color { get; set; }

        /// <summary>
        /// team_type - selection  <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// Help: The type of this channel, it will define the resources this channel uses. <br />
        /// </summary>
        [JsonProperty("team_type")]
        public TeamTypeCrmTeamOdooEnum TeamType { get; set; }

        /// <summary>
        /// dashboard_button_name - char  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("dashboard_button_name")]
        public string DashboardButtonName { get; set; }

        /// <summary>
        /// dashboard_graph_data - text  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("dashboard_graph_data")]
        public string DashboardGraphData { get; set; }

        /// <summary>
        /// dashboard_graph_type - selection  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: The type of graph this channel will display in the dashboard. <br />
        /// </summary>
        [JsonProperty("dashboard_graph_type")]
        public TypeCrmTeamOdooEnum? DashboardGraphType { get; set; }

        /// <summary>
        /// dashboard_graph_group - selection  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: How this channel's dashboard graph will group the results. <br />
        /// </summary>
        [JsonProperty("dashboard_graph_group")]
        public GroupByCrmTeamOdooEnum? DashboardGraphGroup { get; set; }

        /// <summary>
        /// dashboard_graph_period - selection  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: The time period this channel's dashboard graph will consider. <br />
        /// </summary>
        [JsonProperty("dashboard_graph_period")]
        public ScaleCrmTeamOdooEnum? DashboardGraphPeriod { get; set; }

        /// <summary>
        /// use_leads - boolean  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Check this box to filter and qualify incoming requests as leads before converting them into opportunities and assigning them to a salesperson. <br />
        /// </summary>
        [JsonProperty("use_leads")]
        public bool? UseLeads { get; set; }

        /// <summary>
        /// use_opportunities - boolean  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Check this box to manage a presales process with opportunities. <br />
        /// </summary>
        [JsonProperty("use_opportunities")]
        public bool? UseOpportunities { get; set; }

        /// <summary>
        /// alias_id - many2one - mail.alias <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// Help: The email address associated with this channel. New emails received will automatically create new leads assigned to the channel. <br />
        /// </summary>
        [JsonProperty("alias_id")]
        public long AliasId { get; set; }

        /// <summary>
        /// unassigned_leads_count - integer  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("unassigned_leads_count")]
        public int? UnassignedLeadsCount { get; set; }

        /// <summary>
        /// opportunities_count - integer  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("opportunities_count")]
        public int? OpportunitiesCount { get; set; }

        /// <summary>
        /// opportunities_amount - integer  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("opportunities_amount")]
        public int? OpportunitiesAmount { get; set; }

        /// <summary>
        /// dashboard_graph_period_pipeline - selection  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// Help: The time period this channel's dashboard graph will consider. <br />
        /// </summary>
        [JsonProperty("dashboard_graph_period_pipeline")]
        public ExpectedToCloseCrmTeamOdooEnum? DashboardGraphPeriodPipeline { get; set; }

        /// <summary>
        /// dashboard_graph_group_pipeline - selection  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: How this channel's dashboard graph will group the results. <br />
        /// </summary>
        [JsonProperty("dashboard_graph_group_pipeline")]
        public GroupingMethodCrmTeamOdooEnum? DashboardGraphGroupPipeline { get; set; }

        /// <summary>
        /// use_quotations - boolean  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Check this box if you send quotations to your customers rather than confirming orders straight away. This will add specific action buttons to your dashboard. <br />
        /// </summary>
        [JsonProperty("use_quotations")]
        public bool? UseQuotations { get; set; }

        /// <summary>
        /// use_invoices - boolean  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Check this box to set an invoicing target for this Sales Team. <br />
        /// </summary>
        [JsonProperty("use_invoices")]
        public bool? UseInvoices { get; set; }

        /// <summary>
        /// invoiced - integer  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: Invoice revenue for the current month. This is the amount the sales channel has invoiced this month. It is used to compute the progression ratio of the current and target revenue on the kanban view. <br />
        /// </summary>
        [JsonProperty("invoiced")]
        public int? Invoiced { get; set; }

        /// <summary>
        /// invoiced_target - integer  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Target of invoice revenue for the current month. This is the amount the sales channel estimates to be able to invoice this month. <br />
        /// </summary>
        [JsonProperty("invoiced_target")]
        public int? InvoicedTarget { get; set; }

        /// <summary>
        /// quotations_count - integer  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("quotations_count")]
        public int? QuotationsCount { get; set; }

        /// <summary>
        /// quotations_amount - integer  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("quotations_amount")]
        public int? QuotationsAmount { get; set; }

        /// <summary>
        /// sales_to_invoice_count - integer  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("sales_to_invoice_count")]
        public int? SalesToInvoiceCount { get; set; }

        /// <summary>
        /// dashboard_graph_model - selection  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: The graph this channel will display in the Dashboard.;  <br />
        /// </summary>
        [JsonProperty("dashboard_graph_model")]
        public ContentCrmTeamOdooEnum? DashboardGraphModel { get; set; }

        /// <summary>
        /// message_is_follower - boolean  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("message_is_follower")]
        public bool? MessageIsFollower { get; set; }

        /// <summary>
        /// message_follower_ids - one2many - mail.followers (res_id) <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("message_follower_ids")]
        public long[] MessageFollowerIds { get; set; }

        /// <summary>
        /// message_partner_ids - many2many - res.partner <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("message_partner_ids")]
        public long[] MessagePartnerIds { get; set; }

        /// <summary>
        /// message_channel_ids - many2many - mail.channel <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("message_channel_ids")]
        public long[] MessageChannelIds { get; set; }

        /// <summary>
        /// message_ids - one2many - mail.message (res_id) <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("message_ids")]
        public long[] MessageIds { get; set; }

        /// <summary>
        /// message_unread - boolean  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: If checked new messages require your attention. <br />
        /// </summary>
        [JsonProperty("message_unread")]
        public bool? MessageUnread { get; set; }

        /// <summary>
        /// message_unread_counter - integer  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: Number of unread messages <br />
        /// </summary>
        [JsonProperty("message_unread_counter")]
        public int? MessageUnreadCounter { get; set; }

        /// <summary>
        /// message_needaction - boolean  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: If checked, new messages require your attention. <br />
        /// </summary>
        [JsonProperty("message_needaction")]
        public bool? MessageNeedaction { get; set; }

        /// <summary>
        /// message_needaction_counter - integer  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: Number of messages which requires an action <br />
        /// </summary>
        [JsonProperty("message_needaction_counter")]
        public int? MessageNeedactionCounter { get; set; }

        /// <summary>
        /// message_has_error - boolean  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: If checked, some messages have a delivery error. <br />
        /// </summary>
        [JsonProperty("message_has_error")]
        public bool? MessageHasError { get; set; }

        /// <summary>
        /// message_has_error_counter - integer  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: Number of messages with delivery error <br />
        /// </summary>
        [JsonProperty("message_has_error_counter")]
        public int? MessageHasErrorCounter { get; set; }

        /// <summary>
        /// message_attachment_count - integer  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("message_attachment_count")]
        public int? MessageAttachmentCount { get; set; }

        /// <summary>
        /// message_main_attachment_id - many2one - ir.attachment <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("message_main_attachment_id")]
        public long? MessageMainAttachmentId { get; set; }

        /// <summary>
        /// website_message_ids - one2many - mail.message (res_id) <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// Help: Website communication history <br />
        /// </summary>
        [JsonProperty("website_message_ids")]
        public long[] WebsiteMessageIds { get; set; }

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

        /// <summary>
        /// alias_name - char  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// Help: The name of the email alias, e.g. 'jobs' if you want to catch emails for <jobs@example.odoo.com> <br />
        /// </summary>
        [JsonProperty("alias_name")]
        public string AliasName { get; set; }

        /// <summary>
        /// alias_model_id - many2one - ir.model <br />
        /// Required: True, Readonly: False, Store: False, Sortable: True <br />
        /// Help: The model (Odoo Document Kind) to which this alias corresponds. Any incoming email that does not reply to an existing record will cause the creation of a new record of this model (e.g. a Project Task) <br />
        /// </summary>
        [JsonProperty("alias_model_id")]
        public long AliasModelId { get; set; }

        /// <summary>
        /// alias_user_id - many2one - res.users <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// Help: The owner of records created upon receiving emails on this alias. If this field is not set the system will attempt to find the right owner based on the sender (From) address, or will use the Administrator account if no system user is found for that address. <br />
        /// </summary>
        [JsonProperty("alias_user_id")]
        public long? AliasUserId { get; set; }

        /// <summary>
        /// alias_defaults - text  <br />
        /// Required: True, Readonly: False, Store: False, Sortable: True <br />
        /// Help: A Python dictionary that will be evaluated to provide default values when creating new records for this alias. <br />
        /// </summary>
        [JsonProperty("alias_defaults")]
        public string AliasDefaults { get; set; }

        /// <summary>
        /// alias_force_thread_id - integer  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// Help: Optional ID of a thread (record) to which all incoming messages will be attached, even if they did not reply to it. If set, this will disable the creation of new records completely. <br />
        /// </summary>
        [JsonProperty("alias_force_thread_id")]
        public int? AliasForceThreadId { get; set; }

        /// <summary>
        /// alias_domain - char  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("alias_domain")]
        public string AliasDomain { get; set; }

        /// <summary>
        /// alias_parent_model_id - many2one - ir.model <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// Help: Parent model holding the alias. The model holding the alias reference is not necessarily the model given by alias_model_id (example: project (parent_model) and task (model)) <br />
        /// </summary>
        [JsonProperty("alias_parent_model_id")]
        public long? AliasParentModelId { get; set; }

        /// <summary>
        /// alias_parent_thread_id - integer  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// Help: ID of the parent record holding the alias (example: project holding the task creation alias) <br />
        /// </summary>
        [JsonProperty("alias_parent_thread_id")]
        public int? AliasParentThreadId { get; set; }

        /// <summary>
        /// alias_contact - selection  <br />
        /// Required: True, Readonly: False, Store: False, Sortable: True <br />
        /// Help: Policy to post a message on the document using the mailgateway.; - everyone: everyone can post; - partners: only authenticated partners; - followers: only followers of the related document or members of following channels;  <br />
        /// </summary>
        [JsonProperty("alias_contact")]
        public AliasContactSecurityCrmTeamOdooEnum AliasContact { get; set; }
    }


    /// <summary>
    /// Help: The type of this channel, it will define the resources this channel uses.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TeamTypeCrmTeamOdooEnum
    {
        [EnumMember(Value = "sales")]
        Sales = 1,

        [EnumMember(Value = "website")]
        Website = 2,
    }


    /// <summary>
    /// Help: The type of graph this channel will display in the dashboard.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TypeCrmTeamOdooEnum
    {
        [EnumMember(Value = "line")]
        Line = 1,

        [EnumMember(Value = "bar")]
        Bar = 2,
    }


    /// <summary>
    /// Help: How this channel's dashboard graph will group the results.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum GroupByCrmTeamOdooEnum
    {
        [EnumMember(Value = "day")]
        Day = 1,

        [EnumMember(Value = "week")]
        Week = 2,

        [EnumMember(Value = "month")]
        Month = 3,

        [EnumMember(Value = "user")]
        Salesperson = 4,
    }


    /// <summary>
    /// Help: The time period this channel's dashboard graph will consider.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ScaleCrmTeamOdooEnum
    {
        [EnumMember(Value = "week")]
        LastWeek = 1,

        [EnumMember(Value = "month")]
        LastMonth = 2,

        [EnumMember(Value = "year")]
        LastYear = 3,
    }


    /// <summary>
    /// Help: The time period this channel's dashboard graph will consider.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ExpectedToCloseCrmTeamOdooEnum
    {
        [EnumMember(Value = "week")]
        WithinAWeek = 1,

        [EnumMember(Value = "month")]
        WithinAMonth = 2,

        [EnumMember(Value = "year")]
        WithinAYear = 3,
    }


    /// <summary>
    /// Help: How this channel's dashboard graph will group the results.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum GroupingMethodCrmTeamOdooEnum
    {
        [EnumMember(Value = "day")]
        ExpectedClosingDay = 1,

        [EnumMember(Value = "week")]
        ExpectedClosingWeek = 2,

        [EnumMember(Value = "month")]
        ExpectedClosingMonth = 3,

        [EnumMember(Value = "user")]
        Salesperson = 4,

        [EnumMember(Value = "stage")]
        Stage = 5,
    }


    /// <summary>
    /// Help: The graph this channel will display in the Dashboard. <br />
    ///
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ContentCrmTeamOdooEnum
    {
        [EnumMember(Value = "crm.lead")]
        Pipeline = 1,

        [EnumMember(Value = "sale.report")]
        Sales = 2,

        [EnumMember(Value = "account.invoice.report")]
        Invoices = 3,
    }


    /// <summary>
    /// Help: Policy to post a message on the document using the mailgateway. <br />
    /// - everyone: everyone can post <br />
    /// - partners: only authenticated partners <br />
    /// - followers: only followers of the related document or members of following channels <br />
    ///
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AliasContactSecurityCrmTeamOdooEnum
    {
        [EnumMember(Value = "everyone")]
        Everyone = 1,

        [EnumMember(Value = "partners")]
        AuthenticatedPartners = 2,

        [EnumMember(Value = "followers")]
        FollowersOnly = 3,

        [EnumMember(Value = "employees")]
        AuthenticatedEmployees = 4,
    }
}
