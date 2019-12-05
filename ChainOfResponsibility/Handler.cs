namespace ChainOfResponsibility
{
    public abstract class Handler
    {
        protected Handler _successor;

        protected Handler()
        {
            _successor = null;
        }

        protected Handler(Handler successor)
        {
            _successor = successor;
        }

        public abstract void HandleHelp();
        public abstract void ShowHelp();

        public void SetSuccessor(Handler newSuccessor)
        {
            _successor = newSuccessor;
        }
    }
}