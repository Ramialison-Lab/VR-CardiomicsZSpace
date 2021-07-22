# 3D-Cardiomics-VR (zSpace)
## A visual system for the exploration of cardiac transcriptome data


### Overview
3D-Cardiomics-VR for zSpace provides a framework to map multi dimensional data (such as intensity and location of gene expression) on to 3D models in a heatmap-like manner. In our use case the intensity is the level of gene expression of those expressed in the adult heart, and the location is this expression level in 18 discrete pieces of the heart as measured by RNA-seq.

This code only supports 2D monitor solutions and zSpace. [VR code](https://github.com/Ramialison-Lab/3DCardiomicsVR) and the [Webapplication](https://github.com/Ramialison-Lab/3DCardiomics) are also available.

## Supported Devices

Currently all zSpace devices from AIO 200 upwards are fully supported if not declared EOL.

## Upload Files

Gene Expressions are stored under the following path

```
Assets/Resources/
```

A sample of fake gene expressions is provided at:

```
Assets/Resources/fake_mouse_expression_data.txt
```

In order to change expression data, import *.txt* file in Ressources folder. The expression data can simply be changed by using the *Scriptholder* Object in Unity. The attached Script *Colour* stores the datapath of the csv file named *CSV name*. Enter the name of the csv file within ressource strucutre or corresponding datapath if stored otherwise.

![CSVpath](https://user-images.githubusercontent.com/79250095/126587353-91838b1c-c559-4013-af3b-3e2313960c66.PNG)

## Dependencies

- Unity (2018.4.23.f1)
- zSpace Core plugin ([see below](#plugin)) 

### Instructions
Start Unity 2018.4.23.f1 or later on the folder structure of the gitHub Repo. Ensure that zSpace is installed and running. For further information on zSpace setup [klick here](https://support.zspace.com/s/article/Setting-up-your-zSpace-Laptop-and-user-guide?language=en_US). Please note EOL of zSpace devices. 

<a name="plugin">In order</a> to run the code on zSpace in Unity import zSpace plugin. For zSpace Plugin information for Unity to support main features please see [here](https://developer.zspace.com/docs/unity3d-setup). 

