using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsKitchen.Kitchen;
using WinFormsKitchen.Menu;
using WinFormsKitchen.Threads;

namespace WinFormsKitchen
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();
        public MyTask myTask = new MyTask();
        public List<Tableware> tablewares = new List<Tableware>();
        public List<ElementMenu> elementMenus = new List<ElementMenu>();
        private void btnSnacks_Click(object sender, EventArgs e)
        {
            tablewares.Add (new Kettle());
            tablewares.Add(new Pan());
            tablewares.Add(new Toaster());
            elementMenus.Add(new Bacon());
            elementMenus.Add(new Berries());
            elementMenus.Add(new Coffee());
            elementMenus.Add(new Eggs());
            elementMenus.Add(new Tea());
            elementMenus.Add(new Toast("Тост с сыром",10));
            elementMenus.Add(new Toast("Тост с мясом", 15));
            if (chblstSnacks.SelectedItem ==null)
            {
                MessageBox.Show("Сделайте свой выбор");
            }
            if(chblstSnacks.SelectedItem.ToString()== "Бекон")
            {
                //myTask.Cooking = new Task(myTask.Frying);
                Task.Run(myTask.Frying);
                Thread.Sleep(3000);
            }

        }
    }
        

        

        
    
}
