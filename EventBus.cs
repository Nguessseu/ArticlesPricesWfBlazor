using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticlesPricesWfBlazor
{
    public static class EventBus
    {

        public delegate void MessageBoxEventHandler(string message);


        public static void ShowMessageBox(string message)
        {
            if (ShowMessageBoxEvent != null)
            {
                ShowMessageBoxEvent(message);
            }
        }
        public static event MessageBoxEventHandler? ShowMessageBoxEvent;


    }
}
