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
 * Do not modify this file. This file is generated from the sms-voice-2018-09-05.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.PinpointSMSVoice.Model;
using Amazon.PinpointSMSVoice.Model.Internal.MarshallTransformations;
using Amazon.PinpointSMSVoice.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.PinpointSMSVoice
{
    /// <summary>
    /// Implementation for accessing PinpointSMSVoice
    ///
    /// Pinpoint SMS and Voice Messaging public facing APIs
    /// </summary>
    public partial class AmazonPinpointSMSVoiceClient : AmazonServiceClient, IAmazonPinpointSMSVoice
    {
        private static IServiceMetadata serviceMetadata = new AmazonPinpointSMSVoiceMetadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonPinpointSMSVoiceClient with the credentials loaded from the application's
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
        public AmazonPinpointSMSVoiceClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonPinpointSMSVoiceConfig()) { }

        /// <summary>
        /// Constructs AmazonPinpointSMSVoiceClient with the credentials loaded from the application's
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
        public AmazonPinpointSMSVoiceClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonPinpointSMSVoiceConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonPinpointSMSVoiceClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonPinpointSMSVoiceClient Configuration Object</param>
        public AmazonPinpointSMSVoiceClient(AmazonPinpointSMSVoiceConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonPinpointSMSVoiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonPinpointSMSVoiceClient(AWSCredentials credentials)
            : this(credentials, new AmazonPinpointSMSVoiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPinpointSMSVoiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPinpointSMSVoiceClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonPinpointSMSVoiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonPinpointSMSVoiceClient with AWS Credentials and an
        /// AmazonPinpointSMSVoiceClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonPinpointSMSVoiceClient Configuration Object</param>
        public AmazonPinpointSMSVoiceClient(AWSCredentials credentials, AmazonPinpointSMSVoiceConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonPinpointSMSVoiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonPinpointSMSVoiceClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonPinpointSMSVoiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPinpointSMSVoiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPinpointSMSVoiceClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonPinpointSMSVoiceConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonPinpointSMSVoiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonPinpointSMSVoiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonPinpointSMSVoiceClient Configuration Object</param>
        public AmazonPinpointSMSVoiceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonPinpointSMSVoiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonPinpointSMSVoiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonPinpointSMSVoiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonPinpointSMSVoiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPinpointSMSVoiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPinpointSMSVoiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonPinpointSMSVoiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonPinpointSMSVoiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonPinpointSMSVoiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonPinpointSMSVoiceClient Configuration Object</param>
        public AmazonPinpointSMSVoiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonPinpointSMSVoiceConfig clientConfig)
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

        
        #region  CreateConfigurationSet


        /// <summary>
        /// Create a new configuration set. After you create the configuration set, you can add
        /// one or more event destinations to it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConfigurationSet service method.</param>
        /// 
        /// <returns>The response from the CreateConfigurationSet service method, as returned by PinpointSMSVoice.</returns>
        /// <exception cref="Amazon.PinpointSMSVoice.Model.AlreadyExistsException">
        /// The resource specified in your request already exists.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoice.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoice.Model.InternalServiceErrorException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoice.Model.LimitExceededException">
        /// There are too many instances of the specified resource type.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoice.Model.TooManyRequestsException">
        /// You've issued too many requests to the resource. Wait a few minutes, and then try
        /// again.
        /// </exception>
        public virtual CreateConfigurationSetResponse CreateConfigurationSet(CreateConfigurationSetRequest request)
        {
            var marshaller = CreateConfigurationSetRequestMarshaller.Instance;
            var unmarshaller = CreateConfigurationSetResponseUnmarshaller.Instance;

            return Invoke<CreateConfigurationSetRequest,CreateConfigurationSetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateConfigurationSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConfigurationSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<CreateConfigurationSetResponse> CreateConfigurationSetAsync(CreateConfigurationSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateConfigurationSetRequestMarshaller.Instance;
            var unmarshaller = CreateConfigurationSetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateConfigurationSetRequest,CreateConfigurationSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateConfigurationSetEventDestination


        /// <summary>
        /// Create a new event destination in a configuration set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConfigurationSetEventDestination service method.</param>
        /// 
        /// <returns>The response from the CreateConfigurationSetEventDestination service method, as returned by PinpointSMSVoice.</returns>
        /// <exception cref="Amazon.PinpointSMSVoice.Model.AlreadyExistsException">
        /// The resource specified in your request already exists.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoice.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoice.Model.InternalServiceErrorException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoice.Model.LimitExceededException">
        /// There are too many instances of the specified resource type.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoice.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoice.Model.TooManyRequestsException">
        /// You've issued too many requests to the resource. Wait a few minutes, and then try
        /// again.
        /// </exception>
        public virtual CreateConfigurationSetEventDestinationResponse CreateConfigurationSetEventDestination(CreateConfigurationSetEventDestinationRequest request)
        {
            var marshaller = CreateConfigurationSetEventDestinationRequestMarshaller.Instance;
            var unmarshaller = CreateConfigurationSetEventDestinationResponseUnmarshaller.Instance;

            return Invoke<CreateConfigurationSetEventDestinationRequest,CreateConfigurationSetEventDestinationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateConfigurationSetEventDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConfigurationSetEventDestination operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<CreateConfigurationSetEventDestinationResponse> CreateConfigurationSetEventDestinationAsync(CreateConfigurationSetEventDestinationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateConfigurationSetEventDestinationRequestMarshaller.Instance;
            var unmarshaller = CreateConfigurationSetEventDestinationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateConfigurationSetEventDestinationRequest,CreateConfigurationSetEventDestinationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteConfigurationSet


        /// <summary>
        /// Deletes an existing configuration set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationSet service method.</param>
        /// 
        /// <returns>The response from the DeleteConfigurationSet service method, as returned by PinpointSMSVoice.</returns>
        /// <exception cref="Amazon.PinpointSMSVoice.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoice.Model.InternalServiceErrorException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoice.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoice.Model.TooManyRequestsException">
        /// You've issued too many requests to the resource. Wait a few minutes, and then try
        /// again.
        /// </exception>
        public virtual DeleteConfigurationSetResponse DeleteConfigurationSet(DeleteConfigurationSetRequest request)
        {
            var marshaller = DeleteConfigurationSetRequestMarshaller.Instance;
            var unmarshaller = DeleteConfigurationSetResponseUnmarshaller.Instance;

            return Invoke<DeleteConfigurationSetRequest,DeleteConfigurationSetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConfigurationSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteConfigurationSetResponse> DeleteConfigurationSetAsync(DeleteConfigurationSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteConfigurationSetRequestMarshaller.Instance;
            var unmarshaller = DeleteConfigurationSetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteConfigurationSetRequest,DeleteConfigurationSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteConfigurationSetEventDestination


        /// <summary>
        /// Deletes an event destination in a configuration set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationSetEventDestination service method.</param>
        /// 
        /// <returns>The response from the DeleteConfigurationSetEventDestination service method, as returned by PinpointSMSVoice.</returns>
        /// <exception cref="Amazon.PinpointSMSVoice.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoice.Model.InternalServiceErrorException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoice.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoice.Model.TooManyRequestsException">
        /// You've issued too many requests to the resource. Wait a few minutes, and then try
        /// again.
        /// </exception>
        public virtual DeleteConfigurationSetEventDestinationResponse DeleteConfigurationSetEventDestination(DeleteConfigurationSetEventDestinationRequest request)
        {
            var marshaller = DeleteConfigurationSetEventDestinationRequestMarshaller.Instance;
            var unmarshaller = DeleteConfigurationSetEventDestinationResponseUnmarshaller.Instance;

            return Invoke<DeleteConfigurationSetEventDestinationRequest,DeleteConfigurationSetEventDestinationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConfigurationSetEventDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationSetEventDestination operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteConfigurationSetEventDestinationResponse> DeleteConfigurationSetEventDestinationAsync(DeleteConfigurationSetEventDestinationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteConfigurationSetEventDestinationRequestMarshaller.Instance;
            var unmarshaller = DeleteConfigurationSetEventDestinationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteConfigurationSetEventDestinationRequest,DeleteConfigurationSetEventDestinationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetConfigurationSetEventDestinations


        /// <summary>
        /// Obtain information about an event destination, including the types of events it reports,
        /// the Amazon Resource Name (ARN) of the destination, and the name of the event destination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfigurationSetEventDestinations service method.</param>
        /// 
        /// <returns>The response from the GetConfigurationSetEventDestinations service method, as returned by PinpointSMSVoice.</returns>
        /// <exception cref="Amazon.PinpointSMSVoice.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoice.Model.InternalServiceErrorException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoice.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoice.Model.TooManyRequestsException">
        /// You've issued too many requests to the resource. Wait a few minutes, and then try
        /// again.
        /// </exception>
        public virtual GetConfigurationSetEventDestinationsResponse GetConfigurationSetEventDestinations(GetConfigurationSetEventDestinationsRequest request)
        {
            var marshaller = GetConfigurationSetEventDestinationsRequestMarshaller.Instance;
            var unmarshaller = GetConfigurationSetEventDestinationsResponseUnmarshaller.Instance;

            return Invoke<GetConfigurationSetEventDestinationsRequest,GetConfigurationSetEventDestinationsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetConfigurationSetEventDestinations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConfigurationSetEventDestinations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetConfigurationSetEventDestinationsResponse> GetConfigurationSetEventDestinationsAsync(GetConfigurationSetEventDestinationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetConfigurationSetEventDestinationsRequestMarshaller.Instance;
            var unmarshaller = GetConfigurationSetEventDestinationsResponseUnmarshaller.Instance;

            return InvokeAsync<GetConfigurationSetEventDestinationsRequest,GetConfigurationSetEventDestinationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SendVoiceMessage


        /// <summary>
        /// Create a new voice message and send it to a recipient's phone number.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendVoiceMessage service method.</param>
        /// 
        /// <returns>The response from the SendVoiceMessage service method, as returned by PinpointSMSVoice.</returns>
        /// <exception cref="Amazon.PinpointSMSVoice.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoice.Model.InternalServiceErrorException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoice.Model.TooManyRequestsException">
        /// You've issued too many requests to the resource. Wait a few minutes, and then try
        /// again.
        /// </exception>
        public virtual SendVoiceMessageResponse SendVoiceMessage(SendVoiceMessageRequest request)
        {
            var marshaller = SendVoiceMessageRequestMarshaller.Instance;
            var unmarshaller = SendVoiceMessageResponseUnmarshaller.Instance;

            return Invoke<SendVoiceMessageRequest,SendVoiceMessageResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SendVoiceMessage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendVoiceMessage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<SendVoiceMessageResponse> SendVoiceMessageAsync(SendVoiceMessageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = SendVoiceMessageRequestMarshaller.Instance;
            var unmarshaller = SendVoiceMessageResponseUnmarshaller.Instance;

            return InvokeAsync<SendVoiceMessageRequest,SendVoiceMessageResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateConfigurationSetEventDestination


        /// <summary>
        /// Update an event destination in a configuration set. An event destination is a location
        /// that you publish information about your voice calls to. For example, you can log an
        /// event to an Amazon CloudWatch destination when a call fails.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfigurationSetEventDestination service method.</param>
        /// 
        /// <returns>The response from the UpdateConfigurationSetEventDestination service method, as returned by PinpointSMSVoice.</returns>
        /// <exception cref="Amazon.PinpointSMSVoice.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoice.Model.InternalServiceErrorException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoice.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoice.Model.TooManyRequestsException">
        /// You've issued too many requests to the resource. Wait a few minutes, and then try
        /// again.
        /// </exception>
        public virtual UpdateConfigurationSetEventDestinationResponse UpdateConfigurationSetEventDestination(UpdateConfigurationSetEventDestinationRequest request)
        {
            var marshaller = UpdateConfigurationSetEventDestinationRequestMarshaller.Instance;
            var unmarshaller = UpdateConfigurationSetEventDestinationResponseUnmarshaller.Instance;

            return Invoke<UpdateConfigurationSetEventDestinationRequest,UpdateConfigurationSetEventDestinationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConfigurationSetEventDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfigurationSetEventDestination operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<UpdateConfigurationSetEventDestinationResponse> UpdateConfigurationSetEventDestinationAsync(UpdateConfigurationSetEventDestinationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateConfigurationSetEventDestinationRequestMarshaller.Instance;
            var unmarshaller = UpdateConfigurationSetEventDestinationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateConfigurationSetEventDestinationRequest,UpdateConfigurationSetEventDestinationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}