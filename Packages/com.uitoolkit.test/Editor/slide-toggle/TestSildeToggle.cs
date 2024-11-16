using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

//public class TestSildeToggle : MonoBehaviour
//{
//    // Start is called before the first frame update
//    void Start()
//    {

//    }

//    // Update is called once per frame
//    void Update()
//    {

//    }
//}

public class testWindow : EditorWindow
{
    [MenuItem("Window/Custom UI Window %&Q")]
    public static void ShowWindow()
    {
        // ´ò¿ª´°¿Ú
        var window = GetWindow<testWindow>();
        window.titleContent = new GUIContent("Custom UI Window");
        window.minSize = new Vector2(300, 200);
        window.Show();
    }

    private void OnEnable()
    {
        var visualTreeAsset = Resources.Load<VisualTreeAsset>("slide-toggle/SlideToggleUsage");
        visualTreeAsset.CloneTree(rootVisualElement);

        //rootVisualElement.Add(visualTreeAsset);
    }
}
