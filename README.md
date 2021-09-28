# VR-Cardiomics (zSpace)
## A visual system for the exploration of cardiac transcriptome data


### Overview
VR-Cardiomics (zSpace) provides a framework to map multi-dimensional data (such as intensity and location of gene expression) onto 3D models in a heatmap-like manner. In our use case, the intensity is the level of gene expression of those expressed in the adult heart, and the location is this expression level in 18 discrete pieces of the heart as measured by RNA-seq.

Code for the manuscript: Denis Bienroth<sup>\*</sup>, Hieu T. Nim, Dimitar Garkov, Karsten Klein, Sabrina Jaeger-Honz, Mirana Ramialison<sup>#</sup> and Falk Schreiber<sup>#</sup>. "Spatially-Resolved Transcriptomics in ImmersiveEnvironments" (<sup>\*</sup>: first author; <sup>#</sup>: corresponding authors)

VR-Cardiomics (zSpace) is designed to map user-generated data onto a user-specific 3D model. However, the data and the model must meet certain requirements. Please refer to chapter [Upload Custom Data](#custom) for more information on how to use VR-Cardiomics as a framework for your own data and models on your local machine.

This code only supports 2D monitor solutions and zSpace. [VR application](https://github.com/Ramialison-Lab/VR-Cardiomics) and the [Webapplication](https://github.com/Ramialison-Lab/3DCardiomics) are also available.

## Navigate
- [Dependencies](#dependencies)
- [How to run VR-Cardiomics](#runVR)
- [VR-Cardiomics Features](#features)
- [Upload custom data](#custom)
- [Troubleshooting](#trouble)

## <a name="dependencies">Dependencies </a>

-   Unity (2018.4.23f1)
-   zSpace Core plugin ([see below](#plugin)) 

The application was tested and developed for zSpace AIO 200 solutions, other devices may not be fully supported.

## <a name="runVR">How to run VR-Cardiomics </a>

The simplest way to run VR-Cardiomics is by using Unity [2019.4.19f1](https://unity3d.com/de/unity/whats-new/2019.4.19). Copy VR-Cardiomics from GitHub to your local machine ([how to copy from GitHub](https://docs.github.com/en/repositories/creating-and-managing-repositories/cloning-a-repository)) and open it in Unity (Information on how to open an existing project in Unity can be found [here](https://docs.unity3d.com/2019.1/Documentation/Manual/GettingStartedOpeningProjects.html)).

*It is recommended to ignore update notifications from Unity in order to ensure that the application is processed as expected.*

Start Unity 2018.4.23.f1 or later on the folder structure of the gitHub Repo. Ensure that zSpace is installed and running. For further information on zSpace setup [klick here](https://support.zspace.com/s/article/Setting-up-your-zSpace-Laptop-and-user-guide?language=en_US). Please note EOL of zSpace devices. 

<a name="plugin">In order</a> to run the code on zSpace in Unity import zSpace plugin. For zSpace Plugin information for Unity to support main features please see [here](https://developer.zspace.com/docs/unity3d-setup). 

## <a name="features">VR-Cardiomics Features</a>

### <a name="menu">The menu </a>
The menu is always visible while using the application and s used to control all features of VR-Cardiomics.

![zSpaceMenu](https://user-images.githubusercontent.com/79250095/135039690-3093bbd9-2813-49d9-8ac3-1a3b93e10bdb.png)

Menu explanations:
1. Input Field for expression value
2. Explode function to expand the model
3. Reset function to reset all selections and the second object
4. Similar genes list where all similar expression patterns will be shown according to input in input field 1.
5. Export current similar genes list as CSV file
6. Piecewise Comparison / Group Selection
7. Show heatmap legend
8. Alternative colour palette for heat map if visual difficulties might appear
9. Toggle between normalised or absolute values
10. Autocompleted list of expression items according to current input

### <a name="selectExpression">How to select an expression value </a>

To select an expression value simply press the [input field (1)](#menu) by either using the zSpace Stylus or a mouse. Enter input by using a keyboard. The [autofill feature (10)](#menu) will provide a selection according to the current input. 

### <a name="selectExpression">How to select an expression value </a>

Per default the first model will be automatically selected for values chosen from the [input field (1)](#menu). Once an expression value was chosen for the first object two new buttons will appear in the menu. The *Combined* button allows to add a second object, while the [*heatmap* button}(#heatmap) allows a difference based comparison of both objects.

![image](https://user-images.githubusercontent.com/79250095/135041794-ae3713b9-c9b6-44ff-b2a8-99811be2b178.png)

Clicking the *Combined* button, the second object will be added as shown in the following:

![zSpace_comb_heatmap](https://user-images.githubusercontent.com/79250095/135041483-c39e27e8-5588-43cc-991b-e963eb8a50d3.png)

Once a expression value from the [*Similar Genes (4)*](#menu) is selected, it will automatically be expressed on the new heartmodel to compare it with the first selection. 
