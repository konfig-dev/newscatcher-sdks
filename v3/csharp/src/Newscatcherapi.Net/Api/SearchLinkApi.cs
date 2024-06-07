using Newscatcherapi.Net.Client;

namespace Newscatcherapi.Net.Api
{
    public partial class SearchLinkApi : SearchLinkApiGenerated {
        public SearchLinkApi() : base() {}
        public SearchLinkApi(string basePath): base(basePath) {}
        public SearchLinkApi(Newscatcherapi.Net.Client.Configuration configuration): base(configuration) {}
        public SearchLinkApi(Newscatcherapi.Net.Client.ISynchronousClient client, Newscatcherapi.Net.Client.IAsynchronousClient asyncClient, Newscatcherapi.Net.Client.IReadableConfiguration configuration): base(client, asyncClient, configuration) {}
    }
}