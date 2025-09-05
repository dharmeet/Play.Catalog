namespace Play.Catalog.Contracts
{
    public record CatalogItemCreated(Guid ItemId, string Name, string description);

    public record CatalogItemUpdated(Guid ItemId, string Name, string description);

    public record CatalogItemDeleted(Guid ItemId);
}