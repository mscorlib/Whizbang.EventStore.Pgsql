using Whizbang.Core.Data.FluentSqlClient;

namespace Whizbang.EventStore.Pgsql
{
    public static class Pgsql
    {
        public static IExecutor With(string connectionString)
        {
            return new PgsqlExecutor(connectionString);
        }
    }
}