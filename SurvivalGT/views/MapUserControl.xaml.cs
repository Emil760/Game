using SurvivalGT.Models;
using SurvivalGT.Utility;
using SurvivalGT.viewmodels;
using System;
using System.ComponentModel;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace SurvivalGT.views
{
    /// <summary>
    /// Interaction logic for MapUserControl.xaml
    /// </summary>
    public partial class MapUserControl : UserControl, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private MainViewModel main_view_model;
        private Player player;

        private double zoom;
        private Timer move_timer;
        private bool is_moiving;
        private double full_time;
        private double curr_time;
        private Point mouse;
        private Point move;

        public MapUserControl(MainViewModel main_view_model)
        {
            InitializeComponent();
            DataContext = this;
            PrepareMoveCommand = new Command(PrepareMove);

            this.main_view_model = main_view_model;
            player = Player.Instance;
            arrow.Points = null;

            zoom = 1;
            move = new Point();

            move_timer = new Timer(16.666);
            move_timer.Elapsed += Timer_Elapsed;
        }

        public ICommand PrepareMoveCommand { get; }

        public Player Player { get => player; }

        private void PrepareMove(object param)
        {
            mouse = Mouse.GetPosition(map_window);
            mouse.X += viewer.HorizontalOffset;
            mouse.Y += viewer.VerticalOffset;
            arrow.Points = new PointCollection(new Point[2] { new Point(player.X + player.Width / 2, player.Y + player.Height / 2), new Point(mouse.X, mouse.Y) });
            curr_time = 0;
            full_time = Math.Round(Math.Sqrt(Math.Pow(Math.Abs(arrow.Points[0].X - arrow.Points[1].X), 2) + Math.Pow(Math.Abs(arrow.Points[0].Y - arrow.Points[1].Y), 2)) - Math.Sqrt(Math.Pow(player.Width, 2) + Math.Pow(player.Height, 2)));
            full_time = full_time / player.Speed * 10;
            move.X = (arrow.Points[1].X - arrow.Points[0].X) / full_time * 16.6;
            move.Y = (arrow.Points[1].Y - arrow.Points[0].Y) / full_time * 16.6;
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (full_time <= curr_time)
            {
                move_timer.Stop();
                main_view_model.Timer.Stop();
                is_moiving = false;
                Dispatcher.Invoke(() =>
                {
                    arrow.Points = null;
                });
                return;
            }
            player.X += move.X;
            player.Y += move.Y;
            curr_time += 16.6;
            Dispatcher.Invoke(() =>
            {
                arrow.Points = new PointCollection(new Point[2] { new Point(player.X + player.Width / 2, player.Y + player.Height / 2), new Point(mouse.X, mouse.Y) });
            });
        }

        private void map_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            e.Handled = true;
            if (e.Delta > 0)
            {
                if (zoom + 0.02 >= 1.6) return;
                zoom += 0.02;
                map.Width += map.Width * 0.02;
                map.Height += map.Height * 0.02;
                player.X += player.X * 0.02;
                player.Y += player.Y * 0.02;
                if (is_moiving)
                {
                    move.X += move.X * 0.02;
                    move.Y += move.Y * 0.02;
                }
                else
                {
                    if (arrow.Points != null)
                    {
                        arrow.Points = new PointCollection(new Point[2] { new Point(player.X + player.Width / 2, player.Y + player.Height / 2), new Point(arrow.Points[1].X + arrow.Points[1].X * 0.02, arrow.Points[1].Y + arrow.Points[1].Y * 0.02) });
                    }
                }
                if (arrow.Points != null)
                {
                    mouse.X += mouse.X * 0.02;
                    mouse.Y += mouse.Y * 0.02;
                }
            }
            else
            {
                if (zoom - 0.02 <= 0.3) return;
                zoom -= 0.02;
                map.Width -= map.Width * 0.02 * zoom;
                map.Height -= map.Height * 0.02 * zoom;
                player.X -= player.X * 0.02;
                player.Y -= player.Y * 0.02;
                if (is_moiving)
                {
                    move.X -= move.X * 0.02;
                    move.Y -= move.Y * 0.02;
                }
                else
                {
                    if (arrow.Points != null)
                    {
                        arrow.Points = new PointCollection(new Point[2] { new Point(player.X + player.Width / 2, player.Y + player.Height / 2), new Point(arrow.Points[1].X - arrow.Points[1].X * 0.02, arrow.Points[1].Y - arrow.Points[1].Y * 0.02) });
                    }
                }
                if (arrow.Points != null)
                {
                    mouse.X -= mouse.X * 0.02;
                    mouse.Y -= mouse.Y * 0.02;
                }
            }
            Console.WriteLine($"Zoom: {zoom}\tWidth:{map.Width}\tHeight: {map.Height}\n" +
                $"VerticalOffset: {viewer.VerticalOffset}\tHorizontalOffset: {viewer.HorizontalOffset}\n" +
                $"ExtentHeight: {viewer.ExtentHeight}\tExtentWidth: {viewer.ExtentWidth}\n" +
                $"ScrollableHeight: {viewer.ScrollableHeight}\tScrollableWidth: {viewer.ScrollableWidth}\n\n");
            //$"X1: {arrow.Points[0].X}\tY1: {arrow.Points[0].Y}\tX2: {arrow.Points[1].X}\tY2: {arrow.Points[1].Y}\n"
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (is_moiving)
            {
                move_timer.Stop();
                main_view_model.Timer.Stop();
                is_moiving = false;
            }
            else
            {
                move_timer.Start();
                main_view_model.Timer.Start();
                is_moiving = true;
            }
        }

        private void Move()
        {
        }

        private void StopMove()
        {

        }

        public void Set<T>(ref T prop, T value, [System.Runtime.CompilerServices.CallerMemberName] string prop_name = "")
        {
            prop = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop_name));
        }

        private void map_window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.W)
            {
                if (viewer.VerticalOffset <= 10) viewer.ScrollToTop();
                else viewer.ScrollToVerticalOffset(viewer.VerticalOffset - 10);
            }
            else if (e.Key == Key.S)
            {
                if (viewer.VerticalOffset + 10 >= viewer.ExtentHeight) viewer.ScrollToBottom();
                else viewer.ScrollToVerticalOffset(viewer.VerticalOffset + 10);
            }
            else if (e.Key == Key.A)
            {
                if (viewer.HorizontalOffset <= 10) viewer.ScrollToLeftEnd();
                else viewer.ScrollToHorizontalOffset(viewer.HorizontalOffset - 10);
            }
            else if (e.Key == Key.D)
            {
                if (viewer.HorizontalOffset + 10 >= viewer.ExtentWidth) viewer.ScrollToRightEnd();
                else viewer.ScrollToHorizontalOffset(viewer.HorizontalOffset + 10);
            }
        }
    }
}