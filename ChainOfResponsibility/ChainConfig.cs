namespace ChainOfResponsibility
{
    public class ChainConfig
    {
        public static void SetSuccessor(Handler current, Handler next)
        {
            current.SetSuccessor(next);
        }
    }
}