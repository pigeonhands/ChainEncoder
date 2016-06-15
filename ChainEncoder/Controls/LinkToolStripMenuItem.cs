using ChainLink;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChainEncoder.Controls
{
    class LinkToolStripMenuItem : ToolStripMenuItem
    {
        public ILink AssociatedLink { get; private set; }
        public LinkToolStripMenuItem(ILink assoc):base(assoc.Name)
        {
            AssociatedLink = assoc;
        }
    }
}
