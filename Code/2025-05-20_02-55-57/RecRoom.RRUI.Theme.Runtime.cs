using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RRUI.Theme;
using RecRoom.AssetBundles;
using RecRoom.Attributes;
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
	public class FontsConfig : SingletonAddressableScriptableObject<FontsConfig>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		public struct LocalizedFontMaterialOverrideMapping
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000002")]
			public Material NonLocalizedFontOverrideMaterial;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public Material LocalizedFontOverrideMaterial;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		public struct LocalizedFontMapping
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public TMP_FontAsset FontAsset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public TMP_FontAsset LocalizedFontAsset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public LocalizedFontMaterialOverrideMapping[] FontOverrideMaterials;
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class MLPFMCDFIPH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public TMP_FontAsset font;

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public MLPFMCDFIPH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8734770", Offset = "0x8733970", VA = "0x188734770")]
			internal bool LHKPDPOHNFO(LocalizedFontMapping x)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		[Tooltip("Mapping of non-localized font assets to their localized counterparts. By default text fields will forcibly revert to non-localized fonts unless the `AllowsNonLatinCharacters` component is present.")]
		private LocalizedFontMapping[] localizedFontMappings;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8732FC0", Offset = "0x87321C0", VA = "0x188732FC0")]
		public bool DHMKODGEMHH(TMP_FontAsset FAECLBDIGGK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x87333E0", Offset = "0x87325E0", VA = "0x1887333E0")]
		public TMP_FontAsset JBMPKDGDNHE(TMP_FontAsset FAECLBDIGGK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x87331A0", Offset = "0x87323A0", VA = "0x1887331A0")]
		public TMP_FontAsset JBMPKDGDNHE(TMP_FontAsset FAECLBDIGGK, Material OPHEILBKPIA, [Out] Material JFMBAKDHMBL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8733740", Offset = "0x8732940", VA = "0x188733740")]
		public TMP_FontAsset LBNGJKJNKFL(TMP_FontAsset FAECLBDIGGK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8733540", Offset = "0x8732740", VA = "0x188733540")]
		public TMP_FontAsset LBNGJKJNKFL(TMP_FontAsset FAECLBDIGGK, Material OPHEILBKPIA, [Out] Material IPHCPHNPDLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x87330F0", Offset = "0x87322F0", VA = "0x1887330F0")]
		private static bool JBAKPJILKCH(TMP_FontAsset FAECLBDIGGK, LocalizedFontMapping KFHEGGGJAFM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x87338A0", Offset = "0x8732AA0", VA = "0x1887338A0")]
		public FontsConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class ThemesConfig : SingletonAddressableScriptableObject<ThemesConfig>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		private Palette _light;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[SerializeField]
		private Palette _dark;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public Palette Active
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x873DFE0", Offset = "0x873D1E0", VA = "0x18873DFE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x873DF80", Offset = "0x873D180", VA = "0x18873DF80")]
		public ThemesConfig()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct GradientBlock : IEquatable<GradientBlock>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[SerializeField]
		public Gradient normalGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[SerializeField]
		public Gradient highlightedGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[SerializeField]
		public Gradient pressedGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		public Gradient selectedGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[SerializeField]
		public Gradient disabledGradient;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8733980", Offset = "0x8732B80", VA = "0x188733980", Slot = "0")]
		public override bool Equals(object DBCLNEGBNLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8733920", Offset = "0x8732B20", VA = "0x188733920", Slot = "4")]
		public bool Equals(GradientBlock FNJGMJGALLH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8733A60", Offset = "0x8732C60", VA = "0x188733A60", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class MultiGraphicButton : Button
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[SerializeField]
		private List<Graphic> additionalGraphics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[SerializeField]
		private ColorBlock additionalGraphicsColors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[SerializeField]
		private UIGradient backgroundGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[SerializeField]
		private GradientBlock backgroundGradients;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[SerializeField]
		private bool rejectSelectedState;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public List<Graphic> BALNPMLMCML
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xA6F3E0", Offset = "0xA6E5E0", VA = "0x180A6F3E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA6F740", Offset = "0xA6E940", VA = "0x180A6F740")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public ColorBlock HFNLNMBPPBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8735A70", Offset = "0x8734C70", VA = "0x188735A70")]
			get
			{
				return default(ColorBlock);
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8735AF0", Offset = "0x8734CF0", VA = "0x188735AF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public UIGradient HJJCELCJCJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xAC83D0", Offset = "0xAC75D0", VA = "0x180AC83D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xD4F270", Offset = "0xD4E470", VA = "0x180D4F270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public GradientBlock PMKNMDJHFJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8735AC0", Offset = "0x8734CC0", VA = "0x188735AC0")]
			get
			{
				return default(GradientBlock);
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8735B40", Offset = "0x8734D40", VA = "0x188735B40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8735890", Offset = "0x8734A90", VA = "0x188735890", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x87358E0", Offset = "0x8734AE0", VA = "0x1887358E0", Slot = "36")]
		public override void OnSelect(BaseEventData ELJMGFIBFCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8735930", Offset = "0x8734B30", VA = "0x188735930")]
		public void Refresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8735850", Offset = "0x8734A50", VA = "0x188735850")]
		public void ForceHighlighted(bool FONFOEOJBFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8735870", Offset = "0x8734A70", VA = "0x188735870")]
		public void ForceNormal(bool FONFOEOJBFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8735300", Offset = "0x8734500", VA = "0x188735300", Slot = "26")]
		protected override void DoStateTransition(SelectionState HPAPEOOKLIH, bool FONFOEOJBFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8735760", Offset = "0x8734960", VA = "0x188735760")]
		private void FBEHPDLIJDC(Graphic GAHMKJLMGEE, Color JDEGACELEJP, bool FONFOEOJBFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8735660", Offset = "0x8734860", VA = "0x188735660")]
		private void ENEMCJKBMCH(SelectionState HPAPEOOKLIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8735960", Offset = "0x8734B60", VA = "0x188735960")]
		public MultiGraphicButton()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum ALKKBBHFPJP
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	Negative = 1,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	SelectPrimary = 2,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	SelectSidebar = 12,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	SelectCardToggle = 14,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	SelectSidebarInactive = 17,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	ToggleOnSwitch = 18,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	ToggleOffSwitch = 19,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	ToggleChip = 20,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	SliderDefault = 21
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum LCJDHCKEPGJ
{
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	Default
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public enum NIDMDLNFGNG
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	Default
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum MJJJONPFBMN
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
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
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			[SerializeField]
			private ALKKBBHFPJP buttonAudioPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			[SerializeField]
			private ButtonAudioPaletteAsset buttonAudioPaletteConfig;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public ALKKBBHFPJP ButtonAudioPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE3A0", VA = "0x1809EF1A0")]
				get
				{
					return default(ALKKBBHFPJP);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public ButtonAudioPaletteAsset ButtonAudioPaletteConfig
			{
				[Cpp2IlInjected.Token(Token = "0x6000026")]
				[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public ButtonAudioPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public class ScrollingAudioPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			[SerializeField]
			private LCJDHCKEPGJ scrollingAudioPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			[SerializeField]
			private ScrollingAudioPaletteAsset scrollingAudioPaletteConfig;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public LCJDHCKEPGJ ScrollingAudioPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE3A0", VA = "0x1809EF1A0")]
				get
				{
					return default(LCJDHCKEPGJ);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public ScrollingAudioPaletteAsset ScrollingAudioPaletteConfig
			{
				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public ScrollingAudioPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public class ContentLoadingAudioPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			[SerializeField]
			private NIDMDLNFGNG contentLoadingAudioPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			[SerializeField]
			private ContentLoadingAudioPaletteAsset contentLoadingAudioPaletteConfig;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public NIDMDLNFGNG ContentLoadingAudioPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE3A0", VA = "0x1809EF1A0")]
				get
				{
					return default(NIDMDLNFGNG);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public ContentLoadingAudioPaletteAsset ContentLoadingAudioPaletteConfig
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public ContentLoadingAudioPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public class RecyclingAudioPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			[SerializeField]
			private MJJJONPFBMN recyclingAudioPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			[SerializeField]
			private RecyclingAudioPaletteAsset recyclingAudioPaletteConfig;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public MJJJONPFBMN RecyclingAudioPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE3A0", VA = "0x1809EF1A0")]
				get
				{
					return default(MJJJONPFBMN);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public RecyclingAudioPaletteAsset RecyclingAudioPaletteConfig
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public RecyclingAudioPaletteItem()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class HNPIHCIOPDP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public ALKKBBHFPJP buttonAudioPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public HNPIHCIOPDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xDB9200", Offset = "0xDB8400", VA = "0x180DB9200")]
			internal bool DDPHPFODBPB(ButtonAudioPaletteItem buttonAudioPalette)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class FOGHJHCMPKL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public LCJDHCKEPGJ scrollingAudioPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public FOGHJHCMPKL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xDB9200", Offset = "0xDB8400", VA = "0x180DB9200")]
			internal bool ADMKMOAMIGP(ScrollingAudioPaletteItem scrollingAudioPalette)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class KLPJAAEDJLA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public NIDMDLNFGNG contentLoadingAudioPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public KLPJAAEDJLA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xDB9200", Offset = "0xDB8400", VA = "0x180DB9200")]
			internal bool EAMGFEOOCBL(ContentLoadingAudioPaletteItem contentLoadingAudioPalette)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class KLBBNKDLMKN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public MJJJONPFBMN recyclingAudioPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public KLBBNKDLMKN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xDB9200", Offset = "0xDB8400", VA = "0x180DB9200")]
			internal bool OPAAKJKNFLF(RecyclingAudioPaletteItem recyclingAudioPalette)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[SerializeField]
		[NKACJJFOJEK("ButtonAudioPaletteType")]
		private ButtonAudioPaletteItem[] buttonAudioPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[SerializeField]
		[NKACJJFOJEK("ScrollingAudioPaletteType")]
		private ScrollingAudioPaletteItem[] scrollingAudioPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[SerializeField]
		[NKACJJFOJEK("ContentLoadingAudioPaletteType")]
		private ContentLoadingAudioPaletteItem[] contentLoadingAudioPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[SerializeField]
		[NKACJJFOJEK("RecyclingAudioPaletteType")]
		private RecyclingAudioPaletteItem[] recyclingAudioPalettes;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x872FEB0", Offset = "0x872F0B0", VA = "0x18872FEB0")]
		public ButtonAudioPaletteAsset JHFJGCPDGKO(ALKKBBHFPJP INIPCJGGNPD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x872FCD0", Offset = "0x872EED0", VA = "0x18872FCD0")]
		public ScrollingAudioPaletteAsset EGNJPIKNPJD(LCJDHCKEPGJ DIALDKEJDNN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x872FDC0", Offset = "0x872EFC0", VA = "0x18872FDC0")]
		public ContentLoadingAudioPaletteAsset FMIPIBDMIJG(NIDMDLNFGNG FAEJEOHNMJH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x872FFA0", Offset = "0x872F1A0", VA = "0x18872FFA0")]
		public RecyclingAudioPaletteAsset LKKEKFHLHIK(MJJJONPFBMN OFCDLFCKABB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xBC3030", Offset = "0xBC2230", VA = "0x180BC3030")]
		public AudioPalette()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class ButtonAnimationPalette : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[SerializeField]
		private float clickAnimationDuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[SerializeField]
		private float clickAnimationScale;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float ClickAnimationDuration
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xEE8B50", Offset = "0xEE7D50", VA = "0x180EE8B50")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public float ClickAnimationScale
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xD407C0", Offset = "0xD3F9C0", VA = "0x180D407C0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8730120", Offset = "0x872F320", VA = "0x188730120")]
		public ButtonAnimationPalette()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ButtonPalette
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[Header("Background")]
		[SerializeField]
		private Color backgroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[SerializeField]
		[FormerlySerializedAs("colorBlock")]
		private ColorBlock backgroundTints;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		private GradientBlock backgroundGradients;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[Header("Foreground")]
		[SerializeField]
		private Color foregroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[SerializeField]
		private ColorBlock foregroundTints;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[Header("Border")]
		[SerializeField]
		private bool showBorder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[Header("Text")]
		[SerializeField]
		private TextStylePalette textPalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[Header("Audio")]
		[SerializeField]
		private ALKKBBHFPJP audioPalette;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Color BackgroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xF99CD0", Offset = "0xF98ED0", VA = "0x180F99CD0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public ColorBlock BackgroundTints
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x8730240", Offset = "0x872F440", VA = "0x188730240")]
			get
			{
				return default(ColorBlock);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public GradientBlock BackgroundGradients
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x1273CD0", Offset = "0x1272ED0", VA = "0x181273CD0")]
			get
			{
				return default(GradientBlock);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Color ForegroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x10CFA10", Offset = "0x10CEC10", VA = "0x1810CFA10")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public ColorBlock ForegroundTints
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x8730280", Offset = "0x872F480", VA = "0x188730280")]
			get
			{
				return default(ColorBlock);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool ShowBorder
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xDEA320", Offset = "0xDE9520", VA = "0x180DEA320")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public TextStylePalette TextPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xA6F3E0", Offset = "0xA6E5E0", VA = "0x180A6F3E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public ALKKBBHFPJP AudioPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xAAEFC0", Offset = "0xAAE1C0", VA = "0x180AAEFC0")]
			get
			{
				return default(ALKKBBHFPJP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8730140", Offset = "0x872F340", VA = "0x188730140")]
		public ButtonPalette()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class DepthPalette
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		private float depth;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float Depth
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xC22800", Offset = "0xC21A00", VA = "0x180C22800")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public DepthPalette()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class DropdownPalette
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[SerializeField]
		private Color backgroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[SerializeField]
		private Color foregroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[SerializeField]
		private TextStylePalette textPalette;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Color BackgroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xF99CD0", Offset = "0xF98ED0", VA = "0x180F99CD0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public TextStylePalette TextPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x9F2480", Offset = "0x9F1680", VA = "0x1809F2480")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8732930", Offset = "0x8731B30", VA = "0x188732930")]
		public DropdownPalette()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class InputFieldPalette
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[SerializeField]
		private Color backgroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[SerializeField]
		private Color foregroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		private Color placeholderColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		private TextStylePalette textPalette;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Color BackgroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xF99CD0", Offset = "0xF98ED0", VA = "0x180F99CD0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Color ForegroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xD34F00", Offset = "0xD34100", VA = "0x180D34F00")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Color PlaceholderColor
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0xDCD600", Offset = "0xDCC800", VA = "0x180DCD600")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public TextStylePalette TextPalette
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x9F6D90", Offset = "0x9F5F90", VA = "0x1809F6D90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8733F20", Offset = "0x8733120", VA = "0x188733F20")]
		public InputFieldPalette()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class MakerPenToolPalette
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[SerializeField]
		private ButtonPalette buttonPalette;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public ButtonPalette ButtonPalette
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public MakerPenToolPalette()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class MixedTogglePalette
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		private enum EGJKKPBLGFE
		{
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			UseBaseInactive,
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			UseBaseActive,
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			UseCustom
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[SerializeField]
		private BHDJHPJNLKL baseTogglePalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[SerializeField]
		private EGJKKPBLGFE mixedPaletteType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[SerializeField]
		[GLHFIOJNDCO("mixedPaletteType", EGJKKPBLGFE.UseCustom)]
		private ButtonPalette mixedButtonPalette;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8734C50", Offset = "0x8733E50", VA = "0x188734C50")]
		public TogglePalette FHFFOGIMGGF(Palette FCKIJCEFFKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8734C80", Offset = "0x8733E80", VA = "0x188734C80")]
		public ButtonPalette JONKDCGFEOA(Palette FCKIJCEFFKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public MixedTogglePalette()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class Palette : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public class RawImageColorPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			[SerializeField]
			private HBNOGNIDCOF paletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			[SerializeField]
			private Color color;

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			public HBNOGNIDCOF RawImageColorPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000066")]
				[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE3A0", VA = "0x1809EF1A0")]
				get
				{
					return default(HBNOGNIDCOF);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			public Color Color
			{
				[Cpp2IlInjected.Token(Token = "0x6000067")]
				[Cpp2IlInjected.Address(RVA = "0x18E5C10", Offset = "0x18E4E10", VA = "0x1818E5C10")]
				get
				{
					return default(Color);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xA37A20", Offset = "0xA36C20", VA = "0x180A37A20")]
			public RawImageColorPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public class BackgroundColorPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			[SerializeField]
			private NMIEBNGBFHK backgroundColorPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			[SerializeField]
			private Color color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			[SerializeField]
			private Gradient gradient;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			[SerializeField]
			private bool raycastTarget;

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			public NMIEBNGBFHK BackgroundColorPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000069")]
				[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE3A0", VA = "0x1809EF1A0")]
				get
				{
					return default(NMIEBNGBFHK);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			public Color Color
			{
				[Cpp2IlInjected.Token(Token = "0x600006A")]
				[Cpp2IlInjected.Address(RVA = "0x18E5C10", Offset = "0x18E4E10", VA = "0x1818E5C10")]
				get
				{
					return default(Color);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			public Gradient Gradient
			{
				[Cpp2IlInjected.Token(Token = "0x600006B")]
				[Cpp2IlInjected.Address(RVA = "0x9F2510", Offset = "0x9F1710", VA = "0x1809F2510")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			public bool RaycastTarget
			{
				[Cpp2IlInjected.Token(Token = "0x600006C")]
				[Cpp2IlInjected.Address(RVA = "0xA1E2D0", Offset = "0xA1D4D0", VA = "0x180A1E2D0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x8730090", Offset = "0x872F290", VA = "0x188730090")]
			public BackgroundColorPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public class ForegroundColorPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			[SerializeField]
			private DLGMKNADEBL foregroundColorPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			[SerializeField]
			private Color color;

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public DLGMKNADEBL ForegroundColorPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600006E")]
				[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE3A0", VA = "0x1809EF1A0")]
				get
				{
					return default(DLGMKNADEBL);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			public Color Color
			{
				[Cpp2IlInjected.Token(Token = "0x600006F")]
				[Cpp2IlInjected.Address(RVA = "0x18E5C10", Offset = "0x18E4E10", VA = "0x1818E5C10")]
				get
				{
					return default(Color);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x8733900", Offset = "0x8732B00", VA = "0x188733900")]
			public ForegroundColorPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		public class TilerPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			[SerializeField]
			private MMPJEELMCKA tilerPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			[SerializeField]
			private TilerPalette tilerPalette;

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			public MMPJEELMCKA TilerPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000071")]
				[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE3A0", VA = "0x1809EF1A0")]
				get
				{
					return default(MMPJEELMCKA);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			public TilerPalette TilerPalette
			{
				[Cpp2IlInjected.Token(Token = "0x6000072")]
				[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public TilerPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public class TextStylePaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			[SerializeField]
			private LCBCOKFPGHN textStylePaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			[SerializeField]
			private TextStylePalette textStylePalette;

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			public LCBCOKFPGHN TextStylePaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000074")]
				[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE3A0", VA = "0x1809EF1A0")]
				get
				{
					return default(LCBCOKFPGHN);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			public TextStylePalette TextStylePalette
			{
				[Cpp2IlInjected.Token(Token = "0x6000075")]
				[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public TextStylePaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public class TextSizePaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			[SerializeField]
			private GAMCIMBGNMC textSizePaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			[SerializeField]
			private int size;

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			public GAMCIMBGNMC TextSizePaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE3A0", VA = "0x1809EF1A0")]
				get
				{
					return default(GAMCIMBGNMC);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			public int Size
			{
				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0xB834E0", Offset = "0xB826E0", VA = "0x180B834E0")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x12F1590", Offset = "0x12F0790", VA = "0x1812F1590")]
			public TextSizePaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public class ButtonPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			[SerializeField]
			private BMNAMJOLGDK buttonPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			[SerializeField]
			private ButtonPalette buttonPalette;

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			public BMNAMJOLGDK ButtonPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE3A0", VA = "0x1809EF1A0")]
				get
				{
					return default(BMNAMJOLGDK);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			public ButtonPalette ButtonPalette
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public ButtonPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public class TogglePaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			[SerializeField]
			private BHDJHPJNLKL togglePaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			[SerializeField]
			private TogglePalette togglePalette;

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public BHDJHPJNLKL TogglePaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600007D")]
				[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE3A0", VA = "0x1809EF1A0")]
				get
				{
					return default(BHDJHPJNLKL);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public TogglePalette TogglePalette
			{
				[Cpp2IlInjected.Token(Token = "0x600007E")]
				[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public TogglePaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public class MixedTogglePaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			[SerializeField]
			private INMGBEBIABE mixedTogglePaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			[SerializeField]
			private MixedTogglePalette mixedTogglePalette;

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public INMGBEBIABE MixedTogglePaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000080")]
				[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE3A0", VA = "0x1809EF1A0")]
				get
				{
					return default(INMGBEBIABE);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public MixedTogglePalette MixedTogglePalette
			{
				[Cpp2IlInjected.Token(Token = "0x6000081")]
				[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public MixedTogglePaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public class MakerPenToolPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			[SerializeField]
			private DOACINAHKND makerPenToolPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			[SerializeField]
			private MakerPenToolPalette makerPenToolPalette;

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public DOACINAHKND MakerPenToolPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000083")]
				[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE3A0", VA = "0x1809EF1A0")]
				get
				{
					return default(DOACINAHKND);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public MakerPenToolPalette MakerPenToolPalette
			{
				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public MakerPenToolPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public class InputFieldPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			[SerializeField]
			private JHNJMKBMECO inputFieldPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			[SerializeField]
			private InputFieldPalette inputFieldPalette;

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public JHNJMKBMECO InputFieldPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000086")]
				[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE3A0", VA = "0x1809EF1A0")]
				get
				{
					return default(JHNJMKBMECO);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public InputFieldPalette InputFieldPalette
			{
				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public InputFieldPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public class DropdownPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			[SerializeField]
			private CHNNKKBMDJM dropdownPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			[SerializeField]
			private DropdownPalette dropdownPalette;

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public CHNNKKBMDJM DropdownPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE3A0", VA = "0x1809EF1A0")]
				get
				{
					return default(CHNNKKBMDJM);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public DropdownPalette DropdownPalette
			{
				[Cpp2IlInjected.Token(Token = "0x600008A")]
				[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public DropdownPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public class SliderPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			[SerializeField]
			private KJLMALPAGIM sliderPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			[SerializeField]
			private SliderPalette sliderPalette;

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public KJLMALPAGIM SliderPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600008C")]
				[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE3A0", VA = "0x1809EF1A0")]
				get
				{
					return default(KJLMALPAGIM);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public SliderPalette SliderPalette
			{
				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public SliderPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public class DepthPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			[SerializeField]
			private IFKJAMLMAOK depthPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			[SerializeField]
			private DepthPalette depthPalette;

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			public IFKJAMLMAOK DepthPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE3A0", VA = "0x1809EF1A0")]
				get
				{
					return default(IFKJAMLMAOK);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public DepthPalette DepthPalette
			{
				[Cpp2IlInjected.Token(Token = "0x6000090")]
				[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public DepthPaletteItem()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private sealed class GNFDAPFAHLE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public HBNOGNIDCOF backgroundColorPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public GNFDAPFAHLE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xDB9200", Offset = "0xDB8400", VA = "0x180DB9200")]
			internal bool NLCOFEOMJOO(RawImageColorPaletteItem pi)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private sealed class IFBIKCNFCFA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public NMIEBNGBFHK backgroundColorPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public IFBIKCNFCFA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xDB9200", Offset = "0xDB8400", VA = "0x180DB9200")]
			internal bool MHHLMMFLHAM(BackgroundColorPaletteItem backgroundColorPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class CJAHDDIFKEO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public DLGMKNADEBL foregroundColorPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public CJAHDDIFKEO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xDB9200", Offset = "0xDB8400", VA = "0x180DB9200")]
			internal bool CEKFLJJEELJ(ForegroundColorPaletteItem colorPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class LFNJMKPDGIH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public MMPJEELMCKA type;

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public LFNJMKPDGIH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xDB9200", Offset = "0xDB8400", VA = "0x180DB9200")]
			internal bool NHNJNEAPGPC(TilerPaletteItem tilerPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[CompilerGenerated]
		private sealed class HIDIFIMAHEE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public LCBCOKFPGHN textStylePaletteType;

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public HIDIFIMAHEE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0xDB9200", Offset = "0xDB8400", VA = "0x180DB9200")]
			internal bool CJAMJLOJHEM(TextStylePaletteItem textStylePaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		[CompilerGenerated]
		private sealed class NGMHIIDKIFD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public GAMCIMBGNMC textSizePaletteType;

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public NGMHIIDKIFD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0xDB9200", Offset = "0xDB8400", VA = "0x180DB9200")]
			internal bool BICDIBMDNPI(TextSizePaletteItem textSizePaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class EBEMALBPBBP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public BMNAMJOLGDK buttonPaletteType;

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public EBEMALBPBBP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xDB9200", Offset = "0xDB8400", VA = "0x180DB9200")]
			internal bool KELMFHAOJFE(ButtonPaletteItem buttonPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class BEFMFGABBJJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public BHDJHPJNLKL togglePaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public BEFMFGABBJJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xDB9200", Offset = "0xDB8400", VA = "0x180DB9200")]
			internal bool DGNKHNOHOCF(TogglePaletteItem togglePaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000035")]
		[CompilerGenerated]
		private sealed class PODKNIGBEPC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public INMGBEBIABE mixedTogglePaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public PODKNIGBEPC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xDB9200", Offset = "0xDB8400", VA = "0x180DB9200")]
			internal bool JBIENAADFNF(MixedTogglePaletteItem mixedTogglePaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000036")]
		[CompilerGenerated]
		private sealed class KKDLPGEAALH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public DOACINAHKND makerPenToolPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public KKDLPGEAALH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xDB9200", Offset = "0xDB8400", VA = "0x180DB9200")]
			internal bool HBJFDHCINLM(MakerPenToolPaletteItem makerPenToolPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[CompilerGenerated]
		private sealed class HGAAAAKFFDK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public JHNJMKBMECO inputFieldPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public HGAAAAKFFDK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xDB9200", Offset = "0xDB8400", VA = "0x180DB9200")]
			internal bool IPFJIHHDFDB(InputFieldPaletteItem inputFieldPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		[CompilerGenerated]
		private sealed class ACNFPJANMDI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public CHNNKKBMDJM dropdownPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public ACNFPJANMDI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xDB9200", Offset = "0xDB8400", VA = "0x180DB9200")]
			internal bool HOBKPLFDJLO(DropdownPaletteItem dropdownPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000039")]
		[CompilerGenerated]
		private sealed class LLJEFNLOFFB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public KJLMALPAGIM sliderPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public LLJEFNLOFFB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xDB9200", Offset = "0xDB8400", VA = "0x180DB9200")]
			internal bool KCMIONMDDAJ(SliderPaletteItem sliderPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		[CompilerGenerated]
		private sealed class MCBFIIACICD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public IFKJAMLMAOK depthPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public MCBFIIACICD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xDB9200", Offset = "0xDB8400", VA = "0x180DB9200")]
			internal bool HIGAMCDFCNF(DepthPaletteItem depthPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[Header("Visual")]
		[SerializeField]
		[NKACJJFOJEK("RawImageColorPaletteType")]
		private RawImageColorPaletteItem[] rawImageColorPaletteItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[SerializeField]
		[NKACJJFOJEK("BackgroundColorPaletteType")]
		private BackgroundColorPaletteItem[] backgroundColorPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[SerializeField]
		[NKACJJFOJEK("ForegroundColorPaletteType")]
		private ForegroundColorPaletteItem[] foregroundColorPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[SerializeField]
		[NKACJJFOJEK("TilerPaletteType")]
		private TilerPaletteItem[] tilerPaletteItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[SerializeField]
		[NKACJJFOJEK("TextStylePaletteType")]
		private TextStylePaletteItem[] textStylePalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[SerializeField]
		[NKACJJFOJEK("TextSizePaletteType")]
		private TextSizePaletteItem[] textSizePalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[SerializeField]
		[NKACJJFOJEK("ButtonPaletteType")]
		private ButtonPaletteItem[] buttonPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[SerializeField]
		[NKACJJFOJEK("TogglePaletteType")]
		private TogglePaletteItem[] togglePalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[SerializeField]
		[NKACJJFOJEK("MixedTogglePaletteType")]
		private MixedTogglePaletteItem[] mixedTogglePalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[SerializeField]
		[NKACJJFOJEK("MakerPenToolPaletteType")]
		private MakerPenToolPaletteItem[] makerPenToolPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[SerializeField]
		[NKACJJFOJEK("InputFieldPaletteType")]
		private InputFieldPaletteItem[] inputFieldPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[SerializeField]
		[NKACJJFOJEK("DropdownPaletteType")]
		private DropdownPaletteItem[] dropdownPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[SerializeField]
		[NKACJJFOJEK("SliderPaletteType")]
		private SliderPaletteItem[] sliderPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[SerializeField]
		[NKACJJFOJEK("DepthPaletteType")]
		private DepthPaletteItem[] depthPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[SerializeField]
		private ButtonAnimationPalette buttonAnimationPalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[Header("Audio")]
		[SerializeField]
		[FormerlySerializedAs("audioPaletteConfig")]
		private AudioPalette audioPalette;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public IEnumerable<DepthPaletteItem> DepthPalettes
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x9F94E0", Offset = "0x9F86E0", VA = "0x1809F94E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public ButtonAnimationPalette ButtonAnimationPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x9F9460", Offset = "0x9F8660", VA = "0x1809F9460")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public AudioPalette AudioPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xBE1AD0", Offset = "0xBE0CD0", VA = "0x180BE1AD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8738050", Offset = "0x8737250", VA = "0x188738050")]
		public Color HDLBCCDCDMA(HBNOGNIDCOF NLHEBNEGLFC)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8738520", Offset = "0x8737720", VA = "0x188738520")]
		public void KOOJNLOFOLK(NMIEBNGBFHK NLHEBNEGLFC, [Out] Color EKKMKLFENBL, [Out] Gradient MONGOOHGBNC, [Out] bool OLEEHCJHIBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8738240", Offset = "0x8737440", VA = "0x188738240")]
		public Color JFCAHOFCKPK(DLGMKNADEBL OOOJKPMOFDN)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8738870", Offset = "0x8737A70", VA = "0x188738870")]
		public TilerPalette MHINGJJOABA(MMPJEELMCKA EDLOHJEBKFM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8737C90", Offset = "0x8736E90", VA = "0x188737C90")]
		public TextStylePalette ADBDGHODBCF(LCBCOKFPGHN POANADNKGJH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8737D80", Offset = "0x8736F80", VA = "0x188737D80")]
		public int AMMACPIJBGB(GAMCIMBGNMC JCDNBADDJNO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8737E70", Offset = "0x8737070", VA = "0x188737E70")]
		public ButtonPalette CGHPAFBECCD(BMNAMJOLGDK BJDFIBFBJEF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8738780", Offset = "0x8737980", VA = "0x188738780")]
		public TogglePalette MGKMEKOINPJ(BHDJHPJNLKL MBJBFJOLIOK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8738340", Offset = "0x8737540", VA = "0x188738340")]
		public MixedTogglePalette JGCKKFJKMLP(INMGBEBIABE CFCPKHLJOMI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8737F60", Offset = "0x8737160", VA = "0x188737F60")]
		public MakerPenToolPalette FPKICJCDOBC(DOACINAHKND EPOCHBNBJOP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8738690", Offset = "0x8737890", VA = "0x188738690")]
		public InputFieldPalette LECMOOJGJNM(JHNJMKBMECO AEDFKIHFAJL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8738150", Offset = "0x8737350", VA = "0x188738150")]
		public DropdownPalette INCLHDFKPDG(CHNNKKBMDJM HCHINANBGKM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8738430", Offset = "0x8737630", VA = "0x188738430")]
		public SliderPalette JPHAFBBNFHD(KJLMALPAGIM MELKKEDLCOA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8738960", Offset = "0x8737B60", VA = "0x188738960")]
		public float? NDGBAAKMLCN(IFKJAMLMAOK BNAEJEHBNEG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xBC3030", Offset = "0xBC2230", VA = "0x180BC3030")]
		public Palette()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public class SliderPalette
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[SerializeField]
		private Color sliderColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[SerializeField]
		private Color fillColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[SerializeField]
		private Color handleColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[SerializeField]
		private TextStylePalette textPalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[SerializeField]
		private Color textColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[SerializeField]
		private ColorBlock colorBlock;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public Color SliderColor
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xF99CD0", Offset = "0xF98ED0", VA = "0x180F99CD0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public Color FillColor
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xD34F00", Offset = "0xD34100", VA = "0x180D34F00")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public Color HandleColor
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xDCD600", Offset = "0xDCC800", VA = "0x180DCD600")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public ColorBlock ColorBlock
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x873D0A0", Offset = "0x873C2A0", VA = "0x18873D0A0")]
			get
			{
				return default(ColorBlock);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x873CFE0", Offset = "0x873C1E0", VA = "0x18873CFE0")]
		public SliderPalette()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public class TextStylePalette
	{
		[Cpp2IlInjected.Token(Token = "0x200003D")]
		public enum EBECLFLGHPK
		{
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			None,
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			LowerCase,
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			UpperCase,
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			SmallCaps
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[SerializeField]
		private TMP_FontAsset font;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[SerializeField]
		private Material fontOverrideMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		[SerializeField]
		private float kerning;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[SerializeField]
		private float leading;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[SerializeField]
		private bool isBold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[SerializeField]
		private bool isItalic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[SerializeField]
		private EBECLFLGHPK transformation;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x873DA80", Offset = "0x873CC80", VA = "0x18873DA80")]
		public void GBAAOFGLFBB(TextMeshProUGUI LEKIIKLMLBK, bool KLKFONFFPGI = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public TextStylePalette()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public class TilerPalette
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[SerializeField]
		private Sprite sprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[SerializeField]
		private Color tintColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[SerializeField]
		private Color backgroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[SerializeField]
		private float rows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[SerializeField]
		private Vector2 spacing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[SerializeField]
		private float offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		[SerializeField]
		private Vector2 velocity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		[SerializeField]
		[Range(0f, 360f)]
		private float angle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		[SerializeField]
		private UITiler.BJKKKJBCPCH animationDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		[SerializeField]
		private float primaryAnimationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		[SerializeField]
		private float altAnimationSpeed;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public Sprite Sprite
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public Color TintColor
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xC12DF0", Offset = "0xC11FF0", VA = "0x180C12DF0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public Color BackgroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x12A6210", Offset = "0x12A5410", VA = "0x1812A6210")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public float Rows
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xC07D70", Offset = "0xC06F70", VA = "0x180C07D70")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public Vector2 Spacing
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xEBA5C0", Offset = "0xEB97C0", VA = "0x180EBA5C0")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public float Offset
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xCEB7F0", Offset = "0xCEA9F0", VA = "0x180CEB7F0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public Vector2 Velocity
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x873E060", Offset = "0x873D260", VA = "0x18873E060")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public float Angle
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x10CFA70", Offset = "0x10CEC70", VA = "0x1810CFA70")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public UITiler.BJKKKJBCPCH AnimationDirection
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x113E9A0", Offset = "0x113DBA0", VA = "0x18113E9A0")]
			get
			{
				return default(UITiler.BJKKKJBCPCH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public float PrimaryAnimationSpeed
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x10CFA60", Offset = "0x10CEC60", VA = "0x1810CFA60")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public float AltAnimationSpeed
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x10CFAA0", Offset = "0x10CECA0", VA = "0x1810CFAA0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x873E010", Offset = "0x873D210", VA = "0x18873E010")]
		public TilerPalette()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public class TogglePalette
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		[SerializeField]
		private ButtonPalette inactiveButtonPalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		[SerializeField]
		private ButtonPalette activeButtonPalette;

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public ButtonPalette InactiveButtonPalette
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public ButtonPalette ActiveButtonPalette
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public TogglePalette()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public enum NMIEBNGBFHK
{
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	PrimarySolid,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	SecondarySolid,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	HighlightSolid,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	HighlightGradient,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	BannerBG,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	InputField,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	LineColor,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	CardImageBase,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	DarkGradient,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	Shadow,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	Error,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	Warning,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	NotiBase,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	BackgroundAccent,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	SideBarBG,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	Modified,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	LoadingScreen,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	LoadingBarGradient,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	HomeButtonBase,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	TitleRoot,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	HighlightedAccent,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	LoadingCard,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	ChipBase,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	LimitedEventCard,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	LimitedEventBgSolid,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	DateChip,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	WinterWonderlandBG,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	RuntimeAddedTag,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	RuntimeDeletedTag,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	MakerAI,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	RRPlus
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public enum HBNOGNIDCOF
{
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	A
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public enum DLGMKNADEBL
{
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	MainPrimary,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	MainSecondary,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	InversePrimary,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	NotUse,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	WhitePrimary,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	WhiteSecondary,
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	CardPrimary,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	CardSecondary,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	Error,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	Modified,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	Orange
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public enum MMPJEELMCKA
{
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	WatchBackground,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	HomePage,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	DialogPage,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	Card,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	ProfileBG,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	WinterWonderlandHome
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public enum LCBCOKFPGHN
{
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	JostMedium,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	JostMediumCap,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	JostBoldCap,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	RobotoReg,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	RobotoBold,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	RobotoBoldOutlineDropshadow,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	RobotoBoldOutline,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	RobotoBoldOutlineDropshadowGradient,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	RobotoBoldOutlineGradient
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public enum GAMCIMBGNMC
{
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	XXXS = -1,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	XXS = 0,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	XS = 1,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	S = 2,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	M = 3,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	L = 4,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	XL = 5,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	XXL = 8,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	XXXL = 6,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	XXXXL = 7
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public enum BMNAMJOLGDK
{
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	Primary,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	Secondary,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	FlatPrimary,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	FlatButtonForWarningBanner,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	Negative,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	Chips,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	CarouselArrowDark,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	FlatWhite,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	MagicDoor,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	Tertiary_DupeWith2NDHeader_NeedReplace,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	CarouselArrowLight,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	HomePageMainButton,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	DropDown,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	SecondaryHeaderSection,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	ChatButton,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	FeedButton,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	NameTag,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	RoomCurrency,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	ChipsWhite,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	UGCBaseButton,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	UGCBaseButton_Subtle_NoDisabledState,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	RevenuePurchaseGreen
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public enum BHDJHPJNLKL
{
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	FlatOrange,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	FlatWhite,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	InputToggle,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	Chips,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	Switch,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	WhitePagingBlob,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	RSVPToggleHeaderSection,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	CardSelectableToggle,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	ChipsDark,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	MainNavToggle,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	ListItem,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	NotiUnread,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	FlatPrimary,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	CharadePen,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	ShareCam,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	CardSelectableToggleWithBacking,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	SecondaryHeaderSectionToggle,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	PrimaryToSecondaryHeader,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	NegativeToSecondaryHeader,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	LimitedEventPrimary,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	LimitedEventSecondary,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	RoomCardWithLimitedEvent,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	MainNavVrDetach,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	HomeMainNav,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	FlatOrangeSecondary,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	ChipsPurple
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public enum INMGBEBIABE
{
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	Checkbox
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public enum DOACINAHKND
{
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	Create,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	Select,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	Wire,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	Configure,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	Transform,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	Move,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	Rotate,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	Scale,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	CloneFlip,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	Recolor,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	Freeze,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	MakeInvention,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	Manipulate,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	Delete,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	SelectConnect,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	ResetMakerAI
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public enum JHNJMKBMECO
{
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	LightFlat,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	DarkFlat,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	Modified
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public enum CHNNKKBMDJM
{
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	LightFlat,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	DarkFlat
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public enum KJLMALPAGIM
{
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	MirroUIPopUp
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public enum IFKJAMLMAOK
{
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	Base,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	Button,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	Navigation,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	Overlay,
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	Dialog,
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	Toast
}
namespace RRUI.Theme
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public class ApproximationMaskDepthTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		[SerializeField]
		private RectTransform content;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private Vector3? GPKGFKBMPOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private Vector3? FLHHECICJEH;

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x872FBF0", Offset = "0x872EDF0", VA = "0x18872FBF0")]
		private void ILLMBOBOELN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x872F850", Offset = "0x872EA50", VA = "0x18872F850", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x9F0790", Offset = "0x9EF990", VA = "0x1809F0790")]
		public ApproximationMaskDepthTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public class ButtonTheme : ButtonThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		[Header("Button Visual")]
		[SerializeField]
		private BMNAMJOLGDK buttonType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14C")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		[Header("Button Audio")]
		[SerializeField]
		[Tooltip("Override the audio palette defined by the button's visual with a custom palette")]
		private bool overrideButtonAudioPalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		[GLHFIOJNDCO("overrideButtonAudioPalette")]
		[Tooltip("Specify a custom config to use for button audio")]
		[SerializeField]
		private ButtonAudioPaletteAsset customButtonAudioConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		[SerializeField]
		[Tooltip("Layer a 2D SFX on top of base button sounds")]
		private bool useFlavorSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		[SerializeField]
		[GLHFIOJNDCO("useFlavorSFX")]
		[Tooltip("Flavor SFX is picked randomly from this pool config")]
		private RecRoomAudioClipPoolConfig flavorSFXClipPoolConfig;

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public BMNAMJOLGDK AOBILPCAFIO
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0xE86F20", Offset = "0xE86120", VA = "0x180E86F20")]
			get
			{
				return default(BMNAMJOLGDK);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x8731C00", Offset = "0x8730E00", VA = "0x188731C00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x8731990", Offset = "0x8730B90", VA = "0x188731990", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0xAF0F20", Offset = "0xAF0120", VA = "0x180AF0F20")]
		public void SetAnimationEnabled(bool PGGLOGHIPPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x8731BF0", Offset = "0x8730DF0", VA = "0x188731BF0")]
		public ButtonTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public abstract class ButtonThemeBase : SelectableThemeBase
	{
		[Cpp2IlInjected.Token(Token = "0x2000052")]
		protected class OOODADLBAFE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000172")]
			public ButtonAudioPaletteAsset KPDIIOGOJHF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000173")]
			public RecRoomAudioClipPoolConfig PLGLEPEIKIH;

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public OOODADLBAFE()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		[BMOELPNDLIH(HJNEPGJJFOF.Self, false, false, false)]
		[Header("Button Theme Base")]
		[SerializeField]
		private MultiGraphicButton multiGraphicButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		[SerializeField]
		[BMOELPNDLIH(HJNEPGJJFOF.Self, false, true, false)]
		private Image surface;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		[SerializeField]
		private bool useSurfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		[SerializeField]
		[GLHFIOJNDCO("useSurfaceOverride")]
		private Image surfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		[SerializeField]
		private bool controlSurfaceColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		[SerializeField]
		[ReadOnlyField]
		private List<Graphic> graphics;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		[SerializeField]
		private bool useGraphicsOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		[SerializeField]
		[GLHFIOJNDCO("useGraphicsOverride")]
		private List<Graphic> graphicsOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		[SerializeField]
		[HCMOJLMAHOF("useGraphicsOverride", new object[] { })]
		private bool graphicsIgnoreTextFields;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		[SerializeField]
		private bool controlGraphicColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		[SerializeField]
		[BMOELPNDLIH(HJNEPGJJFOF.Self, false, true, false)]
		private UIGradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		[SerializeField]
		private bool useGradientOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		[SerializeField]
		[GLHFIOJNDCO("useGradientOverride")]
		private UIGradient gradientOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		[SerializeField]
		[BMOELPNDLIH(HJNEPGJJFOF.Children, true, true, false)]
		private TextMeshProUGUI textMeshProUGUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		[SerializeField]
		private bool useTextMeshProUGUIOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		[SerializeField]
		[GLHFIOJNDCO("useTextMeshProUGUIOverride")]
		private TextMeshProUGUI textMeshProUGUIOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		[SerializeField]
		private GAMCIMBGNMC textSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		[SerializeField]
		protected Hideable borderHideable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		[SerializeField]
		protected bool isAnimationEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x111")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		[SerializeField]
		[GLHFIOJNDCO("isAnimationEnabled")]
		protected bool overrideAnimationTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		[SerializeField]
		[GLHFIOJNDCO("overrideAnimationTarget")]
		protected GameObject animationTargetOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private bool PKILIMOEKDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private Vector3 MCCOEEPACHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private Vector3 AGHMIHFELAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private MABANDBIMJG IGDKAIIPHNL;

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public Image OANLNNIFNCC
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x8731930", Offset = "0x8730B30", VA = "0x188731930")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public List<Graphic> NOIDFGCOPKB
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x8731910", Offset = "0x8730B10", VA = "0x188731910")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public UIGradient DBBJIFGOFEC
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x87318F0", Offset = "0x8730AF0", VA = "0x1887318F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public TextMeshProUGUI HNMGOEDFCGD
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x8731950", Offset = "0x8730B50", VA = "0x188731950")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public GAMCIMBGNMC BKDNHICCAFA
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x15B6FD0", Offset = "0x15B61D0", VA = "0x1815B6FD0")]
			get
			{
				return default(GAMCIMBGNMC);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x8731970", Offset = "0x8730B70", VA = "0x188731970")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		protected Transform GCOJICFPNOH
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x87302D0", Offset = "0x872F4D0", VA = "0x1887302D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public Button OMKFLPGKOPH
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x8731860", Offset = "0x8730A60", VA = "0x188731860")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8731000", Offset = "0x8730200", VA = "0x188731000")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x8730F60", Offset = "0x8730160", VA = "0x188730F60")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x8730340", Offset = "0x872F540", VA = "0x188730340")]
		protected void NOHBJNNBBCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x8730500", Offset = "0x872F700", VA = "0x188730500")]
		protected void OCJIDIJDOBI(ButtonPalette DPMLDFCPPHE, [Optional] OOODADLBAFE PEANCEIIFLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x87310A0", Offset = "0x87302A0", VA = "0x1887310A0", Slot = "12")]
		public override void OnPointerDown(PointerEventData ELJMGFIBFCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8731450", Offset = "0x8730650", VA = "0x188731450", Slot = "13")]
		public override void OnPointerUp(PointerEventData ELJMGFIBFCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x8731080", Offset = "0x8730280", VA = "0x188731080", Slot = "14")]
		public override void OnPointerClick(PointerEventData ELJMGFIBFCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x8731750", Offset = "0x8730950", VA = "0x188731750")]
		private Vector3 PJOIEBBKBAI(float MMIJFAFPOOH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8731770", Offset = "0x8730970", VA = "0x188731770")]
		protected ButtonThemeBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x8730320", Offset = "0x872F520", VA = "0x188730320")]
		[CompilerGenerated]
		private void IALJDBPOPCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x8730320", Offset = "0x872F520", VA = "0x188730320")]
		[CompilerGenerated]
		private void NNFPMLFFKJI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public class DepthTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		[SerializeField]
		private IFKJAMLMAOK depth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		[SerializeField]
		private bool animateOnEnable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		[SerializeField]
		[GLHFIOJNDCO("animateOnEnable")]
		private float animationTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private Vector3? GPKGFKBMPOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private Vector2 DNDCHEGHIIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private Vector2 BKJPGAJAIMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private Vector2 OFOLBNGLHIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private Vector2 DHGABDIKDIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private Vector2 DOAIPNAANOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private Vector2 AKHMCODPKLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private readonly bool? LAEKOLAIODK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private MNKIDBOAIEG BPHJHPFBCLD;

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		private RectTransform ACIJOEJAPOE
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x8732730", Offset = "0x8731930", VA = "0x188732730")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public IFKJAMLMAOK PHJIIBHJFBE
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0xBFD840", Offset = "0xBFCA40", VA = "0x180BFD840")]
			get
			{
				return default(IFKJAMLMAOK);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x8732910", Offset = "0x8731B10", VA = "0x188732910")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		private MNKIDBOAIEG DHCGMJHJEEH
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x8732260", Offset = "0x8731460", VA = "0x188732260")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		private bool GNJCIBBAJOF
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x8732170", Offset = "0x8731370", VA = "0x188732170")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x87326C0", Offset = "0x87318C0", VA = "0x1887326C0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8732610", Offset = "0x8731810", VA = "0x188732610")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x8731FB0", Offset = "0x87311B0", VA = "0x188731FB0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x87322F0", Offset = "0x87314F0", VA = "0x1887322F0")]
		private void ILLMBOBOELN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x8731C20", Offset = "0x8730E20", VA = "0x188731C20")]
		private Vector3 AMHOCIFLGHG()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x8732790", Offset = "0x8731990", VA = "0x188732790")]
		public DepthTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public class DropdownTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		[SerializeField]
		[GABLABEDCEL(HJNEPGJJFOF.Self, false, false, false)]
		private Dropdown dropdown;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		[SerializeField]
		[BMOELPNDLIH(HJNEPGJJFOF.Self, false, true, false)]
		private Image surface;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		[SerializeField]
		private bool useSurfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		[SerializeField]
		[GLHFIOJNDCO("useSurfaceOverride")]
		private Image surfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		[SerializeField]
		private CHNNKKBMDJM dropdownType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		[SerializeField]
		private GAMCIMBGNMC textSize;

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public Image OANLNNIFNCC
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x8732F70", Offset = "0x8732170", VA = "0x188732F70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public CHNNKKBMDJM MMOLNIOJKNN
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0xBFB9D0", Offset = "0xBFABD0", VA = "0x180BFB9D0")]
			get
			{
				return default(CHNNKKBMDJM);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x8732F80", Offset = "0x8732180", VA = "0x188732F80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public GAMCIMBGNMC BKDNHICCAFA
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xD34EE0", Offset = "0xD340E0", VA = "0x180D34EE0")]
			get
			{
				return default(GAMCIMBGNMC);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x8732FA0", Offset = "0x87321A0", VA = "0x188732FA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x8732950", Offset = "0x8731B50", VA = "0x188732950", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8732F60", Offset = "0x8732160", VA = "0x188732F60")]
		public DropdownTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public class GraphicTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		[SerializeField]
		[GABLABEDCEL(HJNEPGJJFOF.Self, false, false, false)]
		private Graphic graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		[SerializeField]
		private bool useGraphicOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		[SerializeField]
		[GLHFIOJNDCO("useGraphicOverride")]
		private Graphic graphicOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		[SerializeField]
		private DLGMKNADEBL color;

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public Graphic HIMBMEGDKJE
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x8733EF0", Offset = "0x87330F0", VA = "0x188733EF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public DLGMKNADEBL AKCHBFKOHPB
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0xA0E7B0", Offset = "0xA0D9B0", VA = "0x180A0E7B0")]
			get
			{
				return default(DLGMKNADEBL);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x8733F00", Offset = "0x8733100", VA = "0x188733F00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public bool IDBLGNNPIGP
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0xE2D920", Offset = "0xE2CB20", VA = "0x180E2D920")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0xE2D500", Offset = "0xE2C700", VA = "0x180E2D500")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public Color? ONEHGGAFHLC
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x8733CD0", Offset = "0x8732ED0", VA = "0x188733CD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x8733AD0", Offset = "0x8732CD0", VA = "0x188733AD0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x9F0790", Offset = "0x9EF990", VA = "0x1809F0790")]
		public GraphicTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public class InputFieldTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		[SerializeField]
		[GABLABEDCEL(HJNEPGJJFOF.Self, false, false, false)]
		private TMP_InputField inputField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		[SerializeField]
		[BMOELPNDLIH(HJNEPGJJFOF.Self, false, false, false)]
		private Image surface;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		[SerializeField]
		private bool useSurfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		[SerializeField]
		[GLHFIOJNDCO("useSurfaceOverride")]
		private Image surfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		[SerializeField]
		private JHNJMKBMECO inputFieldType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		[SerializeField]
		private GAMCIMBGNMC textSize;

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public Image OANLNNIFNCC
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x8732F70", Offset = "0x8732170", VA = "0x188732F70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public JHNJMKBMECO JLAFLFJBOOA
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0xBFB9D0", Offset = "0xBFABD0", VA = "0x180BFB9D0")]
			get
			{
				return default(JHNJMKBMECO);
			}
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x8732F80", Offset = "0x8732180", VA = "0x188732F80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public GAMCIMBGNMC BKDNHICCAFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0xD34EE0", Offset = "0xD340E0", VA = "0x180D34EE0")]
			get
			{
				return default(GAMCIMBGNMC);
			}
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x8732FA0", Offset = "0x87321A0", VA = "0x188732FA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x8733F50", Offset = "0x8733150", VA = "0x188733F50", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x8732F60", Offset = "0x8732160", VA = "0x188732F60")]
		public InputFieldTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public class LabelTheme : GraphicTheme
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		[SerializeField]
		[GABLABEDCEL(HJNEPGJJFOF.Self, false, false, false)]
		private TextMeshProUGUI textMeshProUGUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		[SerializeField]
		private LCBCOKFPGHN textType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		[SerializeField]
		private GAMCIMBGNMC textSize;

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public LCBCOKFPGHN KIDNAGKJMMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0xE755B0", Offset = "0xE747B0", VA = "0x180E755B0")]
			get
			{
				return default(LCBCOKFPGHN);
			}
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x8734750", Offset = "0x8733950", VA = "0x188734750")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public GAMCIMBGNMC BKDNHICCAFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x1377120", Offset = "0x1376320", VA = "0x181377120")]
			get
			{
				return default(GAMCIMBGNMC);
			}
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x8734730", Offset = "0x8733930", VA = "0x188734730")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x8734420", Offset = "0x8733620", VA = "0x188734420", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x8734720", Offset = "0x8733920", VA = "0x188734720")]
		public LabelTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public class MakerPenToolTheme : ButtonThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		[Header("Maker Pen Tool")]
		[SerializeField]
		private DOACINAHKND makerPenToolPaletteType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		[SerializeField]
		[Tooltip("A list of objects to show while the maker pen tool is active.")]
		private List<Hideable> hideWhenNotActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		[SerializeField]
		[Tooltip("A list of objects to show while the maker pen tool is inactive")]
		private List<Hideable> hideWhenActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		[SerializeField]
		private bool editorIsActiveOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x161")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		protected bool HNEJNCGEBLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x162")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private bool JFAPEJOHLJO;

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public DOACINAHKND EMFOLLCELFA
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0xE86F20", Offset = "0xE86120", VA = "0x180E86F20")]
			get
			{
				return default(DOACINAHKND);
			}
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x8731C00", Offset = "0x8730E00", VA = "0x188731C00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public bool BFDEOBNNJEF
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x8734C20", Offset = "0x8733E20", VA = "0x188734C20")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x8734C30", Offset = "0x8733E30", VA = "0x188734C30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x8734BE0", Offset = "0x8733DE0", VA = "0x188734BE0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x87347F0", Offset = "0x87339F0", VA = "0x1887347F0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x8731BF0", Offset = "0x8730DF0", VA = "0x188731BF0")]
		public MakerPenToolTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public class MixedToggleTheme : ButtonThemeBase
	{
		[Cpp2IlInjected.Token(Token = "0x200005A")]
		public enum EEOJKLHBBNI
		{
			[Cpp2IlInjected.Token(Token = "0x40001A1")]
			Inactive,
			[Cpp2IlInjected.Token(Token = "0x40001A2")]
			Mixed,
			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			Active
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		[SerializeField]
		private INMGBEBIABE toggleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		[SerializeField]
		[Tooltip("A list of objects to hide while the toggle is inactive.")]
		private List<Hideable> hideWhenInactive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		[SerializeField]
		[Tooltip("A list of objects to hide while the toggle is mixed.")]
		private List<Hideable> hideWhenMixed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		[SerializeField]
		[Tooltip("A list of objects to hide while the toggle is active")]
		private List<Hideable> hideWhenActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		[SerializeField]
		private EEOJKLHBBNI editorIsActiveOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private EEOJKLHBBNI JFAPEJOHLJO;

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public EEOJKLHBBNI BFDEOBNNJEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x87352F0", Offset = "0x87344F0", VA = "0x1887352F0")]
			get
			{
				return default(EEOJKLHBBNI);
			}
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x87352D0", Offset = "0x87344D0", VA = "0x1887352D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x87352A0", Offset = "0x87344A0", VA = "0x1887352A0")]
		public void Toggle()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x87352D0", Offset = "0x87344D0", VA = "0x1887352D0")]
		public void Toggle(EEOJKLHBBNI JFAPEJOHLJO, bool HNEJNCGEBLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x8734CF0", Offset = "0x8733EF0", VA = "0x188734CF0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x8731BF0", Offset = "0x8730DF0", VA = "0x188731BF0")]
		public MixedToggleTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class PaletteTheme : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		[SerializeField]
		private bool usePaletteOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		[SerializeField]
		[GLHFIOJNDCO("usePaletteOverride")]
		private Palette paletteOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public JGNOJICCDHE PaletteChangeEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		[SerializeField]
		private bool useDepth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private HCDMAMCBAKB GEFFKAEDCDO;

		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private const string CCDDBGHHBPD = "watch_layer";

		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private const string OHKGPCDAKNN = "depth_multiplier";

		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private const float GKLHCCCFKEB = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private float? MHEPCKOBEEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private float? KEJMHOOINKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private float? NCHPANDBDML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private float BHONKPFDOOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private float PBAELDOCJOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private float KFICAJLDMJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private float CFMFMKEKHAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private readonly IHHCNLCAMGC EGIODPOLKAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private SFXAudioSource CAFEMMNMIGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private SFXAudioSource CLEBMGBMBJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private ContentLoadingAudioPaletteAsset EDGPLIMMLKM;

		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private const float DJAHKGHOLEN = 0.001f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private AAONKAOBFIM JBPFIGLNGHN;

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public Palette DBGJHMPLINC
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x8737BC0", Offset = "0x8736DC0", VA = "0x188737BC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public bool NAEPJMBFJPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0xA1E2D0", Offset = "0xA1D4D0", VA = "0x180A1E2D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public float CDBHOKEPLGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x8737940", Offset = "0x8736B40", VA = "0x188737940")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		private bool KHLBGHMHBDE
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x8737040", Offset = "0x8736240", VA = "0x188737040")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		private bool EMPHHILKEOA
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x87373E0", Offset = "0x87365E0", VA = "0x1887373E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x87365A0", Offset = "0x87357A0", VA = "0x1887365A0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x8736450", Offset = "0x8735650", VA = "0x188736450")]
		private void APKBGBLHMAA(AOAOLGAEKCN.KNACEEKFIOE LAJFCBCGPCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x8737460", Offset = "0x8736660", VA = "0x188737460")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x8736AB0", Offset = "0x8735CB0", VA = "0x188736AB0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x8736C20", Offset = "0x8735E20", VA = "0x188736C20")]
		private void EOOHLCLJMND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x8736480", Offset = "0x8735680", VA = "0x188736480")]
		public void AddLoadingSFXRequest(object PPOILDCNBFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x8737760", Offset = "0x8736960", VA = "0x188737760")]
		public void RemoveLoadingSFXRequest(object PPOILDCNBFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x8736AB0", Offset = "0x8735CB0", VA = "0x188736AB0")]
		private void DEPECOAJJKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x87370C0", Offset = "0x87362C0", VA = "0x1887370C0")]
		private void LGENAACCIMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x8736DE0", Offset = "0x8735FE0", VA = "0x188736DE0")]
		private void GNBBMCAPFDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x87372F0", Offset = "0x87364F0", VA = "0x1887372F0")]
		private void OIAMLHMLICD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x8736840", Offset = "0x8735A40", VA = "0x188736840")]
		private void CHKODDIJCOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x8736F50", Offset = "0x8736150", VA = "0x188736F50")]
		private void ICODCCNNCDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x7DACA80", Offset = "0x7DABC80", VA = "0x187DACA80")]
		private void HAPHGFJHICJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x8736750", Offset = "0x8735950", VA = "0x188736750")]
		private void CDFIPGPLPEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x87372B0", Offset = "0x87364B0", VA = "0x1887372B0")]
		private void MPCMAELLGHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x8737590", Offset = "0x8736790", VA = "0x188737590")]
		public void Play2DUIFlavorSFX(RecRoomAudioClip[] HNFJOGNJMHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x8737880", Offset = "0x8736A80", VA = "0x188737880")]
		public PaletteTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public abstract class PaletteThemeReference : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		[SerializeField]
		[BMOELPNDLIH(HJNEPGJJFOF.SelfAndParent, true, false, false)]
		private PaletteTheme paletteTheme;

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		protected PaletteTheme IOGACOOFPED
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		protected Palette DBGJHMPLINC
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x8735CA0", Offset = "0x8734EA0", VA = "0x188735CA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		protected bool CBLNONKJHLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x87363D0", Offset = "0x87355D0", VA = "0x1887363D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		protected Transform IGJALOPAKNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x8735D80", Offset = "0x8734F80", VA = "0x188735D80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x8735BA0", Offset = "0x8734DA0", VA = "0x188735BA0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x87362F0", Offset = "0x87354F0", VA = "0x1887362F0", Slot = "5")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void Apply();

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x8735E00", Offset = "0x8735000", VA = "0x188735E00")]
		public Color? GetColorFromPalette(DLGMKNADEBL EFOLCIMDKDP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x8735FB0", Offset = "0x87351B0", VA = "0x188735FB0")]
		private void LHBBCOBGPMO(bool CJFPEPGGPKF = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x9F0790", Offset = "0x9EF990", VA = "0x1809F0790")]
		protected PaletteThemeReference()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class RangeSliderTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		[SerializeField]
		[GABLABEDCEL(HJNEPGJJFOF.Self, false, false, false)]
		private RangeSlider slider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		[SerializeField]
		private KJLMALPAGIM sliderType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		[SerializeField]
		private Image sliderImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		[SerializeField]
		private Image fillImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		[SerializeField]
		private Image lowHandleImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		[SerializeField]
		private Image highHandleImage;

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public KJLMALPAGIM HDBKJPEFBIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x9FB3A0", Offset = "0x9FA5A0", VA = "0x1809FB3A0")]
			get
			{
				return default(KJLMALPAGIM);
			}
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x8738D90", Offset = "0x8737F90", VA = "0x188738D90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public Image GADIKLONGOE
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x9F2480", Offset = "0x9F1680", VA = "0x1809F2480")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public Image JLGLLONFGHH
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x9F2500", Offset = "0x9F1700", VA = "0x1809F2500")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public Image DLILBDMJOCL
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x9F6D90", Offset = "0x9F5F90", VA = "0x1809F6D90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public Image OOKLAELICDL
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x9F2450", Offset = "0x9F1650", VA = "0x1809F2450")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public bool DKAOLOKDDJB
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x707A3D0", Offset = "0x70795D0", VA = "0x18707A3D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x707A480", Offset = "0x7079680", VA = "0x18707A480")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x8738A90", Offset = "0x8737C90", VA = "0x188738A90", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x9F0790", Offset = "0x9EF990", VA = "0x1809F0790")]
		public RangeSliderTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public class RawImageTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		[SerializeField]
		[GABLABEDCEL(HJNEPGJJFOF.Self, false, false, false)]
		private RawImage image;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		[SerializeField]
		private HBNOGNIDCOF color;

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public HBNOGNIDCOF MHIKBGJGMMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x9FB3A0", Offset = "0x9FA5A0", VA = "0x1809FB3A0")]
			get
			{
				return default(HBNOGNIDCOF);
			}
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x8738D90", Offset = "0x8737F90", VA = "0x188738D90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x8738DB0", Offset = "0x8737FB0", VA = "0x188738DB0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x9F0790", Offset = "0x9EF990", VA = "0x1809F0790")]
		public RawImageTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class RecyclingGridTheme : RecyclingThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		[SerializeField]
		[GABLABEDCEL(HJNEPGJJFOF.Self, false, false, false)]
		private HPIOBMDDPJP recyclingGrid;

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x8738EE0", Offset = "0x87380E0", VA = "0x188738EE0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x8739150", Offset = "0x8738350", VA = "0x188739150", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x87390E0", Offset = "0x87382E0", VA = "0x1887390E0")]
		private void KFODBCCGHJH(float HFIMOKGKDHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x8739340", Offset = "0x8738540", VA = "0x188739340")]
		public RecyclingGridTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public class RecyclingListTheme : RecyclingThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		[SerializeField]
		[GABLABEDCEL(HJNEPGJJFOF.Self, false, false, false)]
		private HPIOBMDDPJP recyclingList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private bool LCNPDNLJNFJ;

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x87393C0", Offset = "0x87385C0", VA = "0x1887393C0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x8739600", Offset = "0x8738800", VA = "0x188739600", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x8739350", Offset = "0x8738550", VA = "0x188739350")]
		private void AIFBAKPKOHG(float HFIMOKGKDHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x8739340", Offset = "0x8738540", VA = "0x188739340")]
		public RecyclingListTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public abstract class RecyclingThemeBase : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		[Header("Audio")]
		[SerializeField]
		private MJJJONPFBMN recyclingAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		protected RecyclingAudioPaletteAsset NDIFJKPKCOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		[SerializeField]
		private LCJDHCKEPGJ scrollingAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private ScrollingAudioPaletteAsset FNPNNDILEKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		private AAONKAOBFIM HDIMJOOELCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private float EOGEHAPINPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		private float HIAGEDMCNDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private float DLHPCPNHMBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private float LPAMOCJADHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private bool GANFHEBKNJP;

		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private const float BCDBBIGNEFE = 0.01f;

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		private AAONKAOBFIM JBPFIGLNGHN
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x8739800", Offset = "0x8738A00", VA = "0x188739800")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x8739890", Offset = "0x8738A90", VA = "0x188739890", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x8739F40", Offset = "0x8739140", VA = "0x188739F40")]
		protected void HNAMLBHOHEF(bool PCFJJMIHLLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x873A570", Offset = "0x8739770", VA = "0x18873A570")]
		protected void IFBBHPHGALD(GameObject CKEIAGIGCJK, int MKDIPPJBBDB, bool MDIMHFJLIMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x8739A80", Offset = "0x8738C80", VA = "0x188739A80")]
		protected void DLDAPOLDKKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x873A200", Offset = "0x8739400", VA = "0x18873A200")]
		protected void ICKNNIBBEPA(float HFIMOKGKDHG, float NNJEIIOEKPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x8739D50", Offset = "0x8738F50", VA = "0x188739D50")]
		private void GNKAEJKBHPN(float JOIIEIJNMDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x8739C10", Offset = "0x8738E10", VA = "0x188739C10")]
		private void GGHIBDDIEIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x8739340", Offset = "0x8738540", VA = "0x188739340")]
		protected RecyclingThemeBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public class ScrollBarTheme : SelectableThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		[Header("Scroll Bar Audio")]
		[SerializeField]
		private ALKKBBHFPJP buttonAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		[SerializeField]
		[Tooltip("Layer a 2D SFX on top of base button sounds")]
		private bool useFlavorSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		[SerializeField]
		[GLHFIOJNDCO("useFlavorSFX")]
		[Tooltip("Flavor SFX is picked randomly from this pool config")]
		private RecRoomAudioClipPoolConfig flavorSFXClipPoolConfig;

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x873A700", Offset = "0x8739900", VA = "0x18873A700", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x873A820", Offset = "0x8739A20", VA = "0x18873A820")]
		public ScrollBarTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public class ScrollRectTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		private const string AHOJEGFICJL = "RRUI.PlayHittingEndsSFX";

		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private const int JGLPLIDKCHN = 5;

		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private const int CIHBMGGDIAB = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private DateTimeOffset FODJBLMJIMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private int OEOJKLAGLOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private bool ECBAKLFIIBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		[SerializeField]
		[GABLABEDCEL(HJNEPGJJFOF.Self, false, false, false)]
		private ScrollRect scrollRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		[Header("Audio")]
		[SerializeField]
		private LCJDHCKEPGJ scrollAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		private ScrollingAudioPaletteAsset NDIFJKPKCOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		private AAONKAOBFIM HDIMJOOELCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		private JCJNPKLKHAD JNLPNFCDFDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		private float HIAGEDMCNDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private float DLHPCPNHMBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private float LPAMOCJADHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private bool GANFHEBKNJP;

		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private const float BCDBBIGNEFE = 0.01f;

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		private AAONKAOBFIM JBPFIGLNGHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x873A830", Offset = "0x8739A30", VA = "0x18873A830")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		private JCJNPKLKHAD FBPEJAMFOCE
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x873AC50", Offset = "0x8739E50", VA = "0x18873AC50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x873A9A0", Offset = "0x8739BA0", VA = "0x18873A9A0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x873BF40", Offset = "0x873B140", VA = "0x18873BF40", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x873A8C0", Offset = "0x8739AC0", VA = "0x18873A8C0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x873ACE0", Offset = "0x8739EE0", VA = "0x18873ACE0")]
		private void GAGELCNIGBC(Vector2 BJHAAAPCKLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x873BD50", Offset = "0x873AF50", VA = "0x18873BD50")]
		private void GNKAEJKBHPN(float JOIIEIJNMDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x873B160", Offset = "0x873A360", VA = "0x18873B160")]
		private void GGHIBDDIEIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x873AB30", Offset = "0x8739D30", VA = "0x18873AB30")]
		private static string BLKALDFAFJI(GameObject DBCLNEGBNLN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x873C030", Offset = "0x873B230", VA = "0x18873C030")]
		public ScrollRectTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public abstract class SelectableThemeBase : PaletteThemeReference, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IPointerClickHandler, IPointerEnterHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		[Header("Selectable Theme Base")]
		[SerializeField]
		[GABLABEDCEL(HJNEPGJJFOF.Self, false, false, false)]
		[FormerlySerializedAs("button")]
		private Selectable selectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		[Header("Legacy Audio Override")]
		[SerializeField]
		[FormerlySerializedAs("overrideAudio")]
		[Tooltip("Override base selectable audio with a single SFX that plays only on click.")]
		protected bool overrideWithSingleAudio;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		[SerializeField]
		[GLHFIOJNDCO("overrideWithSingleAudio")]
		[Tooltip("The legacy override audio will be randomly picked from this pool")]
		protected RecRoomAudioClip[] randomAudioOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		protected bool PAGKBCHOBAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		private ButtonAudioPaletteAsset NDIFJKPKCOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private RecRoomAudioClipPoolConfig MMLFHILMMMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private IHHCNLCAMGC BCLKAHPHAPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private IHHCNLCAMGC FFPDAIKGAHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private IHHCNLCAMGC JJHAJLALIHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private IHHCNLCAMGC MNIHPJBNMEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private AAONKAOBFIM HDIMJOOELCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private JGDOBJGGKHG MMOKNHLKPGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private PACLKEKNGOF BCKAGBOEMCG;

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		protected Selectable BIDKBDPDELP
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		protected virtual bool ABDONFIECMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0xA0B5F0", Offset = "0xA0A7F0", VA = "0x180A0B5F0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public bool DKAOLOKDDJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x707A3D0", Offset = "0x70795D0", VA = "0x18707A3D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x707A480", Offset = "0x7079680", VA = "0x18707A480")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		private AAONKAOBFIM JBPFIGLNGHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x873C0A0", Offset = "0x873B2A0", VA = "0x18873C0A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		protected JGDOBJGGKHG BAHCBIONOBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x873C130", Offset = "0x873B330", VA = "0x18873C130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		private PACLKEKNGOF JNPILDPDGPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x873C640", Offset = "0x873B840", VA = "0x18873C640")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x873C6E0", Offset = "0x873B8E0", VA = "0x18873C6E0")]
		protected void CHAFAAMEFPI(ButtonAudioPaletteAsset DHBDFDEIFML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x9F24A0", Offset = "0x9F16A0", VA = "0x1809F24A0")]
		protected void PIJADNLHOAD(RecRoomAudioClipPoolConfig MBCHEILJBGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x873CB80", Offset = "0x873BD80", VA = "0x18873CB80", Slot = "12")]
		public virtual void OnPointerDown(PointerEventData ELJMGFIBFCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x873CD30", Offset = "0x873BF30", VA = "0x18873CD30", Slot = "13")]
		public virtual void OnPointerUp(PointerEventData ELJMGFIBFCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x873C820", Offset = "0x873BA20", VA = "0x18873C820", Slot = "14")]
		public virtual void OnPointerClick(PointerEventData ELJMGFIBFCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x873CC60", Offset = "0x873BE60", VA = "0x18873CC60", Slot = "15")]
		public virtual void OnPointerEnter(PointerEventData ELJMGFIBFCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x873C1C0", Offset = "0x873B3C0", VA = "0x18873C1C0")]
		private void BDEMMJGGJEL(RecRoomAudioClip[] ICOKINHCBMK, bool FFPOODLCEGF = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x873C240", Offset = "0x873B440", VA = "0x18873C240")]
		private void BDPOCOEHGDG(RecRoomAudioClip DJBHIKDJJGP, bool FFPOODLCEGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x873CE40", Offset = "0x873C040", VA = "0x18873CE40")]
		public void SetOnPointerDownSoundEffectDisabled(object PPOILDCNBFL, bool JACMJMGIIDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x873CEA0", Offset = "0x873C0A0", VA = "0x18873CEA0")]
		public void SetOnPointerUpSoundEffectDisabled(object PPOILDCNBFL, bool JACMJMGIIDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x873CE10", Offset = "0x873C010", VA = "0x18873CE10")]
		public void SetOnPointerClickSoundEffectDisabled(object PPOILDCNBFL, bool JACMJMGIIDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x873CE70", Offset = "0x873C070", VA = "0x18873CE70")]
		public void SetOnPointerEnterSoundEffectDisabled(object PPOILDCNBFL, bool JACMJMGIIDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x873C7E0", Offset = "0x873B9E0", VA = "0x18873C7E0")]
		private void FHMFFJDODII(IHHCNLCAMGC ONCELMGACCP, object PPOILDCNBFL, bool JACMJMGIIDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x873CED0", Offset = "0x873C0D0", VA = "0x18873CED0")]
		protected SelectableThemeBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class SliderTheme : SelectableThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		[Header("Slider Visual")]
		[SerializeField]
		[GABLABEDCEL(HJNEPGJJFOF.Self, false, false, false)]
		private Slider slider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		[SerializeField]
		private KJLMALPAGIM sliderType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		[Header("Slider Audio")]
		[SerializeField]
		private ALKKBBHFPJP buttonAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		[SerializeField]
		[Tooltip("Layer a 2D SFX on top of base button sounds")]
		private bool useFlavorSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		[SerializeField]
		[GLHFIOJNDCO("useFlavorSFX")]
		[Tooltip("Flavor SFX is picked randomly from this pool config")]
		private RecRoomAudioClipPoolConfig flavorSFXClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		[SerializeField]
		private Image sliderImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		[SerializeField]
		private Image fillImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		[SerializeField]
		private Image handleImage;

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public KJLMALPAGIM HDBKJPEFBIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x9F9490", Offset = "0x9F8690", VA = "0x1809F9490")]
			get
			{
				return default(KJLMALPAGIM);
			}
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x873D4B0", Offset = "0x873C6B0", VA = "0x18873D4B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public Image GADIKLONGOE
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x9F8B10", Offset = "0x9F7D10", VA = "0x1809F8B10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public Image JLGLLONFGHH
		{
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0xD6D9C0", Offset = "0xD6CBC0", VA = "0x180D6D9C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public Image KGMINLABJGD
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0xD51D30", Offset = "0xD50F30", VA = "0x180D51D30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x873D0E0", Offset = "0x873C2E0", VA = "0x18873D0E0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x873D490", Offset = "0x873C690", VA = "0x18873D490")]
		public SliderTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class SurfaceTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		[SerializeField]
		[GABLABEDCEL(HJNEPGJJFOF.Self, false, false, false)]
		private Image image;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		[SerializeField]
		[BMOELPNDLIH(HJNEPGJJFOF.Self, false, false, false)]
		private UIGradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		[SerializeField]
		private NMIEBNGBFHK color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		[SerializeField]
		[GLHFIOJNDCO("gradient")]
		private bool ignoreGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		[SerializeField]
		[Tooltip("The surface theme determines if this Image is a RaycastTarget or not. There are times when you might want to ignore that setting of the palette theme and just respect whatever is the default state on the Image.")]
		private bool ignoreSettingRaycastTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		private NMIEBNGBFHK? OKJOOIFMDNK;

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public NMIEBNGBFHK PEENHFMDMPA
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x873D790", Offset = "0x873C990", VA = "0x18873D790")]
			get
			{
				return default(NMIEBNGBFHK);
			}
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x873D7F0", Offset = "0x873C9F0", VA = "0x18873D7F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x873D4D0", Offset = "0x873C6D0", VA = "0x18873D4D0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x873D770", Offset = "0x873C970", VA = "0x18873D770", Slot = "7")]
		public virtual void OverrideBackgroundColorPaletteAtRuntime(NMIEBNGBFHK? LCABEIMOOEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x9F0790", Offset = "0x9EF990", VA = "0x1809F0790")]
		public SurfaceTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public class SwitchTheme : ToggleTheme
	{
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		private const float CBBAFJOKCGN = 0.33f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		[Header("Switch")]
		[SerializeField]
		private GameObject indicator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		[SerializeField]
		private GameObject indicatorOffPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		[SerializeField]
		private GameObject indicatorOnPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private MABANDBIMJG IGDKAIIPHNL;

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x873D810", Offset = "0x873CA10", VA = "0x18873D810", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x873DA70", Offset = "0x873CC70", VA = "0x18873DA70")]
		public SwitchTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public class TilerTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		[SerializeField]
		[GABLABEDCEL(HJNEPGJJFOF.Self, false, false, false)]
		private UITiler tiler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		[SerializeField]
		private MMPJEELMCKA type;

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x873E080", Offset = "0x873D280", VA = "0x18873E080", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x9F0790", Offset = "0x9EF990", VA = "0x1809F0790")]
		public TilerTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class ToggleTheme : ButtonThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		[Header("Toggle Visual")]
		[SerializeField]
		private BHDJHPJNLKL toggleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		[SerializeField]
		[Tooltip("A list of objects to show while the toggle is active.")]
		private List<Hideable> hideWhenNotActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		[SerializeField]
		[Tooltip("A list of objects to show while the toggle is inactive")]
		private List<Hideable> hideWhenActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		[SerializeField]
		private bool editorIsActiveOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x161")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		[Header("Toggle Audio")]
		[SerializeField]
		[Tooltip("Override the audio palette when active defined by the toggle's visual with a custom palette")]
		private bool overrideAudioPaletteWhenActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		[SerializeField]
		[GLHFIOJNDCO("overrideAudioPaletteWhenActive")]
		[Tooltip("Specify a custom config to use for toggle button audio when active")]
		private ButtonAudioPaletteAsset customButtonAudioConfigWhenActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		[SerializeField]
		[Tooltip("Override the audio palette when inactive defined by the toggle's visual with a custom palette")]
		private bool overrideAudioPaletteWhenInactive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		[GLHFIOJNDCO("overrideAudioPaletteWhenInactive")]
		[Tooltip("Specify a custom config to use for toggle button audio when inactive")]
		[SerializeField]
		private ButtonAudioPaletteAsset customButtonAudioConfigWhenInactive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		[SerializeField]
		[Tooltip("Layer a 2D SFX on top of base button sounds. Flavor SFX only plays when toggling from inactive to active")]
		private bool useFlavorSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		[SerializeField]
		[GLHFIOJNDCO("useFlavorSFX")]
		[Tooltip("Flavor SFX is picked randomly from this pool config")]
		private RecRoomAudioClipPoolConfig flavorSFXClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		protected bool HNEJNCGEBLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x191")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		private bool OLKAJEBIBOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x192")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		private bool JFAPEJOHLJO;

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public bool BFDEOBNNJEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x14E5930", Offset = "0x14E4B30", VA = "0x1814E5930")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x873E7C0", Offset = "0x873D9C0", VA = "0x18873E7C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public BHDJHPJNLKL LBHECGKIAEH
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0xE86F20", Offset = "0xE86120", VA = "0x180E86F20")]
			get
			{
				return default(BHDJHPJNLKL);
			}
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x8731C00", Offset = "0x8730E00", VA = "0x188731C00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		protected override bool ABDONFIECMM
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x873E730", Offset = "0x873D930", VA = "0x18873E730", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x873E6F0", Offset = "0x873D8F0", VA = "0x18873E6F0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x873E780", Offset = "0x873D980", VA = "0x18873E780")]
		public void Toggle()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x873E740", Offset = "0x873D940", VA = "0x18873E740")]
		public void Toggle(bool JFAPEJOHLJO, bool HNEJNCGEBLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x873E310", Offset = "0x873D510", VA = "0x18873E310", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x873DA70", Offset = "0x873CC70", VA = "0x18873DA70")]
		public ToggleTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public class ActiveEventThemeSwapper : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		[SerializeField]
		private string eventActiveGameConfigKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		[SerializeField]
		private bool swapSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		[GLHFIOJNDCO("swapSprite")]
		[SerializeField]
		private Image targetImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		[GLHFIOJNDCO("swapSprite")]
		[SerializeField]
		private Sprite targetSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		[SerializeField]
		private bool swapSurfaceTheme;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		[GLHFIOJNDCO("swapSurfaceTheme")]
		[SerializeField]
		private SurfaceTheme targetSurfaceTheme;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		[GLHFIOJNDCO("swapSurfaceTheme")]
		[SerializeField]
		private NMIEBNGBFHK targetPalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		[SerializeField]
		private bool changeGradientDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		[GLHFIOJNDCO("changeGradientDirection")]
		[SerializeField]
		private UIGradient targetGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		[GLHFIOJNDCO("changeGradientDirection")]
		[SerializeField]
		private UIGradient.MLEFLLDPGCE targetGradientType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		private HJGCGGODOAD PAIGCLKMFBH;

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x872F6A0", Offset = "0x872E8A0", VA = "0x18872F6A0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x872F5F0", Offset = "0x872E7F0", VA = "0x18872F5F0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x872F250", Offset = "0x872E450", VA = "0x18872F250")]
		private void AOHHLKFLLJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x872F4A0", Offset = "0x872E6A0", VA = "0x18872F4A0")]
		private void OGFFOOFJPHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x872F7F0", Offset = "0x872E9F0", VA = "0x18872F7F0")]
		public ActiveEventThemeSwapper()
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
