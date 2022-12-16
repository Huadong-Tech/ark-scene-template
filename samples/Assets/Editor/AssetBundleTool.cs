using UnityEditor;
using System.IO;
using UnityEngine;

public class AssetBundleTool : Editor
{
    private const string root = "AssetBundle/";
    private const string iOSPlatform = "iOS";
    private const string AndroidPlatform = "Android";
    private const string webGLPlatform = "WebGL";
    private const string macOSPlatform = "macOS";
    private const string winPlatform = "Windows";

    private const string generate = "Generate/";
    private const string meetingPage = "Meeting/";
    private const string officePage = "Office/";
    private const string exhibitionStandPage = "ExhibitionStand/";

    static bool selectWebGLPlatform = false;
    static bool selectiOSPlatform = false;
    static bool selectAndroidPlatform = false;
    static bool selectMacOSPlatform = false;
    static bool selectWinPlatform = false;

    private const string OfficeCommonJ = "OfficeCommonJ"; /// 百人办公

    private const string exhibitionStands = "exhibitionStands"; // 展厅
    private const string suffix = ".unity";                    // 后缀名

    private static BuildTarget WebGLTarget = BuildTarget.WebGL;
    private static BuildTarget iOSTarget = BuildTarget.iOS;
    private static BuildTarget AndroidTarget = BuildTarget.Android;
    private static BuildTarget macOSTarget = BuildTarget.StandaloneOSX;
    private static BuildTarget windowsTarget = BuildTarget.StandaloneWindows;


    static void CreateSceneBundle(string sceneName, BuildTarget target)
    {
        CreateSceneBundle(sceneName, null, target);
    }

    static void NewCreateSceneBundle(string sceneName, BuildTarget target)
    {
        string scenePath = "Assets/Scenes/" + sceneName + "/" + sceneName + ".unity";
        CreateSceneBundle(sceneName, scenePath, target);
    }

    [MenuItem(root + "ExhibitionStands")]
    static void CreateExhibitionStandAssetBundle()
    {
        BuildTarget target = GetBuildTarget();
        string outputPath = "";
        if (target == BuildTarget.WebGL)
            outputPath = Application.dataPath + "/SceneAB/WebGL";

        if (target == BuildTarget.iOS)
            outputPath = Application.dataPath + "/SceneAB/iOS";


        if (target == BuildTarget.Android)
            outputPath = Application.dataPath + "/SceneAB/Android";


        if (target == BuildTarget.StandaloneOSX)
            outputPath = Application.dataPath + "/SceneAB/macOS";


        if (target == BuildTarget.StandaloneWindows)
            outputPath = Application.dataPath + "/SceneAB/Windows";

        if (outputPath.Length > 0)
        {
            BuildPipeline.BuildAssetBundles(outputPath, BuildAssetBundleOptions.None, target);
            AssetDatabase.Refresh();
        }

    }

