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
![zSpace_comb_heatmap](https://user-images.githubusercontent.com/79250095/135041483-c39e27e8-5588-43cc-991b-e963eb8a50d3.png)

Clicking the *Combined* button, the second object will be added as shown in the following:
![image](https://user-images.githubusercontent.com/79250095/135041794-ae3713b9-c9b6-44ff-b2a8-99811be2b178.png)

Once a expression value from the [*Similar Genes (4)*](#menu) is selected, it will automatically be expressed on the new heartmodel to compare it with the first selection. 

### <a name="explode">Explode Function</a>
The explode function will expand the model based on its hierarchy. this feature might not work properly for custom objects. To toggle between the normal view and the exploded view press the [*Expand button (2)*](#menu).

![Screenshot (238)](https://user-images.githubusercontent.com/79250095/134447818-21544de8-5dd4-4689-834d-6c8a84e938db.png)

### Change between absolute and normalized expression values

VR-Cardiomics allows to present expression data either in absolute or in normalised values. Our example data is based on log2CPM values for absolute. If [own datasets](#custom) is used, the absolute values will represent the uploaded values of the csv file. Toggle between Normalised or Absolute by using the [*N/A button (9)*](#menu).

### <a name="heatmap">How to use the heatmap comparison </a>

The heatmap comparison is a useful feature to allow calculating the absolute differences of each piece of the object between two expression patterns. The feature will automatically calculate those differences and apply a new colourisation to the model regarding how big the differences in each selected piece are. To use the heatmap function just select an expression for both objects and then press the *Heatmap button* that automatically appears when selecting a expression value. (see [How to select an expression value](#selectExpression)).

### Export data/images

1. **Exporting Similar Expressions** → If an expression value is [selected](#selectExpression) a list of similar expressions will be calculated based on the selection. This list can be exported as a csv file using the export button on the [menu (5)](#menu). This CSV file is then saved in the Asset folder of Unity (blue) calles *SimilarGenes.txt*.
2. **Logfile** → For each session a logfile will be created to keep track of everything you did during your session. This logfile is saved automatically on your local machine within the Assets folder of Unity (blue) called *SessionLog.txt*.
 ![zSpace_Files](https://user-images.githubusercontent.com/79250095/135043900-ec6df8b7-a55c-41b3-a181-f39a984ff93d.png) 


### Piecewise Comparison / Group Selection
The *piecewise comparison/ group selection* is a feature that allows to group a number of pieces of the object together in two groups. Based on those two groups a list of expression values is generated matching the pattern of the selected pieces. 
To use this feature press the *Piecewise Comparison* Button on the [menu (6)](#menu). All objects will be deleted except of one object. This object can be used to select the pieces of the first group. Simply click on them using the zSpace Stylus or using a mouse. The pieces will be highlighted to confirm the selection. Now push the button of the [menu (6)](#menu) again to confirm the first group and start selecting new pieces for group 2. If the selection is done just press the button of the [menu (6)](#menu) again to confirm selection and start calculating the matching expression values. The results will be shown in the table below. 
To deselect pieces from the selection just select them anew.

### Additional features
- Reset the environment by using the [*reset button* (3).](#menu)
- The [*colour button* (7)](#menu) will show the colour transition from low to high expression

## <a name="custom">Upload custom data </a>

VR-Cardiomics allows users to upload their own datasets or models. However, since VR-Cardiomics is still a work in progress, certain requirements of the datasets as well as the objects are expected.

### Upload datasets

VR-Cardiomics allows to upload datasets in csv format. Either as csv or txt files. Please follow the following instructions to change a dataset:

**Change dataset in editor**
1. Open VR-Cardiomics zSpace in the [Unity editor](#runVR).
2. Navigate to ```Assets\Resources```
3. Press right click and select *Import New Asset*
4. Browse your local machine and select the dataset to be uploaded

![image](https://user-images.githubusercontent.com/79250095/135180909-1ab14a5b-28aa-40c5-8c92-3ad293241a5a.png)

5. Select the *ScriptHolder* Object in the Hierarchy tab and drag and drop the new dataset into the field *Csv Name* within the *Colour* Script (green arrow).
![zSpaceNewFile](https://user-images.githubusercontent.com/79250095/135181172-614c47fc-0bf0-4ace-9edd-db8d165f5c55.png)

6. The file *valid_names* (blue) in the figure above needs to be changed to match your new dataset. It is a list of all items you want to use, ensure that all items of your dataset are in the *valid_names* list. Please make sure, that the name of the file won't be changed.

**Example files and structure of datasets**
This version of *VR-Cardiomics* comes with sample data to use. The dataset is stored in ```Assets\Resources\fake_mouse_expression.txt```. A snippet of the dataset is shown here:
![image](https://user-images.githubusercontent.com/79250095/135015941-16cef151-9b09-4a66-ad2a-860888ff798b.png)

Each line of a customised dataset must start with the items name, followed by exactly 18 expression values in csv format, due to the current limitations as explained below.

**Current limitations of the dataset**
VR-Cardiomics is a work in progress. We developed it to use it on a 18 section slices heart model. Therefore, currently only datasets and models with exactly 18 slices are able to be used within the environment. We will take care of this limitation and to allow variable datasets and models as soon as possible.

## <a name="trouble">Troubleshooting </a>

### If the application seems to be not working in Unity game view while running, please navigate from Edit → Project Settings → Player amd emsure that *Virtual Reality Supported* is **not** ticked. 
(https://user-images.githubusercontent.com/79250095/134309050-125952d3-bf16-464e-8f67-9a88e76fb381.png)
