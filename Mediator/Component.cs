namespace Mediator
{
    public abstract class Component
    {
        protected Mediator _mediator;
        
        public Component(Mediator mediator = null)
        {
            _mediator = mediator;
        }

        public void SetMediator(Mediator mediator)
        {
            _mediator = mediator;
        }
    }
}