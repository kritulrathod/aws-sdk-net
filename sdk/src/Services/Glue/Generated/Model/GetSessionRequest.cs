/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the GetSession operation.
    /// Retrieves the session.
    /// </summary>
    public partial class GetSessionRequest : AmazonGlueRequest
    {
        private string _id;
        private string _requestOrigin;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the session. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property RequestOrigin. 
        /// <para>
        /// The origin of the request. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string RequestOrigin
        {
            get { return this._requestOrigin; }
            set { this._requestOrigin = value; }
        }

        // Check to see if RequestOrigin property is set
        internal bool IsSetRequestOrigin()
        {
            return this._requestOrigin != null;
        }

    }
}