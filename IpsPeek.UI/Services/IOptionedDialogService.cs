namespace IpsPeek.UI.Services
{
    public interface IOptionedDialogService<in T>
    {
        bool ShowDialog(T options);
    }
}