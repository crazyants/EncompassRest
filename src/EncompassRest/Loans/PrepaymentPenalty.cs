using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed partial class PrepaymentPenalty : IDirty
    {
        private DirtyValue<StringEnumValue<FullPrepaymentPenaltyOptionType>> _fullPrepaymentPenaltyOptionType;
        public StringEnumValue<FullPrepaymentPenaltyOptionType> FullPrepaymentPenaltyOptionType { get => _fullPrepaymentPenaltyOptionType; set => _fullPrepaymentPenaltyOptionType = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<decimal?> _prepaymentPenaltyPercent;
        public decimal? PrepaymentPenaltyPercent { get => _prepaymentPenaltyPercent; set => _prepaymentPenaltyPercent = value; }
        private DirtyValue<int?> _termMonthsCount;
        public int? TermMonthsCount { get => _termMonthsCount; set => _termMonthsCount = value; }
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
                var dirty = _fullPrepaymentPenaltyOptionType.Dirty
                    || _id.Dirty
                    || _prepaymentPenaltyPercent.Dirty
                    || _termMonthsCount.Dirty
                    || _extensionData?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _fullPrepaymentPenaltyOptionType.Dirty = value;
                _id.Dirty = value;
                _prepaymentPenaltyPercent.Dirty = value;
                _termMonthsCount.Dirty = value;
                if (_extensionData != null) _extensionData.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get => Dirty; set => Dirty = value; }
    }
}