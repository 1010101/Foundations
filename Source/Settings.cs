// Game Settings (Settings.cs) 1.0.0.0
// Foundations (FND)
// created: 
// updated: 30 Aug 2021

using System;
using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using System.Reflection;
using KSP.Localization;

// This will add a tab to the Stock Settings in the Difficulty settings called "Foundations"
// To use, reference the setting using the following:
//
//  HighLogic.CurrentGame.Parameters.CustomParams<Foundations_Options>().needsECtoStart
//
// As it is set up, the option is disabled, so in order to enable it, the player would have
// to deliberately go in and change it
//
namespace Foundations
{

    /// <summary>Game Settings</summary>
    /// http://forum.kerbalspaceprogram.com/index.php?/topic/147576-modders-notes-for-ksp-12/#comment-2754813
    /// search for "Mod integration into Stock Settings
    /// <seealso cref="GameParameters.CustomParameterNode" />
    public class Foundations_Options : GameParameters.CustomParameterNode
    {
        /// <summary>Game Settings: Title</summary>
        public override string Title { get { return "#FND-Title"; } }
        /// <summary>Game Settings: GameMode </summary>
        public override GameParameters.GameMode GameMode { get { return GameParameters.GameMode.ANY; } }
        /// <summary>Game Settings: Section (name) </summary>
        public override string Section { get { return "#FND-Settings-Section"; } }
        /// <summary>Game Settings: DisplaySection (name)</summary>
        public override string DisplaySection { get { return "#FND-Settings-DisplaySection"; } }
        /// <summary>Game Settings: SectionOrder (1)</summary>
        public override int SectionOrder { get { return 1; } }
        /// <summary>Game Settings: HasPresets (false)</summary>
        public override bool HasPresets { get { return false; } }

        // Config Settings
        /// <summary>FoundationsXDebug = false
        /// tells module if it is to record extra debug information in game log. (KSP.log)/// </summary>
        [GameParameters.CustomParameterUI("#FND-Settings-S01", toolTip = "#FND-Settings-S01-Tip", newGameOnly = false, unlockedDuringMission = true)]
        public bool foundationsXDebug = false;

        /// <summary>FoundationsXDebug</summary>
        // public bool FoundationsXDebug { get => foundationsXDebug; set => foundationsXDebug = value; }

        /// <summary>Tells module if it is allowed to use colors in the RMB/PAW</summary>
        [GameParameters.CustomParameterUI("#FND-Settings-S02", toolTip = "#FND-Settings-S02-Tip", newGameOnly = false, unlockedDuringMission = true)]
        public bool coloredPAW = true;

        /// <summary>ColoredPAW</summary>
        //public bool ColoredPAW { get => coloredPAW; set => coloredPAW = value; }


        //public override void SetDifficultyPreset(GameParameters.Preset preset) { }

        //public override bool Enabled(MemberInfo member, GameParameters parameters) { return true; }
        //public override bool Interactible(MemberInfo member, GameParameters parameters) { return true; }
        //public override IList ValidValues(MemberInfo member) { return null; }
    }
}

