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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateNFSFileShare operation.
    /// Updates a file share. 
    /// 
    ///  <note> 
    /// <para>
    /// To leave a file share field unchanged, set the corresponding input field to null.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class UpdateNFSFileShareRequest : AmazonStorageGatewayRequest
    {
        private string _defaultStorageClass;
        private string _fileShareARN;
        private bool? _kmsEncrypted;
        private string _kmsKey;
        private NFSFileShareDefaults _nfsFileShareDefaults;

        /// <summary>
        /// Gets and sets the property DefaultStorageClass. 
        /// <para>
        /// The default storage class for objects put into an Amazon S3 bucket by a file gateway.
        /// Possible values are S3_STANDARD or S3_STANDARD_IA. If this field is not populated,
        /// the default value S3_STANDARD is used. Optional.
        /// </para>
        /// </summary>
        public string DefaultStorageClass
        {
            get { return this._defaultStorageClass; }
            set { this._defaultStorageClass = value; }
        }

        // Check to see if DefaultStorageClass property is set
        internal bool IsSetDefaultStorageClass()
        {
            return this._defaultStorageClass != null;
        }

        /// <summary>
        /// Gets and sets the property FileShareARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the file share to be updated. 
        /// </para>
        /// </summary>
        public string FileShareARN
        {
            get { return this._fileShareARN; }
            set { this._fileShareARN = value; }
        }

        // Check to see if FileShareARN property is set
        internal bool IsSetFileShareARN()
        {
            return this._fileShareARN != null;
        }

        /// <summary>
        /// Gets and sets the property KMSEncrypted. 
        /// <para>
        /// True to use Amazon S3 server side encryption with your own AWS KMS key, or false to
        /// use a key managed by Amazon S3. Optional. 
        /// </para>
        /// </summary>
        public bool KMSEncrypted
        {
            get { return this._kmsEncrypted.GetValueOrDefault(); }
            set { this._kmsEncrypted = value; }
        }

        // Check to see if KMSEncrypted property is set
        internal bool IsSetKMSEncrypted()
        {
            return this._kmsEncrypted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KMSKey. 
        /// <para>
        /// The KMS key used for Amazon S3 server side encryption. This value can only be set
        /// when KmsEncrypted is true. Optional. 
        /// </para>
        /// </summary>
        public string KMSKey
        {
            get { return this._kmsKey; }
            set { this._kmsKey = value; }
        }

        // Check to see if KMSKey property is set
        internal bool IsSetKMSKey()
        {
            return this._kmsKey != null;
        }

        /// <summary>
        /// Gets and sets the property NFSFileShareDefaults. 
        /// <para>
        /// The default values for the file share. Optional.
        /// </para>
        /// </summary>
        public NFSFileShareDefaults NFSFileShareDefaults
        {
            get { return this._nfsFileShareDefaults; }
            set { this._nfsFileShareDefaults = value; }
        }

        // Check to see if NFSFileShareDefaults property is set
        internal bool IsSetNFSFileShareDefaults()
        {
            return this._nfsFileShareDefaults != null;
        }

    }
}