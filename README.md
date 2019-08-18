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

## Different path to the same result:
Although every platform has local or simple storage locations, those locations don't translate exactly. They all have a different notion of where to store data and what the guidelines will be around restrictions.
So for **example**, if you were to access **documents**:
* on an Android device, the actual path would be `/data/data/[App]/files`.
* on iOS, it would be `/Users/[Profile]/Library`.
* on Windows, it would be `/Users/[Profile]/documents`.

![Platform Variations](/imgs/Platform%20Variations.jpg)

So to just make sure we're on the same page about these platform variations, remember that most of the special folders that are on a specific platform are going to be unavailable. Most physical device locations are **unavailable **for use or access from a mobile app. 

There are common locations that are **available** sometimes, only if the user grants `permission`. And they really fall into these five categories: 
* **App assets**: Anything that's available in your app can be made available. So if you were to compile images or deploy images with your app, those app assets would be available.
* **App storage**: Often referred to as local storage.
* **Documents**: And depending on the platform, some things are considered documents or they fall under the documents folder.
* **Images** or **photos** or **pictures**: that are going to be managed typically in a different way on every platform.
* **Transient media**: So we also have this idea that videos and images can sort of exist on a device but they might actually exist somewhere else. For example, maybe these are going to be stored in iTunes ultimately or in One Drive. We have this transient media.

Those locations are typically available if we get `permission`. So again, we're not talking about a wide open folder structure. We're talking about being able to access documents, images, videos, and those types of things.

## Results of this app:
Let me show you the results, you will get the same if you try to build this app on iOS or Android.

![Results](/imgs/results.png)

This App will list all special folders that you can access with a permission.
### Special Folders for android
    
    Desktop=/data/user/0/[Package Name]/files/Desktop
    MyDocuments=/data/user/0/[Package Name]/files
    MyDocuments=/data/user/0/[Package Name]/files
    MyMusic=/data/user/0/[Package Name]/files/Music
    MyVideos=/data/user/0/[Package Name]/files/Videos
    DesktopDirectory=/data/user/0/[Package Name]/files/Desktop
    Fonts=/data/user/0/[Package Name]/files/.fonts
    Templates=/data/user/0/[Package Name]/files/Templates
    ApplicationData=/data/user/0/[Package Name]/files/.config
    LocalApplicationData=/data/user/0/[Package Name]/files/.local/share
    CommonApplicationData=/usr/share
    MyPictures=/data/user/0/[Package Name]/files/Pictures
    UserProfile=/data/user/0/[Package Name]/files
    CommonTemplates=/usr/share/templates

### Special Folders for iOS
    
    Desktop=/Users/[User Name]/Library/Developer/CoreSimulator/Devices/[Generated Sub-Folder]/data/Containers/Data/Application/[Generated Sub-Folder]/Documents/Desktop
    MyDocuments=/Users/[User Name]/Library/Developer/CoreSimulator/Devices/[Generated Sub-Folder]/data/Containers/Data/Application/[Generated Sub-Folder]/Documents
    MyDocuments=/Users/[User Name]/Library/Developer/CoreSimulator/Devices/[Generated Sub-Folder]/data/Containers/Data/Application/[Generated Sub-Folder]/Documents
    Favorites=/Users/[User Name]/Library/Developer/CoreSimulator/Devices/[Generated Sub-Folder]/data/Containers/Data/Application/[Generated Sub-Folder]/Library/Favorites
    MyMusic=/Users/[User Name]/Library/Developer/CoreSimulator/Devices/[Generated Sub-Folder]/data/Containers/Data/Application/[Generated Sub-Folder]/Documents/Music
    MyVideos=/Users/[User Name]/Library/Developer/CoreSimulator/Devices/[Generated Sub-Folder]/data/Containers/Data/Application/[Generated Sub-Folder]/Documents/Videos
    DesktopDirectory=/Users/[User Name]/Library/Developer/CoreSimulator/Devices/[Generated Sub-Folder]/data/Containers/Data/Application/[Generated Sub-Folder]/Documents/Desktop
    Fonts=/Users/[User Name]/Library/Developer/CoreSimulator/Devices/[Generated Sub-Folder]/data/Containers/Data/Application/[Generated Sub-Folder]/Documents/.fonts
    Templates=/Users/[User Name]/Library/Developer/CoreSimulator/Devices/[Generated Sub-Folder]/data/Containers/Data/Application/[Generated Sub-Folder]/Documents/Templates
    ApplicationData=/Users/[User Name]/Library/Developer/CoreSimulator/Devices/[Generated Sub-Folder]/data/Containers/Data/Application/[Generated Sub-Folder]/Documents/.config
    LocalApplicationData=/Users/[User Name]/Library/Developer/CoreSimulator/Devices/[Generated Sub-Folder]/data/Containers/Data/Application/[Generated Sub-Folder]/Documents
    InternetCache=/Users/[User Name]/Library/Developer/CoreSimulator/Devices/[Generated Sub-Folder]/data/Containers/Data/Application/[Generated Sub-Folder]/Library/Caches
    CommonApplicationData=/usr/share
    ProgramFiles=/Applications
    MyPictures=/Users/[User Name]/Library/Developer/CoreSimulator/Devices/[Generated Sub-Folder]/data/Containers/Data/Application/[Generated Sub-Folder]/Documents/Pictures
    UserProfile=/Users/[User Name]/Library/Developer/CoreSimulator/Devices/[Generated Sub-Folder]/data/Containers/Data/Application/[Generated Sub-Folder]
    CommonTemplates=/usr/share/templates
    Resources=/Users/[User Name]/Library/Developer/CoreSimulator/Devices/[Generated Sub-Folder]/data/Containers/Data/Application/[Generated Sub-Folder]/Library