namespace Andrea_OOP_act
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public double CalculateArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        private double CalculateArea(double length, double height, double width)
        {
            return length * height * width;
        }

        private double ComputeTriangle(double baseValue, double height)
        {
            return (baseValue * height) / 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
     
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double radius = Convert.ToDouble(textBox1.Text);
            double area = CalculateArea(radius);

            textBox6.Text = area.ToString();
            listBox1.Items.Add(area);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            double length = Convert.ToDouble(textBox5.Text);
            double height = Convert.ToDouble(textBox3.Text);
            double width = Convert.ToDouble(textBox4.Text);

            double volume = CalculateArea(length, height, width);

            textBox6.Text = volume.ToString();
            listBox1.Items.Add(volume);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            double baseValue = Convert.ToDouble(textBox2.Text);
            double height = Convert.ToDouble(textBox3.Text);

            double area = ComputeTriangle(baseValue, height);

            textBox6.Text = area.ToString();
            listBox1.Items.Add(area);
        }
    }
}
