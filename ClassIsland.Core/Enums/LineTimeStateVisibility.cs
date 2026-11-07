namespace ClassIsland.Core.Enums;

/// <summary>
/// 主界面行的时间状态可见性模式。
/// </summary>
public enum LineTimeStateVisibility
{
    /// <summary>
    /// 始终显示。
    /// </summary>
    Always,
    /// <summary>
    /// 仅在上课时显示。
    /// </summary>
    OnClassOnly,
    /// <summary>
    /// 仅在课间休息时显示。
    /// </summary>
    BreakingOnly
}
