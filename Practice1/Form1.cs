namespace Practice1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PersonName fullname = new PersonName();
            fullname.Name = txtName.Text;
            fullname.LastName = txtLastName.Text;
            fullname.MotherLastName = txtMotherLastName.Text;


            Student student1 = new Student();
            student1.Fullname = fullname;
            student1.BirthDate = dtBirthDate.Value;
            student1.ID = txtId.Text;
            student1.Carrer = txtCarrer.Text;
            student1.Average = nudAverage.Value;

            lblInfoStudent.Text = student1.ToString();
        }
    }
}