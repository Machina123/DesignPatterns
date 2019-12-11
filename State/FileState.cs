namespace State
{
    public interface FileState
    {
        void Open();
        void Close();
        void Read();
        void Write();
        void SetContext(File ctx);
    }
}