using System.Windows.Forms;

namespace UnderstandingInterfaces
{
    public class WindowOutput : IOutputBehavior
    {
        public void MakeOutput(string text)
        {
            MessageBox.Show(text);
        }
    }
}