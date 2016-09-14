/*UserInterface.cs
 * Author:Rob Howell
 * Modified by: Ying Chen
 * 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ksu.Cis300.WebBrowser
{
    /// <summary>
    /// a GUI FOR A SIMPLE WEB Browser
    /// </summary>
    public partial class UserInterface : Form
    {
        /// <summary>
        /// Constructs the GUI.
        /// </summary>
        public UserInterface()
        {
            InitializeComponent();
            uxBrowser.GoHome();
        }
        /// <summary>
        /// Handles a Click event on the Home Button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxHome_Click(object sender, EventArgs e)
        {
            uxBrowser.GoHome();
        }
        /// <summary>
        /// Handles a click event on the Back Button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxBack_Click(object sender, EventArgs e)
        {
            uxBrowser.GoBack();
        }
        /// <summary>
        /// Handles click event on the Forward Button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxForward_Click(object sender, EventArgs e)
        {
            uxBrowser.GoForward();
           
        }
        /// <summary>
        /// Handles Click event on the Go button. Browser navigates to url in the address. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxGo_Click(object sender, EventArgs e)
        {
            uxBrowser.Navigate(uxAddress.Text);  
           
        }
        /// <summary>
        /// Handles Document Complete event on the browser. Puts the address into the address bar;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            uxAddress.Text = uxBrowser.Url.ToString();
          //  uxBack.Enabled = uxBrowser.CanGoBack;
            uxForward.Enabled = uxBrowser.CanGoForward;
        }


    }
}
