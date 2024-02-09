using Raven.Client.Documents;

namespace ControleAlunos.Infraestrutura
{
    public static class DocumentStoreHolder
    {
        private static readonly Lazy<IDocumentStore> LazyStore =
            new(() =>
            {
                DocumentStore store = new()
                {
                    Urls = new[] { "http://127.0.0.1:8080/" },
                    Database = "Banco-Teste"
                };

                store.Initialize();

                return store;
            });

        public static IDocumentStore Store => LazyStore.Value;
    }
}
