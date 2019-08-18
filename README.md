# XamarinFormsSpecialFolders
## Data anywhere:

In Xamarin Forms apps, data can reside at any Level and typically should be available across all devices, on all platforms. So for example, what if a user has a Windows Desktop, an Android phone, and an iPad? Well local data storage strategies don't really apply to these scenarios, because most of these platforms still are unable to communicate inherently to other platforms. Instead we have this **concept of keeping our data synchronized locally** when it needs to be synchronized locally, but be able to access this data across all devices, all platforms, and again have our code shared so that we're not writing different functions and methods for every single device scenario.

![Data and Storage Concepts](/imgs/data%20anywhere.jpg)

