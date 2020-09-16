using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xml_manipulation
{
    public partial class RateResults : IRateResults
    {

        private byte statusCodeField;

        private string statusMessageField;

        private RateResultsPriceSheet[] priceSheetsField;

        /// <remarks/>
        public byte StatusCode
        {
            get
            {
                return this.statusCodeField;
            }
            set
            {
                this.statusCodeField = value;
            }
        }

        /// <remarks/>
        public string StatusMessage
        {
            get
            {
                return this.statusMessageField;
            }
            set
            {
                this.statusMessageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("PriceSheet", IsNullable = false)]
        public RateResultsPriceSheet[] PriceSheets
        {
            get
            {
                return this.priceSheetsField;
            }
            set
            {
                this.priceSheetsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RateResultsPriceSheet : IRateResultsPriceSheet
    {

        private decimal accessorialTotalField;

        private decimal subTotalField;

        private decimal totalField;

        private string contractIdField;

        private string contractNameField;

        private string carrierIdField;

        private string carrierNameField;

        private string sCACField;

        private string modeField;

        private string serviceField;

        private decimal serviceDaysField;

        private ushort distanceField;

        private string idField;

        private RateResultsPriceSheetInsurance[] insuranceTypesField;

        private RateResultsPriceSheetAddress addressField;

        private string expectedDeliveryDateField;

        private object reasonCodeField;

        private object statusField;

        private string laneIDField;

        private string zoneField;

        private object routeGuidePriorityField;

        private object carrierLocationOidField;

        private string originServiceField;

        private string destinationServiceField;

        private RateResultsPriceSheetCharge[] chargesField;

        private object commentsField;

        private RateResultsPriceSheetAssociatedCarrierPricesheet associatedCarrierPricesheetField;

        private string typeField;

        private string chargeModelField;

        private bool isSelectedField;

        private bool isAllocatedField;

        private string currencyCodeField;

        private string createDateField;

        private string internalIdField;

        /// <remarks/>
        public decimal AccessorialTotal
        {
            get
            {
                return this.accessorialTotalField;
            }
            set
            {
                this.accessorialTotalField = value;
            }
        }

        /// <remarks/>
        public decimal SubTotal
        {
            get
            {
                return this.subTotalField;
            }
            set
            {
                this.subTotalField = value;
            }
        }

        /// <remarks/>
        public decimal Total
        {
            get
            {
                return this.totalField;
            }
            set
            {
                this.totalField = value;
            }
        }

        /// <remarks/>
        public string ContractId
        {
            get
            {
                return this.contractIdField;
            }
            set
            {
                this.contractIdField = value;
            }
        }

        /// <remarks/>
        public string ContractName
        {
            get
            {
                return this.contractNameField;
            }
            set
            {
                this.contractNameField = value;
            }
        }

        /// <remarks/>
        public string CarrierId
        {
            get
            {
                return this.carrierIdField;
            }
            set
            {
                this.carrierIdField = value;
            }
        }

        /// <remarks/>
        public string CarrierName
        {
            get
            {
                return this.carrierNameField;
            }
            set
            {
                this.carrierNameField = value;
            }
        }

        /// <remarks/>
        public string SCAC
        {
            get
            {
                return this.sCACField;
            }
            set
            {
                this.sCACField = value;
            }
        }

        /// <remarks/>
        public string Mode
        {
            get
            {
                return this.modeField;
            }
            set
            {
                this.modeField = value;
            }
        }

        /// <remarks/>
        public string Service
        {
            get
            {
                return this.serviceField;
            }
            set
            {
                this.serviceField = value;
            }
        }

        /// <remarks/>
        public decimal ServiceDays
        {
            get
            {
                return this.serviceDaysField;
            }
            set
            {
                this.serviceDaysField = value;
            }
        }

        /// <remarks/>
        public ushort Distance
        {
            get
            {
                return this.distanceField;
            }
            set
            {
                this.distanceField = value;
            }
        }

        /// <remarks/>
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Insurance", IsNullable = false)]
        public RateResultsPriceSheetInsurance[] InsuranceTypes
        {
            get
            {
                return this.insuranceTypesField;
            }
            set
            {
                this.insuranceTypesField = value;
            }
        }

        /// <remarks/>
        public RateResultsPriceSheetAddress Address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }

        /// <remarks/>
        public string ExpectedDeliveryDate
        {
            get
            {
                return this.expectedDeliveryDateField;
            }
            set
            {
                this.expectedDeliveryDateField = value;
            }
        }

        /// <remarks/>
        public object ReasonCode
        {
            get
            {
                return this.reasonCodeField;
            }
            set
            {
                this.reasonCodeField = value;
            }
        }

        /// <remarks/>
        public object Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }

        /// <remarks/>
        public string LaneID
        {
            get
            {
                return this.laneIDField;
            }
            set
            {
                this.laneIDField = value;
            }
        }

        /// <remarks/>
        public string Zone
        {
            get
            {
                return this.zoneField;
            }
            set
            {
                this.zoneField = value;
            }
        }

        /// <remarks/>
        public object RouteGuidePriority
        {
            get
            {
                return this.routeGuidePriorityField;
            }
            set
            {
                this.routeGuidePriorityField = value;
            }
        }

        /// <remarks/>
        public object CarrierLocationOid
        {
            get
            {
                return this.carrierLocationOidField;
            }
            set
            {
                this.carrierLocationOidField = value;
            }
        }

        /// <remarks/>
        public string OriginService
        {
            get
            {
                return this.originServiceField;
            }
            set
            {
                this.originServiceField = value;
            }
        }

        /// <remarks/>
        public string DestinationService
        {
            get
            {
                return this.destinationServiceField;
            }
            set
            {
                this.destinationServiceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Charge", IsNullable = false)]
        public RateResultsPriceSheetCharge[] Charges
        {
            get
            {
                return this.chargesField;
            }
            set
            {
                this.chargesField = value;
            }
        }

        /// <remarks/>
        public object Comments
        {
            get
            {
                return this.commentsField;
            }
            set
            {
                this.commentsField = value;
            }
        }

        /// <remarks/>
        public RateResultsPriceSheetAssociatedCarrierPricesheet AssociatedCarrierPricesheet
        {
            get
            {
                return this.associatedCarrierPricesheetField;
            }
            set
            {
                this.associatedCarrierPricesheetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string chargeModel
        {
            get
            {
                return this.chargeModelField;
            }
            set
            {
                this.chargeModelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool isSelected
        {
            get
            {
                return this.isSelectedField;
            }
            set
            {
                this.isSelectedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool isAllocated
        {
            get
            {
                return this.isAllocatedField;
            }
            set
            {
                this.isAllocatedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string currencyCode
        {
            get
            {
                return this.currencyCodeField;
            }
            set
            {
                this.currencyCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string createDate
        {
            get
            {
                return this.createDateField;
            }
            set
            {
                this.createDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string internalId
        {
            get
            {
                return this.internalIdField;
            }
            set
            {
                this.internalIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RateResultsPriceSheetInsurance
    {

        private string typeField;

        private decimal amountField;

        private string companyField;

        private string expirationDateField;

        private string contactNameField;

        private string contactPhoneField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string company
        {
            get
            {
                return this.companyField;
            }
            set
            {
                this.companyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string expirationDate
        {
            get
            {
                return this.expirationDateField;
            }
            set
            {
                this.expirationDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string contactName
        {
            get
            {
                return this.contactNameField;
            }
            set
            {
                this.contactNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string contactPhone
        {
            get
            {
                return this.contactPhoneField;
            }
            set
            {
                this.contactPhoneField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RateResultsPriceSheetAddress
    {

        private string locationCodeField;

        private string aliasField;

        private string nameField;

        private string addrLine1Field;

        private object addrLine2Field;

        private string cityField;

        private string stateProvinceField;

        private string postalCodeField;

        private string countryCodeField;

        private RateResultsPriceSheetAddressGeoLoc geoLocField;

        private RateResultsPriceSheetAddressContact[] contactsField;

        private object commentsField;

        private string typeField;

        private bool isResidentialField;

        private bool isPrimaryField;

        /// <remarks/>
        public string LocationCode
        {
            get
            {
                return this.locationCodeField;
            }
            set
            {
                this.locationCodeField = value;
            }
        }

        /// <remarks/>
        public string Alias
        {
            get
            {
                return this.aliasField;
            }
            set
            {
                this.aliasField = value;
            }
        }

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string AddrLine1
        {
            get
            {
                return this.addrLine1Field;
            }
            set
            {
                this.addrLine1Field = value;
            }
        }

        /// <remarks/>
        public object AddrLine2
        {
            get
            {
                return this.addrLine2Field;
            }
            set
            {
                this.addrLine2Field = value;
            }
        }

        /// <remarks/>
        public string City
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
            }
        }

        /// <remarks/>
        public string StateProvince
        {
            get
            {
                return this.stateProvinceField;
            }
            set
            {
                this.stateProvinceField = value;
            }
        }

        /// <remarks/>
        public string PostalCode
        {
            get
            {
                return this.postalCodeField;
            }
            set
            {
                this.postalCodeField = value;
            }
        }

        /// <remarks/>
        public string CountryCode
        {
            get
            {
                return this.countryCodeField;
            }
            set
            {
                this.countryCodeField = value;
            }
        }

        /// <remarks/>
        public RateResultsPriceSheetAddressGeoLoc GeoLoc
        {
            get
            {
                return this.geoLocField;
            }
            set
            {
                this.geoLocField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Contact", IsNullable = false)]
        public RateResultsPriceSheetAddressContact[] Contacts
        {
            get
            {
                return this.contactsField;
            }
            set
            {
                this.contactsField = value;
            }
        }

        /// <remarks/>
        public object Comments
        {
            get
            {
                return this.commentsField;
            }
            set
            {
                this.commentsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool isResidential
        {
            get
            {
                return this.isResidentialField;
            }
            set
            {
                this.isResidentialField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool isPrimary
        {
            get
            {
                return this.isPrimaryField;
            }
            set
            {
                this.isPrimaryField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RateResultsPriceSheetAddressGeoLoc
    {

        private uint latDegreesField;

        private string latDirectionField;

        private uint longDegreesField;

        private string longDirectionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint latDegrees
        {
            get
            {
                return this.latDegreesField;
            }
            set
            {
                this.latDegreesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string latDirection
        {
            get
            {
                return this.latDirectionField;
            }
            set
            {
                this.latDirectionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint longDegrees
        {
            get
            {
                return this.longDegreesField;
            }
            set
            {
                this.longDegreesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string longDirection
        {
            get
            {
                return this.longDirectionField;
            }
            set
            {
                this.longDirectionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RateResultsPriceSheetAddressContact
    {

        private string nameField;

        private RateResultsPriceSheetAddressContactContactMethod[] contactMethodsField;

        private string typeField;

        private ulong oidField;

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ContactMethod", IsNullable = false)]
        public RateResultsPriceSheetAddressContactContactMethod[] ContactMethods
        {
            get
            {
                return this.contactMethodsField;
            }
            set
            {
                this.contactMethodsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong oid
        {
            get
            {
                return this.oidField;
            }
            set
            {
                this.oidField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RateResultsPriceSheetAddressContactContactMethod
    {

        private byte sequenceNumField;

        private string typeField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte sequenceNum
        {
            get
            {
                return this.sequenceNumField;
            }
            set
            {
                this.sequenceNumField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RateResultsPriceSheetCharge
    {

        private string descriptionField;

        private string ediCodeField;

        private decimal amountField;

        private decimal rateField;

        private string rateQualifierField;

        private string quantityField;

        private decimal weightField;

        private decimal dimWeightField;

        private decimal freightClassField;

        private decimal fakFreightClassField;

        private bool isMinField;

        private bool isMaxField;

        private bool isNontaxableField;

        private byte sequenceNumField;

        private string typeField;

        private string itemGroupIdField;

        /// <remarks/>
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public string EdiCode
        {
            get
            {
                return this.ediCodeField;
            }
            set
            {
                this.ediCodeField = value;
            }
        }

        /// <remarks/>
        public decimal Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        public decimal Rate
        {
            get
            {
                return this.rateField;
            }
            set
            {
                this.rateField = value;
            }
        }

        /// <remarks/>
        public string RateQualifier
        {
            get
            {
                return this.rateQualifierField;
            }
            set
            {
                this.rateQualifierField = value;
            }
        }

        /// <remarks/>
        public string Quantity
        {
            get
            {
                return this.quantityField;
            }
            set
            {
                this.quantityField = value;
            }
        }

        /// <remarks/>
        public decimal Weight
        {
            get
            {
                return this.weightField;
            }
            set
            {
                this.weightField = value;
            }
        }

        /// <remarks/>
        public decimal DimWeight
        {
            get
            {
                return this.dimWeightField;
            }
            set
            {
                this.dimWeightField = value;
            }
        }

        /// <remarks/>
        public decimal FreightClass
        {
            get
            {
                return this.freightClassField;
            }
            set
            {
                this.freightClassField = value;
            }
        }

        /// <remarks/>
        public decimal FakFreightClass
        {
            get
            {
                return this.fakFreightClassField;
            }
            set
            {
                this.fakFreightClassField = value;
            }
        }

        /// <remarks/>
        public bool IsMin
        {
            get
            {
                return this.isMinField;
            }
            set
            {
                this.isMinField = value;
            }
        }

        /// <remarks/>
        public bool IsMax
        {
            get
            {
                return this.isMaxField;
            }
            set
            {
                this.isMaxField = value;
            }
        }

        /// <remarks/>
        public bool IsNontaxable
        {
            get
            {
                return this.isNontaxableField;
            }
            set
            {
                this.isNontaxableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte sequenceNum
        {
            get
            {
                return this.sequenceNumField;
            }
            set
            {
                this.sequenceNumField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string itemGroupId
        {
            get
            {
                return this.itemGroupIdField;
            }
            set
            {
                this.itemGroupIdField = value;
            }
        }

        public void setup_maintainance()
        {
            this.Description = "Maintanance Charge";
            this.EdiCode = null;
            this.Amount = 12;
            this.Rate = 12;
            this.RateQualifier = "FR";
            this.Weight = 0;
            this.DimWeight = 0;
            this.FreightClass = 0;
            this.FakFreightClass = 0;
            this.IsMax = false;
            this.IsMin = false;
            this.IsNontaxable = false;
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RateResultsPriceSheetAssociatedCarrierPricesheet
    {

        private RateResultsPriceSheetAssociatedCarrierPricesheetPriceSheet priceSheetField;

        /// <remarks/>
        public RateResultsPriceSheetAssociatedCarrierPricesheetPriceSheet PriceSheet
        {
            get
            {
                return this.priceSheetField;
            }
            set
            {
                this.priceSheetField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RateResultsPriceSheetAssociatedCarrierPricesheetPriceSheet
    {

        private decimal accessorialTotalField;

        private decimal subTotalField;

        private decimal totalField;

        private string contractIdField;

        private string contractNameField;

        private string carrierIdField;

        private string carrierNameField;

        private string sCACField;

        private string modeField;

        private string serviceField;

        private decimal serviceDaysField;

        private decimal distanceField;

        private string idField;

        private RateResultsPriceSheetAssociatedCarrierPricesheetPriceSheetInsurance[] insuranceTypesField;

        private RateResultsPriceSheetAssociatedCarrierPricesheetPriceSheetAddress addressField;

        private string expectedDeliveryDateField;

        private object reasonCodeField;

        private object statusField;

        private string laneIDField;

        private string zoneField;

        private object routeGuidePriorityField;

        private object carrierLocationOidField;

        private string originServiceField;

        private string destinationServiceField;

        private RateResultsPriceSheetAssociatedCarrierPricesheetPriceSheetCharge[] chargesField;

        private object commentsField;

        private string typeField;

        private string chargeModelField;

        private bool isSelectedField;

        private bool isAllocatedField;

        private string currencyCodeField;

        private string createDateField;

        private string internalIdField;

        /// <remarks/>
        public decimal AccessorialTotal
        {
            get
            {
                return this.accessorialTotalField;
            }
            set
            {
                this.accessorialTotalField = value;
            }
        }

        /// <remarks/>
        public decimal SubTotal
        {
            get
            {
                return this.subTotalField;
            }
            set
            {
                this.subTotalField = value;
            }
        }

        /// <remarks/>
        public decimal Total
        {
            get
            {
                return this.totalField;
            }
            set
            {
                this.totalField = value;
            }
        }

        /// <remarks/>
        public string ContractId
        {
            get
            {
                return this.contractIdField;
            }
            set
            {
                this.contractIdField = value;
            }
        }

        /// <remarks/>
        public string ContractName
        {
            get
            {
                return this.contractNameField;
            }
            set
            {
                this.contractNameField = value;
            }
        }

        /// <remarks/>
        public string CarrierId
        {
            get
            {
                return this.carrierIdField;
            }
            set
            {
                this.carrierIdField = value;
            }
        }

        /// <remarks/>
        public string CarrierName
        {
            get
            {
                return this.carrierNameField;
            }
            set
            {
                this.carrierNameField = value;
            }
        }

        /// <remarks/>
        public string SCAC
        {
            get
            {
                return this.sCACField;
            }
            set
            {
                this.sCACField = value;
            }
        }

        /// <remarks/>
        public string Mode
        {
            get
            {
                return this.modeField;
            }
            set
            {
                this.modeField = value;
            }
        }

        /// <remarks/>
        public string Service
        {
            get
            {
                return this.serviceField;
            }
            set
            {
                this.serviceField = value;
            }
        }

        /// <remarks/>
        public decimal ServiceDays
        {
            get
            {
                return this.serviceDaysField;
            }
            set
            {
                this.serviceDaysField = value;
            }
        }

        /// <remarks/>
        public decimal Distance
        {
            get
            {
                return this.distanceField;
            }
            set
            {
                this.distanceField = value;
            }
        }

        /// <remarks/>
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Insurance", IsNullable = false)]
        public RateResultsPriceSheetAssociatedCarrierPricesheetPriceSheetInsurance[] InsuranceTypes
        {
            get
            {
                return this.insuranceTypesField;
            }
            set
            {
                this.insuranceTypesField = value;
            }
        }

        /// <remarks/>
        public RateResultsPriceSheetAssociatedCarrierPricesheetPriceSheetAddress Address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }

        /// <remarks/>
        public string ExpectedDeliveryDate
        {
            get
            {
                return this.expectedDeliveryDateField;
            }
            set
            {
                this.expectedDeliveryDateField = value;
            }
        }

        /// <remarks/>
        public object ReasonCode
        {
            get
            {
                return this.reasonCodeField;
            }
            set
            {
                this.reasonCodeField = value;
            }
        }

        /// <remarks/>
        public object Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }

        /// <remarks/>
        public string LaneID
        {
            get
            {
                return this.laneIDField;
            }
            set
            {
                this.laneIDField = value;
            }
        }

        /// <remarks/>
        public string Zone
        {
            get
            {
                return this.zoneField;
            }
            set
            {
                this.zoneField = value;
            }
        }

        /// <remarks/>
        public object RouteGuidePriority
        {
            get
            {
                return this.routeGuidePriorityField;
            }
            set
            {
                this.routeGuidePriorityField = value;
            }
        }

        /// <remarks/>
        public object CarrierLocationOid
        {
            get
            {
                return this.carrierLocationOidField;
            }
            set
            {
                this.carrierLocationOidField = value;
            }
        }

        /// <remarks/>
        public string OriginService
        {
            get
            {
                return this.originServiceField;
            }
            set
            {
                this.originServiceField = value;
            }
        }

        /// <remarks/>
        public string DestinationService
        {
            get
            {
                return this.destinationServiceField;
            }
            set
            {
                this.destinationServiceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Charge", IsNullable = false)]
        public RateResultsPriceSheetAssociatedCarrierPricesheetPriceSheetCharge[] Charges
        {
            get
            {
                return this.chargesField;
            }
            set
            {
                this.chargesField = value;
            }
        }

        /// <remarks/>
        public object Comments
        {
            get
            {
                return this.commentsField;
            }
            set
            {
                this.commentsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string chargeModel
        {
            get
            {
                return this.chargeModelField;
            }
            set
            {
                this.chargeModelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool isSelected
        {
            get
            {
                return this.isSelectedField;
            }
            set
            {
                this.isSelectedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool isAllocated
        {
            get
            {
                return this.isAllocatedField;
            }
            set
            {
                this.isAllocatedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string currencyCode
        {
            get
            {
                return this.currencyCodeField;
            }
            set
            {
                this.currencyCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string createDate
        {
            get
            {
                return this.createDateField;
            }
            set
            {
                this.createDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string internalId
        {
            get
            {
                return this.internalIdField;
            }
            set
            {
                this.internalIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RateResultsPriceSheetAssociatedCarrierPricesheetPriceSheetInsurance
    {

        private string typeField;

        private decimal amountField;

        private string companyField;

        private string expirationDateField;

        private string contactNameField;

        private string contactPhoneField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string company
        {
            get
            {
                return this.companyField;
            }
            set
            {
                this.companyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string expirationDate
        {
            get
            {
                return this.expirationDateField;
            }
            set
            {
                this.expirationDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string contactName
        {
            get
            {
                return this.contactNameField;
            }
            set
            {
                this.contactNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string contactPhone
        {
            get
            {
                return this.contactPhoneField;
            }
            set
            {
                this.contactPhoneField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RateResultsPriceSheetAssociatedCarrierPricesheetPriceSheetAddress
    {

        private string locationCodeField;

        private string aliasField;

        private string nameField;

        private string addrLine1Field;

        private object addrLine2Field;

        private string cityField;

        private string stateProvinceField;

        private string postalCodeField;

        private string countryCodeField;

        private RateResultsPriceSheetAssociatedCarrierPricesheetPriceSheetAddressGeoLoc geoLocField;

        private RateResultsPriceSheetAssociatedCarrierPricesheetPriceSheetAddressContact[] contactsField;

        private object commentsField;

        private string typeField;

        private bool isResidentialField;

        private bool isPrimaryField;

        /// <remarks/>
        public string LocationCode
        {
            get
            {
                return this.locationCodeField;
            }
            set
            {
                this.locationCodeField = value;
            }
        }

        /// <remarks/>
        public string Alias
        {
            get
            {
                return this.aliasField;
            }
            set
            {
                this.aliasField = value;
            }
        }

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string AddrLine1
        {
            get
            {
                return this.addrLine1Field;
            }
            set
            {
                this.addrLine1Field = value;
            }
        }

        /// <remarks/>
        public object AddrLine2
        {
            get
            {
                return this.addrLine2Field;
            }
            set
            {
                this.addrLine2Field = value;
            }
        }

        /// <remarks/>
        public string City
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
            }
        }

        /// <remarks/>
        public string StateProvince
        {
            get
            {
                return this.stateProvinceField;
            }
            set
            {
                this.stateProvinceField = value;
            }
        }

        /// <remarks/>
        public string PostalCode
        {
            get
            {
                return this.postalCodeField;
            }
            set
            {
                this.postalCodeField = value;
            }
        }

        /// <remarks/>
        public string CountryCode
        {
            get
            {
                return this.countryCodeField;
            }
            set
            {
                this.countryCodeField = value;
            }
        }

        /// <remarks/>
        public RateResultsPriceSheetAssociatedCarrierPricesheetPriceSheetAddressGeoLoc GeoLoc
        {
            get
            {
                return this.geoLocField;
            }
            set
            {
                this.geoLocField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Contact", IsNullable = false)]
        public RateResultsPriceSheetAssociatedCarrierPricesheetPriceSheetAddressContact[] Contacts
        {
            get
            {
                return this.contactsField;
            }
            set
            {
                this.contactsField = value;
            }
        }

        /// <remarks/>
        public object Comments
        {
            get
            {
                return this.commentsField;
            }
            set
            {
                this.commentsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool isResidential
        {
            get
            {
                return this.isResidentialField;
            }
            set
            {
                this.isResidentialField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool isPrimary
        {
            get
            {
                return this.isPrimaryField;
            }
            set
            {
                this.isPrimaryField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RateResultsPriceSheetAssociatedCarrierPricesheetPriceSheetAddressGeoLoc
    {

        private uint latDegreesField;

        private string latDirectionField;

        private uint longDegreesField;

        private string longDirectionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint latDegrees
        {
            get
            {
                return this.latDegreesField;
            }
            set
            {
                this.latDegreesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string latDirection
        {
            get
            {
                return this.latDirectionField;
            }
            set
            {
                this.latDirectionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint longDegrees
        {
            get
            {
                return this.longDegreesField;
            }
            set
            {
                this.longDegreesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string longDirection
        {
            get
            {
                return this.longDirectionField;
            }
            set
            {
                this.longDirectionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RateResultsPriceSheetAssociatedCarrierPricesheetPriceSheetAddressContact
    {

        private string nameField;

        private RateResultsPriceSheetAssociatedCarrierPricesheetPriceSheetAddressContactContactMethod[] contactMethodsField;

        private string typeField;

        private ulong oidField;

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ContactMethod", IsNullable = false)]
        public RateResultsPriceSheetAssociatedCarrierPricesheetPriceSheetAddressContactContactMethod[] ContactMethods
        {
            get
            {
                return this.contactMethodsField;
            }
            set
            {
                this.contactMethodsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong oid
        {
            get
            {
                return this.oidField;
            }
            set
            {
                this.oidField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RateResultsPriceSheetAssociatedCarrierPricesheetPriceSheetAddressContactContactMethod
    {

        private byte sequenceNumField;

        private string typeField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte sequenceNum
        {
            get
            {
                return this.sequenceNumField;
            }
            set
            {
                this.sequenceNumField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RateResultsPriceSheetAssociatedCarrierPricesheetPriceSheetCharge
    {

        private string descriptionField;

        private string ediCodeField;

        private decimal amountField;

        private decimal rateField;

        private string rateQualifierField;

        private string quantityField;

        private decimal weightField;

        private decimal dimWeightField;

        private decimal freightClassField;

        private decimal fakFreightClassField;

        private bool isMinField;

        private bool isMaxField;

        private bool isNontaxableField;

        private byte sequenceNumField;

        private string typeField;

        private string itemGroupIdField;

        /// <remarks/>
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public string EdiCode
        {
            get
            {
                return this.ediCodeField;
            }
            set
            {
                this.ediCodeField = value;
            }
        }

        /// <remarks/>
        public decimal Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        public decimal Rate
        {
            get
            {
                return this.rateField;
            }
            set
            {
                this.rateField = value;
            }
        }

        /// <remarks/>
        public string RateQualifier
        {
            get
            {
                return this.rateQualifierField;
            }
            set
            {
                this.rateQualifierField = value;
            }
        }

        /// <remarks/>
        public string Quantity
        {
            get
            {
                return this.quantityField;
            }
            set
            {
                this.quantityField = value;
            }
        }

        /// <remarks/>
        public decimal Weight
        {
            get
            {
                return this.weightField;
            }
            set
            {
                this.weightField = value;
            }
        }

        /// <remarks/>
        public decimal DimWeight
        {
            get
            {
                return this.dimWeightField;
            }
            set
            {
                this.dimWeightField = value;
            }
        }

        /// <remarks/>
        public decimal FreightClass
        {
            get
            {
                return this.freightClassField;
            }
            set
            {
                this.freightClassField = value;
            }
        }

        /// <remarks/>
        public decimal FakFreightClass
        {
            get
            {
                return this.fakFreightClassField;
            }
            set
            {
                this.fakFreightClassField = value;
            }
        }

        /// <remarks/>
        public bool IsMin
        {
            get
            {
                return this.isMinField;
            }
            set
            {
                this.isMinField = value;
            }
        }

        /// <remarks/>
        public bool IsMax
        {
            get
            {
                return this.isMaxField;
            }
            set
            {
                this.isMaxField = value;
            }
        }

        /// <remarks/>
        public bool IsNontaxable
        {
            get
            {
                return this.isNontaxableField;
            }
            set
            {
                this.isNontaxableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte sequenceNum
        {
            get
            {
                return this.sequenceNumField;
            }
            set
            {
                this.sequenceNumField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string itemGroupId
        {
            get
            {
                return this.itemGroupIdField;
            }
            set
            {
                this.itemGroupIdField = value;
            }
        }

    }


}
