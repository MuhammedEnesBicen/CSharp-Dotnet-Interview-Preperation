## Some Important Infos

### Create Char Array from a string

String.ToCharArray();
overrided version => String.ToCharArray(startIndex,Length);
it can be used like that => str.ToCharArray();

### Length Vs Count

str => Length arr=> Count

List<char> chars = str.ToCharArray().ToList();
new string(chars.ToArray()); chars is List<char>

SortedDictionary is a Collection Type


## Array.Sort(parameter_array)
An important thing to keep in mind; when you sort array via this method it doesnt return anything, it makes changes on original array