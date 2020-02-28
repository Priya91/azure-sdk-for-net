// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Synapse
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for SparkSessionOperations.
    /// </summary>
    public static partial class SparkSessionOperationsExtensions
    {
            /// <summary>
            /// List all spark sessions which are running under a particular spark pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace to execute operations on.
            /// </param>
            /// <param name='sparkPoolName'>
            /// Name of the spark pool. "ondemand" targets the ondemand pool.
            /// </param>
            /// <param name='fromParameter'>
            /// Optional param specifying which index the list should begin from.
            /// </param>
            /// <param name='size'>
            /// Optional param specifying the size of the returned list.
            /// By default it is 20 and that is the maximum.
            /// </param>
            /// <param name='detailed'>
            /// Optional query param specifying whether detailed response is returned
            /// beyond plain livy.
            /// </param>
            public static ExtendedLivyListSessionResponse List(this ISparkSessionOperations operations, string workspaceName, string sparkPoolName, int? fromParameter = default(int?), int? size = default(int?), bool? detailed = default(bool?))
            {
                return operations.ListAsync(workspaceName, sparkPoolName, fromParameter, size, detailed).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List all spark sessions which are running under a particular spark pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace to execute operations on.
            /// </param>
            /// <param name='sparkPoolName'>
            /// Name of the spark pool. "ondemand" targets the ondemand pool.
            /// </param>
            /// <param name='fromParameter'>
            /// Optional param specifying which index the list should begin from.
            /// </param>
            /// <param name='size'>
            /// Optional param specifying the size of the returned list.
            /// By default it is 20 and that is the maximum.
            /// </param>
            /// <param name='detailed'>
            /// Optional query param specifying whether detailed response is returned
            /// beyond plain livy.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ExtendedLivyListSessionResponse> ListAsync(this ISparkSessionOperations operations, string workspaceName, string sparkPoolName, int? fromParameter = default(int?), int? size = default(int?), bool? detailed = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(workspaceName, sparkPoolName, fromParameter, size, detailed, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create new spark session.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace to execute operations on.
            /// </param>
            /// <param name='sparkPoolName'>
            /// Name of the spark pool. "ondemand" targets the ondemand pool.
            /// </param>
            /// <param name='livyRequest'>
            /// Livy compatible batch job request payload.
            /// </param>
            /// <param name='detailed'>
            /// Optional query param specifying whether detailed response is returned
            /// beyond plain livy.
            /// </param>
            public static ExtendedLivySessionResponse Create(this ISparkSessionOperations operations, string workspaceName, string sparkPoolName, ExtendedLivySessionRequest livyRequest, bool? detailed = default(bool?))
            {
                return operations.CreateAsync(workspaceName, sparkPoolName, livyRequest, detailed).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create new spark session.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace to execute operations on.
            /// </param>
            /// <param name='sparkPoolName'>
            /// Name of the spark pool. "ondemand" targets the ondemand pool.
            /// </param>
            /// <param name='livyRequest'>
            /// Livy compatible batch job request payload.
            /// </param>
            /// <param name='detailed'>
            /// Optional query param specifying whether detailed response is returned
            /// beyond plain livy.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ExtendedLivySessionResponse> CreateAsync(this ISparkSessionOperations operations, string workspaceName, string sparkPoolName, ExtendedLivySessionRequest livyRequest, bool? detailed = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(workspaceName, sparkPoolName, livyRequest, detailed, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a single spark session.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace to execute operations on.
            /// </param>
            /// <param name='sparkPoolName'>
            /// Name of the spark pool. "ondemand" targets the ondemand pool.
            /// </param>
            /// <param name='sessionId'>
            /// Identifier for the session.
            /// </param>
            /// <param name='detailed'>
            /// Optional query param specifying whether detailed response is returned
            /// beyond plain livy.
            /// </param>
            public static ExtendedLivySessionResponse Get(this ISparkSessionOperations operations, string workspaceName, string sparkPoolName, int sessionId, bool? detailed = default(bool?))
            {
                return operations.GetAsync(workspaceName, sparkPoolName, sessionId, detailed).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a single spark session.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace to execute operations on.
            /// </param>
            /// <param name='sparkPoolName'>
            /// Name of the spark pool. "ondemand" targets the ondemand pool.
            /// </param>
            /// <param name='sessionId'>
            /// Identifier for the session.
            /// </param>
            /// <param name='detailed'>
            /// Optional query param specifying whether detailed response is returned
            /// beyond plain livy.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ExtendedLivySessionResponse> GetAsync(this ISparkSessionOperations operations, string workspaceName, string sparkPoolName, int sessionId, bool? detailed = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(workspaceName, sparkPoolName, sessionId, detailed, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Cancels a running spark session.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace to execute operations on.
            /// </param>
            /// <param name='sparkPoolName'>
            /// Name of the spark pool. "ondemand"
            /// targets the ondemand pool.
            /// </param>
            /// <param name='sessionId'>
            /// Identifier for the session.
            /// </param>
            public static void Delete(this ISparkSessionOperations operations, string workspaceName, string sparkPoolName, int sessionId)
            {
                operations.DeleteAsync(workspaceName, sparkPoolName, sessionId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Cancels a running spark session.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace to execute operations on.
            /// </param>
            /// <param name='sparkPoolName'>
            /// Name of the spark pool. "ondemand"
            /// targets the ondemand pool.
            /// </param>
            /// <param name='sessionId'>
            /// Identifier for the session.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this ISparkSessionOperations operations, string workspaceName, string sparkPoolName, int sessionId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(workspaceName, sparkPoolName, sessionId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Sends a keep alive call to the current session to reset the session
            /// timeout.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace to execute operations on.
            /// </param>
            /// <param name='sparkPoolName'>
            /// Name of the spark pool. "ondemand"
            /// targets the ondemand pool.
            /// </param>
            /// <param name='sessionId'>
            /// Identifier for the session.
            /// </param>
            public static void ResetTimeout(this ISparkSessionOperations operations, string workspaceName, string sparkPoolName, int sessionId)
            {
                operations.ResetTimeoutAsync(workspaceName, sparkPoolName, sessionId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Sends a keep alive call to the current session to reset the session
            /// timeout.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace to execute operations on.
            /// </param>
            /// <param name='sparkPoolName'>
            /// Name of the spark pool. "ondemand"
            /// targets the ondemand pool.
            /// </param>
            /// <param name='sessionId'>
            /// Identifier for the session.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ResetTimeoutAsync(this ISparkSessionOperations operations, string workspaceName, string sparkPoolName, int sessionId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.ResetTimeoutWithHttpMessagesAsync(workspaceName, sparkPoolName, sessionId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets a list of statements within a spark session.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace to execute operations on.
            /// </param>
            /// <param name='sparkPoolName'>
            /// Name of the spark pool. "ondemand" targets the ondemand pool.
            /// </param>
            /// <param name='sessionId'>
            /// Identifier for the session.
            /// </param>
            public static LivyStatementsResponseBody ListStatements(this ISparkSessionOperations operations, string workspaceName, string sparkPoolName, int sessionId)
            {
                return operations.ListStatementsAsync(workspaceName, sparkPoolName, sessionId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of statements within a spark session.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace to execute operations on.
            /// </param>
            /// <param name='sparkPoolName'>
            /// Name of the spark pool. "ondemand" targets the ondemand pool.
            /// </param>
            /// <param name='sessionId'>
            /// Identifier for the session.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LivyStatementsResponseBody> ListStatementsAsync(this ISparkSessionOperations operations, string workspaceName, string sparkPoolName, int sessionId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListStatementsWithHttpMessagesAsync(workspaceName, sparkPoolName, sessionId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create statement within a spark session.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace to execute operations on.
            /// </param>
            /// <param name='sparkPoolName'>
            /// Name of the spark pool. "ondemand" targets the ondemand pool.
            /// </param>
            /// <param name='sessionId'>
            /// Identifier for the session.
            /// </param>
            /// <param name='livyRequest'>
            /// Livy compatible batch job request payload.
            /// </param>
            public static LivyStatementResponseBody CreateStatement(this ISparkSessionOperations operations, string workspaceName, string sparkPoolName, int sessionId, LivyStatementRequestBody livyRequest)
            {
                return operations.CreateStatementAsync(workspaceName, sparkPoolName, sessionId, livyRequest).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create statement within a spark session.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace to execute operations on.
            /// </param>
            /// <param name='sparkPoolName'>
            /// Name of the spark pool. "ondemand" targets the ondemand pool.
            /// </param>
            /// <param name='sessionId'>
            /// Identifier for the session.
            /// </param>
            /// <param name='livyRequest'>
            /// Livy compatible batch job request payload.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LivyStatementResponseBody> CreateStatementAsync(this ISparkSessionOperations operations, string workspaceName, string sparkPoolName, int sessionId, LivyStatementRequestBody livyRequest, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateStatementWithHttpMessagesAsync(workspaceName, sparkPoolName, sessionId, livyRequest, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a single statement within a spark session.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace to execute operations on.
            /// </param>
            /// <param name='sparkPoolName'>
            /// Name of the spark pool. "ondemand" targets the ondemand pool.
            /// </param>
            /// <param name='sessionId'>
            /// Identifier for the session.
            /// </param>
            /// <param name='statementId'>
            /// Identifier for the statement.
            /// </param>
            public static LivyStatementResponseBody GetStatement(this ISparkSessionOperations operations, string workspaceName, string sparkPoolName, int sessionId, int statementId)
            {
                return operations.GetStatementAsync(workspaceName, sparkPoolName, sessionId, statementId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a single statement within a spark session.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace to execute operations on.
            /// </param>
            /// <param name='sparkPoolName'>
            /// Name of the spark pool. "ondemand" targets the ondemand pool.
            /// </param>
            /// <param name='sessionId'>
            /// Identifier for the session.
            /// </param>
            /// <param name='statementId'>
            /// Identifier for the statement.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LivyStatementResponseBody> GetStatementAsync(this ISparkSessionOperations operations, string workspaceName, string sparkPoolName, int sessionId, int statementId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetStatementWithHttpMessagesAsync(workspaceName, sparkPoolName, sessionId, statementId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Kill a statement within a session.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace to execute operations on.
            /// </param>
            /// <param name='sparkPoolName'>
            /// Name of the spark pool. "ondemand" targets the ondemand pool.
            /// </param>
            /// <param name='sessionId'>
            /// Identifier for the session.
            /// </param>
            /// <param name='statementId'>
            /// Identifier for the statement.
            /// </param>
            public static LivyStatementCancellationResponse DeleteStatement(this ISparkSessionOperations operations, string workspaceName, string sparkPoolName, int sessionId, int statementId)
            {
                return operations.DeleteStatementAsync(workspaceName, sparkPoolName, sessionId, statementId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Kill a statement within a session.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace to execute operations on.
            /// </param>
            /// <param name='sparkPoolName'>
            /// Name of the spark pool. "ondemand" targets the ondemand pool.
            /// </param>
            /// <param name='sessionId'>
            /// Identifier for the session.
            /// </param>
            /// <param name='statementId'>
            /// Identifier for the statement.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LivyStatementCancellationResponse> DeleteStatementAsync(this ISparkSessionOperations operations, string workspaceName, string sparkPoolName, int sessionId, int statementId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteStatementWithHttpMessagesAsync(workspaceName, sparkPoolName, sessionId, statementId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}