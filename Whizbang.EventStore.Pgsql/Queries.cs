namespace Whizbang.EventStore.Pgsql
{
    public sealed class Queries
    {
        public const string InsertEventSql = @"
INSERT INTO `Events`
           (`SourceId`
           ,`Version`
           ,`Timestamp`
           ,`Type`
           ,`Data`)
     VALUES
           (@SourceId
           ,@Version
           ,@Timestamp
           ,@Type
           ,@Data)";

        public const string GetEventsSql = @"
SELECT `SourceId`
      ,`Version`
      ,`Timestamp`
      ,`Type`
      ,`Data`
  FROM `Events`
  WHERE `SourceId` = @SourceId 
  AND `Version` > @SkipVersion 
";

        public const string InsertSnapshotSql = @"
INSERT INTO `Snapshots`
           (`SourceId`
           ,`Version`
           ,`Timestamp`
           ,`Type`
           ,`Data`)
     VALUES
           (@SourceId
           ,@Version
           ,@Timestamp
           ,@Type
           ,@Data)";

        public const string GetSnapshotSql = @"
SELECT 
       `SourceId`
      ,`Version`
      ,`Timestamp`
      ,`Type`
      ,`Data`
  FROM `Snapshots`
  WHERE `SourceId` = @SourceId
  ORDER BY `Version` DESC
  LIMIT 1 OFFSET 0
";
    }

    internal static class StringExtensions 
    { 
        public static string FixSql(this string sql)
        {
            if (string.IsNullOrWhiteSpace(sql))
                return string.Empty;

            return sql.Replace("`", "\"");
        }
    }

}