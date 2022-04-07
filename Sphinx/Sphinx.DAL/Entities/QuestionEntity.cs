namespace Sphinx.DAL.Entities
{
    public class QuestionEntity
    {
        /// <summary>
        /// Question identifier
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Question in JSON string format
        /// </summary>
        public string Question { get; set; }

        /// <summary>
        /// Question category
        /// </summary>
        public Guid CategoryId { get; set; }

        /// <summary>
        /// Question dificulty
        /// </summary>
        public Guid DificultyId { get; set; }

        /// <summary>
        /// Last used date
        /// </summary>
        public DateTime LastUsed { get; set; }
    }
}
