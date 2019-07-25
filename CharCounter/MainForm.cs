//Hallo Sören :)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CharCounter
{
    public partial class CharCounter : Form
    {
        public CharCounter()
        {
            InitializeComponent();
        }

        private void CharCounter_Load(object sender, EventArgs e)
        {

        }

        private void Button_count_Click(object sender, EventArgs e)
        {
            String input = input_text_box.Text;
            char[] chars = input.ToCharArray();
            Dictionary<char, int> charMap = new Dictionary<char, int>();
            int value;
            

            for (int i = 0; i < chars.Length; i++)
            {
                if (charMap.TryGetValue(chars[i], out value))
                {
                    charMap[chars[i]] = charMap[chars[i]]+1;
                }
                else
                {
                    charMap.Add(chars[i], 1);
                }
            }

            var charList = charMap.ToList();
            charList.Sort((x, y) => y.Value.CompareTo(x.Value));

            output_text_box.Text = string.Join("\n", charList.Select(x => x.Key + "=" + x.Value));
        }
    }
}
