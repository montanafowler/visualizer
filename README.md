# Montana's Visualizer

![image of visualizer](https://raw.githubusercontent.com/montanafowler/visualizer/main/start_screen.jpg)

[video of the visualizer](https://drive.google.com/file/d/1heyGv4vw9FsjLFrZe9nAr4Z_AOmP6jVe/view?usp=sharing)

## Instructions:

1. Download the zip file for either the ios or windows build (see above).
2. Unzip it and launch the application
3. Shapes are changed at the bottom, and the different menus will give you the ways you can modify the model.

## Documentation

### Overview
Montana's visualizer is formatted for mobile in a vertical layout and designed with minimal screen space for the menu options.  

At the bottom of the screen, a user can choose to visualize a cube, sphere, or a cylinder by clicking on the buttons Montana designed herself.  The shapes are turned on and off with activation, and whether or not the shape is active determines if it is affected by the properties the user changes.

A user can translate the shape by directly moving it around with their mouse.  They can adjust the scale and rotation using the sliders in the Scale/Rotate menu.

A user can change the material of the shape being visualized to be a diffuse green default, a metallic material, or any of the textures Montana created with her own photographs.

Beyond changing the material and transform of the object, a user can also move the camera with the camera settings menu.

Finally, a user can choose a between a variety of directional lights for their scene.  

### Performance Optimization
To optimize performance, the texture sprites on the material buttons have been significantly compressed to a max size of 64 and a low quality compression.  Additionally, all of the textures being applied to shapes used crunch compression to improve performance.

## Challenges
One of my first challenges was getting access to activating and deactivating the shapes from the buttons.  I originally added a script to all of the shape buttons, but this meant I could not use Find() to find a deactivated game object since they all would call the Start() function.  To get around this, I decided to have an ObjectActivationManager as an empty GameObject that would have the script component, so that the buttons could call the manager to activate the correct shape.  I then applied this same design pattern to the PropertiesMenuManager which held all of the script components for changing the properties.  

The other main challenge I encountered was trying to be intentional about laying out my buttons so that they would fit responsively. I carefully used Vertical and Horizontal Layouts to get the nested behavior.


