using System.ComponentModel;

namespace UserStrory.Models
{
    /// <summary>
    /// Пол
    /// </summary>
    public enum Gender
    {
        /// <summary>
        /// Мужской
        /// </summary>
        [Description("Мужской")]
        Male,
        /// <summary>
        /// Женский
        /// </summary>
        [Description("Female")]
        Female,
    }
}
