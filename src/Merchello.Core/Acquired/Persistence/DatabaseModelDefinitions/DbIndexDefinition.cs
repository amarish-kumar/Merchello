// <auto-generated/> - StyleCop hack to not enforce enum value commentation in this file.
namespace Merchello.Core.Acquired.Persistence.DatabaseModelDefinitions
{
    /// <summary>
    /// Represents a database index definition retreived by querying the database
    /// </summary>
    public class DbIndexDefinition
    {
        public virtual string IndexName { get; set; }
        public virtual string TableName { get; set; }
        public virtual string ColumnName { get; set; }
        public virtual bool IsUnique { get; set; }
    }
}