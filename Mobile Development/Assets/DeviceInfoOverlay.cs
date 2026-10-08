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

        // TODO: blend Time.unscaledDeltaTime into smoothedDelta
        // so that the FPS figure does not flicker every frame.
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

        // TODO: a fixed font size is unreadable on a high-DPI phone.
        // Set style.fontSize relative to Screen.height instead.
        string info = $"FPS: {fps:0}\n" + $"GPU: {gpuName}\n" + $"GPU Memory: {gpuMemory} MB\n" + $"DeviceModel: {deviceModel}\n" + $"RAM: {systemMemory / 1000}GB\n" + $"DPI: {dpi}\n" + $"Refresh Rate: {Screen.currentResolution.refreshRateRatio}Hz";


        // TODO: append device model, operating system, resolution,
        // refresh rate, DPI, GPU name, graphics memory and system memory.

        Vector2 size = style.CalcSize(new GUIContent(info));
        GUI.Label(new Rect(40, 40, size.x + 20, size.y + 20), info, style);
    }
}