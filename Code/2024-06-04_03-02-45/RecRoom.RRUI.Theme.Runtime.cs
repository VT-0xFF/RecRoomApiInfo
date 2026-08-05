using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RRUI.Theme;
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
		private sealed class CDBHPDHNDEE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public TMP_FontAsset font;

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public CDBHPDHNDEE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x71485E0", Offset = "0x7146DE0", VA = "0x1871485E0")]
			internal bool KPOOLODCBAP(LocalizedFontMapping x)
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
			[Cpp2IlInjected.Address(RVA = "0x714A360", Offset = "0x7148B60", VA = "0x18714A360")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public TMP_SpriteAsset EmojiAsset
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x84A260", Offset = "0x848A60", VA = "0x18084A260")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7149DE0", Offset = "0x71485E0", VA = "0x187149DE0")]
		public bool COPHJBNAPCB(TMP_FontAsset HBDPCBANNOC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7149F10", Offset = "0x7148710", VA = "0x187149F10")]
		public TMP_FontAsset FEJFFHALNCO(TMP_FontAsset HBDPCBANNOC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x714A070", Offset = "0x7148870", VA = "0x18714A070")]
		public TMP_FontAsset FEJFFHALNCO(TMP_FontAsset HBDPCBANNOC, Material IFBGPNLMPLL, [Out] Material OEOHGLPOILK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7149A80", Offset = "0x7148280", VA = "0x187149A80")]
		public TMP_FontAsset CFKJHDFOFNG(TMP_FontAsset HBDPCBANNOC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7149BE0", Offset = "0x71483E0", VA = "0x187149BE0")]
		public TMP_FontAsset CFKJHDFOFNG(TMP_FontAsset HBDPCBANNOC, Material IFBGPNLMPLL, [Out] Material IFJBBFHCPND)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x714A2B0", Offset = "0x7148AB0", VA = "0x18714A2B0")]
		private static bool JGENJJHCINJ(TMP_FontAsset HBDPCBANNOC, LocalizedFontMapping DFFOPKJJNMB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8B1970", Offset = "0x8B0170", VA = "0x1808B1970")]
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
			[Cpp2IlInjected.Address(RVA = "0x7154D70", Offset = "0x7153570", VA = "0x187154D70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Palette Active
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x7154D40", Offset = "0x7153540", VA = "0x187154D40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8B1970", Offset = "0x8B0170", VA = "0x1808B1970")]
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
		[Cpp2IlInjected.Address(RVA = "0x714A510", Offset = "0x7148D10", VA = "0x18714A510", Slot = "0")]
		public override bool Equals(object GHDJADLHPAA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x714A4B0", Offset = "0x7148CB0", VA = "0x18714A4B0", Slot = "4")]
		public bool Equals(GradientBlock OGFCKBADKBE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x714A600", Offset = "0x7148E00", VA = "0x18714A600", Slot = "2")]
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
		public List<Graphic> MHCKBNNKEDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8B1FF0", Offset = "0x8B07F0", VA = "0x1808B1FF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xB34DA0", Offset = "0xB335A0", VA = "0x180B34DA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public ColorBlock JDDNOBHGBHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x714C790", Offset = "0x714AF90", VA = "0x18714C790")]
			get
			{
				return default(ColorBlock);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x714C810", Offset = "0x714B010", VA = "0x18714C810")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public UIGradient JGOPNCEEJDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8B2010", Offset = "0x8B0810", VA = "0x1808B2010")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xB34E00", Offset = "0xB33600", VA = "0x180B34E00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public GradientBlock IJAHJGJPCJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x714C7E0", Offset = "0x714AFE0", VA = "0x18714C7E0")]
			get
			{
				return default(GradientBlock);
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x714C860", Offset = "0x714B060", VA = "0x18714C860")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x714C5B0", Offset = "0x714ADB0", VA = "0x18714C5B0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x714C600", Offset = "0x714AE00", VA = "0x18714C600", Slot = "36")]
		public override void OnSelect(BaseEventData BNEKFHGOPID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x714C650", Offset = "0x714AE50", VA = "0x18714C650")]
		public void Refresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x714C380", Offset = "0x714AB80", VA = "0x18714C380")]
		public void ForceHighlighted(bool KKPABMHDNPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x714C3A0", Offset = "0x714ABA0", VA = "0x18714C3A0")]
		public void ForceNormal(bool KKPABMHDNPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x714C020", Offset = "0x714A820", VA = "0x18714C020", Slot = "26")]
		protected override void DoStateTransition(SelectionState DAGLKLOEBMA, bool KKPABMHDNPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x714C4C0", Offset = "0x714ACC0", VA = "0x18714C4C0")]
		private void KGOCHNDEBIG(Graphic DGNPLNFBDJE, Color DCPKMAFLBIJ, bool KKPABMHDNPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x714C3C0", Offset = "0x714ABC0", VA = "0x18714C3C0")]
		private void IGKPKMHNNEM(SelectionState DAGLKLOEBMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x714C680", Offset = "0x714AE80", VA = "0x18714C680")]
		public MultiGraphicButton()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum MDPOGNILHGD
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
public enum LMLKAMBELPN
{
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Default
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public enum PJFOCNKDPAC
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	Default
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum KJFFENHNMMM
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
			private MDPOGNILHGD buttonAudioPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			[SerializeField]
			private ButtonAudioPaletteAsset buttonAudioPaletteConfig;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public MDPOGNILHGD ButtonAudioPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x8421A0", Offset = "0x8409A0", VA = "0x1808421A0")]
				get
				{
					return default(MDPOGNILHGD);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public ButtonAudioPaletteAsset ButtonAudioPaletteConfig
			{
				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
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
			private LMLKAMBELPN scrollingAudioPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			[SerializeField]
			private ScrollingAudioPaletteAsset scrollingAudioPaletteConfig;

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public LMLKAMBELPN ScrollingAudioPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0x8421A0", Offset = "0x8409A0", VA = "0x1808421A0")]
				get
				{
					return default(LMLKAMBELPN);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public ScrollingAudioPaletteAsset ScrollingAudioPaletteConfig
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
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
			private PJFOCNKDPAC contentLoadingAudioPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			[SerializeField]
			private ContentLoadingAudioPaletteAsset contentLoadingAudioPaletteConfig;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public PJFOCNKDPAC ContentLoadingAudioPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x8421A0", Offset = "0x8409A0", VA = "0x1808421A0")]
				get
				{
					return default(PJFOCNKDPAC);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public ContentLoadingAudioPaletteAsset ContentLoadingAudioPaletteConfig
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
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
			private KJFFENHNMMM recyclingAudioPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			[SerializeField]
			private RecyclingAudioPaletteAsset recyclingAudioPaletteConfig;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public KJFFENHNMMM RecyclingAudioPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x8421A0", Offset = "0x8409A0", VA = "0x1808421A0")]
				get
				{
					return default(KJFFENHNMMM);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public RecyclingAudioPaletteAsset RecyclingAudioPaletteConfig
			{
				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public RecyclingAudioPaletteItem()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class PPGNBNPHBPA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public MDPOGNILHGD buttonAudioPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public PPGNBNPHBPA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xFC6920", Offset = "0xFC5120", VA = "0x180FC6920")]
			internal bool ONHKLPCFFHK(ButtonAudioPaletteItem buttonAudioPalette)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class EBLFHAENONP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public LMLKAMBELPN scrollingAudioPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public EBLFHAENONP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xFC6920", Offset = "0xFC5120", VA = "0x180FC6920")]
			internal bool CPLEGGBCEDB(ScrollingAudioPaletteItem scrollingAudioPalette)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class PFBNHDFLGOD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public PJFOCNKDPAC contentLoadingAudioPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public PFBNHDFLGOD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xFC6920", Offset = "0xFC5120", VA = "0x180FC6920")]
			internal bool AMAPPOMDGHP(ContentLoadingAudioPaletteItem contentLoadingAudioPalette)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class DAMAPFEJMHB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public KJFFENHNMMM recyclingAudioPaletteType;

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public DAMAPFEJMHB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xFC6920", Offset = "0xFC5120", VA = "0x180FC6920")]
			internal bool MCLCHIPMBMF(RecyclingAudioPaletteItem recyclingAudioPalette)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[SerializeField]
		[JHDHKHGHMBJ("ButtonAudioPaletteType")]
		private ButtonAudioPaletteItem[] buttonAudioPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[SerializeField]
		[JHDHKHGHMBJ("ScrollingAudioPaletteType")]
		private ScrollingAudioPaletteItem[] scrollingAudioPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[SerializeField]
		[JHDHKHGHMBJ("ContentLoadingAudioPaletteType")]
		private ContentLoadingAudioPaletteItem[] contentLoadingAudioPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[SerializeField]
		[JHDHKHGHMBJ("RecyclingAudioPaletteType")]
		private RecyclingAudioPaletteItem[] recyclingAudioPalettes;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7146610", Offset = "0x7144E10", VA = "0x187146610")]
		public ButtonAudioPaletteAsset JAKOLDEBGAO(MDPOGNILHGD HPHACMBOLJP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7146520", Offset = "0x7144D20", VA = "0x187146520")]
		public ScrollingAudioPaletteAsset IMIKJHJMBFN(LMLKAMBELPN LBMDBNPJGCJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7146340", Offset = "0x7144B40", VA = "0x187146340")]
		public ContentLoadingAudioPaletteAsset CMBJFECMNEI(PJFOCNKDPAC AGHKMHFOMMI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7146430", Offset = "0x7144C30", VA = "0x187146430")]
		public RecyclingAudioPaletteAsset FLHBOMHGOIG(KJFFENHNMMM CEJFFHHLAJA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8B1970", Offset = "0x8B0170", VA = "0x1808B1970")]
		public AudioPalette()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class BaseAudioPaletteAsset : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7146780", Offset = "0x7144F80", VA = "0x187146780")]
		protected bool FPPCEALHEJE(RecRoomAudioClipPoolConfig GGMPGGOKENO, [Out] RecRoomAudioClip[] FIELABGHPIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8B1970", Offset = "0x8B0170", VA = "0x1808B1970")]
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
			[Cpp2IlInjected.Address(RVA = "0x8B1960", Offset = "0x8B0160", VA = "0x1808B1960")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public float ClickAnimationScale
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x8B1920", Offset = "0x8B0120", VA = "0x1808B1920")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7146830", Offset = "0x7145030", VA = "0x187146830")]
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
			[Cpp2IlInjected.Address(RVA = "0x71468D0", Offset = "0x71450D0", VA = "0x1871468D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public RecRoomAudioClip[] PointerUpAudioClipPool
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x71469D0", Offset = "0x71451D0", VA = "0x1871469D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public RecRoomAudioClip[] PointerClickAudioClipPool
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x7146850", Offset = "0x7145050", VA = "0x187146850")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public RecRoomAudioClip[] PointerEnterAudioClipPool
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7146950", Offset = "0x7145150", VA = "0x187146950")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8B1970", Offset = "0x8B0170", VA = "0x1808B1970")]
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
		private MDPOGNILHGD audioPalette;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Color BackgroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8BAAE0", Offset = "0x8B92E0", VA = "0x1808BAAE0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public ColorBlock BackgroundTints
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7146B40", Offset = "0x7145340", VA = "0x187146B40")]
			get
			{
				return default(ColorBlock);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public GradientBlock BackgroundGradients
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x9ECD00", Offset = "0x9EB500", VA = "0x1809ECD00")]
			get
			{
				return default(GradientBlock);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Color ForegroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8B1F60", Offset = "0x8B0760", VA = "0x1808B1F60")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ColorBlock ForegroundTints
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x7146B80", Offset = "0x7145380", VA = "0x187146B80")]
			get
			{
				return default(ColorBlock);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool ShowBorder
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xA58910", Offset = "0xA57110", VA = "0x180A58910")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public TextStylePalette TextPalette
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8B1FF0", Offset = "0x8B07F0", VA = "0x1808B1FF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public MDPOGNILHGD AudioPalette
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x1423640", Offset = "0x1421E40", VA = "0x181423640")]
			get
			{
				return default(MDPOGNILHGD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7146A50", Offset = "0x7145250", VA = "0x187146A50")]
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
			[Cpp2IlInjected.Address(RVA = "0x8B1840", Offset = "0x8B0040", VA = "0x1808B1840")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float LoadingSFXStopDelay
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x8B1950", Offset = "0x8B0150", VA = "0x1808B1950")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float MaxLoadingSFXLength
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x8B1930", Offset = "0x8B0130", VA = "0x1808B1930")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float FadeInDuration
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x8B1940", Offset = "0x8B0140", VA = "0x1808B1940")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public float FadeOutDuration
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x8B1910", Offset = "0x8B0110", VA = "0x1808B1910")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7148660", Offset = "0x7146E60", VA = "0x187148660")]
		public bool DACKLJGDDOJ([Out] RecRoomAudioClip[] FIELABGHPIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7148710", Offset = "0x7146F10", VA = "0x187148710")]
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
			[Cpp2IlInjected.Address(RVA = "0x962F10", Offset = "0x961710", VA = "0x180962F10")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8BAAE0", Offset = "0x8B92E0", VA = "0x1808BAAE0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public TextStylePalette TextPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x847480", Offset = "0x845C80", VA = "0x180847480")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7149410", Offset = "0x7147C10", VA = "0x187149410")]
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
			[Cpp2IlInjected.Address(RVA = "0x8BAAE0", Offset = "0x8B92E0", VA = "0x1808BAAE0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Color ForegroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x8BAAF0", Offset = "0x8B92F0", VA = "0x1808BAAF0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Color PlaceholderColor
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x8C98E0", Offset = "0x8C80E0", VA = "0x1808C98E0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public TextStylePalette TextPalette
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x8472C0", Offset = "0x845AC0", VA = "0x1808472C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x714AAC0", Offset = "0x71492C0", VA = "0x18714AAC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x846800", Offset = "0x845000", VA = "0x180846800")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x714B870", Offset = "0x714A070", VA = "0x18714B870")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public RecRoomAudioClip[] MenuOpen2DFlavorAudioClipPool
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x714B8F0", Offset = "0x714A0F0", VA = "0x18714B8F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public RecRoomAudioClip[] MenuDehydrateAudioClipPool
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x714B7F0", Offset = "0x7149FF0", VA = "0x18714B7F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public RecRoomAudioClip[] MenuClose2DFlavorAudioClipPool
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x714B770", Offset = "0x7149F70", VA = "0x18714B770")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8B1970", Offset = "0x8B0170", VA = "0x1808B1970")]
		public MenuAudioPaletteAsset()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class MixedTogglePalette
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		private enum LGAKFPIDBAI
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
		private MBLPOAPHCIP baseTogglePalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[SerializeField]
		private LGAKFPIDBAI mixedPaletteType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[SerializeField]
		[BLIABGLLHHC("mixedPaletteType", LGAKFPIDBAI.UseCustom)]
		private ButtonPalette mixedButtonPalette;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x714B970", Offset = "0x714A170", VA = "0x18714B970")]
		public TogglePalette IGKJPHJAFAE(Palette GNPDINFKCKA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x714B9A0", Offset = "0x714A1A0", VA = "0x18714B9A0")]
		public ButtonPalette IKGCPDADGKK(Palette GNPDINFKCKA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
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
			private ODJBAHALLGF paletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			[SerializeField]
			private Color color;

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public ODJBAHALLGF RawImageColorPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0x8421A0", Offset = "0x8409A0", VA = "0x1808421A0")]
				get
				{
					return default(ODJBAHALLGF);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public Color Color
			{
				[Cpp2IlInjected.Token(Token = "0x600007D")]
				[Cpp2IlInjected.Address(RVA = "0xF8C930", Offset = "0xF8B130", VA = "0x180F8C930")]
				get
				{
					return default(Color);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x887DA0", Offset = "0x8865A0", VA = "0x180887DA0")]
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
			private DNGCPANLNIN backgroundColorPaletteType;

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
			public DNGCPANLNIN BackgroundColorPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600007F")]
				[Cpp2IlInjected.Address(RVA = "0x8421A0", Offset = "0x8409A0", VA = "0x1808421A0")]
				get
				{
					return default(DNGCPANLNIN);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public Color Color
			{
				[Cpp2IlInjected.Token(Token = "0x6000080")]
				[Cpp2IlInjected.Address(RVA = "0xF8C930", Offset = "0xF8B130", VA = "0x180F8C930")]
				get
				{
					return default(Color);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public Gradient Gradient
			{
				[Cpp2IlInjected.Token(Token = "0x6000081")]
				[Cpp2IlInjected.Address(RVA = "0x8472F0", Offset = "0x845AF0", VA = "0x1808472F0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public bool RaycastTarget
			{
				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0x993570", Offset = "0x991D70", VA = "0x180993570")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x7146700", Offset = "0x7144F00", VA = "0x187146700")]
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
			private OHJOOKLHOHO foregroundColorPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			[SerializeField]
			private Color color;

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public OHJOOKLHOHO ForegroundColorPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x8421A0", Offset = "0x8409A0", VA = "0x1808421A0")]
				get
				{
					return default(OHJOOKLHOHO);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public Color Color
			{
				[Cpp2IlInjected.Token(Token = "0x6000085")]
				[Cpp2IlInjected.Address(RVA = "0xF8C930", Offset = "0xF8B130", VA = "0x180F8C930")]
				get
				{
					return default(Color);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x714A490", Offset = "0x7148C90", VA = "0x18714A490")]
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
			private MFPEJMPNFCJ tilerPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			[SerializeField]
			private TilerPalette tilerPalette;

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public MFPEJMPNFCJ TilerPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0x8421A0", Offset = "0x8409A0", VA = "0x1808421A0")]
				get
				{
					return default(MFPEJMPNFCJ);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public TilerPalette TilerPalette
			{
				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
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
			private PCIKHDIGHIK textStylePaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			[SerializeField]
			private TextStylePalette textStylePalette;

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public PCIKHDIGHIK TextStylePaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600008A")]
				[Cpp2IlInjected.Address(RVA = "0x8421A0", Offset = "0x8409A0", VA = "0x1808421A0")]
				get
				{
					return default(PCIKHDIGHIK);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public TextStylePalette TextStylePalette
			{
				[Cpp2IlInjected.Token(Token = "0x600008B")]
				[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
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
			private GIOOMKAOGIP textSizePaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			[SerializeField]
			private int size;

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			public GIOOMKAOGIP TextSizePaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0x8421A0", Offset = "0x8409A0", VA = "0x1808421A0")]
				get
				{
					return default(GIOOMKAOGIP);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public int Size
			{
				[Cpp2IlInjected.Token(Token = "0x600008E")]
				[Cpp2IlInjected.Address(RVA = "0x8BAB10", Offset = "0x8B9310", VA = "0x1808BAB10")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xA80470", Offset = "0xA7EC70", VA = "0x180A80470")]
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
			private NIKNHJEKCCP buttonPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			[SerializeField]
			private ButtonPalette buttonPalette;

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public NIKNHJEKCCP ButtonPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000090")]
				[Cpp2IlInjected.Address(RVA = "0x8421A0", Offset = "0x8409A0", VA = "0x1808421A0")]
				get
				{
					return default(NIKNHJEKCCP);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000042")]
			public ButtonPalette ButtonPalette
			{
				[Cpp2IlInjected.Token(Token = "0x6000091")]
				[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
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
			private MBLPOAPHCIP togglePaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			[SerializeField]
			private TogglePalette togglePalette;

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			public MBLPOAPHCIP TogglePaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000093")]
				[Cpp2IlInjected.Address(RVA = "0x8421A0", Offset = "0x8409A0", VA = "0x1808421A0")]
				get
				{
					return default(MBLPOAPHCIP);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			public TogglePalette TogglePalette
			{
				[Cpp2IlInjected.Token(Token = "0x6000094")]
				[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
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
			private LCAFDMGKNMJ mixedTogglePaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			[SerializeField]
			private MixedTogglePalette mixedTogglePalette;

			[Cpp2IlInjected.Token(Token = "0x17000045")]
			public LCAFDMGKNMJ MixedTogglePaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000096")]
				[Cpp2IlInjected.Address(RVA = "0x8421A0", Offset = "0x8409A0", VA = "0x1808421A0")]
				get
				{
					return default(LCAFDMGKNMJ);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000046")]
			public MixedTogglePalette MixedTogglePalette
			{
				[Cpp2IlInjected.Token(Token = "0x6000097")]
				[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
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
			private JOGGJFDCJEA makerPenToolPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			[SerializeField]
			private MakerPenToolPalette makerPenToolPalette;

			[Cpp2IlInjected.Token(Token = "0x17000047")]
			public JOGGJFDCJEA MakerPenToolPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000099")]
				[Cpp2IlInjected.Address(RVA = "0x8421A0", Offset = "0x8409A0", VA = "0x1808421A0")]
				get
				{
					return default(JOGGJFDCJEA);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000048")]
			public MakerPenToolPalette MakerPenToolPalette
			{
				[Cpp2IlInjected.Token(Token = "0x600009A")]
				[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
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
			private PFIIEAGODFF inputFieldPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			[SerializeField]
			private InputFieldPalette inputFieldPalette;

			[Cpp2IlInjected.Token(Token = "0x17000049")]
			public PFIIEAGODFF InputFieldPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600009C")]
				[Cpp2IlInjected.Address(RVA = "0x8421A0", Offset = "0x8409A0", VA = "0x1808421A0")]
				get
				{
					return default(PFIIEAGODFF);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004A")]
			public InputFieldPalette InputFieldPalette
			{
				[Cpp2IlInjected.Token(Token = "0x600009D")]
				[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
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
			private KDIBIBAEMHB dropdownPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			[SerializeField]
			private DropdownPalette dropdownPalette;

			[Cpp2IlInjected.Token(Token = "0x1700004B")]
			public KDIBIBAEMHB DropdownPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600009F")]
				[Cpp2IlInjected.Address(RVA = "0x8421A0", Offset = "0x8409A0", VA = "0x1808421A0")]
				get
				{
					return default(KDIBIBAEMHB);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004C")]
			public DropdownPalette DropdownPalette
			{
				[Cpp2IlInjected.Token(Token = "0x60000A0")]
				[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
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
			private PIDFAIANGLI sliderPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			[SerializeField]
			private SliderPalette sliderPalette;

			[Cpp2IlInjected.Token(Token = "0x1700004D")]
			public PIDFAIANGLI SliderPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x60000A2")]
				[Cpp2IlInjected.Address(RVA = "0x8421A0", Offset = "0x8409A0", VA = "0x1808421A0")]
				get
				{
					return default(PIDFAIANGLI);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004E")]
			public SliderPalette SliderPalette
			{
				[Cpp2IlInjected.Token(Token = "0x60000A3")]
				[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
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
			private KDPGJIIKDOE depthPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			[SerializeField]
			private DepthPalette depthPalette;

			[Cpp2IlInjected.Token(Token = "0x1700004F")]
			public KDPGJIIKDOE DepthPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x60000A5")]
				[Cpp2IlInjected.Address(RVA = "0x8421A0", Offset = "0x8409A0", VA = "0x1808421A0")]
				get
				{
					return default(KDPGJIIKDOE);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000050")]
			public DepthPalette DepthPalette
			{
				[Cpp2IlInjected.Token(Token = "0x60000A6")]
				[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public DepthPaletteItem()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[CompilerGenerated]
		private sealed class IIMFPGFJOKO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			public ODJBAHALLGF backgroundColorPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public IIMFPGFJOKO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xFC6920", Offset = "0xFC5120", VA = "0x180FC6920")]
			internal bool GHBHBMOAHCK(RawImageColorPaletteItem pi)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		[CompilerGenerated]
		private sealed class PKOOCLJPOHC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			public DNGCPANLNIN backgroundColorPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public PKOOCLJPOHC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xFC6920", Offset = "0xFC5120", VA = "0x180FC6920")]
			internal bool LLODCIJDGGE(BackgroundColorPaletteItem backgroundColorPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class MOIKCLLLFHI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public OHJOOKLHOHO foregroundColorPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public MOIKCLLLFHI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xFC6920", Offset = "0xFC5120", VA = "0x180FC6920")]
			internal bool HDFDHCJDBLB(ForegroundColorPaletteItem colorPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class OPGLLLAKMNF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public MFPEJMPNFCJ type;

			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public OPGLLLAKMNF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xFC6920", Offset = "0xFC5120", VA = "0x180FC6920")]
			internal bool KMDLAPGDOMO(TilerPaletteItem tilerPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000035")]
		[CompilerGenerated]
		private sealed class ECAJKJBCAIN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public PCIKHDIGHIK textStylePaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public ECAJKJBCAIN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xFC6920", Offset = "0xFC5120", VA = "0x180FC6920")]
			internal bool OIPIJPIMLFB(TextStylePaletteItem textStylePaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000036")]
		[CompilerGenerated]
		private sealed class FCHJIAHFMJE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public GIOOMKAOGIP textSizePaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public FCHJIAHFMJE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xFC6920", Offset = "0xFC5120", VA = "0x180FC6920")]
			internal bool LDNNDNKJGAB(TextSizePaletteItem textSizePaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[CompilerGenerated]
		private sealed class OCACFGDMOEK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public NIKNHJEKCCP buttonPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public OCACFGDMOEK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xFC6920", Offset = "0xFC5120", VA = "0x180FC6920")]
			internal bool AGDBHMLIEMF(ButtonPaletteItem buttonPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		[CompilerGenerated]
		private sealed class COJNOGBIJOG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public MBLPOAPHCIP togglePaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public COJNOGBIJOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xFC6920", Offset = "0xFC5120", VA = "0x180FC6920")]
			internal bool KJAGECCDBDA(TogglePaletteItem togglePaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000039")]
		[CompilerGenerated]
		private sealed class MJJFFDKGOKO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			public LCAFDMGKNMJ mixedTogglePaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public MJJFFDKGOKO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xFC6920", Offset = "0xFC5120", VA = "0x180FC6920")]
			internal bool NNNDFDJHDIH(MixedTogglePaletteItem mixedTogglePaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		[CompilerGenerated]
		private sealed class NKAMDFNEGHO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public JOGGJFDCJEA makerPenToolPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public NKAMDFNEGHO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0xFC6920", Offset = "0xFC5120", VA = "0x180FC6920")]
			internal bool FEPJOGEPKHP(MakerPenToolPaletteItem makerPenToolPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		[CompilerGenerated]
		private sealed class FPDBLIIMPME
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public PFIIEAGODFF inputFieldPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public FPDBLIIMPME()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0xFC6920", Offset = "0xFC5120", VA = "0x180FC6920")]
			internal bool EFDELHEKABH(InputFieldPaletteItem inputFieldPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		[CompilerGenerated]
		private sealed class JHNNCHOELHN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			public KDIBIBAEMHB dropdownPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public JHNNCHOELHN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0xFC6920", Offset = "0xFC5120", VA = "0x180FC6920")]
			internal bool ONKPFEFGIHF(DropdownPaletteItem dropdownPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003D")]
		[CompilerGenerated]
		private sealed class AACJAJEIINF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public PIDFAIANGLI sliderPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public AACJAJEIINF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0xFC6920", Offset = "0xFC5120", VA = "0x180FC6920")]
			internal bool OHKOBJIGMNF(SliderPaletteItem sliderPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		[CompilerGenerated]
		private sealed class GCFJLLHGAIL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			public KDPGJIIKDOE depthPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public GCFJLLHGAIL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0xFC6920", Offset = "0xFC5120", VA = "0x180FC6920")]
			internal bool HLDEIPCFOMO(DepthPaletteItem depthPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[JHDHKHGHMBJ("RawImageColorPaletteType")]
		[Header("Visual")]
		[SerializeField]
		private RawImageColorPaletteItem[] rawImageColorPaletteItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[SerializeField]
		[JHDHKHGHMBJ("BackgroundColorPaletteType")]
		private BackgroundColorPaletteItem[] backgroundColorPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[SerializeField]
		[JHDHKHGHMBJ("ForegroundColorPaletteType")]
		private ForegroundColorPaletteItem[] foregroundColorPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[SerializeField]
		[JHDHKHGHMBJ("TilerPaletteType")]
		private TilerPaletteItem[] tilerPaletteItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[SerializeField]
		[JHDHKHGHMBJ("TextStylePaletteType")]
		private TextStylePaletteItem[] textStylePalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[SerializeField]
		[JHDHKHGHMBJ("TextSizePaletteType")]
		private TextSizePaletteItem[] textSizePalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[SerializeField]
		[JHDHKHGHMBJ("ButtonPaletteType")]
		private ButtonPaletteItem[] buttonPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[SerializeField]
		[JHDHKHGHMBJ("TogglePaletteType")]
		private TogglePaletteItem[] togglePalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[SerializeField]
		[JHDHKHGHMBJ("MixedTogglePaletteType")]
		private MixedTogglePaletteItem[] mixedTogglePalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[SerializeField]
		[JHDHKHGHMBJ("MakerPenToolPaletteType")]
		private MakerPenToolPaletteItem[] makerPenToolPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[SerializeField]
		[JHDHKHGHMBJ("InputFieldPaletteType")]
		private InputFieldPaletteItem[] inputFieldPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[SerializeField]
		[JHDHKHGHMBJ("DropdownPaletteType")]
		private DropdownPaletteItem[] dropdownPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[SerializeField]
		[JHDHKHGHMBJ("SliderPaletteType")]
		private SliderPaletteItem[] sliderPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[SerializeField]
		[JHDHKHGHMBJ("DepthPaletteType")]
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
			[Cpp2IlInjected.Address(RVA = "0x851300", Offset = "0x84FB00", VA = "0x180851300")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public ButtonAnimationPalette ButtonAnimationPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x8512E0", Offset = "0x84FAE0", VA = "0x1808512E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public AudioPalette AudioPalette
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xA2E350", Offset = "0xA2CB50", VA = "0x180A2E350")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x714F020", Offset = "0x714D820", VA = "0x18714F020")]
		public Color FNGJFMBONGJ(ODJBAHALLGF EFANAJOHDED)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x714EDC0", Offset = "0x714D5C0", VA = "0x18714EDC0")]
		public void EIDPDCJJBDK(DNGCPANLNIN EFANAJOHDED, [Out] Color NLKAPPNAHLI, [Out] Gradient BLNGPGIIFDE, [Out] bool GJHIJGPPGNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x714F2F0", Offset = "0x714DAF0", VA = "0x18714F2F0")]
		public Color HGPDDPJLHJL(OHJOOKLHOHO CNGLGKIPIGA)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x714F6B0", Offset = "0x714DEB0", VA = "0x18714F6B0")]
		public TilerPalette OPGBHLBFDCG(MFPEJMPNFCJ HKAKMPIMEOA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x714F110", Offset = "0x714D910", VA = "0x18714F110")]
		public TextStylePalette GHNPHMCCIOC(PCIKHDIGHIK JDOEKPDPHJE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x714E9C0", Offset = "0x714D1C0", VA = "0x18714E9C0")]
		public int AEAFHELJIAB(GIOOMKAOGIP MFILKKICFMA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x714F3E0", Offset = "0x714DBE0", VA = "0x18714F3E0")]
		public ButtonPalette IMNCGBFABJL(NIKNHJEKCCP NHHCKNOCIEG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x714F200", Offset = "0x714DA00", VA = "0x18714F200")]
		public TogglePalette GOJCHDOCHBF(MBLPOAPHCIP DIDJAECKCHO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x714EBE0", Offset = "0x714D3E0", VA = "0x18714EBE0")]
		public MixedTogglePalette CMCCFMBCNAB(LCAFDMGKNMJ PHKGKKJOMIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x714ECD0", Offset = "0x714D4D0", VA = "0x18714ECD0")]
		public MakerPenToolPalette DNODMGGDFAB(JOGGJFDCJEA AEBMMMGACOE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x714F4D0", Offset = "0x714DCD0", VA = "0x18714F4D0")]
		public InputFieldPalette JPGENDBJMLK(PFIIEAGODFF OEEHLIHPAKH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x714EF30", Offset = "0x714D730", VA = "0x18714EF30")]
		public DropdownPalette FIEDGPLDJEG(KDIBIBAEMHB DPOGGJBAJOC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x714F5C0", Offset = "0x714DDC0", VA = "0x18714F5C0")]
		public SliderPalette OAJOEMDMKDH(PIDFAIANGLI ENMIGPFFKCG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x714EAB0", Offset = "0x714D2B0", VA = "0x18714EAB0")]
		public float? CLICHBCFLMC(KDPGJIIKDOE GFDIKLIHCPK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8B1970", Offset = "0x8B0170", VA = "0x1808B1970")]
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
			[Cpp2IlInjected.Address(RVA = "0x8B1840", Offset = "0x8B0040", VA = "0x1808B1840")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7148660", Offset = "0x7146E60", VA = "0x187148660")]
		public bool EIGCJIALGAO([Out] RecRoomAudioClip[] FIELABGHPIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x714FBF0", Offset = "0x714E3F0", VA = "0x18714FBF0")]
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
		[Tooltip("This distance is measured in UI canvas space")]
		[Header("Thresholds")]
		[SerializeField]
		private float distanceThresholdToTriggerScrollingSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[SerializeField]
		private float minimumTimeIntervalForScrollingSFX;

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public float DistanceThresholdToTriggerScrollingSFX
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x8B1930", Offset = "0x8B0130", VA = "0x1808B1930")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public float MinimumTimeIntervalForScrollingSFX
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x8B1940", Offset = "0x8B0140", VA = "0x1808B1940")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7148660", Offset = "0x7146E60", VA = "0x187148660")]
		public bool MPMJLBBIBHO([Out] RecRoomAudioClip[] FIELABGHPIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7152DB0", Offset = "0x71515B0", VA = "0x187152DB0")]
		public bool EIODBLFIGDJ([Out] RecRoomAudioClip[] FIELABGHPIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x7152E60", Offset = "0x7151660", VA = "0x187152E60")]
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
			[Cpp2IlInjected.Address(RVA = "0x8BAAE0", Offset = "0x8B92E0", VA = "0x1808BAAE0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public Color FillColor
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x8BAAF0", Offset = "0x8B92F0", VA = "0x1808BAAF0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public Color HandleColor
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x8C98E0", Offset = "0x8C80E0", VA = "0x1808C98E0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public ColorBlock ColorBlock
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x7153F70", Offset = "0x7152770", VA = "0x187153F70")]
			get
			{
				return default(ColorBlock);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7153EB0", Offset = "0x71526B0", VA = "0x187153EB0")]
		public SliderPalette()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class TextStylePalette
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public enum NIAPFDEAEBE
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
		private NIAPFDEAEBE transformation;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7154890", Offset = "0x7153090", VA = "0x187154890")]
		public void IHJKDNEENFH(TextMeshProUGUI JDICCPOKOCF, bool HKNLENJENHL = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
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
		private UITiler.KHDFNHCDHKE animationDirection;

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
			[Cpp2IlInjected.Address(RVA = "0x846800", Offset = "0x845000", VA = "0x180846800")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public Color TintColor
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0xBF3DE0", Offset = "0xBF25E0", VA = "0x180BF3DE0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public Color BackgroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0xBF3E20", Offset = "0xBF2620", VA = "0x180BF3E20")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public Vector2 Spacing
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x70C44C0", Offset = "0x70C2CC0", VA = "0x1870C44C0")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public float Offset
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x8B18B0", Offset = "0x8B00B0", VA = "0x1808B18B0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public Vector2 Velocity
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x7154F10", Offset = "0x7153710", VA = "0x187154F10")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public float Angle
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x8B1FE0", Offset = "0x8B07E0", VA = "0x1808B1FE0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public UITiler.KHDFNHCDHKE AnimationDirection
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0xEC5E40", Offset = "0xEC4640", VA = "0x180EC5E40")]
			get
			{
				return default(UITiler.KHDFNHCDHKE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public float PrimaryAnimationSpeed
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x8B2060", Offset = "0x8B0860", VA = "0x1808B2060")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public float AltAnimationSpeed
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x8B20B0", Offset = "0x8B08B0", VA = "0x1808B20B0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x7154EA0", Offset = "0x71536A0", VA = "0x187154EA0")]
		public float HLDPJICFBGA(JJKHHALDDNJ FAMMJDPFEAN)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x7154EC0", Offset = "0x71536C0", VA = "0x187154EC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x846800", Offset = "0x845000", VA = "0x180846800")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public ButtonPalette ActiveButtonPalette
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public TogglePalette()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public enum DNGCPANLNIN
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
public enum ODJBAHALLGF
{
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	A
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public enum OHJOOKLHOHO
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
public enum MFPEJMPNFCJ
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
public enum PCIKHDIGHIK
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
public enum GIOOMKAOGIP
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
public enum NIKNHJEKCCP
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
	UGCBaseButton,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	UGCBaseButton_Subtle_NoDisabledState
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public enum MBLPOAPHCIP
{
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	FlatOrange,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	FlatWhite,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	InputToggle,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	Chips,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	Switch,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	WhitePagingBlob,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	RSVPToggleHeaderSection,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	CardSelectableToggle,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	ChipsDark,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	MainNavToggle,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	ListItem,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	NotiUnread,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	FlatPrimary,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	CharadePen,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	ShareCam,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	CardSelectableToggleWithBacking,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	SecondaryHeaderSectionToggle,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	PrimaryToSecondaryHeader,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	NegativeToSecondaryHeader,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	LimitedEventPrimary,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	LimitedEventSecondary,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	RoomCardWithLimitedEvent,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	MainNavVrDetach,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	HomeMainNav,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	FlatOrangeSecondary
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public enum LCAFDMGKNMJ
{
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	Checkbox
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public enum JOGGJFDCJEA
{
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	Create,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	Select,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	Wire,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	Configure,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	Transform,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	Move,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	Rotate,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	Scale,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	CloneFlip,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	Recolor,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	Freeze,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	MakeInvention,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	Manipulate,
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	Delete
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public enum PFIIEAGODFF
{
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	LightFlat,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	DarkFlat,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	Modified
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public enum KDIBIBAEMHB
{
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	LightFlat,
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	DarkFlat
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public enum PIDFAIANGLI
{
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	MirroUIPopUp
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public enum KDPGJIIKDOE
{
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	Base,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	Button,
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	Navigation,
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	Overlay,
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	Dialog,
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	Toast
}
namespace RRUI.Theme
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public class ApproximationMaskDepthTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		[SerializeField]
		private RectTransform content;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private Vector3? ANOGAOLFABD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private Vector3? FHHAGIPJPFG;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7146260", Offset = "0x7144A60", VA = "0x187146260")]
		private void DIHNAABPOCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x7145EC0", Offset = "0x71446C0", VA = "0x187145EC0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x843520", Offset = "0x841D20", VA = "0x180843520")]
		public ApproximationMaskDepthTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public class ButtonTheme : ButtonThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		[Header("Button Visual")]
		[SerializeField]
		private NIKNHJEKCCP buttonType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14C")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		[Header("Button Audio")]
		[SerializeField]
		[Tooltip("Override the audio palette defined by the button's visual with a custom palette")]
		private bool overrideButtonAudioPalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		[SerializeField]
		[BLIABGLLHHC("overrideButtonAudioPalette")]
		[Tooltip("Specify a custom config to use for button audio")]
		private ButtonAudioPaletteAsset customButtonAudioConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		[SerializeField]
		[Tooltip("Layer a 2D SFX on top of base button sounds")]
		private bool useFlavorSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		[SerializeField]
		[BLIABGLLHHC("useFlavorSFX")]
		[Tooltip("Flavor SFX is picked randomly from this pool config")]
		private RecRoomAudioClipPoolConfig flavorSFXClipPoolConfig;

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public NIKNHJEKCCP JEICDPOIMBG
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0xB67950", Offset = "0xB66150", VA = "0x180B67950")]
			get
			{
				return default(NIKNHJEKCCP);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x71485C0", Offset = "0x7146DC0", VA = "0x1871485C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7148350", Offset = "0x7146B50", VA = "0x187148350", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x14B4B10", Offset = "0x14B3310", VA = "0x1814B4B10")]
		public void SetAnimationEnabled(bool JKFJGFGHFNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x71485B0", Offset = "0x7146DB0", VA = "0x1871485B0")]
		public ButtonTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public abstract class ButtonThemeBase : SelectableThemeBase
	{
		[Cpp2IlInjected.Token(Token = "0x2000058")]
		protected class MFNHNIKEJGP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000184")]
			public ButtonAudioPaletteAsset CKNKCKAPDBB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000185")]
			public RecRoomAudioClipPoolConfig IFBNHBOEFLN;

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public MFNHNIKEJGP()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		[Header("Button Theme Base")]
		[SerializeField]
		[NOCFGPDPMKL(EEKFPEEGEKF.Self, false, false, false)]
		private MultiGraphicButton multiGraphicButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		[SerializeField]
		[NOCFGPDPMKL(EEKFPEEGEKF.Self, false, true, false)]
		private Image surface;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		[SerializeField]
		private bool useSurfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		[SerializeField]
		[BLIABGLLHHC("useSurfaceOverride")]
		private Image surfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		[SerializeField]
		private bool controlSurfaceColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		[SerializeField]
		[ReadOnlyField]
		private List<Graphic> graphics;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		[SerializeField]
		private bool useGraphicsOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		[SerializeField]
		[BLIABGLLHHC("useGraphicsOverride")]
		private List<Graphic> graphicsOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		[SerializeField]
		[PNODDKAPBLF("useGraphicsOverride", new object[] { })]
		private bool graphicsIgnoreTextFields;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		[SerializeField]
		private bool controlGraphicColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		[SerializeField]
		[NOCFGPDPMKL(EEKFPEEGEKF.Self, false, true, false)]
		private UIGradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		[SerializeField]
		private bool useGradientOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		[SerializeField]
		[BLIABGLLHHC("useGradientOverride")]
		private UIGradient gradientOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		[SerializeField]
		[NOCFGPDPMKL(EEKFPEEGEKF.Children, true, true, false)]
		private TextMeshProUGUI textMeshProUGUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		[SerializeField]
		private bool useTextMeshProUGUIOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		[SerializeField]
		[BLIABGLLHHC("useTextMeshProUGUIOverride")]
		private TextMeshProUGUI textMeshProUGUIOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		[SerializeField]
		private GIOOMKAOGIP textSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		[SerializeField]
		protected Hideable borderHideable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		[SerializeField]
		protected bool isAnimationEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x111")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		[SerializeField]
		[BLIABGLLHHC("isAnimationEnabled")]
		protected bool overrideAnimationTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		[SerializeField]
		[BLIABGLLHHC("overrideAnimationTarget")]
		protected GameObject animationTargetOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private bool MNMGHEPECPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private Vector3 CFIOFOFOGBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private Vector3 PGPHEPKLJBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private BIOIMFCEIEB KMICBEBOFJJ;

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public Image EFEEHCELMLD
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x71482F0", Offset = "0x7146AF0", VA = "0x1871482F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public List<Graphic> AFMAKDMKCPE
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x71482D0", Offset = "0x7146AD0", VA = "0x1871482D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public UIGradient OKPMHIHAKAL
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x71482B0", Offset = "0x7146AB0", VA = "0x1871482B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public TextMeshProUGUI NIOLFJNFHHL
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x7148310", Offset = "0x7146B10", VA = "0x187148310")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public GIOOMKAOGIP OLKMLOKNOAA
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xC9D090", Offset = "0xC9B890", VA = "0x180C9D090")]
			get
			{
				return default(GIOOMKAOGIP);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x7148330", Offset = "0x7146B30", VA = "0x187148330")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		protected Transform NBDMJAAKDFA
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x7146C10", Offset = "0x7145410", VA = "0x187146C10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public Button ILFKGDMBBCF
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x7148230", Offset = "0x7146A30", VA = "0x187148230")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7147940", Offset = "0x7146140", VA = "0x187147940")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x71478A0", Offset = "0x71460A0", VA = "0x1871478A0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7146C60", Offset = "0x7145460", VA = "0x187146C60")]
		protected void HGFFPKALEDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x7146E30", Offset = "0x7145630", VA = "0x187146E30")]
		protected void IDLHPFGCIII(ButtonPalette IDMNFBGFFFA, [Optional] MFNHNIKEJGP CNJCCGMMHNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x71479E0", Offset = "0x71461E0", VA = "0x1871479E0", Slot = "12")]
		public override void OnPointerDown(PointerEventData BNEKFHGOPID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7147DE0", Offset = "0x71465E0", VA = "0x187147DE0", Slot = "13")]
		public override void OnPointerUp(PointerEventData BNEKFHGOPID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x71479C0", Offset = "0x71461C0", VA = "0x1871479C0", Slot = "14")]
		public override void OnPointerClick(PointerEventData BNEKFHGOPID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7146BF0", Offset = "0x71453F0", VA = "0x187146BF0")]
		private Vector3 CDBLGCFJANF(float KEONANJCBKH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x7148140", Offset = "0x7146940", VA = "0x187148140")]
		protected ButtonThemeBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x7146BD0", Offset = "0x71453D0", VA = "0x187146BD0")]
		[CompilerGenerated]
		private void DAMKLAENPLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7146BD0", Offset = "0x71453D0", VA = "0x187146BD0")]
		[CompilerGenerated]
		private void BAEHFCIPCNH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public class DepthTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		[SerializeField]
		private KDPGJIIKDOE depth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		[SerializeField]
		private bool animateOnEnable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		[SerializeField]
		[BLIABGLLHHC("animateOnEnable")]
		private float animationTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private Vector3? ANOGAOLFABD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private Vector2 NGKAPBAGMKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private Vector2 DMFONCJJNPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private Vector2 HEPEJFLHJMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private Vector2 PEGNOLIKCCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private Vector2 HMAHGBPGMAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private Vector2 DFPBAIBCINP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private readonly bool? PFOLFLFLNJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private JFHIBMMIPJK FMNDHCKAFLL;

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		private RectTransform CNBOBBHEJGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x71490F0", Offset = "0x71478F0", VA = "0x1871490F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public KDPGJIIKDOE OBCDFHHBNHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x8B89F0", Offset = "0x8B71F0", VA = "0x1808B89F0")]
			get
			{
				return default(KDPGJIIKDOE);
			}
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x71493F0", Offset = "0x7147BF0", VA = "0x1871493F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		private JFHIBMMIPJK JIKPABEOHAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x7148CF0", Offset = "0x71474F0", VA = "0x187148CF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		private bool FGJCHANIIDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x7148C20", Offset = "0x7147420", VA = "0x187148C20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7149200", Offset = "0x7147A00", VA = "0x187149200")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7149150", Offset = "0x7147950", VA = "0x187149150")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7148740", Offset = "0x7146F40", VA = "0x187148740", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7148900", Offset = "0x7147100", VA = "0x187148900")]
		private void DIHNAABPOCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7148D60", Offset = "0x7147560", VA = "0x187148D60")]
		private Vector3 LEDJNINEEED()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x7149270", Offset = "0x7147A70", VA = "0x187149270")]
		public DepthTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public class DropdownTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		[SerializeField]
		[GMBLIEHBOLK(EEKFPEEGEKF.Self, false, false, false)]
		private Dropdown dropdown;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		[SerializeField]
		[NOCFGPDPMKL(EEKFPEEGEKF.Self, false, true, false)]
		private Image surface;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		[SerializeField]
		private bool useSurfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		[SerializeField]
		[BLIABGLLHHC("useSurfaceOverride")]
		private Image surfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		[SerializeField]
		private KDIBIBAEMHB dropdownType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		[SerializeField]
		private GIOOMKAOGIP textSize;

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public Image EFEEHCELMLD
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x7149A30", Offset = "0x7148230", VA = "0x187149A30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public KDIBIBAEMHB LAGCBGLGIKD
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x852490", Offset = "0x850C90", VA = "0x180852490")]
			get
			{
				return default(KDIBIBAEMHB);
			}
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x7149A40", Offset = "0x7148240", VA = "0x187149A40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public GIOOMKAOGIP OLKMLOKNOAA
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0xAC6BF0", Offset = "0xAC53F0", VA = "0x180AC6BF0")]
			get
			{
				return default(GIOOMKAOGIP);
			}
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x7149A60", Offset = "0x7148260", VA = "0x187149A60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7149430", Offset = "0x7147C30", VA = "0x187149430", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x7149A20", Offset = "0x7148220", VA = "0x187149A20")]
		public DropdownTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class GraphicTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		[SerializeField]
		[GMBLIEHBOLK(EEKFPEEGEKF.Self, false, false, false)]
		private Graphic graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		[SerializeField]
		private bool useGraphicOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		[SerializeField]
		[BLIABGLLHHC("useGraphicOverride")]
		private Graphic graphicOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		[SerializeField]
		private OHJOOKLHOHO color;

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public Graphic IFPMNGKIHMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x714AA90", Offset = "0x7149290", VA = "0x18714AA90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public OHJOOKLHOHO BGHEAACLCDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x860AF0", Offset = "0x85F2F0", VA = "0x180860AF0")]
			get
			{
				return default(OHJOOKLHOHO);
			}
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x714AAA0", Offset = "0x71492A0", VA = "0x18714AAA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public bool JGCEKHKAALH
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x1020FD0", Offset = "0x101F7D0", VA = "0x181020FD0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x1020D50", Offset = "0x101F550", VA = "0x181020D50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public Color? HGPHEDDPHJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x714A870", Offset = "0x7149070", VA = "0x18714A870")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x714A670", Offset = "0x7148E70", VA = "0x18714A670", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x843520", Offset = "0x841D20", VA = "0x180843520")]
		public GraphicTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class InputFieldTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		[SerializeField]
		[GMBLIEHBOLK(EEKFPEEGEKF.Self, false, false, false)]
		private TMP_InputField inputField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		[SerializeField]
		[NOCFGPDPMKL(EEKFPEEGEKF.Self, false, false, false)]
		private Image surface;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		[SerializeField]
		private bool useSurfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		[SerializeField]
		[BLIABGLLHHC("useSurfaceOverride")]
		private Image surfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		[SerializeField]
		private PFIIEAGODFF inputFieldType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		[SerializeField]
		private GIOOMKAOGIP textSize;

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public Image EFEEHCELMLD
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x7149A30", Offset = "0x7148230", VA = "0x187149A30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public PFIIEAGODFF BOGPJJFONAM
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x852490", Offset = "0x850C90", VA = "0x180852490")]
			get
			{
				return default(PFIIEAGODFF);
			}
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x7149A40", Offset = "0x7148240", VA = "0x187149A40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public GIOOMKAOGIP OLKMLOKNOAA
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0xAC6BF0", Offset = "0xAC53F0", VA = "0x180AC6BF0")]
			get
			{
				return default(GIOOMKAOGIP);
			}
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x7149A60", Offset = "0x7148260", VA = "0x187149A60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x714AAF0", Offset = "0x71492F0", VA = "0x18714AAF0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x7149A20", Offset = "0x7148220", VA = "0x187149A20")]
		public InputFieldTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class LabelTheme : GraphicTheme
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		[SerializeField]
		[GMBLIEHBOLK(EEKFPEEGEKF.Self, false, false, false)]
		private TextMeshProUGUI textMeshProUGUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		[SerializeField]
		private PCIKHDIGHIK textType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		[SerializeField]
		private GIOOMKAOGIP textSize;

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public PCIKHDIGHIK GBALBDCOEAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x8E24D0", Offset = "0x8E0CD0", VA = "0x1808E24D0")]
			get
			{
				return default(PCIKHDIGHIK);
			}
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x714B2F0", Offset = "0x7149AF0", VA = "0x18714B2F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public GIOOMKAOGIP OLKMLOKNOAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0xAC6BE0", Offset = "0xAC53E0", VA = "0x180AC6BE0")]
			get
			{
				return default(GIOOMKAOGIP);
			}
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x714B2D0", Offset = "0x7149AD0", VA = "0x18714B2D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x714AFC0", Offset = "0x71497C0", VA = "0x18714AFC0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x714B2C0", Offset = "0x7149AC0", VA = "0x18714B2C0")]
		public LabelTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public class MakerPenToolTheme : ButtonThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		[Header("Maker Pen Tool")]
		[SerializeField]
		private JOGGJFDCJEA makerPenToolPaletteType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		[SerializeField]
		[Tooltip("A list of objects to show while the maker pen tool is active.")]
		private List<Hideable> hideWhenNotActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		[SerializeField]
		[Tooltip("A list of objects to show while the maker pen tool is inactive")]
		private List<Hideable> hideWhenActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		[SerializeField]
		private bool editorIsActiveOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x161")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		protected bool JPINKLFKKHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x162")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private bool LMAPBBKKHOE;

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public JOGGJFDCJEA CAJCIPGEELB
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0xB67950", Offset = "0xB66150", VA = "0x180B67950")]
			get
			{
				return default(JOGGJFDCJEA);
			}
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x71485C0", Offset = "0x7146DC0", VA = "0x1871485C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public bool PDCENHLCBFN
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x714B740", Offset = "0x7149F40", VA = "0x18714B740")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x714B750", Offset = "0x7149F50", VA = "0x18714B750")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x714B700", Offset = "0x7149F00", VA = "0x18714B700", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x714B310", Offset = "0x7149B10", VA = "0x18714B310", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x71485B0", Offset = "0x7146DB0", VA = "0x1871485B0")]
		public MakerPenToolTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class MixedToggleTheme : ButtonThemeBase
	{
		[Cpp2IlInjected.Token(Token = "0x2000060")]
		public enum NPLLALOKMHB
		{
			[Cpp2IlInjected.Token(Token = "0x40001B3")]
			Inactive,
			[Cpp2IlInjected.Token(Token = "0x40001B4")]
			Mixed,
			[Cpp2IlInjected.Token(Token = "0x40001B5")]
			Active
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		[SerializeField]
		private LCAFDMGKNMJ toggleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		[SerializeField]
		[Tooltip("A list of objects to hide while the toggle is inactive.")]
		private List<Hideable> hideWhenInactive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		[SerializeField]
		[Tooltip("A list of objects to hide while the toggle is mixed.")]
		private List<Hideable> hideWhenMixed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		[SerializeField]
		[Tooltip("A list of objects to hide while the toggle is active")]
		private List<Hideable> hideWhenActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		[SerializeField]
		private NPLLALOKMHB editorIsActiveOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private NPLLALOKMHB LMAPBBKKHOE;

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public NPLLALOKMHB PDCENHLCBFN
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x714C010", Offset = "0x714A810", VA = "0x18714C010")]
			get
			{
				return default(NPLLALOKMHB);
			}
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x714BFF0", Offset = "0x714A7F0", VA = "0x18714BFF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x714BFC0", Offset = "0x714A7C0", VA = "0x18714BFC0")]
		public void Toggle()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x714BFF0", Offset = "0x714A7F0", VA = "0x18714BFF0")]
		public void Toggle(NPLLALOKMHB LMAPBBKKHOE, bool JPINKLFKKHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x714BA10", Offset = "0x714A210", VA = "0x18714BA10", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x71485B0", Offset = "0x7146DB0", VA = "0x1871485B0")]
		public MixedToggleTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public class PaletteTheme : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		[SerializeField]
		private bool usePaletteOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		[SerializeField]
		[BLIABGLLHHC("usePaletteOverride")]
		private Palette paletteOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public LFHDLKLNBFG PaletteChangeEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		[SerializeField]
		private bool useDepth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private CKECBDNFIAF CIMEDMLCKMH;

		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		private const string GFAOEIBBJKA = "watch_layer";

		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		private const string EMOIGEAAKPA = "depth_multiplier";

		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private const float LOFHCLKDCPF = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		private float? CCHBGMABAGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private float? FJDECNFHIIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		private float? HDMJKBLHKFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		private float BLDFEKICBFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		private float LLLJEHGJEJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private float CFGLJPDLDFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private float PLLHCAFKLNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private readonly ADHBKFMFMPL MEJAONEJBEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private SFXAudioSource CJPMJGNJCKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		private SFXAudioSource ACFBGNPDLHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private ContentLoadingAudioPaletteAsset JPEAOAGMMHF;

		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		private const float NBAOOLBGFGN = 0.001f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private HILNIMOLCKN AIEOGNKMOAI;

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public Palette GHJMFEGLFEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x714E920", Offset = "0x714D120", VA = "0x18714E920")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public bool KGGLDKCICBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x993570", Offset = "0x991D70", VA = "0x180993570")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public float LOKKLJAHMKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x714E6A0", Offset = "0x714CEA0", VA = "0x18714E6A0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		private bool NMNPCBHOMEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x714D9D0", Offset = "0x714C1D0", VA = "0x18714D9D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		private bool KLBCGJKPPDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x714D950", Offset = "0x714C150", VA = "0x18714D950")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x714D520", Offset = "0x714BD20", VA = "0x18714D520")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x714D830", Offset = "0x714C030", VA = "0x18714D830")]
		private void GJPPJNDHOOI(MLOHNMNDENH.MLPNLLJAFJP GBOKDCHJCPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x714E0D0", Offset = "0x714C8D0", VA = "0x18714E0D0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x714DA50", Offset = "0x714C250", VA = "0x18714DA50")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x714D150", Offset = "0x714B950", VA = "0x18714D150")]
		private void AKKBLGHDJAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x714D400", Offset = "0x714BC00", VA = "0x18714D400")]
		public void AddLoadingSFXRequest(object OECMOOGGOOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x714E4C0", Offset = "0x714CCC0", VA = "0x18714E4C0")]
		public void RemoveLoadingSFXRequest(object OECMOOGGOOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x714DA50", Offset = "0x714C250", VA = "0x18714DA50")]
		private void LAOCMJDDNNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x714DC00", Offset = "0x714C400", VA = "0x18714DC00")]
		private void NOJEELHGECO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x714D6C0", Offset = "0x714BEC0", VA = "0x18714D6C0")]
		private void DLFPAJEKBKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x714D860", Offset = "0x714C060", VA = "0x18714D860")]
		private void IBALNINEICA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x714DDF0", Offset = "0x714C5F0", VA = "0x18714DDF0")]
		private void OAGANJJDFFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x714E200", Offset = "0x714CA00", VA = "0x18714E200")]
		private void POOHNMHCHBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x714D6B0", Offset = "0x714BEB0", VA = "0x18714D6B0")]
		private void BKKOCLIDGEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x714D310", Offset = "0x714BB10", VA = "0x18714D310")]
		private void ALLOJOLHJKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x714DBC0", Offset = "0x714C3C0", VA = "0x18714DBC0")]
		private void MLKKLKKIBDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x714E2F0", Offset = "0x714CAF0", VA = "0x18714E2F0")]
		public void Play2DUIFlavorSFX(RecRoomAudioClip[] KMFPDNPIKNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x714E5E0", Offset = "0x714CDE0", VA = "0x18714E5E0")]
		public PaletteTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public abstract class PaletteThemeReference : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		[SerializeField]
		[NOCFGPDPMKL(EEKFPEEGEKF.SelfAndParent, true, false, false)]
		private PaletteTheme paletteTheme;

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		protected PaletteTheme HBADICKHBAO
		{
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		protected Palette GHJMFEGLFEA
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x714CEC0", Offset = "0x714B6C0", VA = "0x18714CEC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		protected bool CMJLAEJAKJH
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x714CF70", Offset = "0x714B770", VA = "0x18714CF70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		protected Transform KOABLBCEPGJ
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x714CFF0", Offset = "0x714B7F0", VA = "0x18714CFF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x714C8C0", Offset = "0x714B0C0", VA = "0x18714C8C0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x714D070", Offset = "0x714B870", VA = "0x18714D070", Slot = "5")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void Apply();

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x714CD10", Offset = "0x714B510", VA = "0x18714CD10")]
		public Color? GetColorFromPalette(OHJOOKLHOHO LNIOMDOFGFA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x714C9C0", Offset = "0x714B1C0", VA = "0x18714C9C0")]
		private void CAOKMOMLKJK(bool JKGKEILANMN = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x843520", Offset = "0x841D20", VA = "0x180843520")]
		protected PaletteThemeReference()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public class RangeSliderTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		[SerializeField]
		[GMBLIEHBOLK(EEKFPEEGEKF.Self, false, false, false)]
		private RangeSlider slider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		[SerializeField]
		private PIDFAIANGLI sliderType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		[SerializeField]
		private Image sliderImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		[SerializeField]
		private Image fillImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		[SerializeField]
		private Image lowHandleImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		[SerializeField]
		private Image highHandleImage;

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public PIDFAIANGLI BACPNGBDIMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x84CE60", Offset = "0x84B660", VA = "0x18084CE60")]
			get
			{
				return default(PIDFAIANGLI);
			}
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x714FAA0", Offset = "0x714E2A0", VA = "0x18714FAA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public Image EPGHHNEJJBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x847480", Offset = "0x845C80", VA = "0x180847480")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public Image MIBPKMAPNMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x8474A0", Offset = "0x845CA0", VA = "0x1808474A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public Image MMJBMHMAEBI
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x8472C0", Offset = "0x845AC0", VA = "0x1808472C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public Image FDDGLHKNEFE
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x8473D0", Offset = "0x845BD0", VA = "0x1808473D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public bool EKODJKHBCCE
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x5E45C90", Offset = "0x5E44490", VA = "0x185E45C90")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x5E45B40", Offset = "0x5E44340", VA = "0x185E45B40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x714F7A0", Offset = "0x714DFA0", VA = "0x18714F7A0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x843520", Offset = "0x841D20", VA = "0x180843520")]
		public RangeSliderTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public class RawImageTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		[SerializeField]
		[GMBLIEHBOLK(EEKFPEEGEKF.Self, false, false, false)]
		private RawImage image;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		[SerializeField]
		private ODJBAHALLGF color;

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public ODJBAHALLGF GAEMFGMBHJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x84CE60", Offset = "0x84B660", VA = "0x18084CE60")]
			get
			{
				return default(ODJBAHALLGF);
			}
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x714FAA0", Offset = "0x714E2A0", VA = "0x18714FAA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x714FAC0", Offset = "0x714E2C0", VA = "0x18714FAC0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x843520", Offset = "0x841D20", VA = "0x180843520")]
		public RawImageTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class RecyclingGridTheme : RecyclingThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		[SerializeField]
		[GMBLIEHBOLK(EEKFPEEGEKF.Self, false, false, false)]
		private ACGBLNDJLOI recyclingGrid;

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x714FC00", Offset = "0x714E400", VA = "0x18714FC00", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x714FE00", Offset = "0x714E600", VA = "0x18714FE00", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x714FFF0", Offset = "0x714E7F0", VA = "0x18714FFF0")]
		private void PHKAJJPGNJK(float BAKHGDOEBHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x7150060", Offset = "0x714E860", VA = "0x187150060")]
		public RecyclingGridTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class RecyclingListTheme : RecyclingThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		[SerializeField]
		[GMBLIEHBOLK(EEKFPEEGEKF.Self, false, false, false)]
		private ACGBLNDJLOI recyclingList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private bool GONFHPNGPPG;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x7150070", Offset = "0x714E870", VA = "0x187150070", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x7150320", Offset = "0x714EB20", VA = "0x187150320", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x71502B0", Offset = "0x714EAB0", VA = "0x1871502B0")]
		private void DJDALNDIPFO(float BAKHGDOEBHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x7150060", Offset = "0x714E860", VA = "0x187150060")]
		public RecyclingListTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public abstract class RecyclingThemeBase : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		[Header("Audio")]
		[SerializeField]
		private KJFFENHNMMM recyclingAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		protected RecyclingAudioPaletteAsset OJOHEAELOLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		[SerializeField]
		private LMLKAMBELPN scrollingAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		private ScrollingAudioPaletteAsset ANOLGCMABBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		private HILNIMOLCKN JDNFNAHDDAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		private float DIAOAJIPBPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		private float KDEJGDNMNBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		private float PCOIBKJHJFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private float CJHNEAILLOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private bool OIHMODBPBHO;

		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private const float GIDIOAIFGHJ = 0.01f;

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		private HILNIMOLCKN AIEOGNKMOAI
		{
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x7150CD0", Offset = "0x714F4D0", VA = "0x187150CD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x7150520", Offset = "0x714ED20", VA = "0x187150520", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x7150D40", Offset = "0x714F540", VA = "0x187150D40")]
		protected void JGBOGHMPLFP(bool GFMKBNNJNGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7150AD0", Offset = "0x714F2D0", VA = "0x187150AD0")]
		protected void HPFEEBLDODH(GameObject ECMCDEIDGLC, int KJKNLOKPNID, bool EMJCKGEJHPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x7150710", Offset = "0x714EF10", VA = "0x187150710")]
		protected void EOFMKOIAAFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x7151000", Offset = "0x714F800", VA = "0x187151000")]
		protected void JPEMAHBIIIH(float BAKHGDOEBHI, float KOIDPNLPBMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x7151260", Offset = "0x714FA60", VA = "0x187151260")]
		private void LKHAINCFOMG(float HFKGPCEICHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x7150910", Offset = "0x714F110", VA = "0x187150910")]
		private void FALFONLIKIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x7150060", Offset = "0x714E860", VA = "0x187150060")]
		protected RecyclingThemeBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public class ScrollBarTheme : SelectableThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		[Header("Scroll Bar Audio")]
		[SerializeField]
		private MDPOGNILHGD buttonAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		[SerializeField]
		[Tooltip("Layer a 2D SFX on top of base button sounds")]
		private bool useFlavorSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		[SerializeField]
		[BLIABGLLHHC("useFlavorSFX")]
		[Tooltip("Flavor SFX is picked randomly from this pool config")]
		private RecRoomAudioClipPoolConfig flavorSFXClipPoolConfig;

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x71514D0", Offset = "0x714FCD0", VA = "0x1871514D0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x71515F0", Offset = "0x714FDF0", VA = "0x1871515F0")]
		public ScrollBarTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class ScrollRectTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private const string KEOOOJBLPKO = "RRUI.PlayHittingEndsSFX";

		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		private const int IPHAANCBNHG = 5;

		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		private const int LOBEKAJGBPJ = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private DateTimeOffset DGDBIBKINKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private int GLKPDAAHEDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private bool LLBJFFFEIOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		[SerializeField]
		[GMBLIEHBOLK(EEKFPEEGEKF.Self, false, false, false)]
		private ScrollRect scrollRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		[Header("Audio")]
		[SerializeField]
		private LMLKAMBELPN scrollAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private ScrollingAudioPaletteAsset OJOHEAELOLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private HILNIMOLCKN JDNFNAHDDAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private ALCFACDALIF FHKHHPKEMLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		private float KDEJGDNMNBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		private float PCOIBKJHJFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		private float CJHNEAILLOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		private bool OIHMODBPBHO;

		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private const float GIDIOAIFGHJ = 0.01f;

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		private HILNIMOLCKN AIEOGNKMOAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x71527E0", Offset = "0x7150FE0", VA = "0x1871527E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		private ALCFACDALIF JOEIFOCKFDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x7152AC0", Offset = "0x71512C0", VA = "0x187152AC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x71516E0", Offset = "0x714FEE0", VA = "0x1871516E0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x7152C50", Offset = "0x7151450", VA = "0x187152C50", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7151600", Offset = "0x714FE00", VA = "0x187151600", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7152510", Offset = "0x7150D10", VA = "0x187152510")]
		private void FJJCLBLIGGM(Vector2 GBKEBGLIOFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x7152850", Offset = "0x7151050", VA = "0x187152850")]
		private void LKHAINCFOMG(float HFKGPCEICHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x71518F0", Offset = "0x71500F0", VA = "0x1871518F0")]
		private void FALFONLIKIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x7152B30", Offset = "0x7151330", VA = "0x187152B30")]
		private static string NCOLGBJEPOJ(GameObject GHDJADLHPAA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x7152D40", Offset = "0x7151540", VA = "0x187152D40")]
		public ScrollRectTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public abstract class SelectableThemeBase : PaletteThemeReference, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IPointerClickHandler, IPointerEnterHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		[SerializeField]
		[GMBLIEHBOLK(EEKFPEEGEKF.Self, false, false, false)]
		[Header("Selectable Theme Base")]
		[FormerlySerializedAs("button")]
		private Selectable selectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		[SerializeField]
		[FormerlySerializedAs("overrideAudio")]
		[Header("Legacy Audio Override")]
		[Tooltip("Override base selectable audio with a single SFX that plays only on click.")]
		protected bool overrideWithSingleAudio;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		[SerializeField]
		[BLIABGLLHHC("overrideWithSingleAudio")]
		[Tooltip("The legacy override audio will be randomly picked from this pool")]
		protected RecRoomAudioClip[] randomAudioOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		protected bool NGPAAKHLOMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		private ButtonAudioPaletteAsset OJOHEAELOLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		private RecRoomAudioClipPoolConfig KNFGIMNHGKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		private ADHBKFMFMPL IBMHBOLHCEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		private ADHBKFMFMPL MJANACNHCEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		private ADHBKFMFMPL MEFKPCHEBGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		private ADHBKFMFMPL FLKDNNELGOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		private HILNIMOLCKN JDNFNAHDDAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		private KBDFEFJFMFB COMGOEMPKML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private BNGGLLHEGAJ NEPNBAMNDPM;

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		protected Selectable MIPOLLBNNFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x84A260", Offset = "0x848A60", VA = "0x18084A260")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		protected virtual bool DNAABJGAPKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x85D960", Offset = "0x85C160", VA = "0x18085D960", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		public bool EKODJKHBCCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x5E45C90", Offset = "0x5E44490", VA = "0x185E45C90")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x5E45B40", Offset = "0x5E44340", VA = "0x185E45B40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		private HILNIMOLCKN AIEOGNKMOAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x7153510", Offset = "0x7151D10", VA = "0x187153510")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		protected KBDFEFJFMFB GIEMFLLIBLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x7152EC0", Offset = "0x71516C0", VA = "0x187152EC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		private BNGGLLHEGAJ PKMLJCBKDJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x7153410", Offset = "0x7151C10", VA = "0x187153410")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x7153310", Offset = "0x7151B10", VA = "0x187153310")]
		protected void HAFGHCDGLEJ(ButtonAudioPaletteAsset BIJJPIBKPGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x8472D0", Offset = "0x845AD0", VA = "0x1808472D0")]
		protected void OOMOPIFHKBK(RecRoomAudioClipPoolConfig APJOFBOFBIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x7153930", Offset = "0x7152130", VA = "0x187153930", Slot = "12")]
		public virtual void OnPointerDown(PointerEventData BNEKFHGOPID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x7153BA0", Offset = "0x71523A0", VA = "0x187153BA0", Slot = "13")]
		public virtual void OnPointerUp(PointerEventData BNEKFHGOPID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x7153580", Offset = "0x7151D80", VA = "0x187153580", Slot = "14")]
		public virtual void OnPointerClick(PointerEventData BNEKFHGOPID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x7153A70", Offset = "0x7152270", VA = "0x187153A70", Slot = "15")]
		public virtual void OnPointerEnter(PointerEventData BNEKFHGOPID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x7153490", Offset = "0x7151C90", VA = "0x187153490")]
		private void IALIADMGKPF(RecRoomAudioClip[] FIELABGHPIN, bool JMMKNBFLMAF = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x7152F30", Offset = "0x7151730", VA = "0x187152F30")]
		private void DBNAILDFECC(RecRoomAudioClip OKKPJJCPFED, bool JMMKNBFLMAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x7153D10", Offset = "0x7152510", VA = "0x187153D10")]
		public void SetOnPointerDownSoundEffectDisabled(object OECMOOGGOOF, bool PNAIHEEOCMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x7153D70", Offset = "0x7152570", VA = "0x187153D70")]
		public void SetOnPointerUpSoundEffectDisabled(object OECMOOGGOOF, bool PNAIHEEOCMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x7153CE0", Offset = "0x71524E0", VA = "0x187153CE0")]
		public void SetOnPointerClickSoundEffectDisabled(object OECMOOGGOOF, bool PNAIHEEOCMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x7153D40", Offset = "0x7152540", VA = "0x187153D40")]
		public void SetOnPointerEnterSoundEffectDisabled(object OECMOOGGOOF, bool PNAIHEEOCMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x7152E80", Offset = "0x7151680", VA = "0x187152E80")]
		private void CGHKFBJDJJM(ADHBKFMFMPL DNLBGNBJLAH, object OECMOOGGOOF, bool PNAIHEEOCMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x7153DA0", Offset = "0x71525A0", VA = "0x187153DA0")]
		protected SelectableThemeBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public class SliderTheme : SelectableThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		[GMBLIEHBOLK(EEKFPEEGEKF.Self, false, false, false)]
		[Header("Slider Visual")]
		[SerializeField]
		private Slider slider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		[SerializeField]
		private PIDFAIANGLI sliderType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		[Header("Slider Audio")]
		[SerializeField]
		private MDPOGNILHGD buttonAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		[SerializeField]
		[Tooltip("Layer a 2D SFX on top of base button sounds")]
		private bool useFlavorSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		[BLIABGLLHHC("useFlavorSFX")]
		[Tooltip("Flavor SFX is picked randomly from this pool config")]
		[SerializeField]
		private RecRoomAudioClipPoolConfig flavorSFXClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		[SerializeField]
		private Image sliderImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		[SerializeField]
		private Image fillImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		[SerializeField]
		private Image handleImage;

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		public PIDFAIANGLI BACPNGBDIMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x851420", Offset = "0x84FC20", VA = "0x180851420")]
			get
			{
				return default(PIDFAIANGLI);
			}
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x7154380", Offset = "0x7152B80", VA = "0x187154380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		public Image EPGHHNEJJBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x849990", Offset = "0x848190", VA = "0x180849990")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		public Image MIBPKMAPNMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0xB2CC50", Offset = "0xB2B450", VA = "0x180B2CC50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public Image JABEJMHADPJ
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x90BEF0", Offset = "0x90A6F0", VA = "0x18090BEF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x7153FB0", Offset = "0x71527B0", VA = "0x187153FB0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x7154360", Offset = "0x7152B60", VA = "0x187154360")]
		public SliderTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class SurfaceTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		[SerializeField]
		[GMBLIEHBOLK(EEKFPEEGEKF.Self, false, false, false)]
		private Image image;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		[SerializeField]
		[NOCFGPDPMKL(EEKFPEEGEKF.Self, false, false, false)]
		private UIGradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		[SerializeField]
		private DNGCPANLNIN color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		[SerializeField]
		[BLIABGLLHHC("gradient")]
		private bool ignoreGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		[SerializeField]
		[Tooltip("The surface theme determines if this Image is a RaycastTarget or not. There are times when you might want to ignore that setting of the palette theme and just respect whatever is the default state on the Image.")]
		private bool ignoreSettingRaycastTarget;

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public DNGCPANLNIN FHKPFLIOBNN
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x84B8F0", Offset = "0x84A0F0", VA = "0x18084B8F0")]
			get
			{
				return default(DNGCPANLNIN);
			}
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x7154600", Offset = "0x7152E00", VA = "0x187154600")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x71543A0", Offset = "0x7152BA0", VA = "0x1871543A0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x843520", Offset = "0x841D20", VA = "0x180843520")]
		public SurfaceTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class SwitchTheme : ToggleTheme
	{
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private const float AEICHPBPHGN = 0.33f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		[Header("Switch")]
		[SerializeField]
		private GameObject indicator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		[SerializeField]
		private GameObject indicatorOffPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		[SerializeField]
		private GameObject indicatorOnPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		private BIOIMFCEIEB KMICBEBOFJJ;

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x7154620", Offset = "0x7152E20", VA = "0x187154620", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x7154880", Offset = "0x7153080", VA = "0x187154880")]
		public SwitchTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public class TilerTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		[SerializeField]
		[GMBLIEHBOLK(EEKFPEEGEKF.Self, false, false, false)]
		private UITiler tiler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		[SerializeField]
		private MFPEJMPNFCJ type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private KILDCHCFPFK GGKFPGKLGAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private MLMKJMMJKJO JKCLAIAGOHD;

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		private MLMKJMMJKJO KCBKHHPDCHA
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x7155470", Offset = "0x7153C70", VA = "0x187155470")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		private JJKHHALDDNJ DOOLJJKCONB
		{
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x7155360", Offset = "0x7153B60", VA = "0x187155360")]
			get
			{
				return default(JJKHHALDDNJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x71552F0", Offset = "0x7153AF0", VA = "0x1871552F0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x7154F30", Offset = "0x7153730", VA = "0x187154F30", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x843520", Offset = "0x841D20", VA = "0x180843520")]
		public TilerTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public class ToggleTheme : ButtonThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		[Header("Toggle Visual")]
		[SerializeField]
		private MBLPOAPHCIP toggleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		[SerializeField]
		[Tooltip("A list of objects to show while the toggle is active.")]
		private List<Hideable> hideWhenNotActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		[SerializeField]
		[Tooltip("A list of objects to show while the toggle is inactive")]
		private List<Hideable> hideWhenActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		[SerializeField]
		private bool editorIsActiveOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x161")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		[Header("Toggle Audio")]
		[SerializeField]
		[Tooltip("Override the audio palette when active defined by the toggle's visual with a custom palette")]
		private bool overrideAudioPaletteWhenActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		[SerializeField]
		[BLIABGLLHHC("overrideAudioPaletteWhenActive")]
		[Tooltip("Specify a custom config to use for toggle button audio when active")]
		private ButtonAudioPaletteAsset customButtonAudioConfigWhenActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		[SerializeField]
		[Tooltip("Override the audio palette when inactive defined by the toggle's visual with a custom palette")]
		private bool overrideAudioPaletteWhenInactive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		[Tooltip("Specify a custom config to use for toggle button audio when inactive")]
		[SerializeField]
		[BLIABGLLHHC("overrideAudioPaletteWhenInactive")]
		private ButtonAudioPaletteAsset customButtonAudioConfigWhenInactive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		[SerializeField]
		[Tooltip("Layer a 2D SFX on top of base button sounds. Flavor SFX only plays when toggling from inactive to active")]
		private bool useFlavorSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		[SerializeField]
		[BLIABGLLHHC("useFlavorSFX")]
		[Tooltip("Flavor SFX is picked randomly from this pool config")]
		private RecRoomAudioClipPoolConfig flavorSFXClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		protected bool JPINKLFKKHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x191")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		private bool CBLJPPGMNJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x192")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		private bool LMAPBBKKHOE;

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public bool PDCENHLCBFN
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x7155980", Offset = "0x7154180", VA = "0x187155980")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x7155990", Offset = "0x7154190", VA = "0x187155990")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public MBLPOAPHCIP JEJBPPFJAOK
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0xB67950", Offset = "0xB66150", VA = "0x180B67950")]
			get
			{
				return default(MBLPOAPHCIP);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x71485C0", Offset = "0x7146DC0", VA = "0x1871485C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		protected override bool DNAABJGAPKH
		{
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x71558F0", Offset = "0x71540F0", VA = "0x1871558F0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x71558B0", Offset = "0x71540B0", VA = "0x1871558B0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x7155940", Offset = "0x7154140", VA = "0x187155940")]
		public void Toggle()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x7155900", Offset = "0x7154100", VA = "0x187155900")]
		public void Toggle(bool LMAPBBKKHOE, bool JPINKLFKKHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x71554D0", Offset = "0x7153CD0", VA = "0x1871554D0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x7154880", Offset = "0x7153080", VA = "0x187154880")]
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
