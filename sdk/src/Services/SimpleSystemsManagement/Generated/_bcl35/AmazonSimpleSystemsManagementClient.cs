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
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToResource operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddTagsToResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/AddTagsToResource">REST API Reference for AddTagsToResource Operation</seealso>
        public IAsyncResult BeginAddTagsToResource(AddTagsToResourceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new AddTagsToResourceRequestMarshaller();
            var unmarshaller = AddTagsToResourceResponseUnmarshaller.Instance;

            return BeginInvoke<AddTagsToResourceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AddTagsToResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddTagsToResource.</param>
        /// 
        /// <returns>Returns a  AddTagsToResourceResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/AddTagsToResource">REST API Reference for AddTagsToResource Operation</seealso>
        public  AddTagsToResourceResponse EndAddTagsToResource(IAsyncResult asyncResult)
        {
            return EndInvoke<AddTagsToResourceResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the CancelCommand operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelCommand operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelCommand
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CancelCommand">REST API Reference for CancelCommand Operation</seealso>
        public IAsyncResult BeginCancelCommand(CancelCommandRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CancelCommandRequestMarshaller();
            var unmarshaller = CancelCommandResponseUnmarshaller.Instance;

            return BeginInvoke<CancelCommandRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CancelCommand operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelCommand.</param>
        /// 
        /// <returns>Returns a  CancelCommandResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CancelCommand">REST API Reference for CancelCommand Operation</seealso>
        public  CancelCommandResponse EndCancelCommand(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelCommandResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the CreateActivation operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateActivation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateActivation">REST API Reference for CreateActivation Operation</seealso>
        public IAsyncResult BeginCreateActivation(CreateActivationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateActivationRequestMarshaller();
            var unmarshaller = CreateActivationResponseUnmarshaller.Instance;

            return BeginInvoke<CreateActivationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateActivation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateActivation.</param>
        /// 
        /// <returns>Returns a  CreateActivationResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateActivation">REST API Reference for CreateActivation Operation</seealso>
        public  CreateActivationResponse EndCreateActivation(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateActivationResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the CreateAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAssociation operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateAssociation">REST API Reference for CreateAssociation Operation</seealso>
        public IAsyncResult BeginCreateAssociation(CreateAssociationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateAssociationRequestMarshaller();
            var unmarshaller = CreateAssociationResponseUnmarshaller.Instance;

            return BeginInvoke<CreateAssociationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAssociation.</param>
        /// 
        /// <returns>Returns a  CreateAssociationResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateAssociation">REST API Reference for CreateAssociation Operation</seealso>
        public  CreateAssociationResponse EndCreateAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAssociationResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the CreateAssociationBatch operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAssociationBatch
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateAssociationBatch">REST API Reference for CreateAssociationBatch Operation</seealso>
        public IAsyncResult BeginCreateAssociationBatch(CreateAssociationBatchRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateAssociationBatchRequestMarshaller();
            var unmarshaller = CreateAssociationBatchResponseUnmarshaller.Instance;

            return BeginInvoke<CreateAssociationBatchRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAssociationBatch operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAssociationBatch.</param>
        /// 
        /// <returns>Returns a  CreateAssociationBatchResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateAssociationBatch">REST API Reference for CreateAssociationBatch Operation</seealso>
        public  CreateAssociationBatchResponse EndCreateAssociationBatch(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAssociationBatchResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the CreateDocument operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDocument operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDocument
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateDocument">REST API Reference for CreateDocument Operation</seealso>
        public IAsyncResult BeginCreateDocument(CreateDocumentRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateDocumentRequestMarshaller();
            var unmarshaller = CreateDocumentResponseUnmarshaller.Instance;

            return BeginInvoke<CreateDocumentRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDocument operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDocument.</param>
        /// 
        /// <returns>Returns a  CreateDocumentResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateDocument">REST API Reference for CreateDocument Operation</seealso>
        public  CreateDocumentResponse EndCreateDocument(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDocumentResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the CreateMaintenanceWindow operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMaintenanceWindow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateMaintenanceWindow">REST API Reference for CreateMaintenanceWindow Operation</seealso>
        public IAsyncResult BeginCreateMaintenanceWindow(CreateMaintenanceWindowRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateMaintenanceWindowRequestMarshaller();
            var unmarshaller = CreateMaintenanceWindowResponseUnmarshaller.Instance;

            return BeginInvoke<CreateMaintenanceWindowRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMaintenanceWindow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMaintenanceWindow.</param>
        /// 
        /// <returns>Returns a  CreateMaintenanceWindowResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateMaintenanceWindow">REST API Reference for CreateMaintenanceWindow Operation</seealso>
        public  CreateMaintenanceWindowResponse EndCreateMaintenanceWindow(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateMaintenanceWindowResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the CreatePatchBaseline operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePatchBaseline
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreatePatchBaseline">REST API Reference for CreatePatchBaseline Operation</seealso>
        public IAsyncResult BeginCreatePatchBaseline(CreatePatchBaselineRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreatePatchBaselineRequestMarshaller();
            var unmarshaller = CreatePatchBaselineResponseUnmarshaller.Instance;

            return BeginInvoke<CreatePatchBaselineRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePatchBaseline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePatchBaseline.</param>
        /// 
        /// <returns>Returns a  CreatePatchBaselineResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreatePatchBaseline">REST API Reference for CreatePatchBaseline Operation</seealso>
        public  CreatePatchBaselineResponse EndCreatePatchBaseline(IAsyncResult asyncResult)
        {
            return EndInvoke<CreatePatchBaselineResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteActivation operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteActivation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteActivation">REST API Reference for DeleteActivation Operation</seealso>
        public IAsyncResult BeginDeleteActivation(DeleteActivationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteActivationRequestMarshaller();
            var unmarshaller = DeleteActivationResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteActivationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteActivation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteActivation.</param>
        /// 
        /// <returns>Returns a  DeleteActivationResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteActivation">REST API Reference for DeleteActivation Operation</seealso>
        public  DeleteActivationResponse EndDeleteActivation(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteActivationResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DeleteAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssociation operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteAssociation">REST API Reference for DeleteAssociation Operation</seealso>
        public IAsyncResult BeginDeleteAssociation(DeleteAssociationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteAssociationRequestMarshaller();
            var unmarshaller = DeleteAssociationResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteAssociationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAssociation.</param>
        /// 
        /// <returns>Returns a  DeleteAssociationResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteAssociation">REST API Reference for DeleteAssociation Operation</seealso>
        public  DeleteAssociationResponse EndDeleteAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAssociationResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DeleteDocument operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDocument operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDocument
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteDocument">REST API Reference for DeleteDocument Operation</seealso>
        public IAsyncResult BeginDeleteDocument(DeleteDocumentRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteDocumentRequestMarshaller();
            var unmarshaller = DeleteDocumentResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteDocumentRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDocument operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDocument.</param>
        /// 
        /// <returns>Returns a  DeleteDocumentResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteDocument">REST API Reference for DeleteDocument Operation</seealso>
        public  DeleteDocumentResponse EndDeleteDocument(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDocumentResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteMaintenanceWindow operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMaintenanceWindow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteMaintenanceWindow">REST API Reference for DeleteMaintenanceWindow Operation</seealso>
        public IAsyncResult BeginDeleteMaintenanceWindow(DeleteMaintenanceWindowRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteMaintenanceWindowRequestMarshaller();
            var unmarshaller = DeleteMaintenanceWindowResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteMaintenanceWindowRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMaintenanceWindow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMaintenanceWindow.</param>
        /// 
        /// <returns>Returns a  DeleteMaintenanceWindowResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteMaintenanceWindow">REST API Reference for DeleteMaintenanceWindow Operation</seealso>
        public  DeleteMaintenanceWindowResponse EndDeleteMaintenanceWindow(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteMaintenanceWindowResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteParameter operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteParameter
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteParameter">REST API Reference for DeleteParameter Operation</seealso>
        public IAsyncResult BeginDeleteParameter(DeleteParameterRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteParameterRequestMarshaller();
            var unmarshaller = DeleteParameterResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteParameterRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteParameter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteParameter.</param>
        /// 
        /// <returns>Returns a  DeleteParameterResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteParameter">REST API Reference for DeleteParameter Operation</seealso>
        public  DeleteParameterResponse EndDeleteParameter(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteParameterResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the DeletePatchBaseline operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePatchBaseline
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeletePatchBaseline">REST API Reference for DeletePatchBaseline Operation</seealso>
        public IAsyncResult BeginDeletePatchBaseline(DeletePatchBaselineRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeletePatchBaselineRequestMarshaller();
            var unmarshaller = DeletePatchBaselineResponseUnmarshaller.Instance;

            return BeginInvoke<DeletePatchBaselineRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePatchBaseline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePatchBaseline.</param>
        /// 
        /// <returns>Returns a  DeletePatchBaselineResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeletePatchBaseline">REST API Reference for DeletePatchBaseline Operation</seealso>
        public  DeletePatchBaselineResponse EndDeletePatchBaseline(IAsyncResult asyncResult)
        {
            return EndInvoke<DeletePatchBaselineResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the DeregisterManagedInstance operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeregisterManagedInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeregisterManagedInstance">REST API Reference for DeregisterManagedInstance Operation</seealso>
        public IAsyncResult BeginDeregisterManagedInstance(DeregisterManagedInstanceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeregisterManagedInstanceRequestMarshaller();
            var unmarshaller = DeregisterManagedInstanceResponseUnmarshaller.Instance;

            return BeginInvoke<DeregisterManagedInstanceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterManagedInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterManagedInstance.</param>
        /// 
        /// <returns>Returns a  DeregisterManagedInstanceResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeregisterManagedInstance">REST API Reference for DeregisterManagedInstance Operation</seealso>
        public  DeregisterManagedInstanceResponse EndDeregisterManagedInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<DeregisterManagedInstanceResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the DeregisterPatchBaselineForPatchGroup operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeregisterPatchBaselineForPatchGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeregisterPatchBaselineForPatchGroup">REST API Reference for DeregisterPatchBaselineForPatchGroup Operation</seealso>
        public IAsyncResult BeginDeregisterPatchBaselineForPatchGroup(DeregisterPatchBaselineForPatchGroupRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeregisterPatchBaselineForPatchGroupRequestMarshaller();
            var unmarshaller = DeregisterPatchBaselineForPatchGroupResponseUnmarshaller.Instance;

            return BeginInvoke<DeregisterPatchBaselineForPatchGroupRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterPatchBaselineForPatchGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterPatchBaselineForPatchGroup.</param>
        /// 
        /// <returns>Returns a  DeregisterPatchBaselineForPatchGroupResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeregisterPatchBaselineForPatchGroup">REST API Reference for DeregisterPatchBaselineForPatchGroup Operation</seealso>
        public  DeregisterPatchBaselineForPatchGroupResponse EndDeregisterPatchBaselineForPatchGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DeregisterPatchBaselineForPatchGroupResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the DeregisterTargetFromMaintenanceWindow operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeregisterTargetFromMaintenanceWindow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeregisterTargetFromMaintenanceWindow">REST API Reference for DeregisterTargetFromMaintenanceWindow Operation</seealso>
        public IAsyncResult BeginDeregisterTargetFromMaintenanceWindow(DeregisterTargetFromMaintenanceWindowRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeregisterTargetFromMaintenanceWindowRequestMarshaller();
            var unmarshaller = DeregisterTargetFromMaintenanceWindowResponseUnmarshaller.Instance;

            return BeginInvoke<DeregisterTargetFromMaintenanceWindowRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterTargetFromMaintenanceWindow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterTargetFromMaintenanceWindow.</param>
        /// 
        /// <returns>Returns a  DeregisterTargetFromMaintenanceWindowResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeregisterTargetFromMaintenanceWindow">REST API Reference for DeregisterTargetFromMaintenanceWindow Operation</seealso>
        public  DeregisterTargetFromMaintenanceWindowResponse EndDeregisterTargetFromMaintenanceWindow(IAsyncResult asyncResult)
        {
            return EndInvoke<DeregisterTargetFromMaintenanceWindowResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the DeregisterTaskFromMaintenanceWindow operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeregisterTaskFromMaintenanceWindow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeregisterTaskFromMaintenanceWindow">REST API Reference for DeregisterTaskFromMaintenanceWindow Operation</seealso>
        public IAsyncResult BeginDeregisterTaskFromMaintenanceWindow(DeregisterTaskFromMaintenanceWindowRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeregisterTaskFromMaintenanceWindowRequestMarshaller();
            var unmarshaller = DeregisterTaskFromMaintenanceWindowResponseUnmarshaller.Instance;

            return BeginInvoke<DeregisterTaskFromMaintenanceWindowRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterTaskFromMaintenanceWindow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterTaskFromMaintenanceWindow.</param>
        /// 
        /// <returns>Returns a  DeregisterTaskFromMaintenanceWindowResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeregisterTaskFromMaintenanceWindow">REST API Reference for DeregisterTaskFromMaintenanceWindow Operation</seealso>
        public  DeregisterTaskFromMaintenanceWindowResponse EndDeregisterTaskFromMaintenanceWindow(IAsyncResult asyncResult)
        {
            return EndInvoke<DeregisterTaskFromMaintenanceWindowResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeActivations operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeActivations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeActivations">REST API Reference for DescribeActivations Operation</seealso>
        public IAsyncResult BeginDescribeActivations(DescribeActivationsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeActivationsRequestMarshaller();
            var unmarshaller = DescribeActivationsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeActivationsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeActivations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeActivations.</param>
        /// 
        /// <returns>Returns a  DescribeActivationsResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeActivations">REST API Reference for DescribeActivations Operation</seealso>
        public  DescribeActivationsResponse EndDescribeActivations(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeActivationsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DescribeAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssociation operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeAssociation">REST API Reference for DescribeAssociation Operation</seealso>
        public IAsyncResult BeginDescribeAssociation(DescribeAssociationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeAssociationRequestMarshaller();
            var unmarshaller = DescribeAssociationResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeAssociationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAssociation.</param>
        /// 
        /// <returns>Returns a  DescribeAssociationResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeAssociation">REST API Reference for DescribeAssociation Operation</seealso>
        public  DescribeAssociationResponse EndDescribeAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAssociationResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutomationExecutions operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAutomationExecutions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeAutomationExecutions">REST API Reference for DescribeAutomationExecutions Operation</seealso>
        public IAsyncResult BeginDescribeAutomationExecutions(DescribeAutomationExecutionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeAutomationExecutionsRequestMarshaller();
            var unmarshaller = DescribeAutomationExecutionsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeAutomationExecutionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAutomationExecutions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAutomationExecutions.</param>
        /// 
        /// <returns>Returns a  DescribeAutomationExecutionsResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeAutomationExecutions">REST API Reference for DescribeAutomationExecutions Operation</seealso>
        public  DescribeAutomationExecutionsResponse EndDescribeAutomationExecutions(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAutomationExecutionsResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeAvailablePatches operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAvailablePatches
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeAvailablePatches">REST API Reference for DescribeAvailablePatches Operation</seealso>
        public IAsyncResult BeginDescribeAvailablePatches(DescribeAvailablePatchesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeAvailablePatchesRequestMarshaller();
            var unmarshaller = DescribeAvailablePatchesResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeAvailablePatchesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAvailablePatches operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAvailablePatches.</param>
        /// 
        /// <returns>Returns a  DescribeAvailablePatchesResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeAvailablePatches">REST API Reference for DescribeAvailablePatches Operation</seealso>
        public  DescribeAvailablePatchesResponse EndDescribeAvailablePatches(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAvailablePatchesResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DescribeDocument operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDocument operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDocument
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeDocument">REST API Reference for DescribeDocument Operation</seealso>
        public IAsyncResult BeginDescribeDocument(DescribeDocumentRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeDocumentRequestMarshaller();
            var unmarshaller = DescribeDocumentResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeDocumentRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDocument operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDocument.</param>
        /// 
        /// <returns>Returns a  DescribeDocumentResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeDocument">REST API Reference for DescribeDocument Operation</seealso>
        public  DescribeDocumentResponse EndDescribeDocument(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDocumentResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeDocumentPermission operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDocumentPermission
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeDocumentPermission">REST API Reference for DescribeDocumentPermission Operation</seealso>
        public IAsyncResult BeginDescribeDocumentPermission(DescribeDocumentPermissionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeDocumentPermissionRequestMarshaller();
            var unmarshaller = DescribeDocumentPermissionResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeDocumentPermissionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDocumentPermission operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDocumentPermission.</param>
        /// 
        /// <returns>Returns a  DescribeDocumentPermissionResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeDocumentPermission">REST API Reference for DescribeDocumentPermission Operation</seealso>
        public  DescribeDocumentPermissionResponse EndDescribeDocumentPermission(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDocumentPermissionResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeEffectiveInstanceAssociations operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEffectiveInstanceAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeEffectiveInstanceAssociations">REST API Reference for DescribeEffectiveInstanceAssociations Operation</seealso>
        public IAsyncResult BeginDescribeEffectiveInstanceAssociations(DescribeEffectiveInstanceAssociationsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeEffectiveInstanceAssociationsRequestMarshaller();
            var unmarshaller = DescribeEffectiveInstanceAssociationsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeEffectiveInstanceAssociationsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEffectiveInstanceAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEffectiveInstanceAssociations.</param>
        /// 
        /// <returns>Returns a  DescribeEffectiveInstanceAssociationsResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeEffectiveInstanceAssociations">REST API Reference for DescribeEffectiveInstanceAssociations Operation</seealso>
        public  DescribeEffectiveInstanceAssociationsResponse EndDescribeEffectiveInstanceAssociations(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeEffectiveInstanceAssociationsResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeEffectivePatchesForPatchBaseline operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEffectivePatchesForPatchBaseline
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeEffectivePatchesForPatchBaseline">REST API Reference for DescribeEffectivePatchesForPatchBaseline Operation</seealso>
        public IAsyncResult BeginDescribeEffectivePatchesForPatchBaseline(DescribeEffectivePatchesForPatchBaselineRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeEffectivePatchesForPatchBaselineRequestMarshaller();
            var unmarshaller = DescribeEffectivePatchesForPatchBaselineResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeEffectivePatchesForPatchBaselineRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEffectivePatchesForPatchBaseline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEffectivePatchesForPatchBaseline.</param>
        /// 
        /// <returns>Returns a  DescribeEffectivePatchesForPatchBaselineResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeEffectivePatchesForPatchBaseline">REST API Reference for DescribeEffectivePatchesForPatchBaseline Operation</seealso>
        public  DescribeEffectivePatchesForPatchBaselineResponse EndDescribeEffectivePatchesForPatchBaseline(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeEffectivePatchesForPatchBaselineResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceAssociationsStatus operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeInstanceAssociationsStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeInstanceAssociationsStatus">REST API Reference for DescribeInstanceAssociationsStatus Operation</seealso>
        public IAsyncResult BeginDescribeInstanceAssociationsStatus(DescribeInstanceAssociationsStatusRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeInstanceAssociationsStatusRequestMarshaller();
            var unmarshaller = DescribeInstanceAssociationsStatusResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeInstanceAssociationsStatusRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeInstanceAssociationsStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInstanceAssociationsStatus.</param>
        /// 
        /// <returns>Returns a  DescribeInstanceAssociationsStatusResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeInstanceAssociationsStatus">REST API Reference for DescribeInstanceAssociationsStatus Operation</seealso>
        public  DescribeInstanceAssociationsStatusResponse EndDescribeInstanceAssociationsStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeInstanceAssociationsStatusResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DescribeInstanceInformation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceInformation operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeInstanceInformation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeInstanceInformation">REST API Reference for DescribeInstanceInformation Operation</seealso>
        public IAsyncResult BeginDescribeInstanceInformation(DescribeInstanceInformationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeInstanceInformationRequestMarshaller();
            var unmarshaller = DescribeInstanceInformationResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeInstanceInformationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeInstanceInformation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInstanceInformation.</param>
        /// 
        /// <returns>Returns a  DescribeInstanceInformationResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeInstanceInformation">REST API Reference for DescribeInstanceInformation Operation</seealso>
        public  DescribeInstanceInformationResponse EndDescribeInstanceInformation(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeInstanceInformationResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstancePatches operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeInstancePatches
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeInstancePatches">REST API Reference for DescribeInstancePatches Operation</seealso>
        public IAsyncResult BeginDescribeInstancePatches(DescribeInstancePatchesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeInstancePatchesRequestMarshaller();
            var unmarshaller = DescribeInstancePatchesResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeInstancePatchesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeInstancePatches operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInstancePatches.</param>
        /// 
        /// <returns>Returns a  DescribeInstancePatchesResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeInstancePatches">REST API Reference for DescribeInstancePatches Operation</seealso>
        public  DescribeInstancePatchesResponse EndDescribeInstancePatches(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeInstancePatchesResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstancePatchStates operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeInstancePatchStates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeInstancePatchStates">REST API Reference for DescribeInstancePatchStates Operation</seealso>
        public IAsyncResult BeginDescribeInstancePatchStates(DescribeInstancePatchStatesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeInstancePatchStatesRequestMarshaller();
            var unmarshaller = DescribeInstancePatchStatesResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeInstancePatchStatesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeInstancePatchStates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInstancePatchStates.</param>
        /// 
        /// <returns>Returns a  DescribeInstancePatchStatesResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeInstancePatchStates">REST API Reference for DescribeInstancePatchStates Operation</seealso>
        public  DescribeInstancePatchStatesResponse EndDescribeInstancePatchStates(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeInstancePatchStatesResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstancePatchStatesForPatchGroup operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeInstancePatchStatesForPatchGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeInstancePatchStatesForPatchGroup">REST API Reference for DescribeInstancePatchStatesForPatchGroup Operation</seealso>
        public IAsyncResult BeginDescribeInstancePatchStatesForPatchGroup(DescribeInstancePatchStatesForPatchGroupRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeInstancePatchStatesForPatchGroupRequestMarshaller();
            var unmarshaller = DescribeInstancePatchStatesForPatchGroupResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeInstancePatchStatesForPatchGroupRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeInstancePatchStatesForPatchGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInstancePatchStatesForPatchGroup.</param>
        /// 
        /// <returns>Returns a  DescribeInstancePatchStatesForPatchGroupResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeInstancePatchStatesForPatchGroup">REST API Reference for DescribeInstancePatchStatesForPatchGroup Operation</seealso>
        public  DescribeInstancePatchStatesForPatchGroupResponse EndDescribeInstancePatchStatesForPatchGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeInstancePatchStatesForPatchGroupResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceWindowExecutions operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeMaintenanceWindowExecutions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeMaintenanceWindowExecutions">REST API Reference for DescribeMaintenanceWindowExecutions Operation</seealso>
        public IAsyncResult BeginDescribeMaintenanceWindowExecutions(DescribeMaintenanceWindowExecutionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeMaintenanceWindowExecutionsRequestMarshaller();
            var unmarshaller = DescribeMaintenanceWindowExecutionsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeMaintenanceWindowExecutionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeMaintenanceWindowExecutions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeMaintenanceWindowExecutions.</param>
        /// 
        /// <returns>Returns a  DescribeMaintenanceWindowExecutionsResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeMaintenanceWindowExecutions">REST API Reference for DescribeMaintenanceWindowExecutions Operation</seealso>
        public  DescribeMaintenanceWindowExecutionsResponse EndDescribeMaintenanceWindowExecutions(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeMaintenanceWindowExecutionsResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceWindowExecutionTaskInvocations operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeMaintenanceWindowExecutionTaskInvocations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeMaintenanceWindowExecutionTaskInvocations">REST API Reference for DescribeMaintenanceWindowExecutionTaskInvocations Operation</seealso>
        public IAsyncResult BeginDescribeMaintenanceWindowExecutionTaskInvocations(DescribeMaintenanceWindowExecutionTaskInvocationsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeMaintenanceWindowExecutionTaskInvocationsRequestMarshaller();
            var unmarshaller = DescribeMaintenanceWindowExecutionTaskInvocationsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeMaintenanceWindowExecutionTaskInvocationsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeMaintenanceWindowExecutionTaskInvocations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeMaintenanceWindowExecutionTaskInvocations.</param>
        /// 
        /// <returns>Returns a  DescribeMaintenanceWindowExecutionTaskInvocationsResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeMaintenanceWindowExecutionTaskInvocations">REST API Reference for DescribeMaintenanceWindowExecutionTaskInvocations Operation</seealso>
        public  DescribeMaintenanceWindowExecutionTaskInvocationsResponse EndDescribeMaintenanceWindowExecutionTaskInvocations(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeMaintenanceWindowExecutionTaskInvocationsResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceWindowExecutionTasks operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeMaintenanceWindowExecutionTasks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeMaintenanceWindowExecutionTasks">REST API Reference for DescribeMaintenanceWindowExecutionTasks Operation</seealso>
        public IAsyncResult BeginDescribeMaintenanceWindowExecutionTasks(DescribeMaintenanceWindowExecutionTasksRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeMaintenanceWindowExecutionTasksRequestMarshaller();
            var unmarshaller = DescribeMaintenanceWindowExecutionTasksResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeMaintenanceWindowExecutionTasksRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeMaintenanceWindowExecutionTasks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeMaintenanceWindowExecutionTasks.</param>
        /// 
        /// <returns>Returns a  DescribeMaintenanceWindowExecutionTasksResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeMaintenanceWindowExecutionTasks">REST API Reference for DescribeMaintenanceWindowExecutionTasks Operation</seealso>
        public  DescribeMaintenanceWindowExecutionTasksResponse EndDescribeMaintenanceWindowExecutionTasks(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeMaintenanceWindowExecutionTasksResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceWindows operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeMaintenanceWindows
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeMaintenanceWindows">REST API Reference for DescribeMaintenanceWindows Operation</seealso>
        public IAsyncResult BeginDescribeMaintenanceWindows(DescribeMaintenanceWindowsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeMaintenanceWindowsRequestMarshaller();
            var unmarshaller = DescribeMaintenanceWindowsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeMaintenanceWindowsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeMaintenanceWindows operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeMaintenanceWindows.</param>
        /// 
        /// <returns>Returns a  DescribeMaintenanceWindowsResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeMaintenanceWindows">REST API Reference for DescribeMaintenanceWindows Operation</seealso>
        public  DescribeMaintenanceWindowsResponse EndDescribeMaintenanceWindows(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeMaintenanceWindowsResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceWindowTargets operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeMaintenanceWindowTargets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeMaintenanceWindowTargets">REST API Reference for DescribeMaintenanceWindowTargets Operation</seealso>
        public IAsyncResult BeginDescribeMaintenanceWindowTargets(DescribeMaintenanceWindowTargetsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeMaintenanceWindowTargetsRequestMarshaller();
            var unmarshaller = DescribeMaintenanceWindowTargetsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeMaintenanceWindowTargetsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeMaintenanceWindowTargets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeMaintenanceWindowTargets.</param>
        /// 
        /// <returns>Returns a  DescribeMaintenanceWindowTargetsResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeMaintenanceWindowTargets">REST API Reference for DescribeMaintenanceWindowTargets Operation</seealso>
        public  DescribeMaintenanceWindowTargetsResponse EndDescribeMaintenanceWindowTargets(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeMaintenanceWindowTargetsResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceWindowTasks operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeMaintenanceWindowTasks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeMaintenanceWindowTasks">REST API Reference for DescribeMaintenanceWindowTasks Operation</seealso>
        public IAsyncResult BeginDescribeMaintenanceWindowTasks(DescribeMaintenanceWindowTasksRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeMaintenanceWindowTasksRequestMarshaller();
            var unmarshaller = DescribeMaintenanceWindowTasksResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeMaintenanceWindowTasksRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeMaintenanceWindowTasks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeMaintenanceWindowTasks.</param>
        /// 
        /// <returns>Returns a  DescribeMaintenanceWindowTasksResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeMaintenanceWindowTasks">REST API Reference for DescribeMaintenanceWindowTasks Operation</seealso>
        public  DescribeMaintenanceWindowTasksResponse EndDescribeMaintenanceWindowTasks(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeMaintenanceWindowTasksResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeParameters operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeParameters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeParameters">REST API Reference for DescribeParameters Operation</seealso>
        public IAsyncResult BeginDescribeParameters(DescribeParametersRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeParametersRequestMarshaller();
            var unmarshaller = DescribeParametersResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeParametersRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeParameters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeParameters.</param>
        /// 
        /// <returns>Returns a  DescribeParametersResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeParameters">REST API Reference for DescribeParameters Operation</seealso>
        public  DescribeParametersResponse EndDescribeParameters(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeParametersResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the DescribePatchBaselines operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePatchBaselines
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribePatchBaselines">REST API Reference for DescribePatchBaselines Operation</seealso>
        public IAsyncResult BeginDescribePatchBaselines(DescribePatchBaselinesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribePatchBaselinesRequestMarshaller();
            var unmarshaller = DescribePatchBaselinesResponseUnmarshaller.Instance;

            return BeginInvoke<DescribePatchBaselinesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePatchBaselines operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePatchBaselines.</param>
        /// 
        /// <returns>Returns a  DescribePatchBaselinesResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribePatchBaselines">REST API Reference for DescribePatchBaselines Operation</seealso>
        public  DescribePatchBaselinesResponse EndDescribePatchBaselines(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribePatchBaselinesResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the DescribePatchGroups operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePatchGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribePatchGroups">REST API Reference for DescribePatchGroups Operation</seealso>
        public IAsyncResult BeginDescribePatchGroups(DescribePatchGroupsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribePatchGroupsRequestMarshaller();
            var unmarshaller = DescribePatchGroupsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribePatchGroupsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePatchGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePatchGroups.</param>
        /// 
        /// <returns>Returns a  DescribePatchGroupsResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribePatchGroups">REST API Reference for DescribePatchGroups Operation</seealso>
        public  DescribePatchGroupsResponse EndDescribePatchGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribePatchGroupsResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the DescribePatchGroupState operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePatchGroupState
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribePatchGroupState">REST API Reference for DescribePatchGroupState Operation</seealso>
        public IAsyncResult BeginDescribePatchGroupState(DescribePatchGroupStateRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribePatchGroupStateRequestMarshaller();
            var unmarshaller = DescribePatchGroupStateResponseUnmarshaller.Instance;

            return BeginInvoke<DescribePatchGroupStateRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePatchGroupState operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePatchGroupState.</param>
        /// 
        /// <returns>Returns a  DescribePatchGroupStateResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribePatchGroupState">REST API Reference for DescribePatchGroupState Operation</seealso>
        public  DescribePatchGroupStateResponse EndDescribePatchGroupState(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribePatchGroupStateResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the GetAutomationExecution operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAutomationExecution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetAutomationExecution">REST API Reference for GetAutomationExecution Operation</seealso>
        public IAsyncResult BeginGetAutomationExecution(GetAutomationExecutionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetAutomationExecutionRequestMarshaller();
            var unmarshaller = GetAutomationExecutionResponseUnmarshaller.Instance;

            return BeginInvoke<GetAutomationExecutionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAutomationExecution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAutomationExecution.</param>
        /// 
        /// <returns>Returns a  GetAutomationExecutionResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetAutomationExecution">REST API Reference for GetAutomationExecution Operation</seealso>
        public  GetAutomationExecutionResponse EndGetAutomationExecution(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAutomationExecutionResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the GetCommandInvocation operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCommandInvocation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetCommandInvocation">REST API Reference for GetCommandInvocation Operation</seealso>
        public IAsyncResult BeginGetCommandInvocation(GetCommandInvocationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetCommandInvocationRequestMarshaller();
            var unmarshaller = GetCommandInvocationResponseUnmarshaller.Instance;

            return BeginInvoke<GetCommandInvocationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCommandInvocation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCommandInvocation.</param>
        /// 
        /// <returns>Returns a  GetCommandInvocationResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetCommandInvocation">REST API Reference for GetCommandInvocation Operation</seealso>
        public  GetCommandInvocationResponse EndGetCommandInvocation(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCommandInvocationResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the GetDefaultPatchBaseline operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDefaultPatchBaseline
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetDefaultPatchBaseline">REST API Reference for GetDefaultPatchBaseline Operation</seealso>
        public IAsyncResult BeginGetDefaultPatchBaseline(GetDefaultPatchBaselineRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetDefaultPatchBaselineRequestMarshaller();
            var unmarshaller = GetDefaultPatchBaselineResponseUnmarshaller.Instance;

            return BeginInvoke<GetDefaultPatchBaselineRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDefaultPatchBaseline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDefaultPatchBaseline.</param>
        /// 
        /// <returns>Returns a  GetDefaultPatchBaselineResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetDefaultPatchBaseline">REST API Reference for GetDefaultPatchBaseline Operation</seealso>
        public  GetDefaultPatchBaselineResponse EndGetDefaultPatchBaseline(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDefaultPatchBaselineResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the GetDeployablePatchSnapshotForInstance operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDeployablePatchSnapshotForInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetDeployablePatchSnapshotForInstance">REST API Reference for GetDeployablePatchSnapshotForInstance Operation</seealso>
        public IAsyncResult BeginGetDeployablePatchSnapshotForInstance(GetDeployablePatchSnapshotForInstanceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetDeployablePatchSnapshotForInstanceRequestMarshaller();
            var unmarshaller = GetDeployablePatchSnapshotForInstanceResponseUnmarshaller.Instance;

            return BeginInvoke<GetDeployablePatchSnapshotForInstanceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDeployablePatchSnapshotForInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDeployablePatchSnapshotForInstance.</param>
        /// 
        /// <returns>Returns a  GetDeployablePatchSnapshotForInstanceResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetDeployablePatchSnapshotForInstance">REST API Reference for GetDeployablePatchSnapshotForInstance Operation</seealso>
        public  GetDeployablePatchSnapshotForInstanceResponse EndGetDeployablePatchSnapshotForInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDeployablePatchSnapshotForInstanceResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the GetDocument operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDocument operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDocument
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetDocument">REST API Reference for GetDocument Operation</seealso>
        public IAsyncResult BeginGetDocument(GetDocumentRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetDocumentRequestMarshaller();
            var unmarshaller = GetDocumentResponseUnmarshaller.Instance;

            return BeginInvoke<GetDocumentRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDocument operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDocument.</param>
        /// 
        /// <returns>Returns a  GetDocumentResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetDocument">REST API Reference for GetDocument Operation</seealso>
        public  GetDocumentResponse EndGetDocument(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDocumentResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the GetInventory operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetInventory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetInventory">REST API Reference for GetInventory Operation</seealso>
        public IAsyncResult BeginGetInventory(GetInventoryRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetInventoryRequestMarshaller();
            var unmarshaller = GetInventoryResponseUnmarshaller.Instance;

            return BeginInvoke<GetInventoryRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetInventory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInventory.</param>
        /// 
        /// <returns>Returns a  GetInventoryResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetInventory">REST API Reference for GetInventory Operation</seealso>
        public  GetInventoryResponse EndGetInventory(IAsyncResult asyncResult)
        {
            return EndInvoke<GetInventoryResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the GetInventorySchema operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetInventorySchema
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetInventorySchema">REST API Reference for GetInventorySchema Operation</seealso>
        public IAsyncResult BeginGetInventorySchema(GetInventorySchemaRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetInventorySchemaRequestMarshaller();
            var unmarshaller = GetInventorySchemaResponseUnmarshaller.Instance;

            return BeginInvoke<GetInventorySchemaRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetInventorySchema operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInventorySchema.</param>
        /// 
        /// <returns>Returns a  GetInventorySchemaResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetInventorySchema">REST API Reference for GetInventorySchema Operation</seealso>
        public  GetInventorySchemaResponse EndGetInventorySchema(IAsyncResult asyncResult)
        {
            return EndInvoke<GetInventorySchemaResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the GetMaintenanceWindow operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMaintenanceWindow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetMaintenanceWindow">REST API Reference for GetMaintenanceWindow Operation</seealso>
        public IAsyncResult BeginGetMaintenanceWindow(GetMaintenanceWindowRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetMaintenanceWindowRequestMarshaller();
            var unmarshaller = GetMaintenanceWindowResponseUnmarshaller.Instance;

            return BeginInvoke<GetMaintenanceWindowRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetMaintenanceWindow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMaintenanceWindow.</param>
        /// 
        /// <returns>Returns a  GetMaintenanceWindowResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetMaintenanceWindow">REST API Reference for GetMaintenanceWindow Operation</seealso>
        public  GetMaintenanceWindowResponse EndGetMaintenanceWindow(IAsyncResult asyncResult)
        {
            return EndInvoke<GetMaintenanceWindowResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the GetMaintenanceWindowExecution operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMaintenanceWindowExecution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetMaintenanceWindowExecution">REST API Reference for GetMaintenanceWindowExecution Operation</seealso>
        public IAsyncResult BeginGetMaintenanceWindowExecution(GetMaintenanceWindowExecutionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetMaintenanceWindowExecutionRequestMarshaller();
            var unmarshaller = GetMaintenanceWindowExecutionResponseUnmarshaller.Instance;

            return BeginInvoke<GetMaintenanceWindowExecutionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetMaintenanceWindowExecution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMaintenanceWindowExecution.</param>
        /// 
        /// <returns>Returns a  GetMaintenanceWindowExecutionResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetMaintenanceWindowExecution">REST API Reference for GetMaintenanceWindowExecution Operation</seealso>
        public  GetMaintenanceWindowExecutionResponse EndGetMaintenanceWindowExecution(IAsyncResult asyncResult)
        {
            return EndInvoke<GetMaintenanceWindowExecutionResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the GetMaintenanceWindowExecutionTask operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMaintenanceWindowExecutionTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetMaintenanceWindowExecutionTask">REST API Reference for GetMaintenanceWindowExecutionTask Operation</seealso>
        public IAsyncResult BeginGetMaintenanceWindowExecutionTask(GetMaintenanceWindowExecutionTaskRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetMaintenanceWindowExecutionTaskRequestMarshaller();
            var unmarshaller = GetMaintenanceWindowExecutionTaskResponseUnmarshaller.Instance;

            return BeginInvoke<GetMaintenanceWindowExecutionTaskRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetMaintenanceWindowExecutionTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMaintenanceWindowExecutionTask.</param>
        /// 
        /// <returns>Returns a  GetMaintenanceWindowExecutionTaskResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetMaintenanceWindowExecutionTask">REST API Reference for GetMaintenanceWindowExecutionTask Operation</seealso>
        public  GetMaintenanceWindowExecutionTaskResponse EndGetMaintenanceWindowExecutionTask(IAsyncResult asyncResult)
        {
            return EndInvoke<GetMaintenanceWindowExecutionTaskResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the GetParameterHistory operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetParameterHistory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetParameterHistory">REST API Reference for GetParameterHistory Operation</seealso>
        public IAsyncResult BeginGetParameterHistory(GetParameterHistoryRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetParameterHistoryRequestMarshaller();
            var unmarshaller = GetParameterHistoryResponseUnmarshaller.Instance;

            return BeginInvoke<GetParameterHistoryRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetParameterHistory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetParameterHistory.</param>
        /// 
        /// <returns>Returns a  GetParameterHistoryResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetParameterHistory">REST API Reference for GetParameterHistory Operation</seealso>
        public  GetParameterHistoryResponse EndGetParameterHistory(IAsyncResult asyncResult)
        {
            return EndInvoke<GetParameterHistoryResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the GetParameters operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetParameters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetParameters">REST API Reference for GetParameters Operation</seealso>
        public IAsyncResult BeginGetParameters(GetParametersRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetParametersRequestMarshaller();
            var unmarshaller = GetParametersResponseUnmarshaller.Instance;

            return BeginInvoke<GetParametersRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetParameters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetParameters.</param>
        /// 
        /// <returns>Returns a  GetParametersResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetParameters">REST API Reference for GetParameters Operation</seealso>
        public  GetParametersResponse EndGetParameters(IAsyncResult asyncResult)
        {
            return EndInvoke<GetParametersResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the GetPatchBaseline operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPatchBaseline
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetPatchBaseline">REST API Reference for GetPatchBaseline Operation</seealso>
        public IAsyncResult BeginGetPatchBaseline(GetPatchBaselineRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetPatchBaselineRequestMarshaller();
            var unmarshaller = GetPatchBaselineResponseUnmarshaller.Instance;

            return BeginInvoke<GetPatchBaselineRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPatchBaseline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPatchBaseline.</param>
        /// 
        /// <returns>Returns a  GetPatchBaselineResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetPatchBaseline">REST API Reference for GetPatchBaseline Operation</seealso>
        public  GetPatchBaselineResponse EndGetPatchBaseline(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPatchBaselineResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the GetPatchBaselineForPatchGroup operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPatchBaselineForPatchGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetPatchBaselineForPatchGroup">REST API Reference for GetPatchBaselineForPatchGroup Operation</seealso>
        public IAsyncResult BeginGetPatchBaselineForPatchGroup(GetPatchBaselineForPatchGroupRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetPatchBaselineForPatchGroupRequestMarshaller();
            var unmarshaller = GetPatchBaselineForPatchGroupResponseUnmarshaller.Instance;

            return BeginInvoke<GetPatchBaselineForPatchGroupRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPatchBaselineForPatchGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPatchBaselineForPatchGroup.</param>
        /// 
        /// <returns>Returns a  GetPatchBaselineForPatchGroupResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetPatchBaselineForPatchGroup">REST API Reference for GetPatchBaselineForPatchGroup Operation</seealso>
        public  GetPatchBaselineForPatchGroupResponse EndGetPatchBaselineForPatchGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPatchBaselineForPatchGroupResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the ListAssociations operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListAssociations">REST API Reference for ListAssociations Operation</seealso>
        public IAsyncResult BeginListAssociations(ListAssociationsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListAssociationsRequestMarshaller();
            var unmarshaller = ListAssociationsResponseUnmarshaller.Instance;

            return BeginInvoke<ListAssociationsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAssociations.</param>
        /// 
        /// <returns>Returns a  ListAssociationsResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListAssociations">REST API Reference for ListAssociations Operation</seealso>
        public  ListAssociationsResponse EndListAssociations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAssociationsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListCommandInvocations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCommandInvocations operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCommandInvocations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListCommandInvocations">REST API Reference for ListCommandInvocations Operation</seealso>
        public IAsyncResult BeginListCommandInvocations(ListCommandInvocationsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListCommandInvocationsRequestMarshaller();
            var unmarshaller = ListCommandInvocationsResponseUnmarshaller.Instance;

            return BeginInvoke<ListCommandInvocationsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCommandInvocations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCommandInvocations.</param>
        /// 
        /// <returns>Returns a  ListCommandInvocationsResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListCommandInvocations">REST API Reference for ListCommandInvocations Operation</seealso>
        public  ListCommandInvocationsResponse EndListCommandInvocations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCommandInvocationsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListCommands operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCommands operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCommands
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListCommands">REST API Reference for ListCommands Operation</seealso>
        public IAsyncResult BeginListCommands(ListCommandsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListCommandsRequestMarshaller();
            var unmarshaller = ListCommandsResponseUnmarshaller.Instance;

            return BeginInvoke<ListCommandsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCommands operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCommands.</param>
        /// 
        /// <returns>Returns a  ListCommandsResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListCommands">REST API Reference for ListCommands Operation</seealso>
        public  ListCommandsResponse EndListCommands(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCommandsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListDocuments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDocuments operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDocuments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListDocuments">REST API Reference for ListDocuments Operation</seealso>
        public IAsyncResult BeginListDocuments(ListDocumentsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListDocumentsRequestMarshaller();
            var unmarshaller = ListDocumentsResponseUnmarshaller.Instance;

            return BeginInvoke<ListDocumentsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDocuments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDocuments.</param>
        /// 
        /// <returns>Returns a  ListDocumentsResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListDocuments">REST API Reference for ListDocuments Operation</seealso>
        public  ListDocumentsResponse EndListDocuments(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDocumentsResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the ListDocumentVersions operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDocumentVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListDocumentVersions">REST API Reference for ListDocumentVersions Operation</seealso>
        public IAsyncResult BeginListDocumentVersions(ListDocumentVersionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListDocumentVersionsRequestMarshaller();
            var unmarshaller = ListDocumentVersionsResponseUnmarshaller.Instance;

            return BeginInvoke<ListDocumentVersionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDocumentVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDocumentVersions.</param>
        /// 
        /// <returns>Returns a  ListDocumentVersionsResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListDocumentVersions">REST API Reference for ListDocumentVersions Operation</seealso>
        public  ListDocumentVersionsResponse EndListDocumentVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDocumentVersionsResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the ListInventoryEntries operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListInventoryEntries
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListInventoryEntries">REST API Reference for ListInventoryEntries Operation</seealso>
        public IAsyncResult BeginListInventoryEntries(ListInventoryEntriesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListInventoryEntriesRequestMarshaller();
            var unmarshaller = ListInventoryEntriesResponseUnmarshaller.Instance;

            return BeginInvoke<ListInventoryEntriesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListInventoryEntries operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInventoryEntries.</param>
        /// 
        /// <returns>Returns a  ListInventoryEntriesResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListInventoryEntries">REST API Reference for ListInventoryEntries Operation</seealso>
        public  ListInventoryEntriesResponse EndListInventoryEntries(IAsyncResult asyncResult)
        {
            return EndInvoke<ListInventoryEntriesResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListTagsForResourceRequestMarshaller();
            var unmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return BeginInvoke<ListTagsForResourceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public  ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the ModifyDocumentPermission operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyDocumentPermission
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ModifyDocumentPermission">REST API Reference for ModifyDocumentPermission Operation</seealso>
        public IAsyncResult BeginModifyDocumentPermission(ModifyDocumentPermissionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ModifyDocumentPermissionRequestMarshaller();
            var unmarshaller = ModifyDocumentPermissionResponseUnmarshaller.Instance;

            return BeginInvoke<ModifyDocumentPermissionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyDocumentPermission operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyDocumentPermission.</param>
        /// 
        /// <returns>Returns a  ModifyDocumentPermissionResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ModifyDocumentPermission">REST API Reference for ModifyDocumentPermission Operation</seealso>
        public  ModifyDocumentPermissionResponse EndModifyDocumentPermission(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyDocumentPermissionResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the PutInventory operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutInventory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/PutInventory">REST API Reference for PutInventory Operation</seealso>
        public IAsyncResult BeginPutInventory(PutInventoryRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new PutInventoryRequestMarshaller();
            var unmarshaller = PutInventoryResponseUnmarshaller.Instance;

            return BeginInvoke<PutInventoryRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutInventory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutInventory.</param>
        /// 
        /// <returns>Returns a  PutInventoryResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/PutInventory">REST API Reference for PutInventory Operation</seealso>
        public  PutInventoryResponse EndPutInventory(IAsyncResult asyncResult)
        {
            return EndInvoke<PutInventoryResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the PutParameter operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutParameter
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/PutParameter">REST API Reference for PutParameter Operation</seealso>
        public IAsyncResult BeginPutParameter(PutParameterRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new PutParameterRequestMarshaller();
            var unmarshaller = PutParameterResponseUnmarshaller.Instance;

            return BeginInvoke<PutParameterRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutParameter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutParameter.</param>
        /// 
        /// <returns>Returns a  PutParameterResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/PutParameter">REST API Reference for PutParameter Operation</seealso>
        public  PutParameterResponse EndPutParameter(IAsyncResult asyncResult)
        {
            return EndInvoke<PutParameterResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the RegisterDefaultPatchBaseline operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterDefaultPatchBaseline
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/RegisterDefaultPatchBaseline">REST API Reference for RegisterDefaultPatchBaseline Operation</seealso>
        public IAsyncResult BeginRegisterDefaultPatchBaseline(RegisterDefaultPatchBaselineRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new RegisterDefaultPatchBaselineRequestMarshaller();
            var unmarshaller = RegisterDefaultPatchBaselineResponseUnmarshaller.Instance;

            return BeginInvoke<RegisterDefaultPatchBaselineRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterDefaultPatchBaseline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterDefaultPatchBaseline.</param>
        /// 
        /// <returns>Returns a  RegisterDefaultPatchBaselineResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/RegisterDefaultPatchBaseline">REST API Reference for RegisterDefaultPatchBaseline Operation</seealso>
        public  RegisterDefaultPatchBaselineResponse EndRegisterDefaultPatchBaseline(IAsyncResult asyncResult)
        {
            return EndInvoke<RegisterDefaultPatchBaselineResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the RegisterPatchBaselineForPatchGroup operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterPatchBaselineForPatchGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/RegisterPatchBaselineForPatchGroup">REST API Reference for RegisterPatchBaselineForPatchGroup Operation</seealso>
        public IAsyncResult BeginRegisterPatchBaselineForPatchGroup(RegisterPatchBaselineForPatchGroupRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new RegisterPatchBaselineForPatchGroupRequestMarshaller();
            var unmarshaller = RegisterPatchBaselineForPatchGroupResponseUnmarshaller.Instance;

            return BeginInvoke<RegisterPatchBaselineForPatchGroupRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterPatchBaselineForPatchGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterPatchBaselineForPatchGroup.</param>
        /// 
        /// <returns>Returns a  RegisterPatchBaselineForPatchGroupResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/RegisterPatchBaselineForPatchGroup">REST API Reference for RegisterPatchBaselineForPatchGroup Operation</seealso>
        public  RegisterPatchBaselineForPatchGroupResponse EndRegisterPatchBaselineForPatchGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<RegisterPatchBaselineForPatchGroupResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the RegisterTargetWithMaintenanceWindow operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterTargetWithMaintenanceWindow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/RegisterTargetWithMaintenanceWindow">REST API Reference for RegisterTargetWithMaintenanceWindow Operation</seealso>
        public IAsyncResult BeginRegisterTargetWithMaintenanceWindow(RegisterTargetWithMaintenanceWindowRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new RegisterTargetWithMaintenanceWindowRequestMarshaller();
            var unmarshaller = RegisterTargetWithMaintenanceWindowResponseUnmarshaller.Instance;

            return BeginInvoke<RegisterTargetWithMaintenanceWindowRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterTargetWithMaintenanceWindow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterTargetWithMaintenanceWindow.</param>
        /// 
        /// <returns>Returns a  RegisterTargetWithMaintenanceWindowResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/RegisterTargetWithMaintenanceWindow">REST API Reference for RegisterTargetWithMaintenanceWindow Operation</seealso>
        public  RegisterTargetWithMaintenanceWindowResponse EndRegisterTargetWithMaintenanceWindow(IAsyncResult asyncResult)
        {
            return EndInvoke<RegisterTargetWithMaintenanceWindowResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the RegisterTaskWithMaintenanceWindow operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterTaskWithMaintenanceWindow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/RegisterTaskWithMaintenanceWindow">REST API Reference for RegisterTaskWithMaintenanceWindow Operation</seealso>
        public IAsyncResult BeginRegisterTaskWithMaintenanceWindow(RegisterTaskWithMaintenanceWindowRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new RegisterTaskWithMaintenanceWindowRequestMarshaller();
            var unmarshaller = RegisterTaskWithMaintenanceWindowResponseUnmarshaller.Instance;

            return BeginInvoke<RegisterTaskWithMaintenanceWindowRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterTaskWithMaintenanceWindow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterTaskWithMaintenanceWindow.</param>
        /// 
        /// <returns>Returns a  RegisterTaskWithMaintenanceWindowResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/RegisterTaskWithMaintenanceWindow">REST API Reference for RegisterTaskWithMaintenanceWindow Operation</seealso>
        public  RegisterTaskWithMaintenanceWindowResponse EndRegisterTaskWithMaintenanceWindow(IAsyncResult asyncResult)
        {
            return EndInvoke<RegisterTaskWithMaintenanceWindowResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromResource operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveTagsFromResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/RemoveTagsFromResource">REST API Reference for RemoveTagsFromResource Operation</seealso>
        public IAsyncResult BeginRemoveTagsFromResource(RemoveTagsFromResourceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new RemoveTagsFromResourceRequestMarshaller();
            var unmarshaller = RemoveTagsFromResourceResponseUnmarshaller.Instance;

            return BeginInvoke<RemoveTagsFromResourceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveTagsFromResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveTagsFromResource.</param>
        /// 
        /// <returns>Returns a  RemoveTagsFromResourceResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/RemoveTagsFromResource">REST API Reference for RemoveTagsFromResource Operation</seealso>
        public  RemoveTagsFromResourceResponse EndRemoveTagsFromResource(IAsyncResult asyncResult)
        {
            return EndInvoke<RemoveTagsFromResourceResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the SendCommand operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendCommand operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendCommand
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/SendCommand">REST API Reference for SendCommand Operation</seealso>
        public IAsyncResult BeginSendCommand(SendCommandRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new SendCommandRequestMarshaller();
            var unmarshaller = SendCommandResponseUnmarshaller.Instance;

            return BeginInvoke<SendCommandRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SendCommand operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendCommand.</param>
        /// 
        /// <returns>Returns a  SendCommandResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/SendCommand">REST API Reference for SendCommand Operation</seealso>
        public  SendCommandResponse EndSendCommand(IAsyncResult asyncResult)
        {
            return EndInvoke<SendCommandResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the StartAutomationExecution operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartAutomationExecution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/StartAutomationExecution">REST API Reference for StartAutomationExecution Operation</seealso>
        public IAsyncResult BeginStartAutomationExecution(StartAutomationExecutionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new StartAutomationExecutionRequestMarshaller();
            var unmarshaller = StartAutomationExecutionResponseUnmarshaller.Instance;

            return BeginInvoke<StartAutomationExecutionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartAutomationExecution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartAutomationExecution.</param>
        /// 
        /// <returns>Returns a  StartAutomationExecutionResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/StartAutomationExecution">REST API Reference for StartAutomationExecution Operation</seealso>
        public  StartAutomationExecutionResponse EndStartAutomationExecution(IAsyncResult asyncResult)
        {
            return EndInvoke<StartAutomationExecutionResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the StopAutomationExecution operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopAutomationExecution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/StopAutomationExecution">REST API Reference for StopAutomationExecution Operation</seealso>
        public IAsyncResult BeginStopAutomationExecution(StopAutomationExecutionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new StopAutomationExecutionRequestMarshaller();
            var unmarshaller = StopAutomationExecutionResponseUnmarshaller.Instance;

            return BeginInvoke<StopAutomationExecutionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopAutomationExecution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopAutomationExecution.</param>
        /// 
        /// <returns>Returns a  StopAutomationExecutionResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/StopAutomationExecution">REST API Reference for StopAutomationExecution Operation</seealso>
        public  StopAutomationExecutionResponse EndStopAutomationExecution(IAsyncResult asyncResult)
        {
            return EndInvoke<StopAutomationExecutionResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssociation operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateAssociation">REST API Reference for UpdateAssociation Operation</seealso>
        public IAsyncResult BeginUpdateAssociation(UpdateAssociationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateAssociationRequestMarshaller();
            var unmarshaller = UpdateAssociationResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateAssociationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAssociation.</param>
        /// 
        /// <returns>Returns a  UpdateAssociationResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateAssociation">REST API Reference for UpdateAssociation Operation</seealso>
        public  UpdateAssociationResponse EndUpdateAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAssociationResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssociationStatus operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAssociationStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateAssociationStatus">REST API Reference for UpdateAssociationStatus Operation</seealso>
        public IAsyncResult BeginUpdateAssociationStatus(UpdateAssociationStatusRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateAssociationStatusRequestMarshaller();
            var unmarshaller = UpdateAssociationStatusResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateAssociationStatusRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAssociationStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAssociationStatus.</param>
        /// 
        /// <returns>Returns a  UpdateAssociationStatusResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateAssociationStatus">REST API Reference for UpdateAssociationStatus Operation</seealso>
        public  UpdateAssociationStatusResponse EndUpdateAssociationStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAssociationStatusResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the UpdateDocument operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDocument
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateDocument">REST API Reference for UpdateDocument Operation</seealso>
        public IAsyncResult BeginUpdateDocument(UpdateDocumentRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateDocumentRequestMarshaller();
            var unmarshaller = UpdateDocumentResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateDocumentRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDocument operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDocument.</param>
        /// 
        /// <returns>Returns a  UpdateDocumentResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateDocument">REST API Reference for UpdateDocument Operation</seealso>
        public  UpdateDocumentResponse EndUpdateDocument(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDocumentResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the UpdateDocumentDefaultVersion operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDocumentDefaultVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateDocumentDefaultVersion">REST API Reference for UpdateDocumentDefaultVersion Operation</seealso>
        public IAsyncResult BeginUpdateDocumentDefaultVersion(UpdateDocumentDefaultVersionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateDocumentDefaultVersionRequestMarshaller();
            var unmarshaller = UpdateDocumentDefaultVersionResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateDocumentDefaultVersionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDocumentDefaultVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDocumentDefaultVersion.</param>
        /// 
        /// <returns>Returns a  UpdateDocumentDefaultVersionResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateDocumentDefaultVersion">REST API Reference for UpdateDocumentDefaultVersion Operation</seealso>
        public  UpdateDocumentDefaultVersionResponse EndUpdateDocumentDefaultVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDocumentDefaultVersionResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the UpdateMaintenanceWindow operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateMaintenanceWindow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateMaintenanceWindow">REST API Reference for UpdateMaintenanceWindow Operation</seealso>
        public IAsyncResult BeginUpdateMaintenanceWindow(UpdateMaintenanceWindowRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateMaintenanceWindowRequestMarshaller();
            var unmarshaller = UpdateMaintenanceWindowResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateMaintenanceWindowRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateMaintenanceWindow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateMaintenanceWindow.</param>
        /// 
        /// <returns>Returns a  UpdateMaintenanceWindowResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateMaintenanceWindow">REST API Reference for UpdateMaintenanceWindow Operation</seealso>
        public  UpdateMaintenanceWindowResponse EndUpdateMaintenanceWindow(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateMaintenanceWindowResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the UpdateManagedInstanceRole operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateManagedInstanceRole
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateManagedInstanceRole">REST API Reference for UpdateManagedInstanceRole Operation</seealso>
        public IAsyncResult BeginUpdateManagedInstanceRole(UpdateManagedInstanceRoleRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateManagedInstanceRoleRequestMarshaller();
            var unmarshaller = UpdateManagedInstanceRoleResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateManagedInstanceRoleRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateManagedInstanceRole operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateManagedInstanceRole.</param>
        /// 
        /// <returns>Returns a  UpdateManagedInstanceRoleResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateManagedInstanceRole">REST API Reference for UpdateManagedInstanceRole Operation</seealso>
        public  UpdateManagedInstanceRoleResponse EndUpdateManagedInstanceRole(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateManagedInstanceRoleResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the UpdatePatchBaseline operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePatchBaseline
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdatePatchBaseline">REST API Reference for UpdatePatchBaseline Operation</seealso>
        public IAsyncResult BeginUpdatePatchBaseline(UpdatePatchBaselineRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdatePatchBaselineRequestMarshaller();
            var unmarshaller = UpdatePatchBaselineResponseUnmarshaller.Instance;

            return BeginInvoke<UpdatePatchBaselineRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePatchBaseline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePatchBaseline.</param>
        /// 
        /// <returns>Returns a  UpdatePatchBaselineResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdatePatchBaseline">REST API Reference for UpdatePatchBaseline Operation</seealso>
        public  UpdatePatchBaselineResponse EndUpdatePatchBaseline(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdatePatchBaselineResponse>(asyncResult);
        }

        #endregion
        
    }
}