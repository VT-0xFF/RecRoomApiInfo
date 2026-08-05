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
		private sealed class FDHMNHBHENB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public TMP_FontAsset font;

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public FDHMNHBHENB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x74E07E0", Offset = "0x74DF1E0", VA = "0x1874E07E0")]
			internal bool AAAGGAAMLEL(LocalizedFontMapping x)
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
		[Cpp2IlInjected.Address(RVA = "0x74E1010", Offset = "0x74DFA10", VA = "0x1874E1010")]
		public bool MKFECLKAMKP(TMP_FontAsset DCJPLHALKDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x74E0910", Offset = "0x74DF310", VA = "0x1874E0910")]
		public TMP_FontAsset JEFLMKNDKNC(TMP_FontAsset DCJPLHALKDO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x74E0A70", Offset = "0x74DF470", VA = "0x1874E0A70")]
		public TMP_FontAsset JEFLMKNDKNC(TMP_FontAsset DCJPLHALKDO, Material DMOIHBODBIC, [Out] Material HKNJCPNMNGL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x74E0EB0", Offset = "0x74DF8B0", VA = "0x1874E0EB0")]
		public TMP_FontAsset JNMGLFCCKBK(TMP_FontAsset DCJPLHALKDO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x74E0CB0", Offset = "0x74DF6B0", VA = "0x1874E0CB0")]
		public TMP_FontAsset JNMGLFCCKBK(TMP_FontAsset DCJPLHALKDO, Material DMOIHBODBIC, [Out] Material APBMHMOKMMG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x74E0860", Offset = "0x74DF260", VA = "0x1874E0860")]
		private static bool IFJCKFBOECP(TMP_FontAsset DCJPLHALKDO, LocalizedFontMapping KOMDPNIEGHI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x74E1140", Offset = "0x74DFB40", VA = "0x1874E1140")]
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
			[Cpp2IlInjected.Address(RVA = "0x74EB740", Offset = "0x74EA140", VA = "0x1874EB740")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x74EB700", Offset = "0x74EA100", VA = "0x1874EB700")]
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
		[Cpp2IlInjected.Address(RVA = "0x74E1200", Offset = "0x74DFC00", VA = "0x1874E1200", Slot = "0")]
		public override bool Equals(object GIGIFGONEAO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x74E11A0", Offset = "0x74DFBA0", VA = "0x1874E11A0", Slot = "4")]
		public bool Equals(GradientBlock AIPFCMFLDKG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x74E12F0", Offset = "0x74DFCF0", VA = "0x1874E12F0", Slot = "2")]
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
		public List<Graphic> DEKEMCPENIB
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xA3E2C0", Offset = "0xA3CCC0", VA = "0x180A3E2C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xD17D10", Offset = "0xD16710", VA = "0x180D17D10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public ColorBlock BPKPHLACHCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x74E3280", Offset = "0x74E1C80", VA = "0x1874E3280")]
			get
			{
				return default(ColorBlock);
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x74E3300", Offset = "0x74E1D00", VA = "0x1874E3300")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public UIGradient NAOPDAAEBIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x960880", Offset = "0x95F280", VA = "0x180960880")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xD17D50", Offset = "0xD16750", VA = "0x180D17D50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public GradientBlock NGIIKFEECEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x74E32D0", Offset = "0x74E1CD0", VA = "0x1874E32D0")]
			get
			{
				return default(GradientBlock);
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x74E3350", Offset = "0x74E1D50", VA = "0x1874E3350")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x74E30A0", Offset = "0x74E1AA0", VA = "0x1874E30A0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x74E30F0", Offset = "0x74E1AF0", VA = "0x1874E30F0", Slot = "36")]
		public override void OnSelect(BaseEventData NIMOEMOGMIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x74E3140", Offset = "0x74E1B40", VA = "0x1874E3140")]
		public void Refresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x74E2F60", Offset = "0x74E1960", VA = "0x1874E2F60")]
		public void ForceHighlighted(bool NANLGCEGILF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x74E2F80", Offset = "0x74E1980", VA = "0x1874E2F80")]
		public void ForceNormal(bool NANLGCEGILF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x74E2C00", Offset = "0x74E1600", VA = "0x1874E2C00", Slot = "26")]
		protected override void DoStateTransition(SelectionState ACEEMNFHFMB, bool NANLGCEGILF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x74E2B10", Offset = "0x74E1510", VA = "0x1874E2B10")]
		private void BPAKJCJCOIE(Graphic EKCKDPEFNFH, Color NEPGNGKGKIL, bool NANLGCEGILF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x74E2FA0", Offset = "0x74E19A0", VA = "0x1874E2FA0")]
		private void OGBBDOBKEOP(SelectionState ACEEMNFHFMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x74E3170", Offset = "0x74E1B70", VA = "0x1874E3170")]
		public MultiGraphicButton()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum AHDNLGCNFGL
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
public enum KJJCBAPKCJB
{
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	Default
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public enum PAONOKIKIGG
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	Default
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum NPADNCBBFNI
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
			private AHDNLGCNFGL buttonAudioPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			[SerializeField]
			private ButtonAudioPaletteAsset buttonAudioPaletteConfig;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public AHDNLGCNFGL ButtonAudioPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(RVA = "0x8821A0", Offset = "0x880BA0", VA = "0x1808821A0")]
				get
				{
					return default(AHDNLGCNFGL);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public ButtonAudioPaletteAsset ButtonAudioPaletteConfig
			{
				[Cpp2IlInjected.Token(Token = "0x6000026")]
				[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
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
			private KJJCBAPKCJB scrollingAudioPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			[SerializeField]
			private ScrollingAudioPaletteAsset scrollingAudioPaletteConfig;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public KJJCBAPKCJB ScrollingAudioPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x8821A0", Offset = "0x880BA0", VA = "0x1808821A0")]
				get
				{
					return default(KJJCBAPKCJB);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public ScrollingAudioPaletteAsset ScrollingAudioPaletteConfig
			{
				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
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
			private PAONOKIKIGG contentLoadingAudioPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			[SerializeField]
			private ContentLoadingAudioPaletteAsset contentLoadingAudioPaletteConfig;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public PAONOKIKIGG ContentLoadingAudioPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0x8821A0", Offset = "0x880BA0", VA = "0x1808821A0")]
				get
				{
					return default(PAONOKIKIGG);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public ContentLoadingAudioPaletteAsset ContentLoadingAudioPaletteConfig
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
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
			private NPADNCBBFNI recyclingAudioPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			[SerializeField]
			private RecyclingAudioPaletteAsset recyclingAudioPaletteConfig;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public NPADNCBBFNI RecyclingAudioPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x8821A0", Offset = "0x880BA0", VA = "0x1808821A0")]
				get
				{
					return default(NPADNCBBFNI);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public RecyclingAudioPaletteAsset RecyclingAudioPaletteConfig
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public RecyclingAudioPaletteItem()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class CANBBDBNEFM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public AHDNLGCNFGL buttonAudioPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public CANBBDBNEFM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x1572A00", Offset = "0x1571400", VA = "0x181572A00")]
			internal bool KKMIJIHMCBB(ButtonAudioPaletteItem buttonAudioPalette)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class AGJOJJOACBL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public KJJCBAPKCJB scrollingAudioPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public AGJOJJOACBL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x1572A00", Offset = "0x1571400", VA = "0x181572A00")]
			internal bool NIDHNIJBJAO(ScrollingAudioPaletteItem scrollingAudioPalette)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class KIKDJCEMEDE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public PAONOKIKIGG contentLoadingAudioPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public KIKDJCEMEDE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x1572A00", Offset = "0x1571400", VA = "0x181572A00")]
			internal bool DNCPICJFOOG(ContentLoadingAudioPaletteItem contentLoadingAudioPalette)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class PDDPLKJCKIM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public NPADNCBBFNI recyclingAudioPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public PDDPLKJCKIM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x1572A00", Offset = "0x1571400", VA = "0x181572A00")]
			internal bool DPJGGIABAJP(RecyclingAudioPaletteItem recyclingAudioPalette)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[SerializeField]
		[MKFJHAEEAOE("ButtonAudioPaletteType")]
		private ButtonAudioPaletteItem[] buttonAudioPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[SerializeField]
		[MKFJHAEEAOE("ScrollingAudioPaletteType")]
		private ScrollingAudioPaletteItem[] scrollingAudioPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[SerializeField]
		[MKFJHAEEAOE("ContentLoadingAudioPaletteType")]
		private ContentLoadingAudioPaletteItem[] contentLoadingAudioPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[SerializeField]
		[MKFJHAEEAOE("RecyclingAudioPaletteType")]
		private RecyclingAudioPaletteItem[] recyclingAudioPalettes;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x74DD610", Offset = "0x74DC010", VA = "0x1874DD610")]
		public ButtonAudioPaletteAsset OEODAFLNFPC(AHDNLGCNFGL NGNKKLFIOIM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x74DD700", Offset = "0x74DC100", VA = "0x1874DD700")]
		public ScrollingAudioPaletteAsset OJENCJAGCNH(KJJCBAPKCJB CEIDNAGHHMA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x74DD7F0", Offset = "0x74DC1F0", VA = "0x1874DD7F0")]
		public ContentLoadingAudioPaletteAsset OPGDPDGLHCJ(PAONOKIKIGG NNNBJNHPPIO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x74DD520", Offset = "0x74DBF20", VA = "0x1874DD520")]
		public RecyclingAudioPaletteAsset LEJNBMANBMJ(NPADNCBBFNI MFMHAJOEPBK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x903700", Offset = "0x902100", VA = "0x180903700")]
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
			[Cpp2IlInjected.Address(RVA = "0x91E840", Offset = "0x91D240", VA = "0x18091E840")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public float ClickAnimationScale
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xA35360", Offset = "0xA33D60", VA = "0x180A35360")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x74DD960", Offset = "0x74DC360", VA = "0x1874DD960")]
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
		private AHDNLGCNFGL audioPalette;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Color BackgroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x94B360", Offset = "0x949D60", VA = "0x18094B360")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public ColorBlock BackgroundTints
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x74DDA70", Offset = "0x74DC470", VA = "0x1874DDA70")]
			get
			{
				return default(ColorBlock);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public GradientBlock BackgroundGradients
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xBB8CB0", Offset = "0xBB76B0", VA = "0x180BB8CB0")]
			get
			{
				return default(GradientBlock);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Color ForegroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xA3E250", Offset = "0xA3CC50", VA = "0x180A3E250")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public ColorBlock ForegroundTints
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x74DDAB0", Offset = "0x74DC4B0", VA = "0x1874DDAB0")]
			get
			{
				return default(ColorBlock);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool ShowBorder
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x8F4530", Offset = "0x8F2F30", VA = "0x1808F4530")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public TextStylePalette TextPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xA3E2C0", Offset = "0xA3CCC0", VA = "0x180A3E2C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public AHDNLGCNFGL AudioPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x169CCE0", Offset = "0x169B6E0", VA = "0x18169CCE0")]
			get
			{
				return default(AHDNLGCNFGL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x74DD980", Offset = "0x74DC380", VA = "0x1874DD980")]
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
			[Cpp2IlInjected.Address(RVA = "0xB33770", Offset = "0xB32170", VA = "0x180B33770")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
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
			[Cpp2IlInjected.Address(RVA = "0x94B360", Offset = "0x949D60", VA = "0x18094B360")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public TextStylePalette TextPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8893E0", Offset = "0x887DE0", VA = "0x1808893E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x74E0170", Offset = "0x74DEB70", VA = "0x1874E0170")]
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
			[Cpp2IlInjected.Address(RVA = "0x94B360", Offset = "0x949D60", VA = "0x18094B360")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Color ForegroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xA3F130", Offset = "0xA3DB30", VA = "0x180A3F130")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Color PlaceholderColor
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0xA473A0", Offset = "0xA45DA0", VA = "0x180A473A0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public TextStylePalette TextPalette
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x8869B0", Offset = "0x8853B0", VA = "0x1808869B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x74E17B0", Offset = "0x74E01B0", VA = "0x1874E17B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x882780", Offset = "0x881180", VA = "0x180882780")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public MakerPenToolPalette()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class MixedTogglePalette
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		private enum DNPEGACCBEO
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
		private BJOEGDCAIGJ baseTogglePalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[SerializeField]
		private DNPEGACCBEO mixedPaletteType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[SerializeField]
		[BENIALBDKBI("mixedPaletteType", DNPEGACCBEO.UseCustom)]
		private ButtonPalette mixedButtonPalette;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x74E24D0", Offset = "0x74E0ED0", VA = "0x1874E24D0")]
		public TogglePalette NBJIDAENLAH(Palette OLCADENBBAH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x74E2460", Offset = "0x74E0E60", VA = "0x1874E2460")]
		public ButtonPalette MKHKOGOJMGE(Palette OLCADENBBAH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
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
			private APHGPFPCLIK paletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			[SerializeField]
			private Color color;

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			public APHGPFPCLIK RawImageColorPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000066")]
				[Cpp2IlInjected.Address(RVA = "0x8821A0", Offset = "0x880BA0", VA = "0x1808821A0")]
				get
				{
					return default(APHGPFPCLIK);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			public Color Color
			{
				[Cpp2IlInjected.Token(Token = "0x6000067")]
				[Cpp2IlInjected.Address(RVA = "0x1177E80", Offset = "0x1176880", VA = "0x181177E80")]
				get
				{
					return default(Color);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x8C9560", Offset = "0x8C7F60", VA = "0x1808C9560")]
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
			private PNEEIIGPCMI backgroundColorPaletteType;

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
			public PNEEIIGPCMI BackgroundColorPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000069")]
				[Cpp2IlInjected.Address(RVA = "0x8821A0", Offset = "0x880BA0", VA = "0x1808821A0")]
				get
				{
					return default(PNEEIIGPCMI);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			public Color Color
			{
				[Cpp2IlInjected.Token(Token = "0x600006A")]
				[Cpp2IlInjected.Address(RVA = "0x1177E80", Offset = "0x1176880", VA = "0x181177E80")]
				get
				{
					return default(Color);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			public Gradient Gradient
			{
				[Cpp2IlInjected.Token(Token = "0x600006B")]
				[Cpp2IlInjected.Address(RVA = "0x886D60", Offset = "0x885760", VA = "0x180886D60")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			public bool RaycastTarget
			{
				[Cpp2IlInjected.Token(Token = "0x600006C")]
				[Cpp2IlInjected.Address(RVA = "0xB75510", Offset = "0xB73F10", VA = "0x180B75510")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x74DD8E0", Offset = "0x74DC2E0", VA = "0x1874DD8E0")]
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
			private IJKMLLMJEEF foregroundColorPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			[SerializeField]
			private Color color;

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public IJKMLLMJEEF ForegroundColorPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600006E")]
				[Cpp2IlInjected.Address(RVA = "0x8821A0", Offset = "0x880BA0", VA = "0x1808821A0")]
				get
				{
					return default(IJKMLLMJEEF);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			public Color Color
			{
				[Cpp2IlInjected.Token(Token = "0x600006F")]
				[Cpp2IlInjected.Address(RVA = "0x1177E80", Offset = "0x1176880", VA = "0x181177E80")]
				get
				{
					return default(Color);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x74E1180", Offset = "0x74DFB80", VA = "0x1874E1180")]
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
			private IBGHLMCMDGC tilerPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			[SerializeField]
			private TilerPalette tilerPalette;

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			public IBGHLMCMDGC TilerPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000071")]
				[Cpp2IlInjected.Address(RVA = "0x8821A0", Offset = "0x880BA0", VA = "0x1808821A0")]
				get
				{
					return default(IBGHLMCMDGC);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			public TilerPalette TilerPalette
			{
				[Cpp2IlInjected.Token(Token = "0x6000072")]
				[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
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
			private PMPFFCCOKIG textStylePaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			[SerializeField]
			private TextStylePalette textStylePalette;

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			public PMPFFCCOKIG TextStylePaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000074")]
				[Cpp2IlInjected.Address(RVA = "0x8821A0", Offset = "0x880BA0", VA = "0x1808821A0")]
				get
				{
					return default(PMPFFCCOKIG);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			public TextStylePalette TextStylePalette
			{
				[Cpp2IlInjected.Token(Token = "0x6000075")]
				[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
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
			private IJCDEJJPOFN textSizePaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			[SerializeField]
			private int size;

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			public IJCDEJJPOFN TextSizePaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(RVA = "0x8821A0", Offset = "0x880BA0", VA = "0x1808821A0")]
				get
				{
					return default(IJCDEJJPOFN);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			public int Size
			{
				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0x8FD280", Offset = "0x8FBC80", VA = "0x1808FD280")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xC62290", Offset = "0xC60C90", VA = "0x180C62290")]
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
			private FKKKFBMNCAB buttonPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			[SerializeField]
			private ButtonPalette buttonPalette;

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			public FKKKFBMNCAB ButtonPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x8821A0", Offset = "0x880BA0", VA = "0x1808821A0")]
				get
				{
					return default(FKKKFBMNCAB);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			public ButtonPalette ButtonPalette
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
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
			private BJOEGDCAIGJ togglePaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			[SerializeField]
			private TogglePalette togglePalette;

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public BJOEGDCAIGJ TogglePaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600007D")]
				[Cpp2IlInjected.Address(RVA = "0x8821A0", Offset = "0x880BA0", VA = "0x1808821A0")]
				get
				{
					return default(BJOEGDCAIGJ);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public TogglePalette TogglePalette
			{
				[Cpp2IlInjected.Token(Token = "0x600007E")]
				[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
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
			private BPKMPPIPFGP mixedTogglePaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			[SerializeField]
			private MixedTogglePalette mixedTogglePalette;

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public BPKMPPIPFGP MixedTogglePaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000080")]
				[Cpp2IlInjected.Address(RVA = "0x8821A0", Offset = "0x880BA0", VA = "0x1808821A0")]
				get
				{
					return default(BPKMPPIPFGP);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public MixedTogglePalette MixedTogglePalette
			{
				[Cpp2IlInjected.Token(Token = "0x6000081")]
				[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
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
			private EPIOLJOJCFH makerPenToolPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			[SerializeField]
			private MakerPenToolPalette makerPenToolPalette;

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public EPIOLJOJCFH MakerPenToolPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000083")]
				[Cpp2IlInjected.Address(RVA = "0x8821A0", Offset = "0x880BA0", VA = "0x1808821A0")]
				get
				{
					return default(EPIOLJOJCFH);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public MakerPenToolPalette MakerPenToolPalette
			{
				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
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
			private FIDPEHBGHCL inputFieldPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			[SerializeField]
			private InputFieldPalette inputFieldPalette;

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public FIDPEHBGHCL InputFieldPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000086")]
				[Cpp2IlInjected.Address(RVA = "0x8821A0", Offset = "0x880BA0", VA = "0x1808821A0")]
				get
				{
					return default(FIDPEHBGHCL);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public InputFieldPalette InputFieldPalette
			{
				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
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
			private PNGJBPBKAOP dropdownPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			[SerializeField]
			private DropdownPalette dropdownPalette;

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public PNGJBPBKAOP DropdownPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0x8821A0", Offset = "0x880BA0", VA = "0x1808821A0")]
				get
				{
					return default(PNGJBPBKAOP);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public DropdownPalette DropdownPalette
			{
				[Cpp2IlInjected.Token(Token = "0x600008A")]
				[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
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
			private IHMHCIKDDFG sliderPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			[SerializeField]
			private SliderPalette sliderPalette;

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public IHMHCIKDDFG SliderPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600008C")]
				[Cpp2IlInjected.Address(RVA = "0x8821A0", Offset = "0x880BA0", VA = "0x1808821A0")]
				get
				{
					return default(IHMHCIKDDFG);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public SliderPalette SliderPalette
			{
				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
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
			private JLAPBMJJKGN depthPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			[SerializeField]
			private DepthPalette depthPalette;

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			public JLAPBMJJKGN DepthPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0x8821A0", Offset = "0x880BA0", VA = "0x1808821A0")]
				get
				{
					return default(JLAPBMJJKGN);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public DepthPalette DepthPalette
			{
				[Cpp2IlInjected.Token(Token = "0x6000090")]
				[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public DepthPaletteItem()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private sealed class DAFNCMFOHNG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public APHGPFPCLIK backgroundColorPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public DAFNCMFOHNG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x1572A00", Offset = "0x1571400", VA = "0x181572A00")]
			internal bool MMMDGHMMCLL(RawImageColorPaletteItem pi)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private sealed class LOKKOCHDAOF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public PNEEIIGPCMI backgroundColorPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public LOKKOCHDAOF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x1572A00", Offset = "0x1571400", VA = "0x181572A00")]
			internal bool DNFNPACNDJM(BackgroundColorPaletteItem backgroundColorPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class EIHCKCNCIOK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public IJKMLLMJEEF foregroundColorPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public EIHCKCNCIOK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x1572A00", Offset = "0x1571400", VA = "0x181572A00")]
			internal bool IMOODFONDPB(ForegroundColorPaletteItem colorPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class CALHBEFPNMF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public IBGHLMCMDGC type;

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public CALHBEFPNMF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x1572A00", Offset = "0x1571400", VA = "0x181572A00")]
			internal bool OJNHGCEHABB(TilerPaletteItem tilerPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[CompilerGenerated]
		private sealed class IDMICPDBCCL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public PMPFFCCOKIG textStylePaletteType;

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public IDMICPDBCCL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x1572A00", Offset = "0x1571400", VA = "0x181572A00")]
			internal bool PONFJNBBIJC(TextStylePaletteItem textStylePaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		[CompilerGenerated]
		private sealed class OBGEOCJKAEA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public IJCDEJJPOFN textSizePaletteType;

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public OBGEOCJKAEA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x1572A00", Offset = "0x1571400", VA = "0x181572A00")]
			internal bool BMINEBKEAFG(TextSizePaletteItem textSizePaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class LMPDKMNLOLL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public FKKKFBMNCAB buttonPaletteType;

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public LMPDKMNLOLL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x1572A00", Offset = "0x1571400", VA = "0x181572A00")]
			internal bool BHIPCCBOFGM(ButtonPaletteItem buttonPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class MPHFHNIJACG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public BJOEGDCAIGJ togglePaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public MPHFHNIJACG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x1572A00", Offset = "0x1571400", VA = "0x181572A00")]
			internal bool LGPMDODJEAA(TogglePaletteItem togglePaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000035")]
		[CompilerGenerated]
		private sealed class KEOMBGPOLAL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public BPKMPPIPFGP mixedTogglePaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public KEOMBGPOLAL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x1572A00", Offset = "0x1571400", VA = "0x181572A00")]
			internal bool PAMGPEEOJIK(MixedTogglePaletteItem mixedTogglePaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000036")]
		[CompilerGenerated]
		private sealed class LMENHMEDIBJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public EPIOLJOJCFH makerPenToolPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public LMENHMEDIBJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x1572A00", Offset = "0x1571400", VA = "0x181572A00")]
			internal bool JFBMOEFMIGE(MakerPenToolPaletteItem makerPenToolPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[CompilerGenerated]
		private sealed class DLEGFOIMLFO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public FIDPEHBGHCL inputFieldPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public DLEGFOIMLFO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x1572A00", Offset = "0x1571400", VA = "0x181572A00")]
			internal bool NHBECMFOKAG(InputFieldPaletteItem inputFieldPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		[CompilerGenerated]
		private sealed class MJJLCNIIMAJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public PNGJBPBKAOP dropdownPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public MJJLCNIIMAJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x1572A00", Offset = "0x1571400", VA = "0x181572A00")]
			internal bool JJHLKJEPCGN(DropdownPaletteItem dropdownPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000039")]
		[CompilerGenerated]
		private sealed class PBLFEKFFMAE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public IHMHCIKDDFG sliderPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public PBLFEKFFMAE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x1572A00", Offset = "0x1571400", VA = "0x181572A00")]
			internal bool CIMABODBHAL(SliderPaletteItem sliderPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		[CompilerGenerated]
		private sealed class BKIJHBKNLAJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public JLAPBMJJKGN depthPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public BKIJHBKNLAJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x1572A00", Offset = "0x1571400", VA = "0x181572A00")]
			internal bool OBNOJNBNPOD(DepthPaletteItem depthPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[Header("Visual")]
		[SerializeField]
		[MKFJHAEEAOE("RawImageColorPaletteType")]
		private RawImageColorPaletteItem[] rawImageColorPaletteItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[SerializeField]
		[MKFJHAEEAOE("BackgroundColorPaletteType")]
		private BackgroundColorPaletteItem[] backgroundColorPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[SerializeField]
		[MKFJHAEEAOE("ForegroundColorPaletteType")]
		private ForegroundColorPaletteItem[] foregroundColorPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[SerializeField]
		[MKFJHAEEAOE("TilerPaletteType")]
		private TilerPaletteItem[] tilerPaletteItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[SerializeField]
		[MKFJHAEEAOE("TextStylePaletteType")]
		private TextStylePaletteItem[] textStylePalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[SerializeField]
		[MKFJHAEEAOE("TextSizePaletteType")]
		private TextSizePaletteItem[] textSizePalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[SerializeField]
		[MKFJHAEEAOE("ButtonPaletteType")]
		private ButtonPaletteItem[] buttonPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[SerializeField]
		[MKFJHAEEAOE("TogglePaletteType")]
		private TogglePaletteItem[] togglePalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[SerializeField]
		[MKFJHAEEAOE("MixedTogglePaletteType")]
		private MixedTogglePaletteItem[] mixedTogglePalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[SerializeField]
		[MKFJHAEEAOE("MakerPenToolPaletteType")]
		private MakerPenToolPaletteItem[] makerPenToolPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[SerializeField]
		[MKFJHAEEAOE("InputFieldPaletteType")]
		private InputFieldPaletteItem[] inputFieldPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[SerializeField]
		[MKFJHAEEAOE("DropdownPaletteType")]
		private DropdownPaletteItem[] dropdownPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[SerializeField]
		[MKFJHAEEAOE("SliderPaletteType")]
		private SliderPaletteItem[] sliderPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[SerializeField]
		[MKFJHAEEAOE("DepthPaletteType")]
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
			[Cpp2IlInjected.Address(RVA = "0x88C880", Offset = "0x88B280", VA = "0x18088C880")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public ButtonAnimationPalette ButtonAnimationPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x88C900", Offset = "0x88B300", VA = "0x18088C900")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public AudioPalette AudioPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x92DDE0", Offset = "0x92C7E0", VA = "0x18092DDE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x74E6080", Offset = "0x74E4A80", VA = "0x1874E6080")]
		public Color PCBCPBKEEDE(APHGPFPCLIK EAEPFNOHJLA)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x74E5660", Offset = "0x74E4060", VA = "0x1874E5660")]
		public void CKBKCJOEEAH(PNEEIIGPCMI EAEPFNOHJLA, [Out] Color BLBBBKOLGJG, [Out] Gradient DHJCMFOGGJH, [Out] bool ICGKEEOFKOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x74E5CC0", Offset = "0x74E46C0", VA = "0x1874E5CC0")]
		public Color MHFKMCENKDG(IJKMLLMJEEF CNHKNGJECDK)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x74E5DB0", Offset = "0x74E47B0", VA = "0x1874E5DB0")]
		public TilerPalette NCLLHCPFBDE(IBGHLMCMDGC NNCMOPPBEEE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x74E5AE0", Offset = "0x74E44E0", VA = "0x1874E5AE0")]
		public TextStylePalette JHLMNDPEJOG(PMPFFCCOKIG KGECJDIBBCP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x74E5BD0", Offset = "0x74E45D0", VA = "0x1874E5BD0")]
		public int MDDJIOHNILG(IJCDEJJPOFN AMBBDHNJHJP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x74E5570", Offset = "0x74E3F70", VA = "0x1874E5570")]
		public ButtonPalette BGKHLPNFIEC(FKKKFBMNCAB CLLBININNCE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x74E5EA0", Offset = "0x74E48A0", VA = "0x1874E5EA0")]
		public TogglePalette OCGOJEHGPBD(BJOEGDCAIGJ FLKKDGKGFNB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x74E57D0", Offset = "0x74E41D0", VA = "0x1874E57D0")]
		public MixedTogglePalette GNKJEBFGENL(BPKMPPIPFGP MKLLGHOKOLB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x74E5480", Offset = "0x74E3E80", VA = "0x1874E5480")]
		public MakerPenToolPalette AGHLHOKFMDI(EPIOLJOJCFH DKDHCBEEKKK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x74E6170", Offset = "0x74E4B70", VA = "0x1874E6170")]
		public InputFieldPalette PKAEIDCFBOB(FIDPEHBGHCL OEBIPOMDGAK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x74E58C0", Offset = "0x74E42C0", VA = "0x1874E58C0")]
		public DropdownPalette JBCPOEIMAAK(PNGJBPBKAOP HBOJLBIPHKB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x74E5F90", Offset = "0x74E4990", VA = "0x1874E5F90")]
		public SliderPalette OPNDBKKMDKL(IHMHCIKDDFG AOHMMDGEMLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x74E59B0", Offset = "0x74E43B0", VA = "0x1874E59B0")]
		public float? JCLGDLCAPEO(JLAPBMJJKGN DJPHPIFCJOI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x903700", Offset = "0x902100", VA = "0x180903700")]
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
			[Cpp2IlInjected.Address(RVA = "0x94B360", Offset = "0x949D60", VA = "0x18094B360")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public Color FillColor
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xA3F130", Offset = "0xA3DB30", VA = "0x180A3F130")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public Color HandleColor
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xA473A0", Offset = "0xA45DA0", VA = "0x180A473A0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public ColorBlock ColorBlock
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x74EA920", Offset = "0x74E9320", VA = "0x1874EA920")]
			get
			{
				return default(ColorBlock);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x74EA860", Offset = "0x74E9260", VA = "0x1874EA860")]
		public SliderPalette()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public class TextStylePalette
	{
		[Cpp2IlInjected.Token(Token = "0x200003D")]
		public enum CDDOFFNKADM
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
		private CDDOFFNKADM transformation;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x74EB240", Offset = "0x74E9C40", VA = "0x1874EB240")]
		public void CNGJKAJMEBE(TextMeshProUGUI DNKPIGEDLFC, bool FNNBMMDGAMH = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
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
		private UITiler.FLNMDBGIBMK animationDirection;

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
			[Cpp2IlInjected.Address(RVA = "0x882780", Offset = "0x881180", VA = "0x180882780")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public Color TintColor
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xDCD700", Offset = "0xDCC100", VA = "0x180DCD700")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public Color BackgroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xDCD720", Offset = "0xDCC120", VA = "0x180DCD720")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public float Rows
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x923000", Offset = "0x921A00", VA = "0x180923000")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public Vector2 Spacing
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x1F683C0", Offset = "0x1F66DC0", VA = "0x181F683C0")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public float Offset
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x9ECD40", Offset = "0x9EB740", VA = "0x1809ECD40")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public Vector2 Velocity
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x74EB7B0", Offset = "0x74EA1B0", VA = "0x1874EB7B0")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public float Angle
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0xA3E2D0", Offset = "0xA3CCD0", VA = "0x180A3E2D0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public UITiler.FLNMDBGIBMK AnimationDirection
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0xACBBC0", Offset = "0xACA5C0", VA = "0x180ACBBC0")]
			get
			{
				return default(UITiler.FLNMDBGIBMK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public float PrimaryAnimationSpeed
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0xA3E2B0", Offset = "0xA3CCB0", VA = "0x180A3E2B0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public float AltAnimationSpeed
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0xA3E320", Offset = "0xA3CD20", VA = "0x180A3E320")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x74EB770", Offset = "0x74EA170", VA = "0x1874EB770")]
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
			[Cpp2IlInjected.Address(RVA = "0x882780", Offset = "0x881180", VA = "0x180882780")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public ButtonPalette ActiveButtonPalette
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public TogglePalette()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public enum PNEEIIGPCMI
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
	RuntimeDeletedTag
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public enum APHGPFPCLIK
{
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	A
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public enum IJKMLLMJEEF
{
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	MainPrimary,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	MainSecondary,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	InversePrimary,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	NotUse,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	WhitePrimary,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	WhiteSecondary,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	CardPrimary,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	CardSecondary,
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	Error,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	Modified,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	Orange
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public enum IBGHLMCMDGC
{
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	WatchBackground,
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	HomePage,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	DialogPage,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	Card,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	ProfileBG,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	WinterWonderlandHome
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public enum PMPFFCCOKIG
{
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	JostMedium,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	JostMediumCap,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	JostBoldCap,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	RobotoReg,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	RobotoBold,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	RobotoBoldOutlineDropshadow,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	RobotoBoldOutline,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	RobotoBoldOutlineDropshadowGradient,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	RobotoBoldOutlineGradient
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public enum IJCDEJJPOFN
{
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	XXXS = -1,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	XXS = 0,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	XS = 1,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	S = 2,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	M = 3,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	L = 4,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	XL = 5,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	XXL = 8,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	XXXL = 6,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	XXXXL = 7
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public enum FKKKFBMNCAB
{
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	Primary,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	Secondary,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	FlatPrimary,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	FlatButtonForWarningBanner,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	Negative,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	Chips,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	CarouselArrowDark,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	FlatWhite,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	MagicDoor,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	Tertiary_DupeWith2NDHeader_NeedReplace,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	CarouselArrowLight,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	HomePageMainButton,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	DropDown,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	SecondaryHeaderSection,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	ChatButton,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	FeedButton,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	NameTag,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	RoomCurrency,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	ChipsWhite,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	UGCBaseButton,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	UGCBaseButton_Subtle_NoDisabledState
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public enum BJOEGDCAIGJ
{
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	FlatOrange,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	FlatWhite,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	InputToggle,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	Chips,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	Switch,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	WhitePagingBlob,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	RSVPToggleHeaderSection,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	CardSelectableToggle,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	ChipsDark,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	MainNavToggle,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	ListItem,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	NotiUnread,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	FlatPrimary,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	CharadePen,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	ShareCam,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	CardSelectableToggleWithBacking,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	SecondaryHeaderSectionToggle,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	PrimaryToSecondaryHeader,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	NegativeToSecondaryHeader,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	LimitedEventPrimary,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	LimitedEventSecondary,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	RoomCardWithLimitedEvent,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	MainNavVrDetach,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	HomeMainNav,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	FlatOrangeSecondary
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public enum BPKMPPIPFGP
{
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	Checkbox
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public enum EPIOLJOJCFH
{
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	Create,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	Select,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	Wire,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	Configure,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	Transform,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	Move,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	Rotate,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	Scale,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	CloneFlip,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	Recolor,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	Freeze,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	MakeInvention,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	Manipulate,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	Delete
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public enum FIDPEHBGHCL
{
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	LightFlat,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	DarkFlat,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	Modified
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public enum PNGJBPBKAOP
{
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	LightFlat,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	DarkFlat
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public enum IHMHCIKDDFG
{
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	MirroUIPopUp
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public enum JLAPBMJJKGN
{
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	Base,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	Button,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	Navigation,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	Overlay,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	Dialog,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	Toast
}
namespace RRUI.Theme
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public class ApproximationMaskDepthTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		[SerializeField]
		private RectTransform content;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private Vector3? HLEINELJFHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private Vector3? IIEMMJGLCHN;

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x74DD440", Offset = "0x74DBE40", VA = "0x1874DD440")]
		private void PCEEADECCDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x74DD0A0", Offset = "0x74DBAA0", VA = "0x1874DD0A0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x884960", Offset = "0x883360", VA = "0x180884960")]
		public ApproximationMaskDepthTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public class ButtonTheme : ButtonThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		[Header("Button Visual")]
		[SerializeField]
		private FKKKFBMNCAB buttonType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14C")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		[Header("Button Audio")]
		[SerializeField]
		[Tooltip("Override the audio palette defined by the button's visual with a custom palette")]
		private bool overrideButtonAudioPalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		[SerializeField]
		[BENIALBDKBI("overrideButtonAudioPalette")]
		[Tooltip("Specify a custom config to use for button audio")]
		private ButtonAudioPaletteAsset customButtonAudioConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		[SerializeField]
		[Tooltip("Layer a 2D SFX on top of base button sounds")]
		private bool useFlavorSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		[SerializeField]
		[BENIALBDKBI("useFlavorSFX")]
		[Tooltip("Flavor SFX is picked randomly from this pool config")]
		private RecRoomAudioClipPoolConfig flavorSFXClipPoolConfig;

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public FKKKFBMNCAB EINOOEGHPKD
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x1158080", Offset = "0x1156A80", VA = "0x181158080")]
			get
			{
				return default(FKKKFBMNCAB);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x74DF440", Offset = "0x74DDE40", VA = "0x1874DF440")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x74DF1D0", Offset = "0x74DDBD0", VA = "0x1874DF1D0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x1726570", Offset = "0x1724F70", VA = "0x181726570")]
		public void SetAnimationEnabled(bool CEAFCCPFHNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x74DF430", Offset = "0x74DDE30", VA = "0x1874DF430")]
		public ButtonTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public abstract class ButtonThemeBase : SelectableThemeBase
	{
		[Cpp2IlInjected.Token(Token = "0x2000052")]
		protected class BKMGDDELBCA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400016C")]
			public ButtonAudioPaletteAsset NOGBEHAHENA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400016D")]
			public RecRoomAudioClipPoolConfig LEOKPMFIOCP;

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public BKMGDDELBCA()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		[SerializeField]
		[HIPIAIBDPPP(BILCJMODHFE.Self, false, false, false)]
		[Header("Button Theme Base")]
		private MultiGraphicButton multiGraphicButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		[SerializeField]
		[HIPIAIBDPPP(BILCJMODHFE.Self, false, true, false)]
		private Image surface;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		[SerializeField]
		private bool useSurfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		[SerializeField]
		[BENIALBDKBI("useSurfaceOverride")]
		private Image surfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		[SerializeField]
		private bool controlSurfaceColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		[SerializeField]
		[ReadOnlyField]
		private List<Graphic> graphics;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		[SerializeField]
		private bool useGraphicsOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		[SerializeField]
		[BENIALBDKBI("useGraphicsOverride")]
		private List<Graphic> graphicsOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		[SerializeField]
		[LFEOIFAFOOC("useGraphicsOverride", new object[] { })]
		private bool graphicsIgnoreTextFields;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		[SerializeField]
		private bool controlGraphicColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		[SerializeField]
		[HIPIAIBDPPP(BILCJMODHFE.Self, false, true, false)]
		private UIGradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		[SerializeField]
		private bool useGradientOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		[SerializeField]
		[BENIALBDKBI("useGradientOverride")]
		private UIGradient gradientOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		[SerializeField]
		[HIPIAIBDPPP(BILCJMODHFE.Children, true, true, false)]
		private TextMeshProUGUI textMeshProUGUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		[SerializeField]
		private bool useTextMeshProUGUIOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		[SerializeField]
		[BENIALBDKBI("useTextMeshProUGUIOverride")]
		private TextMeshProUGUI textMeshProUGUIOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		[SerializeField]
		private IJCDEJJPOFN textSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		[SerializeField]
		protected Hideable borderHideable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		[SerializeField]
		protected bool isAnimationEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x111")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		[SerializeField]
		[BENIALBDKBI("isAnimationEnabled")]
		protected bool overrideAnimationTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		[SerializeField]
		[BENIALBDKBI("overrideAnimationTarget")]
		protected GameObject animationTargetOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private bool BBIPEODLEKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private Vector3 JJPIOOCJKJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private Vector3 CLCFLBEPDMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private NMLHGOLNJPA JKLNPODMEGH;

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public Image IIBPDEFDAHA
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x74DF170", Offset = "0x74DDB70", VA = "0x1874DF170")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public List<Graphic> JDMLAMPNLAN
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x74DF150", Offset = "0x74DDB50", VA = "0x1874DF150")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public UIGradient EMAMBINGOGA
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x74DF130", Offset = "0x74DDB30", VA = "0x1874DF130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public TextMeshProUGUI MLDGNFBFHBO
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x74DF190", Offset = "0x74DDB90", VA = "0x1874DF190")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public IJCDEJJPOFN COKFEJDLFDL
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0xEAC0A0", Offset = "0xEAAAA0", VA = "0x180EAC0A0")]
			get
			{
				return default(IJCDEJJPOFN);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x74DF1B0", Offset = "0x74DDBB0", VA = "0x1874DF1B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		protected Transform HGKKGJFMKPF
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x74DE5A0", Offset = "0x74DCFA0", VA = "0x1874DE5A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public Button IJCLONPNHFN
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x74DF0A0", Offset = "0x74DDAA0", VA = "0x1874DF0A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x74DE690", Offset = "0x74DD090", VA = "0x1874DE690")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x74DE5F0", Offset = "0x74DCFF0", VA = "0x1874DE5F0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x74DEDE0", Offset = "0x74DD7E0", VA = "0x1874DEDE0")]
		protected void PDIEFPMJJBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x74DDB40", Offset = "0x74DC540", VA = "0x1874DDB40")]
		protected void BLELCGAAAJP(ButtonPalette MEADALLLDEP, [Optional] BKMGDDELBCA JELIDFFHGBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x74DE730", Offset = "0x74DD130", VA = "0x1874DE730", Slot = "12")]
		public override void OnPointerDown(PointerEventData NIMOEMOGMIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x74DEAE0", Offset = "0x74DD4E0", VA = "0x1874DEAE0", Slot = "13")]
		public override void OnPointerUp(PointerEventData NIMOEMOGMIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x74DE710", Offset = "0x74DD110", VA = "0x1874DE710", Slot = "14")]
		public override void OnPointerClick(PointerEventData NIMOEMOGMIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x74DDB00", Offset = "0x74DC500", VA = "0x1874DDB00")]
		private Vector3 ACEJLBKCEAN(float ADJNFMJNIAA)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x74DEFB0", Offset = "0x74DD9B0", VA = "0x1874DEFB0")]
		protected ButtonThemeBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x74DDB20", Offset = "0x74DC520", VA = "0x1874DDB20")]
		[CompilerGenerated]
		private void PMMJEADAOAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x74DDB20", Offset = "0x74DC520", VA = "0x1874DDB20")]
		[CompilerGenerated]
		private void BFHGKEECFAK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public class DepthTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		[SerializeField]
		private JLAPBMJJKGN depth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		[SerializeField]
		private bool animateOnEnable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		[SerializeField]
		[BENIALBDKBI("animateOnEnable")]
		private float animationTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private Vector3? HLEINELJFHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private Vector2 LFLIPHBCHNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private Vector2 KCKOIMPIECF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private Vector2 CGNHOOGODAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private Vector2 LFEKFONHHLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private Vector2 KOCAKHJJAJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private Vector2 DDFIOOHBAGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private readonly bool? LKPJKHOPPAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private PMCOEGDJBPD EOOJIOFIMHN;

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		private RectTransform NIALONHFOHG
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x74DF460", Offset = "0x74DDE60", VA = "0x1874DF460")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public JLAPBMJJKGN JBPFOIEAMFN
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x8F2EF0", Offset = "0x8F18F0", VA = "0x1808F2EF0")]
			get
			{
				return default(JLAPBMJJKGN);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x74E0150", Offset = "0x74DEB50", VA = "0x1874E0150")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		private PMCOEGDJBPD OLAABAJMNOG
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x74DF4C0", Offset = "0x74DDEC0", VA = "0x1874DF4C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		private bool CPCJPKDKNJE
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x74DFAA0", Offset = "0x74DE4A0", VA = "0x1874DFAA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x74DFC40", Offset = "0x74DE640", VA = "0x1874DFC40")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x74DFB90", Offset = "0x74DE590", VA = "0x1874DFB90")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x74DF550", Offset = "0x74DDF50", VA = "0x1874DF550", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x74DFCB0", Offset = "0x74DE6B0", VA = "0x1874DFCB0")]
		private void PCEEADECCDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x74DF710", Offset = "0x74DE110", VA = "0x1874DF710")]
		private Vector3 CCMJGKMNIEI()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x74DFFD0", Offset = "0x74DE9D0", VA = "0x1874DFFD0")]
		public DepthTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public class DropdownTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		[SerializeField]
		[EHNJJNMEJEA(BILCJMODHFE.Self, false, false, false)]
		private Dropdown dropdown;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		[SerializeField]
		[HIPIAIBDPPP(BILCJMODHFE.Self, false, true, false)]
		private Image surface;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		[SerializeField]
		private bool useSurfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		[SerializeField]
		[BENIALBDKBI("useSurfaceOverride")]
		private Image surfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		[SerializeField]
		private PNGJBPBKAOP dropdownType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		[SerializeField]
		private IJCDEJJPOFN textSize;

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public Image IIBPDEFDAHA
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x74E0790", Offset = "0x74DF190", VA = "0x1874E0790")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public PNGJBPBKAOP FEJGPNIKOJC
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x893630", Offset = "0x892030", VA = "0x180893630")]
			get
			{
				return default(PNGJBPBKAOP);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x74E07A0", Offset = "0x74DF1A0", VA = "0x1874E07A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public IJCDEJJPOFN COKFEJDLFDL
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xCAB010", Offset = "0xCA9A10", VA = "0x180CAB010")]
			get
			{
				return default(IJCDEJJPOFN);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x74E07C0", Offset = "0x74DF1C0", VA = "0x1874E07C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x74E0190", Offset = "0x74DEB90", VA = "0x1874E0190", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x74E0780", Offset = "0x74DF180", VA = "0x1874E0780")]
		public DropdownTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public class GraphicTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		[SerializeField]
		[EHNJJNMEJEA(BILCJMODHFE.Self, false, false, false)]
		private Graphic graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		[SerializeField]
		private bool useGraphicOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		[SerializeField]
		[BENIALBDKBI("useGraphicOverride")]
		private Graphic graphicOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		[SerializeField]
		private IJKMLLMJEEF color;

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public Graphic DHHLKALGEPK
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x74E1780", Offset = "0x74E0180", VA = "0x1874E1780")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public IJKMLLMJEEF BONCACFIIFO
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x8A2520", Offset = "0x8A0F20", VA = "0x1808A2520")]
			get
			{
				return default(IJKMLLMJEEF);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x74E1790", Offset = "0x74E0190", VA = "0x1874E1790")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public bool GHGDEMEGDLB
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x1207BC0", Offset = "0x12065C0", VA = "0x181207BC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x1207940", Offset = "0x1206340", VA = "0x181207940")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public Color? JCKHGLEENDP
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x74E1560", Offset = "0x74DFF60", VA = "0x1874E1560")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x74E1360", Offset = "0x74DFD60", VA = "0x1874E1360", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x884960", Offset = "0x883360", VA = "0x180884960")]
		public GraphicTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public class InputFieldTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		[SerializeField]
		[EHNJJNMEJEA(BILCJMODHFE.Self, false, false, false)]
		private TMP_InputField inputField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		[SerializeField]
		[HIPIAIBDPPP(BILCJMODHFE.Self, false, false, false)]
		private Image surface;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		[SerializeField]
		private bool useSurfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		[SerializeField]
		[BENIALBDKBI("useSurfaceOverride")]
		private Image surfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		[SerializeField]
		private FIDPEHBGHCL inputFieldType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		[SerializeField]
		private IJCDEJJPOFN textSize;

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public Image IIBPDEFDAHA
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x74E0790", Offset = "0x74DF190", VA = "0x1874E0790")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public FIDPEHBGHCL NLMLPAOHJJL
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x893630", Offset = "0x892030", VA = "0x180893630")]
			get
			{
				return default(FIDPEHBGHCL);
			}
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x74E07A0", Offset = "0x74DF1A0", VA = "0x1874E07A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public IJCDEJJPOFN COKFEJDLFDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0xCAB010", Offset = "0xCA9A10", VA = "0x180CAB010")]
			get
			{
				return default(IJCDEJJPOFN);
			}
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x74E07C0", Offset = "0x74DF1C0", VA = "0x1874E07C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x74E17E0", Offset = "0x74E01E0", VA = "0x1874E17E0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x74E0780", Offset = "0x74DF180", VA = "0x1874E0780")]
		public InputFieldTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public class LabelTheme : GraphicTheme
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		[SerializeField]
		[EHNJJNMEJEA(BILCJMODHFE.Self, false, false, false)]
		private TextMeshProUGUI textMeshProUGUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		[SerializeField]
		private PMPFFCCOKIG textType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		[SerializeField]
		private IJCDEJJPOFN textSize;

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public PMPFFCCOKIG GECJFKPEGFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0xACBAF0", Offset = "0xACA4F0", VA = "0x180ACBAF0")]
			get
			{
				return default(PMPFFCCOKIG);
			}
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x74E1FE0", Offset = "0x74E09E0", VA = "0x1874E1FE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public IJCDEJJPOFN COKFEJDLFDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x9206C0", Offset = "0x91F0C0", VA = "0x1809206C0")]
			get
			{
				return default(IJCDEJJPOFN);
			}
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x74E1FC0", Offset = "0x74E09C0", VA = "0x1874E1FC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x74E1CB0", Offset = "0x74E06B0", VA = "0x1874E1CB0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x74E1FB0", Offset = "0x74E09B0", VA = "0x1874E1FB0")]
		public LabelTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public class MakerPenToolTheme : ButtonThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		[Header("Maker Pen Tool")]
		[SerializeField]
		private EPIOLJOJCFH makerPenToolPaletteType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		[SerializeField]
		[Tooltip("A list of objects to show while the maker pen tool is active.")]
		private List<Hideable> hideWhenNotActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		[SerializeField]
		[Tooltip("A list of objects to show while the maker pen tool is inactive")]
		private List<Hideable> hideWhenActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		[SerializeField]
		private bool editorIsActiveOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x161")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		protected bool BMBIMGCCPCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x162")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		private bool KMLIMCONOEN;

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public EPIOLJOJCFH EHDAGKDFEJI
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x1158080", Offset = "0x1156A80", VA = "0x181158080")]
			get
			{
				return default(EPIOLJOJCFH);
			}
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x74DF440", Offset = "0x74DDE40", VA = "0x1874DF440")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public bool LKCOBPNALCI
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x74E2430", Offset = "0x74E0E30", VA = "0x1874E2430")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x74E2440", Offset = "0x74E0E40", VA = "0x1874E2440")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x74E23F0", Offset = "0x74E0DF0", VA = "0x1874E23F0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x74E2000", Offset = "0x74E0A00", VA = "0x1874E2000", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x74DF430", Offset = "0x74DDE30", VA = "0x1874DF430")]
		public MakerPenToolTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public class MixedToggleTheme : ButtonThemeBase
	{
		[Cpp2IlInjected.Token(Token = "0x200005A")]
		public enum KHDPJFPBJAI
		{
			[Cpp2IlInjected.Token(Token = "0x400019B")]
			Inactive,
			[Cpp2IlInjected.Token(Token = "0x400019C")]
			Mixed,
			[Cpp2IlInjected.Token(Token = "0x400019D")]
			Active
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		[SerializeField]
		private BPKMPPIPFGP toggleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		[SerializeField]
		[Tooltip("A list of objects to hide while the toggle is inactive.")]
		private List<Hideable> hideWhenInactive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		[SerializeField]
		[Tooltip("A list of objects to hide while the toggle is mixed.")]
		private List<Hideable> hideWhenMixed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		[SerializeField]
		[Tooltip("A list of objects to hide while the toggle is active")]
		private List<Hideable> hideWhenActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		[SerializeField]
		private KHDPJFPBJAI editorIsActiveOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private KHDPJFPBJAI KMLIMCONOEN;

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public KHDPJFPBJAI LKCOBPNALCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x74E2B00", Offset = "0x74E1500", VA = "0x1874E2B00")]
			get
			{
				return default(KHDPJFPBJAI);
			}
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x74E2AE0", Offset = "0x74E14E0", VA = "0x1874E2AE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x74E2AB0", Offset = "0x74E14B0", VA = "0x1874E2AB0")]
		public void Toggle()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x74E2AE0", Offset = "0x74E14E0", VA = "0x1874E2AE0")]
		public void Toggle(KHDPJFPBJAI KMLIMCONOEN, bool BMBIMGCCPCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x74E2500", Offset = "0x74E0F00", VA = "0x1874E2500", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x74DF430", Offset = "0x74DDE30", VA = "0x1874DF430")]
		public MixedToggleTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class PaletteTheme : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		[SerializeField]
		private bool usePaletteOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		[SerializeField]
		[BENIALBDKBI("usePaletteOverride")]
		private Palette paletteOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public PLAJPLAPENK PaletteChangeEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		[SerializeField]
		private bool useDepth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private MADEEJNOHNA JDGBNOGOAHL;

		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private const string CMBGBAFKPIC = "watch_layer";

		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private const string GKKKDPGEEOL = "depth_multiplier";

		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private const float LEHADBPBEFO = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private float? ACLKMEBKMAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private float? LBMKCHDAJFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private float? LILOGAHDIEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private float MAPMKODJLLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private float MOECKIMFCKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private float MBKBPKOKDCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private float FJGCFPLKIMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private readonly NMGCDKAGAKF MGNKHDNELGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private SFXAudioSource FMEGCDAOOGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private SFXAudioSource AHPGENIHABM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private ContentLoadingAudioPaletteAsset KCPKGPPIEMM;

		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private const float JKMNGGBOHED = 0.001f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private FMJNFMFLEFA IIMOCIFOGMP;

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public Palette MNFLHDFLIGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x74E53D0", Offset = "0x74E3DD0", VA = "0x1874E53D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public bool HDLNNJOCANP
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0xB75510", Offset = "0xB73F10", VA = "0x180B75510")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public float JPKKEJCMJGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x74E5150", Offset = "0x74E3B50", VA = "0x1874E5150")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		private bool IAGDOCPGCED
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x74E41D0", Offset = "0x74E2BD0", VA = "0x1874E41D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		private bool LIDOFKMMEDJ
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x74E4BF0", Offset = "0x74E35F0", VA = "0x1874E4BF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x74E3D70", Offset = "0x74E2770", VA = "0x1874E3D70")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x74E44B0", Offset = "0x74E2EB0", VA = "0x1874E44B0")]
		private void FLCNEHJPMNM(NLPBONJBAHG.COMPFIELOHH POPPNAABJGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x74E4C70", Offset = "0x74E3670", VA = "0x1874E4C70")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x74E4340", Offset = "0x74E2D40", VA = "0x1874E4340")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x74E3F20", Offset = "0x74E2920", VA = "0x1874E3F20")]
		private void BPFOIHOAOJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x74E3C50", Offset = "0x74E2650", VA = "0x1874E3C50")]
		public void AddLoadingSFXRequest(object KLGLJKMNAIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x74E4F70", Offset = "0x74E3970", VA = "0x1874E4F70")]
		public void RemoveLoadingSFXRequest(object KLGLJKMNAIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x74E4340", Offset = "0x74E2D40", VA = "0x1874E4340")]
		private void EEIFLCNHHKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x74E4A00", Offset = "0x74E3400", VA = "0x1874E4A00")]
		private void OHLIHMOHPMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x74E4890", Offset = "0x74E3290", VA = "0x1874E4890")]
		private void MNFAIALEMEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x74E40E0", Offset = "0x74E2AE0", VA = "0x1874E40E0")]
		private void CDDFHGLCOIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x74E4620", Offset = "0x74E3020", VA = "0x1874E4620")]
		private void MHFPHHIJHBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x74E44E0", Offset = "0x74E2EE0", VA = "0x1874E44E0")]
		private void HIICEPOAGON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x74E4610", Offset = "0x74E3010", VA = "0x1874E4610")]
		private void MAKPFAEDFML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x74E4250", Offset = "0x74E2C50", VA = "0x1874E4250")]
		private void COILNKEFIBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x74E45D0", Offset = "0x74E2FD0", VA = "0x1874E45D0")]
		private void HMHNGJIKDKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x74E4DA0", Offset = "0x74E37A0", VA = "0x1874E4DA0")]
		public void Play2DUIFlavorSFX(RecRoomAudioClip[] AALOGHGPKFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x74E5090", Offset = "0x74E3A90", VA = "0x1874E5090")]
		public PaletteTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public abstract class PaletteThemeReference : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		[SerializeField]
		[HIPIAIBDPPP(BILCJMODHFE.SelfAndParent, true, false, false)]
		private PaletteTheme paletteTheme;

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		protected PaletteTheme CIABBJPPKII
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		protected Palette MNFLHDFLIGJ
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x74E3AB0", Offset = "0x74E24B0", VA = "0x1874E3AB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		protected bool KLOAHLKKOKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x74E34B0", Offset = "0x74E1EB0", VA = "0x1874E34B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		protected Transform DELKODLMIJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x74E3530", Offset = "0x74E1F30", VA = "0x1874E3530")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x74E33B0", Offset = "0x74E1DB0", VA = "0x1874E33B0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x74E3B70", Offset = "0x74E2570", VA = "0x1874E3B70", Slot = "5")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void Apply();

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x74E35B0", Offset = "0x74E1FB0", VA = "0x1874E35B0")]
		public Color? GetColorFromPalette(IJKMLLMJEEF ABIODPGPHBM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x74E3760", Offset = "0x74E2160", VA = "0x1874E3760")]
		private void JOGIJCBOEOG(bool NIIJKDABPAI = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x884960", Offset = "0x883360", VA = "0x180884960")]
		protected PaletteThemeReference()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class RangeSliderTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		[SerializeField]
		[EHNJJNMEJEA(BILCJMODHFE.Self, false, false, false)]
		private RangeSlider slider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		[SerializeField]
		private IHMHCIKDDFG sliderType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		[SerializeField]
		private Image sliderImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		[SerializeField]
		private Image fillImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		[SerializeField]
		private Image lowHandleImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		[SerializeField]
		private Image highHandleImage;

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public IHMHCIKDDFG OJMCLJGMPJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x8893F0", Offset = "0x887DF0", VA = "0x1808893F0")]
			get
			{
				return default(IHMHCIKDDFG);
			}
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x74E6560", Offset = "0x74E4F60", VA = "0x1874E6560")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public Image ONIPFLGMPHM
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x8893E0", Offset = "0x887DE0", VA = "0x1808893E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public Image NGCCOAKKKNA
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x8853C0", VA = "0x1808869C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public Image JMMDPOMMEKD
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x8869B0", Offset = "0x8853B0", VA = "0x1808869B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public Image CCOACDABLMM
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x88C8B0", Offset = "0x88B2B0", VA = "0x18088C8B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public bool HLLPJBEJJOI
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x613E600", Offset = "0x613D000", VA = "0x18613E600")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x613E5E0", Offset = "0x613CFE0", VA = "0x18613E5E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x74E6260", Offset = "0x74E4C60", VA = "0x1874E6260", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x884960", Offset = "0x883360", VA = "0x180884960")]
		public RangeSliderTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public class RawImageTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		[SerializeField]
		[EHNJJNMEJEA(BILCJMODHFE.Self, false, false, false)]
		private RawImage image;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		[SerializeField]
		private APHGPFPCLIK color;

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public APHGPFPCLIK KPBOBHADMLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x8893F0", Offset = "0x887DF0", VA = "0x1808893F0")]
			get
			{
				return default(APHGPFPCLIK);
			}
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x74E6560", Offset = "0x74E4F60", VA = "0x1874E6560")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x74E6580", Offset = "0x74E4F80", VA = "0x1874E6580", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x884960", Offset = "0x883360", VA = "0x180884960")]
		public RawImageTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class RecyclingGridTheme : RecyclingThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		[SerializeField]
		[EHNJJNMEJEA(BILCJMODHFE.Self, false, false, false)]
		private HMOFPPMAOJE recyclingGrid;

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x74E66B0", Offset = "0x74E50B0", VA = "0x1874E66B0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x74E68B0", Offset = "0x74E52B0", VA = "0x1874E68B0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x74E6AA0", Offset = "0x74E54A0", VA = "0x1874E6AA0")]
		private void PKIJJBGCPFG(float ICKLBECKIMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x74E6B10", Offset = "0x74E5510", VA = "0x1874E6B10")]
		public RecyclingGridTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public class RecyclingListTheme : RecyclingThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		[SerializeField]
		[EHNJJNMEJEA(BILCJMODHFE.Self, false, false, false)]
		private HMOFPPMAOJE recyclingList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		private bool MKFIFMAICNG;

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x74E6B20", Offset = "0x74E5520", VA = "0x1874E6B20", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x74E6DD0", Offset = "0x74E57D0", VA = "0x1874E6DD0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x74E6D60", Offset = "0x74E5760", VA = "0x1874E6D60")]
		private void FDMDOOFGENG(float ICKLBECKIMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x74E6B10", Offset = "0x74E5510", VA = "0x1874E6B10")]
		public RecyclingListTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public abstract class RecyclingThemeBase : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		[Header("Audio")]
		[SerializeField]
		private NPADNCBBFNI recyclingAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		protected RecyclingAudioPaletteAsset AFIIKJNMFJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		[SerializeField]
		private KJJCBAPKCJB scrollingAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		private ScrollingAudioPaletteAsset FHOCOPEEHGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private FMJNFMFLEFA MHIJNDNMAOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private float ABNMJKOPDDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private float HAIAKPENMIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private float HKNDACCOPMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		private float MCIHDDKLDKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private bool IBADIIHODLO;

		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		private const float EANLINJKEEI = 0.01f;

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		private FMJNFMFLEFA IIMOCIFOGMP
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x74E7350", Offset = "0x74E5D50", VA = "0x1874E7350")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x74E7160", Offset = "0x74E5B60", VA = "0x1874E7160", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x74E7520", Offset = "0x74E5F20", VA = "0x1874E7520")]
		protected void EEIOILBIKIM(bool OPOJBPPBENN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x74E7B50", Offset = "0x74E6550", VA = "0x1874E7B50")]
		protected void HLPCHCEODHB(GameObject EDKOAHIAMMF, int AEIDELMDKKG, bool BNECICBOOJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x74E6FD0", Offset = "0x74E59D0", VA = "0x1874E6FD0")]
		protected void AFLLELFDBNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x74E77E0", Offset = "0x74E61E0", VA = "0x1874E77E0")]
		protected void EGCMBMKDKGI(float ICKLBECKIMP, float NCCFOENAJHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x74E7CE0", Offset = "0x74E66E0", VA = "0x1874E7CE0")]
		private void MFNEDCKDFCC(float PBMBJNLFAHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x74E73E0", Offset = "0x74E5DE0", VA = "0x1874E73E0")]
		private void DINPCLDOAHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x74E6B10", Offset = "0x74E5510", VA = "0x1874E6B10")]
		protected RecyclingThemeBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public class ScrollBarTheme : SelectableThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		[Header("Scroll Bar Audio")]
		[SerializeField]
		private AHDNLGCNFGL buttonAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		[SerializeField]
		[Tooltip("Layer a 2D SFX on top of base button sounds")]
		private bool useFlavorSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		[SerializeField]
		[BENIALBDKBI("useFlavorSFX")]
		[Tooltip("Flavor SFX is picked randomly from this pool config")]
		private RecRoomAudioClipPoolConfig flavorSFXClipPoolConfig;

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x74E7ED0", Offset = "0x74E68D0", VA = "0x1874E7ED0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x74E7FF0", Offset = "0x74E69F0", VA = "0x1874E7FF0")]
		public ScrollBarTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public class ScrollRectTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private const string APLBGMCPBKO = "RRUI.PlayHittingEndsSFX";

		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private const int IGCHLEOHBNK = 5;

		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private const int IDLIECNGNNH = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private DateTimeOffset FDNBCCNEGNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private int JHBEDJFLAEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private bool IDDCJCBHKDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		[SerializeField]
		[EHNJJNMEJEA(BILCJMODHFE.Self, false, false, false)]
		private ScrollRect scrollRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		[Header("Audio")]
		[SerializeField]
		private KJJCBAPKCJB scrollAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private ScrollingAudioPaletteAsset AFIIKJNMFJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private FMJNFMFLEFA MHIJNDNMAOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private BJLBEEMGDKC IOCJLKFEJMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private float HAIAKPENMIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		private float HKNDACCOPMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		private float MCIHDDKLDKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		private bool IBADIIHODLO;

		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		private const float EANLINJKEEI = 0.01f;

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		private FMJNFMFLEFA IIMOCIFOGMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x74E8390", Offset = "0x74E6D90", VA = "0x1874E8390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		private BJLBEEMGDKC ICNPKGOEKFP
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x74E8300", Offset = "0x74E6D00", VA = "0x1874E8300")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x74E80E0", Offset = "0x74E6AE0", VA = "0x1874E80E0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x74E97D0", Offset = "0x74E81D0", VA = "0x1874E97D0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x74E8000", Offset = "0x74E6A00", VA = "0x1874E8000", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x74E9040", Offset = "0x74E7A40", VA = "0x1874E9040")]
		private void EFDNGFPDAAL(Vector2 BJDHDJCINFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x74E94C0", Offset = "0x74E7EC0", VA = "0x1874E94C0")]
		private void MFNEDCKDFCC(float PBMBJNLFAHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x74E8420", Offset = "0x74E6E20", VA = "0x1874E8420")]
		private void DINPCLDOAHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x74E96B0", Offset = "0x74E80B0", VA = "0x1874E96B0")]
		private static string OAPIGNJAKCO(GameObject GIGIFGONEAO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x74E98C0", Offset = "0x74E82C0", VA = "0x1874E98C0")]
		public ScrollRectTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public abstract class SelectableThemeBase : PaletteThemeReference, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IPointerClickHandler, IPointerEnterHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		[Header("Selectable Theme Base")]
		[SerializeField]
		[EHNJJNMEJEA(BILCJMODHFE.Self, false, false, false)]
		[FormerlySerializedAs("button")]
		private Selectable selectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		[Header("Legacy Audio Override")]
		[SerializeField]
		[FormerlySerializedAs("overrideAudio")]
		[Tooltip("Override base selectable audio with a single SFX that plays only on click.")]
		protected bool overrideWithSingleAudio;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		[SerializeField]
		[BENIALBDKBI("overrideWithSingleAudio")]
		[Tooltip("The legacy override audio will be randomly picked from this pool")]
		protected RecRoomAudioClip[] randomAudioOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		protected bool DNLLKICAPFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private ButtonAudioPaletteAsset AFIIKJNMFJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private RecRoomAudioClipPoolConfig IHLODEGDMJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private NMGCDKAGAKF IMNMOOBNIHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		private NMGCDKAGAKF AGJMAGOGPFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private NMGCDKAGAKF EMKAPFKAFNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		private NMGCDKAGAKF HIJAHHOEKAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		private FMJNFMFLEFA MHIJNDNMAOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private CJHIACMNOBA BGLMPCAOOCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private IEHEOMDNPBM AHOACOOMINO;

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		protected Selectable JMPJGBGKJIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x8869A0", Offset = "0x8853A0", VA = "0x1808869A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		protected virtual bool EANHJOLIEFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x89F3F0", Offset = "0x89DDF0", VA = "0x18089F3F0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public bool HLLPJBEJJOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x613E600", Offset = "0x613D000", VA = "0x18613E600")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x613E5E0", Offset = "0x613CFE0", VA = "0x18613E5E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		private FMJNFMFLEFA IIMOCIFOGMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x74E9A00", Offset = "0x74E8400", VA = "0x1874E9A00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		protected CJHIACMNOBA ALPKNBEIGKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x74E9930", Offset = "0x74E8330", VA = "0x1874E9930")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		private IEHEOMDNPBM DFGBIBPJEDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x74EA5F0", Offset = "0x74E8FF0", VA = "0x1874EA5F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x74E9A90", Offset = "0x74E8490", VA = "0x1874E9A90")]
		protected void FPMFPJLAPKH(ButtonAudioPaletteAsset HJJDJMOOADN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x88C840", Offset = "0x88B240", VA = "0x18088C840")]
		protected void FFCPNNHJJNG(RecRoomAudioClipPoolConfig EJFKCJFAGIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x74EA360", Offset = "0x74E8D60", VA = "0x1874EA360", Slot = "12")]
		public virtual void OnPointerDown(PointerEventData NIMOEMOGMIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x74EA510", Offset = "0x74E8F10", VA = "0x1874EA510", Slot = "13")]
		public virtual void OnPointerUp(PointerEventData NIMOEMOGMIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x74EA000", Offset = "0x74E8A00", VA = "0x1874EA000", Slot = "14")]
		public virtual void OnPointerClick(PointerEventData NIMOEMOGMIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x74EA440", Offset = "0x74E8E40", VA = "0x1874EA440", Slot = "15")]
		public virtual void OnPointerEnter(PointerEventData NIMOEMOGMIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x74E9F80", Offset = "0x74E8980", VA = "0x1874E9F80")]
		private void OKLOFJCONHD(RecRoomAudioClip[] JLELILIKNOH, bool PDGBOGNEHBG = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x74E9B90", Offset = "0x74E8590", VA = "0x1874E9B90")]
		private void IGILIBJGDKJ(RecRoomAudioClip GBKHDPNANCN, bool PDGBOGNEHBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x74EA6C0", Offset = "0x74E90C0", VA = "0x1874EA6C0")]
		public void SetOnPointerDownSoundEffectDisabled(object KLGLJKMNAIM, bool JHPLPJBJOEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x74EA720", Offset = "0x74E9120", VA = "0x1874EA720")]
		public void SetOnPointerUpSoundEffectDisabled(object KLGLJKMNAIM, bool JHPLPJBJOEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x74EA690", Offset = "0x74E9090", VA = "0x1874EA690")]
		public void SetOnPointerClickSoundEffectDisabled(object KLGLJKMNAIM, bool JHPLPJBJOEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x74EA6F0", Offset = "0x74E90F0", VA = "0x1874EA6F0")]
		public void SetOnPointerEnterSoundEffectDisabled(object KLGLJKMNAIM, bool JHPLPJBJOEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x74E99C0", Offset = "0x74E83C0", VA = "0x1874E99C0")]
		private void BGHAGEFIIDA(NMGCDKAGAKF DBFJEMPBGIP, object KLGLJKMNAIM, bool JHPLPJBJOEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x74EA750", Offset = "0x74E9150", VA = "0x1874EA750")]
		protected SelectableThemeBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class SliderTheme : SelectableThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		[Header("Slider Visual")]
		[SerializeField]
		[EHNJJNMEJEA(BILCJMODHFE.Self, false, false, false)]
		private Slider slider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		[SerializeField]
		private IHMHCIKDDFG sliderType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		[Header("Slider Audio")]
		[SerializeField]
		private AHDNLGCNFGL buttonAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		[SerializeField]
		[Tooltip("Layer a 2D SFX on top of base button sounds")]
		private bool useFlavorSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		[SerializeField]
		[BENIALBDKBI("useFlavorSFX")]
		[Tooltip("Flavor SFX is picked randomly from this pool config")]
		private RecRoomAudioClipPoolConfig flavorSFXClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		[SerializeField]
		private Image sliderImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		[SerializeField]
		private Image fillImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		[SerializeField]
		private Image handleImage;

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public IHMHCIKDDFG OJMCLJGMPJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x88C850", Offset = "0x88B250", VA = "0x18088C850")]
			get
			{
				return default(IHMHCIKDDFG);
			}
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x74EAD30", Offset = "0x74E9730", VA = "0x1874EAD30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public Image ONIPFLGMPHM
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x888340", Offset = "0x886D40", VA = "0x180888340")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public Image NGCCOAKKKNA
		{
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0xA38CD0", Offset = "0xA376D0", VA = "0x180A38CD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public Image LBLADHFNDDD
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x8E18C0", Offset = "0x8E02C0", VA = "0x1808E18C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x74EA960", Offset = "0x74E9360", VA = "0x1874EA960", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x74EAD10", Offset = "0x74E9710", VA = "0x1874EAD10")]
		public SliderTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class SurfaceTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		[SerializeField]
		[EHNJJNMEJEA(BILCJMODHFE.Self, false, false, false)]
		private Image image;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		[SerializeField]
		[HIPIAIBDPPP(BILCJMODHFE.Self, false, false, false)]
		private UIGradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		[SerializeField]
		private PNEEIIGPCMI color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		[SerializeField]
		[BENIALBDKBI("gradient")]
		private bool ignoreGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		[SerializeField]
		[Tooltip("The surface theme determines if this Image is a RaycastTarget or not. There are times when you might want to ignore that setting of the palette theme and just respect whatever is the default state on the Image.")]
		private bool ignoreSettingRaycastTarget;

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public PNEEIIGPCMI MBKECJFJFOB
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x886B70", Offset = "0x885570", VA = "0x180886B70")]
			get
			{
				return default(PNEEIIGPCMI);
			}
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x74EAFB0", Offset = "0x74E99B0", VA = "0x1874EAFB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x74EAD50", Offset = "0x74E9750", VA = "0x1874EAD50", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x884960", Offset = "0x883360", VA = "0x180884960")]
		public SurfaceTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public class SwitchTheme : ToggleTheme
	{
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		private const float BMPNOLLOLKC = 0.33f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		[Header("Switch")]
		[SerializeField]
		private GameObject indicator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		[SerializeField]
		private GameObject indicatorOffPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		[SerializeField]
		private GameObject indicatorOnPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		private NMLHGOLNJPA JKLNPODMEGH;

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x74EAFD0", Offset = "0x74E99D0", VA = "0x1874EAFD0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x74EB230", Offset = "0x74E9C30", VA = "0x1874EB230")]
		public SwitchTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public class TilerTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		[SerializeField]
		[EHNJJNMEJEA(BILCJMODHFE.Self, false, false, false)]
		private UITiler tiler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		[SerializeField]
		private IBGHLMCMDGC type;

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x74EB7D0", Offset = "0x74EA1D0", VA = "0x1874EB7D0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x884960", Offset = "0x883360", VA = "0x180884960")]
		public TilerTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class ToggleTheme : ButtonThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		[Header("Toggle Visual")]
		[SerializeField]
		private BJOEGDCAIGJ toggleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		[SerializeField]
		[Tooltip("A list of objects to show while the toggle is active.")]
		private List<Hideable> hideWhenNotActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		[SerializeField]
		[Tooltip("A list of objects to show while the toggle is inactive")]
		private List<Hideable> hideWhenActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		[SerializeField]
		private bool editorIsActiveOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x161")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		[Tooltip("Override the audio palette when active defined by the toggle's visual with a custom palette")]
		[Header("Toggle Audio")]
		[SerializeField]
		private bool overrideAudioPaletteWhenActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		[SerializeField]
		[BENIALBDKBI("overrideAudioPaletteWhenActive")]
		[Tooltip("Specify a custom config to use for toggle button audio when active")]
		private ButtonAudioPaletteAsset customButtonAudioConfigWhenActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		[SerializeField]
		[Tooltip("Override the audio palette when inactive defined by the toggle's visual with a custom palette")]
		private bool overrideAudioPaletteWhenInactive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		[SerializeField]
		[BENIALBDKBI("overrideAudioPaletteWhenInactive")]
		[Tooltip("Specify a custom config to use for toggle button audio when inactive")]
		private ButtonAudioPaletteAsset customButtonAudioConfigWhenInactive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		[SerializeField]
		[Tooltip("Layer a 2D SFX on top of base button sounds. Flavor SFX only plays when toggling from inactive to active")]
		private bool useFlavorSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		[SerializeField]
		[BENIALBDKBI("useFlavorSFX")]
		[Tooltip("Flavor SFX is picked randomly from this pool config")]
		private RecRoomAudioClipPoolConfig flavorSFXClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		protected bool BMBIMGCCPCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x191")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		private bool OMGMCAAMFNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x192")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private bool KMLIMCONOEN;

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public bool LKCOBPNALCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x74EBF10", Offset = "0x74EA910", VA = "0x1874EBF10")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x74EBF20", Offset = "0x74EA920", VA = "0x1874EBF20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public BJOEGDCAIGJ FOOGPMEJEFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x1158080", Offset = "0x1156A80", VA = "0x181158080")]
			get
			{
				return default(BJOEGDCAIGJ);
			}
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x74DF440", Offset = "0x74DDE40", VA = "0x1874DF440")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		protected override bool EANHJOLIEFP
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x74EBE80", Offset = "0x74EA880", VA = "0x1874EBE80", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x74EBE40", Offset = "0x74EA840", VA = "0x1874EBE40", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x74EBED0", Offset = "0x74EA8D0", VA = "0x1874EBED0")]
		public void Toggle()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x74EBE90", Offset = "0x74EA890", VA = "0x1874EBE90")]
		public void Toggle(bool KMLIMCONOEN, bool BMBIMGCCPCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x74EBA60", Offset = "0x74EA460", VA = "0x1874EBA60", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x74EB230", Offset = "0x74E9C30", VA = "0x1874EB230")]
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
