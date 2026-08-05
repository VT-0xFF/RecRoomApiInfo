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
		public List<Graphic> DMOHJNKNFEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x10537C0", Offset = "0x10527C0", VA = "0x1810537C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x104F8D0", Offset = "0x104E8D0", VA = "0x18104F8D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public ColorBlock COGOOKGNFCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x41DEEA0", Offset = "0x41DDEA0", VA = "0x1841DEEA0")]
			get
			{
				return default(ColorBlock);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x41DEF20", Offset = "0x41DDF20", VA = "0x1841DEF20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public UIGradient KEDKNBNPELC
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x10B4E40", Offset = "0x10B3E40", VA = "0x1810B4E40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x133B300", Offset = "0x133A300", VA = "0x18133B300")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public GradientBlock KBBBAJDBFAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x41DEEF0", Offset = "0x41DDEF0", VA = "0x1841DEEF0")]
			get
			{
				return default(GradientBlock);
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x41DEF70", Offset = "0x41DDF70", VA = "0x1841DEF70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x41DECF0", Offset = "0x41DDCF0", VA = "0x1841DECF0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x41DED40", Offset = "0x41DDD40", VA = "0x1841DED40", Slot = "36")]
		public override void OnSelect(BaseEventData NKPHHCMFEAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x41DED90", Offset = "0x41DDD90", VA = "0x1841DED90")]
		public void Refresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x41DEAD0", Offset = "0x41DDAD0", VA = "0x1841DEAD0")]
		public void ForceHighlighted(bool GGIIGNDFEME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x41DEAF0", Offset = "0x41DDAF0", VA = "0x1841DEAF0")]
		public void ForceNormal(bool GGIIGNDFEME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x41DE820", Offset = "0x41DD820", VA = "0x1841DE820", Slot = "26")]
		protected override void DoStateTransition(SelectionState CILNOBBJOLD, bool GGIIGNDFEME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x41DEC10", Offset = "0x41DDC10", VA = "0x1841DEC10")]
		private void MDGAGLBOIFB(Graphic CLCNCJCLEOG, Color NGEHBLIPIJC, bool GGIIGNDFEME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x41DEB10", Offset = "0x41DDB10", VA = "0x1841DEB10")]
		private void LILONEGKMBC(SelectionState CILNOBBJOLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x41DEDC0", Offset = "0x41DDDC0", VA = "0x1841DEDC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x41E7650", Offset = "0x41E6650", VA = "0x1841E7650")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public Palette Active
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x41E7620", Offset = "0x41E6620", VA = "0x1841E7620")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xBBF6A0", Offset = "0xBBE6A0", VA = "0x180BBF6A0")]
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
		private sealed class ACAADGLBFNC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public TMP_FontAsset font;

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
			public ACAADGLBFNC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x41D8250", Offset = "0x41D7250", VA = "0x1841D8250")]
			internal bool CDKOJPEDGOF(LocalizedFontMapping x)
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
			[Cpp2IlInjected.Address(RVA = "0x41DC940", Offset = "0x41DB940", VA = "0x1841DC940")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public TMP_SpriteAsset EmojiAsset
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x85E980", Offset = "0x85D980", VA = "0x18085E980")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x41DC800", Offset = "0x41DB800", VA = "0x1841DC800")]
		public bool PHEOGDOGHLL(TMP_FontAsset FANIKCBHOGM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x41DC100", Offset = "0x41DB100", VA = "0x1841DC100")]
		public TMP_FontAsset CLHLFFNFMIC(TMP_FontAsset FANIKCBHOGM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x41DC200", Offset = "0x41DB200", VA = "0x1841DC200")]
		public TMP_FontAsset CLHLFFNFMIC(TMP_FontAsset FANIKCBHOGM, Material LMHPEBBOCJP, out Material JGCGDGKFAAP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x41DC4D0", Offset = "0x41DB4D0", VA = "0x1841DC4D0")]
		public TMP_FontAsset OPKEMCMLNNI(TMP_FontAsset FANIKCBHOGM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x41DC5D0", Offset = "0x41DB5D0", VA = "0x1841DC5D0")]
		public TMP_FontAsset OPKEMCMLNNI(TMP_FontAsset FANIKCBHOGM, Material LMHPEBBOCJP, out Material BKGNDALHFCH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x41DC410", Offset = "0x41DB410", VA = "0x1841DC410")]
		private static bool MGIMPLGHCFM(TMP_FontAsset FANIKCBHOGM, LocalizedFontMapping KDIMMBHMIGE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA756E0", Offset = "0xA746E0", VA = "0x180A756E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x41DCAC0", Offset = "0x41DBAC0", VA = "0x1841DCAC0", Slot = "0")]
		public override bool Equals(object EOHGDDIECBJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x41DCBC0", Offset = "0x41DBBC0", VA = "0x1841DCBC0", Slot = "4")]
		public bool Equals(GradientBlock BKLMLPFOMCO)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x41DCBC0", Offset = "0x41DBBC0", VA = "0x1841DCBC0")]
		public static bool LFCPNLBCIDE(GradientBlock OHCEOCHLLGA, GradientBlock PBJIOLCPOOJ)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x41DCCA0", Offset = "0x41DBCA0", VA = "0x1841DCCA0")]
		public static bool JIPCNIGMDBL(GradientBlock OHCEOCHLLGA, GradientBlock PBJIOLCPOOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x41DCC30", Offset = "0x41DBC30", VA = "0x1841DCC30", Slot = "2")]
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
			[Cpp2IlInjected.Address(RVA = "0x41DE000", Offset = "0x41DD000", VA = "0x1841DE000")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public RecRoomAudioClip[] MenuOpen2DFlavorAudioClipPool
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x41DE090", Offset = "0x41DD090", VA = "0x1841DE090")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public RecRoomAudioClip[] MenuDehydrateAudioClipPool
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x41DDF70", Offset = "0x41DCF70", VA = "0x1841DDF70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public RecRoomAudioClip[] MenuClose2DFlavorAudioClipPool
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x41DDEE0", Offset = "0x41DCEE0", VA = "0x1841DDEE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2C52690", Offset = "0x2C51690", VA = "0x182C52690")]
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
			[Cpp2IlInjected.Address(RVA = "0x41D8D20", Offset = "0x41D7D20", VA = "0x1841D8D20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public RecRoomAudioClip[] PointerUpAudioClipPool
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x41D8E40", Offset = "0x41D7E40", VA = "0x1841D8E40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public RecRoomAudioClip[] PointerClickAudioClipPool
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x41D8C90", Offset = "0x41D7C90", VA = "0x1841D8C90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public RecRoomAudioClip[] PointerEnterAudioClipPool
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x41D8DB0", Offset = "0x41D7DB0", VA = "0x1841D8DB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2C52690", Offset = "0x2C51690", VA = "0x182C52690")]
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
			[Cpp2IlInjected.Address(RVA = "0xA76E90", Offset = "0xA75E90", VA = "0x180A76E90")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public float ClickAnimationScale
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xA76E80", Offset = "0xA75E80", VA = "0x180A76E80")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x41D8C70", Offset = "0x41D7C70", VA = "0x1841D8C70")]
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
		private CPJKCOOEGDP buttonAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[SerializeField]
		[Tooltip("Layer a 2D SFX on top of base button sounds")]
		private bool useFlavorSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[SerializeField]
		[Tooltip("Flavor SFX is picked randomly from this pool config")]
		[OKAEPIMCOGM("useFlavorSFX")]
		private RecRoomAudioClipPoolConfig flavorSFXClipPoolConfig;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x41E3E70", Offset = "0x41E2E70", VA = "0x1841E3E70", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x41E3F90", Offset = "0x41E2F90", VA = "0x1841E3F90")]
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
		private UITiler.CDOCAHKLOOP animationDirection;

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
			[Cpp2IlInjected.Address(RVA = "0x85E070", Offset = "0x85D070", VA = "0x18085E070")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Color TintColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xBF8100", Offset = "0xBF7100", VA = "0x180BF8100")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Color BackgroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x9C1330", Offset = "0x9C0330", VA = "0x1809C1330")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public Vector2 Spacing
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x41E7820", Offset = "0x41E6820", VA = "0x1841E7820")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float Offset
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x10B4DC0", Offset = "0x10B3DC0", VA = "0x1810B4DC0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Vector2 Velocity
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x41E7840", Offset = "0x41E6840", VA = "0x1841E7840")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public float Angle
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x10B4E00", Offset = "0x10B3E00", VA = "0x1810B4E00")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public UITiler.CDOCAHKLOOP AnimationDirection
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x907770", Offset = "0x906770", VA = "0x180907770")]
			get
			{
				return default(UITiler.CDOCAHKLOOP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float PrimaryAnimationSpeed
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x10B4E10", Offset = "0x10B3E10", VA = "0x1810B4E10")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float AltAnimationSpeed
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x134B560", Offset = "0x134A560", VA = "0x18134B560")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x41E7790", Offset = "0x41E6790", VA = "0x1841E7790")]
		public float BGDHBOJHOFP(LNOKNHEBCMM OOFDAFIPJFI)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x41E77B0", Offset = "0x41E67B0", VA = "0x1841E77B0")]
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
		[JHDFHPMJCIE(KDNNMHJGNJH.Self, false, false, false)]
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
		[OKAEPIMCOGM("overrideWithSingleAudio")]
		[Tooltip("The legacy override audio will be randomly picked from this pool")]
		protected RecRoomAudioClip[] randomAudioOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		protected bool LIFOBCJFFLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private ButtonAudioPaletteAsset FPBDKEIPLEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private RecRoomAudioClipPoolConfig PCMHIJODNJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private MCKJLIAMDEP DAFBCHEFAHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private EHIPLMIMJGL FCIIJHNDPNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private HNLHKLCEBCD BGDBIMOAFOB;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		protected Selectable CLJMIJDMAEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x85E980", Offset = "0x85D980", VA = "0x18085E980")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		protected virtual bool NFPLMMIODBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x85F430", Offset = "0x85E430", VA = "0x18085F430", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool OGNIHMMBFPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x41E2370", Offset = "0x41E1370", VA = "0x1841E2370")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x41E2390", Offset = "0x41E1390", VA = "0x1841E2390")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private MCKJLIAMDEP DFIOPFFHOOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x41E65B0", Offset = "0x41E55B0", VA = "0x1841E65B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		protected EHIPLMIMJGL JKFPBKHHPNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x41E5F60", Offset = "0x41E4F60", VA = "0x1841E5F60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private HNLHKLCEBCD NDOCJAGCFIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x41E5980", Offset = "0x41E4980", VA = "0x1841E5980")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x41E5DC0", Offset = "0x41E4DC0", VA = "0x1841E5DC0")]
		protected void HPAMNLBFHAE(ButtonAudioPaletteAsset PHLBBIEJOKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x977C50", Offset = "0x976C50", VA = "0x180977C50")]
		protected void FGJAPPHIKDN(RecRoomAudioClipPoolConfig EFOANCDLDFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x41E6200", Offset = "0x41E5200", VA = "0x1841E6200", Slot = "12")]
		public virtual void OnPointerDown(PointerEventData NKPHHCMFEAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x41E6470", Offset = "0x41E5470", VA = "0x1841E6470", Slot = "13")]
		public virtual void OnPointerUp(PointerEventData NKPHHCMFEAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x41E5FD0", Offset = "0x41E4FD0", VA = "0x1841E5FD0", Slot = "14")]
		public virtual void OnPointerClick(PointerEventData NKPHHCMFEAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x41E6340", Offset = "0x41E5340", VA = "0x1841E6340", Slot = "15")]
		public virtual void OnPointerEnter(PointerEventData NKPHHCMFEAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x41E5EE0", Offset = "0x41E4EE0", VA = "0x1841E5EE0")]
		private void JKEELHDKBJN(RecRoomAudioClip[] HADJFDODBJB, bool OEONBEHFFEP = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x41E59F0", Offset = "0x41E49F0", VA = "0x1841E59F0")]
		private void HJGEAJAMLAM(RecRoomAudioClip FIOCAKMHNDJ, bool OEONBEHFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x41E6620", Offset = "0x41E5620", VA = "0x1841E6620")]
		protected SelectableThemeBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class MixedTogglePalette
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		private enum OGNFFNCFHBK
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
		private OFABGJHFNDK baseTogglePalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private OGNFFNCFHBK mixedPaletteType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[SerializeField]
		[OKAEPIMCOGM("mixedPaletteType", 2)]
		private ButtonPalette mixedButtonPalette;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x41DE120", Offset = "0x41DD120", VA = "0x1841DE120")]
		public TogglePalette FIOKFLPCAHP(Palette JPHMFNCOAHA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x41DE150", Offset = "0x41DD150", VA = "0x1841DE150")]
		public ButtonPalette FNDMJOKLKDP(Palette JPHMFNCOAHA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x1320BE0", Offset = "0x131FBE0", VA = "0x181320BE0")]
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
		private KIBHEKBNJJM recyclingAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		protected RecyclingAudioPaletteAsset FPBDKEIPLEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[SerializeField]
		private HMHFJCDBJNM scrollingAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private ScrollingAudioPaletteAsset OJCPMOGONGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private MCKJLIAMDEP DAFBCHEFAHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private float OCMMAHPAOCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private float INCMNJBOLHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private float MIGNPAAANNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private float PFEIHLDOBAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private bool GKENOKKGKCO;

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private const float JGIGFCBPGOD = 0.01f;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private MCKJLIAMDEP DFIOPFFHOOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x41E3DA0", Offset = "0x41E2DA0", VA = "0x1841E3DA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x41E3040", Offset = "0x41E2040", VA = "0x1841E3040", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x41E3AC0", Offset = "0x41E2AC0", VA = "0x1841E3AC0")]
		protected void PCGMFBAHJIA(bool FKBIHCGOOLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x41E33E0", Offset = "0x41E23E0", VA = "0x1841E33E0")]
		protected void GFBFKKKEHFF(GameObject JFJFAONKKJC, int MHLNDIMGHCI, bool DIHFCCDKLDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x41E3250", Offset = "0x41E2250", VA = "0x1841E3250")]
		protected void EPDJLFMMJHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x41E3770", Offset = "0x41E2770", VA = "0x1841E3770")]
		protected void GLEFIMFFHCC(float JOIJOKCLCBE, float AIGALGDGMKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x41E3580", Offset = "0x41E2580", VA = "0x1841E3580")]
		private void GHOLJEOBFIL(float GFNGJGDDADD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x41E3970", Offset = "0x41E2970", VA = "0x1841E3970")]
		private void IAGLMIODEGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x41E3E10", Offset = "0x41E2E10", VA = "0x1841E3E10")]
		protected RecyclingThemeBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class SwitchTheme : ToggleTheme
	{
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private const float EEJIKIHJELO = 0.33f;

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
		private KCLIDDHACMD DOKNJKOIBCN;

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x41E6F20", Offset = "0x41E5F20", VA = "0x1841E6F20", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x41E71B0", Offset = "0x41E61B0", VA = "0x1841E71B0")]
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
		private Vector3? MCMIGAIEJHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private Vector3? GHPLOFNHBOO;

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x41D8640", Offset = "0x41D7640", VA = "0x1841D8640")]
		private void LLEBBJIFEDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x41D82C0", Offset = "0x41D72C0", VA = "0x1841D82C0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x41D8720", Offset = "0x41D7720", VA = "0x1841D8720")]
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
		[JHDFHPMJCIE(KDNNMHJGNJH.Self, false, false, false)]
		private Dropdown dropdown;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[SerializeField]
		[OFFACMCMMNI(KDNNMHJGNJH.Self, false, true, false)]
		private Image surface;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[SerializeField]
		private bool useSurfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[SerializeField]
		[OKAEPIMCOGM("useSurfaceOverride")]
		private Image surfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[SerializeField]
		private GBHBCJHFFPI dropdownType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[SerializeField]
		private FLHGGLODJFH textSize;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Image AHAADOKBKDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x41DC0B0", Offset = "0x41DB0B0", VA = "0x1841DC0B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public GBHBCJHFFPI JHBGJJBHOIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x871180", Offset = "0x870180", VA = "0x180871180")]
			get
			{
				return default(GBHBCJHFFPI);
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x41DC0C0", Offset = "0x41DB0C0", VA = "0x1841DC0C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public FLHGGLODJFH NJIJMHFFHKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x871160", Offset = "0x870160", VA = "0x180871160")]
			get
			{
				return default(FLHGGLODJFH);
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x41DC0E0", Offset = "0x41DB0E0", VA = "0x1841DC0E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x41DB9A0", Offset = "0x41DA9A0", VA = "0x1841DB9A0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x41DC040", Offset = "0x41DB040", VA = "0x1841DC040")]
		public DropdownTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class BaseAudioPaletteAsset : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x41D8BB0", Offset = "0x41D7BB0", VA = "0x1841D8BB0")]
		protected bool IICKAKDKFDL(RecRoomAudioClipPoolConfig FAGCOJIKALB, out RecRoomAudioClip[] HADJFDODBJB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA756E0", Offset = "0xA746E0", VA = "0x180A756E0")]
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
		private AMMDAPBKDLH buttonType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[SerializeField]
		[Tooltip("Override the audio palette defined by the button's visual with a custom palette")]
		[Header("Button Audio")]
		private bool overrideButtonAudioPalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[SerializeField]
		[OKAEPIMCOGM("overrideButtonAudioPalette")]
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
		[OKAEPIMCOGM("useFlavorSFX")]
		[Tooltip("Flavor SFX is picked randomly from this pool config")]
		private RecRoomAudioClipPoolConfig flavorSFXClipPoolConfig;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public AMMDAPBKDLH ABNMEKIGJII
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xFEE4C0", Offset = "0xFED4C0", VA = "0x180FEE4C0")]
			get
			{
				return default(AMMDAPBKDLH);
			}
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x41DAAE0", Offset = "0x41D9AE0", VA = "0x1841DAAE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x41DA810", Offset = "0x41D9810", VA = "0x1841DA810", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x98C050", Offset = "0x98B050", VA = "0x18098C050")]
		public void SetAnimationEnabled(bool DDHDBPLDGLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x41DAAA0", Offset = "0x41D9AA0", VA = "0x1841DAAA0")]
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
		[JHDFHPMJCIE(KDNNMHJGNJH.Self, false, false, false)]
		private KJDGKOFOKAK recyclingList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private bool GFBAAIENPBC;

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x41E2AE0", Offset = "0x41E1AE0", VA = "0x1841E2AE0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x41E2DA0", Offset = "0x41E1DA0", VA = "0x1841E2DA0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x41E2D30", Offset = "0x41E1D30", VA = "0x1841E2D30")]
		private void OCCLNPFJPAM(float JOIJOKCLCBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x41E2FC0", Offset = "0x41E1FC0", VA = "0x1841E2FC0")]
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
			private CPJKCOOEGDP buttonAudioPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			[SerializeField]
			private ButtonAudioPaletteAsset buttonAudioPaletteConfig;

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			public CPJKCOOEGDP ButtonAudioPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(RVA = "0x85E1A0", Offset = "0x85D1A0", VA = "0x18085E1A0")]
				get
				{
					return default(CPJKCOOEGDP);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public ButtonAudioPaletteAsset ButtonAudioPaletteConfig
			{
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xF60EC0", Offset = "0xF5FEC0", VA = "0x180F60EC0")]
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
			private HMHFJCDBJNM scrollingAudioPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			[SerializeField]
			private ScrollingAudioPaletteAsset scrollingAudioPaletteConfig;

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			public HMHFJCDBJNM ScrollingAudioPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600007E")]
				[Cpp2IlInjected.Address(RVA = "0x85E1A0", Offset = "0x85D1A0", VA = "0x18085E1A0")]
				get
				{
					return default(HMHFJCDBJNM);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			public ScrollingAudioPaletteAsset ScrollingAudioPaletteConfig
			{
				[Cpp2IlInjected.Token(Token = "0x600007F")]
				[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xF60EC0", Offset = "0xF5FEC0", VA = "0x180F60EC0")]
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
			private HODFMPKAFLD contentLoadingAudioPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			[SerializeField]
			private ContentLoadingAudioPaletteAsset contentLoadingAudioPaletteConfig;

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			public HODFMPKAFLD ContentLoadingAudioPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000081")]
				[Cpp2IlInjected.Address(RVA = "0x85E1A0", Offset = "0x85D1A0", VA = "0x18085E1A0")]
				get
				{
					return default(HODFMPKAFLD);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			public ContentLoadingAudioPaletteAsset ContentLoadingAudioPaletteConfig
			{
				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xF60EC0", Offset = "0xF5FEC0", VA = "0x180F60EC0")]
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
			private KIBHEKBNJJM recyclingAudioPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			[SerializeField]
			private RecyclingAudioPaletteAsset recyclingAudioPaletteConfig;

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			public KIBHEKBNJJM RecyclingAudioPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x85E1A0", Offset = "0x85D1A0", VA = "0x18085E1A0")]
				get
				{
					return default(KIBHEKBNJJM);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			public RecyclingAudioPaletteAsset RecyclingAudioPaletteConfig
			{
				[Cpp2IlInjected.Token(Token = "0x6000085")]
				[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xF60EC0", Offset = "0xF5FEC0", VA = "0x180F60EC0")]
			public RecyclingAudioPaletteItem()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class LGKHPDAMPNO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public CPJKCOOEGDP buttonAudioPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
			public LGKHPDAMPNO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xD47730", Offset = "0xD46730", VA = "0x180D47730")]
			internal bool LLOJCEHAFJO(ButtonAudioPaletteItem buttonAudioPalette)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class BEMFADKEGDE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public HMHFJCDBJNM scrollingAudioPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
			public BEMFADKEGDE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xD47730", Offset = "0xD46730", VA = "0x180D47730")]
			internal bool IODPJBDMIMA(ScrollingAudioPaletteItem scrollingAudioPalette)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class DKKNGENFGGB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public HODFMPKAFLD contentLoadingAudioPaletteType;

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
			public DKKNGENFGGB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xD47730", Offset = "0xD46730", VA = "0x180D47730")]
			internal bool ILGMFDJBBPA(ContentLoadingAudioPaletteItem contentLoadingAudioPalette)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[CompilerGenerated]
		private sealed class NHHCEOEPPKO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public KIBHEKBNJJM recyclingAudioPaletteType;

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
			public NHHCEOEPPKO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0xD47730", Offset = "0xD46730", VA = "0x180D47730")]
			internal bool HBNNAKOCEFP(RecyclingAudioPaletteItem recyclingAudioPalette)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[SerializeField]
		[KMAOMNHIIAF("ButtonAudioPaletteType")]
		private ButtonAudioPaletteItem[] buttonAudioPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[SerializeField]
		[KMAOMNHIIAF("ScrollingAudioPaletteType")]
		private ScrollingAudioPaletteItem[] scrollingAudioPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[SerializeField]
		[KMAOMNHIIAF("ContentLoadingAudioPaletteType")]
		private ContentLoadingAudioPaletteItem[] contentLoadingAudioPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[SerializeField]
		[KMAOMNHIIAF("RecyclingAudioPaletteType")]
		private RecyclingAudioPaletteItem[] recyclingAudioPalettes;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x41D8760", Offset = "0x41D7760", VA = "0x1841D8760")]
		public ButtonAudioPaletteAsset BKIBAIMKBIB(CPJKCOOEGDP DKNBFDBNEML)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x41D8850", Offset = "0x41D7850", VA = "0x1841D8850")]
		public ScrollingAudioPaletteAsset DGMNKKOIEAH(HMHFJCDBJNM IAIHHJKAMFE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x41D8940", Offset = "0x41D7940", VA = "0x1841D8940")]
		public ContentLoadingAudioPaletteAsset IJHKMGOIPIB(HODFMPKAFLD IKPNEAJELJH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x41D8A30", Offset = "0x41D7A30", VA = "0x1841D8A30")]
		public RecyclingAudioPaletteAsset JAACBFGHHAD(KIBHEKBNJJM NKLHFGMHLGM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2C52690", Offset = "0x2C51690", VA = "0x182C52690")]
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
			[Cpp2IlInjected.Address(RVA = "0xA76DE0", Offset = "0xA75DE0", VA = "0x180A76DE0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public Color ForegroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xA76DF0", Offset = "0xA75DF0", VA = "0x180A76DF0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public Color PlaceholderColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xBB9100", Offset = "0xBB8100", VA = "0x180BB9100")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public TextStylePalette TextPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x914C50", Offset = "0x913C50", VA = "0x180914C50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x41DD0E0", Offset = "0x41DC0E0", VA = "0x1841DD0E0")]
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
		[JHDFHPMJCIE(KDNNMHJGNJH.Self, false, false, false)]
		private Image image;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[SerializeField]
		[OFFACMCMMNI(KDNNMHJGNJH.Self, false, false, false)]
		private UIGradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[SerializeField]
		private HEHNKLCDKJO color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[SerializeField]
		[OKAEPIMCOGM("gradient")]
		private bool ignoreGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[SerializeField]
		[Tooltip("The surface theme determines if this Image is a RaycastTarget or not. There are times when you might want to ignore that setting of the palette theme and just respect whatever is the default state on the Image.")]
		private bool ignoreSettingRaycastTarget;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public HEHNKLCDKJO HHAKDCOCIHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xA1E8B0", Offset = "0xA1D8B0", VA = "0x180A1E8B0")]
			get
			{
				return default(HEHNKLCDKJO);
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x41E6F00", Offset = "0x41E5F00", VA = "0x1841E6F00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x41E6C30", Offset = "0x41E5C30", VA = "0x1841E6C30", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x41E6EA0", Offset = "0x41E5EA0", VA = "0x1841E6EA0")]
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
			[Cpp2IlInjected.Address(RVA = "0xFF9AE0", Offset = "0xFF8AE0", VA = "0x180FF9AE0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x41DAB00", Offset = "0x41D9B00", VA = "0x1841DAB00")]
		public bool NIOOPKCOMJN(out RecRoomAudioClip[] HADJFDODBJB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x41E25A0", Offset = "0x41E15A0", VA = "0x1841E25A0")]
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
		[OKAEPIMCOGM("usePaletteOverride")]
		private Palette paletteOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public NHBIDAMCDOH PaletteChangeEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		[SerializeField]
		private bool useDepth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private OCBALFEOJPM FPDAHMKLCBD;

		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private const string EGIEFBKKPPI = "watch_layer";

		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private const string LIOICBGEBJN = "depth_multiplier";

		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private const float OGPBCDKIGCO = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private float? LKLMBOBAMAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private float? OEPAINDPPJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private float? HNAELIDHIOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private float DHBHNOOJBBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private float GHACKPHJHFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private float PGIPBDNCNIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private float BAAIDFODLDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private readonly FPCHIOCGOJB GFEDGKHEFCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private SFXAudioSource FMGLIOHONBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private SFXAudioSource DINPFIHDHPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private ContentLoadingAudioPaletteAsset PAPPCMEPGDH;

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private const float GEKAFBILMMO = 0.001f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private MCKJLIAMDEP DFIOPFFHOOJ;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public Palette MIGOLKOLMAL
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x41E0FD0", Offset = "0x41DFFD0", VA = "0x1841E0FD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public bool NIIPDAAPHGO
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x90AA90", Offset = "0x909A90", VA = "0x18090AA90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public float PEMICNGCEPC
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x41E0E00", Offset = "0x41DFE00", VA = "0x1841E0E00")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		private bool AKOBNEFOFPE
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x41E02A0", Offset = "0x41DF2A0", VA = "0x1841E02A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		private bool DJKPKILDDNF
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x41E0A00", Offset = "0x41DFA00", VA = "0x1841E0A00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x41DFA70", Offset = "0x41DEA70", VA = "0x1841DFA70")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x41DFF00", Offset = "0x41DEF00", VA = "0x1841DFF00")]
		private void ELHOFKGDKKL(IHFBFGNEHFM.JNHIKNFBFGK HNKBLHFFIII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x41E08D0", Offset = "0x41DF8D0", VA = "0x1841E08D0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x41E0790", Offset = "0x41DF790", VA = "0x1841E0790")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x41DFF40", Offset = "0x41DEF40", VA = "0x1841DFF40")]
		private void FOBFDOJDNIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x41DF940", Offset = "0x41DE940", VA = "0x1841DF940")]
		public void AddLoadingSFXRequest(object FFKJLIDBALM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x41E0BE0", Offset = "0x41DFBE0", VA = "0x1841E0BE0")]
		public void RemoveLoadingSFXRequest(object FFKJLIDBALM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x41E0790", Offset = "0x41DF790", VA = "0x1841E0790")]
		private void NABCPCENOJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x41DFCF0", Offset = "0x41DECF0", VA = "0x1841DFCF0")]
		private void DJBHIHPCGME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x41E0120", Offset = "0x41DF120", VA = "0x1841E0120")]
		private void GEFBLKMEHKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x41E0330", Offset = "0x41DF330", VA = "0x1841E0330")]
		private void LFDJBMHCDIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x41E0430", Offset = "0x41DF430", VA = "0x1841E0430")]
		private void MCINPKKOOFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x41E06A0", Offset = "0x41DF6A0", VA = "0x1841E06A0")]
		private void MIHAMLKKILF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x41DFF30", Offset = "0x41DEF30", VA = "0x1841DFF30")]
		private void FBHOHCEOBKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x41DFC00", Offset = "0x41DEC00", VA = "0x1841DFC00")]
		private void CBLFOOKLPNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x41E0260", Offset = "0x41DF260", VA = "0x1841E0260")]
		private void IIIPIJKKCIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x41E0A10", Offset = "0x41DFA10", VA = "0x1841E0A10")]
		public void Play2DUIFlavorSFX(RecRoomAudioClip[] MJNIEMAJHAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x41E0D00", Offset = "0x41DFD00", VA = "0x1841E0D00")]
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
		private EGCJFLCKHHL depth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		[SerializeField]
		private bool animateOnEnable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[SerializeField]
		[OKAEPIMCOGM("animateOnEnable")]
		private float animationTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private Vector3? MCMIGAIEJHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private Vector2 PACNGLBHDBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private Vector2 DHJCHLAKDKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private Vector2 DIMICFNKHDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private Vector2 OABHJEDHPKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private Vector2 POPFNGNHADD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private Vector2 KIEBJNAHACO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private readonly bool? IHBALHDKAIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private HGICABGNOPK JHMKEHJFPOO;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		private RectTransform DKHKOPDHLAG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x41DAB70", Offset = "0x41D9B70", VA = "0x1841DAB70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public EGCJFLCKHHL KOBPEDOFKAD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xBB0410", Offset = "0xBAF410", VA = "0x180BB0410")]
			get
			{
				return default(EGCJFLCKHHL);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x41DB930", Offset = "0x41DA930", VA = "0x1841DB930")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		private HGICABGNOPK NLGDEHHEPJC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x41DB270", Offset = "0x41DA270", VA = "0x1841DB270")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		private bool MFJACDNEPNL
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x41DB2E0", Offset = "0x41DA2E0", VA = "0x1841DB2E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x41DB7A0", Offset = "0x41DA7A0", VA = "0x1841DB7A0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x41DB6F0", Offset = "0x41DA6F0", VA = "0x1841DB6F0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x41DABD0", Offset = "0x41D9BD0", VA = "0x1841DABD0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x41DB3D0", Offset = "0x41DA3D0", VA = "0x1841DB3D0")]
		private void LLEBBJIFEDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x41DAEF0", Offset = "0x41D9EF0", VA = "0x1841DAEF0")]
		private Vector3 BDGIFFHGLEA()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x41DB810", Offset = "0x41DA810", VA = "0x1841DB810")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD9BB0", Offset = "0xCD8BB0", VA = "0x180CD9BB0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x129D6F0", Offset = "0x129C6F0", VA = "0x18129D6F0")]
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
			private GJIHAGDNPGK paletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			[SerializeField]
			private Color color;

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			public GJIHAGDNPGK RawImageColorPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x60000D1")]
				[Cpp2IlInjected.Address(RVA = "0x85E1A0", Offset = "0x85D1A0", VA = "0x18085E1A0")]
				get
				{
					return default(GJIHAGDNPGK);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			public Color Color
			{
				[Cpp2IlInjected.Token(Token = "0x60000D2")]
				[Cpp2IlInjected.Address(RVA = "0xF72F20", Offset = "0xF71F20", VA = "0x180F72F20")]
				get
				{
					return default(Color);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x41E23D0", Offset = "0x41E13D0", VA = "0x1841E23D0")]
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
			private HEHNKLCDKJO backgroundColorPaletteType;

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
			public HEHNKLCDKJO BackgroundColorPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x60000D4")]
				[Cpp2IlInjected.Address(RVA = "0x85E1A0", Offset = "0x85D1A0", VA = "0x18085E1A0")]
				get
				{
					return default(HEHNKLCDKJO);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000046")]
			public Color Color
			{
				[Cpp2IlInjected.Token(Token = "0x60000D5")]
				[Cpp2IlInjected.Address(RVA = "0xF72F20", Offset = "0xF71F20", VA = "0x180F72F20")]
				get
				{
					return default(Color);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000047")]
			public Gradient Gradient
			{
				[Cpp2IlInjected.Token(Token = "0x60000D6")]
				[Cpp2IlInjected.Address(RVA = "0x9132D0", Offset = "0x9122D0", VA = "0x1809132D0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000048")]
			public bool RaycastTarget
			{
				[Cpp2IlInjected.Token(Token = "0x60000D7")]
				[Cpp2IlInjected.Address(RVA = "0x90AA90", Offset = "0x909A90", VA = "0x18090AA90")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x41D8B20", Offset = "0x41D7B20", VA = "0x1841D8B20")]
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
			private HDGICDMOIDH foregroundColorPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			[SerializeField]
			private Color color;

			[Cpp2IlInjected.Token(Token = "0x17000049")]
			public HDGICDMOIDH ForegroundColorPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x60000D9")]
				[Cpp2IlInjected.Address(RVA = "0x85E1A0", Offset = "0x85D1A0", VA = "0x18085E1A0")]
				get
				{
					return default(HDGICDMOIDH);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004A")]
			public Color Color
			{
				[Cpp2IlInjected.Token(Token = "0x60000DA")]
				[Cpp2IlInjected.Address(RVA = "0xF72F20", Offset = "0xF71F20", VA = "0x180F72F20")]
				get
				{
					return default(Color);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x41DCA80", Offset = "0x41DBA80", VA = "0x1841DCA80")]
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
			private OELNJINEOOB tilerPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			[SerializeField]
			private TilerPalette tilerPalette;

			[Cpp2IlInjected.Token(Token = "0x1700004B")]
			public OELNJINEOOB TilerPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x60000DC")]
				[Cpp2IlInjected.Address(RVA = "0x85E1A0", Offset = "0x85D1A0", VA = "0x18085E1A0")]
				get
				{
					return default(OELNJINEOOB);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004C")]
			public TilerPalette TilerPalette
			{
				[Cpp2IlInjected.Token(Token = "0x60000DD")]
				[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x129D6F0", Offset = "0x129C6F0", VA = "0x18129D6F0")]
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
			private KNPCIAEEDKP textStylePaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			[SerializeField]
			private TextStylePalette textStylePalette;

			[Cpp2IlInjected.Token(Token = "0x1700004D")]
			public KNPCIAEEDKP TextStylePaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x60000DF")]
				[Cpp2IlInjected.Address(RVA = "0x85E1A0", Offset = "0x85D1A0", VA = "0x18085E1A0")]
				get
				{
					return default(KNPCIAEEDKP);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004E")]
			public TextStylePalette TextStylePalette
			{
				[Cpp2IlInjected.Token(Token = "0x60000E0")]
				[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0xF60EC0", Offset = "0xF5FEC0", VA = "0x180F60EC0")]
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
			private FLHGGLODJFH textSizePaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			[SerializeField]
			private int size;

			[Cpp2IlInjected.Token(Token = "0x1700004F")]
			public FLHGGLODJFH TextSizePaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x60000E2")]
				[Cpp2IlInjected.Address(RVA = "0x85E1A0", Offset = "0x85D1A0", VA = "0x18085E1A0")]
				get
				{
					return default(FLHGGLODJFH);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000050")]
			public int Size
			{
				[Cpp2IlInjected.Token(Token = "0x60000E3")]
				[Cpp2IlInjected.Address(RVA = "0x91B190", Offset = "0x91A190", VA = "0x18091B190")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x41E7290", Offset = "0x41E6290", VA = "0x1841E7290")]
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
			private AMMDAPBKDLH buttonPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			[SerializeField]
			private ButtonPalette buttonPalette;

			[Cpp2IlInjected.Token(Token = "0x17000051")]
			public AMMDAPBKDLH ButtonPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x60000E5")]
				[Cpp2IlInjected.Address(RVA = "0x85E1A0", Offset = "0x85D1A0", VA = "0x18085E1A0")]
				get
				{
					return default(AMMDAPBKDLH);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000052")]
			public ButtonPalette ButtonPalette
			{
				[Cpp2IlInjected.Token(Token = "0x60000E6")]
				[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xF60EC0", Offset = "0xF5FEC0", VA = "0x180F60EC0")]
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
			private OFABGJHFNDK togglePaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			[SerializeField]
			private TogglePalette togglePalette;

			[Cpp2IlInjected.Token(Token = "0x17000053")]
			public OFABGJHFNDK TogglePaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x60000E8")]
				[Cpp2IlInjected.Address(RVA = "0x85E1A0", Offset = "0x85D1A0", VA = "0x18085E1A0")]
				get
				{
					return default(OFABGJHFNDK);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000054")]
			public TogglePalette TogglePalette
			{
				[Cpp2IlInjected.Token(Token = "0x60000E9")]
				[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0xF60EC0", Offset = "0xF5FEC0", VA = "0x180F60EC0")]
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
			private HLOFMJBHFMC mixedTogglePaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			[SerializeField]
			private MixedTogglePalette mixedTogglePalette;

			[Cpp2IlInjected.Token(Token = "0x17000055")]
			public HLOFMJBHFMC MixedTogglePaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x60000EB")]
				[Cpp2IlInjected.Address(RVA = "0x85E1A0", Offset = "0x85D1A0", VA = "0x18085E1A0")]
				get
				{
					return default(HLOFMJBHFMC);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000056")]
			public MixedTogglePalette MixedTogglePalette
			{
				[Cpp2IlInjected.Token(Token = "0x60000EC")]
				[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xF60EC0", Offset = "0xF5FEC0", VA = "0x180F60EC0")]
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
			private DEGDPNNFILM makerPenToolPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			[SerializeField]
			private MakerPenToolPalette makerPenToolPalette;

			[Cpp2IlInjected.Token(Token = "0x17000057")]
			public DEGDPNNFILM MakerPenToolPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x60000EE")]
				[Cpp2IlInjected.Address(RVA = "0x85E1A0", Offset = "0x85D1A0", VA = "0x18085E1A0")]
				get
				{
					return default(DEGDPNNFILM);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000058")]
			public MakerPenToolPalette MakerPenToolPalette
			{
				[Cpp2IlInjected.Token(Token = "0x60000EF")]
				[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0xF60EC0", Offset = "0xF5FEC0", VA = "0x180F60EC0")]
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
			private PDMDBFEJPDB inputFieldPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			[SerializeField]
			private InputFieldPalette inputFieldPalette;

			[Cpp2IlInjected.Token(Token = "0x17000059")]
			public PDMDBFEJPDB InputFieldPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x60000F1")]
				[Cpp2IlInjected.Address(RVA = "0x85E1A0", Offset = "0x85D1A0", VA = "0x18085E1A0")]
				get
				{
					return default(PDMDBFEJPDB);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005A")]
			public InputFieldPalette InputFieldPalette
			{
				[Cpp2IlInjected.Token(Token = "0x60000F2")]
				[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0xF60EC0", Offset = "0xF5FEC0", VA = "0x180F60EC0")]
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
			private GBHBCJHFFPI dropdownPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			[SerializeField]
			private DropdownPalette dropdownPalette;

			[Cpp2IlInjected.Token(Token = "0x1700005B")]
			public GBHBCJHFFPI DropdownPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0x85E1A0", Offset = "0x85D1A0", VA = "0x18085E1A0")]
				get
				{
					return default(GBHBCJHFFPI);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005C")]
			public DropdownPalette DropdownPalette
			{
				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0xF60EC0", Offset = "0xF5FEC0", VA = "0x180F60EC0")]
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
			private LGNKAJNOCMB sliderPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			[SerializeField]
			private SliderPalette sliderPalette;

			[Cpp2IlInjected.Token(Token = "0x1700005D")]
			public LGNKAJNOCMB SliderPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x60000F7")]
				[Cpp2IlInjected.Address(RVA = "0x85E1A0", Offset = "0x85D1A0", VA = "0x18085E1A0")]
				get
				{
					return default(LGNKAJNOCMB);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005E")]
			public SliderPalette SliderPalette
			{
				[Cpp2IlInjected.Token(Token = "0x60000F8")]
				[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0xF60EC0", Offset = "0xF5FEC0", VA = "0x180F60EC0")]
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
			private EGCJFLCKHHL depthPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			[SerializeField]
			private DepthPalette depthPalette;

			[Cpp2IlInjected.Token(Token = "0x1700005F")]
			public EGCJFLCKHHL DepthPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x60000FA")]
				[Cpp2IlInjected.Address(RVA = "0x85E1A0", Offset = "0x85D1A0", VA = "0x18085E1A0")]
				get
				{
					return default(EGCJFLCKHHL);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000060")]
			public DepthPalette DepthPalette
			{
				[Cpp2IlInjected.Token(Token = "0x60000FB")]
				[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xF60EC0", Offset = "0xF5FEC0", VA = "0x180F60EC0")]
			public DepthPaletteItem()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[CompilerGenerated]
		private sealed class GBAPOEKKJEH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public GJIHAGDNPGK backgroundColorPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
			public GBAPOEKKJEH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0xD47730", Offset = "0xD46730", VA = "0x180D47730")]
			internal bool FLFDEJHANEL(RawImageColorPaletteItem pi)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		[CompilerGenerated]
		private sealed class PBHIHCPFNOL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public HEHNKLCDKJO backgroundColorPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
			public PBHIHCPFNOL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0xD47730", Offset = "0xD46730", VA = "0x180D47730")]
			internal bool JBCDOIDGGCB(BackgroundColorPaletteItem backgroundColorPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000039")]
		[CompilerGenerated]
		private sealed class NLGMLNAJBKO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public HDGICDMOIDH foregroundColorPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
			public NLGMLNAJBKO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0xD47730", Offset = "0xD46730", VA = "0x180D47730")]
			internal bool ILECEPDDGKH(ForegroundColorPaletteItem colorPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		[CompilerGenerated]
		private sealed class ONPPOFOPGAB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public OELNJINEOOB type;

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
			public ONPPOFOPGAB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0xD47730", Offset = "0xD46730", VA = "0x180D47730")]
			internal bool GJCNIEKJBKP(TilerPaletteItem tilerPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		[CompilerGenerated]
		private sealed class DMHEPIKDFHD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public KNPCIAEEDKP textStylePaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
			public DMHEPIKDFHD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0xD47730", Offset = "0xD46730", VA = "0x180D47730")]
			internal bool NAGGPILIDDO(TextStylePaletteItem textStylePaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		[CompilerGenerated]
		private sealed class JJNMKGDAOMA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public FLHGGLODJFH textSizePaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
			public JJNMKGDAOMA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0xD47730", Offset = "0xD46730", VA = "0x180D47730")]
			internal bool KKOEHBHDDJA(TextSizePaletteItem textSizePaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003D")]
		[CompilerGenerated]
		private sealed class LKDEMCJDBDO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public AMMDAPBKDLH buttonPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
			public LKDEMCJDBDO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0xD47730", Offset = "0xD46730", VA = "0x180D47730")]
			internal bool JAJPEAJHLPM(ButtonPaletteItem buttonPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		[CompilerGenerated]
		private sealed class BNEBNHEPOFK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public OFABGJHFNDK togglePaletteType;

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
			public BNEBNHEPOFK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0xD47730", Offset = "0xD46730", VA = "0x180D47730")]
			internal bool CFAJDBHMMHN(TogglePaletteItem togglePaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		[CompilerGenerated]
		private sealed class JMKNEGIEJKK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public HLOFMJBHFMC mixedTogglePaletteType;

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
			public JMKNEGIEJKK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0xD47730", Offset = "0xD46730", VA = "0x180D47730")]
			internal bool DHDKILBGFGG(MixedTogglePaletteItem mixedTogglePaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		[CompilerGenerated]
		private sealed class JBGICKIHKPA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public DEGDPNNFILM makerPenToolPaletteType;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
			public JBGICKIHKPA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0xD47730", Offset = "0xD46730", VA = "0x180D47730")]
			internal bool ALJPLPHDBLK(MakerPenToolPaletteItem makerPenToolPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[CompilerGenerated]
		private sealed class LDHNNDNPKOH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			public PDMDBFEJPDB inputFieldPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
			public LDHNNDNPKOH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0xD47730", Offset = "0xD46730", VA = "0x180D47730")]
			internal bool AKDNJBLFBDN(InputFieldPaletteItem inputFieldPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		[CompilerGenerated]
		private sealed class CBFGLIADFMH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public GBHBCJHFFPI dropdownPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
			public CBFGLIADFMH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0xD47730", Offset = "0xD46730", VA = "0x180D47730")]
			internal bool NKLEEIGDLNC(DropdownPaletteItem dropdownPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000043")]
		[CompilerGenerated]
		private sealed class OJAIIMCHCJK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public LGNKAJNOCMB sliderPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
			public OJAIIMCHCJK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xD47730", Offset = "0xD46730", VA = "0x180D47730")]
			internal bool LONAIGEDIDE(SliderPaletteItem sliderPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		[CompilerGenerated]
		private sealed class KBAEPBLPBPL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			public EGCJFLCKHHL depthPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
			public KBAEPBLPBPL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0xD47730", Offset = "0xD46730", VA = "0x180D47730")]
			internal bool KLLMHOHNOLM(DepthPaletteItem depthPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[SerializeField]
		[Header("Visual")]
		[KMAOMNHIIAF("RawImageColorPaletteType")]
		private RawImageColorPaletteItem[] rawImageColorPaletteItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[SerializeField]
		[KMAOMNHIIAF("BackgroundColorPaletteType")]
		private BackgroundColorPaletteItem[] backgroundColorPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[SerializeField]
		[KMAOMNHIIAF("ForegroundColorPaletteType")]
		private ForegroundColorPaletteItem[] foregroundColorPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[SerializeField]
		[KMAOMNHIIAF("TilerPaletteType")]
		private TilerPaletteItem[] tilerPaletteItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		[SerializeField]
		[KMAOMNHIIAF("TextStylePaletteType")]
		private TextStylePaletteItem[] textStylePalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		[SerializeField]
		[KMAOMNHIIAF("TextSizePaletteType")]
		private TextSizePaletteItem[] textSizePalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		[SerializeField]
		[KMAOMNHIIAF("ButtonPaletteType")]
		private ButtonPaletteItem[] buttonPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		[SerializeField]
		[KMAOMNHIIAF("TogglePaletteType")]
		private TogglePaletteItem[] togglePalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		[SerializeField]
		[KMAOMNHIIAF("MixedTogglePaletteType")]
		private MixedTogglePaletteItem[] mixedTogglePalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		[SerializeField]
		[KMAOMNHIIAF("MakerPenToolPaletteType")]
		private MakerPenToolPaletteItem[] makerPenToolPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		[SerializeField]
		[KMAOMNHIIAF("InputFieldPaletteType")]
		private InputFieldPaletteItem[] inputFieldPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		[SerializeField]
		[KMAOMNHIIAF("DropdownPaletteType")]
		private DropdownPaletteItem[] dropdownPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		[SerializeField]
		[KMAOMNHIIAF("SliderPaletteType")]
		private SliderPaletteItem[] sliderPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		[SerializeField]
		[KMAOMNHIIAF("DepthPaletteType")]
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
			[Cpp2IlInjected.Address(RVA = "0x9B3910", Offset = "0x9B2910", VA = "0x1809B3910")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public ButtonAnimationPalette ButtonAnimationPalette
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x9AD920", Offset = "0x9AC920", VA = "0x1809AD920")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public AudioPalette AudioPalette
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0xAAC140", Offset = "0xAAB140", VA = "0x180AAC140")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x41E16F0", Offset = "0x41E06F0", VA = "0x1841E16F0")]
		public Color HPOHAJPGACJ(GJIHAGDNPGK HPJNGLMDLNO)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x41E1480", Offset = "0x41E0480", VA = "0x1841E1480")]
		public void CMIOHGHAMPE(HEHNKLCDKJO HPJNGLMDLNO, out Color IFAEOGGHLKI, out Gradient NHFFCJNBHIL, out bool LLCBCJNDJKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x41E1DA0", Offset = "0x41E0DA0", VA = "0x1841E1DA0")]
		public Color PBKOINKFHIO(HDGICDMOIDH MCDMFLEKNCA)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x41E1CB0", Offset = "0x41E0CB0", VA = "0x1841E1CB0")]
		public TilerPalette OCNNELGJOJF(OELNJINEOOB DPPJBLOOGOO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x41E1390", Offset = "0x41E0390", VA = "0x1841E1390")]
		public TextStylePalette CDEGACOJENI(KNPCIAEEDKP CLHHMKDMEBF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x41E19E0", Offset = "0x41E09E0", VA = "0x1841E19E0")]
		public int MFJNJBJFEHO(FLHGGLODJFH EACIJJHCKKF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x41E1080", Offset = "0x41E0080", VA = "0x1841E1080")]
		public ButtonPalette ADCIONBOCPM(AMMDAPBKDLH KPFHNDBAJHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x41E1BC0", Offset = "0x41E0BC0", VA = "0x1841E1BC0")]
		public TogglePalette NCJDPKBGCCA(OFABGJHFNDK FFHELNJDIHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x41E1170", Offset = "0x41E0170", VA = "0x1841E1170")]
		public MixedTogglePalette AIFDIEJHADC(HLOFMJBHFMC MCFDIGGECPH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x41E1AD0", Offset = "0x41E0AD0", VA = "0x1841E1AD0")]
		public MakerPenToolPalette MKCEKDLNKNC(DEGDPNNFILM DCHBFKEKKBE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x41E18F0", Offset = "0x41E08F0", VA = "0x1841E18F0")]
		public InputFieldPalette LFCLLBKCBHC(PDMDBFEJPDB HMNBKFCMLEB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x41E1800", Offset = "0x41E0800", VA = "0x1841E1800")]
		public DropdownPalette INIJNCNEGKG(GBHBCJHFFPI PFOJHCCLOKL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x41E1600", Offset = "0x41E0600", VA = "0x1841E1600")]
		public SliderPalette DDLFFJFLLEC(LGNKAJNOCMB IBCMNOFFKCF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x41E1260", Offset = "0x41E0260", VA = "0x1841E1260")]
		public float? BMFGBDFELED(EGCJFLCKHHL ELGLBKPOFKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x41E1EB0", Offset = "0x41E0EB0", VA = "0x1841E1EB0")]
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
		[JHDFHPMJCIE(KDNNMHJGNJH.Self, false, false, false)]
		private KJDGKOFOKAK recyclingGrid;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x41E2650", Offset = "0x41E1650", VA = "0x1841E2650", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x41E2860", Offset = "0x41E1860", VA = "0x1841E2860", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x41E25E0", Offset = "0x41E15E0", VA = "0x1841E25E0")]
		private void ANLLGDPKJAI(float JOIJOKCLCBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x41E2A70", Offset = "0x41E1A70", VA = "0x1841E2A70")]
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
		private CPJKCOOEGDP audioPalette;

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public Color BackgroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0xA76DE0", Offset = "0xA75DE0", VA = "0x180A76DE0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public ColorBlock BackgroundTints
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x41D9000", Offset = "0x41D8000", VA = "0x1841D9000")]
			get
			{
				return default(ColorBlock);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public GradientBlock BackgroundGradients
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x41D8FD0", Offset = "0x41D7FD0", VA = "0x1841D8FD0")]
			get
			{
				return default(GradientBlock);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public Color ForegroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x2EF3900", Offset = "0x2EF2900", VA = "0x182EF3900")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public ColorBlock ForegroundTints
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x41D9040", Offset = "0x41D8040", VA = "0x1841D9040")]
			get
			{
				return default(ColorBlock);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public bool ShowBorder
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xAD13D0", Offset = "0xAD03D0", VA = "0x180AD13D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public TextStylePalette TextPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x10537C0", Offset = "0x10527C0", VA = "0x1810537C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public CPJKCOOEGDP AudioPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0xFEE4C0", Offset = "0xFED4C0", VA = "0x180FEE4C0")]
			get
			{
				return default(CPJKCOOEGDP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x41D8ED0", Offset = "0x41D7ED0", VA = "0x1841D8ED0")]
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
		[JHDFHPMJCIE(KDNNMHJGNJH.Self, false, false, false)]
		private Graphic graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		[SerializeField]
		private bool useGraphicOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		[SerializeField]
		[OKAEPIMCOGM("useGraphicOverride")]
		private Graphic graphicOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		[SerializeField]
		private HDGICDMOIDH color;

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public Graphic IGGMCFMDADK
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x41DD0B0", Offset = "0x41DC0B0", VA = "0x1841DD0B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public HDGICDMOIDH DMENFELIEED
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0xC34FE0", Offset = "0xC33FE0", VA = "0x180C34FE0")]
			get
			{
				return default(HDGICDMOIDH);
			}
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x41DD0C0", Offset = "0x41DC0C0", VA = "0x1841DD0C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public bool OGMHLOKCPDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0xDFA0E0", Offset = "0xDF90E0", VA = "0x180DFA0E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0xDFA710", Offset = "0xDF9710", VA = "0x180DFA710")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Color? PBNGLPPGBCA
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x41DCFF0", Offset = "0x41DBFF0", VA = "0x1841DCFF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x41DCD10", Offset = "0x41DBD10", VA = "0x1841DCD10", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x41DCF90", Offset = "0x41DBF90", VA = "0x1841DCF90")]
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
		[JHDFHPMJCIE(KDNNMHJGNJH.Self, false, false, false)]
		private RawImage image;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		[SerializeField]
		private GJIHAGDNPGK color;

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public GJIHAGDNPGK HFHAJJIALPG
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x9B5030", Offset = "0x9B4030", VA = "0x1809B5030")]
			get
			{
				return default(GJIHAGDNPGK);
			}
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x41E23B0", Offset = "0x41E13B0", VA = "0x1841E23B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x41E2410", Offset = "0x41E1410", VA = "0x1841E2410", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x41E2550", Offset = "0x41E1550", VA = "0x1841E2550")]
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
			[Cpp2IlInjected.Address(RVA = "0x85E070", Offset = "0x85D070", VA = "0x18085E070")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xA24460", Offset = "0xA23460", VA = "0x180A24460")]
		public MakerPenToolPalette()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public class TextStylePalette
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public enum OOBAFNCMLBN
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
		private OOBAFNCMLBN transformation;

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public TMP_FontAsset Font
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x85E070", Offset = "0x85D070", VA = "0x18085E070")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public Material FontOverrideMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public float Kerning
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0xFF9AE0", Offset = "0xFF8AE0", VA = "0x180FF9AE0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public float Leading
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0xF04D70", Offset = "0xF03D70", VA = "0x180F04D70")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public bool IsBold
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x967710", Offset = "0x966710", VA = "0x180967710")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public bool IsItalic
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0xC040A0", Offset = "0xC030A0", VA = "0x180C040A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public OOBAFNCMLBN Transformation
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0xE30DE0", Offset = "0xE2FDE0", VA = "0x180E30DE0")]
			get
			{
				return default(OOBAFNCMLBN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x41E72A0", Offset = "0x41E62A0", VA = "0x1841E72A0")]
		public void PNGLIPKHLDF(TextMeshProUGUI NPNDOMHDACM, bool PFOKLGONHDD = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x41E75D0", Offset = "0x41E65D0", VA = "0x1841E75D0")]
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
		private OFABGJHFNDK toggleType;

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
		[OKAEPIMCOGM("overrideAudioPaletteWhenActive")]
		private ButtonAudioPaletteAsset customButtonAudioConfigWhenActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		[SerializeField]
		[Tooltip("Override the audio palette when inactive defined by the toggle's visual with a custom palette")]
		private bool overrideAudioPaletteWhenInactive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		[SerializeField]
		[OKAEPIMCOGM("overrideAudioPaletteWhenInactive")]
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
		[OKAEPIMCOGM("useFlavorSFX")]
		[Tooltip("Flavor SFX is picked randomly from this pool config")]
		private RecRoomAudioClipPoolConfig flavorSFXClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		protected bool EGOANCHGGFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x161")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private bool MNOIMMAPFAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x162")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private bool PLFLMBMOIGI;

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public bool DFBOGFJEIOP
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x41E8380", Offset = "0x41E7380", VA = "0x1841E8380")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x41E8390", Offset = "0x41E7390", VA = "0x1841E8390")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public OFABGJHFNDK KNFGHECMGNE
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0xFEE4C0", Offset = "0xFED4C0", VA = "0x180FEE4C0")]
			get
			{
				return default(OFABGJHFNDK);
			}
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x41DAAE0", Offset = "0x41D9AE0", VA = "0x1841DAAE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		protected override bool NFPLMMIODBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x41E8250", Offset = "0x41E7250", VA = "0x1841E8250", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x41E8210", Offset = "0x41E7210", VA = "0x1841E8210", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x41E8260", Offset = "0x41E7260", VA = "0x1841E8260")]
		public void Toggle()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x41E82A0", Offset = "0x41E72A0", VA = "0x1841E82A0")]
		public void Toggle(bool PLFLMBMOIGI, bool EGOANCHGGFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x41E7E10", Offset = "0x41E6E10", VA = "0x1841E7E10", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x41E82E0", Offset = "0x41E72E0", VA = "0x1841E82E0")]
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
		[OFFACMCMMNI(KDNNMHJGNJH.SelfAndParent, true, false, false)]
		private PaletteTheme paletteTheme;

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		protected PaletteTheme HLLFNEAKPPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		protected Palette MIGOLKOLMAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x41DF7E0", Offset = "0x41DE7E0", VA = "0x1841DF7E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		protected bool DKMLGECJGOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x41DF8A0", Offset = "0x41DE8A0", VA = "0x1841DF8A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		protected Transform LKEIFEDILAA
		{
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x41DF0D0", Offset = "0x41DE0D0", VA = "0x1841DF0D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x41DEFC0", Offset = "0x41DDFC0", VA = "0x1841DEFC0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x41DF6F0", Offset = "0x41DE6F0", VA = "0x1841DF6F0", Slot = "5")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void Apply();

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x41DF160", Offset = "0x41DE160", VA = "0x1841DF160")]
		public Color? GetColorFromPalette(HDGICDMOIDH IFHANFMFOFO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x41DF340", Offset = "0x41DE340", VA = "0x1841DF340")]
		private void LCHOEEFFDHC(bool MIBENFLFPNJ = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x868710", Offset = "0x867710", VA = "0x180868710")]
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
		[JHDFHPMJCIE(KDNNMHJGNJH.Self, false, false, false)]
		private TMP_InputField inputField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		[SerializeField]
		[OFFACMCMMNI(KDNNMHJGNJH.Self, false, false, false)]
		private Image surface;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		[SerializeField]
		private bool useSurfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		[SerializeField]
		[OKAEPIMCOGM("useSurfaceOverride")]
		private Image surfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		[SerializeField]
		private PDMDBFEJPDB inputFieldType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		[SerializeField]
		private FLHGGLODJFH textSize;

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public Image AHAADOKBKDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x41DC0B0", Offset = "0x41DB0B0", VA = "0x1841DC0B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public PDMDBFEJPDB PDKPMLBFKHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x871180", Offset = "0x870180", VA = "0x180871180")]
			get
			{
				return default(PDMDBFEJPDB);
			}
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x41DC0C0", Offset = "0x41DB0C0", VA = "0x1841DC0C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public FLHGGLODJFH NJIJMHFFHKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x871160", Offset = "0x870160", VA = "0x180871160")]
			get
			{
				return default(FLHGGLODJFH);
			}
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x41DC0E0", Offset = "0x41DB0E0", VA = "0x1841DC0E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x41DD150", Offset = "0x41DC150", VA = "0x1841DD150", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x41DC040", Offset = "0x41DB040", VA = "0x1841DC040")]
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
		[JHDFHPMJCIE(KDNNMHJGNJH.Self, false, false, false)]
		private RangeSlider slider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		[SerializeField]
		private LGNKAJNOCMB sliderType;

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
		public LGNKAJNOCMB FHLHCKFIMLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x9B5030", Offset = "0x9B4030", VA = "0x1809B5030")]
			get
			{
				return default(LGNKAJNOCMB);
			}
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x41E23B0", Offset = "0x41E13B0", VA = "0x1841E23B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public Image KHEEADDOAHM
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x9132C0", Offset = "0x9122C0", VA = "0x1809132C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public Image FFHJAKKGPMB
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x871190", Offset = "0x870190", VA = "0x180871190")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public Image JEHOFBNHNJK
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x914C50", Offset = "0x913C50", VA = "0x180914C50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public Image AIOBEECEFMI
		{
			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x97E5E0", Offset = "0x97D5E0", VA = "0x18097E5E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public bool OGNIHMMBFPA
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x41E2370", Offset = "0x41E1370", VA = "0x1841E2370")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x41E2390", Offset = "0x41E1390", VA = "0x1841E2390")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x41E1FB0", Offset = "0x41E0FB0", VA = "0x1841E1FB0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x41E22F0", Offset = "0x41E12F0", VA = "0x1841E22F0")]
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
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0xA76DE0", Offset = "0xA75DE0", VA = "0x180A76DE0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public Color ForegroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0xA76DF0", Offset = "0xA75DF0", VA = "0x180A76DF0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public TextStylePalette TextPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x9132C0", Offset = "0x9122C0", VA = "0x1809132C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x41DB950", Offset = "0x41DA950", VA = "0x1841DB950")]
		public DropdownPalette()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public class MixedToggleTheme : ButtonThemeBase
	{
		[Cpp2IlInjected.Token(Token = "0x2000052")]
		public enum ODJPIBFIGJG
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
		private HLOFMJBHFMC toggleType;

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
		private ODJPIBFIGJG editorIsActiveOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private ODJPIBFIGJG PLFLMBMOIGI;

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public ODJPIBFIGJG DFBOGFJEIOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x1D32980", Offset = "0x1D31980", VA = "0x181D32980")]
			get
			{
				return default(ODJPIBFIGJG);
			}
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x41DE760", Offset = "0x41DD760", VA = "0x1841DE760")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x41DE780", Offset = "0x41DD780", VA = "0x1841DE780")]
		public void Toggle()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x41DE760", Offset = "0x41DD760", VA = "0x1841DE760")]
		public void Toggle(ODJPIBFIGJG PLFLMBMOIGI, bool EGOANCHGGFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x41DE1C0", Offset = "0x41DD1C0", VA = "0x1841DE1C0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x41DE7B0", Offset = "0x41DD7B0", VA = "0x1841DE7B0")]
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
		[JHDFHPMJCIE(KDNNMHJGNJH.Self, false, false, false)]
		private UITiler tiler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		[SerializeField]
		private OELNJINEOOB type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private OJOMBGHCAAN MBBEADDAPBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private FEECNHJEKFM OJBHPMGIOGL;

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		private FEECNHJEKFM KAJIBBDDMMO
		{
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x41E7D50", Offset = "0x41E6D50", VA = "0x1841E7D50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		private LNOKNHEBCMM ODIAJLGNHBN
		{
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x41E7C70", Offset = "0x41E6C70", VA = "0x1841E7C70")]
			get
			{
				return default(LNOKNHEBCMM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x41E7C00", Offset = "0x41E6C00", VA = "0x1841E7C00", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x41E7860", Offset = "0x41E6860", VA = "0x1841E7860", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x41E7DC0", Offset = "0x41E6DC0", VA = "0x1841E7DC0")]
		public TilerTheme()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public enum HEHNKLCDKJO
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
public enum GJIHAGDNPGK
{
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	A
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public enum HDGICDMOIDH
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
public enum OELNJINEOOB
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
public enum KNPCIAEEDKP
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
public enum FLHGGLODJFH
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
public enum AMMDAPBKDLH
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
	NameTag,
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	RoomCurrency
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum OFABGJHFNDK
{
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	FlatOrange,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	FlatWhite,
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	InputToggle,
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	Chips,
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	Switch,
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	WhitePagingBlob,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	RSVPToggleHeaderSection,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	CardSelectableToggle,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	ChipsDark,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	MainNavToggle,
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	ListItem,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	NotiUnread,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	FlatPrimary,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	CharadePen,
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	ShareCam,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	CardSelectableToggleWithBacking,
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	SecondaryHeaderSectionToggle,
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	PrimaryToSecondaryHeader,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	NegativeToSecondaryHeader,
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	LimitedEventPrimary,
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	LimitedEventSecondary,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	RoomCardWithLimitedEvent,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	MainNavVrDetach,
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	HomeMainNav
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public enum HLOFMJBHFMC
{
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	Checkbox
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public enum DEGDPNNFILM
{
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	Create,
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	Select,
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	Wire,
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	Configure,
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	Transform,
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	Move,
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	Rotate,
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	Scale,
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	CloneFlip,
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	Recolor,
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	Freeze,
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	MakeInvention,
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	Manipulate,
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	Delete
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public enum PDMDBFEJPDB
{
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	LightFlat,
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	DarkFlat,
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	Modified
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public enum GBHBCJHFFPI
{
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	LightFlat,
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	DarkFlat
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public enum LGNKAJNOCMB
{
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	MirroUIPopUp
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public enum EGCJFLCKHHL
{
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	Base,
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	Button,
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	Navigation,
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	Overlay,
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	Dialog,
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	Toast
}
namespace RRUI.Theme
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public abstract class ButtonThemeBase : SelectableThemeBase
	{
		[Cpp2IlInjected.Token(Token = "0x2000063")]
		protected class ALLPEGJMKDP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001D4")]
			public ButtonAudioPaletteAsset DEPFKLJEEEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001D5")]
			public RecRoomAudioClipPoolConfig OEBBFJKDGLA;

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0xD0E190", Offset = "0xD0D190", VA = "0x180D0E190")]
			public ALLPEGJMKDP()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		[SerializeField]
		[Header("Button Theme Base")]
		[OFFACMCMMNI(KDNNMHJGNJH.Self, false, false, false)]
		private MultiGraphicButton multiGraphicButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		[SerializeField]
		[OFFACMCMMNI(KDNNMHJGNJH.Self, false, true, false)]
		private Image surface;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		[SerializeField]
		private bool useSurfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		[SerializeField]
		[OKAEPIMCOGM("useSurfaceOverride")]
		private Image surfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		[SerializeField]
		[ECEGGLIIJGM]
		private List<Graphic> graphics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		[SerializeField]
		private bool useGraphicsOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		[SerializeField]
		[OKAEPIMCOGM("useGraphicsOverride")]
		private List<Graphic> graphicsOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		[SerializeField]
		[OFFACMCMMNI(KDNNMHJGNJH.Self, false, true, false)]
		private UIGradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		[SerializeField]
		private bool useGradientOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		[SerializeField]
		[OKAEPIMCOGM("useGradientOverride")]
		private UIGradient gradientOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		[SerializeField]
		[OFFACMCMMNI(KDNNMHJGNJH.Children, true, true, false)]
		private TextMeshProUGUI textMeshProUGUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		[SerializeField]
		private bool useTextMeshProUGUIOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		[SerializeField]
		[OKAEPIMCOGM("useTextMeshProUGUIOverride")]
		private TextMeshProUGUI textMeshProUGUIOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		[SerializeField]
		private FLHGGLODJFH textSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		[SerializeField]
		protected Hideable borderHideable;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		[SerializeField]
		protected bool isAnimationEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		[SerializeField]
		[OKAEPIMCOGM("isAnimationEnabled")]
		protected bool overrideAnimationTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		[SerializeField]
		[OKAEPIMCOGM("overrideAnimationTarget")]
		protected GameObject animationTargetOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private bool PACEIBEOFOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private Vector3 IDGGEMEHMMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private Vector3 DIEBNNOMFFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		private KCLIDDHACMD DOKNJKOIBCN;

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public Image AHAADOKBKDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x41DA7B0", Offset = "0x41D97B0", VA = "0x1841DA7B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public List<Graphic> GKHAMOOBMEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x41DA790", Offset = "0x41D9790", VA = "0x1841DA790")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public UIGradient GMFGBJMHICE
		{
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x41DA770", Offset = "0x41D9770", VA = "0x1841DA770")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public TextMeshProUGUI PMAJAOHJBDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x41DA7D0", Offset = "0x41D97D0", VA = "0x1841DA7D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public FLHGGLODJFH NJIJMHFFHKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0xA77D90", Offset = "0xA76D90", VA = "0x180A77D90")]
			get
			{
				return default(FLHGGLODJFH);
			}
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x41DA7F0", Offset = "0x41D97F0", VA = "0x1841DA7F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		protected Transform PFOJHHGFNPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x41D9D10", Offset = "0x41D8D10", VA = "0x1841D9D10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		public Button NFJOPEAIILF
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x41DA6F0", Offset = "0x41D96F0", VA = "0x1841DA6F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x41D9DF0", Offset = "0x41D8DF0", VA = "0x1841D9DF0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x41D9D50", Offset = "0x41D8D50", VA = "0x1841D9D50")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x41D9090", Offset = "0x41D8090", VA = "0x1841D9090")]
		protected void BEONDKIAMMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x41D9210", Offset = "0x41D8210", VA = "0x1841D9210")]
		protected void DKNHILOOPML(ButtonPalette APFKLMAKBMC, [Optional] ALLPEGJMKDP NMOOOOCPBKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x41D9E70", Offset = "0x41D8E70", VA = "0x1841D9E70", Slot = "12")]
		public override void OnPointerDown(PointerEventData NKPHHCMFEAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x41DA240", Offset = "0x41D9240", VA = "0x1841DA240", Slot = "13")]
		public override void OnPointerUp(PointerEventData NKPHHCMFEAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x41D9E50", Offset = "0x41D8E50", VA = "0x1841D9E50", Slot = "14")]
		public override void OnPointerClick(PointerEventData NKPHHCMFEAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x41D9CF0", Offset = "0x41D8CF0", VA = "0x1841D9CF0")]
		private Vector3 IDBDPOHMPJG(float KFEAJPAHNFK)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x41DA570", Offset = "0x41D9570", VA = "0x1841DA570")]
		protected ButtonThemeBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x41D9CD0", Offset = "0x41D8CD0", VA = "0x1841D9CD0")]
		[CompilerGenerated]
		private void EDIKDDPDCON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x41D9CD0", Offset = "0x41D8CD0", VA = "0x1841D9CD0")]
		[CompilerGenerated]
		private void JGFOGLIGDPI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public class ContentLoadingAudioPaletteAsset : BaseAudioPaletteAsset
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		[SerializeField]
		[Header("Clip Configs")]
		private RecRoomAudioClipPoolConfig loadingSFXAudioClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		[SerializeField]
		[Tooltip("Only start looping loading SFX if any content has been loading for this much time")]
		[Header("Thresholds")]
		private float loadingSFXStartDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		[SerializeField]
		[Tooltip("Small delay between content finish loading and stopping loading SFX. Avoiding quick stop and replay if contents load back to back.")]
		private float loadingSFXStopDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		[SerializeField]
		[Tooltip("Cut loading SFX if content is still loading after this much time. Avoid sustaining SFX when content is hanging on loading.")]
		private float maxLoadingSFXLength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		[SerializeField]
		[Header("Smooth Fade")]
		private float fadeInDuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		[SerializeField]
		private float fadeOutDuration;

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		public float LoadingSFXStartDelay
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0xFF9AE0", Offset = "0xFF8AE0", VA = "0x180FF9AE0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		public float LoadingSFXStopDelay
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0xF04D70", Offset = "0xF03D70", VA = "0x180F04D70")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		public float MaxLoadingSFXLength
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x8650D0", Offset = "0x8640D0", VA = "0x1808650D0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		public float FadeInDuration
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x90AC00", Offset = "0x909C00", VA = "0x18090AC00")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		public float FadeOutDuration
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xA76E00", Offset = "0xA75E00", VA = "0x180A76E00")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x41DAB00", Offset = "0x41D9B00", VA = "0x1841DAB00")]
		public bool HMHFBIMEKDK(out RecRoomAudioClip[] HADJFDODBJB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x41DAB20", Offset = "0x41D9B20", VA = "0x1841DAB20")]
		public ContentLoadingAudioPaletteAsset()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class TogglePalette
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		[SerializeField]
		private ButtonPalette inactiveButtonPalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		[SerializeField]
		private ButtonPalette activeButtonPalette;

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		public ButtonPalette InactiveButtonPalette
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x85E070", Offset = "0x85D070", VA = "0x18085E070")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		public ButtonPalette ActiveButtonPalette
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xD0E190", Offset = "0xD0D190", VA = "0x180D0E190")]
		public TogglePalette()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class SliderPalette
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		[SerializeField]
		private Color sliderColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		[SerializeField]
		private Color fillColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		[SerializeField]
		private Color handleColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		[SerializeField]
		private TextStylePalette textPalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		[SerializeField]
		private Color textColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		[SerializeField]
		private ColorBlock colorBlock;

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		public Color SliderColor
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0xA76DE0", Offset = "0xA75DE0", VA = "0x180A76DE0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public Color FillColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0xA76DF0", Offset = "0xA75DF0", VA = "0x180A76DF0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public Color HandleColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0xBB9100", Offset = "0xBB8100", VA = "0x180BB9100")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public TextStylePalette TextPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x914C50", Offset = "0x913C50", VA = "0x180914C50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public Color TextColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0xC277C0", Offset = "0xC267C0", VA = "0x180C277C0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public ColorBlock ColorBlock
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x41E6770", Offset = "0x41E5770", VA = "0x1841E6770")]
			get
			{
				return default(ColorBlock);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x41E66A0", Offset = "0x41E56A0", VA = "0x1841E66A0")]
		public SliderPalette()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public class SliderTheme : SelectableThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		[SerializeField]
		[JHDFHPMJCIE(KDNNMHJGNJH.Self, false, false, false)]
		[Header("Slider Visual")]
		private Slider slider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		[SerializeField]
		private LGNKAJNOCMB sliderType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		[SerializeField]
		[Header("Slider Audio")]
		private CPJKCOOEGDP buttonAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		[SerializeField]
		[Tooltip("Layer a 2D SFX on top of base button sounds")]
		private bool useFlavorSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		[SerializeField]
		[OKAEPIMCOGM("useFlavorSFX")]
		[Tooltip("Flavor SFX is picked randomly from this pool config")]
		private RecRoomAudioClipPoolConfig flavorSFXClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		[SerializeField]
		private Image sliderImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		[SerializeField]
		private Image fillImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		[SerializeField]
		private Image handleImage;

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public LGNKAJNOCMB FHLHCKFIMLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0xBDDBE0", Offset = "0xBDCBE0", VA = "0x180BDDBE0")]
			get
			{
				return default(LGNKAJNOCMB);
			}
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x41E6C10", Offset = "0x41E5C10", VA = "0x1841E6C10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public Image KHEEADDOAHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x9AD920", Offset = "0x9AC920", VA = "0x1809AD920")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public Image FFHJAKKGPMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0xAAC140", Offset = "0xAAB140", VA = "0x180AAC140")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		public Image GINNJGLJKDJ
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x90F2C0", Offset = "0x90E2C0", VA = "0x18090F2C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x41E67B0", Offset = "0x41E57B0", VA = "0x1841E67B0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x41E6B90", Offset = "0x41E5B90", VA = "0x1841E6B90")]
		public SliderTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public class MakerPenToolTheme : ButtonThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		[SerializeField]
		[Header("Maker Pen Tool")]
		private DEGDPNNFILM makerPenToolPaletteType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		[SerializeField]
		[Tooltip("A list of objects to show while the maker pen tool is active.")]
		private List<Hideable> hideWhenNotActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		[SerializeField]
		[Tooltip("A list of objects to show while the maker pen tool is inactive")]
		private List<Hideable> hideWhenActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		[SerializeField]
		private bool editorIsActiveOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x131")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		protected bool EGOANCHGGFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x132")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		private bool PLFLMBMOIGI;

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public DEGDPNNFILM ACKHGJNJFIL
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0xFEE4C0", Offset = "0xFED4C0", VA = "0x180FEE4C0")]
			get
			{
				return default(DEGDPNNFILM);
			}
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x41DAAE0", Offset = "0x41D9AE0", VA = "0x1841DAAE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public bool DFBOGFJEIOP
		{
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x11AD6E0", Offset = "0x11AC6E0", VA = "0x1811AD6E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x41DDEC0", Offset = "0x41DCEC0", VA = "0x1841DDEC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x41DDE20", Offset = "0x41DCE20", VA = "0x1841DDE20", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x41DDA40", Offset = "0x41DCA40", VA = "0x1841DDA40", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x41DDE60", Offset = "0x41DCE60", VA = "0x1841DDE60")]
		public MakerPenToolTheme()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public enum CPJKCOOEGDP
{
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	Negative = 1,
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	SelectPrimary = 2,
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	SelectSidebar = 12,
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	SelectCardToggle = 14,
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	SelectSidebarInactive = 17,
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	ToggleOnSwitch = 18,
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	ToggleOffSwitch = 19,
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	ToggleChip = 20,
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	SliderDefault = 21
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public enum HMHFJCDBJNM
{
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	Default
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public enum HODFMPKAFLD
{
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	Default
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public enum KIBHEKBNJJM
{
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	Default
}
namespace RRUI.Theme
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class ScrollingAudioPaletteAsset : BaseAudioPaletteAsset
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		[SerializeField]
		[Header("Clip Configs")]
		private RecRoomAudioClipPoolConfig scrollingSFXAudioClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		[SerializeField]
		private RecRoomAudioClipPoolConfig hittingEndsAudioClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		[SerializeField]
		[Header("Thresholds")]
		[Tooltip("This distance is measured in UI canvas space")]
		private float distanceThresholdToTriggerScrollingSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		[SerializeField]
		private float minimumTimeIntervalForScrollingSFX;

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public float DistanceThresholdToTriggerScrollingSFX
		{
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x8650D0", Offset = "0x8640D0", VA = "0x1808650D0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		public float MinimumTimeIntervalForScrollingSFX
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x90AC00", Offset = "0x909C00", VA = "0x18090AC00")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x41DAB00", Offset = "0x41D9B00", VA = "0x1841DAB00")]
		public bool JAMGFEICNJH(out RecRoomAudioClip[] HADJFDODBJB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x41E5910", Offset = "0x41E4910", VA = "0x1841E5910")]
		public bool EEOAGHFBPNB(out RecRoomAudioClip[] HADJFDODBJB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x41E5930", Offset = "0x41E4930", VA = "0x1841E5930")]
		public ScrollingAudioPaletteAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public class ScrollRectTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		private const string OEAGOKAAIIH = "RRUI.PlayHittingEndsSFX";

		[Cpp2IlInjected.Token(Token = "0x4000208")]
		private const int DBPEEAGOOOK = 5;

		[Cpp2IlInjected.Token(Token = "0x4000209")]
		private const int BDMEPCFPEMG = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private DateTimeOffset MHIIIMNKCDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private int GNDAPPEDIOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private bool GMIDPGFALKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		[SerializeField]
		[JHDFHPMJCIE(KDNNMHJGNJH.Self, false, false, false)]
		private ScrollRect scrollRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		[SerializeField]
		[Header("Audio")]
		private HMHFJCDBJNM scrollAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private ScrollingAudioPaletteAsset FPBDKEIPLEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		private MCKJLIAMDEP DAFBCHEFAHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		private IONDOLLCJPN CLDEFEDADHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		private float INCMNJBOLHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		private float MIGNPAAANNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		private float PFEIHLDOBAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private bool GKENOKKGKCO;

		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private const float JGIGFCBPGOD = 0.01f;

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		private MCKJLIAMDEP DFIOPFFHOOJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x41E57F0", Offset = "0x41E47F0", VA = "0x1841E57F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		private IONDOLLCJPN DKECKFPNJHE
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x41E44C0", Offset = "0x41E34C0", VA = "0x1841E44C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x41E40B0", Offset = "0x41E30B0", VA = "0x1841E40B0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x41E5370", Offset = "0x41E4370", VA = "0x1841E5370", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x41E3FB0", Offset = "0x41E2FB0", VA = "0x1841E3FB0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x41E5480", Offset = "0x41E4480", VA = "0x1841E5480")]
		private void PHCJJCCOLPE(Vector2 NKMKMKDMOMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x41E42D0", Offset = "0x41E32D0", VA = "0x1841E42D0")]
		private void GHOLJEOBFIL(float GFNGJGDDADD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x41E4530", Offset = "0x41E3530", VA = "0x1841E4530")]
		private void IAGLMIODEGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x41E5240", Offset = "0x41E4240", VA = "0x1841E5240")]
		private static string JEKDKIIJJDG(GameObject EOHGDDIECBJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x41E5860", Offset = "0x41E4860", VA = "0x1841E5860")]
		public ScrollRectTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public class LabelTheme : GraphicTheme
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		[SerializeField]
		[JHDFHPMJCIE(KDNNMHJGNJH.Self, false, false, false)]
		private TextMeshProUGUI textMeshProUGUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		[SerializeField]
		private KNPCIAEEDKP textType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		[SerializeField]
		private FLHGGLODJFH textSize;

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public KNPCIAEEDKP KDJJBDOAFMH
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0xC14D00", Offset = "0xC13D00", VA = "0x180C14D00")]
			get
			{
				return default(KNPCIAEEDKP);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x41DDA20", Offset = "0x41DCA20", VA = "0x1841DDA20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		public FLHGGLODJFH NJIJMHFFHKG
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x915300", Offset = "0x914300", VA = "0x180915300")]
			get
			{
				return default(FLHGGLODJFH);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x41DDA00", Offset = "0x41DCA00", VA = "0x1841DDA00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x41DD660", Offset = "0x41DC660", VA = "0x1841DD660", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x41DD990", Offset = "0x41DC990", VA = "0x1841DD990")]
		public LabelTheme()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class MHGFMJKAFPI
{
	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
	public MHGFMJKAFPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0xBB9C20", Offset = "0xBB8C20", VA = "0x180BB9C20")]
	public static string KILOLNAHAFI(byte[] BKIADALNNFJ, byte[] EEICCMPLMOJ)
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
