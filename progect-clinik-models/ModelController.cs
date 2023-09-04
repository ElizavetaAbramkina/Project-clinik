using System.Reflection;

namespace progect_clinik_models
{
    public class ModelController
    {
        public static Type[] GetModelTypes() => 
            Assembly.GetCallingAssembly()
            .GetTypes()
            .Where(x => typeof(IEntity).IsAssignableFrom(x))
            .ToArray();
    }
}