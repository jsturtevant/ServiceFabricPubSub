// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace ClientApi.Router
{
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Request.
    /// </summary>
    public static partial class RequestExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='tenantId'>
            /// </param>
            /// <param name='topicName'>
            /// </param>
            /// <param name='subscriber'>
            /// </param>
            public static object Get(this IRequest operations, string tenantId, string topicName, string subscriber)
            {
                return operations.GetAsync(tenantId, topicName, subscriber).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='tenantId'>
            /// </param>
            /// <param name='topicName'>
            /// </param>
            /// <param name='subscriber'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> GetAsync(this IRequest operations, string tenantId, string topicName, string subscriber, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(tenantId, topicName, subscriber, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='tenantId'>
            /// </param>
            /// <param name='topicName'>
            /// </param>
            public static object Post(this IRequest operations, string tenantId, string topicName)
            {
                return operations.PostAsync(tenantId, topicName).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='tenantId'>
            /// </param>
            /// <param name='topicName'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> PostAsync(this IRequest operations, string tenantId, string topicName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PostWithHttpMessagesAsync(tenantId, topicName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='tenantId'>
            /// </param>
            public static object GetTopics(this IRequest operations, string tenantId)
            {
                return operations.GetTopicsAsync(tenantId).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='tenantId'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> GetTopicsAsync(this IRequest operations, string tenantId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetTopicsWithHttpMessagesAsync(tenantId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
