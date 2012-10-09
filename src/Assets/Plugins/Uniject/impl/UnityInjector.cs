using System;
using Ninject;
using Ninject.Injection;
using UnityEngine;

public class UnityInjector
{
    private static IKernel kernel;
    
    public static IKernel get() {
        if (null == kernel) {
            kernel = new StandardKernel (new UnityNinjectSettings (), new Ninject.Modules.INinjectModule[] {
                new UnityModule (scoper)
            } );
            
            GameObject listener = new GameObject();
            GameObject.DontDestroyOnLoad(listener);
            listener.name = "LevelLoadListener";
            listener.AddComponent<LevelLoadListener>();
        }
        return kernel;
    }
    
    public static object levelScope = new object();
    private static object scoper(Ninject.Activation.IContext context) {
        return levelScope;
    }
}
