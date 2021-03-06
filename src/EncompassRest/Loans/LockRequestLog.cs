using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed partial class LockRequestLog : IDirty
    {
        private DirtyList<LogAlert> _alerts;
        public IList<LogAlert> Alerts { get => _alerts ?? (_alerts = new DirtyList<LogAlert>()); set => _alerts = new DirtyList<LogAlert>(value); }
        private DirtyValue<string> _alertsXml;
        public string AlertsXml { get => _alertsXml; set => _alertsXml = value; }
        private DirtyValue<DateTime?> _buySideExpirationDate;
        public DateTime? BuySideExpirationDate { get => _buySideExpirationDate; set => _buySideExpirationDate = value; }
        private DirtyValue<DateTime?> _buySideNewLockExtensionDate;
        public DateTime? BuySideNewLockExtensionDate { get => _buySideNewLockExtensionDate; set => _buySideNewLockExtensionDate = value; }
        private DirtyValue<int?> _buySideNumDayExtended;
        public int? BuySideNumDayExtended { get => _buySideNumDayExtended; set => _buySideNumDayExtended = value; }
        private DirtyValue<int?> _buySideNumDayLocked;
        public int? BuySideNumDayLocked { get => _buySideNumDayLocked; set => _buySideNumDayLocked = value; }
        private DirtyList<LogComment> _commentList;
        public IList<LogComment> CommentList { get => _commentList ?? (_commentList = new DirtyList<LogComment>()); set => _commentList = new DirtyList<LogComment>(value); }
        private DirtyValue<string> _commentListXml;
        public string CommentListXml { get => _commentListXml; set => _commentListXml = value; }
        private DirtyValue<string> _comments;
        public string Comments { get => _comments; set => _comments = value; }
        private DirtyValue<DateTime?> _dateUtc;
        public DateTime? DateUtc { get => _dateUtc; set => _dateUtc = value; }
        private DirtyValue<bool?> _fileAttachmentsMigrated;
        public bool? FileAttachmentsMigrated { get => _fileAttachmentsMigrated; set => _fileAttachmentsMigrated = value; }
        private DirtyValue<string> _guid;
        public string Guid { get => _guid; set => _guid = value; }
        private DirtyValue<bool?> _hideLogIndicator;
        public bool? HideLogIndicator { get => _hideLogIndicator; set => _hideLogIndicator = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _investorCommitment;
        public string InvestorCommitment { get => _investorCommitment; set => _investorCommitment = value; }
        private DirtyValue<bool?> _isFakeRequestIndicator;
        public bool? IsFakeRequestIndicator { get => _isFakeRequestIndicator; set => _isFakeRequestIndicator = value; }
        private DirtyValue<bool?> _isLockCancellationIndicator;
        public bool? IsLockCancellationIndicator { get => _isLockCancellationIndicator; set => _isLockCancellationIndicator = value; }
        private DirtyValue<bool?> _isLockExtensionIndicator;
        public bool? IsLockExtensionIndicator { get => _isLockExtensionIndicator; set => _isLockExtensionIndicator = value; }
        private DirtyValue<bool?> _isReLockIndicator;
        public bool? IsReLockIndicator { get => _isReLockIndicator; set => _isReLockIndicator = value; }
        private DirtyValue<bool?> _isSystemSpecificIndicator;
        public bool? IsSystemSpecificIndicator { get => _isSystemSpecificIndicator; set => _isSystemSpecificIndicator = value; }
        private DirtyValue<int?> _logRecordIndex;
        public int? LogRecordIndex { get => _logRecordIndex; set => _logRecordIndex = value; }
        private DirtyValue<int?> _numDayLocked;
        public int? NumDayLocked { get => _numDayLocked; set => _numDayLocked = value; }
        private DirtyValue<string> _parentLockGuid;
        public string ParentLockGuid { get => _parentLockGuid; set => _parentLockGuid = value; }
        private DirtyValue<string> _requestedBy;
        public string RequestedBy { get => _requestedBy; set => _requestedBy = value; }
        private DirtyValue<string> _requestedName;
        public string RequestedName { get => _requestedName; set => _requestedName = value; }
        private DirtyValue<string> _requestedStatus;
        public string RequestedStatus { get => _requestedStatus; set => _requestedStatus = value; }
        private DirtyValue<string> _sellSideDeliveredBy;
        public string SellSideDeliveredBy { get => _sellSideDeliveredBy; set => _sellSideDeliveredBy = value; }
        private DirtyValue<DateTime?> _sellSideDeliveryDate;
        public DateTime? SellSideDeliveryDate { get => _sellSideDeliveryDate; set => _sellSideDeliveryDate = value; }
        private DirtyValue<DateTime?> _sellSideExpirationDate;
        public DateTime? SellSideExpirationDate { get => _sellSideExpirationDate; set => _sellSideExpirationDate = value; }
        private DirtyValue<DateTime?> _sellSideNewLockExtensionDate;
        public DateTime? SellSideNewLockExtensionDate { get => _sellSideNewLockExtensionDate; set => _sellSideNewLockExtensionDate = value; }
        private DirtyValue<int?> _sellSideNumDayExtended;
        public int? SellSideNumDayExtended { get => _sellSideNumDayExtended; set => _sellSideNumDayExtended = value; }
        private DirtyValue<string> _snapshotXml;
        public string SnapshotXml { get => _snapshotXml; set => _snapshotXml = value; }
        private DirtyValue<string> _systemId;
        public string SystemId { get => _systemId; set => _systemId = value; }
        private DirtyValue<string> _timeRequested;
        public string TimeRequested { get => _timeRequested; set => _timeRequested = value; }
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
                var dirty = _alertsXml.Dirty
                    || _buySideExpirationDate.Dirty
                    || _buySideNewLockExtensionDate.Dirty
                    || _buySideNumDayExtended.Dirty
                    || _buySideNumDayLocked.Dirty
                    || _commentListXml.Dirty
                    || _comments.Dirty
                    || _dateUtc.Dirty
                    || _fileAttachmentsMigrated.Dirty
                    || _guid.Dirty
                    || _hideLogIndicator.Dirty
                    || _id.Dirty
                    || _investorCommitment.Dirty
                    || _isFakeRequestIndicator.Dirty
                    || _isLockCancellationIndicator.Dirty
                    || _isLockExtensionIndicator.Dirty
                    || _isReLockIndicator.Dirty
                    || _isSystemSpecificIndicator.Dirty
                    || _logRecordIndex.Dirty
                    || _numDayLocked.Dirty
                    || _parentLockGuid.Dirty
                    || _requestedBy.Dirty
                    || _requestedName.Dirty
                    || _requestedStatus.Dirty
                    || _sellSideDeliveredBy.Dirty
                    || _sellSideDeliveryDate.Dirty
                    || _sellSideExpirationDate.Dirty
                    || _sellSideNewLockExtensionDate.Dirty
                    || _sellSideNumDayExtended.Dirty
                    || _snapshotXml.Dirty
                    || _systemId.Dirty
                    || _timeRequested.Dirty
                    || _alerts?.Dirty == true
                    || _commentList?.Dirty == true
                    || _extensionData?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _alertsXml.Dirty = value;
                _buySideExpirationDate.Dirty = value;
                _buySideNewLockExtensionDate.Dirty = value;
                _buySideNumDayExtended.Dirty = value;
                _buySideNumDayLocked.Dirty = value;
                _commentListXml.Dirty = value;
                _comments.Dirty = value;
                _dateUtc.Dirty = value;
                _fileAttachmentsMigrated.Dirty = value;
                _guid.Dirty = value;
                _hideLogIndicator.Dirty = value;
                _id.Dirty = value;
                _investorCommitment.Dirty = value;
                _isFakeRequestIndicator.Dirty = value;
                _isLockCancellationIndicator.Dirty = value;
                _isLockExtensionIndicator.Dirty = value;
                _isReLockIndicator.Dirty = value;
                _isSystemSpecificIndicator.Dirty = value;
                _logRecordIndex.Dirty = value;
                _numDayLocked.Dirty = value;
                _parentLockGuid.Dirty = value;
                _requestedBy.Dirty = value;
                _requestedName.Dirty = value;
                _requestedStatus.Dirty = value;
                _sellSideDeliveredBy.Dirty = value;
                _sellSideDeliveryDate.Dirty = value;
                _sellSideExpirationDate.Dirty = value;
                _sellSideNewLockExtensionDate.Dirty = value;
                _sellSideNumDayExtended.Dirty = value;
                _snapshotXml.Dirty = value;
                _systemId.Dirty = value;
                _timeRequested.Dirty = value;
                if (_alerts != null) _alerts.Dirty = value;
                if (_commentList != null) _commentList.Dirty = value;
                if (_extensionData != null) _extensionData.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get => Dirty; set => Dirty = value; }
    }
}