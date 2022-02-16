// 
// COP4365 – Spring Semester, 2022 
// 
//Homework #1: The Four Way Stoplight Problem 
// 
// Orestes Bringas
// 
// 

namespace Stoplights
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void nRed_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void nGreen_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void sRed_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void sGreen_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void eRed_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void eGreen_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void wRed_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void wGreen_CheckedChanged(object sender, EventArgs e)
        {

        }

        //
        //Method: Run_Click
        //Description: on click, it runs the current settings for the selected lights and prints out the configuration while also displaying the stoplight color changes.
        //Uses each stoplight individually along with if statements to properly change the stoplight settings. No error codes were specified thus, no exception handling is present.
        private void Run_Click(object sender, EventArgs e)
        {  
            Stoplight North = new Stoplight();
            Stoplight South = new Stoplight();
            Stoplight East = new Stoplight();
            Stoplight West = new Stoplight();

            nRedLight.BackColor = Color.Gray;
            sRedLight.BackColor = Color.Gray;
            eRedLight.BackColor = Color.Gray;
            wRedLight.BackColor = Color.Gray;
            nGreenLight.BackColor = Color.Gray;
            sGreenLight.BackColor = Color.Gray;
            eGreenLight.BackColor = Color.Gray;
            wGreenLight.BackColor = Color.Gray;

            if (nRed.Checked)
            {
                North.currState = "Red";
                nRedLight.BackColor = Color.Red;
            }
            else 
            { 
                North.currState = "Green";
                nGreenLight.BackColor = Color.Green;
            }

            if (sRed.Checked)
            {
                South.currState = "Red";
                sRedLight.BackColor = Color.Red;
            }
            else
            {
                South.currState = "Green";
                sGreenLight.BackColor = Color.Green;
            }

            if (eRed.Checked)
            {
                East.currState = "Red";
                eRedLight.BackColor = Color.Red;
            }
            else
            {
                East.currState = "Green";
                eGreenLight.BackColor = Color.Green;
            }

            if (wRed.Checked)
            {
                West.currState = "Red";
                wRedLight.BackColor = Color.Red;
            }
            else
            {
                West.currState = "Green";
                wGreenLight.BackColor = Color.Green;
            }

            textBox1.Text = "North is: " + North.currState + "\r\nSouth is: " + South.currState + "\r\nEast is: " + East.currState + "\r\nWest is: " + West.currState;


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    public class Stoplight
    {
        public string currState = " ";
    }
}