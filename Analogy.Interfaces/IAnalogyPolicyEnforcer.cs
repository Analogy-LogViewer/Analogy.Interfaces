namespace Analogy.Interfaces
{
    /// <summary>
    /// when implemented, override any Application setting
    /// </summary>
    public interface IAnalogyPolicyEnforcer
    {
        public bool DisableUpdates { get; set; }
    }
}
