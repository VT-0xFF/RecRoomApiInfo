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
		private sealed class JFEKPMDHICO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public TMP_FontAsset font;

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
			public JFEKPMDHICO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x45BB8E0", Offset = "0x45BA0E0", VA = "0x1845BB8E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x45BA980", Offset = "0x45B9180", VA = "0x1845BA980")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public TMP_SpriteAsset EmojiAsset
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x6D6120", Offset = "0x6D4920", VA = "0x1806D6120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x45BA840", Offset = "0x45B9040", VA = "0x1845BA840")]
		public bool JLGDPPGHPKP(TMP_FontAsset MGCALOIHCGN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x45BA320", Offset = "0x45B8B20", VA = "0x1845BA320")]
		public TMP_FontAsset DOKCPMHHFGF(TMP_FontAsset MGCALOIHCGN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x45BA120", Offset = "0x45B8920", VA = "0x1845BA120")]
		public TMP_FontAsset DOKCPMHHFGF(TMP_FontAsset MGCALOIHCGN, Material LKAAKKCLGIL, out Material PHCOKJEOIBC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x45BA430", Offset = "0x45B8C30", VA = "0x1845BA430")]
		public TMP_FontAsset HDDBFCGCDDO(TMP_FontAsset MGCALOIHCGN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x45BA540", Offset = "0x45B8D40", VA = "0x1845BA540")]
		public TMP_FontAsset HDDBFCGCDDO(TMP_FontAsset MGCALOIHCGN, Material LKAAKKCLGIL, out Material NHKDAGMNONM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x45BA780", Offset = "0x45B8F80", VA = "0x1845BA780")]
		private static bool HDHCOEGNDPN(TMP_FontAsset MGCALOIHCGN, LocalizedFontMapping CBDOPKFJHCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xE21530", Offset = "0xE1FD30", VA = "0x180E21530")]
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
			[Cpp2IlInjected.Address(RVA = "0x45C5580", Offset = "0x45C3D80", VA = "0x1845C5580")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Palette Active
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x45C5510", Offset = "0x45C3D10", VA = "0x1845C5510")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xE21530", Offset = "0xE1FD30", VA = "0x180E21530")]
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
		[Cpp2IlInjected.Address(RVA = "0x45BAAF0", Offset = "0x45B92F0", VA = "0x1845BAAF0", Slot = "0")]
		public override bool Equals(object BFHAMCLNCKB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x45BABF0", Offset = "0x45B93F0", VA = "0x1845BABF0", Slot = "4")]
		public bool Equals(GradientBlock HAKPJJGEGOM)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x45BAC70", Offset = "0x45B9470", VA = "0x1845BAC70")]
		public static bool GLPMECKCBFF(GradientBlock LDHBNEKNMNN, GradientBlock GFAKIAABJHE)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x45BAD60", Offset = "0x45B9560", VA = "0x1845BAD60")]
		public static bool PKJGEKBKGNO(GradientBlock LDHBNEKNMNN, GradientBlock GFAKIAABJHE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x45BACF0", Offset = "0x45B94F0", VA = "0x1845BACF0", Slot = "2")]
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
		public List<Graphic> FKLPNBMEAAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8064D0", Offset = "0x804CD0", VA = "0x1808064D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x806670", Offset = "0x804E70", VA = "0x180806670")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public ColorBlock OMOGJLMPKCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x45BCF80", Offset = "0x45BB780", VA = "0x1845BCF80")]
			get
			{
				return default(ColorBlock);
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x45BD000", Offset = "0x45BB800", VA = "0x1845BD000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public UIGradient FIBLILHMNNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xCCA0F0", Offset = "0xCC88F0", VA = "0x180CCA0F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x15DACC0", Offset = "0x15D94C0", VA = "0x1815DACC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public GradientBlock NFHIGPMODIA
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x45BCFD0", Offset = "0x45BB7D0", VA = "0x1845BCFD0")]
			get
			{
				return default(GradientBlock);
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x45BD050", Offset = "0x45BB850", VA = "0x1845BD050")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x45BCDD0", Offset = "0x45BB5D0", VA = "0x1845BCDD0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x45BCE20", Offset = "0x45BB620", VA = "0x1845BCE20", Slot = "36")]
		public override void OnSelect(BaseEventData HIGIGMBKOED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x45BCE70", Offset = "0x45BB670", VA = "0x1845BCE70")]
		public void Refresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x45BCB70", Offset = "0x45BB370", VA = "0x1845BCB70", Slot = "26")]
		protected override void DoStateTransition(SelectionState DMJFIAAGODA, bool EKBFPAOPCDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x45BC9A0", Offset = "0x45BB1A0", VA = "0x1845BC9A0")]
		private void APKKAHNJNEP(Graphic DHHPBJCMFBC, Color ONGHKDBLLMP, bool EKBFPAOPCDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x45BCA70", Offset = "0x45BB270", VA = "0x1845BCA70")]
		private void APPMLCIOHKD(SelectionState DMJFIAAGODA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x45BCEA0", Offset = "0x45BB6A0", VA = "0x1845BCEA0")]
		public MultiGraphicButton()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum HIHAJMOAMBC
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
public enum NJKPLLHGLDB
{
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Default
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public enum LCEKBEIKKGO
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	Default
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum ONOJGABCLLK
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	Default
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum HOHNCCDEKJF
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
public enum BGNNMCBLBNL
{
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	A
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public enum HLDDLMDDHKG
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
public enum KOMKEHPPABH
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
public enum MONHOPEJCME
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
public enum JGEIHLPPBJJ
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
public enum MBLHLMMJHNG
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
public enum JJIAJLMDHKF
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
	MainNavVrDetach,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	HomeMainNav
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum LOOHBNOLNKH
{
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	Checkbox
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum OJEBAEBKFOE
{
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	Create,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	Select,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	Wire,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	Configure,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	Transform,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	Move,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	Rotate,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	Scale,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	CloneFlip,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	Recolor,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	Freeze,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	MakeInvention,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	Manipulate,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	Delete
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum JACJBJMDGDD
{
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	LightFlat,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	DarkFlat,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	Modified
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public enum EOECEJMDMLK
{
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	LightFlat,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	DarkFlat
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum ACHCLNKCPPF
{
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	MirroUIPopUp
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum KKNNMPIEDAL
{
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	Base,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	Button,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	Navigation,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	Overlay,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	Dialog,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	Toast
}
namespace RRUI.Theme
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class AudioPalette : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public class ButtonAudioPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			[SerializeField]
			private HIHAJMOAMBC buttonAudioPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			[SerializeField]
			private ButtonAudioPaletteAsset buttonAudioPaletteConfig;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public HIHAJMOAMBC ButtonAudioPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x6D5040", Offset = "0x6D3840", VA = "0x1806D5040")]
				get
				{
					return default(HIHAJMOAMBC);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public ButtonAudioPaletteAsset ButtonAudioPaletteConfig
			{
				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
			public ButtonAudioPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public class ScrollingAudioPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			[SerializeField]
			private NJKPLLHGLDB scrollingAudioPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			[SerializeField]
			private ScrollingAudioPaletteAsset scrollingAudioPaletteConfig;

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public NJKPLLHGLDB ScrollingAudioPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0x6D5040", Offset = "0x6D3840", VA = "0x1806D5040")]
				get
				{
					return default(NJKPLLHGLDB);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public ScrollingAudioPaletteAsset ScrollingAudioPaletteConfig
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
			public ScrollingAudioPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public class ContentLoadingAudioPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			[SerializeField]
			private LCEKBEIKKGO contentLoadingAudioPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			[SerializeField]
			private ContentLoadingAudioPaletteAsset contentLoadingAudioPaletteConfig;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public LCEKBEIKKGO ContentLoadingAudioPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x6D5040", Offset = "0x6D3840", VA = "0x1806D5040")]
				get
				{
					return default(LCEKBEIKKGO);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public ContentLoadingAudioPaletteAsset ContentLoadingAudioPaletteConfig
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
			public ContentLoadingAudioPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public class RecyclingAudioPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			[SerializeField]
			private ONOJGABCLLK recyclingAudioPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			[SerializeField]
			private RecyclingAudioPaletteAsset recyclingAudioPaletteConfig;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public ONOJGABCLLK RecyclingAudioPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x6D5040", Offset = "0x6D3840", VA = "0x1806D5040")]
				get
				{
					return default(ONOJGABCLLK);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public RecyclingAudioPaletteAsset RecyclingAudioPaletteConfig
			{
				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
			public RecyclingAudioPaletteItem()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class EDJMIEMFEJF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public HIHAJMOAMBC buttonAudioPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
			public EDJMIEMFEJF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xC284F0", Offset = "0xC26CF0", VA = "0x180C284F0")]
			internal bool <GetButtonAudioPalette>b__0(ButtonAudioPaletteItem buttonAudioPalette)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[CompilerGenerated]
		private sealed class FCLDNMNMBKO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public NJKPLLHGLDB scrollingAudioPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
			public FCLDNMNMBKO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xC284F0", Offset = "0xC26CF0", VA = "0x180C284F0")]
			internal bool <GetScrollingAudioPaletteConfig>b__0(ScrollingAudioPaletteItem scrollingAudioPalette)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class OEOJOOOHKKB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public LCEKBEIKKGO contentLoadingAudioPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
			public OEOJOOOHKKB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xC284F0", Offset = "0xC26CF0", VA = "0x180C284F0")]
			internal bool <GetContentLoadingAudioPaletteConfig>b__0(ContentLoadingAudioPaletteItem contentLoadingAudioPalette)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private sealed class HAMBCAJCKOP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public ONOJGABCLLK recyclingAudioPaletteType;

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
			public HAMBCAJCKOP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xC284F0", Offset = "0xC26CF0", VA = "0x180C284F0")]
			internal bool <GetRecyclingAudioPaletteConfig>b__0(RecyclingAudioPaletteItem recyclingAudioPalette)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		[SerializeField]
		[EJKGPJLGKFD("ButtonAudioPaletteType")]
		private ButtonAudioPaletteItem[] buttonAudioPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		[SerializeField]
		[EJKGPJLGKFD("ScrollingAudioPaletteType")]
		private ScrollingAudioPaletteItem[] scrollingAudioPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		[SerializeField]
		[EJKGPJLGKFD("ContentLoadingAudioPaletteType")]
		private ContentLoadingAudioPaletteItem[] contentLoadingAudioPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		[SerializeField]
		[EJKGPJLGKFD("RecyclingAudioPaletteType")]
		private RecyclingAudioPaletteItem[] recyclingAudioPalettes;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x45B6B50", Offset = "0x45B5350", VA = "0x1845B6B50")]
		public ButtonAudioPaletteAsset FHGAHLEKFKN(HIHAJMOAMBC GAEKDNIHDOP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x45B6C40", Offset = "0x45B5440", VA = "0x1845B6C40")]
		public ScrollingAudioPaletteAsset JCILOFHGHIK(NJKPLLHGLDB NIDMFIPMCDG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x45B6D30", Offset = "0x45B5530", VA = "0x1845B6D30")]
		public ContentLoadingAudioPaletteAsset LJOLANBHBIH(LCEKBEIKKGO EMHKABHFBHM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x45B6E20", Offset = "0x45B5620", VA = "0x1845B6E20")]
		public RecyclingAudioPaletteAsset MBBCFIBHNKN(ONOJGABCLLK KNCEFOPDCCL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xE21530", Offset = "0xE1FD30", VA = "0x180E21530")]
		public AudioPalette()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class BaseAudioPaletteAsset : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x45B6F90", Offset = "0x45B5790", VA = "0x1845B6F90")]
		protected bool POLCEJOIOLE(RecRoomAudioClipPoolConfig OIELPGNNMJC, out RecRoomAudioClip[] PJLPJOAIFNA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xE21530", Offset = "0xE1FD30", VA = "0x180E21530")]
		public BaseAudioPaletteAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class ButtonAnimationPalette : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		[SerializeField]
		private float clickAnimationDuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		[SerializeField]
		private float clickAnimationScale;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public float ClickAnimationDuration
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x118F400", Offset = "0x118DC00", VA = "0x18118F400")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public float ClickAnimationScale
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x1145040", Offset = "0x1143840", VA = "0x181145040")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x45B7040", Offset = "0x45B5840", VA = "0x1845B7040")]
		public ButtonAnimationPalette()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class ButtonAudioPaletteAsset : BaseAudioPaletteAsset
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		[SerializeField]
		private RecRoomAudioClipPoolConfig pointerDownAudioClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		[SerializeField]
		private RecRoomAudioClipPoolConfig pointerUpAudioClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		[SerializeField]
		private RecRoomAudioClipPoolConfig pointerClickAudioClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		[SerializeField]
		private RecRoomAudioClipPoolConfig pointerEnterAudioClipPoolConfig;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public RecRoomAudioClip[] PointerDownAudioClipPool
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x45B70F0", Offset = "0x45B58F0", VA = "0x1845B70F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public RecRoomAudioClip[] PointerUpAudioClipPool
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x45B7210", Offset = "0x45B5A10", VA = "0x1845B7210")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public RecRoomAudioClip[] PointerClickAudioClipPool
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x45B7060", Offset = "0x45B5860", VA = "0x1845B7060")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public RecRoomAudioClip[] PointerEnterAudioClipPool
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x45B7180", Offset = "0x45B5980", VA = "0x1845B7180")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xE21530", Offset = "0xE1FD30", VA = "0x180E21530")]
		public ButtonAudioPaletteAsset()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class ButtonPalette
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		[SerializeField]
		[Header("Background")]
		private Color backgroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		[SerializeField]
		[FormerlySerializedAs("colorBlock")]
		private ColorBlock backgroundTints;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		[SerializeField]
		private GradientBlock backgroundGradients;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		[SerializeField]
		[Header("Foreground")]
		private Color foregroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		[SerializeField]
		private ColorBlock foregroundTints;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		[SerializeField]
		[Header("Border")]
		private bool showBorder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		[SerializeField]
		[Header("Text")]
		private TextStylePalette textPalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		[SerializeField]
		[Header("Audio")]
		private HIHAJMOAMBC audioPalette;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Color BackgroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xCDB3C0", Offset = "0xCD9BC0", VA = "0x180CDB3C0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public ColorBlock BackgroundTints
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x45B73B0", Offset = "0x45B5BB0", VA = "0x1845B73B0")]
			get
			{
				return default(ColorBlock);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public GradientBlock BackgroundGradients
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x45B7380", Offset = "0x45B5B80", VA = "0x1845B7380")]
			get
			{
				return default(GradientBlock);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Color ForegroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x1CF09F0", Offset = "0x1CEF1F0", VA = "0x181CF09F0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ColorBlock ForegroundTints
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x45B73F0", Offset = "0x45B5BF0", VA = "0x1845B73F0")]
			get
			{
				return default(ColorBlock);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool ShowBorder
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x10C9BE0", Offset = "0x10C83E0", VA = "0x1810C9BE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public TextStylePalette TextPalette
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8064D0", Offset = "0x804CD0", VA = "0x1808064D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public HIHAJMOAMBC AudioPalette
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x12DD860", Offset = "0x12DC060", VA = "0x1812DD860")]
			get
			{
				return default(HIHAJMOAMBC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x45B72A0", Offset = "0x45B5AA0", VA = "0x1845B72A0")]
		public ButtonPalette()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class ContentLoadingAudioPaletteAsset : BaseAudioPaletteAsset
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		[SerializeField]
		[Header("Clip Configs")]
		private RecRoomAudioClipPoolConfig loadingSFXAudioClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[SerializeField]
		[Header("Thresholds")]
		[Tooltip("Only start looping loading SFX if any content has been loading for this much time")]
		private float loadingSFXStartDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		[SerializeField]
		[Tooltip("Small delay between content finish loading and stopping loading SFX. Avoiding quick stop and replay if contents load back to back.")]
		private float loadingSFXStopDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		[SerializeField]
		[Tooltip("Cut loading SFX if content is still loading after this much time. Avoid sustaining SFX when content is hanging on loading.")]
		private float maxLoadingSFXLength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		[SerializeField]
		[Header("Smooth Fade")]
		private float fadeInDuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		[SerializeField]
		private float fadeOutDuration;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float LoadingSFXStartDelay
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x1296770", Offset = "0x1294F70", VA = "0x181296770")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float LoadingSFXStopDelay
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x121B0D0", Offset = "0x12198D0", VA = "0x18121B0D0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float MaxLoadingSFXLength
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x139CAA0", Offset = "0x139B2A0", VA = "0x18139CAA0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float FadeInDuration
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x10D0450", Offset = "0x10CEC50", VA = "0x1810D0450")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public float FadeOutDuration
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x108B180", Offset = "0x1089980", VA = "0x18108B180")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x45B8D60", Offset = "0x45B7560", VA = "0x1845B8D60")]
		public bool HMECNKGPDKK(out RecRoomAudioClip[] PJLPJOAIFNA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x45B8E10", Offset = "0x45B7610", VA = "0x1845B8E10")]
		public ContentLoadingAudioPaletteAsset()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class DepthPalette
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		[SerializeField]
		private float depth;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float Depth
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xDD98A0", Offset = "0xDD80A0", VA = "0x180DD98A0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public DepthPalette()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class DropdownPalette
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		[SerializeField]
		private Color backgroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		[SerializeField]
		private Color foregroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		[SerializeField]
		private TextStylePalette textPalette;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Color BackgroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xCDB3C0", Offset = "0xCD9BC0", VA = "0x180CDB3C0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Color ForegroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xC06C00", Offset = "0xC05400", VA = "0x180C06C00")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public TextStylePalette TextPalette
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x6EB6F0", Offset = "0x6E9EF0", VA = "0x1806EB6F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x45B9A40", Offset = "0x45B8240", VA = "0x1845B9A40")]
		public DropdownPalette()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class InputFieldPalette
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		[SerializeField]
		private Color backgroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		[SerializeField]
		private Color foregroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		[SerializeField]
		private Color placeholderColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		[SerializeField]
		private TextStylePalette textPalette;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Color BackgroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xCDB3C0", Offset = "0xCD9BC0", VA = "0x180CDB3C0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Color ForegroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xC06C00", Offset = "0xC05400", VA = "0x180C06C00")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Color PlaceholderColor
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xE995E0", Offset = "0xE97DE0", VA = "0x180E995E0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public TextStylePalette TextPalette
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x6DC580", Offset = "0x6DAD80", VA = "0x1806DC580")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x45BB3A0", Offset = "0x45B9BA0", VA = "0x1845BB3A0")]
		public InputFieldPalette()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class MakerPenToolPalette
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		[SerializeField]
		private ButtonPalette buttonPalette;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public ButtonPalette ButtonPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x6D6AC0", Offset = "0x6D52C0", VA = "0x1806D6AC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public MakerPenToolPalette()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class MenuAudioPaletteAsset : BaseAudioPaletteAsset
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		[SerializeField]
		[Header("Menu Open")]
		private RecRoomAudioClipPoolConfig menuHydrateAudioClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		[SerializeField]
		private RecRoomAudioClipPoolConfig menuOpen2DFlavorAudioClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		[SerializeField]
		[Header("Menu Close")]
		private RecRoomAudioClipPoolConfig menuDehydrateAudioClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		[SerializeField]
		private RecRoomAudioClipPoolConfig menuClose2DFlavorAudioClipPoolConfig;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public RecRoomAudioClip[] MenuHydrateAudioClipPool
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x45BC210", Offset = "0x45BAA10", VA = "0x1845BC210")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public RecRoomAudioClip[] MenuOpen2DFlavorAudioClipPool
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x45BC2A0", Offset = "0x45BAAA0", VA = "0x1845BC2A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public RecRoomAudioClip[] MenuDehydrateAudioClipPool
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x45BC180", Offset = "0x45BA980", VA = "0x1845BC180")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public RecRoomAudioClip[] MenuClose2DFlavorAudioClipPool
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x45BC0F0", Offset = "0x45BA8F0", VA = "0x1845BC0F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xE21530", Offset = "0xE1FD30", VA = "0x180E21530")]
		public MenuAudioPaletteAsset()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class MixedTogglePalette
	{
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		private enum MAAKKJAIBKL
		{
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			UseBaseInactive,
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			UseBaseActive,
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			UseCustom
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		[SerializeField]
		private JJIAJLMDHKF baseTogglePalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		[SerializeField]
		private MAAKKJAIBKL mixedPaletteType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		[SerializeField]
		[CPILAAFLPDK("mixedPaletteType", 2)]
		private ButtonPalette mixedButtonPalette;

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x45BC330", Offset = "0x45BAB30", VA = "0x1845BC330")]
		public TogglePalette NCJJFNGCICO(Palette ACEAIPODBCB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x45BC360", Offset = "0x45BAB60", VA = "0x1845BC360")]
		public ButtonPalette NLEGNFLKAEN(Palette ACEAIPODBCB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public MixedTogglePalette()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class Palette : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		public class RawImageColorPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			[SerializeField]
			private BGNNMCBLBNL paletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			[SerializeField]
			private Color color;

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public BGNNMCBLBNL RawImageColorPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600007D")]
				[Cpp2IlInjected.Address(RVA = "0x6D5040", Offset = "0x6D3840", VA = "0x1806D5040")]
				get
				{
					return default(BGNNMCBLBNL);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public Color Color
			{
				[Cpp2IlInjected.Token(Token = "0x600007E")]
				[Cpp2IlInjected.Address(RVA = "0xFCF9A0", Offset = "0xFCE1A0", VA = "0x180FCF9A0")]
				get
				{
					return default(Color);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x14D6430", Offset = "0x14D4C30", VA = "0x1814D6430")]
			public RawImageColorPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public class BackgroundColorPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000109")]
			[SerializeField]
			private HOHNCCDEKJF backgroundColorPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			[SerializeField]
			private Color color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400010B")]
			[SerializeField]
			private Gradient gradient;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			[SerializeField]
			private bool raycastTarget;

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public HOHNCCDEKJF BackgroundColorPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000080")]
				[Cpp2IlInjected.Address(RVA = "0x6D5040", Offset = "0x6D3840", VA = "0x1806D5040")]
				get
				{
					return default(HOHNCCDEKJF);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public Color Color
			{
				[Cpp2IlInjected.Token(Token = "0x6000081")]
				[Cpp2IlInjected.Address(RVA = "0xFCF9A0", Offset = "0xFCE1A0", VA = "0x180FCF9A0")]
				get
				{
					return default(Color);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public Gradient Gradient
			{
				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0x6EF8E0", Offset = "0x6EE0E0", VA = "0x1806EF8E0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public bool RaycastTarget
			{
				[Cpp2IlInjected.Token(Token = "0x6000083")]
				[Cpp2IlInjected.Address(RVA = "0x6D5030", Offset = "0x6D3830", VA = "0x1806D5030")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x45B6F10", Offset = "0x45B5710", VA = "0x1845B6F10")]
			public BackgroundColorPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		public class ForegroundColorPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			[SerializeField]
			private HLDDLMDDHKG foregroundColorPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400010E")]
			[SerializeField]
			private Color color;

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public HLDDLMDDHKG ForegroundColorPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000085")]
				[Cpp2IlInjected.Address(RVA = "0x6D5040", Offset = "0x6D3840", VA = "0x1806D5040")]
				get
				{
					return default(HLDDLMDDHKG);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public Color Color
			{
				[Cpp2IlInjected.Token(Token = "0x6000086")]
				[Cpp2IlInjected.Address(RVA = "0xFCF9A0", Offset = "0xFCE1A0", VA = "0x180FCF9A0")]
				get
				{
					return default(Color);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x45BAAC0", Offset = "0x45B92C0", VA = "0x1845BAAC0")]
			public ForegroundColorPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public class TilerPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400010F")]
			[SerializeField]
			private KOMKEHPPABH tilerPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000110")]
			[SerializeField]
			private TilerPalette tilerPalette;

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public KOMKEHPPABH TilerPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0x6D5040", Offset = "0x6D3840", VA = "0x1806D5040")]
				get
				{
					return default(KOMKEHPPABH);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public TilerPalette TilerPalette
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
			public TilerPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000035")]
		public class TextStylePaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000111")]
			[SerializeField]
			private MONHOPEJCME textStylePaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			[SerializeField]
			private TextStylePalette textStylePalette;

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public MONHOPEJCME TextStylePaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600008B")]
				[Cpp2IlInjected.Address(RVA = "0x6D5040", Offset = "0x6D3840", VA = "0x1806D5040")]
				get
				{
					return default(MONHOPEJCME);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			public TextStylePalette TextStylePalette
			{
				[Cpp2IlInjected.Token(Token = "0x600008C")]
				[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
			public TextStylePaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public class TextSizePaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			[SerializeField]
			private JGEIHLPPBJJ textSizePaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			[SerializeField]
			private int size;

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public JGEIHLPPBJJ TextSizePaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600008E")]
				[Cpp2IlInjected.Address(RVA = "0x6D5040", Offset = "0x6D3840", VA = "0x1806D5040")]
				get
				{
					return default(JGEIHLPPBJJ);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public int Size
			{
				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0x6EB790", Offset = "0x6E9F90", VA = "0x1806EB790")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x10ED980", Offset = "0x10EC180", VA = "0x1810ED980")]
			public TextSizePaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		public class ButtonPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			[SerializeField]
			private MBLHLMMJHNG buttonPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			[SerializeField]
			private ButtonPalette buttonPalette;

			[Cpp2IlInjected.Token(Token = "0x17000042")]
			public MBLHLMMJHNG ButtonPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000091")]
				[Cpp2IlInjected.Address(RVA = "0x6D5040", Offset = "0x6D3840", VA = "0x1806D5040")]
				get
				{
					return default(MBLHLMMJHNG);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			public ButtonPalette ButtonPalette
			{
				[Cpp2IlInjected.Token(Token = "0x6000092")]
				[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
			public ButtonPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public class TogglePaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			[SerializeField]
			private JJIAJLMDHKF togglePaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			[SerializeField]
			private TogglePalette togglePalette;

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			public JJIAJLMDHKF TogglePaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000094")]
				[Cpp2IlInjected.Address(RVA = "0x6D5040", Offset = "0x6D3840", VA = "0x1806D5040")]
				get
				{
					return default(JJIAJLMDHKF);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000045")]
			public TogglePalette TogglePalette
			{
				[Cpp2IlInjected.Token(Token = "0x6000095")]
				[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
			public TogglePaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public class MixedTogglePaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			[SerializeField]
			private LOOHBNOLNKH mixedTogglePaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400011A")]
			[SerializeField]
			private MixedTogglePalette mixedTogglePalette;

			[Cpp2IlInjected.Token(Token = "0x17000046")]
			public LOOHBNOLNKH MixedTogglePaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000097")]
				[Cpp2IlInjected.Address(RVA = "0x6D5040", Offset = "0x6D3840", VA = "0x1806D5040")]
				get
				{
					return default(LOOHBNOLNKH);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000047")]
			public MixedTogglePalette MixedTogglePalette
			{
				[Cpp2IlInjected.Token(Token = "0x6000098")]
				[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
			public MixedTogglePaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public class MakerPenToolPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			[SerializeField]
			private OJEBAEBKFOE makerPenToolPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			[SerializeField]
			private MakerPenToolPalette makerPenToolPalette;

			[Cpp2IlInjected.Token(Token = "0x17000048")]
			public OJEBAEBKFOE MakerPenToolPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600009A")]
				[Cpp2IlInjected.Address(RVA = "0x6D5040", Offset = "0x6D3840", VA = "0x1806D5040")]
				get
				{
					return default(OJEBAEBKFOE);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000049")]
			public MakerPenToolPalette MakerPenToolPalette
			{
				[Cpp2IlInjected.Token(Token = "0x600009B")]
				[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
			public MakerPenToolPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public class InputFieldPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			[SerializeField]
			private JACJBJMDGDD inputFieldPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			[SerializeField]
			private InputFieldPalette inputFieldPalette;

			[Cpp2IlInjected.Token(Token = "0x1700004A")]
			public JACJBJMDGDD InputFieldPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600009D")]
				[Cpp2IlInjected.Address(RVA = "0x6D5040", Offset = "0x6D3840", VA = "0x1806D5040")]
				get
				{
					return default(JACJBJMDGDD);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004B")]
			public InputFieldPalette InputFieldPalette
			{
				[Cpp2IlInjected.Token(Token = "0x600009E")]
				[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
			public InputFieldPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		public class DropdownPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			[SerializeField]
			private EOECEJMDMLK dropdownPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			[SerializeField]
			private DropdownPalette dropdownPalette;

			[Cpp2IlInjected.Token(Token = "0x1700004C")]
			public EOECEJMDMLK DropdownPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x60000A0")]
				[Cpp2IlInjected.Address(RVA = "0x6D5040", Offset = "0x6D3840", VA = "0x1806D5040")]
				get
				{
					return default(EOECEJMDMLK);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004D")]
			public DropdownPalette DropdownPalette
			{
				[Cpp2IlInjected.Token(Token = "0x60000A1")]
				[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
			public DropdownPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200003D")]
		public class SliderPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			[SerializeField]
			private ACHCLNKCPPF sliderPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			[SerializeField]
			private SliderPalette sliderPalette;

			[Cpp2IlInjected.Token(Token = "0x1700004E")]
			public ACHCLNKCPPF SliderPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x60000A3")]
				[Cpp2IlInjected.Address(RVA = "0x6D5040", Offset = "0x6D3840", VA = "0x1806D5040")]
				get
				{
					return default(ACHCLNKCPPF);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004F")]
			public SliderPalette SliderPalette
			{
				[Cpp2IlInjected.Token(Token = "0x60000A4")]
				[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
			public SliderPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		public class DepthPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			[SerializeField]
			private KKNNMPIEDAL depthPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			[SerializeField]
			private DepthPalette depthPalette;

			[Cpp2IlInjected.Token(Token = "0x17000050")]
			public KKNNMPIEDAL DepthPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x60000A6")]
				[Cpp2IlInjected.Address(RVA = "0x6D5040", Offset = "0x6D3840", VA = "0x1806D5040")]
				get
				{
					return default(KKNNMPIEDAL);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000051")]
			public DepthPalette DepthPalette
			{
				[Cpp2IlInjected.Token(Token = "0x60000A7")]
				[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
			public DepthPaletteItem()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		[CompilerGenerated]
		private sealed class AGJCBFLDFFI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public BGNNMCBLBNL backgroundColorPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
			public AGJCBFLDFFI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xC284F0", Offset = "0xC26CF0", VA = "0x180C284F0")]
			internal bool <GetRawImageColor>b__0(RawImageColorPaletteItem pi)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		[CompilerGenerated]
		private sealed class CGGBGMALDBG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			public HOHNCCDEKJF backgroundColorPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
			public CGGBGMALDBG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xC284F0", Offset = "0xC26CF0", VA = "0x180C284F0")]
			internal bool <GetBackgroundPaletteData>b__0(BackgroundColorPaletteItem backgroundColorPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[CompilerGenerated]
		private sealed class HMKAJPFAPIH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			public HLDDLMDDHKG foregroundColorPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
			public HMKAJPFAPIH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xC284F0", Offset = "0xC26CF0", VA = "0x180C284F0")]
			internal bool <GetForegroundColor>b__0(ForegroundColorPaletteItem colorPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		[CompilerGenerated]
		private sealed class PDKIOJLEIDJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			public KOMKEHPPABH type;

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
			public PDKIOJLEIDJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xC284F0", Offset = "0xC26CF0", VA = "0x180C284F0")]
			internal bool <GetTilerPalette>b__0(TilerPaletteItem tilerPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000043")]
		[CompilerGenerated]
		private sealed class MPNMKDKACBJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			public MONHOPEJCME textStylePaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
			public MPNMKDKACBJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xC284F0", Offset = "0xC26CF0", VA = "0x180C284F0")]
			internal bool <GetTextStylePalette>b__0(TextStylePaletteItem textStylePaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		[CompilerGenerated]
		private sealed class GBFKJONEFIO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public JGEIHLPPBJJ textSizePaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
			public GBFKJONEFIO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xC284F0", Offset = "0xC26CF0", VA = "0x180C284F0")]
			internal bool <GetTextSize>b__0(TextSizePaletteItem textSizePaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[CompilerGenerated]
		private sealed class IIIHPHALDII
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public MBLHLMMJHNG buttonPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
			public IIIHPHALDII()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xC284F0", Offset = "0xC26CF0", VA = "0x180C284F0")]
			internal bool <GetButtonPalette>b__0(ButtonPaletteItem buttonPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[CompilerGenerated]
		private sealed class KGGNLKMGPEJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			public JJIAJLMDHKF togglePaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
			public KGGNLKMGPEJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xC284F0", Offset = "0xC26CF0", VA = "0x180C284F0")]
			internal bool <GetTogglePalette>b__0(TogglePaletteItem togglePaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		[CompilerGenerated]
		private sealed class OBIEKHLOHGJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400012D")]
			public LOOHBNOLNKH mixedTogglePaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
			public OBIEKHLOHGJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xC284F0", Offset = "0xC26CF0", VA = "0x180C284F0")]
			internal bool <GetMixedTogglePalette>b__0(MixedTogglePaletteItem mixedTogglePaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[CompilerGenerated]
		private sealed class NEPECBHDCMH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400012E")]
			public OJEBAEBKFOE makerPenToolPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
			public NEPECBHDCMH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0xC284F0", Offset = "0xC26CF0", VA = "0x180C284F0")]
			internal bool <GetMakerPenToolPalette>b__0(MakerPenToolPaletteItem makerPenToolPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		[CompilerGenerated]
		private sealed class NKAAMDCBPNI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400012F")]
			public JACJBJMDGDD inputFieldPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
			public NKAAMDCBPNI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0xC284F0", Offset = "0xC26CF0", VA = "0x180C284F0")]
			internal bool <GetInputFieldPalette>b__0(InputFieldPaletteItem inputFieldPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		[CompilerGenerated]
		private sealed class HDAKGACBJLN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public EOECEJMDMLK dropdownPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
			public HDAKGACBJLN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0xC284F0", Offset = "0xC26CF0", VA = "0x180C284F0")]
			internal bool <GetDropdownPalette>b__0(DropdownPaletteItem dropdownPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private sealed class MKHADKAOLGM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			public ACHCLNKCPPF sliderPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
			public MKHADKAOLGM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0xC284F0", Offset = "0xC26CF0", VA = "0x180C284F0")]
			internal bool <GetSliderPalette>b__0(SliderPaletteItem sliderPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private sealed class EIENENDHCPN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000132")]
			public KKNNMPIEDAL depthPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
			public EIENENDHCPN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xC284F0", Offset = "0xC26CF0", VA = "0x180C284F0")]
			internal bool <GetDepth>b__0(DepthPaletteItem depthPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		[SerializeField]
		[Header("Visual")]
		[EJKGPJLGKFD("RawImageColorPaletteType")]
		private RawImageColorPaletteItem[] rawImageColorPaletteItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		[SerializeField]
		[EJKGPJLGKFD("BackgroundColorPaletteType")]
		private BackgroundColorPaletteItem[] backgroundColorPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		[SerializeField]
		[EJKGPJLGKFD("ForegroundColorPaletteType")]
		private ForegroundColorPaletteItem[] foregroundColorPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		[SerializeField]
		[EJKGPJLGKFD("TilerPaletteType")]
		private TilerPaletteItem[] tilerPaletteItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		[SerializeField]
		[EJKGPJLGKFD("TextStylePaletteType")]
		private TextStylePaletteItem[] textStylePalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		[SerializeField]
		[EJKGPJLGKFD("TextSizePaletteType")]
		private TextSizePaletteItem[] textSizePalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		[SerializeField]
		[EJKGPJLGKFD("ButtonPaletteType")]
		private ButtonPaletteItem[] buttonPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		[SerializeField]
		[EJKGPJLGKFD("TogglePaletteType")]
		private TogglePaletteItem[] togglePalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		[SerializeField]
		[EJKGPJLGKFD("MixedTogglePaletteType")]
		private MixedTogglePaletteItem[] mixedTogglePalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		[SerializeField]
		[EJKGPJLGKFD("MakerPenToolPaletteType")]
		private MakerPenToolPaletteItem[] makerPenToolPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		[SerializeField]
		[EJKGPJLGKFD("InputFieldPaletteType")]
		private InputFieldPaletteItem[] inputFieldPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		[SerializeField]
		[EJKGPJLGKFD("DropdownPaletteType")]
		private DropdownPaletteItem[] dropdownPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		[SerializeField]
		[EJKGPJLGKFD("SliderPaletteType")]
		private SliderPaletteItem[] sliderPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		[SerializeField]
		[EJKGPJLGKFD("DepthPaletteType")]
		private DepthPaletteItem[] depthPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		[SerializeField]
		private ButtonAnimationPalette buttonAnimationPalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		[SerializeField]
		[Header("Audio")]
		[FormerlySerializedAs("audioPaletteConfig")]
		private AudioPalette audioPalette;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public IEnumerable<DepthPaletteItem> DepthPalettes
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x7116D0", Offset = "0x70FED0", VA = "0x1807116D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public ButtonAnimationPalette ButtonAnimationPalette
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x6DBD80", Offset = "0x6DA580", VA = "0x1806DBD80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public AudioPalette AudioPalette
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x6DBE20", Offset = "0x6DA620", VA = "0x1806DBE20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x45C0080", Offset = "0x45BE880", VA = "0x1845C0080")]
		public Color PFBNGPPHFEB(BGNNMCBLBNL GCALHFPKMHB)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x45BF540", Offset = "0x45BDD40", VA = "0x1845BF540")]
		public void BLFBHOAINAN(HOHNCCDEKJF GCALHFPKMHB, out Color LCCPJBCAOGP, out Gradient MFDNGNCJPGM, out bool BGMLILCLGLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x45BF7B0", Offset = "0x45BDFB0", VA = "0x1845BF7B0")]
		public Color GFNBPLHEEJD(HLDDLMDDHKG JNLADKNMEPE)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x45BF450", Offset = "0x45BDC50", VA = "0x1845BF450")]
		public TilerPalette BIHDNGGGKEC(KOMKEHPPABH EHPFPOFFCEJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x45BF8C0", Offset = "0x45BE0C0", VA = "0x1845BF8C0")]
		public TextStylePalette GGKCFIEAJHA(MONHOPEJCME IDMMKBBHKHO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x45C0190", Offset = "0x45BE990", VA = "0x1845C0190")]
		public int PJLHNKBGEDK(JGEIHLPPBJJ MHKKCNBBJBN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x45BFC80", Offset = "0x45BE480", VA = "0x1845BFC80")]
		public ButtonPalette LIFIIBCCMAF(MBLHLMMJHNG KFKJFDELELG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x45BF6C0", Offset = "0x45BDEC0", VA = "0x1845BF6C0")]
		public TogglePalette DGNFHKDEKKJ(JJIAJLMDHKF CFJNFFJNHHM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x45BFD70", Offset = "0x45BE570", VA = "0x1845BFD70")]
		public MixedTogglePalette MAOAOONFJAA(LOOHBNOLNKH HHADPJOIMIB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x45BFE60", Offset = "0x45BE660", VA = "0x1845BFE60")]
		public MakerPenToolPalette OFKIGHFEDIA(OJEBAEBKFOE NOKFBDJCLHA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x45BF9B0", Offset = "0x45BE1B0", VA = "0x1845BF9B0")]
		public InputFieldPalette GILHBBPEBBM(JACJBJMDGDD KPPBPAKLCLG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x45BFB90", Offset = "0x45BE390", VA = "0x1845BFB90")]
		public DropdownPalette KNFOIJAOIIK(EOECEJMDMLK DADGAEMKIKF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x45BFAA0", Offset = "0x45BE2A0", VA = "0x1845BFAA0")]
		public SliderPalette JKDKBOHJFCN(ACHCLNKCPPF OAGKFBPNDOB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x45BFF50", Offset = "0x45BE750", VA = "0x1845BFF50")]
		public float? OOAEIBNBNGD(KKNNMPIEDAL ICANADLPFFO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xE21530", Offset = "0xE1FD30", VA = "0x180E21530")]
		public Palette()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public class RecyclingAudioPaletteAsset : BaseAudioPaletteAsset
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[SerializeField]
		[Header("Clip Configs")]
		private RecRoomAudioClipPoolConfig itemRecycledAudioClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		[SerializeField]
		[Tooltip("Minimum required wait time before recycle SFX can be triggered repetitively")]
		[Header("Thresholds")]
		private float minimumTimeIntervalForRecycleSFX;

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public float MinimumTimeIntervalForRecycleSFX
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x1296770", Offset = "0x1294F70", VA = "0x181296770")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x45B8D60", Offset = "0x45B7560", VA = "0x1845B8D60")]
		public bool GOKCJAGNIFC(out RecRoomAudioClip[] PJLPJOAIFNA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x45C0760", Offset = "0x45BEF60", VA = "0x1845C0760")]
		public RecyclingAudioPaletteAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public class ScrollingAudioPaletteAsset : BaseAudioPaletteAsset
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		[SerializeField]
		[Header("Clip Configs")]
		private RecRoomAudioClipPoolConfig scrollingSFXAudioClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		[SerializeField]
		private RecRoomAudioClipPoolConfig hittingEndsAudioClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		[SerializeField]
		[Header("Thresholds")]
		[Tooltip("This distance is measured in UI canvas space")]
		private float distanceThresholdToTriggerScrollingSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		[SerializeField]
		private float minimumTimeIntervalForScrollingSFX;

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public float DistanceThresholdToTriggerScrollingSFX
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x139CAA0", Offset = "0x139B2A0", VA = "0x18139CAA0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public float MinimumTimeIntervalForScrollingSFX
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x10D0450", Offset = "0x10CEC50", VA = "0x1810D0450")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x45B8D60", Offset = "0x45B7560", VA = "0x1845B8D60")]
		public bool BJFJADCIKDN(out RecRoomAudioClip[] PJLPJOAIFNA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x45C3A40", Offset = "0x45C2240", VA = "0x1845C3A40")]
		public bool BIGKIDKMCLM(out RecRoomAudioClip[] PJLPJOAIFNA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x45C3AF0", Offset = "0x45C22F0", VA = "0x1845C3AF0")]
		public ScrollingAudioPaletteAsset()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public class SliderPalette
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		[SerializeField]
		private Color sliderColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		[SerializeField]
		private Color fillColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		[SerializeField]
		private Color handleColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		[SerializeField]
		private TextStylePalette textPalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		[SerializeField]
		private Color textColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		[SerializeField]
		private ColorBlock colorBlock;

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public Color SliderColor
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0xCDB3C0", Offset = "0xCD9BC0", VA = "0x180CDB3C0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public Color FillColor
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0xC06C00", Offset = "0xC05400", VA = "0x180C06C00")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public Color HandleColor
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0xE995E0", Offset = "0xE97DE0", VA = "0x180E995E0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public TextStylePalette TextPalette
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x6DC580", Offset = "0x6DAD80", VA = "0x1806DC580")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public Color TextColor
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x1285520", Offset = "0x1283D20", VA = "0x181285520")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public ColorBlock ColorBlock
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x45C4880", Offset = "0x45C3080", VA = "0x1845C4880")]
			get
			{
				return default(ColorBlock);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x45C47D0", Offset = "0x45C2FD0", VA = "0x1845C47D0")]
		public SliderPalette()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public class TextStylePalette
	{
		[Cpp2IlInjected.Token(Token = "0x2000051")]
		public enum KBGENAKGABI
		{
			[Cpp2IlInjected.Token(Token = "0x4000147")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			LowerCase,
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			UpperCase,
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			SmallCaps
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		[SerializeField]
		private TMP_FontAsset font;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		[SerializeField]
		private Material fontOverrideMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		[SerializeField]
		private float kerning;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		[SerializeField]
		private float leading;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		[SerializeField]
		private bool isBold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		[SerializeField]
		private bool isItalic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		[SerializeField]
		private KBGENAKGABI transformation;

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public TMP_FontAsset Font
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x6D6AC0", Offset = "0x6D52C0", VA = "0x1806D6AC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public Material FontOverrideMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public float Kerning
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x1296770", Offset = "0x1294F70", VA = "0x181296770")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public float Leading
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x121B0D0", Offset = "0x12198D0", VA = "0x18121B0D0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool IsBold
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x7C5FA0", Offset = "0x7C47A0", VA = "0x1807C5FA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public bool IsItalic
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x9175E0", Offset = "0x915DE0", VA = "0x1809175E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public KBGENAKGABI Transformation
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x9AF4F0", Offset = "0x9ADCF0", VA = "0x1809AF4F0")]
			get
			{
				return default(KBGENAKGABI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x45C5200", Offset = "0x45C3A00", VA = "0x1845C5200")]
		public void KGBEBONMIII(TextMeshProUGUI EADMGGDGJOJ, bool IBOFHFOOGJG = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public TextStylePalette()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public class TilerPalette
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		[SerializeField]
		private Sprite sprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		[SerializeField]
		private Color tintColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		[SerializeField]
		private Color backgroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		[SerializeField]
		private float rows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		[SerializeField]
		private float rowsWhenPortrait;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		[SerializeField]
		private Vector2 spacing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		[SerializeField]
		private float offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		[SerializeField]
		private Vector2 velocity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		[SerializeField]
		[Range(0f, 360f)]
		private float angle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		[SerializeField]
		private UITiler.LLMNOICIDII animationDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		[SerializeField]
		private float primaryAnimationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		[SerializeField]
		private float altAnimationSpeed;

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public Sprite Sprite
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x6D6AC0", Offset = "0x6D52C0", VA = "0x1806D6AC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public Color TintColor
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x6F6040", Offset = "0x6F4840", VA = "0x1806F6040")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public Color BackgroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x6F6030", Offset = "0x6F4830", VA = "0x1806F6030")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public Vector2 Spacing
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x45C5750", Offset = "0x45C3F50", VA = "0x1845C5750")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public float Offset
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x12966F0", Offset = "0x1294EF0", VA = "0x1812966F0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public Vector2 Velocity
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x45C5770", Offset = "0x45C3F70", VA = "0x1845C5770")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public float Angle
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x1296720", Offset = "0x1294F20", VA = "0x181296720")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public UITiler.LLMNOICIDII AnimationDirection
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x7DAA70", Offset = "0x7D9270", VA = "0x1807DAA70")]
			get
			{
				return default(UITiler.LLMNOICIDII);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public float PrimaryAnimationSpeed
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x1296730", Offset = "0x1294F30", VA = "0x181296730")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public float AltAnimationSpeed
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xFE5310", Offset = "0xFE3B10", VA = "0x180FE5310")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x45C56C0", Offset = "0x45C3EC0", VA = "0x1845C56C0")]
		public float GLLHKBABMHH(LPMDOGDGCFP CBNJLMNFJJF)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x45C56E0", Offset = "0x45C3EE0", VA = "0x1845C56E0")]
		public TilerPalette()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public class TogglePalette
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		[SerializeField]
		private ButtonPalette inactiveButtonPalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		[SerializeField]
		private ButtonPalette activeButtonPalette;

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public ButtonPalette InactiveButtonPalette
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x6D6AC0", Offset = "0x6D52C0", VA = "0x1806D6AC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public ButtonPalette ActiveButtonPalette
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public TogglePalette()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public class ApproximationMaskDepthTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		[SerializeField]
		private RectTransform content;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private Vector3? NICJHNIPFBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private Vector3? OPAHCBNKMEE;

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x45B6A70", Offset = "0x45B5270", VA = "0x1845B6A70")]
		private void ODGJJHFNDHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x45B66B0", Offset = "0x45B4EB0", VA = "0x1845B66B0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xE06850", Offset = "0xE05050", VA = "0x180E06850")]
		public ApproximationMaskDepthTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public class ButtonTheme : ButtonThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		[SerializeField]
		[Header("Button Visual")]
		private MBLHLMMJHNG buttonType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		[SerializeField]
		[Header("Button Audio")]
		[Tooltip("Override the audio palette defined by the button's visual with a custom palette")]
		private bool overrideButtonAudioPalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		[SerializeField]
		[CPILAAFLPDK("overrideButtonAudioPalette")]
		[Tooltip("Specify a custom config to use for button audio")]
		private ButtonAudioPaletteAsset customButtonAudioConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		[SerializeField]
		[Tooltip("Layer a 2D SFX on top of base button sounds")]
		private bool useFlavorSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		[SerializeField]
		[CPILAAFLPDK("useFlavorSFX")]
		[Tooltip("Flavor SFX is picked randomly from this pool config")]
		private RecRoomAudioClipPoolConfig flavorSFXClipPoolConfig;

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public MBLHLMMJHNG CEEGNJBLKEH
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x12DD860", Offset = "0x12DC060", VA = "0x1812DD860")]
			get
			{
				return default(MBLHLMMJHNG);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x45B8D40", Offset = "0x45B7540", VA = "0x1845B8D40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x45B8AD0", Offset = "0x45B72D0", VA = "0x1845B8AD0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x10A24E0", Offset = "0x10A0CE0", VA = "0x1810A24E0")]
		public void SetAnimationEnabled(bool KEBPJDOCLJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x45B8D30", Offset = "0x45B7530", VA = "0x1845B8D30")]
		public ButtonTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public abstract class ButtonThemeBase : SelectableThemeBase
	{
		[Cpp2IlInjected.Token(Token = "0x2000058")]
		protected class HNPNMOFKIAC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000179")]
			public ButtonAudioPaletteAsset FPDKPODPJJI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400017A")]
			public RecRoomAudioClipPoolConfig MGCFLGEOHLC;

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
			public HNPNMOFKIAC()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		[SerializeField]
		[PHJFDGPKCBM(OLIJGBPJKMJ.Self, false, false, false)]
		[Header("Button Theme Base")]
		private MultiGraphicButton multiGraphicButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		[SerializeField]
		[PHJFDGPKCBM(OLIJGBPJKMJ.Self, false, true, false)]
		private Image surface;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		[SerializeField]
		private bool useSurfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		[SerializeField]
		[CPILAAFLPDK("useSurfaceOverride")]
		private Image surfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		[SerializeField]
		[DGNHMCLGJOI]
		private List<Graphic> graphics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		[SerializeField]
		private bool useGraphicsOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		[SerializeField]
		[CPILAAFLPDK("useGraphicsOverride")]
		private List<Graphic> graphicsOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		[SerializeField]
		[PHJFDGPKCBM(OLIJGBPJKMJ.Self, false, true, false)]
		private UIGradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		[SerializeField]
		private bool useGradientOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		[SerializeField]
		[CPILAAFLPDK("useGradientOverride")]
		private UIGradient gradientOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		[SerializeField]
		[PHJFDGPKCBM(OLIJGBPJKMJ.Children, true, true, false)]
		private TextMeshProUGUI textMeshProUGUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		[SerializeField]
		private bool useTextMeshProUGUIOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		[SerializeField]
		[CPILAAFLPDK("useTextMeshProUGUIOverride")]
		private TextMeshProUGUI textMeshProUGUIOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		[SerializeField]
		private JGEIHLPPBJJ textSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		[SerializeField]
		protected Hideable borderHideable;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		[SerializeField]
		protected bool isAnimationEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		[SerializeField]
		[CPILAAFLPDK("isAnimationEnabled")]
		protected bool overrideAnimationTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		[SerializeField]
		[CPILAAFLPDK("overrideAnimationTarget")]
		protected GameObject animationTargetOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private bool PMBOLLILBJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private Vector3 NNDCMCJBGEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private Vector3 PFDOBMCFELD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private EJNKHBGGFJF JNJOKKJPBIF;

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public Image FHEHJDFPMJF
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x45B8A70", Offset = "0x45B7270", VA = "0x1845B8A70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public List<Graphic> GNMCHAJCJBO
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x45B8A50", Offset = "0x45B7250", VA = "0x1845B8A50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public UIGradient IFILHCDKLDA
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x45B8A30", Offset = "0x45B7230", VA = "0x1845B8A30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public TextMeshProUGUI CGHIPJEOHEG
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x45B8A90", Offset = "0x45B7290", VA = "0x1845B8A90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public JGEIHLPPBJJ NELEICLBAAB
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x1190560", Offset = "0x118ED60", VA = "0x181190560")]
			get
			{
				return default(JGEIHLPPBJJ);
			}
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x45B8AB0", Offset = "0x45B72B0", VA = "0x1845B8AB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		protected Transform NHFPLMLJGBG
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x45B8050", Offset = "0x45B6850", VA = "0x1845B8050")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public Button NFCKOGCGMOG
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x45B89B0", Offset = "0x45B71B0", VA = "0x1845B89B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x45B8180", Offset = "0x45B6980", VA = "0x1845B8180")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x45B80E0", Offset = "0x45B68E0", VA = "0x1845B80E0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x45B7ED0", Offset = "0x45B66D0", VA = "0x1845B7ED0")]
		protected void FHBDFMMECPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x45B7440", Offset = "0x45B5C40", VA = "0x1845B7440")]
		protected void ECFLCKIJKLH(ButtonPalette EFGFPJKDLFJ, [Optional] HNPNMOFKIAC IKPDOJEGFPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x45B8200", Offset = "0x45B6A00", VA = "0x1845B8200", Slot = "12")]
		public override void OnPointerDown(PointerEventData HIGIGMBKOED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x45B85D0", Offset = "0x45B6DD0", VA = "0x1845B85D0", Slot = "13")]
		public override void OnPointerUp(PointerEventData HIGIGMBKOED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x45B81E0", Offset = "0x45B69E0", VA = "0x1845B81E0", Slot = "14")]
		public override void OnPointerClick(PointerEventData HIGIGMBKOED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x45B80C0", Offset = "0x45B68C0", VA = "0x1845B80C0")]
		private Vector3 MGLKJBKFOMG(float NLPGPFFCFFJ)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x45B8900", Offset = "0x45B7100", VA = "0x1845B8900")]
		protected ButtonThemeBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x45B80A0", Offset = "0x45B68A0", VA = "0x1845B80A0")]
		[CompilerGenerated]
		private void KAGJACOFKCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x45B80A0", Offset = "0x45B68A0", VA = "0x1845B80A0")]
		[CompilerGenerated]
		private void KBELCAJOIDC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public class DepthTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		[SerializeField]
		private KKNNMPIEDAL depth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		[SerializeField]
		private bool animateOnEnable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		[SerializeField]
		[CPILAAFLPDK("animateOnEnable")]
		private float animationTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private Vector3? NICJHNIPFBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private Vector2 FNGJNAAFDJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private Vector2 LIFMIKHPLIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private Vector2 KKDEPBGMFIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private Vector2 MHJKDHDLIDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private Vector2 PNCIECMPFHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private Vector2 JCDOJIBLLMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private readonly bool? EPGPIHOLBIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private KOAJIHDJACK APOJCOILAFO;

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		private RectTransform IKJJOBEFAIA
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x45B9350", Offset = "0x45B7B50", VA = "0x1845B9350")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public KKNNMPIEDAL HLMLMNOMMHJ
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x6D5010", Offset = "0x6D3810", VA = "0x1806D5010")]
			get
			{
				return default(KKNNMPIEDAL);
			}
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x45B9A20", Offset = "0x45B8220", VA = "0x1845B9A20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		private KOAJIHDJACK JCBPABDCCFM
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x45B9480", Offset = "0x45B7C80", VA = "0x1845B9480")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		private bool NGABJMPACGD
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x45B93B0", Offset = "0x45B7BB0", VA = "0x1845B93B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x45B98C0", Offset = "0x45B80C0", VA = "0x1845B98C0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x45B9810", Offset = "0x45B8010", VA = "0x1845B9810")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x45B8E40", Offset = "0x45B7640", VA = "0x1845B8E40", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x45B94F0", Offset = "0x45B7CF0", VA = "0x1845B94F0")]
		private void ODGJJHFNDHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x45B9040", Offset = "0x45B7840", VA = "0x1845B9040")]
		private Vector3 KCBBACBFDDF()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x45B9930", Offset = "0x45B8130", VA = "0x1845B9930")]
		public DepthTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public class DropdownTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		[SerializeField]
		[PMFJBMBMCHD(OLIJGBPJKMJ.Self, false, false, false)]
		private Dropdown dropdown;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		[SerializeField]
		[PHJFDGPKCBM(OLIJGBPJKMJ.Self, false, true, false)]
		private Image surface;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		[SerializeField]
		private bool useSurfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		[SerializeField]
		[CPILAAFLPDK("useSurfaceOverride")]
		private Image surfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		[SerializeField]
		private EOECEJMDMLK dropdownType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		[SerializeField]
		private JGEIHLPPBJJ textSize;

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public Image FHEHJDFPMJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x45BA0D0", Offset = "0x45B88D0", VA = "0x1845BA0D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public EOECEJMDMLK MLKNDKEMIFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x722770", Offset = "0x720F70", VA = "0x180722770")]
			get
			{
				return default(EOECEJMDMLK);
			}
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x45BA0E0", Offset = "0x45B88E0", VA = "0x1845BA0E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public JGEIHLPPBJJ NELEICLBAAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x887B00", Offset = "0x886300", VA = "0x180887B00")]
			get
			{
				return default(JGEIHLPPBJJ);
			}
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x45BA100", Offset = "0x45B8900", VA = "0x1845BA100")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x45B9A80", Offset = "0x45B8280", VA = "0x1845B9A80", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x45BA0C0", Offset = "0x45B88C0", VA = "0x1845BA0C0")]
		public DropdownTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class GraphicTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		[SerializeField]
		[PMFJBMBMCHD(OLIJGBPJKMJ.Self, false, false, false)]
		private Graphic graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		[SerializeField]
		private bool useGraphicOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		[SerializeField]
		[CPILAAFLPDK("useGraphicOverride")]
		private Graphic graphicOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		[SerializeField]
		private HLDDLMDDHKG color;

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public Graphic NGIDHEJMBHC
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x45BB370", Offset = "0x45B9B70", VA = "0x1845BB370")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public HLDDLMDDHKG IFKDCCPKODK
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x6D5020", Offset = "0x6D3820", VA = "0x1806D5020")]
			get
			{
				return default(HLDDLMDDHKG);
			}
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x45BB380", Offset = "0x45B9B80", VA = "0x1845BB380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public bool JAMMPGGMNKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x778D00", Offset = "0x777500", VA = "0x180778D00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x7794B0", Offset = "0x777CB0", VA = "0x1807794B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public Color? OCKBEDJMPJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x45BB190", Offset = "0x45B9990", VA = "0x1845BB190")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x45BADE0", Offset = "0x45B95E0", VA = "0x1845BADE0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0xE06850", Offset = "0xE05050", VA = "0x180E06850")]
		public GraphicTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class InputFieldTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		[SerializeField]
		[PMFJBMBMCHD(OLIJGBPJKMJ.Self, false, false, false)]
		private TMP_InputField inputField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		[SerializeField]
		[PHJFDGPKCBM(OLIJGBPJKMJ.Self, false, false, false)]
		private Image surface;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		[SerializeField]
		private bool useSurfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		[SerializeField]
		[CPILAAFLPDK("useSurfaceOverride")]
		private Image surfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		[SerializeField]
		private JACJBJMDGDD inputFieldType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		[SerializeField]
		private JGEIHLPPBJJ textSize;

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public Image FHEHJDFPMJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x45BA0D0", Offset = "0x45B88D0", VA = "0x1845BA0D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public JACJBJMDGDD HJOJNLFJAAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x722770", Offset = "0x720F70", VA = "0x180722770")]
			get
			{
				return default(JACJBJMDGDD);
			}
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x45BA0E0", Offset = "0x45B88E0", VA = "0x1845BA0E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public JGEIHLPPBJJ NELEICLBAAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x887B00", Offset = "0x886300", VA = "0x180887B00")]
			get
			{
				return default(JGEIHLPPBJJ);
			}
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x45BA100", Offset = "0x45B8900", VA = "0x1845BA100")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x45BB400", Offset = "0x45B9C00", VA = "0x1845BB400", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x45BA0C0", Offset = "0x45B88C0", VA = "0x1845BA0C0")]
		public InputFieldTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class LabelTheme : GraphicTheme
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		[SerializeField]
		[PMFJBMBMCHD(OLIJGBPJKMJ.Self, false, false, false)]
		private TextMeshProUGUI textMeshProUGUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		[SerializeField]
		private MONHOPEJCME textType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		[SerializeField]
		private JGEIHLPPBJJ textSize;

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public MONHOPEJCME LAKBFKFMMLL
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x779530", Offset = "0x777D30", VA = "0x180779530")]
			get
			{
				return default(MONHOPEJCME);
			}
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x45BBCB0", Offset = "0x45BA4B0", VA = "0x1845BBCB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public JGEIHLPPBJJ NELEICLBAAB
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x8F7400", Offset = "0x8F5C00", VA = "0x1808F7400")]
			get
			{
				return default(JGEIHLPPBJJ);
			}
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x45BBC90", Offset = "0x45BA490", VA = "0x1845BBC90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x45BB950", Offset = "0x45BA150", VA = "0x1845BB950", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x45BBC80", Offset = "0x45BA480", VA = "0x1845BBC80")]
		public LabelTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public class MakerPenToolTheme : ButtonThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		[SerializeField]
		[Header("Maker Pen Tool")]
		private OJEBAEBKFOE makerPenToolPaletteType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		[SerializeField]
		[Tooltip("A list of objects to show while the maker pen tool is active.")]
		private List<Hideable> hideWhenNotActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		[SerializeField]
		[Tooltip("A list of objects to show while the maker pen tool is inactive")]
		private List<Hideable> hideWhenActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		[SerializeField]
		private bool editorIsActiveOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x131")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		protected bool ACKELKNJIBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x132")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private bool IJLIKOKMPHI;

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public OJEBAEBKFOE BIKABIKBCIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x12DD860", Offset = "0x12DC060", VA = "0x1812DD860")]
			get
			{
				return default(OJEBAEBKFOE);
			}
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x45B8D40", Offset = "0x45B7540", VA = "0x1845B8D40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public bool BFCAGIPBEBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x1770F30", Offset = "0x176F730", VA = "0x181770F30")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x45BC0D0", Offset = "0x45BA8D0", VA = "0x1845BC0D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x45BC090", Offset = "0x45BA890", VA = "0x1845BC090", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x45BBCD0", Offset = "0x45BA4D0", VA = "0x1845BBCD0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x45B8D30", Offset = "0x45B7530", VA = "0x1845B8D30")]
		public MakerPenToolTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class MixedToggleTheme : ButtonThemeBase
	{
		[Cpp2IlInjected.Token(Token = "0x2000060")]
		public enum GBKBIFCFGCA
		{
			[Cpp2IlInjected.Token(Token = "0x40001A8")]
			Inactive,
			[Cpp2IlInjected.Token(Token = "0x40001A9")]
			Mixed,
			[Cpp2IlInjected.Token(Token = "0x40001AA")]
			Active
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		[SerializeField]
		private LOOHBNOLNKH toggleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		[SerializeField]
		[Tooltip("A list of objects to hide while the toggle is inactive.")]
		private List<Hideable> hideWhenInactive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		[SerializeField]
		[Tooltip("A list of objects to hide while the toggle is mixed.")]
		private List<Hideable> hideWhenMixed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		[SerializeField]
		[Tooltip("A list of objects to hide while the toggle is active")]
		private List<Hideable> hideWhenActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		[SerializeField]
		private GBKBIFCFGCA editorIsActiveOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private GBKBIFCFGCA IJLIKOKMPHI;

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public GBKBIFCFGCA BFCAGIPBEBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x1B3E000", Offset = "0x1B3C800", VA = "0x181B3E000")]
			get
			{
				return default(GBKBIFCFGCA);
			}
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x45BC980", Offset = "0x45BB180", VA = "0x1845BC980")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x45BC950", Offset = "0x45BB150", VA = "0x1845BC950")]
		public void Toggle()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x45BC980", Offset = "0x45BB180", VA = "0x1845BC980")]
		public void Toggle(GBKBIFCFGCA IJLIKOKMPHI, bool ACKELKNJIBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x45BC3D0", Offset = "0x45BABD0", VA = "0x1845BC3D0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x45B8D30", Offset = "0x45B7530", VA = "0x1845B8D30")]
		public MixedToggleTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public class PaletteTheme : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		[SerializeField]
		private bool usePaletteOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		[SerializeField]
		[CPILAAFLPDK("usePaletteOverride")]
		private Palette paletteOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public IFEOEDLAFMF PaletteChangeEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		[SerializeField]
		private bool useDepth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private float? JECDKDFIHCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private float? GOJEBMNONDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private float NDKCJBJBKOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private float KJHMNHCCEAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private float NBBBMIAGEPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private float MNGLDMNNAIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private readonly BGPIKFBGOJB PNAFJMBDOMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private SFXAudioSource NNOHFGIPENN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private SFXAudioSource JLKOJAONEMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private ContentLoadingAudioPaletteAsset OMPAOFKEJIL;

		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private const float BLKMBGDHFJB = 0.001f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private KFNAAOKOBMD PNMLPGLMJEH;

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public Palette NHPIODPLBMI
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x45BF370", Offset = "0x45BDB70", VA = "0x1845BF370")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public bool LBOOGMPLEGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x6D5030", Offset = "0x6D3830", VA = "0x1806D5030")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		private bool IPDDHBBMIAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x45BEAF0", Offset = "0x45BD2F0", VA = "0x1845BEAF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		private bool HFONLELMJNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x45BEB80", Offset = "0x45BD380", VA = "0x1845BEB80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x45BE0C0", Offset = "0x45BC8C0", VA = "0x1845BE0C0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x45BEA80", Offset = "0x45BD280", VA = "0x1845BEA80")]
		private void GANIGAGCJKE(BPBNFJELBCA.HFBAIDBDHAB AAHGFNNCNKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x45BEE70", Offset = "0x45BD670", VA = "0x1845BEE70")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x45BE930", Offset = "0x45BD130", VA = "0x1845BE930")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x45BE390", Offset = "0x45BCB90", VA = "0x1845BE390")]
		private void BHKNOGOAEAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x45BDF90", Offset = "0x45BC790", VA = "0x1845BDF90")]
		public void AddLoadingSFXRequest(object JPCLKLIDFBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x45BF1A0", Offset = "0x45BD9A0", VA = "0x1845BF1A0")]
		public void RemoveLoadingSFXRequest(object JPCLKLIDFBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x45BE930", Offset = "0x45BD130", VA = "0x1845BE930")]
		private void FBDKONOKGEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x45BEB90", Offset = "0x45BD390", VA = "0x1845BEB90")]
		private void KNAMMIJMLJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x45BE240", Offset = "0x45BCA40", VA = "0x1845BE240")]
		private void BBIKNBOPJHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x45BDEA0", Offset = "0x45BC6A0", VA = "0x1845BDEA0")]
		private void AGECDNFCOOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x45BE650", Offset = "0x45BCE50", VA = "0x1845BE650")]
		private void EKGPGKAFJOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x45BED80", Offset = "0x45BD580", VA = "0x1845BED80")]
		private void LFFCIFOEKEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0xA16B40", Offset = "0xA15340", VA = "0x180A16B40")]
		private void GPFGLPAGBGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x45BE560", Offset = "0x45BCD60", VA = "0x1845BE560")]
		private void BJJHOGFNNLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x45BEAB0", Offset = "0x45BD2B0", VA = "0x1845BEAB0")]
		private void HBMHGAIDBND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x45BEFD0", Offset = "0x45BD7D0", VA = "0x1845BEFD0")]
		public void Play2DUIFlavorSFX(RecRoomAudioClip[] MICOCMDDAFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x45BF2C0", Offset = "0x45BDAC0", VA = "0x1845BF2C0")]
		public PaletteTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public abstract class PaletteThemeReference : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		[SerializeField]
		[PHJFDGPKCBM(OLIJGBPJKMJ.SelfAndParent, true, false, false)]
		private PaletteTheme paletteTheme;

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		protected PaletteTheme BPKOLILLMNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		protected Palette NHPIODPLBMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x45BDCB0", Offset = "0x45BC4B0", VA = "0x1845BDCB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		protected bool DCJAIJNJADI
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x45BD6D0", Offset = "0x45BBED0", VA = "0x1845BD6D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		protected Transform CICIKLKBKLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x45BDC20", Offset = "0x45BC420", VA = "0x1845BDC20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x45BD760", Offset = "0x45BBF60", VA = "0x1845BD760", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x45BDDB0", Offset = "0x45BC5B0", VA = "0x1845BDDB0", Slot = "5")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void Apply();

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x45BD870", Offset = "0x45BC070", VA = "0x1845BD870")]
		private void EENIHILEEGA(bool MECNJFNCFJI = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xE06850", Offset = "0xE05050", VA = "0x180E06850")]
		protected PaletteThemeReference()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public class RangeSliderTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		[SerializeField]
		[PMFJBMBMCHD(OLIJGBPJKMJ.Self, false, false, false)]
		private RangeSlider slider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		[SerializeField]
		private ACHCLNKCPPF sliderType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		[SerializeField]
		private Image sliderImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		[SerializeField]
		private Image fillImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		[SerializeField]
		private Image lowHandleImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		[SerializeField]
		private Image highHandleImage;

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public ACHCLNKCPPF LAIIIFBMGKN
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x6F71B0", Offset = "0x6F59B0", VA = "0x1806F71B0")]
			get
			{
				return default(ACHCLNKCPPF);
			}
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x45C0600", Offset = "0x45BEE00", VA = "0x1845C0600")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		public Image CHBOMNJKBNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x6EB6F0", Offset = "0x6E9EF0", VA = "0x1806EB6F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		public Image GKCOKEBDELL
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x6DC570", Offset = "0x6DAD70", VA = "0x1806DC570")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		public Image HHNPHHGFDKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x6DC580", Offset = "0x6DAD80", VA = "0x1806DC580")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		public Image NHMJKGGBDNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x6D50D0", Offset = "0x6D38D0", VA = "0x1806D50D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		public bool EGKOBAKAGLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x45C05C0", Offset = "0x45BEDC0", VA = "0x1845C05C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x45C05E0", Offset = "0x45BEDE0", VA = "0x1845C05E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x45C0280", Offset = "0x45BEA80", VA = "0x1845C0280", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xE06850", Offset = "0xE05050", VA = "0x180E06850")]
		public RangeSliderTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public class RawImageTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		[SerializeField]
		[PMFJBMBMCHD(OLIJGBPJKMJ.Self, false, false, false)]
		private RawImage image;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		[SerializeField]
		private BGNNMCBLBNL color;

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		public BGNNMCBLBNL CCOOGCPPFNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x6F71B0", Offset = "0x6F59B0", VA = "0x1806F71B0")]
			get
			{
				return default(BGNNMCBLBNL);
			}
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x45C0600", Offset = "0x45BEE00", VA = "0x1845C0600")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x45C0620", Offset = "0x45BEE20", VA = "0x1845C0620", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xE06850", Offset = "0xE05050", VA = "0x180E06850")]
		public RawImageTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class RecyclingGridTheme : RecyclingThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		[SerializeField]
		[PMFJBMBMCHD(OLIJGBPJKMJ.Self, false, false, false)]
		private FOGGGPOOAMO recyclingGrid;

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x45C0770", Offset = "0x45BEF70", VA = "0x1845C0770", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x45C09F0", Offset = "0x45BF1F0", VA = "0x1845C09F0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x45C0980", Offset = "0x45BF180", VA = "0x1845C0980")]
		private void FIDKMNNFBEM(float FKPEHBICCJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x45C0C00", Offset = "0x45BF400", VA = "0x1845C0C00")]
		public RecyclingGridTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class RecyclingListTheme : RecyclingThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		[SerializeField]
		[PMFJBMBMCHD(OLIJGBPJKMJ.Self, false, false, false)]
		private FOGGGPOOAMO recyclingList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private bool PDKGJGGAEEO;

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x45C0C10", Offset = "0x45BF410", VA = "0x1845C0C10", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x45C0ED0", Offset = "0x45BF6D0", VA = "0x1845C0ED0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x45C0E60", Offset = "0x45BF660", VA = "0x1845C0E60")]
		private void JIACOPIMPOM(float FKPEHBICCJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x45C0C00", Offset = "0x45BF400", VA = "0x1845C0C00")]
		public RecyclingListTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public abstract class RecyclingThemeBase : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		[SerializeField]
		[Header("Audio")]
		private ONOJGABCLLK recyclingAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		protected RecyclingAudioPaletteAsset CGFPEDABLLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		[SerializeField]
		private NJKPLLHGLDB scrollingAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private ScrollingAudioPaletteAsset HFPLDKMCAPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		private KFNAAOKOBMD AODAMFHHDMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private float LDCMJPEAELP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private float LBLDCDGHMHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private float PIHKNINMNME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private float JGKNMHEDHDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private bool AGNBEMGHPHH;

		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private const float EDHDHOLLBEH = 0.01f;

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		private KFNAAOKOBMD PNMLPGLMJEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x45C1670", Offset = "0x45BFE70", VA = "0x1845C1670")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x45C1470", Offset = "0x45BFC70", VA = "0x1845C1470", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x45C1900", Offset = "0x45C0100", VA = "0x1845C1900")]
		protected void IAAAGDAHGIG(bool NLHMOHEHGBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x45C16E0", Offset = "0x45BFEE0", VA = "0x1845C16E0")]
		protected void BHMBOIEDAJO(GameObject FNHAIFCEKHG, int KKNBFMEEEPF, bool OGCDBNHCJFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x45C16F0", Offset = "0x45BFEF0", VA = "0x1845C16F0")]
		protected void HGEHDHHCOAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x45C10F0", Offset = "0x45BF8F0", VA = "0x1845C10F0")]
		protected void APAKEGCCPGC(float FKPEHBICCJG, float DDPBEDDGGIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x45C1BD0", Offset = "0x45C03D0", VA = "0x1845C1BD0")]
		private void JJBDJCGIABC(float OBIBKBPLDFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x45C1DC0", Offset = "0x45C05C0", VA = "0x1845C1DC0")]
		private void MEFLDHJMALC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x45C0C00", Offset = "0x45BF400", VA = "0x1845C0C00")]
		protected RecyclingThemeBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public class ScrollBarTheme : SelectableThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		[SerializeField]
		[Header("Scroll Bar Audio")]
		private HIHAJMOAMBC buttonAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		[SerializeField]
		[Tooltip("Layer a 2D SFX on top of base button sounds")]
		private bool useFlavorSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		[SerializeField]
		[CPILAAFLPDK("useFlavorSFX")]
		[Tooltip("Flavor SFX is picked randomly from this pool config")]
		private RecRoomAudioClipPoolConfig flavorSFXClipPoolConfig;

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x45C1F10", Offset = "0x45C0710", VA = "0x1845C1F10", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x45C2030", Offset = "0x45C0830", VA = "0x1845C2030")]
		public ScrollBarTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class ScrollRectTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private const string ENOKMHEFIFD = "RRUI.PlayHittingEndsSFX";

		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private const int DHKIJPDLNNF = 5;

		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private const int NPPGCICAJGO = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private DateTimeOffset ENADGCJBAOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		private int HDMKMNLMCHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		private bool KEHDHCGOIME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		[SerializeField]
		[PMFJBMBMCHD(OLIJGBPJKMJ.Self, false, false, false)]
		private ScrollRect scrollRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		[SerializeField]
		[Header("Audio")]
		private NJKPLLHGLDB scrollAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		private ScrollingAudioPaletteAsset CGFPEDABLLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		private KFNAAOKOBMD AODAMFHHDMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private FCJLMEMHFPP JELMHIPBKMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private float LBLDCDGHMHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private float PIHKNINMNME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private float JGKNMHEDHDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private bool AGNBEMGHPHH;

		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		private const float EDHDHOLLBEH = 0.01f;

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		private KFNAAOKOBMD PNMLPGLMJEH
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x45C2350", Offset = "0x45C0B50", VA = "0x1845C2350")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		private FCJLMEMHFPP ILNBGLEPMPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x45C23C0", Offset = "0x45C0BC0", VA = "0x1845C23C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x45C2130", Offset = "0x45C0930", VA = "0x1845C2130", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x45C38D0", Offset = "0x45C20D0", VA = "0x1845C38D0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x45C2040", Offset = "0x45C0840", VA = "0x1845C2040", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x45C3310", Offset = "0x45C1B10", VA = "0x1845C3310")]
		private void NGFGPJINOMM(Vector2 LMLCHIPKJPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x45C2430", Offset = "0x45C0C30", VA = "0x1845C2430")]
		private void JJBDJCGIABC(float OBIBKBPLDFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x45C2620", Offset = "0x45C0E20", VA = "0x1845C2620")]
		private void MEFLDHJMALC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x45C37B0", Offset = "0x45C1FB0", VA = "0x1845C37B0")]
		private static string NJJDNLEBDCK(GameObject BFHAMCLNCKB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x45C39D0", Offset = "0x45C21D0", VA = "0x1845C39D0")]
		public ScrollRectTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public abstract class SelectableThemeBase : PaletteThemeReference, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IPointerClickHandler, IPointerEnterHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		[SerializeField]
		[Header("Selectable Theme Base")]
		[PMFJBMBMCHD(OLIJGBPJKMJ.Self, false, false, false)]
		[FormerlySerializedAs("button")]
		private Selectable selectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		[SerializeField]
		[Header("Legacy Audio Override")]
		[FormerlySerializedAs("overrideAudio")]
		[Tooltip("Override base selectable audio with a single SFX that plays only on click.")]
		protected bool overrideWithSingleAudio;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		[SerializeField]
		[CPILAAFLPDK("overrideWithSingleAudio")]
		[Tooltip("The legacy override audio will be randomly picked from this pool")]
		protected RecRoomAudioClip[] randomAudioOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		protected bool OCDHOEBGAMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private ButtonAudioPaletteAsset CGFPEDABLLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private RecRoomAudioClipPoolConfig ENLNEEMDMDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private KFNAAOKOBMD AODAMFHHDMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private IGEBLFACIIF GDIEOFCKOCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private IJCPDJHOGFD IJNMPJPHBFL;

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		protected Selectable CGALDEPLOEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x6D6120", Offset = "0x6D4920", VA = "0x1806D6120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		protected virtual bool NMLGBAJGOEH
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x6F6020", Offset = "0x6F4820", VA = "0x1806F6020", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public bool EGKOBAKAGLK
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x45C05C0", Offset = "0x45BEDC0", VA = "0x1845C05C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x45C05E0", Offset = "0x45BEDE0", VA = "0x1845C05E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		private KFNAAOKOBMD PNMLPGLMJEH
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x45C3B10", Offset = "0x45C2310", VA = "0x1845C3B10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		protected IGEBLFACIIF IGCJMKDJJIC
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x45C3B80", Offset = "0x45C2380", VA = "0x1845C3B80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		private IJCPDJHOGFD JGNKHKGDBEO
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x45C3D10", Offset = "0x45C2510", VA = "0x1845C3D10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x45C3BF0", Offset = "0x45C23F0", VA = "0x1845C3BF0")]
		protected void DNHLPPGCNDH(ButtonAudioPaletteAsset PEICOANIGKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x7CD330", Offset = "0x7CBB30", VA = "0x1807CD330")]
		protected void DDICEPEIFEK(RecRoomAudioClipPoolConfig NAHAILIBFNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x45C4410", Offset = "0x45C2C10", VA = "0x1845C4410", Slot = "12")]
		public virtual void OnPointerDown(PointerEventData HIGIGMBKOED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x45C4690", Offset = "0x45C2E90", VA = "0x1845C4690", Slot = "13")]
		public virtual void OnPointerUp(PointerEventData HIGIGMBKOED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x45C41E0", Offset = "0x45C29E0", VA = "0x1845C41E0", Slot = "14")]
		public virtual void OnPointerClick(PointerEventData HIGIGMBKOED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x45C4550", Offset = "0x45C2D50", VA = "0x1845C4550", Slot = "15")]
		public virtual void OnPointerEnter(PointerEventData HIGIGMBKOED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x45C4160", Offset = "0x45C2960", VA = "0x1845C4160")]
		private void NLJJCEGCPJN(RecRoomAudioClip[] PJLPJOAIFNA, bool CCOPFEHLHKM = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x45C3D80", Offset = "0x45C2580", VA = "0x1845C3D80")]
		private void GNLHHBFAICE(RecRoomAudioClip IJNEKNIGOML, bool CCOPFEHLHKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x45C2030", Offset = "0x45C0830", VA = "0x1845C2030")]
		protected SelectableThemeBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public class SliderTheme : SelectableThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		[SerializeField]
		[Header("Slider Visual")]
		[PMFJBMBMCHD(OLIJGBPJKMJ.Self, false, false, false)]
		private Slider slider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		[SerializeField]
		private ACHCLNKCPPF sliderType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		[SerializeField]
		[Header("Slider Audio")]
		private HIHAJMOAMBC buttonAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		[SerializeField]
		[Tooltip("Layer a 2D SFX on top of base button sounds")]
		private bool useFlavorSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		[SerializeField]
		[CPILAAFLPDK("useFlavorSFX")]
		[Tooltip("Flavor SFX is picked randomly from this pool config")]
		private RecRoomAudioClipPoolConfig flavorSFXClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		[SerializeField]
		private Image sliderImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		[SerializeField]
		private Image fillImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		[SerializeField]
		private Image handleImage;

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public ACHCLNKCPPF LAIIIFBMGKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x82A6C0", Offset = "0x828EC0", VA = "0x18082A6C0")]
			get
			{
				return default(ACHCLNKCPPF);
			}
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x45C4CC0", Offset = "0x45C34C0", VA = "0x1845C4CC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public Image CHBOMNJKBNB
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x6DBD80", Offset = "0x6DA580", VA = "0x1806DBD80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		public Image GKCOKEBDELL
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x6DBE20", Offset = "0x6DA620", VA = "0x1806DBE20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public Image GNGMKLPANHG
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x7116A0", Offset = "0x70FEA0", VA = "0x1807116A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x45C48C0", Offset = "0x45C30C0", VA = "0x1845C48C0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x45C4CA0", Offset = "0x45C34A0", VA = "0x1845C4CA0")]
		public SliderTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class SurfaceTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		[SerializeField]
		[PMFJBMBMCHD(OLIJGBPJKMJ.Self, false, false, false)]
		private Image image;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		[SerializeField]
		[PHJFDGPKCBM(OLIJGBPJKMJ.Self, false, false, false)]
		private UIGradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		[SerializeField]
		private HOHNCCDEKJF color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		[SerializeField]
		[CPILAAFLPDK("gradient")]
		private bool ignoreGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		[SerializeField]
		[Tooltip("The surface theme determines if this Image is a RaycastTarget or not. There are times when you might want to ignore that setting of the palette theme and just respect whatever is the default state on the Image.")]
		private bool ignoreSettingRaycastTarget;

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public HOHNCCDEKJF ADEHHBNKMGH
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x6D50E0", Offset = "0x6D38E0", VA = "0x1806D50E0")]
			get
			{
				return default(HOHNCCDEKJF);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x45C4F50", Offset = "0x45C3750", VA = "0x1845C4F50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x45C4CE0", Offset = "0x45C34E0", VA = "0x1845C4CE0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0xE06850", Offset = "0xE05050", VA = "0x180E06850")]
		public SurfaceTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class SwitchTheme : ToggleTheme
	{
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		private const float HLPCPLEFHGH = 0.33f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		[SerializeField]
		[Header("Switch")]
		private GameObject indicator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		[SerializeField]
		private GameObject indicatorOffPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		[SerializeField]
		private GameObject indicatorOnPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		private EJNKHBGGFJF JNJOKKJPBIF;

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x45C4F70", Offset = "0x45C3770", VA = "0x1845C4F70", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x45C51F0", Offset = "0x45C39F0", VA = "0x1845C51F0")]
		public SwitchTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public class TilerTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		[SerializeField]
		[PMFJBMBMCHD(OLIJGBPJKMJ.Self, false, false, false)]
		private UITiler tiler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		[SerializeField]
		private KOMKEHPPABH type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private PFGPLINFOJE OKMNCFDDCMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private KIODAJEGLMN CKDMILGKGOJ;

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		private KIODAJEGLMN ADFKFGOALJN
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x45C5BA0", Offset = "0x45C43A0", VA = "0x1845C5BA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		private LPMDOGDGCFP AOKPOKABNGP
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x45C5C10", Offset = "0x45C4410", VA = "0x1845C5C10")]
			get
			{
				return default(LPMDOGDGCFP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x45C5B30", Offset = "0x45C4330", VA = "0x1845C5B30", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x45C5790", Offset = "0x45C3F90", VA = "0x1845C5790", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xE06850", Offset = "0xE05050", VA = "0x180E06850")]
		public TilerTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public class ToggleTheme : ButtonThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		[SerializeField]
		[Header("Toggle Visual")]
		private JJIAJLMDHKF toggleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		[SerializeField]
		[Tooltip("A list of objects to show while the toggle is active.")]
		private List<Hideable> hideWhenNotActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		[SerializeField]
		[Tooltip("A list of objects to show while the toggle is inactive")]
		private List<Hideable> hideWhenActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		[SerializeField]
		private bool editorIsActiveOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x131")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		[SerializeField]
		[Header("Toggle Audio")]
		[Tooltip("Override the audio palette when active defined by the toggle's visual with a custom palette")]
		private bool overrideAudioPaletteWhenActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		[SerializeField]
		[Tooltip("Specify a custom config to use for toggle button audio when active")]
		[CPILAAFLPDK("overrideAudioPaletteWhenActive")]
		private ButtonAudioPaletteAsset customButtonAudioConfigWhenActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		[SerializeField]
		[Tooltip("Override the audio palette when inactive defined by the toggle's visual with a custom palette")]
		private bool overrideAudioPaletteWhenInactive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		[SerializeField]
		[CPILAAFLPDK("overrideAudioPaletteWhenInactive")]
		[Tooltip("Specify a custom config to use for toggle button audio when inactive")]
		private ButtonAudioPaletteAsset customButtonAudioConfigWhenInactive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		[SerializeField]
		[Tooltip("Layer a 2D SFX on top of base button sounds. Flavor SFX only plays when toggling from inactive to active")]
		private bool useFlavorSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		[SerializeField]
		[CPILAAFLPDK("useFlavorSFX")]
		[Tooltip("Flavor SFX is picked randomly from this pool config")]
		private RecRoomAudioClipPoolConfig flavorSFXClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		protected bool ACKELKNJIBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x161")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private bool OEEFCBPCBIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x162")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		private bool IJLIKOKMPHI;

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public bool BFCAGIPBEBK
		{
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x45C6160", Offset = "0x45C4960", VA = "0x1845C6160")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x45C6170", Offset = "0x45C4970", VA = "0x1845C6170")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		public JJIAJLMDHKF CONIJJEANOF
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x12DD860", Offset = "0x12DC060", VA = "0x1812DD860")]
			get
			{
				return default(JJIAJLMDHKF);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x45B8D40", Offset = "0x45B7540", VA = "0x1845B8D40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		protected override bool NMLGBAJGOEH
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x45C60D0", Offset = "0x45C48D0", VA = "0x1845C60D0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x45C6090", Offset = "0x45C4890", VA = "0x1845C6090", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x45C60E0", Offset = "0x45C48E0", VA = "0x1845C60E0")]
		public void Toggle()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x45C6120", Offset = "0x45C4920", VA = "0x1845C6120")]
		public void Toggle(bool IJLIKOKMPHI, bool ACKELKNJIBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x45C5CF0", Offset = "0x45C44F0", VA = "0x1845C5CF0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x45C51F0", Offset = "0x45C39F0", VA = "0x1845C51F0")]
		public ToggleTheme()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class PDJLMBMEBDL
{
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	private static byte[] MEBJOHCMOJE;

	[Cpp2IlInjected.Token(Token = "0x4000212")]
	private static int JLNKJPMHNDA;

	[Cpp2IlInjected.Token(Token = "0x4000213")]
	private static int JMCMMIDKHCA;

	[Cpp2IlInjected.Token(Token = "0x4000214")]
	private static BigInteger PCHDNPNKOJB;

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public PDJLMBMEBDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x45BD3F0", Offset = "0x45BBBF0", VA = "0x1845BD3F0")]
	private static string FEOGEGMPIMJ(byte[] JBKIIGINOKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x45BD0A0", Offset = "0x45BB8A0", VA = "0x1845BD0A0")]
	public static string CIDKAEMCDOH(byte[] EBBNNMNMLOE, bool IGCCOAIPDPG)
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

		[Cpp2IlInjected.Token(Token = "0x4000215")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
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
