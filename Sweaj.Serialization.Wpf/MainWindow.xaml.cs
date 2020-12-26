using System;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Microsoft.Win32;
using Sweaj.Serialization.Wpf.Models;
using Sweaj.Serialization.Wpf.Services;
using Sweaj.Serialization.Wpf.ViewModels;

namespace Sweaj.Serialization.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ConfigureViewModel configureViewModel;

        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            configureViewModel = await ConfigureViewModelFactory.From(SchemeTextBox.Text, HostTextBox.Text, int.Parse(PortTextBox.Text), EndpointTextBox.Text);
            UpdateConfigureUi();
        }

        private async void SaveVideoButton_Click(object sender, RoutedEventArgs e)
        {
            var json = ToJson();
            var saveFileDialog = new SaveFileDialog()
            {
                Title = "Save video information",
                Filter = "JSON file|*.json"
            };

            var dialogResult = saveFileDialog.ShowDialog();

            if (dialogResult.HasValue && !dialogResult.Value)
            {
                MessageBox.Show("Please enter a filename for saving.");
                return;
            }

            File.WriteAllText(saveFileDialog.FileName, json);
        }

        private void OpenVideoButton_Click(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new OpenFileDialog()
            {
                Title = "Open video information",
                Filter = "JSON file|*.json"
            };

            var dialogResult = openFileDialog.ShowDialog();
            if (dialogResult.HasValue && !dialogResult.Value)
            {
                MessageBox.Show("Please select a file.");
                return;
            }

            var json = File.ReadAllText(openFileDialog.FileName);
            var model = JsonSerializer.Deserialize<UploadVideoDetails>(json);

            ApplyUiValuesFromModel(model);
        }

        private void ClearFormButton_Click(object sender, RoutedEventArgs e)
        {
            ClearForm();
        }

        private async void UploadVideoButton_Click(object sender, RoutedEventArgs e)
        {
            var model = GetUploadVideoMetadataModelFromUi();
            var response = await configureViewModel.HttpClient.PostAsJsonAsync("upload", new[] { model });

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Successfully uploaded the video!");
            }
            else
            {
                MessageBox.Show("Failed to upload video to the API.", $"Response {response.StatusCode}", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private async void CheckStatusButton_Click(object sender, RoutedEventArgs e)
        {
            configureViewModel = await ConfigureViewModelFactory.From(SchemeTextBox.Text, HostTextBox.Text, int.Parse(PortTextBox.Text), EndpointTextBox.Text);
            UpdateConfigureUi();
        }

        private void UpdateConfigureUi()
        {
            StatusTextBox.Text = configureViewModel.Status;
            if (configureViewModel.IsSuccessful)
                StatusTextBox.Foreground = Brushes.Green;
            else
            {
                StatusTextBox.Foreground = Brushes.IndianRed;
                MessageBox.Show(configureViewModel.ErrorInfo, "Response", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private string ToJson()
        {
            var uploadVideo = GetUploadVideoMetadataModelFromUi();
            var json = JsonSerializer.Serialize(uploadVideo, new JsonSerializerOptions() { WriteIndented = true });

            return json;
        }

        private UploadVideoDetails GetUploadVideoMetadataModelFromUi()
        {
            var uploadVideo = new UploadVideoDetails
            {
                AllowComments = AllowCommentsCheckBox.IsChecked.Value,
                AllowEmbedding = AllowEmbeddingCheckBox.IsChecked.Value,
                IsForMatureAudience = IsForAdultsCheckBox.IsChecked.Value,
                Category = (string)((ComboBoxItem)CategoryComboBox.SelectedItem).Content,
                Description = DescriptionTextBox.Text,
                IsForChildren = IsForChildrenCheckBox.IsChecked.Value,
                IsMonetized = IsMonetizedCheckBox.IsChecked.Value,
                RecordingDate = RecordingDateDatePicker.SelectedDate.GetValueOrDefault(),
                Tags = TagsTextBox.Text,
                Title = TitleTextBox.Text,
                UploadDate = DateTime.Now,
                Visibility = (string)((ComboBoxItem)VisibilityComboBox.SelectedItem).Content
            };

            return uploadVideo;
        }

        private void ApplyUiValuesFromModel(UploadVideoDetails model)
        {
            AllowCommentsCheckBox.IsChecked = model.AllowComments;
            AllowEmbeddingCheckBox.IsChecked = model.AllowEmbedding;
            IsForAdultsCheckBox.IsChecked = model.IsForMatureAudience;
            CategoryComboBox.SelectedIndex = CategoryComboBox.Items.IndexOf(model.Category);
            DescriptionTextBox.Text = model.Description;
            IsForChildrenCheckBox.IsChecked = model.IsForChildren;
            IsMonetizedCheckBox.IsChecked = model.IsMonetized;
            RecordingDateDatePicker.SelectedDate = model.RecordingDate;
            TagsTextBox.Text = model.Tags;
            TitleTextBox.Text = model.Title;
            VisibilityComboBox.SelectedIndex = 1;
        }

        private void ClearForm()
        {
            AllowCommentsCheckBox.IsChecked = false;
            AllowEmbeddingCheckBox.IsChecked = false;
            IsForAdultsCheckBox.IsChecked = false;
            CategoryComboBox.SelectedItem = null;
            DescriptionTextBox.Text = string.Empty;
            IsForChildrenCheckBox.IsChecked = false;
            IsMonetizedCheckBox.IsChecked = false;
            RecordingDateDatePicker.SelectedDate = null;
            TagsTextBox.Text = string.Empty;
            TitleTextBox.Text = string.Empty;
            VisibilityComboBox.SelectedItem = null;
        }
    }
}
