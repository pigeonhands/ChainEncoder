using ChainLink;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChainEncoder.Controls
{
    class LinkListViewItem : ListViewItem
    {
        public ILink AssociatedLink { get; private set; }
        public LinkListViewItem(ILink assoc) : base(assoc.Name)
        {
            AssociatedLink = assoc;
            SubItems.AddRange(new string[] { string.Empty, string.Empty, string.Empty });
        }
    }
}
