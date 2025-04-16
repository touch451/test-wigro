using UnityEngine;

public static class DeviceUtils
{
    public static bool IsTablet()
    {
        return GetTabletType() != TabletType.None;
    }

    public static bool IsTablet(out TabletType tabletType)
    {
        tabletType = GetTabletType();
        return tabletType != TabletType.None;
    }

    private static TabletType GetTabletType()
    {
        float aspectRatio = Screen.orientation == ScreenOrientation.Portrait
            ? (float)Screen.width / Screen.height
            : Screen.height / (float)Screen.width;

        if (aspectRatio > 0.58f && aspectRatio < 0.65f)
        {
            return TabletType.Slim;
        }

        if (aspectRatio >= 0.65f)
        {
            return TabletType.Wide;
        }

        return TabletType.None;
    }

    public enum TabletType
    {
        None,
        Wide,
        Slim
    }
}
