#nullable enable

namespace Phoenix
{
    public partial interface IExperimentsClient
    {
        /// <summary>
        /// Download experiment runs as a CSV file
        /// </summary>
        /// <param name="experimentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetExperimentCSVAsync(
            string experimentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}