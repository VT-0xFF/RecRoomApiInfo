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
using RecRoom.Logging.Attributes;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_RRUI_Theme_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Preserve]
	public class LogRegistrationIndex : DHBOPDJGFAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x9048630", Offset = "0x9046C30", VA = "0x189048630", Slot = "4")]
		public override void NCEHDCEOICJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RRUI
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class FontsConfig : SingletonAddressableScriptableObject<FontsConfig>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000004")]
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
		[Cpp2IlInjected.Token(Token = "0x2000005")]
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

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class BEJHDFKLDMO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public TMP_FontAsset font;

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
			public BEJHDFKLDMO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x9043D80", Offset = "0x9042380", VA = "0x189043D80")]
			internal bool PJPEJMOHFDB(LocalizedFontMapping x)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		[Tooltip("Mapping of non-localized font assets to their localized counterparts. By default text fields will forcibly revert to non-localized fonts unless the `AllowsNonLatinCharacters` component is present.")]
		private LocalizedFontMapping[] localizedFontMappings;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x90471F0", Offset = "0x90457F0", VA = "0x1890471F0")]
		public bool FKPCGJLLMEJ(TMP_FontAsset OFDDHBPEABE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9046FE0", Offset = "0x90455E0", VA = "0x189046FE0")]
		public TMP_FontAsset FCGAJEHAKDO(TMP_FontAsset OFDDHBPEABE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9046DA0", Offset = "0x90453A0", VA = "0x189046DA0")]
		public TMP_FontAsset FCGAJEHAKDO(TMP_FontAsset OFDDHBPEABE, Material BOANIKOKOII, [Out] Material IDPKCMKLOJD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9047320", Offset = "0x9045920", VA = "0x189047320")]
		public TMP_FontAsset GNGMKOPDOBH(TMP_FontAsset OFDDHBPEABE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9047480", Offset = "0x9045A80", VA = "0x189047480")]
		public TMP_FontAsset GNGMKOPDOBH(TMP_FontAsset OFDDHBPEABE, Material BOANIKOKOII, [Out] Material HBKEGNAFOAI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9047140", Offset = "0x9045740", VA = "0x189047140")]
		private static bool FGLKIFHAGBJ(TMP_FontAsset OFDDHBPEABE, LocalizedFontMapping MLAFPBKKHDI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9047680", Offset = "0x9045C80", VA = "0x189047680")]
		public FontsConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
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
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x9051E70", Offset = "0x9050470", VA = "0x189051E70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9051E10", Offset = "0x9050410", VA = "0x189051E10")]
		public ThemesConfig()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
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

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9047760", Offset = "0x9045D60", VA = "0x189047760", Slot = "0")]
		public override bool Equals(object MPIDDJPOOMJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9047700", Offset = "0x9045D00", VA = "0x189047700", Slot = "4")]
		public bool Equals(GradientBlock AAGCKLPFJME)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9047840", Offset = "0x9045E40", VA = "0x189047840", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class MultiGraphicButton : Button
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[SerializeField]
		private List<Graphic> additionalGraphics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[SerializeField]
		private ColorBlock additionalGraphicsColors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[SerializeField]
		private UIGradient backgroundGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[SerializeField]
		private GradientBlock backgroundGradients;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public List<Graphic> OLEKMIKBCIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xB9DD20", Offset = "0xB9C320", VA = "0x180B9DD20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xC1D4B0", Offset = "0xC1BAB0", VA = "0x180C1D4B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public ColorBlock ANBMBLPFHGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x90498E0", Offset = "0x9047EE0", VA = "0x1890498E0")]
			get
			{
				return default(ColorBlock);
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x9049960", Offset = "0x9047F60", VA = "0x189049960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public UIGradient DMDGMFLMFCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xB48BD0", Offset = "0xB471D0", VA = "0x180B48BD0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xC333C0", Offset = "0xC319C0", VA = "0x180C333C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public GradientBlock PCPKEPPOACI
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x9049930", Offset = "0x9047F30", VA = "0x189049930")]
			get
			{
				return default(GradientBlock);
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x90499B0", Offset = "0x9047FB0", VA = "0x1890499B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9049750", Offset = "0x9047D50", VA = "0x189049750", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x90497A0", Offset = "0x9047DA0", VA = "0x1890497A0")]
		public void Refresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9049610", Offset = "0x9047C10", VA = "0x189049610")]
		public void ForceHighlighted(bool BBPODKCLCOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9049630", Offset = "0x9047C30", VA = "0x189049630")]
		public void ForceNormal(bool BBPODKCLCOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x90491C0", Offset = "0x90477C0", VA = "0x1890491C0", Slot = "28")]
		protected override void DoStateTransition(SelectionState HFPFCKAPBFI, bool BBPODKCLCOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9049520", Offset = "0x9047B20", VA = "0x189049520")]
		private void EGBNCADFCCJ(Graphic AAHHHDCLDPL, Color CFKJAAHGJKO, bool BBPODKCLCOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9049650", Offset = "0x9047C50", VA = "0x189049650")]
		private void IIAJFFLHLCA(SelectionState HFPFCKAPBFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x90497D0", Offset = "0x9047DD0", VA = "0x1890497D0")]
		public MultiGraphicButton()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum JKADJNOOPBJ
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	Negative = 1,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	SelectPrimary = 2,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	SelectSidebar = 12,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	SelectCardToggle = 14,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	SelectSidebarInactive = 17,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	ToggleOnSwitch = 18,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	ToggleOffSwitch = 19,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	ToggleChip = 20,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	SliderDefault = 21
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public enum IHKJBEKMNJA
{
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	Default
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum AKHKCOAJDBE
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	Default
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum BLOLIJOECDK
{
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Default
}
namespace RRUI.Theme
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class AudioPalette : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public class ButtonAudioPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			[SerializeField]
			private JKADJNOOPBJ buttonAudioPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			[SerializeField]
			private ButtonAudioPaletteAsset buttonAudioPaletteConfig;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public JKADJNOOPBJ ButtonAudioPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000026")]
				[Cpp2IlInjected.Address(RVA = "0xAA5180", Offset = "0xAA3780", VA = "0x180AA5180")]
				get
				{
					return default(JKADJNOOPBJ);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public ButtonAudioPaletteAsset ButtonAudioPaletteConfig
			{
				[Cpp2IlInjected.Token(Token = "0x6000027")]
				[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
			public ButtonAudioPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public class ScrollingAudioPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			[SerializeField]
			private IHKJBEKMNJA scrollingAudioPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			[SerializeField]
			private ScrollingAudioPaletteAsset scrollingAudioPaletteConfig;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public IHKJBEKMNJA ScrollingAudioPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0xAA5180", Offset = "0xAA3780", VA = "0x180AA5180")]
				get
				{
					return default(IHKJBEKMNJA);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public ScrollingAudioPaletteAsset ScrollingAudioPaletteConfig
			{
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
			public ScrollingAudioPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public class ContentLoadingAudioPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			[SerializeField]
			private AKHKCOAJDBE contentLoadingAudioPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			[SerializeField]
			private ContentLoadingAudioPaletteAsset contentLoadingAudioPaletteConfig;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public AKHKCOAJDBE ContentLoadingAudioPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0xAA5180", Offset = "0xAA3780", VA = "0x180AA5180")]
				get
				{
					return default(AKHKCOAJDBE);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public ContentLoadingAudioPaletteAsset ContentLoadingAudioPaletteConfig
			{
				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
			public ContentLoadingAudioPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public class RecyclingAudioPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			[SerializeField]
			private BLOLIJOECDK recyclingAudioPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			[SerializeField]
			private RecyclingAudioPaletteAsset recyclingAudioPaletteConfig;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public BLOLIJOECDK RecyclingAudioPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0xAA5180", Offset = "0xAA3780", VA = "0x180AA5180")]
				get
				{
					return default(BLOLIJOECDK);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public RecyclingAudioPaletteAsset RecyclingAudioPaletteConfig
			{
				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
			public RecyclingAudioPaletteItem()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class PEIMDIGIJNC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public JKADJNOOPBJ buttonAudioPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
			public PEIMDIGIJNC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xB82B70", Offset = "0xB81170", VA = "0x180B82B70")]
			internal bool MBPGHIFJAAA(ButtonAudioPaletteItem buttonAudioPalette)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class DGHCCGIPGKJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public IHKJBEKMNJA scrollingAudioPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
			public DGHCCGIPGKJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xB82B70", Offset = "0xB81170", VA = "0x180B82B70")]
			internal bool CPACEAGHGJB(ScrollingAudioPaletteItem scrollingAudioPalette)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class GHNANILIBGE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public AKHKCOAJDBE contentLoadingAudioPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
			public GHNANILIBGE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xB82B70", Offset = "0xB81170", VA = "0x180B82B70")]
			internal bool GMKEBMINBJL(ContentLoadingAudioPaletteItem contentLoadingAudioPalette)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class NHIPAMNKJEI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public BLOLIJOECDK recyclingAudioPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
			public NHIPAMNKJEI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xB82B70", Offset = "0xB81170", VA = "0x180B82B70")]
			internal bool HKHGKBHIAPM(RecyclingAudioPaletteItem recyclingAudioPalette)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[SerializeField]
		[LEFPLNANOPP("ButtonAudioPaletteType")]
		private ButtonAudioPaletteItem[] buttonAudioPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[SerializeField]
		[LEFPLNANOPP("ScrollingAudioPaletteType")]
		private ScrollingAudioPaletteItem[] scrollingAudioPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[SerializeField]
		[LEFPLNANOPP("ContentLoadingAudioPaletteType")]
		private ContentLoadingAudioPaletteItem[] contentLoadingAudioPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[SerializeField]
		[LEFPLNANOPP("RecyclingAudioPaletteType")]
		private RecyclingAudioPaletteItem[] recyclingAudioPalettes;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x90439C0", Offset = "0x9041FC0", VA = "0x1890439C0")]
		public ButtonAudioPaletteAsset EDNKKPIDAEL(JKADJNOOPBJ JBMMGFFCJGM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9043BA0", Offset = "0x90421A0", VA = "0x189043BA0")]
		public ScrollingAudioPaletteAsset KDFOAMPHCPB(IHKJBEKMNJA KHBDIPIKBJE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9043AB0", Offset = "0x90420B0", VA = "0x189043AB0")]
		public ContentLoadingAudioPaletteAsset HBDPMODCJLI(AKHKCOAJDBE MKJHMAFLBBI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9043C90", Offset = "0x9042290", VA = "0x189043C90")]
		public RecyclingAudioPaletteAsset MOEHEIECHDD(BLOLIJOECDK CHBCBGOEBFI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xD5F7D0", Offset = "0xD5DDD0", VA = "0x180D5F7D0")]
		public AudioPalette()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ButtonAnimationPalette : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[SerializeField]
		private float clickAnimationDuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[SerializeField]
		private float clickAnimationScale;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float ClickAnimationDuration
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xB02260", Offset = "0xB00860", VA = "0x180B02260")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public float ClickAnimationScale
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xB02540", Offset = "0xB00B40", VA = "0x180B02540")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9043E90", Offset = "0x9042490", VA = "0x189043E90")]
		public ButtonAnimationPalette()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class ButtonPalette
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[Header("Background")]
		[SerializeField]
		private Color backgroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[SerializeField]
		[FormerlySerializedAs("colorBlock")]
		private ColorBlock backgroundTints;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[SerializeField]
		private GradientBlock backgroundGradients;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[Header("Foreground")]
		[SerializeField]
		private Color foregroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private ColorBlock foregroundTints;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[Header("Border")]
		[SerializeField]
		private bool showBorder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[Header("Text")]
		[SerializeField]
		private TextStylePalette textPalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[Header("Audio")]
		[SerializeField]
		private JKADJNOOPBJ audioPalette;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Color BackgroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xECC1B0", Offset = "0xECA7B0", VA = "0x180ECC1B0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public ColorBlock BackgroundTints
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x9043FB0", Offset = "0x90425B0", VA = "0x189043FB0")]
			get
			{
				return default(ColorBlock);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public GradientBlock BackgroundGradients
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x15764F0", Offset = "0x1574AF0", VA = "0x1815764F0")]
			get
			{
				return default(GradientBlock);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Color ForegroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x12C9FA0", Offset = "0x12C85A0", VA = "0x1812C9FA0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public ColorBlock ForegroundTints
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x9043FF0", Offset = "0x90425F0", VA = "0x189043FF0")]
			get
			{
				return default(ColorBlock);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool ShowBorder
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xB363C0", Offset = "0xB349C0", VA = "0x180B363C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public TextStylePalette TextPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xB37FD0", Offset = "0xB365D0", VA = "0x180B37FD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public JKADJNOOPBJ AudioPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xC2E980", Offset = "0xC2CF80", VA = "0x180C2E980")]
			get
			{
				return default(JKADJNOOPBJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9043EB0", Offset = "0x90424B0", VA = "0x189043EB0")]
		public ButtonPalette()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class DepthPalette
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		private float depth;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float Depth
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xDA16A0", Offset = "0xD9FCA0", VA = "0x180DA16A0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public DepthPalette()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class DropdownPalette
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		private Color backgroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[SerializeField]
		private Color foregroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[SerializeField]
		private TextStylePalette textPalette;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Color BackgroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xECC1B0", Offset = "0xECA7B0", VA = "0x180ECC1B0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public TextStylePalette TextPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xAA5720", Offset = "0xAA3D20", VA = "0x180AA5720")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x90466D0", Offset = "0x9044CD0", VA = "0x1890466D0")]
		public DropdownPalette()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class InputFieldPalette
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[SerializeField]
		private Color backgroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[SerializeField]
		private Color foregroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[SerializeField]
		private Color placeholderColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		private TextStylePalette textPalette;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Color BackgroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xECC1B0", Offset = "0xECA7B0", VA = "0x180ECC1B0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Color ForegroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0xEC0AD0", Offset = "0xEBF0D0", VA = "0x180EC0AD0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Color PlaceholderColor
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xF75380", Offset = "0xF73980", VA = "0x180F75380")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public TextStylePalette TextPalette
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xAA5620", Offset = "0xAA3C20", VA = "0x180AA5620")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x9047D50", Offset = "0x9046350", VA = "0x189047D50")]
		public InputFieldPalette()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class MakerPenToolPalette
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		private ButtonPalette buttonPalette;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public ButtonPalette ButtonPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public MakerPenToolPalette()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class MixedTogglePalette
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		private enum HCCIJIDEIBC
		{
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			UseBaseInactive,
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			UseBaseActive,
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			UseCustom
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[SerializeField]
		private JIFLMFDPNKE baseTogglePalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[SerializeField]
		private HCCIJIDEIBC mixedPaletteType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[SerializeField]
		[IEEHBALBFJL("mixedPaletteType", HCCIJIDEIBC.UseCustom)]
		private ButtonPalette mixedButtonPalette;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9048B80", Offset = "0x9047180", VA = "0x189048B80")]
		public TogglePalette NBEMKOECPHL(Palette BCJNLFBEAGB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9048B10", Offset = "0x9047110", VA = "0x189048B10")]
		public ButtonPalette MNMLAABGMIC(Palette BCJNLFBEAGB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public MixedTogglePalette()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class Palette : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public class RawImageColorPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			[SerializeField]
			private NCCNKGBFPPJ paletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			[SerializeField]
			private Color color;

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			public NCCNKGBFPPJ RawImageColorPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000067")]
				[Cpp2IlInjected.Address(RVA = "0xAA5180", Offset = "0xAA3780", VA = "0x180AA5180")]
				get
				{
					return default(NCCNKGBFPPJ);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			public Color Color
			{
				[Cpp2IlInjected.Token(Token = "0x6000068")]
				[Cpp2IlInjected.Address(RVA = "0x1C1B900", Offset = "0x1C19F00", VA = "0x181C1B900")]
				get
				{
					return default(Color);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xAEE1A0", Offset = "0xAEC7A0", VA = "0x180AEE1A0")]
			public RawImageColorPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public class BackgroundColorPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			[SerializeField]
			private GANJAHHDOCB backgroundColorPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			[SerializeField]
			private Color color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			[SerializeField]
			private Gradient gradient;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			[SerializeField]
			private bool raycastTarget;

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			public GANJAHHDOCB BackgroundColorPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600006A")]
				[Cpp2IlInjected.Address(RVA = "0xAA5180", Offset = "0xAA3780", VA = "0x180AA5180")]
				get
				{
					return default(GANJAHHDOCB);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			public Color Color
			{
				[Cpp2IlInjected.Token(Token = "0x600006B")]
				[Cpp2IlInjected.Address(RVA = "0x1C1B900", Offset = "0x1C19F00", VA = "0x181C1B900")]
				get
				{
					return default(Color);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			public Gradient Gradient
			{
				[Cpp2IlInjected.Token(Token = "0x600006C")]
				[Cpp2IlInjected.Address(RVA = "0xAA5560", Offset = "0xAA3B60", VA = "0x180AA5560")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			public bool RaycastTarget
			{
				[Cpp2IlInjected.Token(Token = "0x600006D")]
				[Cpp2IlInjected.Address(RVA = "0xAD4490", Offset = "0xAD2A90", VA = "0x180AD4490")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x9043E00", Offset = "0x9042400", VA = "0x189043E00")]
			public BackgroundColorPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		public class ForegroundColorPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			[SerializeField]
			private OKGAKFLDHNC foregroundColorPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			[SerializeField]
			private Color color;

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public OKGAKFLDHNC ForegroundColorPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600006F")]
				[Cpp2IlInjected.Address(RVA = "0xAA5180", Offset = "0xAA3780", VA = "0x180AA5180")]
				get
				{
					return default(OKGAKFLDHNC);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			public Color Color
			{
				[Cpp2IlInjected.Token(Token = "0x6000070")]
				[Cpp2IlInjected.Address(RVA = "0x1C1B900", Offset = "0x1C19F00", VA = "0x181C1B900")]
				get
				{
					return default(Color);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x90476E0", Offset = "0x9045CE0", VA = "0x1890476E0")]
			public ForegroundColorPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public class TilerPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			[SerializeField]
			private JIFOLKDMDFL tilerPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			[SerializeField]
			private TilerPalette tilerPalette;

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			public JIFOLKDMDFL TilerPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000072")]
				[Cpp2IlInjected.Address(RVA = "0xAA5180", Offset = "0xAA3780", VA = "0x180AA5180")]
				get
				{
					return default(JIFOLKDMDFL);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			public TilerPalette TilerPalette
			{
				[Cpp2IlInjected.Token(Token = "0x6000073")]
				[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
			public TilerPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public class TextStylePaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			[SerializeField]
			private HFCFPIDBADG textStylePaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			[SerializeField]
			private TextStylePalette textStylePalette;

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			public HFCFPIDBADG TextStylePaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000075")]
				[Cpp2IlInjected.Address(RVA = "0xAA5180", Offset = "0xAA3780", VA = "0x180AA5180")]
				get
				{
					return default(HFCFPIDBADG);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			public TextStylePalette TextStylePalette
			{
				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
			public TextStylePaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public class TextSizePaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			[SerializeField]
			private OEPDFHICCKL textSizePaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			[SerializeField]
			private int size;

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			public OEPDFHICCKL TextSizePaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0xAA5180", Offset = "0xAA3780", VA = "0x180AA5180")]
				get
				{
					return default(OEPDFHICCKL);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			public int Size
			{
				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0xBA16B0", Offset = "0xB9FCB0", VA = "0x180BA16B0")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x15F7820", Offset = "0x15F5E20", VA = "0x1815F7820")]
			public TextSizePaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public class ButtonPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			[SerializeField]
			private OHMHFBDDCKO buttonPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			[SerializeField]
			private ButtonPalette buttonPalette;

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			public OHMHFBDDCKO ButtonPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(RVA = "0xAA5180", Offset = "0xAA3780", VA = "0x180AA5180")]
				get
				{
					return default(OHMHFBDDCKO);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			public ButtonPalette ButtonPalette
			{
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
			public ButtonPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public class TogglePaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			[SerializeField]
			private JIFLMFDPNKE togglePaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			[SerializeField]
			private TogglePalette togglePalette;

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public JIFLMFDPNKE TogglePaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600007E")]
				[Cpp2IlInjected.Address(RVA = "0xAA5180", Offset = "0xAA3780", VA = "0x180AA5180")]
				get
				{
					return default(JIFLMFDPNKE);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public TogglePalette TogglePalette
			{
				[Cpp2IlInjected.Token(Token = "0x600007F")]
				[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
			public TogglePaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public class MixedTogglePaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			[SerializeField]
			private CBMOEGOCAFJ mixedTogglePaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			[SerializeField]
			private MixedTogglePalette mixedTogglePalette;

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public CBMOEGOCAFJ MixedTogglePaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000081")]
				[Cpp2IlInjected.Address(RVA = "0xAA5180", Offset = "0xAA3780", VA = "0x180AA5180")]
				get
				{
					return default(CBMOEGOCAFJ);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public MixedTogglePalette MixedTogglePalette
			{
				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
			public MixedTogglePaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public class MakerPenToolPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			[SerializeField]
			private GMFJJGBMOCA makerPenToolPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			[SerializeField]
			private MakerPenToolPalette makerPenToolPalette;

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public GMFJJGBMOCA MakerPenToolPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0xAA5180", Offset = "0xAA3780", VA = "0x180AA5180")]
				get
				{
					return default(GMFJJGBMOCA);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public MakerPenToolPalette MakerPenToolPalette
			{
				[Cpp2IlInjected.Token(Token = "0x6000085")]
				[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
			public MakerPenToolPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public class InputFieldPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			[SerializeField]
			private NJKNMENOIMA inputFieldPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			[SerializeField]
			private InputFieldPalette inputFieldPalette;

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public NJKNMENOIMA InputFieldPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0xAA5180", Offset = "0xAA3780", VA = "0x180AA5180")]
				get
				{
					return default(NJKNMENOIMA);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public InputFieldPalette InputFieldPalette
			{
				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
			public InputFieldPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public class DropdownPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			[SerializeField]
			private ANBMFKPKPCO dropdownPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			[SerializeField]
			private DropdownPalette dropdownPalette;

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public ANBMFKPKPCO DropdownPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600008A")]
				[Cpp2IlInjected.Address(RVA = "0xAA5180", Offset = "0xAA3780", VA = "0x180AA5180")]
				get
				{
					return default(ANBMFKPKPCO);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public DropdownPalette DropdownPalette
			{
				[Cpp2IlInjected.Token(Token = "0x600008B")]
				[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
			public DropdownPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public class SliderPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			[SerializeField]
			private NACIKEHBEGN sliderPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			[SerializeField]
			private SliderPalette sliderPalette;

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public NACIKEHBEGN SliderPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0xAA5180", Offset = "0xAA3780", VA = "0x180AA5180")]
				get
				{
					return default(NACIKEHBEGN);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public SliderPalette SliderPalette
			{
				[Cpp2IlInjected.Token(Token = "0x600008E")]
				[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
			public SliderPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public class DepthPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			[SerializeField]
			private EHBIINNABEL depthPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			[SerializeField]
			private DepthPalette depthPalette;

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			public EHBIINNABEL DepthPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000090")]
				[Cpp2IlInjected.Address(RVA = "0xAA5180", Offset = "0xAA3780", VA = "0x180AA5180")]
				get
				{
					return default(EHBIINNABEL);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public DepthPalette DepthPalette
			{
				[Cpp2IlInjected.Token(Token = "0x6000091")]
				[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
			public DepthPaletteItem()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private sealed class GPNMPAALCNC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public NCCNKGBFPPJ backgroundColorPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
			public GPNMPAALCNC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xB82B70", Offset = "0xB81170", VA = "0x180B82B70")]
			internal bool BLDHLMHAGOG(RawImageColorPaletteItem pi)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class PKHFFLMOFLO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public GANJAHHDOCB backgroundColorPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
			public PKHFFLMOFLO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xB82B70", Offset = "0xB81170", VA = "0x180B82B70")]
			internal bool HPIHNNJHNEE(BackgroundColorPaletteItem backgroundColorPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class HDOIPNFIOMC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public OKGAKFLDHNC foregroundColorPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
			public HDOIPNFIOMC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xB82B70", Offset = "0xB81170", VA = "0x180B82B70")]
			internal bool EGHICEMBCFJ(ForegroundColorPaletteItem colorPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[CompilerGenerated]
		private sealed class GLHOIHGIILA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public JIFOLKDMDFL type;

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
			public GLHOIHGIILA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0xB82B70", Offset = "0xB81170", VA = "0x180B82B70")]
			internal bool ALBMJLMGOCM(TilerPaletteItem tilerPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		[CompilerGenerated]
		private sealed class DHDACEHLHBL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public HFCFPIDBADG textStylePaletteType;

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
			public DHDACEHLHBL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xB82B70", Offset = "0xB81170", VA = "0x180B82B70")]
			internal bool IJFIDHFDPMI(TextStylePaletteItem textStylePaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class IKBEHFLMMDB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public OEPDFHICCKL textSizePaletteType;

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
			public IKBEHFLMMDB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xB82B70", Offset = "0xB81170", VA = "0x180B82B70")]
			internal bool BBLFAMLCLBC(TextSizePaletteItem textSizePaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class EFINBFCOPBD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public OHMHFBDDCKO buttonPaletteType;

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
			public EFINBFCOPBD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xB82B70", Offset = "0xB81170", VA = "0x180B82B70")]
			internal bool LDKJOCIJHPL(ButtonPaletteItem buttonPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000035")]
		[CompilerGenerated]
		private sealed class ELNFIKFINGD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public JIFLMFDPNKE togglePaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
			public ELNFIKFINGD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0xB82B70", Offset = "0xB81170", VA = "0x180B82B70")]
			internal bool IDHCLFOCPEH(TogglePaletteItem togglePaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000036")]
		[CompilerGenerated]
		private sealed class BMKCADLCMCO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public CBMOEGOCAFJ mixedTogglePaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
			public BMKCADLCMCO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0xB82B70", Offset = "0xB81170", VA = "0x180B82B70")]
			internal bool HFDIGDPLLLF(MixedTogglePaletteItem mixedTogglePaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[CompilerGenerated]
		private sealed class ELLAAJLJNCE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public GMFJJGBMOCA makerPenToolPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
			public ELLAAJLJNCE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xB82B70", Offset = "0xB81170", VA = "0x180B82B70")]
			internal bool DDPDJBEJOPC(MakerPenToolPaletteItem makerPenToolPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		[CompilerGenerated]
		private sealed class HJEMONDOGGP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public NJKNMENOIMA inputFieldPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
			public HJEMONDOGGP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xB82B70", Offset = "0xB81170", VA = "0x180B82B70")]
			internal bool DINEGINNPBH(InputFieldPaletteItem inputFieldPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000039")]
		[CompilerGenerated]
		private sealed class JEOHJHELMGG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public ANBMFKPKPCO dropdownPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
			public JEOHJHELMGG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xB82B70", Offset = "0xB81170", VA = "0x180B82B70")]
			internal bool JCEDOJBKCDA(DropdownPaletteItem dropdownPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		[CompilerGenerated]
		private sealed class EPKCLONKEMJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public NACIKEHBEGN sliderPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
			public EPKCLONKEMJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xB82B70", Offset = "0xB81170", VA = "0x180B82B70")]
			internal bool LGBLLFBKJHB(SliderPaletteItem sliderPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		[CompilerGenerated]
		private sealed class BDLLAKEMDDK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public EHBIINNABEL depthPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
			public BDLLAKEMDDK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xB82B70", Offset = "0xB81170", VA = "0x180B82B70")]
			internal bool PEEPJGONPOB(DepthPaletteItem depthPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[Header("Visual")]
		[SerializeField]
		[LEFPLNANOPP("RawImageColorPaletteType")]
		private RawImageColorPaletteItem[] rawImageColorPaletteItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[SerializeField]
		[LEFPLNANOPP("BackgroundColorPaletteType")]
		private BackgroundColorPaletteItem[] backgroundColorPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[SerializeField]
		[LEFPLNANOPP("ForegroundColorPaletteType")]
		private ForegroundColorPaletteItem[] foregroundColorPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[SerializeField]
		[LEFPLNANOPP("TilerPaletteType")]
		private TilerPaletteItem[] tilerPaletteItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[SerializeField]
		[LEFPLNANOPP("TextStylePaletteType")]
		private TextStylePaletteItem[] textStylePalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[SerializeField]
		[LEFPLNANOPP("TextSizePaletteType")]
		private TextSizePaletteItem[] textSizePalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[SerializeField]
		[LEFPLNANOPP("ButtonPaletteType")]
		private ButtonPaletteItem[] buttonPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[SerializeField]
		[LEFPLNANOPP("TogglePaletteType")]
		private TogglePaletteItem[] togglePalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[SerializeField]
		[LEFPLNANOPP("MixedTogglePaletteType")]
		private MixedTogglePaletteItem[] mixedTogglePalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[SerializeField]
		[LEFPLNANOPP("MakerPenToolPaletteType")]
		private MakerPenToolPaletteItem[] makerPenToolPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[SerializeField]
		[LEFPLNANOPP("InputFieldPaletteType")]
		private InputFieldPaletteItem[] inputFieldPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[SerializeField]
		[LEFPLNANOPP("DropdownPaletteType")]
		private DropdownPaletteItem[] dropdownPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[SerializeField]
		[LEFPLNANOPP("SliderPaletteType")]
		private SliderPaletteItem[] sliderPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[SerializeField]
		[LEFPLNANOPP("DepthPaletteType")]
		private DepthPaletteItem[] depthPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[SerializeField]
		private ButtonAnimationPalette buttonAnimationPalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[Header("Audio")]
		[SerializeField]
		[FormerlySerializedAs("audioPaletteConfig")]
		private AudioPalette audioPalette;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public IEnumerable<DepthPaletteItem> DepthPalettes
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xAB04B0", Offset = "0xAAEAB0", VA = "0x180AB04B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public ButtonAnimationPalette ButtonAnimationPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xAB0560", Offset = "0xAAEB60", VA = "0x180AB0560")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public AudioPalette AudioPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xB2DCA0", Offset = "0xB2C2A0", VA = "0x180B2DCA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x904C0A0", Offset = "0x904A6A0", VA = "0x18904C0A0")]
		public Color INGNLJHHAOC(NCCNKGBFPPJ HCBONHICHBO)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x904BB70", Offset = "0x904A170", VA = "0x18904BB70")]
		public void DNKJEGMNHMG(GANJAHHDOCB HCBONHICHBO, [Out] Color FPHNLEHIJEM, [Out] Gradient EJDPPOFLBAG, [Out] bool MCECFHIIKBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x904C3C0", Offset = "0x904A9C0", VA = "0x18904C3C0")]
		public Color KJJHPLNCLAK(OKGAKFLDHNC JLLIPEEALNK)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x904C6A0", Offset = "0x904ACA0", VA = "0x18904C6A0")]
		public TilerPalette OENPBIDLKEH(JIFOLKDMDFL GPEIAHGICNA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x904BA80", Offset = "0x904A080", VA = "0x18904BA80")]
		public TextStylePalette BOEDCPNENAE(HFCFPIDBADG PDALMNGGBFL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x904C2D0", Offset = "0x904A8D0", VA = "0x18904C2D0")]
		public int JNLJFKLKGBP(OEPDFHICCKL AAGIOMHMKMM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x904BFB0", Offset = "0x904A5B0", VA = "0x18904BFB0")]
		public ButtonPalette ILBFNBLCCJL(OHMHFBDDCKO IIDAFJHNLCC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x904BCE0", Offset = "0x904A2E0", VA = "0x18904BCE0")]
		public TogglePalette EKEMJGIKAFN(JIFLMFDPNKE JBFBMKJAFLN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x904C5B0", Offset = "0x904ABB0", VA = "0x18904C5B0")]
		public MixedTogglePalette MBDFBCNLEJA(CBMOEGOCAFJ IHCKAOGOFKG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x904C4C0", Offset = "0x904AAC0", VA = "0x18904C4C0")]
		public MakerPenToolPalette LHDHHEFJEOA(GMFJJGBMOCA OGKMMNFCGDL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x904BEC0", Offset = "0x904A4C0", VA = "0x18904BEC0")]
		public InputFieldPalette FIKHBPJCDBN(NJKNMENOIMA JADNHALPBCK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x904BDD0", Offset = "0x904A3D0", VA = "0x18904BDD0")]
		public DropdownPalette FFHJONOMNOA(ANBMFKPKPCO EHDDCFAOHII)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x904B990", Offset = "0x9049F90", VA = "0x18904B990")]
		public SliderPalette AJKKMNBNBBD(NACIKEHBEGN CDNADHADPDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x904C1A0", Offset = "0x904A7A0", VA = "0x18904C1A0")]
		public float? IOIBHGICICK(EHBIINNABEL OPDDOABMJLP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xD5F7D0", Offset = "0xD5DDD0", VA = "0x180D5F7D0")]
		public Palette()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public class SliderPalette
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[SerializeField]
		private Color sliderColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[SerializeField]
		private Color fillColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[SerializeField]
		private Color handleColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[SerializeField]
		private TextStylePalette textPalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[SerializeField]
		private Color textColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[SerializeField]
		private ColorBlock colorBlock;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public Color SliderColor
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xECC1B0", Offset = "0xECA7B0", VA = "0x180ECC1B0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public Color FillColor
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xEC0AD0", Offset = "0xEBF0D0", VA = "0x180EC0AD0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public Color HandleColor
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xF75380", Offset = "0xF73980", VA = "0x180F75380")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public ColorBlock ColorBlock
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x9050EE0", Offset = "0x904F4E0", VA = "0x189050EE0")]
			get
			{
				return default(ColorBlock);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x9050E20", Offset = "0x904F420", VA = "0x189050E20")]
		public SliderPalette()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public class TextStylePalette
	{
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		public enum JHEKFDKIFLN
		{
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			LowerCase,
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			UpperCase,
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			SmallCaps
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[SerializeField]
		private TMP_FontAsset font;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[SerializeField]
		private Material fontOverrideMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[SerializeField]
		private float kerning;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		[SerializeField]
		private float leading;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[SerializeField]
		private bool isBold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[SerializeField]
		private bool isItalic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[SerializeField]
		private JHEKFDKIFLN transformation;

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x9051910", Offset = "0x904FF10", VA = "0x189051910")]
		public void MEMEOJMMGJA(TextMeshProUGUI KMHLBCIOMFI, bool MMIKMFNLGID = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public TextStylePalette()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public class TilerPalette
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		[SerializeField]
		private Sprite sprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[SerializeField]
		private Color tintColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[SerializeField]
		private Color backgroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[SerializeField]
		private float rows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[SerializeField]
		private Vector2 spacing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[SerializeField]
		private float offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[SerializeField]
		private Vector2 velocity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		[SerializeField]
		[Range(0f, 360f)]
		private float angle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		[SerializeField]
		private UITiler.NOGOMEHMAHJ animationDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		[SerializeField]
		private float primaryAnimationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		[SerializeField]
		private float altAnimationSpeed;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public Sprite Sprite
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public Color TintColor
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xBF19C0", Offset = "0xBEFFC0", VA = "0x180BF19C0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public Color BackgroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x1455470", Offset = "0x1453A70", VA = "0x181455470")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public float Rows
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xAF8E90", Offset = "0xAF7490", VA = "0x180AF8E90")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public Vector2 Spacing
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x10A5000", Offset = "0x10A3600", VA = "0x1810A5000")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public float Offset
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0xE8F460", Offset = "0xE8DA60", VA = "0x180E8F460")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public Vector2 Velocity
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x2A7A370", Offset = "0x2A78970", VA = "0x182A7A370")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public float Angle
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x12C9FF0", Offset = "0x12C85F0", VA = "0x1812C9FF0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public UITiler.NOGOMEHMAHJ AnimationDirection
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x1342270", Offset = "0x1340870", VA = "0x181342270")]
			get
			{
				return default(UITiler.NOGOMEHMAHJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public float PrimaryAnimationSpeed
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x12C9FE0", Offset = "0x12C85E0", VA = "0x1812C9FE0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public float AltAnimationSpeed
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x12CA020", Offset = "0x12C8620", VA = "0x1812CA020")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x9051EA0", Offset = "0x90504A0", VA = "0x189051EA0")]
		public TilerPalette()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public class TogglePalette
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		[SerializeField]
		private ButtonPalette inactiveButtonPalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		[SerializeField]
		private ButtonPalette activeButtonPalette;

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public ButtonPalette InactiveButtonPalette
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public ButtonPalette ActiveButtonPalette
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public TogglePalette()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public enum GANJAHHDOCB
{
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	PrimarySolid,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	SecondarySolid,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	HighlightSolid,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	HighlightGradient,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	BannerBG,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	InputField,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	LineColor,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	CardImageBase,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	DarkGradient,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	Shadow,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	Error,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	Warning,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	NotiBase,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	BackgroundAccent,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	SideBarBG,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	Modified,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	LoadingScreen,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	LoadingBarGradient,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	HomeButtonBase,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	TitleRoot,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	HighlightedAccent,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	LoadingCard,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	ChipBase,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	LimitedEventCard,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	LimitedEventBgSolid,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	DateChip,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	WinterWonderlandBG,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	RuntimeAddedTag,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	RuntimeDeletedTag,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	MakerAI,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	RRPlus
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public enum NCCNKGBFPPJ
{
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	A
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public enum OKGAKFLDHNC
{
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	MainPrimary,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	MainSecondary,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	InversePrimary,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	NotUse,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	WhitePrimary,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	WhiteSecondary,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	CardPrimary,
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	CardSecondary,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	Error,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	Modified,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	Orange
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public enum JIFOLKDMDFL
{
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	WatchBackground,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	HomePage,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	DialogPage,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	Card,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	ProfileBG,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	WinterWonderlandHome
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public enum HFCFPIDBADG
{
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	JostMedium,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	JostMediumCap,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	JostBoldCap,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	RobotoReg,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	RobotoBold,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	RobotoBoldOutlineDropshadow,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	RobotoBoldOutline,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	RobotoBoldOutlineDropshadowGradient,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	RobotoBoldOutlineGradient
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public enum OEPDFHICCKL
{
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	XXXS = -1,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	XXS = 0,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	XS = 1,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	S = 2,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	M = 3,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	L = 4,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	XL = 5,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	XXL = 8,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	XXXL = 6,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	XXXXL = 7
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public enum OHMHFBDDCKO
{
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	Primary,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	Secondary,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	FlatPrimary,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	FlatButtonForWarningBanner,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	Negative,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	Chips,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	CarouselArrowDark,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	FlatWhite,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	MagicDoor,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Tertiary_DupeWith2NDHeader_NeedReplace,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	CarouselArrowLight,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	HomePageMainButton,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	DropDown,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	SecondaryHeaderSection,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	ChatButton,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	FeedButton,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	NameTag,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	RoomCurrency,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	ChipsWhite,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	UGCBaseButton,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	UGCBaseButton_Subtle_NoDisabledState,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	RevenuePurchaseGreen,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	RecRoomPlus,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	SearchBar
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public enum JIFLMFDPNKE
{
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	FlatOrange,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	FlatWhite,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	InputToggle,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	Chips,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	Switch,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	WhitePagingBlob,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	RSVPToggleHeaderSection,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	CardSelectableToggle,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	ChipsDark,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	MainNavToggle,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	ListItem,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	NotiUnread,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	FlatPrimary,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	CharadePen,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	ShareCam,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	CardSelectableToggleWithBacking,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	SecondaryHeaderSectionToggle,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	PrimaryToSecondaryHeader,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	NegativeToSecondaryHeader,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	LimitedEventPrimary,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	LimitedEventSecondary,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	RoomCardWithLimitedEvent,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	MainNavVrDetach,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	HomeMainNav,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	FlatOrangeSecondary,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	ChipsPurple,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	ShareCamTab
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public enum CBMOEGOCAFJ
{
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	Checkbox
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public enum GMFJJGBMOCA
{
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	Create,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	Select,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	Wire,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	Configure,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	Transform,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	Move,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	Rotate,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	Scale,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	CloneFlip,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	Recolor,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	Freeze,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	MakeInvention,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	Manipulate,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	Delete,
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	SelectConnect,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	ResetMakerAI,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	NewMove
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public enum NJKNMENOIMA
{
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	LightFlat,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	DarkFlat,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	Modified
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public enum ANBMFKPKPCO
{
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	LightFlat,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	DarkFlat
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public enum NACIKEHBEGN
{
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	MirroUIPopUp
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public enum EHBIINNABEL
{
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	Base,
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	Button,
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	Navigation,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	Overlay,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	Dialog,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	Toast
}
namespace RRUI.Theme
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public class ApproximationMaskDepthTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		[SerializeField]
		private RectTransform content;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private Vector3? FGMHENAMABA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private Vector3? DCBNPAPBMAC;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x9043890", Offset = "0x9041E90", VA = "0x189043890")]
		private void BDBKJLHAGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x90434E0", Offset = "0x9041AE0", VA = "0x1890434E0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x9043970", Offset = "0x9041F70", VA = "0x189043970")]
		public ApproximationMaskDepthTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public class ButtonTheme : ButtonThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		[Header("Button Visual")]
		[SerializeField]
		private OHMHFBDDCKO buttonType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14C")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		[Header("Button Audio")]
		[SerializeField]
		[Tooltip("Override the audio palette defined by the button's visual with a custom palette")]
		private bool overrideButtonAudioPalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		[IEEHBALBFJL("overrideButtonAudioPalette")]
		[Tooltip("Specify a custom config to use for button audio")]
		[SerializeField]
		private ButtonAudioPaletteAsset customButtonAudioConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		[SerializeField]
		[Tooltip("Layer a 2D SFX on top of base button sounds")]
		private bool useFlavorSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		[SerializeField]
		[IEEHBALBFJL("useFlavorSFX")]
		[Tooltip("Flavor SFX is picked randomly from this pool config")]
		private RecRoomAudioClipPoolConfig flavorSFXClipPoolConfig;

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public OHMHFBDDCKO HAGKGJJJPDJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x191C730", Offset = "0x191AD30", VA = "0x18191C730")]
			get
			{
				return default(OHMHFBDDCKO);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x9045960", Offset = "0x9043F60", VA = "0x189045960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x90456F0", Offset = "0x9043CF0", VA = "0x1890456F0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0xC82780", Offset = "0xC80D80", VA = "0x180C82780")]
		public void SetAnimationEnabled(bool KBMMNNBFAAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x9045950", Offset = "0x9043F50", VA = "0x189045950")]
		public ButtonTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public abstract class ButtonThemeBase : SelectableThemeBase
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		protected class HECIPLPLJAF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000175")]
			public ButtonAudioPaletteAsset HENDMNMCGJM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000176")]
			public RecRoomAudioClipPoolConfig GIFPIOLLADB;

			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
			public HECIPLPLJAF()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		[DECECLMOCEO(GJFENOMGFMJ.Self, false, false, false)]
		[Header("Button Theme Base")]
		[SerializeField]
		private MultiGraphicButton multiGraphicButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		[SerializeField]
		[DECECLMOCEO(GJFENOMGFMJ.Self, false, true, false)]
		private Image surface;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		[SerializeField]
		private bool useSurfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		[SerializeField]
		[IEEHBALBFJL("useSurfaceOverride")]
		private Image surfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		[SerializeField]
		private bool controlSurfaceColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		[SerializeField]
		[ReadOnlyField]
		private List<Graphic> graphics;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		[SerializeField]
		private bool useGraphicsOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		[SerializeField]
		[IEEHBALBFJL("useGraphicsOverride")]
		private List<Graphic> graphicsOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		[SerializeField]
		[NHGKHOGALHB("useGraphicsOverride", new object[] { })]
		private bool graphicsIgnoreTextFields;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		[SerializeField]
		private bool controlGraphicColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		[SerializeField]
		[DECECLMOCEO(GJFENOMGFMJ.Self, false, true, false)]
		private UIGradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		[SerializeField]
		private bool useGradientOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		[SerializeField]
		[IEEHBALBFJL("useGradientOverride")]
		private UIGradient gradientOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		[SerializeField]
		[DECECLMOCEO(GJFENOMGFMJ.Children, true, true, false)]
		private TextMeshProUGUI textMeshProUGUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		[SerializeField]
		private bool useTextMeshProUGUIOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		[SerializeField]
		[IEEHBALBFJL("useTextMeshProUGUIOverride")]
		private TextMeshProUGUI textMeshProUGUIOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		[SerializeField]
		private OEPDFHICCKL textSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		[SerializeField]
		protected Hideable borderHideable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		[SerializeField]
		protected bool isAnimationEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x111")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		[SerializeField]
		[IEEHBALBFJL("isAnimationEnabled")]
		protected bool overrideAnimationTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		[SerializeField]
		[IEEHBALBFJL("overrideAnimationTarget")]
		protected GameObject animationTargetOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private bool ANNMLJNOEFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private Vector3 FKOENLNPAJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private Vector3 KABPGLJACCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private ABDCGLIPPBP BPMHODEDNEF;

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public Image OEAELJNLIJJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x9045690", Offset = "0x9043C90", VA = "0x189045690")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public List<Graphic> AOMBAOPKGEO
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x9045670", Offset = "0x9043C70", VA = "0x189045670")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public UIGradient DKCNBFHJEBI
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x9045650", Offset = "0x9043C50", VA = "0x189045650")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public TextMeshProUGUI OPKGAJNCIGB
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x90456B0", Offset = "0x9043CB0", VA = "0x1890456B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public OEPDFHICCKL GEJEPPBJNNP
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x18B12A0", Offset = "0x18AF8A0", VA = "0x1818B12A0")]
			get
			{
				return default(OEPDFHICCKL);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x90456D0", Offset = "0x9043CD0", VA = "0x1890456D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		protected Transform FPJGMBDMLCI
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x9044200", Offset = "0x9042800", VA = "0x189044200")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public Button FCOIIPLBPOF
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x90455C0", Offset = "0x9043BC0", VA = "0x1890455C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x9044310", Offset = "0x9042910", VA = "0x189044310")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x9044270", Offset = "0x9042870", VA = "0x189044270")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x9044040", Offset = "0x9042640", VA = "0x189044040")]
		protected void AIAHPMCFOON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x9044A60", Offset = "0x9043060", VA = "0x189044A60")]
		protected void POLOENFENBA(ButtonPalette GLFGEENPEAB, [Optional] HECIPLPLJAF IMENOLBLFON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x90443B0", Offset = "0x90429B0", VA = "0x1890443B0", Slot = "12")]
		public override void OnPointerDown(PointerEventData CBIMJBOHKKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x9044760", Offset = "0x9042D60", VA = "0x189044760", Slot = "13")]
		public override void OnPointerUp(PointerEventData CBIMJBOHKKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x9044390", Offset = "0x9042990", VA = "0x189044390", Slot = "14")]
		public override void OnPointerClick(PointerEventData CBIMJBOHKKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x9044250", Offset = "0x9042850", VA = "0x189044250")]
		private Vector3 IAFNHMCJJJA(float EAHAEIJNIMH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x90454D0", Offset = "0x9043AD0", VA = "0x1890454D0")]
		protected ButtonThemeBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x19893A0", Offset = "0x19879A0", VA = "0x1819893A0")]
		[CompilerGenerated]
		private void IPDPGEJPIBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x19893A0", Offset = "0x19879A0", VA = "0x1819893A0")]
		[CompilerGenerated]
		private void GJNGDFONODC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public class DepthTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		[SerializeField]
		private EHBIINNABEL depth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		[SerializeField]
		private bool animateOnEnable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		[SerializeField]
		[IEEHBALBFJL("animateOnEnable")]
		private float animationTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private Vector3? FGMHENAMABA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private Vector2 MHMOMLGAGLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private Vector2 GKNBDKJAHPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private Vector2 EMPIODGCOID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private Vector2 CBDAPIDNHBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private Vector2 COGLIAONOOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private Vector2 GIOCCINCOIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private readonly bool? HBGJDJKLMDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private HEAELCMEANA APOBMNCECGF;

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		private RectTransform NDCKEHCFJOL
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x90461F0", Offset = "0x90447F0", VA = "0x1890461F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public EHBIINNABEL KOECFDDKNPH
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0xAFC970", Offset = "0xAFAF70", VA = "0x180AFC970")]
			get
			{
				return default(EHBIINNABEL);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x90466B0", Offset = "0x9044CB0", VA = "0x1890466B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		private HEAELCMEANA HLMFIANODJJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x9046460", Offset = "0x9044A60", VA = "0x189046460")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		private bool IHFPCHDHCAH
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x9046250", Offset = "0x9044850", VA = "0x189046250")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x90463F0", Offset = "0x90449F0", VA = "0x1890463F0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x9046340", Offset = "0x9044940", VA = "0x189046340")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x9045980", Offset = "0x9043F80", VA = "0x189045980", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x9045B40", Offset = "0x9044140", VA = "0x189045B40")]
		private void BDBKJLHAGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x9045E60", Offset = "0x9044460", VA = "0x189045E60")]
		private Vector3 JBKCOMNKNFA()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x90464F0", Offset = "0x9044AF0", VA = "0x1890464F0")]
		public DepthTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public class DropdownTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		[SerializeField]
		[OOBMCMDIFDG(GJFENOMGFMJ.Self, false, false, false)]
		private Dropdown dropdown;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		[SerializeField]
		[DECECLMOCEO(GJFENOMGFMJ.Self, false, true, false)]
		private Image surface;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		[SerializeField]
		private bool useSurfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		[SerializeField]
		[IEEHBALBFJL("useSurfaceOverride")]
		private Image surfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		[SerializeField]
		private ANBMFKPKPCO dropdownType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		[SerializeField]
		private OEPDFHICCKL textSize;

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public Image OEAELJNLIJJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x9046D50", Offset = "0x9045350", VA = "0x189046D50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public ANBMFKPKPCO ICGIOHGCEGO
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0xB28EF0", Offset = "0xB274F0", VA = "0x180B28EF0")]
			get
			{
				return default(ANBMFKPKPCO);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x9046D60", Offset = "0x9045360", VA = "0x189046D60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public OEPDFHICCKL GEJEPPBJNNP
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xEC0B20", Offset = "0xEBF120", VA = "0x180EC0B20")]
			get
			{
				return default(OEPDFHICCKL);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x9046D80", Offset = "0x9045380", VA = "0x189046D80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x90466F0", Offset = "0x9044CF0", VA = "0x1890466F0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x9046D00", Offset = "0x9045300", VA = "0x189046D00")]
		public DropdownTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public class GraphicTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		[SerializeField]
		[OOBMCMDIFDG(GJFENOMGFMJ.Self, false, false, false)]
		private Graphic graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		[SerializeField]
		private bool useGraphicOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		[SerializeField]
		[IEEHBALBFJL("useGraphicOverride")]
		private Graphic graphicOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		[SerializeField]
		private OKGAKFLDHNC color;

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public Graphic AHBLKKNEAHA
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x9047D20", Offset = "0x9046320", VA = "0x189047D20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public OKGAKFLDHNC OIJCNLFODFF
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0xAC5000", Offset = "0xAC3600", VA = "0x180AC5000")]
			get
			{
				return default(OKGAKFLDHNC);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x9047D30", Offset = "0x9046330", VA = "0x189047D30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public bool EFNHBEMLINB
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0xFE10B0", Offset = "0xFDF6B0", VA = "0x180FE10B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0xFE0520", Offset = "0xFDEB20", VA = "0x180FE0520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public Color? FCHLBALIDNI
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x9047B00", Offset = "0x9046100", VA = "0x189047B00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x90478B0", Offset = "0x9045EB0", VA = "0x1890478B0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x9047AB0", Offset = "0x90460B0", VA = "0x189047AB0")]
		public GraphicTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public class InputFieldTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		[SerializeField]
		[OOBMCMDIFDG(GJFENOMGFMJ.Self, false, false, false)]
		private TMP_InputField inputField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		[SerializeField]
		[DECECLMOCEO(GJFENOMGFMJ.Self, false, false, false)]
		private Image surface;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		[SerializeField]
		private bool useSurfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		[SerializeField]
		[IEEHBALBFJL("useSurfaceOverride")]
		private Image surfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		[SerializeField]
		private NJKNMENOIMA inputFieldType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		[SerializeField]
		private OEPDFHICCKL textSize;

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public Image OEAELJNLIJJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x9046D50", Offset = "0x9045350", VA = "0x189046D50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public NJKNMENOIMA LNBCJGAMIFK
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0xB28EF0", Offset = "0xB274F0", VA = "0x180B28EF0")]
			get
			{
				return default(NJKNMENOIMA);
			}
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x9046D60", Offset = "0x9045360", VA = "0x189046D60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public OEPDFHICCKL GEJEPPBJNNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0xEC0B20", Offset = "0xEBF120", VA = "0x180EC0B20")]
			get
			{
				return default(OEPDFHICCKL);
			}
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x9046D80", Offset = "0x9045380", VA = "0x189046D80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x9047D80", Offset = "0x9046380", VA = "0x189047D80", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x9048250", Offset = "0x9046850", VA = "0x189048250")]
		public InputFieldTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public class LabelTheme : GraphicTheme
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		[SerializeField]
		[OOBMCMDIFDG(GJFENOMGFMJ.Self, false, false, false)]
		private TextMeshProUGUI textMeshProUGUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		[SerializeField]
		private HFCFPIDBADG textType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		[SerializeField]
		private OEPDFHICCKL textSize;

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public HFCFPIDBADG PJAEPCMEPOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0xB2DCC0", Offset = "0xB2C2C0", VA = "0x180B2DCC0")]
			get
			{
				return default(HFCFPIDBADG);
			}
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x9048610", Offset = "0x9046C10", VA = "0x189048610")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public OEPDFHICCKL GEJEPPBJNNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x152C9A0", Offset = "0x152AFA0", VA = "0x18152C9A0")]
			get
			{
				return default(OEPDFHICCKL);
			}
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x90485F0", Offset = "0x9046BF0", VA = "0x1890485F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x90482A0", Offset = "0x90468A0", VA = "0x1890482A0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x90485A0", Offset = "0x9046BA0", VA = "0x1890485A0")]
		public LabelTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public class MakerPenToolTheme : ButtonThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		[Header("Maker Pen Tool")]
		[SerializeField]
		private GMFJJGBMOCA makerPenToolPaletteType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		[SerializeField]
		[Tooltip("A list of objects to show while the maker pen tool is active.")]
		private List<Hideable> hideWhenNotActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		[SerializeField]
		[Tooltip("A list of objects to show while the maker pen tool is inactive")]
		private List<Hideable> hideWhenActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		[SerializeField]
		private bool editorIsActiveOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x161")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		protected bool CFADOHPLCGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x162")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private bool MBBGCENLGFP;

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public GMFJJGBMOCA ENGKOACLCAI
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x191C730", Offset = "0x191AD30", VA = "0x18191C730")]
			get
			{
				return default(GMFJJGBMOCA);
			}
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x9045960", Offset = "0x9043F60", VA = "0x189045960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public bool DIBGFNJPLKK
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x9013630", Offset = "0x9011C30", VA = "0x189013630")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x9048AF0", Offset = "0x90470F0", VA = "0x189048AF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x9048AB0", Offset = "0x90470B0", VA = "0x189048AB0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x90486C0", Offset = "0x9046CC0", VA = "0x1890486C0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x9045950", Offset = "0x9043F50", VA = "0x189045950")]
		public MakerPenToolTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public class MixedToggleTheme : ButtonThemeBase
	{
		[Cpp2IlInjected.Token(Token = "0x200005B")]
		public enum OKPCENJAGHJ
		{
			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			Inactive,
			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			Mixed,
			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			Active
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		[SerializeField]
		private CBMOEGOCAFJ toggleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		[SerializeField]
		[Tooltip("A list of objects to hide while the toggle is inactive.")]
		private List<Hideable> hideWhenInactive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		[SerializeField]
		[Tooltip("A list of objects to hide while the toggle is mixed.")]
		private List<Hideable> hideWhenMixed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		[SerializeField]
		[Tooltip("A list of objects to hide while the toggle is active")]
		private List<Hideable> hideWhenActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		[SerializeField]
		private OKPCENJAGHJ editorIsActiveOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private OKPCENJAGHJ MBBGCENLGFP;

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public OKPCENJAGHJ DIBGFNJPLKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x90491B0", Offset = "0x90477B0", VA = "0x1890491B0")]
			get
			{
				return default(OKPCENJAGHJ);
			}
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x9049190", Offset = "0x9047790", VA = "0x189049190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x9049160", Offset = "0x9047760", VA = "0x189049160")]
		public void Toggle()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x9049190", Offset = "0x9047790", VA = "0x189049190")]
		public void Toggle(OKPCENJAGHJ MBBGCENLGFP, bool CFADOHPLCGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x9048BB0", Offset = "0x90471B0", VA = "0x189048BB0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x9045950", Offset = "0x9043F50", VA = "0x189045950")]
		public MixedToggleTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class PaletteTheme : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		[SerializeField]
		private bool usePaletteOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		[SerializeField]
		[IEEHBALBFJL("usePaletteOverride")]
		private Palette paletteOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public HLLOFHFLNHG PaletteChangeEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		[SerializeField]
		private bool useDepth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private FDLKGNCJCMC IPEKJJONPLO;

		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private const string KLEDGLFOKDH = "watch_layer";

		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private const string CIOIHADIJKA = "depth_multiplier";

		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private const float JOPGFKCBOPD = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private float? MFIJMJLGOFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private float? FOOLBACEKBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private float? PPLFALIKHNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private float KFBJHKAKGOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private float LLOOPFJCNCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private float GLMJCJANLPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private float IGMMOCPOIFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private readonly PBCNGJENIAB DMGJBLBIENO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private SFXAudioSource EDFIONKAFBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private SFXAudioSource AALEJKJOAOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private ContentLoadingAudioPaletteAsset MHNCPKKCLCA;

		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private const float BEBOHNOBJJI = 0.001f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		private PGOBNKFHHFC HHKAFOOOPOD;

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public Palette HKGCMIJEILD
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x904B8C0", Offset = "0x9049EC0", VA = "0x18904B8C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public bool DJNKJLKJFDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0xAD4490", Offset = "0xAD2A90", VA = "0x180AD4490")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public float GAAFLAJPPEK
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x904B640", Offset = "0x9049C40", VA = "0x18904B640")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		private bool FAEDJFLNKEC
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x904B070", Offset = "0x9049670", VA = "0x18904B070")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		private bool GDPKEHIKLDG
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x904AFF0", Offset = "0x90495F0", VA = "0x18904AFF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x904A5D0", Offset = "0x9048BD0", VA = "0x18904A5D0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x904B0F0", Offset = "0x90496F0", VA = "0x18904B0F0")]
		private void LEPANHJPJHB(NPAKDJEBJAK.APCFGGODHHC GHOEKMPJFCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x904B160", Offset = "0x9049760", VA = "0x18904B160")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x904A340", Offset = "0x9048940", VA = "0x18904A340")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x904A8F0", Offset = "0x9048EF0", VA = "0x18904A8F0")]
		private void DFHBNAMDNDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x904A4B0", Offset = "0x9048AB0", VA = "0x18904A4B0")]
		public void AddLoadingSFXRequest(object INEEADCBMPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x904B460", Offset = "0x9049A60", VA = "0x18904B460")]
		public void RemoveLoadingSFXRequest(object INEEADCBMPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x904A340", Offset = "0x9048940", VA = "0x18904A340")]
		private void ABHKOAGDOFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x904A150", Offset = "0x9048750", VA = "0x18904A150")]
		private void AAOIBJHKBDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x904A780", Offset = "0x9048D80", VA = "0x18904A780")]
		private void BJGDFHOMGFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x904AE10", Offset = "0x9049410", VA = "0x18904AE10")]
		private void FLDHBHALHPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x904ABA0", Offset = "0x90491A0", VA = "0x18904ABA0")]
		private void EOCKJEANJLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x904AAB0", Offset = "0x90490B0", VA = "0x18904AAB0")]
		private void EFJMIKLEKMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x86296B0", Offset = "0x8627CB0", VA = "0x1886296B0")]
		private void GPPKBBEJHIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x904AF00", Offset = "0x9049500", VA = "0x18904AF00")]
		private void FNDNCJPAJKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x904B120", Offset = "0x9049720", VA = "0x18904B120")]
		private void OECNOCHHNOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x904B290", Offset = "0x9049890", VA = "0x18904B290")]
		public void Play2DUIFlavorSFX(RecRoomAudioClip[] KAJMFNNMBHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x904B580", Offset = "0x9049B80", VA = "0x18904B580")]
		public PaletteTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public abstract class PaletteThemeReference : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		protected static readonly IPHNFELODMJ AMCHCCAPJNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		[SerializeField]
		[DECECLMOCEO(GJFENOMGFMJ.SelfAndParent, true, false, false)]
		private PaletteTheme paletteTheme;

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		protected PaletteTheme CBEMHPNBHCE
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		protected Palette HKGCMIJEILD
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x904A000", Offset = "0x9048600", VA = "0x18904A000")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		protected bool AFODPMJEDHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x9049BA0", Offset = "0x90481A0", VA = "0x189049BA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		protected Transform KPGNOCHFCOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x9049EA0", Offset = "0x90484A0", VA = "0x189049EA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x9049A10", Offset = "0x9048010", VA = "0x189049A10", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x9049F20", Offset = "0x9048520", VA = "0x189049F20", Slot = "5")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void Apply();

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x9049CF0", Offset = "0x90482F0", VA = "0x189049CF0")]
		public Color? GetColorFromPalette(OKGAKFLDHNC FBAOEMKJCPK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x9049C20", Offset = "0x9048220", VA = "0x189049C20")]
		private void EMGOEEMMNLP(bool OBBNBDHDPMB = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0xAA8970", Offset = "0xAA6F70", VA = "0x180AA8970")]
		protected PaletteThemeReference()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public class RangeSliderTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		[SerializeField]
		[OOBMCMDIFDG(GJFENOMGFMJ.Self, false, false, false)]
		private RangeSlider slider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		[SerializeField]
		private NACIKEHBEGN sliderType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		[SerializeField]
		private Image sliderImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		[SerializeField]
		private Image fillImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		[SerializeField]
		private Image lowHandleImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		[SerializeField]
		private Image highHandleImage;

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public NACIKEHBEGN KOIMGBNDMAL
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0xAA70A0", Offset = "0xAA56A0", VA = "0x180AA70A0")]
			get
			{
				return default(NACIKEHBEGN);
			}
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x904CAE0", Offset = "0x904B0E0", VA = "0x18904CAE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public Image IJBCEKPNIPP
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0xAA5720", Offset = "0xAA3D20", VA = "0x180AA5720")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public Image NCJJOIBBJJB
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0xAA54B0", Offset = "0xAA3AB0", VA = "0x180AA54B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public Image DEIHJHMHIMO
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0xAA5620", Offset = "0xAA3C20", VA = "0x180AA5620")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public Image KGKDHMAJDDJ
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0xAA55B0", Offset = "0xAA3BB0", VA = "0x180AA55B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public bool MCJEJOKBJLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x781BB90", Offset = "0x781A190", VA = "0x18781BB90")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x781BBD0", Offset = "0x781A1D0", VA = "0x18781BBD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x904C790", Offset = "0x904AD90", VA = "0x18904C790", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x904CA90", Offset = "0x904B090", VA = "0x18904CA90")]
		public RangeSliderTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class RawImageTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		[SerializeField]
		[OOBMCMDIFDG(GJFENOMGFMJ.Self, false, false, false)]
		private RawImage image;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		[SerializeField]
		private NCCNKGBFPPJ color;

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public NCCNKGBFPPJ BALJJOMIPJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0xAA70A0", Offset = "0xAA56A0", VA = "0x180AA70A0")]
			get
			{
				return default(NCCNKGBFPPJ);
			}
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x904CAE0", Offset = "0x904B0E0", VA = "0x18904CAE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x904CB00", Offset = "0x904B100", VA = "0x18904CB00", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x904CC30", Offset = "0x904B230", VA = "0x18904CC30")]
		public RawImageTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public class RecyclingGridTheme : RecyclingThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		[SerializeField]
		[OOBMCMDIFDG(GJFENOMGFMJ.Self, false, false, false)]
		private KIMEDNKLKCN recyclingGrid;

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x904CC80", Offset = "0x904B280", VA = "0x18904CC80", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x904CEF0", Offset = "0x904B4F0", VA = "0x18904CEF0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x904CE80", Offset = "0x904B480", VA = "0x18904CE80")]
		private void LLJJCIIBECG(float BEPBLNNCEDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x904D0E0", Offset = "0x904B6E0", VA = "0x18904D0E0")]
		public RecyclingGridTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public class RecyclingListTheme : RecyclingThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		[SerializeField]
		[OOBMCMDIFDG(GJFENOMGFMJ.Self, false, false, false)]
		private KIMEDNKLKCN recyclingList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private bool IKALAMHBMKL;

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x904D130", Offset = "0x904B730", VA = "0x18904D130", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x904D3E0", Offset = "0x904B9E0", VA = "0x18904D3E0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x904D370", Offset = "0x904B970", VA = "0x18904D370")]
		private void NGLKDIBAGLL(float BEPBLNNCEDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x904D0E0", Offset = "0x904B6E0", VA = "0x18904D0E0")]
		public RecyclingListTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public abstract class RecyclingThemeBase : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		[Header("Audio")]
		[SerializeField]
		private BLOLIJOECDK recyclingAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		protected RecyclingAudioPaletteAsset ONGEKFJDOMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		[SerializeField]
		private IHKJBEKMNJA scrollingAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private ScrollingAudioPaletteAsset EDEGHDDHNPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private PGOBNKFHHFC OALOHNCNKOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private float MDLIPPKLNMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private float OHKLNAMIEIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private float PBANMHOPABI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private float FPKDPJBEAKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private bool CBFCMAAPBKB;

		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		private const float OANJDMMCHCD = 0.01f;

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		private PGOBNKFHHFC HHKAFOOOPOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x904DAF0", Offset = "0x904C0F0", VA = "0x18904DAF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x904D5E0", Offset = "0x904BBE0", VA = "0x18904D5E0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x904DEF0", Offset = "0x904C4F0", VA = "0x18904DEF0")]
		protected void HDCNLEAACPO(bool JENJBJGELDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x904D7D0", Offset = "0x904BDD0", VA = "0x18904D7D0")]
		protected void DGLPBFHKPNJ(GameObject NANHMPOBBLI, int JCILKEAINEL, bool ALPEAOCMGAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x904D960", Offset = "0x904BF60", VA = "0x18904D960")]
		protected void DHIKLGLIJFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x904DB80", Offset = "0x904C180", VA = "0x18904DB80")]
		protected void FPIGEKLEPNP(float BEPBLNNCEDN, float JIGAKLNGJJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x904E1B0", Offset = "0x904C7B0", VA = "0x18904E1B0")]
		private void KBHKEFPLKID(float HJDFGDFCAPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x904E3A0", Offset = "0x904C9A0", VA = "0x18904E3A0")]
		private void MMDHNMALKOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x904D0E0", Offset = "0x904B6E0", VA = "0x18904D0E0")]
		protected RecyclingThemeBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public class ScrollBarTheme : SelectableThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		[Header("Scroll Bar Audio")]
		[SerializeField]
		private JKADJNOOPBJ buttonAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		[SerializeField]
		[Tooltip("Layer a 2D SFX on top of base button sounds")]
		private bool useFlavorSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		[SerializeField]
		[IEEHBALBFJL("useFlavorSFX")]
		[Tooltip("Flavor SFX is picked randomly from this pool config")]
		private RecRoomAudioClipPoolConfig flavorSFXClipPoolConfig;

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x904E4E0", Offset = "0x904CAE0", VA = "0x18904E4E0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x904E600", Offset = "0x904CC00", VA = "0x18904E600")]
		public ScrollBarTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public class ScrollRectTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private const string BBAMAIHHJDG = "RRUI.PlayHittingEndsSFX";

		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private const int IMLPCKBHLEC = 5;

		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		private const int DGHCOLDFLLI = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		private DateTimeOffset DKMCGCMILLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		private int OJDKOGAKJOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		private bool ENHHCANJHGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		[SerializeField]
		[OOBMCMDIFDG(GJFENOMGFMJ.Self, false, false, false)]
		private ScrollRect scrollRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		[Header("Audio")]
		[SerializeField]
		private IHKJBEKMNJA scrollAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private ScrollingAudioPaletteAsset ONGEKFJDOMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private PGOBNKFHHFC OALOHNCNKOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private JCCGKNMBLGM LOOKANJOADI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private float OHKLNAMIEIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private float PBANMHOPABI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		private float FPKDPJBEAKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private bool CBFCMAAPBKB;

		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		private const float OANJDMMCHCD = 0.01f;

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		private PGOBNKFHHFC HHKAFOOOPOD
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x904E9A0", Offset = "0x904CFA0", VA = "0x18904E9A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		private JCCGKNMBLGM FBFMDHGOFMP
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x904EEB0", Offset = "0x904D4B0", VA = "0x18904EEB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x904E6F0", Offset = "0x904CCF0", VA = "0x18904E6F0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x904FD30", Offset = "0x904E330", VA = "0x18904FD30", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x904E610", Offset = "0x904CC10", VA = "0x18904E610", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x904EA30", Offset = "0x904D030", VA = "0x18904EA30")]
		private void HFNIHHOKHKP(Vector2 APHHGJIDDCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x904EF40", Offset = "0x904D540", VA = "0x18904EF40")]
		private void KBHKEFPLKID(float HJDFGDFCAPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x904F130", Offset = "0x904D730", VA = "0x18904F130")]
		private void MMDHNMALKOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x904E880", Offset = "0x904CE80", VA = "0x18904E880")]
		private static string BBGJCAIEGKC(GameObject MPIDDJPOOMJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x904FE20", Offset = "0x904E420", VA = "0x18904FE20")]
		public ScrollRectTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public abstract class SelectableThemeBase : PaletteThemeReference, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IPointerClickHandler, IPointerEnterHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		[Header("Selectable Theme Base")]
		[SerializeField]
		[OOBMCMDIFDG(GJFENOMGFMJ.Self, false, false, false)]
		[FormerlySerializedAs("button")]
		private Selectable selectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		[Header("Legacy Audio Override")]
		[SerializeField]
		[FormerlySerializedAs("overrideAudio")]
		[Tooltip("Override base selectable audio with a single SFX that plays only on click.")]
		protected bool overrideWithSingleAudio;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		[SerializeField]
		[IEEHBALBFJL("overrideWithSingleAudio")]
		[Tooltip("The legacy override audio will be randomly picked from this pool")]
		protected RecRoomAudioClip[] randomAudioOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		protected bool GKOJNGEGMMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private ButtonAudioPaletteAsset ONGEKFJDOMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private RecRoomAudioClipPoolConfig FMHNPEFGINF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private PBCNGJENIAB MPKEGBOPEDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private PBCNGJENIAB EEKKKDPGNPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private PBCNGJENIAB FHCEALCHLPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		private PBCNGJENIAB NFJCEOOGDHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		private PGOBNKFHHFC OALOHNCNKOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		private PCMBDHINOIM MFNLBHAEMGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		private PNIJNFBJADF EMNFHFLGNAI;

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		protected Selectable HADBHPFEIFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0xAA70C0", Offset = "0xAA56C0", VA = "0x180AA70C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		protected virtual bool ICKINHBLPML
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0xAC1E50", Offset = "0xAC0450", VA = "0x180AC1E50", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public bool MCJEJOKBJLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x781BB90", Offset = "0x781A190", VA = "0x18781BB90")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x781BBD0", Offset = "0x781A1D0", VA = "0x18781BBD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		private PGOBNKFHHFC HHKAFOOOPOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x904FF30", Offset = "0x904E530", VA = "0x18904FF30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		protected PCMBDHINOIM BKCCOACNNEO
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x9050060", Offset = "0x904E660", VA = "0x189050060")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		private PNIJNFBJADF FOMPPIAJIJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x904FFC0", Offset = "0x904E5C0", VA = "0x18904FFC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x9050720", Offset = "0x904ED20", VA = "0x189050720")]
		protected void PCEGJJGLLKP(ButtonAudioPaletteAsset LLPDPBIJPCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xAA57F0", Offset = "0xAA3DF0", VA = "0x180AA57F0")]
		protected void CPGJPDIOMPB(RecRoomAudioClipPoolConfig GJPJDJKHPBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x9050490", Offset = "0x904EA90", VA = "0x189050490", Slot = "12")]
		public virtual void OnPointerDown(PointerEventData CBIMJBOHKKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x9050640", Offset = "0x904EC40", VA = "0x189050640", Slot = "13")]
		public virtual void OnPointerUp(PointerEventData CBIMJBOHKKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x9050130", Offset = "0x904E730", VA = "0x189050130", Slot = "14")]
		public virtual void OnPointerClick(PointerEventData CBIMJBOHKKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x9050570", Offset = "0x904EB70", VA = "0x189050570", Slot = "15")]
		public virtual void OnPointerEnter(PointerEventData CBIMJBOHKKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x904FEB0", Offset = "0x904E4B0", VA = "0x18904FEB0")]
		private void BPEHCIEFBMM(RecRoomAudioClip[] HAFLCMLLHHM, bool LCDOALKCFPA = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x9050820", Offset = "0x904EE20", VA = "0x189050820")]
		private void PJAHNFNBMCG(RecRoomAudioClip AGIOANACMBH, bool LCDOALKCFPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x9050C60", Offset = "0x904F260", VA = "0x189050C60")]
		public void SetOnPointerDownSoundEffectDisabled(object INEEADCBMPK, bool AGJGNCFDJGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x9050CC0", Offset = "0x904F2C0", VA = "0x189050CC0")]
		public void SetOnPointerUpSoundEffectDisabled(object INEEADCBMPK, bool AGJGNCFDJGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x9050C30", Offset = "0x904F230", VA = "0x189050C30")]
		public void SetOnPointerClickSoundEffectDisabled(object INEEADCBMPK, bool AGJGNCFDJGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x9050C90", Offset = "0x904F290", VA = "0x189050C90")]
		public void SetOnPointerEnterSoundEffectDisabled(object INEEADCBMPK, bool AGJGNCFDJGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x90500F0", Offset = "0x904E6F0", VA = "0x1890500F0")]
		private void NKPOJAFFGLJ(PBCNGJENIAB NLFMOKELAPM, object INEEADCBMPK, bool AGJGNCFDJGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x9050CF0", Offset = "0x904F2F0", VA = "0x189050CF0")]
		protected SelectableThemeBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class SliderTheme : SelectableThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		[Header("Slider Visual")]
		[SerializeField]
		[OOBMCMDIFDG(GJFENOMGFMJ.Self, false, false, false)]
		private Slider slider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		[SerializeField]
		private NACIKEHBEGN sliderType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		[Header("Slider Audio")]
		[SerializeField]
		private JKADJNOOPBJ buttonAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		[SerializeField]
		[Tooltip("Layer a 2D SFX on top of base button sounds")]
		private bool useFlavorSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		[SerializeField]
		[IEEHBALBFJL("useFlavorSFX")]
		[Tooltip("Flavor SFX is picked randomly from this pool config")]
		private RecRoomAudioClipPoolConfig flavorSFXClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		[SerializeField]
		private Image sliderImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		[SerializeField]
		private Image fillImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		[SerializeField]
		private Image handleImage;

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public NACIKEHBEGN KOIMGBNDMAL
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0xAB0570", Offset = "0xAAEB70", VA = "0x180AB0570")]
			get
			{
				return default(NACIKEHBEGN);
			}
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x90512F0", Offset = "0x904F8F0", VA = "0x1890512F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public Image IJBCEKPNIPP
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0xAAEE90", Offset = "0xAAD490", VA = "0x180AAEE90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public Image NCJJOIBBJJB
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0xB78BB0", Offset = "0xB771B0", VA = "0x180B78BB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public Image JLMOJKBCGIH
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0xEDC690", Offset = "0xEDAC90", VA = "0x180EDC690")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x9050F20", Offset = "0x904F520", VA = "0x189050F20", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x90512D0", Offset = "0x904F8D0", VA = "0x1890512D0")]
		public SliderTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public class SurfaceTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		[SerializeField]
		[OOBMCMDIFDG(GJFENOMGFMJ.Self, false, false, false)]
		private Image image;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		[SerializeField]
		[DECECLMOCEO(GJFENOMGFMJ.Self, false, false, false)]
		private UIGradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		[SerializeField]
		private GANJAHHDOCB color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		[SerializeField]
		[IEEHBALBFJL("gradient")]
		private bool ignoreGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		[SerializeField]
		[Tooltip("The surface theme determines if this Image is a RaycastTarget or not. There are times when you might want to ignore that setting of the palette theme and just respect whatever is the default state on the Image.")]
		private bool ignoreSettingRaycastTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private GANJAHHDOCB? EOBAEGHKDGK;

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public GANJAHHDOCB BINONEIPEFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x9051620", Offset = "0x904FC20", VA = "0x189051620")]
			get
			{
				return default(GANJAHHDOCB);
			}
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x9051680", Offset = "0x904FC80", VA = "0x189051680")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x9051310", Offset = "0x904F910", VA = "0x189051310", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x90515B0", Offset = "0x904FBB0", VA = "0x1890515B0", Slot = "7")]
		public virtual void OverrideBackgroundColorPaletteAtRuntime(GANJAHHDOCB? KIBBCBBLIGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x90515D0", Offset = "0x904FBD0", VA = "0x1890515D0")]
		public SurfaceTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public class SwitchTheme : ToggleTheme
	{
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private const float IDLCKKJNBAH = 0.33f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		[Header("Switch")]
		[SerializeField]
		private GameObject indicator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		[SerializeField]
		private GameObject indicatorOffPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		[SerializeField]
		private GameObject indicatorOnPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		private ABDCGLIPPBP BPMHODEDNEF;

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x90516A0", Offset = "0x904FCA0", VA = "0x1890516A0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x9051900", Offset = "0x904FF00", VA = "0x189051900")]
		public SwitchTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class TilerTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		[SerializeField]
		[OOBMCMDIFDG(GJFENOMGFMJ.Self, false, false, false)]
		private UITiler tiler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		[SerializeField]
		private JIFOLKDMDFL type;

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x9051EF0", Offset = "0x90504F0", VA = "0x189051EF0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x9052180", Offset = "0x9050780", VA = "0x189052180")]
		public TilerTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public class ToggleTheme : ButtonThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		[Header("Toggle Visual")]
		[SerializeField]
		private JIFLMFDPNKE toggleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		[SerializeField]
		[Tooltip("A list of objects to show while the toggle is active.")]
		private List<Hideable> hideWhenNotActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		[SerializeField]
		[Tooltip("A list of objects to show while the toggle is inactive")]
		private List<Hideable> hideWhenActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		[SerializeField]
		private bool editorIsActiveOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x161")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		[Header("Toggle Audio")]
		[SerializeField]
		[Tooltip("Override the audio palette when active defined by the toggle's visual with a custom palette")]
		private bool overrideAudioPaletteWhenActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		[SerializeField]
		[IEEHBALBFJL("overrideAudioPaletteWhenActive")]
		[Tooltip("Specify a custom config to use for toggle button audio when active")]
		private ButtonAudioPaletteAsset customButtonAudioConfigWhenActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		[SerializeField]
		[Tooltip("Override the audio palette when inactive defined by the toggle's visual with a custom palette")]
		private bool overrideAudioPaletteWhenInactive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		[IEEHBALBFJL("overrideAudioPaletteWhenInactive")]
		[Tooltip("Specify a custom config to use for toggle button audio when inactive")]
		[SerializeField]
		private ButtonAudioPaletteAsset customButtonAudioConfigWhenInactive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		[SerializeField]
		[Tooltip("Layer a 2D SFX on top of base button sounds. Flavor SFX only plays when toggling from inactive to active")]
		private bool useFlavorSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		[SerializeField]
		[IEEHBALBFJL("useFlavorSFX")]
		[Tooltip("Flavor SFX is picked randomly from this pool config")]
		private RecRoomAudioClipPoolConfig flavorSFXClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		protected bool CFADOHPLCGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x191")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		private bool APCIIBCBPBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x192")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private bool MBBGCENLGFP;

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public bool DIBGFNJPLKK
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x9052680", Offset = "0x9050C80", VA = "0x189052680")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x9052690", Offset = "0x9050C90", VA = "0x189052690")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public JIFLMFDPNKE LEEDCMIEBPP
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x191C730", Offset = "0x191AD30", VA = "0x18191C730")]
			get
			{
				return default(JIFLMFDPNKE);
			}
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x9045960", Offset = "0x9043F60", VA = "0x189045960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		protected override bool ICKINHBLPML
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x90525F0", Offset = "0x9050BF0", VA = "0x1890525F0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x90525B0", Offset = "0x9050BB0", VA = "0x1890525B0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x9052640", Offset = "0x9050C40", VA = "0x189052640")]
		public void Toggle()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x9052600", Offset = "0x9050C00", VA = "0x189052600")]
		public void Toggle(bool MBBGCENLGFP, bool CFADOHPLCGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x90521D0", Offset = "0x90507D0", VA = "0x1890521D0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x9051900", Offset = "0x904FF00", VA = "0x189051900")]
		public ToggleTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public class ActiveEventThemeSwapper : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		[SerializeField]
		private string eventActiveGameConfigKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		[SerializeField]
		private bool swapSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		[IEEHBALBFJL("swapSprite")]
		[SerializeField]
		private Image targetImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		[IEEHBALBFJL("swapSprite")]
		[SerializeField]
		private Sprite targetSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		[SerializeField]
		private bool swapSurfaceTheme;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		[IEEHBALBFJL("swapSurfaceTheme")]
		[SerializeField]
		private SurfaceTheme targetSurfaceTheme;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		[IEEHBALBFJL("swapSurfaceTheme")]
		[SerializeField]
		private GANJAHHDOCB targetPalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		[SerializeField]
		private bool changeGradientDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		[IEEHBALBFJL("changeGradientDirection")]
		[SerializeField]
		private UIGradient targetGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		[IEEHBALBFJL("changeGradientDirection")]
		[SerializeField]
		private UIGradient.ANAIDBBDDHI targetGradientType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		private DGLAIFNIHGO CPIDCOEIFNH;

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x9043330", Offset = "0x9041930", VA = "0x189043330")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x9043280", Offset = "0x9041880", VA = "0x189043280")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x9043020", Offset = "0x9041620", VA = "0x189043020")]
		private void GJNGAAFGFLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x9042ED0", Offset = "0x90414D0", VA = "0x189042ED0")]
		private void ENHELHELHBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x9043480", Offset = "0x9041A80", VA = "0x189043480")]
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
