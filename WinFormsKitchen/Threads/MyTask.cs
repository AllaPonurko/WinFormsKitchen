using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WinFormsKitchen.Threads
{
    public class MyTask
    {
        public Action Frying;
        public Action Boiling;
        public Action MakingToast;
        public Task Cooking;
    }
}
