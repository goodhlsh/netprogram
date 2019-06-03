using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace BasicWPFDataBinding
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class WinBasicBinding : Window
    {
        public WinBasicBinding()
        {
            InitializeComponent();
        }
        #region OneTime绑定
         private void btnOneTimeBindingChange_Click(object sender, RoutedEventArgs e)
        {
              MyData source = (MyData)(panelOneTime.DataContext);
              source.Name = "Jerry";
              MessageBox.Show("myData.Name has been changed to Jerry","System Information",   MessageBoxButton.OK,
                MessageBoxImage.Information);
       }
 
          private void btnOnTimeBindingGet_Click(object sender, RoutedEventArgs e)
         {
              MyData source = (MyData)(panelOneTime.DataContext);
 
              string name = source.Name;
 
              MessageBox.Show( string.Format("myData.Name value is {0}.", name),"System Information", MessageBoxButton.OK,
               MessageBoxImage.Information);
           }
          #endregion
    
          #region OneWay绑定
         private void btnOneWayeBindingChange_Click(object sender, RoutedEventArgs e)
          {
             MyData source = (MyData)(panelOneWay.DataContext);
             source.Name = "Jerry";
    
              MessageBox.Show( "myData.Name has been changed to Jerry","System Information",MessageBoxButton.OK,
                 MessageBoxImage.Information);
           }
  
        private void btnOneWayBindingGet_Click(object sender, RoutedEventArgs e)
         {
             MyData source = (MyData)(panelOneWay.DataContext);
 
             string name = source.Name;
  
             MessageBox.Show(string.Format("myData.Name value is {0}.", name),"System Information", MessageBoxButton.OK,
                MessageBoxImage.Information);
          }
         #endregion
 
          #region TwoWay绑定
          private void btnTwoWayBindingChange_Click(object sender, RoutedEventArgs e)
          {
              MyData source = (MyData)(panelTwoWay.DataContext);
             source.Name = "Jerry";
 
              MessageBox.Show(
                 "myData.Name has been changed to Jerry","System Information", MessageBoxButton.OK,
                 MessageBoxImage.Information);
          }
  
        private void btnTwoWayBindingGet_Click(object sender, RoutedEventArgs e)
          {
              MyData source = (MyData)(panelTwoWay.DataContext);
 
             string name = source.Name;
  
              MessageBox.Show(
                 string.Format("myData.Name value is {0}.", name), "System Information",MessageBoxButton.OK,
                 MessageBoxImage.Information);
           }
        #endregion
 
       #region OneWayToSource绑定
        private void btnOneWayToSourceBindingChange_Click(object sender, RoutedEventArgs e)
       {
             MyData source = (MyData)(panelOneWayToSource.DataContext);
             source.Name = "Jerry";

            MessageBox.Show("myData.Name has been changed to Jerry","System Information",MessageBoxButton.OK, MessageBoxImage.Information);
        }

       private void btnOneWayToSourceBindingGet_Click(object sender, RoutedEventArgs e)
        {
            MyData source = (MyData)(panelOneWayToSource.DataContext);
  
            string name = source.Name;
  
             MessageBox.Show(
                string.Format("myData.Name value is {0}.", name),"System Information",MessageBoxButton.OK,       MessageBoxImage.Information);
        }
        #endregion
     }
}

  
