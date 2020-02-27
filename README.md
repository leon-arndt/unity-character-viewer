# unity-character-viewer
supports particles and animations

## Features
- Play animations on meshes using the legacy Unity animation system.
- Choose whether to loop animations
- Play particle effects

Legacy animation are used  to save on the time of having to make an animation controller for each mesh.

## How to Use
1. Set the animation type in the mesh import settings to legacy
2. Create a new scriptable object of type Portrait
3. Add the mesh, animations, and particle effects fields in the Potrait scriptable object
4. Add the portrait scriptable object to the scene manager portrait pool
5. Press play and click the left mouse button

## Limitations
- Unity Legacy Animation System must be used
- Each Animation requires its own scriptable object
- Scriptable objects have to be added manually to the data pool
