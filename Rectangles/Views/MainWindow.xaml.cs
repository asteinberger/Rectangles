using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Rectangles.Controllers;

namespace Rectangles.Views
{
    public partial class MainWindow : Window
    {
        BoxController bc;

        public MainWindow()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(OnButtonKeyDown);
            this.Title = "Rectangles";
            bc = new BoxController(this);
            bc.displayBoxes();
            CanvasBorder.BorderThickness = new Thickness(1);
        }

        private void OnButtonKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Up:
                case Key.W:
                    bc.moveUp();
                    break;
                case Key.Left:
                case Key.A:
                    bc.moveLeft();
                    break;
                case Key.Right:
                case Key.D:
                    bc.moveRight();
                    break;
                case Key.Down:
                case Key.S:
                    bc.moveDown();
                    break;
                case Key.Delete:
                    bc.addBox();
                    bc.removeBox();
                    break;
                case Key.Space:
                    bc.switchBox();
                    break;
                case Key.C:
                    bc.changeBoxColor();
                    break;
                case Key.B:
                    bc.changeBgColor();
                    break;
                case Key.L:
                    bc.printLogs();
                    break;
                case Key.Escape:
                    this.Close();
                    break;
            }
            bc.displayBoxes();
        }
    }
}
