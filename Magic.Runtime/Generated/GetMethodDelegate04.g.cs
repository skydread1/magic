// this file was generated by Magic.Runtime.Callsites -- do not edit it by hand!
using System.Reflection;

namespace Magic
{
    public static partial class DelegateHelpers
    {
        public static CallsiteFunc<object, object, object, object, object> GetMethodDelegate04(MethodInfo method)
        {
            CallsiteFunc<object, object, object, object, object> ret;
            if(method.IsStatic)
                ret = (arg0,arg1,arg2,arg3) => method.Invoke(null, new[] { arg0,arg1,arg2,arg3 });
            else
                ret = (target, arg1, arg2, arg3) => method.Invoke(target, new [] { arg1,arg2,arg3 });
            return ret;
        }

    }
}