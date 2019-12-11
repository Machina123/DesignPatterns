namespace Mediator
{
    public class CheckboxComponent : Component
    {
        public bool Checked { get; set; }
        public string Label { get; }
        public string Action { get; }

        public override string ToString()
        {
            return $"[{(Checked ? "X" : " ")}] {Label}";
        }

        public CheckboxComponent(string action, string label) : base()
        {
            Label = label;
            Checked = false;
            Action = action;
        }

        public void Check()
        {
            _mediator.Notify(Action);
        }
    }
}