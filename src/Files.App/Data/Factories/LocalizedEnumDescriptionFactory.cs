﻿// Copyright (c) Files Community
// Licensed under the MIT License.

namespace Files.App.Data.Factories
{
	/// <summary>
	/// Generates localization description for an enum value.
	/// </summary>
	internal static class LocalizedEnumDescriptionFactory
	{
		private static Dictionary<DetailsViewSizeKind, string> DetailsViewSizeKinds { get; } = [];
		private static Dictionary<ListViewSizeKind, string> ListViewSizeKinds { get; } = [];
		private static Dictionary<CardsViewSizeKind, string> CardViewSizeKinds { get; } = [];
		private static Dictionary<GridViewSizeKind, string> GridViewSizeKinds { get; } = [];
		private static Dictionary<ColumnsViewSizeKind, string> ColumnsViewSizeKinds { get; } = [];

		public static string Get(DetailsViewSizeKind value)
		{
			if (DetailsViewSizeKinds.Count == 0)
			{
				DetailsViewSizeKinds.Add(DetailsViewSizeKind.Compact, "Compact".GetLocalizedResource());
				DetailsViewSizeKinds.Add(DetailsViewSizeKind.Small, "Small".GetLocalizedResource());
				DetailsViewSizeKinds.Add(DetailsViewSizeKind.Medium, "Medium".GetLocalizedResource());
				DetailsViewSizeKinds.Add(DetailsViewSizeKind.Large, "Large".GetLocalizedResource());
				DetailsViewSizeKinds.Add(DetailsViewSizeKind.ExtraLarge, "ExtraLarge".GetLocalizedResource());
			}

			var stringValue = DetailsViewSizeKinds.GetValueOrDefault(value)!;
			return stringValue;
		}

		public static string Get(ListViewSizeKind value)
		{
			if (ListViewSizeKinds.Count == 0)
			{
				ListViewSizeKinds.Add(ListViewSizeKind.Compact, "Compact".GetLocalizedResource());
				ListViewSizeKinds.Add(ListViewSizeKind.Small, "Small".GetLocalizedResource());
				ListViewSizeKinds.Add(ListViewSizeKind.Medium, "Medium".GetLocalizedResource());
				ListViewSizeKinds.Add(ListViewSizeKind.Large, "Large".GetLocalizedResource());
				ListViewSizeKinds.Add(ListViewSizeKind.ExtraLarge, "ExtraLarge".GetLocalizedResource());
			}

			var stringValue = ListViewSizeKinds.GetValueOrDefault(value)!;
			return stringValue;
		}

		public static string Get(CardsViewSizeKind value)
		{
			if (CardViewSizeKinds.Count == 0)
			{
				CardViewSizeKinds.Add(CardsViewSizeKind.Small, Strings.Small.GetLocalizedResource());
				CardViewSizeKinds.Add(CardsViewSizeKind.Medium, Strings.Medium.GetLocalizedResource());
				CardViewSizeKinds.Add(CardsViewSizeKind.Large, Strings.Large.GetLocalizedResource());
				CardViewSizeKinds.Add(CardsViewSizeKind.ExtraLarge, Strings.ExtraLarge.GetLocalizedResource());
			}

			var stringValue = CardViewSizeKinds.GetValueOrDefault(value)!;
			return stringValue;
		}

		public static string Get(GridViewSizeKind value)
		{
			if (GridViewSizeKinds.Count == 0)
			{
				GridViewSizeKinds.Add(GridViewSizeKind.Small, "Small".GetLocalizedResource());
				GridViewSizeKinds.Add(GridViewSizeKind.Medium, "Medium".GetLocalizedResource());
				GridViewSizeKinds.Add(GridViewSizeKind.Three, "Medium+".GetLocalizedResource());
				GridViewSizeKinds.Add(GridViewSizeKind.Four, "Medium++".GetLocalizedResource());
				GridViewSizeKinds.Add(GridViewSizeKind.Five, "Medium+++".GetLocalizedResource());
				GridViewSizeKinds.Add(GridViewSizeKind.Six, "Medium++++".GetLocalizedResource());
				GridViewSizeKinds.Add(GridViewSizeKind.Seven, "Medium+++++".GetLocalizedResource());
				GridViewSizeKinds.Add(GridViewSizeKind.Large, "Large".GetLocalizedResource());
				GridViewSizeKinds.Add(GridViewSizeKind.Nine, "Large+".GetLocalizedResource());
				GridViewSizeKinds.Add(GridViewSizeKind.Ten, "Large++".GetLocalizedResource());
				GridViewSizeKinds.Add(GridViewSizeKind.Eleven, "Large+++".GetLocalizedResource());
				GridViewSizeKinds.Add(GridViewSizeKind.ExtraLarge, "ExtraLarge".GetLocalizedResource());
			}

			var stringValue = GridViewSizeKinds.GetValueOrDefault(value)!;
			return stringValue;
		}

		public static string Get(ColumnsViewSizeKind value)
		{
			if (ColumnsViewSizeKinds.Count == 0)
			{
				ColumnsViewSizeKinds.Add(ColumnsViewSizeKind.Compact, "Compact".GetLocalizedResource());
				ColumnsViewSizeKinds.Add(ColumnsViewSizeKind.Small, "Small".GetLocalizedResource());
				ColumnsViewSizeKinds.Add(ColumnsViewSizeKind.Medium, "Medium".GetLocalizedResource());
				ColumnsViewSizeKinds.Add(ColumnsViewSizeKind.Large, "Large".GetLocalizedResource());
				ColumnsViewSizeKinds.Add(ColumnsViewSizeKind.ExtraLarge, "ExtraLarge".GetLocalizedResource());
			}

			var stringValue = ColumnsViewSizeKinds.GetValueOrDefault(value)!;
			return stringValue;
		}
	}
}
