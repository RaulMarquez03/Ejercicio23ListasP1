using System.Configuration;

namespace Ejercicio23ListasP1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (buttonListBox.Checked)
            {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Clear();

                int valor1 = int.Parse(labelCountListBox.Text);
                int result = valor1 + 1;
                labelCountListBox.Text = result.ToString();
            }
            if(buttonComboBox.Checked ) 
            {
                comboBox1.Items.Add(textBox1.Text);
                textBox1.Clear();

                int valor1 = int.Parse(labelCountComboBox.Text);
                int result = valor1 + 1;
                labelCountComboBox.Text = result.ToString();
            }
            if(buttonCheckedListBox.Checked) 
            {
                checkedListBox1.Items.Add(textBox1.Text);
                textBox1.Clear();
                
                int valor1 = int.Parse(labelCountCheckedListBox.Text);
                int result = valor1 + 1;
                labelCountCheckedListBox.Text = result.ToString();
            }
        }
       
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (buttonListBox.Checked)
            {
                if (listBox1.Items.Contains(textBox1.Text))
                {
                    listBox1.Items.Remove(textBox1.Text);
                    

                    int valor1 = int.Parse(labelCountListBox.Text);
                    int result = valor1 - 1;
                    labelCountListBox.Text = result.ToString();
                }
                textBox1.Clear();
            }

            if (buttonComboBox.Checked)
            {
                if (comboBox1.Items.Contains(textBox1.Text))
                {
                    comboBox1.Items.Remove(textBox1.Text);
                    

                    int valor1 = int.Parse(labelCountComboBox.Text);
                    int result = valor1 - 1;
                    labelCountComboBox.Text = result.ToString();
                }
                textBox1.Clear();
            }
            if (buttonCheckedListBox.Checked)
            {
                if (checkedListBox1.Items.Contains(textBox1.Text))
                {
                    checkedListBox1.Items.Remove(textBox1.Text);
                    

                    int valor1 = int.Parse(labelCountCheckedListBox.Text);
                    int result = valor1 - 1;
                    labelCountCheckedListBox.Text = result.ToString();
                }
                textBox1.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
                if (listBox1.SelectedItem != null)
                {
                    string selectedItem = listBox1.SelectedItem.ToString();
                    textBox2.Text = selectedItem;
                }
            if (comboBox1.SelectedItem != null)
            {
                string selectedItem = comboBox1.SelectedItem.ToString();
                textBox2.Text = selectedItem;
            }
            listView1.Items.Clear();

           
         
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    if (checkedListBox1.GetItemChecked(i))
                    {
                        string item = checkedListBox1.Items[i].ToString().Trim();  // Eliminar espacios en blanco
                        listView1.Items.Add(item);
                    }
                }
            

        }
    }
}