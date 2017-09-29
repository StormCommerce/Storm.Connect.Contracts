using System.Collections.Generic;
using System.Runtime.Serialization;
using Enferno.Services.StormConnect.Contracts.Product.Fields;
using Enferno.Services.StormConnect.Contracts.Supplier.Fields;

namespace Enferno.Services.StormConnect.Contracts.Supplier
{
    [DataContract(Name = "ProductHeader", Namespace = "Enferno.Services.StormConnect.Contracts.Supplier")]
    public class SupplierProductHeader : Header
    {
        public SupplierProductHeader()
        {
            FieldsThatAreSet = new List<SupplierProductField>();
            OnhandFieldsThatAreSet = new List<SupplierOnHandField>();
            PriceFieldsThatAreSet = new List<SupplierPriceField>();
            ContentFieldsThatAreSet = new List<ProductCultureField>();
            ProductInfoFieldsThatAreSet = new List<SupplierProductInfoField>();
        }

        [DataMember(Order = 1)]
        public List<SupplierProductField> FieldsThatAreSet { get; set; }
        [DataMember(Order = 2)]
        public List<SupplierOnHandField> OnhandFieldsThatAreSet { get; set; }
        [DataMember(Order = 3)]
        public List<SupplierPriceField> PriceFieldsThatAreSet { get; set; }
        [DataMember(Order = 4)]
        public List<ProductCultureField> ContentFieldsThatAreSet { get; set; }
        [DataMember(Order = 5)]
        public List<SupplierProductInfoField> ProductInfoFieldsThatAreSet { get; set; }

        [DataMember(Order = 6)]
        public bool FullFile { get; set; }
        
        public bool IsFieldSet(SupplierProductField field)
        {
            return FieldsThatAreSet.Contains(field);
        }

        public bool IsFieldSet(SupplierOnHandField value)
        {
            return OnhandFieldsThatAreSet.Contains(value);
        }

        public bool IsFieldSet(SupplierPriceField value)
        {
            return PriceFieldsThatAreSet.Contains(value);
        }

        public bool IsFieldSet(ProductCultureField value)
        {
            return ContentFieldsThatAreSet.Contains(value);
        }

        public bool IsFieldSet(SupplierProductInfoField value)
        {
            return ProductInfoFieldsThatAreSet.Contains(value);
        }

        public void AddProductField(params SupplierProductField[] fields)
        {
            FieldsThatAreSet.AddRange(fields);
        }

        public void AddOnHandField(params SupplierOnHandField[] fields)
        {
            OnhandFieldsThatAreSet.AddRange(fields);
        }

        public void AddPriceField(params SupplierPriceField[] fields)
        {
            PriceFieldsThatAreSet.AddRange(fields);
        }

        public void AddContentField(params ProductCultureField[] fields)
        {
            ContentFieldsThatAreSet.AddRange(fields);
        }

        public void AddContentField(params SupplierProductInfoField[] fields)
        {
            ProductInfoFieldsThatAreSet.AddRange(fields);
        }
    }
}