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
			[Cpp2IlInjected.Address(RVA = "0x9A3190", Offset = "0x9A1D90", VA = "0x1809A3190")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x9A3330", Offset = "0x9A1F30", VA = "0x1809A3330")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public ColorBlock GFJAHDGGIOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x4615AB0", Offset = "0x46146B0", VA = "0x184615AB0")]
			get
			{
				return default(ColorBlock);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x4615B30", Offset = "0x4614730", VA = "0x184615B30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public UIGradient FIHJAOFLBHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xF00490", Offset = "0xEFF090", VA = "0x180F00490")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x1AB2C80", Offset = "0x1AB1880", VA = "0x181AB2C80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public GradientBlock BCGFKKOOPHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x4615B00", Offset = "0x4614700", VA = "0x184615B00")]
			get
			{
				return default(GradientBlock);
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x4615B80", Offset = "0x4614780", VA = "0x184615B80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x4615900", Offset = "0x4614500", VA = "0x184615900", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x4615950", Offset = "0x4614550", VA = "0x184615950", Slot = "36")]
		public override void OnSelect(BaseEventData CBLNAPKAJBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x46159A0", Offset = "0x46145A0", VA = "0x1846159A0")]
		public void Refresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4615470", Offset = "0x4614070", VA = "0x184615470", Slot = "26")]
		protected override void DoStateTransition(SelectionState LLBKKANHBEL, bool MALHBDBALAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x4615820", Offset = "0x4614420", VA = "0x184615820")]
		private void JKGEPGMKEEM(Graphic DOHMHIOBNNH, Color MAGKCELEODA, bool MALHBDBALAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x4615720", Offset = "0x4614320", VA = "0x184615720")]
		private void HOAIMPFIPIC(SelectionState LLBKKANHBEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x46159D0", Offset = "0x46145D0", VA = "0x1846159D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x461E4F0", Offset = "0x461D0F0", VA = "0x18461E4F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public Palette Active
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x461E4C0", Offset = "0x461D0C0", VA = "0x18461E4C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x12E2130", Offset = "0x12E0D30", VA = "0x1812E2130")]
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
			[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
			public LDMLCPGHCOF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x4614240", Offset = "0x4612E40", VA = "0x184614240")]
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
			[Cpp2IlInjected.Address(RVA = "0x4613470", Offset = "0x4612070", VA = "0x184613470")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public TMP_SpriteAsset EmojiAsset
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x83D1E0", Offset = "0x83BDE0", VA = "0x18083D1E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x4612F80", Offset = "0x4611B80", VA = "0x184612F80")]
		public bool KBEFLHBKBNC(TMP_FontAsset DJKJLIMANNG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x46130C0", Offset = "0x4611CC0", VA = "0x1846130C0")]
		public TMP_FontAsset KHDMHJINCHG(TMP_FontAsset DJKJLIMANNG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x46131C0", Offset = "0x4611DC0", VA = "0x1846131C0")]
		public TMP_FontAsset KHDMHJINCHG(TMP_FontAsset DJKJLIMANNG, Material DJHMOJAKINL, out Material BKMBEMOABEB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4612C40", Offset = "0x4611840", VA = "0x184612C40")]
		public TMP_FontAsset GCFPIDHKPPC(TMP_FontAsset DJKJLIMANNG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4612D40", Offset = "0x4611940", VA = "0x184612D40")]
		public TMP_FontAsset GCFPIDHKPPC(TMP_FontAsset DJKJLIMANNG, Material DJHMOJAKINL, out Material DPBBECJOFFP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x46133B0", Offset = "0x4611FB0", VA = "0x1846133B0")]
		private static bool MKDMPICGFOD(TMP_FontAsset DJKJLIMANNG, LocalizedFontMapping IDCAMNJLHEF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x10C7230", Offset = "0x10C5E30", VA = "0x1810C7230")]
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
		[Cpp2IlInjected.Address(RVA = "0x4613670", Offset = "0x4612270", VA = "0x184613670", Slot = "0")]
		public override bool Equals(object HHNPCHNMLMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x4613780", Offset = "0x4612380", VA = "0x184613780", Slot = "4")]
		public bool Equals(GradientBlock MDHJAFNLPON)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x4613780", Offset = "0x4612380", VA = "0x184613780")]
		public static bool FMMDKFLNNFA(GradientBlock OHFJEPKOEEM, GradientBlock JJJCHKJIKDB)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x46135F0", Offset = "0x46121F0", VA = "0x1846135F0")]
		public static bool BDPOAMCDIDB(GradientBlock OHFJEPKOEEM, GradientBlock JJJCHKJIKDB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x4613800", Offset = "0x4612400", VA = "0x184613800", Slot = "2")]
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
			[Cpp2IlInjected.Address(RVA = "0x4614C50", Offset = "0x4613850", VA = "0x184614C50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public RecRoomAudioClip[] MenuOpen2DFlavorAudioClipPool
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x4614CE0", Offset = "0x46138E0", VA = "0x184614CE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public RecRoomAudioClip[] MenuDehydrateAudioClipPool
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x4614BC0", Offset = "0x46137C0", VA = "0x184614BC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public RecRoomAudioClip[] MenuClose2DFlavorAudioClipPool
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x4614B30", Offset = "0x4613730", VA = "0x184614B30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x383DA30", Offset = "0x383C630", VA = "0x18383DA30")]
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
			[Cpp2IlInjected.Address(RVA = "0x460F810", Offset = "0x460E410", VA = "0x18460F810")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public RecRoomAudioClip[] PointerUpAudioClipPool
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x460F930", Offset = "0x460E530", VA = "0x18460F930")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public RecRoomAudioClip[] PointerClickAudioClipPool
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x460F780", Offset = "0x460E380", VA = "0x18460F780")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public RecRoomAudioClip[] PointerEnterAudioClipPool
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x460F8A0", Offset = "0x460E4A0", VA = "0x18460F8A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x383DA30", Offset = "0x383C630", VA = "0x18383DA30")]
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
			[Cpp2IlInjected.Address(RVA = "0x128EBB0", Offset = "0x128D7B0", VA = "0x18128EBB0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public float ClickAnimationScale
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x128EB30", Offset = "0x128D730", VA = "0x18128EB30")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x460F760", Offset = "0x460E360", VA = "0x18460F760")]
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
		[Cpp2IlInjected.Address(RVA = "0x461A990", Offset = "0x4619590", VA = "0x18461A990", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x461AAB0", Offset = "0x46196B0", VA = "0x18461AAB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x839000", Offset = "0x837C00", VA = "0x180839000")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Color TintColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x843900", Offset = "0x842500", VA = "0x180843900")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Color BackgroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x8438F0", Offset = "0x8424F0", VA = "0x1808438F0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public Vector2 Spacing
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x461E6C0", Offset = "0x461D2C0", VA = "0x18461E6C0")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float Offset
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x14D6330", Offset = "0x14D4F30", VA = "0x1814D6330")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Vector2 Velocity
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x461E6E0", Offset = "0x461D2E0", VA = "0x18461E6E0")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public float Angle
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x165C100", Offset = "0x165AD00", VA = "0x18165C100")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public UITiler.NNJMPEJKFOG AnimationDirection
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x973820", Offset = "0x972420", VA = "0x180973820")]
			get
			{
				return default(UITiler.NNJMPEJKFOG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float PrimaryAnimationSpeed
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x165C110", Offset = "0x165AD10", VA = "0x18165C110")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float AltAnimationSpeed
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x140D420", Offset = "0x140C020", VA = "0x18140D420")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x461E630", Offset = "0x461D230", VA = "0x18461E630")]
		public float AJHABMMPGJO(DBCICEJFIGD DHFEMAFLFOF)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x461E650", Offset = "0x461D250", VA = "0x18461E650")]
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
			[Cpp2IlInjected.Address(RVA = "0x83D1E0", Offset = "0x83BDE0", VA = "0x18083D1E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		protected virtual bool GNOBMDCIAFP
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x7F5D00", Offset = "0x7F4900", VA = "0x1807F5D00", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool HDLGCEHMIMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x4618E20", Offset = "0x4617A20", VA = "0x184618E20")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x4618E40", Offset = "0x4617A40", VA = "0x184618E40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private AOHHOPAIALB OBGKDOHCIGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x461C700", Offset = "0x461B300", VA = "0x18461C700")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		protected FPODAMBEHMF HGLBCDNHGEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x461C7E0", Offset = "0x461B3E0", VA = "0x18461C7E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private HAOMCPLNIHN MFDHMPIGPFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x461C770", Offset = "0x461B370", VA = "0x18461C770")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x461D3B0", Offset = "0x461BFB0", VA = "0x18461D3B0")]
		protected void PIPHLHLHHNE(ButtonAudioPaletteAsset BEGEFEAMLFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9660D0", Offset = "0x964CD0", VA = "0x1809660D0")]
		protected void DPMJDKKOMGA(RecRoomAudioClipPoolConfig BGOBOMHOCFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x461D000", Offset = "0x461BC00", VA = "0x18461D000", Slot = "12")]
		public virtual void OnPointerDown(PointerEventData CBLNAPKAJBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x461D270", Offset = "0x461BE70", VA = "0x18461D270", Slot = "13")]
		public virtual void OnPointerUp(PointerEventData CBLNAPKAJBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x461CC30", Offset = "0x461B830", VA = "0x18461CC30", Slot = "14")]
		public virtual void OnPointerClick(PointerEventData CBLNAPKAJBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x461D140", Offset = "0x461BD40", VA = "0x18461D140", Slot = "15")]
		public virtual void OnPointerEnter(PointerEventData CBLNAPKAJBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x461C680", Offset = "0x461B280", VA = "0x18461C680")]
		private void AKGHOHELPHC(RecRoomAudioClip[] GLENKIGIOAA, bool JLGKMPDEMFB = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x461C850", Offset = "0x461B450", VA = "0x18461C850")]
		private void NMLCEMCANDC(RecRoomAudioClip ILAGKMAKNHE, bool JLGKMPDEMFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x461D4D0", Offset = "0x461C0D0", VA = "0x18461D4D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4614DE0", Offset = "0x46139E0", VA = "0x184614DE0")]
		public TogglePalette EKNBJNCEFBN(Palette CFAOEFMKCHD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x4614D70", Offset = "0x4613970", VA = "0x184614D70")]
		public ButtonPalette BHIHCBKEIPL(Palette CFAOEFMKCHD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x188DCC0", Offset = "0x188C8C0", VA = "0x18188DCC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4619D00", Offset = "0x4618900", VA = "0x184619D00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x4619AF0", Offset = "0x46186F0", VA = "0x184619AF0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x461A180", Offset = "0x4618D80", VA = "0x18461A180")]
		protected void KLPHGFBCGDA(bool MNNPIACJMFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x461A170", Offset = "0x4618D70", VA = "0x18461A170")]
		protected void KBLEECLOEJA(GameObject FHJBBMIILLG, int MBNOPHIGKGE, bool JFKPJBACPEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x4619F60", Offset = "0x4618B60", VA = "0x184619F60")]
		protected void KALALIAPNDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x461A460", Offset = "0x4619060", VA = "0x18461A460")]
		protected void PAJLLELOLBP(float NAOEMMMJJLE, float AKNOFPAINMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x4619D70", Offset = "0x4618970", VA = "0x184619D70")]
		private void DJHOELECICD(float MHOGCFCMOOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x461A7E0", Offset = "0x46193E0", VA = "0x18461A7E0")]
		private void PFCLEOFMGFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x461A930", Offset = "0x4619530", VA = "0x18461A930")]
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
		[Cpp2IlInjected.Address(RVA = "0x461DDD0", Offset = "0x461C9D0", VA = "0x18461DDD0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x461E050", Offset = "0x461CC50", VA = "0x18461E050")]
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
		[Cpp2IlInjected.Address(RVA = "0x460F140", Offset = "0x460DD40", VA = "0x18460F140")]
		private void PBAELFIBGFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x460ED80", Offset = "0x460D980", VA = "0x18460ED80", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x460F220", Offset = "0x460DE20", VA = "0x18460F220")]
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
			[Cpp2IlInjected.Address(RVA = "0x4612BF0", Offset = "0x46117F0", VA = "0x184612BF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public KELKDGJBKGI NAFLFODNNGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x870100", Offset = "0x86ED00", VA = "0x180870100")]
			get
			{
				return default(KELKDGJBKGI);
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x4612C00", Offset = "0x4611800", VA = "0x184612C00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public BENIBJHCMDO AOMGJEBAPFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xA6B390", Offset = "0xA69F90", VA = "0x180A6B390")]
			get
			{
				return default(BENIBJHCMDO);
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x4612C20", Offset = "0x4611820", VA = "0x184612C20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x4612510", Offset = "0x4611110", VA = "0x184612510", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x4612B80", Offset = "0x4611780", VA = "0x184612B80")]
		public DropdownTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class BaseAudioPaletteAsset : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x460F6B0", Offset = "0x460E2B0", VA = "0x18460F6B0")]
		protected bool ACHGKMDGNMM(RecRoomAudioClipPoolConfig KFIDLHJLEBM, out RecRoomAudioClip[] GLENKIGIOAA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x10C7230", Offset = "0x10C5E30", VA = "0x1810C7230")]
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
			[Cpp2IlInjected.Address(RVA = "0x178C020", Offset = "0x178AC20", VA = "0x18178C020")]
			get
			{
				return default(GBKHOIEBHJP);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x46115C0", Offset = "0x46101C0", VA = "0x1846115C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x4611300", Offset = "0x460FF00", VA = "0x184611300", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x12C08A0", Offset = "0x12BF4A0", VA = "0x1812C08A0")]
		public void SetAnimationEnabled(bool CNIPDMAOMPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x4611580", Offset = "0x4610180", VA = "0x184611580")]
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
		[Cpp2IlInjected.Address(RVA = "0x4619590", Offset = "0x4618190", VA = "0x184619590", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x4619850", Offset = "0x4618450", VA = "0x184619850", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x46197E0", Offset = "0x46183E0", VA = "0x1846197E0")]
		private void KIJNHKCOMMO(float NAOEMMMJJLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x4619A70", Offset = "0x4618670", VA = "0x184619A70")]
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
				[Cpp2IlInjected.Address(RVA = "0x7F3000", Offset = "0x7F1C00", VA = "0x1807F3000")]
				get
				{
					return default(MBHCJDDDHIK);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public ButtonAudioPaletteAsset ButtonAudioPaletteConfig
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x1B97790", Offset = "0x1B96390", VA = "0x181B97790")]
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
				[Cpp2IlInjected.Address(RVA = "0x7F3000", Offset = "0x7F1C00", VA = "0x1807F3000")]
				get
				{
					return default(KOPACFMHODN);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			public ScrollingAudioPaletteAsset ScrollingAudioPaletteConfig
			{
				[Cpp2IlInjected.Token(Token = "0x600007D")]
				[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x1B97790", Offset = "0x1B96390", VA = "0x181B97790")]
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
				[Cpp2IlInjected.Address(RVA = "0x7F3000", Offset = "0x7F1C00", VA = "0x1807F3000")]
				get
				{
					return default(DDKJOAEFPED);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			public ContentLoadingAudioPaletteAsset ContentLoadingAudioPaletteConfig
			{
				[Cpp2IlInjected.Token(Token = "0x6000080")]
				[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x1B97790", Offset = "0x1B96390", VA = "0x181B97790")]
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
				[Cpp2IlInjected.Address(RVA = "0x7F3000", Offset = "0x7F1C00", VA = "0x1807F3000")]
				get
				{
					return default(CGKHHPHPKGH);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			public RecyclingAudioPaletteAsset RecyclingAudioPaletteConfig
			{
				[Cpp2IlInjected.Token(Token = "0x6000083")]
				[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x1B97790", Offset = "0x1B96390", VA = "0x181B97790")]
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
			[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
			public BHGLODIGPOO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xE64FA0", Offset = "0xE63BA0", VA = "0x180E64FA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
			public CBCAOBNHBNP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xE64FA0", Offset = "0xE63BA0", VA = "0x180E64FA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
			public MNJPDFENCEK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xE64FA0", Offset = "0xE63BA0", VA = "0x180E64FA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
			public AKOEPOJGKCG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xE64FA0", Offset = "0xE63BA0", VA = "0x180E64FA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x460F260", Offset = "0x460DE60", VA = "0x18460F260")]
		public ButtonAudioPaletteAsset EBMKCHJAKBL(MBHCJDDDHIK JPABGPBOOPC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x460F350", Offset = "0x460DF50", VA = "0x18460F350")]
		public ScrollingAudioPaletteAsset FIOCCCEFGAB(KOPACFMHODN GJPMFKKCPIN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x460F530", Offset = "0x460E130", VA = "0x18460F530")]
		public ContentLoadingAudioPaletteAsset HNDLOFKCBBD(DDKJOAEFPED CPGPIMJEICO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x460F440", Offset = "0x460E040", VA = "0x18460F440")]
		public RecyclingAudioPaletteAsset GKEBFKIEGMA(CGKHHPHPKGH FLMJNHLLPJK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x383DA30", Offset = "0x383C630", VA = "0x18383DA30")]
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
			[Cpp2IlInjected.Address(RVA = "0xF448A0", Offset = "0xF434A0", VA = "0x180F448A0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public Color ForegroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0xE43730", Offset = "0xE42330", VA = "0x180E43730")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public Color PlaceholderColor
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x13CA7B0", Offset = "0x13C93B0", VA = "0x1813CA7B0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public TextStylePalette TextPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x89C580", Offset = "0x89B180", VA = "0x18089C580")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x4613CE0", Offset = "0x46128E0", VA = "0x184613CE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x899850", Offset = "0x898450", VA = "0x180899850")]
			get
			{
				return default(CEEAFADHGGC);
			}
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x461DDB0", Offset = "0x461C9B0", VA = "0x18461DDB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x461DAE0", Offset = "0x461C6E0", VA = "0x18461DAE0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x461DD50", Offset = "0x461C950", VA = "0x18461DD50")]
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
			[Cpp2IlInjected.Address(RVA = "0x128EBC0", Offset = "0x128D7C0", VA = "0x18128EBC0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x46115E0", Offset = "0x46101E0", VA = "0x1846115E0")]
		public bool CIMMMBIAEHP(out RecRoomAudioClip[] GLENKIGIOAA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x4619050", Offset = "0x4617C50", VA = "0x184619050")]
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
			[Cpp2IlInjected.Address(RVA = "0x4617A80", Offset = "0x4616680", VA = "0x184617A80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public bool AAJCPFDMPMO
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0xC214A0", Offset = "0xC200A0", VA = "0x180C214A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public float LKPPNPMJJGB
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x46178B0", Offset = "0x46164B0", VA = "0x1846178B0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		private bool OEKCFPBBBME
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x4616CA0", Offset = "0x46158A0", VA = "0x184616CA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		private bool FDDKNEIPOGO
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x4616AA0", Offset = "0x46156A0", VA = "0x184616AA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x4616630", Offset = "0x4615230", VA = "0x184616630")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x4617150", Offset = "0x4615D50", VA = "0x184617150")]
		private void OLINJIFKAFG(BGPGGIJIJPN.JJEDDHNNHCG PJKBEBPNGIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x4617180", Offset = "0x4615D80", VA = "0x184617180")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x4616370", Offset = "0x4614F70", VA = "0x184616370")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x4616D30", Offset = "0x4615930", VA = "0x184616D30")]
		private void LAPDHLKIGDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x4616500", Offset = "0x4615100", VA = "0x184616500")]
		public void AddLoadingSFXRequest(object FLDJLPKNKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x4617690", Offset = "0x4616290", VA = "0x184617690")]
		public void RemoveLoadingSFXRequest(object FLDJLPKNKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x4616370", Offset = "0x4614F70", VA = "0x184616370")]
		private void AGHLJHBLEHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x46172B0", Offset = "0x4615EB0", VA = "0x1846172B0")]
		private void PBJFOINOGGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x4617010", Offset = "0x4615C10", VA = "0x184617010")]
		private void NJKNCELJGPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x4616F10", Offset = "0x4615B10", VA = "0x184616F10")]
		private void LFOPMFJNCLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x46167C0", Offset = "0x46153C0", VA = "0x1846167C0")]
		private void CDCGECBFGMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x4616BB0", Offset = "0x46157B0", VA = "0x184616BB0")]
		private void DGNJEKAEMIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x46164B0", Offset = "0x46150B0", VA = "0x1846164B0")]
		private void AIHPKPKBPMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x4616AB0", Offset = "0x46156B0", VA = "0x184616AB0")]
		private void CIHADABNELL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x46164C0", Offset = "0x46150C0", VA = "0x1846164C0")]
		private void AKDHLANOLCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x46174C0", Offset = "0x46160C0", VA = "0x1846174C0")]
		public void Play2DUIFlavorSFX(RecRoomAudioClip[] AEHNLEPAGDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x46177B0", Offset = "0x46163B0", VA = "0x1846177B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4611A00", Offset = "0x4610600", VA = "0x184611A00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public PLPMNPOBODF CODGCEDHNEK
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x7F3230", Offset = "0x7F1E30", VA = "0x1807F3230")]
			get
			{
				return default(PLPMNPOBODF);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x46124A0", Offset = "0x46110A0", VA = "0x1846124A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		private LDBHAOEJOAP APJDBHAFHGJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x4611ED0", Offset = "0x4610AD0", VA = "0x184611ED0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		private bool PJKCBKCLGLA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x4611DE0", Offset = "0x46109E0", VA = "0x184611DE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x4611FF0", Offset = "0x4610BF0", VA = "0x184611FF0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x4611F40", Offset = "0x4610B40", VA = "0x184611F40")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x46116E0", Offset = "0x46102E0", VA = "0x1846116E0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x4612060", Offset = "0x4610C60", VA = "0x184612060")]
		private void PBAELFIBGFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x4611A60", Offset = "0x4610660", VA = "0x184611A60")]
		private Vector3 HKJMEJNFAPN()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x4612380", Offset = "0x4610F80", VA = "0x184612380")]
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
			[Cpp2IlInjected.Address(RVA = "0x1623790", Offset = "0x1622390", VA = "0x181623790")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xD50630", Offset = "0xD4F230", VA = "0x180D50630")]
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
				[Cpp2IlInjected.Address(RVA = "0x7F3000", Offset = "0x7F1C00", VA = "0x1807F3000")]
				get
				{
					return default(JKIJAIKKHHE);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			public Color Color
			{
				[Cpp2IlInjected.Token(Token = "0x60000D0")]
				[Cpp2IlInjected.Address(RVA = "0xA19F80", Offset = "0xA18B80", VA = "0x180A19F80")]
				get
				{
					return default(Color);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x4618E80", Offset = "0x4617A80", VA = "0x184618E80")]
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
				[Cpp2IlInjected.Address(RVA = "0x7F3000", Offset = "0x7F1C00", VA = "0x1807F3000")]
				get
				{
					return default(CEEAFADHGGC);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000046")]
			public Color Color
			{
				[Cpp2IlInjected.Token(Token = "0x60000D3")]
				[Cpp2IlInjected.Address(RVA = "0xA19F80", Offset = "0xA18B80", VA = "0x180A19F80")]
				get
				{
					return default(Color);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000047")]
			public Gradient Gradient
			{
				[Cpp2IlInjected.Token(Token = "0x60000D4")]
				[Cpp2IlInjected.Address(RVA = "0x7F3240", Offset = "0x7F1E40", VA = "0x1807F3240")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000048")]
			public bool RaycastTarget
			{
				[Cpp2IlInjected.Token(Token = "0x60000D5")]
				[Cpp2IlInjected.Address(RVA = "0xC214A0", Offset = "0xC200A0", VA = "0x180C214A0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x460F620", Offset = "0x460E220", VA = "0x18460F620")]
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
				[Cpp2IlInjected.Address(RVA = "0x7F3000", Offset = "0x7F1C00", VA = "0x1807F3000")]
				get
				{
					return default(DHDELLAANPE);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004A")]
			public Color Color
			{
				[Cpp2IlInjected.Token(Token = "0x60000D8")]
				[Cpp2IlInjected.Address(RVA = "0xA19F80", Offset = "0xA18B80", VA = "0x180A19F80")]
				get
				{
					return default(Color);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x46135B0", Offset = "0x46121B0", VA = "0x1846135B0")]
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
				[Cpp2IlInjected.Address(RVA = "0x7F3000", Offset = "0x7F1C00", VA = "0x1807F3000")]
				get
				{
					return default(HBCABGKNLMP);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004C")]
			public TilerPalette TilerPalette
			{
				[Cpp2IlInjected.Token(Token = "0x60000DB")]
				[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0xD50630", Offset = "0xD4F230", VA = "0x180D50630")]
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
				[Cpp2IlInjected.Address(RVA = "0x7F3000", Offset = "0x7F1C00", VA = "0x1807F3000")]
				get
				{
					return default(JGBGNMILGJP);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004E")]
			public TextStylePalette TextStylePalette
			{
				[Cpp2IlInjected.Token(Token = "0x60000DE")]
				[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x1B97790", Offset = "0x1B96390", VA = "0x181B97790")]
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
				[Cpp2IlInjected.Address(RVA = "0x7F3000", Offset = "0x7F1C00", VA = "0x1807F3000")]
				get
				{
					return default(BENIBJHCMDO);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000050")]
			public int Size
			{
				[Cpp2IlInjected.Token(Token = "0x60000E1")]
				[Cpp2IlInjected.Address(RVA = "0x7F3220", Offset = "0x7F1E20", VA = "0x1807F3220")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x461E130", Offset = "0x461CD30", VA = "0x18461E130")]
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
				[Cpp2IlInjected.Address(RVA = "0x7F3000", Offset = "0x7F1C00", VA = "0x1807F3000")]
				get
				{
					return default(GBKHOIEBHJP);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000052")]
			public ButtonPalette ButtonPalette
			{
				[Cpp2IlInjected.Token(Token = "0x60000E4")]
				[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x1B97790", Offset = "0x1B96390", VA = "0x181B97790")]
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
				[Cpp2IlInjected.Address(RVA = "0x7F3000", Offset = "0x7F1C00", VA = "0x1807F3000")]
				get
				{
					return default(AACPPIMGFIP);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000054")]
			public TogglePalette TogglePalette
			{
				[Cpp2IlInjected.Token(Token = "0x60000E7")]
				[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x1B97790", Offset = "0x1B96390", VA = "0x181B97790")]
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
				[Cpp2IlInjected.Address(RVA = "0x7F3000", Offset = "0x7F1C00", VA = "0x1807F3000")]
				get
				{
					return default(IDDEMAGGHFH);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000056")]
			public MixedTogglePalette MixedTogglePalette
			{
				[Cpp2IlInjected.Token(Token = "0x60000EA")]
				[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x1B97790", Offset = "0x1B96390", VA = "0x181B97790")]
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
				[Cpp2IlInjected.Address(RVA = "0x7F3000", Offset = "0x7F1C00", VA = "0x1807F3000")]
				get
				{
					return default(JFLKPKNPMGK);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000058")]
			public MakerPenToolPalette MakerPenToolPalette
			{
				[Cpp2IlInjected.Token(Token = "0x60000ED")]
				[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x1B97790", Offset = "0x1B96390", VA = "0x181B97790")]
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
				[Cpp2IlInjected.Address(RVA = "0x7F3000", Offset = "0x7F1C00", VA = "0x1807F3000")]
				get
				{
					return default(OGKIKKLANAC);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005A")]
			public InputFieldPalette InputFieldPalette
			{
				[Cpp2IlInjected.Token(Token = "0x60000F0")]
				[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x1B97790", Offset = "0x1B96390", VA = "0x181B97790")]
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
				[Cpp2IlInjected.Address(RVA = "0x7F3000", Offset = "0x7F1C00", VA = "0x1807F3000")]
				get
				{
					return default(KELKDGJBKGI);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005C")]
			public DropdownPalette DropdownPalette
			{
				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x1B97790", Offset = "0x1B96390", VA = "0x181B97790")]
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
				[Cpp2IlInjected.Address(RVA = "0x7F3000", Offset = "0x7F1C00", VA = "0x1807F3000")]
				get
				{
					return default(OIILLKPNLML);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005E")]
			public SliderPalette SliderPalette
			{
				[Cpp2IlInjected.Token(Token = "0x60000F6")]
				[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x1B97790", Offset = "0x1B96390", VA = "0x181B97790")]
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
				[Cpp2IlInjected.Address(RVA = "0x7F3000", Offset = "0x7F1C00", VA = "0x1807F3000")]
				get
				{
					return default(PLPMNPOBODF);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000060")]
			public DepthPalette DepthPalette
			{
				[Cpp2IlInjected.Token(Token = "0x60000F9")]
				[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x1B97790", Offset = "0x1B96390", VA = "0x181B97790")]
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
			[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
			public FBDACBJPPJH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xE64FA0", Offset = "0xE63BA0", VA = "0x180E64FA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
			public FJLLNAMHOGA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0xE64FA0", Offset = "0xE63BA0", VA = "0x180E64FA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
			public CMPBEJKFBHJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0xE64FA0", Offset = "0xE63BA0", VA = "0x180E64FA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
			public HLGIOHKICEG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0xE64FA0", Offset = "0xE63BA0", VA = "0x180E64FA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
			public AHIHHPMAHOO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0xE64FA0", Offset = "0xE63BA0", VA = "0x180E64FA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
			public IEEPKICOCMC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0xE64FA0", Offset = "0xE63BA0", VA = "0x180E64FA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
			public MDAAJKNKEEF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0xE64FA0", Offset = "0xE63BA0", VA = "0x180E64FA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
			public PPLALBACIPA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0xE64FA0", Offset = "0xE63BA0", VA = "0x180E64FA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
			public PDIMMOOEJNI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0xE64FA0", Offset = "0xE63BA0", VA = "0x180E64FA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
			public MOAKDDLCGOJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0xE64FA0", Offset = "0xE63BA0", VA = "0x180E64FA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
			public BLJIHBNFKGH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0xE64FA0", Offset = "0xE63BA0", VA = "0x180E64FA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
			public KIJGNAOMLIL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0xE64FA0", Offset = "0xE63BA0", VA = "0x180E64FA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
			public MDMADHPNGCO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0xE64FA0", Offset = "0xE63BA0", VA = "0x180E64FA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
			public FDHHJPJCOLH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xE64FA0", Offset = "0xE63BA0", VA = "0x180E64FA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x85F070", Offset = "0x85DC70", VA = "0x18085F070")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public ButtonAnimationPalette ButtonAnimationPalette
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x9A4AD0", Offset = "0x9A36D0", VA = "0x1809A4AD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public AudioPalette AudioPalette
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x886AE0", Offset = "0x8856E0", VA = "0x180886AE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x4618540", Offset = "0x4617140", VA = "0x184618540")]
		public Color LNEPAHMLJFL(JKIJAIKKHHE CLIJCJPMNLH)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x4617B30", Offset = "0x4616730", VA = "0x184617B30")]
		public void APGLPMMNJAI(CEEAFADHGGC CLIJCJPMNLH, out Color OPOEPBAFNOG, out Gradient DFFDDAACKDI, out bool LKMNPFKICGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x4617CB0", Offset = "0x46168B0", VA = "0x184617CB0")]
		public Color BLKBIOFOEOM(DHDELLAANPE KMLPGGCPALK)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x4618180", Offset = "0x4616D80", VA = "0x184618180")]
		public TilerPalette HDIKGBBNPOB(HBCABGKNLMP FIJCKHKKDCC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x4618870", Offset = "0x4617470", VA = "0x184618870")]
		public TextStylePalette PBFEFNPEEOG(JGBGNMILGJP MIEKDFAABFB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x4618650", Offset = "0x4617250", VA = "0x184618650")]
		public int LOAJOCNIMMB(BENIBJHCMDO IKJKHDNIJHE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x4618360", Offset = "0x4616F60", VA = "0x184618360")]
		public ButtonPalette JMCEGLMDIJJ(GBKHOIEBHJP BIHPGABANJN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x4618270", Offset = "0x4616E70", VA = "0x184618270")]
		public TogglePalette HPFDCDCGOJI(AACPPIMGFIP NHBBMEFOANO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x4617DC0", Offset = "0x46169C0", VA = "0x184617DC0")]
		public MixedTogglePalette DLNJKBMDBPO(IDDEMAGGHFH KDJAJOAFBAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x4618090", Offset = "0x4616C90", VA = "0x184618090")]
		public MakerPenToolPalette GKEHECPOCBF(JFLKPKNPMGK BMPHPPJCGLN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x4617FA0", Offset = "0x4616BA0", VA = "0x184617FA0")]
		public InputFieldPalette GGEFFGIKLDO(OGKIKKLANAC EAOAPIJNIPP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x4617EB0", Offset = "0x4616AB0", VA = "0x184617EB0")]
		public DropdownPalette EDPIJPBDOPD(KELKDGJBKGI LABCMMADNAF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x4618450", Offset = "0x4617050", VA = "0x184618450")]
		public SliderPalette LGGFKEGMLGP(OIILLKPNLML KOGLKHLGIDO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x4618740", Offset = "0x4617340", VA = "0x184618740")]
		public float? OJOGCALGIMI(PLPMNPOBODF FAMBNFLEDOI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x4618960", Offset = "0x4617560", VA = "0x184618960")]
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
		[Cpp2IlInjected.Address(RVA = "0x4619100", Offset = "0x4617D00", VA = "0x184619100", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x4619310", Offset = "0x4617F10", VA = "0x184619310", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x4619090", Offset = "0x4617C90", VA = "0x184619090")]
		private void APKAKFABLOB(float NAOEMMMJJLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x4619520", Offset = "0x4618120", VA = "0x184619520")]
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
			[Cpp2IlInjected.Address(RVA = "0xF448A0", Offset = "0xF434A0", VA = "0x180F448A0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public ColorBlock BackgroundTints
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x460FAF0", Offset = "0x460E6F0", VA = "0x18460FAF0")]
			get
			{
				return default(ColorBlock);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public GradientBlock BackgroundGradients
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x460FAC0", Offset = "0x460E6C0", VA = "0x18460FAC0")]
			get
			{
				return default(GradientBlock);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public Color ForegroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x1F9CA10", Offset = "0x1F9B610", VA = "0x181F9CA10")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public ColorBlock ForegroundTints
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x460FB30", Offset = "0x460E730", VA = "0x18460FB30")]
			get
			{
				return default(ColorBlock);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public bool ShowBorder
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x14FC3B0", Offset = "0x14FAFB0", VA = "0x1814FC3B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public TextStylePalette TextPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x9A3190", Offset = "0x9A1D90", VA = "0x1809A3190")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public MBHCJDDDHIK AudioPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x178C020", Offset = "0x178AC20", VA = "0x18178C020")]
			get
			{
				return default(MBHCJDDDHIK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x460F9C0", Offset = "0x460E5C0", VA = "0x18460F9C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4613CB0", Offset = "0x46128B0", VA = "0x184613CB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public DHDELLAANPE KAOPHJAOJBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x8D7920", Offset = "0x8D6520", VA = "0x1808D7920")]
			get
			{
				return default(DHDELLAANPE);
			}
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x4613CC0", Offset = "0x46128C0", VA = "0x184613CC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public bool AHEBKECGGKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x8DFD80", Offset = "0x8DE980", VA = "0x1808DFD80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x8E0510", Offset = "0x8DF110", VA = "0x1808E0510")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Color? NECKIFPEIFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x4613AE0", Offset = "0x46126E0", VA = "0x184613AE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x4613870", Offset = "0x4612470", VA = "0x184613870", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x4613A80", Offset = "0x4612680", VA = "0x184613A80")]
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
			[Cpp2IlInjected.Address(RVA = "0x844A80", Offset = "0x843680", VA = "0x180844A80")]
			get
			{
				return default(JKIJAIKKHHE);
			}
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x4618E60", Offset = "0x4617A60", VA = "0x184618E60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x4618EC0", Offset = "0x4617AC0", VA = "0x184618EC0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x4619000", Offset = "0x4617C00", VA = "0x184619000")]
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
			[Cpp2IlInjected.Address(RVA = "0x839000", Offset = "0x837C00", VA = "0x180839000")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x1456B90", Offset = "0x1455790", VA = "0x181456B90")]
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
			[Cpp2IlInjected.Address(RVA = "0x839000", Offset = "0x837C00", VA = "0x180839000")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public Material FontOverrideMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public float Kerning
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x128EBC0", Offset = "0x128D7C0", VA = "0x18128EBC0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public float Leading
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x14D6350", Offset = "0x14D4F50", VA = "0x1814D6350")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public bool IsBold
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x95ED60", Offset = "0x95D960", VA = "0x18095ED60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public bool IsItalic
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x1301170", Offset = "0x12FFD70", VA = "0x181301170")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public CBCHKGNILMN Transformation
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0xB9A4B0", Offset = "0xB990B0", VA = "0x180B9A4B0")]
			get
			{
				return default(CBCHKGNILMN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x461E140", Offset = "0x461CD40", VA = "0x18461E140")]
		public void FHDOJMBIMOM(TextMeshProUGUI FNIONNJOCMH, bool DCHJCGPGHJF = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x461E470", Offset = "0x461D070", VA = "0x18461E470")]
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
			[Cpp2IlInjected.Address(RVA = "0x461F210", Offset = "0x461DE10", VA = "0x18461F210")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x461F220", Offset = "0x461DE20", VA = "0x18461F220")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public AACPPIMGFIP NACEFJLDJAB
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x178C020", Offset = "0x178AC20", VA = "0x18178C020")]
			get
			{
				return default(AACPPIMGFIP);
			}
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x46115C0", Offset = "0x46101C0", VA = "0x1846115C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		protected override bool GNOBMDCIAFP
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x461F0E0", Offset = "0x461DCE0", VA = "0x18461F0E0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x461F0A0", Offset = "0x461DCA0", VA = "0x18461F0A0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x461F0F0", Offset = "0x461DCF0", VA = "0x18461F0F0")]
		public void Toggle()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x461F130", Offset = "0x461DD30", VA = "0x18461F130")]
		public void Toggle(bool MBOOEJLAKMG, bool NLDJDDGFIJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x461ECC0", Offset = "0x461D8C0", VA = "0x18461ECC0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x461F170", Offset = "0x461DD70", VA = "0x18461F170")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		protected Palette PHABAAINJKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x4615CE0", Offset = "0x46148E0", VA = "0x184615CE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		protected bool KJNONEJPJPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x4616150", Offset = "0x4614D50", VA = "0x184616150")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		protected Transform ILPONALEBIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x46161F0", Offset = "0x4614DF0", VA = "0x1846161F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x4615BD0", Offset = "0x46147D0", VA = "0x184615BD0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x4616280", Offset = "0x4614E80", VA = "0x184616280", Slot = "5")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void Apply();

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x4615DA0", Offset = "0x46149A0", VA = "0x184615DA0")]
		private void GBBHEIBMKCB(bool LPGEEPPDAFJ = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x12E8DC0", Offset = "0x12E79C0", VA = "0x1812E8DC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4612BF0", Offset = "0x46117F0", VA = "0x184612BF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public OGKIKKLANAC HMPJAMJHGFG
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x870100", Offset = "0x86ED00", VA = "0x180870100")]
			get
			{
				return default(OGKIKKLANAC);
			}
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x4612C00", Offset = "0x4611800", VA = "0x184612C00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public BENIBJHCMDO AOMGJEBAPFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0xA6B390", Offset = "0xA69F90", VA = "0x180A6B390")]
			get
			{
				return default(BENIBJHCMDO);
			}
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x4612C20", Offset = "0x4611820", VA = "0x184612C20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x4613D50", Offset = "0x4612950", VA = "0x184613D50", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x4612B80", Offset = "0x4611780", VA = "0x184612B80")]
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
			[Cpp2IlInjected.Address(RVA = "0x844A80", Offset = "0x843680", VA = "0x180844A80")]
			get
			{
				return default(OIILLKPNLML);
			}
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x4618E60", Offset = "0x4617A60", VA = "0x184618E60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public Image LCKFDJJCNIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x838FF0", Offset = "0x837BF0", VA = "0x180838FF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public Image BGNLJBNLMHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x843910", Offset = "0x842510", VA = "0x180843910")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public Image LFDHNAEJECA
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x89C580", Offset = "0x89B180", VA = "0x18089C580")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public Image LLJPBIMNAFD
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x8390B0", Offset = "0x837CB0", VA = "0x1808390B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public bool HDLGCEHMIMD
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x4618E20", Offset = "0x4617A20", VA = "0x184618E20")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x4618E40", Offset = "0x4617A40", VA = "0x184618E40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x4618A60", Offset = "0x4617660", VA = "0x184618A60", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x4618DA0", Offset = "0x46179A0", VA = "0x184618DA0")]
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
			[Cpp2IlInjected.Address(RVA = "0xF448A0", Offset = "0xF434A0", VA = "0x180F448A0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public Color ForegroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0xE43730", Offset = "0xE42330", VA = "0x180E43730")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public TextStylePalette TextPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x838FF0", Offset = "0x837BF0", VA = "0x180838FF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x46124C0", Offset = "0x46110C0", VA = "0x1846124C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x20A3C40", Offset = "0x20A2840", VA = "0x1820A3C40")]
			get
			{
				return default(JGAOKGGOAHB);
			}
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x46153B0", Offset = "0x4613FB0", VA = "0x1846153B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x46153D0", Offset = "0x4613FD0", VA = "0x1846153D0")]
		public void Toggle()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x46153B0", Offset = "0x4613FB0", VA = "0x1846153B0")]
		public void Toggle(JGAOKGGOAHB MBOOEJLAKMG, bool NLDJDDGFIJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x4614E10", Offset = "0x4613A10", VA = "0x184614E10", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x4615400", Offset = "0x4614000", VA = "0x184615400")]
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
			[Cpp2IlInjected.Address(RVA = "0x461EC00", Offset = "0x461D800", VA = "0x18461EC00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		private DBCICEJFIGD JDEPHFPMAAO
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x461EB20", Offset = "0x461D720", VA = "0x18461EB20")]
			get
			{
				return default(DBCICEJFIGD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x461EAB0", Offset = "0x461D6B0", VA = "0x18461EAB0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x461E700", Offset = "0x461D300", VA = "0x18461E700", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x461EC70", Offset = "0x461D870", VA = "0x18461EC70")]
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
			[Cpp2IlInjected.Address(RVA = "0x15B85F0", Offset = "0x15B71F0", VA = "0x1815B85F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x46112A0", Offset = "0x460FEA0", VA = "0x1846112A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public List<Graphic> LKHDKMKEBLP
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x4611280", Offset = "0x460FE80", VA = "0x184611280")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public UIGradient AHEHGFNIAGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x4611260", Offset = "0x460FE60", VA = "0x184611260")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public TextMeshProUGUI GJEOLOJMAEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x46112C0", Offset = "0x460FEC0", VA = "0x1846112C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public BENIBJHCMDO AOMGJEBAPFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x12AEC40", Offset = "0x12AD840", VA = "0x1812AEC40")]
			get
			{
				return default(BENIBJHCMDO);
			}
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x46112E0", Offset = "0x460FEE0", VA = "0x1846112E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		protected Transform HJLDGCKPGFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x4610670", Offset = "0x460F270", VA = "0x184610670")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		public Button PMEMPJFFMOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x46111E0", Offset = "0x460FDE0", VA = "0x1846111E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x46108D0", Offset = "0x460F4D0", VA = "0x1846108D0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x4610830", Offset = "0x460F430", VA = "0x184610830")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x46106B0", Offset = "0x460F2B0", VA = "0x1846106B0")]
		protected void NGFAIDNBNLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x460FBA0", Offset = "0x460E7A0", VA = "0x18460FBA0")]
		protected void GJBPOCOPJLK(ButtonPalette AABJOFIAIAB, [Optional] HLAIIJJKHGO JHGBNOIHJJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x4610950", Offset = "0x460F550", VA = "0x184610950", Slot = "12")]
		public override void OnPointerDown(PointerEventData CBLNAPKAJBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x4610D30", Offset = "0x460F930", VA = "0x184610D30", Slot = "13")]
		public override void OnPointerUp(PointerEventData CBLNAPKAJBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x4610930", Offset = "0x460F530", VA = "0x184610930", Slot = "14")]
		public override void OnPointerClick(PointerEventData CBLNAPKAJBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x4610650", Offset = "0x460F250", VA = "0x184610650")]
		private Vector3 HAEEOMOCMFB(float KACNEPKNFIL)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x4611060", Offset = "0x460FC60", VA = "0x184611060")]
		protected ButtonThemeBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x460FB80", Offset = "0x460E780", VA = "0x18460FB80")]
		[CompilerGenerated]
		private void EMJMAMODPNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x460FB80", Offset = "0x460E780", VA = "0x18460FB80")]
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
			[Cpp2IlInjected.Address(RVA = "0x128EBC0", Offset = "0x128D7C0", VA = "0x18128EBC0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		public float LoadingSFXStopDelay
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x14D6350", Offset = "0x14D4F50", VA = "0x1814D6350")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		public float MaxLoadingSFXLength
		{
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x9A1940", Offset = "0x9A0540", VA = "0x1809A1940")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		public float FadeInDuration
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x98E640", Offset = "0x98D240", VA = "0x18098E640")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		public float FadeOutDuration
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x98E4E0", Offset = "0x98D0E0", VA = "0x18098E4E0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x46115E0", Offset = "0x46101E0", VA = "0x1846115E0")]
		public bool OECOALNCFAP(out RecRoomAudioClip[] GLENKIGIOAA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x4611690", Offset = "0x4610290", VA = "0x184611690")]
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
			[Cpp2IlInjected.Address(RVA = "0x839000", Offset = "0x837C00", VA = "0x180839000")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		public ButtonPalette ActiveButtonPalette
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x15B85F0", Offset = "0x15B71F0", VA = "0x1815B85F0")]
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
			[Cpp2IlInjected.Address(RVA = "0xF448A0", Offset = "0xF434A0", VA = "0x180F448A0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public Color FillColor
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0xE43730", Offset = "0xE42330", VA = "0x180E43730")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public Color HandleColor
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x13CA7B0", Offset = "0x13C93B0", VA = "0x1813CA7B0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public TextStylePalette TextPalette
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x89C580", Offset = "0x89B180", VA = "0x18089C580")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public Color TextColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0xA58000", Offset = "0xA56C00", VA = "0x180A58000")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public ColorBlock ColorBlock
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x461D620", Offset = "0x461C220", VA = "0x18461D620")]
			get
			{
				return default(ColorBlock);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x461D550", Offset = "0x461C150", VA = "0x18461D550")]
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
			[Cpp2IlInjected.Address(RVA = "0x9C7350", Offset = "0x9C5F50", VA = "0x1809C7350")]
			get
			{
				return default(OIILLKPNLML);
			}
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x461DAC0", Offset = "0x461C6C0", VA = "0x18461DAC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public Image LCKFDJJCNIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x9A4AD0", Offset = "0x9A36D0", VA = "0x1809A4AD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public Image BGNLJBNLMHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x886AE0", Offset = "0x8856E0", VA = "0x180886AE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		public Image FBAFAAHPBDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x85F040", Offset = "0x85DC40", VA = "0x18085F040")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x461D660", Offset = "0x461C260", VA = "0x18461D660", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x461DA40", Offset = "0x461C640", VA = "0x18461DA40")]
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
			[Cpp2IlInjected.Address(RVA = "0x178C020", Offset = "0x178AC20", VA = "0x18178C020")]
			get
			{
				return default(JFLKPKNPMGK);
			}
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x46115C0", Offset = "0x46101C0", VA = "0x1846115C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public bool EBBFILBJDCG
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x18C5500", Offset = "0x18C4100", VA = "0x1818C5500")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x4614B10", Offset = "0x4613710", VA = "0x184614B10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x4614A70", Offset = "0x4613670", VA = "0x184614A70", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x4614690", Offset = "0x4613290", VA = "0x184614690", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x4614AB0", Offset = "0x46136B0", VA = "0x184614AB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9A1940", Offset = "0x9A0540", VA = "0x1809A1940")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		public float MinimumTimeIntervalForScrollingSFX
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x98E640", Offset = "0x98D240", VA = "0x18098E640")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x46115E0", Offset = "0x46101E0", VA = "0x1846115E0")]
		public bool BEFHPDCPKNJ(out RecRoomAudioClip[] GLENKIGIOAA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x461C580", Offset = "0x461B180", VA = "0x18461C580")]
		public bool NCILIHMOLMA(out RecRoomAudioClip[] GLENKIGIOAA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x461C630", Offset = "0x461B230", VA = "0x18461C630")]
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
			[Cpp2IlInjected.Address(RVA = "0x461AF10", Offset = "0x4619B10", VA = "0x18461AF10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		private BBDNFHGFMBE NELMIKFANIM
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x461B170", Offset = "0x4619D70", VA = "0x18461B170")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x461ACF0", Offset = "0x46198F0", VA = "0x18461ACF0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x461B6D0", Offset = "0x461A2D0", VA = "0x18461B6D0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x461ABF0", Offset = "0x46197F0", VA = "0x18461ABF0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x461B1E0", Offset = "0x4619DE0", VA = "0x18461B1E0")]
		private void HHCGEGEKEDF(Vector2 NABPHMOHNDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x461AF80", Offset = "0x4619B80", VA = "0x18461AF80")]
		private void DJHOELECICD(float MHOGCFCMOOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x461B7E0", Offset = "0x461A3E0", VA = "0x18461B7E0")]
		private void PFCLEOFMGFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x461AAD0", Offset = "0x46196D0", VA = "0x18461AAD0")]
		private static string AEJGCCNAJEK(GameObject HHNPCHNMLMA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x461C4D0", Offset = "0x461B0D0", VA = "0x18461C4D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x87E140", Offset = "0x87CD40", VA = "0x18087E140")]
			get
			{
				return default(JGBGNMILGJP);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x4614670", Offset = "0x4613270", VA = "0x184614670")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		public BENIBJHCMDO AOMGJEBAPFJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x88FF60", Offset = "0x88EB60", VA = "0x18088FF60")]
			get
			{
				return default(BENIBJHCMDO);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x4614650", Offset = "0x4613250", VA = "0x184614650")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x46142B0", Offset = "0x4612EB0", VA = "0x1846142B0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x46145E0", Offset = "0x46131E0", VA = "0x1846145E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
	public PFBBJKPLBFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x1901CE0", Offset = "0x19008E0", VA = "0x181901CE0")]
	public static string NIMNBIGPMKB(byte[] DCFEDNINKHD, byte[] LFMKEJPAGIF)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
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
