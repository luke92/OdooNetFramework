using Newtonsoft.Json;

namespace OdooIntegration.ConsoleApp.Helpers
{
    public class InvoiceLineTaxIdsModel
    {
        [JsonProperty("invoice_line_tax_ids")]
        public InvoiceLineTaxId[][] InvoiceLineTaxIds { get; set; }
    }

    public struct InvoiceLineTaxId
    {
        public bool? Bool;
        public long? Integer;
        public long[] IntegerArray;

        public static implicit operator InvoiceLineTaxId(bool Bool) => new InvoiceLineTaxId { Bool = Bool };
        public static implicit operator InvoiceLineTaxId(long Integer) => new InvoiceLineTaxId { Integer = Integer };
        public static implicit operator InvoiceLineTaxId(long[] IntegerArray) => new InvoiceLineTaxId { IntegerArray = IntegerArray };
    }

    public struct InvoiceLineTaxIdsModelElement
    {
        public long[] IntegerArray;
        public InvoiceLineTaxIdsModel InvoiceLineTaxIdsModelClass;

        public static implicit operator InvoiceLineTaxIdsModelElement(long[] IntegerArray) => new InvoiceLineTaxIdsModelElement { IntegerArray = IntegerArray };
        public static implicit operator InvoiceLineTaxIdsModelElement(InvoiceLineTaxIdsModel InvoiceLineTaxIdsModelClass) => new InvoiceLineTaxIdsModelElement { InvoiceLineTaxIdsModelClass = InvoiceLineTaxIdsModelClass };
    }
}
