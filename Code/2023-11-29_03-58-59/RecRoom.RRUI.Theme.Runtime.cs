using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RRUI.Theme;
using RecRoom.Audio;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RRUI
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class FontsConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		public struct LocalizedFontMaterialOverrideMapping
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public Material NonLocalizedFontOverrideMaterial;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public Material LocalizedFontOverrideMaterial;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		public struct LocalizedFontMapping
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public TMP_FontAsset FontAsset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public TMP_FontAsset LocalizedFontAsset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public LocalizedFontMaterialOverrideMapping[] FontOverrideMaterials;
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class EFGNPPJCEIC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public TMP_FontAsset font;

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
			public EFGNPPJCEIC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x64E7DE0", Offset = "0x64E71E0", VA = "0x1864E7DE0")]
			internal bool HDFJGEJFEHG(LocalizedFontMapping x)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static FontsConfig _instance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		[Tooltip("Mapping of non-localized font assets to their localized counterparts. By default text fields will forcibly revert to non-localized fonts unless the `AllowsNonLatinCharacters` component is present.")]
		private LocalizedFontMapping[] localizedFontMappings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[SerializeField]
		[Tooltip("Emoji asset to use when text fields mark themselves as allowing emoji using the `AllowsEmojis` component.")]
		private TMP_SpriteAsset emojiAsset;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static FontsConfig Instance
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x64E8740", Offset = "0x64E7B40", VA = "0x1864E8740")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public TMP_SpriteAsset EmojiAsset
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x775A80", Offset = "0x774E80", VA = "0x180775A80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x64E8270", Offset = "0x64E7670", VA = "0x1864E8270")]
		public bool FOJEILAHDBP(TMP_FontAsset EKGIDHMIEFB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x64E85E0", Offset = "0x64E79E0", VA = "0x1864E85E0")]
		public TMP_FontAsset OIMDPJCBFBP(TMP_FontAsset EKGIDHMIEFB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x64E83A0", Offset = "0x64E77A0", VA = "0x1864E83A0")]
		public TMP_FontAsset OIMDPJCBFBP(TMP_FontAsset EKGIDHMIEFB, Material CDIMKAGOBHN, [Out] Material PCDMHKPIBNH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x64E7E60", Offset = "0x64E7260", VA = "0x1864E7E60")]
		public TMP_FontAsset CNPNBNAGIOA(TMP_FontAsset EKGIDHMIEFB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x64E7FC0", Offset = "0x64E73C0", VA = "0x1864E7FC0")]
		public TMP_FontAsset CNPNBNAGIOA(TMP_FontAsset EKGIDHMIEFB, Material CDIMKAGOBHN, [Out] Material ODAEPEDMNJG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x64E81C0", Offset = "0x64E75C0", VA = "0x1864E81C0")]
		private static bool EKNCOFIMBHO(TMP_FontAsset EKGIDHMIEFB, LocalizedFontMapping ANBFABNLOLH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7F6AC0", Offset = "0x7F5EC0", VA = "0x1807F6AC0")]
		public FontsConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class ThemesConfig : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static ThemesConfig _instance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[SerializeField]
		private Palette _light;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[SerializeField]
		private Palette _dark;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static ThemesConfig Instance
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x64F30A0", Offset = "0x64F24A0", VA = "0x1864F30A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Palette Active
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x64F3070", Offset = "0x64F2470", VA = "0x1864F3070")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7F6AC0", Offset = "0x7F5EC0", VA = "0x1807F6AC0")]
		public ThemesConfig()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct GradientBlock : IEquatable<GradientBlock>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		public Gradient normalGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[SerializeField]
		public Gradient highlightedGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[SerializeField]
		public Gradient pressedGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[SerializeField]
		public Gradient selectedGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[SerializeField]
		public Gradient disabledGradient;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x64E8900", Offset = "0x64E7D00", VA = "0x1864E8900", Slot = "0")]
		public override bool Equals(object ECLCDMJMICA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x64E88A0", Offset = "0x64E7CA0", VA = "0x1864E88A0", Slot = "4")]
		public bool Equals(GradientBlock LFMLAKDHEFO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x64E89E0", Offset = "0x64E7DE0", VA = "0x1864E89E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class MultiGraphicButton : Button
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[SerializeField]
		private List<Graphic> additionalGraphics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[SerializeField]
		private ColorBlock additionalGraphicsColors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		private UIGradient backgroundGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[SerializeField]
		private GradientBlock backgroundGradients;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[SerializeField]
		private bool rejectSelectedState;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public List<Graphic> PFDNOLINFLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x848F80", Offset = "0x848380", VA = "0x180848F80")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x964420", Offset = "0x963820", VA = "0x180964420")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public ColorBlock EMNMLHJOING
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x64EAB70", Offset = "0x64E9F70", VA = "0x1864EAB70")]
			get
			{
				return default(ColorBlock);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x64EABF0", Offset = "0x64E9FF0", VA = "0x1864EABF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public UIGradient HJIKDHAAFNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x964240", Offset = "0x963640", VA = "0x180964240")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x9644C0", Offset = "0x9638C0", VA = "0x1809644C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public GradientBlock EFNEPCHABNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x64EABC0", Offset = "0x64E9FC0", VA = "0x1864EABC0")]
			get
			{
				return default(GradientBlock);
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x64EAC40", Offset = "0x64EA040", VA = "0x1864EAC40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x64EA990", Offset = "0x64E9D90", VA = "0x1864EA990", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x64EA9E0", Offset = "0x64E9DE0", VA = "0x1864EA9E0", Slot = "36")]
		public override void OnSelect(BaseEventData LHEBENHACBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x64EAA30", Offset = "0x64E9E30", VA = "0x1864EAA30")]
		public void Refresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x64EA860", Offset = "0x64E9C60", VA = "0x1864EA860")]
		public void ForceHighlighted(bool BGJDEHJHHEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x64EA880", Offset = "0x64E9C80", VA = "0x1864EA880")]
		public void ForceNormal(bool BGJDEHJHHEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x64EA400", Offset = "0x64E9800", VA = "0x1864EA400", Slot = "26")]
		protected override void DoStateTransition(SelectionState IFHMBCKBKKK, bool BGJDEHJHHEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x64EA8A0", Offset = "0x64E9CA0", VA = "0x1864EA8A0")]
		private void NGDOJKHIENN(Graphic JLGOOFFEPAC, Color BMMEPPIBFGI, bool BGJDEHJHHEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x64EA760", Offset = "0x64E9B60", VA = "0x1864EA760")]
		private void FEJJOFHCAEC(SelectionState IFHMBCKBKKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x64EAA60", Offset = "0x64E9E60", VA = "0x1864EAA60")]
		public MultiGraphicButton()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum PMNDCFNODBE
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	Negative = 1,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	SelectPrimary = 2,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	SelectSidebar = 12,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	SelectCardToggle = 14,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	SelectSidebarInactive = 17,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	ToggleOnSwitch = 18,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	ToggleOffSwitch = 19,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	ToggleChip = 20,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	SliderDefault = 21
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum EJKOMFHKOCA
{
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Default
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public enum HIAKPIBIBCP
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	Default
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum JFDKCMOBHFF
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	Default
}
namespace RRUI.Theme
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class AudioPalette : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public class ButtonAudioPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			[SerializeField]
			private PMNDCFNODBE buttonAudioPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			[SerializeField]
			private ButtonAudioPaletteAsset buttonAudioPaletteConfig;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public PMNDCFNODBE ButtonAudioPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x770180", Offset = "0x76F580", VA = "0x180770180")]
				get
				{
					return default(PMNDCFNODBE);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public ButtonAudioPaletteAsset ButtonAudioPaletteConfig
			{
				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
			public ButtonAudioPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public class ScrollingAudioPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			[SerializeField]
			private EJKOMFHKOCA scrollingAudioPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			[SerializeField]
			private ScrollingAudioPaletteAsset scrollingAudioPaletteConfig;

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public EJKOMFHKOCA ScrollingAudioPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0x770180", Offset = "0x76F580", VA = "0x180770180")]
				get
				{
					return default(EJKOMFHKOCA);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public ScrollingAudioPaletteAsset ScrollingAudioPaletteConfig
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
			public ScrollingAudioPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public class ContentLoadingAudioPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			[SerializeField]
			private HIAKPIBIBCP contentLoadingAudioPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			[SerializeField]
			private ContentLoadingAudioPaletteAsset contentLoadingAudioPaletteConfig;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public HIAKPIBIBCP ContentLoadingAudioPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x770180", Offset = "0x76F580", VA = "0x180770180")]
				get
				{
					return default(HIAKPIBIBCP);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public ContentLoadingAudioPaletteAsset ContentLoadingAudioPaletteConfig
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
			public ContentLoadingAudioPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public class RecyclingAudioPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			[SerializeField]
			private JFDKCMOBHFF recyclingAudioPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			[SerializeField]
			private RecyclingAudioPaletteAsset recyclingAudioPaletteConfig;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public JFDKCMOBHFF RecyclingAudioPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x770180", Offset = "0x76F580", VA = "0x180770180")]
				get
				{
					return default(JFDKCMOBHFF);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public RecyclingAudioPaletteAsset RecyclingAudioPaletteConfig
			{
				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
			public RecyclingAudioPaletteItem()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class CPGMNNMLHAM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public PMNDCFNODBE buttonAudioPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
			public CPGMNNMLHAM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xDA1800", Offset = "0xDA0C00", VA = "0x180DA1800")]
			internal bool MBDHGKAOIOO(ButtonAudioPaletteItem buttonAudioPalette)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class FOHCLJFBCEG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public EJKOMFHKOCA scrollingAudioPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
			public FOHCLJFBCEG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xDA1800", Offset = "0xDA0C00", VA = "0x180DA1800")]
			internal bool PCILNANMLNF(ScrollingAudioPaletteItem scrollingAudioPalette)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class FCBNLAJOBCM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public HIAKPIBIBCP contentLoadingAudioPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
			public FCBNLAJOBCM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xDA1800", Offset = "0xDA0C00", VA = "0x180DA1800")]
			internal bool BAAAOJNEHFO(ContentLoadingAudioPaletteItem contentLoadingAudioPalette)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class ICPIGDGIFHI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public JFDKCMOBHFF recyclingAudioPaletteType;

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
			public ICPIGDGIFHI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xDA1800", Offset = "0xDA0C00", VA = "0x180DA1800")]
			internal bool GDLAEMGDGPB(RecyclingAudioPaletteItem recyclingAudioPalette)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[SerializeField]
		[LPIDDMIOHNO("ButtonAudioPaletteType")]
		private ButtonAudioPaletteItem[] buttonAudioPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[SerializeField]
		[LPIDDMIOHNO("ScrollingAudioPaletteType")]
		private ScrollingAudioPaletteItem[] scrollingAudioPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[SerializeField]
		[LPIDDMIOHNO("ContentLoadingAudioPaletteType")]
		private ContentLoadingAudioPaletteItem[] contentLoadingAudioPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[SerializeField]
		[LPIDDMIOHNO("RecyclingAudioPaletteType")]
		private RecyclingAudioPaletteItem[] recyclingAudioPalettes;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x64E49F0", Offset = "0x64E3DF0", VA = "0x1864E49F0")]
		public ButtonAudioPaletteAsset MMDKGHDJFFK(PMNDCFNODBE LFJGPFIALMF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x64E4810", Offset = "0x64E3C10", VA = "0x1864E4810")]
		public ScrollingAudioPaletteAsset GKNPOBBGEIE(EJKOMFHKOCA ADEEIFODLEO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x64E4720", Offset = "0x64E3B20", VA = "0x1864E4720")]
		public ContentLoadingAudioPaletteAsset EBAINGIFDJB(HIAKPIBIBCP PDKFBBMMLCL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x64E4900", Offset = "0x64E3D00", VA = "0x1864E4900")]
		public RecyclingAudioPaletteAsset IKKFFKDHCEB(JFDKCMOBHFF HNJINHOMCHH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7F6AC0", Offset = "0x7F5EC0", VA = "0x1807F6AC0")]
		public AudioPalette()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class BaseAudioPaletteAsset : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x64E4B60", Offset = "0x64E3F60", VA = "0x1864E4B60")]
		protected bool EEELEAGPNCO(RecRoomAudioClipPoolConfig LHHOCNDPEDJ, [Out] RecRoomAudioClip[] KPBDDNJIMGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7F6AC0", Offset = "0x7F5EC0", VA = "0x1807F6AC0")]
		public BaseAudioPaletteAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ButtonAnimationPalette : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[SerializeField]
		private float clickAnimationDuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		private float clickAnimationScale;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public float ClickAnimationDuration
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x8710A0", Offset = "0x8704A0", VA = "0x1808710A0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public float ClickAnimationScale
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x912C90", Offset = "0x912090", VA = "0x180912C90")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x64E4C10", Offset = "0x64E4010", VA = "0x1864E4C10")]
		public ButtonAnimationPalette()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class ButtonAudioPaletteAsset : BaseAudioPaletteAsset
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private RecRoomAudioClipPoolConfig pointerDownAudioClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[SerializeField]
		private RecRoomAudioClipPoolConfig pointerUpAudioClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private RecRoomAudioClipPoolConfig pointerClickAudioClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private RecRoomAudioClipPoolConfig pointerEnterAudioClipPoolConfig;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public RecRoomAudioClip[] PointerDownAudioClipPool
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x64E4CB0", Offset = "0x64E40B0", VA = "0x1864E4CB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public RecRoomAudioClip[] PointerUpAudioClipPool
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x64E4DB0", Offset = "0x64E41B0", VA = "0x1864E4DB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public RecRoomAudioClip[] PointerClickAudioClipPool
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x64E4C30", Offset = "0x64E4030", VA = "0x1864E4C30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public RecRoomAudioClip[] PointerEnterAudioClipPool
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x64E4D30", Offset = "0x64E4130", VA = "0x1864E4D30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7F6AC0", Offset = "0x7F5EC0", VA = "0x1807F6AC0")]
		public ButtonAudioPaletteAsset()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ButtonPalette
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[Header("Background")]
		[SerializeField]
		private Color backgroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		[FormerlySerializedAs("colorBlock")]
		private ColorBlock backgroundTints;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[SerializeField]
		private GradientBlock backgroundGradients;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[Header("Foreground")]
		[SerializeField]
		private Color foregroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[SerializeField]
		private ColorBlock foregroundTints;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[Header("Border")]
		[SerializeField]
		private bool showBorder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[Header("Text")]
		[SerializeField]
		private TextStylePalette textPalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[Header("Audio")]
		[SerializeField]
		private PMNDCFNODBE audioPalette;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Color BackgroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xB18E90", Offset = "0xB18290", VA = "0x180B18E90")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public ColorBlock BackgroundTints
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x64E4F30", Offset = "0x64E4330", VA = "0x1864E4F30")]
			get
			{
				return default(ColorBlock);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public GradientBlock BackgroundGradients
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8143F0", Offset = "0x8137F0", VA = "0x1808143F0")]
			get
			{
				return default(GradientBlock);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Color ForegroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x118B450", Offset = "0x118A850", VA = "0x18118B450")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ColorBlock ForegroundTints
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x64E4F70", Offset = "0x64E4370", VA = "0x1864E4F70")]
			get
			{
				return default(ColorBlock);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool ShowBorder
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x9A34D0", Offset = "0x9A28D0", VA = "0x1809A34D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public TextStylePalette TextPalette
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x848F80", Offset = "0x848380", VA = "0x180848F80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public PMNDCFNODBE AudioPalette
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x11AD970", Offset = "0x11ACD70", VA = "0x1811AD970")]
			get
			{
				return default(PMNDCFNODBE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x64E4E30", Offset = "0x64E4230", VA = "0x1864E4E30")]
		public ButtonPalette()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ContentLoadingAudioPaletteAsset : BaseAudioPaletteAsset
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[Header("Clip Configs")]
		[SerializeField]
		private RecRoomAudioClipPoolConfig loadingSFXAudioClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[Header("Thresholds")]
		[SerializeField]
		[Tooltip("Only start looping loading SFX if any content has been loading for this much time")]
		private float loadingSFXStartDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[SerializeField]
		[Tooltip("Small delay between content finish loading and stopping loading SFX. Avoiding quick stop and replay if contents load back to back.")]
		private float loadingSFXStopDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[SerializeField]
		[Tooltip("Cut loading SFX if content is still loading after this much time. Avoid sustaining SFX when content is hanging on loading.")]
		private float maxLoadingSFXLength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[Header("Smooth Fade")]
		[SerializeField]
		private float fadeInDuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[SerializeField]
		private float fadeOutDuration;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float LoadingSFXStartDelay
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x7C7930", Offset = "0x7C6D30", VA = "0x1807C7930")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float LoadingSFXStopDelay
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x7C77F0", Offset = "0x7C6BF0", VA = "0x1807C77F0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float MaxLoadingSFXLength
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x7C75F0", Offset = "0x7C69F0", VA = "0x1807C75F0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float FadeInDuration
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x7C7790", Offset = "0x7C6B90", VA = "0x1807C7790")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public float FadeOutDuration
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x7E8CF0", Offset = "0x7E80F0", VA = "0x1807E8CF0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x64E69B0", Offset = "0x64E5DB0", VA = "0x1864E69B0")]
		public bool EDDOOMHHKFH([Out] RecRoomAudioClip[] KPBDDNJIMGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x64E6A60", Offset = "0x64E5E60", VA = "0x1864E6A60")]
		public ContentLoadingAudioPaletteAsset()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class DepthPalette
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[SerializeField]
		private float depth;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float Depth
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xB38F30", Offset = "0xB38330", VA = "0x180B38F30")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public DepthPalette()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class DropdownPalette
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[SerializeField]
		private Color backgroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[SerializeField]
		private Color foregroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[SerializeField]
		private TextStylePalette textPalette;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Color BackgroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xB18E90", Offset = "0xB18290", VA = "0x180B18E90")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public TextStylePalette TextPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x773AC0", Offset = "0x772EC0", VA = "0x180773AC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x64E7770", Offset = "0x64E6B70", VA = "0x1864E7770")]
		public DropdownPalette()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class InputFieldPalette
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[SerializeField]
		private Color backgroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[SerializeField]
		private Color foregroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[SerializeField]
		private Color placeholderColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[SerializeField]
		private TextStylePalette textPalette;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Color BackgroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xB18E90", Offset = "0xB18290", VA = "0x180B18E90")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Color ForegroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xEE1000", Offset = "0xEE0400", VA = "0x180EE1000")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Color PlaceholderColor
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xDF9AA0", Offset = "0xDF8EA0", VA = "0x180DF9AA0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public TextStylePalette TextPalette
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x775860", Offset = "0x774C60", VA = "0x180775860")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x64E8EA0", Offset = "0x64E82A0", VA = "0x1864E8EA0")]
		public InputFieldPalette()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class MakerPenToolPalette
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[SerializeField]
		private ButtonPalette buttonPalette;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public ButtonPalette ButtonPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x7738B0", Offset = "0x772CB0", VA = "0x1807738B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public MakerPenToolPalette()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class MenuAudioPaletteAsset : BaseAudioPaletteAsset
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[Header("Menu Open")]
		[SerializeField]
		private RecRoomAudioClipPoolConfig menuHydrateAudioClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[SerializeField]
		private RecRoomAudioClipPoolConfig menuOpen2DFlavorAudioClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[Header("Menu Close")]
		[SerializeField]
		private RecRoomAudioClipPoolConfig menuDehydrateAudioClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[SerializeField]
		private RecRoomAudioClipPoolConfig menuClose2DFlavorAudioClipPoolConfig;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public RecRoomAudioClip[] MenuHydrateAudioClipPool
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x64E9C50", Offset = "0x64E9050", VA = "0x1864E9C50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public RecRoomAudioClip[] MenuOpen2DFlavorAudioClipPool
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x64E9CD0", Offset = "0x64E90D0", VA = "0x1864E9CD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public RecRoomAudioClip[] MenuDehydrateAudioClipPool
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x64E9BD0", Offset = "0x64E8FD0", VA = "0x1864E9BD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public RecRoomAudioClip[] MenuClose2DFlavorAudioClipPool
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x64E9B50", Offset = "0x64E8F50", VA = "0x1864E9B50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7F6AC0", Offset = "0x7F5EC0", VA = "0x1807F6AC0")]
		public MenuAudioPaletteAsset()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class MixedTogglePalette
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		private enum PGDJIBFBNBM
		{
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			UseBaseInactive,
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			UseBaseActive,
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			UseCustom
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[SerializeField]
		private PNNNHDBLHFB baseTogglePalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[SerializeField]
		private PGDJIBFBNBM mixedPaletteType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[SerializeField]
		[EHJLCGPCADH("mixedPaletteType", PGDJIBFBNBM.UseCustom)]
		private ButtonPalette mixedButtonPalette;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x64E9D50", Offset = "0x64E9150", VA = "0x1864E9D50")]
		public TogglePalette LAGJKPPKPJF(Palette PHJMGDPMODM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x64E9D80", Offset = "0x64E9180", VA = "0x1864E9D80")]
		public ButtonPalette MBLMLMAHPEM(Palette PHJMGDPMODM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public MixedTogglePalette()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class Palette : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public class RawImageColorPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			[SerializeField]
			private PCKCPBEJNPH paletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			[SerializeField]
			private Color color;

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public PCKCPBEJNPH RawImageColorPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0x770180", Offset = "0x76F580", VA = "0x180770180")]
				get
				{
					return default(PCKCPBEJNPH);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public Color Color
			{
				[Cpp2IlInjected.Token(Token = "0x600007D")]
				[Cpp2IlInjected.Address(RVA = "0xD48610", Offset = "0xD47A10", VA = "0x180D48610")]
				get
				{
					return default(Color);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x7B7C60", Offset = "0x7B7060", VA = "0x1807B7C60")]
			public RawImageColorPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public class BackgroundColorPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			[SerializeField]
			private BGONDFIOOJH backgroundColorPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			[SerializeField]
			private Color color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			[SerializeField]
			private Gradient gradient;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			[SerializeField]
			private bool raycastTarget;

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public BGONDFIOOJH BackgroundColorPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600007F")]
				[Cpp2IlInjected.Address(RVA = "0x770180", Offset = "0x76F580", VA = "0x180770180")]
				get
				{
					return default(BGONDFIOOJH);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public Color Color
			{
				[Cpp2IlInjected.Token(Token = "0x6000080")]
				[Cpp2IlInjected.Address(RVA = "0xD48610", Offset = "0xD47A10", VA = "0x180D48610")]
				get
				{
					return default(Color);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public Gradient Gradient
			{
				[Cpp2IlInjected.Token(Token = "0x6000081")]
				[Cpp2IlInjected.Address(RVA = "0x773860", Offset = "0x772C60", VA = "0x180773860")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public bool RaycastTarget
			{
				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0x7C7CA0", Offset = "0x7C70A0", VA = "0x1807C7CA0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x64E4AE0", Offset = "0x64E3EE0", VA = "0x1864E4AE0")]
			public BackgroundColorPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public class ForegroundColorPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			[SerializeField]
			private MHAKEECFMKD foregroundColorPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			[SerializeField]
			private Color color;

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public MHAKEECFMKD ForegroundColorPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x770180", Offset = "0x76F580", VA = "0x180770180")]
				get
				{
					return default(MHAKEECFMKD);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public Color Color
			{
				[Cpp2IlInjected.Token(Token = "0x6000085")]
				[Cpp2IlInjected.Address(RVA = "0xD48610", Offset = "0xD47A10", VA = "0x180D48610")]
				get
				{
					return default(Color);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x64E8880", Offset = "0x64E7C80", VA = "0x1864E8880")]
			public ForegroundColorPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public class TilerPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			[SerializeField]
			private HPGKMLBGIPP tilerPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			[SerializeField]
			private TilerPalette tilerPalette;

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public HPGKMLBGIPP TilerPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0x770180", Offset = "0x76F580", VA = "0x180770180")]
				get
				{
					return default(HPGKMLBGIPP);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public TilerPalette TilerPalette
			{
				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
			public TilerPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public class TextStylePaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			[SerializeField]
			private KEJCOGOGLBC textStylePaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			[SerializeField]
			private TextStylePalette textStylePalette;

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public KEJCOGOGLBC TextStylePaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600008A")]
				[Cpp2IlInjected.Address(RVA = "0x770180", Offset = "0x76F580", VA = "0x180770180")]
				get
				{
					return default(KEJCOGOGLBC);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public TextStylePalette TextStylePalette
			{
				[Cpp2IlInjected.Token(Token = "0x600008B")]
				[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
			public TextStylePaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public class TextSizePaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			[SerializeField]
			private DJECMGGCGFH textSizePaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			[SerializeField]
			private int size;

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			public DJECMGGCGFH TextSizePaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0x770180", Offset = "0x76F580", VA = "0x180770180")]
				get
				{
					return default(DJECMGGCGFH);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public int Size
			{
				[Cpp2IlInjected.Token(Token = "0x600008E")]
				[Cpp2IlInjected.Address(RVA = "0x992A60", Offset = "0x991E60", VA = "0x180992A60")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x88CF30", Offset = "0x88C330", VA = "0x18088CF30")]
			public TextSizePaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public class ButtonPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			[SerializeField]
			private IJENFLNLILH buttonPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			[SerializeField]
			private ButtonPalette buttonPalette;

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public IJENFLNLILH ButtonPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000090")]
				[Cpp2IlInjected.Address(RVA = "0x770180", Offset = "0x76F580", VA = "0x180770180")]
				get
				{
					return default(IJENFLNLILH);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000042")]
			public ButtonPalette ButtonPalette
			{
				[Cpp2IlInjected.Token(Token = "0x6000091")]
				[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
			public ButtonPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public class TogglePaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			[SerializeField]
			private PNNNHDBLHFB togglePaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			[SerializeField]
			private TogglePalette togglePalette;

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			public PNNNHDBLHFB TogglePaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000093")]
				[Cpp2IlInjected.Address(RVA = "0x770180", Offset = "0x76F580", VA = "0x180770180")]
				get
				{
					return default(PNNNHDBLHFB);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			public TogglePalette TogglePalette
			{
				[Cpp2IlInjected.Token(Token = "0x6000094")]
				[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
			public TogglePaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public class MixedTogglePaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			[SerializeField]
			private LCLBHNPMCIK mixedTogglePaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			[SerializeField]
			private MixedTogglePalette mixedTogglePalette;

			[Cpp2IlInjected.Token(Token = "0x17000045")]
			public LCLBHNPMCIK MixedTogglePaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000096")]
				[Cpp2IlInjected.Address(RVA = "0x770180", Offset = "0x76F580", VA = "0x180770180")]
				get
				{
					return default(LCLBHNPMCIK);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000046")]
			public MixedTogglePalette MixedTogglePalette
			{
				[Cpp2IlInjected.Token(Token = "0x6000097")]
				[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
			public MixedTogglePaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public class MakerPenToolPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			[SerializeField]
			private GNDFFOFHMAA makerPenToolPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			[SerializeField]
			private MakerPenToolPalette makerPenToolPalette;

			[Cpp2IlInjected.Token(Token = "0x17000047")]
			public GNDFFOFHMAA MakerPenToolPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000099")]
				[Cpp2IlInjected.Address(RVA = "0x770180", Offset = "0x76F580", VA = "0x180770180")]
				get
				{
					return default(GNDFFOFHMAA);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000048")]
			public MakerPenToolPalette MakerPenToolPalette
			{
				[Cpp2IlInjected.Token(Token = "0x600009A")]
				[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
			public MakerPenToolPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public class InputFieldPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			[SerializeField]
			private MALDIGDFCLL inputFieldPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			[SerializeField]
			private InputFieldPalette inputFieldPalette;

			[Cpp2IlInjected.Token(Token = "0x17000049")]
			public MALDIGDFCLL InputFieldPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600009C")]
				[Cpp2IlInjected.Address(RVA = "0x770180", Offset = "0x76F580", VA = "0x180770180")]
				get
				{
					return default(MALDIGDFCLL);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004A")]
			public InputFieldPalette InputFieldPalette
			{
				[Cpp2IlInjected.Token(Token = "0x600009D")]
				[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
			public InputFieldPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public class DropdownPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			[SerializeField]
			private KJHFINELCCA dropdownPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			[SerializeField]
			private DropdownPalette dropdownPalette;

			[Cpp2IlInjected.Token(Token = "0x1700004B")]
			public KJHFINELCCA DropdownPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600009F")]
				[Cpp2IlInjected.Address(RVA = "0x770180", Offset = "0x76F580", VA = "0x180770180")]
				get
				{
					return default(KJHFINELCCA);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004C")]
			public DropdownPalette DropdownPalette
			{
				[Cpp2IlInjected.Token(Token = "0x60000A0")]
				[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
			public DropdownPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		public class SliderPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			[SerializeField]
			private GODDGOBOBKD sliderPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			[SerializeField]
			private SliderPalette sliderPalette;

			[Cpp2IlInjected.Token(Token = "0x1700004D")]
			public GODDGOBOBKD SliderPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x60000A2")]
				[Cpp2IlInjected.Address(RVA = "0x770180", Offset = "0x76F580", VA = "0x180770180")]
				get
				{
					return default(GODDGOBOBKD);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004E")]
			public SliderPalette SliderPalette
			{
				[Cpp2IlInjected.Token(Token = "0x60000A3")]
				[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
			public SliderPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		public class DepthPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			[SerializeField]
			private GMOBDJBIJKC depthPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			[SerializeField]
			private DepthPalette depthPalette;

			[Cpp2IlInjected.Token(Token = "0x1700004F")]
			public GMOBDJBIJKC DepthPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x60000A5")]
				[Cpp2IlInjected.Address(RVA = "0x770180", Offset = "0x76F580", VA = "0x180770180")]
				get
				{
					return default(GMOBDJBIJKC);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000050")]
			public DepthPalette DepthPalette
			{
				[Cpp2IlInjected.Token(Token = "0x60000A6")]
				[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
			public DepthPaletteItem()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[CompilerGenerated]
		private sealed class GJOCMKDJLAJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			public PCKCPBEJNPH backgroundColorPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
			public GJOCMKDJLAJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xDA1800", Offset = "0xDA0C00", VA = "0x180DA1800")]
			internal bool CFONHFNDIOO(RawImageColorPaletteItem pi)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		[CompilerGenerated]
		private sealed class KODPDFLPEDL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			public BGONDFIOOJH backgroundColorPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
			public KODPDFLPEDL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xDA1800", Offset = "0xDA0C00", VA = "0x180DA1800")]
			internal bool LEJONHAIOPK(BackgroundColorPaletteItem backgroundColorPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class HIFBHDNDBGD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public MHAKEECFMKD foregroundColorPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
			public HIFBHDNDBGD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xDA1800", Offset = "0xDA0C00", VA = "0x180DA1800")]
			internal bool LFGOBCOLGMP(ForegroundColorPaletteItem colorPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class ABNDLOJBIEO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public HPGKMLBGIPP type;

			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
			public ABNDLOJBIEO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xDA1800", Offset = "0xDA0C00", VA = "0x180DA1800")]
			internal bool BECOBMHDGJO(TilerPaletteItem tilerPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000035")]
		[CompilerGenerated]
		private sealed class MDHMCBBKCFG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public KEJCOGOGLBC textStylePaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
			public MDHMCBBKCFG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xDA1800", Offset = "0xDA0C00", VA = "0x180DA1800")]
			internal bool PJHELMKCDNA(TextStylePaletteItem textStylePaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000036")]
		[CompilerGenerated]
		private sealed class HPKMGOBMGKB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public DJECMGGCGFH textSizePaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
			public HPKMGOBMGKB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xDA1800", Offset = "0xDA0C00", VA = "0x180DA1800")]
			internal bool DOGJLBBBIJM(TextSizePaletteItem textSizePaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[CompilerGenerated]
		private sealed class FDOBOMMDPDN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public IJENFLNLILH buttonPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
			public FDOBOMMDPDN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xDA1800", Offset = "0xDA0C00", VA = "0x180DA1800")]
			internal bool FIGFNLOHPDI(ButtonPaletteItem buttonPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		[CompilerGenerated]
		private sealed class NCKBJFCENKH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public PNNNHDBLHFB togglePaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
			public NCKBJFCENKH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xDA1800", Offset = "0xDA0C00", VA = "0x180DA1800")]
			internal bool EHJCOKPJCNH(TogglePaletteItem togglePaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000039")]
		[CompilerGenerated]
		private sealed class FBJDHFMIKOG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			public LCLBHNPMCIK mixedTogglePaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
			public FBJDHFMIKOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xDA1800", Offset = "0xDA0C00", VA = "0x180DA1800")]
			internal bool CIFAMPFJLAG(MixedTogglePaletteItem mixedTogglePaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		[CompilerGenerated]
		private sealed class DJDHHFOFKAM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public GNDFFOFHMAA makerPenToolPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
			public DJDHHFOFKAM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0xDA1800", Offset = "0xDA0C00", VA = "0x180DA1800")]
			internal bool LBCHEGHLCHF(MakerPenToolPaletteItem makerPenToolPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		[CompilerGenerated]
		private sealed class GFBCCCDOEJM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public MALDIGDFCLL inputFieldPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
			public GFBCCCDOEJM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0xDA1800", Offset = "0xDA0C00", VA = "0x180DA1800")]
			internal bool CGMILIKKGEM(InputFieldPaletteItem inputFieldPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		[CompilerGenerated]
		private sealed class KFMPFIODIHE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			public KJHFINELCCA dropdownPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
			public KFMPFIODIHE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0xDA1800", Offset = "0xDA0C00", VA = "0x180DA1800")]
			internal bool BABGIHBPNLA(DropdownPaletteItem dropdownPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003D")]
		[CompilerGenerated]
		private sealed class NBPNDIHCKMJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public GODDGOBOBKD sliderPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
			public NBPNDIHCKMJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0xDA1800", Offset = "0xDA0C00", VA = "0x180DA1800")]
			internal bool OLPHJCNLJCA(SliderPaletteItem sliderPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		[CompilerGenerated]
		private sealed class KIFBGFCLAMD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			public GMOBDJBIJKC depthPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
			public KIFBGFCLAMD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0xDA1800", Offset = "0xDA0C00", VA = "0x180DA1800")]
			internal bool OCBLIPFOOAK(DepthPaletteItem depthPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[Header("Visual")]
		[SerializeField]
		[LPIDDMIOHNO("RawImageColorPaletteType")]
		private RawImageColorPaletteItem[] rawImageColorPaletteItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[SerializeField]
		[LPIDDMIOHNO("BackgroundColorPaletteType")]
		private BackgroundColorPaletteItem[] backgroundColorPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[SerializeField]
		[LPIDDMIOHNO("ForegroundColorPaletteType")]
		private ForegroundColorPaletteItem[] foregroundColorPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[SerializeField]
		[LPIDDMIOHNO("TilerPaletteType")]
		private TilerPaletteItem[] tilerPaletteItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[SerializeField]
		[LPIDDMIOHNO("TextStylePaletteType")]
		private TextStylePaletteItem[] textStylePalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[SerializeField]
		[LPIDDMIOHNO("TextSizePaletteType")]
		private TextSizePaletteItem[] textSizePalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[SerializeField]
		[LPIDDMIOHNO("ButtonPaletteType")]
		private ButtonPaletteItem[] buttonPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[SerializeField]
		[LPIDDMIOHNO("TogglePaletteType")]
		private TogglePaletteItem[] togglePalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[SerializeField]
		[LPIDDMIOHNO("MixedTogglePaletteType")]
		private MixedTogglePaletteItem[] mixedTogglePalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[SerializeField]
		[LPIDDMIOHNO("MakerPenToolPaletteType")]
		private MakerPenToolPaletteItem[] makerPenToolPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[SerializeField]
		[LPIDDMIOHNO("InputFieldPaletteType")]
		private InputFieldPaletteItem[] inputFieldPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[SerializeField]
		[LPIDDMIOHNO("DropdownPaletteType")]
		private DropdownPaletteItem[] dropdownPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[SerializeField]
		[LPIDDMIOHNO("SliderPaletteType")]
		private SliderPaletteItem[] sliderPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[SerializeField]
		[LPIDDMIOHNO("DepthPaletteType")]
		private DepthPaletteItem[] depthPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[SerializeField]
		private ButtonAnimationPalette buttonAnimationPalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[Header("Audio")]
		[SerializeField]
		[FormerlySerializedAs("audioPaletteConfig")]
		private AudioPalette audioPalette;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public IEnumerable<DepthPaletteItem> DepthPalettes
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x770CE0", Offset = "0x7700E0", VA = "0x180770CE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public ButtonAnimationPalette ButtonAnimationPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x770B60", Offset = "0x76FF60", VA = "0x180770B60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public AudioPalette AudioPalette
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x8AE6F0", Offset = "0x8ADAF0", VA = "0x1808AE6F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x64ED050", Offset = "0x64EC450", VA = "0x1864ED050")]
		public Color DPKABMLOCNI(PCKCPBEJNPH IHDJFNFPKGK)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x64ECD00", Offset = "0x64EC100", VA = "0x1864ECD00")]
		public void AANEJJLEJIE(BGONDFIOOJH IHDJFNFPKGK, [Out] Color DDJLPLIEHMO, [Out] Gradient EHEFLEGCGBO, [Out] bool LIMIFNNFIKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x64ED450", Offset = "0x64EC850", VA = "0x1864ED450")]
		public Color JHOCKGLDHJB(MHAKEECFMKD AFBJHMJODGN)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x64ED810", Offset = "0x64ECC10", VA = "0x1864ED810")]
		public TilerPalette LHMBPODBBJD(HPGKMLBGIPP LFLAEPCPMDG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x64ECE70", Offset = "0x64EC270", VA = "0x1864ECE70")]
		public TextStylePalette BCHNANBMNPB(KEJCOGOGLBC OFLLLGJGGOF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x64ED360", Offset = "0x64EC760", VA = "0x1864ED360")]
		public int GDBKJMPEECM(DJECMGGCGFH JJPDJAIIFFF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x64ED9F0", Offset = "0x64ECDF0", VA = "0x1864ED9F0")]
		public ButtonPalette PFPKFCMKGKK(IJENFLNLILH DKFPGJLDIOK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x64ED630", Offset = "0x64ECA30", VA = "0x1864ED630")]
		public TogglePalette KHLEENAHGCD(PNNNHDBLHFB JGDJPBMIJLA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x64ECF60", Offset = "0x64EC360", VA = "0x1864ECF60")]
		public MixedTogglePalette DGCENCPOMDI(LCLBHNPMCIK FNHJLEKHCNJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x64ED900", Offset = "0x64ECD00", VA = "0x1864ED900")]
		public MakerPenToolPalette MPJLMONEPLD(GNDFFOFHMAA LMOGDMOPKEJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x64ED720", Offset = "0x64ECB20", VA = "0x1864ED720")]
		public InputFieldPalette LGLJCHNEGDI(MALDIGDFCLL ANPMAJCNDNI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x64ED140", Offset = "0x64EC540", VA = "0x1864ED140")]
		public DropdownPalette FBOCPHFDEAK(KJHFINELCCA FGOIMBGPEOJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x64ED540", Offset = "0x64EC940", VA = "0x1864ED540")]
		public SliderPalette JOOMKIEACCK(GODDGOBOBKD CIADEBAJJGE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x64ED230", Offset = "0x64EC630", VA = "0x1864ED230")]
		public float? FIBMADFJFPP(GMOBDJBIJKC BKEHPLDDEMF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x7F6AC0", Offset = "0x7F5EC0", VA = "0x1807F6AC0")]
		public Palette()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public class RecyclingAudioPaletteAsset : BaseAudioPaletteAsset
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		[Header("Clip Configs")]
		[SerializeField]
		private RecRoomAudioClipPoolConfig itemRecycledAudioClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[Header("Thresholds")]
		[SerializeField]
		[Tooltip("Minimum required wait time before recycle SFX can be triggered repetitively")]
		private float minimumTimeIntervalForRecycleSFX;

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public float MinimumTimeIntervalForRecycleSFX
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x7C7930", Offset = "0x7C6D30", VA = "0x1807C7930")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x64E69B0", Offset = "0x64E5DB0", VA = "0x1864E69B0")]
		public bool JIIDGBFPBMB([Out] RecRoomAudioClip[] KPBDDNJIMGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x64EDF30", Offset = "0x64ED330", VA = "0x1864EDF30")]
		public RecyclingAudioPaletteAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public class ScrollingAudioPaletteAsset : BaseAudioPaletteAsset
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[Header("Clip Configs")]
		[SerializeField]
		private RecRoomAudioClipPoolConfig scrollingSFXAudioClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[SerializeField]
		private RecRoomAudioClipPoolConfig hittingEndsAudioClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[Header("Thresholds")]
		[SerializeField]
		[Tooltip("This distance is measured in UI canvas space")]
		private float distanceThresholdToTriggerScrollingSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[SerializeField]
		private float minimumTimeIntervalForScrollingSFX;

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public float DistanceThresholdToTriggerScrollingSFX
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x7C75F0", Offset = "0x7C69F0", VA = "0x1807C75F0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public float MinimumTimeIntervalForScrollingSFX
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x7C7790", Offset = "0x7C6B90", VA = "0x1807C7790")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x64E69B0", Offset = "0x64E5DB0", VA = "0x1864E69B0")]
		public bool HPANEGLOOJP([Out] RecRoomAudioClip[] KPBDDNJIMGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x64F10E0", Offset = "0x64F04E0", VA = "0x1864F10E0")]
		public bool NGFBHEFJFNB([Out] RecRoomAudioClip[] KPBDDNJIMGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x64F1190", Offset = "0x64F0590", VA = "0x1864F1190")]
		public ScrollingAudioPaletteAsset()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public class SliderPalette
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[SerializeField]
		private Color sliderColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		[SerializeField]
		private Color fillColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		[SerializeField]
		private Color handleColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		[SerializeField]
		private TextStylePalette textPalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		[SerializeField]
		private Color textColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		[SerializeField]
		private ColorBlock colorBlock;

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public Color SliderColor
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0xB18E90", Offset = "0xB18290", VA = "0x180B18E90")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public Color FillColor
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0xEE1000", Offset = "0xEE0400", VA = "0x180EE1000")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public Color HandleColor
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0xDF9AA0", Offset = "0xDF8EA0", VA = "0x180DF9AA0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public ColorBlock ColorBlock
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x64F22A0", Offset = "0x64F16A0", VA = "0x1864F22A0")]
			get
			{
				return default(ColorBlock);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x64F21E0", Offset = "0x64F15E0", VA = "0x1864F21E0")]
		public SliderPalette()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class TextStylePalette
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public enum LANJCCAOCOG
		{
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			LowerCase,
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			UpperCase,
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			SmallCaps
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		[SerializeField]
		private TMP_FontAsset font;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		[SerializeField]
		private Material fontOverrideMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		[SerializeField]
		private float kerning;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		[SerializeField]
		private float leading;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		[SerializeField]
		private bool isBold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		[SerializeField]
		private bool isItalic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		[SerializeField]
		private LANJCCAOCOG transformation;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x64F2BC0", Offset = "0x64F1FC0", VA = "0x1864F2BC0")]
		public void KDBIICOHFCL(TextMeshProUGUI FCMGNCIMNEL, bool FPOAEKGJKBP = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public TextStylePalette()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class TilerPalette
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		[SerializeField]
		private Sprite sprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		[SerializeField]
		private Color tintColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		[SerializeField]
		private Color backgroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		[SerializeField]
		private float rows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		[SerializeField]
		private float rowsWhenPortrait;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		[SerializeField]
		private Vector2 spacing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		[SerializeField]
		private float offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		[SerializeField]
		private Vector2 velocity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		[SerializeField]
		[Range(0f, 360f)]
		private float angle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		[SerializeField]
		private UITiler.KEFOKPKHKPF animationDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		[SerializeField]
		private float primaryAnimationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		[SerializeField]
		private float altAnimationSpeed;

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public Sprite Sprite
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x7738B0", Offset = "0x772CB0", VA = "0x1807738B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public Color TintColor
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x9FC980", Offset = "0x9FBD80", VA = "0x1809FC980")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public Color BackgroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x9FC9D0", Offset = "0x9FBDD0", VA = "0x1809FC9D0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public Vector2 Spacing
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x6463B40", Offset = "0x6462F40", VA = "0x186463B40")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public float Offset
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x984D50", Offset = "0x984150", VA = "0x180984D50")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public Vector2 Velocity
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x64F3250", Offset = "0x64F2650", VA = "0x1864F3250")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public float Angle
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x19C94C0", Offset = "0x19C88C0", VA = "0x1819C94C0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public UITiler.KEFOKPKHKPF AnimationDirection
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0xCD8830", Offset = "0xCD7C30", VA = "0x180CD8830")]
			get
			{
				return default(UITiler.KEFOKPKHKPF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public float PrimaryAnimationSpeed
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x1180B70", Offset = "0x117FF70", VA = "0x181180B70")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public float AltAnimationSpeed
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x9B48F0", Offset = "0x9B3CF0", VA = "0x1809B48F0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x64F31E0", Offset = "0x64F25E0", VA = "0x1864F31E0")]
		public float OKHNOJEKFGM(EHJCHDLGKEC PFFPFOCPNLG)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x64F3200", Offset = "0x64F2600", VA = "0x1864F3200")]
		public TilerPalette()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public class TogglePalette
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		[SerializeField]
		private ButtonPalette inactiveButtonPalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		[SerializeField]
		private ButtonPalette activeButtonPalette;

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public ButtonPalette InactiveButtonPalette
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x7738B0", Offset = "0x772CB0", VA = "0x1807738B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public ButtonPalette ActiveButtonPalette
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public TogglePalette()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public enum BGONDFIOOJH
{
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	PrimarySolid,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	SecondarySolid,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	HighlightSolid,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	HighlightGradient,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	BannerBG,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	InputField,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	LineColor,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	CardImageBase,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	DarkGradient,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	Shadow,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	Error,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	Warning,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	NotiBase,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	BackgroundAccent,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	SideBarBG,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	Modified,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	LoadingScreen,
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	LoadingBarGradient,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	HomeButtonBase,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	TitleRoot,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	HighlightedAccent,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	LoadingCard,
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	ChipBase,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	LimitedEventCard,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	LimitedEventBgSolid,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	DateChip,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	WinterWonderlandBG,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	RuntimeAddedTag,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	RuntimeDeletedTag
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public enum PCKCPBEJNPH
{
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	A
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public enum MHAKEECFMKD
{
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	MainPrimary,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	MainSecondary,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	InversePrimary,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	NotUse,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	WhitePrimary,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	WhiteSecondary,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	CardPrimary,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	CardSecondary,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	Error,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	Modified,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	Orange
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public enum HPGKMLBGIPP
{
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	WatchBackground,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	HomePage,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	DialogPage,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	Card,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	ProfileBG,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	WinterWonderlandHome
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public enum KEJCOGOGLBC
{
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	JostMedium,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	JostMediumCap,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	JostBoldCap,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	RobotoReg,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	RobotoBold,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	RobotoBoldOutlineDropshadow,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	RobotoBoldOutline,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	RobotoBoldOutlineDropshadowGradient,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	RobotoBoldOutlineGradient
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public enum DJECMGGCGFH
{
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	XXXS = -1,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	XXS = 0,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	XS = 1,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	S = 2,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	M = 3,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	L = 4,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	XL = 5,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	XXL = 8,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	XXXL = 6,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	XXXXL = 7
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public enum IJENFLNLILH
{
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	Primary,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	Secondary,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	FlatPrimary,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	FlatButtonForWarningBanner,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	Negative,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	Chips,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	CarouselArrowDark,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	FlatWhite,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	MagicDoor,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	Tertiary_DupeWith2NDHeader_NeedReplace,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	CarouselArrowLight,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	HomePageMainButton,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	DropDown,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	SecondaryHeaderSection,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	ChatButton,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	FeedButton,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	NameTag,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	RoomCurrency,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	ChipsWhite,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	UGCBaseButton
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public enum PNNNHDBLHFB
{
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	FlatOrange,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	FlatWhite,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	InputToggle,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	Chips,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	Switch,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	WhitePagingBlob,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	RSVPToggleHeaderSection,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	CardSelectableToggle,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	ChipsDark,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	MainNavToggle,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	ListItem,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	NotiUnread,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	FlatPrimary,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	CharadePen,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	ShareCam,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	CardSelectableToggleWithBacking,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	SecondaryHeaderSectionToggle,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	PrimaryToSecondaryHeader,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	NegativeToSecondaryHeader,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	LimitedEventPrimary,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	LimitedEventSecondary,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	RoomCardWithLimitedEvent,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	MainNavVrDetach,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	HomeMainNav,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	FlatOrangeSecondary
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public enum LCLBHNPMCIK
{
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	Checkbox
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public enum GNDFFOFHMAA
{
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	Create,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	Select,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	Wire,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	Configure,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	Transform,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	Move,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	Rotate,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	Scale,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	CloneFlip,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	Recolor,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	Freeze,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	MakeInvention,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	Manipulate,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	Delete
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public enum MALDIGDFCLL
{
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	LightFlat,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	DarkFlat,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	Modified
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public enum KJHFINELCCA
{
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	LightFlat,
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	DarkFlat
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public enum GODDGOBOBKD
{
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	MirroUIPopUp
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public enum GMOBDJBIJKC
{
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	Base,
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	Button,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	Navigation,
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	Overlay,
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	Dialog,
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	Toast
}
namespace RRUI.Theme
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public class ApproximationMaskDepthTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		[SerializeField]
		private RectTransform content;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private Vector3? HKBFHDHGNEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private Vector3? HBENHOBLHEI;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x64E4640", Offset = "0x64E3A40", VA = "0x1864E4640")]
		private void GJHPIDDJMKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x64E4290", Offset = "0x64E3690", VA = "0x1864E4290", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x772DA0", Offset = "0x7721A0", VA = "0x180772DA0")]
		public ApproximationMaskDepthTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public class ButtonTheme : ButtonThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		[Header("Button Visual")]
		[SerializeField]
		private IJENFLNLILH buttonType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		[Header("Button Audio")]
		[SerializeField]
		[Tooltip("Override the audio palette defined by the button's visual with a custom palette")]
		private bool overrideButtonAudioPalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		[Tooltip("Specify a custom config to use for button audio")]
		[SerializeField]
		[EHJLCGPCADH("overrideButtonAudioPalette")]
		private ButtonAudioPaletteAsset customButtonAudioConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		[SerializeField]
		[Tooltip("Layer a 2D SFX on top of base button sounds")]
		private bool useFlavorSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		[EHJLCGPCADH("useFlavorSFX")]
		[Tooltip("Flavor SFX is picked randomly from this pool config")]
		[SerializeField]
		private RecRoomAudioClipPoolConfig flavorSFXClipPoolConfig;

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public IJENFLNLILH BDJBCBFPLJL
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x54BC260", Offset = "0x54BB660", VA = "0x1854BC260")]
			get
			{
				return default(IJENFLNLILH);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x64E6990", Offset = "0x64E5D90", VA = "0x1864E6990")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x64E6720", Offset = "0x64E5B20", VA = "0x1864E6720", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x865F90", Offset = "0x865390", VA = "0x180865F90")]
		public void SetAnimationEnabled(bool BFEPOIFAJEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x64E6980", Offset = "0x64E5D80", VA = "0x1864E6980")]
		public ButtonTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public abstract class ButtonThemeBase : SelectableThemeBase
	{
		[Cpp2IlInjected.Token(Token = "0x2000058")]
		protected class JMKKHFHMAAF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000180")]
			public ButtonAudioPaletteAsset BMCNHNNCMKO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000181")]
			public RecRoomAudioClipPoolConfig BCOBNKLBAPL;

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
			public JMKKHFHMAAF()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		[Header("Button Theme Base")]
		[SerializeField]
		[ABALMBEBCPA(BLCCKOBNIPN.Self, false, false, false)]
		private MultiGraphicButton multiGraphicButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		[SerializeField]
		[ABALMBEBCPA(BLCCKOBNIPN.Self, false, true, false)]
		private Image surface;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		[SerializeField]
		private bool useSurfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		[SerializeField]
		[EHJLCGPCADH("useSurfaceOverride")]
		private Image surfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		[SerializeField]
		[NDFCALBHJND]
		private List<Graphic> graphics;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		[SerializeField]
		private bool useGraphicsOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		[SerializeField]
		[EHJLCGPCADH("useGraphicsOverride")]
		private List<Graphic> graphicsOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		[SerializeField]
		[ABALMBEBCPA(BLCCKOBNIPN.Self, false, true, false)]
		private UIGradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		[SerializeField]
		private bool useGradientOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		[SerializeField]
		[EHJLCGPCADH("useGradientOverride")]
		private UIGradient gradientOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		[SerializeField]
		[ABALMBEBCPA(BLCCKOBNIPN.Children, true, true, false)]
		private TextMeshProUGUI textMeshProUGUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		[SerializeField]
		private bool useTextMeshProUGUIOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		[SerializeField]
		[EHJLCGPCADH("useTextMeshProUGUIOverride")]
		private TextMeshProUGUI textMeshProUGUIOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		[SerializeField]
		private DJECMGGCGFH textSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		[SerializeField]
		protected Hideable borderHideable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		[SerializeField]
		protected bool isAnimationEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x101")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		[SerializeField]
		[EHJLCGPCADH("isAnimationEnabled")]
		protected bool overrideAnimationTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		[SerializeField]
		[EHJLCGPCADH("overrideAnimationTarget")]
		protected GameObject animationTargetOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private bool CPEFDMIIHKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private Vector3 COGPECPPMJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private Vector3 OHLMBCCDPNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private EKGANFHKHGM IJFPGELFGDC;

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public Image DEHNCCLLBCI
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x64E66C0", Offset = "0x64E5AC0", VA = "0x1864E66C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public List<Graphic> HAHADGDFLIN
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x64E66A0", Offset = "0x64E5AA0", VA = "0x1864E66A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public UIGradient GFJEFGPOOCO
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x64E6680", Offset = "0x64E5A80", VA = "0x1864E6680")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public TextMeshProUGUI OPIMCKBPAHL
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x64E66E0", Offset = "0x64E5AE0", VA = "0x1864E66E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public DJECMGGCGFH IIALABCDACN
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xD27770", Offset = "0xD26B70", VA = "0x180D27770")]
			get
			{
				return default(DJECMGGCGFH);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x64E6700", Offset = "0x64E5B00", VA = "0x1864E6700")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		protected Transform AINEBGMBGMM
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x64E4FE0", Offset = "0x64E43E0", VA = "0x1864E4FE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public Button FLKKLJBBOLI
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x64E65F0", Offset = "0x64E59F0", VA = "0x1864E65F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x64E5BA0", Offset = "0x64E4FA0", VA = "0x1864E5BA0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x64E5B00", Offset = "0x64E4F00", VA = "0x1864E5B00")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x64E63A0", Offset = "0x64E57A0", VA = "0x1864E63A0")]
		protected void PKPMJNHKDDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x64E5030", Offset = "0x64E4430", VA = "0x1864E5030")]
		protected void FGONHEIGCHI(ButtonPalette OBCBPAFEMDE, [Optional] JMKKHFHMAAF IGHCEJENKDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x64E5C40", Offset = "0x64E5040", VA = "0x1864E5C40", Slot = "12")]
		public override void OnPointerDown(PointerEventData LHEBENHACBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x64E6040", Offset = "0x64E5440", VA = "0x1864E6040", Slot = "13")]
		public override void OnPointerUp(PointerEventData LHEBENHACBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x64E5C20", Offset = "0x64E5020", VA = "0x1864E5C20", Slot = "14")]
		public override void OnPointerClick(PointerEventData LHEBENHACBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x64E5AE0", Offset = "0x64E4EE0", VA = "0x1864E5AE0")]
		private Vector3 GHFBLEGGFBG(float HHEJIMODBII)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x64E6510", Offset = "0x64E5910", VA = "0x1864E6510")]
		protected ButtonThemeBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x64E4FC0", Offset = "0x64E43C0", VA = "0x1864E4FC0")]
		[CompilerGenerated]
		private void JHFBHOBAFEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x64E4FC0", Offset = "0x64E43C0", VA = "0x1864E4FC0")]
		[CompilerGenerated]
		private void DFOACBMKJEA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public class DepthTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		[SerializeField]
		private GMOBDJBIJKC depth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		[SerializeField]
		private bool animateOnEnable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		[SerializeField]
		[EHJLCGPCADH("animateOnEnable")]
		private float animationTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private Vector3? HKBFHDHGNEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private Vector2 LNKPDPLAGGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private Vector2 GFJLGAMGJJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private Vector2 OOFPNMLJFEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private Vector2 GPMDFCMJFII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private Vector2 LJEOJBLLOBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private Vector2 GJAILMLNLCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private readonly bool? BEKCJMIADEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private MGNHIPFIELD GCJCEPIAFOE;

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		private RectTransform LBKIFDABKKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x64E7440", Offset = "0x64E6840", VA = "0x1864E7440")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public GMOBDJBIJKC IADGAPGCJJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x896540", Offset = "0x895940", VA = "0x180896540")]
			get
			{
				return default(GMOBDJBIJKC);
			}
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x64E7750", Offset = "0x64E6B50", VA = "0x1864E7750")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		private MGNHIPFIELD FABNGBKNJJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x64E6F70", Offset = "0x64E6370", VA = "0x1864E6F70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		private bool NKCIMINAOHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x64E6FE0", Offset = "0x64E63E0", VA = "0x1864E6FE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x64E7550", Offset = "0x64E6950", VA = "0x1864E7550")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x64E74A0", Offset = "0x64E68A0", VA = "0x1864E74A0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x64E6A90", Offset = "0x64E5E90", VA = "0x1864E6A90", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x64E6C50", Offset = "0x64E6050", VA = "0x1864E6C50")]
		private void GJHPIDDJMKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x64E70B0", Offset = "0x64E64B0", VA = "0x1864E70B0")]
		private Vector3 JPPLFCCBPJA()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x64E75C0", Offset = "0x64E69C0", VA = "0x1864E75C0")]
		public DepthTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public class DropdownTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		[SerializeField]
		[ECFGBFMBKFJ(BLCCKOBNIPN.Self, false, false, false)]
		private Dropdown dropdown;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		[SerializeField]
		[ABALMBEBCPA(BLCCKOBNIPN.Self, false, true, false)]
		private Image surface;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		[SerializeField]
		private bool useSurfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		[SerializeField]
		[EHJLCGPCADH("useSurfaceOverride")]
		private Image surfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		[SerializeField]
		private KJHFINELCCA dropdownType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		[SerializeField]
		private DJECMGGCGFH textSize;

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public Image DEHNCCLLBCI
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x64E7D90", Offset = "0x64E7190", VA = "0x1864E7D90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public KJHFINELCCA CKFINJIMKCB
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x781110", Offset = "0x780510", VA = "0x180781110")]
			get
			{
				return default(KJHFINELCCA);
			}
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x64E7DA0", Offset = "0x64E71A0", VA = "0x1864E7DA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public DJECMGGCGFH IIALABCDACN
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x8DF000", Offset = "0x8DE400", VA = "0x1808DF000")]
			get
			{
				return default(DJECMGGCGFH);
			}
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x64E7DC0", Offset = "0x64E71C0", VA = "0x1864E7DC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x64E7790", Offset = "0x64E6B90", VA = "0x1864E7790", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x64E7D80", Offset = "0x64E7180", VA = "0x1864E7D80")]
		public DropdownTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class GraphicTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		[SerializeField]
		[ECFGBFMBKFJ(BLCCKOBNIPN.Self, false, false, false)]
		private Graphic graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		[SerializeField]
		private bool useGraphicOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		[SerializeField]
		[EHJLCGPCADH("useGraphicOverride")]
		private Graphic graphicOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		[SerializeField]
		private MHAKEECFMKD color;

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public Graphic GECLOPONINL
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x64E8E70", Offset = "0x64E8270", VA = "0x1864E8E70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public MHAKEECFMKD PGKJDMECFHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x78F4E0", Offset = "0x78E8E0", VA = "0x18078F4E0")]
			get
			{
				return default(MHAKEECFMKD);
			}
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x64E8E80", Offset = "0x64E8280", VA = "0x1864E8E80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public bool HPNKBGMCCAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xC2B730", Offset = "0xC2AB30", VA = "0x180C2B730")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0xC2B6F0", Offset = "0xC2AAF0", VA = "0x180C2B6F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public Color? NBGPNEALAOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x64E8C50", Offset = "0x64E8050", VA = "0x1864E8C50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x64E8A50", Offset = "0x64E7E50", VA = "0x1864E8A50", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x772DA0", Offset = "0x7721A0", VA = "0x180772DA0")]
		public GraphicTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class InputFieldTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		[SerializeField]
		[ECFGBFMBKFJ(BLCCKOBNIPN.Self, false, false, false)]
		private TMP_InputField inputField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		[SerializeField]
		[ABALMBEBCPA(BLCCKOBNIPN.Self, false, false, false)]
		private Image surface;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		[SerializeField]
		private bool useSurfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		[SerializeField]
		[EHJLCGPCADH("useSurfaceOverride")]
		private Image surfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		[SerializeField]
		private MALDIGDFCLL inputFieldType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		[SerializeField]
		private DJECMGGCGFH textSize;

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public Image DEHNCCLLBCI
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x64E7D90", Offset = "0x64E7190", VA = "0x1864E7D90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public MALDIGDFCLL KDJAHMMDLLC
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x781110", Offset = "0x780510", VA = "0x180781110")]
			get
			{
				return default(MALDIGDFCLL);
			}
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x64E7DA0", Offset = "0x64E71A0", VA = "0x1864E7DA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public DJECMGGCGFH IIALABCDACN
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x8DF000", Offset = "0x8DE400", VA = "0x1808DF000")]
			get
			{
				return default(DJECMGGCGFH);
			}
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x64E7DC0", Offset = "0x64E71C0", VA = "0x1864E7DC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x64E8ED0", Offset = "0x64E82D0", VA = "0x1864E8ED0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x64E7D80", Offset = "0x64E7180", VA = "0x1864E7D80")]
		public InputFieldTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class LabelTheme : GraphicTheme
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		[SerializeField]
		[ECFGBFMBKFJ(BLCCKOBNIPN.Self, false, false, false)]
		private TextMeshProUGUI textMeshProUGUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		[SerializeField]
		private KEJCOGOGLBC textType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		[SerializeField]
		private DJECMGGCGFH textSize;

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public KEJCOGOGLBC IHBLCODLEPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x87EAA0", Offset = "0x87DEA0", VA = "0x18087EAA0")]
			get
			{
				return default(KEJCOGOGLBC);
			}
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x64E96D0", Offset = "0x64E8AD0", VA = "0x1864E96D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public DJECMGGCGFH IIALABCDACN
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x80CFD0", Offset = "0x80C3D0", VA = "0x18080CFD0")]
			get
			{
				return default(DJECMGGCGFH);
			}
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x64E96B0", Offset = "0x64E8AB0", VA = "0x1864E96B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x64E93A0", Offset = "0x64E87A0", VA = "0x1864E93A0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x64E96A0", Offset = "0x64E8AA0", VA = "0x1864E96A0")]
		public LabelTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public class MakerPenToolTheme : ButtonThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		[Header("Maker Pen Tool")]
		[SerializeField]
		private GNDFFOFHMAA makerPenToolPaletteType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		[SerializeField]
		[Tooltip("A list of objects to show while the maker pen tool is active.")]
		private List<Hideable> hideWhenNotActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		[SerializeField]
		[Tooltip("A list of objects to show while the maker pen tool is inactive")]
		private List<Hideable> hideWhenActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		[SerializeField]
		private bool editorIsActiveOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x151")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		protected bool BLGNAGAKIJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x152")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private bool NBCFOIOMFFP;

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public GNDFFOFHMAA FIFHDCCFGNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x54BC260", Offset = "0x54BB660", VA = "0x1854BC260")]
			get
			{
				return default(GNDFFOFHMAA);
			}
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x64E6990", Offset = "0x64E5D90", VA = "0x1864E6990")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public bool KLNEECJHJNP
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x64E9B20", Offset = "0x64E8F20", VA = "0x1864E9B20")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x64E9B30", Offset = "0x64E8F30", VA = "0x1864E9B30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x64E9AE0", Offset = "0x64E8EE0", VA = "0x1864E9AE0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x64E96F0", Offset = "0x64E8AF0", VA = "0x1864E96F0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x64E6980", Offset = "0x64E5D80", VA = "0x1864E6980")]
		public MakerPenToolTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class MixedToggleTheme : ButtonThemeBase
	{
		[Cpp2IlInjected.Token(Token = "0x2000060")]
		public enum DDDCCGJKBAM
		{
			[Cpp2IlInjected.Token(Token = "0x40001AF")]
			Inactive,
			[Cpp2IlInjected.Token(Token = "0x40001B0")]
			Mixed,
			[Cpp2IlInjected.Token(Token = "0x40001B1")]
			Active
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		[SerializeField]
		private LCLBHNPMCIK toggleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		[SerializeField]
		[Tooltip("A list of objects to hide while the toggle is inactive.")]
		private List<Hideable> hideWhenInactive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		[SerializeField]
		[Tooltip("A list of objects to hide while the toggle is mixed.")]
		private List<Hideable> hideWhenMixed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		[SerializeField]
		[Tooltip("A list of objects to hide while the toggle is active")]
		private List<Hideable> hideWhenActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		[SerializeField]
		private DDDCCGJKBAM editorIsActiveOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15C")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private DDDCCGJKBAM NBCFOIOMFFP;

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public DDDCCGJKBAM KLNEECJHJNP
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x64EA3F0", Offset = "0x64E97F0", VA = "0x1864EA3F0")]
			get
			{
				return default(DDDCCGJKBAM);
			}
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x64EA3D0", Offset = "0x64E97D0", VA = "0x1864EA3D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x64EA3A0", Offset = "0x64E97A0", VA = "0x1864EA3A0")]
		public void Toggle()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x64EA3D0", Offset = "0x64E97D0", VA = "0x1864EA3D0")]
		public void Toggle(DDDCCGJKBAM NBCFOIOMFFP, bool BLGNAGAKIJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x64E9DF0", Offset = "0x64E91F0", VA = "0x1864E9DF0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x64E6980", Offset = "0x64E5D80", VA = "0x1864E6980")]
		public MixedToggleTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public class PaletteTheme : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		[SerializeField]
		private bool usePaletteOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		[SerializeField]
		[EHJLCGPCADH("usePaletteOverride")]
		private Palette paletteOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public FCJKIAIKOOM PaletteChangeEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		[SerializeField]
		private bool useDepth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private EKLGCGNBGGK PJKJNIBPDPK;

		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private const string GAFONBJEBGG = "watch_layer";

		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private const string OJLNFAJONKJ = "depth_multiplier";

		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private const float ADKMLHJNEJJ = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private float? ENDNAIMNCBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		private float? LEIFGPBPBOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		private float? JMHMOENFPMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private float KIFPCENPLMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		private float MBKGLJJMBPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private float NOLNOMHADOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		private float NABJMGNLNDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		private readonly EFHEONJKJKH DHJINLADCAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		private SFXAudioSource PGPHAABPJBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private SFXAudioSource LACHEBGOEED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private ContentLoadingAudioPaletteAsset BEKDOGGOHFN;

		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private const float LJGIOPFEEIK = 0.001f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private BHLGJFAOJLK CBDCJGNKLKL;

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public Palette NJALMACDILL
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x64ECC60", Offset = "0x64EC060", VA = "0x1864ECC60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public bool FPBICDEMDAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x7C7CA0", Offset = "0x7C70A0", VA = "0x1807C7CA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public float BMHDHOGBCJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x64ECA70", Offset = "0x64EBE70", VA = "0x1864ECA70")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		private bool LODGLAJKPEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x64EBA30", Offset = "0x64EAE30", VA = "0x1864EBA30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		private bool DHJIPODDLNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x64EBCA0", Offset = "0x64EB0A0", VA = "0x1864EBCA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x64EB8A0", Offset = "0x64EACA0", VA = "0x1864EB8A0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x64EBE90", Offset = "0x64EB290", VA = "0x1864EBE90")]
		private void ENLPDMOACLM(KPDFHKMMBEE.CNGENODCMEN OBMLIMCFENC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x64EC2B0", Offset = "0x64EB6B0", VA = "0x1864EC2B0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x64EBD20", Offset = "0x64EB120", VA = "0x1864EBD20")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x64EC0E0", Offset = "0x64EB4E0", VA = "0x1864EC0E0")]
		private void KDFOBNFAAOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x64EB780", Offset = "0x64EAB80", VA = "0x1864EB780")]
		public void AddLoadingSFXRequest(object NOEAHPPKHNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x64EC890", Offset = "0x64EBC90", VA = "0x1864EC890")]
		public void RemoveLoadingSFXRequest(object NOEAHPPKHNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x64EBD20", Offset = "0x64EB120", VA = "0x1864EBD20")]
		private void EBJMDNJENJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x64EBAB0", Offset = "0x64EAEB0", VA = "0x1864EBAB0")]
		private void BKNNNJOPIPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x64EB610", Offset = "0x64EAA10", VA = "0x1864EB610")]
		private void AHHIEJPGIOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x64EB520", Offset = "0x64EA920", VA = "0x1864EB520")]
		private void AGNHPAJHEPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x64EC3E0", Offset = "0x64EB7E0", VA = "0x1864EC3E0")]
		private void PLPJOBAJGFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x64EBF00", Offset = "0x64EB300", VA = "0x1864EBF00")]
		private void HFIDFLFLBLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x64EC2A0", Offset = "0x64EB6A0", VA = "0x1864EC2A0")]
		private void MGKJLNLOBJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x64EBFF0", Offset = "0x64EB3F0", VA = "0x1864EBFF0")]
		private void ILBGJAEAJCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x64EBEC0", Offset = "0x64EB2C0", VA = "0x1864EBEC0")]
		private void HBJANGENNFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x64EC6C0", Offset = "0x64EBAC0", VA = "0x1864EC6C0")]
		public void Play2DUIFlavorSFX(RecRoomAudioClip[] PDBJHMOJNED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x64EC9B0", Offset = "0x64EBDB0", VA = "0x1864EC9B0")]
		public PaletteTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public abstract class PaletteThemeReference : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		[SerializeField]
		[ABALMBEBCPA(BLCCKOBNIPN.SelfAndParent, true, false, false)]
		private PaletteTheme paletteTheme;

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		protected PaletteTheme MBBPDMCLPDC
		{
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		protected Palette NJALMACDILL
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x64EADA0", Offset = "0x64EA1A0", VA = "0x1864EADA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		protected bool FCCKADOPIGH
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x64EB080", Offset = "0x64EA480", VA = "0x1864EB080")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		protected Transform BCIDGEAIPEN
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x64EB000", Offset = "0x64EA400", VA = "0x1864EB000")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x64EACA0", Offset = "0x64EA0A0", VA = "0x1864EACA0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x64EB440", Offset = "0x64EA840", VA = "0x1864EB440", Slot = "5")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void Apply();

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x64EAE50", Offset = "0x64EA250", VA = "0x1864EAE50")]
		public Color? GetColorFromPalette(MHAKEECFMKD HDOFGMEMKPL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x64EB100", Offset = "0x64EA500", VA = "0x1864EB100")]
		private void LKNOJLODIBL(bool BCBPCPKIHPC = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x772DA0", Offset = "0x7721A0", VA = "0x180772DA0")]
		protected PaletteThemeReference()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public class RangeSliderTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		[SerializeField]
		[ECFGBFMBKFJ(BLCCKOBNIPN.Self, false, false, false)]
		private RangeSlider slider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		[SerializeField]
		private GODDGOBOBKD sliderType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		[SerializeField]
		private Image sliderImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		[SerializeField]
		private Image fillImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		[SerializeField]
		private Image lowHandleImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		[SerializeField]
		private Image highHandleImage;

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public GODDGOBOBKD AMKPDPMCFCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x77B2F0", Offset = "0x77A6F0", VA = "0x18077B2F0")]
			get
			{
				return default(GODDGOBOBKD);
			}
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x64EDDE0", Offset = "0x64ED1E0", VA = "0x1864EDDE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public Image CNOFJDNGALE
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x773AC0", Offset = "0x772EC0", VA = "0x180773AC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public Image PHLEEGMLEHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x773AA0", Offset = "0x772EA0", VA = "0x180773AA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public Image GIEBCDKLJBI
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x775860", Offset = "0x774C60", VA = "0x180775860")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public Image LGPIBBLGMEA
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x770B10", Offset = "0x76FF10", VA = "0x180770B10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public bool CODJMKECLFI
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x54BCFC0", Offset = "0x54BC3C0", VA = "0x1854BCFC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x54BD260", Offset = "0x54BC660", VA = "0x1854BD260")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x64EDAE0", Offset = "0x64ECEE0", VA = "0x1864EDAE0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x772DA0", Offset = "0x7721A0", VA = "0x180772DA0")]
		public RangeSliderTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public class RawImageTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		[SerializeField]
		[ECFGBFMBKFJ(BLCCKOBNIPN.Self, false, false, false)]
		private RawImage image;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		[SerializeField]
		private PCKCPBEJNPH color;

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public PCKCPBEJNPH ILLELPHOAAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x77B2F0", Offset = "0x77A6F0", VA = "0x18077B2F0")]
			get
			{
				return default(PCKCPBEJNPH);
			}
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x64EDDE0", Offset = "0x64ED1E0", VA = "0x1864EDDE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x64EDE00", Offset = "0x64ED200", VA = "0x1864EDE00", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x772DA0", Offset = "0x7721A0", VA = "0x180772DA0")]
		public RawImageTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class RecyclingGridTheme : RecyclingThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		[SerializeField]
		[ECFGBFMBKFJ(BLCCKOBNIPN.Self, false, false, false)]
		private OLHCDFMLEAN recyclingGrid;

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x64EDF40", Offset = "0x64ED340", VA = "0x1864EDF40", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x64EE1B0", Offset = "0x64ED5B0", VA = "0x1864EE1B0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x64EE140", Offset = "0x64ED540", VA = "0x1864EE140")]
		private void EKPHCOOOFMP(float BFIJFKGNIBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x64EE3A0", Offset = "0x64ED7A0", VA = "0x1864EE3A0")]
		public RecyclingGridTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class RecyclingListTheme : RecyclingThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		[SerializeField]
		[ECFGBFMBKFJ(BLCCKOBNIPN.Self, false, false, false)]
		private OLHCDFMLEAN recyclingList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private bool LMOGFKFOCCB;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x64EE3B0", Offset = "0x64ED7B0", VA = "0x1864EE3B0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x64EE660", Offset = "0x64EDA60", VA = "0x1864EE660", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x64EE5F0", Offset = "0x64ED9F0", VA = "0x1864EE5F0")]
		private void FIOMLPPKAGA(float BFIJFKGNIBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x64EE3A0", Offset = "0x64ED7A0", VA = "0x1864EE3A0")]
		public RecyclingListTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public abstract class RecyclingThemeBase : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		[Header("Audio")]
		[SerializeField]
		private JFDKCMOBHFF recyclingAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		protected RecyclingAudioPaletteAsset DCNDFKOJJGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		[SerializeField]
		private EJKOMFHKOCA scrollingAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private ScrollingAudioPaletteAsset IBKAMJLHBHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private BHLGJFAOJLK LGEKHNMLGIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private float MDNCEIFGAPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		private float FDKFAHILEAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		private float KPDNFJALFLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		private float OCKADPFGJJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		private bool OAJAIHFMDFP;

		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		private const float MKAFPCLEOOB = 0.01f;

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		private BHLGJFAOJLK CBDCJGNKLKL
		{
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x64EF120", Offset = "0x64EE520", VA = "0x1864EF120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x64EE860", Offset = "0x64EDC60", VA = "0x1864EE860", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x64EF350", Offset = "0x64EE750", VA = "0x1864EF350")]
		protected void NHMOBIBMBLI(bool CEDPBFOKBOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x64EEF20", Offset = "0x64EE320", VA = "0x1864EEF20")]
		protected void IOBLFHEMIAD(GameObject EDPLJLLHNEJ, int JLPMMOIKFEP, bool AFNJICHDLHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x64EF610", Offset = "0x64EEA10", VA = "0x1864EF610")]
		protected void ODLLDJMFIJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x64EECC0", Offset = "0x64EE0C0", VA = "0x1864EECC0")]
		protected void GCJJOFDJHHE(float BFIJFKGNIBO, float LMPMOLBILOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x64EEA50", Offset = "0x64EDE50", VA = "0x1864EEA50")]
		private void DGLHPIPMPAK(float JEGOOPIFPAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x64EF190", Offset = "0x64EE590", VA = "0x1864EF190")]
		private void NBDPJFEKCKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x64EE3A0", Offset = "0x64ED7A0", VA = "0x1864EE3A0")]
		protected RecyclingThemeBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public class ScrollBarTheme : SelectableThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		[Header("Scroll Bar Audio")]
		[SerializeField]
		private PMNDCFNODBE buttonAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		[SerializeField]
		[Tooltip("Layer a 2D SFX on top of base button sounds")]
		private bool useFlavorSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		[Tooltip("Flavor SFX is picked randomly from this pool config")]
		[SerializeField]
		[EHJLCGPCADH("useFlavorSFX")]
		private RecRoomAudioClipPoolConfig flavorSFXClipPoolConfig;

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x64EF810", Offset = "0x64EEC10", VA = "0x1864EF810", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x64EF930", Offset = "0x64EED30", VA = "0x1864EF930")]
		public ScrollBarTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class ScrollRectTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private const string JLGGHPLGHNJ = "RRUI.PlayHittingEndsSFX";

		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private const int HHEOHFNEFCF = 5;

		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private const int LMKJELPEHLB = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		private DateTimeOffset KOODFGHNIKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private int LJDNGMHGCNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		private bool MHCBBPHNJEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		[SerializeField]
		[ECFGBFMBKFJ(BLCCKOBNIPN.Self, false, false, false)]
		private ScrollRect scrollRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		[Header("Audio")]
		[SerializeField]
		private EJKOMFHKOCA scrollAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private ScrollingAudioPaletteAsset DCNDFKOJJGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private BHLGJFAOJLK LGEKHNMLGIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private MKEBMMDCPPL BDPOMOELBLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private float FDKFAHILEAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private float KPDNFJALFLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private float OCKADPFGJJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private bool OAJAIHFMDFP;

		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		private const float MKAFPCLEOOB = 0.01f;

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		private BHLGJFAOJLK CBDCJGNKLKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x64EFEA0", Offset = "0x64EF2A0", VA = "0x1864EFEA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		private MKEBMMDCPPL HLDBBFIDHLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x64F01F0", Offset = "0x64EF5F0", VA = "0x1864F01F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x64EFA20", Offset = "0x64EEE20", VA = "0x1864EFA20", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x64F0F80", Offset = "0x64F0380", VA = "0x1864F0F80", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x64EF940", Offset = "0x64EED40", VA = "0x1864EF940", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x64EFF10", Offset = "0x64EF310", VA = "0x1864EFF10")]
		private void MKHOAAHIGPM(Vector2 JCADPOBEOPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x64EFC30", Offset = "0x64EF030", VA = "0x1864EFC30")]
		private void DGLHPIPMPAK(float JEGOOPIFPAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x64F0260", Offset = "0x64EF660", VA = "0x1864F0260")]
		private void NBDPJFEKCKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x64F0E60", Offset = "0x64F0260", VA = "0x1864F0E60")]
		private static string NIKLCFMGFDF(GameObject ECLCDMJMICA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x64F1070", Offset = "0x64F0470", VA = "0x1864F1070")]
		public ScrollRectTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public abstract class SelectableThemeBase : PaletteThemeReference, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IPointerClickHandler, IPointerEnterHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		[Header("Selectable Theme Base")]
		[SerializeField]
		[ECFGBFMBKFJ(BLCCKOBNIPN.Self, false, false, false)]
		[FormerlySerializedAs("button")]
		private Selectable selectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		[FormerlySerializedAs("overrideAudio")]
		[Tooltip("Override base selectable audio with a single SFX that plays only on click.")]
		[Header("Legacy Audio Override")]
		[SerializeField]
		protected bool overrideWithSingleAudio;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		[SerializeField]
		[EHJLCGPCADH("overrideWithSingleAudio")]
		[Tooltip("The legacy override audio will be randomly picked from this pool")]
		protected RecRoomAudioClip[] randomAudioOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		protected bool JNFHLFGBLJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private ButtonAudioPaletteAsset DCNDFKOJJGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		private RecRoomAudioClipPoolConfig BNBALBJOAPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		private EFHEONJKJKH FGPGJEBGJKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		private EFHEONJKJKH NKKJKIPFADN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		private EFHEONJKJKH CLGMDPBEKMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		private EFHEONJKJKH GMHMFDNACCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		private BHLGJFAOJLK LGEKHNMLGIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		private LOJGJANFOID GENCCKEJAJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		private OHFGILFIECP IDFMCJNMPFG;

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		protected Selectable FKOIEDOBAOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x775A80", Offset = "0x774E80", VA = "0x180775A80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		protected virtual bool EJCEHDNBDLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x78C310", Offset = "0x78B710", VA = "0x18078C310", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		public bool CODJMKECLFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x54BCFC0", Offset = "0x54BC3C0", VA = "0x1854BCFC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x54BD260", Offset = "0x54BC660", VA = "0x1854BD260")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		private BHLGJFAOJLK CBDCJGNKLKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x64F1460", Offset = "0x64F0860", VA = "0x1864F1460")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		protected LOJGJANFOID GAIKOINNEEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x64F11B0", Offset = "0x64F05B0", VA = "0x1864F11B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		private OHFGILFIECP FEAELGJMEJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x64F13E0", Offset = "0x64F07E0", VA = "0x1864F13E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x64F1220", Offset = "0x64F0620", VA = "0x1864F1220")]
		protected void CJMEBBOAOPF(ButtonAudioPaletteAsset ILPBJDDKDAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x770CF0", Offset = "0x7700F0", VA = "0x180770CF0")]
		protected void NOMOLDDKOEH(RecRoomAudioClipPoolConfig PFGCMMLBDCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x64F1C60", Offset = "0x64F1060", VA = "0x1864F1C60", Slot = "12")]
		public virtual void OnPointerDown(PointerEventData LHEBENHACBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x64F1ED0", Offset = "0x64F12D0", VA = "0x1864F1ED0", Slot = "13")]
		public virtual void OnPointerUp(PointerEventData LHEBENHACBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x64F18B0", Offset = "0x64F0CB0", VA = "0x1864F18B0", Slot = "14")]
		public virtual void OnPointerClick(PointerEventData LHEBENHACBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x64F1DA0", Offset = "0x64F11A0", VA = "0x1864F1DA0", Slot = "15")]
		public virtual void OnPointerEnter(PointerEventData LHEBENHACBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x64F1320", Offset = "0x64F0720", VA = "0x1864F1320")]
		private void HDEMLDBGHOJ(RecRoomAudioClip[] KPBDDNJIMGH, bool CMOJINGMDCH = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x64F14D0", Offset = "0x64F08D0", VA = "0x1864F14D0")]
		private void LCJBNNKBKGG(RecRoomAudioClip JMEHENBEBKG, bool CMOJINGMDCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x64F2040", Offset = "0x64F1440", VA = "0x1864F2040")]
		public void SetOnPointerDownSoundEffectDisabled(object NOEAHPPKHNC, bool LOPBMPDLBKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x64F20A0", Offset = "0x64F14A0", VA = "0x1864F20A0")]
		public void SetOnPointerUpSoundEffectDisabled(object NOEAHPPKHNC, bool LOPBMPDLBKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x64F2010", Offset = "0x64F1410", VA = "0x1864F2010")]
		public void SetOnPointerClickSoundEffectDisabled(object NOEAHPPKHNC, bool LOPBMPDLBKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x64F2070", Offset = "0x64F1470", VA = "0x1864F2070")]
		public void SetOnPointerEnterSoundEffectDisabled(object NOEAHPPKHNC, bool LOPBMPDLBKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x64F13A0", Offset = "0x64F07A0", VA = "0x1864F13A0")]
		private void HFLMFDGFFPB(EFHEONJKJKH EPHAFPGCGBK, object NOEAHPPKHNC, bool LOPBMPDLBKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x64F20D0", Offset = "0x64F14D0", VA = "0x1864F20D0")]
		protected SelectableThemeBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public class SliderTheme : SelectableThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		[Header("Slider Visual")]
		[SerializeField]
		[ECFGBFMBKFJ(BLCCKOBNIPN.Self, false, false, false)]
		private Slider slider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		[SerializeField]
		private GODDGOBOBKD sliderType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		[Header("Slider Audio")]
		[SerializeField]
		private PMNDCFNODBE buttonAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		[SerializeField]
		[Tooltip("Layer a 2D SFX on top of base button sounds")]
		private bool useFlavorSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		[SerializeField]
		[EHJLCGPCADH("useFlavorSFX")]
		[Tooltip("Flavor SFX is picked randomly from this pool config")]
		private RecRoomAudioClipPoolConfig flavorSFXClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		[SerializeField]
		private Image sliderImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		[SerializeField]
		private Image fillImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		[SerializeField]
		private Image handleImage;

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		public GODDGOBOBKD AMKPDPMCFCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x770C80", Offset = "0x770080", VA = "0x180770C80")]
			get
			{
				return default(GODDGOBOBKD);
			}
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x64F26B0", Offset = "0x64F1AB0", VA = "0x1864F26B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		public Image CNOFJDNGALE
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x7701E0", Offset = "0x76F5E0", VA = "0x1807701E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		public Image PHLEEGMLEHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x9641D0", Offset = "0x9635D0", VA = "0x1809641D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public Image BCAIBHJJHEJ
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x8C2AE0", Offset = "0x8C1EE0", VA = "0x1808C2AE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x64F22E0", Offset = "0x64F16E0", VA = "0x1864F22E0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x64F2690", Offset = "0x64F1A90", VA = "0x1864F2690")]
		public SliderTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class SurfaceTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		[SerializeField]
		[ECFGBFMBKFJ(BLCCKOBNIPN.Self, false, false, false)]
		private Image image;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		[SerializeField]
		[ABALMBEBCPA(BLCCKOBNIPN.Self, false, false, false)]
		private UIGradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		[SerializeField]
		private BGONDFIOOJH color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		[SerializeField]
		[EHJLCGPCADH("gradient")]
		private bool ignoreGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		[SerializeField]
		[Tooltip("The surface theme determines if this Image is a RaycastTarget or not. There are times when you might want to ignore that setting of the palette theme and just respect whatever is the default state on the Image.")]
		private bool ignoreSettingRaycastTarget;

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public BGONDFIOOJH FPEJFKCGMED
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x775A60", Offset = "0x774E60", VA = "0x180775A60")]
			get
			{
				return default(BGONDFIOOJH);
			}
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x64F2930", Offset = "0x64F1D30", VA = "0x1864F2930")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x64F26D0", Offset = "0x64F1AD0", VA = "0x1864F26D0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x772DA0", Offset = "0x7721A0", VA = "0x180772DA0")]
		public SurfaceTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class SwitchTheme : ToggleTheme
	{
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private const float GNOOMFEHEJH = 0.33f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		[Header("Switch")]
		[SerializeField]
		private GameObject indicator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		[SerializeField]
		private GameObject indicatorOffPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		[SerializeField]
		private GameObject indicatorOnPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private EKGANFHKHGM IJFPGELFGDC;

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x64F2950", Offset = "0x64F1D50", VA = "0x1864F2950", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x64F2BB0", Offset = "0x64F1FB0", VA = "0x1864F2BB0")]
		public SwitchTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public class TilerTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		[SerializeField]
		[ECFGBFMBKFJ(BLCCKOBNIPN.Self, false, false, false)]
		private UITiler tiler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		[SerializeField]
		private HPGKMLBGIPP type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		private IIOIEIINGDJ KDCAECPEIKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		private HEHEJMPHDCF ABMCDJGDKMC;

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		private HEHEJMPHDCF NAHMCEPJPIN
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x64F3790", Offset = "0x64F2B90", VA = "0x1864F3790")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		private EHJCHDLGKEC FBAHKLGCBIL
		{
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x64F3690", Offset = "0x64F2A90", VA = "0x1864F3690")]
			get
			{
				return default(EHJCHDLGKEC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x64F3620", Offset = "0x64F2A20", VA = "0x1864F3620", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x64F3270", Offset = "0x64F2670", VA = "0x1864F3270", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x772DA0", Offset = "0x7721A0", VA = "0x180772DA0")]
		public TilerTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public class ToggleTheme : ButtonThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		[Header("Toggle Visual")]
		[SerializeField]
		private PNNNHDBLHFB toggleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		[SerializeField]
		[Tooltip("A list of objects to show while the toggle is active.")]
		private List<Hideable> hideWhenNotActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		[SerializeField]
		[Tooltip("A list of objects to show while the toggle is inactive")]
		private List<Hideable> hideWhenActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		[SerializeField]
		private bool editorIsActiveOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x151")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		[Header("Toggle Audio")]
		[SerializeField]
		[Tooltip("Override the audio palette when active defined by the toggle's visual with a custom palette")]
		private bool overrideAudioPaletteWhenActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		[Tooltip("Specify a custom config to use for toggle button audio when active")]
		[SerializeField]
		[EHJLCGPCADH("overrideAudioPaletteWhenActive")]
		private ButtonAudioPaletteAsset customButtonAudioConfigWhenActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		[SerializeField]
		[Tooltip("Override the audio palette when inactive defined by the toggle's visual with a custom palette")]
		private bool overrideAudioPaletteWhenInactive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		[SerializeField]
		[EHJLCGPCADH("overrideAudioPaletteWhenInactive")]
		[Tooltip("Specify a custom config to use for toggle button audio when inactive")]
		private ButtonAudioPaletteAsset customButtonAudioConfigWhenInactive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		[SerializeField]
		[Tooltip("Layer a 2D SFX on top of base button sounds. Flavor SFX only plays when toggling from inactive to active")]
		private bool useFlavorSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		[SerializeField]
		[EHJLCGPCADH("useFlavorSFX")]
		[Tooltip("Flavor SFX is picked randomly from this pool config")]
		private RecRoomAudioClipPoolConfig flavorSFXClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		protected bool BLGNAGAKIJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x181")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		private bool HMGCAAPDOGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x182")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		private bool NBCFOIOMFFP;

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public bool KLNEECJHJNP
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x649A7E0", Offset = "0x6499BE0", VA = "0x18649A7E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x64F3CA0", Offset = "0x64F30A0", VA = "0x1864F3CA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public PNNNHDBLHFB IPFNOECFNCA
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x54BC260", Offset = "0x54BB660", VA = "0x1854BC260")]
			get
			{
				return default(PNNNHDBLHFB);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x64E6990", Offset = "0x64E5D90", VA = "0x1864E6990")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		protected override bool EJCEHDNBDLN
		{
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x64F3C10", Offset = "0x64F3010", VA = "0x1864F3C10", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x64F3BD0", Offset = "0x64F2FD0", VA = "0x1864F3BD0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x64F3C60", Offset = "0x64F3060", VA = "0x1864F3C60")]
		public void Toggle()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x64F3C20", Offset = "0x64F3020", VA = "0x1864F3C20")]
		public void Toggle(bool NBCFOIOMFFP, bool BLGNAGAKIJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x64F37F0", Offset = "0x64F2BF0", VA = "0x1864F37F0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x64F2BB0", Offset = "0x64F1FB0", VA = "0x1864F2BB0")]
		public ToggleTheme()
		{
		}
	}
}
namespace Cpp2IlInjected
{
	internal class AddressAttribute : Attribute
	{
		public string RVA;

		public string Offset;

		public string VA;

		public string Slot;
	}
	internal class FieldOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class AttributeAttribute : Attribute
	{
		public string Name;

		public string RVA;

		public string Offset;
	}
	internal class MetadataOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class TokenAttribute : Attribute
	{
		public string Token;
	}
	internal class AnalysisFailedException : Exception
	{
		public AnalysisFailedException(string message)
			: base(message)
		{
		}
	}
}
