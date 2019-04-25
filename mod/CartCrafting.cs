namespace Eco.Mods.TechTree
{
    using System;
    using System.Collections.Generic;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.Components.Auth;
    using Eco.Gameplay.Components.VehicleModules;
    using Eco.Gameplay.DynamicValues;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Objects;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Skills;
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Shared.Math;
    using Eco.Shared.Networking;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;

    [RequireComponent(typeof(CraftingComponent))]
    public partial class WoodCartObject : PhysicsWorldObject, IRepresentsItem
    { }

    [RequireComponent(typeof(CraftingComponent))]
    public partial class SteamTruckObject : PhysicsWorldObject, IRepresentsItem
    { }

    [RequireComponent(typeof(CraftingComponent))]
    public partial class PoweredCartObject : PhysicsWorldObject, IRepresentsItem
    { }

    [RequireComponent(typeof(CraftingComponent))]
    public partial class TruckObject : PhysicsWorldObject, IRepresentsItem
    { }

    [RequireComponent(typeof(CraftingComponent))]
    public partial class SmallWoodCartObject : PhysicsWorldObject, IRepresentsItem
    { }
}