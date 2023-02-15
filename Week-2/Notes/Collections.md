# Lists

A list is an ordered collection of elements of the same type. It's like an array but it's dynamically sized. Lists allow you to add, insert and remove items.

Lists provide specific methods of manipulation such as:

- Adding and removing items
- Searching for an element
- Looping through each item
- Sorting the objects
- Extracting items and converting them to other data types

**Creating Lists**
Lists are a data type and can therefore be tied to a variable. You can create list type variables by setting the data type to List under the Systems.Collections.Generic namespace. You can initiliaze the values of the list upon variable declaration.

**Adding Elements**
Either use Append to collection activity or invoke code activity.
When using Append to Collection, make sure that you set the output collection to the destination collection, otherwise it wouldn't add to the collection. You can set this by either going to the properties tab of the activity or expanding the advanced options in the activity itself.

When using invoke code, edit the arguments so you are passing the original collection as an in/out argument and you're setting the original collection as the source for this argument. Within the activity itself, edit the code block and write the expression:

```csharp
    Collection_Name.Add(<element>);
```

**Iterating through collections**
Use the foreach activity to iterate through a collection.

**Removing Elements**
To remove a specific item from your list you can use the remove from collection activity. With this activity you can opt to :

- Remove specific item (delete by the element value)
- Remove item by index (delete by index number)
- Clear all items (nuclear option, delete everything)

Similar to Append to Collection activity, the input and output collections must be the same for the changes to reflect on the collection you want to manipulate.

**Searching Elements**
If you want to check if an element is part of a list, you can utilize the exists in collection activity. This activity checks if a certain element exists in a given collection. It has 2 possible outputs: a boolean that represents whether or not an element exists, and the index of the found element if it exists. Note that if the element does not exist, the index will have a value of -1.

**Filtering Elements**
If you want to limit your data set, you can use the filter collection activity. You set the filter conditions and choose a filter action (either you keep elements that match the condition or remove them ). You can choose to save your filtered elements to a different collection if you set the ouput collection to a different variable from the input collection.

# Dictionaries

Like their real life counterpart, a dictionary as a collection works in a similar way. We use key value pairs to store and access values. Note that dictionary keys are unique.

**Creating Dictionaries**
Like any other collection, you create a dictionary by assigning it as a datatype to a variable/argument. The data types for both keys and values have to be chosen when the variable is declared.

NOTE: When creating a dictionary, don't forget to set the default value to an empty dictionary (ie `new Dictionary<TKey, TValue>()`) otherwise it will have the default of null and you will get errors.

**Manipulating Dictionaries**
When working with dictionaries in UiPath, we mostly use the Invoke Code activity and write out the logic in either C# or VB.NET. Foreach activity still works for iterating through dictionaries.
