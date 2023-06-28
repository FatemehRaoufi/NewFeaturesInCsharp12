using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NewFeaturesInCsharp12
{
    /// <summary>
    /// C# 12 empowers lambda expressions by allowing you to set default values for parameters. 
    /// The syntax is identical to that of other default parameters
    /// Before C# 12, you had to use a local function or the cumbersome System.DefaultParameterValue.
    /// Runtime. These ways continue to work, 
    /// but they are more difficult to read and are inconsistent with the method's default settings. 
    /// To give a default value for lambda expression parameters, use the InteropServices namespace. 
    /// You'll have a consistent look for default parameter values on methods, constructors, 
    /// and lambdas with the new default values on lambdas expression.
    /// The default value will be emitted in metadata 
    /// and is available via reflection as the DefaultValue of the ParameterInfo of the lambda's Method property.
    /// </summary>
    /*
    Before this preview release, 
    if a developer wanted to provide default values for lambda expression parameters, 
    they had to use local functions or a method called DefaultParameterValue from a specific namespace called System.
    Runtime.InteropServices.
     */
    internal class LambdaExpressionParametersdefaultValues
    {
        public LambdaExpressionParametersdefaultValues()
        {

            var addWithDefault = (int addTo = 2) => addTo + 1;
            var defaultValue = addWithDefault.Method.GetParameters()[0].DefaultValue; // 2

            addWithDefault(); // 3
            addWithDefault(5); // 6
           
            
        }
    }
}
//https://www.infoq.com/news/2023/04/csharp-12-preview/