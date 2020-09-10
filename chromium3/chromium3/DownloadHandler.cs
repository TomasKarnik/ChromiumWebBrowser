using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Windows.Forms;
using System.Diagnostics;
using chromium3;

namespace CefSharp.Example.Handlers
{
    public class DownloadHandler : IDownloadHandler

    {
        public ProgressBar _bar;
        public DownloadHandler(ProgressBar bar)
        {
            _bar = bar;
        }
        public event EventHandler<DownloadItem> OnBeforeDownloadFired;

        public event EventHandler<DownloadItem> OnDownloadUpdatedFired;

        public void OnBeforeDownload(IWebBrowser chromiumWebBrowser, IBrowser browser, DownloadItem downloadItem, IBeforeDownloadCallback callback)
        {
            OnBeforeDownloadFired?.Invoke(this, downloadItem);

            if (!callback.IsDisposed)
            {
                using (callback)
                {
                    callback.Continue(downloadItem.SuggestedFileName, showDialog: true);
                }
            }
        }

        public void OnDownloadUpdated(IWebBrowser chromiumWebBrowser, IBrowser browser, DownloadItem downloadItem, IDownloadItemCallback callback)
        {
            OnDownloadUpdatedFired?.Invoke(this, downloadItem);
            

            _bar.BeginInvoke(new Action(() => {
                Debug.Print("{0}/{1} bytes", downloadItem.ReceivedBytes, downloadItem.TotalBytes);
                
                _bar.Maximum = Convert.ToInt32(downloadItem.TotalBytes);
                _bar.Value = Convert.ToInt32(downloadItem.ReceivedBytes);
            }));
            if (downloadItem.IsComplete)
            {
                MessageBox.Show("File has been downloaded you may close this window");
                
            }
            

            
            
               
        }
    }
}
