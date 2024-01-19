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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AndroidWidgetForWindows
{
    /// <summary>
    /// Window1.xaml の相互作用ロジック
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        private async void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            // 高さのアニメーション
            DoubleAnimation heightAnimation = new DoubleAnimation();
            heightAnimation.From = 0;      // 開始位置
            heightAnimation.To = Height;   // 終了位置
            heightAnimation.Duration = new Duration(TimeSpan.FromSeconds(1)); // アニメーションの期間

            // ウィンドウのHeightプロパティにアニメーションを適用
            BeginAnimation(Window.HeightProperty, heightAnimation);

            // 左から右のアニメーション
            DoubleAnimation leftAnimation = new DoubleAnimation();
            leftAnimation.From = -Width;  // 開始位置
            leftAnimation.To = 0;         // 終了位置
            leftAnimation.Duration = new Duration(TimeSpan.FromSeconds(1)); // アニメーションの期間

            // ウィンドウのLeftプロパティにアニメーションを適用
            BeginAnimation(Window.LeftProperty, leftAnimation);

            // 下から上のアニメーション
            DoubleAnimation topAnimation = new DoubleAnimation();
            topAnimation.From = SystemParameters.PrimaryScreenHeight;  // 開始位置
            topAnimation.To = 800;          // 終了位置
            topAnimation.Duration = new Duration(TimeSpan.FromSeconds(1)); // アニメーションの期間

            // ウィンドウのTopプロパティにアニメーションを適用
            BeginAnimation(Window.TopProperty, topAnimation);
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation heightAnimation = new DoubleAnimation();
            heightAnimation.From = Height;      // 開始位置
            heightAnimation.To = 0;   // 終了位置
            heightAnimation.Duration = new Duration(TimeSpan.FromSeconds(1)); // アニメーションの期間

            // ウィンドウのHeightプロパティにアニメーションを適用
            BeginAnimation(Window.HeightProperty, heightAnimation);

            // 左から右のアニメーション
            DoubleAnimation leftAnimation = new DoubleAnimation();
            leftAnimation.From = 0;  // 開始位置
            leftAnimation.To = -Width;         // 終了位置
            leftAnimation.Duration = new Duration(TimeSpan.FromSeconds(1)); // アニメーションの期間

            // ウィンドウのLeftプロパティにアニメーションを適用
            BeginAnimation(Window.LeftProperty, leftAnimation);

            // 下から上のアニメーション
            DoubleAnimation topAnimation = new DoubleAnimation();
            topAnimation.From = 800;  // 開始位置
            topAnimation.To = SystemParameters.PrimaryScreenHeight;          // 終了位置
            topAnimation.Duration = new Duration(TimeSpan.FromSeconds(1)); // アニメーションの期間

            // ウィンドウのTopプロパティにアニメーションを適用
            BeginAnimation(Window.TopProperty, topAnimation);
            await Task.Delay(1000);
            this.Close();
        }
    }
}
