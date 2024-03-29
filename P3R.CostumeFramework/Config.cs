﻿using P3R.CostumeFramework.Template.Configuration;
using P3R.CostumeFramework.Types;
using System.ComponentModel;

namespace P3R.CostumeFramework.Configuration;

public class Config : Configurable<Config>
{
    [DisplayName("Log Level")]
    [DefaultValue(LogLevel.Information)]
    public LogLevel LogLevel { get; set; } = LogLevel.Information;

    [DisplayName("Extra Costumes")]
    [Description("Adds existing game files as new costumes.\nMay or may not cause visual bugs or crashes.")]
    [DefaultValue(true)]
    public bool ExtraCostumes { get; set; } = true;

    [Category("Integrations")]
    [DisplayName("BGME Framework")]
    [DefaultValue(true)]
    public bool Integration_BGME { get; set; } = true;

    [Category("Integrations")]
    [DisplayName("BGME Battle Themes")]
    [DefaultValue(true)]
    public bool Integration_BattleThemes { get; set; } = true;

    [DisplayName("Current Party BGM Only")]
    [Description("Whether to limit costume BGM to only members in the current party.\nPlayer and Fuuka's costume BGM is always enabled.")]
    [DefaultValue(true)]
    public bool CurrentPartyBgmOnly { get; set; } = true;

    [DisplayName("Randomize Costumes")]
    [Description("This enables randomization globally, including the overworld.")]
    [DefaultValue(false)]
    public bool RandomizeCostumes { get; set; } = false;

    [DisplayName("Costume Filter")]
    [Description("Filter out costumes in the game/randomization.")]
    [DefaultValue(CostumeFilter.None)]
    public CostumeFilter CostumeFilter { get; set; } = CostumeFilter.None;
}

/// <summary>
/// Allows you to override certain aspects of the configuration creation process (e.g. create multiple configurations).
/// Override elements in <see cref="ConfiguratorMixinBase"/> for finer control.
/// </summary>
public class ConfiguratorMixin : ConfiguratorMixinBase
{
    // 
}