# Fire in the lab

This is the VR application of group 5 in the _Eksperter i Team_ village *VR/AR i læring og trening 2020*

The purpose of this application is to teach the user how to use a fire extinguisher in a hazardous situation in the VR lab.

To be able to run this project you need to download and install `Oculus Integration` from the Unity Asset Store.

The Scene can be found in `Assets/Scenes/VRLabben.unity`

The fire extinguisher can be lifted with the `HandTrigger` button, and can be engaged with the `IndexTrigger` button,
as illustrated [here](https://developer.oculus.com/documentation/unity/unity-ovrinput/#virtual-mapping-accessed-as-individual-controllers).
Before the extinguisher can be engaged the safety pin (orange sylinder) must be removed.

# Excerpts from the project report:

## Contents of the application

The application consists of a scene that contains:

* A virtual environment similar to the VR lab.
* A fire extinguisher that can be interacted with
* Some fires that should be extinguished


## Functionality

* The body and nose of the fire extinguisher can be picked up by the VR actor separately in each hand respectively
* The body has a safetypin (orange sylinder) that limits extinguishing functionality of the fire extinguisher.
* The fire extinguisher can produce powder particles that are sprayed through the nose. This functionality can be activated by the user when the safety pin is removed, and the user is carrying the body of the extinguisher and presses the index finger button.
* Each fire keeps track of its own intensity, and will grow with time up to an upper boundary set by the developer. The visual size of the fire is determined by this intensity value. 
* Each fire has a small core that powder particles can interact with.
* Powder particles hitting the core of a fire will decrease the intensity of the fire with a certain amount, and then disappear.
* When the intensity of a fire reaches 0 the fire will disappear.
* Doors can be opened using the F key on the keyboard. This is only possible with the Oculus Quest connected using Oculus Link, or using other headsets running the application from a computer.

