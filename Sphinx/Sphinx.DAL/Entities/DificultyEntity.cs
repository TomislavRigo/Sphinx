using Sphinx.DAL.Common.Entities;

namespace Sphinx.DAL.Entities
{
    public class DificultyEntity
    {
        /// <summary>
        /// Dificulty identifier
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Dificulty name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Sort order
        /// </summary>
        public int SortOrder { get; set; }
    }
}
