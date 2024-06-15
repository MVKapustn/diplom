﻿using AdditionalLibrary.Classes;
using System.Windows;
using System.Windows.Controls;

namespace DiplomKapustinMaximISP_41.Pages.BaseTestPgsMed
{
    public partial class BaseTestPgMed3 : Page
    {
        public BaseTestPgMed3()
        {
            InitializeComponent();
            progressBar.Value = BaseTestHelper.CalculateProgressBarStatus(PagesHelper.SkillLevel);
        }
        private void Continue_Click(object sender, RoutedEventArgs e)
        {
            bool isAnyPressed = falseRB1.IsChecked.Value || falseRB2.IsChecked.Value || trueRB1.IsChecked.Value;
            if (!isAnyPressed)
            {
                CustomMessageBoxWindow.Show(owner: PagesHelper.MainWindow, message: "Сперва Вам нужно ответить!", title: "Ошибка!");
                return;
            }
            BaseTestHelper.SaveAnswer(PagesHelper.SkillLevel, 2, trueRB1.IsChecked.Value);
            PagesHelper.GetTo("BaseTestPgsMed/BaseTestPgMed4");
        }
    }
}