    static void CreateSceneBundle(string sceneName, string scenePath, BuildTarget target)
    {
        Caching.ClearCache();
        string scene = "Assets/Scenes/" + sceneName + ".unity";
        if (scenePath != null)
        {
            scene = scenePath;
        }
        string[] levels = new string[] { scene };
        if (target == BuildTarget.WebGL)
        {
            string path = Application.dataPath + "/SceneAB/WebGL/" + sceneName + ".unity3d";
            BuildPipeline.BuildPlayer(levels, path, BuildTarget.WebGL, BuildOptions.BuildAdditionalStreamedScenes);
            AssetDatabase.Refresh();
        }

        if (target == BuildTarget.iOS)
        {
            string path = Application.dataPath + "/SceneAB/iOS/" + sceneName + ".unity3d";
            BuildPipeline.BuildPlayer(levels, path, BuildTarget.iOS, BuildOptions.BuildAdditionalStreamedScenes);
            AssetDatabase.Refresh();
        }

        if (target == BuildTarget.Android)
        {
            string path = Application.dataPath + "/SceneAB/Android/" + sceneName + ".unity3d";
            BuildPipeline.BuildPlayer(levels, path, BuildTarget.Android, BuildOptions.BuildAdditionalStreamedScenes);
            AssetDatabase.Refresh();
        }

        if (target == BuildTarget.StandaloneOSX)
        {
            string path = Application.dataPath + "/SceneAB/macOS/" + sceneName + ".unity3d";
            BuildPipeline.BuildPlayer(levels, path, BuildTarget.StandaloneOSX, BuildOptions.BuildAdditionalStreamedScenes);
            AssetDatabase.Refresh();
        }

        if (target == BuildTarget.StandaloneWindows)
        {
            string path = Application.dataPath + "/SceneAB/Windows/" + sceneName + ".unity3d";
            BuildPipeline.BuildPlayer(levels, path, BuildTarget.StandaloneWindows, BuildOptions.BuildAdditionalStreamedScenes);
            AssetDatabase.Refresh();
        }

    }

    static void UpdateSelectedState()
    {
        Menu.SetChecked(root + webGLPlatform, selectWebGLPlatform);
        Menu.SetChecked(root + iOSPlatform, selectiOSPlatform);
        Menu.SetChecked(root + AndroidPlatform, selectAndroidPlatform);
        Menu.SetChecked(root + macOSPlatform, selectMacOSPlatform);
        Menu.SetChecked(root + winPlatform, selectWinPlatform);
    }

    static BuildTarget GetBuildTarget()
    {
        if (selectWebGLPlatform)
        {
            return WebGLTarget;
        }
        if (selectiOSPlatform)
        {
            return iOSTarget;
        }
        if (selectAndroidPlatform)
        {
            return AndroidTarget;
        }
        if (selectMacOSPlatform)
        {
            return macOSTarget;
        }
        if (selectWinPlatform)
        {
            return windowsTarget;
        }
        return BuildTarget.NoTarget;
    }


    #region Common
    [MenuItem(root + webGLPlatform, priority = 10)]
    static void webGL_SelectTraget()
    {
        selectWebGLPlatform = true;
        selectiOSPlatform = false;
        selectAndroidPlatform = false;
        selectMacOSPlatform = false;
        selectWinPlatform = false;
        UpdateSelectedState();
    }
    [MenuItem(root + iOSPlatform, priority = 10)]
    static void ios_SelectTraget()
    {
        selectWebGLPlatform = false;
        selectiOSPlatform = true;
        selectAndroidPlatform = false;
        selectMacOSPlatform = false;
        selectWinPlatform = false;
        UpdateSelectedState();
    }
    [MenuItem(root + AndroidPlatform, priority = 10)]
    static void android_SelectTraget()
    {
        selectWebGLPlatform = false;
        selectiOSPlatform = false;
        selectAndroidPlatform = true;
        selectMacOSPlatform = false;
        selectWinPlatform = false;
        UpdateSelectedState();
    }
    [MenuItem(root + macOSPlatform, priority = 10)]
    static void macOS_SelectTraget()
    {
        selectWebGLPlatform = false;
        selectiOSPlatform = false;
        selectAndroidPlatform = false;
        selectMacOSPlatform = true;
        selectWinPlatform = false;
        UpdateSelectedState();
    }
    [MenuItem(root + winPlatform, priority = 10)]
    static void win_SelectTraget()
    {
        selectWebGLPlatform = false;
        selectiOSPlatform = false;
        selectAndroidPlatform = false;
        selectMacOSPlatform = false;
        selectWinPlatform = true;
        UpdateSelectedState();
    }

    [MenuItem(root + generate + officePage + OfficeCommonJ)]
    static void CreateOfficeCommonJBundle()
    {
        NewCreateSceneBundle(OfficeCommonJ, GetBuildTarget());
    }

    #endregion

}
