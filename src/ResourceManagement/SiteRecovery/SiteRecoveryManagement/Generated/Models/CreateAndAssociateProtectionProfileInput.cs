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
using System.Linq;
using Microsoft.Azure.Management.SiteRecovery.Models;

namespace Microsoft.Azure.Management.SiteRecovery.Models
{
    /// <summary>
    /// The CreateAndAssociateProtectionProfileInput object.
    /// </summary>
    public partial class CreateAndAssociateProtectionProfileInput
    {
        private ProtectionProfileAssociationInput _associationInput;
        
        /// <summary>
        /// Required. the ProtectionProfileAssociationInput.
        /// </summary>
        public ProtectionProfileAssociationInput AssociationInput
        {
            get { return this._associationInput; }
            set { this._associationInput = value; }
        }
        
        private CreateProtectionProfileInput _protectionProfileInput;
        
        /// <summary>
        /// Optional. the the CreateProtectionProfileInput.
        /// </summary>
        public CreateProtectionProfileInput ProtectionProfileInput
        {
            get { return this._protectionProfileInput; }
            set { this._protectionProfileInput = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// CreateAndAssociateProtectionProfileInput class.
        /// </summary>
        public CreateAndAssociateProtectionProfileInput()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// CreateAndAssociateProtectionProfileInput class with required
        /// arguments.
        /// </summary>
        public CreateAndAssociateProtectionProfileInput(ProtectionProfileAssociationInput associationInput)
            : this()
        {
            if (associationInput == null)
            {
                throw new ArgumentNullException("associationInput");
            }
            this.AssociationInput = associationInput;
        }
    }
}
