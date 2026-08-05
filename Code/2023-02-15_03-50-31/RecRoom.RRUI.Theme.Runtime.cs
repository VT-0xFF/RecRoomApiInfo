using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mono.Math;
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
	[CreateAssetMenu]
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
		private sealed class APHHMCBCHPC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public TMP_FontAsset font;

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
			public APHHMCBCHPC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x49BB170", Offset = "0x49BA570", VA = "0x1849BB170")]
			internal bool <IsLocalizedFontAsset>b__0(LocalizedFontMapping x)
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
			[Cpp2IlInjected.Address(RVA = "0x49BFA60", Offset = "0x49BEE60", VA = "0x1849BFA60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public TMP_SpriteAsset EmojiAsset
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x6E4130", Offset = "0x6E3530", VA = "0x1806E4130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x49BF920", Offset = "0x49BED20", VA = "0x1849BF920")]
		public bool KEPLBNDELCI(TMP_FontAsset DDPAOGEHJLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x49BF610", Offset = "0x49BEA10", VA = "0x1849BF610")]
		public TMP_FontAsset IDBFNIGCBJB(TMP_FontAsset DDPAOGEHJLO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x49BF720", Offset = "0x49BEB20", VA = "0x1849BF720")]
		public TMP_FontAsset IDBFNIGCBJB(TMP_FontAsset DDPAOGEHJLO, Material OJPEBHOJHBL, out Material PDGLCJOOGPJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x49BF200", Offset = "0x49BE600", VA = "0x1849BF200")]
		public TMP_FontAsset ECOIAOJJKCG(TMP_FontAsset DDPAOGEHJLO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x49BF310", Offset = "0x49BE710", VA = "0x1849BF310")]
		public TMP_FontAsset ECOIAOJJKCG(TMP_FontAsset DDPAOGEHJLO, Material OJPEBHOJHBL, out Material HHNLBLOHGBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x49BF550", Offset = "0x49BE950", VA = "0x1849BF550")]
		private static bool GNNMEODNJKO(TMP_FontAsset DDPAOGEHJLO, LocalizedFontMapping JAEMFJIDANN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7681E0", Offset = "0x7675E0", VA = "0x1807681E0")]
		public FontsConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CreateAssetMenu]
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
			[Cpp2IlInjected.Address(RVA = "0x49C9E50", Offset = "0x49C9250", VA = "0x1849C9E50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Palette Active
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x49C9DE0", Offset = "0x49C91E0", VA = "0x1849C9DE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7681E0", Offset = "0x7675E0", VA = "0x1807681E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x49BFC50", Offset = "0x49BF050", VA = "0x1849BFC50", Slot = "0")]
		public override bool Equals(object ADHHHFDPAPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x49BFD50", Offset = "0x49BF150", VA = "0x1849BFD50", Slot = "4")]
		public bool Equals(GradientBlock IHIJPIJNLJM)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x49BFDD0", Offset = "0x49BF1D0", VA = "0x1849BFDD0")]
		public static bool GJOJIEKGOHO(GradientBlock BFOODAMJCHJ, GradientBlock FJBMDODGDGI)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x49BFBD0", Offset = "0x49BEFD0", VA = "0x1849BFBD0")]
		public static bool ALCENKEOHOJ(GradientBlock BFOODAMJCHJ, GradientBlock FJBMDODGDGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x49BFE50", Offset = "0x49BF250", VA = "0x1849BFE50", Slot = "2")]
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
		public List<Graphic> EKDKNPDGDGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x72B1D0", Offset = "0x72A5D0", VA = "0x18072B1D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x72B1F0", Offset = "0x72A5F0", VA = "0x18072B1F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public ColorBlock EFDKJONLPHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x49C1FF0", Offset = "0x49C13F0", VA = "0x1849C1FF0")]
			get
			{
				return default(ColorBlock);
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x49C2070", Offset = "0x49C1470", VA = "0x1849C2070")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public UIGradient GBDCNFLPHKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6E52C0", Offset = "0x6E46C0", VA = "0x1806E52C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6E5580", Offset = "0x6E4980", VA = "0x1806E5580")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public GradientBlock CGKPMJGLGEN
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x49C2040", Offset = "0x49C1440", VA = "0x1849C2040")]
			get
			{
				return default(GradientBlock);
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x49C20C0", Offset = "0x49C14C0", VA = "0x1849C20C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x49C1E40", Offset = "0x49C1240", VA = "0x1849C1E40", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x49C1E90", Offset = "0x49C1290", VA = "0x1849C1E90", Slot = "36")]
		public override void OnSelect(BaseEventData FFEKEOCBAFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x49C1EE0", Offset = "0x49C12E0", VA = "0x1849C1EE0")]
		public void Refresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x49C1A10", Offset = "0x49C0E10", VA = "0x1849C1A10", Slot = "26")]
		protected override void DoStateTransition(SelectionState BGHMFEPCABE, bool IGJHENNBFJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x49C1D70", Offset = "0x49C1170", VA = "0x1849C1D70")]
		private void NJBNKBMLJJL(Graphic BNMLCDKFKFC, Color JOJKIHOOPMC, bool IGJHENNBFJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x49C1C70", Offset = "0x49C1070", VA = "0x1849C1C70")]
		private void MKMEENFPOAE(SelectionState BGHMFEPCABE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x49C1F10", Offset = "0x49C1310", VA = "0x1849C1F10")]
		public MultiGraphicButton()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum NBMDFDBNDCB
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
public enum DKKBMGGHBAD
{
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Default
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public enum GPPHNKEMCID
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	Default
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum FLAOGLOGJAK
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	Default
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum OKABPFHFIDP
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	PrimarySolid,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	SecondarySolid,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	HighlightSolid,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	HighlightGradient,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	BannerBG,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	InputField,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	LineColor,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	CardImageBase,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	DarkGradient,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	Shadow,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	Error,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	Warning,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	NotiBase,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	BackgroundAccent,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	SideBarBG,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	Modified,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	LoadingScreen,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	LoadingBarGradient,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	HomeButtonBase,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	TitleRoot,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	HighlightedAccent,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	LoadingCard,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	ChipBase,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	LimitedEventCard,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	LimitedEventBgSolid,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	DateChip,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	WinterWonderlandBG
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum NKGKCGCOJNG
{
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	A
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public enum OJJELAHPIFL
{
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	MainPrimary,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	MainSecondary,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	InversePrimary,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	NotUse,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	WhitePrimary,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	WhiteSecondary,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	CardPrimary,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	CardSecondary,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	Error,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	Modified,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	Orange
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public enum ADGKCNKILKC
{
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	WatchBackground,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	HomePage,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	DialogPage,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	Card,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	ProfileBG,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	WinterWonderlandHome
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public enum BBJOHPGAODO
{
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	JostMedium,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	JostMediumCap,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	JostBoldCap,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	RobotoReg,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	RobotoBold,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	RobotoBoldOutlineDropshadow,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	RobotoBoldOutline,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	RobotoBoldOutlineDropshadowGradient,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	RobotoBoldOutlineGradient
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum FLOHMNBNIPC
{
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	XXS = 0,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	XS = 1,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	S = 2,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	M = 3,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	L = 4,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	XL = 5,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	XXL = 8,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	XXXL = 6,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	XXXXL = 7
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public enum HAOOMFJOODA
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	Primary,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	Secondary,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	FlatPrimary,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	FlatButtonForWarningBanner,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	Negative,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	Chips,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	CarouselArrowDark,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	FlatWhite,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	MagicDoor,
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	Tertiary,
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	CarouselArrowLight,
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	HomePageMainButton,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	DropDown,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	SecondaryHeaderSection,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	ChatButton,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	FeedButton,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	NameTag
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum IONDLPNIODD
{
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	FlatOrange,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	FlatWhite,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	InputToggle,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	Chips,
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	Switch,
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	WhitePagingBlob,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	RSVPToggleHeaderSection,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	CardToggle,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	ChipsDark,
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	MainNavToggle,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	ListItem,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	NotiUnread,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	FlatPrimary,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	CharadePen,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	ShareCam,
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	CardToggleWithBacking,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	SecondaryHeaderSectionToggle,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	PrimaryToSecondaryHeader,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	NegativeToSecondaryHeader,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	LimitedEventPrimary,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	LimitedEventSecondary,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	LimitedEventTertiary,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	MainNavVrDetach
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum DMAPCKGJOEN
{
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	Checkbox
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum NKMELIIFMBO
{
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	Create,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	Select,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	Wire,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	Configure,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	Transform,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	Move,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	Rotate,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	Scale,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	CloneFlip,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	Recolor,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	Freeze,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	MakeInvention,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	Manipulate,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	Delete
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum IHNLJILAFNH
{
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	LightFlat,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	DarkFlat,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	Modified
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public enum FMMHHLDEGPL
{
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	LightFlat,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	DarkFlat
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum KPLGJMOLEJP
{
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	MirroUIPopUp
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum KFLLBOAABNB
{
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	Base,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	Button,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	Navigation,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	Overlay,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	Dialog,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	Toast
}
namespace RRUI.Theme
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CreateAssetMenu]
	public class AudioPalette : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public class ButtonAudioPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			[SerializeField]
			private NBMDFDBNDCB buttonAudioPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			[SerializeField]
			private ButtonAudioPaletteAsset buttonAudioPaletteConfig;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public NBMDFDBNDCB ButtonAudioPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x6C4060", Offset = "0x6C3460", VA = "0x1806C4060")]
				get
				{
					return default(NBMDFDBNDCB);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public ButtonAudioPaletteAsset ButtonAudioPaletteConfig
			{
				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
			public ButtonAudioPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public class ScrollingAudioPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			[SerializeField]
			private DKKBMGGHBAD scrollingAudioPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			[SerializeField]
			private ScrollingAudioPaletteAsset scrollingAudioPaletteConfig;

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public DKKBMGGHBAD ScrollingAudioPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0x6C4060", Offset = "0x6C3460", VA = "0x1806C4060")]
				get
				{
					return default(DKKBMGGHBAD);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public ScrollingAudioPaletteAsset ScrollingAudioPaletteConfig
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
			public ScrollingAudioPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public class ContentLoadingAudioPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			[SerializeField]
			private GPPHNKEMCID contentLoadingAudioPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			[SerializeField]
			private ContentLoadingAudioPaletteAsset contentLoadingAudioPaletteConfig;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public GPPHNKEMCID ContentLoadingAudioPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x6C4060", Offset = "0x6C3460", VA = "0x1806C4060")]
				get
				{
					return default(GPPHNKEMCID);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public ContentLoadingAudioPaletteAsset ContentLoadingAudioPaletteConfig
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
			public ContentLoadingAudioPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public class RecyclingAudioPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			[SerializeField]
			private FLAOGLOGJAK recyclingAudioPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			[SerializeField]
			private RecyclingAudioPaletteAsset recyclingAudioPaletteConfig;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public FLAOGLOGJAK RecyclingAudioPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x6C4060", Offset = "0x6C3460", VA = "0x1806C4060")]
				get
				{
					return default(FLAOGLOGJAK);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public RecyclingAudioPaletteAsset RecyclingAudioPaletteConfig
			{
				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
			public RecyclingAudioPaletteItem()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class KNMGOBCPBAH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public NBMDFDBNDCB buttonAudioPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
			public KNMGOBCPBAH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x1479C10", Offset = "0x1479010", VA = "0x181479C10")]
			internal bool <GetButtonAudioPalette>b__0(ButtonAudioPaletteItem buttonAudioPalette)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[CompilerGenerated]
		private sealed class DFLLDCLBHJD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public DKKBMGGHBAD scrollingAudioPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
			public DFLLDCLBHJD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x1479C10", Offset = "0x1479010", VA = "0x181479C10")]
			internal bool <GetScrollingAudioPaletteConfig>b__0(ScrollingAudioPaletteItem scrollingAudioPalette)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class AAPCMFIBLDL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public GPPHNKEMCID contentLoadingAudioPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
			public AAPCMFIBLDL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x1479C10", Offset = "0x1479010", VA = "0x181479C10")]
			internal bool <GetContentLoadingAudioPaletteConfig>b__0(ContentLoadingAudioPaletteItem contentLoadingAudioPalette)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private sealed class IOBNKEMOHOJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public FLAOGLOGJAK recyclingAudioPaletteType;

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
			public IOBNKEMOHOJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x1479C10", Offset = "0x1479010", VA = "0x181479C10")]
			internal bool <GetRecyclingAudioPaletteConfig>b__0(RecyclingAudioPaletteItem recyclingAudioPalette)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		[SerializeField]
		[NKNJAIMLBKK("ButtonAudioPaletteType")]
		private ButtonAudioPaletteItem[] buttonAudioPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		[SerializeField]
		[NKNJAIMLBKK("ScrollingAudioPaletteType")]
		private ScrollingAudioPaletteItem[] scrollingAudioPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		[SerializeField]
		[NKNJAIMLBKK("ContentLoadingAudioPaletteType")]
		private ContentLoadingAudioPaletteItem[] contentLoadingAudioPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		[SerializeField]
		[NKNJAIMLBKK("RecyclingAudioPaletteType")]
		private RecyclingAudioPaletteItem[] recyclingAudioPalettes;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x49BB860", Offset = "0x49BAC60", VA = "0x1849BB860")]
		public ButtonAudioPaletteAsset IGJPOCIJOAD(NBMDFDBNDCB NHDEPNBFDNG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x49BB770", Offset = "0x49BAB70", VA = "0x1849BB770")]
		public ScrollingAudioPaletteAsset HBCBHKBEGDH(DKKBMGGHBAD GJEDMKPHLPA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x49BB680", Offset = "0x49BAA80", VA = "0x1849BB680")]
		public ContentLoadingAudioPaletteAsset ECMEJBNAKFN(GPPHNKEMCID DFPKPHMCJCL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x49BB950", Offset = "0x49BAD50", VA = "0x1849BB950")]
		public RecyclingAudioPaletteAsset PBPIDGHPKHD(FLAOGLOGJAK AJHLPMAEMKE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7681E0", Offset = "0x7675E0", VA = "0x1807681E0")]
		public AudioPalette()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class BaseAudioPaletteAsset : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x49BBAC0", Offset = "0x49BAEC0", VA = "0x1849BBAC0")]
		protected bool JFDKPAPPJNP(RecRoomAudioClipPoolConfig NNIDEECGLDL, out RecRoomAudioClip[] OGLBHBJCMPA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7681E0", Offset = "0x7675E0", VA = "0x1807681E0")]
		public BaseAudioPaletteAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CreateAssetMenu]
	public class ButtonAnimationPalette : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		[SerializeField]
		private float clickAnimationDuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		[SerializeField]
		private float clickAnimationScale;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public float ClickAnimationDuration
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x8A55E0", Offset = "0x8A49E0", VA = "0x1808A55E0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public float ClickAnimationScale
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x8D17E0", Offset = "0x8D0BE0", VA = "0x1808D17E0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x49BBB70", Offset = "0x49BAF70", VA = "0x1849BBB70")]
		public ButtonAnimationPalette()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CreateAssetMenu]
	public class ButtonAudioPaletteAsset : BaseAudioPaletteAsset
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		[SerializeField]
		private RecRoomAudioClipPoolConfig pointerDownAudioClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		[SerializeField]
		private RecRoomAudioClipPoolConfig pointerUpAudioClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		[SerializeField]
		private RecRoomAudioClipPoolConfig pointerClickAudioClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		[SerializeField]
		private RecRoomAudioClipPoolConfig pointerEnterAudioClipPoolConfig;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public RecRoomAudioClip[] PointerDownAudioClipPool
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x49BBC20", Offset = "0x49BB020", VA = "0x1849BBC20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public RecRoomAudioClip[] PointerUpAudioClipPool
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x49BBD40", Offset = "0x49BB140", VA = "0x1849BBD40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public RecRoomAudioClip[] PointerClickAudioClipPool
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x49BBB90", Offset = "0x49BAF90", VA = "0x1849BBB90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public RecRoomAudioClip[] PointerEnterAudioClipPool
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x49BBCB0", Offset = "0x49BB0B0", VA = "0x1849BBCB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7681E0", Offset = "0x7675E0", VA = "0x1807681E0")]
		public ButtonAudioPaletteAsset()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class ButtonPalette
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		[SerializeField]
		[Header("Background")]
		private Color backgroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		[SerializeField]
		[FormerlySerializedAs("colorBlock")]
		private ColorBlock backgroundTints;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		[SerializeField]
		private GradientBlock backgroundGradients;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		[SerializeField]
		[Header("Foreground")]
		private Color foregroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		[SerializeField]
		private ColorBlock foregroundTints;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		[SerializeField]
		[Header("Text")]
		private TextStylePalette textPalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		[SerializeField]
		[Header("Audio")]
		private NBMDFDBNDCB audioPalette;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Color BackgroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x725C90", Offset = "0x725090", VA = "0x180725C90")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public ColorBlock BackgroundTints
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x49BBEE0", Offset = "0x49BB2E0", VA = "0x1849BBEE0")]
			get
			{
				return default(ColorBlock);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public GradientBlock BackgroundGradients
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x49BBEB0", Offset = "0x49BB2B0", VA = "0x1849BBEB0")]
			get
			{
				return default(GradientBlock);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Color ForegroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x752DD0", Offset = "0x7521D0", VA = "0x180752DD0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ColorBlock ForegroundTints
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x49BBF20", Offset = "0x49BB320", VA = "0x1849BBF20")]
			get
			{
				return default(ColorBlock);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public TextStylePalette TextPalette
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x723610", Offset = "0x722A10", VA = "0x180723610")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public NBMDFDBNDCB AudioPalette
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x9DF2B0", Offset = "0x9DE6B0", VA = "0x1809DF2B0")]
			get
			{
				return default(NBMDFDBNDCB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x49BBDD0", Offset = "0x49BB1D0", VA = "0x1849BBDD0")]
		public ButtonPalette()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CreateAssetMenu]
	public class ContentLoadingAudioPaletteAsset : BaseAudioPaletteAsset
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		[SerializeField]
		[Header("Clip Configs")]
		private RecRoomAudioClipPoolConfig loadingSFXAudioClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		[SerializeField]
		[Header("Thresholds")]
		[Tooltip("Only start looping loading SFX if any content has been loading for this much time")]
		private float loadingSFXStartDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		[SerializeField]
		[Tooltip("Small delay between content finish loading and stopping loading SFX. Avoiding quick stop and replay if contents load back to back.")]
		private float loadingSFXStopDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[SerializeField]
		[Tooltip("Cut loading SFX if content is still loading after this much time. Avoid sustaining SFX when content is hanging on loading.")]
		private float maxLoadingSFXLength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		[SerializeField]
		[Header("Smooth Fade")]
		private float fadeInDuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		[SerializeField]
		private float fadeOutDuration;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float LoadingSFXStartDelay
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x6F0AE0", Offset = "0x6EFEE0", VA = "0x1806F0AE0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float LoadingSFXStopDelay
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8CC370", Offset = "0x8CB770", VA = "0x1808CC370")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float MaxLoadingSFXLength
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x92C730", Offset = "0x92BB30", VA = "0x18092C730")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float FadeInDuration
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x9148B0", Offset = "0x913CB0", VA = "0x1809148B0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float FadeOutDuration
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x8BC280", Offset = "0x8BB680", VA = "0x1808BC280")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x49BD810", Offset = "0x49BCC10", VA = "0x1849BD810")]
		public bool HPFJEHHBBLN(out RecRoomAudioClip[] OGLBHBJCMPA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x49BD8C0", Offset = "0x49BCCC0", VA = "0x1849BD8C0")]
		public ContentLoadingAudioPaletteAsset()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class DepthPalette
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		[SerializeField]
		private float depth;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public float Depth
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x9C91D0", Offset = "0x9C85D0", VA = "0x1809C91D0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public DepthPalette()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class DropdownPalette
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		[SerializeField]
		private Color backgroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		[SerializeField]
		private Color foregroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		[SerializeField]
		private TextStylePalette textPalette;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Color BackgroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x725C90", Offset = "0x725090", VA = "0x180725C90")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Color ForegroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x752ED0", Offset = "0x7522D0", VA = "0x180752ED0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public TextStylePalette TextPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x702560", Offset = "0x701960", VA = "0x180702560")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x49BE4F0", Offset = "0x49BD8F0", VA = "0x1849BE4F0")]
		public DropdownPalette()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class InputFieldPalette
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		[SerializeField]
		private Color backgroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		[SerializeField]
		private Color foregroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		[SerializeField]
		private Color placeholderColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		[SerializeField]
		private TextStylePalette textPalette;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Color BackgroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x725C90", Offset = "0x725090", VA = "0x180725C90")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Color ForegroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x752ED0", Offset = "0x7522D0", VA = "0x180752ED0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Color PlaceholderColor
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xD489D0", Offset = "0xD47DD0", VA = "0x180D489D0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public TextStylePalette TextPalette
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x6E4150", Offset = "0x6E3550", VA = "0x1806E4150")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x49C0480", Offset = "0x49BF880", VA = "0x1849C0480")]
		public InputFieldPalette()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class MakerPenToolPalette
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		[SerializeField]
		private ButtonPalette buttonPalette;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public ButtonPalette ButtonPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x6E1E40", Offset = "0x6E1240", VA = "0x1806E1E40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public MakerPenToolPalette()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CreateAssetMenu]
	public class MenuAudioPaletteAsset : BaseAudioPaletteAsset
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		[SerializeField]
		[Header("Menu Open")]
		private RecRoomAudioClipPoolConfig menuHydrateAudioClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		[SerializeField]
		private RecRoomAudioClipPoolConfig menuOpen2DFlavorAudioClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		[SerializeField]
		[Header("Menu Close")]
		private RecRoomAudioClipPoolConfig menuDehydrateAudioClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		[SerializeField]
		private RecRoomAudioClipPoolConfig menuClose2DFlavorAudioClipPoolConfig;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public RecRoomAudioClip[] MenuHydrateAudioClipPool
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x49C1280", Offset = "0x49C0680", VA = "0x1849C1280")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public RecRoomAudioClip[] MenuOpen2DFlavorAudioClipPool
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x49C1310", Offset = "0x49C0710", VA = "0x1849C1310")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public RecRoomAudioClip[] MenuDehydrateAudioClipPool
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x49C11F0", Offset = "0x49C05F0", VA = "0x1849C11F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public RecRoomAudioClip[] MenuClose2DFlavorAudioClipPool
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x49C1160", Offset = "0x49C0560", VA = "0x1849C1160")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7681E0", Offset = "0x7675E0", VA = "0x1807681E0")]
		public MenuAudioPaletteAsset()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class MixedTogglePalette
	{
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		private enum KFAAOKENDNN
		{
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			UseBaseInactive,
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			UseBaseActive,
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			UseCustom
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		[SerializeField]
		private IONDLPNIODD baseTogglePalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		[SerializeField]
		private KFAAOKENDNN mixedPaletteType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		[SerializeField]
		[JLJIECADMGK("mixedPaletteType", 2)]
		private ButtonPalette mixedButtonPalette;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x49C13A0", Offset = "0x49C07A0", VA = "0x1849C13A0")]
		public TogglePalette FFFADKKLADK(Palette AEPADEGNNII)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x49C13D0", Offset = "0x49C07D0", VA = "0x1849C13D0")]
		public ButtonPalette NPAGJAMKHAE(Palette AEPADEGNNII)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public MixedTogglePalette()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CreateAssetMenu]
	public class Palette : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		public class RawImageColorPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000105")]
			[SerializeField]
			private NKGKCGCOJNG paletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			[SerializeField]
			private Color color;

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public NKGKCGCOJNG RawImageColorPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0x6C4060", Offset = "0x6C3460", VA = "0x1806C4060")]
				get
				{
					return default(NKGKCGCOJNG);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public Color Color
			{
				[Cpp2IlInjected.Token(Token = "0x600007D")]
				[Cpp2IlInjected.Address(RVA = "0x9C9980", Offset = "0x9C8D80", VA = "0x1809C9980")]
				get
				{
					return default(Color);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x19DB040", Offset = "0x19DA440", VA = "0x1819DB040")]
			public RawImageColorPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public class BackgroundColorPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			[SerializeField]
			private OKABPFHFIDP backgroundColorPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			[SerializeField]
			private Color color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000109")]
			[SerializeField]
			private Gradient gradient;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			[SerializeField]
			private bool raycastTarget;

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public OKABPFHFIDP BackgroundColorPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600007F")]
				[Cpp2IlInjected.Address(RVA = "0x6C4060", Offset = "0x6C3460", VA = "0x1806C4060")]
				get
				{
					return default(OKABPFHFIDP);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public Color Color
			{
				[Cpp2IlInjected.Token(Token = "0x6000080")]
				[Cpp2IlInjected.Address(RVA = "0x9C9980", Offset = "0x9C8D80", VA = "0x1809C9980")]
				get
				{
					return default(Color);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public Gradient Gradient
			{
				[Cpp2IlInjected.Token(Token = "0x6000081")]
				[Cpp2IlInjected.Address(RVA = "0x6E42D0", Offset = "0x6E36D0", VA = "0x1806E42D0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public bool RaycastTarget
			{
				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0x77F530", Offset = "0x77E930", VA = "0x18077F530")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x49BBA40", Offset = "0x49BAE40", VA = "0x1849BBA40")]
			public BackgroundColorPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		public class ForegroundColorPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400010B")]
			[SerializeField]
			private OJJELAHPIFL foregroundColorPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			[SerializeField]
			private Color color;

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public OJJELAHPIFL ForegroundColorPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x6C4060", Offset = "0x6C3460", VA = "0x1806C4060")]
				get
				{
					return default(OJJELAHPIFL);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public Color Color
			{
				[Cpp2IlInjected.Token(Token = "0x6000085")]
				[Cpp2IlInjected.Address(RVA = "0x9C9980", Offset = "0x9C8D80", VA = "0x1809C9980")]
				get
				{
					return default(Color);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x49BFBA0", Offset = "0x49BEFA0", VA = "0x1849BFBA0")]
			public ForegroundColorPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public class TilerPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			[SerializeField]
			private ADGKCNKILKC tilerPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400010E")]
			[SerializeField]
			private TilerPalette tilerPalette;

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public ADGKCNKILKC TilerPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0x6C4060", Offset = "0x6C3460", VA = "0x1806C4060")]
				get
				{
					return default(ADGKCNKILKC);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public TilerPalette TilerPalette
			{
				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
			public TilerPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000035")]
		public class TextStylePaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400010F")]
			[SerializeField]
			private BBJOHPGAODO textStylePaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000110")]
			[SerializeField]
			private TextStylePalette textStylePalette;

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public BBJOHPGAODO TextStylePaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600008A")]
				[Cpp2IlInjected.Address(RVA = "0x6C4060", Offset = "0x6C3460", VA = "0x1806C4060")]
				get
				{
					return default(BBJOHPGAODO);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public TextStylePalette TextStylePalette
			{
				[Cpp2IlInjected.Token(Token = "0x600008B")]
				[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
			public TextStylePaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public class TextSizePaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000111")]
			[SerializeField]
			private FLOHMNBNIPC textSizePaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			[SerializeField]
			private int size;

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			public FLOHMNBNIPC TextSizePaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0x6C4060", Offset = "0x6C3460", VA = "0x1806C4060")]
				get
				{
					return default(FLOHMNBNIPC);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public int Size
			{
				[Cpp2IlInjected.Token(Token = "0x600008E")]
				[Cpp2IlInjected.Address(RVA = "0x7532A0", Offset = "0x7526A0", VA = "0x1807532A0")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x1B398D0", Offset = "0x1B38CD0", VA = "0x181B398D0")]
			public TextSizePaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		public class ButtonPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			[SerializeField]
			private HAOOMFJOODA buttonPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			[SerializeField]
			private ButtonPalette buttonPalette;

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public HAOOMFJOODA ButtonPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000090")]
				[Cpp2IlInjected.Address(RVA = "0x6C4060", Offset = "0x6C3460", VA = "0x1806C4060")]
				get
				{
					return default(HAOOMFJOODA);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000042")]
			public ButtonPalette ButtonPalette
			{
				[Cpp2IlInjected.Token(Token = "0x6000091")]
				[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
			public ButtonPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public class TogglePaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			[SerializeField]
			private IONDLPNIODD togglePaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			[SerializeField]
			private TogglePalette togglePalette;

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			public IONDLPNIODD TogglePaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000093")]
				[Cpp2IlInjected.Address(RVA = "0x6C4060", Offset = "0x6C3460", VA = "0x1806C4060")]
				get
				{
					return default(IONDLPNIODD);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			public TogglePalette TogglePalette
			{
				[Cpp2IlInjected.Token(Token = "0x6000094")]
				[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
			public TogglePaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public class MixedTogglePaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			[SerializeField]
			private DMAPCKGJOEN mixedTogglePaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			[SerializeField]
			private MixedTogglePalette mixedTogglePalette;

			[Cpp2IlInjected.Token(Token = "0x17000045")]
			public DMAPCKGJOEN MixedTogglePaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000096")]
				[Cpp2IlInjected.Address(RVA = "0x6C4060", Offset = "0x6C3460", VA = "0x1806C4060")]
				get
				{
					return default(DMAPCKGJOEN);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000046")]
			public MixedTogglePalette MixedTogglePalette
			{
				[Cpp2IlInjected.Token(Token = "0x6000097")]
				[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
			public MixedTogglePaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public class MakerPenToolPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			[SerializeField]
			private NKMELIIFMBO makerPenToolPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400011A")]
			[SerializeField]
			private MakerPenToolPalette makerPenToolPalette;

			[Cpp2IlInjected.Token(Token = "0x17000047")]
			public NKMELIIFMBO MakerPenToolPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000099")]
				[Cpp2IlInjected.Address(RVA = "0x6C4060", Offset = "0x6C3460", VA = "0x1806C4060")]
				get
				{
					return default(NKMELIIFMBO);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000048")]
			public MakerPenToolPalette MakerPenToolPalette
			{
				[Cpp2IlInjected.Token(Token = "0x600009A")]
				[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
			public MakerPenToolPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public class InputFieldPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			[SerializeField]
			private IHNLJILAFNH inputFieldPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			[SerializeField]
			private InputFieldPalette inputFieldPalette;

			[Cpp2IlInjected.Token(Token = "0x17000049")]
			public IHNLJILAFNH InputFieldPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600009C")]
				[Cpp2IlInjected.Address(RVA = "0x6C4060", Offset = "0x6C3460", VA = "0x1806C4060")]
				get
				{
					return default(IHNLJILAFNH);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004A")]
			public InputFieldPalette InputFieldPalette
			{
				[Cpp2IlInjected.Token(Token = "0x600009D")]
				[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
			public InputFieldPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		public class DropdownPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			[SerializeField]
			private FMMHHLDEGPL dropdownPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			[SerializeField]
			private DropdownPalette dropdownPalette;

			[Cpp2IlInjected.Token(Token = "0x1700004B")]
			public FMMHHLDEGPL DropdownPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600009F")]
				[Cpp2IlInjected.Address(RVA = "0x6C4060", Offset = "0x6C3460", VA = "0x1806C4060")]
				get
				{
					return default(FMMHHLDEGPL);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004C")]
			public DropdownPalette DropdownPalette
			{
				[Cpp2IlInjected.Token(Token = "0x60000A0")]
				[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
			public DropdownPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200003D")]
		public class SliderPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			[SerializeField]
			private KPLGJMOLEJP sliderPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			[SerializeField]
			private SliderPalette sliderPalette;

			[Cpp2IlInjected.Token(Token = "0x1700004D")]
			public KPLGJMOLEJP SliderPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x60000A2")]
				[Cpp2IlInjected.Address(RVA = "0x6C4060", Offset = "0x6C3460", VA = "0x1806C4060")]
				get
				{
					return default(KPLGJMOLEJP);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004E")]
			public SliderPalette SliderPalette
			{
				[Cpp2IlInjected.Token(Token = "0x60000A3")]
				[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
			public SliderPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		public class DepthPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			[SerializeField]
			private KFLLBOAABNB depthPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			[SerializeField]
			private DepthPalette depthPalette;

			[Cpp2IlInjected.Token(Token = "0x1700004F")]
			public KFLLBOAABNB DepthPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x60000A5")]
				[Cpp2IlInjected.Address(RVA = "0x6C4060", Offset = "0x6C3460", VA = "0x1806C4060")]
				get
				{
					return default(KFLLBOAABNB);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000050")]
			public DepthPalette DepthPalette
			{
				[Cpp2IlInjected.Token(Token = "0x60000A6")]
				[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
			public DepthPaletteItem()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		[CompilerGenerated]
		private sealed class DKBKMLKBOLK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public NKGKCGCOJNG backgroundColorPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
			public DKBKMLKBOLK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x1479C10", Offset = "0x1479010", VA = "0x181479C10")]
			internal bool <GetRawImageColor>b__0(RawImageColorPaletteItem pi)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		[CompilerGenerated]
		private sealed class CHGKHBGPNNC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public OKABPFHFIDP backgroundColorPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
			public CHGKHBGPNNC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x1479C10", Offset = "0x1479010", VA = "0x181479C10")]
			internal bool <GetBackgroundPaletteData>b__0(BackgroundColorPaletteItem backgroundColorPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[CompilerGenerated]
		private sealed class NGKJNKNMICH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public OJJELAHPIFL foregroundColorPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
			public NGKJNKNMICH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x1479C10", Offset = "0x1479010", VA = "0x181479C10")]
			internal bool <GetForegroundColor>b__0(ForegroundColorPaletteItem colorPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		[CompilerGenerated]
		private sealed class LEHNKPNFNOH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			public ADGKCNKILKC type;

			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
			public LEHNKPNFNOH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x1479C10", Offset = "0x1479010", VA = "0x181479C10")]
			internal bool <GetTilerPalette>b__0(TilerPaletteItem tilerPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000043")]
		[CompilerGenerated]
		private sealed class BCFIPFCCFKK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			public BBJOHPGAODO textStylePaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
			public BCFIPFCCFKK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x1479C10", Offset = "0x1479010", VA = "0x181479C10")]
			internal bool <GetTextStylePalette>b__0(TextStylePaletteItem textStylePaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		[CompilerGenerated]
		private sealed class JCMDGMJLBEG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			public FLOHMNBNIPC textSizePaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
			public JCMDGMJLBEG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x1479C10", Offset = "0x1479010", VA = "0x181479C10")]
			internal bool <GetTextSize>b__0(TextSizePaletteItem textSizePaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[CompilerGenerated]
		private sealed class BDPPKBLPGOB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			public HAOOMFJOODA buttonPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
			public BDPPKBLPGOB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x1479C10", Offset = "0x1479010", VA = "0x181479C10")]
			internal bool <GetButtonPalette>b__0(ButtonPaletteItem buttonPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[CompilerGenerated]
		private sealed class BMMNOEMNMJA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public IONDLPNIODD togglePaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
			public BMMNOEMNMJA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x1479C10", Offset = "0x1479010", VA = "0x181479C10")]
			internal bool <GetTogglePalette>b__0(TogglePaletteItem togglePaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		[CompilerGenerated]
		private sealed class AIEFNGLJLBP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public DMAPCKGJOEN mixedTogglePaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
			public AIEFNGLJLBP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x1479C10", Offset = "0x1479010", VA = "0x181479C10")]
			internal bool <GetMixedTogglePalette>b__0(MixedTogglePaletteItem mixedTogglePaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[CompilerGenerated]
		private sealed class MPKLFDONODK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			public NKMELIIFMBO makerPenToolPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
			public MPKLFDONODK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x1479C10", Offset = "0x1479010", VA = "0x181479C10")]
			internal bool <GetMakerPenToolPalette>b__0(MakerPenToolPaletteItem makerPenToolPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		[CompilerGenerated]
		private sealed class AOECCGLCHKI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400012D")]
			public IHNLJILAFNH inputFieldPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
			public AOECCGLCHKI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x1479C10", Offset = "0x1479010", VA = "0x181479C10")]
			internal bool <GetInputFieldPalette>b__0(InputFieldPaletteItem inputFieldPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		[CompilerGenerated]
		private sealed class LLDMOLHPIMC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400012E")]
			public FMMHHLDEGPL dropdownPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
			public LLDMOLHPIMC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x1479C10", Offset = "0x1479010", VA = "0x181479C10")]
			internal bool <GetDropdownPalette>b__0(DropdownPaletteItem dropdownPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private sealed class BPOEDMGJHIE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400012F")]
			public KPLGJMOLEJP sliderPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
			public BPOEDMGJHIE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x1479C10", Offset = "0x1479010", VA = "0x181479C10")]
			internal bool <GetSliderPalette>b__0(SliderPaletteItem sliderPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private sealed class NDKPBJNIPNI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public KFLLBOAABNB depthPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
			public NDKPBJNIPNI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x1479C10", Offset = "0x1479010", VA = "0x181479C10")]
			internal bool <GetDepth>b__0(DepthPaletteItem depthPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		[SerializeField]
		[Header("Visual")]
		[NKNJAIMLBKK("RawImageColorPaletteType")]
		private RawImageColorPaletteItem[] rawImageColorPaletteItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		[SerializeField]
		[NKNJAIMLBKK("BackgroundColorPaletteType")]
		private BackgroundColorPaletteItem[] backgroundColorPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		[SerializeField]
		[NKNJAIMLBKK("ForegroundColorPaletteType")]
		private ForegroundColorPaletteItem[] foregroundColorPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		[SerializeField]
		[NKNJAIMLBKK("TilerPaletteType")]
		private TilerPaletteItem[] tilerPaletteItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		[SerializeField]
		[NKNJAIMLBKK("TextStylePaletteType")]
		private TextStylePaletteItem[] textStylePalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		[SerializeField]
		[NKNJAIMLBKK("TextSizePaletteType")]
		private TextSizePaletteItem[] textSizePalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		[SerializeField]
		[NKNJAIMLBKK("ButtonPaletteType")]
		private ButtonPaletteItem[] buttonPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		[SerializeField]
		[NKNJAIMLBKK("TogglePaletteType")]
		private TogglePaletteItem[] togglePalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		[SerializeField]
		[NKNJAIMLBKK("MixedTogglePaletteType")]
		private MixedTogglePaletteItem[] mixedTogglePalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		[SerializeField]
		[NKNJAIMLBKK("MakerPenToolPaletteType")]
		private MakerPenToolPaletteItem[] makerPenToolPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		[SerializeField]
		[NKNJAIMLBKK("InputFieldPaletteType")]
		private InputFieldPaletteItem[] inputFieldPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		[SerializeField]
		[NKNJAIMLBKK("DropdownPaletteType")]
		private DropdownPaletteItem[] dropdownPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		[SerializeField]
		[NKNJAIMLBKK("SliderPaletteType")]
		private SliderPaletteItem[] sliderPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		[SerializeField]
		[NKNJAIMLBKK("DepthPaletteType")]
		private DepthPaletteItem[] depthPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		[SerializeField]
		private ButtonAnimationPalette buttonAnimationPalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		[SerializeField]
		[Header("Audio")]
		[FormerlySerializedAs("audioPaletteConfig")]
		private AudioPalette audioPalette;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public IEnumerable<DepthPaletteItem> DepthPalettes
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x7A4AB0", Offset = "0x7A3EB0", VA = "0x1807A4AB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public ButtonAnimationPalette ButtonAnimationPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x757C60", Offset = "0x757060", VA = "0x180757C60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public AudioPalette AudioPalette
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x786230", Offset = "0x785630", VA = "0x180786230")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x49C4930", Offset = "0x49C3D30", VA = "0x1849C4930")]
		public Color MFBBCPNCFGK(NKGKCGCOJNG AKGEBNBPLLM)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x49C41D0", Offset = "0x49C35D0", VA = "0x1849C41D0")]
		public void FAPLDAMPJFO(OKABPFHFIDP AKGEBNBPLLM, out Color GEDOLEMBLCF, out Gradient KMMJFFFJDOF, out bool DBMGNIDCIPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x49C3FD0", Offset = "0x49C33D0", VA = "0x1849C3FD0")]
		public Color DJCPCMNLPPG(OJJELAHPIFL PKLJCDPKEEA)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x49C4710", Offset = "0x49C3B10", VA = "0x1849C4710")]
		public TilerPalette LNFPEIDPFHP(ADGKCNKILKC DDJDPMGLPAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x49C4B30", Offset = "0x49C3F30", VA = "0x1849C4B30")]
		public TextStylePalette PPMCAECLCHI(BBJOHPGAODO DOALABFEGLP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x49C4620", Offset = "0x49C3A20", VA = "0x1849C4620")]
		public int KHDCHCAFDEL(FLOHMNBNIPC HDCGDLBLLNP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x49C4A40", Offset = "0x49C3E40", VA = "0x1849C4A40")]
		public ButtonPalette PBOBDACICHI(HAOOMFJOODA BEPDLJOIFFJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x49C4530", Offset = "0x49C3930", VA = "0x1849C4530")]
		public TogglePalette JMCKBEDJCJB(IONDLPNIODD IDBFFPKCFNA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x49C4440", Offset = "0x49C3840", VA = "0x1849C4440")]
		public MixedTogglePalette JDGJKLBKNHD(DMAPCKGJOEN DMALALPCKAN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x49C3EE0", Offset = "0x49C32E0", VA = "0x1849C3EE0")]
		public MakerPenToolPalette ADFCGPBIABB(NKMELIIFMBO MEPIPIPECGG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x49C40E0", Offset = "0x49C34E0", VA = "0x1849C40E0")]
		public InputFieldPalette EFEMHPHHFPI(IHNLJILAFNH PCPINOCNPFI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x49C4350", Offset = "0x49C3750", VA = "0x1849C4350")]
		public DropdownPalette GFDIHFICKNN(FMMHHLDEGPL EFPDAAMDLFI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x49C3DF0", Offset = "0x49C31F0", VA = "0x1849C3DF0")]
		public SliderPalette ABOKEEHOKJI(KPLGJMOLEJP GLPDKADHJHO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x49C4800", Offset = "0x49C3C00", VA = "0x1849C4800")]
		public float? MCLNBEIDOEP(KFLLBOAABNB LOGHLJLMCLM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x7681E0", Offset = "0x7675E0", VA = "0x1807681E0")]
		public Palette()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CreateAssetMenu]
	public class RecyclingAudioPaletteAsset : BaseAudioPaletteAsset
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		[SerializeField]
		[Header("Clip Configs")]
		private RecRoomAudioClipPoolConfig itemRecycledAudioClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		[SerializeField]
		[Header("Thresholds")]
		[Tooltip("Minimum required wait time before recycle SFX can be triggered repetitively")]
		private float minimumTimeIntervalForRecycleSFX;

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public float MinimumTimeIntervalForRecycleSFX
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x6F0AE0", Offset = "0x6EFEE0", VA = "0x1806F0AE0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x49BD810", Offset = "0x49BCC10", VA = "0x1849BD810")]
		public bool OOLMPPNEFMD(out RecRoomAudioClip[] OGLBHBJCMPA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x49C5100", Offset = "0x49C4500", VA = "0x1849C5100")]
		public RecyclingAudioPaletteAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CreateAssetMenu]
	public class ScrollingAudioPaletteAsset : BaseAudioPaletteAsset
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[SerializeField]
		[Header("Clip Configs")]
		private RecRoomAudioClipPoolConfig scrollingSFXAudioClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		[SerializeField]
		private RecRoomAudioClipPoolConfig hittingEndsAudioClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		[SerializeField]
		[Header("Thresholds")]
		[Tooltip("This distance is measured in UI canvas space")]
		private float distanceThresholdToTriggerScrollingSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		[SerializeField]
		private float minimumTimeIntervalForScrollingSFX;

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public float DistanceThresholdToTriggerScrollingSFX
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x92C730", Offset = "0x92BB30", VA = "0x18092C730")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public float MinimumTimeIntervalForScrollingSFX
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x9148B0", Offset = "0x913CB0", VA = "0x1809148B0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x49BD810", Offset = "0x49BCC10", VA = "0x1849BD810")]
		public bool ADGMAHMFODI(out RecRoomAudioClip[] OGLBHBJCMPA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x49C8220", Offset = "0x49C7620", VA = "0x1849C8220")]
		public bool IJLGFHEPHNF(out RecRoomAudioClip[] OGLBHBJCMPA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x49C82D0", Offset = "0x49C76D0", VA = "0x1849C82D0")]
		public ScrollingAudioPaletteAsset()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public class SliderPalette
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		[SerializeField]
		private Color sliderColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		[SerializeField]
		private Color fillColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		[SerializeField]
		private Color handleColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		[SerializeField]
		private TextStylePalette textPalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		[SerializeField]
		private Color textColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		[SerializeField]
		private ColorBlock colorBlock;

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public Color SliderColor
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x725C90", Offset = "0x725090", VA = "0x180725C90")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public Color FillColor
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x752ED0", Offset = "0x7522D0", VA = "0x180752ED0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public Color HandleColor
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0xD489D0", Offset = "0xD47DD0", VA = "0x180D489D0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public TextStylePalette TextPalette
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x6E4150", Offset = "0x6E3550", VA = "0x1806E4150")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public Color TextColor
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x752EC0", Offset = "0x7522C0", VA = "0x180752EC0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public ColorBlock ColorBlock
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x49C9150", Offset = "0x49C8550", VA = "0x1849C9150")]
			get
			{
				return default(ColorBlock);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x49C90A0", Offset = "0x49C84A0", VA = "0x1849C90A0")]
		public SliderPalette()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public class TextStylePalette
	{
		[Cpp2IlInjected.Token(Token = "0x2000051")]
		public enum MEPJIGAFDPO
		{
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			LowerCase,
			[Cpp2IlInjected.Token(Token = "0x4000147")]
			UpperCase,
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			SmallCaps
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		[SerializeField]
		private TMP_FontAsset font;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		[SerializeField]
		private Material fontOverrideMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		[SerializeField]
		private float kerning;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		[SerializeField]
		private float leading;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		[SerializeField]
		private bool isBold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		[SerializeField]
		private bool isItalic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		[SerializeField]
		private MEPJIGAFDPO transformation;

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public TMP_FontAsset Font
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x6E1E40", Offset = "0x6E1240", VA = "0x1806E1E40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public Material FontOverrideMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public float Kerning
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x6F0AE0", Offset = "0x6EFEE0", VA = "0x1806F0AE0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public float Leading
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x8CC370", Offset = "0x8CB770", VA = "0x1808CC370")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public bool IsBold
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x810280", Offset = "0x80F680", VA = "0x180810280")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool IsItalic
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x8112F0", Offset = "0x8106F0", VA = "0x1808112F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public MEPJIGAFDPO Transformation
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x74F250", Offset = "0x74E650", VA = "0x18074F250")]
			get
			{
				return default(MEPJIGAFDPO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x49C9AD0", Offset = "0x49C8ED0", VA = "0x1849C9AD0")]
		public void AGFAAKKIOCC(TextMeshProUGUI EEFAFMLEPJI, bool CKJEIPDBONL = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public TextStylePalette()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public class TilerPalette
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		[SerializeField]
		private Sprite sprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		[SerializeField]
		private Color tintColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		[SerializeField]
		private Color backgroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		[SerializeField]
		private float rows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		[SerializeField]
		private float rowsWhenPortrait;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		[SerializeField]
		private Vector2 spacing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		[SerializeField]
		private float offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		[SerializeField]
		private Vector2 velocity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		[SerializeField]
		[Range(0f, 360f)]
		private float angle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		[SerializeField]
		private UITiler.FFAMMPDBCBC animationDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		[SerializeField]
		private float primaryAnimationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		[SerializeField]
		private float altAnimationSpeed;

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public Sprite Sprite
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x6E1E40", Offset = "0x6E1240", VA = "0x1806E1E40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public Color TintColor
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x760C90", Offset = "0x760090", VA = "0x180760C90")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public Color BackgroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x730150", Offset = "0x72F550", VA = "0x180730150")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public Vector2 Spacing
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x1B8D430", Offset = "0x1B8C830", VA = "0x181B8D430")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public float Offset
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x730120", Offset = "0x72F520", VA = "0x180730120")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public Vector2 Velocity
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x49CA020", Offset = "0x49C9420", VA = "0x1849CA020")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public float Angle
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x797730", Offset = "0x796B30", VA = "0x180797730")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public UITiler.FFAMMPDBCBC AnimationDirection
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x77D660", Offset = "0x77CA60", VA = "0x18077D660")]
			get
			{
				return default(UITiler.FFAMMPDBCBC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public float PrimaryAnimationSpeed
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x15ACF30", Offset = "0x15AC330", VA = "0x1815ACF30")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public float AltAnimationSpeed
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x16A6C50", Offset = "0x16A6050", VA = "0x1816A6C50")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x49C9F90", Offset = "0x49C9390", VA = "0x1849C9F90")]
		public float HPLKPOEEDIF(DIBIMNIJNHH DEKPJDKGHCD)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x49C9FB0", Offset = "0x49C93B0", VA = "0x1849C9FB0")]
		public TilerPalette()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public class TogglePalette
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		[SerializeField]
		private ButtonPalette inactiveButtonPalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		[SerializeField]
		private ButtonPalette activeButtonPalette;

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public ButtonPalette InactiveButtonPalette
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x6E1E40", Offset = "0x6E1240", VA = "0x1806E1E40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public ButtonPalette ActiveButtonPalette
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public TogglePalette()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public class ApproximationMaskDepthTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		[SerializeField]
		private RectTransform content;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private Vector3? IHDNPDENHFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private Vector3? LHLBNFMJGON;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x49BB5A0", Offset = "0x49BA9A0", VA = "0x1849BB5A0")]
		private void BNACPANAOEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x49BB1E0", Offset = "0x49BA5E0", VA = "0x1849BB1E0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6E4110", Offset = "0x6E3510", VA = "0x1806E4110")]
		public ApproximationMaskDepthTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public class ButtonTheme : ButtonThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		[SerializeField]
		[Header("Button Visual")]
		private HAOOMFJOODA buttonType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		[SerializeField]
		[Header("Button Audio")]
		[Tooltip("Override the audio palette defined by the button's visual with a custom palette")]
		private bool overrideButtonAudioPalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		[SerializeField]
		[JLJIECADMGK("overrideButtonAudioPalette")]
		[Tooltip("Specify a custom config to use for button audio")]
		private ButtonAudioPaletteAsset customButtonAudioConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		[SerializeField]
		[Tooltip("Layer a 2D SFX on top of base button sounds")]
		private bool useFlavorSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		[SerializeField]
		[JLJIECADMGK("useFlavorSFX")]
		[Tooltip("Flavor SFX is picked randomly from this pool config")]
		private RecRoomAudioClipPoolConfig flavorSFXClipPoolConfig;

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public HAOOMFJOODA IFDEPOEEDBH
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x9DF3A0", Offset = "0x9DE7A0", VA = "0x1809DF3A0")]
			get
			{
				return default(HAOOMFJOODA);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x49BD7F0", Offset = "0x49BCBF0", VA = "0x1849BD7F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x49BD580", Offset = "0x49BC980", VA = "0x1849BD580", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x419E670", Offset = "0x419DA70", VA = "0x18419E670")]
		public void SetAnimationEnabled(bool LNJLGDKOFHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x49BD7E0", Offset = "0x49BCBE0", VA = "0x1849BD7E0")]
		public ButtonTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public abstract class ButtonThemeBase : SelectableThemeBase
	{
		[Cpp2IlInjected.Token(Token = "0x2000058")]
		protected class KBBIPMKOFDK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000176")]
			public ButtonAudioPaletteAsset CCKLDJBPFIF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000177")]
			public RecRoomAudioClipPoolConfig DAADMBMOMBL;

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
			public KBBIPMKOFDK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		[SerializeField]
		[Header("Button Theme Base")]
		[LNFKCGBKKAE(BCMNNOMINIG.Self, false, false, false)]
		private MultiGraphicButton multiGraphicButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		[SerializeField]
		[LNFKCGBKKAE(BCMNNOMINIG.Self, false, true, false)]
		private Image surface;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		[SerializeField]
		private bool useSurfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		[SerializeField]
		[JLJIECADMGK("useSurfaceOverride")]
		private Image surfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		[SerializeField]
		[DJGGFMCNHBJ]
		private List<Graphic> graphics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		[SerializeField]
		private bool useGraphicsOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		[SerializeField]
		[JLJIECADMGK("useGraphicsOverride")]
		private List<Graphic> graphicsOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		[SerializeField]
		[LNFKCGBKKAE(BCMNNOMINIG.Self, false, true, false)]
		private UIGradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		[SerializeField]
		private bool useGradientOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		[SerializeField]
		[JLJIECADMGK("useGradientOverride")]
		private UIGradient gradientOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		[SerializeField]
		[LNFKCGBKKAE(BCMNNOMINIG.Children, true, true, false)]
		private TextMeshProUGUI textMeshProUGUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		[SerializeField]
		private bool useTextMeshProUGUIOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		[SerializeField]
		[JLJIECADMGK("useTextMeshProUGUIOverride")]
		private TextMeshProUGUI textMeshProUGUIOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		[SerializeField]
		private FLOHMNBNIPC textSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		[SerializeField]
		protected bool isAnimationEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD5")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		[SerializeField]
		[JLJIECADMGK("isAnimationEnabled")]
		protected bool overrideAnimationTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		[SerializeField]
		[JLJIECADMGK("overrideAnimationTarget")]
		protected GameObject animationTargetOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private bool JGMMDCGDONP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private Vector3 KOLMDBCKEKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private Vector3 COMPOFMOBMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private MIGBDLGBGMG FCENPPACGGK;

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public Image LLHBLIONNNK
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x49BD520", Offset = "0x49BC920", VA = "0x1849BD520")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public List<Graphic> EABHCCKGKNB
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x49BD500", Offset = "0x49BC900", VA = "0x1849BD500")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public UIGradient ALNNJMCBEOF
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x49BD4E0", Offset = "0x49BC8E0", VA = "0x1849BD4E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public TextMeshProUGUI FHNODPMGPFP
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x49BD540", Offset = "0x49BC940", VA = "0x1849BD540")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public FLOHMNBNIPC KLLNOPGCDOA
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x1C6A850", Offset = "0x1C69C50", VA = "0x181C6A850")]
			get
			{
				return default(FLOHMNBNIPC);
			}
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x49BD560", Offset = "0x49BC960", VA = "0x1849BD560")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		protected Transform NHAACPNABOK
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x49BD360", Offset = "0x49BC760", VA = "0x1849BD360")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public Button FMFCGBOHPON
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x49BD460", Offset = "0x49BC860", VA = "0x1849BD460")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x49BCBE0", Offset = "0x49BBFE0", VA = "0x1849BCBE0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x49BCB40", Offset = "0x49BBF40", VA = "0x1849BCB40")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x49BBF90", Offset = "0x49BB390", VA = "0x1849BBF90")]
		protected void HGHNDHBJCJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x49BC110", Offset = "0x49BB510", VA = "0x1849BC110")]
		protected void JPLONGKJAOH(ButtonPalette DKAOKGEDLFN, [Optional] KBBIPMKOFDK GIGDKJMKFHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x49BCC60", Offset = "0x49BC060", VA = "0x1849BCC60", Slot = "12")]
		public override void OnPointerDown(PointerEventData FFEKEOCBAFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x49BD030", Offset = "0x49BC430", VA = "0x1849BD030", Slot = "13")]
		public override void OnPointerUp(PointerEventData FFEKEOCBAFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x49BCC40", Offset = "0x49BC040", VA = "0x1849BCC40", Slot = "14")]
		public override void OnPointerClick(PointerEventData FFEKEOCBAFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x49BBF70", Offset = "0x49BB370", VA = "0x1849BBF70")]
		private Vector3 BNBEHCIKOCB(float BDMGGOCELCK)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x49BD3B0", Offset = "0x49BC7B0", VA = "0x1849BD3B0")]
		protected ButtonThemeBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x1F2A150", Offset = "0x1F29550", VA = "0x181F2A150")]
		[CompilerGenerated]
		private void DNBOPIJEEME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x1F2A150", Offset = "0x1F29550", VA = "0x181F2A150")]
		[CompilerGenerated]
		private void ABBOBIGAPDL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public class DepthTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		[SerializeField]
		private KFLLBOAABNB depth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		[SerializeField]
		private bool animateOnEnable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		[SerializeField]
		[JLJIECADMGK("animateOnEnable")]
		private float animationTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private Vector3? IHDNPDENHFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private Vector2 JMPCFODJCLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private Vector2 FNKKLLIICCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private Vector2 POMJLJCCMHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private Vector2 MKLNILAFFMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private Vector2 LOFLENPMIGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private Vector2 BDJBHLCPGCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private readonly bool? FGBAAFANBCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private EIPMLBBKCPE GGPKGFFBIOF;

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		private RectTransform CGCMGFILGIO
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x49BE260", Offset = "0x49BD660", VA = "0x1849BE260")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public KFLLBOAABNB EPDMFALLDEL
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x6E08E0", Offset = "0x6DFCE0", VA = "0x1806E08E0")]
			get
			{
				return default(KFLLBOAABNB);
			}
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x49BE4D0", Offset = "0x49BD8D0", VA = "0x1849BE4D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		private EIPMLBBKCPE LGPEOHIJNEI
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x49BE120", Offset = "0x49BD520", VA = "0x1849BE120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		private bool DMBHPLDEBPH
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x49BE190", Offset = "0x49BD590", VA = "0x1849BE190")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x49BE370", Offset = "0x49BD770", VA = "0x1849BE370")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x49BE2C0", Offset = "0x49BD6C0", VA = "0x1849BE2C0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x49BD8F0", Offset = "0x49BCCF0", VA = "0x1849BD8F0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x49BDAF0", Offset = "0x49BCEF0", VA = "0x1849BDAF0")]
		private void BNACPANAOEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x49BDE10", Offset = "0x49BD210", VA = "0x1849BDE10")]
		private Vector3 CJAFJABOKHO()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x49BE3E0", Offset = "0x49BD7E0", VA = "0x1849BE3E0")]
		public DepthTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public class DropdownTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		[SerializeField]
		[PLDPAHFKOHO(BCMNNOMINIG.Self, false, false, false)]
		private Dropdown dropdown;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		[SerializeField]
		[LNFKCGBKKAE(BCMNNOMINIG.Self, false, true, false)]
		private Image surface;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		[SerializeField]
		private bool useSurfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		[SerializeField]
		[JLJIECADMGK("useSurfaceOverride")]
		private Image surfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		[SerializeField]
		private FMMHHLDEGPL dropdownType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		[SerializeField]
		private FLOHMNBNIPC textSize;

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public Image LLHBLIONNNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x49BEB80", Offset = "0x49BDF80", VA = "0x1849BEB80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public FMMHHLDEGPL PBODLJALJDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x6D8750", Offset = "0x6D7B50", VA = "0x1806D8750")]
			get
			{
				return default(FMMHHLDEGPL);
			}
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x49BEB90", Offset = "0x49BDF90", VA = "0x1849BEB90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public FLOHMNBNIPC KLLNOPGCDOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x74E0D0", Offset = "0x74D4D0", VA = "0x18074E0D0")]
			get
			{
				return default(FLOHMNBNIPC);
			}
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x49BEBB0", Offset = "0x49BDFB0", VA = "0x1849BEBB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x49BE530", Offset = "0x49BD930", VA = "0x1849BE530", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x49BEB70", Offset = "0x49BDF70", VA = "0x1849BEB70")]
		public DropdownTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class GraphicTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		[SerializeField]
		[PLDPAHFKOHO(BCMNNOMINIG.Self, false, false, false)]
		private Graphic graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		[SerializeField]
		private bool useGraphicOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		[SerializeField]
		[JLJIECADMGK("useGraphicOverride")]
		private Graphic graphicOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		[SerializeField]
		private OJJELAHPIFL color;

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public Graphic AIBALLAMOFN
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x49C0450", Offset = "0x49BF850", VA = "0x1849C0450")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public OJJELAHPIFL BOCHLFEBLBP
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x702550", Offset = "0x701950", VA = "0x180702550")]
			get
			{
				return default(OJJELAHPIFL);
			}
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x49C0460", Offset = "0x49BF860", VA = "0x1849C0460")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public bool LLDLJGCGKNL
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x950210", Offset = "0x94F610", VA = "0x180950210")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x9509A0", Offset = "0x94FDA0", VA = "0x1809509A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public Color? IAIKFFMDFGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x49C0270", Offset = "0x49BF670", VA = "0x1849C0270")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x49BFEC0", Offset = "0x49BF2C0", VA = "0x1849BFEC0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x6E4110", Offset = "0x6E3510", VA = "0x1806E4110")]
		public GraphicTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class InputFieldTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		[SerializeField]
		[PLDPAHFKOHO(BCMNNOMINIG.Self, false, false, false)]
		private TMP_InputField inputField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		[SerializeField]
		[LNFKCGBKKAE(BCMNNOMINIG.Self, false, false, false)]
		private Image surface;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		[SerializeField]
		private bool useSurfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		[SerializeField]
		[JLJIECADMGK("useSurfaceOverride")]
		private Image surfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		[SerializeField]
		private IHNLJILAFNH inputFieldType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		[SerializeField]
		private FLOHMNBNIPC textSize;

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public Image LLHBLIONNNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x49BEB80", Offset = "0x49BDF80", VA = "0x1849BEB80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public IHNLJILAFNH FLKEEAGFCHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x6D8750", Offset = "0x6D7B50", VA = "0x1806D8750")]
			get
			{
				return default(IHNLJILAFNH);
			}
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x49BEB90", Offset = "0x49BDF90", VA = "0x1849BEB90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public FLOHMNBNIPC KLLNOPGCDOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x74E0D0", Offset = "0x74D4D0", VA = "0x18074E0D0")]
			get
			{
				return default(FLOHMNBNIPC);
			}
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x49BEBB0", Offset = "0x49BDFB0", VA = "0x1849BEBB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x49C04E0", Offset = "0x49BF8E0", VA = "0x1849C04E0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x49BEB70", Offset = "0x49BDF70", VA = "0x1849BEB70")]
		public InputFieldTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class LabelTheme : GraphicTheme
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		[SerializeField]
		[PLDPAHFKOHO(BCMNNOMINIG.Self, false, false, false)]
		private TextMeshProUGUI textMeshProUGUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		[SerializeField]
		private BBJOHPGAODO textType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		[SerializeField]
		private FLOHMNBNIPC textSize;

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public BBJOHPGAODO PGFKKJPMIPF
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x77D680", Offset = "0x77CA80", VA = "0x18077D680")]
			get
			{
				return default(BBJOHPGAODO);
			}
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x49C0D20", Offset = "0x49C0120", VA = "0x1849C0D20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public FLOHMNBNIPC KLLNOPGCDOA
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x77D630", Offset = "0x77CA30", VA = "0x18077D630")]
			get
			{
				return default(FLOHMNBNIPC);
			}
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x49C0D00", Offset = "0x49C0100", VA = "0x1849C0D00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x49C09C0", Offset = "0x49BFDC0", VA = "0x1849C09C0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x49C0CF0", Offset = "0x49C00F0", VA = "0x1849C0CF0")]
		public LabelTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public class MakerPenToolTheme : ButtonThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		[SerializeField]
		[Header("Maker Pen Tool")]
		private NKMELIIFMBO makerPenToolPaletteType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		[SerializeField]
		[Tooltip("A list of objects to show while the maker pen tool is active.")]
		private List<Hideable> hideWhenNotActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		[SerializeField]
		[Tooltip("A list of objects to show while the maker pen tool is inactive")]
		private List<Hideable> hideWhenActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		[SerializeField]
		private bool editorIsActiveOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x121")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		protected bool NIHBLDMDPJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x122")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private bool HJHEPEKODIE;

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public NKMELIIFMBO GDKEAPLGIMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x9DF3A0", Offset = "0x9DE7A0", VA = "0x1809DF3A0")]
			get
			{
				return default(NKMELIIFMBO);
			}
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x49BD7F0", Offset = "0x49BCBF0", VA = "0x1849BD7F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public bool ALLLILMAHLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x2005E20", Offset = "0x2005220", VA = "0x182005E20")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x49C1140", Offset = "0x49C0540", VA = "0x1849C1140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x49C1100", Offset = "0x49C0500", VA = "0x1849C1100", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x49C0D40", Offset = "0x49C0140", VA = "0x1849C0D40", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x49BD7E0", Offset = "0x49BCBE0", VA = "0x1849BD7E0")]
		public MakerPenToolTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class MixedToggleTheme : ButtonThemeBase
	{
		[Cpp2IlInjected.Token(Token = "0x2000060")]
		public enum EMANODPKCPC
		{
			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			Inactive,
			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			Mixed,
			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			Active
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		[SerializeField]
		private DMAPCKGJOEN toggleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		[SerializeField]
		[Tooltip("A list of objects to hide while the toggle is inactive.")]
		private List<Hideable> hideWhenInactive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		[SerializeField]
		[Tooltip("A list of objects to hide while the toggle is mixed.")]
		private List<Hideable> hideWhenMixed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		[SerializeField]
		[Tooltip("A list of objects to hide while the toggle is active")]
		private List<Hideable> hideWhenActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		[SerializeField]
		private EMANODPKCPC editorIsActiveOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private EMANODPKCPC HJHEPEKODIE;

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public EMANODPKCPC ALLLILMAHLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x16C4280", Offset = "0x16C3680", VA = "0x1816C4280")]
			get
			{
				return default(EMANODPKCPC);
			}
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x49C19C0", Offset = "0x49C0DC0", VA = "0x1849C19C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x49C19E0", Offset = "0x49C0DE0", VA = "0x1849C19E0")]
		public void Toggle()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x49C19C0", Offset = "0x49C0DC0", VA = "0x1849C19C0")]
		public void Toggle(EMANODPKCPC HJHEPEKODIE, bool NIHBLDMDPJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x49C1440", Offset = "0x49C0840", VA = "0x1849C1440", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x49BD7E0", Offset = "0x49BCBE0", VA = "0x1849BD7E0")]
		public MixedToggleTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public class PaletteTheme : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		[SerializeField]
		private bool usePaletteOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		[SerializeField]
		[JLJIECADMGK("usePaletteOverride")]
		private Palette paletteOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public CBKLEJNNKJH PaletteChangeEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		[SerializeField]
		private bool useDepth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private float? DKILLHIGDGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private float? CKAPCKMILMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private float BEELBHCPEFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private float IJHFHGABDNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private float AMCLPAOCJCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private float CEGMCDEEHKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private readonly JMMOMAJEGFM CKNAHJHBCMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private SFXAudioSource LJEKBNIFIIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private SFXAudioSource BLNKIKHLJNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private ContentLoadingAudioPaletteAsset FAAIJKPLIIM;

		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private const float DFFKGKEMPBK = 0.001f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private ENPJOLHINEC JNJDJCIOJMH;

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public Palette ICFEJMNOBHF
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x49C3D10", Offset = "0x49C3110", VA = "0x1849C3D10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public bool JDDFHFFJCMH
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x77F530", Offset = "0x77E930", VA = "0x18077F530")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		private bool OOIOFGHKLMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x49C2C80", Offset = "0x49C2080", VA = "0x1849C2C80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		private bool HKOOLFAAMKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x49C2D10", Offset = "0x49C2110", VA = "0x1849C2D10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x49C2A10", Offset = "0x49C1E10", VA = "0x1849C2A10")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x49C3190", Offset = "0x49C2590", VA = "0x1849C3190")]
		private void LCINFCDHNGA(KHLKHCFEEMF.BKCHICLCPOK NAOLKFBIHGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x49C3400", Offset = "0x49C2800", VA = "0x1849C3400")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x49C2D20", Offset = "0x49C2120", VA = "0x1849C2D20")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x49C3560", Offset = "0x49C2960", VA = "0x1849C3560")]
		private void PBEJOKAAIBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x49C28E0", Offset = "0x49C1CE0", VA = "0x1849C28E0")]
		public void AddLoadingSFXRequest(object AJDBKDIMOHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x49C3B40", Offset = "0x49C2F40", VA = "0x1849C3B40")]
		public void RemoveLoadingSFXRequest(object AJDBKDIMOHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x49C2D20", Offset = "0x49C2120", VA = "0x1849C2D20")]
		private void IIFMNFDGPDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x49C2EB0", Offset = "0x49C22B0", VA = "0x1849C2EB0")]
		private void IMMPELKGHEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x49C32B0", Offset = "0x49C26B0", VA = "0x1849C32B0")]
		private void NNLNBAPOKNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x49C31C0", Offset = "0x49C25C0", VA = "0x1849C31C0")]
		private void NFELMLDFMOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x49C3730", Offset = "0x49C2B30", VA = "0x1849C3730")]
		private void PKICLHCCFFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x49C30A0", Offset = "0x49C24A0", VA = "0x1849C30A0")]
		private void KOMPKEFKFDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x110B8D0", Offset = "0x110ACD0", VA = "0x18110B8D0")]
		private void DGCLPGDNKHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x49C2B90", Offset = "0x49C1F90", VA = "0x1849C2B90")]
		private void FCCILGAILGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x49C2E70", Offset = "0x49C2270", VA = "0x1849C2E70")]
		private void ILJGPAMAEAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x49C39B0", Offset = "0x49C2DB0", VA = "0x1849C39B0")]
		public void Play2DUIFlavorSFX(RecRoomAudioClip[] COGNDOJODPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x49C3C60", Offset = "0x49C3060", VA = "0x1849C3C60")]
		public PaletteTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public abstract class PaletteThemeReference : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		[SerializeField]
		[LNFKCGBKKAE(BCMNNOMINIG.SelfAndParent, true, false, false)]
		private PaletteTheme paletteTheme;

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		protected PaletteTheme PHNPPAOGCID
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		protected Palette ICFEJMNOBHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x49C2220", Offset = "0x49C1620", VA = "0x1849C2220")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		protected bool OGHCFPEFIEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x49C2760", Offset = "0x49C1B60", VA = "0x1849C2760")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		protected Transform NKHLFGEPDMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x49C26D0", Offset = "0x49C1AD0", VA = "0x1849C26D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x49C2110", Offset = "0x49C1510", VA = "0x1849C2110", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x49C27F0", Offset = "0x49C1BF0", VA = "0x1849C27F0", Slot = "5")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void Apply();

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x49C2320", Offset = "0x49C1720", VA = "0x1849C2320")]
		private void FBCEJBFIHAA(bool DGHKPCECHKC = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x6E4110", Offset = "0x6E3510", VA = "0x1806E4110")]
		protected PaletteThemeReference()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public class RangeSliderTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		[SerializeField]
		[PLDPAHFKOHO(BCMNNOMINIG.Self, false, false, false)]
		private RangeSlider slider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		[SerializeField]
		private KPLGJMOLEJP sliderType;

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

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public KPLGJMOLEJP NIDNECCOGCD
		{
			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x6F0AD0", Offset = "0x6EFED0", VA = "0x1806F0AD0")]
			get
			{
				return default(KPLGJMOLEJP);
			}
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x49C4FA0", Offset = "0x49C43A0", VA = "0x1849C4FA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public Image MDPDBGMICLI
		{
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x702560", Offset = "0x701960", VA = "0x180702560")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		public Image ICMGHINLHGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x6E0E70", Offset = "0x6E0270", VA = "0x1806E0E70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		public Image ODMBBILEDPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x6E4150", Offset = "0x6E3550", VA = "0x1806E4150")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		public Image NDJMBLPEEKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x6E79C0", Offset = "0x6E6DC0", VA = "0x1806E79C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		public bool JDEDJJJCNNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x49C4F60", Offset = "0x49C4360", VA = "0x1849C4F60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x49C4F80", Offset = "0x49C4380", VA = "0x1849C4F80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x49C4C20", Offset = "0x49C4020", VA = "0x1849C4C20", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x6E4110", Offset = "0x6E3510", VA = "0x1806E4110")]
		public RangeSliderTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public class RawImageTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		[SerializeField]
		[PLDPAHFKOHO(BCMNNOMINIG.Self, false, false, false)]
		private RawImage image;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		[SerializeField]
		private NKGKCGCOJNG color;

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		public NKGKCGCOJNG ADOGJIAPODE
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x6F0AD0", Offset = "0x6EFED0", VA = "0x1806F0AD0")]
			get
			{
				return default(NKGKCGCOJNG);
			}
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x49C4FA0", Offset = "0x49C43A0", VA = "0x1849C4FA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x49C4FC0", Offset = "0x49C43C0", VA = "0x1849C4FC0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x6E4110", Offset = "0x6E3510", VA = "0x1806E4110")]
		public RawImageTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class RecyclingGridTheme : RecyclingThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		[SerializeField]
		[PLDPAHFKOHO(BCMNNOMINIG.Self, false, false, false)]
		private IEGLAMIDIOP recyclingGrid;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x49C5180", Offset = "0x49C4580", VA = "0x1849C5180", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x49C5390", Offset = "0x49C4790", VA = "0x1849C5390", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x49C5110", Offset = "0x49C4510", VA = "0x1849C5110")]
		private void APJGMBCFKFG(float DBBOMHAAIEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x49C55A0", Offset = "0x49C49A0", VA = "0x1849C55A0")]
		public RecyclingGridTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class RecyclingListTheme : RecyclingThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		[SerializeField]
		[PLDPAHFKOHO(BCMNNOMINIG.Self, false, false, false)]
		private IEGLAMIDIOP recyclingList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private bool NOIKBJADPJL;

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x49C55B0", Offset = "0x49C49B0", VA = "0x1849C55B0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x49C5870", Offset = "0x49C4C70", VA = "0x1849C5870", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x49C5800", Offset = "0x49C4C00", VA = "0x1849C5800")]
		private void FEABBMJEIAD(float DBBOMHAAIEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x49C55A0", Offset = "0x49C49A0", VA = "0x1849C55A0")]
		public RecyclingListTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public abstract class RecyclingThemeBase : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		[SerializeField]
		[Header("Audio")]
		private FLAOGLOGJAK recyclingAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		protected RecyclingAudioPaletteAsset LEOPKGNBDAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		[SerializeField]
		private DKKBMGGHBAD scrollingAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		private ScrollingAudioPaletteAsset KDLJGFDMAIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private ENPJOLHINEC AJAEABFGCDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		private float POBBAPHKANL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private float CJCEJJEMALF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		private float LGFHMFAFBPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private float EIJENHEEEBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private bool MMIBKDLJIIB;

		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private const float OEHLPDIBFFC = 0.01f;

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		private ENPJOLHINEC JNJDJCIOJMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x49C6110", Offset = "0x49C5510", VA = "0x1849C6110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x49C5A90", Offset = "0x49C4E90", VA = "0x1849C5A90", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x49C5C90", Offset = "0x49C5090", VA = "0x1849C5C90")]
		protected void BGPCOPFDNFL(bool AKOEBHLEIMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x49C65A0", Offset = "0x49C59A0", VA = "0x1849C65A0")]
		protected void JDBMGPGCJPL(GameObject KDBGGIOGPDM, int KHJAMGKINLL, bool GJPOPJHNBHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x49C65B0", Offset = "0x49C59B0", VA = "0x1849C65B0")]
		protected void MICLIGEAFEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x49C6280", Offset = "0x49C5680", VA = "0x1849C6280")]
		protected void HIHHIANPDNN(float DBBOMHAAIEL, float JHJCJIGGNOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x49C5F60", Offset = "0x49C5360", VA = "0x1849C5F60")]
		private void CHNMBIJAEKL(float OFBNBEDBPGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x49C6180", Offset = "0x49C5580", VA = "0x1849C6180")]
		private void FHEDDFPBLGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x49C55A0", Offset = "0x49C49A0", VA = "0x1849C55A0")]
		protected RecyclingThemeBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public class ScrollBarTheme : SelectableThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		[SerializeField]
		[Header("Scroll Bar Audio")]
		private NBMDFDBNDCB buttonAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		[SerializeField]
		[Tooltip("Layer a 2D SFX on top of base button sounds")]
		private bool useFlavorSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		[SerializeField]
		[Tooltip("Flavor SFX is picked randomly from this pool config")]
		[JLJIECADMGK("useFlavorSFX")]
		private RecRoomAudioClipPoolConfig flavorSFXClipPoolConfig;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x49C6770", Offset = "0x49C5B70", VA = "0x1849C6770", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x49C6890", Offset = "0x49C5C90", VA = "0x1849C6890")]
		public ScrollBarTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class ScrollRectTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private const string EKIFEMDMLLJ = "RRUI.PlayHittingEndsSFX";

		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		private const int OBMLFAHKGCB = 5;

		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private const int HCKFNCLDKEC = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private DateTimeOffset CBMOANLAHBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private int BEEHBLJDHGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private bool DGHAPGKDLGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		[SerializeField]
		[PLDPAHFKOHO(BCMNNOMINIG.Self, false, false, false)]
		private ScrollRect scrollRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		[SerializeField]
		[Header("Audio")]
		private DKKBMGGHBAD scrollAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		private ScrollingAudioPaletteAsset LEOPKGNBDAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		private ENPJOLHINEC AJAEABFGCDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		private KAMKJOOJPCM BGCICFHGKJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		private float CJCEJJEMALF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		private float LGFHMFAFBPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private float EIJENHEEEBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private bool MMIBKDLJIIB;

		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private const float OEHLPDIBFFC = 0.01f;

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		private ENPJOLHINEC JNJDJCIOJMH
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x49C6DD0", Offset = "0x49C61D0", VA = "0x1849C6DD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		private KAMKJOOJPCM HPFKAEFIJLC
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x49C6D60", Offset = "0x49C6160", VA = "0x1849C6D60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x49C6990", Offset = "0x49C5D90", VA = "0x1849C6990", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x49C80B0", Offset = "0x49C74B0", VA = "0x1849C80B0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x49C68A0", Offset = "0x49C5CA0", VA = "0x1849C68A0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x49C7C30", Offset = "0x49C7030", VA = "0x1849C7C30")]
		private void OODHAGLDBPA(Vector2 DACBJNCMNFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x49C6BB0", Offset = "0x49C5FB0", VA = "0x1849C6BB0")]
		private void CHNMBIJAEKL(float OFBNBEDBPGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x49C6E40", Offset = "0x49C6240", VA = "0x1849C6E40")]
		private void FHEDDFPBLGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x49C7B10", Offset = "0x49C6F10", VA = "0x1849C7B10")]
		private static string KHOIFPFPNFK(GameObject ADHHHFDPAPI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x49C81B0", Offset = "0x49C75B0", VA = "0x1849C81B0")]
		public ScrollRectTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public abstract class SelectableThemeBase : PaletteThemeReference, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IPointerClickHandler, IPointerEnterHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		[SerializeField]
		[Header("Selectable Theme Base")]
		[PLDPAHFKOHO(BCMNNOMINIG.Self, false, false, false)]
		[FormerlySerializedAs("button")]
		private Selectable selectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		[SerializeField]
		[FormerlySerializedAs("overrideAudio")]
		[Tooltip("Override base selectable audio with a single SFX that plays only on click.")]
		[Header("Legacy Audio Override")]
		protected bool overrideWithSingleAudio;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		[SerializeField]
		[JLJIECADMGK("overrideWithSingleAudio")]
		[Tooltip("The legacy override audio will be randomly picked from this pool")]
		protected RecRoomAudioClip[] randomAudioOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		protected bool HGPKPPOKNPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		private ButtonAudioPaletteAsset LEOPKGNBDAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		private RecRoomAudioClipPoolConfig JDEGMIMCOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private ENPJOLHINEC AJAEABFGCDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private CMGIAJGECKJ EJINHBGKFDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private NBOKODDOPAD NKOEKPOBFJE;

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		protected Selectable LDJELHPPNNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x6E4130", Offset = "0x6E3530", VA = "0x1806E4130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		protected virtual bool DEFCMCGBJCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x6F9850", Offset = "0x6F8C50", VA = "0x1806F9850", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public bool JDEDJJJCNNB
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x49C4F60", Offset = "0x49C4360", VA = "0x1849C4F60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x49C4F80", Offset = "0x49C4380", VA = "0x1849C4F80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		private ENPJOLHINEC JNJDJCIOJMH
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x49C8360", Offset = "0x49C7760", VA = "0x1849C8360")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		protected CMGIAJGECKJ PFJNEKGLPOO
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x49C82F0", Offset = "0x49C76F0", VA = "0x1849C82F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		private NBOKODDOPAD GABOGKLECDC
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x49C83D0", Offset = "0x49C77D0", VA = "0x1849C83D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x49C8440", Offset = "0x49C7840", VA = "0x1849C8440")]
		protected void JCDKOLKKNIB(ButtonAudioPaletteAsset FJJMCICEGFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x6E8F10", Offset = "0x6E8310", VA = "0x1806E8F10")]
		protected void FJODJOIAKII(RecRoomAudioClipPoolConfig ELKADLDNEMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x49C8CE0", Offset = "0x49C80E0", VA = "0x1849C8CE0", Slot = "12")]
		public virtual void OnPointerDown(PointerEventData FFEKEOCBAFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x49C8F60", Offset = "0x49C8360", VA = "0x1849C8F60", Slot = "13")]
		public virtual void OnPointerUp(PointerEventData FFEKEOCBAFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x49C8950", Offset = "0x49C7D50", VA = "0x1849C8950", Slot = "14")]
		public virtual void OnPointerClick(PointerEventData FFEKEOCBAFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x49C8E20", Offset = "0x49C8220", VA = "0x1849C8E20", Slot = "15")]
		public virtual void OnPointerEnter(PointerEventData FFEKEOCBAFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x49C8560", Offset = "0x49C7960", VA = "0x1849C8560")]
		private void MKFOCNAAJLP(RecRoomAudioClip[] OGLBHBJCMPA, bool DGCILIHCOCL = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x49C85E0", Offset = "0x49C79E0", VA = "0x1849C85E0")]
		private void NGLBPACAMIC(RecRoomAudioClip JKHIECLOPDN, bool DGCILIHCOCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x49C6890", Offset = "0x49C5C90", VA = "0x1849C6890")]
		protected SelectableThemeBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public class SliderTheme : SelectableThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		[SerializeField]
		[Header("Slider Visual")]
		[PLDPAHFKOHO(BCMNNOMINIG.Self, false, false, false)]
		private Slider slider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		[SerializeField]
		private KPLGJMOLEJP sliderType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		[SerializeField]
		[Header("Slider Audio")]
		private NBMDFDBNDCB buttonAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		[SerializeField]
		[Tooltip("Layer a 2D SFX on top of base button sounds")]
		private bool useFlavorSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		[SerializeField]
		[JLJIECADMGK("useFlavorSFX")]
		[Tooltip("Flavor SFX is picked randomly from this pool config")]
		private RecRoomAudioClipPoolConfig flavorSFXClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		[SerializeField]
		private Image sliderImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		[SerializeField]
		private Image fillImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		[SerializeField]
		private Image handleImage;

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public KPLGJMOLEJP NIDNECCOGCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0xB679F0", Offset = "0xB66DF0", VA = "0x180B679F0")]
			get
			{
				return default(KPLGJMOLEJP);
			}
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x49C9590", Offset = "0x49C8990", VA = "0x1849C9590")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public Image MDPDBGMICLI
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x757C60", Offset = "0x757060", VA = "0x180757C60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public Image ICMGHINLHGD
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x786230", Offset = "0x785630", VA = "0x180786230")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		public Image AGCKHGGFIKJ
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x6F71B0", Offset = "0x6F65B0", VA = "0x1806F71B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x49C9190", Offset = "0x49C8590", VA = "0x1849C9190", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x49C9570", Offset = "0x49C8970", VA = "0x1849C9570")]
		public SliderTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class SurfaceTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		[SerializeField]
		[PLDPAHFKOHO(BCMNNOMINIG.Self, false, false, false)]
		private Image image;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		[SerializeField]
		[LNFKCGBKKAE(BCMNNOMINIG.Self, false, false, false)]
		private UIGradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		[SerializeField]
		private OKABPFHFIDP color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		[SerializeField]
		[JLJIECADMGK("gradient")]
		private bool ignoreGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		[SerializeField]
		[Tooltip("The surface theme determines if this Image is a RaycastTarget or not. There are times when you might want to ignore that setting of the palette theme and just respect whatever is the default state on the Image.")]
		private bool ignoreSettingRaycastTarget;

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public OKABPFHFIDP PIDKBDMACFP
		{
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x77F5B0", Offset = "0x77E9B0", VA = "0x18077F5B0")]
			get
			{
				return default(OKABPFHFIDP);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x49C9820", Offset = "0x49C8C20", VA = "0x1849C9820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x49C95B0", Offset = "0x49C89B0", VA = "0x1849C95B0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x6E4110", Offset = "0x6E3510", VA = "0x1806E4110")]
		public SurfaceTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class SwitchTheme : ToggleTheme
	{
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		private const float FNJFALFFKJO = 0.33f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		[SerializeField]
		[Header("Switch")]
		private GameObject indicator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		[SerializeField]
		private GameObject indicatorOffPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		[SerializeField]
		private GameObject indicatorOnPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		private MIGBDLGBGMG FCENPPACGGK;

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x49C9840", Offset = "0x49C8C40", VA = "0x1849C9840", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x49C9AC0", Offset = "0x49C8EC0", VA = "0x1849C9AC0")]
		public SwitchTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public class TilerTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		[SerializeField]
		[PLDPAHFKOHO(BCMNNOMINIG.Self, false, false, false)]
		private UITiler tiler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		[SerializeField]
		private ADGKCNKILKC type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		private EOBMKHKHMNH JBCFLEKPPDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		private HIOCKKGKHNL BLLKFMCEEHP;

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		private HIOCKKGKHNL DLNKALPDGDN
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x49CA530", Offset = "0x49C9930", VA = "0x1849CA530")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		private DIBIMNIJNHH PPJGGKKGCDP
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x49CA450", Offset = "0x49C9850", VA = "0x1849CA450")]
			get
			{
				return default(DIBIMNIJNHH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x49CA3E0", Offset = "0x49C97E0", VA = "0x1849CA3E0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x49CA040", Offset = "0x49C9440", VA = "0x1849CA040", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x6E4110", Offset = "0x6E3510", VA = "0x1806E4110")]
		public TilerTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public class ToggleTheme : ButtonThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		[SerializeField]
		[Header("Toggle Visual")]
		private IONDLPNIODD toggleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		[SerializeField]
		[Tooltip("A list of objects to show while the toggle is active.")]
		private List<Hideable> hideWhenNotActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		[SerializeField]
		[Tooltip("A list of objects to show while the toggle is inactive")]
		private List<Hideable> hideWhenActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		[SerializeField]
		private bool editorIsActiveOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x121")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		[SerializeField]
		[Header("Toggle Audio")]
		[Tooltip("Override the audio palette when active defined by the toggle's visual with a custom palette")]
		private bool overrideAudioPaletteWhenActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		[SerializeField]
		[Tooltip("Specify a custom config to use for toggle button audio when active")]
		[JLJIECADMGK("overrideAudioPaletteWhenActive")]
		private ButtonAudioPaletteAsset customButtonAudioConfigWhenActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		[SerializeField]
		[Tooltip("Override the audio palette when inactive defined by the toggle's visual with a custom palette")]
		private bool overrideAudioPaletteWhenInactive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		[SerializeField]
		[JLJIECADMGK("overrideAudioPaletteWhenInactive")]
		[Tooltip("Specify a custom config to use for toggle button audio when inactive")]
		private ButtonAudioPaletteAsset customButtonAudioConfigWhenInactive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		[SerializeField]
		[Tooltip("Layer a 2D SFX on top of base button sounds. Flavor SFX only plays when toggling from inactive to active")]
		private bool useFlavorSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		[SerializeField]
		[JLJIECADMGK("useFlavorSFX")]
		[Tooltip("Flavor SFX is picked randomly from this pool config")]
		private RecRoomAudioClipPoolConfig flavorSFXClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		protected bool NIHBLDMDPJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x151")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private bool LBIBOPHNBGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x152")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private bool HJHEPEKODIE;

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		public bool ALLLILMAHLP
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x49CAA10", Offset = "0x49C9E10", VA = "0x1849CAA10")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x49CAA20", Offset = "0x49C9E20", VA = "0x1849CAA20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public IONDLPNIODD PEIGNPAKAEA
		{
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x9DF3A0", Offset = "0x9DE7A0", VA = "0x1809DF3A0")]
			get
			{
				return default(IONDLPNIODD);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x49BD7F0", Offset = "0x49BCBF0", VA = "0x1849BD7F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		protected override bool DEFCMCGBJCM
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x49CA980", Offset = "0x49C9D80", VA = "0x1849CA980", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x49CA940", Offset = "0x49C9D40", VA = "0x1849CA940", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x49CA990", Offset = "0x49C9D90", VA = "0x1849CA990")]
		public void Toggle()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x49CA9D0", Offset = "0x49C9DD0", VA = "0x1849CA9D0")]
		public void Toggle(bool HJHEPEKODIE, bool NIHBLDMDPJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x49CA5A0", Offset = "0x49C99A0", VA = "0x1849CA5A0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x49C9AC0", Offset = "0x49C8EC0", VA = "0x1849C9AC0")]
		public ToggleTheme()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class EGIIOKJKKGL
{
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	private static byte[] LAFDEEMEPDM;

	[Cpp2IlInjected.Token(Token = "0x400020F")]
	private static int AHBPGGLKEKP;

	[Cpp2IlInjected.Token(Token = "0x4000210")]
	private static int MAHPDNGMMFO;

	[Cpp2IlInjected.Token(Token = "0x4000211")]
	private static BigInteger NMOJFJKJLEG;

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public EGIIOKJKKGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x49BEBD0", Offset = "0x49BDFD0", VA = "0x1849BEBD0")]
	private static string CIEKLEOAFAL(byte[] GPHMIGDKMEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x49BECE0", Offset = "0x49BE0E0", VA = "0x1849BECE0")]
	public static string NOFFLEGCGLA(byte[] NPNCGJAPKIL, bool FBFFLNHILGA)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000212")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
	{
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
