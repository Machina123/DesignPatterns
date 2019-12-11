namespace State
{
    public class File
    {
        private FileState _state;
        public File()
        {
            _state = FileClosed.GetInstance();
            _state.SetContext(this);
        }

        public void Open()
        {
            _state.Open();
        }

        public void Close()
        {
            _state.Close();
        }

        public void Read()
        {
            _state.Read();
        }

        public void Write()
        {
            _state.Write();
        }

        public void ChangeState(FileState newState)
        {
            _state = newState;
            _state.SetContext(this);
        }
    }
}