using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
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
using Microsoft.Win32;
using Sweaj.Serialization.Wpf.Models;

namespace Sweaj.Serialization.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();       
        }

        private async void SaveVideoButton_Click(object sender, RoutedEventArgs e)
        {
            var json = ToJson();
            var saveFileDialog = new SaveFileDialog()
            {
                Title = "Save video information",
                Filter = "*json"
            };

            var dialogResult = saveFileDialog.ShowDialog();

            if (dialogResult.HasValue && !dialogResult.Value)
            {
                MessageBox.Show("Please enter a filename for saving.");
            }

            File.WriteAllText(saveFileDialog.FileName, json);
        }

        private async void OpenVideoButton_Click(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new OpenFileDialog()
            {
                Title = "Open video information",
                Filter = "*.json"
            };

            var dialogResult = openFileDialog.ShowDialog();
            if (dialogResult.HasValue && !dialogResult.Value)
            {
                MessageBox.Show("Please select a file.");
            }

            var json = File.ReadAllText(openFileDialog.FileName);
            var model = JsonSerializer.Deserialize<UploadVideoMetadata>(json);

            ApplyUiValuesFromModel(model);
        }

        private string ToJson()
        {
            var uploadVideo = new UploadVideoMetadata
            {
                AllowComments = AllowCommentsCheckBox.IsEnabled,
                AllowEmbedding = AllowEmbeddingCheckBox.IsEnabled,
                IsForMatureAudience = IsForAdultsCheckBox.IsEnabled,
                Category = CategoryComboBox.SelectedValue.ToString(),
                Description = DescriptionTextBox.Text,
                IsForChildren = IsForChildrenCheckBox.IsEnabled,
                IsMonetized = IsMonetizedCheckBox.IsEnabled,
                RecordingDate = RecordingDateDatePicker.SelectedDate.GetValueOrDefault(),
                Tags = TagsTextBox.Text,
                Title = TitleTextBox.Text,
                UploadDate = DateTime.Now,
                Visibility = VisibilityComboBox.SelectedValue.ToString()
            };

            var json = JsonSerializer.Serialize(uploadVideo);

            return json;
        }

        private void ApplyUiValuesFromModel(UploadVideoMetadata model)
        {
            AllowCommentsCheckBox.IsEnabled = model.AllowComments;
            AllowEmbeddingCheckBox.IsEnabled = model.AllowEmbedding;
            IsForAdultsCheckBox.IsEnabled = model.IsForMatureAudience;
            CategoryComboBox.SelectedItem = model.Category;
            DescriptionTextBox.Text = model.Description;
            IsForChildrenCheckBox.IsEnabled = model.IsForChildren;
            IsMonetizedCheckBox.IsEnabled = model.IsMonetized;
            RecordingDateDatePicker.SelectedDate = model.RecordingDate;
            TagsTextBox.Text = model.Tags;
            TitleTextBox.Text = model.Title;
            VisibilityComboBox.SelectedItem = model.Visibility;
        }
    }
}
