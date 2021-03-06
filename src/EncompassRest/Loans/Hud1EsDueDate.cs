using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed partial class Hud1EsDueDate : IDirty
    {
        private DirtyValue<DateTime?> _annualFee;
        public DateTime? AnnualFee { get => _annualFee; set => _annualFee = value; }
        private DirtyValue<DateTime?> _floodInsDisb;
        public DateTime? FloodInsDisb { get => _floodInsDisb; set => _floodInsDisb = value; }
        private DirtyValue<DateTime?> _hazInsDisb;
        public DateTime? HazInsDisb { get => _hazInsDisb; set => _hazInsDisb = value; }
        private DirtyValue<int?> _hud1EsDueDateIndex;
        public int? Hud1EsDueDateIndex { get => _hud1EsDueDateIndex; set => _hud1EsDueDateIndex = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<DateTime?> _mtgInsDisb;
        public DateTime? MtgInsDisb { get => _mtgInsDisb; set => _mtgInsDisb = value; }
        private DirtyValue<DateTime?> _schoolTaxes;
        public DateTime? SchoolTaxes { get => _schoolTaxes; set => _schoolTaxes = value; }
        private DirtyValue<DateTime?> _taxDisb;
        public DateTime? TaxDisb { get => _taxDisb; set => _taxDisb = value; }
        private DirtyValue<DateTime?> _userDefined1;
        public DateTime? UserDefined1 { get => _userDefined1; set => _userDefined1 = value; }
        private DirtyValue<DateTime?> _userDefined2;
        public DateTime? UserDefined2 { get => _userDefined2; set => _userDefined2 = value; }
        private DirtyValue<DateTime?> _userDefined3;
        public DateTime? UserDefined3 { get => _userDefined3; set => _userDefined3 = value; }
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
                var dirty = _annualFee.Dirty
                    || _floodInsDisb.Dirty
                    || _hazInsDisb.Dirty
                    || _hud1EsDueDateIndex.Dirty
                    || _id.Dirty
                    || _mtgInsDisb.Dirty
                    || _schoolTaxes.Dirty
                    || _taxDisb.Dirty
                    || _userDefined1.Dirty
                    || _userDefined2.Dirty
                    || _userDefined3.Dirty
                    || _extensionData?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _annualFee.Dirty = value;
                _floodInsDisb.Dirty = value;
                _hazInsDisb.Dirty = value;
                _hud1EsDueDateIndex.Dirty = value;
                _id.Dirty = value;
                _mtgInsDisb.Dirty = value;
                _schoolTaxes.Dirty = value;
                _taxDisb.Dirty = value;
                _userDefined1.Dirty = value;
                _userDefined2.Dirty = value;
                _userDefined3.Dirty = value;
                if (_extensionData != null) _extensionData.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get => Dirty; set => Dirty = value; }
    }
}