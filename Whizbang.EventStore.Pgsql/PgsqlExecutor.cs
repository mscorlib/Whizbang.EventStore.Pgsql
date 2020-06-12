using Npgsql;
using Whizbang.Core.Data.FluentSqlClient;

namespace Whizbang.EventStore.Pgsql
{
    public class PgsqlExecutor : Executor
    {
        public PgsqlExecutor(string connectionString)
            : base(
                () => new NpgsqlConnection(connectionString),
                () => new NpgsqlCommand(),
                (cmd, paramName, value) => ((NpgsqlCommand) cmd).Parameters.AddWithValue(paramName, value))
        {
        }
    }
}