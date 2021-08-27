using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using CFDI.NET.Complements;

namespace CFDI.NET.Base
{
    public class BaseInvoice
    {
        private Supplier _supplier;
        private Customer _customer;
        private List<RelatedInvoice> _relatedInvoice;
        private List<InvoiceItem> _invoiceItems;
        private List<InvoiceTax> _invoiceTaxes;
        private InvoiceComplement _complement;
        private InvoiceAppendix _invoiceAppendix;
        private TaxAuthorization _taxAuthorization;

        private string _version;
        private string _series;
        private string _number;
        private DateTime _invoiceDate;
        private string _invoiceSignature;
        private string _paymentForm;
        private string _paymentMethod;
        private string _paymentConditions;
        private string _certificateNumber;
        private string _certificateBase64;
        private decimal _subTotal;
        private decimal _discount;
        private string _currency;
        private decimal _total;
        private decimal _exchangeRate; //tipo de cambio
        private string _zipCode;
        private string _confirmation;

        [XmlElement("Emisor")]
        public Supplier Supplier
        {
            get => _supplier;
            set => _supplier = value;
        }

        [XmlElement("Receptor")]
        public Customer Customer
        {
            get => _customer;
            set => _customer = value;
        }

        [XmlArray("CfdiRelacionados")]
        [XmlArrayItem("CfdiRelacionado", IsNullable = false)]
        public List<RelatedInvoice> RelatedInvoice
        {
            get => _relatedInvoice;
            set => _relatedInvoice = value;
        }

        [XmlArray("Conceptos")]
        [XmlArrayItem("Concepto", IsNullable = false)]
        public List<InvoiceItem> InvoiceItems
        {
            get => _invoiceItems;
            set => _invoiceItems = value;
        }

        public List<InvoiceTax> InvoiceTaxes
        {
            get => _invoiceTaxes;
            set => _invoiceTaxes = value;
        }

        public InvoiceComplement Complement
        {
            get => _complement;
            set => _complement = value;
        }

        public InvoiceAppendix InvoiceAppendix
        {
            get => _invoiceAppendix;
            set => _invoiceAppendix = value;
        }

        public TaxAuthorization TaxAuthorization
        {
            get => _taxAuthorization;
            set => _taxAuthorization = value;
        }

        public string Version
        {
            get => _version;
            set => _version = value;
        }

        public string Series
        {
            get => _series;
            set => _series = value;
        }

        public string Number
        {
            get => _number;
            set => _number = value;
        }

        public DateTime InvoiceDate
        {
            get => _invoiceDate;
            set => _invoiceDate = value;
        }

        public string InvoiceSignature
        {
            get => _invoiceSignature;
            set => _invoiceSignature = value;
        }

        public string PaymentForm
        {
            get => _paymentForm;
            set
            {
                _paymentForm = value;
                _paymentFormSpecified = true;
            }
        }

        public string PaymentMethod
        {
            get => _paymentMethod;
            set
            {
                _paymentMethod = value;
                _paymentMethodSpecified = true;
            }
        }

        public string PaymentConditions
        {
            get => _paymentConditions;
            set => _paymentConditions = value;
        }

        public string CertificateNumber
        {
            get => _certificateNumber;
            set => _certificateNumber = value;
        }

        public string CertificateBase64
        {
            get => _certificateBase64;
            set => _certificateBase64 = value;
        }

        public decimal SubTotal
        {
            get => _subTotal;
            set => _subTotal = value;
        }

        public decimal Discount
        {
            get => _discount;
            set
            {
                _discount = value;
                _discountSpecified = true;
            }
        }

        public string Currency
        {
            get => _currency;
            set => _currency = value;
        }

        public decimal Total
        {
            get => _total;
            set => _total = value;
        }

        public decimal ExchangeRate
        {
            get => _exchangeRate;
            set
            {
                _exchangeRate = value;
                _exchangeRateSpecified = true;
            }
        }

        public string ZipCode
        {
            get => _zipCode;
            set => _zipCode = value;
        }

        public string Confirmation
        {
            get => _confirmation;
            set => _confirmation = value;
        }

        public bool PaymentFormSpecified
        {
            get => _paymentFormSpecified;
            set => _paymentFormSpecified = value;
        }

        public bool DiscountSpecified
        {
            get => _discountSpecified;
            set => _discountSpecified = value;
        }

        public bool ExchangeRateSpecified
        {
            get => _exchangeRateSpecified;
            set => _exchangeRateSpecified = value;
        }

        public bool PaymentMethodSpecified
        {
            get => _paymentMethodSpecified;
            set => _paymentMethodSpecified = value;
        }

        #region Specified

        private bool _paymentFormSpecified;
        private bool _discountSpecified;
        private bool _exchangeRateSpecified;
        private bool _paymentMethodSpecified;

        #endregion
    }
}