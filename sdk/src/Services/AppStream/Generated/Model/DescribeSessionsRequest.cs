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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppStream.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeSessions operation.
    /// Describes the streaming sessions for a stack and fleet. If a user ID is provided,
    /// this operation returns streaming sessions for only that user. This operation returns
    /// a paginated list of results; use the <code>nextToken</code> to get the next page.
    /// </summary>
    public partial class DescribeSessionsRequest : AmazonAppStreamRequest
    {
        private string _fleetName;
        private int? _limit;
        private string _nextToken;
        private string _stackName;
        private string _userId;

        /// <summary>
        /// Gets and sets the property FleetName. 
        /// <para>
        /// The name of the fleet for which to list sessions.
        /// </para>
        /// </summary>
        public string FleetName
        {
            get { return this._fleetName; }
            set { this._fleetName = value; }
        }

        // Check to see if FleetName property is set
        internal bool IsSetFleetName()
        {
            return this._fleetName != null;
        }

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The size of each page of results. The default value is 20 and the maximum supported
        /// value is 50.
        /// </para>
        /// </summary>
        public int Limit
        {
            get { return this._limit.GetValueOrDefault(); }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The next token to iterate the list. If the request is for the first page, this value
        /// should be null.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property StackName. 
        /// <para>
        /// The name of the stack for which to list sessions.
        /// </para>
        /// </summary>
        public string StackName
        {
            get { return this._stackName; }
            set { this._stackName = value; }
        }

        // Check to see if StackName property is set
        internal bool IsSetStackName()
        {
            return this._stackName != null;
        }

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The user for whom to list sessions. Use null to describe all the sessions for the
        /// stack and fleet.
        /// </para>
        /// </summary>
        public string UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        // Check to see if UserId property is set
        internal bool IsSetUserId()
        {
            return this._userId != null;
        }

    }
}