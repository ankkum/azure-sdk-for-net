// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.WindowsAzure.Management.StorSimple.Models;

namespace Microsoft.WindowsAzure.Management.StorSimple.Models
{
    /// <summary>
    /// This class respresents the status of each backup being migrated
    /// </summary>
    public partial class MigrationBackupSet
    {
        private string _backupPolicyName;
        
        /// <summary>
        /// Required. Gets or sets the name of the policy (virtual disk group)
        /// corresponding to the backup
        /// </summary>
        public string BackupPolicyName
        {
            get { return this._backupPolicyName; }
            set { this._backupPolicyName = value; }
        }
        
        private DateTime _creationTime;
        
        /// <summary>
        /// Required. Gets or sets the backup creation time
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }
        
        private IList<MigrationBackupElement> _elements;
        
        /// <summary>
        /// Required. Gets or sets the backup's source volume details
        /// </summary>
        public IList<MigrationBackupElement> Elements
        {
            get { return this._elements; }
            set { this._elements = value; }
        }
        
        private HcsMessageInfo _message;
        
        /// <summary>
        /// Required. Gets or sets the backup level message and recommendation,
        /// usually updated during failures
        /// </summary>
        public HcsMessageInfo Message
        {
            get { return this._message; }
            set { this._message = value; }
        }
        
        private BackupStatus _status;
        
        /// <summary>
        /// Required. Gets or sets the status of the backup migrated
        /// </summary>
        public BackupStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the MigrationBackupSet class.
        /// </summary>
        public MigrationBackupSet()
        {
            this.Elements = new LazyList<MigrationBackupElement>();
        }
    }
}