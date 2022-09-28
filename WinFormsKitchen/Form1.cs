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
using WinFormsKitchen.Threads;

namespace WinFormsKitchen
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();
        public MyTask myTask = new MyTask();
        
       async private void btnSnacks_Click(object sender, EventArgs e)
        {
            
            if (chblstSnacks.SelectedItem ==null)
            {
                MessageBox.Show("Сделайте свой выбор");
            }
            if(chblstSnacks.SelectedItem.ToString()== "Бекон")
            {
                lstResult.Items.Clear();
                lstResult.Items.Add("Время приготовления 20 мин.");
                await Task.Run(myTask.Frying);
                Thread.Sleep(5000);
                lstResult.Items.Add("Бекон готов!");
            }
            if (chblstSnacks.SelectedItem.ToString() == "Яичница")
            {
                lstResult.Items.Clear();
                lstResult.Items.Add("Время приготовления 10 мин.");
                await Task.Run(myTask.Frying);
                Thread.Sleep(5000);
                lstResult.Items.Add("Яичница готова!");
            }
            if (chblstSnacks.SelectedItem.ToString() == "Тост с сыром")
            {
                lstResult.Items.Clear();
                lstResult.Items.Add("Время приготовления 15 мин.");
                await Task.Run(myTask.MakingToast);
                Thread.Sleep(5000);
                lstResult.Items.Add("Тост с сыром готов!");
            }
            if (chblstSnacks.SelectedItem.ToString() == "Тост с мясом")
            {
                lstResult.Items.Clear();
                lstResult.Items.Add("Время приготовления 10 мин.");
                await Task.Run(myTask.MakingToast);
                Thread.Sleep(5000);
                lstResult.Items.Add("Тост с мясом готов!");
            }
            if (chblstDrinks.SelectedItem.ToString() == "Чай")
            {
                //lstResult.Items.Clear();
                lstResult.Items.Add("Время приготовления 5 мин.");
                await Task.Run(myTask.Boiling);
                Thread.Sleep(5000);
                lstResult.Items.Add("Чай готов!");
            }
            if (chblstDrinks.SelectedItem.ToString() == "Кофе")
            {
                //lstResult.Items.Clear();
                lstResult.Items.Add("Время приготовления 5 мин.");
                await Task.Run(myTask.Boiling);
                Thread.Sleep(5000);
                lstResult.Items.Add("Кофе готов!");
            }
        }
    }
        

        

        
    
}
