namespace Sphinx.DAL.Entities
{
    public class CategoryEntity
    {
        /// <summary>
        /// Category identifier
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Category name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Sort order
        /// </summary>
        public int SortOrder { get; set; }
    }
}
