using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace QuizGame
{
    public partial class MainForm : Form
    {
        MySqlConnection connection;
        MySqlCommand cmd;
        MySqlDataReader dr;
        string displayQuestion, choiceA, choiceB, choiceC, choiceD; // variables for the questions and questions
   

        private void randomBtn_Click(object sender, EventArgs e)
        {
         
        }

        public MainForm()
        {
            InitializeComponent();
            ConnectToSQL();
            GetQuestionsAndAnswers();
        }
        // Connect to the SQL database
        void ConnectToSQL()
        {
            try
            {
                connection = new MySqlConnection("Server=localhost;Database=logindb;user=root;password=123456789;");
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    label1.Text = "[/]";
                    label1.ForeColor = Color.Green;

                }
                else
                {
                    label1.Text = "[X]";
                    label1.ForeColor = Color.Red;
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // Gets the question and answers from the database and assigns it to the string holders
       void GetQuestionsAndAnswers()
        {
            cmd = new MySqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "SELECT column FROM questions_and_answers_table;ORDER BY RAND();LIMIT 1";
            connection.Close();
        }


    }
}
