﻿using System.Collections.Generic;
using EncompassRest.Utilities;
using EnumsNET;
using Newtonsoft.Json;

namespace EncompassRest.Contacts
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public abstract class Contact : IDirty
    {
        internal abstract string ApiPath { get; }
        [JsonIgnore]
        public EncompassRestClient Client { get; private set; }

        [JsonIgnore]
        public ContactNotes Notes { get; private set; }

        public Contact(EncompassRestClient client, string contactId)
        {
            Preconditions.NotNull(client, nameof(client));
            Preconditions.NotNullOrEmpty(contactId, nameof(contactId));

            Id = contactId;
            Initialize(client);
        }

        [JsonConstructor]
        public Contact()
        {
        }

        internal void Initialize(EncompassRestClient client)
        {
            Client = client;
            Notes = new ContactNotes(client, ApiPath, Id);
        }
        private DirtyValue<string> _firstName;
        public string FirstName { get => _firstName; set => _firstName = value; }
        private DirtyValue<string> _lastName;
        public string LastName { get => _lastName; set => _lastName = value; }
        private DirtyValue<string> _ownerId;
        public string OwnerId { get => _ownerId; set => _ownerId = value; }
        private DirtyValue<ContactAccessLevel?> _accessLevel;
        [EnumFormat(EnumFormat.DecimalValue)]
        public ContactAccessLevel? AccessLevel { get => _accessLevel; set => _accessLevel = value; }
        private ContactAddress _currentMailingAddress;
        public ContactAddress CurrentMailingAddress { get => _currentMailingAddress ?? (_currentMailingAddress = new ContactAddress()); set => _currentMailingAddress = value; }
        private DirtyValue<string> _businessWebUrl;
        public string BusinessWebUrl { get => _businessWebUrl; set => _businessWebUrl = value; }
        private DirtyValue<string> _jobTitle;
        public string JobTitle { get => _jobTitle; set => _jobTitle = value; }
        private DirtyValue<string> _workPhone;
        public string WorkPhone { get => _workPhone; set => _workPhone = value; }
        private DirtyValue<string> _homePhone;
        public string HomePhone { get => _homePhone; set => _homePhone = value; }
        private DirtyValue<string> _mobilePhone;
        public string MobilePhone { get => _mobilePhone; set => _mobilePhone = value; }
        private DirtyValue<string> _faxNumber;
        public string FaxNumber { get => _faxNumber; set => _faxNumber = value; }
        private DirtyValue<string> _personalEmail;
        public string PersonalEmail { get => _personalEmail; set => _personalEmail = value; }
        private DirtyValue<string> _businessEmail;
        public string BusinessEmail { get => _businessEmail; set => _businessEmail = value; }
        private DirtyValue<string> _salutation;
        public string Salutation { get => _salutation; set => _salutation = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyDictionary<string, object> _extensionData;
        public IDictionary<string, object> ExtensionData { get => _extensionData ?? (_extensionData = new DirtyDictionary<string, object>()); set => _extensionData = new DirtyDictionary<string, object>(value); }
        internal bool Dirty
        {
            get
            {
                var dirty = _firstName.Dirty
                    || _lastName.Dirty
                    || _ownerId.Dirty
                    || _accessLevel.Dirty
                    || _currentMailingAddress?.Dirty == true
                    || _businessWebUrl.Dirty
                    || _jobTitle.Dirty
                    || _workPhone.Dirty
                    || _homePhone.Dirty
                    || _mobilePhone.Dirty
                    || _faxNumber.Dirty
                    || _personalEmail.Dirty
                    || _businessEmail.Dirty
                    || _salutation.Dirty
                    || _id.Dirty
                    || _extensionData?.Dirty == true;
                return dirty;
            }
            set
            {
                _firstName.Dirty = value;
                _lastName.Dirty = value;
                _ownerId.Dirty = value;
                _accessLevel.Dirty = value;
                if (_currentMailingAddress != null) _currentMailingAddress.Dirty = value;
                _businessWebUrl.Dirty = value;
                _jobTitle.Dirty = value;
                _workPhone.Dirty = value;
                _homePhone.Dirty = value;
                _mobilePhone.Dirty = value;
                _faxNumber.Dirty = value;
                _personalEmail.Dirty = value;
                _businessEmail.Dirty = value;
                _salutation.Dirty = value;
                _id.Dirty = value;
                if (_extensionData != null) _extensionData.Dirty = value;
            }
        }
        bool IDirty.Dirty { get => Dirty; set => Dirty = value; }
    }
}
