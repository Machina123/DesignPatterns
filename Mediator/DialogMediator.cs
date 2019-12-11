namespace Mediator
{
    public class DialogMediator : Mediator
    {
        private CheckboxComponent _check1, _check2, _check3;

        public DialogMediator(CheckboxComponent check1, CheckboxComponent check2, CheckboxComponent check3)
        {
            _check1 = check1;
            _check2 = check2;
            _check3 = check3;
        }

        public void Notify(string action)
        {
            switch (action)
            {
                case "1":
                    if (!_check1.Checked) _check1.Checked = true;
                    else _check1.Checked = _check2.Checked = _check3.Checked = false;
                    return;
                
                case "2":
                    if (!_check2.Checked) _check1.Checked = _check2.Checked = true;
                    else _check2.Checked = _check3.Checked = false;
                    return;
                
                case "3":
                    if (!_check3.Checked) _check1.Checked = _check2.Checked = _check3.Checked = true;
                    else _check3.Checked = false;
                    return;
            }
        }
    }
}