// this file was generated by Magic.Runtime.Callsites -- do not edit it by hand!
using System;
using System.Reflection;

namespace Magic
{
    public class CallsiteInstanceMethod04
    {
        string MemberName;
        CallSiteCache05 cache;

        public CallsiteInstanceMethod04(string memberName)
        {
            MemberName = memberName;
            cache = new CallSiteCache05();
        }

        public object Invoke(object target, object arg0, object arg1, object arg2, object arg3)
        {
            if(cache.TryGet(target, arg0, arg1, arg2, arg3, out var result))
                return result(target, arg0, arg1, arg2, arg3);

            var method = (MethodInfo)Dispatch.BindToMethod(BindingFlags.Public | BindingFlags.Instance, target.GetType(), MemberName, new [] { arg0,arg1,arg2,arg3 });
            if (method != null)
            {
                cache.CacheMethod(target, arg0, arg1, arg2, arg3, DelegateHelpers.GetMethodDelegate05(method));
                return Dispatch.InvokeUnwrappingExceptions(method, target, new[] { arg0,arg1,arg2,arg3 });
            }
            throw new ArgumentException($"Could not invoke instance member method `{MemberName}` on target {target.ToString()} ({target.GetType()}) with argument types {arg0.GetType()}, {arg1.GetType()}, {arg2.GetType()}, {arg3.GetType()}.");
        }

    }
}