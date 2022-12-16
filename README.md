# Human Pose Utility

![DEMO](/doc/hpu_demo.jpg)

The pose json used in [VRM Posing Desktop](https://store.steampowered.com/app/1895630/VRM/) uses Unity's HumanPose class. This makes it easy to make it compatible with your Unity products.

[日本語はこちら](/README_JA.md)

## Usage Examples
* Make a character take a specific pose on the character selection screen in a game.
* Preview display in avatar creation applications, etc.

## Name Space

```cs
using HumanPoseUtil;
```

## Script

```cs
// set pose
public static void ApplyHumanPose(Animator animator, HumanPose pose);
// get pose
public static HumanPose ExtractHumanPose(Animator animator);
```

## For Demo

To simplify usage, I have included free assets related to 3D characters and file browsers.

![demo video](/doc/demo.gif)

* [Unity-Chan! Model](https://assetstore.unity.com/packages/3d/characters/unity-chan-model-18705?aid=1011liAjm)
* [Runtime File Browser](https://assetstore.unity.com/packages/tools/gui/runtime-file-browser-113006?aid=1011liAjm)

Please feel free to remove any unnecessary assets and use the demo scripts as a reference to modify the implementation as you see fit.

## Links

This package wraps Unity's HumanPoseHandler for easier handling.

Official Unity documentation is here.

* [HumanPoseHandler](https://docs.unity.cn/ScriptReference/HumanPoseHandler.html)
* [HumanPose](https://docs.unity.cn/ScriptReference/HumanPose.html)

![UnityChan](/doc/imageLicenseLogo.png)