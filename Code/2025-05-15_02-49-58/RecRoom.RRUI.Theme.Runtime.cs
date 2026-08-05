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
		private sealed class NEMNBMIBABI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public TMP_FontAsset font;

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public NEMNBMIBABI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x86BDE20", Offset = "0x86BC420", VA = "0x1886BDE20")]
			internal bool MGDBIONIJGM(LocalizedFontMapping x)
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
		[Cpp2IlInjected.Address(RVA = "0x86BB2C0", Offset = "0x86B98C0", VA = "0x1886BB2C0")]
		public bool DJDHOICBCEK(TMP_FontAsset EJLOHFFOBEK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x86BB6E0", Offset = "0x86B9CE0", VA = "0x1886BB6E0")]
		public TMP_FontAsset IKDBNMKCKAI(TMP_FontAsset EJLOHFFOBEK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x86BB4A0", Offset = "0x86B9AA0", VA = "0x1886BB4A0")]
		public TMP_FontAsset IKDBNMKCKAI(TMP_FontAsset EJLOHFFOBEK, Material DKABCBBKAPN, [Out] Material MNHCGFOPPKL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x86BB840", Offset = "0x86B9E40", VA = "0x1886BB840")]
		public TMP_FontAsset LKHJMPLNAKN(TMP_FontAsset EJLOHFFOBEK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x86BB9A0", Offset = "0x86B9FA0", VA = "0x1886BB9A0")]
		public TMP_FontAsset LKHJMPLNAKN(TMP_FontAsset EJLOHFFOBEK, Material DKABCBBKAPN, [Out] Material PMMFFLGBKHB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x86BB3F0", Offset = "0x86B99F0", VA = "0x1886BB3F0")]
		private static bool GMEKOOAELCK(TMP_FontAsset EJLOHFFOBEK, LocalizedFontMapping JIJJDJPODNM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x86BBBA0", Offset = "0x86BA1A0", VA = "0x1886BBBA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x86C62E0", Offset = "0x86C48E0", VA = "0x1886C62E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x86C6280", Offset = "0x86C4880", VA = "0x1886C6280")]
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
		[Cpp2IlInjected.Address(RVA = "0x86BBC80", Offset = "0x86BA280", VA = "0x1886BBC80", Slot = "0")]
		public override bool Equals(object BOMDCGFKGKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x86BBC20", Offset = "0x86BA220", VA = "0x1886BBC20", Slot = "4")]
		public bool Equals(GradientBlock MIJLJBIHDMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x86BBD60", Offset = "0x86BA360", VA = "0x1886BBD60", Slot = "2")]
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
		public List<Graphic> JNCJFHEJEMC
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xA6A350", Offset = "0xA68950", VA = "0x180A6A350")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA610A0", Offset = "0xA5F6A0", VA = "0x180A610A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public ColorBlock JOKNKCKLDKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x86BDCF0", Offset = "0x86BC2F0", VA = "0x1886BDCF0")]
			get
			{
				return default(ColorBlock);
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x86BDD70", Offset = "0x86BC370", VA = "0x1886BDD70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public UIGradient ONCBGPGLIJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xAC16C0", Offset = "0xABFCC0", VA = "0x180AC16C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xD46B00", Offset = "0xD45100", VA = "0x180D46B00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public GradientBlock OMOLHNGKDPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x86BDD40", Offset = "0x86BC340", VA = "0x1886BDD40")]
			get
			{
				return default(GradientBlock);
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x86BDDC0", Offset = "0x86BC3C0", VA = "0x1886BDDC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x86BDB10", Offset = "0x86BC110", VA = "0x1886BDB10", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x86BDB60", Offset = "0x86BC160", VA = "0x1886BDB60", Slot = "36")]
		public override void OnSelect(BaseEventData NKBJHKLGFDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x86BDBB0", Offset = "0x86BC1B0", VA = "0x1886BDBB0")]
		public void Refresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x86BD9D0", Offset = "0x86BBFD0", VA = "0x1886BD9D0")]
		public void ForceHighlighted(bool NDILPGAIKJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x86BD9F0", Offset = "0x86BBFF0", VA = "0x1886BD9F0")]
		public void ForceNormal(bool NDILPGAIKJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x86BD580", Offset = "0x86BBB80", VA = "0x1886BD580", Slot = "26")]
		protected override void DoStateTransition(SelectionState IDAKFFICKHC, bool NDILPGAIKJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x86BD8E0", Offset = "0x86BBEE0", VA = "0x1886BD8E0")]
		private void FFNCFBNAFOD(Graphic KBLAAHMKMKM, Color CCLBHEJAFJM, bool NDILPGAIKJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x86BDA10", Offset = "0x86BC010", VA = "0x1886BDA10")]
		private void NDKHEHEHGCN(SelectionState IDAKFFICKHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x86BDBE0", Offset = "0x86BC1E0", VA = "0x1886BDBE0")]
		public MultiGraphicButton()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum MLBOCFGLDGJ
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
public enum GOAKMNMCAPC
{
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	Default
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public enum IBGHGNEKOLI
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	Default
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum FBLNIOGCMMG
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
			private MLBOCFGLDGJ buttonAudioPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			[SerializeField]
			private ButtonAudioPaletteAsset buttonAudioPaletteConfig;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public MLBOCFGLDGJ ButtonAudioPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(RVA = "0x9E91A0", Offset = "0x9E77A0", VA = "0x1809E91A0")]
				get
				{
					return default(MLBOCFGLDGJ);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public ButtonAudioPaletteAsset ButtonAudioPaletteConfig
			{
				[Cpp2IlInjected.Token(Token = "0x6000026")]
				[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
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
			private GOAKMNMCAPC scrollingAudioPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			[SerializeField]
			private ScrollingAudioPaletteAsset scrollingAudioPaletteConfig;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public GOAKMNMCAPC ScrollingAudioPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x9E91A0", Offset = "0x9E77A0", VA = "0x1809E91A0")]
				get
				{
					return default(GOAKMNMCAPC);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public ScrollingAudioPaletteAsset ScrollingAudioPaletteConfig
			{
				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
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
			private IBGHGNEKOLI contentLoadingAudioPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			[SerializeField]
			private ContentLoadingAudioPaletteAsset contentLoadingAudioPaletteConfig;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public IBGHGNEKOLI ContentLoadingAudioPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0x9E91A0", Offset = "0x9E77A0", VA = "0x1809E91A0")]
				get
				{
					return default(IBGHGNEKOLI);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public ContentLoadingAudioPaletteAsset ContentLoadingAudioPaletteConfig
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
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
			private FBLNIOGCMMG recyclingAudioPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			[SerializeField]
			private RecyclingAudioPaletteAsset recyclingAudioPaletteConfig;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public FBLNIOGCMMG RecyclingAudioPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x9E91A0", Offset = "0x9E77A0", VA = "0x1809E91A0")]
				get
				{
					return default(FBLNIOGCMMG);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public RecyclingAudioPaletteAsset RecyclingAudioPaletteConfig
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public RecyclingAudioPaletteItem()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class KGGHCPJDEHP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public MLBOCFGLDGJ buttonAudioPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public KGGHCPJDEHP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xDB30D0", Offset = "0xDB16D0", VA = "0x180DB30D0")]
			internal bool CHEOPPLCPBE(ButtonAudioPaletteItem buttonAudioPalette)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class NGONKJOKMDP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public GOAKMNMCAPC scrollingAudioPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public NGONKJOKMDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xDB30D0", Offset = "0xDB16D0", VA = "0x180DB30D0")]
			internal bool HGKOJOADPIN(ScrollingAudioPaletteItem scrollingAudioPalette)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class NNCKHKJIGCM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public IBGHGNEKOLI contentLoadingAudioPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public NNCKHKJIGCM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xDB30D0", Offset = "0xDB16D0", VA = "0x180DB30D0")]
			internal bool MLOEOMDGOLF(ContentLoadingAudioPaletteItem contentLoadingAudioPalette)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class NICELJPNNCG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public FBLNIOGCMMG recyclingAudioPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public NICELJPNNCG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xDB30D0", Offset = "0xDB16D0", VA = "0x180DB30D0")]
			internal bool BCKFOHAJGBD(RecyclingAudioPaletteItem recyclingAudioPalette)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[SerializeField]
		[JMGCOMGMEOM("ButtonAudioPaletteType")]
		private ButtonAudioPaletteItem[] buttonAudioPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[SerializeField]
		[JMGCOMGMEOM("ScrollingAudioPaletteType")]
		private ScrollingAudioPaletteItem[] scrollingAudioPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[SerializeField]
		[JMGCOMGMEOM("ContentLoadingAudioPaletteType")]
		private ContentLoadingAudioPaletteItem[] contentLoadingAudioPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[SerializeField]
		[JMGCOMGMEOM("RecyclingAudioPaletteType")]
		private RecyclingAudioPaletteItem[] recyclingAudioPalettes;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x86B7FD0", Offset = "0x86B65D0", VA = "0x1886B7FD0")]
		public ButtonAudioPaletteAsset BPIHONLPCBI(MLBOCFGLDGJ JHHEMAHDIGP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x86B82A0", Offset = "0x86B68A0", VA = "0x1886B82A0")]
		public ScrollingAudioPaletteAsset OIKFICEFLDP(GOAKMNMCAPC IFKGNHLDJBK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x86B81B0", Offset = "0x86B67B0", VA = "0x1886B81B0")]
		public ContentLoadingAudioPaletteAsset LEPMOOPJLCI(IBGHGNEKOLI MHAFOKDEMHK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x86B80C0", Offset = "0x86B66C0", VA = "0x1886B80C0")]
		public RecyclingAudioPaletteAsset FOPIPMBNLPE(FBLNIOGCMMG JLKNEIOCOLG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xBBABA0", Offset = "0xBB91A0", VA = "0x180BBABA0")]
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
			[Cpp2IlInjected.Address(RVA = "0xEDF1A0", Offset = "0xEDD7A0", VA = "0x180EDF1A0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public float ClickAnimationScale
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xD47950", Offset = "0xD45F50", VA = "0x180D47950")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x86B8420", Offset = "0x86B6A20", VA = "0x1886B8420")]
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
		private MLBOCFGLDGJ audioPalette;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Color BackgroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xF8C400", Offset = "0xF8AA00", VA = "0x180F8C400")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public ColorBlock BackgroundTints
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x86B8540", Offset = "0x86B6B40", VA = "0x1886B8540")]
			get
			{
				return default(ColorBlock);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public GradientBlock BackgroundGradients
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x1264CE0", Offset = "0x12632E0", VA = "0x181264CE0")]
			get
			{
				return default(GradientBlock);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Color ForegroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x10BFC90", Offset = "0x10BE290", VA = "0x1810BFC90")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public ColorBlock ForegroundTints
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x86B8580", Offset = "0x86B6B80", VA = "0x1886B8580")]
			get
			{
				return default(ColorBlock);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool ShowBorder
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xDDFCA0", Offset = "0xDDE2A0", VA = "0x180DDFCA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public TextStylePalette TextPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xA6A350", Offset = "0xA68950", VA = "0x180A6A350")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public MLBOCFGLDGJ AudioPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xABA4E0", Offset = "0xAB8AE0", VA = "0x180ABA4E0")]
			get
			{
				return default(MLBOCFGLDGJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x86B8440", Offset = "0x86B6A40", VA = "0x1886B8440")]
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
			[Cpp2IlInjected.Address(RVA = "0xC19D70", Offset = "0xC18370", VA = "0x180C19D70")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
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
			[Cpp2IlInjected.Address(RVA = "0xF8C400", Offset = "0xF8AA00", VA = "0x180F8C400")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public TextStylePalette TextPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x9EB510", Offset = "0x9E9B10", VA = "0x1809EB510")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x86BAC30", Offset = "0x86B9230", VA = "0x1886BAC30")]
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
			[Cpp2IlInjected.Address(RVA = "0xF8C400", Offset = "0xF8AA00", VA = "0x180F8C400")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Color ForegroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xD316E0", Offset = "0xD2FCE0", VA = "0x180D316E0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Color PlaceholderColor
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0xDCD450", Offset = "0xDCBA50", VA = "0x180DCD450")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public TextStylePalette TextPalette
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x9F0820", Offset = "0x9EEE20", VA = "0x1809F0820")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x86BC220", Offset = "0x86BA820", VA = "0x1886BC220")]
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
			[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public MakerPenToolPalette()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class MixedTogglePalette
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		private enum GFFJOODHMCE
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
		private EPEGEJACOOJ baseTogglePalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[SerializeField]
		private GFFJOODHMCE mixedPaletteType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[SerializeField]
		[CCGNPALHOMH("mixedPaletteType", GFFJOODHMCE.UseCustom)]
		private ButtonPalette mixedButtonPalette;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x86BCF40", Offset = "0x86BB540", VA = "0x1886BCF40")]
		public TogglePalette MDOACAGEFGH(Palette CKNPIBJGCEJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x86BCED0", Offset = "0x86BB4D0", VA = "0x1886BCED0")]
		public ButtonPalette ABGNPGHOJOA(Palette CKNPIBJGCEJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
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
			private KNAMKDAJLMF paletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			[SerializeField]
			private Color color;

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			public KNAMKDAJLMF RawImageColorPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000066")]
				[Cpp2IlInjected.Address(RVA = "0x9E91A0", Offset = "0x9E77A0", VA = "0x1809E91A0")]
				get
				{
					return default(KNAMKDAJLMF);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			public Color Color
			{
				[Cpp2IlInjected.Token(Token = "0x6000067")]
				[Cpp2IlInjected.Address(RVA = "0x18BFF00", Offset = "0x18BE500", VA = "0x1818BFF00")]
				get
				{
					return default(Color);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xA31160", Offset = "0xA2F760", VA = "0x180A31160")]
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
			private CKBFIGKFKNE backgroundColorPaletteType;

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
			public CKBFIGKFKNE BackgroundColorPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000069")]
				[Cpp2IlInjected.Address(RVA = "0x9E91A0", Offset = "0x9E77A0", VA = "0x1809E91A0")]
				get
				{
					return default(CKBFIGKFKNE);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			public Color Color
			{
				[Cpp2IlInjected.Token(Token = "0x600006A")]
				[Cpp2IlInjected.Address(RVA = "0x18BFF00", Offset = "0x18BE500", VA = "0x1818BFF00")]
				get
				{
					return default(Color);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			public Gradient Gradient
			{
				[Cpp2IlInjected.Token(Token = "0x600006B")]
				[Cpp2IlInjected.Address(RVA = "0x9EB550", Offset = "0x9E9B50", VA = "0x1809EB550")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			public bool RaycastTarget
			{
				[Cpp2IlInjected.Token(Token = "0x600006C")]
				[Cpp2IlInjected.Address(RVA = "0xA18200", Offset = "0xA16800", VA = "0x180A18200")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x86B8390", Offset = "0x86B6990", VA = "0x1886B8390")]
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
			private PGFPNHJNMEP foregroundColorPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			[SerializeField]
			private Color color;

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public PGFPNHJNMEP ForegroundColorPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600006E")]
				[Cpp2IlInjected.Address(RVA = "0x9E91A0", Offset = "0x9E77A0", VA = "0x1809E91A0")]
				get
				{
					return default(PGFPNHJNMEP);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			public Color Color
			{
				[Cpp2IlInjected.Token(Token = "0x600006F")]
				[Cpp2IlInjected.Address(RVA = "0x18BFF00", Offset = "0x18BE500", VA = "0x1818BFF00")]
				get
				{
					return default(Color);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x86BBC00", Offset = "0x86BA200", VA = "0x1886BBC00")]
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
			private AAGMGCCOJHP tilerPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			[SerializeField]
			private TilerPalette tilerPalette;

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			public AAGMGCCOJHP TilerPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000071")]
				[Cpp2IlInjected.Address(RVA = "0x9E91A0", Offset = "0x9E77A0", VA = "0x1809E91A0")]
				get
				{
					return default(AAGMGCCOJHP);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			public TilerPalette TilerPalette
			{
				[Cpp2IlInjected.Token(Token = "0x6000072")]
				[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
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
			private ODFBFIADPPO textStylePaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			[SerializeField]
			private TextStylePalette textStylePalette;

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			public ODFBFIADPPO TextStylePaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000074")]
				[Cpp2IlInjected.Address(RVA = "0x9E91A0", Offset = "0x9E77A0", VA = "0x1809E91A0")]
				get
				{
					return default(ODFBFIADPPO);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			public TextStylePalette TextStylePalette
			{
				[Cpp2IlInjected.Token(Token = "0x6000075")]
				[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
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
			private KEBDANGNMFF textSizePaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			[SerializeField]
			private int size;

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			public KEBDANGNMFF TextSizePaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(RVA = "0x9E91A0", Offset = "0x9E77A0", VA = "0x1809E91A0")]
				get
				{
					return default(KEBDANGNMFF);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			public int Size
			{
				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0xB76480", Offset = "0xB74A80", VA = "0x180B76480")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x12DEEB0", Offset = "0x12DD4B0", VA = "0x1812DEEB0")]
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
			private NNOGKIIIHBL buttonPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			[SerializeField]
			private ButtonPalette buttonPalette;

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			public NNOGKIIIHBL ButtonPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x9E91A0", Offset = "0x9E77A0", VA = "0x1809E91A0")]
				get
				{
					return default(NNOGKIIIHBL);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			public ButtonPalette ButtonPalette
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
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
			private EPEGEJACOOJ togglePaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			[SerializeField]
			private TogglePalette togglePalette;

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public EPEGEJACOOJ TogglePaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600007D")]
				[Cpp2IlInjected.Address(RVA = "0x9E91A0", Offset = "0x9E77A0", VA = "0x1809E91A0")]
				get
				{
					return default(EPEGEJACOOJ);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public TogglePalette TogglePalette
			{
				[Cpp2IlInjected.Token(Token = "0x600007E")]
				[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
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
			private HOIDBPCLLPB mixedTogglePaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			[SerializeField]
			private MixedTogglePalette mixedTogglePalette;

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public HOIDBPCLLPB MixedTogglePaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000080")]
				[Cpp2IlInjected.Address(RVA = "0x9E91A0", Offset = "0x9E77A0", VA = "0x1809E91A0")]
				get
				{
					return default(HOIDBPCLLPB);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public MixedTogglePalette MixedTogglePalette
			{
				[Cpp2IlInjected.Token(Token = "0x6000081")]
				[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
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
			private CLKIIOGGPKB makerPenToolPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			[SerializeField]
			private MakerPenToolPalette makerPenToolPalette;

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public CLKIIOGGPKB MakerPenToolPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000083")]
				[Cpp2IlInjected.Address(RVA = "0x9E91A0", Offset = "0x9E77A0", VA = "0x1809E91A0")]
				get
				{
					return default(CLKIIOGGPKB);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public MakerPenToolPalette MakerPenToolPalette
			{
				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
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
			private BJBPNLFLOBM inputFieldPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			[SerializeField]
			private InputFieldPalette inputFieldPalette;

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public BJBPNLFLOBM InputFieldPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000086")]
				[Cpp2IlInjected.Address(RVA = "0x9E91A0", Offset = "0x9E77A0", VA = "0x1809E91A0")]
				get
				{
					return default(BJBPNLFLOBM);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public InputFieldPalette InputFieldPalette
			{
				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
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
			private NGIGGJDDPCL dropdownPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			[SerializeField]
			private DropdownPalette dropdownPalette;

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public NGIGGJDDPCL DropdownPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0x9E91A0", Offset = "0x9E77A0", VA = "0x1809E91A0")]
				get
				{
					return default(NGIGGJDDPCL);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public DropdownPalette DropdownPalette
			{
				[Cpp2IlInjected.Token(Token = "0x600008A")]
				[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
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
			private JPBDFNDIPEJ sliderPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			[SerializeField]
			private SliderPalette sliderPalette;

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public JPBDFNDIPEJ SliderPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600008C")]
				[Cpp2IlInjected.Address(RVA = "0x9E91A0", Offset = "0x9E77A0", VA = "0x1809E91A0")]
				get
				{
					return default(JPBDFNDIPEJ);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public SliderPalette SliderPalette
			{
				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
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
			private MAMKNOCOIJJ depthPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			[SerializeField]
			private DepthPalette depthPalette;

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			public MAMKNOCOIJJ DepthPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0x9E91A0", Offset = "0x9E77A0", VA = "0x1809E91A0")]
				get
				{
					return default(MAMKNOCOIJJ);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public DepthPalette DepthPalette
			{
				[Cpp2IlInjected.Token(Token = "0x6000090")]
				[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public DepthPaletteItem()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private sealed class MIJKJLEGBJH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public KNAMKDAJLMF backgroundColorPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public MIJKJLEGBJH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xDB30D0", Offset = "0xDB16D0", VA = "0x180DB30D0")]
			internal bool JEJJDBFIGNC(RawImageColorPaletteItem pi)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private sealed class OMBLLCMBIJN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public CKBFIGKFKNE backgroundColorPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public OMBLLCMBIJN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xDB30D0", Offset = "0xDB16D0", VA = "0x180DB30D0")]
			internal bool JKDACPHFDKE(BackgroundColorPaletteItem backgroundColorPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class NFFFLFDMKLH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public PGFPNHJNMEP foregroundColorPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public NFFFLFDMKLH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xDB30D0", Offset = "0xDB16D0", VA = "0x180DB30D0")]
			internal bool EMGPCCCPPLM(ForegroundColorPaletteItem colorPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class HNLIEDKDMBB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public AAGMGCCOJHP type;

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public HNLIEDKDMBB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xDB30D0", Offset = "0xDB16D0", VA = "0x180DB30D0")]
			internal bool DGFPDFHMMHN(TilerPaletteItem tilerPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[CompilerGenerated]
		private sealed class NEANHGEPJFB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public ODFBFIADPPO textStylePaletteType;

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public NEANHGEPJFB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0xDB30D0", Offset = "0xDB16D0", VA = "0x180DB30D0")]
			internal bool GKJEPKEHNAM(TextStylePaletteItem textStylePaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		[CompilerGenerated]
		private sealed class BAFPAOLFPJE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public KEBDANGNMFF textSizePaletteType;

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public BAFPAOLFPJE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0xDB30D0", Offset = "0xDB16D0", VA = "0x180DB30D0")]
			internal bool KGGJPLBJMDO(TextSizePaletteItem textSizePaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class NIODHACLPDA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public NNOGKIIIHBL buttonPaletteType;

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public NIODHACLPDA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xDB30D0", Offset = "0xDB16D0", VA = "0x180DB30D0")]
			internal bool FODBDJLOCJI(ButtonPaletteItem buttonPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class PPCDFOOBJKN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public EPEGEJACOOJ togglePaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public PPCDFOOBJKN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xDB30D0", Offset = "0xDB16D0", VA = "0x180DB30D0")]
			internal bool BAKBFNPDCII(TogglePaletteItem togglePaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000035")]
		[CompilerGenerated]
		private sealed class HNABPPECJIH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public HOIDBPCLLPB mixedTogglePaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public HNABPPECJIH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xDB30D0", Offset = "0xDB16D0", VA = "0x180DB30D0")]
			internal bool JHDMIBKJKKG(MixedTogglePaletteItem mixedTogglePaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000036")]
		[CompilerGenerated]
		private sealed class EGAOKHNNJLM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public CLKIIOGGPKB makerPenToolPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public EGAOKHNNJLM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xDB30D0", Offset = "0xDB16D0", VA = "0x180DB30D0")]
			internal bool LBKGCNFAIFI(MakerPenToolPaletteItem makerPenToolPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[CompilerGenerated]
		private sealed class FILKJIIDPIE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public BJBPNLFLOBM inputFieldPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public FILKJIIDPIE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xDB30D0", Offset = "0xDB16D0", VA = "0x180DB30D0")]
			internal bool PHBMDKFNMGK(InputFieldPaletteItem inputFieldPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		[CompilerGenerated]
		private sealed class HFAJMLEGBKE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public NGIGGJDDPCL dropdownPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public HFAJMLEGBKE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xDB30D0", Offset = "0xDB16D0", VA = "0x180DB30D0")]
			internal bool LICJBNAPIAG(DropdownPaletteItem dropdownPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000039")]
		[CompilerGenerated]
		private sealed class CBDCPGKIDJN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public JPBDFNDIPEJ sliderPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public CBDCPGKIDJN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xDB30D0", Offset = "0xDB16D0", VA = "0x180DB30D0")]
			internal bool KIFKCJHLMGC(SliderPaletteItem sliderPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		[CompilerGenerated]
		private sealed class OACLBPIBGBP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public MAMKNOCOIJJ depthPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public OACLBPIBGBP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xDB30D0", Offset = "0xDB16D0", VA = "0x180DB30D0")]
			internal bool FHGGCKMEKBK(DepthPaletteItem depthPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[Header("Visual")]
		[SerializeField]
		[JMGCOMGMEOM("RawImageColorPaletteType")]
		private RawImageColorPaletteItem[] rawImageColorPaletteItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[SerializeField]
		[JMGCOMGMEOM("BackgroundColorPaletteType")]
		private BackgroundColorPaletteItem[] backgroundColorPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[SerializeField]
		[JMGCOMGMEOM("ForegroundColorPaletteType")]
		private ForegroundColorPaletteItem[] foregroundColorPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[SerializeField]
		[JMGCOMGMEOM("TilerPaletteType")]
		private TilerPaletteItem[] tilerPaletteItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[SerializeField]
		[JMGCOMGMEOM("TextStylePaletteType")]
		private TextStylePaletteItem[] textStylePalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[SerializeField]
		[JMGCOMGMEOM("TextSizePaletteType")]
		private TextSizePaletteItem[] textSizePalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[SerializeField]
		[JMGCOMGMEOM("ButtonPaletteType")]
		private ButtonPaletteItem[] buttonPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[SerializeField]
		[JMGCOMGMEOM("TogglePaletteType")]
		private TogglePaletteItem[] togglePalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[SerializeField]
		[JMGCOMGMEOM("MixedTogglePaletteType")]
		private MixedTogglePaletteItem[] mixedTogglePalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[SerializeField]
		[JMGCOMGMEOM("MakerPenToolPaletteType")]
		private MakerPenToolPaletteItem[] makerPenToolPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[SerializeField]
		[JMGCOMGMEOM("InputFieldPaletteType")]
		private InputFieldPaletteItem[] inputFieldPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[SerializeField]
		[JMGCOMGMEOM("DropdownPaletteType")]
		private DropdownPaletteItem[] dropdownPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[SerializeField]
		[JMGCOMGMEOM("SliderPaletteType")]
		private SliderPaletteItem[] sliderPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[SerializeField]
		[JMGCOMGMEOM("DepthPaletteType")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F30F0", Offset = "0x9F16F0", VA = "0x1809F30F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public ButtonAnimationPalette ButtonAnimationPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x9F3100", Offset = "0x9F1700", VA = "0x1809F3100")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public AudioPalette AudioPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xBEE060", Offset = "0xBEC660", VA = "0x180BEE060")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x86C06A0", Offset = "0x86BECA0", VA = "0x1886C06A0")]
		public Color HCJIPJKFKFO(KNAMKDAJLMF JCPPNNMGKIF)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x86C0080", Offset = "0x86BE680", VA = "0x1886C0080")]
		public void DAJBDIBKCEN(CKBFIGKFKNE JCPPNNMGKIF, [Out] Color NGGKCKILBNF, [Out] Gradient DDHLPOHPIAJ, [Out] bool ALEFDLFKGOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x86C09C0", Offset = "0x86BEFC0", VA = "0x1886C09C0")]
		public Color MGPDKNHHBDL(PGFPNHJNMEP FMBJFGFOMNN)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x86BFF90", Offset = "0x86BE590", VA = "0x1886BFF90")]
		public TilerPalette CACDGEMHHPN(AAGMGCCOJHP MLCOGCMJLBB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x86C04C0", Offset = "0x86BEAC0", VA = "0x1886C04C0")]
		public TextStylePalette GGHLNLBPBOM(ODFBFIADPPO PFMPOFFMJOK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x86C0AC0", Offset = "0x86BF0C0", VA = "0x1886C0AC0")]
		public int MMJLKNHBKGJ(KEBDANGNMFF AJGBJLCKOJC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x86C01F0", Offset = "0x86BE7F0", VA = "0x1886C01F0")]
		public ButtonPalette EJAOLJHNPBP(NNOGKIIIHBL CPKLBFKFMMF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x86C02E0", Offset = "0x86BE8E0", VA = "0x1886C02E0")]
		public TogglePalette ENJHKHEGLJF(EPEGEJACOOJ OBFCMHJFHGJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x86C03D0", Offset = "0x86BE9D0", VA = "0x1886C03D0")]
		public MixedTogglePalette FDLGGAPFFKA(HOIDBPCLLPB JEKCKEIHGJK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x86C0BB0", Offset = "0x86BF1B0", VA = "0x1886C0BB0")]
		public MakerPenToolPalette NIBBEJMIMFJ(CLKIIOGGPKB CKLLOKCDHHN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x86C08D0", Offset = "0x86BEED0", VA = "0x1886C08D0")]
		public InputFieldPalette KJEGEGIDLNL(BJBPNLFLOBM OANNGEGHGGB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x86C0CA0", Offset = "0x86BF2A0", VA = "0x1886C0CA0")]
		public DropdownPalette OJJEDFDENBN(NGIGGJDDPCL ABCNKMMJLHF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x86C05B0", Offset = "0x86BEBB0", VA = "0x1886C05B0")]
		public SliderPalette HCHINLDALHI(JPBDFNDIPEJ MEPOHKIGJDI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x86C07A0", Offset = "0x86BEDA0", VA = "0x1886C07A0")]
		public float? IBNDCOOIPEM(MAMKNOCOIJJ FNLOJAHAJBK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xBBABA0", Offset = "0xBB91A0", VA = "0x180BBABA0")]
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
			[Cpp2IlInjected.Address(RVA = "0xF8C400", Offset = "0xF8AA00", VA = "0x180F8C400")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public Color FillColor
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xD316E0", Offset = "0xD2FCE0", VA = "0x180D316E0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public Color HandleColor
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xDCD450", Offset = "0xDCBA50", VA = "0x180DCD450")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public ColorBlock ColorBlock
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x86C53A0", Offset = "0x86C39A0", VA = "0x1886C53A0")]
			get
			{
				return default(ColorBlock);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x86C52E0", Offset = "0x86C38E0", VA = "0x1886C52E0")]
		public SliderPalette()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public class TextStylePalette
	{
		[Cpp2IlInjected.Token(Token = "0x200003D")]
		public enum ONIOLDLAJPF
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
		private ONIOLDLAJPF transformation;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x86C5D80", Offset = "0x86C4380", VA = "0x1886C5D80")]
		public void KNHMHKGCJLL(TextMeshProUGUI FCBNGMCKDFC, bool OIDPBCKLJEA = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
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
		private UITiler.BPBDPLEFMCH animationDirection;

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
			[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public Color TintColor
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xC0A830", Offset = "0xC08E30", VA = "0x180C0A830")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public Color BackgroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x12A0680", Offset = "0x129EC80", VA = "0x1812A0680")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public float Rows
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xC07340", Offset = "0xC05940", VA = "0x180C07340")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public Vector2 Spacing
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xEB1130", Offset = "0xEAF730", VA = "0x180EB1130")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public float Offset
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xCE2E50", Offset = "0xCE1450", VA = "0x180CE2E50")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public Vector2 Velocity
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x86C6360", Offset = "0x86C4960", VA = "0x1886C6360")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public float Angle
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x10BFCF0", Offset = "0x10BE2F0", VA = "0x1810BFCF0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public UITiler.BPBDPLEFMCH AnimationDirection
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x1132560", Offset = "0x1130B60", VA = "0x181132560")]
			get
			{
				return default(UITiler.BPBDPLEFMCH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public float PrimaryAnimationSpeed
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x10BFCE0", Offset = "0x10BE2E0", VA = "0x1810BFCE0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public float AltAnimationSpeed
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x10BFD20", Offset = "0x10BE320", VA = "0x1810BFD20")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x86C6310", Offset = "0x86C4910", VA = "0x1886C6310")]
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
			[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public ButtonPalette ActiveButtonPalette
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public TogglePalette()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public enum CKBFIGKFKNE
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
	MakerAI
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public enum KNAMKDAJLMF
{
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	A
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public enum PGFPNHJNMEP
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
[Cpp2IlInjected.Token(Token = "0x2000043")]
public enum AAGMGCCOJHP
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
[Cpp2IlInjected.Token(Token = "0x2000044")]
public enum ODFBFIADPPO
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
[Cpp2IlInjected.Token(Token = "0x2000045")]
public enum KEBDANGNMFF
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
[Cpp2IlInjected.Token(Token = "0x2000046")]
public enum NNOGKIIIHBL
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
	RevenuePurchaseGreen
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public enum EPEGEJACOOJ
{
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	FlatOrange,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	FlatWhite,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	InputToggle,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	Chips,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	Switch,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	WhitePagingBlob,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	RSVPToggleHeaderSection,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	CardSelectableToggle,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	ChipsDark,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	MainNavToggle,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	ListItem,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	NotiUnread,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	FlatPrimary,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	CharadePen,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	ShareCam,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	CardSelectableToggleWithBacking,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	SecondaryHeaderSectionToggle,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	PrimaryToSecondaryHeader,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	NegativeToSecondaryHeader,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	LimitedEventPrimary,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	LimitedEventSecondary,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	RoomCardWithLimitedEvent,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	MainNavVrDetach,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	HomeMainNav,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	FlatOrangeSecondary,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	ChipsPurple
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public enum HOIDBPCLLPB
{
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	Checkbox
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public enum CLKIIOGGPKB
{
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	Create,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	Select,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	Wire,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	Configure,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	Transform,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	Move,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	Rotate,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	Scale,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	CloneFlip,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	Recolor,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	Freeze,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	MakeInvention,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	Manipulate,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	Delete,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	SelectConnect,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	ResetMakerAI
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public enum BJBPNLFLOBM
{
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	LightFlat,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	DarkFlat,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	Modified
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public enum NGIGGJDDPCL
{
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	LightFlat,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	DarkFlat
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public enum JPBDFNDIPEJ
{
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	MirroUIPopUp
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public enum MAMKNOCOIJJ
{
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	Base,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	Button,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	Navigation,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	Overlay,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	Dialog,
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	Toast
}
namespace RRUI.Theme
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public class ApproximationMaskDepthTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		[SerializeField]
		private RectTransform content;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private Vector3? NMMFOGDCMEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private Vector3? IGNPEGOLJIB;

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x86B7B50", Offset = "0x86B6150", VA = "0x1886B7B50")]
		private void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x86B7C30", Offset = "0x86B6230", VA = "0x1886B7C30", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x9EA210", Offset = "0x9E8810", VA = "0x1809EA210")]
		public ApproximationMaskDepthTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public class ButtonTheme : ButtonThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		[Header("Button Visual")]
		[SerializeField]
		private NNOGKIIIHBL buttonType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14C")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		[Header("Button Audio")]
		[SerializeField]
		[Tooltip("Override the audio palette defined by the button's visual with a custom palette")]
		private bool overrideButtonAudioPalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		[CCGNPALHOMH("overrideButtonAudioPalette")]
		[Tooltip("Specify a custom config to use for button audio")]
		[SerializeField]
		private ButtonAudioPaletteAsset customButtonAudioConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		[SerializeField]
		[Tooltip("Layer a 2D SFX on top of base button sounds")]
		private bool useFlavorSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		[SerializeField]
		[CCGNPALHOMH("useFlavorSFX")]
		[Tooltip("Flavor SFX is picked randomly from this pool config")]
		private RecRoomAudioClipPoolConfig flavorSFXClipPoolConfig;

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public NNOGKIIIHBL DLIDPGEAHBD
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x2292840", Offset = "0x2290E40", VA = "0x182292840")]
			get
			{
				return default(NNOGKIIIHBL);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x86B9F00", Offset = "0x86B8500", VA = "0x1886B9F00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x86B9C90", Offset = "0x86B8290", VA = "0x1886B9C90", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0xAEA560", Offset = "0xAE8B60", VA = "0x180AEA560")]
		public void SetAnimationEnabled(bool BFEIIPBAHBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x86B9EF0", Offset = "0x86B84F0", VA = "0x1886B9EF0")]
		public ButtonTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public abstract class ButtonThemeBase : SelectableThemeBase
	{
		[Cpp2IlInjected.Token(Token = "0x2000052")]
		protected class JKJKJFEFOFJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000171")]
			public ButtonAudioPaletteAsset IOGDMHDHIEJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000172")]
			public RecRoomAudioClipPoolConfig IJNMBCOPKKL;

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public JKJKJFEFOFJ()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		[JFJLIIJLCAB(JINCPHMLLKA.Self, false, false, false)]
		[Header("Button Theme Base")]
		[SerializeField]
		private MultiGraphicButton multiGraphicButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		[SerializeField]
		[JFJLIIJLCAB(JINCPHMLLKA.Self, false, true, false)]
		private Image surface;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		[SerializeField]
		private bool useSurfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		[SerializeField]
		[CCGNPALHOMH("useSurfaceOverride")]
		private Image surfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		[SerializeField]
		private bool controlSurfaceColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		[SerializeField]
		[ReadOnlyField]
		private List<Graphic> graphics;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		[SerializeField]
		private bool useGraphicsOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		[SerializeField]
		[CCGNPALHOMH("useGraphicsOverride")]
		private List<Graphic> graphicsOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		[SerializeField]
		[OHACGJMPKIK("useGraphicsOverride", new object[] { })]
		private bool graphicsIgnoreTextFields;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		[SerializeField]
		private bool controlGraphicColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		[SerializeField]
		[JFJLIIJLCAB(JINCPHMLLKA.Self, false, true, false)]
		private UIGradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		[SerializeField]
		private bool useGradientOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		[SerializeField]
		[CCGNPALHOMH("useGradientOverride")]
		private UIGradient gradientOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		[SerializeField]
		[JFJLIIJLCAB(JINCPHMLLKA.Children, true, true, false)]
		private TextMeshProUGUI textMeshProUGUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		[SerializeField]
		private bool useTextMeshProUGUIOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		[SerializeField]
		[CCGNPALHOMH("useTextMeshProUGUIOverride")]
		private TextMeshProUGUI textMeshProUGUIOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		[SerializeField]
		private KEBDANGNMFF textSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		[SerializeField]
		protected Hideable borderHideable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		[SerializeField]
		protected bool isAnimationEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x111")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		[SerializeField]
		[CCGNPALHOMH("isAnimationEnabled")]
		protected bool overrideAnimationTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		[SerializeField]
		[CCGNPALHOMH("overrideAnimationTarget")]
		protected GameObject animationTargetOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private bool AGDOELGLKIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private Vector3 IFHICEJCDJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private Vector3 GKBADDPNEMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private GEGOIOPKCPF MKPHFOBNBPI;

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public Image BDCLJHLEMBC
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x86B9C30", Offset = "0x86B8230", VA = "0x1886B9C30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public List<Graphic> KPPGOFAALGG
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x86B9C10", Offset = "0x86B8210", VA = "0x1886B9C10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public UIGradient PGGCJHCPPKK
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x86B9BF0", Offset = "0x86B81F0", VA = "0x1886B9BF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public TextMeshProUGUI BKFILOODDBE
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x86B9C50", Offset = "0x86B8250", VA = "0x1886B9C50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public KEBDANGNMFF KPIPCIELBDL
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x15A1420", Offset = "0x159FA20", VA = "0x1815A1420")]
			get
			{
				return default(KEBDANGNMFF);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x86B9C70", Offset = "0x86B8270", VA = "0x1886B9C70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		protected Transform JJFIGLCPFMF
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x86B85F0", Offset = "0x86B6BF0", VA = "0x1886B85F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public Button LMGDPIGMDFA
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x86B9B60", Offset = "0x86B8160", VA = "0x1886B9B60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x86B9160", Offset = "0x86B7760", VA = "0x1886B9160")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x86B90C0", Offset = "0x86B76C0", VA = "0x1886B90C0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x86B98B0", Offset = "0x86B7EB0", VA = "0x1886B98B0")]
		protected void POEGBAAFHPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x86B8640", Offset = "0x86B6C40", VA = "0x1886B8640")]
		protected void ILOKOAEMGHB(ButtonPalette NHAMPKJLCDC, [Optional] JKJKJFEFOFJ IPOCMIJGCNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x86B9200", Offset = "0x86B7800", VA = "0x1886B9200", Slot = "12")]
		public override void OnPointerDown(PointerEventData NKBJHKLGFDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x86B95B0", Offset = "0x86B7BB0", VA = "0x1886B95B0", Slot = "13")]
		public override void OnPointerUp(PointerEventData NKBJHKLGFDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x86B91E0", Offset = "0x86B77E0", VA = "0x1886B91E0", Slot = "14")]
		public override void OnPointerClick(PointerEventData NKBJHKLGFDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x86B90A0", Offset = "0x86B76A0", VA = "0x1886B90A0")]
		private Vector3 LICJAEBNMGA(float HDLKNIPAJGK)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x86B9A70", Offset = "0x86B8070", VA = "0x1886B9A70")]
		protected ButtonThemeBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x86B85D0", Offset = "0x86B6BD0", VA = "0x1886B85D0")]
		[CompilerGenerated]
		private void FKPOPKELFBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x86B85D0", Offset = "0x86B6BD0", VA = "0x1886B85D0")]
		[CompilerGenerated]
		private void EGMIENPGOLD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public class DepthTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		[SerializeField]
		private MAMKNOCOIJJ depth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		[SerializeField]
		private bool animateOnEnable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		[SerializeField]
		[CCGNPALHOMH("animateOnEnable")]
		private float animationTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private Vector3? NMMFOGDCMEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private Vector2 AHEAGDCHFEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private Vector2 FFBELCICCDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private Vector2 JAHMCMCCJKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private Vector2 GCELDJHODFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private Vector2 MOMJPEMJIFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private Vector2 JLLGEPDAHEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private readonly bool? DAPNALLJHNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private IHIKFHAFOAE PPDHFAOGBBH;

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		private RectTransform HNBMDIMNPDG
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x86BA790", Offset = "0x86B8D90", VA = "0x1886BA790")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public MAMKNOCOIJJ GBFNBGAFKCC
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0xBF5280", Offset = "0xBF3880", VA = "0x180BF5280")]
			get
			{
				return default(MAMKNOCOIJJ);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x86BAC10", Offset = "0x86B9210", VA = "0x1886BAC10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		private IHIKFHAFOAE MKMCNFNBFNN
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x86BA8E0", Offset = "0x86B8EE0", VA = "0x1886BA8E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		private bool LANNKGJDCJE
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x86BA7F0", Offset = "0x86B8DF0", VA = "0x1886BA7F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x86BAA20", Offset = "0x86B9020", VA = "0x1886BAA20")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x86BA970", Offset = "0x86B8F70", VA = "0x1886BA970")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x86BA240", Offset = "0x86B8840", VA = "0x1886BA240", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x86B9F20", Offset = "0x86B8520", VA = "0x1886B9F20")]
		private void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x86BA400", Offset = "0x86B8A00", VA = "0x1886BA400")]
		private Vector3 DEKIPFOALNL()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x86BAA90", Offset = "0x86B9090", VA = "0x1886BAA90")]
		public DepthTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public class DropdownTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		[SerializeField]
		[ANKANEOPOFH(JINCPHMLLKA.Self, false, false, false)]
		private Dropdown dropdown;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		[SerializeField]
		[JFJLIIJLCAB(JINCPHMLLKA.Self, false, true, false)]
		private Image surface;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		[SerializeField]
		private bool useSurfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		[SerializeField]
		[CCGNPALHOMH("useSurfaceOverride")]
		private Image surfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		[SerializeField]
		private NGIGGJDDPCL dropdownType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		[SerializeField]
		private KEBDANGNMFF textSize;

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public Image BDCLJHLEMBC
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x86BB270", Offset = "0x86B9870", VA = "0x1886BB270")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public NGIGGJDDPCL AEDOLKMHHMF
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0xBF3530", Offset = "0xBF1B30", VA = "0x180BF3530")]
			get
			{
				return default(NGIGGJDDPCL);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x86BB280", Offset = "0x86B9880", VA = "0x1886BB280")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public KEBDANGNMFF KPIPCIELBDL
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xD31700", Offset = "0xD2FD00", VA = "0x180D31700")]
			get
			{
				return default(KEBDANGNMFF);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x86BB2A0", Offset = "0x86B98A0", VA = "0x1886BB2A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x86BAC50", Offset = "0x86B9250", VA = "0x1886BAC50", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x86BB260", Offset = "0x86B9860", VA = "0x1886BB260")]
		public DropdownTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public class GraphicTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		[SerializeField]
		[ANKANEOPOFH(JINCPHMLLKA.Self, false, false, false)]
		private Graphic graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		[SerializeField]
		private bool useGraphicOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		[SerializeField]
		[CCGNPALHOMH("useGraphicOverride")]
		private Graphic graphicOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		[SerializeField]
		private PGFPNHJNMEP color;

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public Graphic KEKKFCDMPCB
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x86BC1F0", Offset = "0x86BA7F0", VA = "0x1886BC1F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public PGFPNHJNMEP DIGBKMMMAGJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0xA088E0", Offset = "0xA06EE0", VA = "0x180A088E0")]
			get
			{
				return default(PGFPNHJNMEP);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x86BC200", Offset = "0x86BA800", VA = "0x1886BC200")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public bool IPHAENHBHIM
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0xE28200", Offset = "0xE26800", VA = "0x180E28200")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0xE281F0", Offset = "0xE267F0", VA = "0x180E281F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public Color? HCPHMPECABI
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x86BBFD0", Offset = "0x86BA5D0", VA = "0x1886BBFD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x86BBDD0", Offset = "0x86BA3D0", VA = "0x1886BBDD0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x9EA210", Offset = "0x9E8810", VA = "0x1809EA210")]
		public GraphicTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public class InputFieldTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		[SerializeField]
		[ANKANEOPOFH(JINCPHMLLKA.Self, false, false, false)]
		private TMP_InputField inputField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		[SerializeField]
		[JFJLIIJLCAB(JINCPHMLLKA.Self, false, false, false)]
		private Image surface;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		[SerializeField]
		private bool useSurfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		[SerializeField]
		[CCGNPALHOMH("useSurfaceOverride")]
		private Image surfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		[SerializeField]
		private BJBPNLFLOBM inputFieldType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		[SerializeField]
		private KEBDANGNMFF textSize;

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public Image BDCLJHLEMBC
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x86BB270", Offset = "0x86B9870", VA = "0x1886BB270")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public BJBPNLFLOBM HPPAHNGPHAE
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0xBF3530", Offset = "0xBF1B30", VA = "0x180BF3530")]
			get
			{
				return default(BJBPNLFLOBM);
			}
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x86BB280", Offset = "0x86B9880", VA = "0x1886BB280")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public KEBDANGNMFF KPIPCIELBDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0xD31700", Offset = "0xD2FD00", VA = "0x180D31700")]
			get
			{
				return default(KEBDANGNMFF);
			}
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x86BB2A0", Offset = "0x86B98A0", VA = "0x1886BB2A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x86BC250", Offset = "0x86BA850", VA = "0x1886BC250", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x86BB260", Offset = "0x86B9860", VA = "0x1886BB260")]
		public InputFieldTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public class LabelTheme : GraphicTheme
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		[SerializeField]
		[ANKANEOPOFH(JINCPHMLLKA.Self, false, false, false)]
		private TextMeshProUGUI textMeshProUGUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		[SerializeField]
		private ODFBFIADPPO textType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		[SerializeField]
		private KEBDANGNMFF textSize;

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public ODFBFIADPPO EGJKBINJBMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0xE58DB0", Offset = "0xE573B0", VA = "0x180E58DB0")]
			get
			{
				return default(ODFBFIADPPO);
			}
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x86BCA50", Offset = "0x86BB050", VA = "0x1886BCA50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public KEBDANGNMFF KPIPCIELBDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x1372530", Offset = "0x1370B30", VA = "0x181372530")]
			get
			{
				return default(KEBDANGNMFF);
			}
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x86BCA30", Offset = "0x86BB030", VA = "0x1886BCA30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x86BC720", Offset = "0x86BAD20", VA = "0x1886BC720", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x86BCA20", Offset = "0x86BB020", VA = "0x1886BCA20")]
		public LabelTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public class MakerPenToolTheme : ButtonThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		[Header("Maker Pen Tool")]
		[SerializeField]
		private CLKIIOGGPKB makerPenToolPaletteType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		[SerializeField]
		[Tooltip("A list of objects to show while the maker pen tool is active.")]
		private List<Hideable> hideWhenNotActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		[SerializeField]
		[Tooltip("A list of objects to show while the maker pen tool is inactive")]
		private List<Hideable> hideWhenActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		[SerializeField]
		private bool editorIsActiveOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x161")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		protected bool IOBGFKEMFHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x162")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private bool FGDBGBPOEOK;

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public CLKIIOGGPKB PAEBCPIEIGG
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x2292840", Offset = "0x2290E40", VA = "0x182292840")]
			get
			{
				return default(CLKIIOGGPKB);
			}
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x86B9F00", Offset = "0x86B8500", VA = "0x1886B9F00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public bool DJLLMFIFBBP
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x86BCEA0", Offset = "0x86BB4A0", VA = "0x1886BCEA0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x86BCEB0", Offset = "0x86BB4B0", VA = "0x1886BCEB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x86BCE60", Offset = "0x86BB460", VA = "0x1886BCE60", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x86BCA70", Offset = "0x86BB070", VA = "0x1886BCA70", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x86B9EF0", Offset = "0x86B84F0", VA = "0x1886B9EF0")]
		public MakerPenToolTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public class MixedToggleTheme : ButtonThemeBase
	{
		[Cpp2IlInjected.Token(Token = "0x200005A")]
		public enum IHIIKGEOAHN
		{
			[Cpp2IlInjected.Token(Token = "0x40001A0")]
			Inactive,
			[Cpp2IlInjected.Token(Token = "0x40001A1")]
			Mixed,
			[Cpp2IlInjected.Token(Token = "0x40001A2")]
			Active
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		[SerializeField]
		private HOIDBPCLLPB toggleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		[SerializeField]
		[Tooltip("A list of objects to hide while the toggle is inactive.")]
		private List<Hideable> hideWhenInactive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		[SerializeField]
		[Tooltip("A list of objects to hide while the toggle is mixed.")]
		private List<Hideable> hideWhenMixed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		[SerializeField]
		[Tooltip("A list of objects to hide while the toggle is active")]
		private List<Hideable> hideWhenActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		[SerializeField]
		private IHIIKGEOAHN editorIsActiveOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private IHIIKGEOAHN FGDBGBPOEOK;

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public IHIIKGEOAHN DJLLMFIFBBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x86BD570", Offset = "0x86BBB70", VA = "0x1886BD570")]
			get
			{
				return default(IHIIKGEOAHN);
			}
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x86BD550", Offset = "0x86BBB50", VA = "0x1886BD550")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x86BD520", Offset = "0x86BBB20", VA = "0x1886BD520")]
		public void Toggle()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x86BD550", Offset = "0x86BBB50", VA = "0x1886BD550")]
		public void Toggle(IHIIKGEOAHN FGDBGBPOEOK, bool IOBGFKEMFHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x86BCF70", Offset = "0x86BB570", VA = "0x1886BCF70", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x86B9EF0", Offset = "0x86B84F0", VA = "0x1886B9EF0")]
		public MixedToggleTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class PaletteTheme : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		[SerializeField]
		private bool usePaletteOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		[SerializeField]
		[CCGNPALHOMH("usePaletteOverride")]
		private Palette paletteOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public GCADBNOOJOM PaletteChangeEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		[SerializeField]
		private bool useDepth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private LPGGOLFFKPF NNAMEELADIK;

		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private const string IGKEGICLGNG = "watch_layer";

		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private const string ICEMJEBNEPM = "depth_multiplier";

		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private const float NLHEBEDCCJE = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private float? ECDEJIFLOJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private float? PJCMJGEMEFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private float? LMHGBBBKCGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private float GBACOOGHBNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private float MMBHNGMMBIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private float PBFBFBHBLHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private float MIPKMJMPHIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private readonly PHIGNGELHED AMPCCIFGGNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private SFXAudioSource JDBAKFNLFLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private SFXAudioSource JELGMHBBLEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private ContentLoadingAudioPaletteAsset KOJBAFHIFMC;

		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private const float PPOOBCOECEJ = 0.001f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private HILIJPLMOBJ HOHDBFPNFFN;

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public Palette JIHCNBOCAHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x86BFEC0", Offset = "0x86BE4C0", VA = "0x1886BFEC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public bool IJKADPEDECN
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0xA18200", Offset = "0xA16800", VA = "0x180A18200")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public float FDJIOIJDPDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x86BFC40", Offset = "0x86BE240", VA = "0x1886BFC40")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		private bool FDKKLLLPBBJ
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x86BEBD0", Offset = "0x86BD1D0", VA = "0x1886BEBD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		private bool KAGBEMABGCL
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x86BF810", Offset = "0x86BDE10", VA = "0x1886BF810")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x86BE870", Offset = "0x86BCE70", VA = "0x1886BE870")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x86BEC50", Offset = "0x86BD250", VA = "0x1886BEC50")]
		private void CNDCECIEDLK(PBGFDBPONIP.GDGMILLJJCN JKCMCJACHFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x86BF6E0", Offset = "0x86BDCE0", VA = "0x1886BF6E0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x86BF1C0", Offset = "0x86BD7C0", VA = "0x1886BF1C0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x86BF520", Offset = "0x86BDB20", VA = "0x1886BF520")]
		private void NCGNFIHLFJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x86BE750", Offset = "0x86BCD50", VA = "0x1886BE750")]
		public void AddLoadingSFXRequest(object EJJDDFFADPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x86BFA60", Offset = "0x86BE060", VA = "0x1886BFA60")]
		public void RemoveLoadingSFXRequest(object EJJDDFFADPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x86BF1C0", Offset = "0x86BD7C0", VA = "0x1886BF1C0")]
		private void HEMPPMHEGHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x86BF330", Offset = "0x86BD930", VA = "0x1886BF330")]
		private void MLHNANKDMPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x86BEA20", Offset = "0x86BD020", VA = "0x1886BEA20")]
		private void BFFKNEKOFJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x86BEC80", Offset = "0x86BD280", VA = "0x1886BEC80")]
		private void DIJBECMNFIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x86BEE60", Offset = "0x86BD460", VA = "0x1886BEE60")]
		private void FLPPMMGJJGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x86BED70", Offset = "0x86BD370", VA = "0x1886BED70")]
		private void EDAGLKJFKLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x7D4A960", Offset = "0x7D48F60", VA = "0x187D4A960")]
		private void BECHLAABLKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x86BF0D0", Offset = "0x86BD6D0", VA = "0x1886BF0D0")]
		private void GDDJDBNLLJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x86BEB90", Offset = "0x86BD190", VA = "0x1886BEB90")]
		private void BGDFFHPJLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x86BF890", Offset = "0x86BDE90", VA = "0x1886BF890")]
		public void Play2DUIFlavorSFX(RecRoomAudioClip[] DJIGMNAODFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x86BFB80", Offset = "0x86BE180", VA = "0x1886BFB80")]
		public PaletteTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public abstract class PaletteThemeReference : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		[SerializeField]
		[JFJLIIJLCAB(JINCPHMLLKA.SelfAndParent, true, false, false)]
		private PaletteTheme paletteTheme;

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		protected PaletteTheme ILLADGGHPLO
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		protected Palette JIHCNBOCAHL
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x86BE2E0", Offset = "0x86BC8E0", VA = "0x1886BE2E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		protected bool KPOLLCBCCMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x86BE5F0", Offset = "0x86BCBF0", VA = "0x1886BE5F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		protected Transform KAKAPLOAAFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x86BE570", Offset = "0x86BCB70", VA = "0x1886BE570")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x86BDEA0", Offset = "0x86BC4A0", VA = "0x1886BDEA0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x86BE670", Offset = "0x86BCC70", VA = "0x1886BE670", Slot = "5")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void Apply();

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x86BE3C0", Offset = "0x86BC9C0", VA = "0x1886BE3C0")]
		public Color? GetColorFromPalette(PGFPNHJNMEP NNCNPNJFJIF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x86BDFA0", Offset = "0x86BC5A0", VA = "0x1886BDFA0")]
		private void BGBNKCMPMAD(bool KCHFFKHLPCH = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x9EA210", Offset = "0x9E8810", VA = "0x1809EA210")]
		protected PaletteThemeReference()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class RangeSliderTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		[SerializeField]
		[ANKANEOPOFH(JINCPHMLLKA.Self, false, false, false)]
		private RangeSlider slider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		[SerializeField]
		private JPBDFNDIPEJ sliderType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		[SerializeField]
		private Image sliderImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		[SerializeField]
		private Image fillImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		[SerializeField]
		private Image lowHandleImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		[SerializeField]
		private Image highHandleImage;

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public JPBDFNDIPEJ OGDOBELNDHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x9EAC90", Offset = "0x9E9290", VA = "0x1809EAC90")]
			get
			{
				return default(JPBDFNDIPEJ);
			}
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x86C1090", Offset = "0x86BF690", VA = "0x1886C1090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public Image EACMMFMLLFH
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x9EB510", Offset = "0x9E9B10", VA = "0x1809EB510")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public Image DJCOLIPDIEP
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x9EB780", Offset = "0x9E9D80", VA = "0x1809EB780")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public Image CDDLBFPLKJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x9F0820", Offset = "0x9EEE20", VA = "0x1809F0820")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public Image AKGNMKGBLON
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x9EB7A0", Offset = "0x9E9DA0", VA = "0x1809EB7A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public bool ICMHECKGKDC
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x7018E20", Offset = "0x7017420", VA = "0x187018E20")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x70197B0", Offset = "0x7017DB0", VA = "0x1870197B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x86C0D90", Offset = "0x86BF390", VA = "0x1886C0D90", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x9EA210", Offset = "0x9E8810", VA = "0x1809EA210")]
		public RangeSliderTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public class RawImageTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		[SerializeField]
		[ANKANEOPOFH(JINCPHMLLKA.Self, false, false, false)]
		private RawImage image;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		[SerializeField]
		private KNAMKDAJLMF color;

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public KNAMKDAJLMF LHGACPAOFCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x9EAC90", Offset = "0x9E9290", VA = "0x1809EAC90")]
			get
			{
				return default(KNAMKDAJLMF);
			}
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x86C1090", Offset = "0x86BF690", VA = "0x1886C1090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x86C10B0", Offset = "0x86BF6B0", VA = "0x1886C10B0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x9EA210", Offset = "0x9E8810", VA = "0x1809EA210")]
		public RawImageTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class RecyclingGridTheme : RecyclingThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		[SerializeField]
		[ANKANEOPOFH(JINCPHMLLKA.Self, false, false, false)]
		private FMPCFIDLNLN recyclingGrid;

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x86C11E0", Offset = "0x86BF7E0", VA = "0x1886C11E0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x86C1450", Offset = "0x86BFA50", VA = "0x1886C1450", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x86C13E0", Offset = "0x86BF9E0", VA = "0x1886C13E0")]
		private void GMPFOJGCACL(float DJFKHPCOCCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x86C1640", Offset = "0x86BFC40", VA = "0x1886C1640")]
		public RecyclingGridTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public class RecyclingListTheme : RecyclingThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		[SerializeField]
		[ANKANEOPOFH(JINCPHMLLKA.Self, false, false, false)]
		private FMPCFIDLNLN recyclingList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private bool CDEKPDKIEGB;

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x86C1650", Offset = "0x86BFC50", VA = "0x1886C1650", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x86C1900", Offset = "0x86BFF00", VA = "0x1886C1900", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x86C1890", Offset = "0x86BFE90", VA = "0x1886C1890")]
		private void BPNHPKMIHJO(float DJFKHPCOCCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x86C1640", Offset = "0x86BFC40", VA = "0x1886C1640")]
		public RecyclingListTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public abstract class RecyclingThemeBase : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		[Header("Audio")]
		[SerializeField]
		private FBLNIOGCMMG recyclingAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		protected RecyclingAudioPaletteAsset BIGLLMGHJNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		[SerializeField]
		private GOAKMNMCAPC scrollingAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		private ScrollingAudioPaletteAsset BDHADIJKMGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private HILIJPLMOBJ OPGHLJAHFAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		private float KMMNKBCFMNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private float MIDIJGLCOAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		private float EOBJBILDNAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private float AECNCEKJIEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private bool HPCKCAKICLP;

		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private const float KLCBBADFFMJ = 0.01f;

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		private HILIJPLMOBJ HOHDBFPNFFN
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x86C2380", Offset = "0x86C0980", VA = "0x1886C2380")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x86C1B00", Offset = "0x86C0100", VA = "0x1886C1B00", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x86C2410", Offset = "0x86C0A10", VA = "0x1886C2410")]
		protected void KAPGDOBMDHP(bool PHBMKEMLOKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x86C21F0", Offset = "0x86C07F0", VA = "0x1886C21F0")]
		protected void IIKLFMGJAPP(GameObject HOJKNIMMINF, int LHBAHENKPEK, bool OOHCBKILAAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x86C2060", Offset = "0x86C0660", VA = "0x1886C2060")]
		protected void ECBPPALPHEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x86C1CF0", Offset = "0x86C02F0", VA = "0x1886C1CF0")]
		protected void DPEBPBKFKCF(float DJFKHPCOCCB, float CNNCBHKHCFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x86C2810", Offset = "0x86C0E10", VA = "0x1886C2810")]
		private void PHEGMCHIKIA(float IBCIPIBNBIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x86C26D0", Offset = "0x86C0CD0", VA = "0x1886C26D0")]
		private void OIKHGPEGAKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x86C1640", Offset = "0x86BFC40", VA = "0x1886C1640")]
		protected RecyclingThemeBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public class ScrollBarTheme : SelectableThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		[Header("Scroll Bar Audio")]
		[SerializeField]
		private MLBOCFGLDGJ buttonAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		[SerializeField]
		[Tooltip("Layer a 2D SFX on top of base button sounds")]
		private bool useFlavorSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		[SerializeField]
		[CCGNPALHOMH("useFlavorSFX")]
		[Tooltip("Flavor SFX is picked randomly from this pool config")]
		private RecRoomAudioClipPoolConfig flavorSFXClipPoolConfig;

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x86C2A00", Offset = "0x86C1000", VA = "0x1886C2A00", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x86C2B20", Offset = "0x86C1120", VA = "0x1886C2B20")]
		public ScrollBarTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public class ScrollRectTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private const string EOCGMLGEJCE = "RRUI.PlayHittingEndsSFX";

		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		private const int PPMLELAOCEE = 5;

		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private const int HBFEKEPAMDP = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private DateTimeOffset HICIAIBBHMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private int BFCMCGPJCLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private bool FMDADEFKECD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		[SerializeField]
		[ANKANEOPOFH(JINCPHMLLKA.Self, false, false, false)]
		private ScrollRect scrollRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		[Header("Audio")]
		[SerializeField]
		private GOAKMNMCAPC scrollAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		private ScrollingAudioPaletteAsset BIGLLMGHJNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		private HILIJPLMOBJ OPGHLJAHFAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		private EDGGJKNOCEO KHMMKLLMABD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		private float MIDIJGLCOAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		private float EOBJBILDNAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private float AECNCEKJIEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private bool HPCKCAKICLP;

		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private const float KLCBBADFFMJ = 0.01f;

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		private HILIJPLMOBJ HOHDBFPNFFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x86C33D0", Offset = "0x86C19D0", VA = "0x1886C33D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		private EDGGJKNOCEO DHNGNBLIOEP
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x86C3220", Offset = "0x86C1820", VA = "0x1886C3220")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x86C2C10", Offset = "0x86C1210", VA = "0x1886C2C10", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x86C4050", Offset = "0x86C2650", VA = "0x1886C4050", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x86C2B30", Offset = "0x86C1130", VA = "0x1886C2B30", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x86C2DA0", Offset = "0x86C13A0", VA = "0x1886C2DA0")]
		private void ECIJGJDKBGP(Vector2 EPCLGOKLIPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x86C4140", Offset = "0x86C2740", VA = "0x1886C4140")]
		private void PHEGMCHIKIA(float IBCIPIBNBIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x86C3460", Offset = "0x86C1A60", VA = "0x1886C3460")]
		private void OIKHGPEGAKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x86C32B0", Offset = "0x86C18B0", VA = "0x1886C32B0")]
		private static string JINCHOPFHDL(GameObject BOMDCGFKGKF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x86C4330", Offset = "0x86C2930", VA = "0x1886C4330")]
		public ScrollRectTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public abstract class SelectableThemeBase : PaletteThemeReference, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IPointerClickHandler, IPointerEnterHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		[Header("Selectable Theme Base")]
		[SerializeField]
		[ANKANEOPOFH(JINCPHMLLKA.Self, false, false, false)]
		[FormerlySerializedAs("button")]
		private Selectable selectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		[Header("Legacy Audio Override")]
		[SerializeField]
		[FormerlySerializedAs("overrideAudio")]
		[Tooltip("Override base selectable audio with a single SFX that plays only on click.")]
		protected bool overrideWithSingleAudio;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		[SerializeField]
		[CCGNPALHOMH("overrideWithSingleAudio")]
		[Tooltip("The legacy override audio will be randomly picked from this pool")]
		protected RecRoomAudioClip[] randomAudioOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		protected bool JMLHJOGBMBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		private ButtonAudioPaletteAsset BIGLLMGHJNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		private RecRoomAudioClipPoolConfig IADCPPGDLPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private PHIGNGELHED LCMAEFOILHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private PHIGNGELHED EOAMLOEHGIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private PHIGNGELHED BPCCPJMNKOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private PHIGNGELHED AEBKJNNIJJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private HILIJPLMOBJ OPGHLJAHFAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private GCMHMMLIBDC BOGHCBGJHGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private DNCKMDLLCNF LOEGOBNPPLN;

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		protected Selectable PDPKNIAFFPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		protected virtual bool AJOODEMOOGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0xA05830", Offset = "0xA03E30", VA = "0x180A05830", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public bool ICMHECKGKDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x7018E20", Offset = "0x7017420", VA = "0x187018E20")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x70197B0", Offset = "0x7017DB0", VA = "0x1870197B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		private HILIJPLMOBJ HOHDBFPNFFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x86C49C0", Offset = "0x86C2FC0", VA = "0x1886C49C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		protected GCMHMMLIBDC CDADMCCBDCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x86C4A50", Offset = "0x86C3050", VA = "0x1886C4A50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		private DNCKMDLLCNF IGHFAEFBLJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x86C4420", Offset = "0x86C2A20", VA = "0x1886C4420")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x86C44C0", Offset = "0x86C2AC0", VA = "0x1886C44C0")]
		protected void CGKBHBMHNAL(ButtonAudioPaletteAsset FNAEHFKGKIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x9EB500", Offset = "0x9E9B00", VA = "0x1809EB500")]
		protected void BICDJKEEIEO(RecRoomAudioClipPoolConfig GPBPJIPFOAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x86C4E80", Offset = "0x86C3480", VA = "0x1886C4E80", Slot = "12")]
		public virtual void OnPointerDown(PointerEventData NKBJHKLGFDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x86C5030", Offset = "0x86C3630", VA = "0x1886C5030", Slot = "13")]
		public virtual void OnPointerUp(PointerEventData NKBJHKLGFDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B20", Offset = "0x86C3120", VA = "0x1886C4B20", Slot = "14")]
		public virtual void OnPointerClick(PointerEventData NKBJHKLGFDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x86C4F60", Offset = "0x86C3560", VA = "0x1886C4F60", Slot = "15")]
		public virtual void OnPointerEnter(PointerEventData NKBJHKLGFDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x86C43A0", Offset = "0x86C29A0", VA = "0x1886C43A0")]
		private void AOIFOMNNDCM(RecRoomAudioClip[] BNJICOICFNL, bool DNHIMNMIPJA = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x86C45C0", Offset = "0x86C2BC0", VA = "0x1886C45C0")]
		private void EJMIGFEFOON(RecRoomAudioClip EKDHDCFOPOG, bool DNHIMNMIPJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x86C5140", Offset = "0x86C3740", VA = "0x1886C5140")]
		public void SetOnPointerDownSoundEffectDisabled(object EJJDDFFADPC, bool LEFCPPNMNLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x86C51A0", Offset = "0x86C37A0", VA = "0x1886C51A0")]
		public void SetOnPointerUpSoundEffectDisabled(object EJJDDFFADPC, bool LEFCPPNMNLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x86C5110", Offset = "0x86C3710", VA = "0x1886C5110")]
		public void SetOnPointerClickSoundEffectDisabled(object EJJDDFFADPC, bool LEFCPPNMNLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x86C5170", Offset = "0x86C3770", VA = "0x1886C5170")]
		public void SetOnPointerEnterSoundEffectDisabled(object EJJDDFFADPC, bool LEFCPPNMNLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x86C4AE0", Offset = "0x86C30E0", VA = "0x1886C4AE0")]
		private void OBJKHBMKDAE(PHIGNGELHED CPNOKLLGBPJ, object EJJDDFFADPC, bool LEFCPPNMNLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x86C51D0", Offset = "0x86C37D0", VA = "0x1886C51D0")]
		protected SelectableThemeBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class SliderTheme : SelectableThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		[Header("Slider Visual")]
		[SerializeField]
		[ANKANEOPOFH(JINCPHMLLKA.Self, false, false, false)]
		private Slider slider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		[SerializeField]
		private JPBDFNDIPEJ sliderType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		[Header("Slider Audio")]
		[SerializeField]
		private MLBOCFGLDGJ buttonAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		[SerializeField]
		[Tooltip("Layer a 2D SFX on top of base button sounds")]
		private bool useFlavorSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		[SerializeField]
		[CCGNPALHOMH("useFlavorSFX")]
		[Tooltip("Flavor SFX is picked randomly from this pool config")]
		private RecRoomAudioClipPoolConfig flavorSFXClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		[SerializeField]
		private Image sliderImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		[SerializeField]
		private Image fillImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		[SerializeField]
		private Image handleImage;

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public JPBDFNDIPEJ OGDOBELNDHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x9F3110", Offset = "0x9F1710", VA = "0x1809F3110")]
			get
			{
				return default(JPBDFNDIPEJ);
			}
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x86C57B0", Offset = "0x86C3DB0", VA = "0x1886C57B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public Image EACMMFMLLFH
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x9F64A0", Offset = "0x9F4AA0", VA = "0x1809F64A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public Image DJCOLIPDIEP
		{
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0xD65080", Offset = "0xD63680", VA = "0x180D65080")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public Image AEOOFIAMMCP
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0xD49D80", Offset = "0xD48380", VA = "0x180D49D80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x86C53E0", Offset = "0x86C39E0", VA = "0x1886C53E0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x86C5790", Offset = "0x86C3D90", VA = "0x1886C5790")]
		public SliderTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class SurfaceTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		[SerializeField]
		[ANKANEOPOFH(JINCPHMLLKA.Self, false, false, false)]
		private Image image;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		[SerializeField]
		[JFJLIIJLCAB(JINCPHMLLKA.Self, false, false, false)]
		private UIGradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		[SerializeField]
		private CKBFIGKFKNE color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		[SerializeField]
		[CCGNPALHOMH("gradient")]
		private bool ignoreGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		[SerializeField]
		[Tooltip("The surface theme determines if this Image is a RaycastTarget or not. There are times when you might want to ignore that setting of the palette theme and just respect whatever is the default state on the Image.")]
		private bool ignoreSettingRaycastTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		private CKBFIGKFKNE? KNGAECFFJMO;

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public CKBFIGKFKNE CGDNCAPHMIA
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x86C5A90", Offset = "0x86C4090", VA = "0x1886C5A90")]
			get
			{
				return default(CKBFIGKFKNE);
			}
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x86C5AF0", Offset = "0x86C40F0", VA = "0x1886C5AF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x86C57D0", Offset = "0x86C3DD0", VA = "0x1886C57D0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x86C5A70", Offset = "0x86C4070", VA = "0x1886C5A70", Slot = "7")]
		public virtual void OverrideBackgroundColorPaletteAtRuntime(CKBFIGKFKNE? CKONKMNPFHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x9EA210", Offset = "0x9E8810", VA = "0x1809EA210")]
		public SurfaceTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public class SwitchTheme : ToggleTheme
	{
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		private const float LFHFDLOLPOO = 0.33f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		[Header("Switch")]
		[SerializeField]
		private GameObject indicator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		[SerializeField]
		private GameObject indicatorOffPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		[SerializeField]
		private GameObject indicatorOnPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private GEGOIOPKCPF MKPHFOBNBPI;

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x86C5B10", Offset = "0x86C4110", VA = "0x1886C5B10", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x86C5D70", Offset = "0x86C4370", VA = "0x1886C5D70")]
		public SwitchTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public class TilerTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		[SerializeField]
		[ANKANEOPOFH(JINCPHMLLKA.Self, false, false, false)]
		private UITiler tiler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		[SerializeField]
		private AAGMGCCOJHP type;

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x86C6380", Offset = "0x86C4980", VA = "0x1886C6380", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x9EA210", Offset = "0x9E8810", VA = "0x1809EA210")]
		public TilerTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class ToggleTheme : ButtonThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		[Header("Toggle Visual")]
		[SerializeField]
		private EPEGEJACOOJ toggleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		[SerializeField]
		[Tooltip("A list of objects to show while the toggle is active.")]
		private List<Hideable> hideWhenNotActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		[SerializeField]
		[Tooltip("A list of objects to show while the toggle is inactive")]
		private List<Hideable> hideWhenActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		[SerializeField]
		private bool editorIsActiveOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x161")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		[Header("Toggle Audio")]
		[SerializeField]
		[Tooltip("Override the audio palette when active defined by the toggle's visual with a custom palette")]
		private bool overrideAudioPaletteWhenActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		[SerializeField]
		[CCGNPALHOMH("overrideAudioPaletteWhenActive")]
		[Tooltip("Specify a custom config to use for toggle button audio when active")]
		private ButtonAudioPaletteAsset customButtonAudioConfigWhenActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		[SerializeField]
		[Tooltip("Override the audio palette when inactive defined by the toggle's visual with a custom palette")]
		private bool overrideAudioPaletteWhenInactive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		[CCGNPALHOMH("overrideAudioPaletteWhenInactive")]
		[Tooltip("Specify a custom config to use for toggle button audio when inactive")]
		[SerializeField]
		private ButtonAudioPaletteAsset customButtonAudioConfigWhenInactive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		[SerializeField]
		[Tooltip("Layer a 2D SFX on top of base button sounds. Flavor SFX only plays when toggling from inactive to active")]
		private bool useFlavorSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		[SerializeField]
		[CCGNPALHOMH("useFlavorSFX")]
		[Tooltip("Flavor SFX is picked randomly from this pool config")]
		private RecRoomAudioClipPoolConfig flavorSFXClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		protected bool IOBGFKEMFHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x191")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private bool MELMFJPMNJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x192")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		private bool FGDBGBPOEOK;

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public bool DJLLMFIFBBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x14D2160", Offset = "0x14D0760", VA = "0x1814D2160")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x86C6AC0", Offset = "0x86C50C0", VA = "0x1886C6AC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public EPEGEJACOOJ LJMLCDFKKJG
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x2292840", Offset = "0x2290E40", VA = "0x182292840")]
			get
			{
				return default(EPEGEJACOOJ);
			}
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x86B9F00", Offset = "0x86B8500", VA = "0x1886B9F00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		protected override bool AJOODEMOOGE
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x86C6A30", Offset = "0x86C5030", VA = "0x1886C6A30", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x86C69F0", Offset = "0x86C4FF0", VA = "0x1886C69F0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x86C6A80", Offset = "0x86C5080", VA = "0x1886C6A80")]
		public void Toggle()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x86C6A40", Offset = "0x86C5040", VA = "0x1886C6A40")]
		public void Toggle(bool FGDBGBPOEOK, bool IOBGFKEMFHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x86C6610", Offset = "0x86C4C10", VA = "0x1886C6610", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x86C5D70", Offset = "0x86C4370", VA = "0x1886C5D70")]
		public ToggleTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public class ActiveEventThemeSwapper : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		[SerializeField]
		private string eventActiveGameConfigKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		[SerializeField]
		private bool swapSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		[CCGNPALHOMH("swapSprite")]
		[SerializeField]
		private Image targetImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		[CCGNPALHOMH("swapSprite")]
		[SerializeField]
		private Sprite targetSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		[SerializeField]
		private bool swapSurfaceTheme;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		[CCGNPALHOMH("swapSurfaceTheme")]
		[SerializeField]
		private SurfaceTheme targetSurfaceTheme;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		[CCGNPALHOMH("swapSurfaceTheme")]
		[SerializeField]
		private CKBFIGKFKNE targetPalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		[SerializeField]
		private bool changeGradientDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		[CCGNPALHOMH("changeGradientDirection")]
		[SerializeField]
		private UIGradient targetGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		[CCGNPALHOMH("changeGradientDirection")]
		[SerializeField]
		private UIGradient.DEPAJGOIBMI targetGradientType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		private JAHOCBPGMLL LCLPLENGOMN;

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x86B79A0", Offset = "0x86B5FA0", VA = "0x1886B79A0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x86B78F0", Offset = "0x86B5EF0", VA = "0x1886B78F0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x86B76A0", Offset = "0x86B5CA0", VA = "0x1886B76A0")]
		private void FCNECEHJIGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x86B7550", Offset = "0x86B5B50", VA = "0x1886B7550")]
		private void AJMCOBBMLJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x86B7AF0", Offset = "0x86B60F0", VA = "0x1886B7AF0")]
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
