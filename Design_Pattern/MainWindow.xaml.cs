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

namespace Design_Pattern
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {

        private static MainWindow _instance = null; // Singleton 인스턴스를 저장할 필드
        private static readonly object padlock = new object();  // thread-safe를 위한 lock 객체

        public MainWindow()
        {
            InitializeComponent();
        }

        public static MainWindow Instance    // Singleton 인스턴스에 접근할 수 있는 public static 속성
        {
            get
            {
                lock (padlock)
                {
                    if (_instance == null)  // 인스턴스가 아직 생성되지 않았다면 생성
                    {
                        _instance = new MainWindow();
                    }
                    return _instance; // 이미 생성된 Singleton 인스턴스를 반환
                }
            }
        }
    }
}
