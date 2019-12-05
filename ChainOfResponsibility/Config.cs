namespace ChainOfResponsibility
{
    public class Config
    {
        public static Handler SetChainOfResponsibility()
        {
            return new Button(new Dialog(new Application(null)));
        }
    }
}