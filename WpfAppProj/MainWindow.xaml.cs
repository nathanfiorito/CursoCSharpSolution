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
using CoursesLibNS;

namespace WpfAppProj
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }
        
        private void ButtonCode_Click(object sender, RoutedEventArgs e)
        {
            CoursesLibClass course = new CoursesLibClass();
            course.CourseNotFoundEvent += Course_CourseNotFoundEvent;
            labelCode.Content = course.ShowCourseName(textBoxCode.Text);
        }

        private void Course_CourseNotFoundEvent(int code)
        {
            MessageBox.Show($"O curso com o código {code} não foi encontrado.","Curso não encontrado.");
        }
    }
}
