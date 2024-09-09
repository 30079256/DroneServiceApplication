using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace IcarusDrones
{
    // Student Name: Olga Selezneva
    // Student ID: 30079256

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        List<Drone> FinishedList = new List<Drone>();
        Queue<Drone> RegularService = new Queue<Drone>();
        Queue<Drone> ExpressService = new Queue<Drone>();

        private void AddNewItem(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBoxClientName.Text) &&
                !string.IsNullOrEmpty(TextBoxDroneModel.Text) &&
                 !string.IsNullOrEmpty(TextBoxServiceCost.Text) &&
                 !string.IsNullOrEmpty(TextBoxServiceProblem.Text))
            {
                Drone droneItem = new Drone();
                droneItem.SetClientName(TextBoxClientName.Text);
                droneItem.SetDroneModel(TextBoxDroneModel.Text);                
                droneItem.SetServiceProblem(TextBoxServiceProblem.Text);
                droneItem.SetServiceTag(IncrementServiceTag());
                droneItem.SetServiceCost(double.Parse(TextBoxServiceCost.Text));

                if (GetServicePriority() == "RadioButtonRegular")
                {
                    RegularService.Enqueue(droneItem);
                    DisplayRegularServiceItems();
                }
                else if (GetServicePriority() == "RadioButtonExpress")
                {
                    droneItem.IncreaseServiceCost();
                    ExpressService.Enqueue(droneItem);
                    DisplayExpressServiceItems();
                }

                ClearTextBoxes();
            }            
        }

        private void DisplayRegularServiceItems()
        {
            ListViewRegularService.Items.Clear();
            foreach (Drone regularItem in RegularService)
            {
                ListViewRegularService.Items.Add(new
                {
                    RegularServiceTag = regularItem.GetServiceTag(),
                    RegularClientName = regularItem.GetClientName(),
                    RegularDroneModel = regularItem.GetDroneModel(),
                    RegularServiceCost = regularItem.GetServiceCost(),
                    RegularServiceProblem = regularItem.GetServiceProblem(),
                });                  
            }            
        }

        private void DisplayExpressServiceItems()
        {
            ListViewExpressService.Items.Clear();
            foreach (Drone expressItem in ExpressService)
            {
                ListViewExpressService.Items.Add(new
                {
                    ExpressServiceTag = expressItem.GetServiceTag(),
                    ExpressClientName = expressItem.GetClientName(),
                    ExpressDroneModel = expressItem.GetDroneModel(),
                    ExpressServiceCost = expressItem.GetServiceCost(),
                    ExpressServiceProblem = expressItem.GetServiceProblem(),
                });
            }
        }

        private void ClearTextBoxes()
        {
            TextBoxClientName.Clear();
            TextBoxDroneModel.Clear();
            TextBoxServiceCost.Clear();
            TextBoxServiceProblem.Clear();
            RadioButtonRegular.IsChecked = true;
        }

        private string GetServicePriority()
        {
            foreach (RadioButton rb in StackPanelServicePriority.Children.OfType<RadioButton>())
            {
                if (rb.IsChecked == true)
                {
                    return rb.Name;
                }
            }

            return "RadioButtonRegular";
        }

        private void TextBoxServiceCost_LostFocus(object sender, RoutedEventArgs e)
        {            
            Regex regex = new(@"\b\d+\.\d{2}\b");
                        
            if (!regex.IsMatch(TextBoxServiceCost.Text))
            {
                StatusLabelFeedback.Text = "Please enter a valid number with up to two decimal places.";
                TextBoxServiceCost.Clear();                
            }            
        }

        private void TextBoxServiceCost_GotFocus(object sender, RoutedEventArgs e)
        {
            StatusLabelFeedback.Text = "";
        }

        private int? IncrementServiceTag()
        {
            int? serviceTag = IntegerUpDownServiceTag.Value + 10;            
            IntegerUpDownServiceTag.Value = serviceTag;
            return serviceTag; 
        }

        private void ListViewRegularService_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ListViewRegularService.SelectedIndex != -1)
            {
                int index = ListViewRegularService.SelectedIndex;
                TextBoxClientName.Text = RegularService.ElementAt(index).GetClientName();
                TextBoxServiceProblem.Text = RegularService.ElementAt(index).GetServiceProblem();
            }
        }

        private void ListViewExpressService_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ListViewExpressService.SelectedIndex != -1)
            {
                int index = ListViewExpressService.SelectedIndex;
                TextBoxClientName.Text = ExpressService.ElementAt(index).GetClientName();
                TextBoxServiceProblem.Text = ExpressService.ElementAt(index).GetServiceProblem();
            }
        }

        private void ButtonFinishRegularService_Click(object sender, RoutedEventArgs e)
        {
            if (RegularService.Count > 0)
            {                
                FinishedList.Add(RegularService.Dequeue());
                DisplayFinishedServiceItems();
                DisplayRegularServiceItems();
            }            
        }

        private void ButtonFinishExpressService_Click(object sender, RoutedEventArgs e)
        {
            if (ExpressService.Count > 0)
            {                
                FinishedList.Add(ExpressService.Dequeue());
                DisplayFinishedServiceItems();
                DisplayExpressServiceItems();
            }            
        }

        private void DisplayFinishedServiceItems()
        {
            ListBoxFinishedItems.Items.Clear();
            foreach (Drone finishedItem in FinishedList)
            {                
                ListBoxFinishedItems.Items.Add(Drone.DisplayNameAndCost(finishedItem.GetClientName(), finishedItem.GetServiceCost()));
            }
        }

        private void ListBoxFinishedItems_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            int selectedIndex = ListBoxFinishedItems.SelectedIndex;
            if (selectedIndex != -1)            
            {
                FinishedList.RemoveAt(selectedIndex);
                DisplayFinishedServiceItems();
            }
        }
    }   
}
