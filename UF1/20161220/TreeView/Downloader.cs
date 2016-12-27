using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Windows.Web.Http.Filters;
using Windows.Web.Http;

namespace TreeView
{
    class Downloader
    {

        async public static Task<string> httpGET(string url)
        {

            Uri resourceUri;
            if (!TryGetUri(url, out resourceUri))
            {
                return null;
            }
            HttpClient httpClient = new HttpClient(new HttpBaseProtocolFilter());
            CancellationTokenSource cts = new CancellationTokenSource();
            HttpResponseMessage response = await httpClient.GetAsync(resourceUri).AsTask(cts.Token);

            CancellationToken token;
            string responseBodyAsText = await response.Content.ReadAsStringAsync().AsTask(cts.Token);

            token.ThrowIfCancellationRequested();

            // Insert new lines.
            responseBodyAsText = responseBodyAsText.Replace("<br>", Environment.NewLine);

            return responseBodyAsText;
        }


        internal static bool TryGetUri(string uriString, out Uri uri)
        {
            // Note that this app has both "Internet (Client)" and "Home and Work Networking" capabilities set,
            // since the user may provide URIs for servers located on the internet or intranet. If apps only
            // communicate with servers on the internet, only the "Internet (Client)" capability should be set.
            // Similarly if an app is only intended to communicate on the intranet, only the "Home and Work
            // Networking" capability should be set.
            if (!Uri.TryCreate(uriString.Trim(), UriKind.Absolute, out uri))
            {
                return false;
            }

            if (uri.Scheme != "http" && uri.Scheme != "https")
            {
                return false;
            }

            return true;
        }
    }
}

