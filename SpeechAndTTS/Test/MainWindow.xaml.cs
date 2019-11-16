using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Recognition;
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
using System.Speech.Synthesis;


namespace Test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SpeechRecognizer speechRecognizer = new SpeechRecognizer();
        }

        private void btnNew_Click(object sender, RoutedEventArgs e)
        {
            txtSpeech.Text = "";
        }

        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Command invoked: Open");
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Command invoked: Save");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SpeechSynthesizer speechsynth = new SpeechSynthesizer();
            // Configure the default audio output.
            speechsynth.SetOutputToDefaultAudioDevice();

            //Check if textbox is empty
            if(txtSpeech.Text.ToString() != "")
            {
                //Speak a string in textbox.
                string text = txtSpeech.Text.ToString();
                speechsynth.Speak(text);
            }
            else
            {
                //If textbox is empty 
                speechsynth.Speak("Textbox is empty.");
                           
            }
            
        }

        public void SpeechRecognizedHandler(object sender, SpeechRecognizedEventArgs e)
        {   
            //Get speech and convert it to string, check if it is equal to another string
            //Like button talk 
            if (e.Result.Text.ToString() == "talk")
            {
                SpeechSynthesizer speechsynth = new SpeechSynthesizer();
                // Configure the default audio output.
                speechsynth.SetOutputToDefaultAudioDevice();

                //Check if textbox is empty
                if (txtSpeech.Text.ToString() != "")
                {
                    //Speak a string in textbox.
                    string text = txtSpeech.Text.ToString();
                    speechsynth.Speak(text);
                }
                else
                {
                    //If textbox is empty 
                    speechsynth.Speak("Textbox is empty.");

                }
            }
            
        }

        //TODO
        //speech event close 
        //voice visualizer

    }
}
