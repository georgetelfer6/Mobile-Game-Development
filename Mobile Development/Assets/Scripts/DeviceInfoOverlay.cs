using UnityEngine;

public class DeviceInfoOverlay : MonoBehaviour
{
    float smoothedDelta = 1f / 30f;
    GUIStyle style;

    void Awake()
    {
        Application.targetFrameRate = 60;
    }

    void Update()
    {
    }

    void OnGUI()

    {
        if (style == null)
        {
            style = new GUIStyle(GUI.skin.box);
            style.alignment = TextAnchor.UpperLeft;
            style.normal.textColor = Color.white;
            style.fontSize = 40;
        }
        float fps = 1f / smoothedDelta;
        string gpuName = SystemInfo.graphicsDeviceName;
        float gpuMemory = SystemInfo.graphicsMemorySize;
        float systemMemory = SystemInfo.systemMemorySize;
        string deviceModel = SystemInfo.deviceModel;
        float dpi = Screen.dpi;
        string info = $"FPS: {fps:0}\n" + $"GPU: {gpuName}\n" + $"GPU Memory: {gpuMemory} MB\n" + $"DeviceModel: {deviceModel}\n" + $"RAM: {systemMemory / 1000}GB\n" + $"DPI: {dpi}\n" + $"Refresh Rate: {Screen.currentResolution.refreshRateRatio}Hz";

        Vector2 size = style.CalcSize(new GUIContent(info));
        GUI.Label(new Rect(40, 40, size.x + 20, size.y + 20), info, style);
    }
}