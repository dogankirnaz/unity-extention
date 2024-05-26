using System.Collections.Generic;
using UnityEngine;

public static class Extention {
    // Extension method to set a GameObject active
    public static GameObject ShowGameObject(this GameObject obj) {
        obj.SetActive(true);
        return obj;
    }

    // Extension method to set a GameObject inactive
    public static GameObject HideGameObject(this GameObject obj) {
        obj.SetActive(false);
        return obj;
    }

    // Extension method to toggle the active state of a GameObject
    public static GameObject ToggleGameObject(this GameObject obj) {
        obj.SetActive(!obj.activeSelf);
        return obj;
    }

    // Extension method to get or add a component
    public static T RequireComponent<T>(this GameObject obj) where T : Component {
        T component = obj.GetComponent<T>();
        if (component == null) {
            component = obj.AddComponent<T>();
        }
        return component;
    }

    // Extension method to set the layer of a GameObject
    public static GameObject SetLayer(this GameObject obj, int layer) {
        obj.layer = layer;
        return obj;
    }

    // Extension method to reset the transform of a GameObject
    public static Transform ResetTransform(this Transform transfrom) {
        transfrom.position = Vector3.zero;
        transfrom.rotation = Quaternion.identity;
        transfrom.localScale = Vector3.one;
        return transfrom;
    }

    // Extension method to add an item to a list if it doesn't already contain it
    public static void AddToList<T>(this List<T> list, T thing) {
        if (list.Contains(thing)) return;
        list.Add(thing);
    }

    // Extension method to remove an item from a list if it contains it
    public static void RemoveFromList<T>(this List<T> list, T thing) {
        if (!list.Contains(thing)) return;          
        list.Remove(thing);
    }

    // Extension method to shuffle a list
    public static void ShuffleList<T>(this List<T> list) {
        System.Random random = new System.Random();
        int n = list.Count;
        while (n > 1) {
            n--;
            int k = random.Next(n + 1);
            T value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }

    // Extension method to swap two elements in a list
    public static void SwapList<T>(this List<T> list, int indexA, int indexB) {
        T temp = list[indexA];
        list[indexA] = list[indexB];
        list[indexB] = temp;
    }
}
