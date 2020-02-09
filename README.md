<p align="center">
<img src="https://vueschool.io/media/cb103360d9341bd311b96974a83a3a91/vuejs-components-fundamentals.png" width="300" />
</p>
<p align="center">
One of the common trends in the app development space today is the pattern of microservices and component-based architectures, which when done correctly, gives you ultimate flexibility and scalability where it matters.
</p>
<br>

## So what is component-based architectures

Component-based architecture focuses on the decomposition of the design into individual functional or logical components that represent well-defined communication interfaces containing methods, events, and properties. It provides a higher level of abstraction and divides the problem into sub-problems, each associated with component partitions.

The primary objective of component-based architecture is to ensure component reusability. A component encapsulates functionality and behaviors of a software element into a reusable and self-deployable binary unit.

## But what is a Component?

A component is a modular, portable, replaceable, and reusable set of well-defined functionality that encapsulates its implementation and exporting it as a higher-level interface.

A component is a software object, intended to interact with other components, encapsulating certain functionality or a set of functionalities. It has an obviously defined interface and conforms to a recommended behavior common to all components within an architecture.


## Xamarin ?
Xamarin is an open-source platform for building modern and performant applications for iOS, Android, and Windows with .NET. Xamarin is an abstraction layer that manages communication of shared code with underlying platform code. Xamarin runs in a managed environment that provides conveniences such as memory allocation and garbage collection.

## My story
Xamarin is a flexible platform that enable the developer to work with almost any pattern and architecture, At start the app needed some basic UI with few interactions for crud operations, Soon later the app has grown in size, complexity and the UI became much much complex, That made us challenges as we were debugging specific part of the UI and behavior also the newer recruited devs took a long time to follow the hierarchy.

### What we did 
- We decoupled the pages into reusable components that we can use in other parts of the app.
- The components are simple ContentView Views that contains a specific UI with it own behavior.
- The components can be used in pages or can be used in other components

### Challenges
- When enabling, hot reload in visual studio, every change in the child components of the page make the app look blank, This needs relaunching the debugging process.
- You cant bind an object from the parent directly into the components (Ex: from page to component), The binding happens specifically in the component code behind.
- When using the CollectionView or ListView its hard to bind the iterated object from the list in the component

### Benefits !
- The page became a set of calls for the components.
- Every component holds it own behavior with help us identifying bugs much faster.
- The Reusability of the components removed repetitions witch means remove the redundant code.
- Updating and improving components became easy because you don't have to deal with other none related code.
- Dividing tasks have never been this easy.





