using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed partial class FeeVarianceOther : IDirty
    {
        private DirtyValue<decimal?> _appliedCureAmount;
        public decimal? AppliedCureAmount { get => _appliedCureAmount; set => _appliedCureAmount = value; }
        private DirtyValue<string> _cannotDecreaseCDBaselineGuid;
        public string CannotDecreaseCDBaselineGuid { get => _cannotDecreaseCDBaselineGuid; set => _cannotDecreaseCDBaselineGuid = value; }
        private DirtyValue<string> _cannotDecreaseLEBaselineGuid;
        public string CannotDecreaseLEBaselineGuid { get => _cannotDecreaseLEBaselineGuid; set => _cannotDecreaseLEBaselineGuid = value; }
        private DirtyValue<string> _cannotIncrease10CDBaselineGuid;
        public string CannotIncrease10CDBaselineGuid { get => _cannotIncrease10CDBaselineGuid; set => _cannotIncrease10CDBaselineGuid = value; }
        private DirtyValue<string> _cannotIncrease10LEBaselineGuid;
        public string CannotIncrease10LEBaselineGuid { get => _cannotIncrease10LEBaselineGuid; set => _cannotIncrease10LEBaselineGuid = value; }
        private DirtyValue<string> _cannotIncreaseCDBaselineGuid;
        public string CannotIncreaseCDBaselineGuid { get => _cannotIncreaseCDBaselineGuid; set => _cannotIncreaseCDBaselineGuid = value; }
        private DirtyValue<string> _cannotIncreaseLEBaselineGuid;
        public string CannotIncreaseLEBaselineGuid { get => _cannotIncreaseLEBaselineGuid; set => _cannotIncreaseLEBaselineGuid = value; }
        private DirtyValue<string> _cDInitialGuid;
        public string CDInitialGuid { get => _cDInitialGuid; set => _cDInitialGuid = value; }
        private DirtyValue<string> _cDInitialReceivedDateGuid;
        public string CDInitialReceivedDateGuid { get => _cDInitialReceivedDateGuid; set => _cDInitialReceivedDateGuid = value; }
        private DirtyValue<string> _cDLatestGuid;
        public string CDLatestGuid { get => _cDLatestGuid; set => _cDLatestGuid = value; }
        private DirtyValue<string> _cDPostConGuid;
        public string CDPostConGuid { get => _cDPostConGuid; set => _cDPostConGuid = value; }
        private DirtyValue<string> _cDRecentAppliedCure;
        public string CDRecentAppliedCure { get => _cDRecentAppliedCure; set => _cDRecentAppliedCure = value; }
        private DirtyValue<string> _cDRevisedReceivedDateGuid;
        public string CDRevisedReceivedDateGuid { get => _cDRevisedReceivedDateGuid; set => _cDRevisedReceivedDateGuid = value; }
        private DirtyValue<DateTime?> _chargesCannotIncrease10CD1;
        public DateTime? ChargesCannotIncrease10CD1 { get => _chargesCannotIncrease10CD1; set => _chargesCannotIncrease10CD1 = value; }
        private DirtyValue<DateTime?> _chargesCannotIncrease10InitialLE1;
        public DateTime? ChargesCannotIncrease10InitialLE1 { get => _chargesCannotIncrease10InitialLE1; set => _chargesCannotIncrease10InitialLE1 = value; }
        private DirtyValue<DateTime?> _chargesCannotIncrease10LE1;
        public DateTime? ChargesCannotIncrease10LE1 { get => _chargesCannotIncrease10LE1; set => _chargesCannotIncrease10LE1 = value; }
        private DirtyValue<DateTime?> _chargesThatCanChangeCD1;
        public DateTime? ChargesThatCanChangeCD1 { get => _chargesThatCanChangeCD1; set => _chargesThatCanChangeCD1 = value; }
        private DirtyValue<DateTime?> _chargesThatCanChangeInitialLE1;
        public DateTime? ChargesThatCanChangeInitialLE1 { get => _chargesThatCanChangeInitialLE1; set => _chargesThatCanChangeInitialLE1 = value; }
        private DirtyValue<DateTime?> _chargesThatCanChangeLE1;
        public DateTime? ChargesThatCanChangeLE1 { get => _chargesThatCanChangeLE1; set => _chargesThatCanChangeLE1 = value; }
        private DirtyValue<DateTime?> _chargesThatCannotDecreaseCD1;
        public DateTime? ChargesThatCannotDecreaseCD1 { get => _chargesThatCannotDecreaseCD1; set => _chargesThatCannotDecreaseCD1 = value; }
        private DirtyValue<DateTime?> _chargesThatCannotDecreaseInitialLE1;
        public DateTime? ChargesThatCannotDecreaseInitialLE1 { get => _chargesThatCannotDecreaseInitialLE1; set => _chargesThatCannotDecreaseInitialLE1 = value; }
        private DirtyValue<DateTime?> _chargesThatCannotDecreaseLE1;
        public DateTime? ChargesThatCannotDecreaseLE1 { get => _chargesThatCannotDecreaseLE1; set => _chargesThatCannotDecreaseLE1 = value; }
        private DirtyValue<DateTime?> _chargesThatCannotIncreaseCD1;
        public DateTime? ChargesThatCannotIncreaseCD1 { get => _chargesThatCannotIncreaseCD1; set => _chargesThatCannotIncreaseCD1 = value; }
        private DirtyValue<DateTime?> _chargesThatCannotIncreaseInitialLE1;
        public DateTime? ChargesThatCannotIncreaseInitialLE1 { get => _chargesThatCannotIncreaseInitialLE1; set => _chargesThatCannotIncreaseInitialLE1 = value; }
        private DirtyValue<DateTime?> _chargesThatCannotIncreaseLE1;
        public DateTime? ChargesThatCannotIncreaseLE1 { get => _chargesThatCannotIncreaseLE1; set => _chargesThatCannotIncreaseLE1 = value; }
        private DirtyValue<string> _disclosureLogGUIDForECD;
        public string DisclosureLogGUIDForECD { get => _disclosureLogGUIDForECD; set => _disclosureLogGUIDForECD = value; }
        private DirtyValue<string> _disclosureLogGUIDReceivedForECD;
        public string DisclosureLogGUIDReceivedForECD { get => _disclosureLogGUIDReceivedForECD; set => _disclosureLogGUIDReceivedForECD = value; }
        private DirtyValue<DateTime?> _goodFaithAmountInitialLE1;
        public DateTime? GoodFaithAmountInitialLE1 { get => _goodFaithAmountInitialLE1; set => _goodFaithAmountInitialLE1 = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<bool?> _lEBaselineUsedCannotDecrease;
        public bool? LEBaselineUsedCannotDecrease { get => _lEBaselineUsedCannotDecrease; set => _lEBaselineUsedCannotDecrease = value; }
        private DirtyValue<bool?> _lEBaselineUsedCannotIncrease;
        public bool? LEBaselineUsedCannotIncrease { get => _lEBaselineUsedCannotIncrease; set => _lEBaselineUsedCannotIncrease = value; }
        private DirtyValue<bool?> _lEBaselineUsedCannotIncrease10;
        public bool? LEBaselineUsedCannotIncrease10 { get => _lEBaselineUsedCannotIncrease10; set => _lEBaselineUsedCannotIncrease10 = value; }
        private DirtyValue<string> _lEInitialDTGuid;
        public string LEInitialDTGuid { get => _lEInitialDTGuid; set => _lEInitialDTGuid = value; }
        private DirtyValue<string> _lEInitialGuid;
        public string LEInitialGuid { get => _lEInitialGuid; set => _lEInitialGuid = value; }
        private DirtyValue<string> _lEInitialReceivedDateGuid;
        public string LEInitialReceivedDateGuid { get => _lEInitialReceivedDateGuid; set => _lEInitialReceivedDateGuid = value; }
        private DirtyValue<string> _lELatestGuid;
        public string LELatestGuid { get => _lELatestGuid; set => _lELatestGuid = value; }
        private DirtyValue<string> _lERevisedReceivedDateGuid;
        public string LERevisedReceivedDateGuid { get => _lERevisedReceivedDateGuid; set => _lERevisedReceivedDateGuid = value; }
        private DirtyValue<string> _lERevisedSentDateGuid;
        public string LERevisedSentDateGuid { get => _lERevisedSentDateGuid; set => _lERevisedSentDateGuid = value; }
        private DirtyValue<decimal?> _requiredCureAmount;
        public decimal? RequiredCureAmount { get => _requiredCureAmount; set => _requiredCureAmount = value; }
        private DirtyValue<string> _safeHarborGuid;
        public string SafeHarborGuid { get => _safeHarborGuid; set => _safeHarborGuid = value; }
        private DirtyValue<string> _sSPLGuid;
        public string SSPLGuid { get => _sSPLGuid; set => _sSPLGuid = value; }
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
                var dirty = _appliedCureAmount.Dirty
                    || _cannotDecreaseCDBaselineGuid.Dirty
                    || _cannotDecreaseLEBaselineGuid.Dirty
                    || _cannotIncrease10CDBaselineGuid.Dirty
                    || _cannotIncrease10LEBaselineGuid.Dirty
                    || _cannotIncreaseCDBaselineGuid.Dirty
                    || _cannotIncreaseLEBaselineGuid.Dirty
                    || _cDInitialGuid.Dirty
                    || _cDInitialReceivedDateGuid.Dirty
                    || _cDLatestGuid.Dirty
                    || _cDPostConGuid.Dirty
                    || _cDRecentAppliedCure.Dirty
                    || _cDRevisedReceivedDateGuid.Dirty
                    || _chargesCannotIncrease10CD1.Dirty
                    || _chargesCannotIncrease10InitialLE1.Dirty
                    || _chargesCannotIncrease10LE1.Dirty
                    || _chargesThatCanChangeCD1.Dirty
                    || _chargesThatCanChangeInitialLE1.Dirty
                    || _chargesThatCanChangeLE1.Dirty
                    || _chargesThatCannotDecreaseCD1.Dirty
                    || _chargesThatCannotDecreaseInitialLE1.Dirty
                    || _chargesThatCannotDecreaseLE1.Dirty
                    || _chargesThatCannotIncreaseCD1.Dirty
                    || _chargesThatCannotIncreaseInitialLE1.Dirty
                    || _chargesThatCannotIncreaseLE1.Dirty
                    || _disclosureLogGUIDForECD.Dirty
                    || _disclosureLogGUIDReceivedForECD.Dirty
                    || _goodFaithAmountInitialLE1.Dirty
                    || _id.Dirty
                    || _lEBaselineUsedCannotDecrease.Dirty
                    || _lEBaselineUsedCannotIncrease.Dirty
                    || _lEBaselineUsedCannotIncrease10.Dirty
                    || _lEInitialDTGuid.Dirty
                    || _lEInitialGuid.Dirty
                    || _lEInitialReceivedDateGuid.Dirty
                    || _lELatestGuid.Dirty
                    || _lERevisedReceivedDateGuid.Dirty
                    || _lERevisedSentDateGuid.Dirty
                    || _requiredCureAmount.Dirty
                    || _safeHarborGuid.Dirty
                    || _sSPLGuid.Dirty
                    || _extensionData?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _appliedCureAmount.Dirty = value;
                _cannotDecreaseCDBaselineGuid.Dirty = value;
                _cannotDecreaseLEBaselineGuid.Dirty = value;
                _cannotIncrease10CDBaselineGuid.Dirty = value;
                _cannotIncrease10LEBaselineGuid.Dirty = value;
                _cannotIncreaseCDBaselineGuid.Dirty = value;
                _cannotIncreaseLEBaselineGuid.Dirty = value;
                _cDInitialGuid.Dirty = value;
                _cDInitialReceivedDateGuid.Dirty = value;
                _cDLatestGuid.Dirty = value;
                _cDPostConGuid.Dirty = value;
                _cDRecentAppliedCure.Dirty = value;
                _cDRevisedReceivedDateGuid.Dirty = value;
                _chargesCannotIncrease10CD1.Dirty = value;
                _chargesCannotIncrease10InitialLE1.Dirty = value;
                _chargesCannotIncrease10LE1.Dirty = value;
                _chargesThatCanChangeCD1.Dirty = value;
                _chargesThatCanChangeInitialLE1.Dirty = value;
                _chargesThatCanChangeLE1.Dirty = value;
                _chargesThatCannotDecreaseCD1.Dirty = value;
                _chargesThatCannotDecreaseInitialLE1.Dirty = value;
                _chargesThatCannotDecreaseLE1.Dirty = value;
                _chargesThatCannotIncreaseCD1.Dirty = value;
                _chargesThatCannotIncreaseInitialLE1.Dirty = value;
                _chargesThatCannotIncreaseLE1.Dirty = value;
                _disclosureLogGUIDForECD.Dirty = value;
                _disclosureLogGUIDReceivedForECD.Dirty = value;
                _goodFaithAmountInitialLE1.Dirty = value;
                _id.Dirty = value;
                _lEBaselineUsedCannotDecrease.Dirty = value;
                _lEBaselineUsedCannotIncrease.Dirty = value;
                _lEBaselineUsedCannotIncrease10.Dirty = value;
                _lEInitialDTGuid.Dirty = value;
                _lEInitialGuid.Dirty = value;
                _lEInitialReceivedDateGuid.Dirty = value;
                _lELatestGuid.Dirty = value;
                _lERevisedReceivedDateGuid.Dirty = value;
                _lERevisedSentDateGuid.Dirty = value;
                _requiredCureAmount.Dirty = value;
                _safeHarborGuid.Dirty = value;
                _sSPLGuid.Dirty = value;
                if (_extensionData != null) _extensionData.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get => Dirty; set => Dirty = value; }
    }
}