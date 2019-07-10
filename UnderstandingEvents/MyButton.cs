namespace UnderstandingEvents
{
    public class MyButton
    {
        // declare the delegate type
        // equals public Action<string> MessageHandler
        public delegate void MessageHandler(string input);

        public event MessageHandler Click;

        public void GenerateEvent()
        {
            if (Click != null)
            {
                Click("Message from MyButton: Im Clicked");
            }
        }
    }
}   