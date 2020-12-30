﻿using SurvivalGT.Models;
using SurvivalGT.viewmodels;
using System;
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
    public partial class MapUserControl : UserControl
    {
        private MainViewModel main_view_model;
        private Player player;

        private double full_time;
        private double curr_time;
        private float zoom_per;
        private Point to;
        private Point move;

        public MapUserControl(MainViewModel main_view_model)
        {
            InitializeComponent();
            this.main_view_model = main_view_model;
            DataContext = main_view_model;

            player = Player.Instance;

            ellipse.Width = player.Width;
            ellipse.Height = player.Height;
            Canvas.SetLeft(ellipse, player.X);
            Canvas.SetTop(ellipse, player.Y);
            arrow.Points = null;

            canvas.Width = 5000;
            canvas.Height = 5000;

            move = new Point();

            main_view_model.IsMoving = false;
            main_view_model.Timer.Elapsed += Timer_Elapsed;

            zoom_per = 1.02f;
        }

        private void Canvas_PrepareMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                to = Mouse.GetPosition(map_control);
                to.X += viewer.HorizontalOffset;
                to.Y += viewer.VerticalOffset;
                arrow.Points = new PointCollection(new Point[2] { new Point(player.X + player.Width / 2, player.Y + player.Height / 2), new Point(to.X, to.Y) });
                curr_time = 0;
                full_time = Math.Round(Math.Sqrt(Math.Pow(Math.Abs(arrow.Points[0].X - arrow.Points[1].X), 2) + Math.Pow(Math.Abs(arrow.Points[0].Y - arrow.Points[1].Y), 2)) - Math.Sqrt(Math.Pow(player.Width, 2) + Math.Pow(player.Height, 2)));
                full_time = full_time / player.Speed * 10;
                move.X = (arrow.Points[1].X - arrow.Points[0].X) / full_time * main_view_model.Game.Fps;
                move.Y = (arrow.Points[1].Y - arrow.Points[0].Y) / full_time * main_view_model.Game.Fps;
            }
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (full_time <= curr_time)
            {
                main_view_model.Timer.Stop();
                main_view_model.IsMoving = false;
                Dispatcher.Invoke(() =>
                {
                    arrow.Points = null;
                });
                return;
            }
            player.X += move.X;
            player.Y += move.Y;
            curr_time += main_view_model.Game.Fps;
            Dispatcher.Invoke(() =>
            {
                Canvas.SetLeft(ellipse, player.X);
                Canvas.SetTop(ellipse, player.Y);
                arrow.Points = new PointCollection(new Point[2] { new Point(player.X + player.Width / 2, player.Y + player.Height / 2), new Point(to.X, to.Y) });
            });
        }

        private void canvas_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            Console.WriteLine(main_view_model.Game.Zoom + "\t" + canvas.Width + "\t" + canvas.Height);
            e.Handled = true;
            if (e.Delta > 0 && main_view_model.Game.Zoom <= 2)
            {
                main_view_model.Game.Zoom += (zoom_per - 1);
                canvas.Width *= zoom_per;
                canvas.Height *= zoom_per;

                player.X *= zoom_per;
                player.Y *= zoom_per;
                player.Width *= zoom_per;
                player.Height *= zoom_per;

                move.X *= zoom_per;
                move.Y *= zoom_per;

                to.X *= zoom_per;
                to.Y *= zoom_per;

                ellipse.Width = player.Width;
                ellipse.Height = player.Height;
                Canvas.SetLeft(ellipse, player.X);
                Canvas.SetTop(ellipse, player.Y);

                if (arrow.Points != null)
                {
                    arrow.Points = new PointCollection(new Point[2] { new Point(player.X + player.Width / 2, player.Y + player.Height / 2), new Point(arrow.Points[1].X * zoom_per, arrow.Points[1].Y * zoom_per) });
                }
            }
            else if (main_view_model.Game.Zoom >= 0.5)
            {
                main_view_model.Game.Zoom -= (zoom_per - 1);
                canvas.Width /= zoom_per;
                canvas.Height /= zoom_per;

                player.X /= zoom_per;
                player.Y /= zoom_per;
                player.Width /= zoom_per;
                player.Height /= zoom_per;

                move.X /= zoom_per;
                move.Y /= zoom_per;

                to.X /= zoom_per;
                to.Y /= zoom_per;

                ellipse.Width = player.Width;
                ellipse.Height = player.Height;
                Canvas.SetLeft(ellipse, player.X);
                Canvas.SetTop(ellipse, player.Y);

                if (arrow.Points != null)
                {
                    arrow.Points = new PointCollection(new Point[2] { new Point(player.X + player.Width / 2, player.Y + player.Height / 2), new Point(arrow.Points[1].X / zoom_per, arrow.Points[1].Y / zoom_per) });
                }
            }
        }


        private void Canvas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.W)
            {
                if (viewer.VerticalOffset != 0)
                {
                    if (viewer.VerticalOffset <= 10)
                    {
                        Canvas.SetTop(move_btn, Canvas.GetTop(move_btn) - viewer.VerticalOffset);
                        Canvas.SetTop(sleep_btn, Canvas.GetTop(sleep_btn) - viewer.VerticalOffset);
                        viewer.ScrollToTop();
                    }
                    else
                    {
                        Canvas.SetTop(move_btn, Canvas.GetTop(move_btn) - 10);
                        Canvas.SetTop(sleep_btn, Canvas.GetTop(sleep_btn) - 10);
                        viewer.ScrollToVerticalOffset(viewer.VerticalOffset - 10);
                    }
                }
            }
            else if (e.Key == Key.S)
            {
                if (viewer.VerticalOffset != viewer.Height - viewer.ExtentHeight)
                {
                    if (viewer.VerticalOffset + 10 >= viewer.ExtentHeight)
                    {
                        Canvas.SetTop(move_btn, Canvas.GetTop(move_btn) + viewer.VerticalOffset);
                        Canvas.SetTop(sleep_btn, Canvas.GetTop(sleep_btn) + viewer.VerticalOffset);
                        viewer.ScrollToBottom();
                    }
                    else
                    {
                        Canvas.SetTop(move_btn, Canvas.GetTop(move_btn) + 10);
                        Canvas.SetTop(sleep_btn, Canvas.GetTop(sleep_btn) + 10);
                        viewer.ScrollToVerticalOffset(viewer.VerticalOffset + 10);
                    }
                }
            }
            else if (e.Key == Key.A)
            {
                if (viewer.HorizontalOffset != 0)
                {
                    if (viewer.HorizontalOffset <= 10)
                    {
                        Canvas.SetLeft(move_btn, Canvas.GetLeft(move_btn) - viewer.HorizontalOffset);
                        Canvas.SetLeft(sleep_btn, Canvas.GetLeft(sleep_btn) - viewer.HorizontalOffset);
                        viewer.ScrollToLeftEnd();
                    }
                    else
                    {
                        Canvas.SetLeft(move_btn, Canvas.GetLeft(move_btn) - 10);
                        Canvas.SetLeft(sleep_btn, Canvas.GetLeft(sleep_btn) - 10);
                        viewer.ScrollToHorizontalOffset(viewer.HorizontalOffset - 10);
                    }
                }
            }
            else if (e.Key == Key.D)
            {
                if (viewer.HorizontalOffset != viewer.Width - viewer.ExtentWidth)
                {
                    if (viewer.HorizontalOffset + 10 >= viewer.ExtentWidth)
                    {
                        Canvas.SetLeft(move_btn, Canvas.GetLeft(move_btn) + viewer.HorizontalOffset);
                        Canvas.SetLeft(sleep_btn, Canvas.GetLeft(sleep_btn) + viewer.HorizontalOffset);
                        viewer.ScrollToRightEnd();
                    }
                    else
                    {
                        Canvas.SetLeft(move_btn, Canvas.GetLeft(move_btn) + 10);
                        Canvas.SetLeft(sleep_btn, Canvas.GetLeft(sleep_btn) + 10);
                        viewer.ScrollToHorizontalOffset(viewer.HorizontalOffset + 10);
                    }
                }
            }
        }

        private void Sleep_ClickBtn(object sender, RoutedEventArgs e)
        {

        }

        private void Move_ClickBtn(object sender, RoutedEventArgs e)
        {
            if (main_view_model.IsMoving)
            {
                main_view_model.IsMoving = false;
                main_view_model.Timer.Stop();
            }
            else if (arrow.Points != null)
            {
                main_view_model.IsMoving = true;
                main_view_model.Timer.Start();
            }
        }

        private void Canvas_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (e.WidthChanged)
            {
                SetButtonsX();
            }
            if (e.HeightChanged)
            {
                SetButtonsY();
            }
        }

        private void Canvas_Loaded(object sender, RoutedEventArgs e)
        {
            SetButtonsX();
            SetButtonsY();
        }

        private void map_control_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (e.WidthChanged)
            {
                SetButtonsX();

            }
            if (e.HeightChanged)
            {
                SetButtonsY();
            }
        }

        private void SetButtonsX()
        {
            Canvas.SetLeft(move_btn, viewer.HorizontalOffset + viewer.ActualWidth - 150);
            Canvas.SetLeft(sleep_btn, viewer.HorizontalOffset + viewer.ActualWidth - 150);
        }

        private void SetButtonsY()
        {
            Canvas.SetTop(move_btn, viewer.VerticalOffset + viewer.ActualHeight - 280);
            Canvas.SetTop(sleep_btn, viewer.VerticalOffset + viewer.ActualHeight - 160);
        }
    }
}