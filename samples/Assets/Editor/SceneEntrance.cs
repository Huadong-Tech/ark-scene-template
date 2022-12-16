using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;


namespace OfficeOnline
{
    public class SceneEntrance
    {
        private const string path_1 = "Assets/Scenes/";                 // Scenes文件夹路径_1
        private const string path_2 = "Assets/U3DModule/Scene/";        // Scenes文件夹路径_2
        private const string menuItem = "SceneEntrance/";          // 菜单名
        private const string suffix = ".unity";                    // 后缀名


        /// 百人办公
        private const string OfficeCommonJ = "OfficeCommonJ";

        /// === 大分类 路径 ===
        /// 通用办公
        private const string menu_commonOffice = "Office/";
    
        /// === 场景 菜单路径 ===

        /// 百人办公
        private const string menu_OfficeCommonJ = menuItem + menu_commonOffice + OfficeCommonJ;
        
        /// 百人办公
        [MenuItem(menu_OfficeCommonJ)]
        private static void StartHundredOffice()
        {
            OpenScene_new(OfficeCommonJ);
        }

        private static void OpenScene_withPath(string path, string sceneString)
        {
            Save();
            EditorSceneManager.OpenScene(path + sceneString + suffix);
        }

        private static void OpenScene_old(string sceneString)
        {
            Save();
            EditorSceneManager.OpenScene(path_1 + sceneString + suffix);
        }

        private static void OpenScene_new(string sceneString)
        {
            Save();
            EditorSceneManager.OpenScene(path_1 + sceneString + "/" + sceneString + suffix);
        }

        private static void Save()
        {
            EditorSceneManager.SaveScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene());
        }
    }
}
