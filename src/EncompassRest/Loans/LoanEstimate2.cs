using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed partial class LoanEstimate2 : IDirty
    {
        private DirtyValue<decimal?> _actualLenderCredits;
        public decimal? ActualLenderCredits { get => _actualLenderCredits; set => _actualLenderCredits = value; }
        private DirtyValue<decimal?> _actualSTDLESellerCredits;
        public decimal? ActualSTDLESellerCredits { get => _actualSTDLESellerCredits; set => _actualSTDLESellerCredits = value; }
        private DirtyValue<decimal?> _actualSTDLETotalClosingCostJ;
        public decimal? ActualSTDLETotalClosingCostJ { get => _actualSTDLETotalClosingCostJ; set => _actualSTDLETotalClosingCostJ = value; }
        private DirtyValue<decimal?> _adjustmentsOtherCredits;
        public decimal? AdjustmentsOtherCredits { get => _adjustmentsOtherCredits; set => _adjustmentsOtherCredits = value; }
        private DirtyValue<decimal?> _adjustmentsOtherCreditsAmt1;
        public decimal? AdjustmentsOtherCreditsAmt1 { get => _adjustmentsOtherCreditsAmt1; set => _adjustmentsOtherCreditsAmt1 = value; }
        private DirtyValue<decimal?> _adjustmentsOtherCreditsAmt10;
        public decimal? AdjustmentsOtherCreditsAmt10 { get => _adjustmentsOtherCreditsAmt10; set => _adjustmentsOtherCreditsAmt10 = value; }
        private DirtyValue<decimal?> _adjustmentsOtherCreditsAmt2;
        public decimal? AdjustmentsOtherCreditsAmt2 { get => _adjustmentsOtherCreditsAmt2; set => _adjustmentsOtherCreditsAmt2 = value; }
        private DirtyValue<decimal?> _adjustmentsOtherCreditsAmt3;
        public decimal? AdjustmentsOtherCreditsAmt3 { get => _adjustmentsOtherCreditsAmt3; set => _adjustmentsOtherCreditsAmt3 = value; }
        private DirtyValue<decimal?> _adjustmentsOtherCreditsAmt4;
        public decimal? AdjustmentsOtherCreditsAmt4 { get => _adjustmentsOtherCreditsAmt4; set => _adjustmentsOtherCreditsAmt4 = value; }
        private DirtyValue<decimal?> _adjustmentsOtherCreditsAmt5;
        public decimal? AdjustmentsOtherCreditsAmt5 { get => _adjustmentsOtherCreditsAmt5; set => _adjustmentsOtherCreditsAmt5 = value; }
        private DirtyValue<decimal?> _adjustmentsOtherCreditsAmt6;
        public decimal? AdjustmentsOtherCreditsAmt6 { get => _adjustmentsOtherCreditsAmt6; set => _adjustmentsOtherCreditsAmt6 = value; }
        private DirtyValue<decimal?> _adjustmentsOtherCreditsAmt7;
        public decimal? AdjustmentsOtherCreditsAmt7 { get => _adjustmentsOtherCreditsAmt7; set => _adjustmentsOtherCreditsAmt7 = value; }
        private DirtyValue<decimal?> _adjustmentsOtherCreditsAmt8;
        public decimal? AdjustmentsOtherCreditsAmt8 { get => _adjustmentsOtherCreditsAmt8; set => _adjustmentsOtherCreditsAmt8 = value; }
        private DirtyValue<decimal?> _adjustmentsOtherCreditsAmt9;
        public decimal? AdjustmentsOtherCreditsAmt9 { get => _adjustmentsOtherCreditsAmt9; set => _adjustmentsOtherCreditsAmt9 = value; }
        private DirtyValue<string> _adjustmentsOtherCreditsDesc1;
        public string AdjustmentsOtherCreditsDesc1 { get => _adjustmentsOtherCreditsDesc1; set => _adjustmentsOtherCreditsDesc1 = value; }
        private DirtyValue<string> _adjustmentsOtherCreditsDesc10;
        public string AdjustmentsOtherCreditsDesc10 { get => _adjustmentsOtherCreditsDesc10; set => _adjustmentsOtherCreditsDesc10 = value; }
        private DirtyValue<string> _adjustmentsOtherCreditsDesc2;
        public string AdjustmentsOtherCreditsDesc2 { get => _adjustmentsOtherCreditsDesc2; set => _adjustmentsOtherCreditsDesc2 = value; }
        private DirtyValue<string> _adjustmentsOtherCreditsDesc3;
        public string AdjustmentsOtherCreditsDesc3 { get => _adjustmentsOtherCreditsDesc3; set => _adjustmentsOtherCreditsDesc3 = value; }
        private DirtyValue<string> _adjustmentsOtherCreditsDesc4;
        public string AdjustmentsOtherCreditsDesc4 { get => _adjustmentsOtherCreditsDesc4; set => _adjustmentsOtherCreditsDesc4 = value; }
        private DirtyValue<string> _adjustmentsOtherCreditsDesc5;
        public string AdjustmentsOtherCreditsDesc5 { get => _adjustmentsOtherCreditsDesc5; set => _adjustmentsOtherCreditsDesc5 = value; }
        private DirtyValue<string> _adjustmentsOtherCreditsDesc6;
        public string AdjustmentsOtherCreditsDesc6 { get => _adjustmentsOtherCreditsDesc6; set => _adjustmentsOtherCreditsDesc6 = value; }
        private DirtyValue<string> _adjustmentsOtherCreditsDesc7;
        public string AdjustmentsOtherCreditsDesc7 { get => _adjustmentsOtherCreditsDesc7; set => _adjustmentsOtherCreditsDesc7 = value; }
        private DirtyValue<string> _adjustmentsOtherCreditsDesc8;
        public string AdjustmentsOtherCreditsDesc8 { get => _adjustmentsOtherCreditsDesc8; set => _adjustmentsOtherCreditsDesc8 = value; }
        private DirtyValue<string> _adjustmentsOtherCreditsDesc9;
        public string AdjustmentsOtherCreditsDesc9 { get => _adjustmentsOtherCreditsDesc9; set => _adjustmentsOtherCreditsDesc9 = value; }
        private DirtyValue<decimal?> _closingCostsFinanced;
        public decimal? ClosingCostsFinanced { get => _closingCostsFinanced; set => _closingCostsFinanced = value; }
        private DirtyValue<decimal?> _downPayment;
        public decimal? DownPayment { get => _downPayment; set => _downPayment = value; }
        private DirtyValue<decimal?> _estimatedCashToCloseAV;
        public decimal? EstimatedCashToCloseAV { get => _estimatedCashToCloseAV; set => _estimatedCashToCloseAV = value; }
        private DirtyValue<decimal?> _estimatedCashToCloseSV;
        public decimal? EstimatedCashToCloseSV { get => _estimatedCashToCloseSV; set => _estimatedCashToCloseSV = value; }
        private DirtyValue<int?> _estimatedTotalPayoffsAndPaymentsAmount;
        public int? EstimatedTotalPayoffsAndPaymentsAmount { get => _estimatedTotalPayoffsAndPaymentsAmount; set => _estimatedTotalPayoffsAndPaymentsAmount = value; }
        private DirtyValue<int?> _firstChangeFrequencyMonth;
        public int? firstChangeFrequencyMonth { get => _firstChangeFrequencyMonth; set => _firstChangeFrequencyMonth = value; }
        private DirtyValue<string> _firstChangeMonthSuffix;
        public string firstChangeMonthSuffix { get => _firstChangeMonthSuffix; set => _firstChangeMonthSuffix = value; }
        private DirtyValue<string> _fromOrToBorrower;
        public string FromOrToBorrower { get => _fromOrToBorrower; set => _fromOrToBorrower = value; }
        private DirtyValue<decimal?> _fundsForBorrower;
        public decimal? FundsForBorrower { get => _fundsForBorrower; set => _fundsForBorrower = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<StringEnumValue<IndexMargin>> _indexMargin;
        public StringEnumValue<IndexMargin> IndexMargin { get => _indexMargin; set => _indexMargin = value; }
        private DirtyValue<int?> _initialEscrowPaymentClosingSubTotal;
        public int? InitialEscrowPaymentClosingSubTotal { get => _initialEscrowPaymentClosingSubTotal; set => _initialEscrowPaymentClosingSubTotal = value; }
        private DirtyValue<bool?> _itemizeServiceSectionCType;
        public bool? ItemizeServiceSectionCType { get => _itemizeServiceSectionCType; set => _itemizeServiceSectionCType = value; }
        private DirtyValue<int?> _lenderCredits;
        public int? LenderCredits { get => _lenderCredits; set => _lenderCredits = value; }
        private DirtyValue<int?> _originationChargesSubTotal;
        public int? OriginationChargesSubTotal { get => _originationChargesSubTotal; set => _originationChargesSubTotal = value; }
        private DirtyValue<int?> _otherSubTotal;
        public int? OtherSubTotal { get => _otherSubTotal; set => _otherSubTotal = value; }
        private DirtyValue<int?> _prepaidsSubTotal;
        public int? PrepaidsSubTotal { get => _prepaidsSubTotal; set => _prepaidsSubTotal = value; }
        private DirtyValue<int?> _sellerCreditAmount;
        public int? SellerCreditAmount { get => _sellerCreditAmount; set => _sellerCreditAmount = value; }
        private DirtyValue<int?> _servicesYouNotShopSubTotal;
        public int? ServicesYouNotShopSubTotal { get => _servicesYouNotShopSubTotal; set => _servicesYouNotShopSubTotal = value; }
        private DirtyValue<int?> _servicesYouShopSubTotal;
        public int? ServicesYouShopSubTotal { get => _servicesYouShopSubTotal; set => _servicesYouShopSubTotal = value; }
        private DirtyValue<string> _subseqChangeMonthSuffix;
        public string subseqChangeMonthSuffix { get => _subseqChangeMonthSuffix; set => _subseqChangeMonthSuffix = value; }
        private DirtyValue<int?> _taxesGovFeesSubTotal;
        public int? TaxesGovFeesSubTotal { get => _taxesGovFeesSubTotal; set => _taxesGovFeesSubTotal = value; }
        private DirtyValue<decimal?> _thirdPartyPaymentsNotOtherwiseDisclosed;
        public decimal? ThirdPartyPaymentsNotOtherwiseDisclosed { get => _thirdPartyPaymentsNotOtherwiseDisclosed; set => _thirdPartyPaymentsNotOtherwiseDisclosed = value; }
        private DirtyValue<int?> _totalClosingCosts;
        public int? TotalClosingCosts { get => _totalClosingCosts; set => _totalClosingCosts = value; }
        private DirtyValue<int?> _totalLoanAndOtherCosts;
        public int? TotalLoanAndOtherCosts { get => _totalLoanAndOtherCosts; set => _totalLoanAndOtherCosts = value; }
        private DirtyValue<int?> _totalLoanCosts;
        public int? TotalLoanCosts { get => _totalLoanCosts; set => _totalLoanCosts = value; }
        private DirtyValue<int?> _totalOtherCosts;
        public int? TotalOtherCosts { get => _totalOtherCosts; set => _totalOtherCosts = value; }
        private DirtyValue<decimal?> _unroundedTotalLoanCosts;
        public decimal? UnroundedTotalLoanCosts { get => _unroundedTotalLoanCosts; set => _unroundedTotalLoanCosts = value; }
        private DirtyValue<decimal?> _unroundedTotalOtherCosts;
        public decimal? UnroundedTotalOtherCosts { get => _unroundedTotalOtherCosts; set => _unroundedTotalOtherCosts = value; }
        private DirtyValue<bool?> _useActualDownPaymentAndClosingCostsFinancedIndicator;
        public bool? UseActualDownPaymentAndClosingCostsFinancedIndicator { get => _useActualDownPaymentAndClosingCostsFinancedIndicator; set => _useActualDownPaymentAndClosingCostsFinancedIndicator = value; }
        private DirtyValue<bool?> _useAlternate;
        public bool? UseAlternate { get => _useAlternate; set => _useAlternate = value; }
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
                var dirty = _actualLenderCredits.Dirty
                    || _actualSTDLESellerCredits.Dirty
                    || _actualSTDLETotalClosingCostJ.Dirty
                    || _adjustmentsOtherCredits.Dirty
                    || _adjustmentsOtherCreditsAmt1.Dirty
                    || _adjustmentsOtherCreditsAmt10.Dirty
                    || _adjustmentsOtherCreditsAmt2.Dirty
                    || _adjustmentsOtherCreditsAmt3.Dirty
                    || _adjustmentsOtherCreditsAmt4.Dirty
                    || _adjustmentsOtherCreditsAmt5.Dirty
                    || _adjustmentsOtherCreditsAmt6.Dirty
                    || _adjustmentsOtherCreditsAmt7.Dirty
                    || _adjustmentsOtherCreditsAmt8.Dirty
                    || _adjustmentsOtherCreditsAmt9.Dirty
                    || _adjustmentsOtherCreditsDesc1.Dirty
                    || _adjustmentsOtherCreditsDesc10.Dirty
                    || _adjustmentsOtherCreditsDesc2.Dirty
                    || _adjustmentsOtherCreditsDesc3.Dirty
                    || _adjustmentsOtherCreditsDesc4.Dirty
                    || _adjustmentsOtherCreditsDesc5.Dirty
                    || _adjustmentsOtherCreditsDesc6.Dirty
                    || _adjustmentsOtherCreditsDesc7.Dirty
                    || _adjustmentsOtherCreditsDesc8.Dirty
                    || _adjustmentsOtherCreditsDesc9.Dirty
                    || _closingCostsFinanced.Dirty
                    || _downPayment.Dirty
                    || _estimatedCashToCloseAV.Dirty
                    || _estimatedCashToCloseSV.Dirty
                    || _estimatedTotalPayoffsAndPaymentsAmount.Dirty
                    || _firstChangeFrequencyMonth.Dirty
                    || _firstChangeMonthSuffix.Dirty
                    || _fromOrToBorrower.Dirty
                    || _fundsForBorrower.Dirty
                    || _id.Dirty
                    || _indexMargin.Dirty
                    || _initialEscrowPaymentClosingSubTotal.Dirty
                    || _itemizeServiceSectionCType.Dirty
                    || _lenderCredits.Dirty
                    || _originationChargesSubTotal.Dirty
                    || _otherSubTotal.Dirty
                    || _prepaidsSubTotal.Dirty
                    || _sellerCreditAmount.Dirty
                    || _servicesYouNotShopSubTotal.Dirty
                    || _servicesYouShopSubTotal.Dirty
                    || _subseqChangeMonthSuffix.Dirty
                    || _taxesGovFeesSubTotal.Dirty
                    || _thirdPartyPaymentsNotOtherwiseDisclosed.Dirty
                    || _totalClosingCosts.Dirty
                    || _totalLoanAndOtherCosts.Dirty
                    || _totalLoanCosts.Dirty
                    || _totalOtherCosts.Dirty
                    || _unroundedTotalLoanCosts.Dirty
                    || _unroundedTotalOtherCosts.Dirty
                    || _useActualDownPaymentAndClosingCostsFinancedIndicator.Dirty
                    || _useAlternate.Dirty
                    || _extensionData?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _actualLenderCredits.Dirty = value;
                _actualSTDLESellerCredits.Dirty = value;
                _actualSTDLETotalClosingCostJ.Dirty = value;
                _adjustmentsOtherCredits.Dirty = value;
                _adjustmentsOtherCreditsAmt1.Dirty = value;
                _adjustmentsOtherCreditsAmt10.Dirty = value;
                _adjustmentsOtherCreditsAmt2.Dirty = value;
                _adjustmentsOtherCreditsAmt3.Dirty = value;
                _adjustmentsOtherCreditsAmt4.Dirty = value;
                _adjustmentsOtherCreditsAmt5.Dirty = value;
                _adjustmentsOtherCreditsAmt6.Dirty = value;
                _adjustmentsOtherCreditsAmt7.Dirty = value;
                _adjustmentsOtherCreditsAmt8.Dirty = value;
                _adjustmentsOtherCreditsAmt9.Dirty = value;
                _adjustmentsOtherCreditsDesc1.Dirty = value;
                _adjustmentsOtherCreditsDesc10.Dirty = value;
                _adjustmentsOtherCreditsDesc2.Dirty = value;
                _adjustmentsOtherCreditsDesc3.Dirty = value;
                _adjustmentsOtherCreditsDesc4.Dirty = value;
                _adjustmentsOtherCreditsDesc5.Dirty = value;
                _adjustmentsOtherCreditsDesc6.Dirty = value;
                _adjustmentsOtherCreditsDesc7.Dirty = value;
                _adjustmentsOtherCreditsDesc8.Dirty = value;
                _adjustmentsOtherCreditsDesc9.Dirty = value;
                _closingCostsFinanced.Dirty = value;
                _downPayment.Dirty = value;
                _estimatedCashToCloseAV.Dirty = value;
                _estimatedCashToCloseSV.Dirty = value;
                _estimatedTotalPayoffsAndPaymentsAmount.Dirty = value;
                _firstChangeFrequencyMonth.Dirty = value;
                _firstChangeMonthSuffix.Dirty = value;
                _fromOrToBorrower.Dirty = value;
                _fundsForBorrower.Dirty = value;
                _id.Dirty = value;
                _indexMargin.Dirty = value;
                _initialEscrowPaymentClosingSubTotal.Dirty = value;
                _itemizeServiceSectionCType.Dirty = value;
                _lenderCredits.Dirty = value;
                _originationChargesSubTotal.Dirty = value;
                _otherSubTotal.Dirty = value;
                _prepaidsSubTotal.Dirty = value;
                _sellerCreditAmount.Dirty = value;
                _servicesYouNotShopSubTotal.Dirty = value;
                _servicesYouShopSubTotal.Dirty = value;
                _subseqChangeMonthSuffix.Dirty = value;
                _taxesGovFeesSubTotal.Dirty = value;
                _thirdPartyPaymentsNotOtherwiseDisclosed.Dirty = value;
                _totalClosingCosts.Dirty = value;
                _totalLoanAndOtherCosts.Dirty = value;
                _totalLoanCosts.Dirty = value;
                _totalOtherCosts.Dirty = value;
                _unroundedTotalLoanCosts.Dirty = value;
                _unroundedTotalOtherCosts.Dirty = value;
                _useActualDownPaymentAndClosingCostsFinancedIndicator.Dirty = value;
                _useAlternate.Dirty = value;
                if (_extensionData != null) _extensionData.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get => Dirty; set => Dirty = value; }
    }
}