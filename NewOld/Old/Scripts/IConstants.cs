using UnityEngine;
using System.Collections;

public static class IConstants  
{
	public static bool inWater = false;
    public static bool jetpack = false;
    public static bool menuVisible = false;
	public static Hashtable hashtable = new Hashtable();
    public static Hashtable globalVar = new Hashtable();
    public static int rotation = 1;
    public static int eggs = 0;
    public static bool Charcheat = false;
    public static string gamemode;

    public static void setMap(string val, bool b)
    {
        if (IConstants.hashtable.ContainsKey(val))
        {
            IConstants.hashtable[val] = b;
        }
        else
        {
            IConstants.hashtable.Add(val, b);
        }
    }

    public static bool getMap(string val)
    {
        if (IConstants.hashtable.ContainsKey(val))
        {
            return (bool)IConstants.hashtable[val];
        }
        else return false;
    }

    public static void setGlobalObj(string val, object b)
    {
        if (IConstants.hashtable.ContainsKey(val))
        {
            IConstants.hashtable[val] = b;
        }
        else
        {
            IConstants.hashtable.Add(val, b);
        }
    }

    public static object getGlobalObj(string val)
    {
        if (IConstants.hashtable.ContainsKey(val))
        {
            return IConstants.hashtable[val];
        }
        else return null;
    }

    public static void setGlobalVar(string val, string b)
    {
        if (IConstants.hashtable.ContainsKey(val))
        {
            IConstants.hashtable[val] = b;
        }
        else
        {
            IConstants.hashtable.Add(val, b);
        }
    }

    public static string getGlobalVar(string val)
    {
        if (IConstants.hashtable.ContainsKey(val))
        {
            return (string)IConstants.hashtable[val];
        }
        else return "";
    }
}
