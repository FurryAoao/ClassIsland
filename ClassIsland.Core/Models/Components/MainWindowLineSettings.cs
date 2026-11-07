using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Avalonia.Media;
using ClassIsland.Core.Abstractions.Models.Components;
using ClassIsland.Core.Enums;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ClassIsland.Core.Models.Components;

/// <summary>
/// 代表主界面行的配置
/// </summary>
public partial class MainWindowLineSettings : ObservableObject, IMainWindowCustomizableNodeSettings
{
    /// <summary>
    /// 主界面行包含的组件列表
    /// </summary>
    [ObservableProperty] private ObservableCollection<ComponentSettings> _children = [];

    /// <summary>
    /// 是否为主要行
    /// </summary>
    [ObservableProperty] private bool _isMainLine = false;

    /// <summary>
    /// 是否启用提醒
    /// </summary>
    [ObservableProperty] private bool _isNotificationEnabled = true;
    
    [ObservableProperty] private bool _isResourceOverridingEnabled;
    [ObservableProperty] private double _mainWindowSecondaryFontSize = 14;
    [ObservableProperty] private double _mainWindowBodyFontSize = 16;
    [ObservableProperty] private double _mainWindowEmphasizedFontSize = 18;
    [ObservableProperty] private double _mainWindowLargeFontSize = 20;
    [ObservableProperty] private bool _isCustomForegroundColorEnabled;
    [ObservableProperty] private Color _foregroundColor = Colors.DodgerBlue;
    [ObservableProperty] private double _backgroundOpacity = 0.5;
    [ObservableProperty] private bool _isCustomBackgroundOpacityEnabled;
    [ObservableProperty] private Color _backgroundColor = Colors.Black;
    [ObservableProperty] private bool _isCustomBackgroundColorEnabled;
    [ObservableProperty] private double _customCornerRadius;
    [ObservableProperty] private bool _isCustomCornerRadiusEnabled;
    [ObservableProperty] private double _opacity = 1.0;
    
    [ObservableProperty] private bool _isVisible = true;
    [ObservableProperty] private bool _hideOnRule = false;
    [ObservableProperty] private Ruleset.Ruleset _hidingRules = new();
    /// <summary>
    /// 0 - 默认;1 - 禁用;2 - 启用
    /// </summary>
    [ObservableProperty] private int _islandSeparationMode = 0;

    /// <summary>
    /// 临时栏模式。启用后，此主界面行只会在指定的时间状态下显示。
    /// </summary>
    [ObservableProperty] private LineTimeStateVisibility _temporaryLineVisibility = LineTimeStateVisibility.Always;

    /// <summary>
    /// 当前是否因为临时栏模式而被隐藏。此属性仅用于界面反馈，不参与持久化。
    /// </summary>
    [property: JsonIgnore]
    [ObservableProperty] private bool _isHiddenByTemporaryLineMode = false;
}