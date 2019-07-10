using System;

namespace UnderstandingEvents
{
    public class MyGui
    {
        public MyButton Button { get; set; }

        public MyGui()
        {
            Button = new MyButton();
            Button.Click += Button_Click;
        }

        private void Button_Click(string input)
        {
            Console.WriteLine(input);
        }
    }
}   