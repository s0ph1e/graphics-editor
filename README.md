graphics-editor
===============

Application is written in C# in Visual Studio 2010, has russian user interface. 

Objects consist of cylinders and parallelepipeds, which are represented using triangular polygons. 
(In this program objects are gymnastic training bars, but you can construct anything you want from cylinders and boxes)

The scene may contain multiple objects. All objects can be transformed together or separately. 
Affine transformations are implemented for moving, rotation, scaling, reflection.

Next features are also implemented:

 - central and parallel projections
 - view mode (show faces or edges)
 - UVN-camera
 - frustum culling
 - removal of hidden lines (Painter's algorithm)
 - removal of hidden faces
 - flat shading


The scene with all objects and previous transformations can be saved and loaded from file.
