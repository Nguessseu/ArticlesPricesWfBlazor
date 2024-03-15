using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticlesPricesWfBlazor.wwwroot.css.bootstrap
{
    public partial class bootstrap : Component
    {
        public bootstrap()
        {
            InitializeComponent();
        }

        public bootstrap(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
