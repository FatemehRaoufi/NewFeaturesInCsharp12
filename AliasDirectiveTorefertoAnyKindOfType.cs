namespace NewFeaturesInCsharp12
{
    /// <summary>
    /// Allow the use of the alias directive to refer to any kind of Type:
    /// using_alias_directive (13.5.2) to allow it to point to any type, not just named types. This would allow for types not currently permitted, such as tuple types, pointer types, array types, and so on. 
    /// For example, the following would now be allowed
    /// </summary>
    using Point = (int x, int y);
    internal class AliasDirectiveTorefertoAnyKindOfType
    {
        
        public AliasDirectiveTorefertoAnyKindOfType()
        {

        }
    }
}
