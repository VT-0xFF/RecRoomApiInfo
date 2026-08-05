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
		public List<Graphic> PFGJHDCLLMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x94AC60", Offset = "0x949C60", VA = "0x18094AC60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x94ABC0", Offset = "0x949BC0", VA = "0x18094ABC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public ColorBlock HCDOKHNFDPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x424ED60", Offset = "0x424DD60", VA = "0x18424ED60")]
			get
			{
				return default(ColorBlock);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x424EDE0", Offset = "0x424DDE0", VA = "0x18424EDE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public UIGradient HNAJLGELAGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xF5B5C0", Offset = "0xF5A5C0", VA = "0x180F5B5C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x107D0A0", Offset = "0x107C0A0", VA = "0x18107D0A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public GradientBlock IPIIEDGHDPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x424EDB0", Offset = "0x424DDB0", VA = "0x18424EDB0")]
			get
			{
				return default(GradientBlock);
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x424EE30", Offset = "0x424DE30", VA = "0x18424EE30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x424EAD0", Offset = "0x424DAD0", VA = "0x18424EAD0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x424EB20", Offset = "0x424DB20", VA = "0x18424EB20", Slot = "36")]
		public override void OnSelect(BaseEventData MLPMPPLPMHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x424EC50", Offset = "0x424DC50", VA = "0x18424EC50")]
		public void Refresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x424EA90", Offset = "0x424DA90", VA = "0x18424EA90")]
		public void ForceHighlighted(bool EPIDFFJPMCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x424EAB0", Offset = "0x424DAB0", VA = "0x18424EAB0")]
		public void ForceNormal(bool EPIDFFJPMCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x424E7E0", Offset = "0x424D7E0", VA = "0x18424E7E0", Slot = "26")]
		protected override void DoStateTransition(SelectionState EGNHEHPGBMN, bool EPIDFFJPMCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x424EB70", Offset = "0x424DB70", VA = "0x18424EB70")]
		private void PAGBCKLPEOM(Graphic IDNBECJCFCB, Color OBKHKKOEPBA, bool EPIDFFJPMCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x424E6E0", Offset = "0x424D6E0", VA = "0x18424E6E0")]
		private void AILDNGFIHCA(SelectionState EGNHEHPGBMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x424EC80", Offset = "0x424DC80", VA = "0x18424EC80")]
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
			[Cpp2IlInjected.Address(RVA = "0x4257540", Offset = "0x4256540", VA = "0x184257540")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public Palette Active
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x4257510", Offset = "0x4256510", VA = "0x184257510")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA75A90", Offset = "0xA74A90", VA = "0x180A75A90")]
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
		private sealed class PAMJABHNNJH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public TMP_FontAsset font;

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
			public PAMJABHNNJH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x424EE80", Offset = "0x424DE80", VA = "0x18424EE80")]
			internal bool JFACCEJAENC(LocalizedFontMapping x)
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
			[Cpp2IlInjected.Address(RVA = "0x424C800", Offset = "0x424B800", VA = "0x18424C800")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public TMP_SpriteAsset EmojiAsset
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x91FD40", Offset = "0x91ED40", VA = "0x18091FD40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x424C3B0", Offset = "0x424B3B0", VA = "0x18424C3B0")]
		public bool JKOCMIKNCCJ(TMP_FontAsset APFAPJPNABP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x424C4F0", Offset = "0x424B4F0", VA = "0x18424C4F0")]
		public TMP_FontAsset KOIPJFBHACF(TMP_FontAsset APFAPJPNABP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x424C5F0", Offset = "0x424B5F0", VA = "0x18424C5F0")]
		public TMP_FontAsset KOIPJFBHACF(TMP_FontAsset APFAPJPNABP, Material JMHOFJDKHDE, out Material PLCJACOOBGN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x424C1F0", Offset = "0x424B1F0", VA = "0x18424C1F0")]
		public TMP_FontAsset APMNIDMDPHP(TMP_FontAsset APFAPJPNABP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x424BFC0", Offset = "0x424AFC0", VA = "0x18424BFC0")]
		public TMP_FontAsset APMNIDMDPHP(TMP_FontAsset APFAPJPNABP, Material JMHOFJDKHDE, out Material KNLKLHNFHHA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x424C2F0", Offset = "0x424B2F0", VA = "0x18424C2F0")]
		private static bool EPNHIIOGGIO(TMP_FontAsset APFAPJPNABP, LocalizedFontMapping GGLFLDHHIFN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9A4ED0", Offset = "0x9A3ED0", VA = "0x1809A4ED0")]
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
		[Cpp2IlInjected.Address(RVA = "0x424C980", Offset = "0x424B980", VA = "0x18424C980", Slot = "0")]
		public override bool Equals(object DCGPCJKHCOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x424CA80", Offset = "0x424BA80", VA = "0x18424CA80", Slot = "4")]
		public bool Equals(GradientBlock JONIFABKCAI)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x424CA80", Offset = "0x424BA80", VA = "0x18424CA80")]
		public static bool JFBEPFHBCDN(GradientBlock NENECNIADEJ, GradientBlock PJPFCMCBBHF)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x424CB60", Offset = "0x424BB60", VA = "0x18424CB60")]
		public static bool NLNNLODOBLO(GradientBlock NENECNIADEJ, GradientBlock PJPFCMCBBHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x424CAF0", Offset = "0x424BAF0", VA = "0x18424CAF0", Slot = "2")]
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
			[Cpp2IlInjected.Address(RVA = "0x424DEC0", Offset = "0x424CEC0", VA = "0x18424DEC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public RecRoomAudioClip[] MenuOpen2DFlavorAudioClipPool
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x424DF50", Offset = "0x424CF50", VA = "0x18424DF50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public RecRoomAudioClip[] MenuDehydrateAudioClipPool
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x424DE30", Offset = "0x424CE30", VA = "0x18424DE30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public RecRoomAudioClip[] MenuClose2DFlavorAudioClipPool
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x424DDA0", Offset = "0x424CDA0", VA = "0x18424DDA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2C50520", Offset = "0x2C4F520", VA = "0x182C50520")]
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
			[Cpp2IlInjected.Address(RVA = "0x4248BE0", Offset = "0x4247BE0", VA = "0x184248BE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public RecRoomAudioClip[] PointerUpAudioClipPool
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x4248D00", Offset = "0x4247D00", VA = "0x184248D00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public RecRoomAudioClip[] PointerClickAudioClipPool
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x4248B50", Offset = "0x4247B50", VA = "0x184248B50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public RecRoomAudioClip[] PointerEnterAudioClipPool
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x4248C70", Offset = "0x4247C70", VA = "0x184248C70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2C50520", Offset = "0x2C4F520", VA = "0x182C50520")]
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
			[Cpp2IlInjected.Address(RVA = "0x9877B0", Offset = "0x9867B0", VA = "0x1809877B0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public float ClickAnimationScale
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x987830", Offset = "0x986830", VA = "0x180987830")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x4248B30", Offset = "0x4247B30", VA = "0x184248B30")]
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
		private EKCNABIMODC buttonAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[SerializeField]
		[Tooltip("Layer a 2D SFX on top of base button sounds")]
		private bool useFlavorSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[SerializeField]
		[Tooltip("Flavor SFX is picked randomly from this pool config")]
		[DFFLAPBPAEA("useFlavorSFX")]
		private RecRoomAudioClipPoolConfig flavorSFXClipPoolConfig;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x4253DA0", Offset = "0x4252DA0", VA = "0x184253DA0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4253EC0", Offset = "0x4252EC0", VA = "0x184253EC0")]
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
		private UITiler.GBBJADIOBOP animationDirection;

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
			[Cpp2IlInjected.Address(RVA = "0x83A5D0", Offset = "0x8395D0", VA = "0x18083A5D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Color TintColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xACBFD0", Offset = "0xACAFD0", VA = "0x180ACBFD0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Color BackgroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xB92550", Offset = "0xB91550", VA = "0x180B92550")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public Vector2 Spacing
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x4257710", Offset = "0x4256710", VA = "0x184257710")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float Offset
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xF9FDE0", Offset = "0xF9EDE0", VA = "0x180F9FDE0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Vector2 Velocity
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x4257730", Offset = "0x4256730", VA = "0x184257730")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public float Angle
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xF9FE10", Offset = "0xF9EE10", VA = "0x180F9FE10")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public UITiler.GBBJADIOBOP AnimationDirection
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xAC0EA0", Offset = "0xABFEA0", VA = "0x180AC0EA0")]
			get
			{
				return default(UITiler.GBBJADIOBOP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float PrimaryAnimationSpeed
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xF9FE20", Offset = "0xF9EE20", VA = "0x180F9FE20")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float AltAnimationSpeed
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xB86740", Offset = "0xB85740", VA = "0x180B86740")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x4257680", Offset = "0x4256680", VA = "0x184257680")]
		public float AMLMJLGOCPO(JDBFMBECFKB GJKIINBECJD)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x42576A0", Offset = "0x42566A0", VA = "0x1842576A0")]
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
		[LHIKCFDKPCO(FEMKOOHMMFH.Self, false, false, false)]
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
		[DFFLAPBPAEA("overrideWithSingleAudio")]
		[Tooltip("The legacy override audio will be randomly picked from this pool")]
		protected RecRoomAudioClip[] randomAudioOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		protected bool PLPDAEGEFFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private ButtonAudioPaletteAsset CIAMNJBIPFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private RecRoomAudioClipPoolConfig POAPNIDMBJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private EMBGBMCGBNC JPDLFOIMNBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private JHMIPFIADPC AAOPMACJJCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private GPMNJIGKJPH HLNJHKFFOLI;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		protected Selectable PIELHDPGDNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x91FD40", Offset = "0x91ED40", VA = "0x18091FD40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		protected virtual bool NNMHCDAIBOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x8401F0", Offset = "0x83F1F0", VA = "0x1808401F0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool JJMDENMNACP
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x42522A0", Offset = "0x42512A0", VA = "0x1842522A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x42522C0", Offset = "0x42512C0", VA = "0x1842522C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private EMBGBMCGBNC IKKCAJJGFOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x42558B0", Offset = "0x42548B0", VA = "0x1842558B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		protected JHMIPFIADPC CFENADNNJIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x4255E90", Offset = "0x4254E90", VA = "0x184255E90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private GPMNJIGKJPH AGNBEGOGGEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x42564E0", Offset = "0x42554E0", VA = "0x1842564E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x42559A0", Offset = "0x42549A0", VA = "0x1842559A0")]
		protected void FOAMBBGMMMC(ButtonAudioPaletteAsset JFHBGKLFPGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x94AD10", Offset = "0x949D10", VA = "0x18094AD10")]
		protected void GMKHCJAJCEA(RecRoomAudioClipPoolConfig JDPFBFHNALE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x4256130", Offset = "0x4255130", VA = "0x184256130", Slot = "12")]
		public virtual void OnPointerDown(PointerEventData MLPMPPLPMHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x42563A0", Offset = "0x42553A0", VA = "0x1842563A0", Slot = "13")]
		public virtual void OnPointerUp(PointerEventData MLPMPPLPMHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x4255F00", Offset = "0x4254F00", VA = "0x184255F00", Slot = "14")]
		public virtual void OnPointerClick(PointerEventData MLPMPPLPMHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x4256270", Offset = "0x4255270", VA = "0x184256270", Slot = "15")]
		public virtual void OnPointerEnter(PointerEventData MLPMPPLPMHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x4255920", Offset = "0x4254920", VA = "0x184255920")]
		private void ELEOIOMCEMB(RecRoomAudioClip[] OPDJIOLLIAM, bool BPBAGEDGAIJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x4255AC0", Offset = "0x4254AC0", VA = "0x184255AC0")]
		private void JCIPDODGGEN(RecRoomAudioClip GGOOCMPGPDO, bool BPBAGEDGAIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x4256550", Offset = "0x4255550", VA = "0x184256550")]
		protected SelectableThemeBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class MixedTogglePalette
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		private enum CCEMLMFELHI
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
		private GGGPFNHODOI baseTogglePalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private CCEMLMFELHI mixedPaletteType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[SerializeField]
		[DFFLAPBPAEA("mixedPaletteType", 2)]
		private ButtonPalette mixedButtonPalette;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x424E050", Offset = "0x424D050", VA = "0x18424E050")]
		public TogglePalette PJDKNMBOJGE(Palette MAFMIPLIBIJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x424DFE0", Offset = "0x424CFE0", VA = "0x18424DFE0")]
		public ButtonPalette ELCDOJFHIJI(Palette MAFMIPLIBIJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x128E0C0", Offset = "0x128D0C0", VA = "0x18128E0C0")]
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
		private DLHLIBKODJA recyclingAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		protected RecyclingAudioPaletteAsset CIAMNJBIPFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[SerializeField]
		private HGDALCDFGPL scrollingAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private ScrollingAudioPaletteAsset ELGDJGLDFNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private EMBGBMCGBNC JPDLFOIMNBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private float KKADGFMLCGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private float CKMOLDDJDAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private float OINBBHPPGGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private float OJBDLEGCNHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private bool JEAEGMEONDN;

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private const float FLGJNOBAOMH = 0.01f;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private EMBGBMCGBNC IKKCAJJGFOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x4253370", Offset = "0x4252370", VA = "0x184253370")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x4253160", Offset = "0x4252160", VA = "0x184253160", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x4253780", Offset = "0x4252780", VA = "0x184253780")]
		protected void IIPPDAFLMKG(bool LPMLMDIKOIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x42533E0", Offset = "0x42523E0", VA = "0x1842533E0")]
		protected void HCPPDFLJGCD(GameObject GDMNFPEECEP, int OMOPJGOGJBF, bool BANIJPEAPIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x4253BB0", Offset = "0x4252BB0", VA = "0x184253BB0")]
		protected void NKBLFHGMGAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x4253580", Offset = "0x4252580", VA = "0x184253580")]
		protected void ICEDPLKLKNH(float GFGGALAHOPA, float KFHHHEEHPKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x4252F70", Offset = "0x4251F70", VA = "0x184252F70")]
		private void ADBPEGBINML(float FBCJBEIAPCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x4253A60", Offset = "0x4252A60", VA = "0x184253A60")]
		private void LCAPFHCCLKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x4253D40", Offset = "0x4252D40", VA = "0x184253D40")]
		protected RecyclingThemeBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class SwitchTheme : ToggleTheme
	{
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private const float ALKKINOPHKF = 0.33f;

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
		private BPHKLIGHAMP IDJCLKGDLHO;

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x4256E50", Offset = "0x4255E50", VA = "0x184256E50", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x42570E0", Offset = "0x42560E0", VA = "0x1842570E0")]
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
		private Vector3? PFHOHPECFKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private Vector3? MOCNENEOPJH;

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x4248500", Offset = "0x4247500", VA = "0x184248500")]
		private void JFGMJMMFADK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x4248180", Offset = "0x4247180", VA = "0x184248180", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x42485E0", Offset = "0x42475E0", VA = "0x1842485E0")]
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
		[LHIKCFDKPCO(FEMKOOHMMFH.Self, false, false, false)]
		private Dropdown dropdown;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[SerializeField]
		[ODLINMJGOAE(FEMKOOHMMFH.Self, false, true, false)]
		private Image surface;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[SerializeField]
		private bool useSurfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[SerializeField]
		[DFFLAPBPAEA("useSurfaceOverride")]
		private Image surfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[SerializeField]
		private KFNJBKNBBLC dropdownType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[SerializeField]
		private IOLOGGHJHBL textSize;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Image KLCJLAHEGAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x424BF70", Offset = "0x424AF70", VA = "0x18424BF70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public KFNJBKNBBLC CGJPGCJNFHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xADE620", Offset = "0xADD620", VA = "0x180ADE620")]
			get
			{
				return default(KFNJBKNBBLC);
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x424BF80", Offset = "0x424AF80", VA = "0x18424BF80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public IOLOGGHJHBL KOABLNPIAMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xC22BF0", Offset = "0xC21BF0", VA = "0x180C22BF0")]
			get
			{
				return default(IOLOGGHJHBL);
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x424BFA0", Offset = "0x424AFA0", VA = "0x18424BFA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x424B860", Offset = "0x424A860", VA = "0x18424B860", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x424BF00", Offset = "0x424AF00", VA = "0x18424BF00")]
		public DropdownTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class BaseAudioPaletteAsset : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x4248A70", Offset = "0x4247A70", VA = "0x184248A70")]
		protected bool LEPGPEEGHOO(RecRoomAudioClipPoolConfig CKMDOIFFADH, out RecRoomAudioClip[] OPDJIOLLIAM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9A4ED0", Offset = "0x9A3ED0", VA = "0x1809A4ED0")]
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
		private NFHEFGFIEGC buttonType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[SerializeField]
		[Tooltip("Override the audio palette defined by the button's visual with a custom palette")]
		[Header("Button Audio")]
		private bool overrideButtonAudioPalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[SerializeField]
		[DFFLAPBPAEA("overrideButtonAudioPalette")]
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
		[DFFLAPBPAEA("useFlavorSFX")]
		[Tooltip("Flavor SFX is picked randomly from this pool config")]
		private RecRoomAudioClipPoolConfig flavorSFXClipPoolConfig;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public NFHEFGFIEGC OEFDKEKDFPB
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x94ABF0", Offset = "0x949BF0", VA = "0x18094ABF0")]
			get
			{
				return default(NFHEFGFIEGC);
			}
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x424A9A0", Offset = "0x42499A0", VA = "0x18424A9A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x424A6D0", Offset = "0x42496D0", VA = "0x18424A6D0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA05C90", Offset = "0xA04C90", VA = "0x180A05C90")]
		public void SetAnimationEnabled(bool PINBJOHBLIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x424A960", Offset = "0x4249960", VA = "0x18424A960")]
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
		[LHIKCFDKPCO(FEMKOOHMMFH.Self, false, false, false)]
		private OLHPBCHCIFK recyclingList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private bool FLOFDJBJGEK;

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x4252A10", Offset = "0x4251A10", VA = "0x184252A10", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x4252CD0", Offset = "0x4251CD0", VA = "0x184252CD0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x4252C60", Offset = "0x4251C60", VA = "0x184252C60")]
		private void NPIIDKCDHKL(float GFGGALAHOPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x4252EF0", Offset = "0x4251EF0", VA = "0x184252EF0")]
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
			private EKCNABIMODC buttonAudioPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			[SerializeField]
			private ButtonAudioPaletteAsset buttonAudioPaletteConfig;

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			public EKCNABIMODC ButtonAudioPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(RVA = "0x83A6E0", Offset = "0x8396E0", VA = "0x18083A6E0")]
				get
				{
					return default(EKCNABIMODC);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public ButtonAudioPaletteAsset ButtonAudioPaletteConfig
			{
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xB83F70", Offset = "0xB82F70", VA = "0x180B83F70")]
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
			private HGDALCDFGPL scrollingAudioPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			[SerializeField]
			private ScrollingAudioPaletteAsset scrollingAudioPaletteConfig;

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			public HGDALCDFGPL ScrollingAudioPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600007E")]
				[Cpp2IlInjected.Address(RVA = "0x83A6E0", Offset = "0x8396E0", VA = "0x18083A6E0")]
				get
				{
					return default(HGDALCDFGPL);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			public ScrollingAudioPaletteAsset ScrollingAudioPaletteConfig
			{
				[Cpp2IlInjected.Token(Token = "0x600007F")]
				[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xB83F70", Offset = "0xB82F70", VA = "0x180B83F70")]
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
			private LNGCAFPMEOK contentLoadingAudioPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			[SerializeField]
			private ContentLoadingAudioPaletteAsset contentLoadingAudioPaletteConfig;

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			public LNGCAFPMEOK ContentLoadingAudioPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000081")]
				[Cpp2IlInjected.Address(RVA = "0x83A6E0", Offset = "0x8396E0", VA = "0x18083A6E0")]
				get
				{
					return default(LNGCAFPMEOK);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			public ContentLoadingAudioPaletteAsset ContentLoadingAudioPaletteConfig
			{
				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xB83F70", Offset = "0xB82F70", VA = "0x180B83F70")]
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
			private DLHLIBKODJA recyclingAudioPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			[SerializeField]
			private RecyclingAudioPaletteAsset recyclingAudioPaletteConfig;

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			public DLHLIBKODJA RecyclingAudioPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x83A6E0", Offset = "0x8396E0", VA = "0x18083A6E0")]
				get
				{
					return default(DLHLIBKODJA);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			public RecyclingAudioPaletteAsset RecyclingAudioPaletteConfig
			{
				[Cpp2IlInjected.Token(Token = "0x6000085")]
				[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xB83F70", Offset = "0xB82F70", VA = "0x180B83F70")]
			public RecyclingAudioPaletteItem()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class PGLEGIHFCMF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public EKCNABIMODC buttonAudioPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
			public PGLEGIHFCMF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xD9C090", Offset = "0xD9B090", VA = "0x180D9C090")]
			internal bool EIHMCDGLMPI(ButtonAudioPaletteItem buttonAudioPalette)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class FOFBLHAFJFH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public HGDALCDFGPL scrollingAudioPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
			public FOFBLHAFJFH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xD9C090", Offset = "0xD9B090", VA = "0x180D9C090")]
			internal bool OJDJCPPHPBN(ScrollingAudioPaletteItem scrollingAudioPalette)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class JGNDBIHCOBF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public LNGCAFPMEOK contentLoadingAudioPaletteType;

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
			public JGNDBIHCOBF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xD9C090", Offset = "0xD9B090", VA = "0x180D9C090")]
			internal bool LGEFANKGIFG(ContentLoadingAudioPaletteItem contentLoadingAudioPalette)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[CompilerGenerated]
		private sealed class LCPKOGLCJFB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public DLHLIBKODJA recyclingAudioPaletteType;

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
			public LCPKOGLCJFB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0xD9C090", Offset = "0xD9B090", VA = "0x180D9C090")]
			internal bool MBDJGAAAHJP(RecyclingAudioPaletteItem recyclingAudioPalette)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[SerializeField]
		[PGDCCLHLFJB("ButtonAudioPaletteType")]
		private ButtonAudioPaletteItem[] buttonAudioPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[SerializeField]
		[PGDCCLHLFJB("ScrollingAudioPaletteType")]
		private ScrollingAudioPaletteItem[] scrollingAudioPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[SerializeField]
		[PGDCCLHLFJB("ContentLoadingAudioPaletteType")]
		private ContentLoadingAudioPaletteItem[] contentLoadingAudioPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[SerializeField]
		[PGDCCLHLFJB("RecyclingAudioPaletteType")]
		private RecyclingAudioPaletteItem[] recyclingAudioPalettes;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x4248710", Offset = "0x4247710", VA = "0x184248710")]
		public ButtonAudioPaletteAsset HCNPPAPADNC(EKCNABIMODC JBIGLONCALJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x4248620", Offset = "0x4247620", VA = "0x184248620")]
		public ScrollingAudioPaletteAsset HCEIOGAIENM(HGDALCDFGPL JFPLDPIFPMA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x4248800", Offset = "0x4247800", VA = "0x184248800")]
		public ContentLoadingAudioPaletteAsset LADKJPKIACI(LNGCAFPMEOK MHCLHLFBKJB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x42488F0", Offset = "0x42478F0", VA = "0x1842488F0")]
		public RecyclingAudioPaletteAsset OACOEPIFPED(DLHLIBKODJA MHCHGEJIOKO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2C50520", Offset = "0x2C4F520", VA = "0x182C50520")]
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
			[Cpp2IlInjected.Address(RVA = "0x9A65D0", Offset = "0x9A55D0", VA = "0x1809A65D0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public Color ForegroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x9A65E0", Offset = "0x9A55E0", VA = "0x1809A65E0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public Color PlaceholderColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xA52180", Offset = "0xA51180", VA = "0x180A52180")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public TextStylePalette TextPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x944E20", Offset = "0x943E20", VA = "0x180944E20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x424CFA0", Offset = "0x424BFA0", VA = "0x18424CFA0")]
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
		[LHIKCFDKPCO(FEMKOOHMMFH.Self, false, false, false)]
		private Image image;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[SerializeField]
		[ODLINMJGOAE(FEMKOOHMMFH.Self, false, false, false)]
		private UIGradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[SerializeField]
		private CFHGFKGIKHE color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[SerializeField]
		[DFFLAPBPAEA("gradient")]
		private bool ignoreGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[SerializeField]
		[Tooltip("The surface theme determines if this Image is a RaycastTarget or not. There are times when you might want to ignore that setting of the palette theme and just respect whatever is the default state on the Image.")]
		private bool ignoreSettingRaycastTarget;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public CFHGFKGIKHE KMBCCINHLMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x9CC1C0", Offset = "0x9CB1C0", VA = "0x1809CC1C0")]
			get
			{
				return default(CFHGFKGIKHE);
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x4256E30", Offset = "0x4255E30", VA = "0x184256E30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x4256B60", Offset = "0x4255B60", VA = "0x184256B60", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x4256DD0", Offset = "0x4255DD0", VA = "0x184256DD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9877A0", Offset = "0x9867A0", VA = "0x1809877A0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x424A9C0", Offset = "0x42499C0", VA = "0x18424A9C0")]
		public bool OBCDLDOFJGK(out RecRoomAudioClip[] OPDJIOLLIAM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x42524D0", Offset = "0x42514D0", VA = "0x1842524D0")]
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
		[DFFLAPBPAEA("usePaletteOverride")]
		private Palette paletteOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public MONMJFCKPLO PaletteChangeEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		[SerializeField]
		private bool useDepth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private ADCIIIEIBCH GFEKPCMPLEN;

		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private const string IGAMDEKIIOD = "watch_layer";

		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private const string IPHLHEOCOFO = "depth_multiplier";

		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private const float IGPHFMOLDJO = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private float? OLINNDGBIPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private float? OHLMAGPEGIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private float? OCADMNOFNBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private float FCJIJGENLGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private float LCNBOOGHMLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private float NHMDOEDLBPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private float CAOJCGKDDBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private readonly OEMFJNEEEFM FJNGEGHOEDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private SFXAudioSource BEPHHDLNOBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private SFXAudioSource HICDLHBPHFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private ContentLoadingAudioPaletteAsset PMHBAPOALOA;

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private const float BHLENDELJLH = 0.001f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private EMBGBMCGBNC IKKCAJJGFOD;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public Palette INDGLHBNGDH
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x4250F00", Offset = "0x424FF00", VA = "0x184250F00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public bool PFJEFDOEGLG
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x1031E00", Offset = "0x1030E00", VA = "0x181031E00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public float HPMGMLFDANA
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x4250D30", Offset = "0x424FD30", VA = "0x184250D30")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		private bool GJMDIEDBBNP
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x424F870", Offset = "0x424E870", VA = "0x18424F870")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		private bool FBLFMDDBJKM
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x4250690", Offset = "0x424F690", VA = "0x184250690")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x424FA30", Offset = "0x424EA30", VA = "0x18424FA30")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x42506A0", Offset = "0x424F6A0", VA = "0x1842506A0")]
		private void MLMFLHPBLAC(ALLDMOLDJKE.LKAFECCEKJH GPIFFBMNGIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x4250810", Offset = "0x424F810", VA = "0x184250810")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x4250550", Offset = "0x424F550", VA = "0x184250550")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x4250280", Offset = "0x424F280", VA = "0x184250280")]
		private void HJLBKBDFFCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x424F900", Offset = "0x424E900", VA = "0x18424F900")]
		public void AddLoadingSFXRequest(object DMHDKAFNNAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x4250B10", Offset = "0x424FB10", VA = "0x184250B10")]
		public void RemoveLoadingSFXRequest(object DMHDKAFNNAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x4250550", Offset = "0x424F550", VA = "0x184250550")]
		private void KEOOLELNAHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x424FBC0", Offset = "0x424EBC0", VA = "0x18424FBC0")]
		private void CODKLOJNEFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x42506D0", Offset = "0x424F6D0", VA = "0x1842506D0")]
		private void NHHCOAKHECF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x4250040", Offset = "0x424F040", VA = "0x184250040")]
		private void DDBPEMEOPEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x424FDD0", Offset = "0x424EDD0", VA = "0x18424FDD0")]
		private void COIJHGGHMFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x4250140", Offset = "0x424F140", VA = "0x184250140")]
		private void FGGDEDMNAKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x4250270", Offset = "0x424F270", VA = "0x184250270")]
		private void HHKHDHAGKPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x4250460", Offset = "0x424F460", VA = "0x184250460")]
		private void JMEPNCLOFDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x4250230", Offset = "0x424F230", VA = "0x184250230")]
		private void HADKENIPPDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x4250940", Offset = "0x424F940", VA = "0x184250940")]
		public void Play2DUIFlavorSFX(RecRoomAudioClip[] DKNDNIDADHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x4250C30", Offset = "0x424FC30", VA = "0x184250C30")]
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
		private NCMIPOFAKBL depth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		[SerializeField]
		private bool animateOnEnable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[SerializeField]
		[DFFLAPBPAEA("animateOnEnable")]
		private float animationTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private Vector3? PFHOHPECFKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private Vector2 LIMJKOENBNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private Vector2 MNCNFPGGFFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private Vector2 HIBGGPPFKEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private Vector2 MMGKEFIPHCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private Vector2 IDMNAFCKBEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private Vector2 MEOFMHLAKFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private readonly bool? FPAMAEKOGLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private HLMIKGPPDFG NCCILGJMIKL;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		private RectTransform JMEBNMPKOAB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x424B4E0", Offset = "0x424A4E0", VA = "0x18424B4E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public NCMIPOFAKBL DMNDLJMJJJE
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xA74E00", Offset = "0xA73E00", VA = "0x180A74E00")]
			get
			{
				return default(NCMIPOFAKBL);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x424B7F0", Offset = "0x424A7F0", VA = "0x18424B7F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		private HLMIKGPPDFG EEIPOKMHABJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x424B540", Offset = "0x424A540", VA = "0x18424B540")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		private bool AEFILPKCNPG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x424B0D0", Offset = "0x424A0D0", VA = "0x18424B0D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x424B660", Offset = "0x424A660", VA = "0x18424B660")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x424B5B0", Offset = "0x424A5B0", VA = "0x18424B5B0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x424AA30", Offset = "0x4249A30", VA = "0x18424AA30", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x424B1C0", Offset = "0x424A1C0", VA = "0x18424B1C0")]
		private void JFGMJMMFADK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x424AD50", Offset = "0x4249D50", VA = "0x18424AD50")]
		private Vector3 BGDPFFDMNNN()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x424B6D0", Offset = "0x424A6D0", VA = "0x18424B6D0")]
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
			[Cpp2IlInjected.Address(RVA = "0xDADE30", Offset = "0xDACE30", VA = "0x180DADE30")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x121B830", Offset = "0x121A830", VA = "0x18121B830")]
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
			private FCGJGKJMPFE paletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			[SerializeField]
			private Color color;

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			public FCGJGKJMPFE RawImageColorPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x60000D1")]
				[Cpp2IlInjected.Address(RVA = "0x83A6E0", Offset = "0x8396E0", VA = "0x18083A6E0")]
				get
				{
					return default(FCGJGKJMPFE);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			public Color Color
			{
				[Cpp2IlInjected.Token(Token = "0x60000D2")]
				[Cpp2IlInjected.Address(RVA = "0x94AB70", Offset = "0x949B70", VA = "0x18094AB70")]
				get
				{
					return default(Color);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x4252300", Offset = "0x4251300", VA = "0x184252300")]
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
			private CFHGFKGIKHE backgroundColorPaletteType;

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
			public CFHGFKGIKHE BackgroundColorPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x60000D4")]
				[Cpp2IlInjected.Address(RVA = "0x83A6E0", Offset = "0x8396E0", VA = "0x18083A6E0")]
				get
				{
					return default(CFHGFKGIKHE);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000046")]
			public Color Color
			{
				[Cpp2IlInjected.Token(Token = "0x60000D5")]
				[Cpp2IlInjected.Address(RVA = "0x94AB70", Offset = "0x949B70", VA = "0x18094AB70")]
				get
				{
					return default(Color);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000047")]
			public Gradient Gradient
			{
				[Cpp2IlInjected.Token(Token = "0x60000D6")]
				[Cpp2IlInjected.Address(RVA = "0x91FD50", Offset = "0x91ED50", VA = "0x18091FD50")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000048")]
			public bool RaycastTarget
			{
				[Cpp2IlInjected.Token(Token = "0x60000D7")]
				[Cpp2IlInjected.Address(RVA = "0x1031E00", Offset = "0x1030E00", VA = "0x181031E00")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x42489E0", Offset = "0x42479E0", VA = "0x1842489E0")]
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
			private MFHINLCGGJK foregroundColorPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			[SerializeField]
			private Color color;

			[Cpp2IlInjected.Token(Token = "0x17000049")]
			public MFHINLCGGJK ForegroundColorPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x60000D9")]
				[Cpp2IlInjected.Address(RVA = "0x83A6E0", Offset = "0x8396E0", VA = "0x18083A6E0")]
				get
				{
					return default(MFHINLCGGJK);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004A")]
			public Color Color
			{
				[Cpp2IlInjected.Token(Token = "0x60000DA")]
				[Cpp2IlInjected.Address(RVA = "0x94AB70", Offset = "0x949B70", VA = "0x18094AB70")]
				get
				{
					return default(Color);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x424C940", Offset = "0x424B940", VA = "0x18424C940")]
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
			private PAJMPDDCKLB tilerPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			[SerializeField]
			private TilerPalette tilerPalette;

			[Cpp2IlInjected.Token(Token = "0x1700004B")]
			public PAJMPDDCKLB TilerPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x60000DC")]
				[Cpp2IlInjected.Address(RVA = "0x83A6E0", Offset = "0x8396E0", VA = "0x18083A6E0")]
				get
				{
					return default(PAJMPDDCKLB);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004C")]
			public TilerPalette TilerPalette
			{
				[Cpp2IlInjected.Token(Token = "0x60000DD")]
				[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x121B830", Offset = "0x121A830", VA = "0x18121B830")]
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
			private BAOIAJGBHGD textStylePaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			[SerializeField]
			private TextStylePalette textStylePalette;

			[Cpp2IlInjected.Token(Token = "0x1700004D")]
			public BAOIAJGBHGD TextStylePaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x60000DF")]
				[Cpp2IlInjected.Address(RVA = "0x83A6E0", Offset = "0x8396E0", VA = "0x18083A6E0")]
				get
				{
					return default(BAOIAJGBHGD);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004E")]
			public TextStylePalette TextStylePalette
			{
				[Cpp2IlInjected.Token(Token = "0x60000E0")]
				[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0xB83F70", Offset = "0xB82F70", VA = "0x180B83F70")]
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
			private IOLOGGHJHBL textSizePaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			[SerializeField]
			private int size;

			[Cpp2IlInjected.Token(Token = "0x1700004F")]
			public IOLOGGHJHBL TextSizePaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x60000E2")]
				[Cpp2IlInjected.Address(RVA = "0x83A6E0", Offset = "0x8396E0", VA = "0x18083A6E0")]
				get
				{
					return default(IOLOGGHJHBL);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000050")]
			public int Size
			{
				[Cpp2IlInjected.Token(Token = "0x60000E3")]
				[Cpp2IlInjected.Address(RVA = "0x9A6670", Offset = "0x9A5670", VA = "0x1809A6670")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x42571C0", Offset = "0x42561C0", VA = "0x1842571C0")]
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
			private NFHEFGFIEGC buttonPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			[SerializeField]
			private ButtonPalette buttonPalette;

			[Cpp2IlInjected.Token(Token = "0x17000051")]
			public NFHEFGFIEGC ButtonPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x60000E5")]
				[Cpp2IlInjected.Address(RVA = "0x83A6E0", Offset = "0x8396E0", VA = "0x18083A6E0")]
				get
				{
					return default(NFHEFGFIEGC);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000052")]
			public ButtonPalette ButtonPalette
			{
				[Cpp2IlInjected.Token(Token = "0x60000E6")]
				[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xB83F70", Offset = "0xB82F70", VA = "0x180B83F70")]
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
			private GGGPFNHODOI togglePaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			[SerializeField]
			private TogglePalette togglePalette;

			[Cpp2IlInjected.Token(Token = "0x17000053")]
			public GGGPFNHODOI TogglePaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x60000E8")]
				[Cpp2IlInjected.Address(RVA = "0x83A6E0", Offset = "0x8396E0", VA = "0x18083A6E0")]
				get
				{
					return default(GGGPFNHODOI);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000054")]
			public TogglePalette TogglePalette
			{
				[Cpp2IlInjected.Token(Token = "0x60000E9")]
				[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0xB83F70", Offset = "0xB82F70", VA = "0x180B83F70")]
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
			private PFMFGANNOID mixedTogglePaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			[SerializeField]
			private MixedTogglePalette mixedTogglePalette;

			[Cpp2IlInjected.Token(Token = "0x17000055")]
			public PFMFGANNOID MixedTogglePaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x60000EB")]
				[Cpp2IlInjected.Address(RVA = "0x83A6E0", Offset = "0x8396E0", VA = "0x18083A6E0")]
				get
				{
					return default(PFMFGANNOID);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000056")]
			public MixedTogglePalette MixedTogglePalette
			{
				[Cpp2IlInjected.Token(Token = "0x60000EC")]
				[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xB83F70", Offset = "0xB82F70", VA = "0x180B83F70")]
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
			private CCOMJMNHADI makerPenToolPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			[SerializeField]
			private MakerPenToolPalette makerPenToolPalette;

			[Cpp2IlInjected.Token(Token = "0x17000057")]
			public CCOMJMNHADI MakerPenToolPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x60000EE")]
				[Cpp2IlInjected.Address(RVA = "0x83A6E0", Offset = "0x8396E0", VA = "0x18083A6E0")]
				get
				{
					return default(CCOMJMNHADI);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000058")]
			public MakerPenToolPalette MakerPenToolPalette
			{
				[Cpp2IlInjected.Token(Token = "0x60000EF")]
				[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0xB83F70", Offset = "0xB82F70", VA = "0x180B83F70")]
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
			private DLHMJNFCONB inputFieldPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			[SerializeField]
			private InputFieldPalette inputFieldPalette;

			[Cpp2IlInjected.Token(Token = "0x17000059")]
			public DLHMJNFCONB InputFieldPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x60000F1")]
				[Cpp2IlInjected.Address(RVA = "0x83A6E0", Offset = "0x8396E0", VA = "0x18083A6E0")]
				get
				{
					return default(DLHMJNFCONB);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005A")]
			public InputFieldPalette InputFieldPalette
			{
				[Cpp2IlInjected.Token(Token = "0x60000F2")]
				[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0xB83F70", Offset = "0xB82F70", VA = "0x180B83F70")]
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
			private KFNJBKNBBLC dropdownPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			[SerializeField]
			private DropdownPalette dropdownPalette;

			[Cpp2IlInjected.Token(Token = "0x1700005B")]
			public KFNJBKNBBLC DropdownPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0x83A6E0", Offset = "0x8396E0", VA = "0x18083A6E0")]
				get
				{
					return default(KFNJBKNBBLC);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005C")]
			public DropdownPalette DropdownPalette
			{
				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0xB83F70", Offset = "0xB82F70", VA = "0x180B83F70")]
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
			private HDJDEIFFFAP sliderPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			[SerializeField]
			private SliderPalette sliderPalette;

			[Cpp2IlInjected.Token(Token = "0x1700005D")]
			public HDJDEIFFFAP SliderPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x60000F7")]
				[Cpp2IlInjected.Address(RVA = "0x83A6E0", Offset = "0x8396E0", VA = "0x18083A6E0")]
				get
				{
					return default(HDJDEIFFFAP);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005E")]
			public SliderPalette SliderPalette
			{
				[Cpp2IlInjected.Token(Token = "0x60000F8")]
				[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0xB83F70", Offset = "0xB82F70", VA = "0x180B83F70")]
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
			private NCMIPOFAKBL depthPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			[SerializeField]
			private DepthPalette depthPalette;

			[Cpp2IlInjected.Token(Token = "0x1700005F")]
			public NCMIPOFAKBL DepthPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x60000FA")]
				[Cpp2IlInjected.Address(RVA = "0x83A6E0", Offset = "0x8396E0", VA = "0x18083A6E0")]
				get
				{
					return default(NCMIPOFAKBL);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000060")]
			public DepthPalette DepthPalette
			{
				[Cpp2IlInjected.Token(Token = "0x60000FB")]
				[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xB83F70", Offset = "0xB82F70", VA = "0x180B83F70")]
			public DepthPaletteItem()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[CompilerGenerated]
		private sealed class CMLHPMMGPDP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public FCGJGKJMPFE backgroundColorPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
			public CMLHPMMGPDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0xD9C090", Offset = "0xD9B090", VA = "0x180D9C090")]
			internal bool JECDDMIIGKJ(RawImageColorPaletteItem pi)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		[CompilerGenerated]
		private sealed class GGKCKBHBBCM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public CFHGFKGIKHE backgroundColorPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
			public GGKCKBHBBCM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0xD9C090", Offset = "0xD9B090", VA = "0x180D9C090")]
			internal bool MCILPFAOHCO(BackgroundColorPaletteItem backgroundColorPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000039")]
		[CompilerGenerated]
		private sealed class MIAGJENCODJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public MFHINLCGGJK foregroundColorPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
			public MIAGJENCODJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0xD9C090", Offset = "0xD9B090", VA = "0x180D9C090")]
			internal bool BGFPDKNDJIP(ForegroundColorPaletteItem colorPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		[CompilerGenerated]
		private sealed class MAIBHAKBBIL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public PAJMPDDCKLB type;

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
			public MAIBHAKBBIL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0xD9C090", Offset = "0xD9B090", VA = "0x180D9C090")]
			internal bool EMPCPGNLOOL(TilerPaletteItem tilerPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		[CompilerGenerated]
		private sealed class DICCIBGJPIM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public BAOIAJGBHGD textStylePaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
			public DICCIBGJPIM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0xD9C090", Offset = "0xD9B090", VA = "0x180D9C090")]
			internal bool BILFMJNNPHK(TextStylePaletteItem textStylePaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		[CompilerGenerated]
		private sealed class HNJCKBCOIBC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public IOLOGGHJHBL textSizePaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
			public HNJCKBCOIBC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0xD9C090", Offset = "0xD9B090", VA = "0x180D9C090")]
			internal bool FEGAMKHBEOL(TextSizePaletteItem textSizePaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003D")]
		[CompilerGenerated]
		private sealed class DHNKGHCIBJC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public NFHEFGFIEGC buttonPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
			public DHNKGHCIBJC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0xD9C090", Offset = "0xD9B090", VA = "0x180D9C090")]
			internal bool BCDDDNBEONB(ButtonPaletteItem buttonPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		[CompilerGenerated]
		private sealed class CLMAFHBFBIL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public GGGPFNHODOI togglePaletteType;

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
			public CLMAFHBFBIL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0xD9C090", Offset = "0xD9B090", VA = "0x180D9C090")]
			internal bool KHMIPGPMAPP(TogglePaletteItem togglePaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		[CompilerGenerated]
		private sealed class EDNGKLDPMHK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public PFMFGANNOID mixedTogglePaletteType;

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
			public EDNGKLDPMHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0xD9C090", Offset = "0xD9B090", VA = "0x180D9C090")]
			internal bool GJCADAGHLAC(MixedTogglePaletteItem mixedTogglePaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		[CompilerGenerated]
		private sealed class HGNGANMBEPD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public CCOMJMNHADI makerPenToolPaletteType;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
			public HGNGANMBEPD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0xD9C090", Offset = "0xD9B090", VA = "0x180D9C090")]
			internal bool PMNNIBOLFCG(MakerPenToolPaletteItem makerPenToolPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[CompilerGenerated]
		private sealed class EBMNIHOGNCA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			public DLHMJNFCONB inputFieldPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
			public EBMNIHOGNCA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0xD9C090", Offset = "0xD9B090", VA = "0x180D9C090")]
			internal bool KFAKMBNDLJP(InputFieldPaletteItem inputFieldPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		[CompilerGenerated]
		private sealed class ANGAFDFDDMF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public KFNJBKNBBLC dropdownPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
			public ANGAFDFDDMF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0xD9C090", Offset = "0xD9B090", VA = "0x180D9C090")]
			internal bool CHNGNLABHLK(DropdownPaletteItem dropdownPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000043")]
		[CompilerGenerated]
		private sealed class LPKLNPPMGIG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public HDJDEIFFFAP sliderPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
			public LPKLNPPMGIG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xD9C090", Offset = "0xD9B090", VA = "0x180D9C090")]
			internal bool PONLAONIDDP(SliderPaletteItem sliderPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		[CompilerGenerated]
		private sealed class BCAKLHJGFBA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			public NCMIPOFAKBL depthPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
			public BCAKLHJGFBA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0xD9C090", Offset = "0xD9B090", VA = "0x180D9C090")]
			internal bool DMPFLACAEGG(DepthPaletteItem depthPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[SerializeField]
		[Header("Visual")]
		[PGDCCLHLFJB("RawImageColorPaletteType")]
		private RawImageColorPaletteItem[] rawImageColorPaletteItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[SerializeField]
		[PGDCCLHLFJB("BackgroundColorPaletteType")]
		private BackgroundColorPaletteItem[] backgroundColorPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[SerializeField]
		[PGDCCLHLFJB("ForegroundColorPaletteType")]
		private ForegroundColorPaletteItem[] foregroundColorPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[SerializeField]
		[PGDCCLHLFJB("TilerPaletteType")]
		private TilerPaletteItem[] tilerPaletteItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		[SerializeField]
		[PGDCCLHLFJB("TextStylePaletteType")]
		private TextStylePaletteItem[] textStylePalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		[SerializeField]
		[PGDCCLHLFJB("TextSizePaletteType")]
		private TextSizePaletteItem[] textSizePalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		[SerializeField]
		[PGDCCLHLFJB("ButtonPaletteType")]
		private ButtonPaletteItem[] buttonPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		[SerializeField]
		[PGDCCLHLFJB("TogglePaletteType")]
		private TogglePaletteItem[] togglePalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		[SerializeField]
		[PGDCCLHLFJB("MixedTogglePaletteType")]
		private MixedTogglePaletteItem[] mixedTogglePalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		[SerializeField]
		[PGDCCLHLFJB("MakerPenToolPaletteType")]
		private MakerPenToolPaletteItem[] makerPenToolPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		[SerializeField]
		[PGDCCLHLFJB("InputFieldPaletteType")]
		private InputFieldPaletteItem[] inputFieldPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		[SerializeField]
		[PGDCCLHLFJB("DropdownPaletteType")]
		private DropdownPaletteItem[] dropdownPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		[SerializeField]
		[PGDCCLHLFJB("SliderPaletteType")]
		private SliderPaletteItem[] sliderPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		[SerializeField]
		[PGDCCLHLFJB("DepthPaletteType")]
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
			[Cpp2IlInjected.Address(RVA = "0x94ABE0", Offset = "0x949BE0", VA = "0x18094ABE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public ButtonAnimationPalette ButtonAnimationPalette
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0xA19A10", Offset = "0xA18A10", VA = "0x180A19A10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public AudioPalette AudioPalette
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0xA823E0", Offset = "0xA813E0", VA = "0x180A823E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x4250FB0", Offset = "0x424FFB0", VA = "0x184250FB0")]
		public Color BFPFHDOPBIN(FCGJGKJMPFE EOMGHKBJMAC)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x4251570", Offset = "0x4250570", VA = "0x184251570")]
		public void GNFMNAPKGBH(CFHGFKGIKHE EOMGHKBJMAC, out Color OAIMCLIJEAP, out Gradient KACBMABAGMN, out bool LAKONDPODLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x4251CD0", Offset = "0x4250CD0", VA = "0x184251CD0")]
		public Color PPCFNHGEEGJ(MFHINLCGGJK GAPJBNPHOPB)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x4251AF0", Offset = "0x4250AF0", VA = "0x184251AF0")]
		public TilerPalette NMENFEBOHFB(PAJMPDDCKLB FLAJIGGIBOB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x4251390", Offset = "0x4250390", VA = "0x184251390")]
		public TextStylePalette EBMPMHHHGCD(BAOIAJGBHGD MAILMEPNBFB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x4251A00", Offset = "0x4250A00", VA = "0x184251A00")]
		public int LJLOIDNMIOI(IOLOGGHJHBL OJLFAOINHJF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x42516F0", Offset = "0x42506F0", VA = "0x1842516F0")]
		public ButtonPalette ICCIAGFFPCH(NFHEFGFIEGC ADNCADOEBBB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x42511B0", Offset = "0x42501B0", VA = "0x1842511B0")]
		public TogglePalette DANFHEBDINI(GGGPFNHODOI FJMLEPGMDNC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x42510C0", Offset = "0x42500C0", VA = "0x1842510C0")]
		public MixedTogglePalette CKBBDCHHCAJ(PFMFGANNOID POPIKOOLFLP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x42512A0", Offset = "0x42502A0", VA = "0x1842512A0")]
		public MakerPenToolPalette DNCHDKJJANH(CCOMJMNHADI HKOJAKKABBA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x4251480", Offset = "0x4250480", VA = "0x184251480")]
		public InputFieldPalette FBFBHEKAPIO(DLHMJNFCONB GPONHMKHDJD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x4251BE0", Offset = "0x4250BE0", VA = "0x184251BE0")]
		public DropdownPalette PCNAOPAJEHA(KFNJBKNBBLC FFGNAKDHBJD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x42517E0", Offset = "0x42507E0", VA = "0x1842517E0")]
		public SliderPalette KJCCNCDNPHN(HDJDEIFFFAP OALEDMJOCJN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x42518D0", Offset = "0x42508D0", VA = "0x1842518D0")]
		public float? KMJHIOODMEO(NCMIPOFAKBL CNBHCOKINPO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x4251DE0", Offset = "0x4250DE0", VA = "0x184251DE0")]
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
		[LHIKCFDKPCO(FEMKOOHMMFH.Self, false, false, false)]
		private OLHPBCHCIFK recyclingGrid;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x4252510", Offset = "0x4251510", VA = "0x184252510", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x4252790", Offset = "0x4251790", VA = "0x184252790", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x4252720", Offset = "0x4251720", VA = "0x184252720")]
		private void GFPNNGCBDNH(float GFGGALAHOPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x42529A0", Offset = "0x42519A0", VA = "0x1842529A0")]
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
		private EKCNABIMODC audioPalette;

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public Color BackgroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x9A65D0", Offset = "0x9A55D0", VA = "0x1809A65D0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public ColorBlock BackgroundTints
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x4248EC0", Offset = "0x4247EC0", VA = "0x184248EC0")]
			get
			{
				return default(ColorBlock);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public GradientBlock BackgroundGradients
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x4248E90", Offset = "0x4247E90", VA = "0x184248E90")]
			get
			{
				return default(GradientBlock);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public Color ForegroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0xC18A60", Offset = "0xC17A60", VA = "0x180C18A60")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public ColorBlock ForegroundTints
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x4248F00", Offset = "0x4247F00", VA = "0x184248F00")]
			get
			{
				return default(ColorBlock);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public bool ShowBorder
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x15B01F0", Offset = "0x15AF1F0", VA = "0x1815B01F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public TextStylePalette TextPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x94AC60", Offset = "0x949C60", VA = "0x18094AC60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public EKCNABIMODC AudioPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x94ABF0", Offset = "0x949BF0", VA = "0x18094ABF0")]
			get
			{
				return default(EKCNABIMODC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x4248D90", Offset = "0x4247D90", VA = "0x184248D90")]
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
		[LHIKCFDKPCO(FEMKOOHMMFH.Self, false, false, false)]
		private Graphic graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		[SerializeField]
		private bool useGraphicOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		[SerializeField]
		[DFFLAPBPAEA("useGraphicOverride")]
		private Graphic graphicOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		[SerializeField]
		private MFHINLCGGJK color;

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public Graphic KAOFHCDJOAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x424CF70", Offset = "0x424BF70", VA = "0x18424CF70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public MFHINLCGGJK ACNFOEPHPNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0xA492F0", Offset = "0xA482F0", VA = "0x180A492F0")]
			get
			{
				return default(MFHINLCGGJK);
			}
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x424CF80", Offset = "0x424BF80", VA = "0x18424CF80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public bool KMCPBLCGGNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0xB35DC0", Offset = "0xB34DC0", VA = "0x180B35DC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0xB35FF0", Offset = "0xB34FF0", VA = "0x180B35FF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Color? EMHKBHIPIHG
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x424CEB0", Offset = "0x424BEB0", VA = "0x18424CEB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x424CBD0", Offset = "0x424BBD0", VA = "0x18424CBD0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x424CE50", Offset = "0x424BE50", VA = "0x18424CE50")]
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
		[LHIKCFDKPCO(FEMKOOHMMFH.Self, false, false, false)]
		private RawImage image;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		[SerializeField]
		private FCGJGKJMPFE color;

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public FCGJGKJMPFE HEACOIMNKDA
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0xB92920", Offset = "0xB91920", VA = "0x180B92920")]
			get
			{
				return default(FCGJGKJMPFE);
			}
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x42522E0", Offset = "0x42512E0", VA = "0x1842522E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x4252340", Offset = "0x4251340", VA = "0x184252340", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x4252480", Offset = "0x4251480", VA = "0x184252480")]
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
			[Cpp2IlInjected.Address(RVA = "0x83A5D0", Offset = "0x8395D0", VA = "0x18083A5D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xC2A210", Offset = "0xC29210", VA = "0x180C2A210")]
		public MakerPenToolPalette()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public class TextStylePalette
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public enum OFCBBKMOPIA
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
		private OFCBBKMOPIA transformation;

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public TMP_FontAsset Font
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x83A5D0", Offset = "0x8395D0", VA = "0x18083A5D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public Material FontOverrideMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public float Kerning
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x9877A0", Offset = "0x9867A0", VA = "0x1809877A0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public float Leading
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0xDE9500", Offset = "0xDE8500", VA = "0x180DE9500")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public bool IsBold
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x944220", Offset = "0x943220", VA = "0x180944220")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public bool IsItalic
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x9489B0", Offset = "0x9479B0", VA = "0x1809489B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public OFCBBKMOPIA Transformation
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x10B7150", Offset = "0x10B6150", VA = "0x1810B7150")]
			get
			{
				return default(OFCBBKMOPIA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x42571D0", Offset = "0x42561D0", VA = "0x1842571D0")]
		public void BFMAOAFPDDG(TextMeshProUGUI MPMNABCGOCM, bool PFCMGEGJCHK = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x42574C0", Offset = "0x42564C0", VA = "0x1842574C0")]
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
		private GGGPFNHODOI toggleType;

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
		[DFFLAPBPAEA("overrideAudioPaletteWhenActive")]
		private ButtonAudioPaletteAsset customButtonAudioConfigWhenActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		[SerializeField]
		[Tooltip("Override the audio palette when inactive defined by the toggle's visual with a custom palette")]
		private bool overrideAudioPaletteWhenInactive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		[SerializeField]
		[DFFLAPBPAEA("overrideAudioPaletteWhenInactive")]
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
		[DFFLAPBPAEA("useFlavorSFX")]
		[Tooltip("Flavor SFX is picked randomly from this pool config")]
		private RecRoomAudioClipPoolConfig flavorSFXClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		protected bool AFPONKHEDPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x161")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private bool DCJDENBBCPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x162")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private bool CDIBLPCHBBC;

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public bool EKIGGAAGMNI
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x4258270", Offset = "0x4257270", VA = "0x184258270")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x4258280", Offset = "0x4257280", VA = "0x184258280")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public GGGPFNHODOI IIPEHKMABOF
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x94ABF0", Offset = "0x949BF0", VA = "0x18094ABF0")]
			get
			{
				return default(GGGPFNHODOI);
			}
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x424A9A0", Offset = "0x42499A0", VA = "0x18424A9A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		protected override bool NNMHCDAIBOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x4258140", Offset = "0x4257140", VA = "0x184258140", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x4258100", Offset = "0x4257100", VA = "0x184258100", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x4258150", Offset = "0x4257150", VA = "0x184258150")]
		public void Toggle()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x4258190", Offset = "0x4257190", VA = "0x184258190")]
		public void Toggle(bool CDIBLPCHBBC, bool AFPONKHEDPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x4257D00", Offset = "0x4256D00", VA = "0x184257D00", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x42581D0", Offset = "0x42571D0", VA = "0x1842581D0")]
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
		[ODLINMJGOAE(FEMKOOHMMFH.SelfAndParent, true, false, false)]
		private PaletteTheme paletteTheme;

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		protected PaletteTheme FACGBBLFFLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		protected Palette INDGLHBNGDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x424F6C0", Offset = "0x424E6C0", VA = "0x18424F6C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		protected bool LJGPGBIPBPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x424F440", Offset = "0x424E440", VA = "0x18424F440")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		protected Transform GBPNGMLLLLJ
		{
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x424F3B0", Offset = "0x424E3B0", VA = "0x18424F3B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x424EEF0", Offset = "0x424DEF0", VA = "0x18424EEF0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x424F780", Offset = "0x424E780", VA = "0x18424F780", Slot = "5")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void Apply();

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x424F4E0", Offset = "0x424E4E0", VA = "0x18424F4E0")]
		public Color? GetColorFromPalette(MFHINLCGGJK IKKHLEKOHBK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x424F000", Offset = "0x424E000", VA = "0x18424F000")]
		private void EFPDNODFEHI(bool DJKJCPOGFPJ = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x966840", Offset = "0x965840", VA = "0x180966840")]
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
		[LHIKCFDKPCO(FEMKOOHMMFH.Self, false, false, false)]
		private TMP_InputField inputField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		[SerializeField]
		[ODLINMJGOAE(FEMKOOHMMFH.Self, false, false, false)]
		private Image surface;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		[SerializeField]
		private bool useSurfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		[SerializeField]
		[DFFLAPBPAEA("useSurfaceOverride")]
		private Image surfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		[SerializeField]
		private DLHMJNFCONB inputFieldType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		[SerializeField]
		private IOLOGGHJHBL textSize;

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public Image KLCJLAHEGAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x424BF70", Offset = "0x424AF70", VA = "0x18424BF70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public DLHMJNFCONB NABMCIIBPAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0xADE620", Offset = "0xADD620", VA = "0x180ADE620")]
			get
			{
				return default(DLHMJNFCONB);
			}
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x424BF80", Offset = "0x424AF80", VA = "0x18424BF80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public IOLOGGHJHBL KOABLNPIAMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0xC22BF0", Offset = "0xC21BF0", VA = "0x180C22BF0")]
			get
			{
				return default(IOLOGGHJHBL);
			}
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x424BFA0", Offset = "0x424AFA0", VA = "0x18424BFA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x424D010", Offset = "0x424C010", VA = "0x18424D010", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x424BF00", Offset = "0x424AF00", VA = "0x18424BF00")]
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
		[LHIKCFDKPCO(FEMKOOHMMFH.Self, false, false, false)]
		private RangeSlider slider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		[SerializeField]
		private HDJDEIFFFAP sliderType;

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
		public HDJDEIFFFAP GCOCCKPHMLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0xB92920", Offset = "0xB91920", VA = "0x180B92920")]
			get
			{
				return default(HDJDEIFFFAP);
			}
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x42522E0", Offset = "0x42512E0", VA = "0x1842522E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public Image FBIANJBCIEL
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x936350", Offset = "0x935350", VA = "0x180936350")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public Image KNCOGIAHGGN
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x944E10", Offset = "0x943E10", VA = "0x180944E10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public Image CANNKGEHGFD
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x944E20", Offset = "0x943E20", VA = "0x180944E20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public Image DFKCPIHFEPJ
		{
			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x94B760", Offset = "0x94A760", VA = "0x18094B760")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public bool JJMDENMNACP
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x42522A0", Offset = "0x42512A0", VA = "0x1842522A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x42522C0", Offset = "0x42512C0", VA = "0x1842522C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x4251EE0", Offset = "0x4250EE0", VA = "0x184251EE0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x4252220", Offset = "0x4251220", VA = "0x184252220")]
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
			[Cpp2IlInjected.Address(RVA = "0x9A65D0", Offset = "0x9A55D0", VA = "0x1809A65D0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public Color ForegroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x9A65E0", Offset = "0x9A55E0", VA = "0x1809A65E0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public TextStylePalette TextPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x936350", Offset = "0x935350", VA = "0x180936350")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x424B810", Offset = "0x424A810", VA = "0x18424B810")]
		public DropdownPalette()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public class MixedToggleTheme : ButtonThemeBase
	{
		[Cpp2IlInjected.Token(Token = "0x2000052")]
		public enum DFNOGDBEPPI
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
		private PFMFGANNOID toggleType;

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
		private DFNOGDBEPPI editorIsActiveOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private DFNOGDBEPPI CDIBLPCHBBC;

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public DFNOGDBEPPI EKIGGAAGMNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0xAE9990", Offset = "0xAE8990", VA = "0x180AE9990")]
			get
			{
				return default(DFNOGDBEPPI);
			}
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x424E620", Offset = "0x424D620", VA = "0x18424E620")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x424E640", Offset = "0x424D640", VA = "0x18424E640")]
		public void Toggle()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x424E620", Offset = "0x424D620", VA = "0x18424E620")]
		public void Toggle(DFNOGDBEPPI CDIBLPCHBBC, bool AFPONKHEDPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x424E080", Offset = "0x424D080", VA = "0x18424E080", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x424E670", Offset = "0x424D670", VA = "0x18424E670")]
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
		[LHIKCFDKPCO(FEMKOOHMMFH.Self, false, false, false)]
		private UITiler tiler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		[SerializeField]
		private PAJMPDDCKLB type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private ELCLBKEHMDC NCDMDNPKCPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private ELCJBBOLKOE HHEHMMKDPJJ;

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		private ELCJBBOLKOE LLNIIHEHJPP
		{
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x4257C40", Offset = "0x4256C40", VA = "0x184257C40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		private JDBFMBECFKB DKFECPGJDCO
		{
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x4257750", Offset = "0x4256750", VA = "0x184257750")]
			get
			{
				return default(JDBFMBECFKB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x4257BD0", Offset = "0x4256BD0", VA = "0x184257BD0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x4257830", Offset = "0x4256830", VA = "0x184257830", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x4257CB0", Offset = "0x4256CB0", VA = "0x184257CB0")]
		public TilerTheme()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public enum CFHGFKGIKHE
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
public enum FCGJGKJMPFE
{
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	A
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public enum MFHINLCGGJK
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
public enum PAJMPDDCKLB
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
public enum BAOIAJGBHGD
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
public enum IOLOGGHJHBL
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
public enum NFHEFGFIEGC
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
public enum GGGPFNHODOI
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
public enum PFMFGANNOID
{
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	Checkbox
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public enum CCOMJMNHADI
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
public enum DLHMJNFCONB
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
public enum KFNJBKNBBLC
{
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	LightFlat,
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	DarkFlat
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public enum HDJDEIFFFAP
{
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	MirroUIPopUp
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public enum NCMIPOFAKBL
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
		protected class IMNGEOBGHBH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001D4")]
			public ButtonAudioPaletteAsset BBPGMMNFMKL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001D5")]
			public RecRoomAudioClipPoolConfig JMEALDPGENJ;

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x127EA20", Offset = "0x127DA20", VA = "0x18127EA20")]
			public IMNGEOBGHBH()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		[SerializeField]
		[Header("Button Theme Base")]
		[ODLINMJGOAE(FEMKOOHMMFH.Self, false, false, false)]
		private MultiGraphicButton multiGraphicButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		[SerializeField]
		[ODLINMJGOAE(FEMKOOHMMFH.Self, false, true, false)]
		private Image surface;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		[SerializeField]
		private bool useSurfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		[SerializeField]
		[DFFLAPBPAEA("useSurfaceOverride")]
		private Image surfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		[SerializeField]
		[HNHFGMBAPHI]
		private List<Graphic> graphics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		[SerializeField]
		private bool useGraphicsOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		[SerializeField]
		[DFFLAPBPAEA("useGraphicsOverride")]
		private List<Graphic> graphicsOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		[SerializeField]
		[ODLINMJGOAE(FEMKOOHMMFH.Self, false, true, false)]
		private UIGradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		[SerializeField]
		private bool useGradientOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		[SerializeField]
		[DFFLAPBPAEA("useGradientOverride")]
		private UIGradient gradientOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		[SerializeField]
		[ODLINMJGOAE(FEMKOOHMMFH.Children, true, true, false)]
		private TextMeshProUGUI textMeshProUGUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		[SerializeField]
		private bool useTextMeshProUGUIOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		[SerializeField]
		[DFFLAPBPAEA("useTextMeshProUGUIOverride")]
		private TextMeshProUGUI textMeshProUGUIOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		[SerializeField]
		private IOLOGGHJHBL textSize;

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
		[DFFLAPBPAEA("isAnimationEnabled")]
		protected bool overrideAnimationTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		[SerializeField]
		[DFFLAPBPAEA("overrideAnimationTarget")]
		protected GameObject animationTargetOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private bool FPCDFKEDCOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private Vector3 PFHPAHNKEBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private Vector3 GBJALMEBCAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		private BPHKLIGHAMP IDJCLKGDLHO;

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public Image KLCJLAHEGAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x424A670", Offset = "0x4249670", VA = "0x18424A670")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public List<Graphic> DOCPBFIJMAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x424A650", Offset = "0x4249650", VA = "0x18424A650")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public UIGradient JBAOLBIFGLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x424A630", Offset = "0x4249630", VA = "0x18424A630")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public TextMeshProUGUI EGNMNOLACFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x424A690", Offset = "0x4249690", VA = "0x18424A690")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public IOLOGGHJHBL KOABLNPIAMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x9A75D0", Offset = "0x9A65D0", VA = "0x1809A75D0")]
			get
			{
				return default(IOLOGGHJHBL);
			}
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x424A6B0", Offset = "0x42496B0", VA = "0x18424A6B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		protected Transform OMDCINMJJGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x42490F0", Offset = "0x42480F0", VA = "0x1842490F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		public Button DNDFBPALNFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x424A5B0", Offset = "0x42495B0", VA = "0x18424A5B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x4249CB0", Offset = "0x4248CB0", VA = "0x184249CB0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x4249C10", Offset = "0x4248C10", VA = "0x184249C10")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x4248F50", Offset = "0x4247F50", VA = "0x184248F50")]
		protected void BIKGIDCKPMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x4249150", Offset = "0x4248150", VA = "0x184249150")]
		protected void LJDHAMLLAKF(ButtonPalette PNENGIBNKAF, [Optional] IMNGEOBGHBH KMBLBKECCIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x4249D30", Offset = "0x4248D30", VA = "0x184249D30", Slot = "12")]
		public override void OnPointerDown(PointerEventData MLPMPPLPMHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x424A100", Offset = "0x4249100", VA = "0x18424A100", Slot = "13")]
		public override void OnPointerUp(PointerEventData MLPMPPLPMHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x4249D10", Offset = "0x4248D10", VA = "0x184249D10", Slot = "14")]
		public override void OnPointerClick(PointerEventData MLPMPPLPMHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x42490D0", Offset = "0x42480D0", VA = "0x1842490D0")]
		private Vector3 CLLADOPAHLE(float MCNELIBKDDB)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x424A430", Offset = "0x4249430", VA = "0x18424A430")]
		protected ButtonThemeBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x4249130", Offset = "0x4248130", VA = "0x184249130")]
		[CompilerGenerated]
		private void OJOGCMCNOOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x4249130", Offset = "0x4248130", VA = "0x184249130")]
		[CompilerGenerated]
		private void KDPHBDAADMO()
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
			[Cpp2IlInjected.Address(RVA = "0x9877A0", Offset = "0x9867A0", VA = "0x1809877A0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		public float LoadingSFXStopDelay
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0xDE9500", Offset = "0xDE8500", VA = "0x180DE9500")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		public float MaxLoadingSFXLength
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x97F070", Offset = "0x97E070", VA = "0x18097F070")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		public float FadeInDuration
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x1031FA0", Offset = "0x1030FA0", VA = "0x181031FA0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		public float FadeOutDuration
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x9A65F0", Offset = "0x9A55F0", VA = "0x1809A65F0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x424A9C0", Offset = "0x42499C0", VA = "0x18424A9C0")]
		public bool MDJAIIEKMOJ(out RecRoomAudioClip[] OPDJIOLLIAM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x424A9E0", Offset = "0x42499E0", VA = "0x18424A9E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x83A5D0", Offset = "0x8395D0", VA = "0x18083A5D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		public ButtonPalette ActiveButtonPalette
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x127EA20", Offset = "0x127DA20", VA = "0x18127EA20")]
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
			[Cpp2IlInjected.Address(RVA = "0x9A65D0", Offset = "0x9A55D0", VA = "0x1809A65D0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public Color FillColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x9A65E0", Offset = "0x9A55E0", VA = "0x1809A65E0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public Color HandleColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0xA52180", Offset = "0xA51180", VA = "0x180A52180")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public TextStylePalette TextPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x944E20", Offset = "0x943E20", VA = "0x180944E20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public Color TextColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0xA521F0", Offset = "0xA511F0", VA = "0x180A521F0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public ColorBlock ColorBlock
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x42566A0", Offset = "0x42556A0", VA = "0x1842566A0")]
			get
			{
				return default(ColorBlock);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x42565D0", Offset = "0x42555D0", VA = "0x1842565D0")]
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
		[LHIKCFDKPCO(FEMKOOHMMFH.Self, false, false, false)]
		[Header("Slider Visual")]
		private Slider slider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		[SerializeField]
		private HDJDEIFFFAP sliderType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		[SerializeField]
		[Header("Slider Audio")]
		private EKCNABIMODC buttonAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		[SerializeField]
		[Tooltip("Layer a 2D SFX on top of base button sounds")]
		private bool useFlavorSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		[SerializeField]
		[DFFLAPBPAEA("useFlavorSFX")]
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
		public HDJDEIFFFAP GCOCCKPHMLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0xA94210", Offset = "0xA93210", VA = "0x180A94210")]
			get
			{
				return default(HDJDEIFFFAP);
			}
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x4256B40", Offset = "0x4255B40", VA = "0x184256B40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public Image FBIANJBCIEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0xA19A10", Offset = "0xA18A10", VA = "0x180A19A10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public Image KNCOGIAHGGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0xA823E0", Offset = "0xA813E0", VA = "0x180A823E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		public Image JDENHFEDPBG
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x842FB0", Offset = "0x841FB0", VA = "0x180842FB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x42566E0", Offset = "0x42556E0", VA = "0x1842566E0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x4256AC0", Offset = "0x4255AC0", VA = "0x184256AC0")]
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
		private CCOMJMNHADI makerPenToolPaletteType;

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
		protected bool AFPONKHEDPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x132")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		private bool CDIBLPCHBBC;

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public CCOMJMNHADI FDNJCGILJDA
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x94ABF0", Offset = "0x949BF0", VA = "0x18094ABF0")]
			get
			{
				return default(CCOMJMNHADI);
			}
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x424A9A0", Offset = "0x42499A0", VA = "0x18424A9A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public bool EKIGGAAGMNI
		{
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x105ACD0", Offset = "0x1059CD0", VA = "0x18105ACD0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x424DD80", Offset = "0x424CD80", VA = "0x18424DD80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x424DCE0", Offset = "0x424CCE0", VA = "0x18424DCE0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x424D900", Offset = "0x424C900", VA = "0x18424D900", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x424DD20", Offset = "0x424CD20", VA = "0x18424DD20")]
		public MakerPenToolTheme()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public enum EKCNABIMODC
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
public enum HGDALCDFGPL
{
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	Default
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public enum LNGCAFPMEOK
{
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	Default
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public enum DLHLIBKODJA
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
			[Cpp2IlInjected.Address(RVA = "0x97F070", Offset = "0x97E070", VA = "0x18097F070")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		public float MinimumTimeIntervalForScrollingSFX
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x1031FA0", Offset = "0x1030FA0", VA = "0x181031FA0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x424A9C0", Offset = "0x42499C0", VA = "0x18424A9C0")]
		public bool KLLMFINJDBH(out RecRoomAudioClip[] OPDJIOLLIAM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x4255840", Offset = "0x4254840", VA = "0x184255840")]
		public bool MOBBEIABDPG(out RecRoomAudioClip[] OPDJIOLLIAM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x4255860", Offset = "0x4254860", VA = "0x184255860")]
		public ScrollingAudioPaletteAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public class ScrollRectTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		private const string MPGFJODCJOK = "RRUI.PlayHittingEndsSFX";

		[Cpp2IlInjected.Token(Token = "0x4000208")]
		private const int IJEEJMJEMGN = 5;

		[Cpp2IlInjected.Token(Token = "0x4000209")]
		private const int CNNHLBNMLFP = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private DateTimeOffset NCMKMEEBHMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private int EPINHJMCKJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private bool FHLOCALFMMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		[SerializeField]
		[LHIKCFDKPCO(FEMKOOHMMFH.Self, false, false, false)]
		private ScrollRect scrollRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		[SerializeField]
		[Header("Audio")]
		private HGDALCDFGPL scrollAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private ScrollingAudioPaletteAsset CIAMNJBIPFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		private EMBGBMCGBNC JPDLFOIMNBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		private BJIJOBOKPBN MKBJEIMOLAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		private float CKMOLDDJDAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		private float OINBBHPPGGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		private float OJBDLEGCNHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private bool JEAEGMEONDN;

		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private const float FLGJNOBAOMH = 0.01f;

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		private EMBGBMCGBNC IKKCAJJGFOD
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x42543F0", Offset = "0x42533F0", VA = "0x1842543F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		private BJIJOBOKPBN AJFAIIDLLMK
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x4254460", Offset = "0x4253460", VA = "0x184254460")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x42541D0", Offset = "0x42531D0", VA = "0x1842541D0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x4255680", Offset = "0x4254680", VA = "0x184255680", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x42540D0", Offset = "0x42530D0", VA = "0x1842540D0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x42551E0", Offset = "0x42541E0", VA = "0x1842551E0")]
		private void MCAGFFMPCOO(Vector2 EDEGPGKBEGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x4253EE0", Offset = "0x4252EE0", VA = "0x184253EE0")]
		private void ADBPEGBINML(float FBCJBEIAPCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x42544D0", Offset = "0x42534D0", VA = "0x1842544D0")]
		private void LCAPFHCCLKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x4255550", Offset = "0x4254550", VA = "0x184255550")]
		private static string MOLNNEJNABB(GameObject DCGPCJKHCOO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x4255790", Offset = "0x4254790", VA = "0x184255790")]
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
		[LHIKCFDKPCO(FEMKOOHMMFH.Self, false, false, false)]
		private TextMeshProUGUI textMeshProUGUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		[SerializeField]
		private BAOIAJGBHGD textType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		[SerializeField]
		private IOLOGGHJHBL textSize;

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public BAOIAJGBHGD BPBOLAPLIAM
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0xADCD60", Offset = "0xADBD60", VA = "0x180ADCD60")]
			get
			{
				return default(BAOIAJGBHGD);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x424D8E0", Offset = "0x424C8E0", VA = "0x18424D8E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		public IOLOGGHJHBL KOABLNPIAMI
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0xB9A5C0", Offset = "0xB995C0", VA = "0x180B9A5C0")]
			get
			{
				return default(IOLOGGHJHBL);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x424D8C0", Offset = "0x424C8C0", VA = "0x18424D8C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x424D520", Offset = "0x424C520", VA = "0x18424D520", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x424D850", Offset = "0x424C850", VA = "0x18424D850")]
		public LabelTheme()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class FDBBNKLFMFL
{
	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
	public FDBBNKLFMFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x12847F0", Offset = "0x12837F0", VA = "0x1812847F0")]
	public static string PBLDHIKHPMH(byte[] IHGCJCCJPMA, byte[] NBKBACBBOJK)
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
