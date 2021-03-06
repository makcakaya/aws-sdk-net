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
 * Do not modify this file. This file is generated from the resource-groups-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ResourceGroups.Model
{
    /// <summary>
    /// Container for the parameters to the GetGroupConfiguration operation.
    /// Returns the service configuration associated with the specified resource group. AWS
    /// Resource Groups supports configurations for the following resource group types:
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <code>AWS::EC2::CapacityReservationPool</code> - Amazon EC2 capacity reservation
    /// pools. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/capacity-reservations-using.html#create-cr-group">Working
    /// with capacity reservation groups</a> in the <i>EC2 Users Guide</i>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class GetGroupConfigurationRequest : AmazonResourceGroupsRequest
    {
        private string _group;

        /// <summary>
        /// Gets and sets the property Group. 
        /// <para>
        /// The name or the ARN of the resource group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1600)]
        public string Group
        {
            get { return this._group; }
            set { this._group = value; }
        }

        // Check to see if Group property is set
        internal bool IsSetGroup()
        {
            return this._group != null;
        }

    }
}