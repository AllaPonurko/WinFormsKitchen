using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsKitchen.Threads
{
    public class MyTask
    {
        public Action Frying=>new Action(MethodFrying);
        public Action Boiling=>new Action(MethodBoiling);
        public Action MakingToast=>new Action(MethodMakingToast);
        public Task Cooking;
        public void MethodFrying()
        {
            MessageBox.Show("Используй сковородку");
        }
        public void MethodBoiling()
        {
            MessageBox.Show("Используй чайник");
        }
        public void MethodMakingToast()
        {
            MessageBox.Show("Используй тостер");
        }
    }
}
