/*
 * Created by SharpDevelop.
 * User: jinac
 * Date: 18/10/2022
 * Time: 22:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace jogoDados
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		//função resetar ↓
		void resetar()
		{
			pictureBox1.Load("interrogacao.png");
			pictureBox2.Load("interrogacao.png");
			pictureBox3.Load("interrogacao.png");
			pictureBox4.Load("interrogacao.png");
			pictureBox5.Load("interrogacao.png");
			pictureBox6.Load("interrogacao.png");
			pictureBox7.Load("interrogacao.png");
			pictureBox4.Visible = false;
			pictureBox5.Visible = false;
			label5.Text = ("0");
			label3.Text = ("0");
			button1.Enabled = true;
			pictureBox3.Enabled = false;
			pictureBox4.Enabled = false;
			pictureBox5.Enabled = false;
		}
		
		Random rnd = new Random();
		int n6, n7; //dados do computador
		  
		//Iniciar ↓
		void Button1Click(object sender, EventArgs e)
		{
			button1.Enabled = false;
			pictureBox3.Enabled = true;
			int n1 = rnd.Next(1,7);
			pictureBox1.Load("dado" + n1 + ".png");
			int n2 = rnd.Next(1,7);
			pictureBox2.Load("dado" + n2 + ".png");
			int soma = n1 + n2;
			label3.Text = soma.ToString();
			
			//dados do computador ↓
			n6 = rnd.Next(1,7);
			n7 = rnd.Next(1,7);
		}
		//Novo número 3     
		void PictureBox3Click(object sender, EventArgs e)
		{ 
			
			pictureBox3.Enabled = false;
			pictureBox4.Enabled = true;
			int n3 = rnd.Next(1,7);
			pictureBox3.Load("dado" + n3 + ".png");
			int soma = int.Parse(label3.Text) + n3;
			label3.Text = soma.ToString();
			if (soma > 13)
			{
				MessageBox.Show("Você estourou os 13 pontos, DERROTA !");
				resetar();
			}
			else
			{
				pictureBox4.Visible = true;
				
			}
			
		}
		
		//Novo numero 4
		void PictureBox4Click(object sender, EventArgs e)
		{
	        pictureBox4.Enabled = false;
	        pictureBox5.Enabled = true;
			int n4 = rnd.Next(1,7);
			pictureBox4.Load("dado" + n4 + ".png");
			int soma = int.Parse(label3.Text) + n4;
			label3.Text = soma.ToString();
			if (soma > 13)
			{
				MessageBox.Show("Você estourou os 13 pontos, DERROTA !");
				resetar();
			}
			else
			{
				pictureBox5.Visible = true;
				
			}
		}
		
		//Novo numero 5
		void PictureBox5Click(object sender, EventArgs e)
		{
			
			 pictureBox5.Enabled = false;
			int n5 = rnd.Next(1,7);
			pictureBox5.Load("dado" + n5 + ".png");
			int soma = int.Parse(label3.Text) + n5;
			label3.Text = soma.ToString();
			if (soma > 13)
			{
				MessageBox.Show("Você estourou os 13 pontos, DERROTA !");
				resetar();
			}
			
	
		}
		
		//Botão finalizar ↓
		void Button2Click(object sender, EventArgs e)
		{   
			//Dados Computador ↓
			n6 = rnd.Next(1,7);
			pictureBox6.Load("dado" + n6 + ".png");
			n7 = rnd.Next(1,7);
			pictureBox7.Load("dado" + n7 + ".png");
			int somaC = n6 + n7;
			label5.Text = somaC.ToString();
			
			//if para determinar o resultado 
			if ( int.Parse(label3.Text) <= int.Parse(label5.Text) )
			{
				MessageBox.Show("Você perdeu !");
				resetar();
			}
			else
			{
				MessageBox.Show("Você Venceu !");
				resetar();
			}
			
		}
		
		
		
		
	}
	
}
