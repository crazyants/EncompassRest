using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed partial class LockRequestBorrower : IDirty
    {
        private DirtyValue<string> _equifaxScore;
        public string EquifaxScore { get => _equifaxScore; set => _equifaxScore = value; }
        private DirtyValue<string> _experianScore;
        public string ExperianScore { get => _experianScore; set => _experianScore = value; }
        private DirtyValue<string> _firstName;
        public string FirstName { get => _firstName; set => _firstName = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<bool?> _isEmpty;
        public bool? IsEmpty { get => _isEmpty; set => _isEmpty = value; }
        private DirtyValue<string> _lastName;
        public string LastName { get => _lastName; set => _lastName = value; }
        private DirtyValue<int?> _lrbIndex;
        public int? LrbIndex { get => _lrbIndex; set => _lrbIndex = value; }
        private DirtyValue<string> _sSN;
        public string SSN { get => _sSN; set => _sSN = value; }
        private DirtyValue<string> _transUnionScore;
        public string TransUnionScore { get => _transUnionScore; set => _transUnionScore = value; }
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
                var dirty = _equifaxScore.Dirty
                    || _experianScore.Dirty
                    || _firstName.Dirty
                    || _id.Dirty
                    || _isEmpty.Dirty
                    || _lastName.Dirty
                    || _lrbIndex.Dirty
                    || _sSN.Dirty
                    || _transUnionScore.Dirty
                    || _extensionData?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _equifaxScore.Dirty = value;
                _experianScore.Dirty = value;
                _firstName.Dirty = value;
                _id.Dirty = value;
                _isEmpty.Dirty = value;
                _lastName.Dirty = value;
                _lrbIndex.Dirty = value;
                _sSN.Dirty = value;
                _transUnionScore.Dirty = value;
                if (_extensionData != null) _extensionData.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get => Dirty; set => Dirty = value; }
    }
}