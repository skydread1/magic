// this file was generated by Magic.Runtime.Callsites -- do not edit it by hand!
using System.Reflection;

namespace Magic
{
    public static partial class DelegateHelpers
    {
        public static CallsiteFunc<object, object, object, object, object, object, object, object, object, object, object> GetMethodDelegate10(MethodInfo method)
        {
            CallsiteFunc<object, object, object, object, object, object, object, object, object, object, object> ret;
            if(method.IsStatic)
                ret = (arg0,arg1,arg2,arg3,arg4,arg5,arg6,arg7,arg8,arg9) => method.Invoke(null, new[] { arg0,arg1,arg2,arg3,arg4,arg5,arg6,arg7,arg8,arg9 });
            else
                ret = (target, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9) => method.Invoke(target, new [] { arg1,arg2,arg3,arg4,arg5,arg6,arg7,arg8,arg9 });
            return ret;
        }

    }
}