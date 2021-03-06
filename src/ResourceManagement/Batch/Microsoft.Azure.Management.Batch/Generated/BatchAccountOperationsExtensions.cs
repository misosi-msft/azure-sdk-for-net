// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Batch
{
    using System.Threading.Tasks;
   using Microsoft.Rest.Azure;
   using Models;

    /// <summary>
    /// Extension methods for BatchAccountOperations.
    /// </summary>
    public static partial class BatchAccountOperationsExtensions
    {
            /// <summary>
            /// Creates a new Batch account with the specified parameters. Existing
            /// accounts cannot be updated with this API and should instead be updated
            /// with the Update Batch Account API.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the new Batch account.
            /// </param>
            /// <param name='accountName'>
            /// A name for the Batch account which must be unique within the region. Batch
            /// account names must be between 3 and 24 characters in length and must use
            /// only numbers and lowercase letters. This name is used as part of the DNS
            /// name that is used to access the Batch service in the region in which the
            /// account is created. For example:
            /// http://accountname.region.batch.azure.com/.
            /// </param>
            /// <param name='parameters'>
            /// Additional parameters for account creation.
            /// </param>
            public static BatchAccount Create(this IBatchAccountOperations operations, string resourceGroupName, string accountName, BatchAccountCreateParameters parameters)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IBatchAccountOperations)s).CreateAsync(resourceGroupName, accountName, parameters), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new Batch account with the specified parameters. Existing
            /// accounts cannot be updated with this API and should instead be updated
            /// with the Update Batch Account API.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the new Batch account.
            /// </param>
            /// <param name='accountName'>
            /// A name for the Batch account which must be unique within the region. Batch
            /// account names must be between 3 and 24 characters in length and must use
            /// only numbers and lowercase letters. This name is used as part of the DNS
            /// name that is used to access the Batch service in the region in which the
            /// account is created. For example:
            /// http://accountname.region.batch.azure.com/.
            /// </param>
            /// <param name='parameters'>
            /// Additional parameters for account creation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<BatchAccount> CreateAsync(this IBatchAccountOperations operations, string resourceGroupName, string accountName, BatchAccountCreateParameters parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, accountName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a new Batch account with the specified parameters. Existing
            /// accounts cannot be updated with this API and should instead be updated
            /// with the Update Batch Account API.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the new Batch account.
            /// </param>
            /// <param name='accountName'>
            /// A name for the Batch account which must be unique within the region. Batch
            /// account names must be between 3 and 24 characters in length and must use
            /// only numbers and lowercase letters. This name is used as part of the DNS
            /// name that is used to access the Batch service in the region in which the
            /// account is created. For example:
            /// http://accountname.region.batch.azure.com/.
            /// </param>
            /// <param name='parameters'>
            /// Additional parameters for account creation.
            /// </param>
            public static BatchAccount BeginCreate(this IBatchAccountOperations operations, string resourceGroupName, string accountName, BatchAccountCreateParameters parameters)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IBatchAccountOperations)s).BeginCreateAsync(resourceGroupName, accountName, parameters), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new Batch account with the specified parameters. Existing
            /// accounts cannot be updated with this API and should instead be updated
            /// with the Update Batch Account API.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the new Batch account.
            /// </param>
            /// <param name='accountName'>
            /// A name for the Batch account which must be unique within the region. Batch
            /// account names must be between 3 and 24 characters in length and must use
            /// only numbers and lowercase letters. This name is used as part of the DNS
            /// name that is used to access the Batch service in the region in which the
            /// account is created. For example:
            /// http://accountname.region.batch.azure.com/.
            /// </param>
            /// <param name='parameters'>
            /// Additional parameters for account creation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<BatchAccount> BeginCreateAsync(this IBatchAccountOperations operations, string resourceGroupName, string accountName, BatchAccountCreateParameters parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.BeginCreateWithHttpMessagesAsync(resourceGroupName, accountName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates the properties of an existing Batch account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the Batch account.
            /// </param>
            /// <param name='accountName'>
            /// The name of the account.
            /// </param>
            /// <param name='parameters'>
            /// Additional parameters for account update.
            /// </param>
            public static BatchAccount Update(this IBatchAccountOperations operations, string resourceGroupName, string accountName, BatchAccountUpdateParameters parameters)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IBatchAccountOperations)s).UpdateAsync(resourceGroupName, accountName, parameters), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates the properties of an existing Batch account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the Batch account.
            /// </param>
            /// <param name='accountName'>
            /// The name of the account.
            /// </param>
            /// <param name='parameters'>
            /// Additional parameters for account update.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<BatchAccount> UpdateAsync(this IBatchAccountOperations operations, string resourceGroupName, string accountName, BatchAccountUpdateParameters parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, accountName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified Batch account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the Batch account to be
            /// deleted.
            /// </param>
            /// <param name='accountName'>
            /// The name of the account to be deleted.
            /// </param>
            public static void Delete(this IBatchAccountOperations operations, string resourceGroupName, string accountName)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((IBatchAccountOperations)s).DeleteAsync(resourceGroupName, accountName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified Batch account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the Batch account to be
            /// deleted.
            /// </param>
            /// <param name='accountName'>
            /// The name of the account to be deleted.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task DeleteAsync(this IBatchAccountOperations operations, string resourceGroupName, string accountName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(resourceGroupName, accountName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Deletes the specified Batch account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the Batch account to be
            /// deleted.
            /// </param>
            /// <param name='accountName'>
            /// The name of the account to be deleted.
            /// </param>
            public static void BeginDelete(this IBatchAccountOperations operations, string resourceGroupName, string accountName)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((IBatchAccountOperations)s).BeginDeleteAsync(resourceGroupName, accountName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified Batch account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the Batch account to be
            /// deleted.
            /// </param>
            /// <param name='accountName'>
            /// The name of the account to be deleted.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task BeginDeleteAsync(this IBatchAccountOperations operations, string resourceGroupName, string accountName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, accountName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Gets information about the specified Batch account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the Batch account.
            /// </param>
            /// <param name='accountName'>
            /// The name of the account.
            /// </param>
            public static BatchAccount Get(this IBatchAccountOperations operations, string resourceGroupName, string accountName)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IBatchAccountOperations)s).GetAsync(resourceGroupName, accountName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets information about the specified Batch account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the Batch account.
            /// </param>
            /// <param name='accountName'>
            /// The name of the account.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<BatchAccount> GetAsync(this IBatchAccountOperations operations, string resourceGroupName, string accountName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, accountName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets information about the Batch accounts associated with the subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<BatchAccount> List(this IBatchAccountOperations operations)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IBatchAccountOperations)s).ListAsync(), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets information about the Batch accounts associated with the subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<BatchAccount>> ListAsync(this IBatchAccountOperations operations, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets information about the Batch accounts associated within the specified
            /// resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group whose Batch accounts to list.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<BatchAccount> ListByResourceGroup(this IBatchAccountOperations operations, string resourceGroupName)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IBatchAccountOperations)s).ListByResourceGroupAsync(resourceGroupName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets information about the Batch accounts associated within the specified
            /// resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group whose Batch accounts to list.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<BatchAccount>> ListByResourceGroupAsync(this IBatchAccountOperations operations, string resourceGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Synchronizes access keys for the auto storage account configured for the
            /// specified Batch account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the Batch account.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Batch account.
            /// </param>
            public static void SynchronizeAutoStorageKeys(this IBatchAccountOperations operations, string resourceGroupName, string accountName)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((IBatchAccountOperations)s).SynchronizeAutoStorageKeysAsync(resourceGroupName, accountName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Synchronizes access keys for the auto storage account configured for the
            /// specified Batch account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the Batch account.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Batch account.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task SynchronizeAutoStorageKeysAsync(this IBatchAccountOperations operations, string resourceGroupName, string accountName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.SynchronizeAutoStorageKeysWithHttpMessagesAsync(resourceGroupName, accountName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Regenerates the specified account key for the specified Batch account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the Batch account.
            /// </param>
            /// <param name='accountName'>
            /// The name of the account.
            /// </param>
            /// <param name='keyName'>
            /// The type of account key to regenerate. Possible values include: 'Primary',
            /// 'Secondary'
            /// </param>
            public static BatchAccountKeys RegenerateKey(this IBatchAccountOperations operations, string resourceGroupName, string accountName, AccountKeyType keyName)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IBatchAccountOperations)s).RegenerateKeyAsync(resourceGroupName, accountName, keyName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Regenerates the specified account key for the specified Batch account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the Batch account.
            /// </param>
            /// <param name='accountName'>
            /// The name of the account.
            /// </param>
            /// <param name='keyName'>
            /// The type of account key to regenerate. Possible values include: 'Primary',
            /// 'Secondary'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<BatchAccountKeys> RegenerateKeyAsync(this IBatchAccountOperations operations, string resourceGroupName, string accountName, AccountKeyType keyName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.RegenerateKeyWithHttpMessagesAsync(resourceGroupName, accountName, keyName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the account keys for the specified Batch account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the Batch account.
            /// </param>
            /// <param name='accountName'>
            /// The name of the account.
            /// </param>
            public static BatchAccountKeys GetKeys(this IBatchAccountOperations operations, string resourceGroupName, string accountName)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IBatchAccountOperations)s).GetKeysAsync(resourceGroupName, accountName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the account keys for the specified Batch account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the Batch account.
            /// </param>
            /// <param name='accountName'>
            /// The name of the account.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<BatchAccountKeys> GetKeysAsync(this IBatchAccountOperations operations, string resourceGroupName, string accountName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetKeysWithHttpMessagesAsync(resourceGroupName, accountName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets information about the Batch accounts associated with the subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<BatchAccount> ListNext(this IBatchAccountOperations operations, string nextPageLink)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IBatchAccountOperations)s).ListNextAsync(nextPageLink), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets information about the Batch accounts associated with the subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<BatchAccount>> ListNextAsync(this IBatchAccountOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets information about the Batch accounts associated within the specified
            /// resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<BatchAccount> ListByResourceGroupNext(this IBatchAccountOperations operations, string nextPageLink)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IBatchAccountOperations)s).ListByResourceGroupNextAsync(nextPageLink), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets information about the Batch accounts associated within the specified
            /// resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<BatchAccount>> ListByResourceGroupNextAsync(this IBatchAccountOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
