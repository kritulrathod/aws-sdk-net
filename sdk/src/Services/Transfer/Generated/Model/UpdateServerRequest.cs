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
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Transfer.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateServer operation.
    /// Updates the file transfer protocol-enabled server's properties after that server has
    /// been created.
    /// 
    ///  
    /// <para>
    /// The <code>UpdateServer</code> call returns the <code>ServerId</code> of the server
    /// you updated.
    /// </para>
    /// </summary>
    public partial class UpdateServerRequest : AmazonTransferRequest
    {
        private string _certificate;
        private EndpointDetails _endpointDetails;
        private EndpointType _endpointType;
        private string _hostKey;
        private IdentityProviderDetails _identityProviderDetails;
        private string _loggingRole;
        private ProtocolDetails _protocolDetails;
        private List<string> _protocols = new List<string>();
        private string _securityPolicyName;
        private string _serverId;
        private WorkflowDetails _workflowDetails;

        /// <summary>
        /// Gets and sets the property Certificate. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Web ServicesCertificate Manager (ACM)
        /// certificate. Required when <code>Protocols</code> is set to <code>FTPS</code>.
        /// </para>
        ///  
        /// <para>
        /// To request a new public certificate, see <a href="https://docs.aws.amazon.com/acm/latest/userguide/gs-acm-request-public.html">Request
        /// a public certificate</a> in the <i> Amazon Web ServicesCertificate Manager User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// To import an existing certificate into ACM, see <a href="https://docs.aws.amazon.com/acm/latest/userguide/import-certificate.html">Importing
        /// certificates into ACM</a> in the <i> Amazon Web ServicesCertificate Manager User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// To request a private certificate to use FTPS through private IP addresses, see <a
        /// href="https://docs.aws.amazon.com/acm/latest/userguide/gs-acm-request-private.html">Request
        /// a private certificate</a> in the <i> Amazon Web ServicesCertificate Manager User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Certificates with the following cryptographic algorithms and key sizes are supported:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// 2048-bit RSA (RSA_2048)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 4096-bit RSA (RSA_4096)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Elliptic Prime Curve 256 bit (EC_prime256v1)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Elliptic Prime Curve 384 bit (EC_secp384r1)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Elliptic Prime Curve 521 bit (EC_secp521r1)
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// The certificate must be a valid SSL/TLS X.509 version 3 certificate with FQDN or IP
        /// address specified and information about the issuer.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Max=1600)]
        public string Certificate
        {
            get { return this._certificate; }
            set { this._certificate = value; }
        }

        // Check to see if Certificate property is set
        internal bool IsSetCertificate()
        {
            return this._certificate != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointDetails. 
        /// <para>
        /// The virtual private cloud (VPC) endpoint settings that are configured for your server.
        /// When you host your endpoint within your VPC, you can make it accessible only to resources
        /// within your VPC, or you can attach Elastic IP addresses and make it accessible to
        /// clients over the internet. Your VPC's default security groups are automatically assigned
        /// to your endpoint.
        /// </para>
        /// </summary>
        public EndpointDetails EndpointDetails
        {
            get { return this._endpointDetails; }
            set { this._endpointDetails = value; }
        }

        // Check to see if EndpointDetails property is set
        internal bool IsSetEndpointDetails()
        {
            return this._endpointDetails != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointType. 
        /// <para>
        /// The type of endpoint that you want your server to use. You can choose to make your
        /// server's endpoint publicly accessible (PUBLIC) or host it inside your VPC. With an
        /// endpoint that is hosted in a VPC, you can restrict access to your server and resources
        /// only within your VPC or choose to make it internet facing by attaching Elastic IP
        /// addresses directly to it.
        /// </para>
        ///  <note> 
        /// <para>
        ///  After May 19, 2021, you won't be able to create a server using <code>EndpointType=VPC_ENDPOINT</code>
        /// in your Amazon Web Servicesaccount if your account hasn't already done so before May
        /// 19, 2021. If you have already created servers with <code>EndpointType=VPC_ENDPOINT</code>
        /// in your Amazon Web Servicesaccount on or before May 19, 2021, you will not be affected.
        /// After this date, use <code>EndpointType</code>=<code>VPC</code>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see https://docs.aws.amazon.com/transfer/latest/userguide/create-server-in-vpc.html#deprecate-vpc-endpoint.
        /// </para>
        ///  
        /// <para>
        /// It is recommended that you use <code>VPC</code> as the <code>EndpointType</code>.
        /// With this endpoint type, you have the option to directly associate up to three Elastic
        /// IPv4 addresses (BYO IP included) with your server's endpoint and use VPC security
        /// groups to restrict traffic by the client's public IP address. This is not possible
        /// with <code>EndpointType</code> set to <code>VPC_ENDPOINT</code>.
        /// </para>
        ///  </note>
        /// </summary>
        public EndpointType EndpointType
        {
            get { return this._endpointType; }
            set { this._endpointType = value; }
        }

        // Check to see if EndpointType property is set
        internal bool IsSetEndpointType()
        {
            return this._endpointType != null;
        }

        /// <summary>
        /// Gets and sets the property HostKey. 
        /// <para>
        /// The RSA private key as generated by <code>ssh-keygen -N "" -m PEM -f my-new-server-key</code>.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you aren't planning to migrate existing users from an existing server to a new
        /// server, don't update the host key. Accidentally changing a server's host key can be
        /// disruptive.
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/transfer/latest/userguide/edit-server-config.html#configuring-servers-change-host-key">Change
        /// the host key for your SFTP-enabled server</a> in the <i>Amazon Web ServicesTransfer
        /// Family User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=4096)]
        public string HostKey
        {
            get { return this._hostKey; }
            set { this._hostKey = value; }
        }

        // Check to see if HostKey property is set
        internal bool IsSetHostKey()
        {
            return this._hostKey != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityProviderDetails. 
        /// <para>
        /// An array containing all of the information required to call a customer's authentication
        /// API method.
        /// </para>
        /// </summary>
        public IdentityProviderDetails IdentityProviderDetails
        {
            get { return this._identityProviderDetails; }
            set { this._identityProviderDetails = value; }
        }

        // Check to see if IdentityProviderDetails property is set
        internal bool IsSetIdentityProviderDetails()
        {
            return this._identityProviderDetails != null;
        }

        /// <summary>
        /// Gets and sets the property LoggingRole. 
        /// <para>
        /// Specifies the Amazon Resource Name (ARN) of the Amazon Web Services Identity and Access
        /// Management (IAM) role that allows a server to turn on Amazon CloudWatch logging for
        /// Amazon S3 or Amazon EFS events. When set, user activity can be viewed in your CloudWatch
        /// logs.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
        public string LoggingRole
        {
            get { return this._loggingRole; }
            set { this._loggingRole = value; }
        }

        // Check to see if LoggingRole property is set
        internal bool IsSetLoggingRole()
        {
            return this._loggingRole != null;
        }

        /// <summary>
        /// Gets and sets the property ProtocolDetails. 
        /// <para>
        ///  The protocol settings that are configured for your server. 
        /// </para>
        ///  
        /// <para>
        ///  Use the <code>PassiveIp</code> parameter to indicate passive mode (for FTP and FTPS
        /// protocols). Enter a single dotted-quad IPv4 address, such as the external IP address
        /// of a firewall, router, or load balancer. 
        /// </para>
        ///  
        /// <para>
        /// Use the <code>TlsSessionResumptionMode</code> parameter to determine whether or not
        /// your Transfer server resumes recent, negotiated sessions through a unique session
        /// ID.
        /// </para>
        /// </summary>
        public ProtocolDetails ProtocolDetails
        {
            get { return this._protocolDetails; }
            set { this._protocolDetails = value; }
        }

        // Check to see if ProtocolDetails property is set
        internal bool IsSetProtocolDetails()
        {
            return this._protocolDetails != null;
        }

        /// <summary>
        /// Gets and sets the property Protocols. 
        /// <para>
        /// Specifies the file transfer protocol or protocols over which your file transfer protocol
        /// client can connect to your server's endpoint. The available protocols are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Secure Shell (SSH) File Transfer Protocol (SFTP): File transfer over SSH
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// File Transfer Protocol Secure (FTPS): File transfer with TLS encryption
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// File Transfer Protocol (FTP): Unencrypted file transfer
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// If you select <code>FTPS</code>, you must choose a certificate stored in Amazon Web
        /// ServicesCertificate Manager (ACM) which will be used to identify your server when
        /// clients connect to it over FTPS.
        /// </para>
        ///  
        /// <para>
        /// If <code>Protocol</code> includes either <code>FTP</code> or <code>FTPS</code>, then
        /// the <code>EndpointType</code> must be <code>VPC</code> and the <code>IdentityProviderType</code>
        /// must be <code>AWS_DIRECTORY_SERVICE</code> or <code>API_GATEWAY</code>.
        /// </para>
        ///  
        /// <para>
        /// If <code>Protocol</code> includes <code>FTP</code>, then <code>AddressAllocationIds</code>
        /// cannot be associated.
        /// </para>
        ///  
        /// <para>
        /// If <code>Protocol</code> is set only to <code>SFTP</code>, the <code>EndpointType</code>
        /// can be set to <code>PUBLIC</code> and the <code>IdentityProviderType</code> can be
        /// set to <code>SERVICE_MANAGED</code>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=3)]
        public List<string> Protocols
        {
            get { return this._protocols; }
            set { this._protocols = value; }
        }

        // Check to see if Protocols property is set
        internal bool IsSetProtocols()
        {
            return this._protocols != null && this._protocols.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SecurityPolicyName. 
        /// <para>
        /// Specifies the name of the security policy that is attached to the server.
        /// </para>
        /// </summary>
        [AWSProperty(Max=100)]
        public string SecurityPolicyName
        {
            get { return this._securityPolicyName; }
            set { this._securityPolicyName = value; }
        }

        // Check to see if SecurityPolicyName property is set
        internal bool IsSetSecurityPolicyName()
        {
            return this._securityPolicyName != null;
        }

        /// <summary>
        /// Gets and sets the property ServerId. 
        /// <para>
        /// A system-assigned unique identifier for a server instance that the user account is
        /// assigned to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=19, Max=19)]
        public string ServerId
        {
            get { return this._serverId; }
            set { this._serverId = value; }
        }

        // Check to see if ServerId property is set
        internal bool IsSetServerId()
        {
            return this._serverId != null;
        }

        /// <summary>
        /// Gets and sets the property WorkflowDetails. 
        /// <para>
        /// Specifies the workflow ID for the workflow to assign and the execution role used for
        /// executing the workflow.
        /// </para>
        /// </summary>
        public WorkflowDetails WorkflowDetails
        {
            get { return this._workflowDetails; }
            set { this._workflowDetails = value; }
        }

        // Check to see if WorkflowDetails property is set
        internal bool IsSetWorkflowDetails()
        {
            return this._workflowDetails != null;
        }

    }
}