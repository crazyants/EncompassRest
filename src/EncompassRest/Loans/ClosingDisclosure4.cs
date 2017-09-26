using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class ClosingDisclosure4 : IDirty
    {
        private Value<string> _demandFeature;
        public string DemandFeature { get { return _demandFeature; } set { _demandFeature = value; } }
        private Value<bool?> _escrowIndicator;
        public bool? EscrowIndicator { get { return _escrowIndicator; } set { _escrowIndicator = value; } }
        private Value<decimal?> _estimatedPropertyCosts;
        public decimal? EstimatedPropertyCosts { get { return _estimatedPropertyCosts; } set { _estimatedPropertyCosts = value; } }
        private Value<string> _firstChangeAmt;
        public string FirstChangeAmt { get { return _firstChangeAmt; } set { _firstChangeAmt = value; } }
        private Value<decimal?> _firstChangeMaxAmt;
        public decimal? FirstChangeMaxAmt { get { return _firstChangeMaxAmt; } set { _firstChangeMaxAmt = value; } }
        private Value<decimal?> _firstChangeMinAmt;
        public decimal? FirstChangeMinAmt { get { return _firstChangeMinAmt; } set { _firstChangeMinAmt = value; } }
        private Value<string> _firstChangePayment;
        public string FirstChangePayment { get { return _firstChangePayment; } set { _firstChangePayment = value; } }
        private Value<bool?> _hOADuesIsEscrow;
        public bool? HOADuesIsEscrow { get { return _hOADuesIsEscrow; } set { _hOADuesIsEscrow = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<bool?> _ignoreARMAdj;
        public bool? IgnoreARMAdj { get { return _ignoreARMAdj; } set { _ignoreARMAdj = value; } }
        private Value<decimal?> _initialEscrowPayment;
        public decimal? InitialEscrowPayment { get { return _initialEscrowPayment; } set { _initialEscrowPayment = value; } }
        private Value<int?> _interestOnlyPaymentMonths;
        public int? InterestOnlyPaymentMonths { get { return _interestOnlyPaymentMonths; } set { _interestOnlyPaymentMonths = value; } }
        private Value<bool?> _interestOnlyPayments;
        public bool? InterestOnlyPayments { get { return _interestOnlyPayments; } set { _interestOnlyPayments = value; } }
        private Value<int?> _interestRateAdjustments;
        public int? InterestRateAdjustments { get { return _interestRateAdjustments; } set { _interestRateAdjustments = value; } }
        private Value<bool?> _lender;
        public bool? Lender { get { return _lender; } set { _lender = value; } }
        private Value<string> _maximumPaymentAmt;
        public string MaximumPaymentAmt { get { return _maximumPaymentAmt; } set { _maximumPaymentAmt = value; } }
        private Value<string> _maxPayment;
        public string MaxPayment { get { return _maxPayment; } set { _maxPayment = value; } }
        private Value<decimal?> _maxPaymentAmt;
        public decimal? MaxPaymentAmt { get { return _maxPaymentAmt; } set { _maxPaymentAmt = value; } }
        private Value<decimal?> _monthlyEscrowPayment;
        public decimal? MonthlyEscrowPayment { get { return _monthlyEscrowPayment; } set { _monthlyEscrowPayment = value; } }
        private Value<string> _negativeAmortization;
        public string NegativeAmortization { get { return _negativeAmortization; } set { _negativeAmortization = value; } }
        private Value<decimal?> _nonEscrowedPropertyCosts1YearConsummation;
        public decimal? NonEscrowedPropertyCosts1YearConsummation { get { return _nonEscrowedPropertyCosts1YearConsummation; } set { _nonEscrowedPropertyCosts1YearConsummation = value; } }
        private Value<bool?> _other1;
        public bool? Other1 { get { return _other1; } set { _other1 = value; } }
        private Value<bool?> _other2;
        public bool? Other2 { get { return _other2; } set { _other2 = value; } }
        private Value<bool?> _other3;
        public bool? Other3 { get { return _other3; } set { _other3 = value; } }
        private Value<string> _partialPayment;
        public string PartialPayment { get { return _partialPayment; } set { _partialPayment = value; } }
        private Value<string> _partialPaymentHoldUntilComplete;
        public string PartialPaymentHoldUntilComplete { get { return _partialPaymentHoldUntilComplete; } set { _partialPaymentHoldUntilComplete = value; } }
        private Value<string> _partialPaymentNone;
        public string PartialPaymentNone { get { return _partialPaymentNone; } set { _partialPaymentNone = value; } }
        private Value<string> _seasonalPaymentFromYr;
        public string SeasonalPaymentFromYr { get { return _seasonalPaymentFromYr; } set { _seasonalPaymentFromYr = value; } }
        private Value<bool?> _seasonalPayments;
        public bool? SeasonalPayments { get { return _seasonalPayments; } set { _seasonalPayments = value; } }
        private Value<int?> _stepPayment;
        public int? StepPayment { get { return _stepPayment; } set { _stepPayment = value; } }
        private Value<bool?> _stepPayments;
        public bool? StepPayments { get { return _stepPayments; } set { _stepPayments = value; } }
        private Value<decimal?> _stepRateFirstChange;
        public decimal? StepRateFirstChange { get { return _stepRateFirstChange; } set { _stepRateFirstChange = value; } }
        private Value<string> _subsequentChanges;
        public string SubsequentChanges { get { return _subsequentChanges; } set { _subsequentChanges = value; } }
        private Value<decimal?> _totalDisbursed1YearConsummation;
        public decimal? TotalDisbursed1YearConsummation { get { return _totalDisbursed1YearConsummation; } set { _totalDisbursed1YearConsummation = value; } }
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _demandFeature.Dirty
                    || _escrowIndicator.Dirty
                    || _estimatedPropertyCosts.Dirty
                    || _firstChangeAmt.Dirty
                    || _firstChangeMaxAmt.Dirty
                    || _firstChangeMinAmt.Dirty
                    || _firstChangePayment.Dirty
                    || _hOADuesIsEscrow.Dirty
                    || _id.Dirty
                    || _ignoreARMAdj.Dirty
                    || _initialEscrowPayment.Dirty
                    || _interestOnlyPaymentMonths.Dirty
                    || _interestOnlyPayments.Dirty
                    || _interestRateAdjustments.Dirty
                    || _lender.Dirty
                    || _maximumPaymentAmt.Dirty
                    || _maxPayment.Dirty
                    || _maxPaymentAmt.Dirty
                    || _monthlyEscrowPayment.Dirty
                    || _negativeAmortization.Dirty
                    || _nonEscrowedPropertyCosts1YearConsummation.Dirty
                    || _other1.Dirty
                    || _other2.Dirty
                    || _other3.Dirty
                    || _partialPayment.Dirty
                    || _partialPaymentHoldUntilComplete.Dirty
                    || _partialPaymentNone.Dirty
                    || _seasonalPaymentFromYr.Dirty
                    || _seasonalPayments.Dirty
                    || _stepPayment.Dirty
                    || _stepPayments.Dirty
                    || _stepRateFirstChange.Dirty
                    || _subsequentChanges.Dirty
                    || _totalDisbursed1YearConsummation.Dirty;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
                _demandFeature.Dirty = value;
                _escrowIndicator.Dirty = value;
                _estimatedPropertyCosts.Dirty = value;
                _firstChangeAmt.Dirty = value;
                _firstChangeMaxAmt.Dirty = value;
                _firstChangeMinAmt.Dirty = value;
                _firstChangePayment.Dirty = value;
                _hOADuesIsEscrow.Dirty = value;
                _id.Dirty = value;
                _ignoreARMAdj.Dirty = value;
                _initialEscrowPayment.Dirty = value;
                _interestOnlyPaymentMonths.Dirty = value;
                _interestOnlyPayments.Dirty = value;
                _interestRateAdjustments.Dirty = value;
                _lender.Dirty = value;
                _maximumPaymentAmt.Dirty = value;
                _maxPayment.Dirty = value;
                _maxPaymentAmt.Dirty = value;
                _monthlyEscrowPayment.Dirty = value;
                _negativeAmortization.Dirty = value;
                _nonEscrowedPropertyCosts1YearConsummation.Dirty = value;
                _other1.Dirty = value;
                _other2.Dirty = value;
                _other3.Dirty = value;
                _partialPayment.Dirty = value;
                _partialPaymentHoldUntilComplete.Dirty = value;
                _partialPaymentNone.Dirty = value;
                _seasonalPaymentFromYr.Dirty = value;
                _seasonalPayments.Dirty = value;
                _stepPayment.Dirty = value;
                _stepPayments.Dirty = value;
                _stepRateFirstChange.Dirty = value;
                _subsequentChanges.Dirty = value;
                _totalDisbursed1YearConsummation.Dirty = value;
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}