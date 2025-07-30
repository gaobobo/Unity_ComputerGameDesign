> [!IMPORTANT]
>
> 本人该课程已经结课，故对该存储库归档且不再接受任何Pull Request与Issues。
>
> Beacuse of the ending of this course in person, so this repo is achieved and not recept any PRs and Issues.

# Unity 计算机游戏设计

> [!TIP]
>
> For English, see [the second part](#unity_computergamedesign).

Unity计算机游戏设计课后作业。

包含以下内容：

|实验名称                        | 项目位置                                                         |
|:-------------------------------|:---------------------------------------------------------------:|
|Unity脚本练习-游戏物体的创建与控制|[1_CreateAndControlGameObject](./1_CreateAndControlGameObject/) |
|Unity脚本练习-常用工具类与输入控制|[2_RegularControlClassAndInput](./2_RegularControlClassAndInput/)|
|Unity中的摄像机                  |[3_CameraInUnity](./3_CameraInUnity/)                            |
|Mecanim动画系统                  |[4_MecanimSystem](./4_MecanimSystem/)                            |
|物理引擎                         |[5_PhysicsEngine](./5_PhysicsEngine/)                            |
|UI                               |[6_UI](./6_UI/)                                                  |
|Unity中的导航系统                 |[7_NavigationInUnity](./7_NavigationInUnity/)                   |
|综合练习                         |[8_ComprehensiveExercises](./8_ComprehensiveExercises/)          |
|期末作业-FPS射击游戏              |[9_FinalWork-FPSGame](./9_FinalWork-FPSGame/)                   |

另提供可执行文件，参见[Release页面](https://github.com/gaobobo/Unity_ComputerGameDesign/releases)。

## 构建项目

预想构建项目，需要安装Unity Editor与代码编辑器。所有项目均使用`2022.3.62f1 LTS`版本构建。

### 安装Unity Editor

- [下载Unity Hub](https://unity.com/download)，安装后登录或注册Unity ID；
- 如果之前尚未激活许可证，前往“设置(Settings)-许可证(Licenses)-添加(Add)”以激活Unity Editor。可以使用“免费的个人许可证”激活；
- 前往“安装(Install)-安装编辑器(Install Editor)”，选择一个版本安装。该项目使用`2022.3.62f1 LTS`版本构建；
- 如果已有趁手的代码编辑器，可以在“开发工具”中取消选中“Microsoft Visual Studio Community”。另外，强烈推荐使用[Jetbrains Rider](https://www.jetbrains.com/rider/)；
- 在“平台(Platform)”中选择所有构建目标；
- 亦可在“语言包（预览版）”(Language Pack (preview))选择希望安装的语言包，稍后可在Unity Editor中切换语言。

### 打开项目

- 使用`git clone`克隆本仓库或[下载本仓库档](https://github.com/gaobobo/Unity_ComputerGameDesign/archive/refs/heads/main.zip)；
- 在Unity Hub中，选择“项目(Projects)-添加(Add)-从磁盘添加项目(Add project from disk)”，选择[上表中所示的文件夹](#unity-计算机游戏设计)；
- 如不是`2022.3.62f1 LTS`版本的Unity Editor，Unity Hub会提示选择某特定版本的编辑器。同时，Unity Editor会提示需要重构项目，选择“继续(Continue)”以重构；
- 在Unity Editor中，选择“编辑(Edit)-首选项(Perference)-简体中文(Language)”以切换语言（如安装语言包）；
- 在Unity Editor中，选择“编辑(Edit)-首选项(Perference)-外部工具(External Tools)-外部脚本编辑器(External Script Editor)”以切换带代码编辑器。

### 构建可执行文件

- 在Unity Editor中，选择“文件(File)-生成设置(Build Settings)”
- 选择目标平台。需要[安装相应的平台](#安装unity-editor)；
- 亦可在“玩家设置(Player Settings)”中设置更多的选项；
- 将“场景(Scenes)”拖入“Build中的场景(Scenes In Build)”；
- 点击“生成(Build)”并选择希望存储到的位置。

## 贡献项目

该项目仅作为本人的课程作业，因此不考虑任何形式的贡献。

## 开源许可

该项目中的代码遵循[MIT开源许可](./LICENSE-CODE)。该项目亦包含来自第三方的资源或作品，参见[LICENSE-ASSETS](./LICENSE-ASSETS)了解更多。

------

# Unity_ComputerGameDesign

This repository contains coursework for the *Unity Computer Game Design* class.

It includes the following contents:

| Experiment Title                                                    |                          Project Location                          |
| :------------------------------------------------------------------ | :----------------------------------------------------------------: |
| Unity Scripting Practice – Creating and Controlling GameObjects     |  [1\_CreateAndControlGameObject](./1_CreateAndControlGameObject/)  |
| Unity Scripting Practice – Common Utility Classes and Input Control | [2\_RegularControlClassAndInput](./2_RegularControlClassAndInput/) |
| Cameras in Unity                                                    |               [3\_CameraInUnity](./3_CameraInUnity/)               |
| Mecanim Animation System                                            |               [4\_MecanimSystem](./4_MecanimSystem/)               |
| Physics Engine                                                      |               [5\_PhysicsEngine](./5_PhysicsEngine/)               |
| UI                                                                  |                          [6\_UI](./6_UI/)                          |
| Navigation System in Unity                                          |           [7\_NavigationInUnity](./7_NavigationInUnity/)           |
| Comprehensive Exercises                                             |      [8\_ComprehensiveExercises](./8_ComprehensiveExercises/)      |
| Final Project – FPS Shooting Game                                   |           [9\_FinalWork-FPSGame](./9_FinalWork-FPSGame/)           |

Executable files are also provided. See the [Release Page](https://github.com/gaobobo/Unity_ComputerGameDesign/releases).

## Building the Project

To build the project, you need to install Unity Editor and a code editor. All projects are built using version `2022.3.62f1 LTS`.

### Installing Unity Editor

- [Download Unity Hub](https://unity.com/download), install it, and sign in or register a Unity ID;
- If you haven't activated a license yet, go to **Settings > Licenses > Add** to activate the Unity Editor. You may activate it using the *Free Personal License*;
- Go to **Installs > Install Editor**, and select the version `2022.3.62f1 LTS` used for this project;
- If you already have a preferred code editor, you may uncheck “Microsoft Visual Studio Community” under *Development Tools*. It is highly recommended to use [Jetbrains Rider](https://www.jetbrains.com/rider/);
- In *Platform*, select all target build platforms;
- Optionally, you may choose language packs in *Language Pack (Preview)* to switch languages later in Unity Editor.

### Opening the Project

- Clone this repository via `git clone`, or [download the zip archive](https://github.com/gaobobo/Unity_ComputerGameDesign/archive/refs/heads/main.zip);
- In Unity Hub, go to **Projects > Add > Add project from disk**, and select a folder listed in the [table above](#unity_computergamedesign);
- If your Unity Editor version is not `2022.3.62f1 LTS`, Unity Hub will prompt you to select a specific version. Unity Editor may also prompt to reimport the project — choose **Continue**;
- In Unity Editor, go to **Edit > Preferences > Language** to change the language (if language pack is installed);
- In Unity Editor, go to **Edit > Preferences > External Tools > External Script Editor** to select your preferred code editor.

### Building Executables

- In Unity Editor, go to **File > Build Settings**;
- Choose the target platform (you may need to [install it](#installing-unity-editor));
- You may configure additional settings under **Player Settings**;
- Drag your scenes into the **Scenes In Build** section;
- Click **Build** and choose the destination folder.

## Contributing

This project is a personal coursework submission and does not accept any contributions.

## Open Source License

The code in this project is licensed under the [MIT License](./LICENSE-CODE). This project also includes third-party assets. See [LICENSE-ASSETS](./LICENSE-ASSETS) for more information.
