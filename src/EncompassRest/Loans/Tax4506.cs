using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed partial class Tax4506 : IDirty
    {
        private DirtyValue<bool?> _accountTranscript;
        public bool? AccountTranscript { get => _accountTranscript; set => _accountTranscript = value; }
        private DirtyValue<string> _address;
        public string Address { get => _address; set => _address = value; }
        private DirtyValue<string> _city;
        public string City { get => _city; set => _city = value; }
        private DirtyValue<decimal?> _costForEachPeriod;
        public decimal? CostForEachPeriod { get => _costForEachPeriod; set => _costForEachPeriod = value; }
        private DirtyValue<string> _currentFirst;
        public string CurrentFirst { get => _currentFirst; set => _currentFirst = value; }
        private DirtyValue<string> _currentLast;
        public string CurrentLast { get => _currentLast; set => _currentLast = value; }
        private DirtyValue<string> _first;
        public string First { get => _first; set => _first = value; }
        private DirtyValue<bool?> _formsSeriesTranscript;
        public bool? FormsSeriesTranscript { get => _formsSeriesTranscript; set => _formsSeriesTranscript = value; }
        private DirtyValue<string> _historyId;
        public string HistoryId { get => _historyId; set => _historyId = value; }
        private DirtyValue<bool?> _historyIndicator;
        public bool? HistoryIndicator { get => _historyIndicator; set => _historyIndicator = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<bool?> _ifTaxRecordNotFound;
        public bool? IfTaxRecordNotFound { get => _ifTaxRecordNotFound; set => _ifTaxRecordNotFound = value; }
        private DirtyValue<string> _last;
        public string Last { get => _last; set => _last = value; }
        private DirtyValue<DateTime?> _lastUpdatedDate;
        public DateTime? LastUpdatedDate { get => _lastUpdatedDate; set => _lastUpdatedDate = value; }
        private DirtyValue<int?> _lastUpdatedHistory;
        public int? LastUpdatedHistory { get => _lastUpdatedHistory; set => _lastUpdatedHistory = value; }
        private DirtyValue<string> _lastUpdatedTime;
        public string LastUpdatedTime { get => _lastUpdatedTime; set => _lastUpdatedTime = value; }
        private DirtyValue<bool?> _notifiedIrsIdentityTheftIndicator;
        public bool? NotifiedIrsIdentityTheftIndicator { get => _notifiedIrsIdentityTheftIndicator; set => _notifiedIrsIdentityTheftIndicator = value; }
        private DirtyValue<int?> _numberOfPeriods;
        public int? NumberOfPeriods { get => _numberOfPeriods; set => _numberOfPeriods = value; }
        private DirtyValue<StringEnumValue<Person>> _person;
        public StringEnumValue<Person> Person { get => _person; set => _person = value; }
        private DirtyValue<bool?> _recordOfAccount;
        public bool? RecordOfAccount { get => _recordOfAccount; set => _recordOfAccount = value; }
        private DirtyValue<string> _requestorPhoneNumber;
        public string RequestorPhoneNumber { get => _requestorPhoneNumber; set => _requestorPhoneNumber = value; }
        private DirtyValue<StringEnumValue<RequestorTitle>> _requestorTitle;
        public StringEnumValue<RequestorTitle> RequestorTitle { get => _requestorTitle; set => _requestorTitle = value; }
        private DirtyValue<DateTime?> _requestYear1;
        public DateTime? RequestYear1 { get => _requestYear1; set => _requestYear1 = value; }
        private DirtyValue<DateTime?> _requestYear2;
        public DateTime? RequestYear2 { get => _requestYear2; set => _requestYear2 = value; }
        private DirtyValue<DateTime?> _requestYear3;
        public DateTime? RequestYear3 { get => _requestYear3; set => _requestYear3 = value; }
        private DirtyValue<DateTime?> _requestYear4;
        public DateTime? RequestYear4 { get => _requestYear4; set => _requestYear4 = value; }
        private DirtyValue<DateTime?> _requestYear5;
        public DateTime? RequestYear5 { get => _requestYear5; set => _requestYear5 = value; }
        private DirtyValue<DateTime?> _requestYear6;
        public DateTime? RequestYear6 { get => _requestYear6; set => _requestYear6 = value; }
        private DirtyValue<DateTime?> _requestYear7;
        public DateTime? RequestYear7 { get => _requestYear7; set => _requestYear7 = value; }
        private DirtyValue<DateTime?> _requestYear8;
        public DateTime? RequestYear8 { get => _requestYear8; set => _requestYear8 = value; }
        private DirtyValue<string> _returnAddress;
        public string ReturnAddress { get => _returnAddress; set => _returnAddress = value; }
        private DirtyValue<string> _returnCity;
        public string ReturnCity { get => _returnCity; set => _returnCity = value; }
        private DirtyValue<string> _returnState;
        public string ReturnState { get => _returnState; set => _returnState = value; }
        private DirtyValue<bool?> _returnTranscript;
        public bool? ReturnTranscript { get => _returnTranscript; set => _returnTranscript = value; }
        private DirtyValue<string> _returnZip;
        public string ReturnZip { get => _returnZip; set => _returnZip = value; }
        private DirtyValue<string> _selectedRecordNumber;
        public string SelectedRecordNumber { get => _selectedRecordNumber; set => _selectedRecordNumber = value; }
        private DirtyValue<string> _sendAddress;
        public string SendAddress { get => _sendAddress; set => _sendAddress = value; }
        private DirtyValue<string> _sendCity;
        public string SendCity { get => _sendCity; set => _sendCity = value; }
        private DirtyValue<string> _sendFirst;
        public string SendFirst { get => _sendFirst; set => _sendFirst = value; }
        private DirtyValue<string> _sendLast;
        public string SendLast { get => _sendLast; set => _sendLast = value; }
        private DirtyValue<string> _sendPhone;
        public string SendPhone { get => _sendPhone; set => _sendPhone = value; }
        private DirtyValue<string> _sendState;
        public string SendState { get => _sendState; set => _sendState = value; }
        private DirtyValue<string> _sendZip;
        public string SendZip { get => _sendZip; set => _sendZip = value; }
        private DirtyValue<bool?> _signatoryAttestation;
        public bool? SignatoryAttestation { get => _signatoryAttestation; set => _signatoryAttestation = value; }
        private DirtyValue<bool?> _signatoryAttestationT;
        public bool? SignatoryAttestationT { get => _signatoryAttestationT; set => _signatoryAttestationT = value; }
        private DirtyValue<string> _spouseFirst;
        public string SpouseFirst { get => _spouseFirst; set => _spouseFirst = value; }
        private DirtyValue<string> _spouseLast;
        public string SpouseLast { get => _spouseLast; set => _spouseLast = value; }
        private DirtyValue<string> _spouseSSN;
        public string SpouseSSN { get => _spouseSSN; set => _spouseSSN = value; }
        private DirtyValue<bool?> _spouseUseEIN;
        public bool? SpouseUseEIN { get => _spouseUseEIN; set => _spouseUseEIN = value; }
        private DirtyValue<string> _sSN;
        public string SSN { get => _sSN; set => _sSN = value; }
        private DirtyValue<string> _state;
        public string State { get => _state; set => _state = value; }
        private DirtyValue<int?> _tax4506Index;
        public int? Tax4506Index { get => _tax4506Index; set => _tax4506Index = value; }
        private DirtyValue<bool?> _tax4506TIndicator;
        public bool? Tax4506TIndicator { get => _tax4506TIndicator; set => _tax4506TIndicator = value; }
        private DirtyValue<string> _taxFormNumber;
        public string TaxFormNumber { get => _taxFormNumber; set => _taxFormNumber = value; }
        private DirtyValue<bool?> _theseCopiesMustBeCertified;
        public bool? TheseCopiesMustBeCertified { get => _theseCopiesMustBeCertified; set => _theseCopiesMustBeCertified = value; }
        private DirtyValue<decimal?> _totalCost;
        public decimal? TotalCost { get => _totalCost; set => _totalCost = value; }
        private DirtyValue<bool?> _useEIN;
        public bool? UseEIN { get => _useEIN; set => _useEIN = value; }
        private DirtyValue<bool?> _useWellsFargoRules;
        public bool? UseWellsFargoRules { get => _useWellsFargoRules; set => _useWellsFargoRules = value; }
        private DirtyValue<bool?> _verificationOfNonfiling;
        public bool? VerificationOfNonfiling { get => _verificationOfNonfiling; set => _verificationOfNonfiling = value; }
        private DirtyValue<string> _zip;
        public string Zip { get => _zip; set => _zip = value; }
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
                var dirty = _accountTranscript.Dirty
                    || _address.Dirty
                    || _city.Dirty
                    || _costForEachPeriod.Dirty
                    || _currentFirst.Dirty
                    || _currentLast.Dirty
                    || _first.Dirty
                    || _formsSeriesTranscript.Dirty
                    || _historyId.Dirty
                    || _historyIndicator.Dirty
                    || _id.Dirty
                    || _ifTaxRecordNotFound.Dirty
                    || _last.Dirty
                    || _lastUpdatedDate.Dirty
                    || _lastUpdatedHistory.Dirty
                    || _lastUpdatedTime.Dirty
                    || _notifiedIrsIdentityTheftIndicator.Dirty
                    || _numberOfPeriods.Dirty
                    || _person.Dirty
                    || _recordOfAccount.Dirty
                    || _requestorPhoneNumber.Dirty
                    || _requestorTitle.Dirty
                    || _requestYear1.Dirty
                    || _requestYear2.Dirty
                    || _requestYear3.Dirty
                    || _requestYear4.Dirty
                    || _requestYear5.Dirty
                    || _requestYear6.Dirty
                    || _requestYear7.Dirty
                    || _requestYear8.Dirty
                    || _returnAddress.Dirty
                    || _returnCity.Dirty
                    || _returnState.Dirty
                    || _returnTranscript.Dirty
                    || _returnZip.Dirty
                    || _selectedRecordNumber.Dirty
                    || _sendAddress.Dirty
                    || _sendCity.Dirty
                    || _sendFirst.Dirty
                    || _sendLast.Dirty
                    || _sendPhone.Dirty
                    || _sendState.Dirty
                    || _sendZip.Dirty
                    || _signatoryAttestation.Dirty
                    || _signatoryAttestationT.Dirty
                    || _spouseFirst.Dirty
                    || _spouseLast.Dirty
                    || _spouseSSN.Dirty
                    || _spouseUseEIN.Dirty
                    || _sSN.Dirty
                    || _state.Dirty
                    || _tax4506Index.Dirty
                    || _tax4506TIndicator.Dirty
                    || _taxFormNumber.Dirty
                    || _theseCopiesMustBeCertified.Dirty
                    || _totalCost.Dirty
                    || _useEIN.Dirty
                    || _useWellsFargoRules.Dirty
                    || _verificationOfNonfiling.Dirty
                    || _zip.Dirty
                    || _extensionData?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _accountTranscript.Dirty = value;
                _address.Dirty = value;
                _city.Dirty = value;
                _costForEachPeriod.Dirty = value;
                _currentFirst.Dirty = value;
                _currentLast.Dirty = value;
                _first.Dirty = value;
                _formsSeriesTranscript.Dirty = value;
                _historyId.Dirty = value;
                _historyIndicator.Dirty = value;
                _id.Dirty = value;
                _ifTaxRecordNotFound.Dirty = value;
                _last.Dirty = value;
                _lastUpdatedDate.Dirty = value;
                _lastUpdatedHistory.Dirty = value;
                _lastUpdatedTime.Dirty = value;
                _notifiedIrsIdentityTheftIndicator.Dirty = value;
                _numberOfPeriods.Dirty = value;
                _person.Dirty = value;
                _recordOfAccount.Dirty = value;
                _requestorPhoneNumber.Dirty = value;
                _requestorTitle.Dirty = value;
                _requestYear1.Dirty = value;
                _requestYear2.Dirty = value;
                _requestYear3.Dirty = value;
                _requestYear4.Dirty = value;
                _requestYear5.Dirty = value;
                _requestYear6.Dirty = value;
                _requestYear7.Dirty = value;
                _requestYear8.Dirty = value;
                _returnAddress.Dirty = value;
                _returnCity.Dirty = value;
                _returnState.Dirty = value;
                _returnTranscript.Dirty = value;
                _returnZip.Dirty = value;
                _selectedRecordNumber.Dirty = value;
                _sendAddress.Dirty = value;
                _sendCity.Dirty = value;
                _sendFirst.Dirty = value;
                _sendLast.Dirty = value;
                _sendPhone.Dirty = value;
                _sendState.Dirty = value;
                _sendZip.Dirty = value;
                _signatoryAttestation.Dirty = value;
                _signatoryAttestationT.Dirty = value;
                _spouseFirst.Dirty = value;
                _spouseLast.Dirty = value;
                _spouseSSN.Dirty = value;
                _spouseUseEIN.Dirty = value;
                _sSN.Dirty = value;
                _state.Dirty = value;
                _tax4506Index.Dirty = value;
                _tax4506TIndicator.Dirty = value;
                _taxFormNumber.Dirty = value;
                _theseCopiesMustBeCertified.Dirty = value;
                _totalCost.Dirty = value;
                _useEIN.Dirty = value;
                _useWellsFargoRules.Dirty = value;
                _verificationOfNonfiling.Dirty = value;
                _zip.Dirty = value;
                if (_extensionData != null) _extensionData.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get => Dirty; set => Dirty = value; }
    }
}