namespace UnitOfWorkClass.Link
{
    // Источник данных об обновлении состояния
    public interface ILinkSource
    {
        object GetState();
    }
}
