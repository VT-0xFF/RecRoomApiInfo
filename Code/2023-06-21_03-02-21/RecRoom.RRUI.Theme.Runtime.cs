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
		public List<Graphic> FBKCEELPBHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0xB0EEB0", Offset = "0xB0E0B0", VA = "0x180B0EEB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0xB0F020", Offset = "0xB0E220", VA = "0x180B0F020")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public ColorBlock KGJCIMGPDNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xC80D90", Offset = "0xC7FF90", VA = "0x180C80D90")]
			get
			{
				return default(ColorBlock);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xC80E20", Offset = "0xC80020", VA = "0x180C80E20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public UIGradient MFGHJFOMNBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xC80DE0", Offset = "0xC7FFE0", VA = "0x180C80DE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xC80E70", Offset = "0xC80070", VA = "0x180C80E70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public GradientBlock JOLJHCJJOJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xC80DF0", Offset = "0xC7FFF0", VA = "0x180C80DF0")]
			get
			{
				return default(GradientBlock);
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xC80E80", Offset = "0xC80080", VA = "0x180C80E80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xC80BE0", Offset = "0xC7FDE0", VA = "0x180C80BE0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xC80C30", Offset = "0xC7FE30", VA = "0x180C80C30", Slot = "36")]
		public override void OnSelect(BaseEventData NHCCLIMEPFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xC80C80", Offset = "0xC7FE80", VA = "0x180C80C80")]
		public void Refresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xC80BA0", Offset = "0xC7FDA0", VA = "0x180C80BA0")]
		public void ForceHighlighted(bool PBIPMILGDEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xC80BC0", Offset = "0xC7FDC0", VA = "0x180C80BC0")]
		public void ForceNormal(bool PBIPMILGDEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xC80810", Offset = "0xC7FA10", VA = "0x180C80810", Slot = "26")]
		protected override void DoStateTransition(SelectionState OJBGFLKOHML, bool PBIPMILGDEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xC80AC0", Offset = "0xC7FCC0", VA = "0x180C80AC0")]
		private void ENKPEFLAMCF(Graphic GDNLPOPGBFL, Color NMIBCDOANHG, bool PBIPMILGDEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xC80710", Offset = "0xC7F910", VA = "0x180C80710")]
		private void DMFNALPBNIB(SelectionState OJBGFLKOHML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xC80CB0", Offset = "0xC7FEB0", VA = "0x180C80CB0")]
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
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xC893C0", Offset = "0xC885C0", VA = "0x180C893C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public Palette Active
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xC89390", Offset = "0xC88590", VA = "0x180C89390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9955B0", Offset = "0x9947B0", VA = "0x1809955B0")]
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
		private sealed class LBDGHLBHICM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public TMP_FontAsset font;

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
			public LBDGHLBHICM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xC7F460", Offset = "0xC7E660", VA = "0x180C7F460")]
			internal bool MBOIELJFKJC(LocalizedFontMapping x)
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
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xC7E690", Offset = "0xC7D890", VA = "0x180C7E690")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public TMP_SpriteAsset EmojiAsset
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8D7C00", Offset = "0x8D6E00", VA = "0x1808D7C00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xC7E550", Offset = "0xC7D750", VA = "0x180C7E550")]
		public bool NMIGLPFNPFI(TMP_FontAsset HGFMMDOMOAO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xC7E180", Offset = "0xC7D380", VA = "0x180C7E180")]
		public TMP_FontAsset FEICEMAPHDL(TMP_FontAsset HGFMMDOMOAO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xC7E280", Offset = "0xC7D480", VA = "0x180C7E280")]
		public TMP_FontAsset FEICEMAPHDL(TMP_FontAsset HGFMMDOMOAO, Material CLAONCHNALG, out Material LMBOJOHPNNJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xC7E080", Offset = "0xC7D280", VA = "0x180C7E080")]
		public TMP_FontAsset CEMDKNIOCML(TMP_FontAsset HGFMMDOMOAO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xC7DE50", Offset = "0xC7D050", VA = "0x180C7DE50")]
		public TMP_FontAsset CEMDKNIOCML(TMP_FontAsset HGFMMDOMOAO, Material CLAONCHNALG, out Material FMILHCABPNI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xC7E490", Offset = "0xC7D690", VA = "0x180C7E490")]
		private static bool LHKJAIGJPNJ(TMP_FontAsset HGFMMDOMOAO, LocalizedFontMapping ILOCFLGPNBA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xC7A8A0", Offset = "0xC79AA0", VA = "0x180C7A8A0")]
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

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xC7E810", Offset = "0xC7DA10", VA = "0x180C7E810", Slot = "0")]
		public override bool Equals(object BHEOHCEHIBM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xC7E910", Offset = "0xC7DB10", VA = "0x180C7E910", Slot = "4")]
		public bool Equals(GradientBlock HPOECFLNEOJ)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xC7E910", Offset = "0xC7DB10", VA = "0x180C7E910")]
		public static bool JGKKLLGINAK(GradientBlock BHAMFPLACBK, GradientBlock KEDDOJEHDGM)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xC7E9F0", Offset = "0xC7DBF0", VA = "0x180C7E9F0")]
		public static bool NGNNEMMJMMJ(GradientBlock BHAMFPLACBK, GradientBlock KEDDOJEHDGM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xC7E980", Offset = "0xC7DB80", VA = "0x180C7E980", Slot = "2")]
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
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xC7FEB0", Offset = "0xC7F0B0", VA = "0x180C7FEB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public RecRoomAudioClip[] MenuOpen2DFlavorAudioClipPool
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xC7FF40", Offset = "0xC7F140", VA = "0x180C7FF40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public RecRoomAudioClip[] MenuDehydrateAudioClipPool
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xC7FE20", Offset = "0xC7F020", VA = "0x180C7FE20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public RecRoomAudioClip[] MenuClose2DFlavorAudioClipPool
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xC7FD90", Offset = "0xC7EF90", VA = "0x180C7FD90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xC7A6F0", Offset = "0xC798F0", VA = "0x180C7A6F0")]
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
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xC7A970", Offset = "0xC79B70", VA = "0x180C7A970")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public RecRoomAudioClip[] PointerUpAudioClipPool
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xC7AA90", Offset = "0xC79C90", VA = "0x180C7AA90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public RecRoomAudioClip[] PointerClickAudioClipPool
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0xC7A8E0", Offset = "0xC79AE0", VA = "0x180C7A8E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public RecRoomAudioClip[] PointerEnterAudioClipPool
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xC7AA00", Offset = "0xC79C00", VA = "0x180C7AA00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xC7A6F0", Offset = "0xC798F0", VA = "0x180C7A6F0")]
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
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x981930", Offset = "0x980B30", VA = "0x180981930")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public float ClickAnimationScale
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xC7A8D0", Offset = "0xC79AD0", VA = "0x180C7A8D0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xC7A8B0", Offset = "0xC79AB0", VA = "0x180C7A8B0")]
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
		private OMOPAMPPPJP buttonAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[SerializeField]
		[Tooltip("Layer a 2D SFX on top of base button sounds")]
		private bool useFlavorSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[SerializeField]
		[Tooltip("Flavor SFX is picked randomly from this pool config")]
		[FDKNKMFDEBB("useFlavorSFX")]
		private RecRoomAudioClipPoolConfig flavorSFXClipPoolConfig;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xC85BD0", Offset = "0xC84DD0", VA = "0x180C85BD0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xC85CF0", Offset = "0xC84EF0", VA = "0x180C85CF0")]
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
		private UITiler.LKHHHKCKCBH animationDirection;

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
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x8D4AB0", Offset = "0x8D3CB0", VA = "0x1808D4AB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Color TintColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x8F8BD0", Offset = "0x8F7DD0", VA = "0x1808F8BD0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Color BackgroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x8F8BC0", Offset = "0x8F7DC0", VA = "0x1808F8BC0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public Vector2 Spacing
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xC895D0", Offset = "0xC887D0", VA = "0x180C895D0")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float Offset
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xC895B0", Offset = "0xC887B0", VA = "0x180C895B0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Vector2 Velocity
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xC895F0", Offset = "0xC887F0", VA = "0x180C895F0")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public float Angle
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xC895A0", Offset = "0xC887A0", VA = "0x180C895A0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public UITiler.LKHHHKCKCBH AnimationDirection
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x9F97E0", Offset = "0x9F89E0", VA = "0x1809F97E0")]
			get
			{
				return default(UITiler.LKHHHKCKCBH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float PrimaryAnimationSpeed
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xC895C0", Offset = "0xC887C0", VA = "0x180C895C0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float AltAnimationSpeed
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xC89590", Offset = "0xC88790", VA = "0x180C89590")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xC89500", Offset = "0xC88700", VA = "0x180C89500")]
		public float CJIBLMPPHMA(LMOJCMEKPLF ONPGNHDOJFL)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xC89520", Offset = "0xC88720", VA = "0x180C89520")]
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
		[IMEOLICHDCN(OANOIFMCHLE.Self, false, false, false)]
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
		[FDKNKMFDEBB("overrideWithSingleAudio")]
		[Tooltip("The legacy override audio will be randomly picked from this pool")]
		protected RecRoomAudioClip[] randomAudioOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		protected bool JABCBIPLGFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private ButtonAudioPaletteAsset BNPDNFFNAGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private RecRoomAudioClipPoolConfig BKIJDPAENBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private EJGHBBJDJPG INPHNHMANPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private CAFFCBCFHDP HNJMBNEJFFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private KCKFKNCPAFC PBFINFAGLCJ;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		protected Selectable FOKKDGCPPME
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x8D7C00", Offset = "0x8D6E00", VA = "0x1808D7C00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		protected virtual bool IPIPLKAOHBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x844770", Offset = "0x843970", VA = "0x180844770", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool IDAPHFNDHJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xC840D0", Offset = "0xC832D0", VA = "0x180C840D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xC840F0", Offset = "0xC832F0", VA = "0x180C840F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private EJGHBBJDJPG AEIALMPPNCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xC87C40", Offset = "0xC86E40", VA = "0x180C87C40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		protected CAFFCBCFHDP HGHNHLKJJEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xC876E0", Offset = "0xC868E0", VA = "0x180C876E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private KCKFKNCPAFC MFMJKNHMLNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xC87CB0", Offset = "0xC86EB0", VA = "0x180C87CB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xC87B20", Offset = "0xC86D20", VA = "0x180C87B20")]
		protected void HJBOMCPLFME(ButtonAudioPaletteAsset LPAFENIBHLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x983E90", Offset = "0x983090", VA = "0x180983E90")]
		protected void ICABEPCNLIE(RecRoomAudioClipPoolConfig DIIFHCGKGNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xC87FD0", Offset = "0xC871D0", VA = "0x180C87FD0", Slot = "12")]
		public virtual void OnPointerDown(PointerEventData NHCCLIMEPFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xC88240", Offset = "0xC87440", VA = "0x180C88240", Slot = "13")]
		public virtual void OnPointerUp(PointerEventData NHCCLIMEPFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xC87DA0", Offset = "0xC86FA0", VA = "0x180C87DA0", Slot = "14")]
		public virtual void OnPointerClick(PointerEventData NHCCLIMEPFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xC88110", Offset = "0xC87310", VA = "0x180C88110", Slot = "15")]
		public virtual void OnPointerEnter(PointerEventData NHCCLIMEPFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xC87D20", Offset = "0xC86F20", VA = "0x180C87D20")]
		private void OFDOMCCKIMD(RecRoomAudioClip[] LMCFNFLNGNP, bool PKNHAGEANKN = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xC87750", Offset = "0xC86950", VA = "0x180C87750")]
		private void DJAAMCFBLIK(RecRoomAudioClip LIPBGBFKKJN, bool PKNHAGEANKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xC88380", Offset = "0xC87580", VA = "0x180C88380")]
		protected SelectableThemeBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class MixedTogglePalette
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		private enum EMMAOJMINGF
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
		private CMEIOJGIHGK baseTogglePalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private EMMAOJMINGF mixedPaletteType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[SerializeField]
		[FDKNKMFDEBB("mixedPaletteType", 2)]
		private ButtonPalette mixedButtonPalette;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xC80040", Offset = "0xC7F240", VA = "0x180C80040")]
		public TogglePalette OODPAAJMOPC(Palette HGEOHHIMPHH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xC7FFD0", Offset = "0xC7F1D0", VA = "0x180C7FFD0")]
		public ButtonPalette BKIOBBPEJFN(Palette HGEOHHIMPHH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xC80070", Offset = "0xC7F270", VA = "0x180C80070")]
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
		private MBMHCBINOAP recyclingAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		protected RecyclingAudioPaletteAsset BNPDNFFNAGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[SerializeField]
		private BJAJDEIBDAF scrollingAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private ScrollingAudioPaletteAsset BOPJOGKKAOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private EJGHBBJDJPG INPHNHMANPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private float DLIMCCMDPMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private float LCANECMEMJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private float JLCCLBLOENF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private float LEKBPDNIJLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private bool COFJPJHAEDD;

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private const float NHJDMNNPFNK = 0.01f;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private EJGHBBJDJPG AEIALMPPNCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xC85910", Offset = "0xC84B10", VA = "0x180C85910")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xC84DA0", Offset = "0xC83FA0", VA = "0x180C84DA0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xC85630", Offset = "0xC84830", VA = "0x180C85630")]
		protected void LHIAIKHINGF(bool HFEFGCDHKOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xC84FB0", Offset = "0xC841B0", VA = "0x180C84FB0")]
		protected void BLLGEKBLLJF(GameObject FNPJDMFCFGH, int NCLOFAFKBKL, bool JFNDNNIFGHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xC85350", Offset = "0xC84550", VA = "0x180C85350")]
		protected void HAAAKFGOFOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xC85150", Offset = "0xC84350", VA = "0x180C85150")]
		protected void CEPCPLJFMEL(float IADEJOGNEBB, float HILEJMDKCKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xC85980", Offset = "0xC84B80", VA = "0x180C85980")]
		private void PFGLJLNBAMN(float EAOIEKKLDDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xC854E0", Offset = "0xC846E0", VA = "0x180C854E0")]
		private void IGGBIPLKHKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xC85B70", Offset = "0xC84D70", VA = "0x180C85B70")]
		protected RecyclingThemeBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class SwitchTheme : ToggleTheme
	{
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private const float NCGKJBIHJFL = 0.33f;

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
		private OKCBHIAGHED CDAHBBDKEEO;

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xC88C80", Offset = "0xC87E80", VA = "0x180C88C80", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xC88F10", Offset = "0xC88110", VA = "0x180C88F10")]
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
		private Vector3? LBMKCOABNIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private Vector3? JHBHFCAHOOF;

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xC7A210", Offset = "0xC79410", VA = "0x180C7A210")]
		private void OHLMLHJNBAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xC79E90", Offset = "0xC79090", VA = "0x180C79E90", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xC7A2F0", Offset = "0xC794F0", VA = "0x180C7A2F0")]
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
		[IMEOLICHDCN(OANOIFMCHLE.Self, false, false, false)]
		private Dropdown dropdown;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[SerializeField]
		[LOLBLOLLILE(OANOIFMCHLE.Self, false, true, false)]
		private Image surface;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[SerializeField]
		private bool useSurfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[SerializeField]
		[FDKNKMFDEBB("useSurfaceOverride")]
		private Image surfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[SerializeField]
		private GMDLFBILIOK dropdownType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[SerializeField]
		private BOFOCBPANNA textSize;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Image CBJMFFCEAMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xC7DE00", Offset = "0xC7D000", VA = "0x180C7DE00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public GMDLFBILIOK ADNHFGKCILL
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x9234A0", Offset = "0x9226A0", VA = "0x1809234A0")]
			get
			{
				return default(GMDLFBILIOK);
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xC7DE10", Offset = "0xC7D010", VA = "0x180C7DE10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public BOFOCBPANNA PDMAENKBDNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xB91940", Offset = "0xB90B40", VA = "0x180B91940")]
			get
			{
				return default(BOFOCBPANNA);
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xC7DE30", Offset = "0xC7D030", VA = "0x180C7DE30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xC7D6F0", Offset = "0xC7C8F0", VA = "0x180C7D6F0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xC7DD90", Offset = "0xC7CF90", VA = "0x180C7DD90")]
		public DropdownTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class BaseAudioPaletteAsset : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xC7A7E0", Offset = "0xC799E0", VA = "0x180C7A7E0")]
		protected bool ACDBKPBJADN(RecRoomAudioClipPoolConfig BNNIFOEGOFK, out RecRoomAudioClip[] LMCFNFLNGNP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xC7A8A0", Offset = "0xC79AA0", VA = "0x180C7A8A0")]
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
		private CKPDGNDLLKI buttonType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[SerializeField]
		[Tooltip("Override the audio palette defined by the button's visual with a custom palette")]
		[Header("Button Audio")]
		private bool overrideButtonAudioPalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[SerializeField]
		[FDKNKMFDEBB("overrideButtonAudioPalette")]
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
		[FDKNKMFDEBB("useFlavorSFX")]
		[Tooltip("Flavor SFX is picked randomly from this pool config")]
		private RecRoomAudioClipPoolConfig flavorSFXClipPoolConfig;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public CKPDGNDLLKI JBIBNLOPHNL
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xC7AC50", Offset = "0xC79E50", VA = "0x180C7AC50")]
			get
			{
				return default(CKPDGNDLLKI);
			}
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xC7C7B0", Offset = "0xC7B9B0", VA = "0x180C7C7B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xC7C4D0", Offset = "0xC7B6D0", VA = "0x180C7C4D0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xC7C760", Offset = "0xC7B960", VA = "0x180C7C760")]
		public void SetAnimationEnabled(bool IKKHNLLIAGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xC7C770", Offset = "0xC7B970", VA = "0x180C7C770")]
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
		[IMEOLICHDCN(OANOIFMCHLE.Self, false, false, false)]
		private ELEEDNKGOKL recyclingList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private bool KIEFGPBCKIL;

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xC84840", Offset = "0xC83A40", VA = "0x180C84840", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xC84B00", Offset = "0xC83D00", VA = "0x180C84B00", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xC84A90", Offset = "0xC83C90", VA = "0x180C84A90")]
		private void HENDOCIFMIH(float IADEJOGNEBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xC84D20", Offset = "0xC83F20", VA = "0x180C84D20")]
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
			private OMOPAMPPPJP buttonAudioPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			[SerializeField]
			private ButtonAudioPaletteAsset buttonAudioPaletteConfig;

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			public OMOPAMPPPJP ButtonAudioPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(RVA = "0x841A60", Offset = "0x840C60", VA = "0x180841A60")]
				get
				{
					return default(OMOPAMPPPJP);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public ButtonAudioPaletteAsset ButtonAudioPaletteConfig
			{
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xC7AB20", Offset = "0xC79D20", VA = "0x180C7AB20")]
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
			private BJAJDEIBDAF scrollingAudioPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			[SerializeField]
			private ScrollingAudioPaletteAsset scrollingAudioPaletteConfig;

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			public BJAJDEIBDAF ScrollingAudioPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600007E")]
				[Cpp2IlInjected.Address(RVA = "0x841A60", Offset = "0x840C60", VA = "0x180841A60")]
				get
				{
					return default(BJAJDEIBDAF);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			public ScrollingAudioPaletteAsset ScrollingAudioPaletteConfig
			{
				[Cpp2IlInjected.Token(Token = "0x600007F")]
				[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xC7AB20", Offset = "0xC79D20", VA = "0x180C7AB20")]
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
			private EKFEGBJMIIG contentLoadingAudioPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			[SerializeField]
			private ContentLoadingAudioPaletteAsset contentLoadingAudioPaletteConfig;

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			public EKFEGBJMIIG ContentLoadingAudioPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000081")]
				[Cpp2IlInjected.Address(RVA = "0x841A60", Offset = "0x840C60", VA = "0x180841A60")]
				get
				{
					return default(EKFEGBJMIIG);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			public ContentLoadingAudioPaletteAsset ContentLoadingAudioPaletteConfig
			{
				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xC7AB20", Offset = "0xC79D20", VA = "0x180C7AB20")]
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
			private MBMHCBINOAP recyclingAudioPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			[SerializeField]
			private RecyclingAudioPaletteAsset recyclingAudioPaletteConfig;

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			public MBMHCBINOAP RecyclingAudioPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x841A60", Offset = "0x840C60", VA = "0x180841A60")]
				get
				{
					return default(MBMHCBINOAP);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			public RecyclingAudioPaletteAsset RecyclingAudioPaletteConfig
			{
				[Cpp2IlInjected.Token(Token = "0x6000085")]
				[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xC7AB20", Offset = "0xC79D20", VA = "0x180C7AB20")]
			public RecyclingAudioPaletteItem()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class NABAEALIFLK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public OMOPAMPPPJP buttonAudioPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
			public NABAEALIFLK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xC79E70", Offset = "0xC79070", VA = "0x180C79E70")]
			internal bool GEAAJPJENEF(ButtonAudioPaletteItem buttonAudioPalette)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class FJDEECKBPLN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public BJAJDEIBDAF scrollingAudioPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
			public FJDEECKBPLN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xC79E70", Offset = "0xC79070", VA = "0x180C79E70")]
			internal bool ODAOONCPIKO(ScrollingAudioPaletteItem scrollingAudioPalette)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class PIPODJLFEFN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public EKFEGBJMIIG contentLoadingAudioPaletteType;

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
			public PIPODJLFEFN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xC79E70", Offset = "0xC79070", VA = "0x180C79E70")]
			internal bool CGHKNIBFIMM(ContentLoadingAudioPaletteItem contentLoadingAudioPalette)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[CompilerGenerated]
		private sealed class MFOGGPIDJMN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public MBMHCBINOAP recyclingAudioPaletteType;

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
			public MFOGGPIDJMN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0xC79E70", Offset = "0xC79070", VA = "0x180C79E70")]
			internal bool DHAMEJPMJBD(RecyclingAudioPaletteItem recyclingAudioPalette)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[SerializeField]
		[JBNLAEMHODB("ButtonAudioPaletteType")]
		private ButtonAudioPaletteItem[] buttonAudioPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[SerializeField]
		[JBNLAEMHODB("ScrollingAudioPaletteType")]
		private ScrollingAudioPaletteItem[] scrollingAudioPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[SerializeField]
		[JBNLAEMHODB("ContentLoadingAudioPaletteType")]
		private ContentLoadingAudioPaletteItem[] contentLoadingAudioPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[SerializeField]
		[JBNLAEMHODB("RecyclingAudioPaletteType")]
		private RecyclingAudioPaletteItem[] recyclingAudioPalettes;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xC7A330", Offset = "0xC79530", VA = "0x180C7A330")]
		public ButtonAudioPaletteAsset FBOPBIPCCJP(OMOPAMPPPJP MPLIHBDMLNH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xC7A420", Offset = "0xC79620", VA = "0x180C7A420")]
		public ScrollingAudioPaletteAsset FIGPJEFCLIK(BJAJDEIBDAF DLDOFFPMKBG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xC7A510", Offset = "0xC79710", VA = "0x180C7A510")]
		public ContentLoadingAudioPaletteAsset KLJNAMCCCDK(EKFEGBJMIIG NNAPCCFDAPI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xC7A600", Offset = "0xC79800", VA = "0x180C7A600")]
		public RecyclingAudioPaletteAsset NMHPOJEPNIB(MBMHCBINOAP AIOCIMKIJCK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xC7A6F0", Offset = "0xC798F0", VA = "0x180C7A6F0")]
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
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x980060", Offset = "0x97F260", VA = "0x180980060")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public Color ForegroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x980080", Offset = "0x97F280", VA = "0x180980080")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public Color PlaceholderColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xC08A80", Offset = "0xC07C80", VA = "0x180C08A80")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public TextStylePalette TextPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x826EA0", Offset = "0x8260A0", VA = "0x180826EA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xC7EEE0", Offset = "0xC7E0E0", VA = "0x180C7EEE0")]
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
		[IMEOLICHDCN(OANOIFMCHLE.Self, false, false, false)]
		private Image image;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[SerializeField]
		[LOLBLOLLILE(OANOIFMCHLE.Self, false, false, false)]
		private UIGradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[SerializeField]
		private KJEMDIAELBE color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[SerializeField]
		[FDKNKMFDEBB("gradient")]
		private bool ignoreGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[SerializeField]
		[Tooltip("The surface theme determines if this Image is a RaycastTarget or not. There are times when you might want to ignore that setting of the palette theme and just respect whatever is the default state on the Image.")]
		private bool ignoreSettingRaycastTarget;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public KJEMDIAELBE IHAMMPJHPIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x8D6C00", Offset = "0x8D5E00", VA = "0x1808D6C00")]
			get
			{
				return default(KJEMDIAELBE);
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xC88C60", Offset = "0xC87E60", VA = "0x180C88C60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xC88990", Offset = "0xC87B90", VA = "0x180C88990", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xC88C00", Offset = "0xC87E00", VA = "0x180C88C00")]
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
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xC7C840", Offset = "0xC7BA40", VA = "0x180C7C840")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xC7C7D0", Offset = "0xC7B9D0", VA = "0x180C7C7D0")]
		public bool LPMLOFFDFOJ(out RecRoomAudioClip[] LMCFNFLNGNP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xC84300", Offset = "0xC83500", VA = "0x180C84300")]
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
		[FDKNKMFDEBB("usePaletteOverride")]
		private Palette paletteOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public CJPPGPOGFKM PaletteChangeEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		[SerializeField]
		private bool useDepth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private AAPEKDAMDII EPIAPMLCMDP;

		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private const string GNFPPLGODBI = "watch_layer";

		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private const string JHMNMEPLGNL = "depth_multiplier";

		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private const float PBPALPEJFHL = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private float? FDEMFDPDDKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private float? HEGAALAEEEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private float? KKPAEEODNNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private float ELGOONKBAKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private float NDEDJLJDHAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private float GKGNNLIGPOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private float NFKBGHFOGBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private readonly COJCOIOHKKE GHIJBAOBGFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private SFXAudioSource OBILNFENFOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private SFXAudioSource PAFHDMEKHON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private ContentLoadingAudioPaletteAsset JGBOKFDGFIC;

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private const float DKOGFOPKJDO = 0.001f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private EJGHBBJDJPG AEIALMPPNCA;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public Palette GPNHGEPBILO
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0xC82D30", Offset = "0xC81F30", VA = "0x180C82D30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public bool DMIMECIOFFF
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x8D6B70", Offset = "0x8D5D70", VA = "0x1808D6B70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public float GDFMJJPOOHD
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0xC82B60", Offset = "0xC81D60", VA = "0x180C82B60")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		private bool BGBLGADJCCM
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xC82270", Offset = "0xC81470", VA = "0x180C82270")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		private bool MHMMMNHPIMF
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xC82530", Offset = "0xC81730", VA = "0x180C82530")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xC817D0", Offset = "0xC809D0", VA = "0x180C817D0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xC81D00", Offset = "0xC80F00", VA = "0x180C81D00")]
		private void EDJOMJEDODO(CKPMDBIBJAB.DAJGHIMBLNE HJACGFNBPDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xC82540", Offset = "0xC81740", VA = "0x180C82540")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xC82300", Offset = "0xC81500", VA = "0x180C82300")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xC81D30", Offset = "0xC80F30", VA = "0x180C81D30")]
		private void EEBBLEODHKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xC816A0", Offset = "0xC808A0", VA = "0x180C816A0")]
		public void AddLoadingSFXRequest(object IBIKCCMDMHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0xC82940", Offset = "0xC81B40", VA = "0x180C82940")]
		public void RemoveLoadingSFXRequest(object IBIKCCMDMHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xC82300", Offset = "0xC81500", VA = "0x180C82300")]
		private void KAINOPBAGLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0xC81F10", Offset = "0xC81110", VA = "0x180C81F10")]
		private void FLBEMFHPLFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xC82120", Offset = "0xC81320", VA = "0x180C82120")]
		private void GDPEGFDBLCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xC82670", Offset = "0xC81870", VA = "0x180C82670")]
		private void PCFNEIEBJIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xC81A90", Offset = "0xC80C90", VA = "0x180C81A90")]
		private void DCKKNBKGPCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0xC82440", Offset = "0xC81640", VA = "0x180C82440")]
		private void LDFDOLDEOLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xC82260", Offset = "0xC81460", VA = "0x180C82260")]
		private void GLLJKECOAOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xC819A0", Offset = "0xC80BA0", VA = "0x180C819A0")]
		private void CIAIGMFDIHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xC81960", Offset = "0xC80B60", VA = "0x180C81960")]
		private void CCKOOGJFJBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xC82770", Offset = "0xC81970", VA = "0x180C82770")]
		public void Play2DUIFlavorSFX(RecRoomAudioClip[] PLEFPCFJLFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xC82A60", Offset = "0xC81C60", VA = "0x180C82A60")]
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
		private MPMOPBAPIGO depth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		[SerializeField]
		private bool animateOnEnable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[SerializeField]
		[FDKNKMFDEBB("animateOnEnable")]
		private float animationTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private Vector3? LBMKCOABNIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private Vector2 MNKFFGJGMEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private Vector2 GNOBNHECFGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private Vector2 JCBCPPEIAGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private Vector2 IGPFMFIEKKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private Vector2 LMOMEPFNFPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private Vector2 DJLJFDCOBCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private readonly bool? JMEPCBCOHEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private DKBCMGLPBAN DIDLEMNLOKH;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		private RectTransform BFEBIINBOBI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xC7CC50", Offset = "0xC7BE50", VA = "0x180C7CC50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public MPMOPBAPIGO LGEFBKMBBIK
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x841C90", Offset = "0x840E90", VA = "0x180841C90")]
			get
			{
				return default(MPMOPBAPIGO);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xC7D680", Offset = "0xC7C880", VA = "0x180C7D680")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		private DKBCMGLPBAN JPIHJFLMHHM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xC7CBE0", Offset = "0xC7BDE0", VA = "0x180C7CBE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		private bool OCPFCGNFMNE
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xC7D030", Offset = "0xC7C230", VA = "0x180C7D030")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xC7D4F0", Offset = "0xC7C6F0", VA = "0x180C7D4F0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xC7D440", Offset = "0xC7C640", VA = "0x180C7D440")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0xC7C8C0", Offset = "0xC7BAC0", VA = "0x180C7C8C0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xC7D120", Offset = "0xC7C320", VA = "0x180C7D120")]
		private void OHLMLHJNBAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xC7CCB0", Offset = "0xC7BEB0", VA = "0x180C7CCB0")]
		private Vector3 MJGBJPCFLEN()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xC7D560", Offset = "0xC7C760", VA = "0x180C7D560")]
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
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0xC7C8B0", Offset = "0xC7BAB0", VA = "0x180C7C8B0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xC7C8A0", Offset = "0xC7BAA0", VA = "0x180C7C8A0")]
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
			private EINHAHLILOC paletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			[SerializeField]
			private Color color;

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			public EINHAHLILOC RawImageColorPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x60000D1")]
				[Cpp2IlInjected.Address(RVA = "0x841A60", Offset = "0x840C60", VA = "0x180841A60")]
				get
				{
					return default(EINHAHLILOC);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			public Color Color
			{
				[Cpp2IlInjected.Token(Token = "0x60000D2")]
				[Cpp2IlInjected.Address(RVA = "0x99AF50", Offset = "0x99A150", VA = "0x18099AF50")]
				get
				{
					return default(Color);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0xC84130", Offset = "0xC83330", VA = "0x180C84130")]
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
			private KJEMDIAELBE backgroundColorPaletteType;

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
			public KJEMDIAELBE BackgroundColorPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x60000D4")]
				[Cpp2IlInjected.Address(RVA = "0x841A60", Offset = "0x840C60", VA = "0x180841A60")]
				get
				{
					return default(KJEMDIAELBE);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000046")]
			public Color Color
			{
				[Cpp2IlInjected.Token(Token = "0x60000D5")]
				[Cpp2IlInjected.Address(RVA = "0x99AF50", Offset = "0x99A150", VA = "0x18099AF50")]
				get
				{
					return default(Color);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000047")]
			public Gradient Gradient
			{
				[Cpp2IlInjected.Token(Token = "0x60000D6")]
				[Cpp2IlInjected.Address(RVA = "0x82A5F0", Offset = "0x8297F0", VA = "0x18082A5F0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000048")]
			public bool RaycastTarget
			{
				[Cpp2IlInjected.Token(Token = "0x60000D7")]
				[Cpp2IlInjected.Address(RVA = "0x8D6B70", Offset = "0x8D5D70", VA = "0x1808D6B70")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0xC7A750", Offset = "0xC79950", VA = "0x180C7A750")]
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
			private OMBLAMGAEDP foregroundColorPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			[SerializeField]
			private Color color;

			[Cpp2IlInjected.Token(Token = "0x17000049")]
			public OMBLAMGAEDP ForegroundColorPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x60000D9")]
				[Cpp2IlInjected.Address(RVA = "0x841A60", Offset = "0x840C60", VA = "0x180841A60")]
				get
				{
					return default(OMBLAMGAEDP);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004A")]
			public Color Color
			{
				[Cpp2IlInjected.Token(Token = "0x60000DA")]
				[Cpp2IlInjected.Address(RVA = "0x99AF50", Offset = "0x99A150", VA = "0x18099AF50")]
				get
				{
					return default(Color);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0xC7E7D0", Offset = "0xC7D9D0", VA = "0x180C7E7D0")]
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
			private HCJPFJKIIBD tilerPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			[SerializeField]
			private TilerPalette tilerPalette;

			[Cpp2IlInjected.Token(Token = "0x1700004B")]
			public HCJPFJKIIBD TilerPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x60000DC")]
				[Cpp2IlInjected.Address(RVA = "0x841A60", Offset = "0x840C60", VA = "0x180841A60")]
				get
				{
					return default(HCJPFJKIIBD);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004C")]
			public TilerPalette TilerPalette
			{
				[Cpp2IlInjected.Token(Token = "0x60000DD")]
				[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0xC7C8A0", Offset = "0xC7BAA0", VA = "0x180C7C8A0")]
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
			private KFLIBKPECDP textStylePaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			[SerializeField]
			private TextStylePalette textStylePalette;

			[Cpp2IlInjected.Token(Token = "0x1700004D")]
			public KFLIBKPECDP TextStylePaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x60000DF")]
				[Cpp2IlInjected.Address(RVA = "0x841A60", Offset = "0x840C60", VA = "0x180841A60")]
				get
				{
					return default(KFLIBKPECDP);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004E")]
			public TextStylePalette TextStylePalette
			{
				[Cpp2IlInjected.Token(Token = "0x60000E0")]
				[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0xC7AB20", Offset = "0xC79D20", VA = "0x180C7AB20")]
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
			private BOFOCBPANNA textSizePaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			[SerializeField]
			private int size;

			[Cpp2IlInjected.Token(Token = "0x1700004F")]
			public BOFOCBPANNA TextSizePaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x60000E2")]
				[Cpp2IlInjected.Address(RVA = "0x841A60", Offset = "0x840C60", VA = "0x180841A60")]
				get
				{
					return default(BOFOCBPANNA);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000050")]
			public int Size
			{
				[Cpp2IlInjected.Token(Token = "0x60000E3")]
				[Cpp2IlInjected.Address(RVA = "0x841C80", Offset = "0x840E80", VA = "0x180841C80")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0xC88FF0", Offset = "0xC881F0", VA = "0x180C88FF0")]
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
			private CKPDGNDLLKI buttonPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			[SerializeField]
			private ButtonPalette buttonPalette;

			[Cpp2IlInjected.Token(Token = "0x17000051")]
			public CKPDGNDLLKI ButtonPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x60000E5")]
				[Cpp2IlInjected.Address(RVA = "0x841A60", Offset = "0x840C60", VA = "0x180841A60")]
				get
				{
					return default(CKPDGNDLLKI);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000052")]
			public ButtonPalette ButtonPalette
			{
				[Cpp2IlInjected.Token(Token = "0x60000E6")]
				[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xC7AB20", Offset = "0xC79D20", VA = "0x180C7AB20")]
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
			private CMEIOJGIHGK togglePaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			[SerializeField]
			private TogglePalette togglePalette;

			[Cpp2IlInjected.Token(Token = "0x17000053")]
			public CMEIOJGIHGK TogglePaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x60000E8")]
				[Cpp2IlInjected.Address(RVA = "0x841A60", Offset = "0x840C60", VA = "0x180841A60")]
				get
				{
					return default(CMEIOJGIHGK);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000054")]
			public TogglePalette TogglePalette
			{
				[Cpp2IlInjected.Token(Token = "0x60000E9")]
				[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0xC7AB20", Offset = "0xC79D20", VA = "0x180C7AB20")]
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
			private BNMBIGCFFIL mixedTogglePaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			[SerializeField]
			private MixedTogglePalette mixedTogglePalette;

			[Cpp2IlInjected.Token(Token = "0x17000055")]
			public BNMBIGCFFIL MixedTogglePaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x60000EB")]
				[Cpp2IlInjected.Address(RVA = "0x841A60", Offset = "0x840C60", VA = "0x180841A60")]
				get
				{
					return default(BNMBIGCFFIL);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000056")]
			public MixedTogglePalette MixedTogglePalette
			{
				[Cpp2IlInjected.Token(Token = "0x60000EC")]
				[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xC7AB20", Offset = "0xC79D20", VA = "0x180C7AB20")]
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
			private AMLDBKEDEPB makerPenToolPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			[SerializeField]
			private MakerPenToolPalette makerPenToolPalette;

			[Cpp2IlInjected.Token(Token = "0x17000057")]
			public AMLDBKEDEPB MakerPenToolPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x60000EE")]
				[Cpp2IlInjected.Address(RVA = "0x841A60", Offset = "0x840C60", VA = "0x180841A60")]
				get
				{
					return default(AMLDBKEDEPB);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000058")]
			public MakerPenToolPalette MakerPenToolPalette
			{
				[Cpp2IlInjected.Token(Token = "0x60000EF")]
				[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0xC7AB20", Offset = "0xC79D20", VA = "0x180C7AB20")]
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
			private EFOFGNCGAAA inputFieldPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			[SerializeField]
			private InputFieldPalette inputFieldPalette;

			[Cpp2IlInjected.Token(Token = "0x17000059")]
			public EFOFGNCGAAA InputFieldPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x60000F1")]
				[Cpp2IlInjected.Address(RVA = "0x841A60", Offset = "0x840C60", VA = "0x180841A60")]
				get
				{
					return default(EFOFGNCGAAA);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005A")]
			public InputFieldPalette InputFieldPalette
			{
				[Cpp2IlInjected.Token(Token = "0x60000F2")]
				[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0xC7AB20", Offset = "0xC79D20", VA = "0x180C7AB20")]
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
			private GMDLFBILIOK dropdownPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			[SerializeField]
			private DropdownPalette dropdownPalette;

			[Cpp2IlInjected.Token(Token = "0x1700005B")]
			public GMDLFBILIOK DropdownPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0x841A60", Offset = "0x840C60", VA = "0x180841A60")]
				get
				{
					return default(GMDLFBILIOK);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005C")]
			public DropdownPalette DropdownPalette
			{
				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0xC7AB20", Offset = "0xC79D20", VA = "0x180C7AB20")]
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
			private KOKAALONOLF sliderPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			[SerializeField]
			private SliderPalette sliderPalette;

			[Cpp2IlInjected.Token(Token = "0x1700005D")]
			public KOKAALONOLF SliderPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x60000F7")]
				[Cpp2IlInjected.Address(RVA = "0x841A60", Offset = "0x840C60", VA = "0x180841A60")]
				get
				{
					return default(KOKAALONOLF);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005E")]
			public SliderPalette SliderPalette
			{
				[Cpp2IlInjected.Token(Token = "0x60000F8")]
				[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0xC7AB20", Offset = "0xC79D20", VA = "0x180C7AB20")]
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
			private MPMOPBAPIGO depthPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			[SerializeField]
			private DepthPalette depthPalette;

			[Cpp2IlInjected.Token(Token = "0x1700005F")]
			public MPMOPBAPIGO DepthPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x60000FA")]
				[Cpp2IlInjected.Address(RVA = "0x841A60", Offset = "0x840C60", VA = "0x180841A60")]
				get
				{
					return default(MPMOPBAPIGO);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000060")]
			public DepthPalette DepthPalette
			{
				[Cpp2IlInjected.Token(Token = "0x60000FB")]
				[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xC7AB20", Offset = "0xC79D20", VA = "0x180C7AB20")]
			public DepthPaletteItem()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[CompilerGenerated]
		private sealed class IDADDHGKLNF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public EINHAHLILOC backgroundColorPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
			public IDADDHGKLNF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0xC79E70", Offset = "0xC79070", VA = "0x180C79E70")]
			internal bool CLABENKHAFG(RawImageColorPaletteItem pi)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		[CompilerGenerated]
		private sealed class NMNPMBIDFME
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public KJEMDIAELBE backgroundColorPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
			public NMNPMBIDFME()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0xC79E70", Offset = "0xC79070", VA = "0x180C79E70")]
			internal bool ODLHCIMJIOG(BackgroundColorPaletteItem backgroundColorPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000039")]
		[CompilerGenerated]
		private sealed class FPHDABNMNGG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public OMBLAMGAEDP foregroundColorPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
			public FPHDABNMNGG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0xC79E70", Offset = "0xC79070", VA = "0x180C79E70")]
			internal bool FEIJIGIFOEF(ForegroundColorPaletteItem colorPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		[CompilerGenerated]
		private sealed class LLMGOGGOEJL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public HCJPFJKIIBD type;

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
			public LLMGOGGOEJL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0xC79E70", Offset = "0xC79070", VA = "0x180C79E70")]
			internal bool MHNFCDMAANO(TilerPaletteItem tilerPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		[CompilerGenerated]
		private sealed class GFNPDGJMPCL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public KFLIBKPECDP textStylePaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
			public GFNPDGJMPCL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0xC79E70", Offset = "0xC79070", VA = "0x180C79E70")]
			internal bool LJBDDGNFJMG(TextStylePaletteItem textStylePaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		[CompilerGenerated]
		private sealed class NFLLFJIMNNI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public BOFOCBPANNA textSizePaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
			public NFLLFJIMNNI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0xC79E70", Offset = "0xC79070", VA = "0x180C79E70")]
			internal bool KLNKCINOMEP(TextSizePaletteItem textSizePaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003D")]
		[CompilerGenerated]
		private sealed class OCEHLJLMPIG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public CKPDGNDLLKI buttonPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
			public OCEHLJLMPIG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0xC79E70", Offset = "0xC79070", VA = "0x180C79E70")]
			internal bool CFMLENEBEPA(ButtonPaletteItem buttonPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		[CompilerGenerated]
		private sealed class BIEIKHKAFDH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public CMEIOJGIHGK togglePaletteType;

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
			public BIEIKHKAFDH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0xC79E70", Offset = "0xC79070", VA = "0x180C79E70")]
			internal bool CFMAFKHCOAI(TogglePaletteItem togglePaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		[CompilerGenerated]
		private sealed class DGPKCDNCPOC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public BNMBIGCFFIL mixedTogglePaletteType;

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
			public DGPKCDNCPOC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0xC79E70", Offset = "0xC79070", VA = "0x180C79E70")]
			internal bool DENBNHHBHCJ(MixedTogglePaletteItem mixedTogglePaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		[CompilerGenerated]
		private sealed class OJDLPOPHCJF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public AMLDBKEDEPB makerPenToolPaletteType;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
			public OJDLPOPHCJF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0xC79E70", Offset = "0xC79070", VA = "0x180C79E70")]
			internal bool OCFLKJLCBCC(MakerPenToolPaletteItem makerPenToolPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[CompilerGenerated]
		private sealed class AIAJKFFPCOK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			public EFOFGNCGAAA inputFieldPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
			public AIAJKFFPCOK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0xC79E70", Offset = "0xC79070", VA = "0x180C79E70")]
			internal bool EJNDNLGONFA(InputFieldPaletteItem inputFieldPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		[CompilerGenerated]
		private sealed class KECLBFEPJEH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public GMDLFBILIOK dropdownPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
			public KECLBFEPJEH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0xC79E70", Offset = "0xC79070", VA = "0x180C79E70")]
			internal bool CHPLNPBBLJF(DropdownPaletteItem dropdownPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000043")]
		[CompilerGenerated]
		private sealed class EIBGIDAELKK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public KOKAALONOLF sliderPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
			public EIBGIDAELKK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xC79E70", Offset = "0xC79070", VA = "0x180C79E70")]
			internal bool AGBLMHNLEIJ(SliderPaletteItem sliderPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		[CompilerGenerated]
		private sealed class MOAGAEDLHCH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			public MPMOPBAPIGO depthPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
			public MOAGAEDLHCH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0xC79E70", Offset = "0xC79070", VA = "0x180C79E70")]
			internal bool AEBGBIEPLFD(DepthPaletteItem depthPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[SerializeField]
		[Header("Visual")]
		[JBNLAEMHODB("RawImageColorPaletteType")]
		private RawImageColorPaletteItem[] rawImageColorPaletteItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[SerializeField]
		[JBNLAEMHODB("BackgroundColorPaletteType")]
		private BackgroundColorPaletteItem[] backgroundColorPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[SerializeField]
		[JBNLAEMHODB("ForegroundColorPaletteType")]
		private ForegroundColorPaletteItem[] foregroundColorPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[SerializeField]
		[JBNLAEMHODB("TilerPaletteType")]
		private TilerPaletteItem[] tilerPaletteItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		[SerializeField]
		[JBNLAEMHODB("TextStylePaletteType")]
		private TextStylePaletteItem[] textStylePalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		[SerializeField]
		[JBNLAEMHODB("TextSizePaletteType")]
		private TextSizePaletteItem[] textSizePalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		[SerializeField]
		[JBNLAEMHODB("ButtonPaletteType")]
		private ButtonPaletteItem[] buttonPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		[SerializeField]
		[JBNLAEMHODB("TogglePaletteType")]
		private TogglePaletteItem[] togglePalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		[SerializeField]
		[JBNLAEMHODB("MixedTogglePaletteType")]
		private MixedTogglePaletteItem[] mixedTogglePalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		[SerializeField]
		[JBNLAEMHODB("MakerPenToolPaletteType")]
		private MakerPenToolPaletteItem[] makerPenToolPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		[SerializeField]
		[JBNLAEMHODB("InputFieldPaletteType")]
		private InputFieldPaletteItem[] inputFieldPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		[SerializeField]
		[JBNLAEMHODB("DropdownPaletteType")]
		private DropdownPaletteItem[] dropdownPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		[SerializeField]
		[JBNLAEMHODB("SliderPaletteType")]
		private SliderPaletteItem[] sliderPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		[SerializeField]
		[JBNLAEMHODB("DepthPaletteType")]
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
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x912480", Offset = "0x911680", VA = "0x180912480")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public ButtonAnimationPalette ButtonAnimationPalette
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x8DEE60", Offset = "0x8DE060", VA = "0x1808DEE60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public AudioPalette AudioPalette
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x8DEF00", Offset = "0x8DE100", VA = "0x1808DEF00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0xC832B0", Offset = "0xC824B0", VA = "0x180C832B0")]
		public Color GADIGILNDAD(EINHAHLILOC BKIIJHGDFEG)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0xC83A90", Offset = "0xC82C90", VA = "0x180C83A90")]
		public void PGOJHBHOLGG(KJEMDIAELBE BKIIJHGDFEG, out Color MBOFNGAOJFM, out Gradient BMAJAFJPJAH, out bool NIGMLPMEPHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xC830B0", Offset = "0xC822B0", VA = "0x180C830B0")]
		public Color CBHKCFABDKM(OMBLAMGAEDP ENFKGJHBIBL)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xC82ED0", Offset = "0xC820D0", VA = "0x180C82ED0")]
		public TilerPalette APMAGMCOFNB(HCJPFJKIIBD JAACLLLIGMF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0xC82DE0", Offset = "0xC81FE0", VA = "0x180C82DE0")]
		public TextStylePalette ALDJAOEFPME(KFLIBKPECDP JEACKCKOPHH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xC838B0", Offset = "0xC82AB0", VA = "0x180C838B0")]
		public int NCPBPBFOCEB(BOFOCBPANNA ABFHGDNLAHO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xC831C0", Offset = "0xC823C0", VA = "0x180C831C0")]
		public ButtonPalette EKEBKKCAFKE(CKPDGNDLLKI PFMEFABEJOG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0xC837C0", Offset = "0xC829C0", VA = "0x180C837C0")]
		public TogglePalette NBBNAMFDPEI(CMEIOJGIHGK LDIIGJHLOCH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xC82FC0", Offset = "0xC821C0", VA = "0x180C82FC0")]
		public MixedTogglePalette BGBBMOOOMHJ(BNMBIGCFFIL CKJALOINPFP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xC833C0", Offset = "0xC825C0", VA = "0x180C833C0")]
		public MakerPenToolPalette GJEDLKNKBMJ(AMLDBKEDEPB ONLALAAGDMG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0xC839A0", Offset = "0xC82BA0", VA = "0x180C839A0")]
		public InputFieldPalette NHCJIPMNPMJ(EFOFGNCGAAA CCPAGLICKIB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0xC836D0", Offset = "0xC828D0", VA = "0x180C836D0")]
		public DropdownPalette LEOBGDJKKIL(GMDLFBILIOK KHNFDDFMFOF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xC835E0", Offset = "0xC827E0", VA = "0x180C835E0")]
		public SliderPalette LBFHBDCPELN(KOKAALONOLF MBKJDAPLMCO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0xC834B0", Offset = "0xC826B0", VA = "0x180C834B0")]
		public float? HHPHAAEILKJ(MPMOPBAPIGO KJPECKKNOKM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0xC83C10", Offset = "0xC82E10", VA = "0x180C83C10")]
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
		[IMEOLICHDCN(OANOIFMCHLE.Self, false, false, false)]
		private ELEEDNKGOKL recyclingGrid;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0xC84340", Offset = "0xC83540", VA = "0x180C84340", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xC845C0", Offset = "0xC837C0", VA = "0x180C845C0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xC84550", Offset = "0xC83750", VA = "0x180C84550")]
		private void OEMBOJDACLJ(float IADEJOGNEBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0xC847D0", Offset = "0xC839D0", VA = "0x180C847D0")]
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
		private OMOPAMPPPJP audioPalette;

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public Color BackgroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x980060", Offset = "0x97F260", VA = "0x180980060")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public ColorBlock BackgroundTints
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0xC7AC90", Offset = "0xC79E90", VA = "0x180C7AC90")]
			get
			{
				return default(ColorBlock);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public GradientBlock BackgroundGradients
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0xC7AC60", Offset = "0xC79E60", VA = "0x180C7AC60")]
			get
			{
				return default(GradientBlock);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public Color ForegroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0xC7ACD0", Offset = "0xC79ED0", VA = "0x180C7ACD0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public ColorBlock ForegroundTints
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0xC7ACE0", Offset = "0xC79EE0", VA = "0x180C7ACE0")]
			get
			{
				return default(ColorBlock);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public bool ShowBorder
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xC7AD30", Offset = "0xC79F30", VA = "0x180C7AD30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public TextStylePalette TextPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0xB0EEB0", Offset = "0xB0E0B0", VA = "0x180B0EEB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public OMOPAMPPPJP AudioPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0xC7AC50", Offset = "0xC79E50", VA = "0x180C7AC50")]
			get
			{
				return default(OMOPAMPPPJP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0xC7AB50", Offset = "0xC79D50", VA = "0x180C7AB50")]
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
		[IMEOLICHDCN(OANOIFMCHLE.Self, false, false, false)]
		private Graphic graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		[SerializeField]
		private bool useGraphicOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		[SerializeField]
		[FDKNKMFDEBB("useGraphicOverride")]
		private Graphic graphicOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		[SerializeField]
		private OMBLAMGAEDP color;

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public Graphic KAPELOPCMLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0xC7EEB0", Offset = "0xC7E0B0", VA = "0x180C7EEB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public OMBLAMGAEDP PPNLAIHBCAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x8D6B60", Offset = "0x8D5D60", VA = "0x1808D6B60")]
			get
			{
				return default(OMBLAMGAEDP);
			}
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0xC7EEC0", Offset = "0xC7E0C0", VA = "0x180C7EEC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public bool EIKLGEJIGHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x9D6CF0", Offset = "0x9D5EF0", VA = "0x1809D6CF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x9D7480", Offset = "0x9D6680", VA = "0x1809D7480")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Color? NGDIIJFBJBI
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0xC7ECE0", Offset = "0xC7DEE0", VA = "0x180C7ECE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0xC7EA60", Offset = "0xC7DC60", VA = "0x180C7EA60", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0xC7EC80", Offset = "0xC7DE80", VA = "0x180C7EC80")]
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
		[IMEOLICHDCN(OANOIFMCHLE.Self, false, false, false)]
		private RawImage image;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		[SerializeField]
		private EINHAHLILOC color;

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public EINHAHLILOC JCFCLOKIMAJ
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x8F9D40", Offset = "0x8F8F40", VA = "0x1808F9D40")]
			get
			{
				return default(EINHAHLILOC);
			}
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0xC84110", Offset = "0xC83310", VA = "0x180C84110")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xC84170", Offset = "0xC83370", VA = "0x180C84170", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0xC842B0", Offset = "0xC834B0", VA = "0x180C842B0")]
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
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x8D4AB0", Offset = "0x8D3CB0", VA = "0x1808D4AB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xC7F8B0", Offset = "0xC7EAB0", VA = "0x180C7F8B0")]
		public MakerPenToolPalette()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public class TextStylePalette
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public enum KFNDMKMLCIO
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
		private KFNDMKMLCIO transformation;

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public TMP_FontAsset Font
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x8D4AB0", Offset = "0x8D3CB0", VA = "0x1808D4AB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public Material FontOverrideMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public float Kerning
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0xC7C840", Offset = "0xC7BA40", VA = "0x180C7C840")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public float Leading
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0xC7C850", Offset = "0xC7BA50", VA = "0x180C7C850")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public bool IsBold
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x98C9A0", Offset = "0x98BBA0", VA = "0x18098C9A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public bool IsItalic
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0xC89380", Offset = "0xC88580", VA = "0x180C89380")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public KFNDMKMLCIO Transformation
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0xB8CEF0", Offset = "0xB8C0F0", VA = "0x180B8CEF0")]
			get
			{
				return default(KFNDMKMLCIO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0xC89000", Offset = "0xC88200", VA = "0x180C89000")]
		public void IAIIDMOILJC(TextMeshProUGUI HNADNJHCCAC, bool JFPAHIBHNDI = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0xC89330", Offset = "0xC88530", VA = "0x180C89330")]
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
		private CMEIOJGIHGK toggleType;

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
		[FDKNKMFDEBB("overrideAudioPaletteWhenActive")]
		private ButtonAudioPaletteAsset customButtonAudioConfigWhenActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		[SerializeField]
		[Tooltip("Override the audio palette when inactive defined by the toggle's visual with a custom palette")]
		private bool overrideAudioPaletteWhenInactive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		[SerializeField]
		[FDKNKMFDEBB("overrideAudioPaletteWhenInactive")]
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
		[FDKNKMFDEBB("useFlavorSFX")]
		[Tooltip("Flavor SFX is picked randomly from this pool config")]
		private RecRoomAudioClipPoolConfig flavorSFXClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		protected bool NFLNNKIDKAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x161")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private bool LIHOBBKHLDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x162")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private bool GFPOMHFDIJH;

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public bool MFBCPFGMBFP
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0xC8A130", Offset = "0xC89330", VA = "0x180C8A130")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0xC8A140", Offset = "0xC89340", VA = "0x180C8A140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public CMEIOJGIHGK IMGJMLKDFEF
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0xC7AC50", Offset = "0xC79E50", VA = "0x180C7AC50")]
			get
			{
				return default(CMEIOJGIHGK);
			}
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0xC7C7B0", Offset = "0xC7B9B0", VA = "0x180C7C7B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		protected override bool IPIPLKAOHBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0xC8A000", Offset = "0xC89200", VA = "0x180C8A000", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0xC89FC0", Offset = "0xC891C0", VA = "0x180C89FC0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0xC8A010", Offset = "0xC89210", VA = "0x180C8A010")]
		public void Toggle()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0xC8A050", Offset = "0xC89250", VA = "0x180C8A050")]
		public void Toggle(bool GFPOMHFDIJH, bool NFLNNKIDKAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0xC89BC0", Offset = "0xC88DC0", VA = "0x180C89BC0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0xC8A090", Offset = "0xC89290", VA = "0x180C8A090")]
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
		[LOLBLOLLILE(OANOIFMCHLE.SelfAndParent, true, false, false)]
		private PaletteTheme paletteTheme;

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		protected PaletteTheme NEBDGHGGGOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		protected Palette GPNHGEPBILO
		{
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0xC81110", Offset = "0xC80310", VA = "0x180C81110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		protected bool JEMGNINMBOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0xC80ED0", Offset = "0xC800D0", VA = "0x180C80ED0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		protected Transform OEKDKAIIFFH
		{
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0xC80F70", Offset = "0xC80170", VA = "0x180C80F70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0xC81000", Offset = "0xC80200", VA = "0x180C81000", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0xC81580", Offset = "0xC80780", VA = "0x180C81580", Slot = "5")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void Apply();

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0xC811D0", Offset = "0xC803D0", VA = "0x180C811D0")]
		private void MPHDAFKEKAE(bool BFKKPPMODNM = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0xC81670", Offset = "0xC80870", VA = "0x180C81670")]
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
		[IMEOLICHDCN(OANOIFMCHLE.Self, false, false, false)]
		private TMP_InputField inputField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		[SerializeField]
		[LOLBLOLLILE(OANOIFMCHLE.Self, false, false, false)]
		private Image surface;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		[SerializeField]
		private bool useSurfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		[SerializeField]
		[FDKNKMFDEBB("useSurfaceOverride")]
		private Image surfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		[SerializeField]
		private EFOFGNCGAAA inputFieldType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		[SerializeField]
		private BOFOCBPANNA textSize;

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public Image CBJMFFCEAMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0xC7DE00", Offset = "0xC7D000", VA = "0x180C7DE00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public EFOFGNCGAAA OGEEBHGHLHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x9234A0", Offset = "0x9226A0", VA = "0x1809234A0")]
			get
			{
				return default(EFOFGNCGAAA);
			}
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0xC7DE10", Offset = "0xC7D010", VA = "0x180C7DE10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public BOFOCBPANNA PDMAENKBDNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0xB91940", Offset = "0xB90B40", VA = "0x180B91940")]
			get
			{
				return default(BOFOCBPANNA);
			}
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0xC7DE30", Offset = "0xC7D030", VA = "0x180C7DE30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xC7EF50", Offset = "0xC7E150", VA = "0x180C7EF50", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0xC7DD90", Offset = "0xC7CF90", VA = "0x180C7DD90")]
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
		[IMEOLICHDCN(OANOIFMCHLE.Self, false, false, false)]
		private RangeSlider slider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		[SerializeField]
		private KOKAALONOLF sliderType;

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
		public KOKAALONOLF PLJLNHJKNOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x8F9D40", Offset = "0x8F8F40", VA = "0x1808F9D40")]
			get
			{
				return default(KOKAALONOLF);
			}
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0xC84110", Offset = "0xC83310", VA = "0x180C84110")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public Image PEGKLIAHKOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x825260", Offset = "0x824460", VA = "0x180825260")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public Image IFPEBOCKAPO
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x8293D0", Offset = "0x8285D0", VA = "0x1808293D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public Image IHODJAPDADI
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x826EA0", Offset = "0x8260A0", VA = "0x180826EA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public Image IPHBGALJJAN
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x8D6BF0", Offset = "0x8D5DF0", VA = "0x1808D6BF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public bool IDAPHFNDHJM
		{
			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0xC840D0", Offset = "0xC832D0", VA = "0x180C840D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0xC840F0", Offset = "0xC832F0", VA = "0x180C840F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0xC83D10", Offset = "0xC82F10", VA = "0x180C83D10", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0xC84050", Offset = "0xC83250", VA = "0x180C84050")]
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
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x980060", Offset = "0x97F260", VA = "0x180980060")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public Color ForegroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x980080", Offset = "0x97F280", VA = "0x180980080")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public TextStylePalette TextPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x825260", Offset = "0x824460", VA = "0x180825260")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xC7D6A0", Offset = "0xC7C8A0", VA = "0x180C7D6A0")]
		public DropdownPalette()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public class MixedToggleTheme : ButtonThemeBase
	{
		[Cpp2IlInjected.Token(Token = "0x2000052")]
		public enum JOKMPDFEPCL
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
		private BNMBIGCFFIL toggleType;

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
		private JOKMPDFEPCL editorIsActiveOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private JOKMPDFEPCL GFPOMHFDIJH;

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public JOKMPDFEPCL MFBCPFGMBFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0xC80700", Offset = "0xC7F900", VA = "0x180C80700")]
			get
			{
				return default(JOKMPDFEPCL);
			}
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0xC80670", Offset = "0xC7F870", VA = "0x180C80670")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xC80640", Offset = "0xC7F840", VA = "0x180C80640")]
		public void Toggle()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xC80670", Offset = "0xC7F870", VA = "0x180C80670")]
		public void Toggle(JOKMPDFEPCL GFPOMHFDIJH, bool NFLNNKIDKAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xC800A0", Offset = "0xC7F2A0", VA = "0x180C800A0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xC80690", Offset = "0xC7F890", VA = "0x180C80690")]
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
		[IMEOLICHDCN(OANOIFMCHLE.Self, false, false, false)]
		private UITiler tiler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		[SerializeField]
		private HCJPFJKIIBD type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private DOBDPJBPOMH JMJEOILHCCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private OIOPGCLIHCB EFCBDLAHGFK;

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		private OIOPGCLIHCB HPAMNHDGOHD
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0xC89B00", Offset = "0xC88D00", VA = "0x180C89B00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		private LMOJCMEKPLF KFGDJPMHHKC
		{
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0xC89610", Offset = "0xC88810", VA = "0x180C89610")]
			get
			{
				return default(LMOJCMEKPLF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xC89A90", Offset = "0xC88C90", VA = "0x180C89A90", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0xC896F0", Offset = "0xC888F0", VA = "0x180C896F0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xC89B70", Offset = "0xC88D70", VA = "0x180C89B70")]
		public TilerTheme()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public enum KJEMDIAELBE
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
	WinterWonderlandBG,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	RuntimeAddedTag,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	RuntimeDeletedTag
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public enum EINHAHLILOC
{
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	A
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public enum OMBLAMGAEDP
{
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	MainPrimary,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	MainSecondary,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	InversePrimary,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	NotUse,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	WhitePrimary,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	WhiteSecondary,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	CardPrimary,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	CardSecondary,
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	Error,
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	Modified,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	Orange
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public enum HCJPFJKIIBD
{
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	WatchBackground,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	HomePage,
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	DialogPage,
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	Card,
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	ProfileBG,
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	WinterWonderlandHome
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public enum KFLIBKPECDP
{
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	JostMedium,
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	JostMediumCap,
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	JostBoldCap,
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	RobotoReg,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	RobotoBold,
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	RobotoBoldOutlineDropshadow,
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	RobotoBoldOutline,
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	RobotoBoldOutlineDropshadowGradient,
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	RobotoBoldOutlineGradient
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public enum BOFOCBPANNA
{
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	XXXS = -1,
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	XXS = 0,
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	XS = 1,
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	S = 2,
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	M = 3,
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	L = 4,
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	XL = 5,
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	XXL = 8,
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	XXXL = 6,
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	XXXXL = 7
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public enum CKPDGNDLLKI
{
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	Primary,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	Secondary,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	FlatPrimary,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	FlatButtonForWarningBanner,
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	Negative,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	Chips,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	CarouselArrowDark,
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	FlatWhite,
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	MagicDoor,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	Tertiary,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	CarouselArrowLight,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	HomePageMainButton,
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	DropDown,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	SecondaryHeaderSection,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	ChatButton,
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	FeedButton,
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	NameTag
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum CMEIOJGIHGK
{
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	FlatOrange,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	FlatWhite,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	InputToggle,
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	Chips,
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	Switch,
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	WhitePagingBlob,
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	RSVPToggleHeaderSection,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	CardSelectableToggle,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	ChipsDark,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	MainNavToggle,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	ListItem,
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	NotiUnread,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	FlatPrimary,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	CharadePen,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	ShareCam,
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	CardSelectableToggleWithBacking,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	SecondaryHeaderSectionToggle,
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	PrimaryToSecondaryHeader,
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	NegativeToSecondaryHeader,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	LimitedEventPrimary,
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	LimitedEventSecondary,
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	RoomCardWithLimitedEvent,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	MainNavVrDetach,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	HomeMainNav
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public enum BNMBIGCFFIL
{
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	Checkbox
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public enum AMLDBKEDEPB
{
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	Create,
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	Select,
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	Wire,
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	Configure,
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	Transform,
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	Move,
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	Rotate,
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	Scale,
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	CloneFlip,
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	Recolor,
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	Freeze,
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	MakeInvention,
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	Manipulate,
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	Delete
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public enum EFOFGNCGAAA
{
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	LightFlat,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	DarkFlat,
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	Modified
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public enum GMDLFBILIOK
{
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	LightFlat,
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	DarkFlat
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public enum KOKAALONOLF
{
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	MirroUIPopUp
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public enum MPMOPBAPIGO
{
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	Base,
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	Button,
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	Navigation,
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	Overlay,
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	Dialog,
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	Toast
}
namespace RRUI.Theme
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public abstract class ButtonThemeBase : SelectableThemeBase
	{
		[Cpp2IlInjected.Token(Token = "0x2000063")]
		protected class DGFEGHLIOKJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001D3")]
			public ButtonAudioPaletteAsset CJFCPGPOBFO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001D4")]
			public RecRoomAudioClipPoolConfig IONLDFFKHGC;

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0xC7C860", Offset = "0xC7BA60", VA = "0x180C7C860")]
			public DGFEGHLIOKJ()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		[SerializeField]
		[Header("Button Theme Base")]
		[LOLBLOLLILE(OANOIFMCHLE.Self, false, false, false)]
		private MultiGraphicButton multiGraphicButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		[SerializeField]
		[LOLBLOLLILE(OANOIFMCHLE.Self, false, true, false)]
		private Image surface;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		[SerializeField]
		private bool useSurfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		[SerializeField]
		[FDKNKMFDEBB("useSurfaceOverride")]
		private Image surfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		[SerializeField]
		[CKFGDNEKDDK]
		private List<Graphic> graphics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		[SerializeField]
		private bool useGraphicsOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		[SerializeField]
		[FDKNKMFDEBB("useGraphicsOverride")]
		private List<Graphic> graphicsOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		[SerializeField]
		[LOLBLOLLILE(OANOIFMCHLE.Self, false, true, false)]
		private UIGradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		[SerializeField]
		private bool useGradientOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		[SerializeField]
		[FDKNKMFDEBB("useGradientOverride")]
		private UIGradient gradientOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		[SerializeField]
		[LOLBLOLLILE(OANOIFMCHLE.Children, true, true, false)]
		private TextMeshProUGUI textMeshProUGUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		[SerializeField]
		private bool useTextMeshProUGUIOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		[SerializeField]
		[FDKNKMFDEBB("useTextMeshProUGUIOverride")]
		private TextMeshProUGUI textMeshProUGUIOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		[SerializeField]
		private BOFOCBPANNA textSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		[SerializeField]
		protected Hideable borderHideable;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		[SerializeField]
		protected bool isAnimationEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		[SerializeField]
		[FDKNKMFDEBB("isAnimationEnabled")]
		protected bool overrideAnimationTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		[SerializeField]
		[FDKNKMFDEBB("overrideAnimationTarget")]
		protected GameObject animationTargetOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private bool KDLOHPLJDNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private Vector3 DMANCMCPAEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private Vector3 NKMJBACFNPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private OKCBHIAGHED CDAHBBDKEEO;

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public Image CBJMFFCEAMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0xC7C460", Offset = "0xC7B660", VA = "0x180C7C460")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public List<Graphic> HAGPPJNMOPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0xC7C440", Offset = "0xC7B640", VA = "0x180C7C440")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public UIGradient FPCJPCHLCEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0xC7C420", Offset = "0xC7B620", VA = "0x180C7C420")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public TextMeshProUGUI FKHKGLPMGNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0xC7C480", Offset = "0xC7B680", VA = "0x180C7C480")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public BOFOCBPANNA PDMAENKBDNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0xC7C4A0", Offset = "0xC7B6A0", VA = "0x180C7C4A0")]
			get
			{
				return default(BOFOCBPANNA);
			}
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0xC7C4B0", Offset = "0xC7B6B0", VA = "0x180C7C4B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		protected Transform MFFKBFHNBDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0xC7B9C0", Offset = "0xC7ABC0", VA = "0x180C7B9C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		public Button JJEOEAALCMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0xC7C3A0", Offset = "0xC7B5A0", VA = "0x180C7C3A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xC7BAA0", Offset = "0xC7ACA0", VA = "0x180C7BAA0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xC7BA00", Offset = "0xC7AC00", VA = "0x180C7BA00")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xC7B820", Offset = "0xC7AA20", VA = "0x180C7B820")]
		protected void HALCFPMMHOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0xC7AD60", Offset = "0xC79F60", VA = "0x180C7AD60")]
		protected void GNMEOFMMHOK(ButtonPalette IBODODEILID, [Optional] DGFEGHLIOKJ BMMPIDGEEPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xC7BB20", Offset = "0xC7AD20", VA = "0x180C7BB20", Slot = "12")]
		public override void OnPointerDown(PointerEventData NHCCLIMEPFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xC7BEF0", Offset = "0xC7B0F0", VA = "0x180C7BEF0", Slot = "13")]
		public override void OnPointerUp(PointerEventData NHCCLIMEPFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xC7BB00", Offset = "0xC7AD00", VA = "0x180C7BB00", Slot = "14")]
		public override void OnPointerClick(PointerEventData NHCCLIMEPFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xC7B9A0", Offset = "0xC7ABA0", VA = "0x180C7B9A0")]
		private Vector3 HBHMEBCHEOD(float DNJLOGOEKNP)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0xC7C220", Offset = "0xC7B420", VA = "0x180C7C220")]
		protected ButtonThemeBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0xC7AD40", Offset = "0xC79F40", VA = "0x180C7AD40")]
		[CompilerGenerated]
		private void EMODGLLGFOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xC7AD40", Offset = "0xC79F40", VA = "0x180C7AD40")]
		[CompilerGenerated]
		private void MGCCAJJOLAM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public class ContentLoadingAudioPaletteAsset : BaseAudioPaletteAsset
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		[SerializeField]
		[Header("Clip Configs")]
		private RecRoomAudioClipPoolConfig loadingSFXAudioClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		[SerializeField]
		[Tooltip("Only start looping loading SFX if any content has been loading for this much time")]
		[Header("Thresholds")]
		private float loadingSFXStartDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		[SerializeField]
		[Tooltip("Small delay between content finish loading and stopping loading SFX. Avoiding quick stop and replay if contents load back to back.")]
		private float loadingSFXStopDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		[SerializeField]
		[Tooltip("Cut loading SFX if content is still loading after this much time. Avoid sustaining SFX when content is hanging on loading.")]
		private float maxLoadingSFXLength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		[SerializeField]
		[Header("Smooth Fade")]
		private float fadeInDuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		[SerializeField]
		private float fadeOutDuration;

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		public float LoadingSFXStartDelay
		{
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0xC7C840", Offset = "0xC7BA40", VA = "0x180C7C840")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		public float LoadingSFXStopDelay
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0xC7C850", Offset = "0xC7BA50", VA = "0x180C7C850")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		public float MaxLoadingSFXLength
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0xB0D690", Offset = "0xB0C890", VA = "0x180B0D690")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		public float FadeInDuration
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xAC3990", Offset = "0xAC2B90", VA = "0x180AC3990")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		public float FadeOutDuration
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xAFA320", Offset = "0xAF9520", VA = "0x180AFA320")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xC7C7D0", Offset = "0xC7B9D0", VA = "0x180C7C7D0")]
		public bool MKFNBILOMKC(out RecRoomAudioClip[] LMCFNFLNGNP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xC7C7F0", Offset = "0xC7B9F0", VA = "0x180C7C7F0")]
		public ContentLoadingAudioPaletteAsset()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class TogglePalette
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		[SerializeField]
		private ButtonPalette inactiveButtonPalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		[SerializeField]
		private ButtonPalette activeButtonPalette;

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		public ButtonPalette InactiveButtonPalette
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x8D4AB0", Offset = "0x8D3CB0", VA = "0x1808D4AB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		public ButtonPalette ActiveButtonPalette
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xC7C860", Offset = "0xC7BA60", VA = "0x180C7C860")]
		public TogglePalette()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class SliderPalette
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		[SerializeField]
		private Color sliderColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		[SerializeField]
		private Color fillColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		[SerializeField]
		private Color handleColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		[SerializeField]
		private TextStylePalette textPalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		[SerializeField]
		private Color textColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		[SerializeField]
		private ColorBlock colorBlock;

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		public Color SliderColor
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x980060", Offset = "0x97F260", VA = "0x180980060")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public Color FillColor
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x980080", Offset = "0x97F280", VA = "0x180980080")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public Color HandleColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0xC08A80", Offset = "0xC07C80", VA = "0x180C08A80")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public TextStylePalette TextPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x826EA0", Offset = "0x8260A0", VA = "0x180826EA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public Color TextColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x991CF0", Offset = "0x990EF0", VA = "0x180991CF0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public ColorBlock ColorBlock
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0xC884D0", Offset = "0xC876D0", VA = "0x180C884D0")]
			get
			{
				return default(ColorBlock);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0xC88400", Offset = "0xC87600", VA = "0x180C88400")]
		public SliderPalette()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public class SliderTheme : SelectableThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		[SerializeField]
		[IMEOLICHDCN(OANOIFMCHLE.Self, false, false, false)]
		[Header("Slider Visual")]
		private Slider slider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		[SerializeField]
		private KOKAALONOLF sliderType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		[SerializeField]
		[Header("Slider Audio")]
		private OMOPAMPPPJP buttonAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		[SerializeField]
		[Tooltip("Layer a 2D SFX on top of base button sounds")]
		private bool useFlavorSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		[SerializeField]
		[FDKNKMFDEBB("useFlavorSFX")]
		[Tooltip("Flavor SFX is picked randomly from this pool config")]
		private RecRoomAudioClipPoolConfig flavorSFXClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		[SerializeField]
		private Image sliderImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		[SerializeField]
		private Image fillImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		[SerializeField]
		private Image handleImage;

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public KOKAALONOLF PLJLNHJKNOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x983EB0", Offset = "0x9830B0", VA = "0x180983EB0")]
			get
			{
				return default(KOKAALONOLF);
			}
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0xC88970", Offset = "0xC87B70", VA = "0x180C88970")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public Image PEGKLIAHKOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x8DEE60", Offset = "0x8DE060", VA = "0x1808DEE60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public Image IFPEBOCKAPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x8DEF00", Offset = "0x8DE100", VA = "0x1808DEF00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		public Image GGCALFNGPBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x912450", Offset = "0x911650", VA = "0x180912450")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xC88510", Offset = "0xC87710", VA = "0x180C88510", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0xC888F0", Offset = "0xC87AF0", VA = "0x180C888F0")]
		public SliderTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public class MakerPenToolTheme : ButtonThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		[SerializeField]
		[Header("Maker Pen Tool")]
		private AMLDBKEDEPB makerPenToolPaletteType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		[SerializeField]
		[Tooltip("A list of objects to show while the maker pen tool is active.")]
		private List<Hideable> hideWhenNotActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		[SerializeField]
		[Tooltip("A list of objects to show while the maker pen tool is inactive")]
		private List<Hideable> hideWhenActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		[SerializeField]
		private bool editorIsActiveOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x131")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		protected bool NFLNNKIDKAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x132")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		private bool GFPOMHFDIJH;

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public AMLDBKEDEPB GIBCKHCDCCB
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0xC7AC50", Offset = "0xC79E50", VA = "0x180C7AC50")]
			get
			{
				return default(AMLDBKEDEPB);
			}
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0xC7C7B0", Offset = "0xC7B9B0", VA = "0x180C7C7B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public bool MFBCPFGMBFP
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0xC7FD60", Offset = "0xC7EF60", VA = "0x180C7FD60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0xC7FD70", Offset = "0xC7EF70", VA = "0x180C7FD70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xC7FCC0", Offset = "0xC7EEC0", VA = "0x180C7FCC0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0xC7F8E0", Offset = "0xC7EAE0", VA = "0x180C7F8E0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xC7FD00", Offset = "0xC7EF00", VA = "0x180C7FD00")]
		public MakerPenToolTheme()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public enum OMOPAMPPPJP
{
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	Negative = 1,
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	SelectPrimary = 2,
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	SelectSidebar = 12,
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	SelectCardToggle = 14,
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	SelectSidebarInactive = 17,
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	ToggleOnSwitch = 18,
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	ToggleOffSwitch = 19,
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	ToggleChip = 20,
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	SliderDefault = 21
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public enum BJAJDEIBDAF
{
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	Default
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public enum EKFEGBJMIIG
{
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	Default
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public enum MBMHCBINOAP
{
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	Default
}
namespace RRUI.Theme
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class ScrollingAudioPaletteAsset : BaseAudioPaletteAsset
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		[SerializeField]
		[Header("Clip Configs")]
		private RecRoomAudioClipPoolConfig scrollingSFXAudioClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		[SerializeField]
		private RecRoomAudioClipPoolConfig hittingEndsAudioClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		[SerializeField]
		[Header("Thresholds")]
		[Tooltip("This distance is measured in UI canvas space")]
		private float distanceThresholdToTriggerScrollingSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		[SerializeField]
		private float minimumTimeIntervalForScrollingSFX;

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public float DistanceThresholdToTriggerScrollingSFX
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0xB0D690", Offset = "0xB0C890", VA = "0x180B0D690")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		public float MinimumTimeIntervalForScrollingSFX
		{
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0xAC3990", Offset = "0xAC2B90", VA = "0x180AC3990")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0xC7C7D0", Offset = "0xC7B9D0", VA = "0x180C7C7D0")]
		public bool DADIJLHCKOO(out RecRoomAudioClip[] LMCFNFLNGNP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0xC87670", Offset = "0xC86870", VA = "0x180C87670")]
		public bool ONAKOGMMPLC(out RecRoomAudioClip[] LMCFNFLNGNP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0xC87690", Offset = "0xC86890", VA = "0x180C87690")]
		public ScrollingAudioPaletteAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public class ScrollRectTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		private const string FKGIOLNEOFI = "RRUI.PlayHittingEndsSFX";

		[Cpp2IlInjected.Token(Token = "0x4000207")]
		private const int KOBMMHIIJPC = 5;

		[Cpp2IlInjected.Token(Token = "0x4000208")]
		private const int DDGPMDMOAOL = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		private DateTimeOffset PAKGHNCKAIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private int MHOPMMCNCDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private bool EDOHAMNNMLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		[SerializeField]
		[IMEOLICHDCN(OANOIFMCHLE.Self, false, false, false)]
		private ScrollRect scrollRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		[SerializeField]
		[Header("Audio")]
		private BJAJDEIBDAF scrollAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		private ScrollingAudioPaletteAsset BNPDNFFNAGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private EJGHBBJDJPG INPHNHMANPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		private JGCJPDMMFLO MDDKAJHBOJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		private float LCANECMEMJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		private float JLCCLBLOENF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		private float LEKBPDNIJLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		private bool COFJPJHAEDD;

		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private const float NHJDMNNPFNK = 0.01f;

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		private EJGHBBJDJPG AEIALMPPNCA
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0xC86EE0", Offset = "0xC860E0", VA = "0x180C86EE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		private JGCJPDMMFLO ILMBBLJNGNB
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0xC86030", Offset = "0xC85230", VA = "0x180C86030")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xC85E10", Offset = "0xC85010", VA = "0x180C85E10", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xC872C0", Offset = "0xC864C0", VA = "0x180C872C0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xC85D10", Offset = "0xC84F10", VA = "0x180C85D10", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xC86F50", Offset = "0xC86150", VA = "0x180C86F50")]
		private void NCLBFMFDMHD(Vector2 FNDKHLEFPKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0xC873D0", Offset = "0xC865D0", VA = "0x180C873D0")]
		private void PFGLJLNBAMN(float EAOIEKKLDDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0xC861D0", Offset = "0xC853D0", VA = "0x180C861D0")]
		private void IGGBIPLKHKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0xC860A0", Offset = "0xC852A0", VA = "0x180C860A0")]
		private static string GPDOALLNNNG(GameObject BHEOHCEHIBM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0xC875C0", Offset = "0xC867C0", VA = "0x180C875C0")]
		public ScrollRectTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public class LabelTheme : GraphicTheme
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		[SerializeField]
		[IMEOLICHDCN(OANOIFMCHLE.Self, false, false, false)]
		private TextMeshProUGUI textMeshProUGUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		[SerializeField]
		private KFLIBKPECDP textType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		[SerializeField]
		private BOFOCBPANNA textSize;

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public KFLIBKPECDP KFNGBKHDNCK
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x931270", Offset = "0x930470", VA = "0x180931270")]
			get
			{
				return default(KFLIBKPECDP);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0xC7F890", Offset = "0xC7EA90", VA = "0x180C7F890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		public BOFOCBPANNA PDMAENKBDNG
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x943160", Offset = "0x942360", VA = "0x180943160")]
			get
			{
				return default(BOFOCBPANNA);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0xC7F870", Offset = "0xC7EA70", VA = "0x180C7F870")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0xC7F4D0", Offset = "0xC7E6D0", VA = "0x180C7F4D0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0xC7F800", Offset = "0xC7EA00", VA = "0x180C7F800")]
		public LabelTheme()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class CGEPNPBBKEG
{
	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
	public CGEPNPBBKEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x892120", Offset = "0x891320", VA = "0x180892120")]
	public static string AADLLEBJPEC(byte[] MJAMHAEGDEA, byte[] ELNJHIHGPEE)
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
