using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rental_status
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Parent = button1; // label의 부모를 button1으로 설정
            label2.BackColor = Color.Transparent; // 배경 투명 처리
            label2.Location = new Point(
                label2.Left - button1.Left, // 원래 위치 보정
                label2.Top - button1.Top
            );
            label3.Parent = button2; // label의 부모를 button1으로 설정
            label3.BackColor = Color.Transparent; // 배경 투명 처리
            label3.Location = new Point(
                label3.Left - button2.Left, // 원래 위치 보정
                label3.Top - button2.Top
            );
            label4.Parent = button3; // label의 부모를 button1으로 설정
            label4.BackColor = Color.Transparent; // 배경 투명 처리
            label4.Location = new Point(
                label4.Left - button3.Left, // 원래 위치 보정
                label4.Top - button3.Top
            );
            label5.Parent = button4; // label의 부모를 button1으로 설정
            label5.BackColor = Color.Transparent; // 배경 투명 처리
            label5.Location = new Point(
                label5.Left - button4.Left, // 원래 위치 보정
                label5.Top - button4.Top
            );
            label6.Parent = button5; // label의 부모를 button1으로 설정
            label6.BackColor = Color.Transparent; // 배경 투명 처리
            label6.Location = new Point(
                label6.Left - button5.Left, // 원래 위치 보정
                label6.Top - button5.Top
            );
            label7.Parent = button6; // label의 부모를 button1으로 설정
            label7.BackColor = Color.Transparent; // 배경 투명 처리
            label7.Location = new Point(
                label7.Left - button6.Left, // 원래 위치 보정
                label7.Top - button6.Top
            );
            label8.Parent = button1; // label의 부모를 button1으로 설정
            label8.BackColor = Color.Transparent; // 배경 투명 처리
            label8.Location = new Point(
                label8.Left - button1.Left, // 원래 위치 보정
                label8.Top - button1.Top
            );
            label9.Parent = button2; // label의 부모를 button1으로 설정
            label9.BackColor = Color.Transparent; // 배경 투명 처리
            label9.Location = new Point(
                label9.Left - button2.Left, // 원래 위치 보정
                label9.Top - button2.Top
            );
            label10.Parent = button3; // label의 부모를 button1으로 설정
            label10.BackColor = Color.Transparent; // 배경 투명 처리
            label10.Location = new Point(
                label10.Left - button3.Left, // 원래 위치 보정
                label10.Top - button3.Top
            );
            label11.Parent = button4; // label의 부모를 button1으로 설정
            label11.BackColor = Color.Transparent; // 배경 투명 처리
            label11.Location = new Point(
                label11.Left - button4.Left, // 원래 위치 보정
                label11.Top - button4.Top
            );
            label12.Parent = button5; // label의 부모를 button1으로 설정
            label12.BackColor = Color.Transparent; // 배경 투명 처리
            label12.Location = new Point(
                label12.Left - button5.Left, // 원래 위치 보정
                label12.Top - button5.Top
            );
            label13.Parent = button6; // label의 부모를 button1으로 설정
            label13.BackColor = Color.Transparent; // 배경 투명 처리
            label13.Location = new Point(
                label13.Left - button6.Left, // 원래 위치 보정
                label13.Top - button6.Top
            );
            label14.Parent = button1; // label의 부모를 button1으로 설정
            label14.BackColor = Color.Transparent; // 배경 투명 처리
            label14.Location = new Point(
                label14.Left - button1.Left, // 원래 위치 보정
                label14.Top - button1.Top
            );
            label15.Parent = button2; // label의 부모를 button1으로 설정
            label15.BackColor = Color.Transparent; // 배경 투명 처리
            label15.Location = new Point(
                label15.Left - button2.Left, // 원래 위치 보정
                label15.Top - button2.Top
            );
            label16.Parent = button3; // label의 부모를 button1으로 설정
            label16.BackColor = Color.Transparent; // 배경 투명 처리
            label16.Location = new Point(
                label16.Left - button3.Left, // 원래 위치 보정
                label16.Top - button3.Top
            );
            label17.Parent = button4; // label의 부모를 button1으로 설정
            label17.BackColor = Color.Transparent; // 배경 투명 처리
            label17.Location = new Point(
                label17.Left - button4.Left, // 원래 위치 보정
                label17.Top - button4.Top
            );
            label18.Parent = button5; // label의 부모를 button1으로 설정
            label18.BackColor = Color.Transparent; // 배경 투명 처리
            label18.Location = new Point(
                label18.Left - button5.Left, // 원래 위치 보정
                label18.Top - button5.Top
            );
            label19.Parent = button6; // label의 부모를 button1으로 설정
            label19.BackColor = Color.Transparent; // 배경 투명 처리
            label19.Location = new Point(
                label19.Left - button6.Left, // 원래 위치 보정
                label19.Top - button6.Top
            );

            pictureBox2.Parent = button1; // pictureBox2의 부모를 button1으로 설정
            pictureBox2.BackColor = Color.Transparent; // 배경 투명 처리
            pictureBox2.Location = new Point(
                pictureBox2.Left - button1.Left, // 원래 위치 보정
                pictureBox2.Top - button1.Top    // 원래 위치 보정
            );
            pictureBox3.Parent = button2; // pictureBox2의 부모를 button1으로 설정
            pictureBox3.BackColor = Color.Transparent; // 배경 투명 처리
            pictureBox3.Location = new Point(
                pictureBox3.Left - button2.Left, // 원래 위치 보정
                pictureBox3.Top - button2.Top    // 원래 위치 보정
            );
            pictureBox4.Parent = button3; // pictureBox2의 부모를 button1으로 설정
            pictureBox4.BackColor = Color.Transparent; // 배경 투명 처리
            pictureBox4.Location = new Point(
                pictureBox4.Left - button3.Left, // 원래 위치 보정
                pictureBox4.Top - button3.Top    // 원래 위치 보정
            );
            pictureBox5.Parent = button4; // pictureBox2의 부모를 button1으로 설정
            pictureBox5.BackColor = Color.Transparent; // 배경 투명 처리
            pictureBox5.Location = new Point(
                pictureBox5.Left - button4.Left, // 원래 위치 보정
                pictureBox5.Top - button4.Top    // 원래 위치 보정
            );
            pictureBox6.Parent = button5; // pictureBox2의 부모를 button1으로 설정
            pictureBox6.BackColor = Color.Transparent; // 배경 투명 처리
            pictureBox6.Location = new Point(
                pictureBox6.Left - button5.Left, // 원래 위치 보정
                pictureBox6.Top - button5.Top    // 원래 위치 보정
            );
            pictureBox7.Parent = button6; // pictureBox2의 부모를 button1으로 설정
            pictureBox7.BackColor = Color.Transparent; // 배경 투명 처리
            pictureBox7.Location = new Point(
                pictureBox7.Left - button6.Left, // 원래 위치 보정
                pictureBox7.Top - button6.Top    // 원래 위치 보정
            );

            DateTime today = DateTime.Now;

            DateTime threeDaysLater = today.AddDays(3);

            label14.Text = $"{today.ToShortDateString()} ~ {threeDaysLater.ToShortDateString()}";
            label15.Text = $"{today.ToShortDateString()} ~ {threeDaysLater.ToShortDateString()}";
            label16.Text = $"{today.ToShortDateString()} ~ {threeDaysLater.ToShortDateString()}";
            label17.Text = $"{today.ToShortDateString()} ~ {threeDaysLater.ToShortDateString()}";
            label18.Text = $"{today.ToShortDateString()} ~ {threeDaysLater.ToShortDateString()}";
            label19.Text = $"{today.ToShortDateString()} ~ {threeDaysLater.ToShortDateString()}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
