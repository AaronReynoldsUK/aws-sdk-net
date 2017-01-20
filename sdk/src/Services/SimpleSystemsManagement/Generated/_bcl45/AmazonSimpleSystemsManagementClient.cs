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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.SimpleSystemsManagement.Model;
using Amazon.SimpleSystemsManagement.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.SimpleSystemsManagement
{
    /// <summary>
    /// Implementation for accessing SimpleSystemsManagement
    ///
    /// Amazon EC2 Systems Manager is a collection of capabilities that helps you automate
    /// management tasks such as collecting system inventory, applying operating system (OS)
    /// patches, automating the creation of Amazon Machine Images (AMIs), and configuring
    /// operating systems (OSs) and applications at scale. Systems Manager works with managed
    /// instances: Amazon EC2 instances and servers or virtual machines (VMs) in your on-premises
    /// environment that are configured for Systems Manager. 
    /// 
    ///  
    /// <para>
    /// This references is intended to be used with the EC2 Systems Manager User Guide (<a
    /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/systems-manager.html">Linux</a>)
    /// (<a href="http://docs.aws.amazon.com/AWSEC2/latest/WindowsGuide/systems-manager.html">Windows</a>).
    /// </para>
    ///  
    /// <para>
    /// To get started, verify prerequisites and configure managed instances (<a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/systems-manager-prereqs.html">Linux</a>)
    /// (<a href="http://docs.aws.amazon.com/AWSEC2/latest/WindowsGuide/systems-manager-prereqs.html">Windows</a>).
    /// </para>
    /// </summary>
    public partial class AmazonSimpleSystemsManagementClient : AmazonServiceClient, IAmazonSimpleSystemsManagement
    {
        #region Constructors

        /// <summary>
        /// Constructs AmazonSimpleSystemsManagementClient with the credentials loaded from the application's
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
        public AmazonSimpleSystemsManagementClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSimpleSystemsManagementConfig()) { }

        /// <summary>
        /// Constructs AmazonSimpleSystemsManagementClient with the credentials loaded from the application's
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
        public AmazonSimpleSystemsManagementClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSimpleSystemsManagementConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonSimpleSystemsManagementClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonSimpleSystemsManagementClient Configuration Object</param>
        public AmazonSimpleSystemsManagementClient(AmazonSimpleSystemsManagementConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonSimpleSystemsManagementClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSimpleSystemsManagementClient(AWSCredentials credentials)
            : this(credentials, new AmazonSimpleSystemsManagementConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleSystemsManagementClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSimpleSystemsManagementClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSimpleSystemsManagementConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleSystemsManagementClient with AWS Credentials and an
        /// AmazonSimpleSystemsManagementClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSimpleSystemsManagementClient Configuration Object</param>
        public AmazonSimpleSystemsManagementClient(AWSCredentials credentials, AmazonSimpleSystemsManagementConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleSystemsManagementClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSimpleSystemsManagementClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSimpleSystemsManagementConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleSystemsManagementClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSimpleSystemsManagementClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSimpleSystemsManagementConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleSystemsManagementClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSimpleSystemsManagementClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSimpleSystemsManagementClient Configuration Object</param>
        public AmazonSimpleSystemsManagementClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSimpleSystemsManagementConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleSystemsManagementClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonSimpleSystemsManagementClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSimpleSystemsManagementConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleSystemsManagementClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSimpleSystemsManagementClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSimpleSystemsManagementConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleSystemsManagementClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSimpleSystemsManagementClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSimpleSystemsManagementClient Configuration Object</param>
        public AmazonSimpleSystemsManagementClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSimpleSystemsManagementConfig clientConfig)
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

        
        #region  AddTagsToResource


        /// <summary>
        /// Adds or overwrites one or more tags for the specified resource. Tags are metadata
        /// that you assign to your managed instances. Tags enable you to categorize your managed
        /// instances in different ways, for example, by purpose, owner, or environment. Each
        /// tag consists of a key and an optional value, both of which you define. For example,
        /// you could define a set of tags for your account's managed instances that helps you
        /// track each instance's owner and stack level. For example: Key=Owner and Value=DbAdmin,
        /// SysAdmin, or Dev. Or Key=Stack and Value=Production, Pre-Production, or Test. Each
        /// resource can have a maximum of 10 tags. 
        /// 
        ///  
        /// <para>
        /// We recommend that you devise a set of tag keys that meets your needs for each resource
        /// type. Using a consistent set of tag keys makes it easier for you to manage your resources.
        /// You can search and filter the resources based on the tags you add. Tags don't have
        /// any semantic meaning to Amazon EC2 and are interpreted strictly as a string of characters.
        /// 
        /// </para>
        ///  
        /// <para>
        /// For more information about tags, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html">Tagging
        /// Your Amazon EC2 Resources</a> in the Amazon EC2 User Guide. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToResource service method.</param>
        /// 
        /// <returns>The response from the AddTagsToResource service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidResourceIdException">
        /// The resource ID is not valid. Verify that you entered the correct ID and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidResourceTypeException">
        /// The resource type is not valid. If you are attempting to tag an instance, the instance
        /// must be a registered, managed instance.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TooManyTagsErrorException">
        /// The <code>Targets</code> parameter includes too many tags. Remove one or more tags
        /// and try the command again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/AddTagsToResource">REST API Reference for AddTagsToResource Operation</seealso>
        public AddTagsToResourceResponse AddTagsToResource(AddTagsToResourceRequest request)
        {
            var marshaller = new AddTagsToResourceRequestMarshaller();
            var unmarshaller = AddTagsToResourceResponseUnmarshaller.Instance;

            return Invoke<AddTagsToResourceRequest,AddTagsToResourceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddTagsToResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/AddTagsToResource">REST API Reference for AddTagsToResource Operation</seealso>
        public Task<AddTagsToResourceResponse> AddTagsToResourceAsync(AddTagsToResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AddTagsToResourceRequestMarshaller();
            var unmarshaller = AddTagsToResourceResponseUnmarshaller.Instance;

            return InvokeAsync<AddTagsToResourceRequest,AddTagsToResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CancelCommand


        /// <summary>
        /// Attempts to cancel the command specified by the Command ID. There is no guarantee
        /// that the command will be terminated and the underlying process stopped.
        /// </summary>
        /// <param name="commandId">The ID of the command you want to cancel.</param>
        /// 
        /// <returns>The response from the CancelCommand service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DuplicateInstanceIdException">
        /// You cannot specify an instance ID in more than one association.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidCommandIdException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  
        /// <para>
        /// You do not have permission to access the instance.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent is not running. On managed instances and Linux instances, verify that
        /// the SSM agent is running. On EC2 Windows instances, verify that the EC2Config service
        /// is running.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent or EC2Config service is not registered to the SSM endpoint. Try reinstalling
        /// the SSM agent or EC2Config service.
        /// </para>
        ///  
        /// <para>
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CancelCommand">REST API Reference for CancelCommand Operation</seealso>
        public CancelCommandResponse CancelCommand(string commandId)
        {
            var request = new CancelCommandRequest();
            request.CommandId = commandId;
            return CancelCommand(request);
        }


        /// <summary>
        /// Attempts to cancel the command specified by the Command ID. There is no guarantee
        /// that the command will be terminated and the underlying process stopped.
        /// </summary>
        /// <param name="commandId">The ID of the command you want to cancel.</param>
        /// <param name="instanceIds">(Optional) A list of instance IDs on which you want to cancel the command. If not provided, the command is canceled on every instance on which it was requested.</param>
        /// 
        /// <returns>The response from the CancelCommand service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DuplicateInstanceIdException">
        /// You cannot specify an instance ID in more than one association.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidCommandIdException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  
        /// <para>
        /// You do not have permission to access the instance.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent is not running. On managed instances and Linux instances, verify that
        /// the SSM agent is running. On EC2 Windows instances, verify that the EC2Config service
        /// is running.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent or EC2Config service is not registered to the SSM endpoint. Try reinstalling
        /// the SSM agent or EC2Config service.
        /// </para>
        ///  
        /// <para>
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CancelCommand">REST API Reference for CancelCommand Operation</seealso>
        public CancelCommandResponse CancelCommand(string commandId, List<string> instanceIds)
        {
            var request = new CancelCommandRequest();
            request.CommandId = commandId;
            request.InstanceIds = instanceIds;
            return CancelCommand(request);
        }


        /// <summary>
        /// Attempts to cancel the command specified by the Command ID. There is no guarantee
        /// that the command will be terminated and the underlying process stopped.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelCommand service method.</param>
        /// 
        /// <returns>The response from the CancelCommand service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DuplicateInstanceIdException">
        /// You cannot specify an instance ID in more than one association.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidCommandIdException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  
        /// <para>
        /// You do not have permission to access the instance.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent is not running. On managed instances and Linux instances, verify that
        /// the SSM agent is running. On EC2 Windows instances, verify that the EC2Config service
        /// is running.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent or EC2Config service is not registered to the SSM endpoint. Try reinstalling
        /// the SSM agent or EC2Config service.
        /// </para>
        ///  
        /// <para>
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CancelCommand">REST API Reference for CancelCommand Operation</seealso>
        public CancelCommandResponse CancelCommand(CancelCommandRequest request)
        {
            var marshaller = new CancelCommandRequestMarshaller();
            var unmarshaller = CancelCommandResponseUnmarshaller.Instance;

            return Invoke<CancelCommandRequest,CancelCommandResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Attempts to cancel the command specified by the Command ID. There is no guarantee
        /// that the command will be terminated and the underlying process stopped.
        /// </summary>
        /// <param name="commandId">The ID of the command you want to cancel.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelCommand service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DuplicateInstanceIdException">
        /// You cannot specify an instance ID in more than one association.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidCommandIdException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  
        /// <para>
        /// You do not have permission to access the instance.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent is not running. On managed instances and Linux instances, verify that
        /// the SSM agent is running. On EC2 Windows instances, verify that the EC2Config service
        /// is running.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent or EC2Config service is not registered to the SSM endpoint. Try reinstalling
        /// the SSM agent or EC2Config service.
        /// </para>
        ///  
        /// <para>
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CancelCommand">REST API Reference for CancelCommand Operation</seealso>
        public Task<CancelCommandResponse> CancelCommandAsync(string commandId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new CancelCommandRequest();
            request.CommandId = commandId;
            return CancelCommandAsync(request, cancellationToken);
        }


        /// <summary>
        /// Attempts to cancel the command specified by the Command ID. There is no guarantee
        /// that the command will be terminated and the underlying process stopped.
        /// </summary>
        /// <param name="commandId">The ID of the command you want to cancel.</param>
        /// <param name="instanceIds">(Optional) A list of instance IDs on which you want to cancel the command. If not provided, the command is canceled on every instance on which it was requested.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelCommand service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DuplicateInstanceIdException">
        /// You cannot specify an instance ID in more than one association.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidCommandIdException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  
        /// <para>
        /// You do not have permission to access the instance.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent is not running. On managed instances and Linux instances, verify that
        /// the SSM agent is running. On EC2 Windows instances, verify that the EC2Config service
        /// is running.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent or EC2Config service is not registered to the SSM endpoint. Try reinstalling
        /// the SSM agent or EC2Config service.
        /// </para>
        ///  
        /// <para>
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CancelCommand">REST API Reference for CancelCommand Operation</seealso>
        public Task<CancelCommandResponse> CancelCommandAsync(string commandId, List<string> instanceIds, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new CancelCommandRequest();
            request.CommandId = commandId;
            request.InstanceIds = instanceIds;
            return CancelCommandAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelCommand operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelCommand operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CancelCommand">REST API Reference for CancelCommand Operation</seealso>
        public Task<CancelCommandResponse> CancelCommandAsync(CancelCommandRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CancelCommandRequestMarshaller();
            var unmarshaller = CancelCommandResponseUnmarshaller.Instance;

            return InvokeAsync<CancelCommandRequest,CancelCommandResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateActivation


        /// <summary>
        /// Registers your on-premises server or virtual machine with Amazon EC2 so that you can
        /// manage these resources using Run Command. An on-premises server or virtual machine
        /// that has been registered with EC2 is called a managed instance. For more information
        /// about activations, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/managed-instances.html">Setting
        /// Up Managed Instances (Linux)</a> or <a href="http://docs.aws.amazon.com/AWSEC2/latest/WindowsGuide/managed-instances.html">Setting
        /// Up Managed Instances (Windows)</a> in the Amazon EC2 User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateActivation service method.</param>
        /// 
        /// <returns>The response from the CreateActivation service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateActivation">REST API Reference for CreateActivation Operation</seealso>
        public CreateActivationResponse CreateActivation(CreateActivationRequest request)
        {
            var marshaller = new CreateActivationRequestMarshaller();
            var unmarshaller = CreateActivationResponseUnmarshaller.Instance;

            return Invoke<CreateActivationRequest,CreateActivationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateActivation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateActivation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateActivation">REST API Reference for CreateActivation Operation</seealso>
        public Task<CreateActivationResponse> CreateActivationAsync(CreateActivationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateActivationRequestMarshaller();
            var unmarshaller = CreateActivationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateActivationRequest,CreateActivationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateAssociation


        /// <summary>
        /// Associates the specified SSM document with the specified instances or targets.
        /// 
        ///  
        /// <para>
        /// When you associate an SSM document with one or more instances using instance IDs or
        /// tags, the SSM agent running on the instance processes the document and configures
        /// the instance as specified.
        /// </para>
        ///  
        /// <para>
        /// If you associate a document with an instance that already has an associated document,
        /// the system throws the AssociationAlreadyExists exception.
        /// </para>
        /// </summary>
        /// <param name="instanceId">The instance ID.</param>
        /// <param name="name">The name of the SSM document.</param>
        /// 
        /// <returns>The response from the CreateAssociation service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationAlreadyExistsException">
        /// The specified association already exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationLimitExceededException">
        /// You can have at most 2,000 active associations.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified document does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentVersionException">
        /// The document version is not valid or does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  
        /// <para>
        /// You do not have permission to access the instance.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent is not running. On managed instances and Linux instances, verify that
        /// the SSM agent is running. On EC2 Windows instances, verify that the EC2Config service
        /// is running.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent or EC2Config service is not registered to the SSM endpoint. Try reinstalling
        /// the SSM agent or EC2Config service.
        /// </para>
        ///  
        /// <para>
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidOutputLocationException">
        /// The output location is not valid or does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidParametersException">
        /// You must specify values for all required parameters in the SSM document. You can only
        /// supply values to parameters defined in the SSM document.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidScheduleException">
        /// The schedule is invalid. Verify your cron or rate expression and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidTargetException">
        /// The target is not valid or does not exist. It might not be configured for EC2 Systems
        /// Manager or you might not have permission to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.UnsupportedPlatformTypeException">
        /// The document does not support the platform type of the given instance ID(s). For example,
        /// you sent an SSM document for a Windows instance to a Linux instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateAssociation">REST API Reference for CreateAssociation Operation</seealso>
        public CreateAssociationResponse CreateAssociation(string instanceId, string name)
        {
            var request = new CreateAssociationRequest();
            request.InstanceId = instanceId;
            request.Name = name;
            return CreateAssociation(request);
        }


        /// <summary>
        /// Associates the specified SSM document with the specified instances or targets.
        /// 
        ///  
        /// <para>
        /// When you associate an SSM document with one or more instances using instance IDs or
        /// tags, the SSM agent running on the instance processes the document and configures
        /// the instance as specified.
        /// </para>
        ///  
        /// <para>
        /// If you associate a document with an instance that already has an associated document,
        /// the system throws the AssociationAlreadyExists exception.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAssociation service method.</param>
        /// 
        /// <returns>The response from the CreateAssociation service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationAlreadyExistsException">
        /// The specified association already exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationLimitExceededException">
        /// You can have at most 2,000 active associations.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified document does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentVersionException">
        /// The document version is not valid or does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  
        /// <para>
        /// You do not have permission to access the instance.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent is not running. On managed instances and Linux instances, verify that
        /// the SSM agent is running. On EC2 Windows instances, verify that the EC2Config service
        /// is running.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent or EC2Config service is not registered to the SSM endpoint. Try reinstalling
        /// the SSM agent or EC2Config service.
        /// </para>
        ///  
        /// <para>
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidOutputLocationException">
        /// The output location is not valid or does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidParametersException">
        /// You must specify values for all required parameters in the SSM document. You can only
        /// supply values to parameters defined in the SSM document.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidScheduleException">
        /// The schedule is invalid. Verify your cron or rate expression and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidTargetException">
        /// The target is not valid or does not exist. It might not be configured for EC2 Systems
        /// Manager or you might not have permission to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.UnsupportedPlatformTypeException">
        /// The document does not support the platform type of the given instance ID(s). For example,
        /// you sent an SSM document for a Windows instance to a Linux instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateAssociation">REST API Reference for CreateAssociation Operation</seealso>
        public CreateAssociationResponse CreateAssociation(CreateAssociationRequest request)
        {
            var marshaller = new CreateAssociationRequestMarshaller();
            var unmarshaller = CreateAssociationResponseUnmarshaller.Instance;

            return Invoke<CreateAssociationRequest,CreateAssociationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Associates the specified SSM document with the specified instances or targets.
        /// 
        ///  
        /// <para>
        /// When you associate an SSM document with one or more instances using instance IDs or
        /// tags, the SSM agent running on the instance processes the document and configures
        /// the instance as specified.
        /// </para>
        ///  
        /// <para>
        /// If you associate a document with an instance that already has an associated document,
        /// the system throws the AssociationAlreadyExists exception.
        /// </para>
        /// </summary>
        /// <param name="instanceId">The instance ID.</param>
        /// <param name="name">The name of the SSM document.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAssociation service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationAlreadyExistsException">
        /// The specified association already exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationLimitExceededException">
        /// You can have at most 2,000 active associations.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified document does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentVersionException">
        /// The document version is not valid or does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  
        /// <para>
        /// You do not have permission to access the instance.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent is not running. On managed instances and Linux instances, verify that
        /// the SSM agent is running. On EC2 Windows instances, verify that the EC2Config service
        /// is running.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent or EC2Config service is not registered to the SSM endpoint. Try reinstalling
        /// the SSM agent or EC2Config service.
        /// </para>
        ///  
        /// <para>
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidOutputLocationException">
        /// The output location is not valid or does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidParametersException">
        /// You must specify values for all required parameters in the SSM document. You can only
        /// supply values to parameters defined in the SSM document.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidScheduleException">
        /// The schedule is invalid. Verify your cron or rate expression and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidTargetException">
        /// The target is not valid or does not exist. It might not be configured for EC2 Systems
        /// Manager or you might not have permission to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.UnsupportedPlatformTypeException">
        /// The document does not support the platform type of the given instance ID(s). For example,
        /// you sent an SSM document for a Windows instance to a Linux instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateAssociation">REST API Reference for CreateAssociation Operation</seealso>
        public Task<CreateAssociationResponse> CreateAssociationAsync(string instanceId, string name, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new CreateAssociationRequest();
            request.InstanceId = instanceId;
            request.Name = name;
            return CreateAssociationAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAssociation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateAssociation">REST API Reference for CreateAssociation Operation</seealso>
        public Task<CreateAssociationResponse> CreateAssociationAsync(CreateAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateAssociationRequestMarshaller();
            var unmarshaller = CreateAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAssociationRequest,CreateAssociationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateAssociationBatch


        /// <summary>
        /// Associates the specified SSM document with the specified instances or targets.
        /// 
        ///  
        /// <para>
        /// When you associate an SSM document with one or more instances using instance IDs or
        /// tags, the SSM agent running on the instance processes the document and configures
        /// the instance as specified.
        /// </para>
        ///  
        /// <para>
        /// If you associate a document with an instance that already has an associated document,
        /// the system throws the AssociationAlreadyExists exception.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAssociationBatch service method.</param>
        /// 
        /// <returns>The response from the CreateAssociationBatch service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationLimitExceededException">
        /// You can have at most 2,000 active associations.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DuplicateInstanceIdException">
        /// You cannot specify an instance ID in more than one association.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified document does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentVersionException">
        /// The document version is not valid or does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  
        /// <para>
        /// You do not have permission to access the instance.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent is not running. On managed instances and Linux instances, verify that
        /// the SSM agent is running. On EC2 Windows instances, verify that the EC2Config service
        /// is running.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent or EC2Config service is not registered to the SSM endpoint. Try reinstalling
        /// the SSM agent or EC2Config service.
        /// </para>
        ///  
        /// <para>
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidOutputLocationException">
        /// The output location is not valid or does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidParametersException">
        /// You must specify values for all required parameters in the SSM document. You can only
        /// supply values to parameters defined in the SSM document.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidScheduleException">
        /// The schedule is invalid. Verify your cron or rate expression and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidTargetException">
        /// The target is not valid or does not exist. It might not be configured for EC2 Systems
        /// Manager or you might not have permission to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.UnsupportedPlatformTypeException">
        /// The document does not support the platform type of the given instance ID(s). For example,
        /// you sent an SSM document for a Windows instance to a Linux instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateAssociationBatch">REST API Reference for CreateAssociationBatch Operation</seealso>
        public CreateAssociationBatchResponse CreateAssociationBatch(CreateAssociationBatchRequest request)
        {
            var marshaller = new CreateAssociationBatchRequestMarshaller();
            var unmarshaller = CreateAssociationBatchResponseUnmarshaller.Instance;

            return Invoke<CreateAssociationBatchRequest,CreateAssociationBatchResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAssociationBatch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAssociationBatch operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateAssociationBatch">REST API Reference for CreateAssociationBatch Operation</seealso>
        public Task<CreateAssociationBatchResponse> CreateAssociationBatchAsync(CreateAssociationBatchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateAssociationBatchRequestMarshaller();
            var unmarshaller = CreateAssociationBatchResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAssociationBatchRequest,CreateAssociationBatchResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateDocument


        /// <summary>
        /// Creates an SSM document.
        /// 
        ///  
        /// <para>
        /// After you create an SSM document, you can use CreateAssociation to associate it with
        /// one or more running instances.
        /// </para>
        /// </summary>
        /// <param name="content">A valid JSON string.</param>
        /// <param name="name">A name for the SSM document.</param>
        /// 
        /// <returns>The response from the CreateDocument service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DocumentAlreadyExistsException">
        /// The specified SSM document already exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DocumentLimitExceededException">
        /// You can have at most 200 active SSM documents.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentContentException">
        /// The content for the SSM document is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentSchemaVersionException">
        /// The version of the document schema is not supported.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.MaxDocumentSizeExceededException">
        /// The size limit of an SSM document is 64 KB.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateDocument">REST API Reference for CreateDocument Operation</seealso>
        public CreateDocumentResponse CreateDocument(string content, string name)
        {
            var request = new CreateDocumentRequest();
            request.Content = content;
            request.Name = name;
            return CreateDocument(request);
        }


        /// <summary>
        /// Creates an SSM document.
        /// 
        ///  
        /// <para>
        /// After you create an SSM document, you can use CreateAssociation to associate it with
        /// one or more running instances.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDocument service method.</param>
        /// 
        /// <returns>The response from the CreateDocument service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DocumentAlreadyExistsException">
        /// The specified SSM document already exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DocumentLimitExceededException">
        /// You can have at most 200 active SSM documents.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentContentException">
        /// The content for the SSM document is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentSchemaVersionException">
        /// The version of the document schema is not supported.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.MaxDocumentSizeExceededException">
        /// The size limit of an SSM document is 64 KB.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateDocument">REST API Reference for CreateDocument Operation</seealso>
        public CreateDocumentResponse CreateDocument(CreateDocumentRequest request)
        {
            var marshaller = new CreateDocumentRequestMarshaller();
            var unmarshaller = CreateDocumentResponseUnmarshaller.Instance;

            return Invoke<CreateDocumentRequest,CreateDocumentResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Creates an SSM document.
        /// 
        ///  
        /// <para>
        /// After you create an SSM document, you can use CreateAssociation to associate it with
        /// one or more running instances.
        /// </para>
        /// </summary>
        /// <param name="content">A valid JSON string.</param>
        /// <param name="name">A name for the SSM document.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDocument service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DocumentAlreadyExistsException">
        /// The specified SSM document already exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DocumentLimitExceededException">
        /// You can have at most 200 active SSM documents.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentContentException">
        /// The content for the SSM document is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentSchemaVersionException">
        /// The version of the document schema is not supported.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.MaxDocumentSizeExceededException">
        /// The size limit of an SSM document is 64 KB.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateDocument">REST API Reference for CreateDocument Operation</seealso>
        public Task<CreateDocumentResponse> CreateDocumentAsync(string content, string name, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new CreateDocumentRequest();
            request.Content = content;
            request.Name = name;
            return CreateDocumentAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDocument operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDocument operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateDocument">REST API Reference for CreateDocument Operation</seealso>
        public Task<CreateDocumentResponse> CreateDocumentAsync(CreateDocumentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateDocumentRequestMarshaller();
            var unmarshaller = CreateDocumentResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDocumentRequest,CreateDocumentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateMaintenanceWindow


        /// <summary>
        /// Creates a new Maintenance Window.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMaintenanceWindow service method.</param>
        /// 
        /// <returns>The response from the CreateMaintenanceWindow service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.IdempotentParameterMismatchException">
        /// Error returned when an idempotent operation is retried and the parameters don’t match
        /// the original call to the API with the same idempotency token.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourceLimitExceededException">
        /// Error returned when the caller has exceeded the default resource limits (e.g. too
        /// many Maintenance Windows have been created).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateMaintenanceWindow">REST API Reference for CreateMaintenanceWindow Operation</seealso>
        public CreateMaintenanceWindowResponse CreateMaintenanceWindow(CreateMaintenanceWindowRequest request)
        {
            var marshaller = new CreateMaintenanceWindowRequestMarshaller();
            var unmarshaller = CreateMaintenanceWindowResponseUnmarshaller.Instance;

            return Invoke<CreateMaintenanceWindowRequest,CreateMaintenanceWindowResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateMaintenanceWindow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMaintenanceWindow operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateMaintenanceWindow">REST API Reference for CreateMaintenanceWindow Operation</seealso>
        public Task<CreateMaintenanceWindowResponse> CreateMaintenanceWindowAsync(CreateMaintenanceWindowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateMaintenanceWindowRequestMarshaller();
            var unmarshaller = CreateMaintenanceWindowResponseUnmarshaller.Instance;

            return InvokeAsync<CreateMaintenanceWindowRequest,CreateMaintenanceWindowResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreatePatchBaseline


        /// <summary>
        /// Creates a patch baseline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePatchBaseline service method.</param>
        /// 
        /// <returns>The response from the CreatePatchBaseline service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.IdempotentParameterMismatchException">
        /// Error returned when an idempotent operation is retried and the parameters don’t match
        /// the original call to the API with the same idempotency token.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourceLimitExceededException">
        /// Error returned when the caller has exceeded the default resource limits (e.g. too
        /// many Maintenance Windows have been created).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreatePatchBaseline">REST API Reference for CreatePatchBaseline Operation</seealso>
        public CreatePatchBaselineResponse CreatePatchBaseline(CreatePatchBaselineRequest request)
        {
            var marshaller = new CreatePatchBaselineRequestMarshaller();
            var unmarshaller = CreatePatchBaselineResponseUnmarshaller.Instance;

            return Invoke<CreatePatchBaselineRequest,CreatePatchBaselineResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePatchBaseline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePatchBaseline operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreatePatchBaseline">REST API Reference for CreatePatchBaseline Operation</seealso>
        public Task<CreatePatchBaselineResponse> CreatePatchBaselineAsync(CreatePatchBaselineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreatePatchBaselineRequestMarshaller();
            var unmarshaller = CreatePatchBaselineResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePatchBaselineRequest,CreatePatchBaselineResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteActivation


        /// <summary>
        /// Deletes an activation. You are not required to delete an activation. If you delete
        /// an activation, you can no longer use it to register additional managed instances.
        /// Deleting an activation does not de-register managed instances. You must manually de-register
        /// managed instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteActivation service method.</param>
        /// 
        /// <returns>The response from the DeleteActivation service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidActivationException">
        /// The activation is not valid. The activation might have been deleted, or the ActivationId
        /// and the ActivationCode do not match.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidActivationIdException">
        /// The activation ID is not valid. Verify the you entered the correct ActivationId or
        /// ActivationCode and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteActivation">REST API Reference for DeleteActivation Operation</seealso>
        public DeleteActivationResponse DeleteActivation(DeleteActivationRequest request)
        {
            var marshaller = new DeleteActivationRequestMarshaller();
            var unmarshaller = DeleteActivationResponseUnmarshaller.Instance;

            return Invoke<DeleteActivationRequest,DeleteActivationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteActivation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteActivation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteActivation">REST API Reference for DeleteActivation Operation</seealso>
        public Task<DeleteActivationResponse> DeleteActivationAsync(DeleteActivationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteActivationRequestMarshaller();
            var unmarshaller = DeleteActivationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteActivationRequest,DeleteActivationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteAssociation


        /// <summary>
        /// Disassociates the specified SSM document from the specified instance.
        /// 
        ///  
        /// <para>
        /// When you disassociate an SSM document from an instance, it does not change the configuration
        /// of the instance. To change the configuration state of an instance after you disassociate
        /// a document, you must create a new document with the desired configuration and associate
        /// it with the instance.
        /// </para>
        /// </summary>
        /// <param name="instanceId">The ID of the instance.</param>
        /// <param name="name">The name of the SSM document.</param>
        /// 
        /// <returns>The response from the DeleteAssociation service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationDoesNotExistException">
        /// The specified association does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified document does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  
        /// <para>
        /// You do not have permission to access the instance.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent is not running. On managed instances and Linux instances, verify that
        /// the SSM agent is running. On EC2 Windows instances, verify that the EC2Config service
        /// is running.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent or EC2Config service is not registered to the SSM endpoint. Try reinstalling
        /// the SSM agent or EC2Config service.
        /// </para>
        ///  
        /// <para>
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TooManyUpdatesException">
        /// There are concurrent updates for a resource that supports one update at a time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteAssociation">REST API Reference for DeleteAssociation Operation</seealso>
        public DeleteAssociationResponse DeleteAssociation(string instanceId, string name)
        {
            var request = new DeleteAssociationRequest();
            request.InstanceId = instanceId;
            request.Name = name;
            return DeleteAssociation(request);
        }


        /// <summary>
        /// Disassociates the specified SSM document from the specified instance.
        /// 
        ///  
        /// <para>
        /// When you disassociate an SSM document from an instance, it does not change the configuration
        /// of the instance. To change the configuration state of an instance after you disassociate
        /// a document, you must create a new document with the desired configuration and associate
        /// it with the instance.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssociation service method.</param>
        /// 
        /// <returns>The response from the DeleteAssociation service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationDoesNotExistException">
        /// The specified association does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified document does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  
        /// <para>
        /// You do not have permission to access the instance.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent is not running. On managed instances and Linux instances, verify that
        /// the SSM agent is running. On EC2 Windows instances, verify that the EC2Config service
        /// is running.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent or EC2Config service is not registered to the SSM endpoint. Try reinstalling
        /// the SSM agent or EC2Config service.
        /// </para>
        ///  
        /// <para>
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TooManyUpdatesException">
        /// There are concurrent updates for a resource that supports one update at a time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteAssociation">REST API Reference for DeleteAssociation Operation</seealso>
        public DeleteAssociationResponse DeleteAssociation(DeleteAssociationRequest request)
        {
            var marshaller = new DeleteAssociationRequestMarshaller();
            var unmarshaller = DeleteAssociationResponseUnmarshaller.Instance;

            return Invoke<DeleteAssociationRequest,DeleteAssociationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Disassociates the specified SSM document from the specified instance.
        /// 
        ///  
        /// <para>
        /// When you disassociate an SSM document from an instance, it does not change the configuration
        /// of the instance. To change the configuration state of an instance after you disassociate
        /// a document, you must create a new document with the desired configuration and associate
        /// it with the instance.
        /// </para>
        /// </summary>
        /// <param name="instanceId">The ID of the instance.</param>
        /// <param name="name">The name of the SSM document.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAssociation service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationDoesNotExistException">
        /// The specified association does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified document does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  
        /// <para>
        /// You do not have permission to access the instance.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent is not running. On managed instances and Linux instances, verify that
        /// the SSM agent is running. On EC2 Windows instances, verify that the EC2Config service
        /// is running.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent or EC2Config service is not registered to the SSM endpoint. Try reinstalling
        /// the SSM agent or EC2Config service.
        /// </para>
        ///  
        /// <para>
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TooManyUpdatesException">
        /// There are concurrent updates for a resource that supports one update at a time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteAssociation">REST API Reference for DeleteAssociation Operation</seealso>
        public Task<DeleteAssociationResponse> DeleteAssociationAsync(string instanceId, string name, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteAssociationRequest();
            request.InstanceId = instanceId;
            request.Name = name;
            return DeleteAssociationAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssociation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteAssociation">REST API Reference for DeleteAssociation Operation</seealso>
        public Task<DeleteAssociationResponse> DeleteAssociationAsync(DeleteAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteAssociationRequestMarshaller();
            var unmarshaller = DeleteAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAssociationRequest,DeleteAssociationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteDocument


        /// <summary>
        /// Deletes the SSM document and all instance associations to the document.
        /// 
        ///  
        /// <para>
        /// Before you delete the SSM document, we recommend that you use DeleteAssociation to
        /// disassociate all instances that are associated with the document.
        /// </para>
        /// </summary>
        /// <param name="name">The name of the SSM document.</param>
        /// 
        /// <returns>The response from the DeleteDocument service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociatedInstancesException">
        /// You must disassociate an SSM document from all instances before you can delete it.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified document does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentOperationException">
        /// You attempted to delete a document while it is still shared. You must stop sharing
        /// the document before you can delete it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteDocument">REST API Reference for DeleteDocument Operation</seealso>
        public DeleteDocumentResponse DeleteDocument(string name)
        {
            var request = new DeleteDocumentRequest();
            request.Name = name;
            return DeleteDocument(request);
        }


        /// <summary>
        /// Deletes the SSM document and all instance associations to the document.
        /// 
        ///  
        /// <para>
        /// Before you delete the SSM document, we recommend that you use DeleteAssociation to
        /// disassociate all instances that are associated with the document.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDocument service method.</param>
        /// 
        /// <returns>The response from the DeleteDocument service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociatedInstancesException">
        /// You must disassociate an SSM document from all instances before you can delete it.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified document does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentOperationException">
        /// You attempted to delete a document while it is still shared. You must stop sharing
        /// the document before you can delete it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteDocument">REST API Reference for DeleteDocument Operation</seealso>
        public DeleteDocumentResponse DeleteDocument(DeleteDocumentRequest request)
        {
            var marshaller = new DeleteDocumentRequestMarshaller();
            var unmarshaller = DeleteDocumentResponseUnmarshaller.Instance;

            return Invoke<DeleteDocumentRequest,DeleteDocumentResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Deletes the SSM document and all instance associations to the document.
        /// 
        ///  
        /// <para>
        /// Before you delete the SSM document, we recommend that you use DeleteAssociation to
        /// disassociate all instances that are associated with the document.
        /// </para>
        /// </summary>
        /// <param name="name">The name of the SSM document.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDocument service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociatedInstancesException">
        /// You must disassociate an SSM document from all instances before you can delete it.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified document does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentOperationException">
        /// You attempted to delete a document while it is still shared. You must stop sharing
        /// the document before you can delete it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteDocument">REST API Reference for DeleteDocument Operation</seealso>
        public Task<DeleteDocumentResponse> DeleteDocumentAsync(string name, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteDocumentRequest();
            request.Name = name;
            return DeleteDocumentAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDocument operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDocument operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteDocument">REST API Reference for DeleteDocument Operation</seealso>
        public Task<DeleteDocumentResponse> DeleteDocumentAsync(DeleteDocumentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteDocumentRequestMarshaller();
            var unmarshaller = DeleteDocumentResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDocumentRequest,DeleteDocumentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteMaintenanceWindow


        /// <summary>
        /// Deletes a Maintenance Window.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMaintenanceWindow service method.</param>
        /// 
        /// <returns>The response from the DeleteMaintenanceWindow service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteMaintenanceWindow">REST API Reference for DeleteMaintenanceWindow Operation</seealso>
        public DeleteMaintenanceWindowResponse DeleteMaintenanceWindow(DeleteMaintenanceWindowRequest request)
        {
            var marshaller = new DeleteMaintenanceWindowRequestMarshaller();
            var unmarshaller = DeleteMaintenanceWindowResponseUnmarshaller.Instance;

            return Invoke<DeleteMaintenanceWindowRequest,DeleteMaintenanceWindowResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMaintenanceWindow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMaintenanceWindow operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteMaintenanceWindow">REST API Reference for DeleteMaintenanceWindow Operation</seealso>
        public Task<DeleteMaintenanceWindowResponse> DeleteMaintenanceWindowAsync(DeleteMaintenanceWindowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteMaintenanceWindowRequestMarshaller();
            var unmarshaller = DeleteMaintenanceWindowResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteMaintenanceWindowRequest,DeleteMaintenanceWindowResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteParameter


        /// <summary>
        /// Delete a parameter from the system.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteParameter service method.</param>
        /// 
        /// <returns>The response from the DeleteParameter service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ParameterNotFoundException">
        /// The parameter could not be found. Verify the name and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteParameter">REST API Reference for DeleteParameter Operation</seealso>
        public DeleteParameterResponse DeleteParameter(DeleteParameterRequest request)
        {
            var marshaller = new DeleteParameterRequestMarshaller();
            var unmarshaller = DeleteParameterResponseUnmarshaller.Instance;

            return Invoke<DeleteParameterRequest,DeleteParameterResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteParameter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteParameter operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteParameter">REST API Reference for DeleteParameter Operation</seealso>
        public Task<DeleteParameterResponse> DeleteParameterAsync(DeleteParameterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteParameterRequestMarshaller();
            var unmarshaller = DeleteParameterResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteParameterRequest,DeleteParameterResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeletePatchBaseline


        /// <summary>
        /// Deletes a patch baseline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePatchBaseline service method.</param>
        /// 
        /// <returns>The response from the DeletePatchBaseline service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourceInUseException">
        /// Error returned if an attempt is made to delete a patch baseline that is registered
        /// for a patch group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeletePatchBaseline">REST API Reference for DeletePatchBaseline Operation</seealso>
        public DeletePatchBaselineResponse DeletePatchBaseline(DeletePatchBaselineRequest request)
        {
            var marshaller = new DeletePatchBaselineRequestMarshaller();
            var unmarshaller = DeletePatchBaselineResponseUnmarshaller.Instance;

            return Invoke<DeletePatchBaselineRequest,DeletePatchBaselineResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePatchBaseline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePatchBaseline operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeletePatchBaseline">REST API Reference for DeletePatchBaseline Operation</seealso>
        public Task<DeletePatchBaselineResponse> DeletePatchBaselineAsync(DeletePatchBaselineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeletePatchBaselineRequestMarshaller();
            var unmarshaller = DeletePatchBaselineResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePatchBaselineRequest,DeletePatchBaselineResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeregisterManagedInstance


        /// <summary>
        /// Removes the server or virtual machine from the list of registered servers. You can
        /// reregister the instance again at any time. If you don’t plan to use Run Command on
        /// the server, we suggest uninstalling the SSM agent first.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterManagedInstance service method.</param>
        /// 
        /// <returns>The response from the DeregisterManagedInstance service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  
        /// <para>
        /// You do not have permission to access the instance.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent is not running. On managed instances and Linux instances, verify that
        /// the SSM agent is running. On EC2 Windows instances, verify that the EC2Config service
        /// is running.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent or EC2Config service is not registered to the SSM endpoint. Try reinstalling
        /// the SSM agent or EC2Config service.
        /// </para>
        ///  
        /// <para>
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeregisterManagedInstance">REST API Reference for DeregisterManagedInstance Operation</seealso>
        public DeregisterManagedInstanceResponse DeregisterManagedInstance(DeregisterManagedInstanceRequest request)
        {
            var marshaller = new DeregisterManagedInstanceRequestMarshaller();
            var unmarshaller = DeregisterManagedInstanceResponseUnmarshaller.Instance;

            return Invoke<DeregisterManagedInstanceRequest,DeregisterManagedInstanceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterManagedInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterManagedInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeregisterManagedInstance">REST API Reference for DeregisterManagedInstance Operation</seealso>
        public Task<DeregisterManagedInstanceResponse> DeregisterManagedInstanceAsync(DeregisterManagedInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeregisterManagedInstanceRequestMarshaller();
            var unmarshaller = DeregisterManagedInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<DeregisterManagedInstanceRequest,DeregisterManagedInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeregisterPatchBaselineForPatchGroup


        /// <summary>
        /// Removes a patch group from a patch baseline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterPatchBaselineForPatchGroup service method.</param>
        /// 
        /// <returns>The response from the DeregisterPatchBaselineForPatchGroup service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidResourceIdException">
        /// The resource ID is not valid. Verify that you entered the correct ID and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeregisterPatchBaselineForPatchGroup">REST API Reference for DeregisterPatchBaselineForPatchGroup Operation</seealso>
        public DeregisterPatchBaselineForPatchGroupResponse DeregisterPatchBaselineForPatchGroup(DeregisterPatchBaselineForPatchGroupRequest request)
        {
            var marshaller = new DeregisterPatchBaselineForPatchGroupRequestMarshaller();
            var unmarshaller = DeregisterPatchBaselineForPatchGroupResponseUnmarshaller.Instance;

            return Invoke<DeregisterPatchBaselineForPatchGroupRequest,DeregisterPatchBaselineForPatchGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterPatchBaselineForPatchGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterPatchBaselineForPatchGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeregisterPatchBaselineForPatchGroup">REST API Reference for DeregisterPatchBaselineForPatchGroup Operation</seealso>
        public Task<DeregisterPatchBaselineForPatchGroupResponse> DeregisterPatchBaselineForPatchGroupAsync(DeregisterPatchBaselineForPatchGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeregisterPatchBaselineForPatchGroupRequestMarshaller();
            var unmarshaller = DeregisterPatchBaselineForPatchGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeregisterPatchBaselineForPatchGroupRequest,DeregisterPatchBaselineForPatchGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeregisterTargetFromMaintenanceWindow


        /// <summary>
        /// Removes a target from a Maintenance Window.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterTargetFromMaintenanceWindow service method.</param>
        /// 
        /// <returns>The response from the DeregisterTargetFromMaintenanceWindow service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource (e.g. a Maintenance Window) doesn’t
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeregisterTargetFromMaintenanceWindow">REST API Reference for DeregisterTargetFromMaintenanceWindow Operation</seealso>
        public DeregisterTargetFromMaintenanceWindowResponse DeregisterTargetFromMaintenanceWindow(DeregisterTargetFromMaintenanceWindowRequest request)
        {
            var marshaller = new DeregisterTargetFromMaintenanceWindowRequestMarshaller();
            var unmarshaller = DeregisterTargetFromMaintenanceWindowResponseUnmarshaller.Instance;

            return Invoke<DeregisterTargetFromMaintenanceWindowRequest,DeregisterTargetFromMaintenanceWindowResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterTargetFromMaintenanceWindow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterTargetFromMaintenanceWindow operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeregisterTargetFromMaintenanceWindow">REST API Reference for DeregisterTargetFromMaintenanceWindow Operation</seealso>
        public Task<DeregisterTargetFromMaintenanceWindowResponse> DeregisterTargetFromMaintenanceWindowAsync(DeregisterTargetFromMaintenanceWindowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeregisterTargetFromMaintenanceWindowRequestMarshaller();
            var unmarshaller = DeregisterTargetFromMaintenanceWindowResponseUnmarshaller.Instance;

            return InvokeAsync<DeregisterTargetFromMaintenanceWindowRequest,DeregisterTargetFromMaintenanceWindowResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeregisterTaskFromMaintenanceWindow


        /// <summary>
        /// Removes a task from a Maintenance Window.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterTaskFromMaintenanceWindow service method.</param>
        /// 
        /// <returns>The response from the DeregisterTaskFromMaintenanceWindow service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource (e.g. a Maintenance Window) doesn’t
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeregisterTaskFromMaintenanceWindow">REST API Reference for DeregisterTaskFromMaintenanceWindow Operation</seealso>
        public DeregisterTaskFromMaintenanceWindowResponse DeregisterTaskFromMaintenanceWindow(DeregisterTaskFromMaintenanceWindowRequest request)
        {
            var marshaller = new DeregisterTaskFromMaintenanceWindowRequestMarshaller();
            var unmarshaller = DeregisterTaskFromMaintenanceWindowResponseUnmarshaller.Instance;

            return Invoke<DeregisterTaskFromMaintenanceWindowRequest,DeregisterTaskFromMaintenanceWindowResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterTaskFromMaintenanceWindow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterTaskFromMaintenanceWindow operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeregisterTaskFromMaintenanceWindow">REST API Reference for DeregisterTaskFromMaintenanceWindow Operation</seealso>
        public Task<DeregisterTaskFromMaintenanceWindowResponse> DeregisterTaskFromMaintenanceWindowAsync(DeregisterTaskFromMaintenanceWindowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeregisterTaskFromMaintenanceWindowRequestMarshaller();
            var unmarshaller = DeregisterTaskFromMaintenanceWindowResponseUnmarshaller.Instance;

            return InvokeAsync<DeregisterTaskFromMaintenanceWindowRequest,DeregisterTaskFromMaintenanceWindowResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeActivations


        /// <summary>
        /// Details about the activation, including: the date and time the activation was created,
        /// the expiration date, the IAM role assigned to the instances in the activation, and
        /// the number of instances activated by this registration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeActivations service method.</param>
        /// 
        /// <returns>The response from the DescribeActivations service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterException">
        /// The filter name is not valid. Verify the you entered the correct name and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeActivations">REST API Reference for DescribeActivations Operation</seealso>
        public DescribeActivationsResponse DescribeActivations(DescribeActivationsRequest request)
        {
            var marshaller = new DescribeActivationsRequestMarshaller();
            var unmarshaller = DescribeActivationsResponseUnmarshaller.Instance;

            return Invoke<DescribeActivationsRequest,DescribeActivationsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeActivations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeActivations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeActivations">REST API Reference for DescribeActivations Operation</seealso>
        public Task<DescribeActivationsResponse> DescribeActivationsAsync(DescribeActivationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeActivationsRequestMarshaller();
            var unmarshaller = DescribeActivationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeActivationsRequest,DescribeActivationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeAssociation


        /// <summary>
        /// Describes the associations for the specified SSM document or instance.
        /// </summary>
        /// <param name="instanceId">The instance ID.</param>
        /// <param name="name">The name of the SSM document.</param>
        /// 
        /// <returns>The response from the DescribeAssociation service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationDoesNotExistException">
        /// The specified association does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified document does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  
        /// <para>
        /// You do not have permission to access the instance.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent is not running. On managed instances and Linux instances, verify that
        /// the SSM agent is running. On EC2 Windows instances, verify that the EC2Config service
        /// is running.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent or EC2Config service is not registered to the SSM endpoint. Try reinstalling
        /// the SSM agent or EC2Config service.
        /// </para>
        ///  
        /// <para>
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeAssociation">REST API Reference for DescribeAssociation Operation</seealso>
        public DescribeAssociationResponse DescribeAssociation(string instanceId, string name)
        {
            var request = new DescribeAssociationRequest();
            request.InstanceId = instanceId;
            request.Name = name;
            return DescribeAssociation(request);
        }


        /// <summary>
        /// Describes the associations for the specified SSM document or instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssociation service method.</param>
        /// 
        /// <returns>The response from the DescribeAssociation service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationDoesNotExistException">
        /// The specified association does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified document does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  
        /// <para>
        /// You do not have permission to access the instance.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent is not running. On managed instances and Linux instances, verify that
        /// the SSM agent is running. On EC2 Windows instances, verify that the EC2Config service
        /// is running.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent or EC2Config service is not registered to the SSM endpoint. Try reinstalling
        /// the SSM agent or EC2Config service.
        /// </para>
        ///  
        /// <para>
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeAssociation">REST API Reference for DescribeAssociation Operation</seealso>
        public DescribeAssociationResponse DescribeAssociation(DescribeAssociationRequest request)
        {
            var marshaller = new DescribeAssociationRequestMarshaller();
            var unmarshaller = DescribeAssociationResponseUnmarshaller.Instance;

            return Invoke<DescribeAssociationRequest,DescribeAssociationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Describes the associations for the specified SSM document or instance.
        /// </summary>
        /// <param name="instanceId">The instance ID.</param>
        /// <param name="name">The name of the SSM document.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAssociation service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationDoesNotExistException">
        /// The specified association does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified document does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  
        /// <para>
        /// You do not have permission to access the instance.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent is not running. On managed instances and Linux instances, verify that
        /// the SSM agent is running. On EC2 Windows instances, verify that the EC2Config service
        /// is running.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent or EC2Config service is not registered to the SSM endpoint. Try reinstalling
        /// the SSM agent or EC2Config service.
        /// </para>
        ///  
        /// <para>
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeAssociation">REST API Reference for DescribeAssociation Operation</seealso>
        public Task<DescribeAssociationResponse> DescribeAssociationAsync(string instanceId, string name, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DescribeAssociationRequest();
            request.InstanceId = instanceId;
            request.Name = name;
            return DescribeAssociationAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssociation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeAssociation">REST API Reference for DescribeAssociation Operation</seealso>
        public Task<DescribeAssociationResponse> DescribeAssociationAsync(DescribeAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeAssociationRequestMarshaller();
            var unmarshaller = DescribeAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAssociationRequest,DescribeAssociationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeAutomationExecutions


        /// <summary>
        /// Provides details about all active and terminated Automation executions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutomationExecutions service method.</param>
        /// 
        /// <returns>The response from the DescribeAutomationExecutions service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeAutomationExecutions">REST API Reference for DescribeAutomationExecutions Operation</seealso>
        public DescribeAutomationExecutionsResponse DescribeAutomationExecutions(DescribeAutomationExecutionsRequest request)
        {
            var marshaller = new DescribeAutomationExecutionsRequestMarshaller();
            var unmarshaller = DescribeAutomationExecutionsResponseUnmarshaller.Instance;

            return Invoke<DescribeAutomationExecutionsRequest,DescribeAutomationExecutionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAutomationExecutions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutomationExecutions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeAutomationExecutions">REST API Reference for DescribeAutomationExecutions Operation</seealso>
        public Task<DescribeAutomationExecutionsResponse> DescribeAutomationExecutionsAsync(DescribeAutomationExecutionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeAutomationExecutionsRequestMarshaller();
            var unmarshaller = DescribeAutomationExecutionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAutomationExecutionsRequest,DescribeAutomationExecutionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeAvailablePatches


        /// <summary>
        /// Lists all patches that could possibly be included in a patch baseline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAvailablePatches service method.</param>
        /// 
        /// <returns>The response from the DescribeAvailablePatches service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeAvailablePatches">REST API Reference for DescribeAvailablePatches Operation</seealso>
        public DescribeAvailablePatchesResponse DescribeAvailablePatches(DescribeAvailablePatchesRequest request)
        {
            var marshaller = new DescribeAvailablePatchesRequestMarshaller();
            var unmarshaller = DescribeAvailablePatchesResponseUnmarshaller.Instance;

            return Invoke<DescribeAvailablePatchesRequest,DescribeAvailablePatchesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAvailablePatches operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAvailablePatches operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeAvailablePatches">REST API Reference for DescribeAvailablePatches Operation</seealso>
        public Task<DescribeAvailablePatchesResponse> DescribeAvailablePatchesAsync(DescribeAvailablePatchesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeAvailablePatchesRequestMarshaller();
            var unmarshaller = DescribeAvailablePatchesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAvailablePatchesRequest,DescribeAvailablePatchesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeDocument


        /// <summary>
        /// Describes the specified SSM document.
        /// </summary>
        /// <param name="name">The name of the SSM document.</param>
        /// 
        /// <returns>The response from the DescribeDocument service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified document does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentVersionException">
        /// The document version is not valid or does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeDocument">REST API Reference for DescribeDocument Operation</seealso>
        public DescribeDocumentResponse DescribeDocument(string name)
        {
            var request = new DescribeDocumentRequest();
            request.Name = name;
            return DescribeDocument(request);
        }


        /// <summary>
        /// Describes the specified SSM document.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDocument service method.</param>
        /// 
        /// <returns>The response from the DescribeDocument service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified document does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentVersionException">
        /// The document version is not valid or does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeDocument">REST API Reference for DescribeDocument Operation</seealso>
        public DescribeDocumentResponse DescribeDocument(DescribeDocumentRequest request)
        {
            var marshaller = new DescribeDocumentRequestMarshaller();
            var unmarshaller = DescribeDocumentResponseUnmarshaller.Instance;

            return Invoke<DescribeDocumentRequest,DescribeDocumentResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Describes the specified SSM document.
        /// </summary>
        /// <param name="name">The name of the SSM document.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDocument service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified document does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentVersionException">
        /// The document version is not valid or does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeDocument">REST API Reference for DescribeDocument Operation</seealso>
        public Task<DescribeDocumentResponse> DescribeDocumentAsync(string name, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DescribeDocumentRequest();
            request.Name = name;
            return DescribeDocumentAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDocument operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDocument operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeDocument">REST API Reference for DescribeDocument Operation</seealso>
        public Task<DescribeDocumentResponse> DescribeDocumentAsync(DescribeDocumentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeDocumentRequestMarshaller();
            var unmarshaller = DescribeDocumentResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDocumentRequest,DescribeDocumentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeDocumentPermission


        /// <summary>
        /// Describes the permissions for an SSM document. If you created the document, you are
        /// the owner. If a document is shared, it can either be shared privately (by specifying
        /// a user’s AWS account ID) or publicly (<i>All</i>).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDocumentPermission service method.</param>
        /// 
        /// <returns>The response from the DescribeDocumentPermission service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified document does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidPermissionTypeException">
        /// The permission type is not supported. <i>Share</i> is the only supported permission
        /// type.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeDocumentPermission">REST API Reference for DescribeDocumentPermission Operation</seealso>
        public DescribeDocumentPermissionResponse DescribeDocumentPermission(DescribeDocumentPermissionRequest request)
        {
            var marshaller = new DescribeDocumentPermissionRequestMarshaller();
            var unmarshaller = DescribeDocumentPermissionResponseUnmarshaller.Instance;

            return Invoke<DescribeDocumentPermissionRequest,DescribeDocumentPermissionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDocumentPermission operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDocumentPermission operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeDocumentPermission">REST API Reference for DescribeDocumentPermission Operation</seealso>
        public Task<DescribeDocumentPermissionResponse> DescribeDocumentPermissionAsync(DescribeDocumentPermissionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeDocumentPermissionRequestMarshaller();
            var unmarshaller = DescribeDocumentPermissionResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDocumentPermissionRequest,DescribeDocumentPermissionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeEffectiveInstanceAssociations


        /// <summary>
        /// All associations for the instance(s).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEffectiveInstanceAssociations service method.</param>
        /// 
        /// <returns>The response from the DescribeEffectiveInstanceAssociations service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  
        /// <para>
        /// You do not have permission to access the instance.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent is not running. On managed instances and Linux instances, verify that
        /// the SSM agent is running. On EC2 Windows instances, verify that the EC2Config service
        /// is running.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent or EC2Config service is not registered to the SSM endpoint. Try reinstalling
        /// the SSM agent or EC2Config service.
        /// </para>
        ///  
        /// <para>
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeEffectiveInstanceAssociations">REST API Reference for DescribeEffectiveInstanceAssociations Operation</seealso>
        public DescribeEffectiveInstanceAssociationsResponse DescribeEffectiveInstanceAssociations(DescribeEffectiveInstanceAssociationsRequest request)
        {
            var marshaller = new DescribeEffectiveInstanceAssociationsRequestMarshaller();
            var unmarshaller = DescribeEffectiveInstanceAssociationsResponseUnmarshaller.Instance;

            return Invoke<DescribeEffectiveInstanceAssociationsRequest,DescribeEffectiveInstanceAssociationsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEffectiveInstanceAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEffectiveInstanceAssociations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeEffectiveInstanceAssociations">REST API Reference for DescribeEffectiveInstanceAssociations Operation</seealso>
        public Task<DescribeEffectiveInstanceAssociationsResponse> DescribeEffectiveInstanceAssociationsAsync(DescribeEffectiveInstanceAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeEffectiveInstanceAssociationsRequestMarshaller();
            var unmarshaller = DescribeEffectiveInstanceAssociationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEffectiveInstanceAssociationsRequest,DescribeEffectiveInstanceAssociationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeEffectivePatchesForPatchBaseline


        /// <summary>
        /// Retrieves the current effective patches (the patch and the approval state) for the
        /// specified patch baseline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEffectivePatchesForPatchBaseline service method.</param>
        /// 
        /// <returns>The response from the DescribeEffectivePatchesForPatchBaseline service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource (e.g. a Maintenance Window) doesn’t
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidResourceIdException">
        /// The resource ID is not valid. Verify that you entered the correct ID and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeEffectivePatchesForPatchBaseline">REST API Reference for DescribeEffectivePatchesForPatchBaseline Operation</seealso>
        public DescribeEffectivePatchesForPatchBaselineResponse DescribeEffectivePatchesForPatchBaseline(DescribeEffectivePatchesForPatchBaselineRequest request)
        {
            var marshaller = new DescribeEffectivePatchesForPatchBaselineRequestMarshaller();
            var unmarshaller = DescribeEffectivePatchesForPatchBaselineResponseUnmarshaller.Instance;

            return Invoke<DescribeEffectivePatchesForPatchBaselineRequest,DescribeEffectivePatchesForPatchBaselineResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEffectivePatchesForPatchBaseline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEffectivePatchesForPatchBaseline operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeEffectivePatchesForPatchBaseline">REST API Reference for DescribeEffectivePatchesForPatchBaseline Operation</seealso>
        public Task<DescribeEffectivePatchesForPatchBaselineResponse> DescribeEffectivePatchesForPatchBaselineAsync(DescribeEffectivePatchesForPatchBaselineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeEffectivePatchesForPatchBaselineRequestMarshaller();
            var unmarshaller = DescribeEffectivePatchesForPatchBaselineResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEffectivePatchesForPatchBaselineRequest,DescribeEffectivePatchesForPatchBaselineResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeInstanceAssociationsStatus


        /// <summary>
        /// The status of the associations for the instance(s).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceAssociationsStatus service method.</param>
        /// 
        /// <returns>The response from the DescribeInstanceAssociationsStatus service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  
        /// <para>
        /// You do not have permission to access the instance.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent is not running. On managed instances and Linux instances, verify that
        /// the SSM agent is running. On EC2 Windows instances, verify that the EC2Config service
        /// is running.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent or EC2Config service is not registered to the SSM endpoint. Try reinstalling
        /// the SSM agent or EC2Config service.
        /// </para>
        ///  
        /// <para>
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeInstanceAssociationsStatus">REST API Reference for DescribeInstanceAssociationsStatus Operation</seealso>
        public DescribeInstanceAssociationsStatusResponse DescribeInstanceAssociationsStatus(DescribeInstanceAssociationsStatusRequest request)
        {
            var marshaller = new DescribeInstanceAssociationsStatusRequestMarshaller();
            var unmarshaller = DescribeInstanceAssociationsStatusResponseUnmarshaller.Instance;

            return Invoke<DescribeInstanceAssociationsStatusRequest,DescribeInstanceAssociationsStatusResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInstanceAssociationsStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceAssociationsStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeInstanceAssociationsStatus">REST API Reference for DescribeInstanceAssociationsStatus Operation</seealso>
        public Task<DescribeInstanceAssociationsStatusResponse> DescribeInstanceAssociationsStatusAsync(DescribeInstanceAssociationsStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeInstanceAssociationsStatusRequestMarshaller();
            var unmarshaller = DescribeInstanceAssociationsStatusResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeInstanceAssociationsStatusRequest,DescribeInstanceAssociationsStatusResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeInstanceInformation


        /// <summary>
        /// Describes one or more of your instances. You can use this to get information about
        /// instances like the operating system platform, the SSM agent version (Linux), status
        /// etc. If you specify one or more instance IDs, it returns information for those instances.
        /// If you do not specify instance IDs, it returns information for all your instances.
        /// If you specify an instance ID that is not valid or an instance that you do not own,
        /// you receive an error.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeInstanceInformation service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterKeyException">
        /// The specified key is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  
        /// <para>
        /// You do not have permission to access the instance.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent is not running. On managed instances and Linux instances, verify that
        /// the SSM agent is running. On EC2 Windows instances, verify that the EC2Config service
        /// is running.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent or EC2Config service is not registered to the SSM endpoint. Try reinstalling
        /// the SSM agent or EC2Config service.
        /// </para>
        ///  
        /// <para>
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceInformationFilterValueException">
        /// The specified filter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeInstanceInformation">REST API Reference for DescribeInstanceInformation Operation</seealso>
        public DescribeInstanceInformationResponse DescribeInstanceInformation()
        {
            return DescribeInstanceInformation(new DescribeInstanceInformationRequest());
        }


        /// <summary>
        /// Describes one or more of your instances. You can use this to get information about
        /// instances like the operating system platform, the SSM agent version (Linux), status
        /// etc. If you specify one or more instance IDs, it returns information for those instances.
        /// If you do not specify instance IDs, it returns information for all your instances.
        /// If you specify an instance ID that is not valid or an instance that you do not own,
        /// you receive an error.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceInformation service method.</param>
        /// 
        /// <returns>The response from the DescribeInstanceInformation service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterKeyException">
        /// The specified key is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  
        /// <para>
        /// You do not have permission to access the instance.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent is not running. On managed instances and Linux instances, verify that
        /// the SSM agent is running. On EC2 Windows instances, verify that the EC2Config service
        /// is running.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent or EC2Config service is not registered to the SSM endpoint. Try reinstalling
        /// the SSM agent or EC2Config service.
        /// </para>
        ///  
        /// <para>
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceInformationFilterValueException">
        /// The specified filter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeInstanceInformation">REST API Reference for DescribeInstanceInformation Operation</seealso>
        public DescribeInstanceInformationResponse DescribeInstanceInformation(DescribeInstanceInformationRequest request)
        {
            var marshaller = new DescribeInstanceInformationRequestMarshaller();
            var unmarshaller = DescribeInstanceInformationResponseUnmarshaller.Instance;

            return Invoke<DescribeInstanceInformationRequest,DescribeInstanceInformationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Describes one or more of your instances. You can use this to get information about
        /// instances like the operating system platform, the SSM agent version (Linux), status
        /// etc. If you specify one or more instance IDs, it returns information for those instances.
        /// If you do not specify instance IDs, it returns information for all your instances.
        /// If you specify an instance ID that is not valid or an instance that you do not own,
        /// you receive an error.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInstanceInformation service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterKeyException">
        /// The specified key is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  
        /// <para>
        /// You do not have permission to access the instance.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent is not running. On managed instances and Linux instances, verify that
        /// the SSM agent is running. On EC2 Windows instances, verify that the EC2Config service
        /// is running.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent or EC2Config service is not registered to the SSM endpoint. Try reinstalling
        /// the SSM agent or EC2Config service.
        /// </para>
        ///  
        /// <para>
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceInformationFilterValueException">
        /// The specified filter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeInstanceInformation">REST API Reference for DescribeInstanceInformation Operation</seealso>
        public Task<DescribeInstanceInformationResponse> DescribeInstanceInformationAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeInstanceInformationAsync(new DescribeInstanceInformationRequest(), cancellationToken);
        }
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInstanceInformation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceInformation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeInstanceInformation">REST API Reference for DescribeInstanceInformation Operation</seealso>
        public Task<DescribeInstanceInformationResponse> DescribeInstanceInformationAsync(DescribeInstanceInformationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeInstanceInformationRequestMarshaller();
            var unmarshaller = DescribeInstanceInformationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeInstanceInformationRequest,DescribeInstanceInformationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeInstancePatches


        /// <summary>
        /// Retrieves information about the patches on the specified instance and their state
        /// relative to the patch baseline being used for the instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstancePatches service method.</param>
        /// 
        /// <returns>The response from the DescribeInstancePatches service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterException">
        /// The filter name is not valid. Verify the you entered the correct name and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  
        /// <para>
        /// You do not have permission to access the instance.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent is not running. On managed instances and Linux instances, verify that
        /// the SSM agent is running. On EC2 Windows instances, verify that the EC2Config service
        /// is running.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent or EC2Config service is not registered to the SSM endpoint. Try reinstalling
        /// the SSM agent or EC2Config service.
        /// </para>
        ///  
        /// <para>
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeInstancePatches">REST API Reference for DescribeInstancePatches Operation</seealso>
        public DescribeInstancePatchesResponse DescribeInstancePatches(DescribeInstancePatchesRequest request)
        {
            var marshaller = new DescribeInstancePatchesRequestMarshaller();
            var unmarshaller = DescribeInstancePatchesResponseUnmarshaller.Instance;

            return Invoke<DescribeInstancePatchesRequest,DescribeInstancePatchesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInstancePatches operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstancePatches operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeInstancePatches">REST API Reference for DescribeInstancePatches Operation</seealso>
        public Task<DescribeInstancePatchesResponse> DescribeInstancePatchesAsync(DescribeInstancePatchesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeInstancePatchesRequestMarshaller();
            var unmarshaller = DescribeInstancePatchesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeInstancePatchesRequest,DescribeInstancePatchesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeInstancePatchStates


        /// <summary>
        /// Retrieves the high-level patch state of one or more instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstancePatchStates service method.</param>
        /// 
        /// <returns>The response from the DescribeInstancePatchStates service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeInstancePatchStates">REST API Reference for DescribeInstancePatchStates Operation</seealso>
        public DescribeInstancePatchStatesResponse DescribeInstancePatchStates(DescribeInstancePatchStatesRequest request)
        {
            var marshaller = new DescribeInstancePatchStatesRequestMarshaller();
            var unmarshaller = DescribeInstancePatchStatesResponseUnmarshaller.Instance;

            return Invoke<DescribeInstancePatchStatesRequest,DescribeInstancePatchStatesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInstancePatchStates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstancePatchStates operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeInstancePatchStates">REST API Reference for DescribeInstancePatchStates Operation</seealso>
        public Task<DescribeInstancePatchStatesResponse> DescribeInstancePatchStatesAsync(DescribeInstancePatchStatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeInstancePatchStatesRequestMarshaller();
            var unmarshaller = DescribeInstancePatchStatesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeInstancePatchStatesRequest,DescribeInstancePatchStatesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeInstancePatchStatesForPatchGroup


        /// <summary>
        /// Retrieves the high-level patch state for the instances in the specified patch group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstancePatchStatesForPatchGroup service method.</param>
        /// 
        /// <returns>The response from the DescribeInstancePatchStatesForPatchGroup service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterException">
        /// The filter name is not valid. Verify the you entered the correct name and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeInstancePatchStatesForPatchGroup">REST API Reference for DescribeInstancePatchStatesForPatchGroup Operation</seealso>
        public DescribeInstancePatchStatesForPatchGroupResponse DescribeInstancePatchStatesForPatchGroup(DescribeInstancePatchStatesForPatchGroupRequest request)
        {
            var marshaller = new DescribeInstancePatchStatesForPatchGroupRequestMarshaller();
            var unmarshaller = DescribeInstancePatchStatesForPatchGroupResponseUnmarshaller.Instance;

            return Invoke<DescribeInstancePatchStatesForPatchGroupRequest,DescribeInstancePatchStatesForPatchGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInstancePatchStatesForPatchGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstancePatchStatesForPatchGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeInstancePatchStatesForPatchGroup">REST API Reference for DescribeInstancePatchStatesForPatchGroup Operation</seealso>
        public Task<DescribeInstancePatchStatesForPatchGroupResponse> DescribeInstancePatchStatesForPatchGroupAsync(DescribeInstancePatchStatesForPatchGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeInstancePatchStatesForPatchGroupRequestMarshaller();
            var unmarshaller = DescribeInstancePatchStatesForPatchGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeInstancePatchStatesForPatchGroupRequest,DescribeInstancePatchStatesForPatchGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeMaintenanceWindowExecutions


        /// <summary>
        /// Lists the executions of a Maintenance Window (meaning, information about when the
        /// Maintenance Window was scheduled to be active and information about tasks registered
        /// and run with the Maintenance Window).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceWindowExecutions service method.</param>
        /// 
        /// <returns>The response from the DescribeMaintenanceWindowExecutions service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeMaintenanceWindowExecutions">REST API Reference for DescribeMaintenanceWindowExecutions Operation</seealso>
        public DescribeMaintenanceWindowExecutionsResponse DescribeMaintenanceWindowExecutions(DescribeMaintenanceWindowExecutionsRequest request)
        {
            var marshaller = new DescribeMaintenanceWindowExecutionsRequestMarshaller();
            var unmarshaller = DescribeMaintenanceWindowExecutionsResponseUnmarshaller.Instance;

            return Invoke<DescribeMaintenanceWindowExecutionsRequest,DescribeMaintenanceWindowExecutionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMaintenanceWindowExecutions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceWindowExecutions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeMaintenanceWindowExecutions">REST API Reference for DescribeMaintenanceWindowExecutions Operation</seealso>
        public Task<DescribeMaintenanceWindowExecutionsResponse> DescribeMaintenanceWindowExecutionsAsync(DescribeMaintenanceWindowExecutionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeMaintenanceWindowExecutionsRequestMarshaller();
            var unmarshaller = DescribeMaintenanceWindowExecutionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeMaintenanceWindowExecutionsRequest,DescribeMaintenanceWindowExecutionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeMaintenanceWindowExecutionTaskInvocations


        /// <summary>
        /// Retrieves the individual task executions (one per target) for a particular task executed
        /// as part of a Maintenance Window execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceWindowExecutionTaskInvocations service method.</param>
        /// 
        /// <returns>The response from the DescribeMaintenanceWindowExecutionTaskInvocations service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource (e.g. a Maintenance Window) doesn’t
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeMaintenanceWindowExecutionTaskInvocations">REST API Reference for DescribeMaintenanceWindowExecutionTaskInvocations Operation</seealso>
        public DescribeMaintenanceWindowExecutionTaskInvocationsResponse DescribeMaintenanceWindowExecutionTaskInvocations(DescribeMaintenanceWindowExecutionTaskInvocationsRequest request)
        {
            var marshaller = new DescribeMaintenanceWindowExecutionTaskInvocationsRequestMarshaller();
            var unmarshaller = DescribeMaintenanceWindowExecutionTaskInvocationsResponseUnmarshaller.Instance;

            return Invoke<DescribeMaintenanceWindowExecutionTaskInvocationsRequest,DescribeMaintenanceWindowExecutionTaskInvocationsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMaintenanceWindowExecutionTaskInvocations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceWindowExecutionTaskInvocations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeMaintenanceWindowExecutionTaskInvocations">REST API Reference for DescribeMaintenanceWindowExecutionTaskInvocations Operation</seealso>
        public Task<DescribeMaintenanceWindowExecutionTaskInvocationsResponse> DescribeMaintenanceWindowExecutionTaskInvocationsAsync(DescribeMaintenanceWindowExecutionTaskInvocationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeMaintenanceWindowExecutionTaskInvocationsRequestMarshaller();
            var unmarshaller = DescribeMaintenanceWindowExecutionTaskInvocationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeMaintenanceWindowExecutionTaskInvocationsRequest,DescribeMaintenanceWindowExecutionTaskInvocationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeMaintenanceWindowExecutionTasks


        /// <summary>
        /// For a given Maintenance Window execution, lists the tasks that were executed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceWindowExecutionTasks service method.</param>
        /// 
        /// <returns>The response from the DescribeMaintenanceWindowExecutionTasks service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource (e.g. a Maintenance Window) doesn’t
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeMaintenanceWindowExecutionTasks">REST API Reference for DescribeMaintenanceWindowExecutionTasks Operation</seealso>
        public DescribeMaintenanceWindowExecutionTasksResponse DescribeMaintenanceWindowExecutionTasks(DescribeMaintenanceWindowExecutionTasksRequest request)
        {
            var marshaller = new DescribeMaintenanceWindowExecutionTasksRequestMarshaller();
            var unmarshaller = DescribeMaintenanceWindowExecutionTasksResponseUnmarshaller.Instance;

            return Invoke<DescribeMaintenanceWindowExecutionTasksRequest,DescribeMaintenanceWindowExecutionTasksResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMaintenanceWindowExecutionTasks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceWindowExecutionTasks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeMaintenanceWindowExecutionTasks">REST API Reference for DescribeMaintenanceWindowExecutionTasks Operation</seealso>
        public Task<DescribeMaintenanceWindowExecutionTasksResponse> DescribeMaintenanceWindowExecutionTasksAsync(DescribeMaintenanceWindowExecutionTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeMaintenanceWindowExecutionTasksRequestMarshaller();
            var unmarshaller = DescribeMaintenanceWindowExecutionTasksResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeMaintenanceWindowExecutionTasksRequest,DescribeMaintenanceWindowExecutionTasksResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeMaintenanceWindows


        /// <summary>
        /// Retrieves the Maintenance Windows in an AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceWindows service method.</param>
        /// 
        /// <returns>The response from the DescribeMaintenanceWindows service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeMaintenanceWindows">REST API Reference for DescribeMaintenanceWindows Operation</seealso>
        public DescribeMaintenanceWindowsResponse DescribeMaintenanceWindows(DescribeMaintenanceWindowsRequest request)
        {
            var marshaller = new DescribeMaintenanceWindowsRequestMarshaller();
            var unmarshaller = DescribeMaintenanceWindowsResponseUnmarshaller.Instance;

            return Invoke<DescribeMaintenanceWindowsRequest,DescribeMaintenanceWindowsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMaintenanceWindows operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceWindows operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeMaintenanceWindows">REST API Reference for DescribeMaintenanceWindows Operation</seealso>
        public Task<DescribeMaintenanceWindowsResponse> DescribeMaintenanceWindowsAsync(DescribeMaintenanceWindowsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeMaintenanceWindowsRequestMarshaller();
            var unmarshaller = DescribeMaintenanceWindowsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeMaintenanceWindowsRequest,DescribeMaintenanceWindowsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeMaintenanceWindowTargets


        /// <summary>
        /// Lists the targets registered with the Maintenance Window.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceWindowTargets service method.</param>
        /// 
        /// <returns>The response from the DescribeMaintenanceWindowTargets service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource (e.g. a Maintenance Window) doesn’t
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeMaintenanceWindowTargets">REST API Reference for DescribeMaintenanceWindowTargets Operation</seealso>
        public DescribeMaintenanceWindowTargetsResponse DescribeMaintenanceWindowTargets(DescribeMaintenanceWindowTargetsRequest request)
        {
            var marshaller = new DescribeMaintenanceWindowTargetsRequestMarshaller();
            var unmarshaller = DescribeMaintenanceWindowTargetsResponseUnmarshaller.Instance;

            return Invoke<DescribeMaintenanceWindowTargetsRequest,DescribeMaintenanceWindowTargetsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMaintenanceWindowTargets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceWindowTargets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeMaintenanceWindowTargets">REST API Reference for DescribeMaintenanceWindowTargets Operation</seealso>
        public Task<DescribeMaintenanceWindowTargetsResponse> DescribeMaintenanceWindowTargetsAsync(DescribeMaintenanceWindowTargetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeMaintenanceWindowTargetsRequestMarshaller();
            var unmarshaller = DescribeMaintenanceWindowTargetsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeMaintenanceWindowTargetsRequest,DescribeMaintenanceWindowTargetsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeMaintenanceWindowTasks


        /// <summary>
        /// Lists the tasks in a Maintenance Window.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceWindowTasks service method.</param>
        /// 
        /// <returns>The response from the DescribeMaintenanceWindowTasks service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource (e.g. a Maintenance Window) doesn’t
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeMaintenanceWindowTasks">REST API Reference for DescribeMaintenanceWindowTasks Operation</seealso>
        public DescribeMaintenanceWindowTasksResponse DescribeMaintenanceWindowTasks(DescribeMaintenanceWindowTasksRequest request)
        {
            var marshaller = new DescribeMaintenanceWindowTasksRequestMarshaller();
            var unmarshaller = DescribeMaintenanceWindowTasksResponseUnmarshaller.Instance;

            return Invoke<DescribeMaintenanceWindowTasksRequest,DescribeMaintenanceWindowTasksResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMaintenanceWindowTasks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceWindowTasks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeMaintenanceWindowTasks">REST API Reference for DescribeMaintenanceWindowTasks Operation</seealso>
        public Task<DescribeMaintenanceWindowTasksResponse> DescribeMaintenanceWindowTasksAsync(DescribeMaintenanceWindowTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeMaintenanceWindowTasksRequestMarshaller();
            var unmarshaller = DescribeMaintenanceWindowTasksResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeMaintenanceWindowTasksRequest,DescribeMaintenanceWindowTasksResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeParameters


        /// <summary>
        /// Get information about a parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeParameters service method.</param>
        /// 
        /// <returns>The response from the DescribeParameters service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterValueException">
        /// The filter value is not valid. Verify the value and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeParameters">REST API Reference for DescribeParameters Operation</seealso>
        public DescribeParametersResponse DescribeParameters(DescribeParametersRequest request)
        {
            var marshaller = new DescribeParametersRequestMarshaller();
            var unmarshaller = DescribeParametersResponseUnmarshaller.Instance;

            return Invoke<DescribeParametersRequest,DescribeParametersResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeParameters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeParameters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeParameters">REST API Reference for DescribeParameters Operation</seealso>
        public Task<DescribeParametersResponse> DescribeParametersAsync(DescribeParametersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeParametersRequestMarshaller();
            var unmarshaller = DescribeParametersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeParametersRequest,DescribeParametersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribePatchBaselines


        /// <summary>
        /// Lists the patch baselines in your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePatchBaselines service method.</param>
        /// 
        /// <returns>The response from the DescribePatchBaselines service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribePatchBaselines">REST API Reference for DescribePatchBaselines Operation</seealso>
        public DescribePatchBaselinesResponse DescribePatchBaselines(DescribePatchBaselinesRequest request)
        {
            var marshaller = new DescribePatchBaselinesRequestMarshaller();
            var unmarshaller = DescribePatchBaselinesResponseUnmarshaller.Instance;

            return Invoke<DescribePatchBaselinesRequest,DescribePatchBaselinesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePatchBaselines operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePatchBaselines operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribePatchBaselines">REST API Reference for DescribePatchBaselines Operation</seealso>
        public Task<DescribePatchBaselinesResponse> DescribePatchBaselinesAsync(DescribePatchBaselinesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribePatchBaselinesRequestMarshaller();
            var unmarshaller = DescribePatchBaselinesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribePatchBaselinesRequest,DescribePatchBaselinesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribePatchGroups


        /// <summary>
        /// Lists all patch groups that have been registered with patch baselines.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePatchGroups service method.</param>
        /// 
        /// <returns>The response from the DescribePatchGroups service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribePatchGroups">REST API Reference for DescribePatchGroups Operation</seealso>
        public DescribePatchGroupsResponse DescribePatchGroups(DescribePatchGroupsRequest request)
        {
            var marshaller = new DescribePatchGroupsRequestMarshaller();
            var unmarshaller = DescribePatchGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribePatchGroupsRequest,DescribePatchGroupsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePatchGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePatchGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribePatchGroups">REST API Reference for DescribePatchGroups Operation</seealso>
        public Task<DescribePatchGroupsResponse> DescribePatchGroupsAsync(DescribePatchGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribePatchGroupsRequestMarshaller();
            var unmarshaller = DescribePatchGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribePatchGroupsRequest,DescribePatchGroupsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribePatchGroupState


        /// <summary>
        /// Returns high-level aggregated patch compliance state for a patch group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePatchGroupState service method.</param>
        /// 
        /// <returns>The response from the DescribePatchGroupState service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribePatchGroupState">REST API Reference for DescribePatchGroupState Operation</seealso>
        public DescribePatchGroupStateResponse DescribePatchGroupState(DescribePatchGroupStateRequest request)
        {
            var marshaller = new DescribePatchGroupStateRequestMarshaller();
            var unmarshaller = DescribePatchGroupStateResponseUnmarshaller.Instance;

            return Invoke<DescribePatchGroupStateRequest,DescribePatchGroupStateResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePatchGroupState operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePatchGroupState operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribePatchGroupState">REST API Reference for DescribePatchGroupState Operation</seealso>
        public Task<DescribePatchGroupStateResponse> DescribePatchGroupStateAsync(DescribePatchGroupStateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribePatchGroupStateRequestMarshaller();
            var unmarshaller = DescribePatchGroupStateResponseUnmarshaller.Instance;

            return InvokeAsync<DescribePatchGroupStateRequest,DescribePatchGroupStateResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetAutomationExecution


        /// <summary>
        /// Get detailed information about a particular Automation execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAutomationExecution service method.</param>
        /// 
        /// <returns>The response from the GetAutomationExecution service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AutomationExecutionNotFoundException">
        /// There is no automation execution information for the requested automation execution
        /// ID.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetAutomationExecution">REST API Reference for GetAutomationExecution Operation</seealso>
        public GetAutomationExecutionResponse GetAutomationExecution(GetAutomationExecutionRequest request)
        {
            var marshaller = new GetAutomationExecutionRequestMarshaller();
            var unmarshaller = GetAutomationExecutionResponseUnmarshaller.Instance;

            return Invoke<GetAutomationExecutionRequest,GetAutomationExecutionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAutomationExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAutomationExecution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetAutomationExecution">REST API Reference for GetAutomationExecution Operation</seealso>
        public Task<GetAutomationExecutionResponse> GetAutomationExecutionAsync(GetAutomationExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetAutomationExecutionRequestMarshaller();
            var unmarshaller = GetAutomationExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<GetAutomationExecutionRequest,GetAutomationExecutionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetCommandInvocation


        /// <summary>
        /// Returns detailed information about command execution for an invocation or plugin.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCommandInvocation service method.</param>
        /// 
        /// <returns>The response from the GetCommandInvocation service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidCommandIdException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  
        /// <para>
        /// You do not have permission to access the instance.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent is not running. On managed instances and Linux instances, verify that
        /// the SSM agent is running. On EC2 Windows instances, verify that the EC2Config service
        /// is running.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent or EC2Config service is not registered to the SSM endpoint. Try reinstalling
        /// the SSM agent or EC2Config service.
        /// </para>
        ///  
        /// <para>
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidPluginNameException">
        /// The plugin name is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvocationDoesNotExistException">
        /// The command ID and instance ID you specified did not match any invocations. Verify
        /// the command ID adn the instance ID and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetCommandInvocation">REST API Reference for GetCommandInvocation Operation</seealso>
        public GetCommandInvocationResponse GetCommandInvocation(GetCommandInvocationRequest request)
        {
            var marshaller = new GetCommandInvocationRequestMarshaller();
            var unmarshaller = GetCommandInvocationResponseUnmarshaller.Instance;

            return Invoke<GetCommandInvocationRequest,GetCommandInvocationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCommandInvocation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCommandInvocation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetCommandInvocation">REST API Reference for GetCommandInvocation Operation</seealso>
        public Task<GetCommandInvocationResponse> GetCommandInvocationAsync(GetCommandInvocationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetCommandInvocationRequestMarshaller();
            var unmarshaller = GetCommandInvocationResponseUnmarshaller.Instance;

            return InvokeAsync<GetCommandInvocationRequest,GetCommandInvocationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetDefaultPatchBaseline


        /// <summary>
        /// Retrieves the default patch baseline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDefaultPatchBaseline service method.</param>
        /// 
        /// <returns>The response from the GetDefaultPatchBaseline service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetDefaultPatchBaseline">REST API Reference for GetDefaultPatchBaseline Operation</seealso>
        public GetDefaultPatchBaselineResponse GetDefaultPatchBaseline(GetDefaultPatchBaselineRequest request)
        {
            var marshaller = new GetDefaultPatchBaselineRequestMarshaller();
            var unmarshaller = GetDefaultPatchBaselineResponseUnmarshaller.Instance;

            return Invoke<GetDefaultPatchBaselineRequest,GetDefaultPatchBaselineResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDefaultPatchBaseline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDefaultPatchBaseline operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetDefaultPatchBaseline">REST API Reference for GetDefaultPatchBaseline Operation</seealso>
        public Task<GetDefaultPatchBaselineResponse> GetDefaultPatchBaselineAsync(GetDefaultPatchBaselineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetDefaultPatchBaselineRequestMarshaller();
            var unmarshaller = GetDefaultPatchBaselineResponseUnmarshaller.Instance;

            return InvokeAsync<GetDefaultPatchBaselineRequest,GetDefaultPatchBaselineResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetDeployablePatchSnapshotForInstance


        /// <summary>
        /// Retrieves the current snapshot for the patch baseline the instance uses. This API
        /// is primarily used by the AWS-ApplyPatchBaseline Systems Manager document.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeployablePatchSnapshotForInstance service method.</param>
        /// 
        /// <returns>The response from the GetDeployablePatchSnapshotForInstance service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetDeployablePatchSnapshotForInstance">REST API Reference for GetDeployablePatchSnapshotForInstance Operation</seealso>
        public GetDeployablePatchSnapshotForInstanceResponse GetDeployablePatchSnapshotForInstance(GetDeployablePatchSnapshotForInstanceRequest request)
        {
            var marshaller = new GetDeployablePatchSnapshotForInstanceRequestMarshaller();
            var unmarshaller = GetDeployablePatchSnapshotForInstanceResponseUnmarshaller.Instance;

            return Invoke<GetDeployablePatchSnapshotForInstanceRequest,GetDeployablePatchSnapshotForInstanceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDeployablePatchSnapshotForInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDeployablePatchSnapshotForInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetDeployablePatchSnapshotForInstance">REST API Reference for GetDeployablePatchSnapshotForInstance Operation</seealso>
        public Task<GetDeployablePatchSnapshotForInstanceResponse> GetDeployablePatchSnapshotForInstanceAsync(GetDeployablePatchSnapshotForInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetDeployablePatchSnapshotForInstanceRequestMarshaller();
            var unmarshaller = GetDeployablePatchSnapshotForInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<GetDeployablePatchSnapshotForInstanceRequest,GetDeployablePatchSnapshotForInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetDocument


        /// <summary>
        /// Gets the contents of the specified SSM document.
        /// </summary>
        /// <param name="name">The name of the SSM document.</param>
        /// 
        /// <returns>The response from the GetDocument service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified document does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentVersionException">
        /// The document version is not valid or does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetDocument">REST API Reference for GetDocument Operation</seealso>
        public GetDocumentResponse GetDocument(string name)
        {
            var request = new GetDocumentRequest();
            request.Name = name;
            return GetDocument(request);
        }


        /// <summary>
        /// Gets the contents of the specified SSM document.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDocument service method.</param>
        /// 
        /// <returns>The response from the GetDocument service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified document does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentVersionException">
        /// The document version is not valid or does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetDocument">REST API Reference for GetDocument Operation</seealso>
        public GetDocumentResponse GetDocument(GetDocumentRequest request)
        {
            var marshaller = new GetDocumentRequestMarshaller();
            var unmarshaller = GetDocumentResponseUnmarshaller.Instance;

            return Invoke<GetDocumentRequest,GetDocumentResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Gets the contents of the specified SSM document.
        /// </summary>
        /// <param name="name">The name of the SSM document.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDocument service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified document does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentVersionException">
        /// The document version is not valid or does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetDocument">REST API Reference for GetDocument Operation</seealso>
        public Task<GetDocumentResponse> GetDocumentAsync(string name, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetDocumentRequest();
            request.Name = name;
            return GetDocumentAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDocument operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDocument operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetDocument">REST API Reference for GetDocument Operation</seealso>
        public Task<GetDocumentResponse> GetDocumentAsync(GetDocumentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetDocumentRequestMarshaller();
            var unmarshaller = GetDocumentResponseUnmarshaller.Instance;

            return InvokeAsync<GetDocumentRequest,GetDocumentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetInventory


        /// <summary>
        /// Query inventory information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInventory service method.</param>
        /// 
        /// <returns>The response from the GetInventory service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterException">
        /// The filter name is not valid. Verify the you entered the correct name and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidResultAttributeException">
        /// The specified inventory item result attribute is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidTypeNameException">
        /// The parameter type name is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetInventory">REST API Reference for GetInventory Operation</seealso>
        public GetInventoryResponse GetInventory(GetInventoryRequest request)
        {
            var marshaller = new GetInventoryRequestMarshaller();
            var unmarshaller = GetInventoryResponseUnmarshaller.Instance;

            return Invoke<GetInventoryRequest,GetInventoryResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetInventory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInventory operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetInventory">REST API Reference for GetInventory Operation</seealso>
        public Task<GetInventoryResponse> GetInventoryAsync(GetInventoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetInventoryRequestMarshaller();
            var unmarshaller = GetInventoryResponseUnmarshaller.Instance;

            return InvokeAsync<GetInventoryRequest,GetInventoryResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetInventorySchema


        /// <summary>
        /// Return a list of inventory type names for the account, or return a list of attribute
        /// names for a specific Inventory item type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInventorySchema service method.</param>
        /// 
        /// <returns>The response from the GetInventorySchema service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidTypeNameException">
        /// The parameter type name is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetInventorySchema">REST API Reference for GetInventorySchema Operation</seealso>
        public GetInventorySchemaResponse GetInventorySchema(GetInventorySchemaRequest request)
        {
            var marshaller = new GetInventorySchemaRequestMarshaller();
            var unmarshaller = GetInventorySchemaResponseUnmarshaller.Instance;

            return Invoke<GetInventorySchemaRequest,GetInventorySchemaResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetInventorySchema operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInventorySchema operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetInventorySchema">REST API Reference for GetInventorySchema Operation</seealso>
        public Task<GetInventorySchemaResponse> GetInventorySchemaAsync(GetInventorySchemaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetInventorySchemaRequestMarshaller();
            var unmarshaller = GetInventorySchemaResponseUnmarshaller.Instance;

            return InvokeAsync<GetInventorySchemaRequest,GetInventorySchemaResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetMaintenanceWindow


        /// <summary>
        /// Retrieves a Maintenance Window.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMaintenanceWindow service method.</param>
        /// 
        /// <returns>The response from the GetMaintenanceWindow service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource (e.g. a Maintenance Window) doesn’t
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetMaintenanceWindow">REST API Reference for GetMaintenanceWindow Operation</seealso>
        public GetMaintenanceWindowResponse GetMaintenanceWindow(GetMaintenanceWindowRequest request)
        {
            var marshaller = new GetMaintenanceWindowRequestMarshaller();
            var unmarshaller = GetMaintenanceWindowResponseUnmarshaller.Instance;

            return Invoke<GetMaintenanceWindowRequest,GetMaintenanceWindowResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetMaintenanceWindow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMaintenanceWindow operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetMaintenanceWindow">REST API Reference for GetMaintenanceWindow Operation</seealso>
        public Task<GetMaintenanceWindowResponse> GetMaintenanceWindowAsync(GetMaintenanceWindowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetMaintenanceWindowRequestMarshaller();
            var unmarshaller = GetMaintenanceWindowResponseUnmarshaller.Instance;

            return InvokeAsync<GetMaintenanceWindowRequest,GetMaintenanceWindowResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetMaintenanceWindowExecution


        /// <summary>
        /// Retrieves details about a specific task executed as part of a Maintenance Window execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMaintenanceWindowExecution service method.</param>
        /// 
        /// <returns>The response from the GetMaintenanceWindowExecution service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource (e.g. a Maintenance Window) doesn’t
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetMaintenanceWindowExecution">REST API Reference for GetMaintenanceWindowExecution Operation</seealso>
        public GetMaintenanceWindowExecutionResponse GetMaintenanceWindowExecution(GetMaintenanceWindowExecutionRequest request)
        {
            var marshaller = new GetMaintenanceWindowExecutionRequestMarshaller();
            var unmarshaller = GetMaintenanceWindowExecutionResponseUnmarshaller.Instance;

            return Invoke<GetMaintenanceWindowExecutionRequest,GetMaintenanceWindowExecutionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetMaintenanceWindowExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMaintenanceWindowExecution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetMaintenanceWindowExecution">REST API Reference for GetMaintenanceWindowExecution Operation</seealso>
        public Task<GetMaintenanceWindowExecutionResponse> GetMaintenanceWindowExecutionAsync(GetMaintenanceWindowExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetMaintenanceWindowExecutionRequestMarshaller();
            var unmarshaller = GetMaintenanceWindowExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<GetMaintenanceWindowExecutionRequest,GetMaintenanceWindowExecutionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetMaintenanceWindowExecutionTask


        /// <summary>
        /// Retrieves the details about a specific task executed as part of a Maintenance Window
        /// execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMaintenanceWindowExecutionTask service method.</param>
        /// 
        /// <returns>The response from the GetMaintenanceWindowExecutionTask service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource (e.g. a Maintenance Window) doesn’t
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetMaintenanceWindowExecutionTask">REST API Reference for GetMaintenanceWindowExecutionTask Operation</seealso>
        public GetMaintenanceWindowExecutionTaskResponse GetMaintenanceWindowExecutionTask(GetMaintenanceWindowExecutionTaskRequest request)
        {
            var marshaller = new GetMaintenanceWindowExecutionTaskRequestMarshaller();
            var unmarshaller = GetMaintenanceWindowExecutionTaskResponseUnmarshaller.Instance;

            return Invoke<GetMaintenanceWindowExecutionTaskRequest,GetMaintenanceWindowExecutionTaskResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetMaintenanceWindowExecutionTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMaintenanceWindowExecutionTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetMaintenanceWindowExecutionTask">REST API Reference for GetMaintenanceWindowExecutionTask Operation</seealso>
        public Task<GetMaintenanceWindowExecutionTaskResponse> GetMaintenanceWindowExecutionTaskAsync(GetMaintenanceWindowExecutionTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetMaintenanceWindowExecutionTaskRequestMarshaller();
            var unmarshaller = GetMaintenanceWindowExecutionTaskResponseUnmarshaller.Instance;

            return InvokeAsync<GetMaintenanceWindowExecutionTaskRequest,GetMaintenanceWindowExecutionTaskResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetParameterHistory


        /// <summary>
        /// Query a list of all parameters used by the AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetParameterHistory service method.</param>
        /// 
        /// <returns>The response from the GetParameterHistory service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ParameterNotFoundException">
        /// The parameter could not be found. Verify the name and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetParameterHistory">REST API Reference for GetParameterHistory Operation</seealso>
        public GetParameterHistoryResponse GetParameterHistory(GetParameterHistoryRequest request)
        {
            var marshaller = new GetParameterHistoryRequestMarshaller();
            var unmarshaller = GetParameterHistoryResponseUnmarshaller.Instance;

            return Invoke<GetParameterHistoryRequest,GetParameterHistoryResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetParameterHistory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetParameterHistory operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetParameterHistory">REST API Reference for GetParameterHistory Operation</seealso>
        public Task<GetParameterHistoryResponse> GetParameterHistoryAsync(GetParameterHistoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetParameterHistoryRequestMarshaller();
            var unmarshaller = GetParameterHistoryResponseUnmarshaller.Instance;

            return InvokeAsync<GetParameterHistoryRequest,GetParameterHistoryResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetParameters


        /// <summary>
        /// Get a list of parameters used by the AWS account.&gt;
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetParameters service method.</param>
        /// 
        /// <returns>The response from the GetParameters service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetParameters">REST API Reference for GetParameters Operation</seealso>
        public GetParametersResponse GetParameters(GetParametersRequest request)
        {
            var marshaller = new GetParametersRequestMarshaller();
            var unmarshaller = GetParametersResponseUnmarshaller.Instance;

            return Invoke<GetParametersRequest,GetParametersResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetParameters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetParameters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetParameters">REST API Reference for GetParameters Operation</seealso>
        public Task<GetParametersResponse> GetParametersAsync(GetParametersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetParametersRequestMarshaller();
            var unmarshaller = GetParametersResponseUnmarshaller.Instance;

            return InvokeAsync<GetParametersRequest,GetParametersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetPatchBaseline


        /// <summary>
        /// Retrieves information about a patch baseline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPatchBaseline service method.</param>
        /// 
        /// <returns>The response from the GetPatchBaseline service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource (e.g. a Maintenance Window) doesn’t
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidResourceIdException">
        /// The resource ID is not valid. Verify that you entered the correct ID and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetPatchBaseline">REST API Reference for GetPatchBaseline Operation</seealso>
        public GetPatchBaselineResponse GetPatchBaseline(GetPatchBaselineRequest request)
        {
            var marshaller = new GetPatchBaselineRequestMarshaller();
            var unmarshaller = GetPatchBaselineResponseUnmarshaller.Instance;

            return Invoke<GetPatchBaselineRequest,GetPatchBaselineResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPatchBaseline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPatchBaseline operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetPatchBaseline">REST API Reference for GetPatchBaseline Operation</seealso>
        public Task<GetPatchBaselineResponse> GetPatchBaselineAsync(GetPatchBaselineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetPatchBaselineRequestMarshaller();
            var unmarshaller = GetPatchBaselineResponseUnmarshaller.Instance;

            return InvokeAsync<GetPatchBaselineRequest,GetPatchBaselineResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetPatchBaselineForPatchGroup


        /// <summary>
        /// Retrieves the patch baseline that should be used for the specified patch group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPatchBaselineForPatchGroup service method.</param>
        /// 
        /// <returns>The response from the GetPatchBaselineForPatchGroup service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetPatchBaselineForPatchGroup">REST API Reference for GetPatchBaselineForPatchGroup Operation</seealso>
        public GetPatchBaselineForPatchGroupResponse GetPatchBaselineForPatchGroup(GetPatchBaselineForPatchGroupRequest request)
        {
            var marshaller = new GetPatchBaselineForPatchGroupRequestMarshaller();
            var unmarshaller = GetPatchBaselineForPatchGroupResponseUnmarshaller.Instance;

            return Invoke<GetPatchBaselineForPatchGroupRequest,GetPatchBaselineForPatchGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPatchBaselineForPatchGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPatchBaselineForPatchGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetPatchBaselineForPatchGroup">REST API Reference for GetPatchBaselineForPatchGroup Operation</seealso>
        public Task<GetPatchBaselineForPatchGroupResponse> GetPatchBaselineForPatchGroupAsync(GetPatchBaselineForPatchGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetPatchBaselineForPatchGroupRequestMarshaller();
            var unmarshaller = GetPatchBaselineForPatchGroupResponseUnmarshaller.Instance;

            return InvokeAsync<GetPatchBaselineForPatchGroupRequest,GetPatchBaselineForPatchGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListAssociations


        /// <summary>
        /// Lists the associations for the specified SSM document or instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssociations service method.</param>
        /// 
        /// <returns>The response from the ListAssociations service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListAssociations">REST API Reference for ListAssociations Operation</seealso>
        public ListAssociationsResponse ListAssociations(ListAssociationsRequest request)
        {
            var marshaller = new ListAssociationsRequestMarshaller();
            var unmarshaller = ListAssociationsResponseUnmarshaller.Instance;

            return Invoke<ListAssociationsRequest,ListAssociationsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssociations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListAssociations">REST API Reference for ListAssociations Operation</seealso>
        public Task<ListAssociationsResponse> ListAssociationsAsync(ListAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListAssociationsRequestMarshaller();
            var unmarshaller = ListAssociationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAssociationsRequest,ListAssociationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListCommandInvocations


        /// <summary>
        /// An invocation is copy of a command sent to a specific instance. A command can apply
        /// to one or more instances. A command invocation applies to one instance. For example,
        /// if a user executes SendCommand against three instances, then a command invocation
        /// is created for each requested instance ID. ListCommandInvocations provide status about
        /// command execution.
        /// </summary>
        /// 
        /// <returns>The response from the ListCommandInvocations service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidCommandIdException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterKeyException">
        /// The specified key is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  
        /// <para>
        /// You do not have permission to access the instance.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent is not running. On managed instances and Linux instances, verify that
        /// the SSM agent is running. On EC2 Windows instances, verify that the EC2Config service
        /// is running.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent or EC2Config service is not registered to the SSM endpoint. Try reinstalling
        /// the SSM agent or EC2Config service.
        /// </para>
        ///  
        /// <para>
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListCommandInvocations">REST API Reference for ListCommandInvocations Operation</seealso>
        public ListCommandInvocationsResponse ListCommandInvocations()
        {
            return ListCommandInvocations(new ListCommandInvocationsRequest());
        }


        /// <summary>
        /// An invocation is copy of a command sent to a specific instance. A command can apply
        /// to one or more instances. A command invocation applies to one instance. For example,
        /// if a user executes SendCommand against three instances, then a command invocation
        /// is created for each requested instance ID. ListCommandInvocations provide status about
        /// command execution.
        /// </summary>
        /// <param name="commandId">(Optional) The invocations for a specific command ID.</param>
        /// 
        /// <returns>The response from the ListCommandInvocations service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidCommandIdException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterKeyException">
        /// The specified key is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  
        /// <para>
        /// You do not have permission to access the instance.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent is not running. On managed instances and Linux instances, verify that
        /// the SSM agent is running. On EC2 Windows instances, verify that the EC2Config service
        /// is running.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent or EC2Config service is not registered to the SSM endpoint. Try reinstalling
        /// the SSM agent or EC2Config service.
        /// </para>
        ///  
        /// <para>
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListCommandInvocations">REST API Reference for ListCommandInvocations Operation</seealso>
        public ListCommandInvocationsResponse ListCommandInvocations(string commandId)
        {
            var request = new ListCommandInvocationsRequest();
            request.CommandId = commandId;
            return ListCommandInvocations(request);
        }


        /// <summary>
        /// An invocation is copy of a command sent to a specific instance. A command can apply
        /// to one or more instances. A command invocation applies to one instance. For example,
        /// if a user executes SendCommand against three instances, then a command invocation
        /// is created for each requested instance ID. ListCommandInvocations provide status about
        /// command execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCommandInvocations service method.</param>
        /// 
        /// <returns>The response from the ListCommandInvocations service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidCommandIdException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterKeyException">
        /// The specified key is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  
        /// <para>
        /// You do not have permission to access the instance.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent is not running. On managed instances and Linux instances, verify that
        /// the SSM agent is running. On EC2 Windows instances, verify that the EC2Config service
        /// is running.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent or EC2Config service is not registered to the SSM endpoint. Try reinstalling
        /// the SSM agent or EC2Config service.
        /// </para>
        ///  
        /// <para>
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListCommandInvocations">REST API Reference for ListCommandInvocations Operation</seealso>
        public ListCommandInvocationsResponse ListCommandInvocations(ListCommandInvocationsRequest request)
        {
            var marshaller = new ListCommandInvocationsRequestMarshaller();
            var unmarshaller = ListCommandInvocationsResponseUnmarshaller.Instance;

            return Invoke<ListCommandInvocationsRequest,ListCommandInvocationsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// An invocation is copy of a command sent to a specific instance. A command can apply
        /// to one or more instances. A command invocation applies to one instance. For example,
        /// if a user executes SendCommand against three instances, then a command invocation
        /// is created for each requested instance ID. ListCommandInvocations provide status about
        /// command execution.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCommandInvocations service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidCommandIdException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterKeyException">
        /// The specified key is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  
        /// <para>
        /// You do not have permission to access the instance.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent is not running. On managed instances and Linux instances, verify that
        /// the SSM agent is running. On EC2 Windows instances, verify that the EC2Config service
        /// is running.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent or EC2Config service is not registered to the SSM endpoint. Try reinstalling
        /// the SSM agent or EC2Config service.
        /// </para>
        ///  
        /// <para>
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListCommandInvocations">REST API Reference for ListCommandInvocations Operation</seealso>
        public Task<ListCommandInvocationsResponse> ListCommandInvocationsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListCommandInvocationsAsync(new ListCommandInvocationsRequest(), cancellationToken);
        }

        /// <summary>
        /// An invocation is copy of a command sent to a specific instance. A command can apply
        /// to one or more instances. A command invocation applies to one instance. For example,
        /// if a user executes SendCommand against three instances, then a command invocation
        /// is created for each requested instance ID. ListCommandInvocations provide status about
        /// command execution.
        /// </summary>
        /// <param name="commandId">(Optional) The invocations for a specific command ID.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCommandInvocations service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidCommandIdException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterKeyException">
        /// The specified key is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  
        /// <para>
        /// You do not have permission to access the instance.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent is not running. On managed instances and Linux instances, verify that
        /// the SSM agent is running. On EC2 Windows instances, verify that the EC2Config service
        /// is running.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent or EC2Config service is not registered to the SSM endpoint. Try reinstalling
        /// the SSM agent or EC2Config service.
        /// </para>
        ///  
        /// <para>
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListCommandInvocations">REST API Reference for ListCommandInvocations Operation</seealso>
        public Task<ListCommandInvocationsResponse> ListCommandInvocationsAsync(string commandId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ListCommandInvocationsRequest();
            request.CommandId = commandId;
            return ListCommandInvocationsAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCommandInvocations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCommandInvocations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListCommandInvocations">REST API Reference for ListCommandInvocations Operation</seealso>
        public Task<ListCommandInvocationsResponse> ListCommandInvocationsAsync(ListCommandInvocationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListCommandInvocationsRequestMarshaller();
            var unmarshaller = ListCommandInvocationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListCommandInvocationsRequest,ListCommandInvocationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListCommands


        /// <summary>
        /// Lists the commands requested by users of the AWS account.
        /// </summary>
        /// 
        /// <returns>The response from the ListCommands service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidCommandIdException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterKeyException">
        /// The specified key is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  
        /// <para>
        /// You do not have permission to access the instance.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent is not running. On managed instances and Linux instances, verify that
        /// the SSM agent is running. On EC2 Windows instances, verify that the EC2Config service
        /// is running.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent or EC2Config service is not registered to the SSM endpoint. Try reinstalling
        /// the SSM agent or EC2Config service.
        /// </para>
        ///  
        /// <para>
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListCommands">REST API Reference for ListCommands Operation</seealso>
        public ListCommandsResponse ListCommands()
        {
            return ListCommands(new ListCommandsRequest());
        }


        /// <summary>
        /// Lists the commands requested by users of the AWS account.
        /// </summary>
        /// <param name="commandId">(Optional) If provided, lists only the specified command.</param>
        /// 
        /// <returns>The response from the ListCommands service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidCommandIdException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterKeyException">
        /// The specified key is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  
        /// <para>
        /// You do not have permission to access the instance.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent is not running. On managed instances and Linux instances, verify that
        /// the SSM agent is running. On EC2 Windows instances, verify that the EC2Config service
        /// is running.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent or EC2Config service is not registered to the SSM endpoint. Try reinstalling
        /// the SSM agent or EC2Config service.
        /// </para>
        ///  
        /// <para>
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListCommands">REST API Reference for ListCommands Operation</seealso>
        public ListCommandsResponse ListCommands(string commandId)
        {
            var request = new ListCommandsRequest();
            request.CommandId = commandId;
            return ListCommands(request);
        }


        /// <summary>
        /// Lists the commands requested by users of the AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCommands service method.</param>
        /// 
        /// <returns>The response from the ListCommands service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidCommandIdException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterKeyException">
        /// The specified key is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  
        /// <para>
        /// You do not have permission to access the instance.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent is not running. On managed instances and Linux instances, verify that
        /// the SSM agent is running. On EC2 Windows instances, verify that the EC2Config service
        /// is running.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent or EC2Config service is not registered to the SSM endpoint. Try reinstalling
        /// the SSM agent or EC2Config service.
        /// </para>
        ///  
        /// <para>
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListCommands">REST API Reference for ListCommands Operation</seealso>
        public ListCommandsResponse ListCommands(ListCommandsRequest request)
        {
            var marshaller = new ListCommandsRequestMarshaller();
            var unmarshaller = ListCommandsResponseUnmarshaller.Instance;

            return Invoke<ListCommandsRequest,ListCommandsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Lists the commands requested by users of the AWS account.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCommands service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidCommandIdException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterKeyException">
        /// The specified key is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  
        /// <para>
        /// You do not have permission to access the instance.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent is not running. On managed instances and Linux instances, verify that
        /// the SSM agent is running. On EC2 Windows instances, verify that the EC2Config service
        /// is running.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent or EC2Config service is not registered to the SSM endpoint. Try reinstalling
        /// the SSM agent or EC2Config service.
        /// </para>
        ///  
        /// <para>
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListCommands">REST API Reference for ListCommands Operation</seealso>
        public Task<ListCommandsResponse> ListCommandsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListCommandsAsync(new ListCommandsRequest(), cancellationToken);
        }

        /// <summary>
        /// Lists the commands requested by users of the AWS account.
        /// </summary>
        /// <param name="commandId">(Optional) If provided, lists only the specified command.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCommands service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidCommandIdException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterKeyException">
        /// The specified key is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  
        /// <para>
        /// You do not have permission to access the instance.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent is not running. On managed instances and Linux instances, verify that
        /// the SSM agent is running. On EC2 Windows instances, verify that the EC2Config service
        /// is running.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent or EC2Config service is not registered to the SSM endpoint. Try reinstalling
        /// the SSM agent or EC2Config service.
        /// </para>
        ///  
        /// <para>
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListCommands">REST API Reference for ListCommands Operation</seealso>
        public Task<ListCommandsResponse> ListCommandsAsync(string commandId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ListCommandsRequest();
            request.CommandId = commandId;
            return ListCommandsAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCommands operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCommands operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListCommands">REST API Reference for ListCommands Operation</seealso>
        public Task<ListCommandsResponse> ListCommandsAsync(ListCommandsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListCommandsRequestMarshaller();
            var unmarshaller = ListCommandsResponseUnmarshaller.Instance;

            return InvokeAsync<ListCommandsRequest,ListCommandsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListDocuments


        /// <summary>
        /// Describes one or more of your SSM documents.
        /// </summary>
        /// 
        /// <returns>The response from the ListDocuments service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterKeyException">
        /// The specified key is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListDocuments">REST API Reference for ListDocuments Operation</seealso>
        public ListDocumentsResponse ListDocuments()
        {
            return ListDocuments(new ListDocumentsRequest());
        }


        /// <summary>
        /// Describes one or more of your SSM documents.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDocuments service method.</param>
        /// 
        /// <returns>The response from the ListDocuments service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterKeyException">
        /// The specified key is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListDocuments">REST API Reference for ListDocuments Operation</seealso>
        public ListDocumentsResponse ListDocuments(ListDocumentsRequest request)
        {
            var marshaller = new ListDocumentsRequestMarshaller();
            var unmarshaller = ListDocumentsResponseUnmarshaller.Instance;

            return Invoke<ListDocumentsRequest,ListDocumentsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Describes one or more of your SSM documents.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDocuments service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterKeyException">
        /// The specified key is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListDocuments">REST API Reference for ListDocuments Operation</seealso>
        public Task<ListDocumentsResponse> ListDocumentsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListDocumentsAsync(new ListDocumentsRequest(), cancellationToken);
        }
        /// <summary>
        /// Initiates the asynchronous execution of the ListDocuments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDocuments operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListDocuments">REST API Reference for ListDocuments Operation</seealso>
        public Task<ListDocumentsResponse> ListDocumentsAsync(ListDocumentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListDocumentsRequestMarshaller();
            var unmarshaller = ListDocumentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDocumentsRequest,ListDocumentsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListDocumentVersions


        /// <summary>
        /// List all versions for a document.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDocumentVersions service method.</param>
        /// 
        /// <returns>The response from the ListDocumentVersions service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified document does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListDocumentVersions">REST API Reference for ListDocumentVersions Operation</seealso>
        public ListDocumentVersionsResponse ListDocumentVersions(ListDocumentVersionsRequest request)
        {
            var marshaller = new ListDocumentVersionsRequestMarshaller();
            var unmarshaller = ListDocumentVersionsResponseUnmarshaller.Instance;

            return Invoke<ListDocumentVersionsRequest,ListDocumentVersionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDocumentVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDocumentVersions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListDocumentVersions">REST API Reference for ListDocumentVersions Operation</seealso>
        public Task<ListDocumentVersionsResponse> ListDocumentVersionsAsync(ListDocumentVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListDocumentVersionsRequestMarshaller();
            var unmarshaller = ListDocumentVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDocumentVersionsRequest,ListDocumentVersionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListInventoryEntries


        /// <summary>
        /// A list of inventory items returned by the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInventoryEntries service method.</param>
        /// 
        /// <returns>The response from the ListInventoryEntries service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterException">
        /// The filter name is not valid. Verify the you entered the correct name and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  
        /// <para>
        /// You do not have permission to access the instance.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent is not running. On managed instances and Linux instances, verify that
        /// the SSM agent is running. On EC2 Windows instances, verify that the EC2Config service
        /// is running.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent or EC2Config service is not registered to the SSM endpoint. Try reinstalling
        /// the SSM agent or EC2Config service.
        /// </para>
        ///  
        /// <para>
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidTypeNameException">
        /// The parameter type name is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListInventoryEntries">REST API Reference for ListInventoryEntries Operation</seealso>
        public ListInventoryEntriesResponse ListInventoryEntries(ListInventoryEntriesRequest request)
        {
            var marshaller = new ListInventoryEntriesRequestMarshaller();
            var unmarshaller = ListInventoryEntriesResponseUnmarshaller.Instance;

            return Invoke<ListInventoryEntriesRequest,ListInventoryEntriesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListInventoryEntries operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInventoryEntries operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListInventoryEntries">REST API Reference for ListInventoryEntries Operation</seealso>
        public Task<ListInventoryEntriesResponse> ListInventoryEntriesAsync(ListInventoryEntriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListInventoryEntriesRequestMarshaller();
            var unmarshaller = ListInventoryEntriesResponseUnmarshaller.Instance;

            return InvokeAsync<ListInventoryEntriesRequest,ListInventoryEntriesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Returns a list of the tags assigned to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidResourceIdException">
        /// The resource ID is not valid. Verify that you entered the correct ID and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidResourceTypeException">
        /// The resource type is not valid. If you are attempting to tag an instance, the instance
        /// must be a registered, managed instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var marshaller = new ListTagsForResourceRequestMarshaller();
            var unmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceRequest,ListTagsForResourceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListTagsForResourceRequestMarshaller();
            var unmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceRequest,ListTagsForResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyDocumentPermission


        /// <summary>
        /// Share a document publicly or privately. If you share a document privately, you must
        /// specify the AWS user account IDs for those people who can use the document. If you
        /// share a document publicly, you must specify <i>All</i> as the account ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDocumentPermission service method.</param>
        /// 
        /// <returns>The response from the ModifyDocumentPermission service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DocumentLimitExceededException">
        /// You can have at most 200 active SSM documents.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DocumentPermissionLimitException">
        /// The document cannot be shared with more AWS user accounts. You can share a document
        /// with a maximum of 20 accounts. You can publicly share up to five documents. If you
        /// need to increase this limit, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified document does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidPermissionTypeException">
        /// The permission type is not supported. <i>Share</i> is the only supported permission
        /// type.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ModifyDocumentPermission">REST API Reference for ModifyDocumentPermission Operation</seealso>
        public ModifyDocumentPermissionResponse ModifyDocumentPermission(ModifyDocumentPermissionRequest request)
        {
            var marshaller = new ModifyDocumentPermissionRequestMarshaller();
            var unmarshaller = ModifyDocumentPermissionResponseUnmarshaller.Instance;

            return Invoke<ModifyDocumentPermissionRequest,ModifyDocumentPermissionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyDocumentPermission operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyDocumentPermission operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ModifyDocumentPermission">REST API Reference for ModifyDocumentPermission Operation</seealso>
        public Task<ModifyDocumentPermissionResponse> ModifyDocumentPermissionAsync(ModifyDocumentPermissionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyDocumentPermissionRequestMarshaller();
            var unmarshaller = ModifyDocumentPermissionResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyDocumentPermissionRequest,ModifyDocumentPermissionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutInventory


        /// <summary>
        /// Bulk update custom inventory items on one more instance. The request adds an inventory
        /// item, if it doesn't already exist, or updates an inventory item, if it does exist.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutInventory service method.</param>
        /// 
        /// <returns>The response from the PutInventory service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.CustomSchemaCountLimitExceededException">
        /// You have exceeded the limit for custom schemas. Delete one or more custom schemas
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  
        /// <para>
        /// You do not have permission to access the instance.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent is not running. On managed instances and Linux instances, verify that
        /// the SSM agent is running. On EC2 Windows instances, verify that the EC2Config service
        /// is running.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent or EC2Config service is not registered to the SSM endpoint. Try reinstalling
        /// the SSM agent or EC2Config service.
        /// </para>
        ///  
        /// <para>
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidItemContentException">
        /// One or more content items is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidTypeNameException">
        /// The parameter type name is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ItemContentMismatchException">
        /// The inventory item has invalid content.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ItemSizeLimitExceededException">
        /// The inventory item size has exceeded the size limit.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TotalSizeLimitExceededException">
        /// The size of inventory data has exceeded the total size limit for the resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.UnsupportedInventorySchemaVersionException">
        /// Inventory item type schema version has to match supported versions in the service.
        /// Check output of <code>GetInventorySchema</code> to see the available schema version
        /// for each type.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/PutInventory">REST API Reference for PutInventory Operation</seealso>
        public PutInventoryResponse PutInventory(PutInventoryRequest request)
        {
            var marshaller = new PutInventoryRequestMarshaller();
            var unmarshaller = PutInventoryResponseUnmarshaller.Instance;

            return Invoke<PutInventoryRequest,PutInventoryResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutInventory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutInventory operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/PutInventory">REST API Reference for PutInventory Operation</seealso>
        public Task<PutInventoryResponse> PutInventoryAsync(PutInventoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutInventoryRequestMarshaller();
            var unmarshaller = PutInventoryResponseUnmarshaller.Instance;

            return InvokeAsync<PutInventoryRequest,PutInventoryResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutParameter


        /// <summary>
        /// Add one or more paramaters to the system.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutParameter service method.</param>
        /// 
        /// <returns>The response from the PutParameter service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidKeyIdException">
        /// The query key ID is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ParameterAlreadyExistsException">
        /// The parameter already exists. You can't create duplicate parameters.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ParameterLimitExceededException">
        /// You have exceeded the number of parameters for this AWS account. Delete one or more
        /// parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TooManyUpdatesException">
        /// There are concurrent updates for a resource that supports one update at a time.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.UnsupportedParameterTypeException">
        /// The parameter type is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/PutParameter">REST API Reference for PutParameter Operation</seealso>
        public PutParameterResponse PutParameter(PutParameterRequest request)
        {
            var marshaller = new PutParameterRequestMarshaller();
            var unmarshaller = PutParameterResponseUnmarshaller.Instance;

            return Invoke<PutParameterRequest,PutParameterResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutParameter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutParameter operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/PutParameter">REST API Reference for PutParameter Operation</seealso>
        public Task<PutParameterResponse> PutParameterAsync(PutParameterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutParameterRequestMarshaller();
            var unmarshaller = PutParameterResponseUnmarshaller.Instance;

            return InvokeAsync<PutParameterRequest,PutParameterResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RegisterDefaultPatchBaseline


        /// <summary>
        /// Defines the default patch baseline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterDefaultPatchBaseline service method.</param>
        /// 
        /// <returns>The response from the RegisterDefaultPatchBaseline service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource (e.g. a Maintenance Window) doesn’t
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidResourceIdException">
        /// The resource ID is not valid. Verify that you entered the correct ID and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/RegisterDefaultPatchBaseline">REST API Reference for RegisterDefaultPatchBaseline Operation</seealso>
        public RegisterDefaultPatchBaselineResponse RegisterDefaultPatchBaseline(RegisterDefaultPatchBaselineRequest request)
        {
            var marshaller = new RegisterDefaultPatchBaselineRequestMarshaller();
            var unmarshaller = RegisterDefaultPatchBaselineResponseUnmarshaller.Instance;

            return Invoke<RegisterDefaultPatchBaselineRequest,RegisterDefaultPatchBaselineResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterDefaultPatchBaseline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterDefaultPatchBaseline operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/RegisterDefaultPatchBaseline">REST API Reference for RegisterDefaultPatchBaseline Operation</seealso>
        public Task<RegisterDefaultPatchBaselineResponse> RegisterDefaultPatchBaselineAsync(RegisterDefaultPatchBaselineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RegisterDefaultPatchBaselineRequestMarshaller();
            var unmarshaller = RegisterDefaultPatchBaselineResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterDefaultPatchBaselineRequest,RegisterDefaultPatchBaselineResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RegisterPatchBaselineForPatchGroup


        /// <summary>
        /// Registers a patch baseline for a patch group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterPatchBaselineForPatchGroup service method.</param>
        /// 
        /// <returns>The response from the RegisterPatchBaselineForPatchGroup service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AlreadyExistsException">
        /// Error returned if an attempt is made to register a patch group with a patch baseline
        /// that is already registered with a different patch baseline.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource (e.g. a Maintenance Window) doesn’t
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidResourceIdException">
        /// The resource ID is not valid. Verify that you entered the correct ID and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourceLimitExceededException">
        /// Error returned when the caller has exceeded the default resource limits (e.g. too
        /// many Maintenance Windows have been created).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/RegisterPatchBaselineForPatchGroup">REST API Reference for RegisterPatchBaselineForPatchGroup Operation</seealso>
        public RegisterPatchBaselineForPatchGroupResponse RegisterPatchBaselineForPatchGroup(RegisterPatchBaselineForPatchGroupRequest request)
        {
            var marshaller = new RegisterPatchBaselineForPatchGroupRequestMarshaller();
            var unmarshaller = RegisterPatchBaselineForPatchGroupResponseUnmarshaller.Instance;

            return Invoke<RegisterPatchBaselineForPatchGroupRequest,RegisterPatchBaselineForPatchGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterPatchBaselineForPatchGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterPatchBaselineForPatchGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/RegisterPatchBaselineForPatchGroup">REST API Reference for RegisterPatchBaselineForPatchGroup Operation</seealso>
        public Task<RegisterPatchBaselineForPatchGroupResponse> RegisterPatchBaselineForPatchGroupAsync(RegisterPatchBaselineForPatchGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RegisterPatchBaselineForPatchGroupRequestMarshaller();
            var unmarshaller = RegisterPatchBaselineForPatchGroupResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterPatchBaselineForPatchGroupRequest,RegisterPatchBaselineForPatchGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RegisterTargetWithMaintenanceWindow


        /// <summary>
        /// Registers a target with a Maintenance Window.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterTargetWithMaintenanceWindow service method.</param>
        /// 
        /// <returns>The response from the RegisterTargetWithMaintenanceWindow service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource (e.g. a Maintenance Window) doesn’t
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.IdempotentParameterMismatchException">
        /// Error returned when an idempotent operation is retried and the parameters don’t match
        /// the original call to the API with the same idempotency token.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourceLimitExceededException">
        /// Error returned when the caller has exceeded the default resource limits (e.g. too
        /// many Maintenance Windows have been created).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/RegisterTargetWithMaintenanceWindow">REST API Reference for RegisterTargetWithMaintenanceWindow Operation</seealso>
        public RegisterTargetWithMaintenanceWindowResponse RegisterTargetWithMaintenanceWindow(RegisterTargetWithMaintenanceWindowRequest request)
        {
            var marshaller = new RegisterTargetWithMaintenanceWindowRequestMarshaller();
            var unmarshaller = RegisterTargetWithMaintenanceWindowResponseUnmarshaller.Instance;

            return Invoke<RegisterTargetWithMaintenanceWindowRequest,RegisterTargetWithMaintenanceWindowResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterTargetWithMaintenanceWindow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterTargetWithMaintenanceWindow operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/RegisterTargetWithMaintenanceWindow">REST API Reference for RegisterTargetWithMaintenanceWindow Operation</seealso>
        public Task<RegisterTargetWithMaintenanceWindowResponse> RegisterTargetWithMaintenanceWindowAsync(RegisterTargetWithMaintenanceWindowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RegisterTargetWithMaintenanceWindowRequestMarshaller();
            var unmarshaller = RegisterTargetWithMaintenanceWindowResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterTargetWithMaintenanceWindowRequest,RegisterTargetWithMaintenanceWindowResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RegisterTaskWithMaintenanceWindow


        /// <summary>
        /// Adds a new task to a Maintenance Window.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterTaskWithMaintenanceWindow service method.</param>
        /// 
        /// <returns>The response from the RegisterTaskWithMaintenanceWindow service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource (e.g. a Maintenance Window) doesn’t
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.IdempotentParameterMismatchException">
        /// Error returned when an idempotent operation is retried and the parameters don’t match
        /// the original call to the API with the same idempotency token.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourceLimitExceededException">
        /// Error returned when the caller has exceeded the default resource limits (e.g. too
        /// many Maintenance Windows have been created).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/RegisterTaskWithMaintenanceWindow">REST API Reference for RegisterTaskWithMaintenanceWindow Operation</seealso>
        public RegisterTaskWithMaintenanceWindowResponse RegisterTaskWithMaintenanceWindow(RegisterTaskWithMaintenanceWindowRequest request)
        {
            var marshaller = new RegisterTaskWithMaintenanceWindowRequestMarshaller();
            var unmarshaller = RegisterTaskWithMaintenanceWindowResponseUnmarshaller.Instance;

            return Invoke<RegisterTaskWithMaintenanceWindowRequest,RegisterTaskWithMaintenanceWindowResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterTaskWithMaintenanceWindow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterTaskWithMaintenanceWindow operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/RegisterTaskWithMaintenanceWindow">REST API Reference for RegisterTaskWithMaintenanceWindow Operation</seealso>
        public Task<RegisterTaskWithMaintenanceWindowResponse> RegisterTaskWithMaintenanceWindowAsync(RegisterTaskWithMaintenanceWindowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RegisterTaskWithMaintenanceWindowRequestMarshaller();
            var unmarshaller = RegisterTaskWithMaintenanceWindowResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterTaskWithMaintenanceWindowRequest,RegisterTaskWithMaintenanceWindowResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RemoveTagsFromResource


        /// <summary>
        /// Removes all tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromResource service method.</param>
        /// 
        /// <returns>The response from the RemoveTagsFromResource service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidResourceIdException">
        /// The resource ID is not valid. Verify that you entered the correct ID and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidResourceTypeException">
        /// The resource type is not valid. If you are attempting to tag an instance, the instance
        /// must be a registered, managed instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/RemoveTagsFromResource">REST API Reference for RemoveTagsFromResource Operation</seealso>
        public RemoveTagsFromResourceResponse RemoveTagsFromResource(RemoveTagsFromResourceRequest request)
        {
            var marshaller = new RemoveTagsFromResourceRequestMarshaller();
            var unmarshaller = RemoveTagsFromResourceResponseUnmarshaller.Instance;

            return Invoke<RemoveTagsFromResourceRequest,RemoveTagsFromResourceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveTagsFromResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/RemoveTagsFromResource">REST API Reference for RemoveTagsFromResource Operation</seealso>
        public Task<RemoveTagsFromResourceResponse> RemoveTagsFromResourceAsync(RemoveTagsFromResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RemoveTagsFromResourceRequestMarshaller();
            var unmarshaller = RemoveTagsFromResourceResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveTagsFromResourceRequest,RemoveTagsFromResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SendCommand


        /// <summary>
        /// Executes commands on one or more remote instances.
        /// </summary>
        /// <param name="documentName">Required. The name of the SSM document to execute. This can be an SSM public document or a custom document.</param>
        /// <param name="instanceIds">Required. The instance IDs where the command should execute. You can specify a maximum of 50 IDs.</param>
        /// 
        /// <returns>The response from the SendCommand service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DuplicateInstanceIdException">
        /// You cannot specify an instance ID in more than one association.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified document does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  
        /// <para>
        /// You do not have permission to access the instance.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent is not running. On managed instances and Linux instances, verify that
        /// the SSM agent is running. On EC2 Windows instances, verify that the EC2Config service
        /// is running.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent or EC2Config service is not registered to the SSM endpoint. Try reinstalling
        /// the SSM agent or EC2Config service.
        /// </para>
        ///  
        /// <para>
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNotificationConfigException">
        /// One or more configuration items is not valid. Verify that a valid Amazon Resource
        /// Name (ARN) was provided for an Amazon SNS topic.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidOutputFolderException">
        /// The S3 bucket does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidParametersException">
        /// You must specify values for all required parameters in the SSM document. You can only
        /// supply values to parameters defined in the SSM document.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidRoleException">
        /// The role name can't contain invalid characters. Also verify that you specified an
        /// IAM role for notifications that includes the required trust policy. For information
        /// about configuring the IAM role for Run Command notifications, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/rc-sns.html">Getting
        /// Amazon SNS Notifications When a Command Changes Status</a> in the <i>Amazon Elastic
        /// Compute Cloud User Guide </i>.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.MaxDocumentSizeExceededException">
        /// The size limit of an SSM document is 64 KB.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.UnsupportedPlatformTypeException">
        /// The document does not support the platform type of the given instance ID(s). For example,
        /// you sent an SSM document for a Windows instance to a Linux instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/SendCommand">REST API Reference for SendCommand Operation</seealso>
        public SendCommandResponse SendCommand(string documentName, List<string> instanceIds)
        {
            var request = new SendCommandRequest();
            request.DocumentName = documentName;
            request.InstanceIds = instanceIds;
            return SendCommand(request);
        }


        /// <summary>
        /// Executes commands on one or more remote instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendCommand service method.</param>
        /// 
        /// <returns>The response from the SendCommand service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DuplicateInstanceIdException">
        /// You cannot specify an instance ID in more than one association.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified document does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  
        /// <para>
        /// You do not have permission to access the instance.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent is not running. On managed instances and Linux instances, verify that
        /// the SSM agent is running. On EC2 Windows instances, verify that the EC2Config service
        /// is running.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent or EC2Config service is not registered to the SSM endpoint. Try reinstalling
        /// the SSM agent or EC2Config service.
        /// </para>
        ///  
        /// <para>
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNotificationConfigException">
        /// One or more configuration items is not valid. Verify that a valid Amazon Resource
        /// Name (ARN) was provided for an Amazon SNS topic.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidOutputFolderException">
        /// The S3 bucket does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidParametersException">
        /// You must specify values for all required parameters in the SSM document. You can only
        /// supply values to parameters defined in the SSM document.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidRoleException">
        /// The role name can't contain invalid characters. Also verify that you specified an
        /// IAM role for notifications that includes the required trust policy. For information
        /// about configuring the IAM role for Run Command notifications, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/rc-sns.html">Getting
        /// Amazon SNS Notifications When a Command Changes Status</a> in the <i>Amazon Elastic
        /// Compute Cloud User Guide </i>.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.MaxDocumentSizeExceededException">
        /// The size limit of an SSM document is 64 KB.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.UnsupportedPlatformTypeException">
        /// The document does not support the platform type of the given instance ID(s). For example,
        /// you sent an SSM document for a Windows instance to a Linux instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/SendCommand">REST API Reference for SendCommand Operation</seealso>
        public SendCommandResponse SendCommand(SendCommandRequest request)
        {
            var marshaller = new SendCommandRequestMarshaller();
            var unmarshaller = SendCommandResponseUnmarshaller.Instance;

            return Invoke<SendCommandRequest,SendCommandResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Executes commands on one or more remote instances.
        /// </summary>
        /// <param name="documentName">Required. The name of the SSM document to execute. This can be an SSM public document or a custom document.</param>
        /// <param name="instanceIds">Required. The instance IDs where the command should execute. You can specify a maximum of 50 IDs.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendCommand service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DuplicateInstanceIdException">
        /// You cannot specify an instance ID in more than one association.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified document does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  
        /// <para>
        /// You do not have permission to access the instance.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent is not running. On managed instances and Linux instances, verify that
        /// the SSM agent is running. On EC2 Windows instances, verify that the EC2Config service
        /// is running.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent or EC2Config service is not registered to the SSM endpoint. Try reinstalling
        /// the SSM agent or EC2Config service.
        /// </para>
        ///  
        /// <para>
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNotificationConfigException">
        /// One or more configuration items is not valid. Verify that a valid Amazon Resource
        /// Name (ARN) was provided for an Amazon SNS topic.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidOutputFolderException">
        /// The S3 bucket does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidParametersException">
        /// You must specify values for all required parameters in the SSM document. You can only
        /// supply values to parameters defined in the SSM document.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidRoleException">
        /// The role name can't contain invalid characters. Also verify that you specified an
        /// IAM role for notifications that includes the required trust policy. For information
        /// about configuring the IAM role for Run Command notifications, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/rc-sns.html">Getting
        /// Amazon SNS Notifications When a Command Changes Status</a> in the <i>Amazon Elastic
        /// Compute Cloud User Guide </i>.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.MaxDocumentSizeExceededException">
        /// The size limit of an SSM document is 64 KB.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.UnsupportedPlatformTypeException">
        /// The document does not support the platform type of the given instance ID(s). For example,
        /// you sent an SSM document for a Windows instance to a Linux instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/SendCommand">REST API Reference for SendCommand Operation</seealso>
        public Task<SendCommandResponse> SendCommandAsync(string documentName, List<string> instanceIds, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new SendCommandRequest();
            request.DocumentName = documentName;
            request.InstanceIds = instanceIds;
            return SendCommandAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SendCommand operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendCommand operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/SendCommand">REST API Reference for SendCommand Operation</seealso>
        public Task<SendCommandResponse> SendCommandAsync(SendCommandRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SendCommandRequestMarshaller();
            var unmarshaller = SendCommandResponseUnmarshaller.Instance;

            return InvokeAsync<SendCommandRequest,SendCommandResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StartAutomationExecution


        /// <summary>
        /// Initiates execution of an Automation document.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartAutomationExecution service method.</param>
        /// 
        /// <returns>The response from the StartAutomationExecution service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AutomationDefinitionNotFoundException">
        /// An Automation document with the specified name could not be found.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AutomationDefinitionVersionNotFoundException">
        /// An Automation document with the specified name and version could not be found.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AutomationExecutionLimitExceededException">
        /// The number of simultaneously running Automation executions exceeded the allowable
        /// limit.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidAutomationExecutionParametersException">
        /// The supplied parameters for invoking the specified Automation document are incorrect.
        /// For example, they may not match the set of parameters permitted for the specified
        /// Automation document.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/StartAutomationExecution">REST API Reference for StartAutomationExecution Operation</seealso>
        public StartAutomationExecutionResponse StartAutomationExecution(StartAutomationExecutionRequest request)
        {
            var marshaller = new StartAutomationExecutionRequestMarshaller();
            var unmarshaller = StartAutomationExecutionResponseUnmarshaller.Instance;

            return Invoke<StartAutomationExecutionRequest,StartAutomationExecutionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartAutomationExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartAutomationExecution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/StartAutomationExecution">REST API Reference for StartAutomationExecution Operation</seealso>
        public Task<StartAutomationExecutionResponse> StartAutomationExecutionAsync(StartAutomationExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new StartAutomationExecutionRequestMarshaller();
            var unmarshaller = StartAutomationExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<StartAutomationExecutionRequest,StartAutomationExecutionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StopAutomationExecution


        /// <summary>
        /// Stop an Automation that is currently executing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopAutomationExecution service method.</param>
        /// 
        /// <returns>The response from the StopAutomationExecution service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AutomationExecutionNotFoundException">
        /// There is no automation execution information for the requested automation execution
        /// ID.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/StopAutomationExecution">REST API Reference for StopAutomationExecution Operation</seealso>
        public StopAutomationExecutionResponse StopAutomationExecution(StopAutomationExecutionRequest request)
        {
            var marshaller = new StopAutomationExecutionRequestMarshaller();
            var unmarshaller = StopAutomationExecutionResponseUnmarshaller.Instance;

            return Invoke<StopAutomationExecutionRequest,StopAutomationExecutionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopAutomationExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopAutomationExecution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/StopAutomationExecution">REST API Reference for StopAutomationExecution Operation</seealso>
        public Task<StopAutomationExecutionResponse> StopAutomationExecutionAsync(StopAutomationExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new StopAutomationExecutionRequestMarshaller();
            var unmarshaller = StopAutomationExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<StopAutomationExecutionRequest,StopAutomationExecutionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateAssociation


        /// <summary>
        /// Updates an association. You can only update the document version, schedule, parameters,
        /// and Amazon S3 output of an association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssociation service method.</param>
        /// 
        /// <returns>The response from the UpdateAssociation service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationDoesNotExistException">
        /// The specified association does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentVersionException">
        /// The document version is not valid or does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidOutputLocationException">
        /// The output location is not valid or does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidParametersException">
        /// You must specify values for all required parameters in the SSM document. You can only
        /// supply values to parameters defined in the SSM document.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidScheduleException">
        /// The schedule is invalid. Verify your cron or rate expression and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidUpdateException">
        /// The update is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TooManyUpdatesException">
        /// There are concurrent updates for a resource that supports one update at a time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateAssociation">REST API Reference for UpdateAssociation Operation</seealso>
        public UpdateAssociationResponse UpdateAssociation(UpdateAssociationRequest request)
        {
            var marshaller = new UpdateAssociationRequestMarshaller();
            var unmarshaller = UpdateAssociationResponseUnmarshaller.Instance;

            return Invoke<UpdateAssociationRequest,UpdateAssociationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssociation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateAssociation">REST API Reference for UpdateAssociation Operation</seealso>
        public Task<UpdateAssociationResponse> UpdateAssociationAsync(UpdateAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateAssociationRequestMarshaller();
            var unmarshaller = UpdateAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAssociationRequest,UpdateAssociationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateAssociationStatus


        /// <summary>
        /// Updates the status of the SSM document associated with the specified instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssociationStatus service method.</param>
        /// 
        /// <returns>The response from the UpdateAssociationStatus service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationDoesNotExistException">
        /// The specified association does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified document does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  
        /// <para>
        /// You do not have permission to access the instance.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent is not running. On managed instances and Linux instances, verify that
        /// the SSM agent is running. On EC2 Windows instances, verify that the EC2Config service
        /// is running.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent or EC2Config service is not registered to the SSM endpoint. Try reinstalling
        /// the SSM agent or EC2Config service.
        /// </para>
        ///  
        /// <para>
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.StatusUnchangedException">
        /// The updated status is the same as the current status.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TooManyUpdatesException">
        /// There are concurrent updates for a resource that supports one update at a time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateAssociationStatus">REST API Reference for UpdateAssociationStatus Operation</seealso>
        public UpdateAssociationStatusResponse UpdateAssociationStatus(UpdateAssociationStatusRequest request)
        {
            var marshaller = new UpdateAssociationStatusRequestMarshaller();
            var unmarshaller = UpdateAssociationStatusResponseUnmarshaller.Instance;

            return Invoke<UpdateAssociationStatusRequest,UpdateAssociationStatusResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAssociationStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssociationStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateAssociationStatus">REST API Reference for UpdateAssociationStatus Operation</seealso>
        public Task<UpdateAssociationStatusResponse> UpdateAssociationStatusAsync(UpdateAssociationStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateAssociationStatusRequestMarshaller();
            var unmarshaller = UpdateAssociationStatusResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAssociationStatusRequest,UpdateAssociationStatusResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateDocument


        /// <summary>
        /// The document you want to update.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDocument service method.</param>
        /// 
        /// <returns>The response from the UpdateDocument service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DocumentVersionLimitExceededException">
        /// The document has too many versions. Delete one or more document versions and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DuplicateDocumentContentException">
        /// The content of the association document matches another document. Change the content
        /// of the document and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentContentException">
        /// The content for the SSM document is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified document does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentSchemaVersionException">
        /// The version of the document schema is not supported.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentVersionException">
        /// The document version is not valid or does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.MaxDocumentSizeExceededException">
        /// The size limit of an SSM document is 64 KB.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateDocument">REST API Reference for UpdateDocument Operation</seealso>
        public UpdateDocumentResponse UpdateDocument(UpdateDocumentRequest request)
        {
            var marshaller = new UpdateDocumentRequestMarshaller();
            var unmarshaller = UpdateDocumentResponseUnmarshaller.Instance;

            return Invoke<UpdateDocumentRequest,UpdateDocumentResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDocument operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDocument operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateDocument">REST API Reference for UpdateDocument Operation</seealso>
        public Task<UpdateDocumentResponse> UpdateDocumentAsync(UpdateDocumentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateDocumentRequestMarshaller();
            var unmarshaller = UpdateDocumentResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDocumentRequest,UpdateDocumentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateDocumentDefaultVersion


        /// <summary>
        /// Set the default version of a document.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDocumentDefaultVersion service method.</param>
        /// 
        /// <returns>The response from the UpdateDocumentDefaultVersion service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified document does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentSchemaVersionException">
        /// The version of the document schema is not supported.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentVersionException">
        /// The document version is not valid or does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateDocumentDefaultVersion">REST API Reference for UpdateDocumentDefaultVersion Operation</seealso>
        public UpdateDocumentDefaultVersionResponse UpdateDocumentDefaultVersion(UpdateDocumentDefaultVersionRequest request)
        {
            var marshaller = new UpdateDocumentDefaultVersionRequestMarshaller();
            var unmarshaller = UpdateDocumentDefaultVersionResponseUnmarshaller.Instance;

            return Invoke<UpdateDocumentDefaultVersionRequest,UpdateDocumentDefaultVersionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDocumentDefaultVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDocumentDefaultVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateDocumentDefaultVersion">REST API Reference for UpdateDocumentDefaultVersion Operation</seealso>
        public Task<UpdateDocumentDefaultVersionResponse> UpdateDocumentDefaultVersionAsync(UpdateDocumentDefaultVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateDocumentDefaultVersionRequestMarshaller();
            var unmarshaller = UpdateDocumentDefaultVersionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDocumentDefaultVersionRequest,UpdateDocumentDefaultVersionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateMaintenanceWindow


        /// <summary>
        /// Updates an existing Maintenance Window. Only specified parameters are modified.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMaintenanceWindow service method.</param>
        /// 
        /// <returns>The response from the UpdateMaintenanceWindow service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource (e.g. a Maintenance Window) doesn’t
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateMaintenanceWindow">REST API Reference for UpdateMaintenanceWindow Operation</seealso>
        public UpdateMaintenanceWindowResponse UpdateMaintenanceWindow(UpdateMaintenanceWindowRequest request)
        {
            var marshaller = new UpdateMaintenanceWindowRequestMarshaller();
            var unmarshaller = UpdateMaintenanceWindowResponseUnmarshaller.Instance;

            return Invoke<UpdateMaintenanceWindowRequest,UpdateMaintenanceWindowResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMaintenanceWindow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMaintenanceWindow operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateMaintenanceWindow">REST API Reference for UpdateMaintenanceWindow Operation</seealso>
        public Task<UpdateMaintenanceWindowResponse> UpdateMaintenanceWindowAsync(UpdateMaintenanceWindowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateMaintenanceWindowRequestMarshaller();
            var unmarshaller = UpdateMaintenanceWindowResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateMaintenanceWindowRequest,UpdateMaintenanceWindowResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateManagedInstanceRole


        /// <summary>
        /// Assigns or changes an Amazon Identity and Access Management (IAM) role to the managed
        /// instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateManagedInstanceRole service method.</param>
        /// 
        /// <returns>The response from the UpdateManagedInstanceRole service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  
        /// <para>
        /// You do not have permission to access the instance.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent is not running. On managed instances and Linux instances, verify that
        /// the SSM agent is running. On EC2 Windows instances, verify that the EC2Config service
        /// is running.
        /// </para>
        ///  
        /// <para>
        /// The SSM agent or EC2Config service is not registered to the SSM endpoint. Try reinstalling
        /// the SSM agent or EC2Config service.
        /// </para>
        ///  
        /// <para>
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateManagedInstanceRole">REST API Reference for UpdateManagedInstanceRole Operation</seealso>
        public UpdateManagedInstanceRoleResponse UpdateManagedInstanceRole(UpdateManagedInstanceRoleRequest request)
        {
            var marshaller = new UpdateManagedInstanceRoleRequestMarshaller();
            var unmarshaller = UpdateManagedInstanceRoleResponseUnmarshaller.Instance;

            return Invoke<UpdateManagedInstanceRoleRequest,UpdateManagedInstanceRoleResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateManagedInstanceRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateManagedInstanceRole operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateManagedInstanceRole">REST API Reference for UpdateManagedInstanceRole Operation</seealso>
        public Task<UpdateManagedInstanceRoleResponse> UpdateManagedInstanceRoleAsync(UpdateManagedInstanceRoleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateManagedInstanceRoleRequestMarshaller();
            var unmarshaller = UpdateManagedInstanceRoleResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateManagedInstanceRoleRequest,UpdateManagedInstanceRoleResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdatePatchBaseline


        /// <summary>
        /// Modifies an existing patch baseline. Fields not specified in the request are left
        /// unchanged.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePatchBaseline service method.</param>
        /// 
        /// <returns>The response from the UpdatePatchBaseline service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource (e.g. a Maintenance Window) doesn’t
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdatePatchBaseline">REST API Reference for UpdatePatchBaseline Operation</seealso>
        public UpdatePatchBaselineResponse UpdatePatchBaseline(UpdatePatchBaselineRequest request)
        {
            var marshaller = new UpdatePatchBaselineRequestMarshaller();
            var unmarshaller = UpdatePatchBaselineResponseUnmarshaller.Instance;

            return Invoke<UpdatePatchBaselineRequest,UpdatePatchBaselineResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePatchBaseline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePatchBaseline operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdatePatchBaseline">REST API Reference for UpdatePatchBaseline Operation</seealso>
        public Task<UpdatePatchBaselineResponse> UpdatePatchBaselineAsync(UpdatePatchBaselineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdatePatchBaselineRequestMarshaller();
            var unmarshaller = UpdatePatchBaselineResponseUnmarshaller.Instance;

            return InvokeAsync<UpdatePatchBaselineRequest,UpdatePatchBaselineResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}