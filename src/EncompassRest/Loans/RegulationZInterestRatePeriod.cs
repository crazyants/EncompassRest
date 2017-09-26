using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class RegulationZInterestRatePeriod : IDirty
    {
        private Value<DateTime?> _adjustmentDate;
        public DateTime? AdjustmentDate { get { return _adjustmentDate; } set { _adjustmentDate = value; } }
        private Value<int?> _adjustmentMonths;
        public int? AdjustmentMonths { get { return _adjustmentMonths; } set { _adjustmentMonths = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<decimal?> _interestPayment;
        public decimal? InterestPayment { get { return _interestPayment; } set { _interestPayment = value; } }
        private Value<decimal?> _interestPrincipalPayment;
        public decimal? InterestPrincipalPayment { get { return _interestPrincipalPayment; } set { _interestPrincipalPayment = value; } }
        private Value<decimal?> _interestRatePercent;
        public decimal? InterestRatePercent { get { return _interestRatePercent; } set { _interestRatePercent = value; } }
        private Value<decimal?> _monthlyPayment;
        public decimal? MonthlyPayment { get { return _monthlyPayment; } set { _monthlyPayment = value; } }
        private Value<decimal?> _principalPayment;
        public decimal? PrincipalPayment { get { return _principalPayment; } set { _principalPayment = value; } }
        private Value<string> _regulationZInterestRatePeriodType;
        public string RegulationZInterestRatePeriodType { get { return _regulationZInterestRatePeriodType; } set { _regulationZInterestRatePeriodType = value; } }
        private Value<decimal?> _taxInsuranceAmount;
        public decimal? TaxInsuranceAmount { get { return _taxInsuranceAmount; } set { _taxInsuranceAmount = value; } }
        private Value<decimal?> _totalPayment;
        public decimal? TotalPayment { get { return _totalPayment; } set { _totalPayment = value; } }
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _adjustmentDate.Dirty
                    || _adjustmentMonths.Dirty
                    || _id.Dirty
                    || _interestPayment.Dirty
                    || _interestPrincipalPayment.Dirty
                    || _interestRatePercent.Dirty
                    || _monthlyPayment.Dirty
                    || _principalPayment.Dirty
                    || _regulationZInterestRatePeriodType.Dirty
                    || _taxInsuranceAmount.Dirty
                    || _totalPayment.Dirty;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
                _adjustmentDate.Dirty = value;
                _adjustmentMonths.Dirty = value;
                _id.Dirty = value;
                _interestPayment.Dirty = value;
                _interestPrincipalPayment.Dirty = value;
                _interestRatePercent.Dirty = value;
                _monthlyPayment.Dirty = value;
                _principalPayment.Dirty = value;
                _regulationZInterestRatePeriodType.Dirty = value;
                _taxInsuranceAmount.Dirty = value;
                _totalPayment.Dirty = value;
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}