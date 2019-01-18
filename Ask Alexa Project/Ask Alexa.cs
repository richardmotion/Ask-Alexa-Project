using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace Ask_Alexa_Project
{
    public partial class Form1 : Form
    {
        SpeechSynthesizer synth = new SpeechSynthesizer();
        private int index = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            //Points to the synched file from the web server.
            var lines = File.ReadAllLines("C:\\AlexaQuestions.txt");
            //Sets the text box on the UI to show the current question (starting from the first line in text file).
            if (index < lines.Length)
                textBox1.Text = lines[index++];
            //Speaks the question displayed in the UI text box.
            synth.SpeakAsync(textBox1.Text);
        }
    }
}
