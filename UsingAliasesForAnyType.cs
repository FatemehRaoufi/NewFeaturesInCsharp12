
namespace NewFeaturesInCsharp12
{
    /// <summary>
    /// With C# 12, any type can use directive support.
    /// By aliasing types, you can abstract the actual types you're using and give confusing or lengthy generic and understandable names. 
    /// Your code may be simpler to read as a result.
    /// </summary>
    /// 
    using Measurement = (string, int);
    using Measurement1 = (string Units, int Distance);
    using PathOfPoints = int[];
    using DatabaseInt = int?;
    internal class UsingAliasesForAnyType
    {

        public UsingAliasesForAnyType()
        {

        }
        public void F(Measurement x)
        { }

    }
}
