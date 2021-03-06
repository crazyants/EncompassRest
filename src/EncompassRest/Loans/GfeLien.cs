using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed partial class GfeLien : IDirty
    {
        private DirtyValue<decimal?> _amountOwing;
        public decimal? AmountOwing { get => _amountOwing; set => _amountOwing = value; }
        private DirtyValue<int?> _gfeLienIndex;
        public int? GfeLienIndex { get => _gfeLienIndex; set => _gfeLienIndex = value; }
        private DirtyValue<StringEnumValue<GfeLienType>> _gfeLienType;
        public StringEnumValue<GfeLienType> GfeLienType { get => _gfeLienType; set => _gfeLienType = value; }
        private DirtyValue<string> _holderName;
        public string HolderName { get => _holderName; set => _holderName = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _priority;
        public string Priority { get => _priority; set => _priority = value; }
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
                var dirty = _amountOwing.Dirty
                    || _gfeLienIndex.Dirty
                    || _gfeLienType.Dirty
                    || _holderName.Dirty
                    || _id.Dirty
                    || _priority.Dirty
                    || _extensionData?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _amountOwing.Dirty = value;
                _gfeLienIndex.Dirty = value;
                _gfeLienType.Dirty = value;
                _holderName.Dirty = value;
                _id.Dirty = value;
                _priority.Dirty = value;
                if (_extensionData != null) _extensionData.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get => Dirty; set => Dirty = value; }
    }
}