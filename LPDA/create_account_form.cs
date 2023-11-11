using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LPDA
{
    public partial class create_account_form : Form
    {
        LRegDate data = new LRegDate(); //    "data " is bject name of LRegData.class's fils created. 

        public create_account_form()
        {
            InitializeComponent( );
        }
        private void UpdateData(LRegDate updatedData)
        { 
            data = updatedData;// <---- Update the 'data' instance with the updated data.
        }
        private void create_account_form_Load(object sender, EventArgs e)
        {
            this.ActiveControl = Surname_txet_box; //<----- FOCUS first text box after FORM LOAD.
        }

        private void button1_Click(object sender, EventArgs e)
        {

    //====================== This code is check SURNAME IS CORRECT===========================================

            bool SurnameNameIsCorrect = false;
            if (data.FormIsEmpty(Surname_txet_box.Text))//   <----- "FormIsEmpty" public method in data-object.
            {
                surname_error_picture.Visible = true;
                label1.Visible = true;
                SurnameNameIsCorrect = false;               
            }
            else
            {
                surname_error_picture.Visible = false;
                label1.Visible = false;
                surname_correct_picture.Visible = true;
                first_name_text_box.Focus();
                data.setSurname(Surname_txet_box.ToString() );
                SurnameNameIsCorrect=true;                   
            }

    //======================This code is check FIRST NAME IS CORRECT.===========================================

            bool FirstNameNameIsCorrect = false;
            if (data.FormIsEmpty(first_name_text_box.Text))
            {
                first_name_error_picture.Visible = true;
                label2.Visible = true;
                FirstNameNameIsCorrect = false;
            }
            else
            {
                first_name_error_picture.Visible = false;
                label2.Visible = false;
                first_name_correct_picture.Visible = true;
                second_name_text.Focus();
                data.setFirstName(first_name_text_box.ToString());
                FirstNameNameIsCorrect = true;
            }
    //======================This code is check SECOND-NAME IS CORRECT.===========================================
            bool SecondNameNameIsCorrect = false;     
            if (data.FormIsEmpty(second_name_text.Text))
            {
                second_name_error_picture.Visible = true;
                label3.Visible = true;
                SecondNameNameIsCorrect = false;   
            }
            else
            {
                second_name_error_picture.Visible = false;
                label3.Visible = false;
                second_name_correct_picture.Visible = true;
                data.setSecondName(second_name_text.ToString() );
                ID_number_text_box.Focus();
                SecondNameNameIsCorrect = true;                   
            }

    //======================This code is check ID NUMBER IS CORRECT.===========================================

            bool IDNumberIsCorrect = false;
            if (data.FormIsEmpty(ID_number_text_box.Text))
            {
                ID_number_error_picture.Visible = true;
                label4.Visible = true;
                ID_number_text_box.Focus();
                IDNumberIsCorrect = false;
            }
            else
            {
                if (data.IdNumberIsCorrect(ID_number_text_box.Text))
                {

                    ID_number_error_picture.Visible = false;
                    label4.Visible = false;
                    label7.Visible = false;
                    id_correct_picture.Visible = true;
                    IDNumberIsCorrect = true;
                }
                else
                {
                    ID_number_error_picture.Visible = true;
                    label7.Visible = true;
                    label4.Visible = false;
                    ID_number_text_box.Clear();
                    ID_number_text_box.Focus();
                    IDNumberIsCorrect = false;
                }
            }

            //======================This part is GET the USER INPUTED DATE.===========================================

            /*
              DateTime DateOfBirth = dateTimePicker1.Value;
              MessageBox.Show(DateOfBirth.ToString());
            */

            Boolean DateOfBirthIsCorrect = false;
            DateTime currentDate = DateTime.Now;
            DateTime DateOfBirth = dateTimePicker1.Value;

            // Define the minimum and maximum age ranges
            int minimumAge = 18; // Minimum age in years
            int maximumAge = 120; // Maximum age in years

            // Calculate the minimum and maximum birthdates based on the age range
            DateTime minimumBirthdate = currentDate.AddYears(-maximumAge);
            DateTime maximumBirthdate = currentDate.AddYears(-minimumAge);

            if (DateOfBirth < minimumBirthdate || DateOfBirth > maximumBirthdate)
            {
                birthday_error_picture.Visible = true;
                birthday_correct_picture.Visible = false;
                DateOfBirthIsCorrect = false;
                MessageBox.Show("Invalid birthdate. Please select a valid date within the age range.");
                /*  
                 *  You can optionally reset the value to a default date or take other actions.
                 *  For example :
                                dateTimePicker1.Value = DateTime.Now;
                */
            }
            else
            {
                birthday_error_picture.Visible=false;
                birthday_correct_picture.Visible = true;
                DateOfBirthIsCorrect=true;
                data.setDateOfBirth(DateOfBirth);



            }

            //======================This code is check GENDER IS CORRECT.===========================================

            if (male_radio_button.Checked || female_radio_button.Checked || other_radio_button.Checked)
            {

                if (male_radio_button.Checked)
                {
                    data.setGender("Male");
                }
                else if (female_radio_button.Checked)
                {
                    data.setGender("Female") ;
                }
                else if (other_radio_button.Checked)
                {
                    data.setGender("Other");
                }

                gender_correct_picture.Visible = true;
                gender_error_picture.Visible = false;
            }
            else
            {
                gender_error_picture.Visible = true;
                gender_correct_picture.Visible = false;
            }
            
            //=================================================================
            if (SurnameNameIsCorrect && FirstNameNameIsCorrect && SecondNameNameIsCorrect && IDNumberIsCorrect && DateOfBirthIsCorrect ) 
            {
                /*
                  *MessageBox.Show(data.Gender);
                  *Create an instance of the create_account_form_02                
                */
                
                this.Hide();//<------  Hide the create_account_form

                create_account_form_02 create_account_form_02 = new create_account_form_02(data);
                create_account_form_02.Show();// <----------  Show the create_account_form_02
            }
        }
        private void Surname_txet_box_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bool SurnameNameIsCorrect = false;
                while (SurnameNameIsCorrect!= true)
                {
                    if(data.FormIsEmpty(Surname_txet_box.Text))
                    {
                        surname_error_picture.Visible = true;
                        label1.Visible = true;
                        SurnameNameIsCorrect = false;
                        break;
                    }
                    else
                    {
                        surname_error_picture.Visible = false;
                        label1.Visible = false;
                        surname_correct_picture.Visible = true;
                        data.setSecondName(Surname_txet_box.Text);
                        first_name_text_box.Focus();
                        break;
                    }
                }
            }
        }
        private void first_name_text_box_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bool FirstNameNameIsCorrect = false;
                while (FirstNameNameIsCorrect != true)
                {
                    if (data.FormIsEmpty(first_name_text_box.Text))
                    {
                        first_name_error_picture.Visible = true;
                        label2.Visible = true;
                        FirstNameNameIsCorrect = false;
                        break;
                    }
                    else
                    {
                        first_name_error_picture.Visible = false;
                        label2.Visible = false;
                        first_name_correct_picture.Visible = true;
                        data.setFirstName(first_name_text_box.Text);
                        second_name_text.Focus();
                        break;
                    }
                }
            }
        }
        private void second_name_text_box_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bool SecondNameNameIsCorrect = false;
                while (SecondNameNameIsCorrect != true)
                {
                    if (data.FormIsEmpty(second_name_text.Text))
                    {
                        second_name_error_picture.Visible = true;
                        label3.Visible = true;
                        SecondNameNameIsCorrect = false;
                        break;
                    }
                    else
                    {
                        second_name_error_picture.Visible = false;
                        label3.Visible = false;
                        second_name_correct_picture.Visible = true;
                        data.setSecondName(second_name_text.Text);
                        ID_number_text_box.Focus();
                        break;
                    }
                }
            }
        }

        private void ID_number_text_box_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bool IDNumberIsCorrect = false;
                while (IDNumberIsCorrect != true)
                {

                    if (data.FormIsEmpty(ID_number_text_box.Text))
                    {
                        ID_number_error_picture.Visible = true;
                        label4.Visible = true;
                        ID_number_text_box.Focus();
                        IDNumberIsCorrect = false;
                        break;

                    }
                    else 
                    {
                        if (data.IdNumberIsCorrect(ID_number_text_box.Text)) 
                        {

                            ID_number_error_picture.Visible = false;
                            label4.Visible = false;
                            label7.Visible = false;
                            id_correct_picture.Visible = true;
                            data.setIDNumber(second_name_text.Text);
                            IDNumberIsCorrect = true;
                            break;
                        }
                        else
                        {
                            ID_number_error_picture.Visible = true;
                            label7.Visible = true;
                            label4.Visible = false;
                            ID_number_text_box.Clear();
                            ID_number_text_box.Focus();
                            IDNumberIsCorrect = false;
                            break;
                        } 
                    }
                            
                }
            }
        }

        private void Surname_txet_box_TextChanged(object sender, EventArgs e)
        {
         
                bool SurnameNameIsCorrect = false;
                while (SurnameNameIsCorrect != true)
                {
                    if (data.FormIsEmpty(Surname_txet_box.Text))
                    {
                        surname_error_picture.Visible = true;
                        label1.Visible = true;
                        SurnameNameIsCorrect = false;
                        break;
                    }
                    else
                    {
                        surname_error_picture.Visible = false;
                        label1.Visible = false;
                        surname_correct_picture.Visible = true;
                        data.setSurname(second_name_text.Text);
                        //first_name_text_box.Focus();
                        break;
                    }
                }
            
        }

        private void Surname_txet_box_Click(object sender, EventArgs e)
        {
            /*Surname_txet_box.Text = string.Empty;
            Surname_txet_box.ForeColor = Color.Black;*/
        }

        private void ID_number_text_box_Click(object sender, EventArgs e)
        {
            /*ID_number_text_box.Text = string.Empty;
            ID_number_text_box.ForeColor = Color.Black;*/
        }

        private void first_name_text_box_Click(object sender, EventArgs e)
        {
           /* first_name_text_box.Text = string.Empty;
            first_name_text_box.ForeColor = Color.Black;*/
        }

        private void second_name_text_box_Click(object sender, EventArgs e)
        {
            /*second_name_text_box.Text = string.Empty;
            second_name_text_box.ForeColor = Color.Black;*/
        }
        private void ID_number_text_box_TextChanged_1(object sender, EventArgs e)
        {
            bool IDNumberIsCorrect = false;
            while (IDNumberIsCorrect != true)
            {

                if (data.FormIsEmpty(ID_number_text_box.Text))
                {
                    ID_number_error_picture.Visible = true;
                    label4.Visible = true;
                    IDNumberIsCorrect = false;
                    break;

                }
                else
                {
                    if (data.IdNumberIsCorrect(ID_number_text_box.Text))
                    {
                        ID_number_error_picture.Visible = false;
                        label4.Visible = false;
                        label7.Visible = false;
                        id_correct_picture.Visible = true;
                        data.setIDNumber(ID_number_text_box.ToString());
                        IDNumberIsCorrect = true;
                        break;
                    }
                    else 
                    {
                        ID_number_error_picture.Visible = true;
                        label7.Visible = true;
                        label4.Visible = false;
                        //ID_number_text_box.Clear();
                        ID_number_text_box.Focus();
                        IDNumberIsCorrect = false;
                        break;
                    }
                }
            }
        }

        private void second_name_text_TextChanged(object sender, EventArgs e)
        {
            bool SecondNameNameIsCorrect = false;
            while (SecondNameNameIsCorrect != true)
            {
                if (data.FormIsEmpty(second_name_text.Text))
                {
                    second_name_error_picture.Visible = true;
                    label3.Visible = true;
                    SecondNameNameIsCorrect = false;
                    break;
                }
                else
                {
                    second_name_error_picture.Visible = false;
                    label3.Visible = false;
                    second_name_correct_picture.Visible = true;
                    data.setSecondName(second_name_text.Text);
                    //ID_number_text_box.Focus();
                    break;
                }
            }
        }
        private void first_name_text_box_TextChanged(object sender, EventArgs e)
        {
            bool FirstNameNameIsCorrect = false;
            while (FirstNameNameIsCorrect != true)
            {
                if (data.FormIsEmpty(first_name_text_box.Text))
                {
                    first_name_error_picture.Visible = true;
                    label2.Visible = true;
                    FirstNameNameIsCorrect = false;
                    break;
                }
                else
                {
                    first_name_error_picture.Visible = false;
                    label2.Visible = false;
                    first_name_correct_picture.Visible = true;
                    data.setFirstName(first_name_text_box.Text);
                    //second_name_text_box.Focus();
                    break;
                }
            }
        }
    }
}
