﻿namespace ModPlus.Helpers
{
    using System;
    using ModPlusAPI;

    /// <summary>
    /// Дополнительные утилиты локализации в контексте Renga
    /// </summary>
    public static class Localization
    {
        private static readonly string LangItem = "RengaDlls";

        /// <summary>
        /// Локализованное название типа объекта Renga
        /// </summary>
        /// <param name="rengaObjectType">Renga object id</param>
        /// <returns></returns>
        public static string RengaObjectType(Guid rengaObjectType)
        {
            if (rengaObjectType == Renga.ObjectTypes.Level)
                return Language.GetItem(LangItem, nameof(Renga.ObjectTypes.Level));
            if (rengaObjectType == Renga.ObjectTypes.Wall)
                return Language.GetItem(LangItem, nameof(Renga.ObjectTypes.Wall));
            if (rengaObjectType == Renga.ObjectTypes.Column)
                return Language.GetItem(LangItem, nameof(Renga.ObjectTypes.Column));
            if (rengaObjectType == Renga.ObjectTypes.Beam)
                return Language.GetItem(LangItem, nameof(Renga.ObjectTypes.Beam));
            if (rengaObjectType == Renga.ObjectTypes.Floor)
                return Language.GetItem(LangItem, nameof(Renga.ObjectTypes.Floor));
            if (rengaObjectType == Renga.ObjectTypes.Opening)
                return Language.GetItem(LangItem, nameof(Renga.ObjectTypes.Opening));
            if (rengaObjectType == Renga.ObjectTypes.Roof)
                return Language.GetItem(LangItem, nameof(Renga.ObjectTypes.Roof));
            if (rengaObjectType == Renga.ObjectTypes.Ramp)
                return Language.GetItem(LangItem, nameof(Renga.ObjectTypes.Ramp));
            if (rengaObjectType == Renga.ObjectTypes.Stair)
                return Language.GetItem(LangItem, nameof(Renga.ObjectTypes.Stair));
            if (rengaObjectType == Renga.ObjectTypes.Door)
                return Language.GetItem(LangItem, nameof(Renga.ObjectTypes.Door));
            if (rengaObjectType == Renga.ObjectTypes.Window)
                return Language.GetItem(LangItem, nameof(Renga.ObjectTypes.Window));
            if (rengaObjectType == Renga.ObjectTypes.Railing)
                return Language.GetItem(LangItem, nameof(Renga.ObjectTypes.Railing));
            if (rengaObjectType == Renga.ObjectTypes.IsolatedFoundation)
                return Language.GetItem(LangItem, nameof(Renga.ObjectTypes.IsolatedFoundation));
            if (rengaObjectType == Renga.ObjectTypes.WallFoundation)
                return Language.GetItem(LangItem, nameof(Renga.ObjectTypes.WallFoundation));
            if (rengaObjectType == Renga.ObjectTypes.Room)
                return Language.GetItem(LangItem, nameof(Renga.ObjectTypes.Room));
            if (rengaObjectType == Renga.ObjectTypes.AssemblyInstance)
                return Language.GetItem(LangItem, nameof(Renga.ObjectTypes.AssemblyInstance));
            if (rengaObjectType == Renga.ObjectTypes.Element)
                return Language.GetItem(LangItem, nameof(Renga.ObjectTypes.Element));
            if (rengaObjectType == Renga.ObjectTypes.RoutePoint)
                return Language.GetItem(LangItem, nameof(Renga.ObjectTypes.RoutePoint));
            if (rengaObjectType == Renga.ObjectTypes.Route)
                return Language.GetItem(LangItem, nameof(Renga.ObjectTypes.Route));
            if (rengaObjectType == Renga.ObjectTypes.PlumbingFixture)
                return Language.GetItem(LangItem, nameof(Renga.ObjectTypes.PlumbingFixture));
            if (rengaObjectType == Renga.ObjectTypes.Equipment)
                return Language.GetItem(LangItem, nameof(Renga.ObjectTypes.Equipment));
            if (rengaObjectType == Renga.ObjectTypes.Pipe)
                return Language.GetItem(LangItem, nameof(Renga.ObjectTypes.Pipe));
            if (rengaObjectType == Renga.ObjectTypes.PipelineAccessory)
                return Language.GetItem(LangItem, nameof(Renga.ObjectTypes.PipelineAccessory));
            if (rengaObjectType == Renga.ObjectTypes.PipeFitting)
                return Language.GetItem(LangItem, nameof(Renga.ObjectTypes.PipeFitting));
            if (rengaObjectType == Renga.ObjectTypes.IfcObject)
                return Language.GetItem(LangItem, nameof(Renga.ObjectTypes.IfcObject));
            if (rengaObjectType == Renga.ObjectTypes.Rebar)
                return Language.GetItem(LangItem, nameof(Renga.ObjectTypes.Rebar));
            if (rengaObjectType == Renga.ObjectTypes.Axis)
                return Language.GetItem(LangItem, nameof(Renga.ObjectTypes.Axis));
            if (rengaObjectType == Renga.ObjectTypes.Section)
                return Language.GetItem(LangItem, nameof(Renga.ObjectTypes.Section));
            if (rengaObjectType == Renga.ObjectTypes.Elevation)
                return Language.GetItem(LangItem, nameof(Renga.ObjectTypes.Elevation));
            if (rengaObjectType == Renga.ObjectTypes.Plate)
                return Language.GetItem(LangItem, nameof(Renga.ObjectTypes.Plate));

            return Language.GetItem(LangItem, nameof(Renga.ObjectTypes.Undefined));
        }
    }
}
