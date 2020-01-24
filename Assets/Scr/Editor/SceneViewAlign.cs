using UnityEngine;
using UnityEditor;

public class SceneViewAlign : MonoBehaviour
{
    [MenuItem("Editor/Set Scene View %h")]
    static void SetSceneViewAlign()
    {
        Transform cam = Camera.main.transform;
        var sceneView = SceneView.lastActiveSceneView;
        if (sceneView != null) {
            sceneView.AlignViewToObject(cam);
            sceneView.orthographic = false;
        }

    }
}
