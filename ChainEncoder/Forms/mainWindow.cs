using ChainEncoder.Controls;
using ChainLink;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChainEncoder.Forms
{
    public partial class mainWindow : Form
    {
        public mainWindow()
        {
            InitializeComponent();
        }

        private void mainWindow_Load(object sender, EventArgs e)
        {
            DirectoryInfo linkDir = new DirectoryInfo("Links");
            if (!linkDir.Exists)
                linkDir.Create();

            foreach(FileInfo fi in linkDir.GetFiles("*.dll"))
            {
                try
                {
                    Assembly asm = Assembly.LoadFile(fi.FullName);
                    foreach(Type t in asm.GetTypes())
                    {
                        if (!typeof(ILink).IsAssignableFrom(t))
                            continue;

                        ILink loadedLink = (ILink)Activator.CreateInstance(t);

                        LinkToolStripMenuItem linkItem = new LinkToolStripMenuItem(loadedLink);
                        linkItem.Click += LinkItem_Click;
                        this.tsmAdd.DropDownItems.Add(linkItem);
                    }
                   
                }
                catch(Exception ex)
                {
                    Debug.Write(ex.ToString(), "Loading Chain");
                    throw;
                }
            }
        }

        private void LinkItem_Click(object sender, EventArgs e)
        {
            LinkToolStripMenuItem linkStrip = sender as LinkToolStripMenuItem;
            ILink link = linkStrip.AssociatedLink;
            if (link == null)
                return;

            ListViewItem i = new LinkListViewItem(link);
            lvChain.Items.Add(i);
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if(lvChain.Items.Count < 1)
            {
                MessageBox.Show("Chain is empty, please add a link");
                return;
            }
            string currentString = rtbInput.Text;

            Stopwatch sw = new Stopwatch();
            bool success = true;

            foreach (ListViewItem i in lvChain.Items)
            {
                if (success == false)
                {
                    i.SubItems[1].Text = "";
                    i.SubItems[2].Text = "";
                    i.SubItems[3].Text = "";
                    continue;
                }
                sw.Start();
                LinkListViewItem llItem = i as LinkListViewItem;
                try
                {
                    if (llItem == null)
                        throw new Exception("Invalid Link");
                    ILink link = ((LinkListViewItem)i).AssociatedLink;
                    currentString = cbDecode.Checked ? link.Decode(currentString) : link.Encode(currentString);
                }
                catch(Exception ex)
                {
                    success = false;
                    currentString = ex.Message;
                }
                sw.Stop();
                if (llItem != null)
                {
                    i.SubItems[1].Text = sw.ElapsedMilliseconds.ToString() + "ms";
                    i.SubItems[2].Text = success.ToString();
                    i.SubItems[3].Text = currentString;
                }
                sw.Reset();
            }

            rtbOutput.Text = success ? currentString : string.Empty;
        }

        private void reverseChainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem[] newOrder = new ListViewItem[lvChain.Items.Count];

            for (int i = 0; i < newOrder.Length; i++)
                newOrder[(newOrder.Length - 1) - i] = lvChain.Items[i];

            lvChain.Items.Clear();
            lvChain.Items.AddRange(newOrder);
        }

        private void removeSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem i in lvChain.SelectedItems)
                lvChain.Items.Remove(i);
        }

        private void copySelectedStateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvChain.SelectedItems.Count < 1)
                return;
            Clipboard.SetText(lvChain.SelectedItems[0].SubItems[3].Text);
        }
    }
}
