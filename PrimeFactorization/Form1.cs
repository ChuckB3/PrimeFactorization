using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PrimeFactorization
{
    public partial class PrimeFactorization : Form
    {
        public long num;
        public int n;        
        public List<String> primeFacts = new List<String>();
        public PrimeFactorization()
        {
            InitializeComponent();
        }
        
       
        private void primeFact(long n)
        {
            for( int i = 2; i <= n; i++)
            {
                while(n%i==0)
                {                    
                    n /= i;
                    primeFacts.Add(i.ToString());
                }                               
            }         
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            primeFacts.Clear();
            num = long.Parse(numBox.Text);
            primeFact(num);
            var results = String.Join(", ", primeFacts.ToArray());
            MessageBox.Show(results, "Results");

        }
    }
}
