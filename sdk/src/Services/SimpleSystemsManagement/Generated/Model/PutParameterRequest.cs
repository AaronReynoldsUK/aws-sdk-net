/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the PutParameter operation.
    /// Add one or more paramaters to the system.
    /// </summary>
    public partial class PutParameterRequest : AmazonSimpleSystemsManagementRequest
    {
        private string _description;
        private string _keyId;
        private string _name;
        private bool? _overwrite;
        private ParameterType _type;
        private string _value;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Information about the parameter that you want to add to the system
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property KeyId. 
        /// <para>
        /// The parameter key ID that you want to add to the system.
        /// </para>
        /// </summary>
        public string KeyId
        {
            get { return this._keyId; }
            set { this._keyId = value; }
        }

        // Check to see if KeyId property is set
        internal bool IsSetKeyId()
        {
            return this._keyId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the parameter that you want to add to the system.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Overwrite. 
        /// <para>
        /// Overwrite an existing parameter.
        /// </para>
        /// </summary>
        public bool Overwrite
        {
            get { return this._overwrite.GetValueOrDefault(); }
            set { this._overwrite = value; }
        }

        // Check to see if Overwrite property is set
        internal bool IsSetOverwrite()
        {
            return this._overwrite.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of parameter that you want to add to the system.
        /// </para>
        /// </summary>
        public ParameterType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The parameter value that you want to add to the system.
        /// </para>
        /// </summary>
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}