using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp2
{
    public partial class Form2 : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\HP\\Documents\\Logindatabase.mdf;Integrated Security=True;Connect Timeout=30");
        public Form2()
        {
            InitializeComponent();
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (phone.Text != "" && mail.Text != "" && pincode.Text != "" && city.Text != "" && state.Text != "" && area.Text != "" && house.Text != "" && contactname.Text != "" && contactphone.Text != "")
                {
                    string insertQuery = "INSERT INTO logindata (phone, mail, pincode, city, state, area, house, contactname, contactphone) VALUES (@phone, @mail, @pincode, @city, @state, @area, @house, @contactname, @contactphone";
                    using (connection)
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(insertQuery, connection))
                        {
                            // Replace @patientname and @other_value with actual parameter names
                            command.Parameters.AddWithValue("@phone", phone.Text);
                            command.Parameters.AddWithValue("@mail",mail.Text );
                            command.Parameters.AddWithValue("@pincode", pincode.Text);
                            command.Parameters.AddWithValue("@city", city.Text);
                            command.Parameters.AddWithValue("@state", state.Text);
                            command.Parameters.AddWithValue("@area", area.Text);
                            command.Parameters.AddWithValue("@house", house.Text);
                            command.Parameters.AddWithValue("@contactname", contactname.Text);
                            command.Parameters.AddWithValue("@contactphone", contactphone.Text);
                            command.ExecuteNonQuery();
                            connection.Close();
                            MessageBox.Show("Details Saved Successfully!");
                            phone.Text = "";
                            mail.Text = "";
                            pincode.Text = "";
                            city.Text = "";
                            state.Text = "";
                            area.Text = "";
                            house.Text = "";
                            contactname.Text = "";
                            contactphone.Text = "";
                        }
                    }
                }

                else
                {
                    MessageBox.Show("Fill all the boxes");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
