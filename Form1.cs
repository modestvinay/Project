using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        private Random random = new Random();
        private SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\HP\\Documents\\Logindatabase.mdf;Integrated Security=True;Connect Timeout=30");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize and enumerate available video devices (webcams)
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (videoDevices.Count > 0)
            {
                videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
                videoSource.NewFrame += new NewFrameEventHandler(videoSource_NewFrame);
            }
            else
            {
                MessageBox.Show("No webcam found.");
                return;
            }
        }

        // Function to generate a unique 6-digit numerical password
        private string GeneratePassword()
        {
            // Generate a random 6-digit password
            string password = random.Next(100000, 999999).ToString();

            // Check if the generated password is already in use in the database
            while (IsPasswordInUse(password))
            {
                password = random.Next(100000, 999999).ToString();
            }

            return password;
        }

        // Function to check if a password is already in use in the database
        private bool IsPasswordInUse(string password)
        {
            using (connection)
            {
                connection.Open();

                // Check if the password exists in the database table
                string query = "SELECT COUNT(*) FROM logindata WHERE umrid = @umrid";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@umrid", password);
                    int count = Convert.ToInt32(command.ExecuteScalar());

                    // If count is greater than 0, the password is already in use
                    return count > 0;
                }
            }
        }

        private void generateumr_Click(object sender, EventArgs e)
        {
            // Generate a new 6-digit numerical password
            string newPassword = GeneratePassword();

            // Set the generated password in the "umr" TextBox
            umrid.Text = newPassword;
        }

        private void CalculateAge(DateTime dob)
        {
            DateTime today = DateTime.Today;
            int calage = today.Year - dob.Year;

            // Subtract one year if the birthday has not occurred this year
            if (dob.Date > today.AddYears(-calage))
            {
                calage--;
            }

            age.Text = calage.ToString();
        }

        private void dob_ValueChanged(object sender, EventArgs e)
        {
            // Calculate and display age when the DOB is changed
            CalculateAge(dob.Value);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Stop and release the webcam when the form is closed
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
                videoSource = null;
            }
        }

        private void videoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            photo.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void start_Click(object sender, EventArgs e)
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (videoDevices.Count > 0)
            {
                videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
                videoSource.NewFrame += new NewFrameEventHandler(videoSource_NewFrame);
                videoSource.Start();
            }
        }

        private Bitmap capturedImage;

        private void capture_Click(object sender, EventArgs e)
        {
            capturedImage = (Bitmap)photo.Image.Clone();
            photo.Image = capturedImage;
        }

        // Function to save the captured image and other information to the database
        private void SaveDataToDatabase()
        {
            try
            {
                if (capturedImage != null)
                {
                    using (connection)
                    {
                        connection.Open();

                        // Your SQL query to insert data, including the image
                        string insertQuery = "INSERT INTO logindata (patientname, umrid, dob, age, gender, referaldoctor, currentdate, currenttime, aadhar, religion, profession, photo) VALUES (@patientname, @umrid, @dob, @age, @gender, @referaldoctor, @currentdate, @currenttime, @aadhar, @religion, @profession, @photo)";

                        using (SqlCommand command = new SqlCommand(insertQuery, connection))
                        {
                            command.Parameters.AddWithValue("@patientname", patientname.Text);
                            command.Parameters.AddWithValue("@umrid", umrid.Text);
                            command.Parameters.AddWithValue("@dob", dob.Value);
                            command.Parameters.AddWithValue("@age", age.Text);
                            command.Parameters.AddWithValue("@gender", gender.Text);
                            command.Parameters.AddWithValue("@referaldoctor", referaldoctor.Text);
                            command.Parameters.AddWithValue("@currentdate", currentdate.Text);
                            command.Parameters.AddWithValue("@currenttime", currenttime.Text);
                            command.Parameters.Add("@photo", SqlDbType.VarBinary).Value = ImageToByteArray(capturedImage);
                            command.Parameters.AddWithValue("@aadhar", aadhar.Text);
                            command.Parameters.AddWithValue("@religion", religion.Text);
                            command.Parameters.AddWithValue("@profession", profession.Text);

                            command.ExecuteNonQuery();
                        }

                        MessageBox.Show("Details and Image Saved Successfully!");
                        ClearFormFields();
                    }
                }
                else
                {
                    MessageBox.Show("Capture an image before saving.");
                }

                var nextform = new Form2();
                nextform.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ClearFormFields()
        {
            patientname.Text = "";
            umrid.Text = "";
            dob.Text = "";
            age.Text = "";
            gender.Text = "";
            referaldoctor.Text = "";
            currentdate.Text = "";
            currenttime.Text = "";
            aadhar.Text = "";
            religion.Text = "";
            profession.Text = "";
            photo.Image = null;
        }

        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, ImageFormat.Jpeg); // Use the appropriate image format
                return ms.ToArray();
            }
        }

        private void nextbutton_Click(object sender, EventArgs e)
        {
            SaveDataToDatabase();

        }
    }
}
