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
	public class MultiGraphicButton : Button
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private List<Graphic> additionalGraphics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private ColorBlock additionalGraphicsColors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[SerializeField]
		private UIGradient backgroundGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[SerializeField]
		private GradientBlock backgroundGradients;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[SerializeField]
		private bool rejectSelectedState;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public List<Graphic> CAALFBODOAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0xA65BA0", Offset = "0xA643A0", VA = "0x180A65BA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0xA65D40", Offset = "0xA64540", VA = "0x180A65D40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public ColorBlock GFJAHDGGIOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xBC2280", Offset = "0xBC0A80", VA = "0x180BC2280")]
			get
			{
				return default(ColorBlock);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xBC2310", Offset = "0xBC0B10", VA = "0x180BC2310")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public UIGradient FIHJAOFLBHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xBC22D0", Offset = "0xBC0AD0", VA = "0x180BC22D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xBC2360", Offset = "0xBC0B60", VA = "0x180BC2360")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public GradientBlock BCGFKKOOPHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xBC22E0", Offset = "0xBC0AE0", VA = "0x180BC22E0")]
			get
			{
				return default(GradientBlock);
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xBC2370", Offset = "0xBC0B70", VA = "0x180BC2370")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xBC20D0", Offset = "0xBC08D0", VA = "0x180BC20D0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xBC2120", Offset = "0xBC0920", VA = "0x180BC2120", Slot = "36")]
		public override void OnSelect(BaseEventData CBLNAPKAJBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xBC2170", Offset = "0xBC0970", VA = "0x180BC2170")]
		public void Refresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xBC1C40", Offset = "0xBC0440", VA = "0x180BC1C40", Slot = "26")]
		protected override void DoStateTransition(SelectionState LLBKKANHBEL, bool MALHBDBALAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xBC1FF0", Offset = "0xBC07F0", VA = "0x180BC1FF0")]
		private void JKGEPGMKEEM(Graphic DOHMHIOBNNH, Color MAGKCELEODA, bool MALHBDBALAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xBC1EF0", Offset = "0xBC06F0", VA = "0x180BC1EF0")]
		private void HOAIMPFIPIC(SelectionState LLBKKANHBEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xBC21A0", Offset = "0xBC09A0", VA = "0x180BC21A0")]
		public MultiGraphicButton()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class ThemesConfig : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static ThemesConfig _instance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		private Palette _light;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		private Palette _dark;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static ThemesConfig Instance
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xBCAE50", Offset = "0xBC9650", VA = "0x180BCAE50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public Palette Active
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xBCAE20", Offset = "0xBC9620", VA = "0x180BCAE20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xBCADE0", Offset = "0xBC95E0", VA = "0x180BCADE0")]
		public ThemesConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class FontsConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public struct LocalizedFontMaterialOverrideMapping
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public Material NonLocalizedFontOverrideMaterial;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public Material LocalizedFontOverrideMaterial;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public struct LocalizedFontMapping
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public TMP_FontAsset FontAsset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public TMP_FontAsset LocalizedFontAsset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public LocalizedFontMaterialOverrideMapping[] FontOverrideMaterials;
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class LDMLCPGHCOF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public TMP_FontAsset font;

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
			public LDMLCPGHCOF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0xBC0990", Offset = "0xBBF190", VA = "0x180BC0990")]
			internal bool HHNLPEKOLFH(LocalizedFontMapping x)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static FontsConfig _instance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[SerializeField]
		[Tooltip("Mapping of non-localized font assets to their localized counterparts. By default text fields will forcibly revert to non-localized fonts unless the `AllowsNonLatinCharacters` component is present.")]
		private LocalizedFontMapping[] localizedFontMappings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[SerializeField]
		[Tooltip("Emoji asset to use when text fields mark themselves as allowing emoji using the `AllowsEmojis` component.")]
		private TMP_SpriteAsset emojiAsset;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static FontsConfig Instance
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xBBFB70", Offset = "0xBBE370", VA = "0x180BBFB70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public TMP_SpriteAsset EmojiAsset
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8ACF00", Offset = "0x8AB700", VA = "0x1808ACF00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xBBF680", Offset = "0xBBDE80", VA = "0x180BBF680")]
		public bool KBEFLHBKBNC(TMP_FontAsset DJKJLIMANNG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xBBF7C0", Offset = "0xBBDFC0", VA = "0x180BBF7C0")]
		public TMP_FontAsset KHDMHJINCHG(TMP_FontAsset DJKJLIMANNG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xBBF8C0", Offset = "0xBBE0C0", VA = "0x180BBF8C0")]
		public TMP_FontAsset KHDMHJINCHG(TMP_FontAsset DJKJLIMANNG, Material DJHMOJAKINL, out Material BKMBEMOABEB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xBBF340", Offset = "0xBBDB40", VA = "0x180BBF340")]
		public TMP_FontAsset GCFPIDHKPPC(TMP_FontAsset DJKJLIMANNG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xBBF440", Offset = "0xBBDC40", VA = "0x180BBF440")]
		public TMP_FontAsset GCFPIDHKPPC(TMP_FontAsset DJKJLIMANNG, Material DJHMOJAKINL, out Material DPBBECJOFFP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xBBFAB0", Offset = "0xBBE2B0", VA = "0x180BBFAB0")]
		private static bool MKDMPICGFOD(TMP_FontAsset DJKJLIMANNG, LocalizedFontMapping IDCAMNJLHEF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xBBBD50", Offset = "0xBBA550", VA = "0x180BBBD50")]
		public FontsConfig()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct GradientBlock : IEquatable<GradientBlock>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[SerializeField]
		public Gradient normalGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[SerializeField]
		public Gradient highlightedGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		public Gradient pressedGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[SerializeField]
		public Gradient selectedGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[SerializeField]
		public Gradient disabledGradient;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xBBFD70", Offset = "0xBBE570", VA = "0x180BBFD70", Slot = "0")]
		public override bool Equals(object HHNPCHNMLMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xBBFE80", Offset = "0xBBE680", VA = "0x180BBFE80", Slot = "4")]
		public bool Equals(GradientBlock MDHJAFNLPON)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xBBFE80", Offset = "0xBBE680", VA = "0x180BBFE80")]
		public static bool FMMDKFLNNFA(GradientBlock OHFJEPKOEEM, GradientBlock JJJCHKJIKDB)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xBBFCF0", Offset = "0xBBE4F0", VA = "0x180BBFCF0")]
		public static bool BDPOAMCDIDB(GradientBlock OHFJEPKOEEM, GradientBlock JJJCHKJIKDB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xBBFF00", Offset = "0xBBE700", VA = "0x180BBFF00", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
namespace RRUI.Theme
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class MenuAudioPaletteAsset : BaseAudioPaletteAsset
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[SerializeField]
		[Header("Menu Open")]
		private RecRoomAudioClipPoolConfig menuHydrateAudioClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		private RecRoomAudioClipPoolConfig menuOpen2DFlavorAudioClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[SerializeField]
		[Header("Menu Close")]
		private RecRoomAudioClipPoolConfig menuDehydrateAudioClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private RecRoomAudioClipPoolConfig menuClose2DFlavorAudioClipPoolConfig;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public RecRoomAudioClip[] MenuHydrateAudioClipPool
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xBC13E0", Offset = "0xBBFBE0", VA = "0x180BC13E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public RecRoomAudioClip[] MenuOpen2DFlavorAudioClipPool
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xBC1470", Offset = "0xBBFC70", VA = "0x180BC1470")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public RecRoomAudioClip[] MenuDehydrateAudioClipPool
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xBC1350", Offset = "0xBBFB50", VA = "0x180BC1350")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public RecRoomAudioClip[] MenuClose2DFlavorAudioClipPool
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xBC12C0", Offset = "0xBBFAC0", VA = "0x180BC12C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xBBBBB0", Offset = "0xBBA3B0", VA = "0x180BBBBB0")]
		public MenuAudioPaletteAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class ButtonAudioPaletteAsset : BaseAudioPaletteAsset
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[SerializeField]
		private RecRoomAudioClipPoolConfig pointerDownAudioClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[SerializeField]
		private RecRoomAudioClipPoolConfig pointerUpAudioClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		private RecRoomAudioClipPoolConfig pointerClickAudioClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[SerializeField]
		private RecRoomAudioClipPoolConfig pointerEnterAudioClipPoolConfig;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public RecRoomAudioClip[] PointerDownAudioClipPool
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xBBBE30", Offset = "0xBBA630", VA = "0x180BBBE30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public RecRoomAudioClip[] PointerUpAudioClipPool
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xBBBF50", Offset = "0xBBA750", VA = "0x180BBBF50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public RecRoomAudioClip[] PointerClickAudioClipPool
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xBBBDA0", Offset = "0xBBA5A0", VA = "0x180BBBDA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public RecRoomAudioClip[] PointerEnterAudioClipPool
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xBBBEC0", Offset = "0xBBA6C0", VA = "0x180BBBEC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xBBBBB0", Offset = "0xBBA3B0", VA = "0x180BBBBB0")]
		public ButtonAudioPaletteAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class ButtonAnimationPalette : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[SerializeField]
		private float clickAnimationDuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[SerializeField]
		private float clickAnimationScale;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public float ClickAnimationDuration
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xBBBD80", Offset = "0xBBA580", VA = "0x180BBBD80")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public float ClickAnimationScale
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xBBBD90", Offset = "0xBBA590", VA = "0x180BBBD90")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xBBBD60", Offset = "0xBBA560", VA = "0x180BBBD60")]
		public ButtonAnimationPalette()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class ScrollBarTheme : SelectableThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[SerializeField]
		[Header("Scroll Bar Audio")]
		private MBHCJDDDHIK buttonAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[SerializeField]
		[Tooltip("Layer a 2D SFX on top of base button sounds")]
		private bool useFlavorSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[SerializeField]
		[Tooltip("Flavor SFX is picked randomly from this pool config")]
		[LEKNNDJMFFO("useFlavorSFX")]
		private RecRoomAudioClipPoolConfig flavorSFXClipPoolConfig;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xBC7290", Offset = "0xBC5A90", VA = "0x180BC7290", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xBC73B0", Offset = "0xBC5BB0", VA = "0x180BC73B0")]
		public ScrollBarTheme()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class TilerPalette
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[SerializeField]
		private Sprite sprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[SerializeField]
		private Color tintColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[SerializeField]
		private Color backgroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[SerializeField]
		private float rows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[SerializeField]
		private float rowsWhenPortrait;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[SerializeField]
		private Vector2 spacing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[SerializeField]
		private float offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[SerializeField]
		private Vector2 velocity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[SerializeField]
		[Range(0f, 360f)]
		private float angle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[SerializeField]
		private UITiler.NNJMPEJKFOG animationDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[SerializeField]
		private float primaryAnimationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[SerializeField]
		private float altAnimationSpeed;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Sprite Sprite
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x85D1E0", Offset = "0x85B9E0", VA = "0x18085D1E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Color TintColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x8CDE30", Offset = "0x8CC630", VA = "0x1808CDE30")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Color BackgroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x8CDE20", Offset = "0x8CC620", VA = "0x1808CDE20")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public Vector2 Spacing
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xBCB060", Offset = "0xBC9860", VA = "0x180BCB060")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float Offset
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xBCB040", Offset = "0xBC9840", VA = "0x180BCB040")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Vector2 Velocity
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xBCB080", Offset = "0xBC9880", VA = "0x180BCB080")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public float Angle
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xBCB030", Offset = "0xBC9830", VA = "0x180BCB030")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public UITiler.NNJMPEJKFOG AnimationDirection
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xA36260", Offset = "0xA34A60", VA = "0x180A36260")]
			get
			{
				return default(UITiler.NNJMPEJKFOG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float PrimaryAnimationSpeed
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xBCB050", Offset = "0xBC9850", VA = "0x180BCB050")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float AltAnimationSpeed
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xBCB020", Offset = "0xBC9820", VA = "0x180BCB020")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xBCAF90", Offset = "0xBC9790", VA = "0x180BCAF90")]
		public float AJHABMMPGJO(DBCICEJFIGD DHFEMAFLFOF)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xBCAFB0", Offset = "0xBC97B0", VA = "0x180BCAFB0")]
		public TilerPalette()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public abstract class SelectableThemeBase : PaletteThemeReference, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IPointerClickHandler, IPointerEnterHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		[SerializeField]
		[Header("Selectable Theme Base")]
		[HHGPBADECGL(MGNIEFNKKLA.Self, false, false, false)]
		[FormerlySerializedAs("button")]
		private Selectable selectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[SerializeField]
		[Header("Legacy Audio Override")]
		[FormerlySerializedAs("overrideAudio")]
		[Tooltip("Override base selectable audio with a single SFX that plays only on click.")]
		protected bool overrideWithSingleAudio;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[SerializeField]
		[LEKNNDJMFFO("overrideWithSingleAudio")]
		[Tooltip("The legacy override audio will be randomly picked from this pool")]
		protected RecRoomAudioClip[] randomAudioOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		protected bool OLEIAHODBHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private ButtonAudioPaletteAsset AMDOKPIHBJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private RecRoomAudioClipPoolConfig GHIMABGGGOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private AOHHOPAIALB FHDBGEBKHNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private FPODAMBEHMF NOOODOIGEEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private HAOMCPLNIHN IGOOPOPIFOB;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		protected Selectable FAHDONHKCKG
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x8ACF00", Offset = "0x8AB700", VA = "0x1808ACF00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		protected virtual bool GNOBMDCIAFP
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x811740", Offset = "0x80FF40", VA = "0x180811740", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool HDLGCEHMIMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xBC5720", Offset = "0xBC3F20", VA = "0x180BC5720")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xBC5740", Offset = "0xBC3F40", VA = "0x180BC5740")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private AOHHOPAIALB OBGKDOHCIGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xBC9000", Offset = "0xBC7800", VA = "0x180BC9000")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		protected FPODAMBEHMF HGLBCDNHGEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xBC90E0", Offset = "0xBC78E0", VA = "0x180BC90E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private HAOMCPLNIHN MFDHMPIGPFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xBC9070", Offset = "0xBC7870", VA = "0x180BC9070")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xBC9CB0", Offset = "0xBC84B0", VA = "0x180BC9CB0")]
		protected void PIPHLHLHHNE(ButtonAudioPaletteAsset BEGEFEAMLFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA28B40", Offset = "0xA27340", VA = "0x180A28B40")]
		protected void DPMJDKKOMGA(RecRoomAudioClipPoolConfig BGOBOMHOCFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xBC9900", Offset = "0xBC8100", VA = "0x180BC9900", Slot = "12")]
		public virtual void OnPointerDown(PointerEventData CBLNAPKAJBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xBC9B70", Offset = "0xBC8370", VA = "0x180BC9B70", Slot = "13")]
		public virtual void OnPointerUp(PointerEventData CBLNAPKAJBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xBC9530", Offset = "0xBC7D30", VA = "0x180BC9530", Slot = "14")]
		public virtual void OnPointerClick(PointerEventData CBLNAPKAJBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xBC9A40", Offset = "0xBC8240", VA = "0x180BC9A40", Slot = "15")]
		public virtual void OnPointerEnter(PointerEventData CBLNAPKAJBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xBC8F80", Offset = "0xBC7780", VA = "0x180BC8F80")]
		private void AKGHOHELPHC(RecRoomAudioClip[] GLENKIGIOAA, bool JLGKMPDEMFB = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xBC9150", Offset = "0xBC7950", VA = "0x180BC9150")]
		private void NMLCEMCANDC(RecRoomAudioClip ILAGKMAKNHE, bool JLGKMPDEMFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xBC9DD0", Offset = "0xBC85D0", VA = "0x180BC9DD0")]
		protected SelectableThemeBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class MixedTogglePalette
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		private enum IAOPCHIPFNG
		{
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			UseBaseInactive,
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			UseBaseActive,
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			UseCustom
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		private AACPPIMGFIP baseTogglePalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private IAOPCHIPFNG mixedPaletteType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[SerializeField]
		[LEKNNDJMFFO("mixedPaletteType", 2)]
		private ButtonPalette mixedButtonPalette;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xBC1570", Offset = "0xBBFD70", VA = "0x180BC1570")]
		public TogglePalette EKNBJNCEFBN(Palette CFAOEFMKCHD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xBC1500", Offset = "0xBBFD00", VA = "0x180BC1500")]
		public ButtonPalette BHIHCBKEIPL(Palette CFAOEFMKCHD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xBC15A0", Offset = "0xBBFDA0", VA = "0x180BC15A0")]
		public MixedTogglePalette()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public abstract class RecyclingThemeBase : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[SerializeField]
		[Header("Audio")]
		private CGKHHPHPKGH recyclingAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		protected RecyclingAudioPaletteAsset AMDOKPIHBJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[SerializeField]
		private KOPACFMHODN scrollingAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private ScrollingAudioPaletteAsset AOIBFFLPFHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private AOHHOPAIALB FHDBGEBKHNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private float IBKGKFFOONH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private float BHOCJDFBHIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private float GKNOOFFBCHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private float CHFABMIHOBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private bool EJLENOGNKEB;

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private const float PMMLKMOBNIJ = 0.01f;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private AOHHOPAIALB OBGKDOHCIGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xBC6600", Offset = "0xBC4E00", VA = "0x180BC6600")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xBC63F0", Offset = "0xBC4BF0", VA = "0x180BC63F0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xBC6A80", Offset = "0xBC5280", VA = "0x180BC6A80")]
		protected void KLPHGFBCGDA(bool MNNPIACJMFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xBC6A70", Offset = "0xBC5270", VA = "0x180BC6A70")]
		protected void KBLEECLOEJA(GameObject FHJBBMIILLG, int MBNOPHIGKGE, bool JFKPJBACPEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xBC6860", Offset = "0xBC5060", VA = "0x180BC6860")]
		protected void KALALIAPNDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xBC6D60", Offset = "0xBC5560", VA = "0x180BC6D60")]
		protected void PAJLLELOLBP(float NAOEMMMJJLE, float AKNOFPAINMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xBC6670", Offset = "0xBC4E70", VA = "0x180BC6670")]
		private void DJHOELECICD(float MHOGCFCMOOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xBC70E0", Offset = "0xBC58E0", VA = "0x180BC70E0")]
		private void PFCLEOFMGFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xBC7230", Offset = "0xBC5A30", VA = "0x180BC7230")]
		protected RecyclingThemeBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class SwitchTheme : ToggleTheme
	{
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private const float LGAGANLPIJO = 0.33f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[SerializeField]
		[Header("Switch")]
		private GameObject indicator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[SerializeField]
		private GameObject indicatorOffPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[SerializeField]
		private GameObject indicatorOnPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private EAODNKAKKBM CBPKGGLFMKD;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xBCA6D0", Offset = "0xBC8ED0", VA = "0x180BCA6D0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xBCA950", Offset = "0xBC9150", VA = "0x180BCA950")]
		public SwitchTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class ApproximationMaskDepthTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[SerializeField]
		private RectTransform content;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private Vector3? LCNGJGBHCHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private Vector3? KNPJEDBMCPN;

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xBBB6D0", Offset = "0xBB9ED0", VA = "0x180BBB6D0")]
		private void PBAELFIBGFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xBBB310", Offset = "0xBB9B10", VA = "0x180BBB310", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xBBB7B0", Offset = "0xBB9FB0", VA = "0x180BBB7B0")]
		public ApproximationMaskDepthTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class DropdownTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[SerializeField]
		[HHGPBADECGL(MGNIEFNKKLA.Self, false, false, false)]
		private Dropdown dropdown;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[SerializeField]
		[KDKAGIPBBGM(MGNIEFNKKLA.Self, false, true, false)]
		private Image surface;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[SerializeField]
		private bool useSurfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[SerializeField]
		[LEKNNDJMFFO("useSurfaceOverride")]
		private Image surfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[SerializeField]
		private KELKDGJBKGI dropdownType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[SerializeField]
		private BENIBJHCMDO textSize;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Image ABDJFAGGKDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xBBF2F0", Offset = "0xBBDAF0", VA = "0x180BBF2F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public KELKDGJBKGI NAFLFODNNGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8FA2B0", Offset = "0x8F8AB0", VA = "0x1808FA2B0")]
			get
			{
				return default(KELKDGJBKGI);
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xBBF300", Offset = "0xBBDB00", VA = "0x180BBF300")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public BENIBJHCMDO AOMGJEBAPFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xB6D130", Offset = "0xB6B930", VA = "0x180B6D130")]
			get
			{
				return default(BENIBJHCMDO);
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xBBF320", Offset = "0xBBDB20", VA = "0x180BBF320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xBBEC10", Offset = "0xBBD410", VA = "0x180BBEC10", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xBBF280", Offset = "0xBBDA80", VA = "0x180BBF280")]
		public DropdownTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class BaseAudioPaletteAsset : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xBBBCA0", Offset = "0xBBA4A0", VA = "0x180BBBCA0")]
		protected bool ACHGKMDGNMM(RecRoomAudioClipPoolConfig KFIDLHJLEBM, out RecRoomAudioClip[] GLENKIGIOAA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xBBBD50", Offset = "0xBBA550", VA = "0x180BBBD50")]
		public BaseAudioPaletteAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ButtonTheme : ButtonThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[SerializeField]
		[Header("Button Visual")]
		private GBKHOIEBHJP buttonType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[SerializeField]
		[Tooltip("Override the audio palette defined by the button's visual with a custom palette")]
		[Header("Button Audio")]
		private bool overrideButtonAudioPalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[SerializeField]
		[LEKNNDJMFFO("overrideButtonAudioPalette")]
		[Tooltip("Specify a custom config to use for button audio")]
		private ButtonAudioPaletteAsset customButtonAudioConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[SerializeField]
		[Tooltip("Layer a 2D SFX on top of base button sounds")]
		private bool useFlavorSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		[SerializeField]
		[LEKNNDJMFFO("useFlavorSFX")]
		[Tooltip("Flavor SFX is picked randomly from this pool config")]
		private RecRoomAudioClipPoolConfig flavorSFXClipPoolConfig;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public GBKHOIEBHJP LOKKGDLKFKN
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xBBC110", Offset = "0xBBA910", VA = "0x180BBC110")]
			get
			{
				return default(GBKHOIEBHJP);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xBBDC70", Offset = "0xBBC470", VA = "0x180BBDC70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xBBD9A0", Offset = "0xBBC1A0", VA = "0x180BBD9A0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xBBDC20", Offset = "0xBBC420", VA = "0x180BBDC20")]
		public void SetAnimationEnabled(bool CNIPDMAOMPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xBBDC30", Offset = "0xBBC430", VA = "0x180BBDC30")]
		public ButtonTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class RecyclingListTheme : RecyclingThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[SerializeField]
		[HHGPBADECGL(MGNIEFNKKLA.Self, false, false, false)]
		private JJGNLLDMFCL recyclingList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private bool LJOBEOLNAPP;

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xBC5E90", Offset = "0xBC4690", VA = "0x180BC5E90", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xBC6150", Offset = "0xBC4950", VA = "0x180BC6150", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xBC60E0", Offset = "0xBC48E0", VA = "0x180BC60E0")]
		private void KIJNHKCOMMO(float NAOEMMMJJLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xBC6370", Offset = "0xBC4B70", VA = "0x180BC6370")]
		public RecyclingListTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class AudioPalette : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public class ButtonAudioPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			[SerializeField]
			private MBHCJDDDHIK buttonAudioPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			[SerializeField]
			private ButtonAudioPaletteAsset buttonAudioPaletteConfig;

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			public MBHCJDDDHIK ButtonAudioPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80D270", VA = "0x18080EA70")]
				get
				{
					return default(MBHCJDDDHIK);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public ButtonAudioPaletteAsset ButtonAudioPaletteConfig
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xBBBFE0", Offset = "0xBBA7E0", VA = "0x180BBBFE0")]
			public ButtonAudioPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public class ScrollingAudioPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			[SerializeField]
			private KOPACFMHODN scrollingAudioPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			[SerializeField]
			private ScrollingAudioPaletteAsset scrollingAudioPaletteConfig;

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			public KOPACFMHODN ScrollingAudioPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80D270", VA = "0x18080EA70")]
				get
				{
					return default(KOPACFMHODN);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			public ScrollingAudioPaletteAsset ScrollingAudioPaletteConfig
			{
				[Cpp2IlInjected.Token(Token = "0x600007D")]
				[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xBBBFE0", Offset = "0xBBA7E0", VA = "0x180BBBFE0")]
			public ScrollingAudioPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public class ContentLoadingAudioPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			[SerializeField]
			private DDKJOAEFPED contentLoadingAudioPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			[SerializeField]
			private ContentLoadingAudioPaletteAsset contentLoadingAudioPaletteConfig;

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			public DDKJOAEFPED ContentLoadingAudioPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600007F")]
				[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80D270", VA = "0x18080EA70")]
				get
				{
					return default(DDKJOAEFPED);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			public ContentLoadingAudioPaletteAsset ContentLoadingAudioPaletteConfig
			{
				[Cpp2IlInjected.Token(Token = "0x6000080")]
				[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xBBBFE0", Offset = "0xBBA7E0", VA = "0x180BBBFE0")]
			public ContentLoadingAudioPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public class RecyclingAudioPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			[SerializeField]
			private CGKHHPHPKGH recyclingAudioPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			[SerializeField]
			private RecyclingAudioPaletteAsset recyclingAudioPaletteConfig;

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			public CGKHHPHPKGH RecyclingAudioPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80D270", VA = "0x18080EA70")]
				get
				{
					return default(CGKHHPHPKGH);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			public RecyclingAudioPaletteAsset RecyclingAudioPaletteConfig
			{
				[Cpp2IlInjected.Token(Token = "0x6000083")]
				[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xBBBFE0", Offset = "0xBBA7E0", VA = "0x180BBBFE0")]
			public RecyclingAudioPaletteItem()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class BHGLODIGPOO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public MBHCJDDDHIK buttonAudioPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
			public BHGLODIGPOO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xBBB2F0", Offset = "0xBB9AF0", VA = "0x180BBB2F0")]
			internal bool PFANGKLGKEA(ButtonAudioPaletteItem buttonAudioPalette)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class CBCAOBNHBNP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public KOPACFMHODN scrollingAudioPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
			public CBCAOBNHBNP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xBBB2F0", Offset = "0xBB9AF0", VA = "0x180BBB2F0")]
			internal bool OJHHFBGCADK(ScrollingAudioPaletteItem scrollingAudioPalette)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class MNJPDFENCEK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public DDKJOAEFPED contentLoadingAudioPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
			public MNJPDFENCEK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xBBB2F0", Offset = "0xBB9AF0", VA = "0x180BBB2F0")]
			internal bool OOMPJIAKIGA(ContentLoadingAudioPaletteItem contentLoadingAudioPalette)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[CompilerGenerated]
		private sealed class AKOEPOJGKCG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public CGKHHPHPKGH recyclingAudioPaletteType;

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
			public AKOEPOJGKCG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xBBB2F0", Offset = "0xBB9AF0", VA = "0x180BBB2F0")]
			internal bool GNAIBMHMBBM(RecyclingAudioPaletteItem recyclingAudioPalette)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[SerializeField]
		[HFGPJOINBMP("ButtonAudioPaletteType")]
		private ButtonAudioPaletteItem[] buttonAudioPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[SerializeField]
		[HFGPJOINBMP("ScrollingAudioPaletteType")]
		private ScrollingAudioPaletteItem[] scrollingAudioPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[SerializeField]
		[HFGPJOINBMP("ContentLoadingAudioPaletteType")]
		private ContentLoadingAudioPaletteItem[] contentLoadingAudioPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[SerializeField]
		[HFGPJOINBMP("RecyclingAudioPaletteType")]
		private RecyclingAudioPaletteItem[] recyclingAudioPalettes;

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xBBB7F0", Offset = "0xBB9FF0", VA = "0x180BBB7F0")]
		public ButtonAudioPaletteAsset EBMKCHJAKBL(MBHCJDDDHIK JPABGPBOOPC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xBBB8E0", Offset = "0xBBA0E0", VA = "0x180BBB8E0")]
		public ScrollingAudioPaletteAsset FIOCCCEFGAB(KOPACFMHODN GJPMFKKCPIN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xBBBAC0", Offset = "0xBBA2C0", VA = "0x180BBBAC0")]
		public ContentLoadingAudioPaletteAsset HNDLOFKCBBD(DDKJOAEFPED CPGPIMJEICO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xBBB9D0", Offset = "0xBBA1D0", VA = "0x180BBB9D0")]
		public RecyclingAudioPaletteAsset GKEBFKIEGMA(CGKHHPHPKGH FLMJNHLLPJK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xBBBBB0", Offset = "0xBBA3B0", VA = "0x180BBBBB0")]
		public AudioPalette()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class InputFieldPalette
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		[SerializeField]
		private Color backgroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[SerializeField]
		private Color foregroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[SerializeField]
		private Color placeholderColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		[SerializeField]
		private TextStylePalette textPalette;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public Color BackgroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xBBC120", Offset = "0xBBA920", VA = "0x180BBC120")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public Color ForegroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0xBBEC00", Offset = "0xBBD400", VA = "0x180BBEC00")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public Color PlaceholderColor
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xBC0490", Offset = "0xBBEC90", VA = "0x180BC0490")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public TextStylePalette TextPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x7F51E0", Offset = "0x7F39E0", VA = "0x1807F51E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xBC0420", Offset = "0xBBEC20", VA = "0x180BC0420")]
		public InputFieldPalette()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class SurfaceTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[SerializeField]
		[HHGPBADECGL(MGNIEFNKKLA.Self, false, false, false)]
		private Image image;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[SerializeField]
		[KDKAGIPBBGM(MGNIEFNKKLA.Self, false, false, false)]
		private UIGradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[SerializeField]
		private CEEAFADHGGC color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[SerializeField]
		[LEKNNDJMFFO("gradient")]
		private bool ignoreGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[SerializeField]
		[Tooltip("The surface theme determines if this Image is a RaycastTarget or not. There are times when you might want to ignore that setting of the palette theme and just respect whatever is the default state on the Image.")]
		private bool ignoreSettingRaycastTarget;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public CEEAFADHGGC BKEGBOHLKAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x8ABEE0", Offset = "0x8AA6E0", VA = "0x1808ABEE0")]
			get
			{
				return default(CEEAFADHGGC);
			}
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xBCA6B0", Offset = "0xBC8EB0", VA = "0x180BCA6B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xBCA3E0", Offset = "0xBC8BE0", VA = "0x180BCA3E0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xBCA650", Offset = "0xBC8E50", VA = "0x180BCA650")]
		public SurfaceTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class RecyclingAudioPaletteAsset : BaseAudioPaletteAsset
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[SerializeField]
		[Header("Clip Configs")]
		private RecRoomAudioClipPoolConfig itemRecycledAudioClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[SerializeField]
		[Header("Thresholds")]
		[Tooltip("Minimum required wait time before recycle SFX can be triggered repetitively")]
		private float minimumTimeIntervalForRecycleSFX;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public float MinimumTimeIntervalForRecycleSFX
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xBBDD90", Offset = "0xBBC590", VA = "0x180BBDD90")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xBBDC90", Offset = "0xBBC490", VA = "0x180BBDC90")]
		public bool CIMMMBIAEHP(out RecRoomAudioClip[] GLENKIGIOAA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xBC5950", Offset = "0xBC4150", VA = "0x180BC5950")]
		public RecyclingAudioPaletteAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class PaletteTheme : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[SerializeField]
		private bool usePaletteOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[SerializeField]
		[LEKNNDJMFFO("usePaletteOverride")]
		private Palette paletteOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public KBJOPGEOOCH PaletteChangeEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		[SerializeField]
		private bool useDepth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private CHMPJAOMKBA LLADMFMGALP;

		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private const string GBKEDEDLLPH = "watch_layer";

		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private const string HONHCIGFGAP = "depth_multiplier";

		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private const float NBFAPECDNBH = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private float? BCIPONGIDLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private float? NNOEMNBDKMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private float? MEFACBKFDJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private float DIGDJBLAEDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private float JIKBFPNDGMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private float NBONKEMMPJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private float ENPNGPKHNEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private readonly FMDOKKBAPOM HOJFCLANJGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private SFXAudioSource EGIFCLFIBLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private SFXAudioSource HOOEIGBPILN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private ContentLoadingAudioPaletteAsset GJIBAJFEFHM;

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private const float DOGAJHEIAAF = 0.001f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private AOHHOPAIALB OBGKDOHCIGC;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public Palette PHABAAINJKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xBC4380", Offset = "0xBC2B80", VA = "0x180BC4380")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public bool AAJCPFDMPMO
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x8ABE60", Offset = "0x8AA660", VA = "0x1808ABE60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public float LKPPNPMJJGB
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0xBC41B0", Offset = "0xBC29B0", VA = "0x180BC41B0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		private bool OEKCFPBBBME
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xBC35A0", Offset = "0xBC1DA0", VA = "0x180BC35A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		private bool FDDKNEIPOGO
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0xBC33A0", Offset = "0xBC1BA0", VA = "0x180BC33A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xBC2F30", Offset = "0xBC1730", VA = "0x180BC2F30")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xBC3A50", Offset = "0xBC2250", VA = "0x180BC3A50")]
		private void OLINJIFKAFG(BGPGGIJIJPN.JJEDDHNNHCG PJKBEBPNGIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xBC3A80", Offset = "0xBC2280", VA = "0x180BC3A80")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xBC2C70", Offset = "0xBC1470", VA = "0x180BC2C70")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xBC3630", Offset = "0xBC1E30", VA = "0x180BC3630")]
		private void LAPDHLKIGDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xBC2E00", Offset = "0xBC1600", VA = "0x180BC2E00")]
		public void AddLoadingSFXRequest(object FLDJLPKNKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xBC3F90", Offset = "0xBC2790", VA = "0x180BC3F90")]
		public void RemoveLoadingSFXRequest(object FLDJLPKNKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xBC2C70", Offset = "0xBC1470", VA = "0x180BC2C70")]
		private void AGHLJHBLEHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0xBC3BB0", Offset = "0xBC23B0", VA = "0x180BC3BB0")]
		private void PBJFOINOGGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xBC3910", Offset = "0xBC2110", VA = "0x180BC3910")]
		private void NJKNCELJGPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0xBC3810", Offset = "0xBC2010", VA = "0x180BC3810")]
		private void LFOPMFJNCLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xBC30C0", Offset = "0xBC18C0", VA = "0x180BC30C0")]
		private void CDCGECBFGMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xBC34B0", Offset = "0xBC1CB0", VA = "0x180BC34B0")]
		private void DGNJEKAEMIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xBC2DB0", Offset = "0xBC15B0", VA = "0x180BC2DB0")]
		private void AIHPKPKBPMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0xBC33B0", Offset = "0xBC1BB0", VA = "0x180BC33B0")]
		private void CIHADABNELL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xBC2DC0", Offset = "0xBC15C0", VA = "0x180BC2DC0")]
		private void AKDHLANOLCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xBC3DC0", Offset = "0xBC25C0", VA = "0x180BC3DC0")]
		public void Play2DUIFlavorSFX(RecRoomAudioClip[] AEHNLEPAGDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xBC40B0", Offset = "0xBC28B0", VA = "0x180BC40B0")]
		public PaletteTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class DepthTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[SerializeField]
		private PLPMNPOBODF depth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		[SerializeField]
		private bool animateOnEnable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[SerializeField]
		[LEKNNDJMFFO("animateOnEnable")]
		private float animationTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private Vector3? LCNGJGBHCHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private Vector2 MMJLOPOKJNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private Vector2 JPEBNFLMFNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private Vector2 AIILIKPCNPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private Vector2 GCBIMLCCEMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private Vector2 FCLBEGBKLBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private Vector2 DIJLPPIELBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private readonly bool? ACHEIDIAAKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private LDBHAOEJOAP JKNCMEHEFDA;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		private RectTransform PFIMNMKGOHJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xBBE0F0", Offset = "0xBBC8F0", VA = "0x180BBE0F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public PLPMNPOBODF CODGCEDHNEK
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x80ECA0", Offset = "0x80D4A0", VA = "0x18080ECA0")]
			get
			{
				return default(PLPMNPOBODF);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xBBEB90", Offset = "0xBBD390", VA = "0x180BBEB90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		private LDBHAOEJOAP APJDBHAFHGJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xBBE5C0", Offset = "0xBBCDC0", VA = "0x180BBE5C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		private bool PJKCBKCLGLA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xBBE4D0", Offset = "0xBBCCD0", VA = "0x180BBE4D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xBBE6E0", Offset = "0xBBCEE0", VA = "0x180BBE6E0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xBBE630", Offset = "0xBBCE30", VA = "0x180BBE630")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xBBDDD0", Offset = "0xBBC5D0", VA = "0x180BBDDD0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xBBE750", Offset = "0xBBCF50", VA = "0x180BBE750")]
		private void PBAELFIBGFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0xBBE150", Offset = "0xBBC950", VA = "0x180BBE150")]
		private Vector3 HKJMEJNFAPN()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xBBEA70", Offset = "0xBBD270", VA = "0x180BBEA70")]
		public DepthTheme()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class DepthPalette
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[SerializeField]
		private float depth;

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public float Depth
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0xBBDDC0", Offset = "0xBBC5C0", VA = "0x180BBDDC0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xBBDDB0", Offset = "0xBBC5B0", VA = "0x180BBDDB0")]
		public DepthPalette()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class Palette : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public class RawImageColorPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			[SerializeField]
			private JKIJAIKKHHE paletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			[SerializeField]
			private Color color;

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			public JKIJAIKKHHE RawImageColorPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x60000CF")]
				[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80D270", VA = "0x18080EA70")]
				get
				{
					return default(JKIJAIKKHHE);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			public Color Color
			{
				[Cpp2IlInjected.Token(Token = "0x60000D0")]
				[Cpp2IlInjected.Address(RVA = "0xADC640", Offset = "0xADAE40", VA = "0x180ADC640")]
				get
				{
					return default(Color);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0xBC5780", Offset = "0xBC3F80", VA = "0x180BC5780")]
			public RawImageColorPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public class BackgroundColorPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			[SerializeField]
			private CEEAFADHGGC backgroundColorPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			[SerializeField]
			private Color color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			[SerializeField]
			private Gradient gradient;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			[SerializeField]
			private bool raycastTarget;

			[Cpp2IlInjected.Token(Token = "0x17000045")]
			public CEEAFADHGGC BackgroundColorPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x60000D2")]
				[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80D270", VA = "0x18080EA70")]
				get
				{
					return default(CEEAFADHGGC);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000046")]
			public Color Color
			{
				[Cpp2IlInjected.Token(Token = "0x60000D3")]
				[Cpp2IlInjected.Address(RVA = "0xADC640", Offset = "0xADAE40", VA = "0x180ADC640")]
				get
				{
					return default(Color);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000047")]
			public Gradient Gradient
			{
				[Cpp2IlInjected.Token(Token = "0x60000D4")]
				[Cpp2IlInjected.Address(RVA = "0x7F2CE0", Offset = "0x7F14E0", VA = "0x1807F2CE0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000048")]
			public bool RaycastTarget
			{
				[Cpp2IlInjected.Token(Token = "0x60000D5")]
				[Cpp2IlInjected.Address(RVA = "0x8ABE60", Offset = "0x8AA660", VA = "0x1808ABE60")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0xBBBC10", Offset = "0xBBA410", VA = "0x180BBBC10")]
			public BackgroundColorPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public class ForegroundColorPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			[SerializeField]
			private DHDELLAANPE foregroundColorPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			[SerializeField]
			private Color color;

			[Cpp2IlInjected.Token(Token = "0x17000049")]
			public DHDELLAANPE ForegroundColorPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x60000D7")]
				[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80D270", VA = "0x18080EA70")]
				get
				{
					return default(DHDELLAANPE);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004A")]
			public Color Color
			{
				[Cpp2IlInjected.Token(Token = "0x60000D8")]
				[Cpp2IlInjected.Address(RVA = "0xADC640", Offset = "0xADAE40", VA = "0x180ADC640")]
				get
				{
					return default(Color);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0xBBFCB0", Offset = "0xBBE4B0", VA = "0x180BBFCB0")]
			public ForegroundColorPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public class TilerPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			[SerializeField]
			private HBCABGKNLMP tilerPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			[SerializeField]
			private TilerPalette tilerPalette;

			[Cpp2IlInjected.Token(Token = "0x1700004B")]
			public HBCABGKNLMP TilerPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x60000DA")]
				[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80D270", VA = "0x18080EA70")]
				get
				{
					return default(HBCABGKNLMP);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004C")]
			public TilerPalette TilerPalette
			{
				[Cpp2IlInjected.Token(Token = "0x60000DB")]
				[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0xBBDDB0", Offset = "0xBBC5B0", VA = "0x180BBDDB0")]
			public TilerPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public class TextStylePaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			[SerializeField]
			private JGBGNMILGJP textStylePaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			[SerializeField]
			private TextStylePalette textStylePalette;

			[Cpp2IlInjected.Token(Token = "0x1700004D")]
			public JGBGNMILGJP TextStylePaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x60000DD")]
				[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80D270", VA = "0x18080EA70")]
				get
				{
					return default(JGBGNMILGJP);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004E")]
			public TextStylePalette TextStylePalette
			{
				[Cpp2IlInjected.Token(Token = "0x60000DE")]
				[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0xBBBFE0", Offset = "0xBBA7E0", VA = "0x180BBBFE0")]
			public TextStylePaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public class TextSizePaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			[SerializeField]
			private BENIBJHCMDO textSizePaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			[SerializeField]
			private int size;

			[Cpp2IlInjected.Token(Token = "0x1700004F")]
			public BENIBJHCMDO TextSizePaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x60000E0")]
				[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80D270", VA = "0x18080EA70")]
				get
				{
					return default(BENIBJHCMDO);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000050")]
			public int Size
			{
				[Cpp2IlInjected.Token(Token = "0x60000E1")]
				[Cpp2IlInjected.Address(RVA = "0x80EC90", Offset = "0x80D490", VA = "0x18080EC90")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0xBCAA30", Offset = "0xBC9230", VA = "0x180BCAA30")]
			public TextSizePaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		public class ButtonPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			[SerializeField]
			private GBKHOIEBHJP buttonPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			[SerializeField]
			private ButtonPalette buttonPalette;

			[Cpp2IlInjected.Token(Token = "0x17000051")]
			public GBKHOIEBHJP ButtonPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x60000E3")]
				[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80D270", VA = "0x18080EA70")]
				get
				{
					return default(GBKHOIEBHJP);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000052")]
			public ButtonPalette ButtonPalette
			{
				[Cpp2IlInjected.Token(Token = "0x60000E4")]
				[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0xBBBFE0", Offset = "0xBBA7E0", VA = "0x180BBBFE0")]
			public ButtonPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		public class TogglePaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			[SerializeField]
			private AACPPIMGFIP togglePaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			[SerializeField]
			private TogglePalette togglePalette;

			[Cpp2IlInjected.Token(Token = "0x17000053")]
			public AACPPIMGFIP TogglePaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x60000E6")]
				[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80D270", VA = "0x18080EA70")]
				get
				{
					return default(AACPPIMGFIP);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000054")]
			public TogglePalette TogglePalette
			{
				[Cpp2IlInjected.Token(Token = "0x60000E7")]
				[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0xBBBFE0", Offset = "0xBBA7E0", VA = "0x180BBBFE0")]
			public TogglePaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		public class MixedTogglePaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			[SerializeField]
			private IDDEMAGGHFH mixedTogglePaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			[SerializeField]
			private MixedTogglePalette mixedTogglePalette;

			[Cpp2IlInjected.Token(Token = "0x17000055")]
			public IDDEMAGGHFH MixedTogglePaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x60000E9")]
				[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80D270", VA = "0x18080EA70")]
				get
				{
					return default(IDDEMAGGHFH);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000056")]
			public MixedTogglePalette MixedTogglePalette
			{
				[Cpp2IlInjected.Token(Token = "0x60000EA")]
				[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xBBBFE0", Offset = "0xBBA7E0", VA = "0x180BBBFE0")]
			public MixedTogglePaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public class MakerPenToolPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			[SerializeField]
			private JFLKPKNPMGK makerPenToolPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			[SerializeField]
			private MakerPenToolPalette makerPenToolPalette;

			[Cpp2IlInjected.Token(Token = "0x17000057")]
			public JFLKPKNPMGK MakerPenToolPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x60000EC")]
				[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80D270", VA = "0x18080EA70")]
				get
				{
					return default(JFLKPKNPMGK);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000058")]
			public MakerPenToolPalette MakerPenToolPalette
			{
				[Cpp2IlInjected.Token(Token = "0x60000ED")]
				[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0xBBBFE0", Offset = "0xBBA7E0", VA = "0x180BBBFE0")]
			public MakerPenToolPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		public class InputFieldPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			[SerializeField]
			private OGKIKKLANAC inputFieldPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			[SerializeField]
			private InputFieldPalette inputFieldPalette;

			[Cpp2IlInjected.Token(Token = "0x17000059")]
			public OGKIKKLANAC InputFieldPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x60000EF")]
				[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80D270", VA = "0x18080EA70")]
				get
				{
					return default(OGKIKKLANAC);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005A")]
			public InputFieldPalette InputFieldPalette
			{
				[Cpp2IlInjected.Token(Token = "0x60000F0")]
				[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xBBBFE0", Offset = "0xBBA7E0", VA = "0x180BBBFE0")]
			public InputFieldPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public class DropdownPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			[SerializeField]
			private KELKDGJBKGI dropdownPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			[SerializeField]
			private DropdownPalette dropdownPalette;

			[Cpp2IlInjected.Token(Token = "0x1700005B")]
			public KELKDGJBKGI DropdownPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x60000F2")]
				[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80D270", VA = "0x18080EA70")]
				get
				{
					return default(KELKDGJBKGI);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005C")]
			public DropdownPalette DropdownPalette
			{
				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0xBBBFE0", Offset = "0xBBA7E0", VA = "0x180BBBFE0")]
			public DropdownPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000035")]
		public class SliderPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			[SerializeField]
			private OIILLKPNLML sliderPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			[SerializeField]
			private SliderPalette sliderPalette;

			[Cpp2IlInjected.Token(Token = "0x1700005D")]
			public OIILLKPNLML SliderPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80D270", VA = "0x18080EA70")]
				get
				{
					return default(OIILLKPNLML);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005E")]
			public SliderPalette SliderPalette
			{
				[Cpp2IlInjected.Token(Token = "0x60000F6")]
				[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0xBBBFE0", Offset = "0xBBA7E0", VA = "0x180BBBFE0")]
			public SliderPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public class DepthPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			[SerializeField]
			private PLPMNPOBODF depthPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			[SerializeField]
			private DepthPalette depthPalette;

			[Cpp2IlInjected.Token(Token = "0x1700005F")]
			public PLPMNPOBODF DepthPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x60000F8")]
				[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80D270", VA = "0x18080EA70")]
				get
				{
					return default(PLPMNPOBODF);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000060")]
			public DepthPalette DepthPalette
			{
				[Cpp2IlInjected.Token(Token = "0x60000F9")]
				[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0xBBBFE0", Offset = "0xBBA7E0", VA = "0x180BBBFE0")]
			public DepthPaletteItem()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[CompilerGenerated]
		private sealed class FBDACBJPPJH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public JKIJAIKKHHE backgroundColorPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
			public FBDACBJPPJH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xBBB2F0", Offset = "0xBB9AF0", VA = "0x180BBB2F0")]
			internal bool DCDIEAPOIKK(RawImageColorPaletteItem pi)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		[CompilerGenerated]
		private sealed class FJLLNAMHOGA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public CEEAFADHGGC backgroundColorPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
			public FJLLNAMHOGA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0xBBB2F0", Offset = "0xBB9AF0", VA = "0x180BBB2F0")]
			internal bool JEHALIDONHD(BackgroundColorPaletteItem backgroundColorPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000039")]
		[CompilerGenerated]
		private sealed class CMPBEJKFBHJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public DHDELLAANPE foregroundColorPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
			public CMPBEJKFBHJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0xBBB2F0", Offset = "0xBB9AF0", VA = "0x180BBB2F0")]
			internal bool KECNOKDLEOK(ForegroundColorPaletteItem colorPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		[CompilerGenerated]
		private sealed class HLGIOHKICEG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public HBCABGKNLMP type;

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
			public HLGIOHKICEG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0xBBB2F0", Offset = "0xBB9AF0", VA = "0x180BBB2F0")]
			internal bool HHFMMJGFBFC(TilerPaletteItem tilerPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		[CompilerGenerated]
		private sealed class AHIHHPMAHOO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public JGBGNMILGJP textStylePaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
			public AHIHHPMAHOO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0xBBB2F0", Offset = "0xBB9AF0", VA = "0x180BBB2F0")]
			internal bool KJNFGCODCPK(TextStylePaletteItem textStylePaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		[CompilerGenerated]
		private sealed class IEEPKICOCMC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public BENIBJHCMDO textSizePaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
			public IEEPKICOCMC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0xBBB2F0", Offset = "0xBB9AF0", VA = "0x180BBB2F0")]
			internal bool IHKOFIPKNOK(TextSizePaletteItem textSizePaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003D")]
		[CompilerGenerated]
		private sealed class MDAAJKNKEEF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public GBKHOIEBHJP buttonPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
			public MDAAJKNKEEF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0xBBB2F0", Offset = "0xBB9AF0", VA = "0x180BBB2F0")]
			internal bool EAMHGHECKJB(ButtonPaletteItem buttonPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		[CompilerGenerated]
		private sealed class PPLALBACIPA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public AACPPIMGFIP togglePaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
			public PPLALBACIPA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0xBBB2F0", Offset = "0xBB9AF0", VA = "0x180BBB2F0")]
			internal bool IDPKFENONMI(TogglePaletteItem togglePaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		[CompilerGenerated]
		private sealed class PDIMMOOEJNI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public IDDEMAGGHFH mixedTogglePaletteType;

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
			public PDIMMOOEJNI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0xBBB2F0", Offset = "0xBB9AF0", VA = "0x180BBB2F0")]
			internal bool APHKLFGBLKG(MixedTogglePaletteItem mixedTogglePaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		[CompilerGenerated]
		private sealed class MOAKDDLCGOJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public JFLKPKNPMGK makerPenToolPaletteType;

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
			public MOAKDDLCGOJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0xBBB2F0", Offset = "0xBB9AF0", VA = "0x180BBB2F0")]
			internal bool CMDFAHFMICM(MakerPenToolPaletteItem makerPenToolPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[CompilerGenerated]
		private sealed class BLJIHBNFKGH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			public OGKIKKLANAC inputFieldPaletteType;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
			public BLJIHBNFKGH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0xBBB2F0", Offset = "0xBB9AF0", VA = "0x180BBB2F0")]
			internal bool HJPAHBIFGBP(InputFieldPaletteItem inputFieldPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		[CompilerGenerated]
		private sealed class KIJGNAOMLIL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public KELKDGJBKGI dropdownPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
			public KIJGNAOMLIL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0xBBB2F0", Offset = "0xBB9AF0", VA = "0x180BBB2F0")]
			internal bool AEGLIIMDFCJ(DropdownPaletteItem dropdownPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000043")]
		[CompilerGenerated]
		private sealed class MDMADHPNGCO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public OIILLKPNLML sliderPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
			public MDMADHPNGCO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0xBBB2F0", Offset = "0xBB9AF0", VA = "0x180BBB2F0")]
			internal bool GKADMNKHMJN(SliderPaletteItem sliderPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		[CompilerGenerated]
		private sealed class FDHHJPJCOLH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			public PLPMNPOBODF depthPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
			public FDHHJPJCOLH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xBBB2F0", Offset = "0xBB9AF0", VA = "0x180BBB2F0")]
			internal bool COHOJFFFDFC(DepthPaletteItem depthPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[SerializeField]
		[Header("Visual")]
		[HFGPJOINBMP("RawImageColorPaletteType")]
		private RawImageColorPaletteItem[] rawImageColorPaletteItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[SerializeField]
		[HFGPJOINBMP("BackgroundColorPaletteType")]
		private BackgroundColorPaletteItem[] backgroundColorPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[SerializeField]
		[HFGPJOINBMP("ForegroundColorPaletteType")]
		private ForegroundColorPaletteItem[] foregroundColorPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[SerializeField]
		[HFGPJOINBMP("TilerPaletteType")]
		private TilerPaletteItem[] tilerPaletteItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		[SerializeField]
		[HFGPJOINBMP("TextStylePaletteType")]
		private TextStylePaletteItem[] textStylePalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		[SerializeField]
		[HFGPJOINBMP("TextSizePaletteType")]
		private TextSizePaletteItem[] textSizePalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		[SerializeField]
		[HFGPJOINBMP("ButtonPaletteType")]
		private ButtonPaletteItem[] buttonPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		[SerializeField]
		[HFGPJOINBMP("TogglePaletteType")]
		private TogglePaletteItem[] togglePalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		[SerializeField]
		[HFGPJOINBMP("MixedTogglePaletteType")]
		private MixedTogglePaletteItem[] mixedTogglePalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		[SerializeField]
		[HFGPJOINBMP("MakerPenToolPaletteType")]
		private MakerPenToolPaletteItem[] makerPenToolPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		[SerializeField]
		[HFGPJOINBMP("InputFieldPaletteType")]
		private InputFieldPaletteItem[] inputFieldPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		[SerializeField]
		[HFGPJOINBMP("DropdownPaletteType")]
		private DropdownPaletteItem[] dropdownPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		[SerializeField]
		[HFGPJOINBMP("SliderPaletteType")]
		private SliderPaletteItem[] sliderPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		[SerializeField]
		[HFGPJOINBMP("DepthPaletteType")]
		private DepthPaletteItem[] depthPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		[SerializeField]
		private ButtonAnimationPalette buttonAnimationPalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		[SerializeField]
		[FormerlySerializedAs("audioPaletteConfig")]
		[Header("Audio")]
		private AudioPalette audioPalette;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public IEnumerable<DepthPaletteItem> DepthPalettes
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x8E9240", Offset = "0x8E7A40", VA = "0x1808E9240")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public ButtonAnimationPalette ButtonAnimationPalette
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x8B4140", Offset = "0x8B2940", VA = "0x1808B4140")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public AudioPalette AudioPalette
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x8B41E0", Offset = "0x8B29E0", VA = "0x1808B41E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xBC4E40", Offset = "0xBC3640", VA = "0x180BC4E40")]
		public Color LNEPAHMLJFL(JKIJAIKKHHE CLIJCJPMNLH)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xBC4430", Offset = "0xBC2C30", VA = "0x180BC4430")]
		public void APGLPMMNJAI(CEEAFADHGGC CLIJCJPMNLH, out Color OPOEPBAFNOG, out Gradient DFFDDAACKDI, out bool LKMNPFKICGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0xBC45B0", Offset = "0xBC2DB0", VA = "0x180BC45B0")]
		public Color BLKBIOFOEOM(DHDELLAANPE KMLPGGCPALK)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0xBC4A80", Offset = "0xBC3280", VA = "0x180BC4A80")]
		public TilerPalette HDIKGBBNPOB(HBCABGKNLMP FIJCKHKKDCC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xBC5170", Offset = "0xBC3970", VA = "0x180BC5170")]
		public TextStylePalette PBFEFNPEEOG(JGBGNMILGJP MIEKDFAABFB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xBC4F50", Offset = "0xBC3750", VA = "0x180BC4F50")]
		public int LOAJOCNIMMB(BENIBJHCMDO IKJKHDNIJHE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0xBC4C60", Offset = "0xBC3460", VA = "0x180BC4C60")]
		public ButtonPalette JMCEGLMDIJJ(GBKHOIEBHJP BIHPGABANJN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xBC4B70", Offset = "0xBC3370", VA = "0x180BC4B70")]
		public TogglePalette HPFDCDCGOJI(AACPPIMGFIP NHBBMEFOANO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xBC46C0", Offset = "0xBC2EC0", VA = "0x180BC46C0")]
		public MixedTogglePalette DLNJKBMDBPO(IDDEMAGGHFH KDJAJOAFBAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0xBC4990", Offset = "0xBC3190", VA = "0x180BC4990")]
		public MakerPenToolPalette GKEHECPOCBF(JFLKPKNPMGK BMPHPPJCGLN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xBC48A0", Offset = "0xBC30A0", VA = "0x180BC48A0")]
		public InputFieldPalette GGEFFGIKLDO(OGKIKKLANAC EAOAPIJNIPP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xBC47B0", Offset = "0xBC2FB0", VA = "0x180BC47B0")]
		public DropdownPalette EDPIJPBDOPD(KELKDGJBKGI LABCMMADNAF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0xBC4D50", Offset = "0xBC3550", VA = "0x180BC4D50")]
		public SliderPalette LGGFKEGMLGP(OIILLKPNLML KOGLKHLGIDO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xBC5040", Offset = "0xBC3840", VA = "0x180BC5040")]
		public float? OJOGCALGIMI(PLPMNPOBODF FAMBNFLEDOI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0xBC5260", Offset = "0xBC3A60", VA = "0x180BC5260")]
		public Palette()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public class RecyclingGridTheme : RecyclingThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		[SerializeField]
		[HHGPBADECGL(MGNIEFNKKLA.Self, false, false, false)]
		private JJGNLLDMFCL recyclingGrid;

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0xBC5A00", Offset = "0xBC4200", VA = "0x180BC5A00", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0xBC5C10", Offset = "0xBC4410", VA = "0x180BC5C10", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0xBC5990", Offset = "0xBC4190", VA = "0x180BC5990")]
		private void APKAKFABLOB(float NAOEMMMJJLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xBC5E20", Offset = "0xBC4620", VA = "0x180BC5E20")]
		public RecyclingGridTheme()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public class ButtonPalette
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		[SerializeField]
		[Header("Background")]
		private Color backgroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		[SerializeField]
		[FormerlySerializedAs("colorBlock")]
		private ColorBlock backgroundTints;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[SerializeField]
		private GradientBlock backgroundGradients;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		[SerializeField]
		[Header("Foreground")]
		private Color foregroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		[SerializeField]
		private ColorBlock foregroundTints;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		[SerializeField]
		[Header("Border")]
		private bool showBorder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		[SerializeField]
		[Header("Text")]
		private TextStylePalette textPalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		[SerializeField]
		[Header("Audio")]
		private MBHCJDDDHIK audioPalette;

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public Color BackgroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0xBBC120", Offset = "0xBBA920", VA = "0x180BBC120")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public ColorBlock BackgroundTints
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0xBBC160", Offset = "0xBBA960", VA = "0x180BBC160")]
			get
			{
				return default(ColorBlock);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public GradientBlock BackgroundGradients
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0xBBC130", Offset = "0xBBA930", VA = "0x180BBC130")]
			get
			{
				return default(GradientBlock);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public Color ForegroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0xBBC1A0", Offset = "0xBBA9A0", VA = "0x180BBC1A0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public ColorBlock ForegroundTints
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0xBBC1B0", Offset = "0xBBA9B0", VA = "0x180BBC1B0")]
			get
			{
				return default(ColorBlock);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public bool ShowBorder
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0xBBC200", Offset = "0xBBAA00", VA = "0x180BBC200")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public TextStylePalette TextPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0xA65BA0", Offset = "0xA643A0", VA = "0x180A65BA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public MBHCJDDDHIK AudioPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xBBC110", Offset = "0xBBA910", VA = "0x180BBC110")]
			get
			{
				return default(MBHCJDDDHIK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0xBBC010", Offset = "0xBBA810", VA = "0x180BBC010")]
		public ButtonPalette()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public class GraphicTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		[SerializeField]
		[HHGPBADECGL(MGNIEFNKKLA.Self, false, false, false)]
		private Graphic graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		[SerializeField]
		private bool useGraphicOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		[SerializeField]
		[LEKNNDJMFFO("useGraphicOverride")]
		private Graphic graphicOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		[SerializeField]
		private DHDELLAANPE color;

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public Graphic EJHADEGAOID
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0xBC03B0", Offset = "0xBBEBB0", VA = "0x180BC03B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public DHDELLAANPE KAOPHJAOJBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x8ABE50", Offset = "0x8AA650", VA = "0x1808ABE50")]
			get
			{
				return default(DHDELLAANPE);
			}
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0xBC03C0", Offset = "0xBBEBC0", VA = "0x180BC03C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public bool AHEBKECGGKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x9813F0", Offset = "0x97FBF0", VA = "0x1809813F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x981B80", Offset = "0x980380", VA = "0x180981B80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Color? NECKIFPEIFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0xBC01E0", Offset = "0xBBE9E0", VA = "0x180BC01E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xBBFF70", Offset = "0xBBE770", VA = "0x180BBFF70", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xBC0180", Offset = "0xBBE980", VA = "0x180BC0180")]
		public GraphicTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public class RawImageTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		[SerializeField]
		[HHGPBADECGL(MGNIEFNKKLA.Self, false, false, false)]
		private RawImage image;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		[SerializeField]
		private JKIJAIKKHHE color;

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public JKIJAIKKHHE BDCHLGNLLII
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x8CEF90", Offset = "0x8CD790", VA = "0x1808CEF90")]
			get
			{
				return default(JKIJAIKKHHE);
			}
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0xBC5760", Offset = "0xBC3F60", VA = "0x180BC5760")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0xBC57C0", Offset = "0xBC3FC0", VA = "0x180BC57C0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0xBC5900", Offset = "0xBC4100", VA = "0x180BC5900")]
		public RawImageTheme()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public class MakerPenToolPalette
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		[SerializeField]
		private ButtonPalette buttonPalette;

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public ButtonPalette ButtonPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x85D1E0", Offset = "0x85B9E0", VA = "0x18085D1E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0xBC0DE0", Offset = "0xBBF5E0", VA = "0x180BC0DE0")]
		public MakerPenToolPalette()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public class TextStylePalette
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public enum CBCHKGNILMN
		{
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			LowerCase,
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			UpperCase,
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			SmallCaps
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		[SerializeField]
		private TMP_FontAsset font;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		[SerializeField]
		private Material fontOverrideMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		[SerializeField]
		private float kerning;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		[SerializeField]
		private float leading;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		[SerializeField]
		private bool isBold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		[SerializeField]
		private bool isItalic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		[SerializeField]
		private CBCHKGNILMN transformation;

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public TMP_FontAsset Font
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x85D1E0", Offset = "0x85B9E0", VA = "0x18085D1E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public Material FontOverrideMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public float Kerning
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0xBBDD90", Offset = "0xBBC590", VA = "0x180BBDD90")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public float Leading
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0xBBDDA0", Offset = "0xBBC5A0", VA = "0x180BBDDA0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public bool IsBold
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0xA217D0", Offset = "0xA1FFD0", VA = "0x180A217D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public bool IsItalic
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0xBCADC0", Offset = "0xBC95C0", VA = "0x180BCADC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public CBCHKGNILMN Transformation
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0xBCADD0", Offset = "0xBC95D0", VA = "0x180BCADD0")]
			get
			{
				return default(CBCHKGNILMN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0xBCAA40", Offset = "0xBC9240", VA = "0x180BCAA40")]
		public void FHDOJMBIMOM(TextMeshProUGUI FNIONNJOCMH, bool DCHJCGPGHJF = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xBCAD70", Offset = "0xBC9570", VA = "0x180BCAD70")]
		public TextStylePalette()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public class ToggleTheme : ButtonThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		[SerializeField]
		[Header("Toggle Visual")]
		private AACPPIMGFIP toggleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		[SerializeField]
		[Tooltip("A list of objects to show while the toggle is active.")]
		private List<Hideable> hideWhenNotActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		[SerializeField]
		[Tooltip("A list of objects to show while the toggle is inactive")]
		private List<Hideable> hideWhenActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		[SerializeField]
		private bool editorIsActiveOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x131")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		[SerializeField]
		[Header("Toggle Audio")]
		[Tooltip("Override the audio palette when active defined by the toggle's visual with a custom palette")]
		private bool overrideAudioPaletteWhenActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		[SerializeField]
		[Tooltip("Specify a custom config to use for toggle button audio when active")]
		[LEKNNDJMFFO("overrideAudioPaletteWhenActive")]
		private ButtonAudioPaletteAsset customButtonAudioConfigWhenActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		[SerializeField]
		[Tooltip("Override the audio palette when inactive defined by the toggle's visual with a custom palette")]
		private bool overrideAudioPaletteWhenInactive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		[SerializeField]
		[LEKNNDJMFFO("overrideAudioPaletteWhenInactive")]
		[Tooltip("Specify a custom config to use for toggle button audio when inactive")]
		private ButtonAudioPaletteAsset customButtonAudioConfigWhenInactive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		[SerializeField]
		[Tooltip("Layer a 2D SFX on top of base button sounds. Flavor SFX only plays when toggling from inactive to active")]
		private bool useFlavorSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		[SerializeField]
		[LEKNNDJMFFO("useFlavorSFX")]
		[Tooltip("Flavor SFX is picked randomly from this pool config")]
		private RecRoomAudioClipPoolConfig flavorSFXClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		protected bool NLDJDDGFIJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x161")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private bool GKJDINFCKGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x162")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private bool MBOOEJLAKMG;

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public bool EBBFILBJDCG
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0xBCBBB0", Offset = "0xBCA3B0", VA = "0x180BCBBB0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0xBCBBC0", Offset = "0xBCA3C0", VA = "0x180BCBBC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public AACPPIMGFIP NACEFJLDJAB
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0xBBC110", Offset = "0xBBA910", VA = "0x180BBC110")]
			get
			{
				return default(AACPPIMGFIP);
			}
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0xBBDC70", Offset = "0xBBC470", VA = "0x180BBDC70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		protected override bool GNOBMDCIAFP
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0xBCBA80", Offset = "0xBCA280", VA = "0x180BCBA80", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0xBCBA40", Offset = "0xBCA240", VA = "0x180BCBA40", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0xBCBA90", Offset = "0xBCA290", VA = "0x180BCBA90")]
		public void Toggle()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0xBCBAD0", Offset = "0xBCA2D0", VA = "0x180BCBAD0")]
		public void Toggle(bool MBOOEJLAKMG, bool NLDJDDGFIJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0xBCB660", Offset = "0xBC9E60", VA = "0x180BCB660", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0xBCBB10", Offset = "0xBCA310", VA = "0x180BCBB10")]
		public ToggleTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public abstract class PaletteThemeReference : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		[SerializeField]
		[KDKAGIPBBGM(MGNIEFNKKLA.SelfAndParent, true, false, false)]
		private PaletteTheme paletteTheme;

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		protected PaletteTheme JHEHDKKEDNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		protected Palette PHABAAINJKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0xBC25B0", Offset = "0xBC0DB0", VA = "0x180BC25B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		protected bool KJNONEJPJPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0xBC2A20", Offset = "0xBC1220", VA = "0x180BC2A20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		protected Transform ILPONALEBIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0xBC2AC0", Offset = "0xBC12C0", VA = "0x180BC2AC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0xBC24A0", Offset = "0xBC0CA0", VA = "0x180BC24A0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0xBC2B50", Offset = "0xBC1350", VA = "0x180BC2B50", Slot = "5")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void Apply();

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0xBC2670", Offset = "0xBC0E70", VA = "0x180BC2670")]
		private void GBBHEIBMKCB(bool LPGEEPPDAFJ = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0xBC2C40", Offset = "0xBC1440", VA = "0x180BC2C40")]
		protected PaletteThemeReference()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public class InputFieldTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		[SerializeField]
		[HHGPBADECGL(MGNIEFNKKLA.Self, false, false, false)]
		private TMP_InputField inputField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		[SerializeField]
		[KDKAGIPBBGM(MGNIEFNKKLA.Self, false, false, false)]
		private Image surface;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		[SerializeField]
		private bool useSurfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		[SerializeField]
		[LEKNNDJMFFO("useSurfaceOverride")]
		private Image surfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		[SerializeField]
		private OGKIKKLANAC inputFieldType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		[SerializeField]
		private BENIBJHCMDO textSize;

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public Image ABDJFAGGKDM
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0xBBF2F0", Offset = "0xBBDAF0", VA = "0x180BBF2F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public OGKIKKLANAC HMPJAMJHGFG
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x8FA2B0", Offset = "0x8F8AB0", VA = "0x1808FA2B0")]
			get
			{
				return default(OGKIKKLANAC);
			}
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0xBBF300", Offset = "0xBBDB00", VA = "0x180BBF300")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public BENIBJHCMDO AOMGJEBAPFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0xB6D130", Offset = "0xB6B930", VA = "0x180B6D130")]
			get
			{
				return default(BENIBJHCMDO);
			}
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0xBBF320", Offset = "0xBBDB20", VA = "0x180BBF320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0xBC04A0", Offset = "0xBBECA0", VA = "0x180BC04A0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0xBBF280", Offset = "0xBBDA80", VA = "0x180BBF280")]
		public InputFieldTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public class RangeSliderTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		[SerializeField]
		[HHGPBADECGL(MGNIEFNKKLA.Self, false, false, false)]
		private RangeSlider slider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		[SerializeField]
		private OIILLKPNLML sliderType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		[SerializeField]
		private Image sliderImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		[SerializeField]
		private Image fillImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		[SerializeField]
		private Image lowHandleImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		[SerializeField]
		private Image highHandleImage;

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public OIILLKPNLML FGALDMKBHCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x8CEF90", Offset = "0x8CD790", VA = "0x1808CEF90")]
			get
			{
				return default(OIILLKPNLML);
			}
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0xBC5760", Offset = "0xBC3F60", VA = "0x180BC5760")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public Image LCKFDJJCNIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x7F2A40", Offset = "0x7F1240", VA = "0x1807F2A40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public Image BGNLJBNLMHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x7F3660", Offset = "0x7F1E60", VA = "0x1807F3660")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public Image LFDHNAEJECA
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x7F51E0", Offset = "0x7F39E0", VA = "0x1807F51E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public Image LLJPBIMNAFD
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x80DE70", Offset = "0x80C670", VA = "0x18080DE70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public bool HDLGCEHMIMD
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0xBC5720", Offset = "0xBC3F20", VA = "0x180BC5720")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0xBC5740", Offset = "0xBC3F40", VA = "0x180BC5740")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xBC5360", Offset = "0xBC3B60", VA = "0x180BC5360", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0xBC56A0", Offset = "0xBC3EA0", VA = "0x180BC56A0")]
		public RangeSliderTheme()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public class DropdownPalette
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		[SerializeField]
		private Color backgroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		[SerializeField]
		private Color foregroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		[SerializeField]
		private TextStylePalette textPalette;

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public Color BackgroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0xBBC120", Offset = "0xBBA920", VA = "0x180BBC120")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public Color ForegroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0xBBEC00", Offset = "0xBBD400", VA = "0x180BBEC00")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public TextStylePalette TextPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x7F2A40", Offset = "0x7F1240", VA = "0x1807F2A40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xBBEBB0", Offset = "0xBBD3B0", VA = "0x180BBEBB0")]
		public DropdownPalette()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public class MixedToggleTheme : ButtonThemeBase
	{
		[Cpp2IlInjected.Token(Token = "0x2000052")]
		public enum JGAOKGGOAHB
		{
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			Inactive,
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			Mixed,
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			Active
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		[SerializeField]
		private IDDEMAGGHFH toggleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		[SerializeField]
		[Tooltip("A list of objects to hide while the toggle is inactive.")]
		private List<Hideable> hideWhenInactive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		[SerializeField]
		[Tooltip("A list of objects to hide while the toggle is mixed.")]
		private List<Hideable> hideWhenMixed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		[SerializeField]
		[Tooltip("A list of objects to hide while the toggle is active")]
		private List<Hideable> hideWhenActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		[SerializeField]
		private JGAOKGGOAHB editorIsActiveOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private JGAOKGGOAHB MBOOEJLAKMG;

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public JGAOKGGOAHB EBBFILBJDCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0xBC1C30", Offset = "0xBC0430", VA = "0x180BC1C30")]
			get
			{
				return default(JGAOKGGOAHB);
			}
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0xBC1B70", Offset = "0xBC0370", VA = "0x180BC1B70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xBC1B90", Offset = "0xBC0390", VA = "0x180BC1B90")]
		public void Toggle()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0xBC1B70", Offset = "0xBC0370", VA = "0x180BC1B70")]
		public void Toggle(JGAOKGGOAHB MBOOEJLAKMG, bool NLDJDDGFIJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xBC15D0", Offset = "0xBBFDD0", VA = "0x180BC15D0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xBC1BC0", Offset = "0xBC03C0", VA = "0x180BC1BC0")]
		public MixedToggleTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public class TilerTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		[SerializeField]
		[HHGPBADECGL(MGNIEFNKKLA.Self, false, false, false)]
		private UITiler tiler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		[SerializeField]
		private HBCABGKNLMP type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private GGPFPLDGNNB CBDDAPAODND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private KHINEMMODAO DNMIKEDBKPO;

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		private KHINEMMODAO NLHPPONELDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0xBCB5A0", Offset = "0xBC9DA0", VA = "0x180BCB5A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		private DBCICEJFIGD JDEPHFPMAAO
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0xBCB4C0", Offset = "0xBC9CC0", VA = "0x180BCB4C0")]
			get
			{
				return default(DBCICEJFIGD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xBCB450", Offset = "0xBC9C50", VA = "0x180BCB450", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0xBCB0A0", Offset = "0xBC98A0", VA = "0x180BCB0A0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xBCB610", Offset = "0xBC9E10", VA = "0x180BCB610")]
		public TilerTheme()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public enum CEEAFADHGGC
{
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	PrimarySolid,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	SecondarySolid,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	HighlightSolid,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	HighlightGradient,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	BannerBG,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	InputField,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	LineColor,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	CardImageBase,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	DarkGradient,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	Shadow,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	Error,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	Warning,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	NotiBase,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	BackgroundAccent,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	SideBarBG,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	Modified,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	LoadingScreen,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	LoadingBarGradient,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	HomeButtonBase,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	TitleRoot,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	HighlightedAccent,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	LoadingCard,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	ChipBase,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	LimitedEventCard,
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	LimitedEventBgSolid,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	DateChip,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	WinterWonderlandBG
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public enum JKIJAIKKHHE
{
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	A
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public enum DHDELLAANPE
{
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	MainPrimary,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	MainSecondary,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	InversePrimary,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	NotUse,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	WhitePrimary,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	WhiteSecondary,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	CardPrimary,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	CardSecondary,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	Error,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	Modified,
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	Orange
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public enum HBCABGKNLMP
{
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	WatchBackground,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	HomePage,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	DialogPage,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	Card,
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	ProfileBG,
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	WinterWonderlandHome
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public enum JGBGNMILGJP
{
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	JostMedium,
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	JostMediumCap,
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	JostBoldCap,
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	RobotoReg,
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	RobotoBold,
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	RobotoBoldOutlineDropshadow,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	RobotoBoldOutline,
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	RobotoBoldOutlineDropshadowGradient,
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	RobotoBoldOutlineGradient
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public enum BENIBJHCMDO
{
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	XXXS = -1,
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	XXS = 0,
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	XS = 1,
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	S = 2,
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	M = 3,
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	L = 4,
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	XL = 5,
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	XXL = 8,
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	XXXL = 6,
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	XXXXL = 7
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public enum GBKHOIEBHJP
{
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	Primary,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	Secondary,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	FlatPrimary,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	FlatButtonForWarningBanner,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	Negative,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	Chips,
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	CarouselArrowDark,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	FlatWhite,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	MagicDoor,
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	Tertiary,
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	CarouselArrowLight,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	HomePageMainButton,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	DropDown,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	SecondaryHeaderSection,
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	ChatButton,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	FeedButton,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	NameTag
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum AACPPIMGFIP
{
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	FlatOrange,
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	FlatWhite,
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	InputToggle,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	Chips,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	Switch,
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	WhitePagingBlob,
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	RSVPToggleHeaderSection,
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	CardSelectableToggle,
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	ChipsDark,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	MainNavToggle,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	ListItem,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	NotiUnread,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	FlatPrimary,
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	CharadePen,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	ShareCam,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	CardSelectableToggleWithBacking,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	SecondaryHeaderSectionToggle,
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	PrimaryToSecondaryHeader,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	NegativeToSecondaryHeader,
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	LimitedEventPrimary,
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	LimitedEventSecondary,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	RoomCardWithLimitedEvent,
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	MainNavVrDetach,
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	HomeMainNav
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public enum IDDEMAGGHFH
{
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	Checkbox
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public enum JFLKPKNPMGK
{
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	Create,
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	Select,
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	Wire,
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	Configure,
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	Transform,
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	Move,
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	Rotate,
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	Scale,
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	CloneFlip,
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	Recolor,
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	Freeze,
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	MakeInvention,
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	Manipulate,
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	Delete
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public enum OGKIKKLANAC
{
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	LightFlat,
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	DarkFlat,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	Modified
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public enum KELKDGJBKGI
{
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	LightFlat,
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	DarkFlat
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public enum OIILLKPNLML
{
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	MirroUIPopUp
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public enum PLPMNPOBODF
{
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	Base,
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	Button,
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	Navigation,
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	Overlay,
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	Dialog,
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	Toast
}
namespace RRUI.Theme
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public abstract class ButtonThemeBase : SelectableThemeBase
	{
		[Cpp2IlInjected.Token(Token = "0x2000063")]
		protected class HLAIIJJKHGO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001D1")]
			public ButtonAudioPaletteAsset APOKLNIJPHN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001D2")]
			public RecRoomAudioClipPoolConfig PLLOBGGMLJO;

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0xBC03E0", Offset = "0xBBEBE0", VA = "0x180BC03E0")]
			public HLAIIJJKHGO()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		[SerializeField]
		[Header("Button Theme Base")]
		[KDKAGIPBBGM(MGNIEFNKKLA.Self, false, false, false)]
		private MultiGraphicButton multiGraphicButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		[SerializeField]
		[KDKAGIPBBGM(MGNIEFNKKLA.Self, false, true, false)]
		private Image surface;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		[SerializeField]
		private bool useSurfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		[SerializeField]
		[LEKNNDJMFFO("useSurfaceOverride")]
		private Image surfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		[SerializeField]
		[LBBBOIMCAIE]
		private List<Graphic> graphics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		[SerializeField]
		private bool useGraphicsOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		[SerializeField]
		[LEKNNDJMFFO("useGraphicsOverride")]
		private List<Graphic> graphicsOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		[SerializeField]
		[KDKAGIPBBGM(MGNIEFNKKLA.Self, false, true, false)]
		private UIGradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		[SerializeField]
		private bool useGradientOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		[SerializeField]
		[LEKNNDJMFFO("useGradientOverride")]
		private UIGradient gradientOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		[SerializeField]
		[KDKAGIPBBGM(MGNIEFNKKLA.Children, true, true, false)]
		private TextMeshProUGUI textMeshProUGUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		[SerializeField]
		private bool useTextMeshProUGUIOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		[SerializeField]
		[LEKNNDJMFFO("useTextMeshProUGUIOverride")]
		private TextMeshProUGUI textMeshProUGUIOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		[SerializeField]
		private BENIBJHCMDO textSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		[SerializeField]
		protected Hideable borderHideable;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		[SerializeField]
		protected bool isAnimationEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		[SerializeField]
		[LEKNNDJMFFO("isAnimationEnabled")]
		protected bool overrideAnimationTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		[SerializeField]
		[LEKNNDJMFFO("overrideAnimationTarget")]
		protected GameObject animationTargetOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private bool CIBFEDBGPBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private Vector3 JLPELFMJHCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private Vector3 KDCNOPLKMLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private EAODNKAKKBM CBPKGGLFMKD;

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public Image ABDJFAGGKDM
		{
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0xBBD930", Offset = "0xBBC130", VA = "0x180BBD930")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public List<Graphic> LKHDKMKEBLP
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0xBBD910", Offset = "0xBBC110", VA = "0x180BBD910")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public UIGradient AHEHGFNIAGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0xBBD8F0", Offset = "0xBBC0F0", VA = "0x180BBD8F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public TextMeshProUGUI GJEOLOJMAEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0xBBD950", Offset = "0xBBC150", VA = "0x180BBD950")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public BENIBJHCMDO AOMGJEBAPFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0xBBD970", Offset = "0xBBC170", VA = "0x180BBD970")]
			get
			{
				return default(BENIBJHCMDO);
			}
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0xBBD980", Offset = "0xBBC180", VA = "0x180BBD980")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		protected Transform HJLDGCKPGFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0xBBCD00", Offset = "0xBBB500", VA = "0x180BBCD00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		public Button PMEMPJFFMOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0xBBD870", Offset = "0xBBC070", VA = "0x180BBD870")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xBBCF60", Offset = "0xBBB760", VA = "0x180BBCF60")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xBBCEC0", Offset = "0xBBB6C0", VA = "0x180BBCEC0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xBBCD40", Offset = "0xBBB540", VA = "0x180BBCD40")]
		protected void NGFAIDNBNLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xBBC230", Offset = "0xBBAA30", VA = "0x180BBC230")]
		protected void GJBPOCOPJLK(ButtonPalette AABJOFIAIAB, [Optional] HLAIIJJKHGO JHGBNOIHJJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xBBCFE0", Offset = "0xBBB7E0", VA = "0x180BBCFE0", Slot = "12")]
		public override void OnPointerDown(PointerEventData CBLNAPKAJBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0xBBD3C0", Offset = "0xBBBBC0", VA = "0x180BBD3C0", Slot = "13")]
		public override void OnPointerUp(PointerEventData CBLNAPKAJBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xBBCFC0", Offset = "0xBBB7C0", VA = "0x180BBCFC0", Slot = "14")]
		public override void OnPointerClick(PointerEventData CBLNAPKAJBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xBBCCE0", Offset = "0xBBB4E0", VA = "0x180BBCCE0")]
		private Vector3 HAEEOMOCMFB(float KACNEPKNFIL)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xBBD6F0", Offset = "0xBBBEF0", VA = "0x180BBD6F0")]
		protected ButtonThemeBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xBBC210", Offset = "0xBBAA10", VA = "0x180BBC210")]
		[CompilerGenerated]
		private void EMJMAMODPNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0xBBC210", Offset = "0xBBAA10", VA = "0x180BBC210")]
		[CompilerGenerated]
		private void COPHGGIFLME()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public class ContentLoadingAudioPaletteAsset : BaseAudioPaletteAsset
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		[SerializeField]
		[Header("Clip Configs")]
		private RecRoomAudioClipPoolConfig loadingSFXAudioClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		[SerializeField]
		[Tooltip("Only start looping loading SFX if any content has been loading for this much time")]
		[Header("Thresholds")]
		private float loadingSFXStartDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		[SerializeField]
		[Tooltip("Small delay between content finish loading and stopping loading SFX. Avoiding quick stop and replay if contents load back to back.")]
		private float loadingSFXStopDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		[SerializeField]
		[Tooltip("Cut loading SFX if content is still loading after this much time. Avoid sustaining SFX when content is hanging on loading.")]
		private float maxLoadingSFXLength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		[SerializeField]
		[Header("Smooth Fade")]
		private float fadeInDuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		[SerializeField]
		private float fadeOutDuration;

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		public float LoadingSFXStartDelay
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0xBBDD90", Offset = "0xBBC590", VA = "0x180BBDD90")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		public float LoadingSFXStopDelay
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0xBBDDA0", Offset = "0xBBC5A0", VA = "0x180BBDDA0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		public float MaxLoadingSFXLength
		{
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0xA64350", Offset = "0xA62B50", VA = "0x180A64350")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		public float FadeInDuration
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0xA51050", Offset = "0xA4F850", VA = "0x180A51050")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		public float FadeOutDuration
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0xA50F00", Offset = "0xA4F700", VA = "0x180A50F00")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0xBBDC90", Offset = "0xBBC490", VA = "0x180BBDC90")]
		public bool OECOALNCFAP(out RecRoomAudioClip[] GLENKIGIOAA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xBBDD40", Offset = "0xBBC540", VA = "0x180BBDD40")]
		public ContentLoadingAudioPaletteAsset()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class TogglePalette
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		[SerializeField]
		private ButtonPalette inactiveButtonPalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		[SerializeField]
		private ButtonPalette activeButtonPalette;

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		public ButtonPalette InactiveButtonPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x85D1E0", Offset = "0x85B9E0", VA = "0x18085D1E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		public ButtonPalette ActiveButtonPalette
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0xBC03E0", Offset = "0xBBEBE0", VA = "0x180BC03E0")]
		public TogglePalette()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class SliderPalette
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		[SerializeField]
		private Color sliderColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		[SerializeField]
		private Color fillColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		[SerializeField]
		private Color handleColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		[SerializeField]
		private TextStylePalette textPalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		[SerializeField]
		private Color textColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		[SerializeField]
		private ColorBlock colorBlock;

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		public Color SliderColor
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0xBBC120", Offset = "0xBBA920", VA = "0x180BBC120")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public Color FillColor
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0xBBEC00", Offset = "0xBBD400", VA = "0x180BBEC00")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public Color HandleColor
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0xBC0490", Offset = "0xBBEC90", VA = "0x180BC0490")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public TextStylePalette TextPalette
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x7F51E0", Offset = "0x7F39E0", VA = "0x1807F51E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public Color TextColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0xB59DE0", Offset = "0xB585E0", VA = "0x180B59DE0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public ColorBlock ColorBlock
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0xBC9F20", Offset = "0xBC8720", VA = "0x180BC9F20")]
			get
			{
				return default(ColorBlock);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xBC9E50", Offset = "0xBC8650", VA = "0x180BC9E50")]
		public SliderPalette()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public class SliderTheme : SelectableThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		[SerializeField]
		[HHGPBADECGL(MGNIEFNKKLA.Self, false, false, false)]
		[Header("Slider Visual")]
		private Slider slider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		[SerializeField]
		private OIILLKPNLML sliderType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		[SerializeField]
		[Header("Slider Audio")]
		private MBHCJDDDHIK buttonAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		[SerializeField]
		[Tooltip("Layer a 2D SFX on top of base button sounds")]
		private bool useFlavorSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		[SerializeField]
		[LEKNNDJMFFO("useFlavorSFX")]
		[Tooltip("Flavor SFX is picked randomly from this pool config")]
		private RecRoomAudioClipPoolConfig flavorSFXClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		[SerializeField]
		private Image sliderImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		[SerializeField]
		private Image fillImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		[SerializeField]
		private Image handleImage;

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public OIILLKPNLML FGALDMKBHCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0xA89D10", Offset = "0xA88510", VA = "0x180A89D10")]
			get
			{
				return default(OIILLKPNLML);
			}
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0xBCA3C0", Offset = "0xBC8BC0", VA = "0x180BCA3C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public Image LCKFDJJCNIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x8B4140", Offset = "0x8B2940", VA = "0x1808B4140")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public Image BGNLJBNLMHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x8B41E0", Offset = "0x8B29E0", VA = "0x1808B41E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		public Image FBAFAAHPBDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x8E9210", Offset = "0x8E7A10", VA = "0x1808E9210")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0xBC9F60", Offset = "0xBC8760", VA = "0x180BC9F60", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xBCA340", Offset = "0xBC8B40", VA = "0x180BCA340")]
		public SliderTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public class MakerPenToolTheme : ButtonThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		[SerializeField]
		[Header("Maker Pen Tool")]
		private JFLKPKNPMGK makerPenToolPaletteType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		[SerializeField]
		[Tooltip("A list of objects to show while the maker pen tool is active.")]
		private List<Hideable> hideWhenNotActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		[SerializeField]
		[Tooltip("A list of objects to show while the maker pen tool is inactive")]
		private List<Hideable> hideWhenActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		[SerializeField]
		private bool editorIsActiveOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x131")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		protected bool NLDJDDGFIJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x132")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private bool MBOOEJLAKMG;

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public JFLKPKNPMGK OHJNJEFLJPN
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0xBBC110", Offset = "0xBBA910", VA = "0x180BBC110")]
			get
			{
				return default(JFLKPKNPMGK);
			}
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0xBBDC70", Offset = "0xBBC470", VA = "0x180BBDC70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public bool EBBFILBJDCG
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0xBC1290", Offset = "0xBBFA90", VA = "0x180BC1290")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0xBC12A0", Offset = "0xBBFAA0", VA = "0x180BC12A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xBC11F0", Offset = "0xBBF9F0", VA = "0x180BC11F0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0xBC0E10", Offset = "0xBBF610", VA = "0x180BC0E10", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xBC1230", Offset = "0xBBFA30", VA = "0x180BC1230")]
		public MakerPenToolTheme()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public enum MBHCJDDDHIK
{
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	Negative = 1,
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	SelectPrimary = 2,
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	SelectSidebar = 12,
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	SelectCardToggle = 14,
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	SelectSidebarInactive = 17,
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	ToggleOnSwitch = 18,
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	ToggleOffSwitch = 19,
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	ToggleChip = 20,
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	SliderDefault = 21
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public enum KOPACFMHODN
{
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	Default
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public enum DDKJOAEFPED
{
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	Default
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public enum CGKHHPHPKGH
{
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	Default
}
namespace RRUI.Theme
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class ScrollingAudioPaletteAsset : BaseAudioPaletteAsset
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		[SerializeField]
		[Header("Clip Configs")]
		private RecRoomAudioClipPoolConfig scrollingSFXAudioClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		[SerializeField]
		private RecRoomAudioClipPoolConfig hittingEndsAudioClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		[SerializeField]
		[Header("Thresholds")]
		[Tooltip("This distance is measured in UI canvas space")]
		private float distanceThresholdToTriggerScrollingSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		[SerializeField]
		private float minimumTimeIntervalForScrollingSFX;

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public float DistanceThresholdToTriggerScrollingSFX
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0xA64350", Offset = "0xA62B50", VA = "0x180A64350")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		public float MinimumTimeIntervalForScrollingSFX
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0xA51050", Offset = "0xA4F850", VA = "0x180A51050")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0xBBDC90", Offset = "0xBBC490", VA = "0x180BBDC90")]
		public bool BEFHPDCPKNJ(out RecRoomAudioClip[] GLENKIGIOAA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0xBC8E80", Offset = "0xBC7680", VA = "0x180BC8E80")]
		public bool NCILIHMOLMA(out RecRoomAudioClip[] GLENKIGIOAA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0xBC8F30", Offset = "0xBC7730", VA = "0x180BC8F30")]
		public ScrollingAudioPaletteAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public class ScrollRectTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private const string IOICLGGAIPM = "RRUI.PlayHittingEndsSFX";

		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private const int LNKLHLKHNCK = 5;

		[Cpp2IlInjected.Token(Token = "0x4000206")]
		private const int IJJKDOAKOLN = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		private DateTimeOffset AJCOILCLNMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		private int NKGIMOAHNLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		private bool LGJHJAFOEMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		[SerializeField]
		[HHGPBADECGL(MGNIEFNKKLA.Self, false, false, false)]
		private ScrollRect scrollRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		[SerializeField]
		[Header("Audio")]
		private KOPACFMHODN scrollAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private ScrollingAudioPaletteAsset AMDOKPIHBJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private AOHHOPAIALB FHDBGEBKHNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		private BBDNFHGFMBE JHPLPGAICLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private float BHOCJDFBHIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		private float GKNOOFFBCHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		private float CHFABMIHOBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		private bool EJLENOGNKEB;

		[Cpp2IlInjected.Token(Token = "0x4000213")]
		private const float PMMLKMOBNIJ = 0.01f;

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		private AOHHOPAIALB OBGKDOHCIGC
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0xBC7810", Offset = "0xBC6010", VA = "0x180BC7810")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		private BBDNFHGFMBE NELMIKFANIM
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0xBC7A70", Offset = "0xBC6270", VA = "0x180BC7A70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xBC75F0", Offset = "0xBC5DF0", VA = "0x180BC75F0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0xBC7FD0", Offset = "0xBC67D0", VA = "0x180BC7FD0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xBC74F0", Offset = "0xBC5CF0", VA = "0x180BC74F0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xBC7AE0", Offset = "0xBC62E0", VA = "0x180BC7AE0")]
		private void HHCGEGEKEDF(Vector2 NABPHMOHNDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xBC7880", Offset = "0xBC6080", VA = "0x180BC7880")]
		private void DJHOELECICD(float MHOGCFCMOOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xBC80E0", Offset = "0xBC68E0", VA = "0x180BC80E0")]
		private void PFCLEOFMGFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0xBC73D0", Offset = "0xBC5BD0", VA = "0x180BC73D0")]
		private static string AEJGCCNAJEK(GameObject HHNPCHNMLMA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0xBC8DD0", Offset = "0xBC75D0", VA = "0x180BC8DD0")]
		public ScrollRectTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public class LabelTheme : GraphicTheme
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		[SerializeField]
		[HHGPBADECGL(MGNIEFNKKLA.Self, false, false, false)]
		private TextMeshProUGUI textMeshProUGUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		[SerializeField]
		private JGBGNMILGJP textType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		[SerializeField]
		private BENIBJHCMDO textSize;

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public JGBGNMILGJP JKLGIKMEIGI
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x9082E0", Offset = "0x906AE0", VA = "0x1809082E0")]
			get
			{
				return default(JGBGNMILGJP);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0xBC0DC0", Offset = "0xBBF5C0", VA = "0x180BC0DC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		public BENIBJHCMDO AOMGJEBAPFJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x91A0D0", Offset = "0x9188D0", VA = "0x18091A0D0")]
			get
			{
				return default(BENIBJHCMDO);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0xBC0DA0", Offset = "0xBBF5A0", VA = "0x180BC0DA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0xBC0A00", Offset = "0xBBF200", VA = "0x180BC0A00", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0xBC0D30", Offset = "0xBBF530", VA = "0x180BC0D30")]
		public LabelTheme()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class PFBBJKPLBFC
{
	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
	public PFBBJKPLBFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0xBC23C0", Offset = "0xBC0BC0", VA = "0x180BC23C0")]
	public static string NIMNBIGPMKB(byte[] DCFEDNINKHD, byte[] LFMKEJPAGIF)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public class __BB_OBFUSCATOR_VERSION_3_9_9
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
