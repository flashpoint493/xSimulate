﻿using System;
using System.Reflection;
using xSimulate.Action;
using xSimulate.Configuration;

namespace xSimulate.Util
{
    public class ClassLoader
    {
        public static IAction LoadAction(AutomationAction actionConfig)
        {
            return LoadAssambly<IAction>(typeof(ClassLoader).Assembly, actionConfig);
        }

        private static T LoadAssambly<T>(Assembly assembly, AutomationAction actionConfig)
        {
            string fullName = typeof(T).FullName;

            Type[] typeArray = assembly.GetTypes();
            foreach (Type type in typeArray)
            {
                if (!type.IsPublic)
                {
                    continue;
                }

                Type find = type.GetInterface(fullName);
                if (find != null && find.IsPublic && !type.IsAbstract)
                {
                    if (type.Name == actionConfig.Type + "Action")
                    {
                        T obj = (T)Activator.CreateInstance(type, actionConfig);
                        return obj;
                    }
                }
            }

            throw new ArgumentException(string.Format("action type:{0} not found", actionConfig.Type));
        }
    }
}