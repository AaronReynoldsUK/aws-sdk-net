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
 * Do not modify this file. This file is generated from the opsworkscm-2016-11-01.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.OpsWorksCM.Model;

namespace Amazon.OpsWorksCM
{
    /// <summary>
    /// Interface for accessing OpsWorksCM
    ///
    /// AWS OpsWorks for Chef Automate 
    /// <para>
    ///  A service that runs and manages configuration management servers. 
    /// </para>
    ///  
    /// <para>
    /// Glossary of terms
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Server</b>: A server is a configuration management server, and can be highly-available.
    /// The configuration manager runs on your instances by using various AWS services, such
    /// as Amazon Elastic Compute Cloud (EC2), and potentially Amazon Relational Database
    /// Service (RDS). A server is a generic abstraction over the configuration manager that
    /// you want to use, much like Amazon RDS. In AWS OpsWorks for Chef Automate, you do not
    /// start or stop servers. After you create servers, they continue to run until they are
    /// deleted.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Engine</b>: The specific configuration manager that you want to use (such as <code>Chef</code>)
    /// is the engine.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Backup</b>: This is an application-level backup of the data that the configuration
    /// manager stores. A backup creates a .tar.gz file that is stored in an Amazon Simple
    /// Storage Service (S3) bucket in your account. AWS OpsWorks for Chef Automate creates
    /// the S3 bucket when you launch the first instance. A backup maintains a snapshot of
    /// all of a server's important attributes at the time of the backup.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Events</b>: Events are always related to a server. Events are written during server
    /// creation, when health checks run, when backups are created, etc. When you delete a
    /// server, the server's events are also deleted.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>AccountAttributes</b>: Every account has attributes that are assigned in the AWS
    /// OpsWorks for Chef Automate database. These attributes store information about configuration
    /// limits (servers, backups, etc.) and your customer account. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Throttling limits
    /// </para>
    ///  
    /// <para>
    /// All API operations allow for 5 requests per second with a burst of 10 requests per
    /// second.
    /// </para>
    /// </summary>
    public partial interface IAmazonOpsWorksCM : IAmazonService, IDisposable
    {

        
        #region  AssociateNode


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateNode service method.</param>
        /// 
        /// <returns>The response from the AssociateNode service method, as returned by OpsWorksCM.</returns>
        /// <exception cref="Amazon.OpsWorksCM.Model.InvalidStateException">
        /// The resource is in a state that does not allow you to perform a specified action.
        /// </exception>
        /// <exception cref="Amazon.OpsWorksCM.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.OpsWorksCM.Model.ValidationException">
        /// One or more of the provided request parameters are not valid.
        /// </exception>
        AssociateNodeResponse AssociateNode(AssociateNodeRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the AssociateNode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateNode operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<AssociateNodeResponse> AssociateNodeAsync(AssociateNodeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateBackup


        /// <summary>
        /// Creates an application-level backup of a server. While the server is <code>BACKING_UP</code>,
        /// the server can not be modified and no additional backup can be created. 
        /// 
        ///  
        /// <para>
        ///  Backups can be created for <code>RUNNING</code>, <code>HEALTHY</code> and <code>UNHEALTHY</code>
        /// servers. 
        /// </para>
        ///  
        /// <para>
        ///  This operation is asnychronous. 
        /// </para>
        ///  
        /// <para>
        ///  By default 50 manual backups can be created. 
        /// </para>
        ///  
        /// <para>
        ///  A <code>LimitExceededException</code> is thrown then the maximum number of manual
        /// backup is reached. A <code>InvalidStateException</code> is thrown when the server
        /// is not in any of RUNNING, HEALTHY, UNHEALTHY. A <code>ResourceNotFoundException</code>
        /// is thrown when the server is not found. A <code>ValidationException</code> is thrown
        /// when parameters of the request are not valid. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBackup service method.</param>
        /// 
        /// <returns>The response from the CreateBackup service method, as returned by OpsWorksCM.</returns>
        /// <exception cref="Amazon.OpsWorksCM.Model.InvalidStateException">
        /// The resource is in a state that does not allow you to perform a specified action.
        /// </exception>
        /// <exception cref="Amazon.OpsWorksCM.Model.LimitExceededException">
        /// The limit of servers or backups has been reached.
        /// </exception>
        /// <exception cref="Amazon.OpsWorksCM.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.OpsWorksCM.Model.ValidationException">
        /// One or more of the provided request parameters are not valid.
        /// </exception>
        CreateBackupResponse CreateBackup(CreateBackupRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateBackup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBackup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateBackupResponse> CreateBackupAsync(CreateBackupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateServer


        /// <summary>
        /// Creates and immedately starts a new Server. The server can be used once it has reached
        /// the <code>HEALTHY</code> state. 
        /// 
        ///  
        /// <para>
        ///  This operation is asnychronous. 
        /// </para>
        ///  
        /// <para>
        ///  A <code>LimitExceededException</code> is thrown then the maximum number of server
        /// backup is reached. A <code>ResourceAlreadyExistsException</code> is raise when a server
        /// with the same name already exists in the account. A <code>ResourceNotFoundException</code>
        /// is thrown when a backupId is passed, but the backup does not exist. A <code>ValidationException</code>
        /// is thrown when parameters of the request are not valid. 
        /// </para>
        ///  
        /// <para>
        ///  By default 10 servers can be created. A <code>LimitExceededException</code> is raised
        /// when the limit is exceeded. 
        /// </para>
        ///  
        /// <para>
        ///  When no security groups are provided by using <code>SecurityGroupIds</code>, AWS
        /// OpsWorks creates a new security group. This security group opens the Chef server to
        /// the world on TCP port 443. If a KeyName is present, SSH access is enabled. SSH is
        /// also open to the world on TCP port 22. 
        /// </para>
        ///  
        /// <para>
        /// By default, the Chef Server is accessible from any IP address. We recommend that you
        /// update your security group rules to allow access from known IP addresses and address
        /// ranges only. To edit security group rules, open Security Groups in the navigation
        /// pane of the EC2 management console. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateServer service method.</param>
        /// 
        /// <returns>The response from the CreateServer service method, as returned by OpsWorksCM.</returns>
        /// <exception cref="Amazon.OpsWorksCM.Model.LimitExceededException">
        /// The limit of servers or backups has been reached.
        /// </exception>
        /// <exception cref="Amazon.OpsWorksCM.Model.ResourceAlreadyExistsException">
        /// The requested resource cannot be created because it already exists.
        /// </exception>
        /// <exception cref="Amazon.OpsWorksCM.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.OpsWorksCM.Model.ValidationException">
        /// One or more of the provided request parameters are not valid.
        /// </exception>
        CreateServerResponse CreateServer(CreateServerRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateServer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateServer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateServerResponse> CreateServerAsync(CreateServerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteBackup


        /// <summary>
        /// Deletes a backup. You can delete both manual and automated backups. 
        /// 
        ///  
        /// <para>
        ///  This operation is asynchronous. 
        /// </para>
        ///  
        /// <para>
        ///  A <code>InvalidStateException</code> is thrown then a backup is already deleting.
        /// A <code>ResourceNotFoundException</code> is thrown when the backup does not exist.
        /// A <code>ValidationException</code> is thrown when parameters of the request are not
        /// valid. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackup service method.</param>
        /// 
        /// <returns>The response from the DeleteBackup service method, as returned by OpsWorksCM.</returns>
        /// <exception cref="Amazon.OpsWorksCM.Model.InvalidStateException">
        /// The resource is in a state that does not allow you to perform a specified action.
        /// </exception>
        /// <exception cref="Amazon.OpsWorksCM.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.OpsWorksCM.Model.ValidationException">
        /// One or more of the provided request parameters are not valid.
        /// </exception>
        DeleteBackupResponse DeleteBackup(DeleteBackupRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBackup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteBackupResponse> DeleteBackupAsync(DeleteBackupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteServer


        /// <summary>
        /// Deletes the server and the underlying AWS CloudFormation stack (including the server's
        /// EC2 instance). The server status updated to <code>DELETING</code>. Once the server
        /// is successfully deleted, it will no longer be returned by <code>DescribeServer</code>
        /// requests. If the AWS CloudFormation stack cannot be deleted, the server cannot be
        /// deleted. 
        /// 
        ///  
        /// <para>
        ///  This operation is asynchronous. 
        /// </para>
        ///  
        /// <para>
        ///  A <code>InvalidStateException</code> is thrown then a server is already deleting.
        /// A <code>ResourceNotFoundException</code> is thrown when the server does not exist.
        /// A <code>ValidationException</code> is raised when parameters of the request are invalid.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServer service method.</param>
        /// 
        /// <returns>The response from the DeleteServer service method, as returned by OpsWorksCM.</returns>
        /// <exception cref="Amazon.OpsWorksCM.Model.InvalidStateException">
        /// The resource is in a state that does not allow you to perform a specified action.
        /// </exception>
        /// <exception cref="Amazon.OpsWorksCM.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.OpsWorksCM.Model.ValidationException">
        /// One or more of the provided request parameters are not valid.
        /// </exception>
        DeleteServerResponse DeleteServer(DeleteServerRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteServer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteServer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteServerResponse> DeleteServerAsync(DeleteServerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeAccountAttributes


        /// <summary>
        /// Describes your account attributes, and creates requests to increase limits before
        /// they are reached or exceeded. 
        /// 
        ///  
        /// <para>
        ///  This operation is synchronous. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountAttributes service method.</param>
        /// 
        /// <returns>The response from the DescribeAccountAttributes service method, as returned by OpsWorksCM.</returns>
        DescribeAccountAttributesResponse DescribeAccountAttributes(DescribeAccountAttributesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAccountAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeAccountAttributesResponse> DescribeAccountAttributesAsync(DescribeAccountAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeBackups


        /// <summary>
        /// Describes backups. The results are ordered by time, with newest backups first. If
        /// you do not specify a BackupId or ServerName, the command returns all backups. 
        /// 
        ///  
        /// <para>
        ///  This operation is synchronous. 
        /// </para>
        ///  
        /// <para>
        ///  A <code>ResourceNotFoundException</code> is thrown when the backup does not exist.
        /// A <code>ValidationException</code> is raised when parameters of the request are invalid.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBackups service method.</param>
        /// 
        /// <returns>The response from the DescribeBackups service method, as returned by OpsWorksCM.</returns>
        /// <exception cref="Amazon.OpsWorksCM.Model.InvalidNextTokenException">
        /// This occurs when the provided nextToken is not valid.
        /// </exception>
        /// <exception cref="Amazon.OpsWorksCM.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.OpsWorksCM.Model.ValidationException">
        /// One or more of the provided request parameters are not valid.
        /// </exception>
        DescribeBackupsResponse DescribeBackups(DescribeBackupsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeBackups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBackups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeBackupsResponse> DescribeBackupsAsync(DescribeBackupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeEvents


        /// <summary>
        /// Describes events for a specified server. Results are ordered by time, with newest
        /// events first. 
        /// 
        ///  
        /// <para>
        ///  This operation is synchronous. 
        /// </para>
        ///  
        /// <para>
        ///  A <code>ResourceNotFoundException</code> is thrown when the server does not exist.
        /// A <code>ValidationException</code> is raised when parameters of the request are invalid.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents service method.</param>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by OpsWorksCM.</returns>
        /// <exception cref="Amazon.OpsWorksCM.Model.InvalidNextTokenException">
        /// This occurs when the provided nextToken is not valid.
        /// </exception>
        /// <exception cref="Amazon.OpsWorksCM.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.OpsWorksCM.Model.ValidationException">
        /// One or more of the provided request parameters are not valid.
        /// </exception>
        DescribeEventsResponse DescribeEvents(DescribeEventsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeEventsResponse> DescribeEventsAsync(DescribeEventsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeNodeAssociationStatus


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNodeAssociationStatus service method.</param>
        /// 
        /// <returns>The response from the DescribeNodeAssociationStatus service method, as returned by OpsWorksCM.</returns>
        /// <exception cref="Amazon.OpsWorksCM.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.OpsWorksCM.Model.ValidationException">
        /// One or more of the provided request parameters are not valid.
        /// </exception>
        DescribeNodeAssociationStatusResponse DescribeNodeAssociationStatus(DescribeNodeAssociationStatusRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeNodeAssociationStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeNodeAssociationStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeNodeAssociationStatusResponse> DescribeNodeAssociationStatusAsync(DescribeNodeAssociationStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeServers


        /// <summary>
        /// Lists all configuration management servers that are identified with your account.
        /// Only the stored results from Amazon DynamoDB are returned. AWS OpsWorks for Chef Automate
        /// does not query other services. 
        /// 
        ///  
        /// <para>
        ///  This operation is synchronous. 
        /// </para>
        ///  
        /// <para>
        ///  A <code>ResourceNotFoundException</code> is thrown when the server does not exist.
        /// A <code>ValidationException</code> is raised when parameters of the request are invalid.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeServers service method.</param>
        /// 
        /// <returns>The response from the DescribeServers service method, as returned by OpsWorksCM.</returns>
        /// <exception cref="Amazon.OpsWorksCM.Model.InvalidNextTokenException">
        /// This occurs when the provided nextToken is not valid.
        /// </exception>
        /// <exception cref="Amazon.OpsWorksCM.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.OpsWorksCM.Model.ValidationException">
        /// One or more of the provided request parameters are not valid.
        /// </exception>
        DescribeServersResponse DescribeServers(DescribeServersRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeServers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeServers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeServersResponse> DescribeServersAsync(DescribeServersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisassociateNode


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateNode service method.</param>
        /// 
        /// <returns>The response from the DisassociateNode service method, as returned by OpsWorksCM.</returns>
        /// <exception cref="Amazon.OpsWorksCM.Model.InvalidStateException">
        /// The resource is in a state that does not allow you to perform a specified action.
        /// </exception>
        /// <exception cref="Amazon.OpsWorksCM.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.OpsWorksCM.Model.ValidationException">
        /// One or more of the provided request parameters are not valid.
        /// </exception>
        DisassociateNodeResponse DisassociateNode(DisassociateNodeRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateNode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateNode operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DisassociateNodeResponse> DisassociateNodeAsync(DisassociateNodeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RestoreServer


        /// <summary>
        /// Restores a backup to a server that is in a <code>RUNNING</code>, <code>FAILED</code>,
        /// or <code>HEALTHY</code> state. When you run RestoreServer, the server's EC2 instance
        /// is deleted, and a new EC2 instance is configured. RestoreServer maintains the existing
        /// server endpoint, so configuration management of all of the server's client devices
        /// should continue to work. 
        /// 
        ///  
        /// <para>
        ///  This operation is asynchronous. 
        /// </para>
        ///  
        /// <para>
        ///  A <code>InvalidStateException</code> is thrown when the server is not in a valid
        /// state. A <code>ResourceNotFoundException</code> is thrown when the server does not
        /// exist. A <code>ValidationException</code> is raised when parameters of the request
        /// are invalid. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreServer service method.</param>
        /// 
        /// <returns>The response from the RestoreServer service method, as returned by OpsWorksCM.</returns>
        /// <exception cref="Amazon.OpsWorksCM.Model.InvalidStateException">
        /// The resource is in a state that does not allow you to perform a specified action.
        /// </exception>
        /// <exception cref="Amazon.OpsWorksCM.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.OpsWorksCM.Model.ValidationException">
        /// One or more of the provided request parameters are not valid.
        /// </exception>
        RestoreServerResponse RestoreServer(RestoreServerRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the RestoreServer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreServer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RestoreServerResponse> RestoreServerAsync(RestoreServerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartMaintenance


        /// <summary>
        /// Manually starts server maintenance. This command can be useful if an earlier maintenance
        /// attempt failed, and the underlying cause of maintenance failure has been resolved.
        /// The server will switch to <code>UNDER_MAINTENANCE</code> state, while maintenace is
        /// in progress. 
        /// 
        ///  
        /// <para>
        ///  Maintenace can only be started for <code>HEALTHY</code> and <code>UNHEALTHY</code>
        /// servers. A <code>InvalidStateException</code> is thrown otherwise. A <code>ResourceNotFoundException</code>
        /// is thrown when the server does not exist. A <code>ValidationException</code> is raised
        /// when parameters of the request are invalid. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMaintenance service method.</param>
        /// 
        /// <returns>The response from the StartMaintenance service method, as returned by OpsWorksCM.</returns>
        /// <exception cref="Amazon.OpsWorksCM.Model.InvalidStateException">
        /// The resource is in a state that does not allow you to perform a specified action.
        /// </exception>
        /// <exception cref="Amazon.OpsWorksCM.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.OpsWorksCM.Model.ValidationException">
        /// One or more of the provided request parameters are not valid.
        /// </exception>
        StartMaintenanceResponse StartMaintenance(StartMaintenanceRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the StartMaintenance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartMaintenance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<StartMaintenanceResponse> StartMaintenanceAsync(StartMaintenanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateServer


        /// <summary>
        /// Updates settings for a server. 
        /// 
        ///  
        /// <para>
        ///  This operation is synchronous. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServer service method.</param>
        /// 
        /// <returns>The response from the UpdateServer service method, as returned by OpsWorksCM.</returns>
        /// <exception cref="Amazon.OpsWorksCM.Model.InvalidStateException">
        /// The resource is in a state that does not allow you to perform a specified action.
        /// </exception>
        /// <exception cref="Amazon.OpsWorksCM.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.OpsWorksCM.Model.ValidationException">
        /// One or more of the provided request parameters are not valid.
        /// </exception>
        UpdateServerResponse UpdateServer(UpdateServerRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateServer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateServer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateServerResponse> UpdateServerAsync(UpdateServerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateServerEngineAttributes


        /// <summary>
        /// Updates engine specific attributes on a specified server. Server will enter the <code>MODIFYING</code>
        /// state when this operation is in progress. Only one update can take place at a time.
        /// 
        /// 
        ///  
        /// <para>
        ///  This operation can be use to reset Chef Server main API key (<code>CHEF_PIVOTAL_KEY</code>).
        /// 
        /// </para>
        ///  
        /// <para>
        ///  This operation is asynchronous. 
        /// </para>
        ///  
        /// <para>
        ///  
        /// </para>
        ///  
        /// <para>
        ///  This operation can only be called for <code>HEALTHY</code> and <code>UNHEALTHY</code>
        /// servers. Otherwise a <code>InvalidStateException</code> is raised. A <code>ResourceNotFoundException</code>
        /// is thrown when the server does not exist. A <code>ValidationException</code> is raised
        /// when parameters of the request are invalid. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServerEngineAttributes service method.</param>
        /// 
        /// <returns>The response from the UpdateServerEngineAttributes service method, as returned by OpsWorksCM.</returns>
        /// <exception cref="Amazon.OpsWorksCM.Model.InvalidStateException">
        /// The resource is in a state that does not allow you to perform a specified action.
        /// </exception>
        /// <exception cref="Amazon.OpsWorksCM.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.OpsWorksCM.Model.ValidationException">
        /// One or more of the provided request parameters are not valid.
        /// </exception>
        UpdateServerEngineAttributesResponse UpdateServerEngineAttributes(UpdateServerEngineAttributesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateServerEngineAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateServerEngineAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateServerEngineAttributesResponse> UpdateServerEngineAttributesAsync(UpdateServerEngineAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}