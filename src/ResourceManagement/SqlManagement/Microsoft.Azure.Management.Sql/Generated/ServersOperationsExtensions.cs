// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Sql
{
    using System.Threading.Tasks;
   using Microsoft.Rest.Azure;
   using Models;

    /// <summary>
    /// Extension methods for ServersOperations.
    /// </summary>
    public static partial class ServersOperationsExtensions
    {
            /// <summary>
            /// Returns information about an Azure SQL Server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static System.Collections.Generic.IEnumerable<Server> List(this IServersOperations operations)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IServersOperations)s).ListAsync(), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns information about an Azure SQL Server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<System.Collections.Generic.IEnumerable<Server>> ListAsync(this IServersOperations operations, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a new Azure SQL Server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Resource Group to which the resource belongs.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Azure SQL Server
            /// </param>
            /// <param name='parameters'>
            /// The required parameters for createing or updating a server.
            /// </param>
            public static Server CreateOrUpdate(this IServersOperations operations, string resourceGroupName, string serverName, Server parameters)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IServersOperations)s).CreateOrUpdateAsync(resourceGroupName, serverName, parameters), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new Azure SQL Server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Resource Group to which the resource belongs.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Azure SQL Server
            /// </param>
            /// <param name='parameters'>
            /// The required parameters for createing or updating a server.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<Server> CreateOrUpdateAsync(this IServersOperations operations, string resourceGroupName, string serverName, Server parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serverName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns information about an Azure SQL Server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Resource Group to which the resource belongs.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Azure SQL Server
            /// </param>
            public static void Delete(this IServersOperations operations, string resourceGroupName, string serverName)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((IServersOperations)s).DeleteAsync(resourceGroupName, serverName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns information about an Azure SQL Server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Resource Group to which the resource belongs.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Azure SQL Server
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task DeleteAsync(this IServersOperations operations, string resourceGroupName, string serverName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(resourceGroupName, serverName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Returns information about an Azure SQL Server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Resource Group to which the resource belongs.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Azure SQL Server
            /// </param>
            public static Server GetByResourceGroup(this IServersOperations operations, string resourceGroupName, string serverName)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IServersOperations)s).GetByResourceGroupAsync(resourceGroupName, serverName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns information about an Azure SQL Server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Resource Group to which the resource belongs.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Azure SQL Server
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<Server> GetByResourceGroupAsync(this IServersOperations operations, string resourceGroupName, string serverName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetByResourceGroupWithHttpMessagesAsync(resourceGroupName, serverName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns information about an Azure SQL Server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Resource Group to which the resource belongs.
            /// </param>
            public static System.Collections.Generic.IEnumerable<Server> ListByResourceGroup(this IServersOperations operations, string resourceGroupName)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IServersOperations)s).ListByResourceGroupAsync(resourceGroupName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns information about an Azure SQL Server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Resource Group to which the resource belongs.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<System.Collections.Generic.IEnumerable<Server>> ListByResourceGroupAsync(this IServersOperations operations, string resourceGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Cancel a pending upgrade for the Azure SQL Server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Resource Group to which the resource belongs.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Azure SQL Server
            /// </param>
            public static void CancelUpgrade(this IServersOperations operations, string resourceGroupName, string serverName)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((IServersOperations)s).CancelUpgradeAsync(resourceGroupName, serverName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Cancel a pending upgrade for the Azure SQL Server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Resource Group to which the resource belongs.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Azure SQL Server
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task CancelUpgradeAsync(this IServersOperations operations, string resourceGroupName, string serverName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.CancelUpgradeWithHttpMessagesAsync(resourceGroupName, serverName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Returns information about Upgrade status of an Azure SQL Server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Resource Group to which the resource belongs.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Azure SQL Server
            /// </param>
            public static ServerUpgradeGetResult GetUpgrade(this IServersOperations operations, string resourceGroupName, string serverName)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IServersOperations)s).GetUpgradeAsync(resourceGroupName, serverName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns information about Upgrade status of an Azure SQL Server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Resource Group to which the resource belongs.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Azure SQL Server
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<ServerUpgradeGetResult> GetUpgradeAsync(this IServersOperations operations, string resourceGroupName, string serverName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetUpgradeWithHttpMessagesAsync(resourceGroupName, serverName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Start an Azure SQL Server Upgrade.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Resource Group to which the resource belongs.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Azure SQL Server
            /// </param>
            /// <param name='parameters'>
            /// The required parameters for the Azure SQL Server Upgrade.
            /// </param>
            public static void StartUpgrade(this IServersOperations operations, string resourceGroupName, string serverName, ServerUpgradeStartParameters parameters)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((IServersOperations)s).StartUpgradeAsync(resourceGroupName, serverName, parameters), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Start an Azure SQL Server Upgrade.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Resource Group to which the resource belongs.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Azure SQL Server
            /// </param>
            /// <param name='parameters'>
            /// The required parameters for the Azure SQL Server Upgrade.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task StartUpgradeAsync(this IServersOperations operations, string resourceGroupName, string serverName, ServerUpgradeStartParameters parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.StartUpgradeWithHttpMessagesAsync(resourceGroupName, serverName, parameters, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Start an Azure SQL Server Upgrade.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Resource Group to which the resource belongs.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Azure SQL Server
            /// </param>
            /// <param name='parameters'>
            /// The required parameters for the Azure SQL Server Upgrade.
            /// </param>
            public static void BeginStartUpgrade(this IServersOperations operations, string resourceGroupName, string serverName, ServerUpgradeStartParameters parameters)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((IServersOperations)s).BeginStartUpgradeAsync(resourceGroupName, serverName, parameters), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Start an Azure SQL Server Upgrade.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Resource Group to which the resource belongs.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Azure SQL Server
            /// </param>
            /// <param name='parameters'>
            /// The required parameters for the Azure SQL Server Upgrade.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task BeginStartUpgradeAsync(this IServersOperations operations, string resourceGroupName, string serverName, ServerUpgradeStartParameters parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.BeginStartUpgradeWithHttpMessagesAsync(resourceGroupName, serverName, parameters, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Returns information about Azure SQL Server usage.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Resource Group to which the resource belongs.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Azure SQL Server
            /// </param>
            public static System.Collections.Generic.IEnumerable<ServerMetric> ListUsages(this IServersOperations operations, string resourceGroupName, string serverName)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IServersOperations)s).ListUsagesAsync(resourceGroupName, serverName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns information about Azure SQL Server usage.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Resource Group to which the resource belongs.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Azure SQL Server
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<System.Collections.Generic.IEnumerable<ServerMetric>> ListUsagesAsync(this IServersOperations operations, string resourceGroupName, string serverName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListUsagesWithHttpMessagesAsync(resourceGroupName, serverName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns information about an Azure SQL Database Service Objective.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Resource Group to which the resource belongs.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Azure SQL Server
            /// </param>
            /// <param name='serviceObjectiveName'>
            /// The name of the service objective to retrieve.
            /// </param>
            public static ServiceObjective GetServiceObjective(this IServersOperations operations, string resourceGroupName, string serverName, string serviceObjectiveName)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IServersOperations)s).GetServiceObjectiveAsync(resourceGroupName, serverName, serviceObjectiveName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns information about an Azure SQL Database Service Objective.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Resource Group to which the resource belongs.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Azure SQL Server
            /// </param>
            /// <param name='serviceObjectiveName'>
            /// The name of the service objective to retrieve.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<ServiceObjective> GetServiceObjectiveAsync(this IServersOperations operations, string resourceGroupName, string serverName, string serviceObjectiveName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetServiceObjectiveWithHttpMessagesAsync(resourceGroupName, serverName, serviceObjectiveName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns information about Azure SQL Database Service Objectives.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Resource Group to which the resource belongs.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Azure SQL Server
            /// </param>
            public static System.Collections.Generic.IEnumerable<ServiceObjective> ListServiceObjectives(this IServersOperations operations, string resourceGroupName, string serverName)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IServersOperations)s).ListServiceObjectivesAsync(resourceGroupName, serverName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns information about Azure SQL Database Service Objectives.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Resource Group to which the resource belongs.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Azure SQL Server
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<System.Collections.Generic.IEnumerable<ServiceObjective>> ListServiceObjectivesAsync(this IServersOperations operations, string resourceGroupName, string serverName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListServiceObjectivesWithHttpMessagesAsync(resourceGroupName, serverName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates an Azure SQL server firewall rule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Resource Group to which the resource belongs.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Azure SQL Server
            /// </param>
            /// <param name='firewallRuleName'>
            /// The name of the Azure SQL Server Firewall Rule.
            /// </param>
            /// <param name='parameters'>
            /// The required parameters for createing or updating a firewall rule.
            /// </param>
            public static ServerFirewallRule CreateOrUpdateFirewallRule(this IServersOperations operations, string resourceGroupName, string serverName, string firewallRuleName, ServerFirewallRule parameters)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IServersOperations)s).CreateOrUpdateFirewallRuleAsync(resourceGroupName, serverName, firewallRuleName, parameters), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates an Azure SQL server firewall rule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Resource Group to which the resource belongs.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Azure SQL Server
            /// </param>
            /// <param name='firewallRuleName'>
            /// The name of the Azure SQL Server Firewall Rule.
            /// </param>
            /// <param name='parameters'>
            /// The required parameters for createing or updating a firewall rule.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<ServerFirewallRule> CreateOrUpdateFirewallRuleAsync(this IServersOperations operations, string resourceGroupName, string serverName, string firewallRuleName, ServerFirewallRule parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateFirewallRuleWithHttpMessagesAsync(resourceGroupName, serverName, firewallRuleName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes an Azure SQL server firewall rule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Resource Group to which the resource belongs.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Azure SQL Server
            /// </param>
            /// <param name='firewallRuleName'>
            /// The name of the Azure SQL Server Firewall Rule.
            /// </param>
            public static void DeleteFirewallRule(this IServersOperations operations, string resourceGroupName, string serverName, string firewallRuleName)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((IServersOperations)s).DeleteFirewallRuleAsync(resourceGroupName, serverName, firewallRuleName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes an Azure SQL server firewall rule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Resource Group to which the resource belongs.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Azure SQL Server
            /// </param>
            /// <param name='firewallRuleName'>
            /// The name of the Azure SQL Server Firewall Rule.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task DeleteFirewallRuleAsync(this IServersOperations operations, string resourceGroupName, string serverName, string firewallRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.DeleteFirewallRuleWithHttpMessagesAsync(resourceGroupName, serverName, firewallRuleName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Returns an Azure SQL server firewall rule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Resource Group to which the resource belongs.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Azure SQL Server
            /// </param>
            /// <param name='firewallRuleName'>
            /// The name of the Azure SQL Server Firewall Rule.
            /// </param>
            public static ServerFirewallRule GetFirewallRule(this IServersOperations operations, string resourceGroupName, string serverName, string firewallRuleName)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IServersOperations)s).GetFirewallRuleAsync(resourceGroupName, serverName, firewallRuleName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns an Azure SQL server firewall rule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Resource Group to which the resource belongs.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Azure SQL Server
            /// </param>
            /// <param name='firewallRuleName'>
            /// The name of the Azure SQL Server Firewall Rule.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<ServerFirewallRule> GetFirewallRuleAsync(this IServersOperations operations, string resourceGroupName, string serverName, string firewallRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetFirewallRuleWithHttpMessagesAsync(resourceGroupName, serverName, firewallRuleName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns a list of Azure SQL server firewall rules.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Resource Group to which the resource belongs.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Azure SQL Server
            /// </param>
            public static System.Collections.Generic.IEnumerable<ServerFirewallRule> ListFirewallRules(this IServersOperations operations, string resourceGroupName, string serverName)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IServersOperations)s).ListFirewallRulesAsync(resourceGroupName, serverName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of Azure SQL server firewall rules.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Resource Group to which the resource belongs.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Azure SQL Server
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<System.Collections.Generic.IEnumerable<ServerFirewallRule>> ListFirewallRulesAsync(this IServersOperations operations, string resourceGroupName, string serverName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListFirewallRulesWithHttpMessagesAsync(resourceGroupName, serverName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}