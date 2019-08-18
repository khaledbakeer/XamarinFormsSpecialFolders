# XamarinFormsSpecialFolders
## Data anywhere:

In Xamarin Forms apps, data can reside at any Level and typically should be available across all devices, on all platforms. So for example, what if a user has a Windows Desktop, an Android phone, and an iPad? Well local data storage strategies don't really apply to these scenarios, because most of these platforms still are unable to communicate inherently to other platforms. Instead we have this **concept of keeping our data synchronized locally** when it needs to be synchronized locally, but be able to access this data across all devices, all platforms, and again have our code shared so that we're not writing different functions and methods for every single device scenario.

![Data and Storage Concepts](/imgs/data%20anywhere.jpg)

## Local Sandbox:
In mobile app development, local storage exists at different Levels, and the physical Location of data serves a specific Purpose:
* App
* Temporary
* Local
* Documents or Files

![Local Sandbox](/imgs/Local%20Sandbox.jpg)

Apps cannot access the operating system in a wide-open fashion like you might have been able to do with a Windows desktop app for example. In a Windows desktop app, if a user's an administrator and really have the ability to run any kind of code in any scenario. This can become problematic, dangerous and susceptible to all kinds of software threats from badly behaving data. 

But in general we have this idea of a local sandbox, which means that the app can run in its own space. The app has its own local storage and that local storage is always available to the app. Then we have the system storage that's typically always unavailable. We can't access anything that exists in the system storage, but we can access on a conditional basis storage that's outside the app, things like images, videos, documents or document files are all available to us typically if the user grants us permission.
