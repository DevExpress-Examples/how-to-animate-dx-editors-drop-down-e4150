using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace AnimatedDropDown
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            comboBoxEdit1.ItemsSource = CreateData(10);
        }

        private static List<string> CreateData(int listCnt)
        {
            List<string> list = new List<string>();
            for (int i = 0; i < listCnt; i++)
                list.Add("Item" + (i + 1));
            return list;
        }
    }
}