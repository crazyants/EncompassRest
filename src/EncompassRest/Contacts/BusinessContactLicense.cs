﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace EncompassRest.Contacts
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed class BusinessContactLicense : IDirty
    {
        private DirtyValue<string> _licenseAuthName;
        public string LicenseAuthName { get => _licenseAuthName; set => _licenseAuthName = value; }
        private DirtyValue<string> _licenseAuthType;
        public string LicenseAuthType { get => _licenseAuthType; set => _licenseAuthType = value; }
        private DirtyValue<DateTime?> _licenseIssueDate;
        public DateTime? LicenseIssueDate { get => _licenseIssueDate; set => _licenseIssueDate = value; }
        private DirtyValue<string> _licenseNumber;
        public string LicenseNumber { get => _licenseNumber; set => _licenseNumber = value; }
        private DirtyValue<string> _licenseStateCode;
        public string LicenseStateCode { get => _licenseStateCode; set => _licenseStateCode = value; }
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
                var dirty = _licenseAuthName.Dirty
                    || _licenseAuthType.Dirty
                    || _licenseIssueDate.Dirty
                    || _licenseNumber.Dirty
                    || _licenseStateCode.Dirty
                    || _extensionData?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _licenseAuthName.Dirty = value;
                _licenseAuthType.Dirty = value;
                _licenseIssueDate.Dirty = value;
                _licenseNumber.Dirty = value;
                _licenseStateCode.Dirty = value;
                if (_extensionData != null) _extensionData.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get => Dirty; set => Dirty = value; }
    }
}