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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.EC2.Model;
using Amazon.EC2.Model.Internal.MarshallTransformations;
using Amazon.EC2.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.EC2
{
    /// <summary>
    /// Implementation for accessing EC2
    ///
    /// Amazon Elastic Compute Cloud 
    /// <para>
    /// Amazon Elastic Compute Cloud (Amazon EC2) provides secure and resizable computing
    /// capacity in the AWS cloud. Using Amazon EC2 eliminates the need to invest in hardware
    /// up front, so you can develop and deploy applications faster.
    /// </para>
    ///  
    /// <para>
    /// To learn more about Amazon EC2, Amazon EBS, and Amazon VPC, see the following resources:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="http://aws.amazon.com/ec2">Amazon EC2 product page</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="http://aws.amazon.com/documentation/ec2">Amazon EC2 documentation</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="http://aws.amazon.com/ebs">Amazon EBS product page</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="http://aws.amazon.com/vpc">Amazon VPC product page</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="http://aws.amazon.com/documentation/vpc">Amazon VPC documentation</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AmazonEC2Client : AmazonServiceClient, IAmazonEC2
    {
        private static IServiceMetadata serviceMetadata = new AmazonEC2Metadata();
        
        #region Constructors

#if NETSTANDARD
    
        /// <summary>
        /// Constructs AmazonEC2Client with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonEC2Client()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonEC2Config()) { }

        /// <summary>
        /// Constructs AmazonEC2Client with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonEC2Client(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonEC2Config{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonEC2Client with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonEC2Client Configuration Object</param>
        public AmazonEC2Client(AmazonEC2Config config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonEC2Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonEC2Client(AWSCredentials credentials)
            : this(credentials, new AmazonEC2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonEC2Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonEC2Client(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonEC2Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonEC2Client with AWS Credentials and an
        /// AmazonEC2Client Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonEC2Client Configuration Object</param>
        public AmazonEC2Client(AWSCredentials credentials, AmazonEC2Config clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonEC2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonEC2Client(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonEC2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonEC2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonEC2Client(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonEC2Config() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonEC2Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonEC2Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonEC2Client Configuration Object</param>
        public AmazonEC2Client(string awsAccessKeyId, string awsSecretAccessKey, AmazonEC2Config clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonEC2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonEC2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonEC2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonEC2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonEC2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonEC2Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonEC2Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonEC2Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonEC2Client Configuration Object</param>
        public AmazonEC2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonEC2Config clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        } 

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.AddHandlerBefore<Amazon.Runtime.Internal.Marshaller>(new Amazon.EC2.Internal.AmazonEC2PreMarshallHandler(this.Credentials));
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new Amazon.EC2.Internal.AmazonEC2PostMarshallHandler());
            pipeline.AddHandlerBefore<Amazon.Runtime.Internal.Unmarshaller>(new Amazon.EC2.Internal.AmazonEC2ResponseHandler());
        }
        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


        #region  AcceptReservedInstancesExchangeQuote

        internal virtual AcceptReservedInstancesExchangeQuoteResponse AcceptReservedInstancesExchangeQuote(AcceptReservedInstancesExchangeQuoteRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptReservedInstancesExchangeQuoteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptReservedInstancesExchangeQuoteResponseUnmarshaller.Instance;

            return Invoke<AcceptReservedInstancesExchangeQuoteResponse>(request, options);
        }



        /// <summary>
        /// Accepts the Convertible Reserved Instance exchange quote described in the <a>GetReservedInstancesExchangeQuote</a>
        /// call.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptReservedInstancesExchangeQuote service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AcceptReservedInstancesExchangeQuote service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AcceptReservedInstancesExchangeQuote">REST API Reference for AcceptReservedInstancesExchangeQuote Operation</seealso>
        public virtual Task<AcceptReservedInstancesExchangeQuoteResponse> AcceptReservedInstancesExchangeQuoteAsync(AcceptReservedInstancesExchangeQuoteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptReservedInstancesExchangeQuoteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptReservedInstancesExchangeQuoteResponseUnmarshaller.Instance;

            return InvokeAsync<AcceptReservedInstancesExchangeQuoteResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AcceptTransitGatewayVpcAttachment

        internal virtual AcceptTransitGatewayVpcAttachmentResponse AcceptTransitGatewayVpcAttachment(AcceptTransitGatewayVpcAttachmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptTransitGatewayVpcAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptTransitGatewayVpcAttachmentResponseUnmarshaller.Instance;

            return Invoke<AcceptTransitGatewayVpcAttachmentResponse>(request, options);
        }



        /// <summary>
        /// Accepts a request to attach a VPC to a transit gateway.
        /// 
        ///  
        /// <para>
        /// The VPC attachment must be in the <code>pendingAcceptance</code> state. Use <a>DescribeTransitGatewayVpcAttachments</a>
        /// to view your pending VPC attachment requests. Use <a>RejectTransitGatewayVpcAttachment</a>
        /// to reject a VPC attachment request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptTransitGatewayVpcAttachment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AcceptTransitGatewayVpcAttachment service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AcceptTransitGatewayVpcAttachment">REST API Reference for AcceptTransitGatewayVpcAttachment Operation</seealso>
        public virtual Task<AcceptTransitGatewayVpcAttachmentResponse> AcceptTransitGatewayVpcAttachmentAsync(AcceptTransitGatewayVpcAttachmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptTransitGatewayVpcAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptTransitGatewayVpcAttachmentResponseUnmarshaller.Instance;

            return InvokeAsync<AcceptTransitGatewayVpcAttachmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AcceptVpcEndpointConnections

        internal virtual AcceptVpcEndpointConnectionsResponse AcceptVpcEndpointConnections(AcceptVpcEndpointConnectionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptVpcEndpointConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptVpcEndpointConnectionsResponseUnmarshaller.Instance;

            return Invoke<AcceptVpcEndpointConnectionsResponse>(request, options);
        }



        /// <summary>
        /// Accepts one or more interface VPC endpoint connection requests to your VPC endpoint
        /// service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptVpcEndpointConnections service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AcceptVpcEndpointConnections service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AcceptVpcEndpointConnections">REST API Reference for AcceptVpcEndpointConnections Operation</seealso>
        public virtual Task<AcceptVpcEndpointConnectionsResponse> AcceptVpcEndpointConnectionsAsync(AcceptVpcEndpointConnectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptVpcEndpointConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptVpcEndpointConnectionsResponseUnmarshaller.Instance;

            return InvokeAsync<AcceptVpcEndpointConnectionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AcceptVpcPeeringConnection

        internal virtual AcceptVpcPeeringConnectionResponse AcceptVpcPeeringConnection(AcceptVpcPeeringConnectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptVpcPeeringConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptVpcPeeringConnectionResponseUnmarshaller.Instance;

            return Invoke<AcceptVpcPeeringConnectionResponse>(request, options);
        }



        /// <summary>
        /// Accept a VPC peering connection request. To accept a request, the VPC peering connection
        /// must be in the <code>pending-acceptance</code> state, and you must be the owner of
        /// the peer VPC. Use <a>DescribeVpcPeeringConnections</a> to view your outstanding VPC
        /// peering connection requests.
        /// 
        ///  
        /// <para>
        /// For an inter-Region VPC peering connection request, you must accept the VPC peering
        /// connection in the Region of the accepter VPC.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptVpcPeeringConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AcceptVpcPeeringConnection service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AcceptVpcPeeringConnection">REST API Reference for AcceptVpcPeeringConnection Operation</seealso>
        public virtual Task<AcceptVpcPeeringConnectionResponse> AcceptVpcPeeringConnectionAsync(AcceptVpcPeeringConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptVpcPeeringConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptVpcPeeringConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<AcceptVpcPeeringConnectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AdvertiseByoipCidr

        internal virtual AdvertiseByoipCidrResponse AdvertiseByoipCidr(AdvertiseByoipCidrRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdvertiseByoipCidrRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdvertiseByoipCidrResponseUnmarshaller.Instance;

            return Invoke<AdvertiseByoipCidrResponse>(request, options);
        }



        /// <summary>
        /// Advertises an IPv4 address range that is provisioned for use with your AWS resources
        /// through bring your own IP addresses (BYOIP).
        /// 
        ///  
        /// <para>
        /// You can perform this operation at most once every 10 seconds, even if you specify
        /// different address ranges each time.
        /// </para>
        ///  
        /// <para>
        /// We recommend that you stop advertising the BYOIP CIDR from other locations when you
        /// advertise it from AWS. To minimize down time, you can configure your AWS resources
        /// to use an address from a BYOIP CIDR before it is advertised, and then simultaneously
        /// stop advertising it from the current location and start advertising it through AWS.
        /// </para>
        ///  
        /// <para>
        /// It can take a few minutes before traffic to the specified addresses starts routing
        /// to AWS because of BGP propagation delays.
        /// </para>
        ///  
        /// <para>
        /// To stop advertising the BYOIP CIDR, use <a>WithdrawByoipCidr</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AdvertiseByoipCidr service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AdvertiseByoipCidr service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AdvertiseByoipCidr">REST API Reference for AdvertiseByoipCidr Operation</seealso>
        public virtual Task<AdvertiseByoipCidrResponse> AdvertiseByoipCidrAsync(AdvertiseByoipCidrRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdvertiseByoipCidrRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdvertiseByoipCidrResponseUnmarshaller.Instance;

            return InvokeAsync<AdvertiseByoipCidrResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AllocateAddress

        internal virtual AllocateAddressResponse AllocateAddress()
        {
            return AllocateAddress(new AllocateAddressRequest());
        }
        internal virtual AllocateAddressResponse AllocateAddress(AllocateAddressRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AllocateAddressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AllocateAddressResponseUnmarshaller.Instance;

            return Invoke<AllocateAddressResponse>(request, options);
        }


        /// <summary>
        /// Allocates an Elastic IP address to your AWS account. After you allocate the Elastic
        /// IP address you can associate it with an instance or network interface. After you release
        /// an Elastic IP address, it is released to the IP address pool and can be allocated
        /// to a different AWS account.
        /// 
        ///  
        /// <para>
        /// You can allocate an Elastic IP address from an address pool owned by AWS or from an
        /// address pool created from a public IPv4 address range that you have brought to AWS
        /// for use with your AWS resources using bring your own IP addresses (BYOIP). For more
        /// information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-byoip.html">Bring
        /// Your Own IP Addresses (BYOIP)</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// [EC2-VPC] If you release an Elastic IP address, you might be able to recover it. You
        /// cannot recover an Elastic IP address that you released after it is allocated to another
        /// AWS account. You cannot recover an Elastic IP address for EC2-Classic. To attempt
        /// to recover an Elastic IP address that you released, specify it in this operation.
        /// </para>
        ///  
        /// <para>
        /// An Elastic IP address is for use either in the EC2-Classic platform or in a VPC. By
        /// default, you can allocate 5 Elastic IP addresses for EC2-Classic per Region and 5
        /// Elastic IP addresses for EC2-VPC per Region.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html">Elastic
        /// IP Addresses</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AllocateAddress service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AllocateAddress">REST API Reference for AllocateAddress Operation</seealso>
        public virtual Task<AllocateAddressResponse> AllocateAddressAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return AllocateAddressAsync(new AllocateAddressRequest(), cancellationToken);
        }



        /// <summary>
        /// Allocates an Elastic IP address to your AWS account. After you allocate the Elastic
        /// IP address you can associate it with an instance or network interface. After you release
        /// an Elastic IP address, it is released to the IP address pool and can be allocated
        /// to a different AWS account.
        /// 
        ///  
        /// <para>
        /// You can allocate an Elastic IP address from an address pool owned by AWS or from an
        /// address pool created from a public IPv4 address range that you have brought to AWS
        /// for use with your AWS resources using bring your own IP addresses (BYOIP). For more
        /// information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-byoip.html">Bring
        /// Your Own IP Addresses (BYOIP)</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// [EC2-VPC] If you release an Elastic IP address, you might be able to recover it. You
        /// cannot recover an Elastic IP address that you released after it is allocated to another
        /// AWS account. You cannot recover an Elastic IP address for EC2-Classic. To attempt
        /// to recover an Elastic IP address that you released, specify it in this operation.
        /// </para>
        ///  
        /// <para>
        /// An Elastic IP address is for use either in the EC2-Classic platform or in a VPC. By
        /// default, you can allocate 5 Elastic IP addresses for EC2-Classic per Region and 5
        /// Elastic IP addresses for EC2-VPC per Region.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html">Elastic
        /// IP Addresses</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AllocateAddress service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AllocateAddress service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AllocateAddress">REST API Reference for AllocateAddress Operation</seealso>
        public virtual Task<AllocateAddressResponse> AllocateAddressAsync(AllocateAddressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AllocateAddressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AllocateAddressResponseUnmarshaller.Instance;

            return InvokeAsync<AllocateAddressResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AllocateHosts

        internal virtual AllocateHostsResponse AllocateHosts(AllocateHostsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AllocateHostsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AllocateHostsResponseUnmarshaller.Instance;

            return Invoke<AllocateHostsResponse>(request, options);
        }



        /// <summary>
        /// Allocates a Dedicated Host to your account. At a minimum, specify the instance size
        /// type, Availability Zone, and quantity of hosts to allocate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AllocateHosts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AllocateHosts service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AllocateHosts">REST API Reference for AllocateHosts Operation</seealso>
        public virtual Task<AllocateHostsResponse> AllocateHostsAsync(AllocateHostsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AllocateHostsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AllocateHostsResponseUnmarshaller.Instance;

            return InvokeAsync<AllocateHostsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ApplySecurityGroupsToClientVpnTargetNetwork

        internal virtual ApplySecurityGroupsToClientVpnTargetNetworkResponse ApplySecurityGroupsToClientVpnTargetNetwork(ApplySecurityGroupsToClientVpnTargetNetworkRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ApplySecurityGroupsToClientVpnTargetNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ApplySecurityGroupsToClientVpnTargetNetworkResponseUnmarshaller.Instance;

            return Invoke<ApplySecurityGroupsToClientVpnTargetNetworkResponse>(request, options);
        }



        /// <summary>
        /// Applies a security group to the association between the target network and the Client
        /// VPN endpoint. This action replaces the existing security groups with the specified
        /// security groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ApplySecurityGroupsToClientVpnTargetNetwork service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ApplySecurityGroupsToClientVpnTargetNetwork service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ApplySecurityGroupsToClientVpnTargetNetwork">REST API Reference for ApplySecurityGroupsToClientVpnTargetNetwork Operation</seealso>
        public virtual Task<ApplySecurityGroupsToClientVpnTargetNetworkResponse> ApplySecurityGroupsToClientVpnTargetNetworkAsync(ApplySecurityGroupsToClientVpnTargetNetworkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ApplySecurityGroupsToClientVpnTargetNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ApplySecurityGroupsToClientVpnTargetNetworkResponseUnmarshaller.Instance;

            return InvokeAsync<ApplySecurityGroupsToClientVpnTargetNetworkResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssignIpv6Addresses

        internal virtual AssignIpv6AddressesResponse AssignIpv6Addresses(AssignIpv6AddressesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssignIpv6AddressesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssignIpv6AddressesResponseUnmarshaller.Instance;

            return Invoke<AssignIpv6AddressesResponse>(request, options);
        }



        /// <summary>
        /// Assigns one or more IPv6 addresses to the specified network interface. You can specify
        /// one or more specific IPv6 addresses, or you can specify the number of IPv6 addresses
        /// to be automatically assigned from within the subnet's IPv6 CIDR block range. You can
        /// assign as many IPv6 addresses to a network interface as you can assign private IPv4
        /// addresses, and the limit varies per instance type. For information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-eni.html#AvailableIpPerENI">IP
        /// Addresses Per Network Interface Per Instance Type</a> in the <i>Amazon Elastic Compute
        /// Cloud User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssignIpv6Addresses service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssignIpv6Addresses service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssignIpv6Addresses">REST API Reference for AssignIpv6Addresses Operation</seealso>
        public virtual Task<AssignIpv6AddressesResponse> AssignIpv6AddressesAsync(AssignIpv6AddressesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssignIpv6AddressesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssignIpv6AddressesResponseUnmarshaller.Instance;

            return InvokeAsync<AssignIpv6AddressesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssignPrivateIpAddresses

        internal virtual AssignPrivateIpAddressesResponse AssignPrivateIpAddresses(AssignPrivateIpAddressesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssignPrivateIpAddressesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssignPrivateIpAddressesResponseUnmarshaller.Instance;

            return Invoke<AssignPrivateIpAddressesResponse>(request, options);
        }



        /// <summary>
        /// Assigns one or more secondary private IP addresses to the specified network interface.
        /// 
        ///  
        /// <para>
        /// You can specify one or more specific secondary IP addresses, or you can specify the
        /// number of secondary IP addresses to be automatically assigned within the subnet's
        /// CIDR block range. The number of secondary IP addresses that you can assign to an instance
        /// varies by instance type. For information about instance types, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html">Instance
        /// Types</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>. For more information
        /// about Elastic IP addresses, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html">Elastic
        /// IP Addresses</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// When you move a secondary private IP address to another network interface, any Elastic
        /// IP address that is associated with the IP address is also moved.
        /// </para>
        ///  
        /// <para>
        /// Remapping an IP address is an asynchronous operation. When you move an IP address
        /// from one network interface to another, check <code>network/interfaces/macs/mac/local-ipv4s</code>
        /// in the instance metadata to confirm that the remapping is complete.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssignPrivateIpAddresses service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssignPrivateIpAddresses service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssignPrivateIpAddresses">REST API Reference for AssignPrivateIpAddresses Operation</seealso>
        public virtual Task<AssignPrivateIpAddressesResponse> AssignPrivateIpAddressesAsync(AssignPrivateIpAddressesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssignPrivateIpAddressesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssignPrivateIpAddressesResponseUnmarshaller.Instance;

            return InvokeAsync<AssignPrivateIpAddressesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateAddress

        internal virtual AssociateAddressResponse AssociateAddress(AssociateAddressRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateAddressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateAddressResponseUnmarshaller.Instance;

            return Invoke<AssociateAddressResponse>(request, options);
        }



        /// <summary>
        /// Associates an Elastic IP address with an instance or a network interface. Before you
        /// can use an Elastic IP address, you must allocate it to your account.
        /// 
        ///  
        /// <para>
        /// An Elastic IP address is for use in either the EC2-Classic platform or in a VPC. For
        /// more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html">Elastic
        /// IP Addresses</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// [EC2-Classic, VPC in an EC2-VPC-only account] If the Elastic IP address is already
        /// associated with a different instance, it is disassociated from that instance and associated
        /// with the specified instance. If you associate an Elastic IP address with an instance
        /// that has an existing Elastic IP address, the existing address is disassociated from
        /// the instance, but remains allocated to your account.
        /// </para>
        ///  
        /// <para>
        /// [VPC in an EC2-Classic account] If you don't specify a private IP address, the Elastic
        /// IP address is associated with the primary IP address. If the Elastic IP address is
        /// already associated with a different instance or a network interface, you get an error
        /// unless you allow reassociation. You cannot associate an Elastic IP address with an
        /// instance or network interface that has an existing Elastic IP address.
        /// </para>
        ///  <important> 
        /// <para>
        /// This is an idempotent operation. If you perform the operation more than once, Amazon
        /// EC2 doesn't return an error, and you may be charged for each time the Elastic IP address
        /// is remapped to the same instance. For more information, see the <i>Elastic IP Addresses</i>
        /// section of <a href="http://aws.amazon.com/ec2/pricing/">Amazon EC2 Pricing</a>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateAddress service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateAddress service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssociateAddress">REST API Reference for AssociateAddress Operation</seealso>
        public virtual Task<AssociateAddressResponse> AssociateAddressAsync(AssociateAddressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateAddressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateAddressResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateAddressResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateClientVpnTargetNetwork

        internal virtual AssociateClientVpnTargetNetworkResponse AssociateClientVpnTargetNetwork(AssociateClientVpnTargetNetworkRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateClientVpnTargetNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateClientVpnTargetNetworkResponseUnmarshaller.Instance;

            return Invoke<AssociateClientVpnTargetNetworkResponse>(request, options);
        }



        /// <summary>
        /// Associates a target network with a Client VPN endpoint. A target network is a subnet
        /// in a VPC. You can associate multiple subnets from the same VPC with a Client VPN endpoint.
        /// You can associate only one subnet in each Availability Zone. We recommend that you
        /// associate at least two subnets to provide Availability Zone redundancy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateClientVpnTargetNetwork service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateClientVpnTargetNetwork service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssociateClientVpnTargetNetwork">REST API Reference for AssociateClientVpnTargetNetwork Operation</seealso>
        public virtual Task<AssociateClientVpnTargetNetworkResponse> AssociateClientVpnTargetNetworkAsync(AssociateClientVpnTargetNetworkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateClientVpnTargetNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateClientVpnTargetNetworkResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateClientVpnTargetNetworkResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateDhcpOptions

        internal virtual AssociateDhcpOptionsResponse AssociateDhcpOptions(AssociateDhcpOptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateDhcpOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateDhcpOptionsResponseUnmarshaller.Instance;

            return Invoke<AssociateDhcpOptionsResponse>(request, options);
        }



        /// <summary>
        /// Associates a set of DHCP options (that you've previously created) with the specified
        /// VPC, or associates no DHCP options with the VPC.
        /// 
        ///  
        /// <para>
        /// After you associate the options with the VPC, any existing instances and all new instances
        /// that you launch in that VPC use the options. You don't need to restart or relaunch
        /// the instances. They automatically pick up the changes within a few hours, depending
        /// on how frequently the instance renews its DHCP lease. You can explicitly renew the
        /// lease using the operating system on the instance.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_DHCP_Options.html">DHCP
        /// Options Sets</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateDhcpOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateDhcpOptions service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssociateDhcpOptions">REST API Reference for AssociateDhcpOptions Operation</seealso>
        public virtual Task<AssociateDhcpOptionsResponse> AssociateDhcpOptionsAsync(AssociateDhcpOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateDhcpOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateDhcpOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateDhcpOptionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateIamInstanceProfile

        internal virtual AssociateIamInstanceProfileResponse AssociateIamInstanceProfile(AssociateIamInstanceProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateIamInstanceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateIamInstanceProfileResponseUnmarshaller.Instance;

            return Invoke<AssociateIamInstanceProfileResponse>(request, options);
        }



        /// <summary>
        /// Associates an IAM instance profile with a running or stopped instance. You cannot
        /// associate more than one IAM instance profile with an instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateIamInstanceProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateIamInstanceProfile service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssociateIamInstanceProfile">REST API Reference for AssociateIamInstanceProfile Operation</seealso>
        public virtual Task<AssociateIamInstanceProfileResponse> AssociateIamInstanceProfileAsync(AssociateIamInstanceProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateIamInstanceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateIamInstanceProfileResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateIamInstanceProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateRouteTable

        internal virtual AssociateRouteTableResponse AssociateRouteTable(AssociateRouteTableRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateRouteTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateRouteTableResponseUnmarshaller.Instance;

            return Invoke<AssociateRouteTableResponse>(request, options);
        }



        /// <summary>
        /// Associates a subnet with a route table. The subnet and route table must be in the
        /// same VPC. This association causes traffic originating from the subnet to be routed
        /// according to the routes in the route table. The action returns an association ID,
        /// which you need in order to disassociate the route table from the subnet later. A route
        /// table can be associated with multiple subnets.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html">Route
        /// Tables</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateRouteTable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateRouteTable service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssociateRouteTable">REST API Reference for AssociateRouteTable Operation</seealso>
        public virtual Task<AssociateRouteTableResponse> AssociateRouteTableAsync(AssociateRouteTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateRouteTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateRouteTableResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateRouteTableResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateSubnetCidrBlock

        internal virtual AssociateSubnetCidrBlockResponse AssociateSubnetCidrBlock(AssociateSubnetCidrBlockRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateSubnetCidrBlockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateSubnetCidrBlockResponseUnmarshaller.Instance;

            return Invoke<AssociateSubnetCidrBlockResponse>(request, options);
        }



        /// <summary>
        /// Associates a CIDR block with your subnet. You can only associate a single IPv6 CIDR
        /// block with your subnet. An IPv6 CIDR block must have a prefix length of /64.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateSubnetCidrBlock service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateSubnetCidrBlock service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssociateSubnetCidrBlock">REST API Reference for AssociateSubnetCidrBlock Operation</seealso>
        public virtual Task<AssociateSubnetCidrBlockResponse> AssociateSubnetCidrBlockAsync(AssociateSubnetCidrBlockRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateSubnetCidrBlockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateSubnetCidrBlockResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateSubnetCidrBlockResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateTransitGatewayRouteTable

        internal virtual AssociateTransitGatewayRouteTableResponse AssociateTransitGatewayRouteTable(AssociateTransitGatewayRouteTableRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateTransitGatewayRouteTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateTransitGatewayRouteTableResponseUnmarshaller.Instance;

            return Invoke<AssociateTransitGatewayRouteTableResponse>(request, options);
        }



        /// <summary>
        /// Associates the specified attachment with the specified transit gateway route table.
        /// You can associate only one route table with an attachment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateTransitGatewayRouteTable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateTransitGatewayRouteTable service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssociateTransitGatewayRouteTable">REST API Reference for AssociateTransitGatewayRouteTable Operation</seealso>
        public virtual Task<AssociateTransitGatewayRouteTableResponse> AssociateTransitGatewayRouteTableAsync(AssociateTransitGatewayRouteTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateTransitGatewayRouteTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateTransitGatewayRouteTableResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateTransitGatewayRouteTableResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateVpcCidrBlock

        internal virtual AssociateVpcCidrBlockResponse AssociateVpcCidrBlock(AssociateVpcCidrBlockRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateVpcCidrBlockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateVpcCidrBlockResponseUnmarshaller.Instance;

            return Invoke<AssociateVpcCidrBlockResponse>(request, options);
        }



        /// <summary>
        /// Associates a CIDR block with your VPC. You can associate a secondary IPv4 CIDR block,
        /// or you can associate an Amazon-provided IPv6 CIDR block. The IPv6 CIDR block size
        /// is fixed at /56.
        /// 
        ///  
        /// <para>
        /// For more information about associating CIDR blocks with your VPC and applicable restrictions,
        /// see <a href="https://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Subnets.html#VPC_Sizing">VPC
        /// and Subnet Sizing</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateVpcCidrBlock service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateVpcCidrBlock service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssociateVpcCidrBlock">REST API Reference for AssociateVpcCidrBlock Operation</seealso>
        public virtual Task<AssociateVpcCidrBlockResponse> AssociateVpcCidrBlockAsync(AssociateVpcCidrBlockRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateVpcCidrBlockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateVpcCidrBlockResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateVpcCidrBlockResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AttachClassicLinkVpc

        internal virtual AttachClassicLinkVpcResponse AttachClassicLinkVpc(AttachClassicLinkVpcRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachClassicLinkVpcRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachClassicLinkVpcResponseUnmarshaller.Instance;

            return Invoke<AttachClassicLinkVpcResponse>(request, options);
        }



        /// <summary>
        /// Links an EC2-Classic instance to a ClassicLink-enabled VPC through one or more of
        /// the VPC's security groups. You cannot link an EC2-Classic instance to more than one
        /// VPC at a time. You can only link an instance that's in the <code>running</code> state.
        /// An instance is automatically unlinked from a VPC when it's stopped - you can link
        /// it to the VPC again when you restart it.
        /// 
        ///  
        /// <para>
        /// After you've linked an instance, you cannot change the VPC security groups that are
        /// associated with it. To change the security groups, you must first unlink the instance,
        /// and then link it again.
        /// </para>
        ///  
        /// <para>
        /// Linking your instance to a VPC is sometimes referred to as <i>attaching</i> your instance.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachClassicLinkVpc service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AttachClassicLinkVpc service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AttachClassicLinkVpc">REST API Reference for AttachClassicLinkVpc Operation</seealso>
        public virtual Task<AttachClassicLinkVpcResponse> AttachClassicLinkVpcAsync(AttachClassicLinkVpcRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachClassicLinkVpcRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachClassicLinkVpcResponseUnmarshaller.Instance;

            return InvokeAsync<AttachClassicLinkVpcResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AttachInternetGateway

        internal virtual AttachInternetGatewayResponse AttachInternetGateway(AttachInternetGatewayRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachInternetGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachInternetGatewayResponseUnmarshaller.Instance;

            return Invoke<AttachInternetGatewayResponse>(request, options);
        }



        /// <summary>
        /// Attaches an internet gateway to a VPC, enabling connectivity between the internet
        /// and the VPC. For more information about your VPC and internet gateway, see the <a
        /// href="https://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/">Amazon Virtual Private
        /// Cloud User Guide</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachInternetGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AttachInternetGateway service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AttachInternetGateway">REST API Reference for AttachInternetGateway Operation</seealso>
        public virtual Task<AttachInternetGatewayResponse> AttachInternetGatewayAsync(AttachInternetGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachInternetGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachInternetGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<AttachInternetGatewayResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AttachNetworkInterface

        internal virtual AttachNetworkInterfaceResponse AttachNetworkInterface(AttachNetworkInterfaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachNetworkInterfaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachNetworkInterfaceResponseUnmarshaller.Instance;

            return Invoke<AttachNetworkInterfaceResponse>(request, options);
        }



        /// <summary>
        /// Attaches a network interface to an instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachNetworkInterface service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AttachNetworkInterface service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AttachNetworkInterface">REST API Reference for AttachNetworkInterface Operation</seealso>
        public virtual Task<AttachNetworkInterfaceResponse> AttachNetworkInterfaceAsync(AttachNetworkInterfaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachNetworkInterfaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachNetworkInterfaceResponseUnmarshaller.Instance;

            return InvokeAsync<AttachNetworkInterfaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AttachVolume

        internal virtual AttachVolumeResponse AttachVolume(AttachVolumeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachVolumeResponseUnmarshaller.Instance;

            return Invoke<AttachVolumeResponse>(request, options);
        }



        /// <summary>
        /// Attaches an EBS volume to a running or stopped instance and exposes it to the instance
        /// with the specified device name.
        /// 
        ///  
        /// <para>
        /// Encrypted EBS volumes may only be attached to instances that support Amazon EBS encryption.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSEncryption.html">Amazon
        /// EBS Encryption</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For a list of supported device names, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-attaching-volume.html">Attaching
        /// an EBS Volume to an Instance</a>. Any device names that aren't reserved for instance
        /// store volumes can be used for EBS volumes. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/InstanceStorage.html">Amazon
        /// EC2 Instance Store</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If a volume has an AWS Marketplace product code:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The volume can be attached only to a stopped instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AWS Marketplace product codes are copied from the volume to the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must be subscribed to the product.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The instance type and operating system of the instance must support the product. For
        /// example, you can't detach a volume from a Windows instance and attach it to a Linux
        /// instance.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about EBS volumes, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-attaching-volume.html">Attaching
        /// Amazon EBS Volumes</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachVolume service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AttachVolume service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AttachVolume">REST API Reference for AttachVolume Operation</seealso>
        public virtual Task<AttachVolumeResponse> AttachVolumeAsync(AttachVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachVolumeResponseUnmarshaller.Instance;

            return InvokeAsync<AttachVolumeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AttachVpnGateway

        internal virtual AttachVpnGatewayResponse AttachVpnGateway(AttachVpnGatewayRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachVpnGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachVpnGatewayResponseUnmarshaller.Instance;

            return Invoke<AttachVpnGatewayResponse>(request, options);
        }



        /// <summary>
        /// Attaches a virtual private gateway to a VPC. You can attach one virtual private gateway
        /// to one VPC at a time.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/vpn/latest/s2svpn/VPC_VPN.html">AWS
        /// Site-to-Site VPN</a> in the <i>AWS Site-to-Site VPN User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachVpnGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AttachVpnGateway service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AttachVpnGateway">REST API Reference for AttachVpnGateway Operation</seealso>
        public virtual Task<AttachVpnGatewayResponse> AttachVpnGatewayAsync(AttachVpnGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachVpnGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachVpnGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<AttachVpnGatewayResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AuthorizeClientVpnIngress

        internal virtual AuthorizeClientVpnIngressResponse AuthorizeClientVpnIngress(AuthorizeClientVpnIngressRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AuthorizeClientVpnIngressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AuthorizeClientVpnIngressResponseUnmarshaller.Instance;

            return Invoke<AuthorizeClientVpnIngressResponse>(request, options);
        }



        /// <summary>
        /// Adds an ingress authorization rule to a Client VPN endpoint. Ingress authorization
        /// rules act as firewall rules that grant access to networks. You must configure ingress
        /// authorization rules to enable clients to access resources in AWS or on-premises networks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeClientVpnIngress service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AuthorizeClientVpnIngress service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AuthorizeClientVpnIngress">REST API Reference for AuthorizeClientVpnIngress Operation</seealso>
        public virtual Task<AuthorizeClientVpnIngressResponse> AuthorizeClientVpnIngressAsync(AuthorizeClientVpnIngressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AuthorizeClientVpnIngressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AuthorizeClientVpnIngressResponseUnmarshaller.Instance;

            return InvokeAsync<AuthorizeClientVpnIngressResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AuthorizeSecurityGroupEgress

        internal virtual AuthorizeSecurityGroupEgressResponse AuthorizeSecurityGroupEgress(AuthorizeSecurityGroupEgressRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AuthorizeSecurityGroupEgressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AuthorizeSecurityGroupEgressResponseUnmarshaller.Instance;

            return Invoke<AuthorizeSecurityGroupEgressResponse>(request, options);
        }



        /// <summary>
        /// [VPC only] Adds the specified egress rules to a security group for use with a VPC.
        /// 
        ///  
        /// <para>
        /// An outbound rule permits instances to send traffic to the specified IPv4 or IPv6 CIDR
        /// address ranges, or to the instances associated with the specified destination security
        /// groups.
        /// </para>
        ///  
        /// <para>
        /// You specify a protocol for each rule (for example, TCP). For the TCP and UDP protocols,
        /// you must also specify the destination port or port range. For the ICMP protocol, you
        /// must also specify the ICMP type and code. You can use -1 for the type or code to mean
        /// all types or all codes.
        /// </para>
        ///  
        /// <para>
        /// Rule changes are propagated to affected instances as quickly as possible. However,
        /// a small delay might occur.
        /// </para>
        ///  
        /// <para>
        /// For more information about VPC security group limits, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/amazon-vpc-limits.html">Amazon
        /// VPC Limits</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeSecurityGroupEgress service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AuthorizeSecurityGroupEgress service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AuthorizeSecurityGroupEgress">REST API Reference for AuthorizeSecurityGroupEgress Operation</seealso>
        public virtual Task<AuthorizeSecurityGroupEgressResponse> AuthorizeSecurityGroupEgressAsync(AuthorizeSecurityGroupEgressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AuthorizeSecurityGroupEgressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AuthorizeSecurityGroupEgressResponseUnmarshaller.Instance;

            return InvokeAsync<AuthorizeSecurityGroupEgressResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AuthorizeSecurityGroupIngress

        internal virtual AuthorizeSecurityGroupIngressResponse AuthorizeSecurityGroupIngress(AuthorizeSecurityGroupIngressRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AuthorizeSecurityGroupIngressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AuthorizeSecurityGroupIngressResponseUnmarshaller.Instance;

            return Invoke<AuthorizeSecurityGroupIngressResponse>(request, options);
        }



        /// <summary>
        /// Adds the specified ingress rules to a security group.
        /// 
        ///  
        /// <para>
        /// An inbound rule permits instances to receive traffic from the specified IPv4 or IPv6
        /// CIDR address ranges, or from the instances associated with the specified destination
        /// security groups.
        /// </para>
        ///  
        /// <para>
        /// You specify a protocol for each rule (for example, TCP). For TCP and UDP, you must
        /// also specify the destination port or port range. For ICMP/ICMPv6, you must also specify
        /// the ICMP/ICMPv6 type and code. You can use -1 to mean all types or all codes.
        /// </para>
        ///  
        /// <para>
        /// Rule changes are propagated to instances within the security group as quickly as possible.
        /// However, a small delay might occur.
        /// </para>
        ///  
        /// <para>
        /// For more information about VPC security group limits, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/amazon-vpc-limits.html">Amazon
        /// VPC Limits</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeSecurityGroupIngress service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AuthorizeSecurityGroupIngress service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AuthorizeSecurityGroupIngress">REST API Reference for AuthorizeSecurityGroupIngress Operation</seealso>
        public virtual Task<AuthorizeSecurityGroupIngressResponse> AuthorizeSecurityGroupIngressAsync(AuthorizeSecurityGroupIngressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AuthorizeSecurityGroupIngressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AuthorizeSecurityGroupIngressResponseUnmarshaller.Instance;

            return InvokeAsync<AuthorizeSecurityGroupIngressResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BundleInstance

        internal virtual BundleInstanceResponse BundleInstance(BundleInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BundleInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BundleInstanceResponseUnmarshaller.Instance;

            return Invoke<BundleInstanceResponse>(request, options);
        }



        /// <summary>
        /// Bundles an Amazon instance store-backed Windows instance.
        /// 
        ///  
        /// <para>
        /// During bundling, only the root device volume (C:\) is bundled. Data on other instance
        /// store volumes is not preserved.
        /// </para>
        ///  <note> 
        /// <para>
        /// This action is not applicable for Linux/Unix instances or Windows instances that are
        /// backed by Amazon EBS.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BundleInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BundleInstance service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/BundleInstance">REST API Reference for BundleInstance Operation</seealso>
        public virtual Task<BundleInstanceResponse> BundleInstanceAsync(BundleInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BundleInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BundleInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<BundleInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CancelBundleTask

        internal virtual CancelBundleTaskResponse CancelBundleTask(CancelBundleTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelBundleTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelBundleTaskResponseUnmarshaller.Instance;

            return Invoke<CancelBundleTaskResponse>(request, options);
        }



        /// <summary>
        /// Cancels a bundling operation for an instance store-backed Windows instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelBundleTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelBundleTask service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CancelBundleTask">REST API Reference for CancelBundleTask Operation</seealso>
        public virtual Task<CancelBundleTaskResponse> CancelBundleTaskAsync(CancelBundleTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelBundleTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelBundleTaskResponseUnmarshaller.Instance;

            return InvokeAsync<CancelBundleTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CancelCapacityReservation

        internal virtual CancelCapacityReservationResponse CancelCapacityReservation(CancelCapacityReservationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelCapacityReservationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelCapacityReservationResponseUnmarshaller.Instance;

            return Invoke<CancelCapacityReservationResponse>(request, options);
        }



        /// <summary>
        /// Cancels the specified Capacity Reservation, releases the reserved capacity, and changes
        /// the Capacity Reservation's state to <code>cancelled</code>.
        /// 
        ///  
        /// <para>
        /// Instances running in the reserved capacity continue running until you stop them. Stopped
        /// instances that target the Capacity Reservation can no longer launch. Modify these
        /// instances to either target a different Capacity Reservation, launch On-Demand Instance
        /// capacity, or run in any open Capacity Reservation that has matching attributes and
        /// sufficient capacity.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelCapacityReservation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelCapacityReservation service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CancelCapacityReservation">REST API Reference for CancelCapacityReservation Operation</seealso>
        public virtual Task<CancelCapacityReservationResponse> CancelCapacityReservationAsync(CancelCapacityReservationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelCapacityReservationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelCapacityReservationResponseUnmarshaller.Instance;

            return InvokeAsync<CancelCapacityReservationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CancelConversionTask

        internal virtual CancelConversionTaskResponse CancelConversionTask(CancelConversionTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelConversionTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelConversionTaskResponseUnmarshaller.Instance;

            return Invoke<CancelConversionTaskResponse>(request, options);
        }



        /// <summary>
        /// Cancels an active conversion task. The task can be the import of an instance or volume.
        /// The action removes all artifacts of the conversion, including a partially uploaded
        /// volume or instance. If the conversion is complete or is in the process of transferring
        /// the final disk image, the command fails and returns an exception.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/CommandLineReference/ec2-cli-vmimport-export.html">Importing
        /// a Virtual Machine Using the Amazon EC2 CLI</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelConversionTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelConversionTask service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CancelConversionTask">REST API Reference for CancelConversionTask Operation</seealso>
        public virtual Task<CancelConversionTaskResponse> CancelConversionTaskAsync(CancelConversionTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelConversionTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelConversionTaskResponseUnmarshaller.Instance;

            return InvokeAsync<CancelConversionTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CancelExportTask

        internal virtual CancelExportTaskResponse CancelExportTask(CancelExportTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelExportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelExportTaskResponseUnmarshaller.Instance;

            return Invoke<CancelExportTaskResponse>(request, options);
        }



        /// <summary>
        /// Cancels an active export task. The request removes all artifacts of the export, including
        /// any partially-created Amazon S3 objects. If the export task is complete or is in the
        /// process of transferring the final disk image, the command fails and returns an error.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelExportTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelExportTask service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CancelExportTask">REST API Reference for CancelExportTask Operation</seealso>
        public virtual Task<CancelExportTaskResponse> CancelExportTaskAsync(CancelExportTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelExportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelExportTaskResponseUnmarshaller.Instance;

            return InvokeAsync<CancelExportTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CancelImportTask

        internal virtual CancelImportTaskResponse CancelImportTask(CancelImportTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelImportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelImportTaskResponseUnmarshaller.Instance;

            return Invoke<CancelImportTaskResponse>(request, options);
        }



        /// <summary>
        /// Cancels an in-process import virtual machine or import snapshot task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelImportTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelImportTask service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CancelImportTask">REST API Reference for CancelImportTask Operation</seealso>
        public virtual Task<CancelImportTaskResponse> CancelImportTaskAsync(CancelImportTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelImportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelImportTaskResponseUnmarshaller.Instance;

            return InvokeAsync<CancelImportTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CancelReservedInstancesListing

        internal virtual CancelReservedInstancesListingResponse CancelReservedInstancesListing(CancelReservedInstancesListingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelReservedInstancesListingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelReservedInstancesListingResponseUnmarshaller.Instance;

            return Invoke<CancelReservedInstancesListingResponse>(request, options);
        }



        /// <summary>
        /// Cancels the specified Reserved Instance listing in the Reserved Instance Marketplace.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-market-general.html">Reserved
        /// Instance Marketplace</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelReservedInstancesListing service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelReservedInstancesListing service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CancelReservedInstancesListing">REST API Reference for CancelReservedInstancesListing Operation</seealso>
        public virtual Task<CancelReservedInstancesListingResponse> CancelReservedInstancesListingAsync(CancelReservedInstancesListingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelReservedInstancesListingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelReservedInstancesListingResponseUnmarshaller.Instance;

            return InvokeAsync<CancelReservedInstancesListingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CancelSpotFleetRequests

        internal virtual CancelSpotFleetRequestsResponse CancelSpotFleetRequests(CancelSpotFleetRequestsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelSpotFleetRequestsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelSpotFleetRequestsResponseUnmarshaller.Instance;

            return Invoke<CancelSpotFleetRequestsResponse>(request, options);
        }



        /// <summary>
        /// Cancels the specified Spot Fleet requests.
        /// 
        ///  
        /// <para>
        /// After you cancel a Spot Fleet request, the Spot Fleet launches no new Spot Instances.
        /// You must specify whether the Spot Fleet should also terminate its Spot Instances.
        /// If you terminate the instances, the Spot Fleet request enters the <code>cancelled_terminating</code>
        /// state. Otherwise, the Spot Fleet request enters the <code>cancelled_running</code>
        /// state and the instances continue to run until they are interrupted or you terminate
        /// them manually.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelSpotFleetRequests service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelSpotFleetRequests service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CancelSpotFleetRequests">REST API Reference for CancelSpotFleetRequests Operation</seealso>
        public virtual Task<CancelSpotFleetRequestsResponse> CancelSpotFleetRequestsAsync(CancelSpotFleetRequestsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelSpotFleetRequestsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelSpotFleetRequestsResponseUnmarshaller.Instance;

            return InvokeAsync<CancelSpotFleetRequestsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CancelSpotInstanceRequests

        internal virtual CancelSpotInstanceRequestsResponse CancelSpotInstanceRequests(CancelSpotInstanceRequestsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelSpotInstanceRequestsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelSpotInstanceRequestsResponseUnmarshaller.Instance;

            return Invoke<CancelSpotInstanceRequestsResponse>(request, options);
        }



        /// <summary>
        /// Cancels one or more Spot Instance requests.
        /// 
        ///  <important> 
        /// <para>
        /// Canceling a Spot Instance request does not terminate running Spot Instances associated
        /// with the request.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelSpotInstanceRequests service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelSpotInstanceRequests service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CancelSpotInstanceRequests">REST API Reference for CancelSpotInstanceRequests Operation</seealso>
        public virtual Task<CancelSpotInstanceRequestsResponse> CancelSpotInstanceRequestsAsync(CancelSpotInstanceRequestsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelSpotInstanceRequestsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelSpotInstanceRequestsResponseUnmarshaller.Instance;

            return InvokeAsync<CancelSpotInstanceRequestsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ConfirmProductInstance

        internal virtual ConfirmProductInstanceResponse ConfirmProductInstance(ConfirmProductInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConfirmProductInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConfirmProductInstanceResponseUnmarshaller.Instance;

            return Invoke<ConfirmProductInstanceResponse>(request, options);
        }



        /// <summary>
        /// Determines whether a product code is associated with an instance. This action can
        /// only be used by the owner of the product code. It is useful when a product code owner
        /// must verify whether another user's instance is eligible for support.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConfirmProductInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ConfirmProductInstance service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ConfirmProductInstance">REST API Reference for ConfirmProductInstance Operation</seealso>
        public virtual Task<ConfirmProductInstanceResponse> ConfirmProductInstanceAsync(ConfirmProductInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConfirmProductInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConfirmProductInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<ConfirmProductInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CopyFpgaImage

        internal virtual CopyFpgaImageResponse CopyFpgaImage(CopyFpgaImageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CopyFpgaImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyFpgaImageResponseUnmarshaller.Instance;

            return Invoke<CopyFpgaImageResponse>(request, options);
        }



        /// <summary>
        /// Copies the specified Amazon FPGA Image (AFI) to the current Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyFpgaImage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CopyFpgaImage service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CopyFpgaImage">REST API Reference for CopyFpgaImage Operation</seealso>
        public virtual Task<CopyFpgaImageResponse> CopyFpgaImageAsync(CopyFpgaImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CopyFpgaImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyFpgaImageResponseUnmarshaller.Instance;

            return InvokeAsync<CopyFpgaImageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CopyImage

        internal virtual CopyImageResponse CopyImage(CopyImageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CopyImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyImageResponseUnmarshaller.Instance;

            return Invoke<CopyImageResponse>(request, options);
        }



        /// <summary>
        /// Initiates the copy of an AMI from the specified source Region to the current Region.
        /// You specify the destination Region by using its endpoint when making the request.
        /// 
        ///  
        /// <para>
        /// Copies of encrypted backing snapshots for the AMI are encrypted. Copies of unencrypted
        /// backing snapshots remain unencrypted, unless you set <code>Encrypted</code> during
        /// the copy operation. You cannot create an unencrypted copy of an encrypted backing
        /// snapshot.
        /// </para>
        ///  
        /// <para>
        /// For more information about the prerequisites and limits when copying an AMI, see <a
        /// href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/CopyingAMIs.html">Copying
        /// an AMI</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyImage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CopyImage service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CopyImage">REST API Reference for CopyImage Operation</seealso>
        public virtual Task<CopyImageResponse> CopyImageAsync(CopyImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CopyImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyImageResponseUnmarshaller.Instance;

            return InvokeAsync<CopyImageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CopySnapshot

        internal virtual CopySnapshotResponse CopySnapshot(CopySnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CopySnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopySnapshotResponseUnmarshaller.Instance;

            return Invoke<CopySnapshotResponse>(request, options);
        }



        /// <summary>
        /// Copies a point-in-time snapshot of an EBS volume and stores it in Amazon S3. You can
        /// copy the snapshot within the same Region or from one Region to another. You can use
        /// the snapshot to create EBS volumes or Amazon Machine Images (AMIs). The snapshot is
        /// copied to the regional endpoint that you send the HTTP request to.
        /// 
        ///  
        /// <para>
        /// Copies of encrypted EBS snapshots remain encrypted. Copies of unencrypted snapshots
        /// remain unencrypted, unless the <code>Encrypted</code> flag is specified during the
        /// snapshot copy operation. By default, encrypted snapshot copies use the default AWS
        /// Key Management Service (AWS KMS) customer master key (CMK); however, you can specify
        /// a non-default CMK with the <code>KmsKeyId</code> parameter.
        /// </para>
        ///  
        /// <para>
        /// To copy an encrypted snapshot that has been shared from another account, you must
        /// have permissions for the CMK used to encrypt the snapshot.
        /// </para>
        ///  
        /// <para>
        /// Snapshots created by copying another snapshot have an arbitrary volume ID that should
        /// not be used for any purpose.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-copy-snapshot.html">Copying
        /// an Amazon EBS Snapshot</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopySnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CopySnapshot service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CopySnapshot">REST API Reference for CopySnapshot Operation</seealso>
        public virtual Task<CopySnapshotResponse> CopySnapshotAsync(CopySnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CopySnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopySnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<CopySnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateCapacityReservation

        internal virtual CreateCapacityReservationResponse CreateCapacityReservation(CreateCapacityReservationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCapacityReservationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCapacityReservationResponseUnmarshaller.Instance;

            return Invoke<CreateCapacityReservationResponse>(request, options);
        }



        /// <summary>
        /// Creates a new Capacity Reservation with the specified attributes.
        /// 
        ///  
        /// <para>
        /// Capacity Reservations enable you to reserve capacity for your Amazon EC2 instances
        /// in a specific Availability Zone for any duration. This gives you the flexibility to
        /// selectively add capacity reservations and still get the Regional RI discounts for
        /// that usage. By creating Capacity Reservations, you ensure that you always have access
        /// to Amazon EC2 capacity when you need it, for as long as you need it. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-capacity-reservations.html">Capacity
        /// Reservations</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Your request to create a Capacity Reservation could fail if Amazon EC2 does not have
        /// sufficient capacity to fulfill the request. If your request fails due to Amazon EC2
        /// capacity constraints, either try again at a later time, try in a different Availability
        /// Zone, or request a smaller capacity reservation. If your application is flexible across
        /// instance types and sizes, try to create a Capacity Reservation with different instance
        /// attributes.
        /// </para>
        ///  
        /// <para>
        /// Your request could also fail if the requested quantity exceeds your On-Demand Instance
        /// limit for the selected instance type. If your request fails due to limit constraints,
        /// increase your On-Demand Instance limit for the required instance type and try again.
        /// For more information about increasing your instance limits, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-resource-limits.html">Amazon
        /// EC2 Service Limits</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCapacityReservation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCapacityReservation service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateCapacityReservation">REST API Reference for CreateCapacityReservation Operation</seealso>
        public virtual Task<CreateCapacityReservationResponse> CreateCapacityReservationAsync(CreateCapacityReservationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCapacityReservationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCapacityReservationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCapacityReservationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateClientVpnEndpoint

        internal virtual CreateClientVpnEndpointResponse CreateClientVpnEndpoint(CreateClientVpnEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateClientVpnEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClientVpnEndpointResponseUnmarshaller.Instance;

            return Invoke<CreateClientVpnEndpointResponse>(request, options);
        }



        /// <summary>
        /// Creates a Client VPN endpoint. A Client VPN endpoint is the resource you create and
        /// configure to enable and manage client VPN sessions. It is the destination endpoint
        /// at which all client VPN sessions are terminated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateClientVpnEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateClientVpnEndpoint service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateClientVpnEndpoint">REST API Reference for CreateClientVpnEndpoint Operation</seealso>
        public virtual Task<CreateClientVpnEndpointResponse> CreateClientVpnEndpointAsync(CreateClientVpnEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateClientVpnEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClientVpnEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<CreateClientVpnEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateClientVpnRoute

        internal virtual CreateClientVpnRouteResponse CreateClientVpnRoute(CreateClientVpnRouteRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateClientVpnRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClientVpnRouteResponseUnmarshaller.Instance;

            return Invoke<CreateClientVpnRouteResponse>(request, options);
        }



        /// <summary>
        /// Adds a route to a network to a Client VPN endpoint. Each Client VPN endpoint has a
        /// route table that describes the available destination network routes. Each route in
        /// the route table specifies the path for traﬃc to speciﬁc resources or networks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateClientVpnRoute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateClientVpnRoute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateClientVpnRoute">REST API Reference for CreateClientVpnRoute Operation</seealso>
        public virtual Task<CreateClientVpnRouteResponse> CreateClientVpnRouteAsync(CreateClientVpnRouteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateClientVpnRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClientVpnRouteResponseUnmarshaller.Instance;

            return InvokeAsync<CreateClientVpnRouteResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateCustomerGateway

        internal virtual CreateCustomerGatewayResponse CreateCustomerGateway(CreateCustomerGatewayRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCustomerGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCustomerGatewayResponseUnmarshaller.Instance;

            return Invoke<CreateCustomerGatewayResponse>(request, options);
        }



        /// <summary>
        /// Provides information to AWS about your VPN customer gateway device. The customer gateway
        /// is the appliance at your end of the VPN connection. (The device on the AWS side of
        /// the VPN connection is the virtual private gateway.) You must provide the Internet-routable
        /// IP address of the customer gateway's external interface. The IP address must be static
        /// and may be behind a device performing network address translation (NAT).
        /// 
        ///  
        /// <para>
        /// For devices that use Border Gateway Protocol (BGP), you can also provide the device's
        /// BGP Autonomous System Number (ASN). You can use an existing ASN assigned to your network.
        /// If you don't have an ASN already, you can use a private ASN (in the 64512 - 65534
        /// range).
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon EC2 supports all 2-byte ASN numbers in the range of 1 - 65534, with the exception
        /// of 7224, which is reserved in the <code>us-east-1</code> Region, and 9059, which is
        /// reserved in the <code>eu-west-1</code> Region.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/vpn/latest/s2svpn/VPC_VPN.html">AWS
        /// Site-to-Site VPN</a> in the <i>AWS Site-to-Site VPN User Guide</i>.
        /// </para>
        ///  <important> 
        /// <para>
        /// You cannot create more than one customer gateway with the same VPN type, IP address,
        /// and BGP ASN parameter values. If you run an identical request more than one time,
        /// the first request creates the customer gateway, and subsequent requests return information
        /// about the existing customer gateway. The subsequent requests do not create new customer
        /// gateway resources.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomerGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCustomerGateway service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateCustomerGateway">REST API Reference for CreateCustomerGateway Operation</seealso>
        public virtual Task<CreateCustomerGatewayResponse> CreateCustomerGatewayAsync(CreateCustomerGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCustomerGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCustomerGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCustomerGatewayResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDefaultSubnet

        internal virtual CreateDefaultSubnetResponse CreateDefaultSubnet(CreateDefaultSubnetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDefaultSubnetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDefaultSubnetResponseUnmarshaller.Instance;

            return Invoke<CreateDefaultSubnetResponse>(request, options);
        }



        /// <summary>
        /// Creates a default subnet with a size <code>/20</code> IPv4 CIDR block in the specified
        /// Availability Zone in your default VPC. You can have only one default subnet per Availability
        /// Zone. For more information, see <a href="https://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/default-vpc.html#create-default-subnet">Creating
        /// a Default Subnet</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDefaultSubnet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDefaultSubnet service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateDefaultSubnet">REST API Reference for CreateDefaultSubnet Operation</seealso>
        public virtual Task<CreateDefaultSubnetResponse> CreateDefaultSubnetAsync(CreateDefaultSubnetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDefaultSubnetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDefaultSubnetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDefaultSubnetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDefaultVpc

        internal virtual CreateDefaultVpcResponse CreateDefaultVpc(CreateDefaultVpcRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDefaultVpcRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDefaultVpcResponseUnmarshaller.Instance;

            return Invoke<CreateDefaultVpcResponse>(request, options);
        }



        /// <summary>
        /// Creates a default VPC with a size <code>/16</code> IPv4 CIDR block and a default subnet
        /// in each Availability Zone. For more information about the components of a default
        /// VPC, see <a href="https://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/default-vpc.html">Default
        /// VPC and Default Subnets</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// You cannot specify the components of the default VPC yourself.
        /// 
        ///  
        /// <para>
        /// If you deleted your previous default VPC, you can create a default VPC. You cannot
        /// have more than one default VPC per Region.
        /// </para>
        ///  
        /// <para>
        /// If your account supports EC2-Classic, you cannot use this action to create a default
        /// VPC in a Region that supports EC2-Classic. If you want a default VPC in a Region that
        /// supports EC2-Classic, see "I really want a default VPC for my existing EC2 account.
        /// Is that possible?" in the <a href="http://aws.amazon.com/vpc/faqs/#Default_VPCs">Default
        /// VPCs FAQ</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDefaultVpc service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDefaultVpc service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateDefaultVpc">REST API Reference for CreateDefaultVpc Operation</seealso>
        public virtual Task<CreateDefaultVpcResponse> CreateDefaultVpcAsync(CreateDefaultVpcRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDefaultVpcRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDefaultVpcResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDefaultVpcResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDhcpOptions

        internal virtual CreateDhcpOptionsResponse CreateDhcpOptions(CreateDhcpOptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDhcpOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDhcpOptionsResponseUnmarshaller.Instance;

            return Invoke<CreateDhcpOptionsResponse>(request, options);
        }



        /// <summary>
        /// Creates a set of DHCP options for your VPC. After creating the set, you must associate
        /// it with the VPC, causing all existing and new instances that you launch in the VPC
        /// to use this set of DHCP options. The following are the individual DHCP options you
        /// can specify. For more information about the options, see <a href="http://www.ietf.org/rfc/rfc2132.txt">RFC
        /// 2132</a>.
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <code>domain-name-servers</code> - The IP addresses of up to four domain name servers,
        /// or AmazonProvidedDNS. The default DHCP option set specifies AmazonProvidedDNS. If
        /// specifying more than one domain name server, specify the IP addresses in a single
        /// parameter, separated by commas. ITo have your instance to receive a custom DNS hostname
        /// as specified in <code>domain-name</code>, you must set <code>domain-name-servers</code>
        /// to a custom DNS server.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>domain-name</code> - If you're using AmazonProvidedDNS in <code>us-east-1</code>,
        /// specify <code>ec2.internal</code>. If you're using AmazonProvidedDNS in another Region,
        /// specify <code>region.compute.internal</code> (for example, <code>ap-northeast-1.compute.internal</code>).
        /// Otherwise, specify a domain name (for example, <code>MyCompany.com</code>). This value
        /// is used to complete unqualified DNS hostnames. <b>Important</b>: Some Linux operating
        /// systems accept multiple domain names separated by spaces. However, Windows and other
        /// Linux operating systems treat the value as a single domain, which results in unexpected
        /// behavior. If your DHCP options set is associated with a VPC that has instances with
        /// multiple operating systems, specify only one domain name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ntp-servers</code> - The IP addresses of up to four Network Time Protocol (NTP)
        /// servers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>netbios-name-servers</code> - The IP addresses of up to four NetBIOS name servers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>netbios-node-type</code> - The NetBIOS node type (1, 2, 4, or 8). We recommend
        /// that you specify 2 (broadcast and multicast are not currently supported). For more
        /// information about these node types, see <a href="http://www.ietf.org/rfc/rfc2132.txt">RFC
        /// 2132</a>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Your VPC automatically starts out with a set of DHCP options that includes only a
        /// DNS server that we provide (AmazonProvidedDNS). If you create a set of options, and
        /// if your VPC has an internet gateway, make sure to set the <code>domain-name-servers</code>
        /// option either to <code>AmazonProvidedDNS</code> or to a domain name server of your
        /// choice. For more information, see <a href="https://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_DHCP_Options.html">DHCP
        /// Options Sets</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDhcpOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDhcpOptions service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateDhcpOptions">REST API Reference for CreateDhcpOptions Operation</seealso>
        public virtual Task<CreateDhcpOptionsResponse> CreateDhcpOptionsAsync(CreateDhcpOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDhcpOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDhcpOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDhcpOptionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateEgressOnlyInternetGateway

        internal virtual CreateEgressOnlyInternetGatewayResponse CreateEgressOnlyInternetGateway(CreateEgressOnlyInternetGatewayRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEgressOnlyInternetGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEgressOnlyInternetGatewayResponseUnmarshaller.Instance;

            return Invoke<CreateEgressOnlyInternetGatewayResponse>(request, options);
        }



        /// <summary>
        /// [IPv6 only] Creates an egress-only internet gateway for your VPC. An egress-only internet
        /// gateway is used to enable outbound communication over IPv6 from instances in your
        /// VPC to the internet, and prevents hosts outside of your VPC from initiating an IPv6
        /// connection with your instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEgressOnlyInternetGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEgressOnlyInternetGateway service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateEgressOnlyInternetGateway">REST API Reference for CreateEgressOnlyInternetGateway Operation</seealso>
        public virtual Task<CreateEgressOnlyInternetGatewayResponse> CreateEgressOnlyInternetGatewayAsync(CreateEgressOnlyInternetGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEgressOnlyInternetGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEgressOnlyInternetGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<CreateEgressOnlyInternetGatewayResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateFleet

        internal virtual CreateFleetResponse CreateFleet(CreateFleetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFleetResponseUnmarshaller.Instance;

            return Invoke<CreateFleetResponse>(request, options);
        }



        /// <summary>
        /// Launches an EC2 Fleet.
        /// 
        ///  
        /// <para>
        /// You can create a single EC2 Fleet that includes multiple launch specifications that
        /// vary by instance type, AMI, Availability Zone, or subnet.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-fleet.html">Launching
        /// an EC2 Fleet</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFleet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFleet service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateFleet">REST API Reference for CreateFleet Operation</seealso>
        public virtual Task<CreateFleetResponse> CreateFleetAsync(CreateFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFleetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateFleetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateFlowLogs

        internal virtual CreateFlowLogsResponse CreateFlowLogs(CreateFlowLogsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFlowLogsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFlowLogsResponseUnmarshaller.Instance;

            return Invoke<CreateFlowLogsResponse>(request, options);
        }



        /// <summary>
        /// Creates one or more flow logs to capture information about IP traffic for a specific
        /// network interface, subnet, or VPC. 
        /// 
        ///  
        /// <para>
        /// Flow log data for a monitored network interface is recorded as flow log records, which
        /// are log events consisting of fields that describe the traffic flow. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/flow-logs.html#flow-log-records">Flow
        /// Log Records</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// When publishing to CloudWatch Logs, flow log records are published to a log group,
        /// and each network interface has a unique log stream in the log group. When publishing
        /// to Amazon S3, flow log records for all of the monitored network interfaces are published
        /// to a single log file object that is stored in the specified bucket.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/flow-logs.html">VPC
        /// Flow Logs</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFlowLogs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFlowLogs service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateFlowLogs">REST API Reference for CreateFlowLogs Operation</seealso>
        public virtual Task<CreateFlowLogsResponse> CreateFlowLogsAsync(CreateFlowLogsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFlowLogsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFlowLogsResponseUnmarshaller.Instance;

            return InvokeAsync<CreateFlowLogsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateFpgaImage

        internal virtual CreateFpgaImageResponse CreateFpgaImage(CreateFpgaImageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFpgaImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFpgaImageResponseUnmarshaller.Instance;

            return Invoke<CreateFpgaImageResponse>(request, options);
        }



        /// <summary>
        /// Creates an Amazon FPGA Image (AFI) from the specified design checkpoint (DCP).
        /// 
        ///  
        /// <para>
        /// The create operation is asynchronous. To verify that the AFI is ready for use, check
        /// the output logs.
        /// </para>
        ///  
        /// <para>
        /// An AFI contains the FPGA bitstream that is ready to download to an FPGA. You can securely
        /// deploy an AFI on multiple FPGA-accelerated instances. For more information, see the
        /// <a href="https://github.com/aws/aws-fpga/">AWS FPGA Hardware Development Kit</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFpgaImage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFpgaImage service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateFpgaImage">REST API Reference for CreateFpgaImage Operation</seealso>
        public virtual Task<CreateFpgaImageResponse> CreateFpgaImageAsync(CreateFpgaImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFpgaImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFpgaImageResponseUnmarshaller.Instance;

            return InvokeAsync<CreateFpgaImageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateImage

        internal virtual CreateImageResponse CreateImage(CreateImageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateImageResponseUnmarshaller.Instance;

            return Invoke<CreateImageResponse>(request, options);
        }



        /// <summary>
        /// Creates an Amazon EBS-backed AMI from an Amazon EBS-backed instance that is either
        /// running or stopped.
        /// 
        ///  
        /// <para>
        /// If you customized your instance with instance store volumes or EBS volumes in addition
        /// to the root device volume, the new AMI contains block device mapping information for
        /// those volumes. When you launch an instance from this new AMI, the instance automatically
        /// launches with those additional volumes.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/creating-an-ami-ebs.html">Creating
        /// Amazon EBS-Backed Linux AMIs</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateImage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateImage service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateImage">REST API Reference for CreateImage Operation</seealso>
        public virtual Task<CreateImageResponse> CreateImageAsync(CreateImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateImageResponseUnmarshaller.Instance;

            return InvokeAsync<CreateImageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateInstanceExportTask

        internal virtual CreateInstanceExportTaskResponse CreateInstanceExportTask(CreateInstanceExportTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateInstanceExportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInstanceExportTaskResponseUnmarshaller.Instance;

            return Invoke<CreateInstanceExportTaskResponse>(request, options);
        }



        /// <summary>
        /// Exports a running or stopped instance to an S3 bucket.
        /// 
        ///  
        /// <para>
        /// For information about the supported operating systems, image formats, and known limitations
        /// for the types of instances you can export, see <a href="https://docs.aws.amazon.com/vm-import/latest/userguide/vmexport.html">Exporting
        /// an Instance as a VM Using VM Import/Export</a> in the <i>VM Import/Export User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInstanceExportTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateInstanceExportTask service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateInstanceExportTask">REST API Reference for CreateInstanceExportTask Operation</seealso>
        public virtual Task<CreateInstanceExportTaskResponse> CreateInstanceExportTaskAsync(CreateInstanceExportTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateInstanceExportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInstanceExportTaskResponseUnmarshaller.Instance;

            return InvokeAsync<CreateInstanceExportTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateInternetGateway

        internal virtual CreateInternetGatewayResponse CreateInternetGateway()
        {
            return CreateInternetGateway(new CreateInternetGatewayRequest());
        }
        internal virtual CreateInternetGatewayResponse CreateInternetGateway(CreateInternetGatewayRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateInternetGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInternetGatewayResponseUnmarshaller.Instance;

            return Invoke<CreateInternetGatewayResponse>(request, options);
        }


        /// <summary>
        /// Creates an internet gateway for use with a VPC. After creating the internet gateway,
        /// you attach it to a VPC using <a>AttachInternetGateway</a>.
        /// 
        ///  
        /// <para>
        /// For more information about your VPC and internet gateway, see the <a href="https://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/">Amazon
        /// Virtual Private Cloud User Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateInternetGateway service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateInternetGateway">REST API Reference for CreateInternetGateway Operation</seealso>
        public virtual Task<CreateInternetGatewayResponse> CreateInternetGatewayAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return CreateInternetGatewayAsync(new CreateInternetGatewayRequest(), cancellationToken);
        }



        /// <summary>
        /// Creates an internet gateway for use with a VPC. After creating the internet gateway,
        /// you attach it to a VPC using <a>AttachInternetGateway</a>.
        /// 
        ///  
        /// <para>
        /// For more information about your VPC and internet gateway, see the <a href="https://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/">Amazon
        /// Virtual Private Cloud User Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInternetGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateInternetGateway service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateInternetGateway">REST API Reference for CreateInternetGateway Operation</seealso>
        public virtual Task<CreateInternetGatewayResponse> CreateInternetGatewayAsync(CreateInternetGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateInternetGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInternetGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<CreateInternetGatewayResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateKeyPair

        internal virtual CreateKeyPairResponse CreateKeyPair(CreateKeyPairRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateKeyPairRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateKeyPairResponseUnmarshaller.Instance;

            return Invoke<CreateKeyPairResponse>(request, options);
        }



        /// <summary>
        /// Creates a 2048-bit RSA key pair with the specified name. Amazon EC2 stores the public
        /// key and displays the private key for you to save to a file. The private key is returned
        /// as an unencrypted PEM encoded PKCS#1 private key. If a key with the specified name
        /// already exists, Amazon EC2 returns an error.
        /// 
        ///  
        /// <para>
        /// You can have up to five thousand key pairs per Region.
        /// </para>
        ///  
        /// <para>
        /// The key pair returned to you is available only in the Region in which you create it.
        /// If you prefer, you can create your own key pair using a third-party tool and upload
        /// it to any Region using <a>ImportKeyPair</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-key-pairs.html">Key
        /// Pairs</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateKeyPair service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateKeyPair service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateKeyPair">REST API Reference for CreateKeyPair Operation</seealso>
        public virtual Task<CreateKeyPairResponse> CreateKeyPairAsync(CreateKeyPairRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateKeyPairRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateKeyPairResponseUnmarshaller.Instance;

            return InvokeAsync<CreateKeyPairResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateLaunchTemplate

        internal virtual CreateLaunchTemplateResponse CreateLaunchTemplate(CreateLaunchTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLaunchTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLaunchTemplateResponseUnmarshaller.Instance;

            return Invoke<CreateLaunchTemplateResponse>(request, options);
        }



        /// <summary>
        /// Creates a launch template. A launch template contains the parameters to launch an
        /// instance. When you launch an instance using <a>RunInstances</a>, you can specify a
        /// launch template instead of providing the launch parameters in the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLaunchTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLaunchTemplate service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateLaunchTemplate">REST API Reference for CreateLaunchTemplate Operation</seealso>
        public virtual Task<CreateLaunchTemplateResponse> CreateLaunchTemplateAsync(CreateLaunchTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLaunchTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLaunchTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLaunchTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateLaunchTemplateVersion

        internal virtual CreateLaunchTemplateVersionResponse CreateLaunchTemplateVersion(CreateLaunchTemplateVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLaunchTemplateVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLaunchTemplateVersionResponseUnmarshaller.Instance;

            return Invoke<CreateLaunchTemplateVersionResponse>(request, options);
        }



        /// <summary>
        /// Creates a new version for a launch template. You can specify an existing version of
        /// launch template from which to base the new version.
        /// 
        ///  
        /// <para>
        /// Launch template versions are numbered in the order in which they are created. You
        /// cannot specify, change, or replace the numbering of launch template versions.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLaunchTemplateVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLaunchTemplateVersion service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateLaunchTemplateVersion">REST API Reference for CreateLaunchTemplateVersion Operation</seealso>
        public virtual Task<CreateLaunchTemplateVersionResponse> CreateLaunchTemplateVersionAsync(CreateLaunchTemplateVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLaunchTemplateVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLaunchTemplateVersionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLaunchTemplateVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateNatGateway

        internal virtual CreateNatGatewayResponse CreateNatGateway(CreateNatGatewayRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNatGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNatGatewayResponseUnmarshaller.Instance;

            return Invoke<CreateNatGatewayResponse>(request, options);
        }



        /// <summary>
        /// Creates a NAT gateway in the specified public subnet. This action creates a network
        /// interface in the specified subnet with a private IP address from the IP address range
        /// of the subnet. Internet-bound traffic from a private subnet can be routed to the NAT
        /// gateway, therefore enabling instances in the private subnet to connect to the internet.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/vpc-nat-gateway.html">NAT
        /// Gateways</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNatGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateNatGateway service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateNatGateway">REST API Reference for CreateNatGateway Operation</seealso>
        public virtual Task<CreateNatGatewayResponse> CreateNatGatewayAsync(CreateNatGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNatGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNatGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<CreateNatGatewayResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateNetworkAcl

        internal virtual CreateNetworkAclResponse CreateNetworkAcl(CreateNetworkAclRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNetworkAclRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNetworkAclResponseUnmarshaller.Instance;

            return Invoke<CreateNetworkAclResponse>(request, options);
        }



        /// <summary>
        /// Creates a network ACL in a VPC. Network ACLs provide an optional layer of security
        /// (in addition to security groups) for the instances in your VPC.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_ACLs.html">Network
        /// ACLs</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkAcl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateNetworkAcl service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateNetworkAcl">REST API Reference for CreateNetworkAcl Operation</seealso>
        public virtual Task<CreateNetworkAclResponse> CreateNetworkAclAsync(CreateNetworkAclRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNetworkAclRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNetworkAclResponseUnmarshaller.Instance;

            return InvokeAsync<CreateNetworkAclResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateNetworkAclEntry

        internal virtual CreateNetworkAclEntryResponse CreateNetworkAclEntry(CreateNetworkAclEntryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNetworkAclEntryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNetworkAclEntryResponseUnmarshaller.Instance;

            return Invoke<CreateNetworkAclEntryResponse>(request, options);
        }



        /// <summary>
        /// Creates an entry (a rule) in a network ACL with the specified rule number. Each network
        /// ACL has a set of numbered ingress rules and a separate set of numbered egress rules.
        /// When determining whether a packet should be allowed in or out of a subnet associated
        /// with the ACL, we process the entries in the ACL according to the rule numbers, in
        /// ascending order. Each network ACL has a set of ingress rules and a separate set of
        /// egress rules.
        /// 
        ///  
        /// <para>
        /// We recommend that you leave room between the rule numbers (for example, 100, 110,
        /// 120, ...), and not number them one right after the other (for example, 101, 102, 103,
        /// ...). This makes it easier to add a rule between existing ones without having to renumber
        /// the rules.
        /// </para>
        ///  
        /// <para>
        /// After you add an entry, you can't modify it; you must either replace it, or create
        /// an entry and delete the old one.
        /// </para>
        ///  
        /// <para>
        /// For more information about network ACLs, see <a href="https://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_ACLs.html">Network
        /// ACLs</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkAclEntry service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateNetworkAclEntry service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateNetworkAclEntry">REST API Reference for CreateNetworkAclEntry Operation</seealso>
        public virtual Task<CreateNetworkAclEntryResponse> CreateNetworkAclEntryAsync(CreateNetworkAclEntryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNetworkAclEntryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNetworkAclEntryResponseUnmarshaller.Instance;

            return InvokeAsync<CreateNetworkAclEntryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateNetworkInterface

        internal virtual CreateNetworkInterfaceResponse CreateNetworkInterface(CreateNetworkInterfaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNetworkInterfaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNetworkInterfaceResponseUnmarshaller.Instance;

            return Invoke<CreateNetworkInterfaceResponse>(request, options);
        }



        /// <summary>
        /// Creates a network interface in the specified subnet.
        /// 
        ///  
        /// <para>
        /// For more information about network interfaces, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-eni.html">Elastic
        /// Network Interfaces</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkInterface service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateNetworkInterface service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateNetworkInterface">REST API Reference for CreateNetworkInterface Operation</seealso>
        public virtual Task<CreateNetworkInterfaceResponse> CreateNetworkInterfaceAsync(CreateNetworkInterfaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNetworkInterfaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNetworkInterfaceResponseUnmarshaller.Instance;

            return InvokeAsync<CreateNetworkInterfaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateNetworkInterfacePermission

        internal virtual CreateNetworkInterfacePermissionResponse CreateNetworkInterfacePermission(CreateNetworkInterfacePermissionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNetworkInterfacePermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNetworkInterfacePermissionResponseUnmarshaller.Instance;

            return Invoke<CreateNetworkInterfacePermissionResponse>(request, options);
        }



        /// <summary>
        /// Grants an AWS-authorized account permission to attach the specified network interface
        /// to an instance in their account.
        /// 
        ///  
        /// <para>
        /// You can grant permission to a single AWS account only, and only one account at a time.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkInterfacePermission service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateNetworkInterfacePermission service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateNetworkInterfacePermission">REST API Reference for CreateNetworkInterfacePermission Operation</seealso>
        public virtual Task<CreateNetworkInterfacePermissionResponse> CreateNetworkInterfacePermissionAsync(CreateNetworkInterfacePermissionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNetworkInterfacePermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNetworkInterfacePermissionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateNetworkInterfacePermissionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreatePlacementGroup

        internal virtual CreatePlacementGroupResponse CreatePlacementGroup(CreatePlacementGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePlacementGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePlacementGroupResponseUnmarshaller.Instance;

            return Invoke<CreatePlacementGroupResponse>(request, options);
        }



        /// <summary>
        /// Creates a placement group in which to launch instances. The strategy of the placement
        /// group determines how the instances are organized within the group. 
        /// 
        ///  
        /// <para>
        /// A <code>cluster</code> placement group is a logical grouping of instances within a
        /// single Availability Zone that benefit from low network latency, high network throughput.
        /// A <code>spread</code> placement group places instances on distinct hardware. A <code>partition</code>
        /// placement group places groups of instances in different partitions, where instances
        /// in one partition do not share the same hardware with instances in another partition.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/placement-groups.html">Placement
        /// Groups</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePlacementGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePlacementGroup service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreatePlacementGroup">REST API Reference for CreatePlacementGroup Operation</seealso>
        public virtual Task<CreatePlacementGroupResponse> CreatePlacementGroupAsync(CreatePlacementGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePlacementGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePlacementGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePlacementGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateReservedInstancesListing

        internal virtual CreateReservedInstancesListingResponse CreateReservedInstancesListing(CreateReservedInstancesListingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateReservedInstancesListingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateReservedInstancesListingResponseUnmarshaller.Instance;

            return Invoke<CreateReservedInstancesListingResponse>(request, options);
        }



        /// <summary>
        /// Creates a listing for Amazon EC2 Standard Reserved Instances to be sold in the Reserved
        /// Instance Marketplace. You can submit one Standard Reserved Instance listing at a time.
        /// To get a list of your Standard Reserved Instances, you can use the <a>DescribeReservedInstances</a>
        /// operation.
        /// 
        ///  <note> 
        /// <para>
        /// Only Standard Reserved Instances can be sold in the Reserved Instance Marketplace.
        /// Convertible Reserved Instances cannot be sold.
        /// </para>
        ///  </note> 
        /// <para>
        /// The Reserved Instance Marketplace matches sellers who want to resell Standard Reserved
        /// Instance capacity that they no longer need with buyers who want to purchase additional
        /// capacity. Reserved Instances bought and sold through the Reserved Instance Marketplace
        /// work like any other Reserved Instances.
        /// </para>
        ///  
        /// <para>
        /// To sell your Standard Reserved Instances, you must first register as a seller in the
        /// Reserved Instance Marketplace. After completing the registration process, you can
        /// create a Reserved Instance Marketplace listing of some or all of your Standard Reserved
        /// Instances, and specify the upfront price to receive for them. Your Standard Reserved
        /// Instance listings then become available for purchase. To view the details of your
        /// Standard Reserved Instance listing, you can use the <a>DescribeReservedInstancesListings</a>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-market-general.html">Reserved
        /// Instance Marketplace</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReservedInstancesListing service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateReservedInstancesListing service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateReservedInstancesListing">REST API Reference for CreateReservedInstancesListing Operation</seealso>
        public virtual Task<CreateReservedInstancesListingResponse> CreateReservedInstancesListingAsync(CreateReservedInstancesListingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateReservedInstancesListingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateReservedInstancesListingResponseUnmarshaller.Instance;

            return InvokeAsync<CreateReservedInstancesListingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateRoute

        internal virtual CreateRouteResponse CreateRoute(CreateRouteRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRouteResponseUnmarshaller.Instance;

            return Invoke<CreateRouteResponse>(request, options);
        }



        /// <summary>
        /// Creates a route in a route table within a VPC.
        /// 
        ///  
        /// <para>
        /// You must specify one of the following targets: internet gateway or virtual private
        /// gateway, NAT instance, NAT gateway, VPC peering connection, network interface, or
        /// egress-only internet gateway.
        /// </para>
        ///  
        /// <para>
        /// When determining how to route traffic, we use the route with the most specific match.
        /// For example, traffic is destined for the IPv4 address <code>192.0.2.3</code>, and
        /// the route table includes the following two IPv4 routes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>192.0.2.0/24</code> (goes to some target A)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>192.0.2.0/28</code> (goes to some target B)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Both routes apply to the traffic destined for <code>192.0.2.3</code>. However, the
        /// second route in the list covers a smaller number of IP addresses and is therefore
        /// more specific, so we use that route to determine where to target the traffic.
        /// </para>
        ///  
        /// <para>
        /// For more information about route tables, see <a href="https://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html">Route
        /// Tables</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRoute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRoute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateRoute">REST API Reference for CreateRoute Operation</seealso>
        public virtual Task<CreateRouteResponse> CreateRouteAsync(CreateRouteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRouteResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRouteResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateRouteTable

        internal virtual CreateRouteTableResponse CreateRouteTable(CreateRouteTableRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRouteTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRouteTableResponseUnmarshaller.Instance;

            return Invoke<CreateRouteTableResponse>(request, options);
        }



        /// <summary>
        /// Creates a route table for the specified VPC. After you create a route table, you can
        /// add routes and associate the table with a subnet.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html">Route
        /// Tables</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRouteTable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRouteTable service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateRouteTable">REST API Reference for CreateRouteTable Operation</seealso>
        public virtual Task<CreateRouteTableResponse> CreateRouteTableAsync(CreateRouteTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRouteTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRouteTableResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRouteTableResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateSecurityGroup

        internal virtual CreateSecurityGroupResponse CreateSecurityGroup(CreateSecurityGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSecurityGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSecurityGroupResponseUnmarshaller.Instance;

            return Invoke<CreateSecurityGroupResponse>(request, options);
        }



        /// <summary>
        /// Creates a security group.
        /// 
        ///  
        /// <para>
        /// A security group acts as a virtual firewall for your instance to control inbound and
        /// outbound traffic. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-network-security.html">Amazon
        /// EC2 Security Groups</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> and
        /// <a href="https://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_SecurityGroups.html">Security
        /// Groups for Your VPC</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// When you create a security group, you specify a friendly name of your choice. You
        /// can have a security group for use in EC2-Classic with the same name as a security
        /// group for use in a VPC. However, you can't have two security groups for use in EC2-Classic
        /// with the same name or two security groups for use in a VPC with the same name.
        /// </para>
        ///  
        /// <para>
        /// You have a default security group for use in EC2-Classic and a default security group
        /// for use in your VPC. If you don't specify a security group when you launch an instance,
        /// the instance is launched into the appropriate default security group. A default security
        /// group includes a default rule that grants instances unrestricted network access to
        /// each other.
        /// </para>
        ///  
        /// <para>
        /// You can add or remove rules from your security groups using <a>AuthorizeSecurityGroupIngress</a>,
        /// <a>AuthorizeSecurityGroupEgress</a>, <a>RevokeSecurityGroupIngress</a>, and <a>RevokeSecurityGroupEgress</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information about VPC security group limits, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/amazon-vpc-limits.html">Amazon
        /// VPC Limits</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSecurityGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSecurityGroup service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateSecurityGroup">REST API Reference for CreateSecurityGroup Operation</seealso>
        public virtual Task<CreateSecurityGroupResponse> CreateSecurityGroupAsync(CreateSecurityGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSecurityGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSecurityGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSecurityGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateSnapshot

        internal virtual CreateSnapshotResponse CreateSnapshot(CreateSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSnapshotResponseUnmarshaller.Instance;

            return Invoke<CreateSnapshotResponse>(request, options);
        }



        /// <summary>
        /// Creates a snapshot of an EBS volume and stores it in Amazon S3. You can use snapshots
        /// for backups, to make copies of EBS volumes, and to save data before shutting down
        /// an instance.
        /// 
        ///  
        /// <para>
        /// When a snapshot is created, any AWS Marketplace product codes that are associated
        /// with the source volume are propagated to the snapshot.
        /// </para>
        ///  
        /// <para>
        /// You can take a snapshot of an attached volume that is in use. However, snapshots only
        /// capture data that has been written to your EBS volume at the time the snapshot command
        /// is issued; this may exclude any data that has been cached by any applications or the
        /// operating system. If you can pause any file systems on the volume long enough to take
        /// a snapshot, your snapshot should be complete. However, if you cannot pause all file
        /// writes to the volume, you should unmount the volume from within the instance, issue
        /// the snapshot command, and then remount the volume to ensure a consistent and complete
        /// snapshot. You may remount and use your volume while the snapshot status is <code>pending</code>.
        /// </para>
        ///  
        /// <para>
        /// To create a snapshot for EBS volumes that serve as root devices, you should stop the
        /// instance before taking the snapshot.
        /// </para>
        ///  
        /// <para>
        /// Snapshots that are taken from encrypted volumes are automatically encrypted. Volumes
        /// that are created from encrypted snapshots are also automatically encrypted. Your encrypted
        /// volumes and any associated snapshots always remain protected.
        /// </para>
        ///  
        /// <para>
        /// You can tag your snapshots during creation. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html">Tagging
        /// Your Amazon EC2 Resources</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/AmazonEBS.html">Amazon
        /// Elastic Block Store</a> and <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSEncryption.html">Amazon
        /// EBS Encryption</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSnapshot service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateSnapshot">REST API Reference for CreateSnapshot Operation</seealso>
        public virtual Task<CreateSnapshotResponse> CreateSnapshotAsync(CreateSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateSnapshots

        internal virtual CreateSnapshotsResponse CreateSnapshots(CreateSnapshotsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSnapshotsResponseUnmarshaller.Instance;

            return Invoke<CreateSnapshotsResponse>(request, options);
        }



        /// <summary>
        /// Creates crash-consistent snapshots of multiple EBS volumes and stores the data in
        /// S3. Volumes are chosen by specifying an instance. Any attached volumes will produce
        /// one snapshot each that is crash-consistent across the instance. Boot volumes can be
        /// excluded by changing the paramaters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshots service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSnapshots service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateSnapshots">REST API Reference for CreateSnapshots Operation</seealso>
        public virtual Task<CreateSnapshotsResponse> CreateSnapshotsAsync(CreateSnapshotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSnapshotsResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSnapshotsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateSpotDatafeedSubscription

        internal virtual CreateSpotDatafeedSubscriptionResponse CreateSpotDatafeedSubscription(CreateSpotDatafeedSubscriptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSpotDatafeedSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSpotDatafeedSubscriptionResponseUnmarshaller.Instance;

            return Invoke<CreateSpotDatafeedSubscriptionResponse>(request, options);
        }



        /// <summary>
        /// Creates a data feed for Spot Instances, enabling you to view Spot Instance usage logs.
        /// You can create one data feed per AWS account. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/spot-data-feeds.html">Spot
        /// Instance Data Feed</a> in the <i>Amazon EC2 User Guide for Linux Instances</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSpotDatafeedSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSpotDatafeedSubscription service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateSpotDatafeedSubscription">REST API Reference for CreateSpotDatafeedSubscription Operation</seealso>
        public virtual Task<CreateSpotDatafeedSubscriptionResponse> CreateSpotDatafeedSubscriptionAsync(CreateSpotDatafeedSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSpotDatafeedSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSpotDatafeedSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSpotDatafeedSubscriptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateSubnet

        internal virtual CreateSubnetResponse CreateSubnet(CreateSubnetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSubnetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSubnetResponseUnmarshaller.Instance;

            return Invoke<CreateSubnetResponse>(request, options);
        }



        /// <summary>
        /// Creates a subnet in an existing VPC.
        /// 
        ///  
        /// <para>
        /// When you create each subnet, you provide the VPC ID and IPv4 CIDR block for the subnet.
        /// After you create a subnet, you can't change its CIDR block. The size of the subnet's
        /// IPv4 CIDR block can be the same as a VPC's IPv4 CIDR block, or a subset of a VPC's
        /// IPv4 CIDR block. If you create more than one subnet in a VPC, the subnets' CIDR blocks
        /// must not overlap. The smallest IPv4 subnet (and VPC) you can create uses a /28 netmask
        /// (16 IPv4 addresses), and the largest uses a /16 netmask (65,536 IPv4 addresses).
        /// </para>
        ///  
        /// <para>
        /// If you've associated an IPv6 CIDR block with your VPC, you can create a subnet with
        /// an IPv6 CIDR block that uses a /64 prefix length. 
        /// </para>
        ///  <important> 
        /// <para>
        /// AWS reserves both the first four and the last IPv4 address in each subnet's CIDR block.
        /// They're not available for use.
        /// </para>
        ///  </important> 
        /// <para>
        /// If you add more than one subnet to a VPC, they're set up in a star topology with a
        /// logical router in the middle.
        /// </para>
        ///  
        /// <para>
        /// If you launch an instance in a VPC using an Amazon EBS-backed AMI, the IP address
        /// doesn't change if you stop and restart the instance (unlike a similar instance launched
        /// outside a VPC, which gets a new IP address when restarted). It's therefore possible
        /// to have a subnet with no running instances (they're all stopped), but no remaining
        /// IP addresses available.
        /// </para>
        ///  
        /// <para>
        /// For more information about subnets, see <a href="https://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Subnets.html">Your
        /// VPC and Subnets</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSubnet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSubnet service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateSubnet">REST API Reference for CreateSubnet Operation</seealso>
        public virtual Task<CreateSubnetResponse> CreateSubnetAsync(CreateSubnetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSubnetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSubnetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSubnetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateTags

        internal virtual CreateTagsResponse CreateTags(CreateTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTagsResponseUnmarshaller.Instance;

            return Invoke<CreateTagsResponse>(request, options);
        }



        /// <summary>
        /// Adds or overwrites the specified tags for the specified Amazon EC2 resource or resources.
        /// Each resource can have a maximum of 50 tags. Each tag consists of a key and optional
        /// value. Tag keys must be unique per resource.
        /// 
        ///  
        /// <para>
        /// For more information about tags, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html">Tagging
        /// Your Resources</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>. For more
        /// information about creating IAM policies that control users' access to resources based
        /// on tags, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-supported-iam-actions-resources.html">Supported
        /// Resource-Level Permissions for Amazon EC2 API Actions</a> in the <i>Amazon Elastic
        /// Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTags service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateTags">REST API Reference for CreateTags Operation</seealso>
        public virtual Task<CreateTagsResponse> CreateTagsAsync(CreateTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTagsResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateTransitGateway

        internal virtual CreateTransitGatewayResponse CreateTransitGateway(CreateTransitGatewayRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTransitGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTransitGatewayResponseUnmarshaller.Instance;

            return Invoke<CreateTransitGatewayResponse>(request, options);
        }



        /// <summary>
        /// Creates a transit gateway.
        /// 
        ///  
        /// <para>
        /// You can use a transit gateway to interconnect your virtual private clouds (VPC) and
        /// on-premises networks. After the transit gateway enters the <code>available</code>
        /// state, you can attach your VPCs and VPN connections to the transit gateway.
        /// </para>
        ///  
        /// <para>
        /// To attach your VPCs, use <a>CreateTransitGatewayVpcAttachment</a>.
        /// </para>
        ///  
        /// <para>
        /// To attach a VPN connection, use <a>CreateCustomerGateway</a> to create a customer
        /// gateway and specify the ID of the customer gateway and the ID of the transit gateway
        /// in a call to <a>CreateVpnConnection</a>.
        /// </para>
        ///  
        /// <para>
        /// When you create a transit gateway, we create a default transit gateway route table
        /// and use it as the default association route table and the default propagation route
        /// table. You can use <a>CreateTransitGatewayRouteTable</a> to create additional transit
        /// gateway route tables. If you disable automatic route propagation, we do not create
        /// a default transit gateway route table. You can use <a>EnableTransitGatewayRouteTablePropagation</a>
        /// to propagate routes from a resource attachment to a transit gateway route table. If
        /// you disable automatic associations, you can use <a>AssociateTransitGatewayRouteTable</a>
        /// to associate a resource attachment with a transit gateway route table.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTransitGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTransitGateway service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateTransitGateway">REST API Reference for CreateTransitGateway Operation</seealso>
        public virtual Task<CreateTransitGatewayResponse> CreateTransitGatewayAsync(CreateTransitGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTransitGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTransitGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTransitGatewayResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateTransitGatewayRoute

        internal virtual CreateTransitGatewayRouteResponse CreateTransitGatewayRoute(CreateTransitGatewayRouteRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTransitGatewayRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTransitGatewayRouteResponseUnmarshaller.Instance;

            return Invoke<CreateTransitGatewayRouteResponse>(request, options);
        }



        /// <summary>
        /// Creates a static route for the specified transit gateway route table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTransitGatewayRoute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTransitGatewayRoute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateTransitGatewayRoute">REST API Reference for CreateTransitGatewayRoute Operation</seealso>
        public virtual Task<CreateTransitGatewayRouteResponse> CreateTransitGatewayRouteAsync(CreateTransitGatewayRouteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTransitGatewayRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTransitGatewayRouteResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTransitGatewayRouteResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateTransitGatewayRouteTable

        internal virtual CreateTransitGatewayRouteTableResponse CreateTransitGatewayRouteTable(CreateTransitGatewayRouteTableRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTransitGatewayRouteTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTransitGatewayRouteTableResponseUnmarshaller.Instance;

            return Invoke<CreateTransitGatewayRouteTableResponse>(request, options);
        }



        /// <summary>
        /// Creates a route table for the specified transit gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTransitGatewayRouteTable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTransitGatewayRouteTable service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateTransitGatewayRouteTable">REST API Reference for CreateTransitGatewayRouteTable Operation</seealso>
        public virtual Task<CreateTransitGatewayRouteTableResponse> CreateTransitGatewayRouteTableAsync(CreateTransitGatewayRouteTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTransitGatewayRouteTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTransitGatewayRouteTableResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTransitGatewayRouteTableResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateTransitGatewayVpcAttachment

        internal virtual CreateTransitGatewayVpcAttachmentResponse CreateTransitGatewayVpcAttachment(CreateTransitGatewayVpcAttachmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTransitGatewayVpcAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTransitGatewayVpcAttachmentResponseUnmarshaller.Instance;

            return Invoke<CreateTransitGatewayVpcAttachmentResponse>(request, options);
        }



        /// <summary>
        /// Attaches the specified VPC to the specified transit gateway.
        /// 
        ///  
        /// <para>
        /// If you attach a VPC with a CIDR range that overlaps the CIDR range of a VPC that is
        /// already attached, the new VPC CIDR range is not propagated to the default propagation
        /// route table.
        /// </para>
        ///  
        /// <para>
        /// To send VPC traffic to an attached transit gateway, add a route to the VPC route table
        /// using <a>CreateRoute</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTransitGatewayVpcAttachment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTransitGatewayVpcAttachment service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateTransitGatewayVpcAttachment">REST API Reference for CreateTransitGatewayVpcAttachment Operation</seealso>
        public virtual Task<CreateTransitGatewayVpcAttachmentResponse> CreateTransitGatewayVpcAttachmentAsync(CreateTransitGatewayVpcAttachmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTransitGatewayVpcAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTransitGatewayVpcAttachmentResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTransitGatewayVpcAttachmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateVolume

        internal virtual CreateVolumeResponse CreateVolume(CreateVolumeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVolumeResponseUnmarshaller.Instance;

            return Invoke<CreateVolumeResponse>(request, options);
        }



        /// <summary>
        /// Creates an EBS volume that can be attached to an instance in the same Availability
        /// Zone. The volume is created in the regional endpoint that you send the HTTP request
        /// to. For more information see <a href="https://docs.aws.amazon.com/general/latest/gr/rande.html">Regions
        /// and Endpoints</a>.
        /// 
        ///  
        /// <para>
        /// You can create a new empty volume or restore a volume from an EBS snapshot. Any AWS
        /// Marketplace product codes from the snapshot are propagated to the volume.
        /// </para>
        ///  
        /// <para>
        /// You can create encrypted volumes with the <code>Encrypted</code> parameter. Encrypted
        /// volumes may only be attached to instances that support Amazon EBS encryption. Volumes
        /// that are created from encrypted snapshots are also automatically encrypted. For more
        /// information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSEncryption.html">Amazon
        /// EBS Encryption</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can tag your volumes during creation. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html">Tagging
        /// Your Amazon EC2 Resources</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-creating-volume.html">Creating
        /// an Amazon EBS Volume</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVolume service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateVolume service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVolume">REST API Reference for CreateVolume Operation</seealso>
        public virtual Task<CreateVolumeResponse> CreateVolumeAsync(CreateVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVolumeResponseUnmarshaller.Instance;

            return InvokeAsync<CreateVolumeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateVpc

        internal virtual CreateVpcResponse CreateVpc(CreateVpcRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVpcRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpcResponseUnmarshaller.Instance;

            return Invoke<CreateVpcResponse>(request, options);
        }



        /// <summary>
        /// Creates a VPC with the specified IPv4 CIDR block. The smallest VPC you can create
        /// uses a /28 netmask (16 IPv4 addresses), and the largest uses a /16 netmask (65,536
        /// IPv4 addresses). For more information about how large to make your VPC, see <a href="https://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Subnets.html">Your
        /// VPC and Subnets</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// 
        ///  
        /// <para>
        /// You can optionally request an Amazon-provided IPv6 CIDR block for the VPC. The IPv6
        /// CIDR block uses a /56 prefix length, and is allocated from Amazon's pool of IPv6 addresses.
        /// You cannot choose the IPv6 range for your VPC.
        /// </para>
        ///  
        /// <para>
        /// By default, each instance you launch in the VPC has the default DHCP options, which
        /// include only a default DNS server that we provide (AmazonProvidedDNS). For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_DHCP_Options.html">DHCP
        /// Options Sets</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can specify the instance tenancy value for the VPC when you create it. You can't
        /// change this value for the VPC after you create it. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/dedicated-instance.html">Dedicated
        /// Instances</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVpc service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateVpc service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVpc">REST API Reference for CreateVpc Operation</seealso>
        public virtual Task<CreateVpcResponse> CreateVpcAsync(CreateVpcRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVpcRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpcResponseUnmarshaller.Instance;

            return InvokeAsync<CreateVpcResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateVpcEndpoint

        internal virtual CreateVpcEndpointResponse CreateVpcEndpoint(CreateVpcEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVpcEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpcEndpointResponseUnmarshaller.Instance;

            return Invoke<CreateVpcEndpointResponse>(request, options);
        }



        /// <summary>
        /// Creates a VPC endpoint for a specified service. An endpoint enables you to create
        /// a private connection between your VPC and the service. The service may be provided
        /// by AWS, an AWS Marketplace partner, or another AWS account. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/vpc-endpoints.html">VPC
        /// Endpoints</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// 
        ///  
        /// <para>
        /// A <code>gateway</code> endpoint serves as a target for a route in your route table
        /// for traffic destined for the AWS service. You can specify an endpoint policy to attach
        /// to the endpoint that will control access to the service from your VPC. You can also
        /// specify the VPC route tables that use the endpoint.
        /// </para>
        ///  
        /// <para>
        /// An <code>interface</code> endpoint is a network interface in your subnet that serves
        /// as an endpoint for communicating with the specified service. You can specify the subnets
        /// in which to create an endpoint, and the security groups to associate with the endpoint
        /// network interface.
        /// </para>
        ///  
        /// <para>
        /// Use <a>DescribeVpcEndpointServices</a> to get a list of supported services.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateVpcEndpoint service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVpcEndpoint">REST API Reference for CreateVpcEndpoint Operation</seealso>
        public virtual Task<CreateVpcEndpointResponse> CreateVpcEndpointAsync(CreateVpcEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVpcEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpcEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<CreateVpcEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateVpcEndpointConnectionNotification

        internal virtual CreateVpcEndpointConnectionNotificationResponse CreateVpcEndpointConnectionNotification(CreateVpcEndpointConnectionNotificationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVpcEndpointConnectionNotificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpcEndpointConnectionNotificationResponseUnmarshaller.Instance;

            return Invoke<CreateVpcEndpointConnectionNotificationResponse>(request, options);
        }



        /// <summary>
        /// Creates a connection notification for a specified VPC endpoint or VPC endpoint service.
        /// A connection notification notifies you of specific endpoint events. You must create
        /// an SNS topic to receive notifications. For more information, see <a href="https://docs.aws.amazon.com/sns/latest/dg/CreateTopic.html">Create
        /// a Topic</a> in the <i>Amazon Simple Notification Service Developer Guide</i>.
        /// 
        ///  
        /// <para>
        /// You can create a connection notification for interface endpoints only.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcEndpointConnectionNotification service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateVpcEndpointConnectionNotification service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVpcEndpointConnectionNotification">REST API Reference for CreateVpcEndpointConnectionNotification Operation</seealso>
        public virtual Task<CreateVpcEndpointConnectionNotificationResponse> CreateVpcEndpointConnectionNotificationAsync(CreateVpcEndpointConnectionNotificationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVpcEndpointConnectionNotificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpcEndpointConnectionNotificationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateVpcEndpointConnectionNotificationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateVpcEndpointServiceConfiguration

        internal virtual CreateVpcEndpointServiceConfigurationResponse CreateVpcEndpointServiceConfiguration(CreateVpcEndpointServiceConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVpcEndpointServiceConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpcEndpointServiceConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateVpcEndpointServiceConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Creates a VPC endpoint service configuration to which service consumers (AWS accounts,
        /// IAM users, and IAM roles) can connect. Service consumers can create an interface VPC
        /// endpoint to connect to your service.
        /// 
        ///  
        /// <para>
        /// To create an endpoint service configuration, you must first create a Network Load
        /// Balancer for your service. For more information, see <a href="https://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/endpoint-service.html">VPC
        /// Endpoint Services</a> in the <i>Amazon Virtual Private Cloud User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcEndpointServiceConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateVpcEndpointServiceConfiguration service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVpcEndpointServiceConfiguration">REST API Reference for CreateVpcEndpointServiceConfiguration Operation</seealso>
        public virtual Task<CreateVpcEndpointServiceConfigurationResponse> CreateVpcEndpointServiceConfigurationAsync(CreateVpcEndpointServiceConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVpcEndpointServiceConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpcEndpointServiceConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateVpcEndpointServiceConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateVpcPeeringConnection

        internal virtual CreateVpcPeeringConnectionResponse CreateVpcPeeringConnection(CreateVpcPeeringConnectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVpcPeeringConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpcPeeringConnectionResponseUnmarshaller.Instance;

            return Invoke<CreateVpcPeeringConnectionResponse>(request, options);
        }



        /// <summary>
        /// Requests a VPC peering connection between two VPCs: a requester VPC that you own and
        /// an accepter VPC with which to create the connection. The accepter VPC can belong to
        /// another AWS account and can be in a different Region to the requester VPC. The requester
        /// VPC and accepter VPC cannot have overlapping CIDR blocks.
        /// 
        ///  <note> 
        /// <para>
        /// Limitations and rules apply to a VPC peering connection. For more information, see
        /// the <a href="https://docs.aws.amazon.com/AmazonVPC/latest/PeeringGuide/vpc-peering-basics.html#vpc-peering-limitations">limitations</a>
        /// section in the <i>VPC Peering Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// The owner of the accepter VPC must accept the peering request to activate the peering
        /// connection. The VPC peering connection request expires after 7 days, after which it
        /// cannot be accepted or rejected.
        /// </para>
        ///  
        /// <para>
        /// If you create a VPC peering connection request between VPCs with overlapping CIDR
        /// blocks, the VPC peering connection has a status of <code>failed</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcPeeringConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateVpcPeeringConnection service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVpcPeeringConnection">REST API Reference for CreateVpcPeeringConnection Operation</seealso>
        public virtual Task<CreateVpcPeeringConnectionResponse> CreateVpcPeeringConnectionAsync(CreateVpcPeeringConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVpcPeeringConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpcPeeringConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateVpcPeeringConnectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateVpnConnection

        internal virtual CreateVpnConnectionResponse CreateVpnConnection(CreateVpnConnectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVpnConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpnConnectionResponseUnmarshaller.Instance;

            return Invoke<CreateVpnConnectionResponse>(request, options);
        }



        /// <summary>
        /// Creates a VPN connection between an existing virtual private gateway and a VPN customer
        /// gateway. The supported connection types are <code>ipsec.1</code> and <code>ipsec.2</code>.
        /// 
        ///  
        /// <para>
        /// The response includes information that you need to give to your network administrator
        /// to configure your customer gateway.
        /// </para>
        ///  <important> 
        /// <para>
        /// We strongly recommend that you use HTTPS when calling this operation because the response
        /// contains sensitive cryptographic information for configuring your customer gateway.
        /// </para>
        ///  </important> 
        /// <para>
        /// If you decide to shut down your VPN connection for any reason and later create a new
        /// VPN connection, you must reconfigure your customer gateway with the new information
        /// returned from this call.
        /// </para>
        ///  
        /// <para>
        /// This is an idempotent operation. If you perform the operation more than once, Amazon
        /// EC2 doesn't return an error.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/vpn/latest/s2svpn/VPC_VPN.html">AWS
        /// Site-to-Site VPN</a> in the <i>AWS Site-to-Site VPN User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVpnConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateVpnConnection service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVpnConnection">REST API Reference for CreateVpnConnection Operation</seealso>
        public virtual Task<CreateVpnConnectionResponse> CreateVpnConnectionAsync(CreateVpnConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVpnConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpnConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateVpnConnectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateVpnConnectionRoute

        internal virtual CreateVpnConnectionRouteResponse CreateVpnConnectionRoute(CreateVpnConnectionRouteRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVpnConnectionRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpnConnectionRouteResponseUnmarshaller.Instance;

            return Invoke<CreateVpnConnectionRouteResponse>(request, options);
        }



        /// <summary>
        /// Creates a static route associated with a VPN connection between an existing virtual
        /// private gateway and a VPN customer gateway. The static route allows traffic to be
        /// routed from the virtual private gateway to the VPN customer gateway.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/vpn/latest/s2svpn/VPC_VPN.html">AWS
        /// Site-to-Site VPN</a> in the <i>AWS Site-to-Site VPN User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVpnConnectionRoute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateVpnConnectionRoute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVpnConnectionRoute">REST API Reference for CreateVpnConnectionRoute Operation</seealso>
        public virtual Task<CreateVpnConnectionRouteResponse> CreateVpnConnectionRouteAsync(CreateVpnConnectionRouteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVpnConnectionRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpnConnectionRouteResponseUnmarshaller.Instance;

            return InvokeAsync<CreateVpnConnectionRouteResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateVpnGateway

        internal virtual CreateVpnGatewayResponse CreateVpnGateway(CreateVpnGatewayRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVpnGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpnGatewayResponseUnmarshaller.Instance;

            return Invoke<CreateVpnGatewayResponse>(request, options);
        }



        /// <summary>
        /// Creates a virtual private gateway. A virtual private gateway is the endpoint on the
        /// VPC side of your VPN connection. You can create a virtual private gateway before creating
        /// the VPC itself.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/vpn/latest/s2svpn/VPC_VPN.html">AWS
        /// Site-to-Site VPN</a> in the <i>AWS Site-to-Site VPN User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVpnGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateVpnGateway service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVpnGateway">REST API Reference for CreateVpnGateway Operation</seealso>
        public virtual Task<CreateVpnGatewayResponse> CreateVpnGatewayAsync(CreateVpnGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVpnGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpnGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<CreateVpnGatewayResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteClientVpnEndpoint

        internal virtual DeleteClientVpnEndpointResponse DeleteClientVpnEndpoint(DeleteClientVpnEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteClientVpnEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClientVpnEndpointResponseUnmarshaller.Instance;

            return Invoke<DeleteClientVpnEndpointResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified Client VPN endpoint. You must disassociate all target networks
        /// before you can delete a Client VPN endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteClientVpnEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteClientVpnEndpoint service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteClientVpnEndpoint">REST API Reference for DeleteClientVpnEndpoint Operation</seealso>
        public virtual Task<DeleteClientVpnEndpointResponse> DeleteClientVpnEndpointAsync(DeleteClientVpnEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteClientVpnEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClientVpnEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteClientVpnEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteClientVpnRoute

        internal virtual DeleteClientVpnRouteResponse DeleteClientVpnRoute(DeleteClientVpnRouteRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteClientVpnRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClientVpnRouteResponseUnmarshaller.Instance;

            return Invoke<DeleteClientVpnRouteResponse>(request, options);
        }



        /// <summary>
        /// Deletes a route from a Client VPN endpoint. You can only delete routes that you manually
        /// added using the <b>CreateClientVpnRoute</b> action. You cannot delete routes that
        /// were automatically added when associating a subnet. To remove routes that have been
        /// automatically added, disassociate the target subnet from the Client VPN endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteClientVpnRoute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteClientVpnRoute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteClientVpnRoute">REST API Reference for DeleteClientVpnRoute Operation</seealso>
        public virtual Task<DeleteClientVpnRouteResponse> DeleteClientVpnRouteAsync(DeleteClientVpnRouteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteClientVpnRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClientVpnRouteResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteClientVpnRouteResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteCustomerGateway

        internal virtual DeleteCustomerGatewayResponse DeleteCustomerGateway(DeleteCustomerGatewayRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCustomerGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCustomerGatewayResponseUnmarshaller.Instance;

            return Invoke<DeleteCustomerGatewayResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified customer gateway. You must delete the VPN connection before
        /// you can delete the customer gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomerGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCustomerGateway service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteCustomerGateway">REST API Reference for DeleteCustomerGateway Operation</seealso>
        public virtual Task<DeleteCustomerGatewayResponse> DeleteCustomerGatewayAsync(DeleteCustomerGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCustomerGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCustomerGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCustomerGatewayResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDhcpOptions

        internal virtual DeleteDhcpOptionsResponse DeleteDhcpOptions(DeleteDhcpOptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDhcpOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDhcpOptionsResponseUnmarshaller.Instance;

            return Invoke<DeleteDhcpOptionsResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified set of DHCP options. You must disassociate the set of DHCP options
        /// before you can delete it. You can disassociate the set of DHCP options by associating
        /// either a new set of options or the default set of options with the VPC.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDhcpOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDhcpOptions service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteDhcpOptions">REST API Reference for DeleteDhcpOptions Operation</seealso>
        public virtual Task<DeleteDhcpOptionsResponse> DeleteDhcpOptionsAsync(DeleteDhcpOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDhcpOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDhcpOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDhcpOptionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteEgressOnlyInternetGateway

        internal virtual DeleteEgressOnlyInternetGatewayResponse DeleteEgressOnlyInternetGateway(DeleteEgressOnlyInternetGatewayRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEgressOnlyInternetGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEgressOnlyInternetGatewayResponseUnmarshaller.Instance;

            return Invoke<DeleteEgressOnlyInternetGatewayResponse>(request, options);
        }



        /// <summary>
        /// Deletes an egress-only internet gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEgressOnlyInternetGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEgressOnlyInternetGateway service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteEgressOnlyInternetGateway">REST API Reference for DeleteEgressOnlyInternetGateway Operation</seealso>
        public virtual Task<DeleteEgressOnlyInternetGatewayResponse> DeleteEgressOnlyInternetGatewayAsync(DeleteEgressOnlyInternetGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEgressOnlyInternetGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEgressOnlyInternetGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteEgressOnlyInternetGatewayResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteFleets

        internal virtual DeleteFleetsResponse DeleteFleets(DeleteFleetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFleetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFleetsResponseUnmarshaller.Instance;

            return Invoke<DeleteFleetsResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified EC2 Fleet.
        /// 
        ///  
        /// <para>
        /// After you delete an EC2 Fleet, it launches no new instances. You must specify whether
        /// an EC2 Fleet should also terminate its instances. If you terminate the instances,
        /// the EC2 Fleet enters the <code>deleted_terminating</code> state. Otherwise, the EC2
        /// Fleet enters the <code>deleted_running</code> state, and the instances continue to
        /// run until they are interrupted or you terminate them manually. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFleets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFleets service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteFleets">REST API Reference for DeleteFleets Operation</seealso>
        public virtual Task<DeleteFleetsResponse> DeleteFleetsAsync(DeleteFleetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFleetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFleetsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFleetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteFlowLogs

        internal virtual DeleteFlowLogsResponse DeleteFlowLogs(DeleteFlowLogsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFlowLogsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFlowLogsResponseUnmarshaller.Instance;

            return Invoke<DeleteFlowLogsResponse>(request, options);
        }



        /// <summary>
        /// Deletes one or more flow logs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFlowLogs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFlowLogs service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteFlowLogs">REST API Reference for DeleteFlowLogs Operation</seealso>
        public virtual Task<DeleteFlowLogsResponse> DeleteFlowLogsAsync(DeleteFlowLogsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFlowLogsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFlowLogsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFlowLogsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteFpgaImage

        internal virtual DeleteFpgaImageResponse DeleteFpgaImage(DeleteFpgaImageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFpgaImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFpgaImageResponseUnmarshaller.Instance;

            return Invoke<DeleteFpgaImageResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified Amazon FPGA Image (AFI).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFpgaImage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFpgaImage service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteFpgaImage">REST API Reference for DeleteFpgaImage Operation</seealso>
        public virtual Task<DeleteFpgaImageResponse> DeleteFpgaImageAsync(DeleteFpgaImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFpgaImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFpgaImageResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFpgaImageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteInternetGateway

        internal virtual DeleteInternetGatewayResponse DeleteInternetGateway(DeleteInternetGatewayRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInternetGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInternetGatewayResponseUnmarshaller.Instance;

            return Invoke<DeleteInternetGatewayResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified internet gateway. You must detach the internet gateway from
        /// the VPC before you can delete it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInternetGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteInternetGateway service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteInternetGateway">REST API Reference for DeleteInternetGateway Operation</seealso>
        public virtual Task<DeleteInternetGatewayResponse> DeleteInternetGatewayAsync(DeleteInternetGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInternetGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInternetGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteInternetGatewayResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteKeyPair

        internal virtual DeleteKeyPairResponse DeleteKeyPair(DeleteKeyPairRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteKeyPairRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteKeyPairResponseUnmarshaller.Instance;

            return Invoke<DeleteKeyPairResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified key pair, by removing the public key from Amazon EC2.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteKeyPair service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteKeyPair service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteKeyPair">REST API Reference for DeleteKeyPair Operation</seealso>
        public virtual Task<DeleteKeyPairResponse> DeleteKeyPairAsync(DeleteKeyPairRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteKeyPairRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteKeyPairResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteKeyPairResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteLaunchTemplate

        internal virtual DeleteLaunchTemplateResponse DeleteLaunchTemplate(DeleteLaunchTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLaunchTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLaunchTemplateResponseUnmarshaller.Instance;

            return Invoke<DeleteLaunchTemplateResponse>(request, options);
        }



        /// <summary>
        /// Deletes a launch template. Deleting a launch template deletes all of its versions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLaunchTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLaunchTemplate service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteLaunchTemplate">REST API Reference for DeleteLaunchTemplate Operation</seealso>
        public virtual Task<DeleteLaunchTemplateResponse> DeleteLaunchTemplateAsync(DeleteLaunchTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLaunchTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLaunchTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLaunchTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteLaunchTemplateVersions

        internal virtual DeleteLaunchTemplateVersionsResponse DeleteLaunchTemplateVersions(DeleteLaunchTemplateVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLaunchTemplateVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLaunchTemplateVersionsResponseUnmarshaller.Instance;

            return Invoke<DeleteLaunchTemplateVersionsResponse>(request, options);
        }



        /// <summary>
        /// Deletes one or more versions of a launch template. You cannot delete the default version
        /// of a launch template; you must first assign a different version as the default. If
        /// the default version is the only version for the launch template, you must delete the
        /// entire launch template using <a>DeleteLaunchTemplate</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLaunchTemplateVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLaunchTemplateVersions service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteLaunchTemplateVersions">REST API Reference for DeleteLaunchTemplateVersions Operation</seealso>
        public virtual Task<DeleteLaunchTemplateVersionsResponse> DeleteLaunchTemplateVersionsAsync(DeleteLaunchTemplateVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLaunchTemplateVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLaunchTemplateVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLaunchTemplateVersionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteNatGateway

        internal virtual DeleteNatGatewayResponse DeleteNatGateway(DeleteNatGatewayRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNatGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNatGatewayResponseUnmarshaller.Instance;

            return Invoke<DeleteNatGatewayResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified NAT gateway. Deleting a NAT gateway disassociates its Elastic
        /// IP address, but does not release the address from your account. Deleting a NAT gateway
        /// does not delete any NAT gateway routes in your route tables.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNatGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteNatGateway service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteNatGateway">REST API Reference for DeleteNatGateway Operation</seealso>
        public virtual Task<DeleteNatGatewayResponse> DeleteNatGatewayAsync(DeleteNatGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNatGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNatGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteNatGatewayResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteNetworkAcl

        internal virtual DeleteNetworkAclResponse DeleteNetworkAcl(DeleteNetworkAclRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNetworkAclRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNetworkAclResponseUnmarshaller.Instance;

            return Invoke<DeleteNetworkAclResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified network ACL. You can't delete the ACL if it's associated with
        /// any subnets. You can't delete the default network ACL.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkAcl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteNetworkAcl service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteNetworkAcl">REST API Reference for DeleteNetworkAcl Operation</seealso>
        public virtual Task<DeleteNetworkAclResponse> DeleteNetworkAclAsync(DeleteNetworkAclRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNetworkAclRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNetworkAclResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteNetworkAclResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteNetworkAclEntry

        internal virtual DeleteNetworkAclEntryResponse DeleteNetworkAclEntry(DeleteNetworkAclEntryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNetworkAclEntryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNetworkAclEntryResponseUnmarshaller.Instance;

            return Invoke<DeleteNetworkAclEntryResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified ingress or egress entry (rule) from the specified network ACL.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkAclEntry service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteNetworkAclEntry service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteNetworkAclEntry">REST API Reference for DeleteNetworkAclEntry Operation</seealso>
        public virtual Task<DeleteNetworkAclEntryResponse> DeleteNetworkAclEntryAsync(DeleteNetworkAclEntryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNetworkAclEntryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNetworkAclEntryResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteNetworkAclEntryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteNetworkInterface

        internal virtual DeleteNetworkInterfaceResponse DeleteNetworkInterface(DeleteNetworkInterfaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNetworkInterfaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNetworkInterfaceResponseUnmarshaller.Instance;

            return Invoke<DeleteNetworkInterfaceResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified network interface. You must detach the network interface before
        /// you can delete it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkInterface service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteNetworkInterface service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteNetworkInterface">REST API Reference for DeleteNetworkInterface Operation</seealso>
        public virtual Task<DeleteNetworkInterfaceResponse> DeleteNetworkInterfaceAsync(DeleteNetworkInterfaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNetworkInterfaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNetworkInterfaceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteNetworkInterfaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteNetworkInterfacePermission

        internal virtual DeleteNetworkInterfacePermissionResponse DeleteNetworkInterfacePermission(DeleteNetworkInterfacePermissionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNetworkInterfacePermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNetworkInterfacePermissionResponseUnmarshaller.Instance;

            return Invoke<DeleteNetworkInterfacePermissionResponse>(request, options);
        }



        /// <summary>
        /// Deletes a permission for a network interface. By default, you cannot delete the permission
        /// if the account for which you're removing the permission has attached the network interface
        /// to an instance. However, you can force delete the permission, regardless of any attachment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkInterfacePermission service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteNetworkInterfacePermission service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteNetworkInterfacePermission">REST API Reference for DeleteNetworkInterfacePermission Operation</seealso>
        public virtual Task<DeleteNetworkInterfacePermissionResponse> DeleteNetworkInterfacePermissionAsync(DeleteNetworkInterfacePermissionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNetworkInterfacePermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNetworkInterfacePermissionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteNetworkInterfacePermissionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeletePlacementGroup

        internal virtual DeletePlacementGroupResponse DeletePlacementGroup(DeletePlacementGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePlacementGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePlacementGroupResponseUnmarshaller.Instance;

            return Invoke<DeletePlacementGroupResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified placement group. You must terminate all instances in the placement
        /// group before you can delete the placement group. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/placement-groups.html">Placement
        /// Groups</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePlacementGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePlacementGroup service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeletePlacementGroup">REST API Reference for DeletePlacementGroup Operation</seealso>
        public virtual Task<DeletePlacementGroupResponse> DeletePlacementGroupAsync(DeletePlacementGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePlacementGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePlacementGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePlacementGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteRoute

        internal virtual DeleteRouteResponse DeleteRoute(DeleteRouteRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRouteResponseUnmarshaller.Instance;

            return Invoke<DeleteRouteResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified route from the specified route table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRoute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteRoute">REST API Reference for DeleteRoute Operation</seealso>
        public virtual Task<DeleteRouteResponse> DeleteRouteAsync(DeleteRouteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRouteResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRouteResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteRouteTable

        internal virtual DeleteRouteTableResponse DeleteRouteTable(DeleteRouteTableRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRouteTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRouteTableResponseUnmarshaller.Instance;

            return Invoke<DeleteRouteTableResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified route table. You must disassociate the route table from any
        /// subnets before you can delete it. You can't delete the main route table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRouteTable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRouteTable service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteRouteTable">REST API Reference for DeleteRouteTable Operation</seealso>
        public virtual Task<DeleteRouteTableResponse> DeleteRouteTableAsync(DeleteRouteTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRouteTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRouteTableResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRouteTableResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSecurityGroup

        internal virtual DeleteSecurityGroupResponse DeleteSecurityGroup(DeleteSecurityGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSecurityGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSecurityGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteSecurityGroupResponse>(request, options);
        }



        /// <summary>
        /// Deletes a security group.
        /// 
        ///  
        /// <para>
        /// If you attempt to delete a security group that is associated with an instance, or
        /// is referenced by another security group, the operation fails with <code>InvalidGroup.InUse</code>
        /// in EC2-Classic or <code>DependencyViolation</code> in EC2-VPC.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSecurityGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSecurityGroup service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteSecurityGroup">REST API Reference for DeleteSecurityGroup Operation</seealso>
        public virtual Task<DeleteSecurityGroupResponse> DeleteSecurityGroupAsync(DeleteSecurityGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSecurityGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSecurityGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSecurityGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSnapshot

        internal virtual DeleteSnapshotResponse DeleteSnapshot(DeleteSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSnapshotResponseUnmarshaller.Instance;

            return Invoke<DeleteSnapshotResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified snapshot.
        /// 
        ///  
        /// <para>
        /// When you make periodic snapshots of a volume, the snapshots are incremental, and only
        /// the blocks on the device that have changed since your last snapshot are saved in the
        /// new snapshot. When you delete a snapshot, only the data not needed for any other snapshot
        /// is removed. So regardless of which prior snapshots have been deleted, all active snapshots
        /// will have access to all the information needed to restore the volume.
        /// </para>
        ///  
        /// <para>
        /// You cannot delete a snapshot of the root device of an EBS volume used by a registered
        /// AMI. You must first de-register the AMI before you can delete the snapshot.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-deleting-snapshot.html">Deleting
        /// an Amazon EBS Snapshot</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSnapshot service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteSnapshot">REST API Reference for DeleteSnapshot Operation</seealso>
        public virtual Task<DeleteSnapshotResponse> DeleteSnapshotAsync(DeleteSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSpotDatafeedSubscription

        internal virtual DeleteSpotDatafeedSubscriptionResponse DeleteSpotDatafeedSubscription()
        {
            return DeleteSpotDatafeedSubscription(new DeleteSpotDatafeedSubscriptionRequest());
        }
        internal virtual DeleteSpotDatafeedSubscriptionResponse DeleteSpotDatafeedSubscription(DeleteSpotDatafeedSubscriptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSpotDatafeedSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSpotDatafeedSubscriptionResponseUnmarshaller.Instance;

            return Invoke<DeleteSpotDatafeedSubscriptionResponse>(request, options);
        }


        /// <summary>
        /// Deletes the data feed for Spot Instances.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSpotDatafeedSubscription service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteSpotDatafeedSubscription">REST API Reference for DeleteSpotDatafeedSubscription Operation</seealso>
        public virtual Task<DeleteSpotDatafeedSubscriptionResponse> DeleteSpotDatafeedSubscriptionAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DeleteSpotDatafeedSubscriptionAsync(new DeleteSpotDatafeedSubscriptionRequest(), cancellationToken);
        }



        /// <summary>
        /// Deletes the data feed for Spot Instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSpotDatafeedSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSpotDatafeedSubscription service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteSpotDatafeedSubscription">REST API Reference for DeleteSpotDatafeedSubscription Operation</seealso>
        public virtual Task<DeleteSpotDatafeedSubscriptionResponse> DeleteSpotDatafeedSubscriptionAsync(DeleteSpotDatafeedSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSpotDatafeedSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSpotDatafeedSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSpotDatafeedSubscriptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSubnet

        internal virtual DeleteSubnetResponse DeleteSubnet(DeleteSubnetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSubnetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSubnetResponseUnmarshaller.Instance;

            return Invoke<DeleteSubnetResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified subnet. You must terminate all running instances in the subnet
        /// before you can delete the subnet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubnet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSubnet service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteSubnet">REST API Reference for DeleteSubnet Operation</seealso>
        public virtual Task<DeleteSubnetResponse> DeleteSubnetAsync(DeleteSubnetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSubnetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSubnetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSubnetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteTags

        internal virtual DeleteTagsResponse DeleteTags(DeleteTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTagsResponseUnmarshaller.Instance;

            return Invoke<DeleteTagsResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified set of tags from the specified set of resources.
        /// 
        ///  
        /// <para>
        /// To list the current tags, use <a>DescribeTags</a>. For more information about tags,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html">Tagging
        /// Your Resources</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTags service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteTags">REST API Reference for DeleteTags Operation</seealso>
        public virtual Task<DeleteTagsResponse> DeleteTagsAsync(DeleteTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTagsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteTransitGateway

        internal virtual DeleteTransitGatewayResponse DeleteTransitGateway(DeleteTransitGatewayRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTransitGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTransitGatewayResponseUnmarshaller.Instance;

            return Invoke<DeleteTransitGatewayResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified transit gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTransitGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTransitGateway service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteTransitGateway">REST API Reference for DeleteTransitGateway Operation</seealso>
        public virtual Task<DeleteTransitGatewayResponse> DeleteTransitGatewayAsync(DeleteTransitGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTransitGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTransitGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTransitGatewayResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteTransitGatewayRoute

        internal virtual DeleteTransitGatewayRouteResponse DeleteTransitGatewayRoute(DeleteTransitGatewayRouteRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTransitGatewayRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTransitGatewayRouteResponseUnmarshaller.Instance;

            return Invoke<DeleteTransitGatewayRouteResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified route from the specified transit gateway route table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTransitGatewayRoute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTransitGatewayRoute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteTransitGatewayRoute">REST API Reference for DeleteTransitGatewayRoute Operation</seealso>
        public virtual Task<DeleteTransitGatewayRouteResponse> DeleteTransitGatewayRouteAsync(DeleteTransitGatewayRouteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTransitGatewayRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTransitGatewayRouteResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTransitGatewayRouteResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteTransitGatewayRouteTable

        internal virtual DeleteTransitGatewayRouteTableResponse DeleteTransitGatewayRouteTable(DeleteTransitGatewayRouteTableRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTransitGatewayRouteTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTransitGatewayRouteTableResponseUnmarshaller.Instance;

            return Invoke<DeleteTransitGatewayRouteTableResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified transit gateway route table. You must disassociate the route
        /// table from any transit gateway route tables before you can delete it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTransitGatewayRouteTable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTransitGatewayRouteTable service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteTransitGatewayRouteTable">REST API Reference for DeleteTransitGatewayRouteTable Operation</seealso>
        public virtual Task<DeleteTransitGatewayRouteTableResponse> DeleteTransitGatewayRouteTableAsync(DeleteTransitGatewayRouteTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTransitGatewayRouteTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTransitGatewayRouteTableResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTransitGatewayRouteTableResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteTransitGatewayVpcAttachment

        internal virtual DeleteTransitGatewayVpcAttachmentResponse DeleteTransitGatewayVpcAttachment(DeleteTransitGatewayVpcAttachmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTransitGatewayVpcAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTransitGatewayVpcAttachmentResponseUnmarshaller.Instance;

            return Invoke<DeleteTransitGatewayVpcAttachmentResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified VPC attachment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTransitGatewayVpcAttachment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTransitGatewayVpcAttachment service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteTransitGatewayVpcAttachment">REST API Reference for DeleteTransitGatewayVpcAttachment Operation</seealso>
        public virtual Task<DeleteTransitGatewayVpcAttachmentResponse> DeleteTransitGatewayVpcAttachmentAsync(DeleteTransitGatewayVpcAttachmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTransitGatewayVpcAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTransitGatewayVpcAttachmentResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTransitGatewayVpcAttachmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteVolume

        internal virtual DeleteVolumeResponse DeleteVolume(DeleteVolumeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVolumeResponseUnmarshaller.Instance;

            return Invoke<DeleteVolumeResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified EBS volume. The volume must be in the <code>available</code>
        /// state (not attached to an instance).
        /// 
        ///  
        /// <para>
        /// The volume can remain in the <code>deleting</code> state for several minutes.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-deleting-volume.html">Deleting
        /// an Amazon EBS Volume</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVolume service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVolume service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVolume">REST API Reference for DeleteVolume Operation</seealso>
        public virtual Task<DeleteVolumeResponse> DeleteVolumeAsync(DeleteVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVolumeResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVolumeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteVpc

        internal virtual DeleteVpcResponse DeleteVpc(DeleteVpcRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVpcRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVpcResponseUnmarshaller.Instance;

            return Invoke<DeleteVpcResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified VPC. You must detach or delete all gateways and resources that
        /// are associated with the VPC before you can delete it. For example, you must terminate
        /// all instances running in the VPC, delete all security groups associated with the VPC
        /// (except the default one), delete all route tables associated with the VPC (except
        /// the default one), and so on.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpc service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVpc service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVpc">REST API Reference for DeleteVpc Operation</seealso>
        public virtual Task<DeleteVpcResponse> DeleteVpcAsync(DeleteVpcRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVpcRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVpcResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVpcResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteVpcEndpointConnectionNotifications

        internal virtual DeleteVpcEndpointConnectionNotificationsResponse DeleteVpcEndpointConnectionNotifications(DeleteVpcEndpointConnectionNotificationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVpcEndpointConnectionNotificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVpcEndpointConnectionNotificationsResponseUnmarshaller.Instance;

            return Invoke<DeleteVpcEndpointConnectionNotificationsResponse>(request, options);
        }



        /// <summary>
        /// Deletes one or more VPC endpoint connection notifications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcEndpointConnectionNotifications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVpcEndpointConnectionNotifications service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVpcEndpointConnectionNotifications">REST API Reference for DeleteVpcEndpointConnectionNotifications Operation</seealso>
        public virtual Task<DeleteVpcEndpointConnectionNotificationsResponse> DeleteVpcEndpointConnectionNotificationsAsync(DeleteVpcEndpointConnectionNotificationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVpcEndpointConnectionNotificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVpcEndpointConnectionNotificationsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVpcEndpointConnectionNotificationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteVpcEndpoints

        internal virtual DeleteVpcEndpointsResponse DeleteVpcEndpoints(DeleteVpcEndpointsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVpcEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVpcEndpointsResponseUnmarshaller.Instance;

            return Invoke<DeleteVpcEndpointsResponse>(request, options);
        }



        /// <summary>
        /// Deletes one or more specified VPC endpoints. Deleting a gateway endpoint also deletes
        /// the endpoint routes in the route tables that were associated with the endpoint. Deleting
        /// an interface endpoint deletes the endpoint network interfaces.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcEndpoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVpcEndpoints service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVpcEndpoints">REST API Reference for DeleteVpcEndpoints Operation</seealso>
        public virtual Task<DeleteVpcEndpointsResponse> DeleteVpcEndpointsAsync(DeleteVpcEndpointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVpcEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVpcEndpointsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVpcEndpointsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteVpcEndpointServiceConfigurations

        internal virtual DeleteVpcEndpointServiceConfigurationsResponse DeleteVpcEndpointServiceConfigurations(DeleteVpcEndpointServiceConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVpcEndpointServiceConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVpcEndpointServiceConfigurationsResponseUnmarshaller.Instance;

            return Invoke<DeleteVpcEndpointServiceConfigurationsResponse>(request, options);
        }



        /// <summary>
        /// Deletes one or more VPC endpoint service configurations in your account. Before you
        /// delete the endpoint service configuration, you must reject any <code>Available</code>
        /// or <code>PendingAcceptance</code> interface endpoint connections that are attached
        /// to the service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcEndpointServiceConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVpcEndpointServiceConfigurations service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVpcEndpointServiceConfigurations">REST API Reference for DeleteVpcEndpointServiceConfigurations Operation</seealso>
        public virtual Task<DeleteVpcEndpointServiceConfigurationsResponse> DeleteVpcEndpointServiceConfigurationsAsync(DeleteVpcEndpointServiceConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVpcEndpointServiceConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVpcEndpointServiceConfigurationsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVpcEndpointServiceConfigurationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteVpcPeeringConnection

        internal virtual DeleteVpcPeeringConnectionResponse DeleteVpcPeeringConnection(DeleteVpcPeeringConnectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVpcPeeringConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVpcPeeringConnectionResponseUnmarshaller.Instance;

            return Invoke<DeleteVpcPeeringConnectionResponse>(request, options);
        }



        /// <summary>
        /// Deletes a VPC peering connection. Either the owner of the requester VPC or the owner
        /// of the accepter VPC can delete the VPC peering connection if it's in the <code>active</code>
        /// state. The owner of the requester VPC can delete a VPC peering connection in the <code>pending-acceptance</code>
        /// state. You cannot delete a VPC peering connection that's in the <code>failed</code>
        /// state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcPeeringConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVpcPeeringConnection service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVpcPeeringConnection">REST API Reference for DeleteVpcPeeringConnection Operation</seealso>
        public virtual Task<DeleteVpcPeeringConnectionResponse> DeleteVpcPeeringConnectionAsync(DeleteVpcPeeringConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVpcPeeringConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVpcPeeringConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVpcPeeringConnectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteVpnConnection

        internal virtual DeleteVpnConnectionResponse DeleteVpnConnection(DeleteVpnConnectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVpnConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVpnConnectionResponseUnmarshaller.Instance;

            return Invoke<DeleteVpnConnectionResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified VPN connection.
        /// 
        ///  
        /// <para>
        /// If you're deleting the VPC and its associated components, we recommend that you detach
        /// the virtual private gateway from the VPC and delete the VPC before deleting the VPN
        /// connection. If you believe that the tunnel credentials for your VPN connection have
        /// been compromised, you can delete the VPN connection and create a new one that has
        /// new keys, without needing to delete the VPC or virtual private gateway. If you create
        /// a new VPN connection, you must reconfigure the customer gateway using the new configuration
        /// information returned with the new VPN connection ID.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpnConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVpnConnection service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVpnConnection">REST API Reference for DeleteVpnConnection Operation</seealso>
        public virtual Task<DeleteVpnConnectionResponse> DeleteVpnConnectionAsync(DeleteVpnConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVpnConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVpnConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVpnConnectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteVpnConnectionRoute

        internal virtual DeleteVpnConnectionRouteResponse DeleteVpnConnectionRoute(DeleteVpnConnectionRouteRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVpnConnectionRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVpnConnectionRouteResponseUnmarshaller.Instance;

            return Invoke<DeleteVpnConnectionRouteResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified static route associated with a VPN connection between an existing
        /// virtual private gateway and a VPN customer gateway. The static route allows traffic
        /// to be routed from the virtual private gateway to the VPN customer gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpnConnectionRoute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVpnConnectionRoute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVpnConnectionRoute">REST API Reference for DeleteVpnConnectionRoute Operation</seealso>
        public virtual Task<DeleteVpnConnectionRouteResponse> DeleteVpnConnectionRouteAsync(DeleteVpnConnectionRouteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVpnConnectionRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVpnConnectionRouteResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVpnConnectionRouteResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteVpnGateway

        internal virtual DeleteVpnGatewayResponse DeleteVpnGateway(DeleteVpnGatewayRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVpnGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVpnGatewayResponseUnmarshaller.Instance;

            return Invoke<DeleteVpnGatewayResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified virtual private gateway. We recommend that before you delete
        /// a virtual private gateway, you detach it from the VPC and delete the VPN connection.
        /// Note that you don't need to delete the virtual private gateway if you plan to delete
        /// and recreate the VPN connection between your VPC and your network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpnGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVpnGateway service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVpnGateway">REST API Reference for DeleteVpnGateway Operation</seealso>
        public virtual Task<DeleteVpnGatewayResponse> DeleteVpnGatewayAsync(DeleteVpnGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVpnGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVpnGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVpnGatewayResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeprovisionByoipCidr

        internal virtual DeprovisionByoipCidrResponse DeprovisionByoipCidr(DeprovisionByoipCidrRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeprovisionByoipCidrRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeprovisionByoipCidrResponseUnmarshaller.Instance;

            return Invoke<DeprovisionByoipCidrResponse>(request, options);
        }



        /// <summary>
        /// Releases the specified address range that you provisioned for use with your AWS resources
        /// through bring your own IP addresses (BYOIP) and deletes the corresponding address
        /// pool.
        /// 
        ///  
        /// <para>
        /// Before you can release an address range, you must stop advertising it using <a>WithdrawByoipCidr</a>
        /// and you must not have any IP addresses allocated from its address range.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeprovisionByoipCidr service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeprovisionByoipCidr service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeprovisionByoipCidr">REST API Reference for DeprovisionByoipCidr Operation</seealso>
        public virtual Task<DeprovisionByoipCidrResponse> DeprovisionByoipCidrAsync(DeprovisionByoipCidrRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeprovisionByoipCidrRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeprovisionByoipCidrResponseUnmarshaller.Instance;

            return InvokeAsync<DeprovisionByoipCidrResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeregisterImage

        internal virtual DeregisterImageResponse DeregisterImage(DeregisterImageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterImageResponseUnmarshaller.Instance;

            return Invoke<DeregisterImageResponse>(request, options);
        }



        /// <summary>
        /// Deregisters the specified AMI. After you deregister an AMI, it can't be used to launch
        /// new instances; however, it doesn't affect any instances that you've already launched
        /// from the AMI. You'll continue to incur usage costs for those instances until you terminate
        /// them.
        /// 
        ///  
        /// <para>
        /// When you deregister an Amazon EBS-backed AMI, it doesn't affect the snapshot that
        /// was created for the root volume of the instance during the AMI creation process. When
        /// you deregister an instance store-backed AMI, it doesn't affect the files that you
        /// uploaded to Amazon S3 when you created the AMI.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterImage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeregisterImage service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeregisterImage">REST API Reference for DeregisterImage Operation</seealso>
        public virtual Task<DeregisterImageResponse> DeregisterImageAsync(DeregisterImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterImageResponseUnmarshaller.Instance;

            return InvokeAsync<DeregisterImageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAccountAttributes

        internal virtual DescribeAccountAttributesResponse DescribeAccountAttributes()
        {
            return DescribeAccountAttributes(new DescribeAccountAttributesRequest());
        }
        internal virtual DescribeAccountAttributesResponse DescribeAccountAttributes(DescribeAccountAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccountAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountAttributesResponseUnmarshaller.Instance;

            return Invoke<DescribeAccountAttributesResponse>(request, options);
        }


        /// <summary>
        /// Describes attributes of your AWS account. The following are the supported account
        /// attributes:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <code>supported-platforms</code>: Indicates whether your account can launch instances
        /// into EC2-Classic and EC2-VPC, or only into EC2-VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>default-vpc</code>: The ID of the default VPC for your account, or <code>none</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>max-instances</code>: The maximum number of On-Demand Instances that you can
        /// run.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>vpc-max-security-groups-per-interface</code>: The maximum number of security
        /// groups that you can assign to a network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>max-elastic-ips</code>: The maximum number of Elastic IP addresses that you
        /// can allocate for use with EC2-Classic. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>vpc-max-elastic-ips</code>: The maximum number of Elastic IP addresses that
        /// you can allocate for use with EC2-VPC.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAccountAttributes service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeAccountAttributes">REST API Reference for DescribeAccountAttributes Operation</seealso>
        public virtual Task<DescribeAccountAttributesResponse> DescribeAccountAttributesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeAccountAttributesAsync(new DescribeAccountAttributesRequest(), cancellationToken);
        }



        /// <summary>
        /// Describes attributes of your AWS account. The following are the supported account
        /// attributes:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <code>supported-platforms</code>: Indicates whether your account can launch instances
        /// into EC2-Classic and EC2-VPC, or only into EC2-VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>default-vpc</code>: The ID of the default VPC for your account, or <code>none</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>max-instances</code>: The maximum number of On-Demand Instances that you can
        /// run.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>vpc-max-security-groups-per-interface</code>: The maximum number of security
        /// groups that you can assign to a network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>max-elastic-ips</code>: The maximum number of Elastic IP addresses that you
        /// can allocate for use with EC2-Classic. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>vpc-max-elastic-ips</code>: The maximum number of Elastic IP addresses that
        /// you can allocate for use with EC2-VPC.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAccountAttributes service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeAccountAttributes">REST API Reference for DescribeAccountAttributes Operation</seealso>
        public virtual Task<DescribeAccountAttributesResponse> DescribeAccountAttributesAsync(DescribeAccountAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccountAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAccountAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAddresses

        internal virtual DescribeAddressesResponse DescribeAddresses()
        {
            return DescribeAddresses(new DescribeAddressesRequest());
        }
        internal virtual DescribeAddressesResponse DescribeAddresses(DescribeAddressesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAddressesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAddressesResponseUnmarshaller.Instance;

            return Invoke<DescribeAddressesResponse>(request, options);
        }


        /// <summary>
        /// Describes the specified Elastic IP addresses or all of your Elastic IP addresses.
        /// 
        ///  
        /// <para>
        /// An Elastic IP address is for use in either the EC2-Classic platform or in a VPC. For
        /// more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html">Elastic
        /// IP Addresses</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAddresses service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeAddresses">REST API Reference for DescribeAddresses Operation</seealso>
        public virtual Task<DescribeAddressesResponse> DescribeAddressesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeAddressesAsync(new DescribeAddressesRequest(), cancellationToken);
        }



        /// <summary>
        /// Describes the specified Elastic IP addresses or all of your Elastic IP addresses.
        /// 
        ///  
        /// <para>
        /// An Elastic IP address is for use in either the EC2-Classic platform or in a VPC. For
        /// more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html">Elastic
        /// IP Addresses</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAddresses service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAddresses service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeAddresses">REST API Reference for DescribeAddresses Operation</seealso>
        public virtual Task<DescribeAddressesResponse> DescribeAddressesAsync(DescribeAddressesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAddressesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAddressesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAddressesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAggregateIdFormat

        internal virtual DescribeAggregateIdFormatResponse DescribeAggregateIdFormat(DescribeAggregateIdFormatRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAggregateIdFormatRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAggregateIdFormatResponseUnmarshaller.Instance;

            return Invoke<DescribeAggregateIdFormatResponse>(request, options);
        }



        /// <summary>
        /// Describes the longer ID format settings for all resource types in a specific Region.
        /// This request is useful for performing a quick audit to determine whether a specific
        /// Region is fully opted in for longer IDs (17-character IDs).
        /// 
        ///  
        /// <para>
        /// This request only returns information about resource types that support longer IDs.
        /// </para>
        ///  
        /// <para>
        /// The following resource types support longer IDs: <code>bundle</code> | <code>conversion-task</code>
        /// | <code>customer-gateway</code> | <code>dhcp-options</code> | <code>elastic-ip-allocation</code>
        /// | <code>elastic-ip-association</code> | <code>export-task</code> | <code>flow-log</code>
        /// | <code>image</code> | <code>import-task</code> | <code>instance</code> | <code>internet-gateway</code>
        /// | <code>network-acl</code> | <code>network-acl-association</code> | <code>network-interface</code>
        /// | <code>network-interface-attachment</code> | <code>prefix-list</code> | <code>reservation</code>
        /// | <code>route-table</code> | <code>route-table-association</code> | <code>security-group</code>
        /// | <code>snapshot</code> | <code>subnet</code> | <code>subnet-cidr-block-association</code>
        /// | <code>volume</code> | <code>vpc</code> | <code>vpc-cidr-block-association</code>
        /// | <code>vpc-endpoint</code> | <code>vpc-peering-connection</code> | <code>vpn-connection</code>
        /// | <code>vpn-gateway</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAggregateIdFormat service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAggregateIdFormat service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeAggregateIdFormat">REST API Reference for DescribeAggregateIdFormat Operation</seealso>
        public virtual Task<DescribeAggregateIdFormatResponse> DescribeAggregateIdFormatAsync(DescribeAggregateIdFormatRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAggregateIdFormatRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAggregateIdFormatResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAggregateIdFormatResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAvailabilityZones

        internal virtual DescribeAvailabilityZonesResponse DescribeAvailabilityZones()
        {
            return DescribeAvailabilityZones(new DescribeAvailabilityZonesRequest());
        }
        internal virtual DescribeAvailabilityZonesResponse DescribeAvailabilityZones(DescribeAvailabilityZonesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAvailabilityZonesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAvailabilityZonesResponseUnmarshaller.Instance;

            return Invoke<DescribeAvailabilityZonesResponse>(request, options);
        }


        /// <summary>
        /// Describes the Availability Zones that are available to you. The results include zones
        /// only for the Region you're currently using. If there is an event impacting an Availability
        /// Zone, you can use this request to view the state and any provided message for that
        /// Availability Zone.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-regions-availability-zones.html">Regions
        /// and Availability Zones</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAvailabilityZones service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeAvailabilityZones">REST API Reference for DescribeAvailabilityZones Operation</seealso>
        public virtual Task<DescribeAvailabilityZonesResponse> DescribeAvailabilityZonesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeAvailabilityZonesAsync(new DescribeAvailabilityZonesRequest(), cancellationToken);
        }



        /// <summary>
        /// Describes the Availability Zones that are available to you. The results include zones
        /// only for the Region you're currently using. If there is an event impacting an Availability
        /// Zone, you can use this request to view the state and any provided message for that
        /// Availability Zone.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-regions-availability-zones.html">Regions
        /// and Availability Zones</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAvailabilityZones service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAvailabilityZones service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeAvailabilityZones">REST API Reference for DescribeAvailabilityZones Operation</seealso>
        public virtual Task<DescribeAvailabilityZonesResponse> DescribeAvailabilityZonesAsync(DescribeAvailabilityZonesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAvailabilityZonesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAvailabilityZonesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAvailabilityZonesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeBundleTasks

        internal virtual DescribeBundleTasksResponse DescribeBundleTasks()
        {
            return DescribeBundleTasks(new DescribeBundleTasksRequest());
        }
        internal virtual DescribeBundleTasksResponse DescribeBundleTasks(DescribeBundleTasksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeBundleTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBundleTasksResponseUnmarshaller.Instance;

            return Invoke<DescribeBundleTasksResponse>(request, options);
        }


        /// <summary>
        /// Describes the specified bundle tasks or all of your bundle tasks.
        /// 
        ///  <note> 
        /// <para>
        /// Completed bundle tasks are listed for only a limited time. If your bundle task is
        /// no longer in the list, you can still register an AMI from it. Just use <code>RegisterImage</code>
        /// with the Amazon S3 bucket name and image manifest name you provided to the bundle
        /// task.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeBundleTasks service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeBundleTasks">REST API Reference for DescribeBundleTasks Operation</seealso>
        public virtual Task<DescribeBundleTasksResponse> DescribeBundleTasksAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeBundleTasksAsync(new DescribeBundleTasksRequest(), cancellationToken);
        }



        /// <summary>
        /// Describes the specified bundle tasks or all of your bundle tasks.
        /// 
        ///  <note> 
        /// <para>
        /// Completed bundle tasks are listed for only a limited time. If your bundle task is
        /// no longer in the list, you can still register an AMI from it. Just use <code>RegisterImage</code>
        /// with the Amazon S3 bucket name and image manifest name you provided to the bundle
        /// task.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBundleTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeBundleTasks service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeBundleTasks">REST API Reference for DescribeBundleTasks Operation</seealso>
        public virtual Task<DescribeBundleTasksResponse> DescribeBundleTasksAsync(DescribeBundleTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeBundleTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBundleTasksResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeBundleTasksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeByoipCidrs

        internal virtual DescribeByoipCidrsResponse DescribeByoipCidrs(DescribeByoipCidrsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeByoipCidrsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeByoipCidrsResponseUnmarshaller.Instance;

            return Invoke<DescribeByoipCidrsResponse>(request, options);
        }



        /// <summary>
        /// Describes the IP address ranges that were specified in calls to <a>ProvisionByoipCidr</a>.
        /// 
        ///  
        /// <para>
        /// To describe the address pools that were created when you provisioned the address ranges,
        /// use <a>DescribePublicIpv4Pools</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeByoipCidrs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeByoipCidrs service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeByoipCidrs">REST API Reference for DescribeByoipCidrs Operation</seealso>
        public virtual Task<DescribeByoipCidrsResponse> DescribeByoipCidrsAsync(DescribeByoipCidrsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeByoipCidrsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeByoipCidrsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeByoipCidrsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeCapacityReservations

        internal virtual DescribeCapacityReservationsResponse DescribeCapacityReservations(DescribeCapacityReservationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCapacityReservationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCapacityReservationsResponseUnmarshaller.Instance;

            return Invoke<DescribeCapacityReservationsResponse>(request, options);
        }



        /// <summary>
        /// Describes one or more of your Capacity Reservations. The results describe only the
        /// Capacity Reservations in the AWS Region that you're currently using.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCapacityReservations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCapacityReservations service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeCapacityReservations">REST API Reference for DescribeCapacityReservations Operation</seealso>
        public virtual Task<DescribeCapacityReservationsResponse> DescribeCapacityReservationsAsync(DescribeCapacityReservationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCapacityReservationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCapacityReservationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeCapacityReservationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeClassicLinkInstances

        internal virtual DescribeClassicLinkInstancesResponse DescribeClassicLinkInstances(DescribeClassicLinkInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClassicLinkInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClassicLinkInstancesResponseUnmarshaller.Instance;

            return Invoke<DescribeClassicLinkInstancesResponse>(request, options);
        }



        /// <summary>
        /// Describes one or more of your linked EC2-Classic instances. This request only returns
        /// information about EC2-Classic instances linked to a VPC through ClassicLink. You cannot
        /// use this request to return information about other instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClassicLinkInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeClassicLinkInstances service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeClassicLinkInstances">REST API Reference for DescribeClassicLinkInstances Operation</seealso>
        public virtual Task<DescribeClassicLinkInstancesResponse> DescribeClassicLinkInstancesAsync(DescribeClassicLinkInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClassicLinkInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClassicLinkInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeClassicLinkInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeClientVpnAuthorizationRules

        internal virtual DescribeClientVpnAuthorizationRulesResponse DescribeClientVpnAuthorizationRules(DescribeClientVpnAuthorizationRulesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClientVpnAuthorizationRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClientVpnAuthorizationRulesResponseUnmarshaller.Instance;

            return Invoke<DescribeClientVpnAuthorizationRulesResponse>(request, options);
        }



        /// <summary>
        /// Describes the authorization rules for a specified Client VPN endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClientVpnAuthorizationRules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeClientVpnAuthorizationRules service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeClientVpnAuthorizationRules">REST API Reference for DescribeClientVpnAuthorizationRules Operation</seealso>
        public virtual Task<DescribeClientVpnAuthorizationRulesResponse> DescribeClientVpnAuthorizationRulesAsync(DescribeClientVpnAuthorizationRulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClientVpnAuthorizationRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClientVpnAuthorizationRulesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeClientVpnAuthorizationRulesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeClientVpnConnections

        internal virtual DescribeClientVpnConnectionsResponse DescribeClientVpnConnections(DescribeClientVpnConnectionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClientVpnConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClientVpnConnectionsResponseUnmarshaller.Instance;

            return Invoke<DescribeClientVpnConnectionsResponse>(request, options);
        }



        /// <summary>
        /// Describes active client connections and connections that have been terminated within
        /// the last 60 minutes for the specified Client VPN endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClientVpnConnections service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeClientVpnConnections service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeClientVpnConnections">REST API Reference for DescribeClientVpnConnections Operation</seealso>
        public virtual Task<DescribeClientVpnConnectionsResponse> DescribeClientVpnConnectionsAsync(DescribeClientVpnConnectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClientVpnConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClientVpnConnectionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeClientVpnConnectionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeClientVpnEndpoints

        internal virtual DescribeClientVpnEndpointsResponse DescribeClientVpnEndpoints(DescribeClientVpnEndpointsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClientVpnEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClientVpnEndpointsResponseUnmarshaller.Instance;

            return Invoke<DescribeClientVpnEndpointsResponse>(request, options);
        }



        /// <summary>
        /// Describes one or more Client VPN endpoints in the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClientVpnEndpoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeClientVpnEndpoints service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeClientVpnEndpoints">REST API Reference for DescribeClientVpnEndpoints Operation</seealso>
        public virtual Task<DescribeClientVpnEndpointsResponse> DescribeClientVpnEndpointsAsync(DescribeClientVpnEndpointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClientVpnEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClientVpnEndpointsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeClientVpnEndpointsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeClientVpnRoutes

        internal virtual DescribeClientVpnRoutesResponse DescribeClientVpnRoutes(DescribeClientVpnRoutesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClientVpnRoutesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClientVpnRoutesResponseUnmarshaller.Instance;

            return Invoke<DescribeClientVpnRoutesResponse>(request, options);
        }



        /// <summary>
        /// Describes the routes for the specified Client VPN endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClientVpnRoutes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeClientVpnRoutes service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeClientVpnRoutes">REST API Reference for DescribeClientVpnRoutes Operation</seealso>
        public virtual Task<DescribeClientVpnRoutesResponse> DescribeClientVpnRoutesAsync(DescribeClientVpnRoutesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClientVpnRoutesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClientVpnRoutesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeClientVpnRoutesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeClientVpnTargetNetworks

        internal virtual DescribeClientVpnTargetNetworksResponse DescribeClientVpnTargetNetworks(DescribeClientVpnTargetNetworksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClientVpnTargetNetworksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClientVpnTargetNetworksResponseUnmarshaller.Instance;

            return Invoke<DescribeClientVpnTargetNetworksResponse>(request, options);
        }



        /// <summary>
        /// Describes the target networks associated with the specified Client VPN endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClientVpnTargetNetworks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeClientVpnTargetNetworks service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeClientVpnTargetNetworks">REST API Reference for DescribeClientVpnTargetNetworks Operation</seealso>
        public virtual Task<DescribeClientVpnTargetNetworksResponse> DescribeClientVpnTargetNetworksAsync(DescribeClientVpnTargetNetworksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClientVpnTargetNetworksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClientVpnTargetNetworksResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeClientVpnTargetNetworksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeConversionTasks

        internal virtual DescribeConversionTasksResponse DescribeConversionTasks()
        {
            return DescribeConversionTasks(new DescribeConversionTasksRequest());
        }
        internal virtual DescribeConversionTasksResponse DescribeConversionTasks(DescribeConversionTasksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConversionTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConversionTasksResponseUnmarshaller.Instance;

            return Invoke<DescribeConversionTasksResponse>(request, options);
        }


        /// <summary>
        /// Describes the specified conversion tasks or all your conversion tasks. For more information,
        /// see the <a href="https://docs.aws.amazon.com/vm-import/latest/userguide/">VM Import/Export
        /// User Guide</a>.
        /// 
        ///  
        /// <para>
        /// For information about the import manifest referenced by this API action, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/manifest.html">VM
        /// Import Manifest</a>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeConversionTasks service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeConversionTasks">REST API Reference for DescribeConversionTasks Operation</seealso>
        public virtual Task<DescribeConversionTasksResponse> DescribeConversionTasksAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeConversionTasksAsync(new DescribeConversionTasksRequest(), cancellationToken);
        }



        /// <summary>
        /// Describes the specified conversion tasks or all your conversion tasks. For more information,
        /// see the <a href="https://docs.aws.amazon.com/vm-import/latest/userguide/">VM Import/Export
        /// User Guide</a>.
        /// 
        ///  
        /// <para>
        /// For information about the import manifest referenced by this API action, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/manifest.html">VM
        /// Import Manifest</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConversionTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeConversionTasks service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeConversionTasks">REST API Reference for DescribeConversionTasks Operation</seealso>
        public virtual Task<DescribeConversionTasksResponse> DescribeConversionTasksAsync(DescribeConversionTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConversionTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConversionTasksResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeConversionTasksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeCustomerGateways

        internal virtual DescribeCustomerGatewaysResponse DescribeCustomerGateways()
        {
            return DescribeCustomerGateways(new DescribeCustomerGatewaysRequest());
        }
        internal virtual DescribeCustomerGatewaysResponse DescribeCustomerGateways(DescribeCustomerGatewaysRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCustomerGatewaysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCustomerGatewaysResponseUnmarshaller.Instance;

            return Invoke<DescribeCustomerGatewaysResponse>(request, options);
        }


        /// <summary>
        /// Describes one or more of your VPN customer gateways.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/vpn/latest/s2svpn/VPC_VPN.html">AWS
        /// Site-to-Site VPN</a> in the <i>AWS Site-to-Site VPN User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCustomerGateways service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeCustomerGateways">REST API Reference for DescribeCustomerGateways Operation</seealso>
        public virtual Task<DescribeCustomerGatewaysResponse> DescribeCustomerGatewaysAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeCustomerGatewaysAsync(new DescribeCustomerGatewaysRequest(), cancellationToken);
        }



        /// <summary>
        /// Describes one or more of your VPN customer gateways.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/vpn/latest/s2svpn/VPC_VPN.html">AWS
        /// Site-to-Site VPN</a> in the <i>AWS Site-to-Site VPN User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCustomerGateways service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCustomerGateways service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeCustomerGateways">REST API Reference for DescribeCustomerGateways Operation</seealso>
        public virtual Task<DescribeCustomerGatewaysResponse> DescribeCustomerGatewaysAsync(DescribeCustomerGatewaysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCustomerGatewaysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCustomerGatewaysResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeCustomerGatewaysResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDhcpOptions

        internal virtual DescribeDhcpOptionsResponse DescribeDhcpOptions()
        {
            return DescribeDhcpOptions(new DescribeDhcpOptionsRequest());
        }
        internal virtual DescribeDhcpOptionsResponse DescribeDhcpOptions(DescribeDhcpOptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDhcpOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDhcpOptionsResponseUnmarshaller.Instance;

            return Invoke<DescribeDhcpOptionsResponse>(request, options);
        }


        /// <summary>
        /// Describes one or more of your DHCP options sets.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_DHCP_Options.html">DHCP
        /// Options Sets</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDhcpOptions service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeDhcpOptions">REST API Reference for DescribeDhcpOptions Operation</seealso>
        public virtual Task<DescribeDhcpOptionsResponse> DescribeDhcpOptionsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeDhcpOptionsAsync(new DescribeDhcpOptionsRequest(), cancellationToken);
        }



        /// <summary>
        /// Describes one or more of your DHCP options sets.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_DHCP_Options.html">DHCP
        /// Options Sets</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDhcpOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDhcpOptions service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeDhcpOptions">REST API Reference for DescribeDhcpOptions Operation</seealso>
        public virtual Task<DescribeDhcpOptionsResponse> DescribeDhcpOptionsAsync(DescribeDhcpOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDhcpOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDhcpOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDhcpOptionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEgressOnlyInternetGateways

        internal virtual DescribeEgressOnlyInternetGatewaysResponse DescribeEgressOnlyInternetGateways(DescribeEgressOnlyInternetGatewaysRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEgressOnlyInternetGatewaysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEgressOnlyInternetGatewaysResponseUnmarshaller.Instance;

            return Invoke<DescribeEgressOnlyInternetGatewaysResponse>(request, options);
        }



        /// <summary>
        /// Describes one or more of your egress-only internet gateways.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEgressOnlyInternetGateways service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEgressOnlyInternetGateways service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeEgressOnlyInternetGateways">REST API Reference for DescribeEgressOnlyInternetGateways Operation</seealso>
        public virtual Task<DescribeEgressOnlyInternetGatewaysResponse> DescribeEgressOnlyInternetGatewaysAsync(DescribeEgressOnlyInternetGatewaysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEgressOnlyInternetGatewaysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEgressOnlyInternetGatewaysResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEgressOnlyInternetGatewaysResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeElasticGpus

        internal virtual DescribeElasticGpusResponse DescribeElasticGpus(DescribeElasticGpusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeElasticGpusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeElasticGpusResponseUnmarshaller.Instance;

            return Invoke<DescribeElasticGpusResponse>(request, options);
        }



        /// <summary>
        /// Describes the Elastic Graphics accelerator associated with your instances. For more
        /// information about Elastic Graphics, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/WindowsGuide/elastic-graphics.html">Amazon
        /// Elastic Graphics</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeElasticGpus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeElasticGpus service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeElasticGpus">REST API Reference for DescribeElasticGpus Operation</seealso>
        public virtual Task<DescribeElasticGpusResponse> DescribeElasticGpusAsync(DescribeElasticGpusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeElasticGpusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeElasticGpusResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeElasticGpusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeExportTasks

        internal virtual DescribeExportTasksResponse DescribeExportTasks()
        {
            return DescribeExportTasks(new DescribeExportTasksRequest());
        }
        internal virtual DescribeExportTasksResponse DescribeExportTasks(DescribeExportTasksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeExportTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeExportTasksResponseUnmarshaller.Instance;

            return Invoke<DescribeExportTasksResponse>(request, options);
        }


        /// <summary>
        /// Describes the specified export tasks or all your export tasks.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeExportTasks service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeExportTasks">REST API Reference for DescribeExportTasks Operation</seealso>
        public virtual Task<DescribeExportTasksResponse> DescribeExportTasksAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeExportTasksAsync(new DescribeExportTasksRequest(), cancellationToken);
        }



        /// <summary>
        /// Describes the specified export tasks or all your export tasks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeExportTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeExportTasks service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeExportTasks">REST API Reference for DescribeExportTasks Operation</seealso>
        public virtual Task<DescribeExportTasksResponse> DescribeExportTasksAsync(DescribeExportTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeExportTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeExportTasksResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeExportTasksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeFleetHistory

        internal virtual DescribeFleetHistoryResponse DescribeFleetHistory(DescribeFleetHistoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFleetHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetHistoryResponseUnmarshaller.Instance;

            return Invoke<DescribeFleetHistoryResponse>(request, options);
        }



        /// <summary>
        /// Describes the events for the specified EC2 Fleet during the specified time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetHistory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFleetHistory service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeFleetHistory">REST API Reference for DescribeFleetHistory Operation</seealso>
        public virtual Task<DescribeFleetHistoryResponse> DescribeFleetHistoryAsync(DescribeFleetHistoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFleetHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetHistoryResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFleetHistoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeFleetInstances

        internal virtual DescribeFleetInstancesResponse DescribeFleetInstances(DescribeFleetInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFleetInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetInstancesResponseUnmarshaller.Instance;

            return Invoke<DescribeFleetInstancesResponse>(request, options);
        }



        /// <summary>
        /// Describes the running instances for the specified EC2 Fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFleetInstances service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeFleetInstances">REST API Reference for DescribeFleetInstances Operation</seealso>
        public virtual Task<DescribeFleetInstancesResponse> DescribeFleetInstancesAsync(DescribeFleetInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFleetInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFleetInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeFleets

        internal virtual DescribeFleetsResponse DescribeFleets(DescribeFleetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFleetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetsResponseUnmarshaller.Instance;

            return Invoke<DescribeFleetsResponse>(request, options);
        }



        /// <summary>
        /// Describes the specified EC2 Fleets or all your EC2 Fleets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFleets service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeFleets">REST API Reference for DescribeFleets Operation</seealso>
        public virtual Task<DescribeFleetsResponse> DescribeFleetsAsync(DescribeFleetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFleetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFleetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeFlowLogs

        internal virtual DescribeFlowLogsResponse DescribeFlowLogs(DescribeFlowLogsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFlowLogsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFlowLogsResponseUnmarshaller.Instance;

            return Invoke<DescribeFlowLogsResponse>(request, options);
        }



        /// <summary>
        /// Describes one or more flow logs. To view the information in your flow logs (the log
        /// streams for the network interfaces), you must use the CloudWatch Logs console or the
        /// CloudWatch Logs API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFlowLogs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFlowLogs service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeFlowLogs">REST API Reference for DescribeFlowLogs Operation</seealso>
        public virtual Task<DescribeFlowLogsResponse> DescribeFlowLogsAsync(DescribeFlowLogsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFlowLogsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFlowLogsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFlowLogsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeFpgaImageAttribute

        internal virtual DescribeFpgaImageAttributeResponse DescribeFpgaImageAttribute(DescribeFpgaImageAttributeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFpgaImageAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFpgaImageAttributeResponseUnmarshaller.Instance;

            return Invoke<DescribeFpgaImageAttributeResponse>(request, options);
        }



        /// <summary>
        /// Describes the specified attribute of the specified Amazon FPGA Image (AFI).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFpgaImageAttribute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFpgaImageAttribute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeFpgaImageAttribute">REST API Reference for DescribeFpgaImageAttribute Operation</seealso>
        public virtual Task<DescribeFpgaImageAttributeResponse> DescribeFpgaImageAttributeAsync(DescribeFpgaImageAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFpgaImageAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFpgaImageAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFpgaImageAttributeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeFpgaImages

        internal virtual DescribeFpgaImagesResponse DescribeFpgaImages(DescribeFpgaImagesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFpgaImagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFpgaImagesResponseUnmarshaller.Instance;

            return Invoke<DescribeFpgaImagesResponse>(request, options);
        }



        /// <summary>
        /// Describes the Amazon FPGA Images (AFIs) available to you. These include public AFIs,
        /// private AFIs that you own, and AFIs owned by other AWS accounts for which you have
        /// load permissions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFpgaImages service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFpgaImages service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeFpgaImages">REST API Reference for DescribeFpgaImages Operation</seealso>
        public virtual Task<DescribeFpgaImagesResponse> DescribeFpgaImagesAsync(DescribeFpgaImagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFpgaImagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFpgaImagesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFpgaImagesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeHostReservationOfferings

        internal virtual DescribeHostReservationOfferingsResponse DescribeHostReservationOfferings(DescribeHostReservationOfferingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeHostReservationOfferingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeHostReservationOfferingsResponseUnmarshaller.Instance;

            return Invoke<DescribeHostReservationOfferingsResponse>(request, options);
        }



        /// <summary>
        /// Describes the Dedicated Host reservations that are available to purchase.
        /// 
        ///  
        /// <para>
        /// The results describe all the Dedicated Host reservation offerings, including offerings
        /// that may not match the instance family and Region of your Dedicated Hosts. When purchasing
        /// an offering, ensure that the instance family and Region of the offering matches that
        /// of the Dedicated Hosts with which it is to be associated. For more information about
        /// supported instance types, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/dedicated-hosts-overview.html">Dedicated
        /// Hosts Overview</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeHostReservationOfferings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeHostReservationOfferings service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeHostReservationOfferings">REST API Reference for DescribeHostReservationOfferings Operation</seealso>
        public virtual Task<DescribeHostReservationOfferingsResponse> DescribeHostReservationOfferingsAsync(DescribeHostReservationOfferingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeHostReservationOfferingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeHostReservationOfferingsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeHostReservationOfferingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeHostReservations

        internal virtual DescribeHostReservationsResponse DescribeHostReservations(DescribeHostReservationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeHostReservationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeHostReservationsResponseUnmarshaller.Instance;

            return Invoke<DescribeHostReservationsResponse>(request, options);
        }



        /// <summary>
        /// Describes reservations that are associated with Dedicated Hosts in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeHostReservations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeHostReservations service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeHostReservations">REST API Reference for DescribeHostReservations Operation</seealso>
        public virtual Task<DescribeHostReservationsResponse> DescribeHostReservationsAsync(DescribeHostReservationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeHostReservationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeHostReservationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeHostReservationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeHosts

        internal virtual DescribeHostsResponse DescribeHosts(DescribeHostsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeHostsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeHostsResponseUnmarshaller.Instance;

            return Invoke<DescribeHostsResponse>(request, options);
        }



        /// <summary>
        /// Describes the specified Dedicated Hosts or all your Dedicated Hosts.
        /// 
        ///  
        /// <para>
        /// The results describe only the Dedicated Hosts in the Region you're currently using.
        /// All listed instances consume capacity on your Dedicated Host. Dedicated Hosts that
        /// have recently been released are listed with the state <code>released</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeHosts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeHosts service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeHosts">REST API Reference for DescribeHosts Operation</seealso>
        public virtual Task<DescribeHostsResponse> DescribeHostsAsync(DescribeHostsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeHostsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeHostsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeHostsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeIamInstanceProfileAssociations

        internal virtual DescribeIamInstanceProfileAssociationsResponse DescribeIamInstanceProfileAssociations(DescribeIamInstanceProfileAssociationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeIamInstanceProfileAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeIamInstanceProfileAssociationsResponseUnmarshaller.Instance;

            return Invoke<DescribeIamInstanceProfileAssociationsResponse>(request, options);
        }



        /// <summary>
        /// Describes your IAM instance profile associations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeIamInstanceProfileAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeIamInstanceProfileAssociations service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeIamInstanceProfileAssociations">REST API Reference for DescribeIamInstanceProfileAssociations Operation</seealso>
        public virtual Task<DescribeIamInstanceProfileAssociationsResponse> DescribeIamInstanceProfileAssociationsAsync(DescribeIamInstanceProfileAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeIamInstanceProfileAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeIamInstanceProfileAssociationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeIamInstanceProfileAssociationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeIdentityIdFormat

        internal virtual DescribeIdentityIdFormatResponse DescribeIdentityIdFormat(DescribeIdentityIdFormatRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeIdentityIdFormatRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeIdentityIdFormatResponseUnmarshaller.Instance;

            return Invoke<DescribeIdentityIdFormatResponse>(request, options);
        }



        /// <summary>
        /// Describes the ID format settings for resources for the specified IAM user, IAM role,
        /// or root user. For example, you can view the resource types that are enabled for longer
        /// IDs. This request only returns information about resource types whose ID formats can
        /// be modified; it does not return information about other resource types. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/resource-ids.html">Resource
        /// IDs</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>. 
        /// 
        ///  
        /// <para>
        /// The following resource types support longer IDs: <code>bundle</code> | <code>conversion-task</code>
        /// | <code>customer-gateway</code> | <code>dhcp-options</code> | <code>elastic-ip-allocation</code>
        /// | <code>elastic-ip-association</code> | <code>export-task</code> | <code>flow-log</code>
        /// | <code>image</code> | <code>import-task</code> | <code>instance</code> | <code>internet-gateway</code>
        /// | <code>network-acl</code> | <code>network-acl-association</code> | <code>network-interface</code>
        /// | <code>network-interface-attachment</code> | <code>prefix-list</code> | <code>reservation</code>
        /// | <code>route-table</code> | <code>route-table-association</code> | <code>security-group</code>
        /// | <code>snapshot</code> | <code>subnet</code> | <code>subnet-cidr-block-association</code>
        /// | <code>volume</code> | <code>vpc</code> | <code>vpc-cidr-block-association</code>
        /// | <code>vpc-endpoint</code> | <code>vpc-peering-connection</code> | <code>vpn-connection</code>
        /// | <code>vpn-gateway</code>. 
        /// </para>
        ///  
        /// <para>
        /// These settings apply to the principal specified in the request. They do not apply
        /// to the principal that makes the request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeIdentityIdFormat service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeIdentityIdFormat service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeIdentityIdFormat">REST API Reference for DescribeIdentityIdFormat Operation</seealso>
        public virtual Task<DescribeIdentityIdFormatResponse> DescribeIdentityIdFormatAsync(DescribeIdentityIdFormatRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeIdentityIdFormatRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeIdentityIdFormatResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeIdentityIdFormatResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeIdFormat

        internal virtual DescribeIdFormatResponse DescribeIdFormat(DescribeIdFormatRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeIdFormatRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeIdFormatResponseUnmarshaller.Instance;

            return Invoke<DescribeIdFormatResponse>(request, options);
        }



        /// <summary>
        /// Describes the ID format settings for your resources on a per-Region basis, for example,
        /// to view which resource types are enabled for longer IDs. This request only returns
        /// information about resource types whose ID formats can be modified; it does not return
        /// information about other resource types.
        /// 
        ///  
        /// <para>
        /// The following resource types support longer IDs: <code>bundle</code> | <code>conversion-task</code>
        /// | <code>customer-gateway</code> | <code>dhcp-options</code> | <code>elastic-ip-allocation</code>
        /// | <code>elastic-ip-association</code> | <code>export-task</code> | <code>flow-log</code>
        /// | <code>image</code> | <code>import-task</code> | <code>instance</code> | <code>internet-gateway</code>
        /// | <code>network-acl</code> | <code>network-acl-association</code> | <code>network-interface</code>
        /// | <code>network-interface-attachment</code> | <code>prefix-list</code> | <code>reservation</code>
        /// | <code>route-table</code> | <code>route-table-association</code> | <code>security-group</code>
        /// | <code>snapshot</code> | <code>subnet</code> | <code>subnet-cidr-block-association</code>
        /// | <code>volume</code> | <code>vpc</code> | <code>vpc-cidr-block-association</code>
        /// | <code>vpc-endpoint</code> | <code>vpc-peering-connection</code> | <code>vpn-connection</code>
        /// | <code>vpn-gateway</code>. 
        /// </para>
        ///  
        /// <para>
        /// These settings apply to the IAM user who makes the request; they do not apply to the
        /// entire AWS account. By default, an IAM user defaults to the same settings as the root
        /// user, unless they explicitly override the settings by running the <a>ModifyIdFormat</a>
        /// command. Resources created with longer IDs are visible to all IAM users, regardless
        /// of these settings and provided that they have permission to use the relevant <code>Describe</code>
        /// command for the resource type.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeIdFormat service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeIdFormat service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeIdFormat">REST API Reference for DescribeIdFormat Operation</seealso>
        public virtual Task<DescribeIdFormatResponse> DescribeIdFormatAsync(DescribeIdFormatRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeIdFormatRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeIdFormatResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeIdFormatResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeImageAttribute

        internal virtual DescribeImageAttributeResponse DescribeImageAttribute(DescribeImageAttributeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeImageAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeImageAttributeResponseUnmarshaller.Instance;

            return Invoke<DescribeImageAttributeResponse>(request, options);
        }



        /// <summary>
        /// Describes the specified attribute of the specified AMI. You can specify only one attribute
        /// at a time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeImageAttribute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeImageAttribute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeImageAttribute">REST API Reference for DescribeImageAttribute Operation</seealso>
        public virtual Task<DescribeImageAttributeResponse> DescribeImageAttributeAsync(DescribeImageAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeImageAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeImageAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeImageAttributeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeImages

        internal virtual DescribeImagesResponse DescribeImages()
        {
            return DescribeImages(new DescribeImagesRequest());
        }
        internal virtual DescribeImagesResponse DescribeImages(DescribeImagesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeImagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeImagesResponseUnmarshaller.Instance;

            return Invoke<DescribeImagesResponse>(request, options);
        }


        /// <summary>
        /// Describes the specified images (AMIs, AKIs, and ARIs) available to you or all of the
        /// images available to you.
        /// 
        ///  
        /// <para>
        /// The images available to you include public images, private images that you own, and
        /// private images owned by other AWS accounts for which you have explicit launch permissions.
        /// </para>
        ///  
        /// <para>
        /// Recently deregistered images appear in the returned results for a short interval and
        /// then return empty results. After all instances that reference a deregistered AMI are
        /// terminated, specifying the ID of the image results in an error indicating that the
        /// AMI ID cannot be found.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeImages service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeImages">REST API Reference for DescribeImages Operation</seealso>
        public virtual Task<DescribeImagesResponse> DescribeImagesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeImagesAsync(new DescribeImagesRequest(), cancellationToken);
        }



        /// <summary>
        /// Describes the specified images (AMIs, AKIs, and ARIs) available to you or all of the
        /// images available to you.
        /// 
        ///  
        /// <para>
        /// The images available to you include public images, private images that you own, and
        /// private images owned by other AWS accounts for which you have explicit launch permissions.
        /// </para>
        ///  
        /// <para>
        /// Recently deregistered images appear in the returned results for a short interval and
        /// then return empty results. After all instances that reference a deregistered AMI are
        /// terminated, specifying the ID of the image results in an error indicating that the
        /// AMI ID cannot be found.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeImages service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeImages service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeImages">REST API Reference for DescribeImages Operation</seealso>
        public virtual Task<DescribeImagesResponse> DescribeImagesAsync(DescribeImagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeImagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeImagesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeImagesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeImportImageTasks

        internal virtual DescribeImportImageTasksResponse DescribeImportImageTasks(DescribeImportImageTasksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeImportImageTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeImportImageTasksResponseUnmarshaller.Instance;

            return Invoke<DescribeImportImageTasksResponse>(request, options);
        }



        /// <summary>
        /// Displays details about an import virtual machine or import snapshot tasks that are
        /// already created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeImportImageTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeImportImageTasks service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeImportImageTasks">REST API Reference for DescribeImportImageTasks Operation</seealso>
        public virtual Task<DescribeImportImageTasksResponse> DescribeImportImageTasksAsync(DescribeImportImageTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeImportImageTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeImportImageTasksResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeImportImageTasksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeImportSnapshotTasks

        internal virtual DescribeImportSnapshotTasksResponse DescribeImportSnapshotTasks(DescribeImportSnapshotTasksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeImportSnapshotTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeImportSnapshotTasksResponseUnmarshaller.Instance;

            return Invoke<DescribeImportSnapshotTasksResponse>(request, options);
        }



        /// <summary>
        /// Describes your import snapshot tasks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeImportSnapshotTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeImportSnapshotTasks service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeImportSnapshotTasks">REST API Reference for DescribeImportSnapshotTasks Operation</seealso>
        public virtual Task<DescribeImportSnapshotTasksResponse> DescribeImportSnapshotTasksAsync(DescribeImportSnapshotTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeImportSnapshotTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeImportSnapshotTasksResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeImportSnapshotTasksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeInstanceAttribute

        internal virtual DescribeInstanceAttributeResponse DescribeInstanceAttribute(DescribeInstanceAttributeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInstanceAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInstanceAttributeResponseUnmarshaller.Instance;

            return Invoke<DescribeInstanceAttributeResponse>(request, options);
        }



        /// <summary>
        /// Describes the specified attribute of the specified instance. You can specify only
        /// one attribute at a time. Valid attribute values are: <code>instanceType</code> | <code>kernel</code>
        /// | <code>ramdisk</code> | <code>userData</code> | <code>disableApiTermination</code>
        /// | <code>instanceInitiatedShutdownBehavior</code> | <code>rootDeviceName</code> | <code>blockDeviceMapping</code>
        /// | <code>productCodes</code> | <code>sourceDestCheck</code> | <code>groupSet</code>
        /// | <code>ebsOptimized</code> | <code>sriovNetSupport</code>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceAttribute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInstanceAttribute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeInstanceAttribute">REST API Reference for DescribeInstanceAttribute Operation</seealso>
        public virtual Task<DescribeInstanceAttributeResponse> DescribeInstanceAttributeAsync(DescribeInstanceAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInstanceAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInstanceAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeInstanceAttributeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeInstanceCreditSpecifications

        internal virtual DescribeInstanceCreditSpecificationsResponse DescribeInstanceCreditSpecifications(DescribeInstanceCreditSpecificationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInstanceCreditSpecificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInstanceCreditSpecificationsResponseUnmarshaller.Instance;

            return Invoke<DescribeInstanceCreditSpecificationsResponse>(request, options);
        }



        /// <summary>
        /// Describes the credit option for CPU usage of the specified T2 or T3 instances. The
        /// credit options are <code>standard</code> and <code>unlimited</code>.
        /// 
        ///  
        /// <para>
        /// If you do not specify an instance ID, Amazon EC2 returns T2 and T3 instances with
        /// the <code>unlimited</code> credit option, as well as instances that were previously
        /// configured as T2 or T3 with the <code>unlimited</code> credit option. For example,
        /// if you resize a T2 instance, while it is configured as <code>unlimited</code>, to
        /// an M4 instance, Amazon EC2 returns the M4 instance.
        /// </para>
        ///  
        /// <para>
        /// If you specify one or more instance IDs, Amazon EC2 returns the credit option (<code>standard</code>
        /// or <code>unlimited</code>) of those instances. If you specify an instance ID that
        /// is not valid, such as an instance that is not a T2 or T3 instance, an error is returned.
        /// </para>
        ///  
        /// <para>
        /// Recently terminated instances might appear in the returned results. This interval
        /// is usually less than one hour.
        /// </para>
        ///  
        /// <para>
        /// If an Availability Zone is experiencing a service disruption and you specify instance
        /// IDs in the affected zone, or do not specify any instance IDs at all, the call fails.
        /// If you specify only instance IDs in an unaffected zone, the call works normally.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/burstable-performance-instances.html">Burstable
        /// Performance Instances</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceCreditSpecifications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInstanceCreditSpecifications service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeInstanceCreditSpecifications">REST API Reference for DescribeInstanceCreditSpecifications Operation</seealso>
        public virtual Task<DescribeInstanceCreditSpecificationsResponse> DescribeInstanceCreditSpecificationsAsync(DescribeInstanceCreditSpecificationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInstanceCreditSpecificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInstanceCreditSpecificationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeInstanceCreditSpecificationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeInstances

        internal virtual DescribeInstancesResponse DescribeInstances()
        {
            return DescribeInstances(new DescribeInstancesRequest());
        }
        internal virtual DescribeInstancesResponse DescribeInstances(DescribeInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInstancesResponseUnmarshaller.Instance;

            return Invoke<DescribeInstancesResponse>(request, options);
        }


        /// <summary>
        /// Describes the specified instances or all of your instances.
        /// 
        ///  
        /// <para>
        /// If you specify one or more instance IDs, Amazon EC2 returns information for those
        /// instances. If you do not specify instance IDs, Amazon EC2 returns information for
        /// all relevant instances. If you specify an instance ID that is not valid, an error
        /// is returned. If you specify an instance that you do not own, it is not included in
        /// the returned results.
        /// </para>
        ///  
        /// <para>
        /// Recently terminated instances might appear in the returned results. This interval
        /// is usually less than one hour.
        /// </para>
        ///  
        /// <para>
        /// If you describe instances in the rare case where an Availability Zone is experiencing
        /// a service disruption and you specify instance IDs that are in the affected zone, or
        /// do not specify any instance IDs at all, the call fails. If you describe instances
        /// and specify only instance IDs that are in an unaffected zone, the call works normally.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInstances service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeInstances">REST API Reference for DescribeInstances Operation</seealso>
        public virtual Task<DescribeInstancesResponse> DescribeInstancesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeInstancesAsync(new DescribeInstancesRequest(), cancellationToken);
        }



        /// <summary>
        /// Describes the specified instances or all of your instances.
        /// 
        ///  
        /// <para>
        /// If you specify one or more instance IDs, Amazon EC2 returns information for those
        /// instances. If you do not specify instance IDs, Amazon EC2 returns information for
        /// all relevant instances. If you specify an instance ID that is not valid, an error
        /// is returned. If you specify an instance that you do not own, it is not included in
        /// the returned results.
        /// </para>
        ///  
        /// <para>
        /// Recently terminated instances might appear in the returned results. This interval
        /// is usually less than one hour.
        /// </para>
        ///  
        /// <para>
        /// If you describe instances in the rare case where an Availability Zone is experiencing
        /// a service disruption and you specify instance IDs that are in the affected zone, or
        /// do not specify any instance IDs at all, the call fails. If you describe instances
        /// and specify only instance IDs that are in an unaffected zone, the call works normally.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInstances service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeInstances">REST API Reference for DescribeInstances Operation</seealso>
        public virtual Task<DescribeInstancesResponse> DescribeInstancesAsync(DescribeInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeInstanceStatus

        internal virtual DescribeInstanceStatusResponse DescribeInstanceStatus()
        {
            return DescribeInstanceStatus(new DescribeInstanceStatusRequest());
        }
        internal virtual DescribeInstanceStatusResponse DescribeInstanceStatus(DescribeInstanceStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInstanceStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInstanceStatusResponseUnmarshaller.Instance;

            return Invoke<DescribeInstanceStatusResponse>(request, options);
        }


        /// <summary>
        /// Describes the status of the specified instances or all of your instances. By default,
        /// only running instances are described, unless you specifically indicate to return the
        /// status of all instances.
        /// 
        ///  
        /// <para>
        /// Instance status includes the following components:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Status checks</b> - Amazon EC2 performs status checks on running EC2 instances
        /// to identify hardware and software issues. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/monitoring-system-instance-status-check.html">Status
        /// Checks for Your Instances</a> and <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/TroubleshootingInstances.html">Troubleshooting
        /// Instances with Failed Status Checks</a> in the <i>Amazon Elastic Compute Cloud User
        /// Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Scheduled events</b> - Amazon EC2 can schedule events (such as reboot, stop, or
        /// terminate) for your instances related to hardware issues, software updates, or system
        /// maintenance. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/monitoring-instances-status-check_sched.html">Scheduled
        /// Events for Your Instances</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Instance state</b> - You can manage your instances from the moment you launch
        /// them through their termination. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instance-lifecycle.html">Instance
        /// Lifecycle</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInstanceStatus service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeInstanceStatus">REST API Reference for DescribeInstanceStatus Operation</seealso>
        public virtual Task<DescribeInstanceStatusResponse> DescribeInstanceStatusAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeInstanceStatusAsync(new DescribeInstanceStatusRequest(), cancellationToken);
        }



        /// <summary>
        /// Describes the status of the specified instances or all of your instances. By default,
        /// only running instances are described, unless you specifically indicate to return the
        /// status of all instances.
        /// 
        ///  
        /// <para>
        /// Instance status includes the following components:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Status checks</b> - Amazon EC2 performs status checks on running EC2 instances
        /// to identify hardware and software issues. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/monitoring-system-instance-status-check.html">Status
        /// Checks for Your Instances</a> and <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/TroubleshootingInstances.html">Troubleshooting
        /// Instances with Failed Status Checks</a> in the <i>Amazon Elastic Compute Cloud User
        /// Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Scheduled events</b> - Amazon EC2 can schedule events (such as reboot, stop, or
        /// terminate) for your instances related to hardware issues, software updates, or system
        /// maintenance. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/monitoring-instances-status-check_sched.html">Scheduled
        /// Events for Your Instances</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Instance state</b> - You can manage your instances from the moment you launch
        /// them through their termination. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instance-lifecycle.html">Instance
        /// Lifecycle</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInstanceStatus service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeInstanceStatus">REST API Reference for DescribeInstanceStatus Operation</seealso>
        public virtual Task<DescribeInstanceStatusResponse> DescribeInstanceStatusAsync(DescribeInstanceStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInstanceStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInstanceStatusResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeInstanceStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeInternetGateways

        internal virtual DescribeInternetGatewaysResponse DescribeInternetGateways()
        {
            return DescribeInternetGateways(new DescribeInternetGatewaysRequest());
        }
        internal virtual DescribeInternetGatewaysResponse DescribeInternetGateways(DescribeInternetGatewaysRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInternetGatewaysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInternetGatewaysResponseUnmarshaller.Instance;

            return Invoke<DescribeInternetGatewaysResponse>(request, options);
        }


        /// <summary>
        /// Describes one or more of your internet gateways.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInternetGateways service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeInternetGateways">REST API Reference for DescribeInternetGateways Operation</seealso>
        public virtual Task<DescribeInternetGatewaysResponse> DescribeInternetGatewaysAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeInternetGatewaysAsync(new DescribeInternetGatewaysRequest(), cancellationToken);
        }



        /// <summary>
        /// Describes one or more of your internet gateways.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInternetGateways service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInternetGateways service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeInternetGateways">REST API Reference for DescribeInternetGateways Operation</seealso>
        public virtual Task<DescribeInternetGatewaysResponse> DescribeInternetGatewaysAsync(DescribeInternetGatewaysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInternetGatewaysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInternetGatewaysResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeInternetGatewaysResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeKeyPairs

        internal virtual DescribeKeyPairsResponse DescribeKeyPairs()
        {
            return DescribeKeyPairs(new DescribeKeyPairsRequest());
        }
        internal virtual DescribeKeyPairsResponse DescribeKeyPairs(DescribeKeyPairsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeKeyPairsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeKeyPairsResponseUnmarshaller.Instance;

            return Invoke<DescribeKeyPairsResponse>(request, options);
        }


        /// <summary>
        /// Describes the specified key pairs or all of your key pairs.
        /// 
        ///  
        /// <para>
        /// For more information about key pairs, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-key-pairs.html">Key
        /// Pairs</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeKeyPairs service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeKeyPairs">REST API Reference for DescribeKeyPairs Operation</seealso>
        public virtual Task<DescribeKeyPairsResponse> DescribeKeyPairsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeKeyPairsAsync(new DescribeKeyPairsRequest(), cancellationToken);
        }



        /// <summary>
        /// Describes the specified key pairs or all of your key pairs.
        /// 
        ///  
        /// <para>
        /// For more information about key pairs, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-key-pairs.html">Key
        /// Pairs</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeKeyPairs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeKeyPairs service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeKeyPairs">REST API Reference for DescribeKeyPairs Operation</seealso>
        public virtual Task<DescribeKeyPairsResponse> DescribeKeyPairsAsync(DescribeKeyPairsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeKeyPairsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeKeyPairsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeKeyPairsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeLaunchTemplates

        internal virtual DescribeLaunchTemplatesResponse DescribeLaunchTemplates(DescribeLaunchTemplatesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLaunchTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLaunchTemplatesResponseUnmarshaller.Instance;

            return Invoke<DescribeLaunchTemplatesResponse>(request, options);
        }



        /// <summary>
        /// Describes one or more launch templates.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLaunchTemplates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLaunchTemplates service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeLaunchTemplates">REST API Reference for DescribeLaunchTemplates Operation</seealso>
        public virtual Task<DescribeLaunchTemplatesResponse> DescribeLaunchTemplatesAsync(DescribeLaunchTemplatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLaunchTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLaunchTemplatesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLaunchTemplatesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeLaunchTemplateVersions

        internal virtual DescribeLaunchTemplateVersionsResponse DescribeLaunchTemplateVersions(DescribeLaunchTemplateVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLaunchTemplateVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLaunchTemplateVersionsResponseUnmarshaller.Instance;

            return Invoke<DescribeLaunchTemplateVersionsResponse>(request, options);
        }



        /// <summary>
        /// Describes one or more versions of a specified launch template. You can describe all
        /// versions, individual versions, or a range of versions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLaunchTemplateVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLaunchTemplateVersions service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeLaunchTemplateVersions">REST API Reference for DescribeLaunchTemplateVersions Operation</seealso>
        public virtual Task<DescribeLaunchTemplateVersionsResponse> DescribeLaunchTemplateVersionsAsync(DescribeLaunchTemplateVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLaunchTemplateVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLaunchTemplateVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLaunchTemplateVersionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeMovingAddresses

        internal virtual DescribeMovingAddressesResponse DescribeMovingAddresses(DescribeMovingAddressesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMovingAddressesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMovingAddressesResponseUnmarshaller.Instance;

            return Invoke<DescribeMovingAddressesResponse>(request, options);
        }



        /// <summary>
        /// Describes your Elastic IP addresses that are being moved to the EC2-VPC platform,
        /// or that are being restored to the EC2-Classic platform. This request does not return
        /// information about any other Elastic IP addresses in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMovingAddresses service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeMovingAddresses service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeMovingAddresses">REST API Reference for DescribeMovingAddresses Operation</seealso>
        public virtual Task<DescribeMovingAddressesResponse> DescribeMovingAddressesAsync(DescribeMovingAddressesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMovingAddressesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMovingAddressesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeMovingAddressesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeNatGateways

        internal virtual DescribeNatGatewaysResponse DescribeNatGateways(DescribeNatGatewaysRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeNatGatewaysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNatGatewaysResponseUnmarshaller.Instance;

            return Invoke<DescribeNatGatewaysResponse>(request, options);
        }



        /// <summary>
        /// Describes one or more of your NAT gateways.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNatGateways service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeNatGateways service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeNatGateways">REST API Reference for DescribeNatGateways Operation</seealso>
        public virtual Task<DescribeNatGatewaysResponse> DescribeNatGatewaysAsync(DescribeNatGatewaysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeNatGatewaysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNatGatewaysResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeNatGatewaysResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeNetworkAcls

        internal virtual DescribeNetworkAclsResponse DescribeNetworkAcls()
        {
            return DescribeNetworkAcls(new DescribeNetworkAclsRequest());
        }
        internal virtual DescribeNetworkAclsResponse DescribeNetworkAcls(DescribeNetworkAclsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeNetworkAclsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNetworkAclsResponseUnmarshaller.Instance;

            return Invoke<DescribeNetworkAclsResponse>(request, options);
        }


        /// <summary>
        /// Describes one or more of your network ACLs.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_ACLs.html">Network
        /// ACLs</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeNetworkAcls service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeNetworkAcls">REST API Reference for DescribeNetworkAcls Operation</seealso>
        public virtual Task<DescribeNetworkAclsResponse> DescribeNetworkAclsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeNetworkAclsAsync(new DescribeNetworkAclsRequest(), cancellationToken);
        }



        /// <summary>
        /// Describes one or more of your network ACLs.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_ACLs.html">Network
        /// ACLs</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNetworkAcls service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeNetworkAcls service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeNetworkAcls">REST API Reference for DescribeNetworkAcls Operation</seealso>
        public virtual Task<DescribeNetworkAclsResponse> DescribeNetworkAclsAsync(DescribeNetworkAclsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeNetworkAclsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNetworkAclsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeNetworkAclsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeNetworkInterfaceAttribute

        internal virtual DescribeNetworkInterfaceAttributeResponse DescribeNetworkInterfaceAttribute(DescribeNetworkInterfaceAttributeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeNetworkInterfaceAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNetworkInterfaceAttributeResponseUnmarshaller.Instance;

            return Invoke<DescribeNetworkInterfaceAttributeResponse>(request, options);
        }



        /// <summary>
        /// Describes a network interface attribute. You can specify only one attribute at a time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNetworkInterfaceAttribute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeNetworkInterfaceAttribute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeNetworkInterfaceAttribute">REST API Reference for DescribeNetworkInterfaceAttribute Operation</seealso>
        public virtual Task<DescribeNetworkInterfaceAttributeResponse> DescribeNetworkInterfaceAttributeAsync(DescribeNetworkInterfaceAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeNetworkInterfaceAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNetworkInterfaceAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeNetworkInterfaceAttributeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeNetworkInterfacePermissions

        internal virtual DescribeNetworkInterfacePermissionsResponse DescribeNetworkInterfacePermissions(DescribeNetworkInterfacePermissionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeNetworkInterfacePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNetworkInterfacePermissionsResponseUnmarshaller.Instance;

            return Invoke<DescribeNetworkInterfacePermissionsResponse>(request, options);
        }



        /// <summary>
        /// Describes the permissions for your network interfaces.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNetworkInterfacePermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeNetworkInterfacePermissions service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeNetworkInterfacePermissions">REST API Reference for DescribeNetworkInterfacePermissions Operation</seealso>
        public virtual Task<DescribeNetworkInterfacePermissionsResponse> DescribeNetworkInterfacePermissionsAsync(DescribeNetworkInterfacePermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeNetworkInterfacePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNetworkInterfacePermissionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeNetworkInterfacePermissionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeNetworkInterfaces

        internal virtual DescribeNetworkInterfacesResponse DescribeNetworkInterfaces()
        {
            return DescribeNetworkInterfaces(new DescribeNetworkInterfacesRequest());
        }
        internal virtual DescribeNetworkInterfacesResponse DescribeNetworkInterfaces(DescribeNetworkInterfacesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeNetworkInterfacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNetworkInterfacesResponseUnmarshaller.Instance;

            return Invoke<DescribeNetworkInterfacesResponse>(request, options);
        }


        /// <summary>
        /// Describes one or more of your network interfaces.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeNetworkInterfaces service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeNetworkInterfaces">REST API Reference for DescribeNetworkInterfaces Operation</seealso>
        public virtual Task<DescribeNetworkInterfacesResponse> DescribeNetworkInterfacesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeNetworkInterfacesAsync(new DescribeNetworkInterfacesRequest(), cancellationToken);
        }



        /// <summary>
        /// Describes one or more of your network interfaces.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNetworkInterfaces service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeNetworkInterfaces service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeNetworkInterfaces">REST API Reference for DescribeNetworkInterfaces Operation</seealso>
        public virtual Task<DescribeNetworkInterfacesResponse> DescribeNetworkInterfacesAsync(DescribeNetworkInterfacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeNetworkInterfacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNetworkInterfacesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeNetworkInterfacesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribePlacementGroups

        internal virtual DescribePlacementGroupsResponse DescribePlacementGroups()
        {
            return DescribePlacementGroups(new DescribePlacementGroupsRequest());
        }
        internal virtual DescribePlacementGroupsResponse DescribePlacementGroups(DescribePlacementGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePlacementGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePlacementGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribePlacementGroupsResponse>(request, options);
        }


        /// <summary>
        /// Describes the specified placement groups or all of your placement groups. For more
        /// information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/placement-groups.html">Placement
        /// Groups</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePlacementGroups service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribePlacementGroups">REST API Reference for DescribePlacementGroups Operation</seealso>
        public virtual Task<DescribePlacementGroupsResponse> DescribePlacementGroupsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribePlacementGroupsAsync(new DescribePlacementGroupsRequest(), cancellationToken);
        }



        /// <summary>
        /// Describes the specified placement groups or all of your placement groups. For more
        /// information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/placement-groups.html">Placement
        /// Groups</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePlacementGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePlacementGroups service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribePlacementGroups">REST API Reference for DescribePlacementGroups Operation</seealso>
        public virtual Task<DescribePlacementGroupsResponse> DescribePlacementGroupsAsync(DescribePlacementGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePlacementGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePlacementGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribePlacementGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribePrefixLists

        internal virtual DescribePrefixListsResponse DescribePrefixLists(DescribePrefixListsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePrefixListsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePrefixListsResponseUnmarshaller.Instance;

            return Invoke<DescribePrefixListsResponse>(request, options);
        }



        /// <summary>
        /// Describes available AWS services in a prefix list format, which includes the prefix
        /// list name and prefix list ID of the service and the IP address range for the service.
        /// A prefix list ID is required for creating an outbound security group rule that allows
        /// traffic from a VPC to access an AWS service through a gateway VPC endpoint. Currently,
        /// the services that support this action are Amazon S3 and Amazon DynamoDB.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePrefixLists service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePrefixLists service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribePrefixLists">REST API Reference for DescribePrefixLists Operation</seealso>
        public virtual Task<DescribePrefixListsResponse> DescribePrefixListsAsync(DescribePrefixListsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePrefixListsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePrefixListsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribePrefixListsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribePrincipalIdFormat

        internal virtual DescribePrincipalIdFormatResponse DescribePrincipalIdFormat(DescribePrincipalIdFormatRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePrincipalIdFormatRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePrincipalIdFormatResponseUnmarshaller.Instance;

            return Invoke<DescribePrincipalIdFormatResponse>(request, options);
        }



        /// <summary>
        /// Describes the ID format settings for the root user and all IAM roles and IAM users
        /// that have explicitly specified a longer ID (17-character ID) preference. 
        /// 
        ///  
        /// <para>
        /// By default, all IAM roles and IAM users default to the same ID settings as the root
        /// user, unless they explicitly override the settings. This request is useful for identifying
        /// those IAM users and IAM roles that have overridden the default ID settings.
        /// </para>
        ///  
        /// <para>
        /// The following resource types support longer IDs: <code>bundle</code> | <code>conversion-task</code>
        /// | <code>customer-gateway</code> | <code>dhcp-options</code> | <code>elastic-ip-allocation</code>
        /// | <code>elastic-ip-association</code> | <code>export-task</code> | <code>flow-log</code>
        /// | <code>image</code> | <code>import-task</code> | <code>instance</code> | <code>internet-gateway</code>
        /// | <code>network-acl</code> | <code>network-acl-association</code> | <code>network-interface</code>
        /// | <code>network-interface-attachment</code> | <code>prefix-list</code> | <code>reservation</code>
        /// | <code>route-table</code> | <code>route-table-association</code> | <code>security-group</code>
        /// | <code>snapshot</code> | <code>subnet</code> | <code>subnet-cidr-block-association</code>
        /// | <code>volume</code> | <code>vpc</code> | <code>vpc-cidr-block-association</code>
        /// | <code>vpc-endpoint</code> | <code>vpc-peering-connection</code> | <code>vpn-connection</code>
        /// | <code>vpn-gateway</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePrincipalIdFormat service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePrincipalIdFormat service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribePrincipalIdFormat">REST API Reference for DescribePrincipalIdFormat Operation</seealso>
        public virtual Task<DescribePrincipalIdFormatResponse> DescribePrincipalIdFormatAsync(DescribePrincipalIdFormatRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePrincipalIdFormatRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePrincipalIdFormatResponseUnmarshaller.Instance;

            return InvokeAsync<DescribePrincipalIdFormatResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribePublicIpv4Pools

        internal virtual DescribePublicIpv4PoolsResponse DescribePublicIpv4Pools(DescribePublicIpv4PoolsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePublicIpv4PoolsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePublicIpv4PoolsResponseUnmarshaller.Instance;

            return Invoke<DescribePublicIpv4PoolsResponse>(request, options);
        }



        /// <summary>
        /// Describes the specified IPv4 address pools.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePublicIpv4Pools service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePublicIpv4Pools service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribePublicIpv4Pools">REST API Reference for DescribePublicIpv4Pools Operation</seealso>
        public virtual Task<DescribePublicIpv4PoolsResponse> DescribePublicIpv4PoolsAsync(DescribePublicIpv4PoolsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePublicIpv4PoolsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePublicIpv4PoolsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribePublicIpv4PoolsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeRegions

        internal virtual DescribeRegionsResponse DescribeRegions()
        {
            return DescribeRegions(new DescribeRegionsRequest());
        }
        internal virtual DescribeRegionsResponse DescribeRegions(DescribeRegionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRegionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRegionsResponseUnmarshaller.Instance;

            return Invoke<DescribeRegionsResponse>(request, options);
        }


        /// <summary>
        /// Describes the Regions that are currently available to you. The API returns a list
        /// of all the Regions, including Regions that are disabled for your account. For information
        /// about enabling Regions for your account, see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/manage-account-payment.html#manage-account-payment-enable-disable-regions">Enabling
        /// and Disabling Regions</a> in the <i>AWS Billing and Cost Management User Guide</i>.
        /// 
        ///  
        /// <para>
        /// For a list of the Regions supported by Amazon EC2, see <a href="https://docs.aws.amazon.com/general/latest/gr/rande.html#ec2_region">
        /// Regions and Endpoints</a>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRegions service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeRegions">REST API Reference for DescribeRegions Operation</seealso>
        public virtual Task<DescribeRegionsResponse> DescribeRegionsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeRegionsAsync(new DescribeRegionsRequest(), cancellationToken);
        }



        /// <summary>
        /// Describes the Regions that are currently available to you. The API returns a list
        /// of all the Regions, including Regions that are disabled for your account. For information
        /// about enabling Regions for your account, see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/manage-account-payment.html#manage-account-payment-enable-disable-regions">Enabling
        /// and Disabling Regions</a> in the <i>AWS Billing and Cost Management User Guide</i>.
        /// 
        ///  
        /// <para>
        /// For a list of the Regions supported by Amazon EC2, see <a href="https://docs.aws.amazon.com/general/latest/gr/rande.html#ec2_region">
        /// Regions and Endpoints</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRegions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRegions service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeRegions">REST API Reference for DescribeRegions Operation</seealso>
        public virtual Task<DescribeRegionsResponse> DescribeRegionsAsync(DescribeRegionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRegionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRegionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeRegionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeReservedInstances

        internal virtual DescribeReservedInstancesResponse DescribeReservedInstances()
        {
            return DescribeReservedInstances(new DescribeReservedInstancesRequest());
        }
        internal virtual DescribeReservedInstancesResponse DescribeReservedInstances(DescribeReservedInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReservedInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReservedInstancesResponseUnmarshaller.Instance;

            return Invoke<DescribeReservedInstancesResponse>(request, options);
        }


        /// <summary>
        /// Describes one or more of the Reserved Instances that you purchased.
        /// 
        ///  
        /// <para>
        /// For more information about Reserved Instances, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/concepts-on-demand-reserved-instances.html">Reserved
        /// Instances</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReservedInstances service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeReservedInstances">REST API Reference for DescribeReservedInstances Operation</seealso>
        public virtual Task<DescribeReservedInstancesResponse> DescribeReservedInstancesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeReservedInstancesAsync(new DescribeReservedInstancesRequest(), cancellationToken);
        }



        /// <summary>
        /// Describes one or more of the Reserved Instances that you purchased.
        /// 
        ///  
        /// <para>
        /// For more information about Reserved Instances, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/concepts-on-demand-reserved-instances.html">Reserved
        /// Instances</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReservedInstances service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeReservedInstances">REST API Reference for DescribeReservedInstances Operation</seealso>
        public virtual Task<DescribeReservedInstancesResponse> DescribeReservedInstancesAsync(DescribeReservedInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReservedInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReservedInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeReservedInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeReservedInstancesListings

        internal virtual DescribeReservedInstancesListingsResponse DescribeReservedInstancesListings()
        {
            return DescribeReservedInstancesListings(new DescribeReservedInstancesListingsRequest());
        }
        internal virtual DescribeReservedInstancesListingsResponse DescribeReservedInstancesListings(DescribeReservedInstancesListingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReservedInstancesListingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReservedInstancesListingsResponseUnmarshaller.Instance;

            return Invoke<DescribeReservedInstancesListingsResponse>(request, options);
        }


        /// <summary>
        /// Describes your account's Reserved Instance listings in the Reserved Instance Marketplace.
        /// 
        ///  
        /// <para>
        /// The Reserved Instance Marketplace matches sellers who want to resell Reserved Instance
        /// capacity that they no longer need with buyers who want to purchase additional capacity.
        /// Reserved Instances bought and sold through the Reserved Instance Marketplace work
        /// like any other Reserved Instances.
        /// </para>
        ///  
        /// <para>
        /// As a seller, you choose to list some or all of your Reserved Instances, and you specify
        /// the upfront price to receive for them. Your Reserved Instances are then listed in
        /// the Reserved Instance Marketplace and are available for purchase.
        /// </para>
        ///  
        /// <para>
        /// As a buyer, you specify the configuration of the Reserved Instance to purchase, and
        /// the Marketplace matches what you're searching for with what's available. The Marketplace
        /// first sells the lowest priced Reserved Instances to you, and continues to sell available
        /// Reserved Instance listings to you until your demand is met. You are charged based
        /// on the total price of all of the listings that you purchase.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-market-general.html">Reserved
        /// Instance Marketplace</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReservedInstancesListings service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeReservedInstancesListings">REST API Reference for DescribeReservedInstancesListings Operation</seealso>
        public virtual Task<DescribeReservedInstancesListingsResponse> DescribeReservedInstancesListingsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeReservedInstancesListingsAsync(new DescribeReservedInstancesListingsRequest(), cancellationToken);
        }



        /// <summary>
        /// Describes your account's Reserved Instance listings in the Reserved Instance Marketplace.
        /// 
        ///  
        /// <para>
        /// The Reserved Instance Marketplace matches sellers who want to resell Reserved Instance
        /// capacity that they no longer need with buyers who want to purchase additional capacity.
        /// Reserved Instances bought and sold through the Reserved Instance Marketplace work
        /// like any other Reserved Instances.
        /// </para>
        ///  
        /// <para>
        /// As a seller, you choose to list some or all of your Reserved Instances, and you specify
        /// the upfront price to receive for them. Your Reserved Instances are then listed in
        /// the Reserved Instance Marketplace and are available for purchase.
        /// </para>
        ///  
        /// <para>
        /// As a buyer, you specify the configuration of the Reserved Instance to purchase, and
        /// the Marketplace matches what you're searching for with what's available. The Marketplace
        /// first sells the lowest priced Reserved Instances to you, and continues to sell available
        /// Reserved Instance listings to you until your demand is met. You are charged based
        /// on the total price of all of the listings that you purchase.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-market-general.html">Reserved
        /// Instance Marketplace</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedInstancesListings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReservedInstancesListings service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeReservedInstancesListings">REST API Reference for DescribeReservedInstancesListings Operation</seealso>
        public virtual Task<DescribeReservedInstancesListingsResponse> DescribeReservedInstancesListingsAsync(DescribeReservedInstancesListingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReservedInstancesListingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReservedInstancesListingsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeReservedInstancesListingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeReservedInstancesModifications

        internal virtual DescribeReservedInstancesModificationsResponse DescribeReservedInstancesModifications()
        {
            return DescribeReservedInstancesModifications(new DescribeReservedInstancesModificationsRequest());
        }
        internal virtual DescribeReservedInstancesModificationsResponse DescribeReservedInstancesModifications(DescribeReservedInstancesModificationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReservedInstancesModificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReservedInstancesModificationsResponseUnmarshaller.Instance;

            return Invoke<DescribeReservedInstancesModificationsResponse>(request, options);
        }


        /// <summary>
        /// Describes the modifications made to your Reserved Instances. If no parameter is specified,
        /// information about all your Reserved Instances modification requests is returned. If
        /// a modification ID is specified, only information about the specific modification is
        /// returned.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-modifying.html">Modifying
        /// Reserved Instances</a> in the Amazon Elastic Compute Cloud User Guide.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReservedInstancesModifications service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeReservedInstancesModifications">REST API Reference for DescribeReservedInstancesModifications Operation</seealso>
        public virtual Task<DescribeReservedInstancesModificationsResponse> DescribeReservedInstancesModificationsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeReservedInstancesModificationsAsync(new DescribeReservedInstancesModificationsRequest(), cancellationToken);
        }



        /// <summary>
        /// Describes the modifications made to your Reserved Instances. If no parameter is specified,
        /// information about all your Reserved Instances modification requests is returned. If
        /// a modification ID is specified, only information about the specific modification is
        /// returned.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-modifying.html">Modifying
        /// Reserved Instances</a> in the Amazon Elastic Compute Cloud User Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedInstancesModifications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReservedInstancesModifications service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeReservedInstancesModifications">REST API Reference for DescribeReservedInstancesModifications Operation</seealso>
        public virtual Task<DescribeReservedInstancesModificationsResponse> DescribeReservedInstancesModificationsAsync(DescribeReservedInstancesModificationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReservedInstancesModificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReservedInstancesModificationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeReservedInstancesModificationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeReservedInstancesOfferings

        internal virtual DescribeReservedInstancesOfferingsResponse DescribeReservedInstancesOfferings()
        {
            return DescribeReservedInstancesOfferings(new DescribeReservedInstancesOfferingsRequest());
        }
        internal virtual DescribeReservedInstancesOfferingsResponse DescribeReservedInstancesOfferings(DescribeReservedInstancesOfferingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReservedInstancesOfferingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReservedInstancesOfferingsResponseUnmarshaller.Instance;

            return Invoke<DescribeReservedInstancesOfferingsResponse>(request, options);
        }


        /// <summary>
        /// Describes Reserved Instance offerings that are available for purchase. With Reserved
        /// Instances, you purchase the right to launch instances for a period of time. During
        /// that time period, you do not receive insufficient capacity errors, and you pay a lower
        /// usage rate than the rate charged for On-Demand instances for the actual time used.
        /// 
        ///  
        /// <para>
        /// If you have listed your own Reserved Instances for sale in the Reserved Instance Marketplace,
        /// they will be excluded from these results. This is to ensure that you do not purchase
        /// your own Reserved Instances.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-market-general.html">Reserved
        /// Instance Marketplace</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReservedInstancesOfferings service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeReservedInstancesOfferings">REST API Reference for DescribeReservedInstancesOfferings Operation</seealso>
        public virtual Task<DescribeReservedInstancesOfferingsResponse> DescribeReservedInstancesOfferingsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeReservedInstancesOfferingsAsync(new DescribeReservedInstancesOfferingsRequest(), cancellationToken);
        }



        /// <summary>
        /// Describes Reserved Instance offerings that are available for purchase. With Reserved
        /// Instances, you purchase the right to launch instances for a period of time. During
        /// that time period, you do not receive insufficient capacity errors, and you pay a lower
        /// usage rate than the rate charged for On-Demand instances for the actual time used.
        /// 
        ///  
        /// <para>
        /// If you have listed your own Reserved Instances for sale in the Reserved Instance Marketplace,
        /// they will be excluded from these results. This is to ensure that you do not purchase
        /// your own Reserved Instances.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-market-general.html">Reserved
        /// Instance Marketplace</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedInstancesOfferings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReservedInstancesOfferings service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeReservedInstancesOfferings">REST API Reference for DescribeReservedInstancesOfferings Operation</seealso>
        public virtual Task<DescribeReservedInstancesOfferingsResponse> DescribeReservedInstancesOfferingsAsync(DescribeReservedInstancesOfferingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReservedInstancesOfferingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReservedInstancesOfferingsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeReservedInstancesOfferingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeRouteTables

        internal virtual DescribeRouteTablesResponse DescribeRouteTables()
        {
            return DescribeRouteTables(new DescribeRouteTablesRequest());
        }
        internal virtual DescribeRouteTablesResponse DescribeRouteTables(DescribeRouteTablesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRouteTablesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRouteTablesResponseUnmarshaller.Instance;

            return Invoke<DescribeRouteTablesResponse>(request, options);
        }


        /// <summary>
        /// Describes one or more of your route tables.
        /// 
        ///  
        /// <para>
        /// Each subnet in your VPC must be associated with a route table. If a subnet is not
        /// explicitly associated with any route table, it is implicitly associated with the main
        /// route table. This command does not return the subnet ID for implicit associations.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html">Route
        /// Tables</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRouteTables service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeRouteTables">REST API Reference for DescribeRouteTables Operation</seealso>
        public virtual Task<DescribeRouteTablesResponse> DescribeRouteTablesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeRouteTablesAsync(new DescribeRouteTablesRequest(), cancellationToken);
        }



        /// <summary>
        /// Describes one or more of your route tables.
        /// 
        ///  
        /// <para>
        /// Each subnet in your VPC must be associated with a route table. If a subnet is not
        /// explicitly associated with any route table, it is implicitly associated with the main
        /// route table. This command does not return the subnet ID for implicit associations.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html">Route
        /// Tables</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRouteTables service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRouteTables service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeRouteTables">REST API Reference for DescribeRouteTables Operation</seealso>
        public virtual Task<DescribeRouteTablesResponse> DescribeRouteTablesAsync(DescribeRouteTablesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRouteTablesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRouteTablesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeRouteTablesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeScheduledInstanceAvailability

        internal virtual DescribeScheduledInstanceAvailabilityResponse DescribeScheduledInstanceAvailability(DescribeScheduledInstanceAvailabilityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeScheduledInstanceAvailabilityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScheduledInstanceAvailabilityResponseUnmarshaller.Instance;

            return Invoke<DescribeScheduledInstanceAvailabilityResponse>(request, options);
        }



        /// <summary>
        /// Finds available schedules that meet the specified criteria.
        /// 
        ///  
        /// <para>
        /// You can search for an available schedule no more than 3 months in advance. You must
        /// meet the minimum required duration of 1,200 hours per year. For example, the minimum
        /// daily schedule is 4 hours, the minimum weekly schedule is 24 hours, and the minimum
        /// monthly schedule is 100 hours.
        /// </para>
        ///  
        /// <para>
        /// After you find a schedule that meets your needs, call <a>PurchaseScheduledInstances</a>
        /// to purchase Scheduled Instances with that schedule.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeScheduledInstanceAvailability service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeScheduledInstanceAvailability service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeScheduledInstanceAvailability">REST API Reference for DescribeScheduledInstanceAvailability Operation</seealso>
        public virtual Task<DescribeScheduledInstanceAvailabilityResponse> DescribeScheduledInstanceAvailabilityAsync(DescribeScheduledInstanceAvailabilityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeScheduledInstanceAvailabilityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScheduledInstanceAvailabilityResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeScheduledInstanceAvailabilityResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeScheduledInstances

        internal virtual DescribeScheduledInstancesResponse DescribeScheduledInstances(DescribeScheduledInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeScheduledInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScheduledInstancesResponseUnmarshaller.Instance;

            return Invoke<DescribeScheduledInstancesResponse>(request, options);
        }



        /// <summary>
        /// Describes the specified Scheduled Instances or all your Scheduled Instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeScheduledInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeScheduledInstances service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeScheduledInstances">REST API Reference for DescribeScheduledInstances Operation</seealso>
        public virtual Task<DescribeScheduledInstancesResponse> DescribeScheduledInstancesAsync(DescribeScheduledInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeScheduledInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScheduledInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeScheduledInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeSecurityGroupReferences

        internal virtual DescribeSecurityGroupReferencesResponse DescribeSecurityGroupReferences(DescribeSecurityGroupReferencesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSecurityGroupReferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSecurityGroupReferencesResponseUnmarshaller.Instance;

            return Invoke<DescribeSecurityGroupReferencesResponse>(request, options);
        }



        /// <summary>
        /// [VPC only] Describes the VPCs on the other side of a VPC peering connection that are
        /// referencing the security groups you've specified in this request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSecurityGroupReferences service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSecurityGroupReferences service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSecurityGroupReferences">REST API Reference for DescribeSecurityGroupReferences Operation</seealso>
        public virtual Task<DescribeSecurityGroupReferencesResponse> DescribeSecurityGroupReferencesAsync(DescribeSecurityGroupReferencesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSecurityGroupReferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSecurityGroupReferencesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSecurityGroupReferencesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeSecurityGroups

        internal virtual DescribeSecurityGroupsResponse DescribeSecurityGroups()
        {
            return DescribeSecurityGroups(new DescribeSecurityGroupsRequest());
        }
        internal virtual DescribeSecurityGroupsResponse DescribeSecurityGroups(DescribeSecurityGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSecurityGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSecurityGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeSecurityGroupsResponse>(request, options);
        }


        /// <summary>
        /// Describes the specified security groups or all of your security groups.
        /// 
        ///  
        /// <para>
        /// A security group is for use with instances either in the EC2-Classic platform or in
        /// a specific VPC. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-network-security.html">Amazon
        /// EC2 Security Groups</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> and
        /// <a href="https://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_SecurityGroups.html">Security
        /// Groups for Your VPC</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSecurityGroups service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSecurityGroups">REST API Reference for DescribeSecurityGroups Operation</seealso>
        public virtual Task<DescribeSecurityGroupsResponse> DescribeSecurityGroupsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeSecurityGroupsAsync(new DescribeSecurityGroupsRequest(), cancellationToken);
        }



        /// <summary>
        /// Describes the specified security groups or all of your security groups.
        /// 
        ///  
        /// <para>
        /// A security group is for use with instances either in the EC2-Classic platform or in
        /// a specific VPC. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-network-security.html">Amazon
        /// EC2 Security Groups</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> and
        /// <a href="https://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_SecurityGroups.html">Security
        /// Groups for Your VPC</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSecurityGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSecurityGroups service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSecurityGroups">REST API Reference for DescribeSecurityGroups Operation</seealso>
        public virtual Task<DescribeSecurityGroupsResponse> DescribeSecurityGroupsAsync(DescribeSecurityGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSecurityGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSecurityGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSecurityGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeSnapshotAttribute

        internal virtual DescribeSnapshotAttributeResponse DescribeSnapshotAttribute(DescribeSnapshotAttributeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSnapshotAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSnapshotAttributeResponseUnmarshaller.Instance;

            return Invoke<DescribeSnapshotAttributeResponse>(request, options);
        }



        /// <summary>
        /// Describes the specified attribute of the specified snapshot. You can specify only
        /// one attribute at a time.
        /// 
        ///  
        /// <para>
        /// For more information about EBS snapshots, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSSnapshots.html">Amazon
        /// EBS Snapshots</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshotAttribute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSnapshotAttribute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSnapshotAttribute">REST API Reference for DescribeSnapshotAttribute Operation</seealso>
        public virtual Task<DescribeSnapshotAttributeResponse> DescribeSnapshotAttributeAsync(DescribeSnapshotAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSnapshotAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSnapshotAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSnapshotAttributeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeSnapshots

        internal virtual DescribeSnapshotsResponse DescribeSnapshots()
        {
            return DescribeSnapshots(new DescribeSnapshotsRequest());
        }
        internal virtual DescribeSnapshotsResponse DescribeSnapshots(DescribeSnapshotsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSnapshotsResponseUnmarshaller.Instance;

            return Invoke<DescribeSnapshotsResponse>(request, options);
        }


        /// <summary>
        /// Describes the specified EBS snapshots available to you or all of the EBS snapshots
        /// available to you.
        /// 
        ///  
        /// <para>
        /// The snapshots available to you include public snapshots, private snapshots that you
        /// own, and private snapshots owned by other AWS accounts for which you have explicit
        /// create volume permissions.
        /// </para>
        ///  
        /// <para>
        /// The create volume permissions fall into the following categories:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>public</i>: The owner of the snapshot granted create volume permissions for the
        /// snapshot to the <code>all</code> group. All AWS accounts have create volume permissions
        /// for these snapshots.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>explicit</i>: The owner of the snapshot granted create volume permissions to a
        /// specific AWS account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>implicit</i>: An AWS account has implicit create volume permissions for all snapshots
        /// it owns.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The list of snapshots returned can be modified by specifying snapshot IDs, snapshot
        /// owners, or AWS accounts with create volume permissions. If no options are specified,
        /// Amazon EC2 returns all snapshots for which you have create volume permissions.
        /// </para>
        ///  
        /// <para>
        /// If you specify one or more snapshot IDs, only snapshots that have the specified IDs
        /// are returned. If you specify an invalid snapshot ID, an error is returned. If you
        /// specify a snapshot ID for which you do not have access, it is not included in the
        /// returned results.
        /// </para>
        ///  
        /// <para>
        /// If you specify one or more snapshot owners using the <code>OwnerIds</code> option,
        /// only snapshots from the specified owners and for which you have access are returned.
        /// The results can include the AWS account IDs of the specified owners, <code>amazon</code>
        /// for snapshots owned by Amazon, or <code>self</code> for snapshots that you own.
        /// </para>
        ///  
        /// <para>
        /// If you specify a list of restorable users, only snapshots with create snapshot permissions
        /// for those users are returned. You can specify AWS account IDs (if you own the snapshots),
        /// <code>self</code> for snapshots for which you own or have explicit permissions, or
        /// <code>all</code> for public snapshots.
        /// </para>
        ///  
        /// <para>
        /// If you are describing a long list of snapshots, you can paginate the output to make
        /// the list more manageable. The <code>MaxResults</code> parameter sets the maximum number
        /// of results returned in a single page. If the list of results exceeds your <code>MaxResults</code>
        /// value, then that number of results is returned along with a <code>NextToken</code>
        /// value that can be passed to a subsequent <code>DescribeSnapshots</code> request to
        /// retrieve the remaining results.
        /// </para>
        ///  
        /// <para>
        /// For more information about EBS snapshots, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSSnapshots.html">Amazon
        /// EBS Snapshots</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSnapshots service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSnapshots">REST API Reference for DescribeSnapshots Operation</seealso>
        public virtual Task<DescribeSnapshotsResponse> DescribeSnapshotsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeSnapshotsAsync(new DescribeSnapshotsRequest(), cancellationToken);
        }



        /// <summary>
        /// Describes the specified EBS snapshots available to you or all of the EBS snapshots
        /// available to you.
        /// 
        ///  
        /// <para>
        /// The snapshots available to you include public snapshots, private snapshots that you
        /// own, and private snapshots owned by other AWS accounts for which you have explicit
        /// create volume permissions.
        /// </para>
        ///  
        /// <para>
        /// The create volume permissions fall into the following categories:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>public</i>: The owner of the snapshot granted create volume permissions for the
        /// snapshot to the <code>all</code> group. All AWS accounts have create volume permissions
        /// for these snapshots.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>explicit</i>: The owner of the snapshot granted create volume permissions to a
        /// specific AWS account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>implicit</i>: An AWS account has implicit create volume permissions for all snapshots
        /// it owns.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The list of snapshots returned can be modified by specifying snapshot IDs, snapshot
        /// owners, or AWS accounts with create volume permissions. If no options are specified,
        /// Amazon EC2 returns all snapshots for which you have create volume permissions.
        /// </para>
        ///  
        /// <para>
        /// If you specify one or more snapshot IDs, only snapshots that have the specified IDs
        /// are returned. If you specify an invalid snapshot ID, an error is returned. If you
        /// specify a snapshot ID for which you do not have access, it is not included in the
        /// returned results.
        /// </para>
        ///  
        /// <para>
        /// If you specify one or more snapshot owners using the <code>OwnerIds</code> option,
        /// only snapshots from the specified owners and for which you have access are returned.
        /// The results can include the AWS account IDs of the specified owners, <code>amazon</code>
        /// for snapshots owned by Amazon, or <code>self</code> for snapshots that you own.
        /// </para>
        ///  
        /// <para>
        /// If you specify a list of restorable users, only snapshots with create snapshot permissions
        /// for those users are returned. You can specify AWS account IDs (if you own the snapshots),
        /// <code>self</code> for snapshots for which you own or have explicit permissions, or
        /// <code>all</code> for public snapshots.
        /// </para>
        ///  
        /// <para>
        /// If you are describing a long list of snapshots, you can paginate the output to make
        /// the list more manageable. The <code>MaxResults</code> parameter sets the maximum number
        /// of results returned in a single page. If the list of results exceeds your <code>MaxResults</code>
        /// value, then that number of results is returned along with a <code>NextToken</code>
        /// value that can be passed to a subsequent <code>DescribeSnapshots</code> request to
        /// retrieve the remaining results.
        /// </para>
        ///  
        /// <para>
        /// For more information about EBS snapshots, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSSnapshots.html">Amazon
        /// EBS Snapshots</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshots service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSnapshots service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSnapshots">REST API Reference for DescribeSnapshots Operation</seealso>
        public virtual Task<DescribeSnapshotsResponse> DescribeSnapshotsAsync(DescribeSnapshotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSnapshotsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSnapshotsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeSpotDatafeedSubscription

        internal virtual DescribeSpotDatafeedSubscriptionResponse DescribeSpotDatafeedSubscription()
        {
            return DescribeSpotDatafeedSubscription(new DescribeSpotDatafeedSubscriptionRequest());
        }
        internal virtual DescribeSpotDatafeedSubscriptionResponse DescribeSpotDatafeedSubscription(DescribeSpotDatafeedSubscriptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSpotDatafeedSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSpotDatafeedSubscriptionResponseUnmarshaller.Instance;

            return Invoke<DescribeSpotDatafeedSubscriptionResponse>(request, options);
        }


        /// <summary>
        /// Describes the data feed for Spot Instances. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/spot-data-feeds.html">Spot
        /// Instance Data Feed</a> in the <i>Amazon EC2 User Guide for Linux Instances</i>.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSpotDatafeedSubscription service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotDatafeedSubscription">REST API Reference for DescribeSpotDatafeedSubscription Operation</seealso>
        public virtual Task<DescribeSpotDatafeedSubscriptionResponse> DescribeSpotDatafeedSubscriptionAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeSpotDatafeedSubscriptionAsync(new DescribeSpotDatafeedSubscriptionRequest(), cancellationToken);
        }



        /// <summary>
        /// Describes the data feed for Spot Instances. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/spot-data-feeds.html">Spot
        /// Instance Data Feed</a> in the <i>Amazon EC2 User Guide for Linux Instances</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpotDatafeedSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSpotDatafeedSubscription service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotDatafeedSubscription">REST API Reference for DescribeSpotDatafeedSubscription Operation</seealso>
        public virtual Task<DescribeSpotDatafeedSubscriptionResponse> DescribeSpotDatafeedSubscriptionAsync(DescribeSpotDatafeedSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSpotDatafeedSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSpotDatafeedSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSpotDatafeedSubscriptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeSpotFleetInstances

        internal virtual DescribeSpotFleetInstancesResponse DescribeSpotFleetInstances(DescribeSpotFleetInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSpotFleetInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSpotFleetInstancesResponseUnmarshaller.Instance;

            return Invoke<DescribeSpotFleetInstancesResponse>(request, options);
        }



        /// <summary>
        /// Describes the running instances for the specified Spot Fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpotFleetInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSpotFleetInstances service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotFleetInstances">REST API Reference for DescribeSpotFleetInstances Operation</seealso>
        public virtual Task<DescribeSpotFleetInstancesResponse> DescribeSpotFleetInstancesAsync(DescribeSpotFleetInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSpotFleetInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSpotFleetInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSpotFleetInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeSpotFleetRequestHistory

        internal virtual DescribeSpotFleetRequestHistoryResponse DescribeSpotFleetRequestHistory(DescribeSpotFleetRequestHistoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSpotFleetRequestHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSpotFleetRequestHistoryResponseUnmarshaller.Instance;

            return Invoke<DescribeSpotFleetRequestHistoryResponse>(request, options);
        }



        /// <summary>
        /// Describes the events for the specified Spot Fleet request during the specified time.
        /// 
        ///  
        /// <para>
        /// Spot Fleet events are delayed by up to 30 seconds before they can be described. This
        /// ensures that you can query by the last evaluated time and not miss a recorded event.
        /// Spot Fleet events are available for 48 hours.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpotFleetRequestHistory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSpotFleetRequestHistory service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotFleetRequestHistory">REST API Reference for DescribeSpotFleetRequestHistory Operation</seealso>
        public virtual Task<DescribeSpotFleetRequestHistoryResponse> DescribeSpotFleetRequestHistoryAsync(DescribeSpotFleetRequestHistoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSpotFleetRequestHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSpotFleetRequestHistoryResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSpotFleetRequestHistoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeSpotFleetRequests

        internal virtual DescribeSpotFleetRequestsResponse DescribeSpotFleetRequests(DescribeSpotFleetRequestsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSpotFleetRequestsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSpotFleetRequestsResponseUnmarshaller.Instance;

            return Invoke<DescribeSpotFleetRequestsResponse>(request, options);
        }



        /// <summary>
        /// Describes your Spot Fleet requests.
        /// 
        ///  
        /// <para>
        /// Spot Fleet requests are deleted 48 hours after they are canceled and their instances
        /// are terminated.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpotFleetRequests service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSpotFleetRequests service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotFleetRequests">REST API Reference for DescribeSpotFleetRequests Operation</seealso>
        public virtual Task<DescribeSpotFleetRequestsResponse> DescribeSpotFleetRequestsAsync(DescribeSpotFleetRequestsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSpotFleetRequestsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSpotFleetRequestsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSpotFleetRequestsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeSpotInstanceRequests

        internal virtual DescribeSpotInstanceRequestsResponse DescribeSpotInstanceRequests()
        {
            return DescribeSpotInstanceRequests(new DescribeSpotInstanceRequestsRequest());
        }
        internal virtual DescribeSpotInstanceRequestsResponse DescribeSpotInstanceRequests(DescribeSpotInstanceRequestsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSpotInstanceRequestsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSpotInstanceRequestsResponseUnmarshaller.Instance;

            return Invoke<DescribeSpotInstanceRequestsResponse>(request, options);
        }


        /// <summary>
        /// Describes the specified Spot Instance requests.
        /// 
        ///  
        /// <para>
        /// You can use <code>DescribeSpotInstanceRequests</code> to find a running Spot Instance
        /// by examining the response. If the status of the Spot Instance is <code>fulfilled</code>,
        /// the instance ID appears in the response and contains the identifier of the instance.
        /// Alternatively, you can use <a>DescribeInstances</a> with a filter to look for instances
        /// where the instance lifecycle is <code>spot</code>.
        /// </para>
        ///  
        /// <para>
        /// We recommend that you set <code>MaxResults</code> to a value between 5 and 1000 to
        /// limit the number of results returned. This paginates the output, which makes the list
        /// more manageable and returns the results faster. If the list of results exceeds your
        /// <code>MaxResults</code> value, then that number of results is returned along with
        /// a <code>NextToken</code> value that can be passed to a subsequent <code>DescribeSpotInstanceRequests</code>
        /// request to retrieve the remaining results.
        /// </para>
        ///  
        /// <para>
        /// Spot Instance requests are deleted four hours after they are canceled and their instances
        /// are terminated.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSpotInstanceRequests service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotInstanceRequests">REST API Reference for DescribeSpotInstanceRequests Operation</seealso>
        public virtual Task<DescribeSpotInstanceRequestsResponse> DescribeSpotInstanceRequestsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeSpotInstanceRequestsAsync(new DescribeSpotInstanceRequestsRequest(), cancellationToken);
        }



        /// <summary>
        /// Describes the specified Spot Instance requests.
        /// 
        ///  
        /// <para>
        /// You can use <code>DescribeSpotInstanceRequests</code> to find a running Spot Instance
        /// by examining the response. If the status of the Spot Instance is <code>fulfilled</code>,
        /// the instance ID appears in the response and contains the identifier of the instance.
        /// Alternatively, you can use <a>DescribeInstances</a> with a filter to look for instances
        /// where the instance lifecycle is <code>spot</code>.
        /// </para>
        ///  
        /// <para>
        /// We recommend that you set <code>MaxResults</code> to a value between 5 and 1000 to
        /// limit the number of results returned. This paginates the output, which makes the list
        /// more manageable and returns the results faster. If the list of results exceeds your
        /// <code>MaxResults</code> value, then that number of results is returned along with
        /// a <code>NextToken</code> value that can be passed to a subsequent <code>DescribeSpotInstanceRequests</code>
        /// request to retrieve the remaining results.
        /// </para>
        ///  
        /// <para>
        /// Spot Instance requests are deleted four hours after they are canceled and their instances
        /// are terminated.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpotInstanceRequests service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSpotInstanceRequests service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotInstanceRequests">REST API Reference for DescribeSpotInstanceRequests Operation</seealso>
        public virtual Task<DescribeSpotInstanceRequestsResponse> DescribeSpotInstanceRequestsAsync(DescribeSpotInstanceRequestsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSpotInstanceRequestsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSpotInstanceRequestsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSpotInstanceRequestsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeSpotPriceHistory

        internal virtual DescribeSpotPriceHistoryResponse DescribeSpotPriceHistory()
        {
            return DescribeSpotPriceHistory(new DescribeSpotPriceHistoryRequest());
        }
        internal virtual DescribeSpotPriceHistoryResponse DescribeSpotPriceHistory(DescribeSpotPriceHistoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSpotPriceHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSpotPriceHistoryResponseUnmarshaller.Instance;

            return Invoke<DescribeSpotPriceHistoryResponse>(request, options);
        }


        /// <summary>
        /// Describes the Spot price history. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-spot-instances-history.html">Spot
        /// Instance Pricing History</a> in the <i>Amazon EC2 User Guide for Linux Instances</i>.
        /// 
        ///  
        /// <para>
        /// When you specify a start and end time, this operation returns the prices of the instance
        /// types within the time range that you specified and the time when the price changed.
        /// The price is valid within the time period that you specified; the response merely
        /// indicates the last time that the price changed.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSpotPriceHistory service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotPriceHistory">REST API Reference for DescribeSpotPriceHistory Operation</seealso>
        public virtual Task<DescribeSpotPriceHistoryResponse> DescribeSpotPriceHistoryAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeSpotPriceHistoryAsync(new DescribeSpotPriceHistoryRequest(), cancellationToken);
        }



        /// <summary>
        /// Describes the Spot price history. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-spot-instances-history.html">Spot
        /// Instance Pricing History</a> in the <i>Amazon EC2 User Guide for Linux Instances</i>.
        /// 
        ///  
        /// <para>
        /// When you specify a start and end time, this operation returns the prices of the instance
        /// types within the time range that you specified and the time when the price changed.
        /// The price is valid within the time period that you specified; the response merely
        /// indicates the last time that the price changed.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpotPriceHistory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSpotPriceHistory service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotPriceHistory">REST API Reference for DescribeSpotPriceHistory Operation</seealso>
        public virtual Task<DescribeSpotPriceHistoryResponse> DescribeSpotPriceHistoryAsync(DescribeSpotPriceHistoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSpotPriceHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSpotPriceHistoryResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSpotPriceHistoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeStaleSecurityGroups

        internal virtual DescribeStaleSecurityGroupsResponse DescribeStaleSecurityGroups(DescribeStaleSecurityGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStaleSecurityGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStaleSecurityGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeStaleSecurityGroupsResponse>(request, options);
        }



        /// <summary>
        /// [VPC only] Describes the stale security group rules for security groups in a specified
        /// VPC. Rules are stale when they reference a deleted security group in a peer VPC, or
        /// a security group in a peer VPC for which the VPC peering connection has been deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStaleSecurityGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeStaleSecurityGroups service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeStaleSecurityGroups">REST API Reference for DescribeStaleSecurityGroups Operation</seealso>
        public virtual Task<DescribeStaleSecurityGroupsResponse> DescribeStaleSecurityGroupsAsync(DescribeStaleSecurityGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStaleSecurityGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStaleSecurityGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeStaleSecurityGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeSubnets

        internal virtual DescribeSubnetsResponse DescribeSubnets()
        {
            return DescribeSubnets(new DescribeSubnetsRequest());
        }
        internal virtual DescribeSubnetsResponse DescribeSubnets(DescribeSubnetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSubnetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSubnetsResponseUnmarshaller.Instance;

            return Invoke<DescribeSubnetsResponse>(request, options);
        }


        /// <summary>
        /// Describes one or more of your subnets.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Subnets.html">Your
        /// VPC and Subnets</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSubnets service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSubnets">REST API Reference for DescribeSubnets Operation</seealso>
        public virtual Task<DescribeSubnetsResponse> DescribeSubnetsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeSubnetsAsync(new DescribeSubnetsRequest(), cancellationToken);
        }



        /// <summary>
        /// Describes one or more of your subnets.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Subnets.html">Your
        /// VPC and Subnets</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSubnets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSubnets service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSubnets">REST API Reference for DescribeSubnets Operation</seealso>
        public virtual Task<DescribeSubnetsResponse> DescribeSubnetsAsync(DescribeSubnetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSubnetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSubnetsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSubnetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeTags

        internal virtual DescribeTagsResponse DescribeTags()
        {
            return DescribeTags(new DescribeTagsRequest());
        }
        internal virtual DescribeTagsResponse DescribeTags(DescribeTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTagsResponseUnmarshaller.Instance;

            return Invoke<DescribeTagsResponse>(request, options);
        }


        /// <summary>
        /// Describes the specified tags for your EC2 resources.
        /// 
        ///  
        /// <para>
        /// For more information about tags, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html">Tagging
        /// Your Resources</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeTags">REST API Reference for DescribeTags Operation</seealso>
        public virtual Task<DescribeTagsResponse> DescribeTagsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeTagsAsync(new DescribeTagsRequest(), cancellationToken);
        }



        /// <summary>
        /// Describes the specified tags for your EC2 resources.
        /// 
        ///  
        /// <para>
        /// For more information about tags, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html">Tagging
        /// Your Resources</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeTags">REST API Reference for DescribeTags Operation</seealso>
        public virtual Task<DescribeTagsResponse> DescribeTagsAsync(DescribeTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTagsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeTransitGatewayAttachments

        internal virtual DescribeTransitGatewayAttachmentsResponse DescribeTransitGatewayAttachments(DescribeTransitGatewayAttachmentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTransitGatewayAttachmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTransitGatewayAttachmentsResponseUnmarshaller.Instance;

            return Invoke<DescribeTransitGatewayAttachmentsResponse>(request, options);
        }



        /// <summary>
        /// Describes one or more attachments between resources and transit gateways. By default,
        /// all attachments are described. Alternatively, you can filter the results by attachment
        /// ID, attachment state, resource ID, or resource owner.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTransitGatewayAttachments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTransitGatewayAttachments service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeTransitGatewayAttachments">REST API Reference for DescribeTransitGatewayAttachments Operation</seealso>
        public virtual Task<DescribeTransitGatewayAttachmentsResponse> DescribeTransitGatewayAttachmentsAsync(DescribeTransitGatewayAttachmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTransitGatewayAttachmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTransitGatewayAttachmentsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTransitGatewayAttachmentsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeTransitGatewayRouteTables

        internal virtual DescribeTransitGatewayRouteTablesResponse DescribeTransitGatewayRouteTables(DescribeTransitGatewayRouteTablesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTransitGatewayRouteTablesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTransitGatewayRouteTablesResponseUnmarshaller.Instance;

            return Invoke<DescribeTransitGatewayRouteTablesResponse>(request, options);
        }



        /// <summary>
        /// Describes one or more transit gateway route tables. By default, all transit gateway
        /// route tables are described. Alternatively, you can filter the results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTransitGatewayRouteTables service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTransitGatewayRouteTables service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeTransitGatewayRouteTables">REST API Reference for DescribeTransitGatewayRouteTables Operation</seealso>
        public virtual Task<DescribeTransitGatewayRouteTablesResponse> DescribeTransitGatewayRouteTablesAsync(DescribeTransitGatewayRouteTablesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTransitGatewayRouteTablesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTransitGatewayRouteTablesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTransitGatewayRouteTablesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeTransitGateways

        internal virtual DescribeTransitGatewaysResponse DescribeTransitGateways(DescribeTransitGatewaysRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTransitGatewaysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTransitGatewaysResponseUnmarshaller.Instance;

            return Invoke<DescribeTransitGatewaysResponse>(request, options);
        }



        /// <summary>
        /// Describes one or more transit gateways. By default, all transit gateways are described.
        /// Alternatively, you can filter the results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTransitGateways service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTransitGateways service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeTransitGateways">REST API Reference for DescribeTransitGateways Operation</seealso>
        public virtual Task<DescribeTransitGatewaysResponse> DescribeTransitGatewaysAsync(DescribeTransitGatewaysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTransitGatewaysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTransitGatewaysResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTransitGatewaysResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeTransitGatewayVpcAttachments

        internal virtual DescribeTransitGatewayVpcAttachmentsResponse DescribeTransitGatewayVpcAttachments(DescribeTransitGatewayVpcAttachmentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTransitGatewayVpcAttachmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTransitGatewayVpcAttachmentsResponseUnmarshaller.Instance;

            return Invoke<DescribeTransitGatewayVpcAttachmentsResponse>(request, options);
        }



        /// <summary>
        /// Describes one or more VPC attachments. By default, all VPC attachments are described.
        /// Alternatively, you can filter the results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTransitGatewayVpcAttachments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTransitGatewayVpcAttachments service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeTransitGatewayVpcAttachments">REST API Reference for DescribeTransitGatewayVpcAttachments Operation</seealso>
        public virtual Task<DescribeTransitGatewayVpcAttachmentsResponse> DescribeTransitGatewayVpcAttachmentsAsync(DescribeTransitGatewayVpcAttachmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTransitGatewayVpcAttachmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTransitGatewayVpcAttachmentsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTransitGatewayVpcAttachmentsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeVolumeAttribute

        internal virtual DescribeVolumeAttributeResponse DescribeVolumeAttribute(DescribeVolumeAttributeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVolumeAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVolumeAttributeResponseUnmarshaller.Instance;

            return Invoke<DescribeVolumeAttributeResponse>(request, options);
        }



        /// <summary>
        /// Describes the specified attribute of the specified volume. You can specify only one
        /// attribute at a time.
        /// 
        ///  
        /// <para>
        /// For more information about EBS volumes, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSVolumes.html">Amazon
        /// EBS Volumes</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVolumeAttribute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVolumeAttribute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVolumeAttribute">REST API Reference for DescribeVolumeAttribute Operation</seealso>
        public virtual Task<DescribeVolumeAttributeResponse> DescribeVolumeAttributeAsync(DescribeVolumeAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVolumeAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVolumeAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVolumeAttributeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeVolumes

        internal virtual DescribeVolumesResponse DescribeVolumes()
        {
            return DescribeVolumes(new DescribeVolumesRequest());
        }
        internal virtual DescribeVolumesResponse DescribeVolumes(DescribeVolumesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVolumesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVolumesResponseUnmarshaller.Instance;

            return Invoke<DescribeVolumesResponse>(request, options);
        }


        /// <summary>
        /// Describes the specified EBS volumes or all of your EBS volumes.
        /// 
        ///  
        /// <para>
        /// If you are describing a long list of volumes, you can paginate the output to make
        /// the list more manageable. The <code>MaxResults</code> parameter sets the maximum number
        /// of results returned in a single page. If the list of results exceeds your <code>MaxResults</code>
        /// value, then that number of results is returned along with a <code>NextToken</code>
        /// value that can be passed to a subsequent <code>DescribeVolumes</code> request to retrieve
        /// the remaining results.
        /// </para>
        ///  
        /// <para>
        /// For more information about EBS volumes, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSVolumes.html">Amazon
        /// EBS Volumes</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVolumes service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVolumes">REST API Reference for DescribeVolumes Operation</seealso>
        public virtual Task<DescribeVolumesResponse> DescribeVolumesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeVolumesAsync(new DescribeVolumesRequest(), cancellationToken);
        }



        /// <summary>
        /// Describes the specified EBS volumes or all of your EBS volumes.
        /// 
        ///  
        /// <para>
        /// If you are describing a long list of volumes, you can paginate the output to make
        /// the list more manageable. The <code>MaxResults</code> parameter sets the maximum number
        /// of results returned in a single page. If the list of results exceeds your <code>MaxResults</code>
        /// value, then that number of results is returned along with a <code>NextToken</code>
        /// value that can be passed to a subsequent <code>DescribeVolumes</code> request to retrieve
        /// the remaining results.
        /// </para>
        ///  
        /// <para>
        /// For more information about EBS volumes, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSVolumes.html">Amazon
        /// EBS Volumes</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVolumes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVolumes service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVolumes">REST API Reference for DescribeVolumes Operation</seealso>
        public virtual Task<DescribeVolumesResponse> DescribeVolumesAsync(DescribeVolumesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVolumesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVolumesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVolumesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeVolumesModifications

        internal virtual DescribeVolumesModificationsResponse DescribeVolumesModifications(DescribeVolumesModificationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVolumesModificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVolumesModificationsResponseUnmarshaller.Instance;

            return Invoke<DescribeVolumesModificationsResponse>(request, options);
        }



        /// <summary>
        /// Reports the current modification status of EBS volumes.
        /// 
        ///  
        /// <para>
        /// Current-generation EBS volumes support modification of attributes including type,
        /// size, and (for <code>io1</code> volumes) IOPS provisioning while either attached to
        /// or detached from an instance. Following an action from the API or the console to modify
        /// a volume, the status of the modification may be <code>modifying</code>, <code>optimizing</code>,
        /// <code>completed</code>, or <code>failed</code>. If a volume has never been modified,
        /// then certain elements of the returned <code>VolumeModification</code> objects are
        /// null. 
        /// </para>
        ///  
        /// <para>
        ///  You can also use CloudWatch Events to check the status of a modification to an EBS
        /// volume. For information about CloudWatch Events, see the <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/events/">Amazon
        /// CloudWatch Events User Guide</a>. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-expand-volume.html#monitoring_mods">Monitoring
        /// Volume Modifications"</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVolumesModifications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVolumesModifications service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVolumesModifications">REST API Reference for DescribeVolumesModifications Operation</seealso>
        public virtual Task<DescribeVolumesModificationsResponse> DescribeVolumesModificationsAsync(DescribeVolumesModificationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVolumesModificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVolumesModificationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVolumesModificationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeVolumeStatus

        internal virtual DescribeVolumeStatusResponse DescribeVolumeStatus()
        {
            return DescribeVolumeStatus(new DescribeVolumeStatusRequest());
        }
        internal virtual DescribeVolumeStatusResponse DescribeVolumeStatus(DescribeVolumeStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVolumeStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVolumeStatusResponseUnmarshaller.Instance;

            return Invoke<DescribeVolumeStatusResponse>(request, options);
        }


        /// <summary>
        /// Describes the status of the specified volumes. Volume status provides the result of
        /// the checks performed on your volumes to determine events that can impair the performance
        /// of your volumes. The performance of a volume can be affected if an issue occurs on
        /// the volume's underlying host. If the volume's underlying host experiences a power
        /// outage or system issue, after the system is restored, there could be data inconsistencies
        /// on the volume. Volume events notify you if this occurs. Volume actions notify you
        /// if any action needs to be taken in response to the event.
        /// 
        ///  
        /// <para>
        /// The <code>DescribeVolumeStatus</code> operation provides the following information
        /// about the specified volumes:
        /// </para>
        ///  
        /// <para>
        ///  <i>Status</i>: Reflects the current status of the volume. The possible values are
        /// <code>ok</code>, <code>impaired</code> , <code>warning</code>, or <code>insufficient-data</code>.
        /// If all checks pass, the overall status of the volume is <code>ok</code>. If the check
        /// fails, the overall status is <code>impaired</code>. If the status is <code>insufficient-data</code>,
        /// then the checks may still be taking place on your volume at the time. We recommend
        /// that you retry the request. For more information about volume status, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/monitoring-volume-status.html">Monitoring
        /// the Status of Your Volumes</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <i>Events</i>: Reflect the cause of a volume status and may require you to take action.
        /// For example, if your volume returns an <code>impaired</code> status, then the volume
        /// event might be <code>potential-data-inconsistency</code>. This means that your volume
        /// has been affected by an issue with the underlying host, has all I/O operations disabled,
        /// and may have inconsistent data.
        /// </para>
        ///  
        /// <para>
        ///  <i>Actions</i>: Reflect the actions you may have to take in response to an event.
        /// For example, if the status of the volume is <code>impaired</code> and the volume event
        /// shows <code>potential-data-inconsistency</code>, then the action shows <code>enable-volume-io</code>.
        /// This means that you may want to enable the I/O operations for the volume by calling
        /// the <a>EnableVolumeIO</a> action and then check the volume for data consistency.
        /// </para>
        ///  
        /// <para>
        /// Volume status is based on the volume status checks, and does not reflect the volume
        /// state. Therefore, volume status does not indicate volumes in the <code>error</code>
        /// state (for example, when a volume is incapable of accepting I/O.)
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVolumeStatus service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVolumeStatus">REST API Reference for DescribeVolumeStatus Operation</seealso>
        public virtual Task<DescribeVolumeStatusResponse> DescribeVolumeStatusAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeVolumeStatusAsync(new DescribeVolumeStatusRequest(), cancellationToken);
        }



        /// <summary>
        /// Describes the status of the specified volumes. Volume status provides the result of
        /// the checks performed on your volumes to determine events that can impair the performance
        /// of your volumes. The performance of a volume can be affected if an issue occurs on
        /// the volume's underlying host. If the volume's underlying host experiences a power
        /// outage or system issue, after the system is restored, there could be data inconsistencies
        /// on the volume. Volume events notify you if this occurs. Volume actions notify you
        /// if any action needs to be taken in response to the event.
        /// 
        ///  
        /// <para>
        /// The <code>DescribeVolumeStatus</code> operation provides the following information
        /// about the specified volumes:
        /// </para>
        ///  
        /// <para>
        ///  <i>Status</i>: Reflects the current status of the volume. The possible values are
        /// <code>ok</code>, <code>impaired</code> , <code>warning</code>, or <code>insufficient-data</code>.
        /// If all checks pass, the overall status of the volume is <code>ok</code>. If the check
        /// fails, the overall status is <code>impaired</code>. If the status is <code>insufficient-data</code>,
        /// then the checks may still be taking place on your volume at the time. We recommend
        /// that you retry the request. For more information about volume status, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/monitoring-volume-status.html">Monitoring
        /// the Status of Your Volumes</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <i>Events</i>: Reflect the cause of a volume status and may require you to take action.
        /// For example, if your volume returns an <code>impaired</code> status, then the volume
        /// event might be <code>potential-data-inconsistency</code>. This means that your volume
        /// has been affected by an issue with the underlying host, has all I/O operations disabled,
        /// and may have inconsistent data.
        /// </para>
        ///  
        /// <para>
        ///  <i>Actions</i>: Reflect the actions you may have to take in response to an event.
        /// For example, if the status of the volume is <code>impaired</code> and the volume event
        /// shows <code>potential-data-inconsistency</code>, then the action shows <code>enable-volume-io</code>.
        /// This means that you may want to enable the I/O operations for the volume by calling
        /// the <a>EnableVolumeIO</a> action and then check the volume for data consistency.
        /// </para>
        ///  
        /// <para>
        /// Volume status is based on the volume status checks, and does not reflect the volume
        /// state. Therefore, volume status does not indicate volumes in the <code>error</code>
        /// state (for example, when a volume is incapable of accepting I/O.)
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVolumeStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVolumeStatus service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVolumeStatus">REST API Reference for DescribeVolumeStatus Operation</seealso>
        public virtual Task<DescribeVolumeStatusResponse> DescribeVolumeStatusAsync(DescribeVolumeStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVolumeStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVolumeStatusResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVolumeStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeVpcAttribute

        internal virtual DescribeVpcAttributeResponse DescribeVpcAttribute(DescribeVpcAttributeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVpcAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpcAttributeResponseUnmarshaller.Instance;

            return Invoke<DescribeVpcAttributeResponse>(request, options);
        }



        /// <summary>
        /// Describes the specified attribute of the specified VPC. You can specify only one attribute
        /// at a time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcAttribute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVpcAttribute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcAttribute">REST API Reference for DescribeVpcAttribute Operation</seealso>
        public virtual Task<DescribeVpcAttributeResponse> DescribeVpcAttributeAsync(DescribeVpcAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVpcAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpcAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVpcAttributeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeVpcClassicLink

        internal virtual DescribeVpcClassicLinkResponse DescribeVpcClassicLink(DescribeVpcClassicLinkRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVpcClassicLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpcClassicLinkResponseUnmarshaller.Instance;

            return Invoke<DescribeVpcClassicLinkResponse>(request, options);
        }



        /// <summary>
        /// Describes the ClassicLink status of one or more VPCs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcClassicLink service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVpcClassicLink service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcClassicLink">REST API Reference for DescribeVpcClassicLink Operation</seealso>
        public virtual Task<DescribeVpcClassicLinkResponse> DescribeVpcClassicLinkAsync(DescribeVpcClassicLinkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVpcClassicLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpcClassicLinkResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVpcClassicLinkResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeVpcClassicLinkDnsSupport

        internal virtual DescribeVpcClassicLinkDnsSupportResponse DescribeVpcClassicLinkDnsSupport(DescribeVpcClassicLinkDnsSupportRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVpcClassicLinkDnsSupportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpcClassicLinkDnsSupportResponseUnmarshaller.Instance;

            return Invoke<DescribeVpcClassicLinkDnsSupportResponse>(request, options);
        }



        /// <summary>
        /// Describes the ClassicLink DNS support status of one or more VPCs. If enabled, the
        /// DNS hostname of a linked EC2-Classic instance resolves to its private IP address when
        /// addressed from an instance in the VPC to which it's linked. Similarly, the DNS hostname
        /// of an instance in a VPC resolves to its private IP address when addressed from a linked
        /// EC2-Classic instance. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/vpc-classiclink.html">ClassicLink</a>
        /// in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcClassicLinkDnsSupport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVpcClassicLinkDnsSupport service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcClassicLinkDnsSupport">REST API Reference for DescribeVpcClassicLinkDnsSupport Operation</seealso>
        public virtual Task<DescribeVpcClassicLinkDnsSupportResponse> DescribeVpcClassicLinkDnsSupportAsync(DescribeVpcClassicLinkDnsSupportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVpcClassicLinkDnsSupportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpcClassicLinkDnsSupportResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVpcClassicLinkDnsSupportResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeVpcEndpointConnectionNotifications

        internal virtual DescribeVpcEndpointConnectionNotificationsResponse DescribeVpcEndpointConnectionNotifications(DescribeVpcEndpointConnectionNotificationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVpcEndpointConnectionNotificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpcEndpointConnectionNotificationsResponseUnmarshaller.Instance;

            return Invoke<DescribeVpcEndpointConnectionNotificationsResponse>(request, options);
        }



        /// <summary>
        /// Describes the connection notifications for VPC endpoints and VPC endpoint services.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcEndpointConnectionNotifications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVpcEndpointConnectionNotifications service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcEndpointConnectionNotifications">REST API Reference for DescribeVpcEndpointConnectionNotifications Operation</seealso>
        public virtual Task<DescribeVpcEndpointConnectionNotificationsResponse> DescribeVpcEndpointConnectionNotificationsAsync(DescribeVpcEndpointConnectionNotificationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVpcEndpointConnectionNotificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpcEndpointConnectionNotificationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVpcEndpointConnectionNotificationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeVpcEndpointConnections

        internal virtual DescribeVpcEndpointConnectionsResponse DescribeVpcEndpointConnections(DescribeVpcEndpointConnectionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVpcEndpointConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpcEndpointConnectionsResponseUnmarshaller.Instance;

            return Invoke<DescribeVpcEndpointConnectionsResponse>(request, options);
        }



        /// <summary>
        /// Describes the VPC endpoint connections to your VPC endpoint services, including any
        /// endpoints that are pending your acceptance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcEndpointConnections service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVpcEndpointConnections service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcEndpointConnections">REST API Reference for DescribeVpcEndpointConnections Operation</seealso>
        public virtual Task<DescribeVpcEndpointConnectionsResponse> DescribeVpcEndpointConnectionsAsync(DescribeVpcEndpointConnectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVpcEndpointConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpcEndpointConnectionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVpcEndpointConnectionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeVpcEndpoints

        internal virtual DescribeVpcEndpointsResponse DescribeVpcEndpoints(DescribeVpcEndpointsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVpcEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpcEndpointsResponseUnmarshaller.Instance;

            return Invoke<DescribeVpcEndpointsResponse>(request, options);
        }



        /// <summary>
        /// Describes one or more of your VPC endpoints.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcEndpoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVpcEndpoints service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcEndpoints">REST API Reference for DescribeVpcEndpoints Operation</seealso>
        public virtual Task<DescribeVpcEndpointsResponse> DescribeVpcEndpointsAsync(DescribeVpcEndpointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVpcEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpcEndpointsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVpcEndpointsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeVpcEndpointServiceConfigurations

        internal virtual DescribeVpcEndpointServiceConfigurationsResponse DescribeVpcEndpointServiceConfigurations(DescribeVpcEndpointServiceConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVpcEndpointServiceConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpcEndpointServiceConfigurationsResponseUnmarshaller.Instance;

            return Invoke<DescribeVpcEndpointServiceConfigurationsResponse>(request, options);
        }



        /// <summary>
        /// Describes the VPC endpoint service configurations in your account (your services).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcEndpointServiceConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVpcEndpointServiceConfigurations service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcEndpointServiceConfigurations">REST API Reference for DescribeVpcEndpointServiceConfigurations Operation</seealso>
        public virtual Task<DescribeVpcEndpointServiceConfigurationsResponse> DescribeVpcEndpointServiceConfigurationsAsync(DescribeVpcEndpointServiceConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVpcEndpointServiceConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpcEndpointServiceConfigurationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVpcEndpointServiceConfigurationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeVpcEndpointServicePermissions

        internal virtual DescribeVpcEndpointServicePermissionsResponse DescribeVpcEndpointServicePermissions(DescribeVpcEndpointServicePermissionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVpcEndpointServicePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpcEndpointServicePermissionsResponseUnmarshaller.Instance;

            return Invoke<DescribeVpcEndpointServicePermissionsResponse>(request, options);
        }



        /// <summary>
        /// Describes the principals (service consumers) that are permitted to discover your VPC
        /// endpoint service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcEndpointServicePermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVpcEndpointServicePermissions service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcEndpointServicePermissions">REST API Reference for DescribeVpcEndpointServicePermissions Operation</seealso>
        public virtual Task<DescribeVpcEndpointServicePermissionsResponse> DescribeVpcEndpointServicePermissionsAsync(DescribeVpcEndpointServicePermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVpcEndpointServicePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpcEndpointServicePermissionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVpcEndpointServicePermissionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeVpcEndpointServices

        internal virtual DescribeVpcEndpointServicesResponse DescribeVpcEndpointServices(DescribeVpcEndpointServicesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVpcEndpointServicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpcEndpointServicesResponseUnmarshaller.Instance;

            return Invoke<DescribeVpcEndpointServicesResponse>(request, options);
        }



        /// <summary>
        /// Describes available services to which you can create a VPC endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcEndpointServices service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVpcEndpointServices service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcEndpointServices">REST API Reference for DescribeVpcEndpointServices Operation</seealso>
        public virtual Task<DescribeVpcEndpointServicesResponse> DescribeVpcEndpointServicesAsync(DescribeVpcEndpointServicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVpcEndpointServicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpcEndpointServicesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVpcEndpointServicesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeVpcPeeringConnections

        internal virtual DescribeVpcPeeringConnectionsResponse DescribeVpcPeeringConnections()
        {
            return DescribeVpcPeeringConnections(new DescribeVpcPeeringConnectionsRequest());
        }
        internal virtual DescribeVpcPeeringConnectionsResponse DescribeVpcPeeringConnections(DescribeVpcPeeringConnectionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVpcPeeringConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpcPeeringConnectionsResponseUnmarshaller.Instance;

            return Invoke<DescribeVpcPeeringConnectionsResponse>(request, options);
        }


        /// <summary>
        /// Describes one or more of your VPC peering connections.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVpcPeeringConnections service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcPeeringConnections">REST API Reference for DescribeVpcPeeringConnections Operation</seealso>
        public virtual Task<DescribeVpcPeeringConnectionsResponse> DescribeVpcPeeringConnectionsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeVpcPeeringConnectionsAsync(new DescribeVpcPeeringConnectionsRequest(), cancellationToken);
        }



        /// <summary>
        /// Describes one or more of your VPC peering connections.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcPeeringConnections service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVpcPeeringConnections service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcPeeringConnections">REST API Reference for DescribeVpcPeeringConnections Operation</seealso>
        public virtual Task<DescribeVpcPeeringConnectionsResponse> DescribeVpcPeeringConnectionsAsync(DescribeVpcPeeringConnectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVpcPeeringConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpcPeeringConnectionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVpcPeeringConnectionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeVpcs

        internal virtual DescribeVpcsResponse DescribeVpcs()
        {
            return DescribeVpcs(new DescribeVpcsRequest());
        }
        internal virtual DescribeVpcsResponse DescribeVpcs(DescribeVpcsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVpcsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpcsResponseUnmarshaller.Instance;

            return Invoke<DescribeVpcsResponse>(request, options);
        }


        /// <summary>
        /// Describes one or more of your VPCs.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVpcs service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcs">REST API Reference for DescribeVpcs Operation</seealso>
        public virtual Task<DescribeVpcsResponse> DescribeVpcsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeVpcsAsync(new DescribeVpcsRequest(), cancellationToken);
        }



        /// <summary>
        /// Describes one or more of your VPCs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVpcs service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcs">REST API Reference for DescribeVpcs Operation</seealso>
        public virtual Task<DescribeVpcsResponse> DescribeVpcsAsync(DescribeVpcsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVpcsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpcsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVpcsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeVpnConnections

        internal virtual DescribeVpnConnectionsResponse DescribeVpnConnections()
        {
            return DescribeVpnConnections(new DescribeVpnConnectionsRequest());
        }
        internal virtual DescribeVpnConnectionsResponse DescribeVpnConnections(DescribeVpnConnectionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVpnConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpnConnectionsResponseUnmarshaller.Instance;

            return Invoke<DescribeVpnConnectionsResponse>(request, options);
        }


        /// <summary>
        /// Describes one or more of your VPN connections.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/vpn/latest/s2svpn/VPC_VPN.html">AWS
        /// Site-to-Site VPN</a> in the <i>AWS Site-to-Site VPN User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVpnConnections service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpnConnections">REST API Reference for DescribeVpnConnections Operation</seealso>
        public virtual Task<DescribeVpnConnectionsResponse> DescribeVpnConnectionsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeVpnConnectionsAsync(new DescribeVpnConnectionsRequest(), cancellationToken);
        }



        /// <summary>
        /// Describes one or more of your VPN connections.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/vpn/latest/s2svpn/VPC_VPN.html">AWS
        /// Site-to-Site VPN</a> in the <i>AWS Site-to-Site VPN User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpnConnections service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVpnConnections service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpnConnections">REST API Reference for DescribeVpnConnections Operation</seealso>
        public virtual Task<DescribeVpnConnectionsResponse> DescribeVpnConnectionsAsync(DescribeVpnConnectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVpnConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpnConnectionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVpnConnectionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeVpnGateways

        internal virtual DescribeVpnGatewaysResponse DescribeVpnGateways()
        {
            return DescribeVpnGateways(new DescribeVpnGatewaysRequest());
        }
        internal virtual DescribeVpnGatewaysResponse DescribeVpnGateways(DescribeVpnGatewaysRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVpnGatewaysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpnGatewaysResponseUnmarshaller.Instance;

            return Invoke<DescribeVpnGatewaysResponse>(request, options);
        }


        /// <summary>
        /// Describes one or more of your virtual private gateways.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/vpn/latest/s2svpn/VPC_VPN.html">AWS
        /// Site-to-Site VPN</a> in the <i>AWS Site-to-Site VPN User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVpnGateways service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpnGateways">REST API Reference for DescribeVpnGateways Operation</seealso>
        public virtual Task<DescribeVpnGatewaysResponse> DescribeVpnGatewaysAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeVpnGatewaysAsync(new DescribeVpnGatewaysRequest(), cancellationToken);
        }



        /// <summary>
        /// Describes one or more of your virtual private gateways.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/vpn/latest/s2svpn/VPC_VPN.html">AWS
        /// Site-to-Site VPN</a> in the <i>AWS Site-to-Site VPN User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpnGateways service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVpnGateways service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpnGateways">REST API Reference for DescribeVpnGateways Operation</seealso>
        public virtual Task<DescribeVpnGatewaysResponse> DescribeVpnGatewaysAsync(DescribeVpnGatewaysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVpnGatewaysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpnGatewaysResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVpnGatewaysResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DetachClassicLinkVpc

        internal virtual DetachClassicLinkVpcResponse DetachClassicLinkVpc(DetachClassicLinkVpcRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachClassicLinkVpcRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachClassicLinkVpcResponseUnmarshaller.Instance;

            return Invoke<DetachClassicLinkVpcResponse>(request, options);
        }



        /// <summary>
        /// Unlinks (detaches) a linked EC2-Classic instance from a VPC. After the instance has
        /// been unlinked, the VPC security groups are no longer associated with it. An instance
        /// is automatically unlinked from a VPC when it's stopped.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachClassicLinkVpc service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DetachClassicLinkVpc service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DetachClassicLinkVpc">REST API Reference for DetachClassicLinkVpc Operation</seealso>
        public virtual Task<DetachClassicLinkVpcResponse> DetachClassicLinkVpcAsync(DetachClassicLinkVpcRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachClassicLinkVpcRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachClassicLinkVpcResponseUnmarshaller.Instance;

            return InvokeAsync<DetachClassicLinkVpcResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DetachInternetGateway

        internal virtual DetachInternetGatewayResponse DetachInternetGateway(DetachInternetGatewayRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachInternetGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachInternetGatewayResponseUnmarshaller.Instance;

            return Invoke<DetachInternetGatewayResponse>(request, options);
        }



        /// <summary>
        /// Detaches an internet gateway from a VPC, disabling connectivity between the internet
        /// and the VPC. The VPC must not contain any running instances with Elastic IP addresses
        /// or public IPv4 addresses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachInternetGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DetachInternetGateway service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DetachInternetGateway">REST API Reference for DetachInternetGateway Operation</seealso>
        public virtual Task<DetachInternetGatewayResponse> DetachInternetGatewayAsync(DetachInternetGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachInternetGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachInternetGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<DetachInternetGatewayResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DetachNetworkInterface

        internal virtual DetachNetworkInterfaceResponse DetachNetworkInterface(DetachNetworkInterfaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachNetworkInterfaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachNetworkInterfaceResponseUnmarshaller.Instance;

            return Invoke<DetachNetworkInterfaceResponse>(request, options);
        }



        /// <summary>
        /// Detaches a network interface from an instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachNetworkInterface service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DetachNetworkInterface service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DetachNetworkInterface">REST API Reference for DetachNetworkInterface Operation</seealso>
        public virtual Task<DetachNetworkInterfaceResponse> DetachNetworkInterfaceAsync(DetachNetworkInterfaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachNetworkInterfaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachNetworkInterfaceResponseUnmarshaller.Instance;

            return InvokeAsync<DetachNetworkInterfaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DetachVolume

        internal virtual DetachVolumeResponse DetachVolume(DetachVolumeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachVolumeResponseUnmarshaller.Instance;

            return Invoke<DetachVolumeResponse>(request, options);
        }



        /// <summary>
        /// Detaches an EBS volume from an instance. Make sure to unmount any file systems on
        /// the device within your operating system before detaching the volume. Failure to do
        /// so can result in the volume becoming stuck in the <code>busy</code> state while detaching.
        /// If this happens, detachment can be delayed indefinitely until you unmount the volume,
        /// force detachment, reboot the instance, or all three. If an EBS volume is the root
        /// device of an instance, it can't be detached while the instance is running. To detach
        /// the root volume, stop the instance first.
        /// 
        ///  
        /// <para>
        /// When a volume with an AWS Marketplace product code is detached from an instance, the
        /// product code is no longer associated with the instance.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-detaching-volume.html">Detaching
        /// an Amazon EBS Volume</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachVolume service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DetachVolume service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DetachVolume">REST API Reference for DetachVolume Operation</seealso>
        public virtual Task<DetachVolumeResponse> DetachVolumeAsync(DetachVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachVolumeResponseUnmarshaller.Instance;

            return InvokeAsync<DetachVolumeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DetachVpnGateway

        internal virtual DetachVpnGatewayResponse DetachVpnGateway(DetachVpnGatewayRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachVpnGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachVpnGatewayResponseUnmarshaller.Instance;

            return Invoke<DetachVpnGatewayResponse>(request, options);
        }



        /// <summary>
        /// Detaches a virtual private gateway from a VPC. You do this if you're planning to turn
        /// off the VPC and not use it anymore. You can confirm a virtual private gateway has
        /// been completely detached from a VPC by describing the virtual private gateway (any
        /// attachments to the virtual private gateway are also described).
        /// 
        ///  
        /// <para>
        /// You must wait for the attachment's state to switch to <code>detached</code> before
        /// you can delete the VPC or attach a different VPC to the virtual private gateway.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachVpnGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DetachVpnGateway service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DetachVpnGateway">REST API Reference for DetachVpnGateway Operation</seealso>
        public virtual Task<DetachVpnGatewayResponse> DetachVpnGatewayAsync(DetachVpnGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachVpnGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachVpnGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<DetachVpnGatewayResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisableEbsEncryptionByDefault

        internal virtual DisableEbsEncryptionByDefaultResponse DisableEbsEncryptionByDefault(DisableEbsEncryptionByDefaultRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableEbsEncryptionByDefaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableEbsEncryptionByDefaultResponseUnmarshaller.Instance;

            return Invoke<DisableEbsEncryptionByDefaultResponse>(request, options);
        }



        /// <summary>
        /// Disables default encryption for EBS volumes that are created in your account in the
        /// current region.
        /// 
        ///  
        /// <para>
        /// Call this API if you have enabled default encryption using <a>EnableEbsEncryptionByDefault</a>
        /// and want to disable default EBS encryption. Once default EBS encryption is disabled,
        /// you can still create an encrypted volume by setting <i>encrypted</i> to <i>true</i>
        /// in the API call that creates the volume. 
        /// </para>
        ///  
        /// <para>
        /// Disabling default EBS encryption will not change the encryption status of any of your
        /// existing volumes.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableEbsEncryptionByDefault service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableEbsEncryptionByDefault service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisableEbsEncryptionByDefault">REST API Reference for DisableEbsEncryptionByDefault Operation</seealso>
        public virtual Task<DisableEbsEncryptionByDefaultResponse> DisableEbsEncryptionByDefaultAsync(DisableEbsEncryptionByDefaultRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableEbsEncryptionByDefaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableEbsEncryptionByDefaultResponseUnmarshaller.Instance;

            return InvokeAsync<DisableEbsEncryptionByDefaultResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisableTransitGatewayRouteTablePropagation

        internal virtual DisableTransitGatewayRouteTablePropagationResponse DisableTransitGatewayRouteTablePropagation(DisableTransitGatewayRouteTablePropagationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableTransitGatewayRouteTablePropagationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableTransitGatewayRouteTablePropagationResponseUnmarshaller.Instance;

            return Invoke<DisableTransitGatewayRouteTablePropagationResponse>(request, options);
        }



        /// <summary>
        /// Disables the specified resource attachment from propagating routes to the specified
        /// propagation route table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableTransitGatewayRouteTablePropagation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableTransitGatewayRouteTablePropagation service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisableTransitGatewayRouteTablePropagation">REST API Reference for DisableTransitGatewayRouteTablePropagation Operation</seealso>
        public virtual Task<DisableTransitGatewayRouteTablePropagationResponse> DisableTransitGatewayRouteTablePropagationAsync(DisableTransitGatewayRouteTablePropagationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableTransitGatewayRouteTablePropagationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableTransitGatewayRouteTablePropagationResponseUnmarshaller.Instance;

            return InvokeAsync<DisableTransitGatewayRouteTablePropagationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisableVgwRoutePropagation

        internal virtual DisableVgwRoutePropagationResponse DisableVgwRoutePropagation(DisableVgwRoutePropagationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableVgwRoutePropagationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableVgwRoutePropagationResponseUnmarshaller.Instance;

            return Invoke<DisableVgwRoutePropagationResponse>(request, options);
        }



        /// <summary>
        /// Disables a virtual private gateway (VGW) from propagating routes to a specified route
        /// table of a VPC.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableVgwRoutePropagation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableVgwRoutePropagation service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisableVgwRoutePropagation">REST API Reference for DisableVgwRoutePropagation Operation</seealso>
        public virtual Task<DisableVgwRoutePropagationResponse> DisableVgwRoutePropagationAsync(DisableVgwRoutePropagationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableVgwRoutePropagationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableVgwRoutePropagationResponseUnmarshaller.Instance;

            return InvokeAsync<DisableVgwRoutePropagationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisableVpcClassicLink

        internal virtual DisableVpcClassicLinkResponse DisableVpcClassicLink(DisableVpcClassicLinkRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableVpcClassicLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableVpcClassicLinkResponseUnmarshaller.Instance;

            return Invoke<DisableVpcClassicLinkResponse>(request, options);
        }



        /// <summary>
        /// Disables ClassicLink for a VPC. You cannot disable ClassicLink for a VPC that has
        /// EC2-Classic instances linked to it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableVpcClassicLink service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableVpcClassicLink service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisableVpcClassicLink">REST API Reference for DisableVpcClassicLink Operation</seealso>
        public virtual Task<DisableVpcClassicLinkResponse> DisableVpcClassicLinkAsync(DisableVpcClassicLinkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableVpcClassicLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableVpcClassicLinkResponseUnmarshaller.Instance;

            return InvokeAsync<DisableVpcClassicLinkResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisableVpcClassicLinkDnsSupport

        internal virtual DisableVpcClassicLinkDnsSupportResponse DisableVpcClassicLinkDnsSupport(DisableVpcClassicLinkDnsSupportRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableVpcClassicLinkDnsSupportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableVpcClassicLinkDnsSupportResponseUnmarshaller.Instance;

            return Invoke<DisableVpcClassicLinkDnsSupportResponse>(request, options);
        }



        /// <summary>
        /// Disables ClassicLink DNS support for a VPC. If disabled, DNS hostnames resolve to
        /// public IP addresses when addressed between a linked EC2-Classic instance and instances
        /// in the VPC to which it's linked. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/vpc-classiclink.html">ClassicLink</a>
        /// in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableVpcClassicLinkDnsSupport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableVpcClassicLinkDnsSupport service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisableVpcClassicLinkDnsSupport">REST API Reference for DisableVpcClassicLinkDnsSupport Operation</seealso>
        public virtual Task<DisableVpcClassicLinkDnsSupportResponse> DisableVpcClassicLinkDnsSupportAsync(DisableVpcClassicLinkDnsSupportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableVpcClassicLinkDnsSupportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableVpcClassicLinkDnsSupportResponseUnmarshaller.Instance;

            return InvokeAsync<DisableVpcClassicLinkDnsSupportResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateAddress

        internal virtual DisassociateAddressResponse DisassociateAddress(DisassociateAddressRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateAddressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateAddressResponseUnmarshaller.Instance;

            return Invoke<DisassociateAddressResponse>(request, options);
        }



        /// <summary>
        /// Disassociates an Elastic IP address from the instance or network interface it's associated
        /// with.
        /// 
        ///  
        /// <para>
        /// An Elastic IP address is for use in either the EC2-Classic platform or in a VPC. For
        /// more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html">Elastic
        /// IP Addresses</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This is an idempotent operation. If you perform the operation more than once, Amazon
        /// EC2 doesn't return an error.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateAddress service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateAddress service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisassociateAddress">REST API Reference for DisassociateAddress Operation</seealso>
        public virtual Task<DisassociateAddressResponse> DisassociateAddressAsync(DisassociateAddressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateAddressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateAddressResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateAddressResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateClientVpnTargetNetwork

        internal virtual DisassociateClientVpnTargetNetworkResponse DisassociateClientVpnTargetNetwork(DisassociateClientVpnTargetNetworkRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateClientVpnTargetNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateClientVpnTargetNetworkResponseUnmarshaller.Instance;

            return Invoke<DisassociateClientVpnTargetNetworkResponse>(request, options);
        }



        /// <summary>
        /// Disassociates a target network from the specified Client VPN endpoint. When you disassociate
        /// the last target network from a Client VPN, the following happens:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The route that was automatically added for the VPC is deleted
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// All active client connections are terminated
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// New client connections are disallowed
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The Client VPN endpoint's status changes to <code>pending-associate</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateClientVpnTargetNetwork service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateClientVpnTargetNetwork service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisassociateClientVpnTargetNetwork">REST API Reference for DisassociateClientVpnTargetNetwork Operation</seealso>
        public virtual Task<DisassociateClientVpnTargetNetworkResponse> DisassociateClientVpnTargetNetworkAsync(DisassociateClientVpnTargetNetworkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateClientVpnTargetNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateClientVpnTargetNetworkResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateClientVpnTargetNetworkResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateIamInstanceProfile

        internal virtual DisassociateIamInstanceProfileResponse DisassociateIamInstanceProfile(DisassociateIamInstanceProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateIamInstanceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateIamInstanceProfileResponseUnmarshaller.Instance;

            return Invoke<DisassociateIamInstanceProfileResponse>(request, options);
        }



        /// <summary>
        /// Disassociates an IAM instance profile from a running or stopped instance.
        /// 
        ///  
        /// <para>
        /// Use <a>DescribeIamInstanceProfileAssociations</a> to get the association ID.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateIamInstanceProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateIamInstanceProfile service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisassociateIamInstanceProfile">REST API Reference for DisassociateIamInstanceProfile Operation</seealso>
        public virtual Task<DisassociateIamInstanceProfileResponse> DisassociateIamInstanceProfileAsync(DisassociateIamInstanceProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateIamInstanceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateIamInstanceProfileResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateIamInstanceProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateRouteTable

        internal virtual DisassociateRouteTableResponse DisassociateRouteTable(DisassociateRouteTableRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateRouteTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateRouteTableResponseUnmarshaller.Instance;

            return Invoke<DisassociateRouteTableResponse>(request, options);
        }



        /// <summary>
        /// Disassociates a subnet from a route table.
        /// 
        ///  
        /// <para>
        /// After you perform this action, the subnet no longer uses the routes in the route table.
        /// Instead, it uses the routes in the VPC's main route table. For more information about
        /// route tables, see <a href="https://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html">Route
        /// Tables</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateRouteTable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateRouteTable service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisassociateRouteTable">REST API Reference for DisassociateRouteTable Operation</seealso>
        public virtual Task<DisassociateRouteTableResponse> DisassociateRouteTableAsync(DisassociateRouteTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateRouteTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateRouteTableResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateRouteTableResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateSubnetCidrBlock

        internal virtual DisassociateSubnetCidrBlockResponse DisassociateSubnetCidrBlock(DisassociateSubnetCidrBlockRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateSubnetCidrBlockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateSubnetCidrBlockResponseUnmarshaller.Instance;

            return Invoke<DisassociateSubnetCidrBlockResponse>(request, options);
        }



        /// <summary>
        /// Disassociates a CIDR block from a subnet. Currently, you can disassociate an IPv6
        /// CIDR block only. You must detach or delete all gateways and resources that are associated
        /// with the CIDR block before you can disassociate it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateSubnetCidrBlock service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateSubnetCidrBlock service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisassociateSubnetCidrBlock">REST API Reference for DisassociateSubnetCidrBlock Operation</seealso>
        public virtual Task<DisassociateSubnetCidrBlockResponse> DisassociateSubnetCidrBlockAsync(DisassociateSubnetCidrBlockRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateSubnetCidrBlockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateSubnetCidrBlockResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateSubnetCidrBlockResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateTransitGatewayRouteTable

        internal virtual DisassociateTransitGatewayRouteTableResponse DisassociateTransitGatewayRouteTable(DisassociateTransitGatewayRouteTableRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateTransitGatewayRouteTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateTransitGatewayRouteTableResponseUnmarshaller.Instance;

            return Invoke<DisassociateTransitGatewayRouteTableResponse>(request, options);
        }



        /// <summary>
        /// Disassociates a resource attachment from a transit gateway route table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateTransitGatewayRouteTable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateTransitGatewayRouteTable service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisassociateTransitGatewayRouteTable">REST API Reference for DisassociateTransitGatewayRouteTable Operation</seealso>
        public virtual Task<DisassociateTransitGatewayRouteTableResponse> DisassociateTransitGatewayRouteTableAsync(DisassociateTransitGatewayRouteTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateTransitGatewayRouteTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateTransitGatewayRouteTableResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateTransitGatewayRouteTableResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateVpcCidrBlock

        internal virtual DisassociateVpcCidrBlockResponse DisassociateVpcCidrBlock(DisassociateVpcCidrBlockRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateVpcCidrBlockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateVpcCidrBlockResponseUnmarshaller.Instance;

            return Invoke<DisassociateVpcCidrBlockResponse>(request, options);
        }



        /// <summary>
        /// Disassociates a CIDR block from a VPC. To disassociate the CIDR block, you must specify
        /// its association ID. You can get the association ID by using <a>DescribeVpcs</a>. You
        /// must detach or delete all gateways and resources that are associated with the CIDR
        /// block before you can disassociate it. 
        /// 
        ///  
        /// <para>
        /// You cannot disassociate the CIDR block with which you originally created the VPC (the
        /// primary CIDR block).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateVpcCidrBlock service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateVpcCidrBlock service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisassociateVpcCidrBlock">REST API Reference for DisassociateVpcCidrBlock Operation</seealso>
        public virtual Task<DisassociateVpcCidrBlockResponse> DisassociateVpcCidrBlockAsync(DisassociateVpcCidrBlockRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateVpcCidrBlockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateVpcCidrBlockResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateVpcCidrBlockResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  EnableEbsEncryptionByDefault

        internal virtual EnableEbsEncryptionByDefaultResponse EnableEbsEncryptionByDefault(EnableEbsEncryptionByDefaultRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableEbsEncryptionByDefaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableEbsEncryptionByDefaultResponseUnmarshaller.Instance;

            return Invoke<EnableEbsEncryptionByDefaultResponse>(request, options);
        }



        /// <summary>
        /// Enables default encryption for EBS volumes that are created in your account in the
        /// current region.
        /// 
        ///  
        /// <para>
        /// Once encryption is enabled with this action, EBS volumes that are created in your
        /// account will always be encrypted even if encryption is not specified at launch. This
        /// setting overrides the <i>encrypted</i> setting to <i>true</i> in all API calls that
        /// create EBS volumes in your account. A volume will be encrypted even if you specify
        /// <i>encryption</i> to be <i>false</i> in the API call that creates the volume.
        /// </para>
        ///  
        /// <para>
        /// If you do not specify a customer master key (CMK) in the API call that creates the
        /// EBS volume, then the volume is encrypted to your AWS account's default CMK.
        /// </para>
        ///  
        /// <para>
        /// You can specify a default CMK of your choice using <a>ModifyEbsDefaultKmsKeyId</a>.
        /// </para>
        ///  
        /// <para>
        /// Enabling default encryption for EBS volumes has no effect on existing unencrypted
        /// volumes in your account. Encrypting the data in these requires manual action. You
        /// can either create an encrypted snapshot of an unencrypted volume, or encrypt a copy
        /// of an unencrypted snapshot. Any volume restored from an encrypted snapshot is also
        /// encrypted. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSSnapshots.html">Amazon
        /// EBS Snapshots</a>.
        /// </para>
        ///  
        /// <para>
        /// After EBS encryption by default is enabled, you can no longer launch older-generation
        /// instance types that do not support encryption. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSEncryption.html#EBSEncryption_supported_instances">Supported
        /// Instance Types</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableEbsEncryptionByDefault service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableEbsEncryptionByDefault service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/EnableEbsEncryptionByDefault">REST API Reference for EnableEbsEncryptionByDefault Operation</seealso>
        public virtual Task<EnableEbsEncryptionByDefaultResponse> EnableEbsEncryptionByDefaultAsync(EnableEbsEncryptionByDefaultRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableEbsEncryptionByDefaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableEbsEncryptionByDefaultResponseUnmarshaller.Instance;

            return InvokeAsync<EnableEbsEncryptionByDefaultResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  EnableTransitGatewayRouteTablePropagation

        internal virtual EnableTransitGatewayRouteTablePropagationResponse EnableTransitGatewayRouteTablePropagation(EnableTransitGatewayRouteTablePropagationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableTransitGatewayRouteTablePropagationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableTransitGatewayRouteTablePropagationResponseUnmarshaller.Instance;

            return Invoke<EnableTransitGatewayRouteTablePropagationResponse>(request, options);
        }



        /// <summary>
        /// Enables the specified attachment to propagate routes to the specified propagation
        /// route table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableTransitGatewayRouteTablePropagation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableTransitGatewayRouteTablePropagation service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/EnableTransitGatewayRouteTablePropagation">REST API Reference for EnableTransitGatewayRouteTablePropagation Operation</seealso>
        public virtual Task<EnableTransitGatewayRouteTablePropagationResponse> EnableTransitGatewayRouteTablePropagationAsync(EnableTransitGatewayRouteTablePropagationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableTransitGatewayRouteTablePropagationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableTransitGatewayRouteTablePropagationResponseUnmarshaller.Instance;

            return InvokeAsync<EnableTransitGatewayRouteTablePropagationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  EnableVgwRoutePropagation

        internal virtual EnableVgwRoutePropagationResponse EnableVgwRoutePropagation(EnableVgwRoutePropagationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableVgwRoutePropagationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableVgwRoutePropagationResponseUnmarshaller.Instance;

            return Invoke<EnableVgwRoutePropagationResponse>(request, options);
        }



        /// <summary>
        /// Enables a virtual private gateway (VGW) to propagate routes to the specified route
        /// table of a VPC.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableVgwRoutePropagation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableVgwRoutePropagation service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/EnableVgwRoutePropagation">REST API Reference for EnableVgwRoutePropagation Operation</seealso>
        public virtual Task<EnableVgwRoutePropagationResponse> EnableVgwRoutePropagationAsync(EnableVgwRoutePropagationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableVgwRoutePropagationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableVgwRoutePropagationResponseUnmarshaller.Instance;

            return InvokeAsync<EnableVgwRoutePropagationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  EnableVolumeIO

        internal virtual EnableVolumeIOResponse EnableVolumeIO(EnableVolumeIORequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableVolumeIORequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableVolumeIOResponseUnmarshaller.Instance;

            return Invoke<EnableVolumeIOResponse>(request, options);
        }



        /// <summary>
        /// Enables I/O operations for a volume that had I/O operations disabled because the data
        /// on the volume was potentially inconsistent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableVolumeIO service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableVolumeIO service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/EnableVolumeIO">REST API Reference for EnableVolumeIO Operation</seealso>
        public virtual Task<EnableVolumeIOResponse> EnableVolumeIOAsync(EnableVolumeIORequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableVolumeIORequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableVolumeIOResponseUnmarshaller.Instance;

            return InvokeAsync<EnableVolumeIOResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  EnableVpcClassicLink

        internal virtual EnableVpcClassicLinkResponse EnableVpcClassicLink(EnableVpcClassicLinkRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableVpcClassicLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableVpcClassicLinkResponseUnmarshaller.Instance;

            return Invoke<EnableVpcClassicLinkResponse>(request, options);
        }



        /// <summary>
        /// Enables a VPC for ClassicLink. You can then link EC2-Classic instances to your ClassicLink-enabled
        /// VPC to allow communication over private IP addresses. You cannot enable your VPC for
        /// ClassicLink if any of your VPC route tables have existing routes for address ranges
        /// within the <code>10.0.0.0/8</code> IP address range, excluding local routes for VPCs
        /// in the <code>10.0.0.0/16</code> and <code>10.1.0.0/16</code> IP address ranges. For
        /// more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/vpc-classiclink.html">ClassicLink</a>
        /// in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableVpcClassicLink service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableVpcClassicLink service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/EnableVpcClassicLink">REST API Reference for EnableVpcClassicLink Operation</seealso>
        public virtual Task<EnableVpcClassicLinkResponse> EnableVpcClassicLinkAsync(EnableVpcClassicLinkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableVpcClassicLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableVpcClassicLinkResponseUnmarshaller.Instance;

            return InvokeAsync<EnableVpcClassicLinkResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  EnableVpcClassicLinkDnsSupport

        internal virtual EnableVpcClassicLinkDnsSupportResponse EnableVpcClassicLinkDnsSupport(EnableVpcClassicLinkDnsSupportRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableVpcClassicLinkDnsSupportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableVpcClassicLinkDnsSupportResponseUnmarshaller.Instance;

            return Invoke<EnableVpcClassicLinkDnsSupportResponse>(request, options);
        }



        /// <summary>
        /// Enables a VPC to support DNS hostname resolution for ClassicLink. If enabled, the
        /// DNS hostname of a linked EC2-Classic instance resolves to its private IP address when
        /// addressed from an instance in the VPC to which it's linked. Similarly, the DNS hostname
        /// of an instance in a VPC resolves to its private IP address when addressed from a linked
        /// EC2-Classic instance. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/vpc-classiclink.html">ClassicLink</a>
        /// in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableVpcClassicLinkDnsSupport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableVpcClassicLinkDnsSupport service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/EnableVpcClassicLinkDnsSupport">REST API Reference for EnableVpcClassicLinkDnsSupport Operation</seealso>
        public virtual Task<EnableVpcClassicLinkDnsSupportResponse> EnableVpcClassicLinkDnsSupportAsync(EnableVpcClassicLinkDnsSupportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableVpcClassicLinkDnsSupportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableVpcClassicLinkDnsSupportResponseUnmarshaller.Instance;

            return InvokeAsync<EnableVpcClassicLinkDnsSupportResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ExportClientVpnClientCertificateRevocationList

        internal virtual ExportClientVpnClientCertificateRevocationListResponse ExportClientVpnClientCertificateRevocationList(ExportClientVpnClientCertificateRevocationListRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportClientVpnClientCertificateRevocationListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportClientVpnClientCertificateRevocationListResponseUnmarshaller.Instance;

            return Invoke<ExportClientVpnClientCertificateRevocationListResponse>(request, options);
        }



        /// <summary>
        /// Downloads the client certificate revocation list for the specified Client VPN endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportClientVpnClientCertificateRevocationList service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExportClientVpnClientCertificateRevocationList service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ExportClientVpnClientCertificateRevocationList">REST API Reference for ExportClientVpnClientCertificateRevocationList Operation</seealso>
        public virtual Task<ExportClientVpnClientCertificateRevocationListResponse> ExportClientVpnClientCertificateRevocationListAsync(ExportClientVpnClientCertificateRevocationListRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportClientVpnClientCertificateRevocationListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportClientVpnClientCertificateRevocationListResponseUnmarshaller.Instance;

            return InvokeAsync<ExportClientVpnClientCertificateRevocationListResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ExportClientVpnClientConfiguration

        internal virtual ExportClientVpnClientConfigurationResponse ExportClientVpnClientConfiguration(ExportClientVpnClientConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportClientVpnClientConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportClientVpnClientConfigurationResponseUnmarshaller.Instance;

            return Invoke<ExportClientVpnClientConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Downloads the contents of the Client VPN endpoint configuration file for the specified
        /// Client VPN endpoint. The Client VPN endpoint configuration file includes the Client
        /// VPN endpoint and certificate information clients need to establish a connection with
        /// the Client VPN endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportClientVpnClientConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExportClientVpnClientConfiguration service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ExportClientVpnClientConfiguration">REST API Reference for ExportClientVpnClientConfiguration Operation</seealso>
        public virtual Task<ExportClientVpnClientConfigurationResponse> ExportClientVpnClientConfigurationAsync(ExportClientVpnClientConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportClientVpnClientConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportClientVpnClientConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<ExportClientVpnClientConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ExportTransitGatewayRoutes

        internal virtual ExportTransitGatewayRoutesResponse ExportTransitGatewayRoutes(ExportTransitGatewayRoutesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportTransitGatewayRoutesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportTransitGatewayRoutesResponseUnmarshaller.Instance;

            return Invoke<ExportTransitGatewayRoutesResponse>(request, options);
        }



        /// <summary>
        /// Exports routes from the specified transit gateway route table to the specified S3
        /// bucket. By default, all routes are exported. Alternatively, you can filter by CIDR
        /// range.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportTransitGatewayRoutes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExportTransitGatewayRoutes service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ExportTransitGatewayRoutes">REST API Reference for ExportTransitGatewayRoutes Operation</seealso>
        public virtual Task<ExportTransitGatewayRoutesResponse> ExportTransitGatewayRoutesAsync(ExportTransitGatewayRoutesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportTransitGatewayRoutesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportTransitGatewayRoutesResponseUnmarshaller.Instance;

            return InvokeAsync<ExportTransitGatewayRoutesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetConsoleOutput

        internal virtual GetConsoleOutputResponse GetConsoleOutput(GetConsoleOutputRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConsoleOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConsoleOutputResponseUnmarshaller.Instance;

            return Invoke<GetConsoleOutputResponse>(request, options);
        }



        /// <summary>
        /// Gets the console output for the specified instance. For Linux instances, the instance
        /// console output displays the exact console output that would normally be displayed
        /// on a physical monitor attached to a computer. For Windows instances, the instance
        /// console output includes the last three system event log errors.
        /// 
        ///  
        /// <para>
        /// By default, the console output returns buffered information that was posted shortly
        /// after an instance transition state (start, stop, reboot, or terminate). This information
        /// is available for at least one hour after the most recent post. Only the most recent
        /// 64 KB of console output is available.
        /// </para>
        ///  
        /// <para>
        /// You can optionally retrieve the latest serial console output at any time during the
        /// instance lifecycle. This option is supported on instance types that use the Nitro
        /// hypervisor.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-console.html#instance-console-console-output">Instance
        /// Console Output</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConsoleOutput service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetConsoleOutput service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetConsoleOutput">REST API Reference for GetConsoleOutput Operation</seealso>
        public virtual Task<GetConsoleOutputResponse> GetConsoleOutputAsync(GetConsoleOutputRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConsoleOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConsoleOutputResponseUnmarshaller.Instance;

            return InvokeAsync<GetConsoleOutputResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetConsoleScreenshot

        internal virtual GetConsoleScreenshotResponse GetConsoleScreenshot(GetConsoleScreenshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConsoleScreenshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConsoleScreenshotResponseUnmarshaller.Instance;

            return Invoke<GetConsoleScreenshotResponse>(request, options);
        }



        /// <summary>
        /// Retrieve a JPG-format screenshot of a running instance to help with troubleshooting.
        /// 
        ///  
        /// <para>
        /// The returned content is Base64-encoded.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConsoleScreenshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetConsoleScreenshot service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetConsoleScreenshot">REST API Reference for GetConsoleScreenshot Operation</seealso>
        public virtual Task<GetConsoleScreenshotResponse> GetConsoleScreenshotAsync(GetConsoleScreenshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConsoleScreenshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConsoleScreenshotResponseUnmarshaller.Instance;

            return InvokeAsync<GetConsoleScreenshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetEbsDefaultKmsKeyId

        internal virtual GetEbsDefaultKmsKeyIdResponse GetEbsDefaultKmsKeyId(GetEbsDefaultKmsKeyIdRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEbsDefaultKmsKeyIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEbsDefaultKmsKeyIdResponseUnmarshaller.Instance;

            return Invoke<GetEbsDefaultKmsKeyIdResponse>(request, options);
        }



        /// <summary>
        /// Describes the default customer master key (CMK) that your account uses to encrypt
        /// EBS volumes if you don’t specify a CMK in the API call. You can change this default
        /// using <a>ModifyEbsDefaultKmsKeyId</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEbsDefaultKmsKeyId service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEbsDefaultKmsKeyId service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetEbsDefaultKmsKeyId">REST API Reference for GetEbsDefaultKmsKeyId Operation</seealso>
        public virtual Task<GetEbsDefaultKmsKeyIdResponse> GetEbsDefaultKmsKeyIdAsync(GetEbsDefaultKmsKeyIdRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEbsDefaultKmsKeyIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEbsDefaultKmsKeyIdResponseUnmarshaller.Instance;

            return InvokeAsync<GetEbsDefaultKmsKeyIdResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetEbsEncryptionByDefault

        internal virtual GetEbsEncryptionByDefaultResponse GetEbsEncryptionByDefault(GetEbsEncryptionByDefaultRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEbsEncryptionByDefaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEbsEncryptionByDefaultResponseUnmarshaller.Instance;

            return Invoke<GetEbsEncryptionByDefaultResponse>(request, options);
        }



        /// <summary>
        /// Describes whether default EBS encryption is enabled for your account in the current
        /// region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEbsEncryptionByDefault service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEbsEncryptionByDefault service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetEbsEncryptionByDefault">REST API Reference for GetEbsEncryptionByDefault Operation</seealso>
        public virtual Task<GetEbsEncryptionByDefaultResponse> GetEbsEncryptionByDefaultAsync(GetEbsEncryptionByDefaultRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEbsEncryptionByDefaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEbsEncryptionByDefaultResponseUnmarshaller.Instance;

            return InvokeAsync<GetEbsEncryptionByDefaultResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetHostReservationPurchasePreview

        internal virtual GetHostReservationPurchasePreviewResponse GetHostReservationPurchasePreview(GetHostReservationPurchasePreviewRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetHostReservationPurchasePreviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetHostReservationPurchasePreviewResponseUnmarshaller.Instance;

            return Invoke<GetHostReservationPurchasePreviewResponse>(request, options);
        }



        /// <summary>
        /// Preview a reservation purchase with configurations that match those of your Dedicated
        /// Host. You must have active Dedicated Hosts in your account before you purchase a reservation.
        /// 
        ///  
        /// <para>
        /// This is a preview of the <a>PurchaseHostReservation</a> action and does not result
        /// in the offering being purchased.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHostReservationPurchasePreview service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetHostReservationPurchasePreview service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetHostReservationPurchasePreview">REST API Reference for GetHostReservationPurchasePreview Operation</seealso>
        public virtual Task<GetHostReservationPurchasePreviewResponse> GetHostReservationPurchasePreviewAsync(GetHostReservationPurchasePreviewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetHostReservationPurchasePreviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetHostReservationPurchasePreviewResponseUnmarshaller.Instance;

            return InvokeAsync<GetHostReservationPurchasePreviewResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetLaunchTemplateData

        internal virtual GetLaunchTemplateDataResponse GetLaunchTemplateData(GetLaunchTemplateDataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLaunchTemplateDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLaunchTemplateDataResponseUnmarshaller.Instance;

            return Invoke<GetLaunchTemplateDataResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the configuration data of the specified instance. You can use this data
        /// to create a launch template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLaunchTemplateData service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLaunchTemplateData service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetLaunchTemplateData">REST API Reference for GetLaunchTemplateData Operation</seealso>
        public virtual Task<GetLaunchTemplateDataResponse> GetLaunchTemplateDataAsync(GetLaunchTemplateDataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLaunchTemplateDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLaunchTemplateDataResponseUnmarshaller.Instance;

            return InvokeAsync<GetLaunchTemplateDataResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetPasswordData

        internal virtual GetPasswordDataResponse GetPasswordData(GetPasswordDataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPasswordDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPasswordDataResponseUnmarshaller.Instance;

            return Invoke<GetPasswordDataResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the encrypted administrator password for a running Windows instance.
        /// 
        ///  
        /// <para>
        /// The Windows password is generated at boot by the <code>EC2Config</code> service or
        /// <code>EC2Launch</code> scripts (Windows Server 2016 and later). This usually only
        /// happens the first time an instance is launched. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/WindowsGuide/UsingConfig_WinAMI.html">EC2Config</a>
        /// and <a href="https://docs.aws.amazon.com/AWSEC2/latest/WindowsGuide/ec2launch.html">EC2Launch</a>
        /// in the Amazon Elastic Compute Cloud User Guide.
        /// </para>
        ///  
        /// <para>
        /// For the <code>EC2Config</code> service, the password is not generated for rebundled
        /// AMIs unless <code>Ec2SetPassword</code> is enabled before bundling.
        /// </para>
        ///  
        /// <para>
        /// The password is encrypted using the key pair that you specified when you launched
        /// the instance. You must provide the corresponding key pair file.
        /// </para>
        ///  
        /// <para>
        /// When you launch an instance, password generation and encryption may take a few minutes.
        /// If you try to retrieve the password before it's available, the output returns an empty
        /// string. We recommend that you wait up to 15 minutes after launching an instance before
        /// trying to retrieve the generated password.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPasswordData service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPasswordData service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetPasswordData">REST API Reference for GetPasswordData Operation</seealso>
        public virtual Task<GetPasswordDataResponse> GetPasswordDataAsync(GetPasswordDataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPasswordDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPasswordDataResponseUnmarshaller.Instance;

            return InvokeAsync<GetPasswordDataResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetReservedInstancesExchangeQuote

        internal virtual GetReservedInstancesExchangeQuoteResponse GetReservedInstancesExchangeQuote(GetReservedInstancesExchangeQuoteRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetReservedInstancesExchangeQuoteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReservedInstancesExchangeQuoteResponseUnmarshaller.Instance;

            return Invoke<GetReservedInstancesExchangeQuoteResponse>(request, options);
        }



        /// <summary>
        /// Returns a quote and exchange information for exchanging one or more specified Convertible
        /// Reserved Instances for a new Convertible Reserved Instance. If the exchange cannot
        /// be performed, the reason is returned in the response. Use <a>AcceptReservedInstancesExchangeQuote</a>
        /// to perform the exchange.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReservedInstancesExchangeQuote service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetReservedInstancesExchangeQuote service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetReservedInstancesExchangeQuote">REST API Reference for GetReservedInstancesExchangeQuote Operation</seealso>
        public virtual Task<GetReservedInstancesExchangeQuoteResponse> GetReservedInstancesExchangeQuoteAsync(GetReservedInstancesExchangeQuoteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetReservedInstancesExchangeQuoteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReservedInstancesExchangeQuoteResponseUnmarshaller.Instance;

            return InvokeAsync<GetReservedInstancesExchangeQuoteResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetTransitGatewayAttachmentPropagations

        internal virtual GetTransitGatewayAttachmentPropagationsResponse GetTransitGatewayAttachmentPropagations(GetTransitGatewayAttachmentPropagationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTransitGatewayAttachmentPropagationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTransitGatewayAttachmentPropagationsResponseUnmarshaller.Instance;

            return Invoke<GetTransitGatewayAttachmentPropagationsResponse>(request, options);
        }



        /// <summary>
        /// Lists the route tables to which the specified resource attachment propagates routes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTransitGatewayAttachmentPropagations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTransitGatewayAttachmentPropagations service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetTransitGatewayAttachmentPropagations">REST API Reference for GetTransitGatewayAttachmentPropagations Operation</seealso>
        public virtual Task<GetTransitGatewayAttachmentPropagationsResponse> GetTransitGatewayAttachmentPropagationsAsync(GetTransitGatewayAttachmentPropagationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTransitGatewayAttachmentPropagationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTransitGatewayAttachmentPropagationsResponseUnmarshaller.Instance;

            return InvokeAsync<GetTransitGatewayAttachmentPropagationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetTransitGatewayRouteTableAssociations

        internal virtual GetTransitGatewayRouteTableAssociationsResponse GetTransitGatewayRouteTableAssociations(GetTransitGatewayRouteTableAssociationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTransitGatewayRouteTableAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTransitGatewayRouteTableAssociationsResponseUnmarshaller.Instance;

            return Invoke<GetTransitGatewayRouteTableAssociationsResponse>(request, options);
        }



        /// <summary>
        /// Gets information about the associations for the specified transit gateway route table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTransitGatewayRouteTableAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTransitGatewayRouteTableAssociations service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetTransitGatewayRouteTableAssociations">REST API Reference for GetTransitGatewayRouteTableAssociations Operation</seealso>
        public virtual Task<GetTransitGatewayRouteTableAssociationsResponse> GetTransitGatewayRouteTableAssociationsAsync(GetTransitGatewayRouteTableAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTransitGatewayRouteTableAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTransitGatewayRouteTableAssociationsResponseUnmarshaller.Instance;

            return InvokeAsync<GetTransitGatewayRouteTableAssociationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetTransitGatewayRouteTablePropagations

        internal virtual GetTransitGatewayRouteTablePropagationsResponse GetTransitGatewayRouteTablePropagations(GetTransitGatewayRouteTablePropagationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTransitGatewayRouteTablePropagationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTransitGatewayRouteTablePropagationsResponseUnmarshaller.Instance;

            return Invoke<GetTransitGatewayRouteTablePropagationsResponse>(request, options);
        }



        /// <summary>
        /// Gets information about the route table propagations for the specified transit gateway
        /// route table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTransitGatewayRouteTablePropagations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTransitGatewayRouteTablePropagations service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetTransitGatewayRouteTablePropagations">REST API Reference for GetTransitGatewayRouteTablePropagations Operation</seealso>
        public virtual Task<GetTransitGatewayRouteTablePropagationsResponse> GetTransitGatewayRouteTablePropagationsAsync(GetTransitGatewayRouteTablePropagationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTransitGatewayRouteTablePropagationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTransitGatewayRouteTablePropagationsResponseUnmarshaller.Instance;

            return InvokeAsync<GetTransitGatewayRouteTablePropagationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ImportClientVpnClientCertificateRevocationList

        internal virtual ImportClientVpnClientCertificateRevocationListResponse ImportClientVpnClientCertificateRevocationList(ImportClientVpnClientCertificateRevocationListRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportClientVpnClientCertificateRevocationListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportClientVpnClientCertificateRevocationListResponseUnmarshaller.Instance;

            return Invoke<ImportClientVpnClientCertificateRevocationListResponse>(request, options);
        }



        /// <summary>
        /// Uploads a client certificate revocation list to the specified Client VPN endpoint.
        /// Uploading a client certificate revocation list overwrites the existing client certificate
        /// revocation list.
        /// 
        ///  
        /// <para>
        /// Uploading a client certificate revocation list resets existing client connections.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportClientVpnClientCertificateRevocationList service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ImportClientVpnClientCertificateRevocationList service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ImportClientVpnClientCertificateRevocationList">REST API Reference for ImportClientVpnClientCertificateRevocationList Operation</seealso>
        public virtual Task<ImportClientVpnClientCertificateRevocationListResponse> ImportClientVpnClientCertificateRevocationListAsync(ImportClientVpnClientCertificateRevocationListRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportClientVpnClientCertificateRevocationListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportClientVpnClientCertificateRevocationListResponseUnmarshaller.Instance;

            return InvokeAsync<ImportClientVpnClientCertificateRevocationListResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ImportImage

        internal virtual ImportImageResponse ImportImage(ImportImageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportImageResponseUnmarshaller.Instance;

            return Invoke<ImportImageResponse>(request, options);
        }



        /// <summary>
        /// Import single or multi-volume disk images or EBS snapshots into an Amazon Machine
        /// Image (AMI). For more information, see <a href="https://docs.aws.amazon.com/vm-import/latest/userguide/vmimport-image-import.html">Importing
        /// a VM as an Image Using VM Import/Export</a> in the <i>VM Import/Export User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportImage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ImportImage service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ImportImage">REST API Reference for ImportImage Operation</seealso>
        public virtual Task<ImportImageResponse> ImportImageAsync(ImportImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportImageResponseUnmarshaller.Instance;

            return InvokeAsync<ImportImageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ImportInstance

        internal virtual ImportInstanceResponse ImportInstance(ImportInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportInstanceResponseUnmarshaller.Instance;

            return Invoke<ImportInstanceResponse>(request, options);
        }



        /// <summary>
        /// Creates an import instance task using metadata from the specified disk image. <code>ImportInstance</code>
        /// only supports single-volume VMs. To import multi-volume VMs, use <a>ImportImage</a>.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/CommandLineReference/ec2-cli-vmimport-export.html">Importing
        /// a Virtual Machine Using the Amazon EC2 CLI</a>.
        /// 
        ///  
        /// <para>
        /// For information about the import manifest referenced by this API action, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/manifest.html">VM
        /// Import Manifest</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ImportInstance service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ImportInstance">REST API Reference for ImportInstance Operation</seealso>
        public virtual Task<ImportInstanceResponse> ImportInstanceAsync(ImportInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<ImportInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ImportKeyPair

        internal virtual ImportKeyPairResponse ImportKeyPair(ImportKeyPairRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportKeyPairRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportKeyPairResponseUnmarshaller.Instance;

            return Invoke<ImportKeyPairResponse>(request, options);
        }



        /// <summary>
        /// Imports the public key from an RSA key pair that you created with a third-party tool.
        /// Compare this with <a>CreateKeyPair</a>, in which AWS creates the key pair and gives
        /// the keys to you (AWS keeps a copy of the public key). With ImportKeyPair, you create
        /// the key pair and give AWS just the public key. The private key is never transferred
        /// between you and AWS.
        /// 
        ///  
        /// <para>
        /// For more information about key pairs, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-key-pairs.html">Key
        /// Pairs</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportKeyPair service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ImportKeyPair service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ImportKeyPair">REST API Reference for ImportKeyPair Operation</seealso>
        public virtual Task<ImportKeyPairResponse> ImportKeyPairAsync(ImportKeyPairRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportKeyPairRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportKeyPairResponseUnmarshaller.Instance;

            return InvokeAsync<ImportKeyPairResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ImportSnapshot

        internal virtual ImportSnapshotResponse ImportSnapshot(ImportSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportSnapshotResponseUnmarshaller.Instance;

            return Invoke<ImportSnapshotResponse>(request, options);
        }



        /// <summary>
        /// Imports a disk into an EBS snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ImportSnapshot service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ImportSnapshot">REST API Reference for ImportSnapshot Operation</seealso>
        public virtual Task<ImportSnapshotResponse> ImportSnapshotAsync(ImportSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<ImportSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ImportVolume

        internal virtual ImportVolumeResponse ImportVolume(ImportVolumeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportVolumeResponseUnmarshaller.Instance;

            return Invoke<ImportVolumeResponse>(request, options);
        }



        /// <summary>
        /// Creates an import volume task using metadata from the specified disk image.For more
        /// information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/CommandLineReference/importing-your-volumes-into-amazon-ebs.html">Importing
        /// Disks to Amazon EBS</a>.
        /// 
        ///  
        /// <para>
        /// For information about the import manifest referenced by this API action, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/manifest.html">VM
        /// Import Manifest</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportVolume service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ImportVolume service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ImportVolume">REST API Reference for ImportVolume Operation</seealso>
        public virtual Task<ImportVolumeResponse> ImportVolumeAsync(ImportVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportVolumeResponseUnmarshaller.Instance;

            return InvokeAsync<ImportVolumeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyCapacityReservation

        internal virtual ModifyCapacityReservationResponse ModifyCapacityReservation(ModifyCapacityReservationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyCapacityReservationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyCapacityReservationResponseUnmarshaller.Instance;

            return Invoke<ModifyCapacityReservationResponse>(request, options);
        }



        /// <summary>
        /// Modifies a Capacity Reservation's capacity and the conditions under which it is to
        /// be released. You cannot change a Capacity Reservation's instance type, EBS optimization,
        /// instance store settings, platform, Availability Zone, or instance eligibility. If
        /// you need to modify any of these attributes, we recommend that you cancel the Capacity
        /// Reservation, and then create a new one with the required attributes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyCapacityReservation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyCapacityReservation service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyCapacityReservation">REST API Reference for ModifyCapacityReservation Operation</seealso>
        public virtual Task<ModifyCapacityReservationResponse> ModifyCapacityReservationAsync(ModifyCapacityReservationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyCapacityReservationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyCapacityReservationResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyCapacityReservationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyClientVpnEndpoint

        internal virtual ModifyClientVpnEndpointResponse ModifyClientVpnEndpoint(ModifyClientVpnEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyClientVpnEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyClientVpnEndpointResponseUnmarshaller.Instance;

            return Invoke<ModifyClientVpnEndpointResponse>(request, options);
        }



        /// <summary>
        /// Modifies the specified Client VPN endpoint. You can only modify an endpoint's server
        /// certificate information, client connection logging information, DNS server, and description.
        /// Modifying the DNS server resets existing client connections.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyClientVpnEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyClientVpnEndpoint service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyClientVpnEndpoint">REST API Reference for ModifyClientVpnEndpoint Operation</seealso>
        public virtual Task<ModifyClientVpnEndpointResponse> ModifyClientVpnEndpointAsync(ModifyClientVpnEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyClientVpnEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyClientVpnEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyClientVpnEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyEbsDefaultKmsKeyId

        internal virtual ModifyEbsDefaultKmsKeyIdResponse ModifyEbsDefaultKmsKeyId(ModifyEbsDefaultKmsKeyIdRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyEbsDefaultKmsKeyIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyEbsDefaultKmsKeyIdResponseUnmarshaller.Instance;

            return Invoke<ModifyEbsDefaultKmsKeyIdResponse>(request, options);
        }



        /// <summary>
        /// Changes the default customer master key (CMK) that your account uses to encrypt EBS
        /// volumes if you don't specify a CMK in the API call.
        /// 
        ///  
        /// <para>
        /// Your account has an AWS-managed default CMK that is used for encrypting an EBS volume
        /// when no CMK is specified in the API call that creates the volume. By calling this
        /// API, you can specify a customer-managed CMK to use in place of the AWS-managed default
        /// CMK.
        /// </para>
        ///  
        /// <para>
        /// Note: Deleting or disabling the custom CMK that you have specified to act as your
        /// default CMK will result in instance-launch failures.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyEbsDefaultKmsKeyId service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyEbsDefaultKmsKeyId service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyEbsDefaultKmsKeyId">REST API Reference for ModifyEbsDefaultKmsKeyId Operation</seealso>
        public virtual Task<ModifyEbsDefaultKmsKeyIdResponse> ModifyEbsDefaultKmsKeyIdAsync(ModifyEbsDefaultKmsKeyIdRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyEbsDefaultKmsKeyIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyEbsDefaultKmsKeyIdResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyEbsDefaultKmsKeyIdResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyFleet

        internal virtual ModifyFleetResponse ModifyFleet(ModifyFleetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyFleetResponseUnmarshaller.Instance;

            return Invoke<ModifyFleetResponse>(request, options);
        }



        /// <summary>
        /// Modifies the specified EC2 Fleet.
        /// 
        ///  
        /// <para>
        /// While the EC2 Fleet is being modified, it is in the <code>modifying</code> state.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyFleet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyFleet service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyFleet">REST API Reference for ModifyFleet Operation</seealso>
        public virtual Task<ModifyFleetResponse> ModifyFleetAsync(ModifyFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyFleetResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyFleetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyFpgaImageAttribute

        internal virtual ModifyFpgaImageAttributeResponse ModifyFpgaImageAttribute(ModifyFpgaImageAttributeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyFpgaImageAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyFpgaImageAttributeResponseUnmarshaller.Instance;

            return Invoke<ModifyFpgaImageAttributeResponse>(request, options);
        }



        /// <summary>
        /// Modifies the specified attribute of the specified Amazon FPGA Image (AFI).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyFpgaImageAttribute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyFpgaImageAttribute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyFpgaImageAttribute">REST API Reference for ModifyFpgaImageAttribute Operation</seealso>
        public virtual Task<ModifyFpgaImageAttributeResponse> ModifyFpgaImageAttributeAsync(ModifyFpgaImageAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyFpgaImageAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyFpgaImageAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyFpgaImageAttributeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyHosts

        internal virtual ModifyHostsResponse ModifyHosts(ModifyHostsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyHostsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyHostsResponseUnmarshaller.Instance;

            return Invoke<ModifyHostsResponse>(request, options);
        }



        /// <summary>
        /// Modify the auto-placement setting of a Dedicated Host. When auto-placement is enabled,
        /// any instances that you launch with a tenancy of <code>host</code> but without a specific
        /// host ID are placed onto any available Dedicated Host in your account that has auto-placement
        /// enabled. When auto-placement is disabled, you need to provide a host ID to have the
        /// instance launch onto a specific host. If no host ID is provided, the instance is launched
        /// onto a suitable host with auto-placement enabled.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyHosts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyHosts service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyHosts">REST API Reference for ModifyHosts Operation</seealso>
        public virtual Task<ModifyHostsResponse> ModifyHostsAsync(ModifyHostsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyHostsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyHostsResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyHostsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyIdentityIdFormat

        internal virtual ModifyIdentityIdFormatResponse ModifyIdentityIdFormat(ModifyIdentityIdFormatRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyIdentityIdFormatRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyIdentityIdFormatResponseUnmarshaller.Instance;

            return Invoke<ModifyIdentityIdFormatResponse>(request, options);
        }



        /// <summary>
        /// Modifies the ID format of a resource for a specified IAM user, IAM role, or the root
        /// user for an account; or all IAM users, IAM roles, and the root user for an account.
        /// You can specify that resources should receive longer IDs (17-character IDs) when they
        /// are created. 
        /// 
        ///  
        /// <para>
        /// This request can only be used to modify longer ID settings for resource types that
        /// are within the opt-in period. Resources currently in their opt-in period include:
        /// <code>bundle</code> | <code>conversion-task</code> | <code>customer-gateway</code>
        /// | <code>dhcp-options</code> | <code>elastic-ip-allocation</code> | <code>elastic-ip-association</code>
        /// | <code>export-task</code> | <code>flow-log</code> | <code>image</code> | <code>import-task</code>
        /// | <code>internet-gateway</code> | <code>network-acl</code> | <code>network-acl-association</code>
        /// | <code>network-interface</code> | <code>network-interface-attachment</code> | <code>prefix-list</code>
        /// | <code>route-table</code> | <code>route-table-association</code> | <code>security-group</code>
        /// | <code>subnet</code> | <code>subnet-cidr-block-association</code> | <code>vpc</code>
        /// | <code>vpc-cidr-block-association</code> | <code>vpc-endpoint</code> | <code>vpc-peering-connection</code>
        /// | <code>vpn-connection</code> | <code>vpn-gateway</code>. 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/resource-ids.html">Resource
        /// IDs</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// This setting applies to the principal specified in the request; it does not apply
        /// to the principal that makes the request. 
        /// </para>
        ///  
        /// <para>
        /// Resources created with longer IDs are visible to all IAM roles and users, regardless
        /// of these settings and provided that they have permission to use the relevant <code>Describe</code>
        /// command for the resource type.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyIdentityIdFormat service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyIdentityIdFormat service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyIdentityIdFormat">REST API Reference for ModifyIdentityIdFormat Operation</seealso>
        public virtual Task<ModifyIdentityIdFormatResponse> ModifyIdentityIdFormatAsync(ModifyIdentityIdFormatRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyIdentityIdFormatRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyIdentityIdFormatResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyIdentityIdFormatResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyIdFormat

        internal virtual ModifyIdFormatResponse ModifyIdFormat(ModifyIdFormatRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyIdFormatRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyIdFormatResponseUnmarshaller.Instance;

            return Invoke<ModifyIdFormatResponse>(request, options);
        }



        /// <summary>
        /// Modifies the ID format for the specified resource on a per-Region basis. You can specify
        /// that resources should receive longer IDs (17-character IDs) when they are created.
        /// 
        ///  
        /// <para>
        /// This request can only be used to modify longer ID settings for resource types that
        /// are within the opt-in period. Resources currently in their opt-in period include:
        /// <code>bundle</code> | <code>conversion-task</code> | <code>customer-gateway</code>
        /// | <code>dhcp-options</code> | <code>elastic-ip-allocation</code> | <code>elastic-ip-association</code>
        /// | <code>export-task</code> | <code>flow-log</code> | <code>image</code> | <code>import-task</code>
        /// | <code>internet-gateway</code> | <code>network-acl</code> | <code>network-acl-association</code>
        /// | <code>network-interface</code> | <code>network-interface-attachment</code> | <code>prefix-list</code>
        /// | <code>route-table</code> | <code>route-table-association</code> | <code>security-group</code>
        /// | <code>subnet</code> | <code>subnet-cidr-block-association</code> | <code>vpc</code>
        /// | <code>vpc-cidr-block-association</code> | <code>vpc-endpoint</code> | <code>vpc-peering-connection</code>
        /// | <code>vpn-connection</code> | <code>vpn-gateway</code>.
        /// </para>
        ///  
        /// <para>
        /// This setting applies to the IAM user who makes the request; it does not apply to the
        /// entire AWS account. By default, an IAM user defaults to the same settings as the root
        /// user. If you're using this action as the root user, then these settings apply to the
        /// entire account, unless an IAM user explicitly overrides these settings for themselves.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/resource-ids.html">Resource
        /// IDs</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Resources created with longer IDs are visible to all IAM roles and users, regardless
        /// of these settings and provided that they have permission to use the relevant <code>Describe</code>
        /// command for the resource type.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyIdFormat service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyIdFormat service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyIdFormat">REST API Reference for ModifyIdFormat Operation</seealso>
        public virtual Task<ModifyIdFormatResponse> ModifyIdFormatAsync(ModifyIdFormatRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyIdFormatRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyIdFormatResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyIdFormatResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyImageAttribute

        internal virtual ModifyImageAttributeResponse ModifyImageAttribute(ModifyImageAttributeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyImageAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyImageAttributeResponseUnmarshaller.Instance;

            return Invoke<ModifyImageAttributeResponse>(request, options);
        }



        /// <summary>
        /// Modifies the specified attribute of the specified AMI. You can specify only one attribute
        /// at a time. You can use the <code>Attribute</code> parameter to specify the attribute
        /// or one of the following parameters: <code>Description</code>, <code>LaunchPermission</code>,
        /// or <code>ProductCode</code>.
        /// 
        ///  
        /// <para>
        /// AWS Marketplace product codes cannot be modified. Images with an AWS Marketplace product
        /// code cannot be made public.
        /// </para>
        ///  
        /// <para>
        /// To enable the SriovNetSupport enhanced networking attribute of an image, enable SriovNetSupport
        /// on an instance and create an AMI from the instance.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyImageAttribute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyImageAttribute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyImageAttribute">REST API Reference for ModifyImageAttribute Operation</seealso>
        public virtual Task<ModifyImageAttributeResponse> ModifyImageAttributeAsync(ModifyImageAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyImageAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyImageAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyImageAttributeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyInstanceAttribute

        internal virtual ModifyInstanceAttributeResponse ModifyInstanceAttribute(ModifyInstanceAttributeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyInstanceAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyInstanceAttributeResponseUnmarshaller.Instance;

            return Invoke<ModifyInstanceAttributeResponse>(request, options);
        }



        /// <summary>
        /// Modifies the specified attribute of the specified instance. You can specify only one
        /// attribute at a time.
        /// 
        ///  
        /// <para>
        ///  <b>Note: </b>Using this action to change the security groups associated with an elastic
        /// network interface (ENI) attached to an instance in a VPC can result in an error if
        /// the instance has more than one ENI. To change the security groups associated with
        /// an ENI attached to an instance that has multiple ENIs, we recommend that you use the
        /// <a>ModifyNetworkInterfaceAttribute</a> action.
        /// </para>
        ///  
        /// <para>
        /// To modify some attributes, the instance must be stopped. For more information, see
        /// <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_ChangingAttributesWhileInstanceStopped.html">Modifying
        /// Attributes of a Stopped Instance</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyInstanceAttribute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyInstanceAttribute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyInstanceAttribute">REST API Reference for ModifyInstanceAttribute Operation</seealso>
        public virtual Task<ModifyInstanceAttributeResponse> ModifyInstanceAttributeAsync(ModifyInstanceAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyInstanceAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyInstanceAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyInstanceAttributeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyInstanceCapacityReservationAttributes

        internal virtual ModifyInstanceCapacityReservationAttributesResponse ModifyInstanceCapacityReservationAttributes(ModifyInstanceCapacityReservationAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyInstanceCapacityReservationAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyInstanceCapacityReservationAttributesResponseUnmarshaller.Instance;

            return Invoke<ModifyInstanceCapacityReservationAttributesResponse>(request, options);
        }



        /// <summary>
        /// Modifies the Capacity Reservation settings for a stopped instance. Use this action
        /// to configure an instance to target a specific Capacity Reservation, run in any <code>open</code>
        /// Capacity Reservation with matching attributes, or run On-Demand Instance capacity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyInstanceCapacityReservationAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyInstanceCapacityReservationAttributes service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyInstanceCapacityReservationAttributes">REST API Reference for ModifyInstanceCapacityReservationAttributes Operation</seealso>
        public virtual Task<ModifyInstanceCapacityReservationAttributesResponse> ModifyInstanceCapacityReservationAttributesAsync(ModifyInstanceCapacityReservationAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyInstanceCapacityReservationAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyInstanceCapacityReservationAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyInstanceCapacityReservationAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyInstanceCreditSpecification

        internal virtual ModifyInstanceCreditSpecificationResponse ModifyInstanceCreditSpecification(ModifyInstanceCreditSpecificationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyInstanceCreditSpecificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyInstanceCreditSpecificationResponseUnmarshaller.Instance;

            return Invoke<ModifyInstanceCreditSpecificationResponse>(request, options);
        }



        /// <summary>
        /// Modifies the credit option for CPU usage on a running or stopped T2 or T3 instance.
        /// The credit options are <code>standard</code> and <code>unlimited</code>.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/burstable-performance-instances.html">Burstable
        /// Performance Instances</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyInstanceCreditSpecification service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyInstanceCreditSpecification service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyInstanceCreditSpecification">REST API Reference for ModifyInstanceCreditSpecification Operation</seealso>
        public virtual Task<ModifyInstanceCreditSpecificationResponse> ModifyInstanceCreditSpecificationAsync(ModifyInstanceCreditSpecificationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyInstanceCreditSpecificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyInstanceCreditSpecificationResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyInstanceCreditSpecificationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyInstanceEventStartTime

        internal virtual ModifyInstanceEventStartTimeResponse ModifyInstanceEventStartTime(ModifyInstanceEventStartTimeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyInstanceEventStartTimeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyInstanceEventStartTimeResponseUnmarshaller.Instance;

            return Invoke<ModifyInstanceEventStartTimeResponse>(request, options);
        }



        /// <summary>
        /// Modifies the start time for a scheduled Amazon EC2 instance event.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyInstanceEventStartTime service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyInstanceEventStartTime service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyInstanceEventStartTime">REST API Reference for ModifyInstanceEventStartTime Operation</seealso>
        public virtual Task<ModifyInstanceEventStartTimeResponse> ModifyInstanceEventStartTimeAsync(ModifyInstanceEventStartTimeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyInstanceEventStartTimeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyInstanceEventStartTimeResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyInstanceEventStartTimeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyInstancePlacement

        internal virtual ModifyInstancePlacementResponse ModifyInstancePlacement(ModifyInstancePlacementRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyInstancePlacementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyInstancePlacementResponseUnmarshaller.Instance;

            return Invoke<ModifyInstancePlacementResponse>(request, options);
        }



        /// <summary>
        /// Modifies the placement attributes for a specified instance. You can do the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Modify the affinity between an instance and a <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/dedicated-hosts-overview.html">Dedicated
        /// Host</a>. When affinity is set to <code>host</code> and the instance is not associated
        /// with a specific Dedicated Host, the next time the instance is launched, it is automatically
        /// associated with the host on which it lands. If the instance is restarted or rebooted,
        /// this relationship persists.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Change the Dedicated Host with which an instance is associated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Change the instance tenancy of an instance from <code>host</code> to <code>dedicated</code>,
        /// or from <code>dedicated</code> to <code>host</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Move an instance to or from a <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/placement-groups.html">placement
        /// group</a>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// At least one attribute for affinity, host ID, tenancy, or placement group name must
        /// be specified in the request. Affinity and tenancy can be modified in the same request.
        /// </para>
        ///  
        /// <para>
        /// To modify the host ID, tenancy, placement group, or partition for an instance, the
        /// instance must be in the <code>stopped</code> state.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyInstancePlacement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyInstancePlacement service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyInstancePlacement">REST API Reference for ModifyInstancePlacement Operation</seealso>
        public virtual Task<ModifyInstancePlacementResponse> ModifyInstancePlacementAsync(ModifyInstancePlacementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyInstancePlacementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyInstancePlacementResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyInstancePlacementResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyLaunchTemplate

        internal virtual ModifyLaunchTemplateResponse ModifyLaunchTemplate(ModifyLaunchTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyLaunchTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyLaunchTemplateResponseUnmarshaller.Instance;

            return Invoke<ModifyLaunchTemplateResponse>(request, options);
        }



        /// <summary>
        /// Modifies a launch template. You can specify which version of the launch template to
        /// set as the default version. When launching an instance, the default version applies
        /// when a launch template version is not specified.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyLaunchTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyLaunchTemplate service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyLaunchTemplate">REST API Reference for ModifyLaunchTemplate Operation</seealso>
        public virtual Task<ModifyLaunchTemplateResponse> ModifyLaunchTemplateAsync(ModifyLaunchTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyLaunchTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyLaunchTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyLaunchTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyNetworkInterfaceAttribute

        internal virtual ModifyNetworkInterfaceAttributeResponse ModifyNetworkInterfaceAttribute(ModifyNetworkInterfaceAttributeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyNetworkInterfaceAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyNetworkInterfaceAttributeResponseUnmarshaller.Instance;

            return Invoke<ModifyNetworkInterfaceAttributeResponse>(request, options);
        }



        /// <summary>
        /// Modifies the specified network interface attribute. You can specify only one attribute
        /// at a time. You can use this action to attach and detach security groups from an existing
        /// EC2 instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyNetworkInterfaceAttribute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyNetworkInterfaceAttribute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyNetworkInterfaceAttribute">REST API Reference for ModifyNetworkInterfaceAttribute Operation</seealso>
        public virtual Task<ModifyNetworkInterfaceAttributeResponse> ModifyNetworkInterfaceAttributeAsync(ModifyNetworkInterfaceAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyNetworkInterfaceAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyNetworkInterfaceAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyNetworkInterfaceAttributeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyReservedInstances

        internal virtual ModifyReservedInstancesResponse ModifyReservedInstances(ModifyReservedInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyReservedInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyReservedInstancesResponseUnmarshaller.Instance;

            return Invoke<ModifyReservedInstancesResponse>(request, options);
        }



        /// <summary>
        /// Modifies the Availability Zone, instance count, instance type, or network platform
        /// (EC2-Classic or EC2-VPC) of your Reserved Instances. The Reserved Instances to be
        /// modified must be identical, except for Availability Zone, network platform, and instance
        /// type.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-modifying.html">Modifying
        /// Reserved Instances</a> in the Amazon Elastic Compute Cloud User Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyReservedInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyReservedInstances service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyReservedInstances">REST API Reference for ModifyReservedInstances Operation</seealso>
        public virtual Task<ModifyReservedInstancesResponse> ModifyReservedInstancesAsync(ModifyReservedInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyReservedInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyReservedInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyReservedInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifySnapshotAttribute

        internal virtual ModifySnapshotAttributeResponse ModifySnapshotAttribute(ModifySnapshotAttributeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifySnapshotAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifySnapshotAttributeResponseUnmarshaller.Instance;

            return Invoke<ModifySnapshotAttributeResponse>(request, options);
        }



        /// <summary>
        /// Adds or removes permission settings for the specified snapshot. You may add or remove
        /// specified AWS account IDs from a snapshot's list of create volume permissions, but
        /// you cannot do both in a single API call. If you need to both add and remove account
        /// IDs for a snapshot, you must use multiple API calls.
        /// 
        ///  
        /// <para>
        /// Encrypted snapshots and snapshots with AWS Marketplace product codes cannot be made
        /// public. Snapshots encrypted with your default CMK cannot be shared with other accounts.
        /// </para>
        ///  
        /// <para>
        /// For more information about modifying snapshot permissions, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-modifying-snapshot-permissions.html">Sharing
        /// Snapshots</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifySnapshotAttribute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifySnapshotAttribute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifySnapshotAttribute">REST API Reference for ModifySnapshotAttribute Operation</seealso>
        public virtual Task<ModifySnapshotAttributeResponse> ModifySnapshotAttributeAsync(ModifySnapshotAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifySnapshotAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifySnapshotAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<ModifySnapshotAttributeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifySpotFleetRequest

        internal virtual ModifySpotFleetRequestResponse ModifySpotFleetRequest(ModifySpotFleetRequestRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifySpotFleetRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifySpotFleetRequestResponseUnmarshaller.Instance;

            return Invoke<ModifySpotFleetRequestResponse>(request, options);
        }



        /// <summary>
        /// Modifies the specified Spot Fleet request.
        /// 
        ///  
        /// <para>
        /// You can only modify a Spot Fleet request of type <code>maintain</code>.
        /// </para>
        ///  
        /// <para>
        /// While the Spot Fleet request is being modified, it is in the <code>modifying</code>
        /// state.
        /// </para>
        ///  
        /// <para>
        /// To scale up your Spot Fleet, increase its target capacity. The Spot Fleet launches
        /// the additional Spot Instances according to the allocation strategy for the Spot Fleet
        /// request. If the allocation strategy is <code>lowestPrice</code>, the Spot Fleet launches
        /// instances using the Spot pool with the lowest price. If the allocation strategy is
        /// <code>diversified</code>, the Spot Fleet distributes the instances across the Spot
        /// pools.
        /// </para>
        ///  
        /// <para>
        /// To scale down your Spot Fleet, decrease its target capacity. First, the Spot Fleet
        /// cancels any open requests that exceed the new target capacity. You can request that
        /// the Spot Fleet terminate Spot Instances until the size of the fleet no longer exceeds
        /// the new target capacity. If the allocation strategy is <code>lowestPrice</code>, the
        /// Spot Fleet terminates the instances with the highest price per unit. If the allocation
        /// strategy is <code>diversified</code>, the Spot Fleet terminates instances across the
        /// Spot pools. Alternatively, you can request that the Spot Fleet keep the fleet at its
        /// current size, but not replace any Spot Instances that are interrupted or that you
        /// terminate manually.
        /// </para>
        ///  
        /// <para>
        /// If you are finished with your Spot Fleet for now, but will use it again later, you
        /// can set the target capacity to 0.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifySpotFleetRequest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifySpotFleetRequest service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifySpotFleetRequest">REST API Reference for ModifySpotFleetRequest Operation</seealso>
        public virtual Task<ModifySpotFleetRequestResponse> ModifySpotFleetRequestAsync(ModifySpotFleetRequestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifySpotFleetRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifySpotFleetRequestResponseUnmarshaller.Instance;

            return InvokeAsync<ModifySpotFleetRequestResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifySubnetAttribute

        internal virtual ModifySubnetAttributeResponse ModifySubnetAttribute(ModifySubnetAttributeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifySubnetAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifySubnetAttributeResponseUnmarshaller.Instance;

            return Invoke<ModifySubnetAttributeResponse>(request, options);
        }



        /// <summary>
        /// Modifies a subnet attribute. You can only modify one attribute at a time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifySubnetAttribute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifySubnetAttribute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifySubnetAttribute">REST API Reference for ModifySubnetAttribute Operation</seealso>
        public virtual Task<ModifySubnetAttributeResponse> ModifySubnetAttributeAsync(ModifySubnetAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifySubnetAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifySubnetAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<ModifySubnetAttributeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyTransitGatewayVpcAttachment

        internal virtual ModifyTransitGatewayVpcAttachmentResponse ModifyTransitGatewayVpcAttachment(ModifyTransitGatewayVpcAttachmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyTransitGatewayVpcAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyTransitGatewayVpcAttachmentResponseUnmarshaller.Instance;

            return Invoke<ModifyTransitGatewayVpcAttachmentResponse>(request, options);
        }



        /// <summary>
        /// Modifies the specified VPC attachment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyTransitGatewayVpcAttachment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyTransitGatewayVpcAttachment service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyTransitGatewayVpcAttachment">REST API Reference for ModifyTransitGatewayVpcAttachment Operation</seealso>
        public virtual Task<ModifyTransitGatewayVpcAttachmentResponse> ModifyTransitGatewayVpcAttachmentAsync(ModifyTransitGatewayVpcAttachmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyTransitGatewayVpcAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyTransitGatewayVpcAttachmentResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyTransitGatewayVpcAttachmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyVolume

        internal virtual ModifyVolumeResponse ModifyVolume(ModifyVolumeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyVolumeResponseUnmarshaller.Instance;

            return Invoke<ModifyVolumeResponse>(request, options);
        }



        /// <summary>
        /// You can modify several parameters of an existing EBS volume, including volume size,
        /// volume type, and IOPS capacity. If your EBS volume is attached to a current-generation
        /// EC2 instance type, you may be able to apply these changes without stopping the instance
        /// or detaching the volume from it. For more information about modifying an EBS volume
        /// running Linux, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-expand-volume.html">Modifying
        /// the Size, IOPS, or Type of an EBS Volume on Linux</a>. For more information about
        /// modifying an EBS volume running Windows, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/WindowsGuide/ebs-expand-volume.html">Modifying
        /// the Size, IOPS, or Type of an EBS Volume on Windows</a>. 
        /// 
        ///  
        /// <para>
        ///  When you complete a resize operation on your volume, you need to extend the volume's
        /// file-system size to take advantage of the new storage capacity. For information about
        /// extending a Linux file system, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-expand-volume.html#recognize-expanded-volume-linux">Extending
        /// a Linux File System</a>. For information about extending a Windows file system, see
        /// <a href="https://docs.aws.amazon.com/AWSEC2/latest/WindowsGuide/ebs-expand-volume.html#recognize-expanded-volume-windows">Extending
        /// a Windows File System</a>. 
        /// </para>
        ///  
        /// <para>
        ///  You can use CloudWatch Events to check the status of a modification to an EBS volume.
        /// For information about CloudWatch Events, see the <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/events/">Amazon
        /// CloudWatch Events User Guide</a>. You can also track the status of a modification
        /// using the <a>DescribeVolumesModifications</a> API. For information about tracking
        /// status changes using either method, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-expand-volume.html#monitoring_mods">Monitoring
        /// Volume Modifications</a>. 
        /// </para>
        ///  
        /// <para>
        /// With previous-generation instance types, resizing an EBS volume may require detaching
        /// and reattaching the volume or stopping and restarting the instance. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-expand-volume.html">Modifying
        /// the Size, IOPS, or Type of an EBS Volume on Linux</a> and <a href="https://docs.aws.amazon.com/AWSEC2/latest/WindowsGuide/ebs-expand-volume.html">Modifying
        /// the Size, IOPS, or Type of an EBS Volume on Windows</a>.
        /// </para>
        ///  
        /// <para>
        /// If you reach the maximum volume modification rate per volume limit, you will need
        /// to wait at least six hours before applying further modifications to the affected EBS
        /// volume.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyVolume service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyVolume service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVolume">REST API Reference for ModifyVolume Operation</seealso>
        public virtual Task<ModifyVolumeResponse> ModifyVolumeAsync(ModifyVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyVolumeResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyVolumeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyVolumeAttribute

        internal virtual ModifyVolumeAttributeResponse ModifyVolumeAttribute(ModifyVolumeAttributeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyVolumeAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyVolumeAttributeResponseUnmarshaller.Instance;

            return Invoke<ModifyVolumeAttributeResponse>(request, options);
        }



        /// <summary>
        /// Modifies a volume attribute.
        /// 
        ///  
        /// <para>
        /// By default, all I/O operations for the volume are suspended when the data on the volume
        /// is determined to be potentially inconsistent, to prevent undetectable, latent data
        /// corruption. The I/O access to the volume can be resumed by first enabling I/O access
        /// and then checking the data consistency on your volume.
        /// </para>
        ///  
        /// <para>
        /// You can change the default behavior to resume I/O operations. We recommend that you
        /// change this only for boot volumes or for volumes that are stateless or disposable.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyVolumeAttribute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyVolumeAttribute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVolumeAttribute">REST API Reference for ModifyVolumeAttribute Operation</seealso>
        public virtual Task<ModifyVolumeAttributeResponse> ModifyVolumeAttributeAsync(ModifyVolumeAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyVolumeAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyVolumeAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyVolumeAttributeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyVpcAttribute

        internal virtual ModifyVpcAttributeResponse ModifyVpcAttribute(ModifyVpcAttributeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyVpcAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyVpcAttributeResponseUnmarshaller.Instance;

            return Invoke<ModifyVpcAttributeResponse>(request, options);
        }



        /// <summary>
        /// Modifies the specified attribute of the specified VPC.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyVpcAttribute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyVpcAttribute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVpcAttribute">REST API Reference for ModifyVpcAttribute Operation</seealso>
        public virtual Task<ModifyVpcAttributeResponse> ModifyVpcAttributeAsync(ModifyVpcAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyVpcAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyVpcAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyVpcAttributeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyVpcEndpoint

        internal virtual ModifyVpcEndpointResponse ModifyVpcEndpoint(ModifyVpcEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyVpcEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyVpcEndpointResponseUnmarshaller.Instance;

            return Invoke<ModifyVpcEndpointResponse>(request, options);
        }



        /// <summary>
        /// Modifies attributes of a specified VPC endpoint. The attributes that you can modify
        /// depend on the type of VPC endpoint (interface or gateway). For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/vpc-endpoints.html">VPC
        /// Endpoints</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyVpcEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyVpcEndpoint service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVpcEndpoint">REST API Reference for ModifyVpcEndpoint Operation</seealso>
        public virtual Task<ModifyVpcEndpointResponse> ModifyVpcEndpointAsync(ModifyVpcEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyVpcEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyVpcEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyVpcEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyVpcEndpointConnectionNotification

        internal virtual ModifyVpcEndpointConnectionNotificationResponse ModifyVpcEndpointConnectionNotification(ModifyVpcEndpointConnectionNotificationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyVpcEndpointConnectionNotificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyVpcEndpointConnectionNotificationResponseUnmarshaller.Instance;

            return Invoke<ModifyVpcEndpointConnectionNotificationResponse>(request, options);
        }



        /// <summary>
        /// Modifies a connection notification for VPC endpoint or VPC endpoint service. You can
        /// change the SNS topic for the notification, or the events for which to be notified.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyVpcEndpointConnectionNotification service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyVpcEndpointConnectionNotification service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVpcEndpointConnectionNotification">REST API Reference for ModifyVpcEndpointConnectionNotification Operation</seealso>
        public virtual Task<ModifyVpcEndpointConnectionNotificationResponse> ModifyVpcEndpointConnectionNotificationAsync(ModifyVpcEndpointConnectionNotificationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyVpcEndpointConnectionNotificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyVpcEndpointConnectionNotificationResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyVpcEndpointConnectionNotificationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyVpcEndpointServiceConfiguration

        internal virtual ModifyVpcEndpointServiceConfigurationResponse ModifyVpcEndpointServiceConfiguration(ModifyVpcEndpointServiceConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyVpcEndpointServiceConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyVpcEndpointServiceConfigurationResponseUnmarshaller.Instance;

            return Invoke<ModifyVpcEndpointServiceConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Modifies the attributes of your VPC endpoint service configuration. You can change
        /// the Network Load Balancers for your service, and you can specify whether acceptance
        /// is required for requests to connect to your endpoint service through an interface
        /// VPC endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyVpcEndpointServiceConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyVpcEndpointServiceConfiguration service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVpcEndpointServiceConfiguration">REST API Reference for ModifyVpcEndpointServiceConfiguration Operation</seealso>
        public virtual Task<ModifyVpcEndpointServiceConfigurationResponse> ModifyVpcEndpointServiceConfigurationAsync(ModifyVpcEndpointServiceConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyVpcEndpointServiceConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyVpcEndpointServiceConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyVpcEndpointServiceConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyVpcEndpointServicePermissions

        internal virtual ModifyVpcEndpointServicePermissionsResponse ModifyVpcEndpointServicePermissions(ModifyVpcEndpointServicePermissionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyVpcEndpointServicePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyVpcEndpointServicePermissionsResponseUnmarshaller.Instance;

            return Invoke<ModifyVpcEndpointServicePermissionsResponse>(request, options);
        }



        /// <summary>
        /// Modifies the permissions for your <a href="https://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/endpoint-service.html">VPC
        /// endpoint service</a>. You can add or remove permissions for service consumers (IAM
        /// users, IAM roles, and AWS accounts) to connect to your endpoint service.
        /// 
        ///  
        /// <para>
        /// If you grant permissions to all principals, the service is public. Any users who know
        /// the name of a public service can send a request to attach an endpoint. If the service
        /// does not require manual approval, attachments are automatically approved.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyVpcEndpointServicePermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyVpcEndpointServicePermissions service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVpcEndpointServicePermissions">REST API Reference for ModifyVpcEndpointServicePermissions Operation</seealso>
        public virtual Task<ModifyVpcEndpointServicePermissionsResponse> ModifyVpcEndpointServicePermissionsAsync(ModifyVpcEndpointServicePermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyVpcEndpointServicePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyVpcEndpointServicePermissionsResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyVpcEndpointServicePermissionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyVpcPeeringConnectionOptions

        internal virtual ModifyVpcPeeringConnectionOptionsResponse ModifyVpcPeeringConnectionOptions(ModifyVpcPeeringConnectionOptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyVpcPeeringConnectionOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyVpcPeeringConnectionOptionsResponseUnmarshaller.Instance;

            return Invoke<ModifyVpcPeeringConnectionOptionsResponse>(request, options);
        }



        /// <summary>
        /// Modifies the VPC peering connection options on one side of a VPC peering connection.
        /// You can do the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Enable/disable communication over the peering connection between an EC2-Classic instance
        /// that's linked to your VPC (using ClassicLink) and instances in the peer VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Enable/disable communication over the peering connection between instances in your
        /// VPC and an EC2-Classic instance that's linked to the peer VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Enable/disable the ability to resolve public DNS hostnames to private IP addresses
        /// when queried from instances in the peer VPC.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the peered VPCs are in the same AWS account, you can enable DNS resolution for
        /// queries from the local VPC. This ensures that queries from the local VPC resolve to
        /// private IP addresses in the peer VPC. This option is not available if the peered VPCs
        /// are in different AWS accounts or different Regions. For peered VPCs in different AWS
        /// accounts, each AWS account owner must initiate a separate request to modify the peering
        /// connection options. For inter-region peering connections, you must use the Region
        /// for the requester VPC to modify the requester VPC peering options and the Region for
        /// the accepter VPC to modify the accepter VPC peering options. To verify which VPCs
        /// are the accepter and the requester for a VPC peering connection, use the <a>DescribeVpcPeeringConnections</a>
        /// command.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyVpcPeeringConnectionOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyVpcPeeringConnectionOptions service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVpcPeeringConnectionOptions">REST API Reference for ModifyVpcPeeringConnectionOptions Operation</seealso>
        public virtual Task<ModifyVpcPeeringConnectionOptionsResponse> ModifyVpcPeeringConnectionOptionsAsync(ModifyVpcPeeringConnectionOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyVpcPeeringConnectionOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyVpcPeeringConnectionOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyVpcPeeringConnectionOptionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyVpcTenancy

        internal virtual ModifyVpcTenancyResponse ModifyVpcTenancy(ModifyVpcTenancyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyVpcTenancyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyVpcTenancyResponseUnmarshaller.Instance;

            return Invoke<ModifyVpcTenancyResponse>(request, options);
        }



        /// <summary>
        /// Modifies the instance tenancy attribute of the specified VPC. You can change the instance
        /// tenancy attribute of a VPC to <code>default</code> only. You cannot change the instance
        /// tenancy attribute to <code>dedicated</code>.
        /// 
        ///  
        /// <para>
        /// After you modify the tenancy of the VPC, any new instances that you launch into the
        /// VPC have a tenancy of <code>default</code>, unless you specify otherwise during launch.
        /// The tenancy of any existing instances in the VPC is not affected.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/dedicated-instance.html">Dedicated
        /// Instances</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyVpcTenancy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyVpcTenancy service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVpcTenancy">REST API Reference for ModifyVpcTenancy Operation</seealso>
        public virtual Task<ModifyVpcTenancyResponse> ModifyVpcTenancyAsync(ModifyVpcTenancyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyVpcTenancyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyVpcTenancyResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyVpcTenancyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyVpnConnection

        internal virtual ModifyVpnConnectionResponse ModifyVpnConnection(ModifyVpnConnectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyVpnConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyVpnConnectionResponseUnmarshaller.Instance;

            return Invoke<ModifyVpnConnectionResponse>(request, options);
        }



        /// <summary>
        /// Modifies the target gateway of a AWS Site-to-Site VPN connection. The following migration
        /// options are available:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// An existing virtual private gateway to a new virtual private gateway
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An existing virtual private gateway to a transit gateway
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An existing transit gateway to a new transit gateway
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An existing transit gateway to a virtual private gateway
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Before you perform the migration to the new gateway, you must configure the new gateway.
        /// Use <a>CreateVpnGateway</a> to create a virtual private gateway, or <a>CreateTransitGateway</a>
        /// to create a transit gateway.
        /// </para>
        ///  
        /// <para>
        /// This step is required when you migrate from a virtual private gateway with static
        /// routes to a transit gateway. 
        /// </para>
        ///  
        /// <para>
        /// You must delete the static routes before you migrate to the new gateway.
        /// </para>
        ///  
        /// <para>
        /// Keep a copy of the static route before you delete it. You will need to add back these
        /// routes to the transit gateway after the VPN connection migration is complete.
        /// </para>
        ///  
        /// <para>
        /// After you migrate to the new gateway, you might need to modify your VPC route table.
        /// Use <a>CreateRoute</a> and <a>DeleteRoute</a> to make the changes described in <a
        /// href="https://docs.aws.amazon.com/vpn/latest/s2svpn/modify-vpn-target.html#step-update-routing">VPN
        /// Gateway Target Modification Required VPC Route Table Updates</a> in the <i>AWS Site-to-Site
        /// VPN User Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  When the new gateway is a transit gateway, modify the transit gateway route table
        /// to allow traffic between the VPC and the AWS Site-to-Site VPN connection. Use <a>CreateTransitGatewayRoute</a>
        /// to add the routes.
        /// </para>
        ///  
        /// <para>
        ///  If you deleted VPN static routes, you must add the static routes to the transit gateway
        /// route table.
        /// </para>
        ///  
        /// <para>
        /// After you perform this operation, the AWS VPN endpoint's IP addresses on the AWS side
        /// and the tunnel options remain intact. Your s2slong; connection will be temporarily
        /// unavailable for approximately 10 minutes while we provision the new endpoints 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyVpnConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyVpnConnection service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVpnConnection">REST API Reference for ModifyVpnConnection Operation</seealso>
        public virtual Task<ModifyVpnConnectionResponse> ModifyVpnConnectionAsync(ModifyVpnConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyVpnConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyVpnConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyVpnConnectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  MonitorInstances

        internal virtual MonitorInstancesResponse MonitorInstances(MonitorInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = MonitorInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = MonitorInstancesResponseUnmarshaller.Instance;

            return Invoke<MonitorInstancesResponse>(request, options);
        }



        /// <summary>
        /// Enables detailed monitoring for a running instance. Otherwise, basic monitoring is
        /// enabled. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-cloudwatch.html">Monitoring
        /// Your Instances and Volumes</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// 
        ///  
        /// <para>
        /// To disable detailed monitoring, see .
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the MonitorInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the MonitorInstances service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/MonitorInstances">REST API Reference for MonitorInstances Operation</seealso>
        public virtual Task<MonitorInstancesResponse> MonitorInstancesAsync(MonitorInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = MonitorInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = MonitorInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<MonitorInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  MoveAddressToVpc

        internal virtual MoveAddressToVpcResponse MoveAddressToVpc(MoveAddressToVpcRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = MoveAddressToVpcRequestMarshaller.Instance;
            options.ResponseUnmarshaller = MoveAddressToVpcResponseUnmarshaller.Instance;

            return Invoke<MoveAddressToVpcResponse>(request, options);
        }



        /// <summary>
        /// Moves an Elastic IP address from the EC2-Classic platform to the EC2-VPC platform.
        /// The Elastic IP address must be allocated to your account for more than 24 hours, and
        /// it must not be associated with an instance. After the Elastic IP address is moved,
        /// it is no longer available for use in the EC2-Classic platform, unless you move it
        /// back using the <a>RestoreAddressToClassic</a> request. You cannot move an Elastic
        /// IP address that was originally allocated for use in the EC2-VPC platform to the EC2-Classic
        /// platform.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the MoveAddressToVpc service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the MoveAddressToVpc service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/MoveAddressToVpc">REST API Reference for MoveAddressToVpc Operation</seealso>
        public virtual Task<MoveAddressToVpcResponse> MoveAddressToVpcAsync(MoveAddressToVpcRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = MoveAddressToVpcRequestMarshaller.Instance;
            options.ResponseUnmarshaller = MoveAddressToVpcResponseUnmarshaller.Instance;

            return InvokeAsync<MoveAddressToVpcResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ProvisionByoipCidr

        internal virtual ProvisionByoipCidrResponse ProvisionByoipCidr(ProvisionByoipCidrRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ProvisionByoipCidrRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ProvisionByoipCidrResponseUnmarshaller.Instance;

            return Invoke<ProvisionByoipCidrResponse>(request, options);
        }



        /// <summary>
        /// Provisions an address range for use with your AWS resources through bring your own
        /// IP addresses (BYOIP) and creates a corresponding address pool. After the address range
        /// is provisioned, it is ready to be advertised using <a>AdvertiseByoipCidr</a>.
        /// 
        ///  
        /// <para>
        /// AWS verifies that you own the address range and are authorized to advertise it. You
        /// must ensure that the address range is registered to you and that you created an RPKI
        /// ROA to authorize Amazon ASNs 16509 and 14618 to advertise the address range. For more
        /// information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-byoip.html">Bring
        /// Your Own IP Addresses (BYOIP)</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Provisioning an address range is an asynchronous operation, so the call returns immediately,
        /// but the address range is not ready to use until its status changes from <code>pending-provision</code>
        /// to <code>provisioned</code>. To monitor the status of an address range, use <a>DescribeByoipCidrs</a>.
        /// To allocate an Elastic IP address from your address pool, use <a>AllocateAddress</a>
        /// with either the specific address from the address pool or the ID of the address pool.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ProvisionByoipCidr service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ProvisionByoipCidr service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ProvisionByoipCidr">REST API Reference for ProvisionByoipCidr Operation</seealso>
        public virtual Task<ProvisionByoipCidrResponse> ProvisionByoipCidrAsync(ProvisionByoipCidrRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ProvisionByoipCidrRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ProvisionByoipCidrResponseUnmarshaller.Instance;

            return InvokeAsync<ProvisionByoipCidrResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PurchaseHostReservation

        internal virtual PurchaseHostReservationResponse PurchaseHostReservation(PurchaseHostReservationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PurchaseHostReservationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PurchaseHostReservationResponseUnmarshaller.Instance;

            return Invoke<PurchaseHostReservationResponse>(request, options);
        }



        /// <summary>
        /// Purchase a reservation with configurations that match those of your Dedicated Host.
        /// You must have active Dedicated Hosts in your account before you purchase a reservation.
        /// This action results in the specified reservation being purchased and charged to your
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PurchaseHostReservation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PurchaseHostReservation service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/PurchaseHostReservation">REST API Reference for PurchaseHostReservation Operation</seealso>
        public virtual Task<PurchaseHostReservationResponse> PurchaseHostReservationAsync(PurchaseHostReservationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PurchaseHostReservationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PurchaseHostReservationResponseUnmarshaller.Instance;

            return InvokeAsync<PurchaseHostReservationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PurchaseReservedInstancesOffering

        internal virtual PurchaseReservedInstancesOfferingResponse PurchaseReservedInstancesOffering(PurchaseReservedInstancesOfferingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PurchaseReservedInstancesOfferingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PurchaseReservedInstancesOfferingResponseUnmarshaller.Instance;

            return Invoke<PurchaseReservedInstancesOfferingResponse>(request, options);
        }



        /// <summary>
        /// Purchases a Reserved Instance for use with your account. With Reserved Instances,
        /// you pay a lower hourly rate compared to On-Demand instance pricing.
        /// 
        ///  
        /// <para>
        /// Use <a>DescribeReservedInstancesOfferings</a> to get a list of Reserved Instance offerings
        /// that match your specifications. After you've purchased a Reserved Instance, you can
        /// check for your new Reserved Instance with <a>DescribeReservedInstances</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/concepts-on-demand-reserved-instances.html">Reserved
        /// Instances</a> and <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-market-general.html">Reserved
        /// Instance Marketplace</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PurchaseReservedInstancesOffering service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PurchaseReservedInstancesOffering service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/PurchaseReservedInstancesOffering">REST API Reference for PurchaseReservedInstancesOffering Operation</seealso>
        public virtual Task<PurchaseReservedInstancesOfferingResponse> PurchaseReservedInstancesOfferingAsync(PurchaseReservedInstancesOfferingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PurchaseReservedInstancesOfferingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PurchaseReservedInstancesOfferingResponseUnmarshaller.Instance;

            return InvokeAsync<PurchaseReservedInstancesOfferingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PurchaseScheduledInstances

        internal virtual PurchaseScheduledInstancesResponse PurchaseScheduledInstances(PurchaseScheduledInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PurchaseScheduledInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PurchaseScheduledInstancesResponseUnmarshaller.Instance;

            return Invoke<PurchaseScheduledInstancesResponse>(request, options);
        }



        /// <summary>
        /// Purchases the Scheduled Instances with the specified schedule.
        /// 
        ///  
        /// <para>
        /// Scheduled Instances enable you to purchase Amazon EC2 compute capacity by the hour
        /// for a one-year term. Before you can purchase a Scheduled Instance, you must call <a>DescribeScheduledInstanceAvailability</a>
        /// to check for available schedules and obtain a purchase token. After you purchase a
        /// Scheduled Instance, you must call <a>RunScheduledInstances</a> during each scheduled
        /// time period.
        /// </para>
        ///  
        /// <para>
        /// After you purchase a Scheduled Instance, you can't cancel, modify, or resell your
        /// purchase.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PurchaseScheduledInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PurchaseScheduledInstances service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/PurchaseScheduledInstances">REST API Reference for PurchaseScheduledInstances Operation</seealso>
        public virtual Task<PurchaseScheduledInstancesResponse> PurchaseScheduledInstancesAsync(PurchaseScheduledInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PurchaseScheduledInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PurchaseScheduledInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<PurchaseScheduledInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RebootInstances

        internal virtual RebootInstancesResponse RebootInstances(RebootInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RebootInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebootInstancesResponseUnmarshaller.Instance;

            return Invoke<RebootInstancesResponse>(request, options);
        }



        /// <summary>
        /// Requests a reboot of the specified instances. This operation is asynchronous; it only
        /// queues a request to reboot the specified instances. The operation succeeds if the
        /// instances are valid and belong to you. Requests to reboot terminated instances are
        /// ignored.
        /// 
        ///  
        /// <para>
        /// If an instance does not cleanly shut down within four minutes, Amazon EC2 performs
        /// a hard reboot.
        /// </para>
        ///  
        /// <para>
        /// For more information about troubleshooting, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-console.html">Getting
        /// Console Output and Rebooting Instances</a> in the <i>Amazon Elastic Compute Cloud
        /// User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebootInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RebootInstances service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RebootInstances">REST API Reference for RebootInstances Operation</seealso>
        public virtual Task<RebootInstancesResponse> RebootInstancesAsync(RebootInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RebootInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebootInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<RebootInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RegisterImage

        internal virtual RegisterImageResponse RegisterImage(RegisterImageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterImageResponseUnmarshaller.Instance;

            return Invoke<RegisterImageResponse>(request, options);
        }



        /// <summary>
        /// Registers an AMI. When you're creating an AMI, this is the final step you must complete
        /// before you can launch an instance from the AMI. For more information about creating
        /// AMIs, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/creating-an-ami.html">Creating
        /// Your Own AMIs</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// 
        ///  <note> 
        /// <para>
        /// For Amazon EBS-backed instances, <a>CreateImage</a> creates and registers the AMI
        /// in a single request, so you don't have to register the AMI yourself.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can also use <code>RegisterImage</code> to create an Amazon EBS-backed Linux AMI
        /// from a snapshot of a root device volume. You specify the snapshot using the block
        /// device mapping. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-launch-snapshot.html">Launching
        /// a Linux Instance from a Backup</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can't register an image where a secondary (non-root) snapshot has AWS Marketplace
        /// product codes.
        /// </para>
        ///  
        /// <para>
        /// Some Linux distributions, such as Red Hat Enterprise Linux (RHEL) and SUSE Linux Enterprise
        /// Server (SLES), use the EC2 billing product code associated with an AMI to verify the
        /// subscription status for package updates. Creating an AMI from an EBS snapshot does
        /// not maintain this billing code, and instances launched from such an AMI are not able
        /// to connect to package update infrastructure. If you purchase a Reserved Instance offering
        /// for one of these Linux distributions and launch instances using an AMI that does not
        /// contain the required billing code, your Reserved Instance is not applied to these
        /// instances.
        /// </para>
        ///  
        /// <para>
        /// To create an AMI for operating systems that require a billing code, see <a>CreateImage</a>.
        /// </para>
        ///  
        /// <para>
        /// If needed, you can deregister an AMI at any time. Any modifications you make to an
        /// AMI backed by an instance store volume invalidates its registration. If you make changes
        /// to an image, deregister the previous image and register the new image.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterImage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterImage service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RegisterImage">REST API Reference for RegisterImage Operation</seealso>
        public virtual Task<RegisterImageResponse> RegisterImageAsync(RegisterImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterImageResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterImageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RejectTransitGatewayVpcAttachment

        internal virtual RejectTransitGatewayVpcAttachmentResponse RejectTransitGatewayVpcAttachment(RejectTransitGatewayVpcAttachmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RejectTransitGatewayVpcAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectTransitGatewayVpcAttachmentResponseUnmarshaller.Instance;

            return Invoke<RejectTransitGatewayVpcAttachmentResponse>(request, options);
        }



        /// <summary>
        /// Rejects a request to attach a VPC to a transit gateway.
        /// 
        ///  
        /// <para>
        /// The VPC attachment must be in the <code>pendingAcceptance</code> state. Use <a>DescribeTransitGatewayVpcAttachments</a>
        /// to view your pending VPC attachment requests. Use <a>AcceptTransitGatewayVpcAttachment</a>
        /// to accept a VPC attachment request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectTransitGatewayVpcAttachment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RejectTransitGatewayVpcAttachment service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RejectTransitGatewayVpcAttachment">REST API Reference for RejectTransitGatewayVpcAttachment Operation</seealso>
        public virtual Task<RejectTransitGatewayVpcAttachmentResponse> RejectTransitGatewayVpcAttachmentAsync(RejectTransitGatewayVpcAttachmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RejectTransitGatewayVpcAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectTransitGatewayVpcAttachmentResponseUnmarshaller.Instance;

            return InvokeAsync<RejectTransitGatewayVpcAttachmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RejectVpcEndpointConnections

        internal virtual RejectVpcEndpointConnectionsResponse RejectVpcEndpointConnections(RejectVpcEndpointConnectionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RejectVpcEndpointConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectVpcEndpointConnectionsResponseUnmarshaller.Instance;

            return Invoke<RejectVpcEndpointConnectionsResponse>(request, options);
        }



        /// <summary>
        /// Rejects one or more VPC endpoint connection requests to your VPC endpoint service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectVpcEndpointConnections service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RejectVpcEndpointConnections service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RejectVpcEndpointConnections">REST API Reference for RejectVpcEndpointConnections Operation</seealso>
        public virtual Task<RejectVpcEndpointConnectionsResponse> RejectVpcEndpointConnectionsAsync(RejectVpcEndpointConnectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RejectVpcEndpointConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectVpcEndpointConnectionsResponseUnmarshaller.Instance;

            return InvokeAsync<RejectVpcEndpointConnectionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RejectVpcPeeringConnection

        internal virtual RejectVpcPeeringConnectionResponse RejectVpcPeeringConnection(RejectVpcPeeringConnectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RejectVpcPeeringConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectVpcPeeringConnectionResponseUnmarshaller.Instance;

            return Invoke<RejectVpcPeeringConnectionResponse>(request, options);
        }



        /// <summary>
        /// Rejects a VPC peering connection request. The VPC peering connection must be in the
        /// <code>pending-acceptance</code> state. Use the <a>DescribeVpcPeeringConnections</a>
        /// request to view your outstanding VPC peering connection requests. To delete an active
        /// VPC peering connection, or to delete a VPC peering connection request that you initiated,
        /// use <a>DeleteVpcPeeringConnection</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectVpcPeeringConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RejectVpcPeeringConnection service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RejectVpcPeeringConnection">REST API Reference for RejectVpcPeeringConnection Operation</seealso>
        public virtual Task<RejectVpcPeeringConnectionResponse> RejectVpcPeeringConnectionAsync(RejectVpcPeeringConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RejectVpcPeeringConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectVpcPeeringConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<RejectVpcPeeringConnectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ReleaseAddress

        internal virtual ReleaseAddressResponse ReleaseAddress(ReleaseAddressRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReleaseAddressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReleaseAddressResponseUnmarshaller.Instance;

            return Invoke<ReleaseAddressResponse>(request, options);
        }



        /// <summary>
        /// Releases the specified Elastic IP address.
        /// 
        ///  
        /// <para>
        /// [EC2-Classic, default VPC] Releasing an Elastic IP address automatically disassociates
        /// it from any instance that it's associated with. To disassociate an Elastic IP address
        /// without releasing it, use <a>DisassociateAddress</a>.
        /// </para>
        ///  
        /// <para>
        /// [Nondefault VPC] You must use <a>DisassociateAddress</a> to disassociate the Elastic
        /// IP address before you can release it. Otherwise, Amazon EC2 returns an error (<code>InvalidIPAddress.InUse</code>).
        /// </para>
        ///  
        /// <para>
        /// After releasing an Elastic IP address, it is released to the IP address pool. Be sure
        /// to update your DNS records and any servers or devices that communicate with the address.
        /// If you attempt to release an Elastic IP address that you already released, you'll
        /// get an <code>AuthFailure</code> error if the address is already allocated to another
        /// AWS account.
        /// </para>
        ///  
        /// <para>
        /// [EC2-VPC] After you release an Elastic IP address for use in a VPC, you might be able
        /// to recover it. For more information, see <a>AllocateAddress</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReleaseAddress service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ReleaseAddress service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReleaseAddress">REST API Reference for ReleaseAddress Operation</seealso>
        public virtual Task<ReleaseAddressResponse> ReleaseAddressAsync(ReleaseAddressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReleaseAddressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReleaseAddressResponseUnmarshaller.Instance;

            return InvokeAsync<ReleaseAddressResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ReleaseHosts

        internal virtual ReleaseHostsResponse ReleaseHosts(ReleaseHostsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReleaseHostsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReleaseHostsResponseUnmarshaller.Instance;

            return Invoke<ReleaseHostsResponse>(request, options);
        }



        /// <summary>
        /// When you no longer want to use an On-Demand Dedicated Host it can be released. On-Demand
        /// billing is stopped and the host goes into <code>released</code> state. The host ID
        /// of Dedicated Hosts that have been released can no longer be specified in another request,
        /// for example, to modify the host. You must stop or terminate all instances on a host
        /// before it can be released.
        /// 
        ///  
        /// <para>
        /// When Dedicated Hosts are released, it may take some time for them to stop counting
        /// toward your limit and you may receive capacity errors when trying to allocate new
        /// Dedicated Hosts. Wait a few minutes and then try again.
        /// </para>
        ///  
        /// <para>
        /// Released hosts still appear in a <a>DescribeHosts</a> response.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReleaseHosts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ReleaseHosts service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReleaseHosts">REST API Reference for ReleaseHosts Operation</seealso>
        public virtual Task<ReleaseHostsResponse> ReleaseHostsAsync(ReleaseHostsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReleaseHostsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReleaseHostsResponseUnmarshaller.Instance;

            return InvokeAsync<ReleaseHostsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ReplaceIamInstanceProfileAssociation

        internal virtual ReplaceIamInstanceProfileAssociationResponse ReplaceIamInstanceProfileAssociation(ReplaceIamInstanceProfileAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReplaceIamInstanceProfileAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReplaceIamInstanceProfileAssociationResponseUnmarshaller.Instance;

            return Invoke<ReplaceIamInstanceProfileAssociationResponse>(request, options);
        }



        /// <summary>
        /// Replaces an IAM instance profile for the specified running instance. You can use this
        /// action to change the IAM instance profile that's associated with an instance without
        /// having to disassociate the existing IAM instance profile first.
        /// 
        ///  
        /// <para>
        /// Use <a>DescribeIamInstanceProfileAssociations</a> to get the association ID.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReplaceIamInstanceProfileAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ReplaceIamInstanceProfileAssociation service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReplaceIamInstanceProfileAssociation">REST API Reference for ReplaceIamInstanceProfileAssociation Operation</seealso>
        public virtual Task<ReplaceIamInstanceProfileAssociationResponse> ReplaceIamInstanceProfileAssociationAsync(ReplaceIamInstanceProfileAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReplaceIamInstanceProfileAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReplaceIamInstanceProfileAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<ReplaceIamInstanceProfileAssociationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ReplaceNetworkAclAssociation

        internal virtual ReplaceNetworkAclAssociationResponse ReplaceNetworkAclAssociation(ReplaceNetworkAclAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReplaceNetworkAclAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReplaceNetworkAclAssociationResponseUnmarshaller.Instance;

            return Invoke<ReplaceNetworkAclAssociationResponse>(request, options);
        }



        /// <summary>
        /// Changes which network ACL a subnet is associated with. By default when you create
        /// a subnet, it's automatically associated with the default network ACL. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_ACLs.html">Network
        /// ACLs</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// 
        ///  
        /// <para>
        /// This is an idempotent operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReplaceNetworkAclAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ReplaceNetworkAclAssociation service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReplaceNetworkAclAssociation">REST API Reference for ReplaceNetworkAclAssociation Operation</seealso>
        public virtual Task<ReplaceNetworkAclAssociationResponse> ReplaceNetworkAclAssociationAsync(ReplaceNetworkAclAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReplaceNetworkAclAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReplaceNetworkAclAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<ReplaceNetworkAclAssociationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ReplaceNetworkAclEntry

        internal virtual ReplaceNetworkAclEntryResponse ReplaceNetworkAclEntry(ReplaceNetworkAclEntryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReplaceNetworkAclEntryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReplaceNetworkAclEntryResponseUnmarshaller.Instance;

            return Invoke<ReplaceNetworkAclEntryResponse>(request, options);
        }



        /// <summary>
        /// Replaces an entry (rule) in a network ACL. For more information, see <a href="https://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_ACLs.html">Network
        /// ACLs</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReplaceNetworkAclEntry service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ReplaceNetworkAclEntry service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReplaceNetworkAclEntry">REST API Reference for ReplaceNetworkAclEntry Operation</seealso>
        public virtual Task<ReplaceNetworkAclEntryResponse> ReplaceNetworkAclEntryAsync(ReplaceNetworkAclEntryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReplaceNetworkAclEntryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReplaceNetworkAclEntryResponseUnmarshaller.Instance;

            return InvokeAsync<ReplaceNetworkAclEntryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ReplaceRoute

        internal virtual ReplaceRouteResponse ReplaceRoute(ReplaceRouteRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReplaceRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReplaceRouteResponseUnmarshaller.Instance;

            return Invoke<ReplaceRouteResponse>(request, options);
        }



        /// <summary>
        /// Replaces an existing route within a route table in a VPC. You must provide only one
        /// of the following: internet gateway or virtual private gateway, NAT instance, NAT gateway,
        /// VPC peering connection, network interface, or egress-only internet gateway.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html">Route
        /// Tables</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReplaceRoute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ReplaceRoute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReplaceRoute">REST API Reference for ReplaceRoute Operation</seealso>
        public virtual Task<ReplaceRouteResponse> ReplaceRouteAsync(ReplaceRouteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReplaceRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReplaceRouteResponseUnmarshaller.Instance;

            return InvokeAsync<ReplaceRouteResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ReplaceRouteTableAssociation

        internal virtual ReplaceRouteTableAssociationResponse ReplaceRouteTableAssociation(ReplaceRouteTableAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReplaceRouteTableAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReplaceRouteTableAssociationResponseUnmarshaller.Instance;

            return Invoke<ReplaceRouteTableAssociationResponse>(request, options);
        }



        /// <summary>
        /// Changes the route table associated with a given subnet in a VPC. After the operation
        /// completes, the subnet uses the routes in the new route table it's associated with.
        /// For more information about route tables, see <a href="https://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html">Route
        /// Tables</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// 
        ///  
        /// <para>
        /// You can also use ReplaceRouteTableAssociation to change which table is the main route
        /// table in the VPC. You just specify the main route table's association ID and the route
        /// table to be the new main route table.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReplaceRouteTableAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ReplaceRouteTableAssociation service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReplaceRouteTableAssociation">REST API Reference for ReplaceRouteTableAssociation Operation</seealso>
        public virtual Task<ReplaceRouteTableAssociationResponse> ReplaceRouteTableAssociationAsync(ReplaceRouteTableAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReplaceRouteTableAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReplaceRouteTableAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<ReplaceRouteTableAssociationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ReplaceTransitGatewayRoute

        internal virtual ReplaceTransitGatewayRouteResponse ReplaceTransitGatewayRoute(ReplaceTransitGatewayRouteRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReplaceTransitGatewayRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReplaceTransitGatewayRouteResponseUnmarshaller.Instance;

            return Invoke<ReplaceTransitGatewayRouteResponse>(request, options);
        }



        /// <summary>
        /// Replaces the specified route in the specified transit gateway route table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReplaceTransitGatewayRoute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ReplaceTransitGatewayRoute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReplaceTransitGatewayRoute">REST API Reference for ReplaceTransitGatewayRoute Operation</seealso>
        public virtual Task<ReplaceTransitGatewayRouteResponse> ReplaceTransitGatewayRouteAsync(ReplaceTransitGatewayRouteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReplaceTransitGatewayRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReplaceTransitGatewayRouteResponseUnmarshaller.Instance;

            return InvokeAsync<ReplaceTransitGatewayRouteResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ReportInstanceStatus

        internal virtual ReportInstanceStatusResponse ReportInstanceStatus(ReportInstanceStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReportInstanceStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReportInstanceStatusResponseUnmarshaller.Instance;

            return Invoke<ReportInstanceStatusResponse>(request, options);
        }



        /// <summary>
        /// Submits feedback about the status of an instance. The instance must be in the <code>running</code>
        /// state. If your experience with the instance differs from the instance status returned
        /// by <a>DescribeInstanceStatus</a>, use <a>ReportInstanceStatus</a> to report your experience
        /// with the instance. Amazon EC2 collects this information to improve the accuracy of
        /// status checks.
        /// 
        ///  
        /// <para>
        /// Use of this action does not change the value returned by <a>DescribeInstanceStatus</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReportInstanceStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ReportInstanceStatus service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReportInstanceStatus">REST API Reference for ReportInstanceStatus Operation</seealso>
        public virtual Task<ReportInstanceStatusResponse> ReportInstanceStatusAsync(ReportInstanceStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReportInstanceStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReportInstanceStatusResponseUnmarshaller.Instance;

            return InvokeAsync<ReportInstanceStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RequestSpotFleet

        internal virtual RequestSpotFleetResponse RequestSpotFleet(RequestSpotFleetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RequestSpotFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RequestSpotFleetResponseUnmarshaller.Instance;

            return Invoke<RequestSpotFleetResponse>(request, options);
        }



        /// <summary>
        /// Creates a Spot Fleet request.
        /// 
        ///  
        /// <para>
        /// The Spot Fleet request specifies the total target capacity and the On-Demand target
        /// capacity. Amazon EC2 calculates the difference between the total capacity and On-Demand
        /// capacity, and launches the difference as Spot capacity.
        /// </para>
        ///  
        /// <para>
        /// You can submit a single request that includes multiple launch specifications that
        /// vary by instance type, AMI, Availability Zone, or subnet.
        /// </para>
        ///  
        /// <para>
        /// By default, the Spot Fleet requests Spot Instances in the Spot pool where the price
        /// per unit is the lowest. Each launch specification can include its own instance weighting
        /// that reflects the value of the instance type to your application workload.
        /// </para>
        ///  
        /// <para>
        /// Alternatively, you can specify that the Spot Fleet distribute the target capacity
        /// across the Spot pools included in its launch specifications. By ensuring that the
        /// Spot Instances in your Spot Fleet are in different Spot pools, you can improve the
        /// availability of your fleet.
        /// </para>
        ///  
        /// <para>
        /// You can specify tags for the Spot Instances. You cannot tag other resource types in
        /// a Spot Fleet request because only the <code>instance</code> resource type is supported.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/spot-fleet-requests.html">Spot
        /// Fleet Requests</a> in the <i>Amazon EC2 User Guide for Linux Instances</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RequestSpotFleet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RequestSpotFleet service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RequestSpotFleet">REST API Reference for RequestSpotFleet Operation</seealso>
        public virtual Task<RequestSpotFleetResponse> RequestSpotFleetAsync(RequestSpotFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RequestSpotFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RequestSpotFleetResponseUnmarshaller.Instance;

            return InvokeAsync<RequestSpotFleetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RequestSpotInstances

        internal virtual RequestSpotInstancesResponse RequestSpotInstances(RequestSpotInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RequestSpotInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RequestSpotInstancesResponseUnmarshaller.Instance;

            return Invoke<RequestSpotInstancesResponse>(request, options);
        }



        /// <summary>
        /// Creates a Spot Instance request.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/spot-requests.html">Spot
        /// Instance Requests</a> in the <i>Amazon EC2 User Guide for Linux Instances</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RequestSpotInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RequestSpotInstances service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RequestSpotInstances">REST API Reference for RequestSpotInstances Operation</seealso>
        public virtual Task<RequestSpotInstancesResponse> RequestSpotInstancesAsync(RequestSpotInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RequestSpotInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RequestSpotInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<RequestSpotInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ResetEbsDefaultKmsKeyId

        internal virtual ResetEbsDefaultKmsKeyIdResponse ResetEbsDefaultKmsKeyId(ResetEbsDefaultKmsKeyIdRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetEbsDefaultKmsKeyIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetEbsDefaultKmsKeyIdResponseUnmarshaller.Instance;

            return Invoke<ResetEbsDefaultKmsKeyIdResponse>(request, options);
        }



        /// <summary>
        /// Resets the account's default customer master key (CMK) to the account's AWS-managed
        /// default CMK. This default CMK is used to encrypt EBS volumes when you have enabled
        /// EBS encryption by default without specifying a CMK in the API call. If you have not
        /// enabled encryption by default, then this CMK is used when you set the <code>Encrypted</code>
        /// parameter to true without specifying a custom CMK in the API call.
        /// 
        ///  
        /// <para>
        /// Call this API if you have modified the default CMK that is used for encrypting your
        /// EBS volume using <a>ModifyEbsDefaultKmsKeyId</a> and you want to reset it to the AWS-managed
        /// default CMK. After resetting, you can continue to provide a CMK of your choice in
        /// the API call that creates the volume. However, if no CMK is specified, your account
        /// will encrypt the volume to the AWS-managed default CMK.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetEbsDefaultKmsKeyId service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResetEbsDefaultKmsKeyId service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ResetEbsDefaultKmsKeyId">REST API Reference for ResetEbsDefaultKmsKeyId Operation</seealso>
        public virtual Task<ResetEbsDefaultKmsKeyIdResponse> ResetEbsDefaultKmsKeyIdAsync(ResetEbsDefaultKmsKeyIdRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetEbsDefaultKmsKeyIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetEbsDefaultKmsKeyIdResponseUnmarshaller.Instance;

            return InvokeAsync<ResetEbsDefaultKmsKeyIdResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ResetFpgaImageAttribute

        internal virtual ResetFpgaImageAttributeResponse ResetFpgaImageAttribute(ResetFpgaImageAttributeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetFpgaImageAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetFpgaImageAttributeResponseUnmarshaller.Instance;

            return Invoke<ResetFpgaImageAttributeResponse>(request, options);
        }



        /// <summary>
        /// Resets the specified attribute of the specified Amazon FPGA Image (AFI) to its default
        /// value. You can only reset the load permission attribute.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetFpgaImageAttribute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResetFpgaImageAttribute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ResetFpgaImageAttribute">REST API Reference for ResetFpgaImageAttribute Operation</seealso>
        public virtual Task<ResetFpgaImageAttributeResponse> ResetFpgaImageAttributeAsync(ResetFpgaImageAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetFpgaImageAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetFpgaImageAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<ResetFpgaImageAttributeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ResetImageAttribute

        internal virtual ResetImageAttributeResponse ResetImageAttribute(ResetImageAttributeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetImageAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetImageAttributeResponseUnmarshaller.Instance;

            return Invoke<ResetImageAttributeResponse>(request, options);
        }



        /// <summary>
        /// Resets an attribute of an AMI to its default value.
        /// 
        ///  <note> 
        /// <para>
        /// The productCodes attribute can't be reset.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetImageAttribute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResetImageAttribute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ResetImageAttribute">REST API Reference for ResetImageAttribute Operation</seealso>
        public virtual Task<ResetImageAttributeResponse> ResetImageAttributeAsync(ResetImageAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetImageAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetImageAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<ResetImageAttributeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ResetInstanceAttribute

        internal virtual ResetInstanceAttributeResponse ResetInstanceAttribute(ResetInstanceAttributeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetInstanceAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetInstanceAttributeResponseUnmarshaller.Instance;

            return Invoke<ResetInstanceAttributeResponse>(request, options);
        }



        /// <summary>
        /// Resets an attribute of an instance to its default value. To reset the <code>kernel</code>
        /// or <code>ramdisk</code>, the instance must be in a stopped state. To reset the <code>sourceDestCheck</code>,
        /// the instance can be either running or stopped.
        /// 
        ///  
        /// <para>
        /// The <code>sourceDestCheck</code> attribute controls whether source/destination checking
        /// is enabled. The default value is <code>true</code>, which means checking is enabled.
        /// This value must be <code>false</code> for a NAT instance to perform NAT. For more
        /// information, see <a href="https://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_NAT_Instance.html">NAT
        /// Instances</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetInstanceAttribute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResetInstanceAttribute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ResetInstanceAttribute">REST API Reference for ResetInstanceAttribute Operation</seealso>
        public virtual Task<ResetInstanceAttributeResponse> ResetInstanceAttributeAsync(ResetInstanceAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetInstanceAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetInstanceAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<ResetInstanceAttributeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ResetNetworkInterfaceAttribute

        internal virtual ResetNetworkInterfaceAttributeResponse ResetNetworkInterfaceAttribute(ResetNetworkInterfaceAttributeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetNetworkInterfaceAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetNetworkInterfaceAttributeResponseUnmarshaller.Instance;

            return Invoke<ResetNetworkInterfaceAttributeResponse>(request, options);
        }



        /// <summary>
        /// Resets a network interface attribute. You can specify only one attribute at a time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetNetworkInterfaceAttribute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResetNetworkInterfaceAttribute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ResetNetworkInterfaceAttribute">REST API Reference for ResetNetworkInterfaceAttribute Operation</seealso>
        public virtual Task<ResetNetworkInterfaceAttributeResponse> ResetNetworkInterfaceAttributeAsync(ResetNetworkInterfaceAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetNetworkInterfaceAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetNetworkInterfaceAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<ResetNetworkInterfaceAttributeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ResetSnapshotAttribute

        internal virtual ResetSnapshotAttributeResponse ResetSnapshotAttribute(ResetSnapshotAttributeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetSnapshotAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetSnapshotAttributeResponseUnmarshaller.Instance;

            return Invoke<ResetSnapshotAttributeResponse>(request, options);
        }



        /// <summary>
        /// Resets permission settings for the specified snapshot.
        /// 
        ///  
        /// <para>
        /// For more information about modifying snapshot permissions, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-modifying-snapshot-permissions.html">Sharing
        /// Snapshots</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetSnapshotAttribute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResetSnapshotAttribute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ResetSnapshotAttribute">REST API Reference for ResetSnapshotAttribute Operation</seealso>
        public virtual Task<ResetSnapshotAttributeResponse> ResetSnapshotAttributeAsync(ResetSnapshotAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetSnapshotAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetSnapshotAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<ResetSnapshotAttributeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RestoreAddressToClassic

        internal virtual RestoreAddressToClassicResponse RestoreAddressToClassic(RestoreAddressToClassicRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreAddressToClassicRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreAddressToClassicResponseUnmarshaller.Instance;

            return Invoke<RestoreAddressToClassicResponse>(request, options);
        }



        /// <summary>
        /// Restores an Elastic IP address that was previously moved to the EC2-VPC platform back
        /// to the EC2-Classic platform. You cannot move an Elastic IP address that was originally
        /// allocated for use in EC2-VPC. The Elastic IP address must not be associated with an
        /// instance or network interface.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreAddressToClassic service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RestoreAddressToClassic service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RestoreAddressToClassic">REST API Reference for RestoreAddressToClassic Operation</seealso>
        public virtual Task<RestoreAddressToClassicResponse> RestoreAddressToClassicAsync(RestoreAddressToClassicRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreAddressToClassicRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreAddressToClassicResponseUnmarshaller.Instance;

            return InvokeAsync<RestoreAddressToClassicResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RevokeClientVpnIngress

        internal virtual RevokeClientVpnIngressResponse RevokeClientVpnIngress(RevokeClientVpnIngressRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RevokeClientVpnIngressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeClientVpnIngressResponseUnmarshaller.Instance;

            return Invoke<RevokeClientVpnIngressResponse>(request, options);
        }



        /// <summary>
        /// Removes an ingress authorization rule from a Client VPN endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeClientVpnIngress service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RevokeClientVpnIngress service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RevokeClientVpnIngress">REST API Reference for RevokeClientVpnIngress Operation</seealso>
        public virtual Task<RevokeClientVpnIngressResponse> RevokeClientVpnIngressAsync(RevokeClientVpnIngressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RevokeClientVpnIngressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeClientVpnIngressResponseUnmarshaller.Instance;

            return InvokeAsync<RevokeClientVpnIngressResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RevokeSecurityGroupEgress

        internal virtual RevokeSecurityGroupEgressResponse RevokeSecurityGroupEgress(RevokeSecurityGroupEgressRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RevokeSecurityGroupEgressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeSecurityGroupEgressResponseUnmarshaller.Instance;

            return Invoke<RevokeSecurityGroupEgressResponse>(request, options);
        }



        /// <summary>
        /// [VPC only] Removes the specified egress rules from a security group for EC2-VPC. This
        /// action doesn't apply to security groups for use in EC2-Classic. To remove a rule,
        /// the values that you specify (for example, ports) must match the existing rule's values
        /// exactly.
        /// 
        ///  
        /// <para>
        /// Each rule consists of the protocol and the IPv4 or IPv6 CIDR range or source security
        /// group. For the TCP and UDP protocols, you must also specify the destination port or
        /// range of ports. For the ICMP protocol, you must also specify the ICMP type and code.
        /// If the security group rule has a description, you do not have to specify the description
        /// to revoke the rule.
        /// </para>
        ///  
        /// <para>
        /// Rule changes are propagated to instances within the security group as quickly as possible.
        /// However, a small delay might occur.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeSecurityGroupEgress service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RevokeSecurityGroupEgress service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RevokeSecurityGroupEgress">REST API Reference for RevokeSecurityGroupEgress Operation</seealso>
        public virtual Task<RevokeSecurityGroupEgressResponse> RevokeSecurityGroupEgressAsync(RevokeSecurityGroupEgressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RevokeSecurityGroupEgressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeSecurityGroupEgressResponseUnmarshaller.Instance;

            return InvokeAsync<RevokeSecurityGroupEgressResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RevokeSecurityGroupIngress

        internal virtual RevokeSecurityGroupIngressResponse RevokeSecurityGroupIngress(RevokeSecurityGroupIngressRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RevokeSecurityGroupIngressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeSecurityGroupIngressResponseUnmarshaller.Instance;

            return Invoke<RevokeSecurityGroupIngressResponse>(request, options);
        }



        /// <summary>
        /// Removes the specified ingress rules from a security group. To remove a rule, the values
        /// that you specify (for example, ports) must match the existing rule's values exactly.
        /// 
        ///  <note> 
        /// <para>
        /// [EC2-Classic only] If the values you specify do not match the existing rule's values,
        /// no error is returned. Use <a>DescribeSecurityGroups</a> to verify that the rule has
        /// been removed.
        /// </para>
        ///  </note> 
        /// <para>
        /// Each rule consists of the protocol and the CIDR range or source security group. For
        /// the TCP and UDP protocols, you must also specify the destination port or range of
        /// ports. For the ICMP protocol, you must also specify the ICMP type and code. If the
        /// security group rule has a description, you do not have to specify the description
        /// to revoke the rule.
        /// </para>
        ///  
        /// <para>
        /// Rule changes are propagated to instances within the security group as quickly as possible.
        /// However, a small delay might occur.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeSecurityGroupIngress service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RevokeSecurityGroupIngress service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RevokeSecurityGroupIngress">REST API Reference for RevokeSecurityGroupIngress Operation</seealso>
        public virtual Task<RevokeSecurityGroupIngressResponse> RevokeSecurityGroupIngressAsync(RevokeSecurityGroupIngressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RevokeSecurityGroupIngressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeSecurityGroupIngressResponseUnmarshaller.Instance;

            return InvokeAsync<RevokeSecurityGroupIngressResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RunInstances

        internal virtual RunInstancesResponse RunInstances(RunInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RunInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RunInstancesResponseUnmarshaller.Instance;

            return Invoke<RunInstancesResponse>(request, options);
        }



        /// <summary>
        /// Launches the specified number of instances using an AMI for which you have permissions.
        /// 
        /// 
        ///  
        /// <para>
        /// You can specify a number of options, or leave the default options. The following rules
        /// apply:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// [EC2-VPC] If you don't specify a subnet ID, we choose a default subnet from your default
        /// VPC for you. If you don't have a default VPC, you must specify a subnet ID in the
        /// request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// [EC2-Classic] If don't specify an Availability Zone, we choose one for you.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Some instance types must be launched into a VPC. If you do not have a default VPC,
        /// or if you do not specify a subnet ID, the request fails. For more information, see
        /// <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-vpc.html#vpc-only-instance-types">Instance
        /// Types Available Only in a VPC</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// [EC2-VPC] All instances have a network interface with a primary private IPv4 address.
        /// If you don't specify this address, we choose one from the IPv4 range of your subnet.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not all instance types support IPv6 addresses. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html">Instance
        /// Types</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you don't specify a security group ID, we use the default security group. For more
        /// information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-network-security.html">Security
        /// Groups</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If any of the AMIs have a product code attached for which the user has not subscribed,
        /// the request fails.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can create a <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-launch-templates.html">launch
        /// template</a>, which is a resource that contains the parameters to launch an instance.
        /// When you launch an instance using <a>RunInstances</a>, you can specify the launch
        /// template instead of specifying the launch parameters.
        /// </para>
        ///  
        /// <para>
        /// To ensure faster instance launches, break up large requests into smaller batches.
        /// For example, create five separate launch requests for 100 instances each instead of
        /// one launch request for 500 instances.
        /// </para>
        ///  
        /// <para>
        /// An instance is ready for you to use when it's in the <code>running</code> state. You
        /// can check the state of your instance using <a>DescribeInstances</a>. You can tag instances
        /// and EBS volumes during launch, after launch, or both. For more information, see <a>CreateTags</a>
        /// and <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html">Tagging
        /// Your Amazon EC2 Resources</a>.
        /// </para>
        ///  
        /// <para>
        /// Linux instances have access to the public key of the key pair at boot. You can use
        /// this key to provide secure access to the instance. Amazon EC2 public images use this
        /// feature to provide secure access without passwords. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-key-pairs.html">Key
        /// Pairs</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For troubleshooting, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_InstanceStraightToTerminated.html">What
        /// To Do If An Instance Immediately Terminates</a>, and <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/TroubleshootingInstancesConnecting.html">Troubleshooting
        /// Connecting to Your Instance</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RunInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RunInstances service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RunInstances">REST API Reference for RunInstances Operation</seealso>
        public virtual Task<RunInstancesResponse> RunInstancesAsync(RunInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RunInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RunInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<RunInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RunScheduledInstances

        internal virtual RunScheduledInstancesResponse RunScheduledInstances(RunScheduledInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RunScheduledInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RunScheduledInstancesResponseUnmarshaller.Instance;

            return Invoke<RunScheduledInstancesResponse>(request, options);
        }



        /// <summary>
        /// Launches the specified Scheduled Instances.
        /// 
        ///  
        /// <para>
        /// Before you can launch a Scheduled Instance, you must purchase it and obtain an identifier
        /// using <a>PurchaseScheduledInstances</a>.
        /// </para>
        ///  
        /// <para>
        /// You must launch a Scheduled Instance during its scheduled time period. You can't stop
        /// or reboot a Scheduled Instance, but you can terminate it as needed. If you terminate
        /// a Scheduled Instance before the current scheduled time period ends, you can launch
        /// it again after a few minutes. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-scheduled-instances.html">Scheduled
        /// Instances</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RunScheduledInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RunScheduledInstances service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RunScheduledInstances">REST API Reference for RunScheduledInstances Operation</seealso>
        public virtual Task<RunScheduledInstancesResponse> RunScheduledInstancesAsync(RunScheduledInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RunScheduledInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RunScheduledInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<RunScheduledInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SearchTransitGatewayRoutes

        internal virtual SearchTransitGatewayRoutesResponse SearchTransitGatewayRoutes(SearchTransitGatewayRoutesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchTransitGatewayRoutesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchTransitGatewayRoutesResponseUnmarshaller.Instance;

            return Invoke<SearchTransitGatewayRoutesResponse>(request, options);
        }



        /// <summary>
        /// Searches for routes in the specified transit gateway route table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchTransitGatewayRoutes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchTransitGatewayRoutes service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/SearchTransitGatewayRoutes">REST API Reference for SearchTransitGatewayRoutes Operation</seealso>
        public virtual Task<SearchTransitGatewayRoutesResponse> SearchTransitGatewayRoutesAsync(SearchTransitGatewayRoutesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchTransitGatewayRoutesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchTransitGatewayRoutesResponseUnmarshaller.Instance;

            return InvokeAsync<SearchTransitGatewayRoutesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartInstances

        internal virtual StartInstancesResponse StartInstances(StartInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartInstancesResponseUnmarshaller.Instance;

            return Invoke<StartInstancesResponse>(request, options);
        }



        /// <summary>
        /// Starts an Amazon EBS-backed instance that you've previously stopped.
        /// 
        ///  
        /// <para>
        /// Instances that use Amazon EBS volumes as their root devices can be quickly stopped
        /// and started. When an instance is stopped, the compute resources are released and you
        /// are not billed for instance usage. However, your root partition Amazon EBS volume
        /// remains and continues to persist your data, and you are charged for Amazon EBS volume
        /// usage. You can restart your instance at any time. Every time you start your Windows
        /// instance, Amazon EC2 charges you for a full instance hour. If you stop and restart
        /// your Windows instance, a new instance hour begins and Amazon EC2 charges you for another
        /// full instance hour even if you are still within the same 60-minute period when it
        /// was stopped. Every time you start your Linux instance, Amazon EC2 charges a one-minute
        /// minimum for instance usage, and thereafter charges per second for instance usage.
        /// </para>
        ///  
        /// <para>
        /// Before stopping an instance, make sure it is in a state from which it can be restarted.
        /// Stopping an instance does not preserve data stored in RAM.
        /// </para>
        ///  
        /// <para>
        /// Performing this operation on an instance that uses an instance store as its root device
        /// returns an error.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Stop_Start.html">Stopping
        /// Instances</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartInstances service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/StartInstances">REST API Reference for StartInstances Operation</seealso>
        public virtual Task<StartInstancesResponse> StartInstancesAsync(StartInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<StartInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopInstances

        internal virtual StopInstancesResponse StopInstances(StopInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopInstancesResponseUnmarshaller.Instance;

            return Invoke<StopInstancesResponse>(request, options);
        }



        /// <summary>
        /// Stops an Amazon EBS-backed instance.
        /// 
        ///  
        /// <para>
        /// You can use the Stop action to hibernate an instance if the instance is <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Hibernate.html#enabling-hibernation">enabled
        /// for hibernation</a> and it meets the <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Hibernate.html#hibernating-prerequisites">hibernation
        /// prerequisites</a>. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Hibernate.html">Hibernate
        /// Your Instance</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// We don't charge usage for a stopped instance, or data transfer fees; however, your
        /// root partition Amazon EBS volume remains and continues to persist your data, and you
        /// are charged for Amazon EBS volume usage. Every time you start your Windows instance,
        /// Amazon EC2 charges you for a full instance hour. If you stop and restart your Windows
        /// instance, a new instance hour begins and Amazon EC2 charges you for another full instance
        /// hour even if you are still within the same 60-minute period when it was stopped. Every
        /// time you start your Linux instance, Amazon EC2 charges a one-minute minimum for instance
        /// usage, and thereafter charges per second for instance usage.
        /// </para>
        ///  
        /// <para>
        /// You can't start, stop, or hibernate Spot Instances, and you can't stop or hibernate
        /// instance store-backed instances. For information about using hibernation for Spot
        /// Instances, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/spot-interruptions.html#hibernate-spot-instances">Hibernating
        /// Interrupted Spot Instances</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// When you stop or hibernate an instance, we shut it down. You can restart your instance
        /// at any time. Before stopping or hibernating an instance, make sure it is in a state
        /// from which it can be restarted. Stopping an instance does not preserve data stored
        /// in RAM, but hibernating an instance does preserve data stored in RAM. If an instance
        /// cannot hibernate successfully, a normal shutdown occurs.
        /// </para>
        ///  
        /// <para>
        /// Stopping and hibernating an instance is different to rebooting or terminating it.
        /// For example, when you stop or hibernate an instance, the root device and any other
        /// devices attached to the instance persist. When you terminate an instance, the root
        /// device and any other devices attached during the instance launch are automatically
        /// deleted. For more information about the differences between rebooting, stopping, hibernating,
        /// and terminating instances, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instance-lifecycle.html">Instance
        /// Lifecycle</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// When you stop an instance, we attempt to shut it down forcibly after a short while.
        /// If your instance appears stuck in the stopping state after a period of time, there
        /// may be an issue with the underlying host computer. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/TroubleshootingInstancesStopping.html">Troubleshooting
        /// Stopping Your Instance</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopInstances service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/StopInstances">REST API Reference for StopInstances Operation</seealso>
        public virtual Task<StopInstancesResponse> StopInstancesAsync(StopInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<StopInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TerminateClientVpnConnections

        internal virtual TerminateClientVpnConnectionsResponse TerminateClientVpnConnections(TerminateClientVpnConnectionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TerminateClientVpnConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TerminateClientVpnConnectionsResponseUnmarshaller.Instance;

            return Invoke<TerminateClientVpnConnectionsResponse>(request, options);
        }



        /// <summary>
        /// Terminates active Client VPN endpoint connections. This action can be used to terminate
        /// a specific client connection, or up to five connections established by a specific
        /// user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TerminateClientVpnConnections service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TerminateClientVpnConnections service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/TerminateClientVpnConnections">REST API Reference for TerminateClientVpnConnections Operation</seealso>
        public virtual Task<TerminateClientVpnConnectionsResponse> TerminateClientVpnConnectionsAsync(TerminateClientVpnConnectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TerminateClientVpnConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TerminateClientVpnConnectionsResponseUnmarshaller.Instance;

            return InvokeAsync<TerminateClientVpnConnectionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TerminateInstances

        internal virtual TerminateInstancesResponse TerminateInstances(TerminateInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TerminateInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TerminateInstancesResponseUnmarshaller.Instance;

            return Invoke<TerminateInstancesResponse>(request, options);
        }



        /// <summary>
        /// Shuts down the specified instances. This operation is idempotent; if you terminate
        /// an instance more than once, each call succeeds. 
        /// 
        ///  
        /// <para>
        /// If you specify multiple instances and the request fails (for example, because of a
        /// single incorrect instance ID), none of the instances are terminated.
        /// </para>
        ///  
        /// <para>
        /// Terminated instances remain visible after termination (for approximately one hour).
        /// </para>
        ///  
        /// <para>
        /// By default, Amazon EC2 deletes all EBS volumes that were attached when the instance
        /// launched. Volumes attached after instance launch continue running.
        /// </para>
        ///  
        /// <para>
        /// You can stop, start, and terminate EBS-backed instances. You can only terminate instance
        /// store-backed instances. What happens to an instance differs if you stop it or terminate
        /// it. For example, when you stop an instance, the root device and any other devices
        /// attached to the instance persist. When you terminate an instance, any attached EBS
        /// volumes with the <code>DeleteOnTermination</code> block device mapping parameter set
        /// to <code>true</code> are automatically deleted. For more information about the differences
        /// between stopping and terminating instances, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instance-lifecycle.html">Instance
        /// Lifecycle</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information about troubleshooting, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/TroubleshootingInstancesShuttingDown.html">Troubleshooting
        /// Terminating Your Instance</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TerminateInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TerminateInstances service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/TerminateInstances">REST API Reference for TerminateInstances Operation</seealso>
        public virtual Task<TerminateInstancesResponse> TerminateInstancesAsync(TerminateInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TerminateInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TerminateInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<TerminateInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UnassignIpv6Addresses

        internal virtual UnassignIpv6AddressesResponse UnassignIpv6Addresses(UnassignIpv6AddressesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UnassignIpv6AddressesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UnassignIpv6AddressesResponseUnmarshaller.Instance;

            return Invoke<UnassignIpv6AddressesResponse>(request, options);
        }



        /// <summary>
        /// Unassigns one or more IPv6 addresses from a network interface.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UnassignIpv6Addresses service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UnassignIpv6Addresses service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/UnassignIpv6Addresses">REST API Reference for UnassignIpv6Addresses Operation</seealso>
        public virtual Task<UnassignIpv6AddressesResponse> UnassignIpv6AddressesAsync(UnassignIpv6AddressesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UnassignIpv6AddressesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UnassignIpv6AddressesResponseUnmarshaller.Instance;

            return InvokeAsync<UnassignIpv6AddressesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UnassignPrivateIpAddresses

        internal virtual UnassignPrivateIpAddressesResponse UnassignPrivateIpAddresses(UnassignPrivateIpAddressesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UnassignPrivateIpAddressesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UnassignPrivateIpAddressesResponseUnmarshaller.Instance;

            return Invoke<UnassignPrivateIpAddressesResponse>(request, options);
        }



        /// <summary>
        /// Unassigns one or more secondary private IP addresses from a network interface.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UnassignPrivateIpAddresses service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UnassignPrivateIpAddresses service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/UnassignPrivateIpAddresses">REST API Reference for UnassignPrivateIpAddresses Operation</seealso>
        public virtual Task<UnassignPrivateIpAddressesResponse> UnassignPrivateIpAddressesAsync(UnassignPrivateIpAddressesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UnassignPrivateIpAddressesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UnassignPrivateIpAddressesResponseUnmarshaller.Instance;

            return InvokeAsync<UnassignPrivateIpAddressesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UnmonitorInstances

        internal virtual UnmonitorInstancesResponse UnmonitorInstances(UnmonitorInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UnmonitorInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UnmonitorInstancesResponseUnmarshaller.Instance;

            return Invoke<UnmonitorInstancesResponse>(request, options);
        }



        /// <summary>
        /// Disables detailed monitoring for a running instance. For more information, see <a
        /// href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-cloudwatch.html">Monitoring
        /// Your Instances and Volumes</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UnmonitorInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UnmonitorInstances service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/UnmonitorInstances">REST API Reference for UnmonitorInstances Operation</seealso>
        public virtual Task<UnmonitorInstancesResponse> UnmonitorInstancesAsync(UnmonitorInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UnmonitorInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UnmonitorInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<UnmonitorInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateSecurityGroupRuleDescriptionsEgress

        internal virtual UpdateSecurityGroupRuleDescriptionsEgressResponse UpdateSecurityGroupRuleDescriptionsEgress(UpdateSecurityGroupRuleDescriptionsEgressRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSecurityGroupRuleDescriptionsEgressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSecurityGroupRuleDescriptionsEgressResponseUnmarshaller.Instance;

            return Invoke<UpdateSecurityGroupRuleDescriptionsEgressResponse>(request, options);
        }



        /// <summary>
        /// [VPC only] Updates the description of an egress (outbound) security group rule. You
        /// can replace an existing description, or add a description to a rule that did not have
        /// one previously.
        /// 
        ///  
        /// <para>
        /// You specify the description as part of the IP permissions structure. You can remove
        /// a description for a security group rule by omitting the description parameter in the
        /// request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSecurityGroupRuleDescriptionsEgress service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSecurityGroupRuleDescriptionsEgress service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/UpdateSecurityGroupRuleDescriptionsEgress">REST API Reference for UpdateSecurityGroupRuleDescriptionsEgress Operation</seealso>
        public virtual Task<UpdateSecurityGroupRuleDescriptionsEgressResponse> UpdateSecurityGroupRuleDescriptionsEgressAsync(UpdateSecurityGroupRuleDescriptionsEgressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSecurityGroupRuleDescriptionsEgressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSecurityGroupRuleDescriptionsEgressResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSecurityGroupRuleDescriptionsEgressResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateSecurityGroupRuleDescriptionsIngress

        internal virtual UpdateSecurityGroupRuleDescriptionsIngressResponse UpdateSecurityGroupRuleDescriptionsIngress(UpdateSecurityGroupRuleDescriptionsIngressRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSecurityGroupRuleDescriptionsIngressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSecurityGroupRuleDescriptionsIngressResponseUnmarshaller.Instance;

            return Invoke<UpdateSecurityGroupRuleDescriptionsIngressResponse>(request, options);
        }



        /// <summary>
        /// Updates the description of an ingress (inbound) security group rule. You can replace
        /// an existing description, or add a description to a rule that did not have one previously.
        /// 
        ///  
        /// <para>
        /// You specify the description as part of the IP permissions structure. You can remove
        /// a description for a security group rule by omitting the description parameter in the
        /// request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSecurityGroupRuleDescriptionsIngress service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSecurityGroupRuleDescriptionsIngress service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/UpdateSecurityGroupRuleDescriptionsIngress">REST API Reference for UpdateSecurityGroupRuleDescriptionsIngress Operation</seealso>
        public virtual Task<UpdateSecurityGroupRuleDescriptionsIngressResponse> UpdateSecurityGroupRuleDescriptionsIngressAsync(UpdateSecurityGroupRuleDescriptionsIngressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSecurityGroupRuleDescriptionsIngressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSecurityGroupRuleDescriptionsIngressResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSecurityGroupRuleDescriptionsIngressResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  WithdrawByoipCidr

        internal virtual WithdrawByoipCidrResponse WithdrawByoipCidr(WithdrawByoipCidrRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = WithdrawByoipCidrRequestMarshaller.Instance;
            options.ResponseUnmarshaller = WithdrawByoipCidrResponseUnmarshaller.Instance;

            return Invoke<WithdrawByoipCidrResponse>(request, options);
        }



        /// <summary>
        /// Stops advertising an IPv4 address range that is provisioned as an address pool.
        /// 
        ///  
        /// <para>
        /// You can perform this operation at most once every 10 seconds, even if you specify
        /// different address ranges each time.
        /// </para>
        ///  
        /// <para>
        /// It can take a few minutes before traffic to the specified addresses stops routing
        /// to AWS because of BGP propagation delays.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the WithdrawByoipCidr service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the WithdrawByoipCidr service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/WithdrawByoipCidr">REST API Reference for WithdrawByoipCidr Operation</seealso>
        public virtual Task<WithdrawByoipCidrResponse> WithdrawByoipCidrAsync(WithdrawByoipCidrRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = WithdrawByoipCidrRequestMarshaller.Instance;
            options.ResponseUnmarshaller = WithdrawByoipCidrResponseUnmarshaller.Instance;

            return InvokeAsync<WithdrawByoipCidrResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}