namespace Eco.Mods.TechTree
{
    using System;
    using System.Collections.Generic;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.DynamicValues;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Skills;
    using Eco.Shared.Utils;
    using Eco.World;
    using Eco.World.Blocks;
    using Gameplay.Systems.TextLinks;
    using Eco.Shared.Localization;

    public class CartProcessLimestoneRecipe : Recipe {
        public CartProcessLimestoneRecipe() {
            this.Products = new CraftingElement[] {
               new CraftingElement<StoneItem>(1f)
            };
            this.Ingredients = new CraftingElement[] {
                new CraftingElement<LimestoneItem>(1)
            };
            this.Initialize(Localizer.DoStr("Process Limestone"), typeof(CartProcessLimestoneRecipe));
            this.CraftMinutes = new ConstantValue(0.04f);
            CraftingComponent.AddRecipe(typeof(WoodCartObject), this);
            CraftingComponent.AddRecipe(typeof(SmallWoodCartObject), this);
            CraftingComponent.AddRecipe(typeof(TruckObject), this);
            CraftingComponent.AddRecipe(typeof(SteamTruckObject), this);
            CraftingComponent.AddRecipe(typeof(PoweredCartObject), this);
        }
    }

    public class CartProcessGraniteRecipe : Recipe {
        public CartProcessGraniteRecipe() {
            this.Products = new CraftingElement[] {
               new CraftingElement<StoneItem>(1f)
            };
            this.Ingredients = new CraftingElement[] {
                new CraftingElement<GraniteItem>(1)
            };
            this.Initialize(Localizer.DoStr("Process Granite"), typeof(CartProcessGraniteRecipe));
            this.CraftMinutes = new ConstantValue(0.04f);
            CraftingComponent.AddRecipe(typeof(WoodCartObject), this);
            CraftingComponent.AddRecipe(typeof(SmallWoodCartObject), this);
            CraftingComponent.AddRecipe(typeof(TruckObject), this);
            CraftingComponent.AddRecipe(typeof(SteamTruckObject), this);
            CraftingComponent.AddRecipe(typeof(PoweredCartObject), this);
        }
    }

    public class CartProcessGneissRecipe : Recipe {
        public CartProcessGneissRecipe() {
            this.Products = new CraftingElement[] {
               new CraftingElement<StoneItem>(1f)
            };
            this.Ingredients = new CraftingElement[] {
                new CraftingElement<GneissItem>(1)
            };
            this.Initialize(Localizer.DoStr("Process Gneiss"), typeof(CartProcessGneissRecipe));
            this.CraftMinutes = new ConstantValue(0.04f);
            CraftingComponent.AddRecipe(typeof(WoodCartObject), this);
            CraftingComponent.AddRecipe(typeof(SmallWoodCartObject), this);
            CraftingComponent.AddRecipe(typeof(TruckObject), this);
            CraftingComponent.AddRecipe(typeof(SteamTruckObject), this);
            CraftingComponent.AddRecipe(typeof(PoweredCartObject), this);
        }
    }

    public class CartProcessBasaltRecipe : Recipe {
        public CartProcessBasaltRecipe() {
            this.Products = new CraftingElement[] {
               new CraftingElement<StoneItem>(1f)
            };
            this.Ingredients = new CraftingElement[] {
                new CraftingElement<BasaltItem>(1)
            };
            this.Initialize(Localizer.DoStr("Process Basalt"), typeof(CartProcessBasaltRecipe));
            this.CraftMinutes = new ConstantValue(0.04f);
            CraftingComponent.AddRecipe(typeof(WoodCartObject), this);
            CraftingComponent.AddRecipe(typeof(SmallWoodCartObject), this);
            CraftingComponent.AddRecipe(typeof(TruckObject), this);
            CraftingComponent.AddRecipe(typeof(SteamTruckObject), this);
            CraftingComponent.AddRecipe(typeof(PoweredCartObject), this);
        }
    }

    public class CartProcessShaleRecipe : Recipe {
        public CartProcessShaleRecipe() {
            this.Products = new CraftingElement[] {
               new CraftingElement<StoneItem>(1f)
            };
            this.Ingredients = new CraftingElement[] {
                new CraftingElement<ShaleItem>(1)
            };
            this.Initialize(Localizer.DoStr("Process Shale"), typeof(CartProcessShaleRecipe));
            this.CraftMinutes = new ConstantValue(0.04f);
            CraftingComponent.AddRecipe(typeof(WoodCartObject), this);
            CraftingComponent.AddRecipe(typeof(SmallWoodCartObject), this);
            CraftingComponent.AddRecipe(typeof(TruckObject), this);
            CraftingComponent.AddRecipe(typeof(SteamTruckObject), this);
            CraftingComponent.AddRecipe(typeof(PoweredCartObject), this);
        }
    }

    public class CartProcessSandstoneRecipe : Recipe
    {
        public CartProcessSandstoneRecipe() {
            this.Products = new CraftingElement[] {
               new CraftingElement<StoneItem>(1f),
            };
            this.Ingredients = new CraftingElement[] {
                new CraftingElement<SandstoneItem>(1)
            };
            this.Initialize(Localizer.DoStr("Process Sandstone"), typeof(CartProcessSandstoneRecipe));
            this.CraftMinutes = new ConstantValue(0.04f);
            CraftingComponent.AddRecipe(typeof(WoodCartObject), this);
            CraftingComponent.AddRecipe(typeof(SmallWoodCartObject), this);
            CraftingComponent.AddRecipe(typeof(TruckObject), this);
            CraftingComponent.AddRecipe(typeof(SteamTruckObject), this);
            CraftingComponent.AddRecipe(typeof(PoweredCartObject), this);
        }
    }
}