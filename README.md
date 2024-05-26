# unity-extention
This repository contains a collection of extension methods written in C# for use in Unity game development. These extension methods aim to enhance the functionality and ease of use when working with GameObjects, components, and lists within Unity projects.

You are free to use, edit, or change the code provided in this repository to suit your needs. Whether you're a beginner learning Unity development or an experienced developer looking for utility methods, feel free to incorporate these extension methods into your projects. If you make improvements or additions to the code, consider contributing them back to this repository. Fork the repository, make your changes, and submit a pull request. Your contributions can help improve the utility and versatility of these extension methods for everyone.

**Example Calls:**
```
// ShowGameObject
GameObject objToShow = ...; // Get reference to GameObject
objToShow.ShowGameObject();
```

```
// HideGameObject
GameObject objToHide = ...; // Get reference to GameObject
objToHide.HideGameObject();
```

```
// ToggleGameObject
GameObject objToToggle = ...; // Get reference to GameObject
objToToggle.ToggleGameObject();
```

```
// RequireComponent
GameObject objWithComponent = ...; // Get reference to GameObject
Rigidbody rb = objWithComponent.RequireComponent<Rigidbody>();
```

```
// ResetTransform
Transform transformToReset = ...; // Get reference to Transform
transformToReset.ResetTransform();
```

```
// AddToList
List<T> list = ...; // Initialize or get reference to a list of type T
T item = ...; // Item to add to the list
list.AddToList(item); // Add the item to the list if it doesn't already contain it
```

```
// RemoveFromList
List<T> list = ...; // Initialize or get reference to a list of type T
T item = ...; // Item to remove from the list
list.RemoveFromList(item); // Remove the item from the list if it contains it
```

```
// ShuffleList
List<T> list = ...; // Initialize or get reference to a list of type T
list.ShuffleList(); // Shuffle the elements of the list randomly
```

```
// SwapList
List<T> list = ...; // Initialize or get reference to a list of type T
int indexA = ...; // Index of the first element to swap
int indexB = ...; // Index of the second element to swap
list.SwapList(indexA, indexB); // Swap the positions of the elements at indexA and indexB in the list
```
