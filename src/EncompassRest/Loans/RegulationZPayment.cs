using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed partial class RegulationZPayment : IDirty
    {
        private DirtyValue<decimal?> _balance;
        public decimal? Balance { get => _balance; set => _balance = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<decimal?> _interestRatePercent;
        public decimal? InterestRatePercent { get => _interestRatePercent; set => _interestRatePercent = value; }
        private DirtyValue<decimal?> _monthlyPayment;
        public decimal? MonthlyPayment { get => _monthlyPayment; set => _monthlyPayment = value; }
        private DirtyValue<int?> _numberOfPayments;
        public int? NumberOfPayments { get => _numberOfPayments; set => _numberOfPayments = value; }
        private DirtyValue<DateTime?> _paymentDate;
        public DateTime? PaymentDate { get => _paymentDate; set => _paymentDate = value; }
        private DirtyValue<int?> _regulationZPaymentIndex;
        public int? RegulationZPaymentIndex { get => _regulationZPaymentIndex; set => _regulationZPaymentIndex = value; }
        private DirtyDictionary<string, object> _extensionData;
        public IDictionary<string, object> ExtensionData { get => _extensionData ?? (_extensionData = new DirtyDictionary<string, object>()); set => _extensionData = new DirtyDictionary<string, object>(value); }
        private bool _gettingDirty;
        private bool _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
                var dirty = _balance.Dirty
                    || _id.Dirty
                    || _interestRatePercent.Dirty
                    || _monthlyPayment.Dirty
                    || _numberOfPayments.Dirty
                    || _paymentDate.Dirty
                    || _regulationZPaymentIndex.Dirty
                    || _extensionData?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _balance.Dirty = value;
                _id.Dirty = value;
                _interestRatePercent.Dirty = value;
                _monthlyPayment.Dirty = value;
                _numberOfPayments.Dirty = value;
                _paymentDate.Dirty = value;
                _regulationZPaymentIndex.Dirty = value;
                if (_extensionData != null) _extensionData.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get => Dirty; set => Dirty = value; }
    }
}