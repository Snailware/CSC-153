/**
* 1/28/2021
* CSC 153
* Adam Lancaster
* Drivers License Exam Grader
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DLExam
{
	public partial class Main_Form : Form
	{
		public Main_Form()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int grade = 100;
			// create grade variable. 

			int no_correct = 20;
			// create correct answer count variable.

			int no_incorrect = 0;
			// create incorrect answer count variable.

			char[] answers = {'B', 'D', 'A', 'A', 'C', 'A', 'B', 'A', 'C', 'D',
				'B', 'C', 'D', 'A', 'D', 'C', 'C', 'B', 'D', 'A'};
			// create array for answer key.

			string[] rough_student_answers = 
				File.ReadAllLines(@"..\..\student_answers.txt");
			// create array for students answers. 

			string rough_answer_string = "";
			// create string var to use for char conversion of student answers. 

			foreach (string answer in rough_student_answers)
			{
				rough_answer_string += answer;
			}
			// loop creates string from array of single character strings.

			char[] student_answers = rough_answer_string.ToCharArray();
			// convert created string to char array.

			List<int> incorrect_questions = new List<int>();
			// create list to hold incorrect question numbers. 

			for (int q_no = 0; q_no < answers.Length; q_no++)
			{
				if (answers[q_no] != student_answers[q_no])
				{
					incorrect_questions.Add(q_no + 1);
					grade -= 5;
					no_correct -= 1;
					no_incorrect += 1;
				}
			}
			/* this loops through all questions, comparing the answers in the
			answer key to the answers submitted in the student answers file.
			if values are not the same, question number is added to
			incorrect_questions list, grade is reduced by 5 points, and counter
			variables are updated accordingly.*/

			correctAnswersTextBox.Text = no_correct.ToString();
			// insert correct answer number in correctAnswersTextBox.

			incorrectAnswersTextBox.Text = no_incorrect.ToString();
			// insert incorrect answer number into incorrectAnswerTextBox.

			incorrectQuestionListBox.DataSource = incorrect_questions;
			// connect incorrect question list to incorrectQuestionListBox.

			gradeBox.Text = grade.ToString() + "%";
			// insert grade value into gradeBox.

			if (grade >= 75)
			{
				responseBox.Text = "Passed";
			}
			else
			{
				responseBox.Text = "Failed";
			}
			/* set responseBox to "Passed" if student got atleast 15 questions
			correct (a grade of 75 or more). If not, set responseBox to
			"Failed". */
		}

		private void closeButton_Click(object sender, EventArgs e)
		{
			this.Close();
			// close program. 
		}
	}
}
