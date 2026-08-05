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
		private sealed class IJPMOACKLLP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public TMP_FontAsset font;

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
			public IJPMOACKLLP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x6355A90", Offset = "0x6354290", VA = "0x186355A90")]
			internal bool LBJEKGGKFHK(LocalizedFontMapping x)
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
			[Cpp2IlInjected.Address(RVA = "0x6355330", Offset = "0x6353B30", VA = "0x186355330")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public TMP_SpriteAsset EmojiAsset
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x766110", Offset = "0x764910", VA = "0x180766110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6355200", Offset = "0x6353A00", VA = "0x186355200")]
		public bool PNDIEFDKDJB(TMP_FontAsset KECEADGOAJK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6354C90", Offset = "0x6353490", VA = "0x186354C90")]
		public TMP_FontAsset ADBBNKADILC(TMP_FontAsset KECEADGOAJK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6354A50", Offset = "0x6353250", VA = "0x186354A50")]
		public TMP_FontAsset ADBBNKADILC(TMP_FontAsset KECEADGOAJK, Material MLHBHDBEPEI, [Out] Material GDHCLPEDNLI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x63550A0", Offset = "0x63538A0", VA = "0x1863550A0")]
		public TMP_FontAsset LMLMELMLGBK(TMP_FontAsset KECEADGOAJK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6354EA0", Offset = "0x63536A0", VA = "0x186354EA0")]
		public TMP_FontAsset LMLMELMLGBK(TMP_FontAsset KECEADGOAJK, Material MLHBHDBEPEI, [Out] Material ELDEFKMEBJA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6354DF0", Offset = "0x63535F0", VA = "0x186354DF0")]
		private static bool KMHEBAOFABC(TMP_FontAsset KECEADGOAJK, LocalizedFontMapping LPAFCFCGMKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x848550", Offset = "0x846D50", VA = "0x180848550")]
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
			[Cpp2IlInjected.Address(RVA = "0x635FA40", Offset = "0x635E240", VA = "0x18635FA40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Palette Active
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x635FA10", Offset = "0x635E210", VA = "0x18635FA10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x848550", Offset = "0x846D50", VA = "0x180848550")]
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
		[Cpp2IlInjected.Address(RVA = "0x63554F0", Offset = "0x6353CF0", VA = "0x1863554F0", Slot = "0")]
		public override bool Equals(object CBBCDNDPNHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6355490", Offset = "0x6353C90", VA = "0x186355490", Slot = "4")]
		public bool Equals(GradientBlock IFHFGCDLDEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x63555D0", Offset = "0x6353DD0", VA = "0x1863555D0", Slot = "2")]
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
		public List<Graphic> PGMGKCNFNLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8B6420", Offset = "0x8B4C20", VA = "0x1808B6420")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8B6790", Offset = "0x8B4F90", VA = "0x1808B6790")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public ColorBlock NLIEINBPCJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x63577C0", Offset = "0x6355FC0", VA = "0x1863577C0")]
			get
			{
				return default(ColorBlock);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x6357840", Offset = "0x6356040", VA = "0x186357840")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public UIGradient HMHOABDJOOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8B6430", Offset = "0x8B4C30", VA = "0x1808B6430")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8B67B0", Offset = "0x8B4FB0", VA = "0x1808B67B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public GradientBlock EIJNJBKIHEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6357810", Offset = "0x6356010", VA = "0x186357810")]
			get
			{
				return default(GradientBlock);
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6357890", Offset = "0x6356090", VA = "0x186357890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x63574F0", Offset = "0x6355CF0", VA = "0x1863574F0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6357540", Offset = "0x6355D40", VA = "0x186357540", Slot = "36")]
		public override void OnSelect(BaseEventData HOCFILEOKMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6357680", Offset = "0x6355E80", VA = "0x186357680")]
		public void Refresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x63574B0", Offset = "0x6355CB0", VA = "0x1863574B0")]
		public void ForceHighlighted(bool CHFBFOLNPJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x63574D0", Offset = "0x6355CD0", VA = "0x1863574D0")]
		public void ForceNormal(bool CHFBFOLNPJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6357150", Offset = "0x6355950", VA = "0x186357150", Slot = "26")]
		protected override void DoStateTransition(SelectionState CDOGIGHJFKJ, bool CHFBFOLNPJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6357590", Offset = "0x6355D90", VA = "0x186357590")]
		private void PGJHIFEHKKO(Graphic JNPCPNCDGKL, Color HLPPMHJDJLN, bool CHFBFOLNPJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6357050", Offset = "0x6355850", VA = "0x186357050")]
		private void CJDCOFAFBIK(SelectionState CDOGIGHJFKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x63576B0", Offset = "0x6355EB0", VA = "0x1863576B0")]
		public MultiGraphicButton()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum DMCLKDIHOKH
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
public enum JPGBEKHKEGK
{
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Default
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public enum LPCFJPKBCOI
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	Default
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum IJCKKCMMDJA
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
			private DMCLKDIHOKH buttonAudioPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			[SerializeField]
			private ButtonAudioPaletteAsset buttonAudioPaletteConfig;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public DMCLKDIHOKH ButtonAudioPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x761180", Offset = "0x75F980", VA = "0x180761180")]
				get
				{
					return default(DMCLKDIHOKH);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public ButtonAudioPaletteAsset ButtonAudioPaletteConfig
			{
				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
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
			private JPGBEKHKEGK scrollingAudioPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			[SerializeField]
			private ScrollingAudioPaletteAsset scrollingAudioPaletteConfig;

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public JPGBEKHKEGK ScrollingAudioPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0x761180", Offset = "0x75F980", VA = "0x180761180")]
				get
				{
					return default(JPGBEKHKEGK);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public ScrollingAudioPaletteAsset ScrollingAudioPaletteConfig
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
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
			private LPCFJPKBCOI contentLoadingAudioPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			[SerializeField]
			private ContentLoadingAudioPaletteAsset contentLoadingAudioPaletteConfig;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public LPCFJPKBCOI ContentLoadingAudioPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x761180", Offset = "0x75F980", VA = "0x180761180")]
				get
				{
					return default(LPCFJPKBCOI);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public ContentLoadingAudioPaletteAsset ContentLoadingAudioPaletteConfig
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
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
			private IJCKKCMMDJA recyclingAudioPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			[SerializeField]
			private RecyclingAudioPaletteAsset recyclingAudioPaletteConfig;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public IJCKKCMMDJA RecyclingAudioPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x761180", Offset = "0x75F980", VA = "0x180761180")]
				get
				{
					return default(IJCKKCMMDJA);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public RecyclingAudioPaletteAsset RecyclingAudioPaletteConfig
			{
				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
			public RecyclingAudioPaletteItem()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class NLFKPALPHFJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public DMCLKDIHOKH buttonAudioPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
			public NLFKPALPHFJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xC1C640", Offset = "0xC1AE40", VA = "0x180C1C640")]
			internal bool EFBOHLBJJJK(ButtonAudioPaletteItem buttonAudioPalette)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class HJOCLLHGPAF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public JPGBEKHKEGK scrollingAudioPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
			public HJOCLLHGPAF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xC1C640", Offset = "0xC1AE40", VA = "0x180C1C640")]
			internal bool FGLLLELMCKL(ScrollingAudioPaletteItem scrollingAudioPalette)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class MFLCNONIBOF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public LPCFJPKBCOI contentLoadingAudioPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
			public MFLCNONIBOF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xC1C640", Offset = "0xC1AE40", VA = "0x180C1C640")]
			internal bool KBKHNOBADIJ(ContentLoadingAudioPaletteItem contentLoadingAudioPalette)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class BPKFDLCOJAO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public IJCKKCMMDJA recyclingAudioPaletteType;

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
			public BPKFDLCOJAO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xC1C640", Offset = "0xC1AE40", VA = "0x180C1C640")]
			internal bool FOFMFHKLHDG(RecyclingAudioPaletteItem recyclingAudioPalette)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[SerializeField]
		[DFCDIMJJEDM("ButtonAudioPaletteType")]
		private ButtonAudioPaletteItem[] buttonAudioPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[SerializeField]
		[DFCDIMJJEDM("ScrollingAudioPaletteType")]
		private ScrollingAudioPaletteItem[] scrollingAudioPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[SerializeField]
		[DFCDIMJJEDM("ContentLoadingAudioPaletteType")]
		private ContentLoadingAudioPaletteItem[] contentLoadingAudioPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[SerializeField]
		[DFCDIMJJEDM("RecyclingAudioPaletteType")]
		private RecyclingAudioPaletteItem[] recyclingAudioPalettes;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6351510", Offset = "0x634FD10", VA = "0x186351510")]
		public ButtonAudioPaletteAsset GAEOMPJBJPI(DMCLKDIHOKH KEFFIIIKEEM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6351420", Offset = "0x634FC20", VA = "0x186351420")]
		public ScrollingAudioPaletteAsset FIANEKLDNAA(JPGBEKHKEGK PHDGLIGJFIF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6351600", Offset = "0x634FE00", VA = "0x186351600")]
		public ContentLoadingAudioPaletteAsset HMICHAMGHGA(LPCFJPKBCOI NLGCDEEFLBF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x63516F0", Offset = "0x634FEF0", VA = "0x1863516F0")]
		public RecyclingAudioPaletteAsset MCPOIFHIILG(IJCKKCMMDJA IDLFIBLIPNI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x848550", Offset = "0x846D50", VA = "0x180848550")]
		public AudioPalette()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class BaseAudioPaletteAsset : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6351860", Offset = "0x6350060", VA = "0x186351860")]
		protected bool HGAGHNFKMJI(RecRoomAudioClipPoolConfig MIPLBCAMLJE, [Out] RecRoomAudioClip[] CLHJNOOEEDL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x848550", Offset = "0x846D50", VA = "0x180848550")]
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
			[Cpp2IlInjected.Address(RVA = "0x7EE890", Offset = "0x7ED090", VA = "0x1807EE890")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public float ClickAnimationScale
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x86FB70", Offset = "0x86E370", VA = "0x18086FB70")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6351910", Offset = "0x6350110", VA = "0x186351910")]
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
			[Cpp2IlInjected.Address(RVA = "0x63519B0", Offset = "0x63501B0", VA = "0x1863519B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public RecRoomAudioClip[] PointerUpAudioClipPool
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6351AB0", Offset = "0x63502B0", VA = "0x186351AB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public RecRoomAudioClip[] PointerClickAudioClipPool
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x6351930", Offset = "0x6350130", VA = "0x186351930")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public RecRoomAudioClip[] PointerEnterAudioClipPool
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6351A30", Offset = "0x6350230", VA = "0x186351A30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x848550", Offset = "0x846D50", VA = "0x180848550")]
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
		private DMCLKDIHOKH audioPalette;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Color BackgroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xA8BA40", Offset = "0xA8A240", VA = "0x180A8BA40")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public ColorBlock BackgroundTints
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6351C30", Offset = "0x6350430", VA = "0x186351C30")]
			get
			{
				return default(ColorBlock);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public GradientBlock BackgroundGradients
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x1AD5A30", Offset = "0x1AD4230", VA = "0x181AD5A30")]
			get
			{
				return default(GradientBlock);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Color ForegroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x10C8480", Offset = "0x10C6C80", VA = "0x1810C8480")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ColorBlock ForegroundTints
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x6351C70", Offset = "0x6350470", VA = "0x186351C70")]
			get
			{
				return default(ColorBlock);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool ShowBorder
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x8EF480", Offset = "0x8EDC80", VA = "0x1808EF480")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public TextStylePalette TextPalette
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8B6420", Offset = "0x8B4C20", VA = "0x1808B6420")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public DMCLKDIHOKH AudioPalette
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x10EDC60", Offset = "0x10EC460", VA = "0x1810EDC60")]
			get
			{
				return default(DMCLKDIHOKH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6351B30", Offset = "0x6350330", VA = "0x186351B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x7B7860", Offset = "0x7B6060", VA = "0x1807B7860")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float LoadingSFXStopDelay
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x7B7B40", Offset = "0x7B6340", VA = "0x1807B7B40")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float MaxLoadingSFXLength
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x7B7DF0", Offset = "0x7B65F0", VA = "0x1807B7DF0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float FadeInDuration
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x7B7B30", Offset = "0x7B6330", VA = "0x1807B7B30")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public float FadeOutDuration
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x803000", Offset = "0x801800", VA = "0x180803000")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6353620", Offset = "0x6351E20", VA = "0x186353620")]
		public bool CNCNBKHCEPN([Out] RecRoomAudioClip[] CLHJNOOEEDL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x63536D0", Offset = "0x6351ED0", VA = "0x1863536D0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA86B30", Offset = "0xA85330", VA = "0x180A86B30")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
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
			[Cpp2IlInjected.Address(RVA = "0xA8BA40", Offset = "0xA8A240", VA = "0x180A8BA40")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public TextStylePalette TextPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x76B5B0", Offset = "0x769DB0", VA = "0x18076B5B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x63543E0", Offset = "0x6352BE0", VA = "0x1863543E0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA8BA40", Offset = "0xA8A240", VA = "0x180A8BA40")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Color ForegroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xD48CA0", Offset = "0xD474A0", VA = "0x180D48CA0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Color PlaceholderColor
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xD5F460", Offset = "0xD5DC60", VA = "0x180D5F460")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public TextStylePalette TextPalette
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x766140", Offset = "0x764940", VA = "0x180766140")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6355B10", Offset = "0x6354310", VA = "0x186355B10")]
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
			[Cpp2IlInjected.Address(RVA = "0x765EF0", Offset = "0x7646F0", VA = "0x180765EF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
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
			[Cpp2IlInjected.Address(RVA = "0x63568B0", Offset = "0x63550B0", VA = "0x1863568B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public RecRoomAudioClip[] MenuOpen2DFlavorAudioClipPool
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x6356930", Offset = "0x6355130", VA = "0x186356930")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public RecRoomAudioClip[] MenuDehydrateAudioClipPool
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x6356830", Offset = "0x6355030", VA = "0x186356830")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public RecRoomAudioClip[] MenuClose2DFlavorAudioClipPool
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x63567B0", Offset = "0x6354FB0", VA = "0x1863567B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x848550", Offset = "0x846D50", VA = "0x180848550")]
		public MenuAudioPaletteAsset()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class MixedTogglePalette
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		private enum IMNIEBICCLK
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
		private IIFOGMALIEG baseTogglePalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[SerializeField]
		private IMNIEBICCLK mixedPaletteType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[SerializeField]
		[IJNIOHAIOOA("mixedPaletteType", IMNIEBICCLK.UseCustom)]
		private ButtonPalette mixedButtonPalette;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6356A20", Offset = "0x6355220", VA = "0x186356A20")]
		public TogglePalette CPLECCMJECM(Palette DENNIMGHFMB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x63569B0", Offset = "0x63551B0", VA = "0x1863569B0")]
		public ButtonPalette AFIJDLCIJHO(Palette DENNIMGHFMB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
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
			private CPDCFKFIIGF paletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			[SerializeField]
			private Color color;

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public CPDCFKFIIGF RawImageColorPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0x761180", Offset = "0x75F980", VA = "0x180761180")]
				get
				{
					return default(CPDCFKFIIGF);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public Color Color
			{
				[Cpp2IlInjected.Token(Token = "0x600007D")]
				[Cpp2IlInjected.Address(RVA = "0xCAB600", Offset = "0xCA9E00", VA = "0x180CAB600")]
				get
				{
					return default(Color);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x7A8FD0", Offset = "0x7A77D0", VA = "0x1807A8FD0")]
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
			private NKPNKBHIEIK backgroundColorPaletteType;

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
			public NKPNKBHIEIK BackgroundColorPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600007F")]
				[Cpp2IlInjected.Address(RVA = "0x761180", Offset = "0x75F980", VA = "0x180761180")]
				get
				{
					return default(NKPNKBHIEIK);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public Color Color
			{
				[Cpp2IlInjected.Token(Token = "0x6000080")]
				[Cpp2IlInjected.Address(RVA = "0xCAB600", Offset = "0xCA9E00", VA = "0x180CAB600")]
				get
				{
					return default(Color);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public Gradient Gradient
			{
				[Cpp2IlInjected.Token(Token = "0x6000081")]
				[Cpp2IlInjected.Address(RVA = "0x765D00", Offset = "0x764500", VA = "0x180765D00")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public bool RaycastTarget
			{
				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0x7B7C00", Offset = "0x7B6400", VA = "0x1807B7C00")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x63517E0", Offset = "0x634FFE0", VA = "0x1863517E0")]
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
			private JHMMIMNOMPG foregroundColorPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			[SerializeField]
			private Color color;

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public JHMMIMNOMPG ForegroundColorPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x761180", Offset = "0x75F980", VA = "0x180761180")]
				get
				{
					return default(JHMMIMNOMPG);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public Color Color
			{
				[Cpp2IlInjected.Token(Token = "0x6000085")]
				[Cpp2IlInjected.Address(RVA = "0xCAB600", Offset = "0xCA9E00", VA = "0x180CAB600")]
				get
				{
					return default(Color);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x6355470", Offset = "0x6353C70", VA = "0x186355470")]
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
			private ALGINPPPEEJ tilerPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			[SerializeField]
			private TilerPalette tilerPalette;

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public ALGINPPPEEJ TilerPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0x761180", Offset = "0x75F980", VA = "0x180761180")]
				get
				{
					return default(ALGINPPPEEJ);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public TilerPalette TilerPalette
			{
				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
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
			private MPKJBFKPFGB textStylePaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			[SerializeField]
			private TextStylePalette textStylePalette;

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public MPKJBFKPFGB TextStylePaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600008A")]
				[Cpp2IlInjected.Address(RVA = "0x761180", Offset = "0x75F980", VA = "0x180761180")]
				get
				{
					return default(MPKJBFKPFGB);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public TextStylePalette TextStylePalette
			{
				[Cpp2IlInjected.Token(Token = "0x600008B")]
				[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
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
			private DHEBDNHGKMI textSizePaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			[SerializeField]
			private int size;

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			public DHEBDNHGKMI TextSizePaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0x761180", Offset = "0x75F980", VA = "0x180761180")]
				get
				{
					return default(DHEBDNHGKMI);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public int Size
			{
				[Cpp2IlInjected.Token(Token = "0x600008E")]
				[Cpp2IlInjected.Address(RVA = "0x8C9910", Offset = "0x8C8110", VA = "0x1808C9910")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x8084D0", Offset = "0x806CD0", VA = "0x1808084D0")]
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
			private JENICDLJDCF buttonPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			[SerializeField]
			private ButtonPalette buttonPalette;

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public JENICDLJDCF ButtonPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000090")]
				[Cpp2IlInjected.Address(RVA = "0x761180", Offset = "0x75F980", VA = "0x180761180")]
				get
				{
					return default(JENICDLJDCF);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000042")]
			public ButtonPalette ButtonPalette
			{
				[Cpp2IlInjected.Token(Token = "0x6000091")]
				[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
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
			private IIFOGMALIEG togglePaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			[SerializeField]
			private TogglePalette togglePalette;

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			public IIFOGMALIEG TogglePaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000093")]
				[Cpp2IlInjected.Address(RVA = "0x761180", Offset = "0x75F980", VA = "0x180761180")]
				get
				{
					return default(IIFOGMALIEG);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			public TogglePalette TogglePalette
			{
				[Cpp2IlInjected.Token(Token = "0x6000094")]
				[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
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
			private NKLJNNHEDJJ mixedTogglePaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			[SerializeField]
			private MixedTogglePalette mixedTogglePalette;

			[Cpp2IlInjected.Token(Token = "0x17000045")]
			public NKLJNNHEDJJ MixedTogglePaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000096")]
				[Cpp2IlInjected.Address(RVA = "0x761180", Offset = "0x75F980", VA = "0x180761180")]
				get
				{
					return default(NKLJNNHEDJJ);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000046")]
			public MixedTogglePalette MixedTogglePalette
			{
				[Cpp2IlInjected.Token(Token = "0x6000097")]
				[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
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
			private NHOJFHOBDIL makerPenToolPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			[SerializeField]
			private MakerPenToolPalette makerPenToolPalette;

			[Cpp2IlInjected.Token(Token = "0x17000047")]
			public NHOJFHOBDIL MakerPenToolPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000099")]
				[Cpp2IlInjected.Address(RVA = "0x761180", Offset = "0x75F980", VA = "0x180761180")]
				get
				{
					return default(NHOJFHOBDIL);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000048")]
			public MakerPenToolPalette MakerPenToolPalette
			{
				[Cpp2IlInjected.Token(Token = "0x600009A")]
				[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
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
			private CDPHNHHANDB inputFieldPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			[SerializeField]
			private InputFieldPalette inputFieldPalette;

			[Cpp2IlInjected.Token(Token = "0x17000049")]
			public CDPHNHHANDB InputFieldPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600009C")]
				[Cpp2IlInjected.Address(RVA = "0x761180", Offset = "0x75F980", VA = "0x180761180")]
				get
				{
					return default(CDPHNHHANDB);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004A")]
			public InputFieldPalette InputFieldPalette
			{
				[Cpp2IlInjected.Token(Token = "0x600009D")]
				[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
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
			private DCDNEHHCDGC dropdownPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			[SerializeField]
			private DropdownPalette dropdownPalette;

			[Cpp2IlInjected.Token(Token = "0x1700004B")]
			public DCDNEHHCDGC DropdownPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600009F")]
				[Cpp2IlInjected.Address(RVA = "0x761180", Offset = "0x75F980", VA = "0x180761180")]
				get
				{
					return default(DCDNEHHCDGC);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004C")]
			public DropdownPalette DropdownPalette
			{
				[Cpp2IlInjected.Token(Token = "0x60000A0")]
				[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
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
			private PLOMGFCEKLJ sliderPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			[SerializeField]
			private SliderPalette sliderPalette;

			[Cpp2IlInjected.Token(Token = "0x1700004D")]
			public PLOMGFCEKLJ SliderPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x60000A2")]
				[Cpp2IlInjected.Address(RVA = "0x761180", Offset = "0x75F980", VA = "0x180761180")]
				get
				{
					return default(PLOMGFCEKLJ);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004E")]
			public SliderPalette SliderPalette
			{
				[Cpp2IlInjected.Token(Token = "0x60000A3")]
				[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
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
			private NKPPCEGGIOK depthPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			[SerializeField]
			private DepthPalette depthPalette;

			[Cpp2IlInjected.Token(Token = "0x1700004F")]
			public NKPPCEGGIOK DepthPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x60000A5")]
				[Cpp2IlInjected.Address(RVA = "0x761180", Offset = "0x75F980", VA = "0x180761180")]
				get
				{
					return default(NKPPCEGGIOK);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000050")]
			public DepthPalette DepthPalette
			{
				[Cpp2IlInjected.Token(Token = "0x60000A6")]
				[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
			public DepthPaletteItem()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[CompilerGenerated]
		private sealed class ELFGEKEHDHE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			public CPDCFKFIIGF backgroundColorPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
			public ELFGEKEHDHE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xC1C640", Offset = "0xC1AE40", VA = "0x180C1C640")]
			internal bool LDNJLPDDIDJ(RawImageColorPaletteItem pi)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		[CompilerGenerated]
		private sealed class JBGJKCEMNLH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			public NKPNKBHIEIK backgroundColorPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
			public JBGJKCEMNLH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xC1C640", Offset = "0xC1AE40", VA = "0x180C1C640")]
			internal bool OGPEDAAGKMF(BackgroundColorPaletteItem backgroundColorPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class OEOOFKGPBKB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public JHMMIMNOMPG foregroundColorPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
			public OEOOFKGPBKB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xC1C640", Offset = "0xC1AE40", VA = "0x180C1C640")]
			internal bool MFFPFDFGGIP(ForegroundColorPaletteItem colorPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class ACKMBKLNJPK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public ALGINPPPEEJ type;

			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
			public ACKMBKLNJPK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xC1C640", Offset = "0xC1AE40", VA = "0x180C1C640")]
			internal bool CPFMPEJIBPK(TilerPaletteItem tilerPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000035")]
		[CompilerGenerated]
		private sealed class PEFHNKELIPD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public MPKJBFKPFGB textStylePaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
			public PEFHNKELIPD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xC1C640", Offset = "0xC1AE40", VA = "0x180C1C640")]
			internal bool ADGEMKJLLFN(TextStylePaletteItem textStylePaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000036")]
		[CompilerGenerated]
		private sealed class HCHPPAGNHGP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public DHEBDNHGKMI textSizePaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
			public HCHPPAGNHGP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xC1C640", Offset = "0xC1AE40", VA = "0x180C1C640")]
			internal bool PKGCNANBCLH(TextSizePaletteItem textSizePaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[CompilerGenerated]
		private sealed class IFIPLNNLABB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public JENICDLJDCF buttonPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
			public IFIPLNNLABB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xC1C640", Offset = "0xC1AE40", VA = "0x180C1C640")]
			internal bool FAAJPIPILHE(ButtonPaletteItem buttonPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		[CompilerGenerated]
		private sealed class IOKCBAEGAMD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public IIFOGMALIEG togglePaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
			public IOKCBAEGAMD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xC1C640", Offset = "0xC1AE40", VA = "0x180C1C640")]
			internal bool DDFIKPHDKBG(TogglePaletteItem togglePaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000039")]
		[CompilerGenerated]
		private sealed class IJMBLCDLCEB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			public NKLJNNHEDJJ mixedTogglePaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
			public IJMBLCDLCEB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xC1C640", Offset = "0xC1AE40", VA = "0x180C1C640")]
			internal bool FFOAEJNLIIF(MixedTogglePaletteItem mixedTogglePaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		[CompilerGenerated]
		private sealed class NGHIEPFMADO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public NHOJFHOBDIL makerPenToolPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
			public NGHIEPFMADO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0xC1C640", Offset = "0xC1AE40", VA = "0x180C1C640")]
			internal bool LMFMFOPEGJA(MakerPenToolPaletteItem makerPenToolPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		[CompilerGenerated]
		private sealed class KOLKDFECDBO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public CDPHNHHANDB inputFieldPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
			public KOLKDFECDBO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0xC1C640", Offset = "0xC1AE40", VA = "0x180C1C640")]
			internal bool OFPHFFFHNJP(InputFieldPaletteItem inputFieldPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		[CompilerGenerated]
		private sealed class EKALHOMMILA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			public DCDNEHHCDGC dropdownPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
			public EKALHOMMILA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0xC1C640", Offset = "0xC1AE40", VA = "0x180C1C640")]
			internal bool BNMMGPHHGFG(DropdownPaletteItem dropdownPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003D")]
		[CompilerGenerated]
		private sealed class HDBNICCDEEB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public PLOMGFCEKLJ sliderPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
			public HDBNICCDEEB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0xC1C640", Offset = "0xC1AE40", VA = "0x180C1C640")]
			internal bool NBBKEEJIEEC(SliderPaletteItem sliderPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		[CompilerGenerated]
		private sealed class FKJHPFDAJAL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			public NKPPCEGGIOK depthPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
			public FKJHPFDAJAL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0xC1C640", Offset = "0xC1AE40", VA = "0x180C1C640")]
			internal bool JMHHAMEMHFK(DepthPaletteItem depthPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[Header("Visual")]
		[SerializeField]
		[DFCDIMJJEDM("RawImageColorPaletteType")]
		private RawImageColorPaletteItem[] rawImageColorPaletteItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[SerializeField]
		[DFCDIMJJEDM("BackgroundColorPaletteType")]
		private BackgroundColorPaletteItem[] backgroundColorPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[SerializeField]
		[DFCDIMJJEDM("ForegroundColorPaletteType")]
		private ForegroundColorPaletteItem[] foregroundColorPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[SerializeField]
		[DFCDIMJJEDM("TilerPaletteType")]
		private TilerPaletteItem[] tilerPaletteItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[SerializeField]
		[DFCDIMJJEDM("TextStylePaletteType")]
		private TextStylePaletteItem[] textStylePalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[SerializeField]
		[DFCDIMJJEDM("TextSizePaletteType")]
		private TextSizePaletteItem[] textSizePalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[SerializeField]
		[DFCDIMJJEDM("ButtonPaletteType")]
		private ButtonPaletteItem[] buttonPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[SerializeField]
		[DFCDIMJJEDM("TogglePaletteType")]
		private TogglePaletteItem[] togglePalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[SerializeField]
		[DFCDIMJJEDM("MixedTogglePaletteType")]
		private MixedTogglePaletteItem[] mixedTogglePalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[SerializeField]
		[DFCDIMJJEDM("MakerPenToolPaletteType")]
		private MakerPenToolPaletteItem[] makerPenToolPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[SerializeField]
		[DFCDIMJJEDM("InputFieldPaletteType")]
		private InputFieldPaletteItem[] inputFieldPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[SerializeField]
		[DFCDIMJJEDM("DropdownPaletteType")]
		private DropdownPaletteItem[] dropdownPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[SerializeField]
		[DFCDIMJJEDM("SliderPaletteType")]
		private SliderPaletteItem[] sliderPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[SerializeField]
		[DFCDIMJJEDM("DepthPaletteType")]
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
			[Cpp2IlInjected.Address(RVA = "0x768D30", Offset = "0x767530", VA = "0x180768D30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public ButtonAnimationPalette ButtonAnimationPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x768CB0", Offset = "0x7674B0", VA = "0x180768CB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public AudioPalette AudioPalette
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x8120A0", Offset = "0x8108A0", VA = "0x1808120A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x635A200", Offset = "0x6358A00", VA = "0x18635A200")]
		public Color IEGGCCHDCBG(CPDCFKFIIGF NPCNODFPNKL)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x635A2F0", Offset = "0x6358AF0", VA = "0x18635A2F0")]
		public void LHMDNCGDOFK(NKPNKBHIEIK NPCNODFPNKL, [Out] Color MOJKBHCPNEF, [Out] Gradient IPEMOPDHLEO, [Out] bool BGFOAFJBHKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6359E40", Offset = "0x6358640", VA = "0x186359E40")]
		public Color DLMCJGGPLID(JHMMIMNOMPG HDDFMJKIBIC)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x635A460", Offset = "0x6358C60", VA = "0x18635A460")]
		public TilerPalette MFNJIKHNEGG(ALGINPPPEEJ GFGNPBCFEMC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6359F30", Offset = "0x6358730", VA = "0x186359F30")]
		public TextStylePalette GGFDNCILGBO(MPKJBFKPFGB MCCGOMCDLFN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6359A40", Offset = "0x6358240", VA = "0x186359A40")]
		public int BDDBHMKAPJM(DHEBDNHGKMI AOEPNHHMBGN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6359C60", Offset = "0x6358460", VA = "0x186359C60")]
		public ButtonPalette BNILFLOFBCK(JENICDLJDCF BBKMOKAJNEG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6359D50", Offset = "0x6358550", VA = "0x186359D50")]
		public TogglePalette CCECLPLCHCA(IIFOGMALIEG LGONLLENBBH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6359950", Offset = "0x6358150", VA = "0x186359950")]
		public MixedTogglePalette AMCKAMCDHDN(NKLJNNHEDJJ IPIIIKJBALM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x635A550", Offset = "0x6358D50", VA = "0x18635A550")]
		public MakerPenToolPalette NFFGGKAIOBE(NHOJFHOBDIL OFFGHMGCIPM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x635A110", Offset = "0x6358910", VA = "0x18635A110")]
		public InputFieldPalette GLGFNGNPHBE(CDPHNHHANDB OHNEKJGKDKF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x635A020", Offset = "0x6358820", VA = "0x18635A020")]
		public DropdownPalette GJJAODKMOBP(DCDNEHHCDGC EOKLJODDIPL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x635A640", Offset = "0x6358E40", VA = "0x18635A640")]
		public SliderPalette NMHGCMJNAIM(PLOMGFCEKLJ IANKHLDJGAH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6359B30", Offset = "0x6358330", VA = "0x186359B30")]
		public float? BFMMEGJIAMN(NKPPCEGGIOK NPGDGMFNKIF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x848550", Offset = "0x846D50", VA = "0x180848550")]
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
			[Cpp2IlInjected.Address(RVA = "0x7B7860", Offset = "0x7B6060", VA = "0x1807B7860")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6353620", Offset = "0x6351E20", VA = "0x186353620")]
		public bool HBELEGLBEIE([Out] RecRoomAudioClip[] CLHJNOOEEDL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x635AB80", Offset = "0x6359380", VA = "0x18635AB80")]
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
		[Header("Thresholds")]
		[SerializeField]
		[Tooltip("This distance is measured in UI canvas space")]
		private float distanceThresholdToTriggerScrollingSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[SerializeField]
		private float minimumTimeIntervalForScrollingSFX;

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public float DistanceThresholdToTriggerScrollingSFX
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x7B7DF0", Offset = "0x7B65F0", VA = "0x1807B7DF0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public float MinimumTimeIntervalForScrollingSFX
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x7B7B30", Offset = "0x7B6330", VA = "0x1807B7B30")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x6353620", Offset = "0x6351E20", VA = "0x186353620")]
		public bool AILMJPALJND([Out] RecRoomAudioClip[] CLHJNOOEEDL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x635DD20", Offset = "0x635C520", VA = "0x18635DD20")]
		public bool AMFJFFKIIFE([Out] RecRoomAudioClip[] CLHJNOOEEDL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x635DDD0", Offset = "0x635C5D0", VA = "0x18635DDD0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA8BA40", Offset = "0xA8A240", VA = "0x180A8BA40")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public Color FillColor
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0xD48CA0", Offset = "0xD474A0", VA = "0x180D48CA0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public Color HandleColor
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0xD5F460", Offset = "0xD5DC60", VA = "0x180D5F460")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public ColorBlock ColorBlock
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x635EC50", Offset = "0x635D450", VA = "0x18635EC50")]
			get
			{
				return default(ColorBlock);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x635EB90", Offset = "0x635D390", VA = "0x18635EB90")]
		public SliderPalette()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class TextStylePalette
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public enum DCNECCNGCBD
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
		private DCNECCNGCBD transformation;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x635F560", Offset = "0x635DD60", VA = "0x18635F560")]
		public void DIDGOAEAKBH(TextMeshProUGUI HHBKBDCEAKH, bool GDDKPGOOFFC = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
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
		private UITiler.OPEGEOCFPMF animationDirection;

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
			[Cpp2IlInjected.Address(RVA = "0x765EF0", Offset = "0x7646F0", VA = "0x180765EF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public Color TintColor
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x955E20", Offset = "0x954620", VA = "0x180955E20")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public Color BackgroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x955E70", Offset = "0x954670", VA = "0x180955E70")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public Vector2 Spacing
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x62D2F70", Offset = "0x62D1770", VA = "0x1862D2F70")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public float Offset
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x8A3720", Offset = "0x8A1F20", VA = "0x1808A3720")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public Vector2 Velocity
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x635FBF0", Offset = "0x635E3F0", VA = "0x18635FBF0")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public float Angle
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x19DCC50", Offset = "0x19DB450", VA = "0x1819DCC50")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public UITiler.OPEGEOCFPMF AnimationDirection
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0xEB7870", Offset = "0xEB6070", VA = "0x180EB7870")]
			get
			{
				return default(UITiler.OPEGEOCFPMF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public float PrimaryAnimationSpeed
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x10BDC60", Offset = "0x10BC460", VA = "0x1810BDC60")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public float AltAnimationSpeed
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x9254A0", Offset = "0x923CA0", VA = "0x1809254A0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x635FB80", Offset = "0x635E380", VA = "0x18635FB80")]
		public float KAADGBFIPMM(AGLMONDDIKG LKEJHNEEPLM)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x635FBA0", Offset = "0x635E3A0", VA = "0x18635FBA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x765EF0", Offset = "0x7646F0", VA = "0x180765EF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public ButtonPalette ActiveButtonPalette
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public TogglePalette()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public enum NKPNKBHIEIK
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
public enum CPDCFKFIIGF
{
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	A
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public enum JHMMIMNOMPG
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
public enum ALGINPPPEEJ
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
public enum MPKJBFKPFGB
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
public enum DHEBDNHGKMI
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
public enum JENICDLJDCF
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
	RoomCurrency
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public enum IIFOGMALIEG
{
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	FlatOrange,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	FlatWhite,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	InputToggle,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	Chips,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	Switch,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	WhitePagingBlob,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	RSVPToggleHeaderSection,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	CardSelectableToggle,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	ChipsDark,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	MainNavToggle,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	ListItem,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	NotiUnread,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	FlatPrimary,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	CharadePen,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	ShareCam,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	CardSelectableToggleWithBacking,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	SecondaryHeaderSectionToggle,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	PrimaryToSecondaryHeader,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	NegativeToSecondaryHeader,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	LimitedEventPrimary,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	LimitedEventSecondary,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	RoomCardWithLimitedEvent,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	MainNavVrDetach,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	HomeMainNav
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public enum NKLJNNHEDJJ
{
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	Checkbox
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public enum NHOJFHOBDIL
{
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	Create,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	Select,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	Wire,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	Configure,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	Transform,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	Move,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	Rotate,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	Scale,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	CloneFlip,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	Recolor,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	Freeze,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	MakeInvention,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	Manipulate,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	Delete
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public enum CDPHNHHANDB
{
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	LightFlat,
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	DarkFlat,
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	Modified
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public enum DCDNEHHCDGC
{
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	LightFlat,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	DarkFlat
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public enum PLOMGFCEKLJ
{
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	MirroUIPopUp
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public enum NKPPCEGGIOK
{
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	Base,
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	Button,
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	Navigation,
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	Overlay,
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	Dialog,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	Toast
}
namespace RRUI.Theme
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public class ApproximationMaskDepthTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		[SerializeField]
		private RectTransform content;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private Vector3? CMCGHAJCPAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private Vector3? PGCGBFDMEEI;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6351340", Offset = "0x634FB40", VA = "0x186351340")]
		private void GLJEDCMMNGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x6350F90", Offset = "0x634F790", VA = "0x186350F90", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x7644E0", Offset = "0x762CE0", VA = "0x1807644E0")]
		public ApproximationMaskDepthTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public class ButtonTheme : ButtonThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		[Header("Button Visual")]
		[SerializeField]
		private JENICDLJDCF buttonType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		[Header("Button Audio")]
		[SerializeField]
		[Tooltip("Override the audio palette defined by the button's visual with a custom palette")]
		private bool overrideButtonAudioPalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		[Tooltip("Specify a custom config to use for button audio")]
		[SerializeField]
		[IJNIOHAIOOA("overrideButtonAudioPalette")]
		private ButtonAudioPaletteAsset customButtonAudioConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		[SerializeField]
		[Tooltip("Layer a 2D SFX on top of base button sounds")]
		private bool useFlavorSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		[IJNIOHAIOOA("useFlavorSFX")]
		[Tooltip("Flavor SFX is picked randomly from this pool config")]
		[SerializeField]
		private RecRoomAudioClipPoolConfig flavorSFXClipPoolConfig;

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public JENICDLJDCF BHILLFJOLAL
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x10EDC60", Offset = "0x10EC460", VA = "0x1810EDC60")]
			get
			{
				return default(JENICDLJDCF);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x6353600", Offset = "0x6351E00", VA = "0x186353600")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6353390", Offset = "0x6351B90", VA = "0x186353390", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x9382D0", Offset = "0x936AD0", VA = "0x1809382D0")]
		public void SetAnimationEnabled(bool PLMDMDMKAAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x63535F0", Offset = "0x6351DF0", VA = "0x1863535F0")]
		public ButtonTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public abstract class ButtonThemeBase : SelectableThemeBase
	{
		[Cpp2IlInjected.Token(Token = "0x2000058")]
		protected class NHJIKKPBOBO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400017D")]
			public ButtonAudioPaletteAsset DLJBKEAKMIK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400017E")]
			public RecRoomAudioClipPoolConfig KNJENEEDDIJ;

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
			public NHJIKKPBOBO()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		[Header("Button Theme Base")]
		[SerializeField]
		[PDDJFAPJMON(LFNBNCHIJGL.Self, false, false, false)]
		private MultiGraphicButton multiGraphicButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		[SerializeField]
		[PDDJFAPJMON(LFNBNCHIJGL.Self, false, true, false)]
		private Image surface;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		[SerializeField]
		private bool useSurfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		[SerializeField]
		[IJNIOHAIOOA("useSurfaceOverride")]
		private Image surfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		[SerializeField]
		[CLGMHEMAAJM]
		private List<Graphic> graphics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		[SerializeField]
		private bool useGraphicsOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		[SerializeField]
		[IJNIOHAIOOA("useGraphicsOverride")]
		private List<Graphic> graphicsOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		[SerializeField]
		[PDDJFAPJMON(LFNBNCHIJGL.Self, false, true, false)]
		private UIGradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		[SerializeField]
		private bool useGradientOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		[SerializeField]
		[IJNIOHAIOOA("useGradientOverride")]
		private UIGradient gradientOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		[SerializeField]
		[PDDJFAPJMON(LFNBNCHIJGL.Children, true, true, false)]
		private TextMeshProUGUI textMeshProUGUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		[SerializeField]
		private bool useTextMeshProUGUIOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		[SerializeField]
		[IJNIOHAIOOA("useTextMeshProUGUIOverride")]
		private TextMeshProUGUI textMeshProUGUIOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		[SerializeField]
		private DHEBDNHGKMI textSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		[SerializeField]
		protected Hideable borderHideable;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		[SerializeField]
		protected bool isAnimationEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		[SerializeField]
		[IJNIOHAIOOA("isAnimationEnabled")]
		protected bool overrideAnimationTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		[SerializeField]
		[IJNIOHAIOOA("overrideAnimationTarget")]
		protected GameObject animationTargetOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private bool CCBNHKMEOPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private Vector3 EJHDBHNDDGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private Vector3 JLHDNHCKIPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private CJECIFNJKAF PPOPCDDHEPG;

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public Image FHEOMFCLKPD
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x6353330", Offset = "0x6351B30", VA = "0x186353330")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public List<Graphic> PKNDLBHDGDO
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x6353310", Offset = "0x6351B10", VA = "0x186353310")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public UIGradient JNKJJEEHOCE
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x63532F0", Offset = "0x6351AF0", VA = "0x1863532F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public TextMeshProUGUI NHHONFMOLAE
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x6353350", Offset = "0x6351B50", VA = "0x186353350")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public DHEBDNHGKMI JMFCBIMCENI
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xAE4A30", Offset = "0xAE3230", VA = "0x180AE4A30")]
			get
			{
				return default(DHEBDNHGKMI);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x6353370", Offset = "0x6351B70", VA = "0x186353370")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		protected Transform KKCDFMOIPJP
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x63528C0", Offset = "0x63510C0", VA = "0x1863528C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public Button HLOLOACOOBN
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x6353260", Offset = "0x6351A60", VA = "0x186353260")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x63529B0", Offset = "0x63511B0", VA = "0x1863529B0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6352910", Offset = "0x6351110", VA = "0x186352910")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6352750", Offset = "0x6350F50", VA = "0x186352750")]
		protected void JCFJPILCLPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6351CE0", Offset = "0x63504E0", VA = "0x186351CE0")]
		protected void JBOIDIHMKPE(ButtonPalette BDGOHFGHMCP, [Optional] NHJIKKPBOBO IIJDDOOJEAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6352A50", Offset = "0x6351250", VA = "0x186352A50", Slot = "12")]
		public override void OnPointerDown(PointerEventData HOCFILEOKMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6352E40", Offset = "0x6351640", VA = "0x186352E40", Slot = "13")]
		public override void OnPointerUp(PointerEventData HOCFILEOKMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6352A30", Offset = "0x6351230", VA = "0x186352A30", Slot = "14")]
		public override void OnPointerClick(PointerEventData HOCFILEOKMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6351CC0", Offset = "0x63504C0", VA = "0x186351CC0")]
		private Vector3 GHELOCNNJEE(float DCPNEEKOHBH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6353180", Offset = "0x6351980", VA = "0x186353180")]
		protected ButtonThemeBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x5CF8F50", Offset = "0x5CF7750", VA = "0x185CF8F50")]
		[CompilerGenerated]
		private void CFOANGCKHCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x5CF8F50", Offset = "0x5CF7750", VA = "0x185CF8F50")]
		[CompilerGenerated]
		private void JPNPFGJGNHD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public class DepthTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		[SerializeField]
		private NKPPCEGGIOK depth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		[SerializeField]
		private bool animateOnEnable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		[SerializeField]
		[IJNIOHAIOOA("animateOnEnable")]
		private float animationTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private Vector3? CMCGHAJCPAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private Vector2 NCBLOIJKMGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private Vector2 PECLNLAOCMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private Vector2 KCFAMOOEABA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private Vector2 LKHDPNKAGPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private Vector2 PEKBINANDDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private Vector2 INMJADNCOCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private readonly bool? NLMFPLKKOLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private PHOBHDFADLA MLDDBHJDHAL;

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		private RectTransform MLEOPHHPDCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x6353CB0", Offset = "0x63524B0", VA = "0x186353CB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public NKPPCEGGIOK IJMDLMIBKCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x80C100", Offset = "0x80A900", VA = "0x18080C100")]
			get
			{
				return default(NKPPCEGGIOK);
			}
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x63543C0", Offset = "0x6352BC0", VA = "0x1863543C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		private PHOBHDFADLA OKIMPGCGIJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x6353D10", Offset = "0x6352510", VA = "0x186353D10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		private bool NHKPJIICBPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x63538C0", Offset = "0x63520C0", VA = "0x1863538C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x63541C0", Offset = "0x63529C0", VA = "0x1863541C0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6354110", Offset = "0x6352910", VA = "0x186354110")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6353700", Offset = "0x6351F00", VA = "0x186353700", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x6353990", Offset = "0x6352190", VA = "0x186353990")]
		private void GLJEDCMMNGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x6353D80", Offset = "0x6352580", VA = "0x186353D80")]
		private Vector3 MCLLOGFILAI()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6354230", Offset = "0x6352A30", VA = "0x186354230")]
		public DepthTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public class DropdownTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		[SerializeField]
		[MPCIHJNAEHG(LFNBNCHIJGL.Self, false, false, false)]
		private Dropdown dropdown;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		[SerializeField]
		[PDDJFAPJMON(LFNBNCHIJGL.Self, false, true, false)]
		private Image surface;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		[SerializeField]
		private bool useSurfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		[SerializeField]
		[IJNIOHAIOOA("useSurfaceOverride")]
		private Image surfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		[SerializeField]
		private DCDNEHHCDGC dropdownType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		[SerializeField]
		private DHEBDNHGKMI textSize;

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public Image FHEOMFCLKPD
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x6354A00", Offset = "0x6353200", VA = "0x186354A00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public DCDNEHHCDGC LODHKOBOBNK
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x772110", Offset = "0x770910", VA = "0x180772110")]
			get
			{
				return default(DCDNEHHCDGC);
			}
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x6354A10", Offset = "0x6353210", VA = "0x186354A10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public DHEBDNHGKMI JMFCBIMCENI
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x847AB0", Offset = "0x8462B0", VA = "0x180847AB0")]
			get
			{
				return default(DHEBDNHGKMI);
			}
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x6354A30", Offset = "0x6353230", VA = "0x186354A30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6354400", Offset = "0x6352C00", VA = "0x186354400", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x63549F0", Offset = "0x63531F0", VA = "0x1863549F0")]
		public DropdownTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class GraphicTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		[SerializeField]
		[MPCIHJNAEHG(LFNBNCHIJGL.Self, false, false, false)]
		private Graphic graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		[SerializeField]
		private bool useGraphicOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		[SerializeField]
		[IJNIOHAIOOA("useGraphicOverride")]
		private Graphic graphicOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		[SerializeField]
		private JHMMIMNOMPG color;

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public Graphic KLNPLMNHLID
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x6355A60", Offset = "0x6354260", VA = "0x186355A60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public JHMMIMNOMPG PAPAJMJFCGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x780BE0", Offset = "0x77F3E0", VA = "0x180780BE0")]
			get
			{
				return default(JHMMIMNOMPG);
			}
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x6355A70", Offset = "0x6354270", VA = "0x186355A70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public bool ACBDLKGEGEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xB75020", Offset = "0xB73820", VA = "0x180B75020")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0xB75350", Offset = "0xB73B50", VA = "0x180B75350")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public Color? IJDICHEDCNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x6355840", Offset = "0x6354040", VA = "0x186355840")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6355640", Offset = "0x6353E40", VA = "0x186355640", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x7644E0", Offset = "0x762CE0", VA = "0x1807644E0")]
		public GraphicTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class InputFieldTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		[SerializeField]
		[MPCIHJNAEHG(LFNBNCHIJGL.Self, false, false, false)]
		private TMP_InputField inputField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		[SerializeField]
		[PDDJFAPJMON(LFNBNCHIJGL.Self, false, false, false)]
		private Image surface;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		[SerializeField]
		private bool useSurfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		[SerializeField]
		[IJNIOHAIOOA("useSurfaceOverride")]
		private Image surfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		[SerializeField]
		private CDPHNHHANDB inputFieldType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		[SerializeField]
		private DHEBDNHGKMI textSize;

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public Image FHEOMFCLKPD
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x6354A00", Offset = "0x6353200", VA = "0x186354A00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public CDPHNHHANDB LKHJFCHFOFA
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x772110", Offset = "0x770910", VA = "0x180772110")]
			get
			{
				return default(CDPHNHHANDB);
			}
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x6354A10", Offset = "0x6353210", VA = "0x186354A10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public DHEBDNHGKMI JMFCBIMCENI
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x847AB0", Offset = "0x8462B0", VA = "0x180847AB0")]
			get
			{
				return default(DHEBDNHGKMI);
			}
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x6354A30", Offset = "0x6353230", VA = "0x186354A30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x6355B40", Offset = "0x6354340", VA = "0x186355B40", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x63549F0", Offset = "0x63531F0", VA = "0x1863549F0")]
		public InputFieldTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class LabelTheme : GraphicTheme
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		[SerializeField]
		[MPCIHJNAEHG(LFNBNCHIJGL.Self, false, false, false)]
		private TextMeshProUGUI textMeshProUGUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		[SerializeField]
		private MPKJBFKPFGB textType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		[SerializeField]
		private DHEBDNHGKMI textSize;

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public MPKJBFKPFGB KKONGOGNFPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x7F9690", Offset = "0x7F7E90", VA = "0x1807F9690")]
			get
			{
				return default(MPKJBFKPFGB);
			}
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x6356340", Offset = "0x6354B40", VA = "0x186356340")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public DHEBDNHGKMI JMFCBIMCENI
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x847AA0", Offset = "0x8462A0", VA = "0x180847AA0")]
			get
			{
				return default(DHEBDNHGKMI);
			}
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x6356320", Offset = "0x6354B20", VA = "0x186356320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x6356010", Offset = "0x6354810", VA = "0x186356010", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x6356310", Offset = "0x6354B10", VA = "0x186356310")]
		public LabelTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public class MakerPenToolTheme : ButtonThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		[Header("Maker Pen Tool")]
		[SerializeField]
		private NHOJFHOBDIL makerPenToolPaletteType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		[SerializeField]
		[Tooltip("A list of objects to show while the maker pen tool is active.")]
		private List<Hideable> hideWhenNotActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		[SerializeField]
		[Tooltip("A list of objects to show while the maker pen tool is inactive")]
		private List<Hideable> hideWhenActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		[SerializeField]
		private bool editorIsActiveOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x131")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		protected bool BNNGMJPCOBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x132")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private bool KDKPNNJOKIF;

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public NHOJFHOBDIL AHEFHNDIGOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x10EDC60", Offset = "0x10EC460", VA = "0x1810EDC60")]
			get
			{
				return default(NHOJFHOBDIL);
			}
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x6353600", Offset = "0x6351E00", VA = "0x186353600")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public bool FEAHJNJLDMD
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x13C3950", Offset = "0x13C2150", VA = "0x1813C3950")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x6356790", Offset = "0x6354F90", VA = "0x186356790")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x6356750", Offset = "0x6354F50", VA = "0x186356750", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x6356360", Offset = "0x6354B60", VA = "0x186356360", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x63535F0", Offset = "0x6351DF0", VA = "0x1863535F0")]
		public MakerPenToolTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class MixedToggleTheme : ButtonThemeBase
	{
		[Cpp2IlInjected.Token(Token = "0x2000060")]
		public enum HPPOJKAHJOM
		{
			[Cpp2IlInjected.Token(Token = "0x40001AC")]
			Inactive,
			[Cpp2IlInjected.Token(Token = "0x40001AD")]
			Mixed,
			[Cpp2IlInjected.Token(Token = "0x40001AE")]
			Active
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		[SerializeField]
		private NKLJNNHEDJJ toggleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		[SerializeField]
		[Tooltip("A list of objects to hide while the toggle is inactive.")]
		private List<Hideable> hideWhenInactive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		[SerializeField]
		[Tooltip("A list of objects to hide while the toggle is mixed.")]
		private List<Hideable> hideWhenMixed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		[SerializeField]
		[Tooltip("A list of objects to hide while the toggle is active")]
		private List<Hideable> hideWhenActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		[SerializeField]
		private HPPOJKAHJOM editorIsActiveOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private HPPOJKAHJOM KDKPNNJOKIF;

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public HPPOJKAHJOM FEAHJNJLDMD
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x135ADB0", Offset = "0x13595B0", VA = "0x18135ADB0")]
			get
			{
				return default(HPPOJKAHJOM);
			}
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x6357030", Offset = "0x6355830", VA = "0x186357030")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x6357000", Offset = "0x6355800", VA = "0x186357000")]
		public void Toggle()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x6357030", Offset = "0x6355830", VA = "0x186357030")]
		public void Toggle(HPPOJKAHJOM KDKPNNJOKIF, bool BNNGMJPCOBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x6356A50", Offset = "0x6355250", VA = "0x186356A50", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x63535F0", Offset = "0x6351DF0", VA = "0x1863535F0")]
		public MixedToggleTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public class PaletteTheme : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		[SerializeField]
		private bool usePaletteOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		[SerializeField]
		[IJNIOHAIOOA("usePaletteOverride")]
		private Palette paletteOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public BJPMGBAMGNN PaletteChangeEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		[SerializeField]
		private bool useDepth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private JJCDNFCIIMN PENIHBIONCK;

		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private const string NKNLIGHDICH = "watch_layer";

		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private const string OIGHCMMCLNK = "depth_multiplier";

		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private const float EPDOENKDIFO = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private float? AHINMLFHHPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private float? JBGCIEEIICG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private float? BPOIHHGMCDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private float JMCNMIMKHMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		private float HCBAENNLPGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		private float LKMFIPBFDKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private float IOHBGCJLPPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		private readonly BOKOFNDFGJO OOMPDCDDJBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private SFXAudioSource NENFNKECPED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		private SFXAudioSource IBNJKKEHKLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		private ContentLoadingAudioPaletteAsset LNGJGAFNGIF;

		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		private const float AGDKFDDFEAJ = 0.001f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private NCNJECCDABG NLBJJBPKLJI;

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public Palette EHKLGHDMIPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x63598B0", Offset = "0x63580B0", VA = "0x1863598B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public bool NIGIOKLOHAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x7B7C00", Offset = "0x7B6400", VA = "0x1807B7C00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public float INCJLLCCDJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x63596C0", Offset = "0x6357EC0", VA = "0x1863596C0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		private bool KKMPFCOOBBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x6358FC0", Offset = "0x63577C0", VA = "0x186358FC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		private bool HMONIAGABEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x6358AA0", Offset = "0x63572A0", VA = "0x186358AA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x63582A0", Offset = "0x6356AA0", VA = "0x1863582A0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x6359040", Offset = "0x6357840", VA = "0x186359040")]
		private void LMNDEIKKABO(ILMJBJIIGJG.PDDLMCMGJGK FJCKPGPJKCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x63591E0", Offset = "0x63579E0", VA = "0x1863591E0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x6359070", Offset = "0x6357870", VA = "0x186359070")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x6358D10", Offset = "0x6357510", VA = "0x186358D10")]
		private void KJOOIMBLMLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x6358180", Offset = "0x6356980", VA = "0x186358180")]
		public void AddLoadingSFXRequest(object KIAKEGJPMAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x63594E0", Offset = "0x6357CE0", VA = "0x1863594E0")]
		public void RemoveLoadingSFXRequest(object KIAKEGJPMAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x6359070", Offset = "0x6357870", VA = "0x186359070")]
		private void MKGJJKIAMEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x6358B20", Offset = "0x6357320", VA = "0x186358B20")]
		private void JIGKDFCMFOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x6358930", Offset = "0x6357130", VA = "0x186358930")]
		private void EOJGAOEBPLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x6358470", Offset = "0x6356C70", VA = "0x186358470")]
		private void CCHDMOIKFKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x6358650", Offset = "0x6356E50", VA = "0x186358650")]
		private void EFOFDLBLGCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x6358ED0", Offset = "0x63576D0", VA = "0x186358ED0")]
		private void LDMLMCCIBJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x6358170", Offset = "0x6356970", VA = "0x186358170")]
		private void AFOMIPNKNMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x6358560", Offset = "0x6356D60", VA = "0x186358560")]
		private void CFHIMDCIDNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x6358430", Offset = "0x6356C30", VA = "0x186358430")]
		private void BOGBGBIPMOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x6359310", Offset = "0x6357B10", VA = "0x186359310")]
		public void Play2DUIFlavorSFX(RecRoomAudioClip[] CDOGLLCOBKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x6359600", Offset = "0x6357E00", VA = "0x186359600")]
		public PaletteTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public abstract class PaletteThemeReference : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		[SerializeField]
		[PDDJFAPJMON(LFNBNCHIJGL.SelfAndParent, true, false, false)]
		private PaletteTheme paletteTheme;

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		protected PaletteTheme NOBOMCMFNHE
		{
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		protected Palette EHKLGHDMIPG
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x6357A70", Offset = "0x6356270", VA = "0x186357A70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		protected bool OMGBPMBJPGH
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x63579F0", Offset = "0x63561F0", VA = "0x1863579F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		protected Transform IJEOIKIOHJG
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x6357CD0", Offset = "0x63564D0", VA = "0x186357CD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x63578F0", Offset = "0x63560F0", VA = "0x1863578F0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x6358090", Offset = "0x6356890", VA = "0x186358090", Slot = "5")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void Apply();

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x6357B20", Offset = "0x6356320", VA = "0x186357B20")]
		public Color? GetColorFromPalette(JHMMIMNOMPG EGBCPOBOMBI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x6357D50", Offset = "0x6356550", VA = "0x186357D50")]
		private void MIIDNBONHIB(bool IIHHGDJPHAF = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x7644E0", Offset = "0x762CE0", VA = "0x1807644E0")]
		protected PaletteThemeReference()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public class RangeSliderTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		[SerializeField]
		[MPCIHJNAEHG(LFNBNCHIJGL.Self, false, false, false)]
		private RangeSlider slider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		[SerializeField]
		private PLOMGFCEKLJ sliderType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		[SerializeField]
		private Image sliderImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		[SerializeField]
		private Image fillImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		[SerializeField]
		private Image lowHandleImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		[SerializeField]
		private Image highHandleImage;

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public PLOMGFCEKLJ FPEACMGLHMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x76A240", Offset = "0x768A40", VA = "0x18076A240")]
			get
			{
				return default(PLOMGFCEKLJ);
			}
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x635AA30", Offset = "0x6359230", VA = "0x18635AA30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public Image JBGCPMMLDPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x76B5B0", Offset = "0x769DB0", VA = "0x18076B5B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public Image EOLHJINIIKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x7660F0", Offset = "0x7648F0", VA = "0x1807660F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public Image LNPMAKFICMC
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x766140", Offset = "0x764940", VA = "0x180766140")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public Image AIPOLHDDBKI
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x768D80", Offset = "0x767580", VA = "0x180768D80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public bool CDAGACAAFJF
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x539E170", Offset = "0x539C970", VA = "0x18539E170")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x539E420", Offset = "0x539CC20", VA = "0x18539E420")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x635A730", Offset = "0x6358F30", VA = "0x18635A730", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x7644E0", Offset = "0x762CE0", VA = "0x1807644E0")]
		public RangeSliderTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public class RawImageTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		[SerializeField]
		[MPCIHJNAEHG(LFNBNCHIJGL.Self, false, false, false)]
		private RawImage image;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		[SerializeField]
		private CPDCFKFIIGF color;

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public CPDCFKFIIGF DKKOFOOONID
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x76A240", Offset = "0x768A40", VA = "0x18076A240")]
			get
			{
				return default(CPDCFKFIIGF);
			}
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x635AA30", Offset = "0x6359230", VA = "0x18635AA30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x635AA50", Offset = "0x6359250", VA = "0x18635AA50", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x7644E0", Offset = "0x762CE0", VA = "0x1807644E0")]
		public RawImageTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class RecyclingGridTheme : RecyclingThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		[SerializeField]
		[MPCIHJNAEHG(LFNBNCHIJGL.Self, false, false, false)]
		private KHJPBOOLFKE recyclingGrid;

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x635AB90", Offset = "0x6359390", VA = "0x18635AB90", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x635AE00", Offset = "0x6359600", VA = "0x18635AE00", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x635AD90", Offset = "0x6359590", VA = "0x18635AD90")]
		private void DPGIOHHBGBM(float LGAHKFJAFNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x635AFF0", Offset = "0x63597F0", VA = "0x18635AFF0")]
		public RecyclingGridTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class RecyclingListTheme : RecyclingThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		[SerializeField]
		[MPCIHJNAEHG(LFNBNCHIJGL.Self, false, false, false)]
		private KHJPBOOLFKE recyclingList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private bool JFKEPIGAPDL;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x635B000", Offset = "0x6359800", VA = "0x18635B000", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x635B2B0", Offset = "0x6359AB0", VA = "0x18635B2B0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x635B240", Offset = "0x6359A40", VA = "0x18635B240")]
		private void DKOPIIEHLHN(float LGAHKFJAFNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x635AFF0", Offset = "0x63597F0", VA = "0x18635AFF0")]
		public RecyclingListTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public abstract class RecyclingThemeBase : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		[Header("Audio")]
		[SerializeField]
		private IJCKKCMMDJA recyclingAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		protected RecyclingAudioPaletteAsset DGFHDABCECP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		[SerializeField]
		private JPGBEKHKEGK scrollingAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		private ScrollingAudioPaletteAsset MHGBKHNAHHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private NCNJECCDABG DAAHLJOJGJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private float PDOGKOFHDAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private float FPMIAKLEFPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private float BMPMDNJPOCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private float LBCNACMPLBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		private bool PDIMMANKIJL;

		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		private const float FDDMKDPDCFG = 0.01f;

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		private NCNJECCDABG NLBJJBPKLJI
		{
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x635B710", Offset = "0x6359F10", VA = "0x18635B710")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x635B780", Offset = "0x6359F80", VA = "0x18635B780", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x635C1A0", Offset = "0x635A9A0", VA = "0x18635C1A0")]
		protected void ODGPMDKKDGC(bool PEPGHDJKIMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x635BB70", Offset = "0x635A370", VA = "0x18635BB70")]
		protected void CGHLPHODNMD(GameObject BBKHFDEMMEH, int ENBCDHMMLIP, bool POMAODCLJFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x635B970", Offset = "0x635A170", VA = "0x18635B970")]
		protected void CEMGPKPCNJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x635B4B0", Offset = "0x6359CB0", VA = "0x18635B4B0")]
		protected void AHKCMIEBEPO(float LGAHKFJAFNC, float HHDOFMKKNGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x635BD70", Offset = "0x635A570", VA = "0x18635BD70")]
		private void FMBCGPHAKPE(float IACKOFEDAMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x635BFE0", Offset = "0x635A7E0", VA = "0x18635BFE0")]
		private void HDJPLNAMPGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x635AFF0", Offset = "0x63597F0", VA = "0x18635AFF0")]
		protected RecyclingThemeBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public class ScrollBarTheme : SelectableThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		[Header("Scroll Bar Audio")]
		[SerializeField]
		private DMCLKDIHOKH buttonAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		[SerializeField]
		[Tooltip("Layer a 2D SFX on top of base button sounds")]
		private bool useFlavorSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		[Tooltip("Flavor SFX is picked randomly from this pool config")]
		[SerializeField]
		[IJNIOHAIOOA("useFlavorSFX")]
		private RecRoomAudioClipPoolConfig flavorSFXClipPoolConfig;

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x635C460", Offset = "0x635AC60", VA = "0x18635C460", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x635C570", Offset = "0x635AD70", VA = "0x18635C570")]
		public ScrollBarTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class ScrollRectTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		private const string EGEIKFILNDH = "RRUI.PlayHittingEndsSFX";

		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private const int LKLOGDEFHHK = 5;

		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private const int DINJEHLOMLP = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private DateTimeOffset HJLCEMGFBAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private int BMLLHHHIGEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private bool GJJBEHPBKKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		[SerializeField]
		[MPCIHJNAEHG(LFNBNCHIJGL.Self, false, false, false)]
		private ScrollRect scrollRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		[Header("Audio")]
		[SerializeField]
		private JPGBEKHKEGK scrollAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		private ScrollingAudioPaletteAsset DGFHDABCECP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		private NCNJECCDABG DAAHLJOJGJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private NBDDNHBFDLH MFMNKAHFBMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private float FPMIAKLEFPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private float BMPMDNJPOCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private float LBCNACMPLBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private bool PDIMMANKIJL;

		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private const float FDDMKDPDCFG = 0.01f;

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		private NCNJECCDABG NLBJJBPKLJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x635C580", Offset = "0x635AD80", VA = "0x18635C580")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		private NBDDNHBFDLH IKKDEMGCHEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x635D870", Offset = "0x635C070", VA = "0x18635D870")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x635C6D0", Offset = "0x635AED0", VA = "0x18635C6D0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x635DBC0", Offset = "0x635C3C0", VA = "0x18635DBC0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x635C5F0", Offset = "0x635ADF0", VA = "0x18635C5F0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x635D8E0", Offset = "0x635C0E0", VA = "0x18635D8E0")]
		private void NHIICNDDKAF(Vector2 MCLBBPPAHAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x635C8E0", Offset = "0x635B0E0", VA = "0x18635C8E0")]
		private void FMBCGPHAKPE(float IACKOFEDAMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x635CB50", Offset = "0x635B350", VA = "0x18635CB50")]
		private void HDJPLNAMPGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x635D750", Offset = "0x635BF50", VA = "0x18635D750")]
		private static string MCLMIFGPAEC(GameObject CBBCDNDPNHF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x635DCB0", Offset = "0x635C4B0", VA = "0x18635DCB0")]
		public ScrollRectTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public abstract class SelectableThemeBase : PaletteThemeReference, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IPointerClickHandler, IPointerEnterHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		[Header("Selectable Theme Base")]
		[SerializeField]
		[MPCIHJNAEHG(LFNBNCHIJGL.Self, false, false, false)]
		[FormerlySerializedAs("button")]
		private Selectable selectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		[FormerlySerializedAs("overrideAudio")]
		[Tooltip("Override base selectable audio with a single SFX that plays only on click.")]
		[Header("Legacy Audio Override")]
		[SerializeField]
		protected bool overrideWithSingleAudio;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		[SerializeField]
		[IJNIOHAIOOA("overrideWithSingleAudio")]
		[Tooltip("The legacy override audio will be randomly picked from this pool")]
		protected RecRoomAudioClip[] randomAudioOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		protected bool EAFBAOEDNMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		private ButtonAudioPaletteAsset DGFHDABCECP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		private RecRoomAudioClipPoolConfig GJILLJANPEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private NCNJECCDABG DAAHLJOJGJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private HGBDEOGOGEB OIIDNIGKHMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		private FGNOIGGKFNB MEBEFEJFDPL;

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		protected Selectable LDOKPOIOFIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x766110", Offset = "0x764910", VA = "0x180766110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		protected virtual bool DKGLHOPEDGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x77D0F0", Offset = "0x77B8F0", VA = "0x18077D0F0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		public bool CDAGACAAFJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x539E170", Offset = "0x539C970", VA = "0x18539E170")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x539E420", Offset = "0x539CC20", VA = "0x18539E420")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		private NCNJECCDABG NLBJJBPKLJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x635E1C0", Offset = "0x635C9C0", VA = "0x18635E1C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		protected HGBDEOGOGEB PMLDDMMLHCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x635E3B0", Offset = "0x635CBB0", VA = "0x18635E3B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		private FGNOIGGKFNB APILAEIKGCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x635EB20", Offset = "0x635D320", VA = "0x18635EB20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x635E230", Offset = "0x635CA30", VA = "0x18635E230")]
		protected void BAFFGKCGBEK(ButtonAudioPaletteAsset ANIHCHODHKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x768E00", Offset = "0x767600", VA = "0x180768E00")]
		protected void CHIAKENFHAK(RecRoomAudioClipPoolConfig FMCBMBDDLHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x635E7C0", Offset = "0x635CFC0", VA = "0x18635E7C0", Slot = "12")]
		public virtual void OnPointerDown(PointerEventData HOCFILEOKMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x635EA00", Offset = "0x635D200", VA = "0x18635EA00", Slot = "13")]
		public virtual void OnPointerUp(PointerEventData HOCFILEOKMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x635E420", Offset = "0x635CC20", VA = "0x18635E420", Slot = "14")]
		public virtual void OnPointerClick(PointerEventData HOCFILEOKMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x635E8E0", Offset = "0x635D0E0", VA = "0x18635E8E0", Slot = "15")]
		public virtual void OnPointerEnter(PointerEventData HOCFILEOKMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x635E330", Offset = "0x635CB30", VA = "0x18635E330")]
		private void FBCADDKIOEF(RecRoomAudioClip[] CLHJNOOEEDL, bool JPEDFODBEEJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x635DDF0", Offset = "0x635C5F0", VA = "0x18635DDF0")]
		private void AFGCMFMNFPC(RecRoomAudioClip OPIMKBNMIBG, bool JPEDFODBEEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x635C570", Offset = "0x635AD70", VA = "0x18635C570")]
		protected SelectableThemeBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public class SliderTheme : SelectableThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		[Header("Slider Visual")]
		[SerializeField]
		[MPCIHJNAEHG(LFNBNCHIJGL.Self, false, false, false)]
		private Slider slider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		[SerializeField]
		private PLOMGFCEKLJ sliderType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		[Header("Slider Audio")]
		[SerializeField]
		private DMCLKDIHOKH buttonAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		[SerializeField]
		[Tooltip("Layer a 2D SFX on top of base button sounds")]
		private bool useFlavorSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		[SerializeField]
		[IJNIOHAIOOA("useFlavorSFX")]
		[Tooltip("Flavor SFX is picked randomly from this pool config")]
		private RecRoomAudioClipPoolConfig flavorSFXClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		[SerializeField]
		private Image sliderImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		[SerializeField]
		private Image fillImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		[SerializeField]
		private Image handleImage;

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		public PLOMGFCEKLJ FPEACMGLHMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x78A1F0", Offset = "0x7889F0", VA = "0x18078A1F0")]
			get
			{
				return default(PLOMGFCEKLJ);
			}
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x635F050", Offset = "0x635D850", VA = "0x18635F050")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		public Image JBGCPMMLDPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x768CB0", Offset = "0x7674B0", VA = "0x180768CB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		public Image EOLHJINIIKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x8120A0", Offset = "0x8108A0", VA = "0x1808120A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public Image EMGHMJFPILM
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x768E20", Offset = "0x767620", VA = "0x180768E20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x635EC90", Offset = "0x635D490", VA = "0x18635EC90", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x635F030", Offset = "0x635D830", VA = "0x18635F030")]
		public SliderTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class SurfaceTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		[SerializeField]
		[MPCIHJNAEHG(LFNBNCHIJGL.Self, false, false, false)]
		private Image image;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		[SerializeField]
		[PDDJFAPJMON(LFNBNCHIJGL.Self, false, false, false)]
		private UIGradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		[SerializeField]
		private NKPNKBHIEIK color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		[SerializeField]
		[IJNIOHAIOOA("gradient")]
		private bool ignoreGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		[SerializeField]
		[Tooltip("The surface theme determines if this Image is a RaycastTarget or not. There are times when you might want to ignore that setting of the palette theme and just respect whatever is the default state on the Image.")]
		private bool ignoreSettingRaycastTarget;

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public NKPNKBHIEIK CCMIKOECABK
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x766100", Offset = "0x764900", VA = "0x180766100")]
			get
			{
				return default(NKPNKBHIEIK);
			}
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x635F2D0", Offset = "0x635DAD0", VA = "0x18635F2D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x635F070", Offset = "0x635D870", VA = "0x18635F070", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x7644E0", Offset = "0x762CE0", VA = "0x1807644E0")]
		public SurfaceTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class SwitchTheme : ToggleTheme
	{
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private const float KKJMDBHLOHH = 0.33f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		[Header("Switch")]
		[SerializeField]
		private GameObject indicator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		[SerializeField]
		private GameObject indicatorOffPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		[SerializeField]
		private GameObject indicatorOnPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		private CJECIFNJKAF PPOPCDDHEPG;

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x635F2F0", Offset = "0x635DAF0", VA = "0x18635F2F0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x635F550", Offset = "0x635DD50", VA = "0x18635F550")]
		public SwitchTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public class TilerTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		[SerializeField]
		[MPCIHJNAEHG(LFNBNCHIJGL.Self, false, false, false)]
		private UITiler tiler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		[SerializeField]
		private ALGINPPPEEJ type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private OLFBDNEMOKC EBHLDHOLPJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private DBEJEGPDHDB BLHKCCMMNAI;

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		private DBEJEGPDHDB EFJMNMHAGNL
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x6360130", Offset = "0x635E930", VA = "0x186360130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		private AGLMONDDIKG PLELDKODLBA
		{
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x6360030", Offset = "0x635E830", VA = "0x186360030")]
			get
			{
				return default(AGLMONDDIKG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x635FFC0", Offset = "0x635E7C0", VA = "0x18635FFC0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x635FC10", Offset = "0x635E410", VA = "0x18635FC10", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x7644E0", Offset = "0x762CE0", VA = "0x1807644E0")]
		public TilerTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public class ToggleTheme : ButtonThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		[Header("Toggle Visual")]
		[SerializeField]
		private IIFOGMALIEG toggleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		[SerializeField]
		[Tooltip("A list of objects to show while the toggle is active.")]
		private List<Hideable> hideWhenNotActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		[SerializeField]
		[Tooltip("A list of objects to show while the toggle is inactive")]
		private List<Hideable> hideWhenActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		[SerializeField]
		private bool editorIsActiveOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x131")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		[Header("Toggle Audio")]
		[SerializeField]
		[Tooltip("Override the audio palette when active defined by the toggle's visual with a custom palette")]
		private bool overrideAudioPaletteWhenActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		[Tooltip("Specify a custom config to use for toggle button audio when active")]
		[SerializeField]
		[IJNIOHAIOOA("overrideAudioPaletteWhenActive")]
		private ButtonAudioPaletteAsset customButtonAudioConfigWhenActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		[SerializeField]
		[Tooltip("Override the audio palette when inactive defined by the toggle's visual with a custom palette")]
		private bool overrideAudioPaletteWhenInactive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		[SerializeField]
		[IJNIOHAIOOA("overrideAudioPaletteWhenInactive")]
		[Tooltip("Specify a custom config to use for toggle button audio when inactive")]
		private ButtonAudioPaletteAsset customButtonAudioConfigWhenInactive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		[SerializeField]
		[Tooltip("Layer a 2D SFX on top of base button sounds. Flavor SFX only plays when toggling from inactive to active")]
		private bool useFlavorSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		[SerializeField]
		[IJNIOHAIOOA("useFlavorSFX")]
		[Tooltip("Flavor SFX is picked randomly from this pool config")]
		private RecRoomAudioClipPoolConfig flavorSFXClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		protected bool BNNGMJPCOBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x161")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		private bool MAMIKDHPHNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x162")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		private bool KDKPNNJOKIF;

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public bool FEAHJNJLDMD
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x6360640", Offset = "0x635EE40", VA = "0x186360640")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x6360650", Offset = "0x635EE50", VA = "0x186360650")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public IIFOGMALIEG BBMPAFFBBIK
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x10EDC60", Offset = "0x10EC460", VA = "0x1810EDC60")]
			get
			{
				return default(IIFOGMALIEG);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x6353600", Offset = "0x6351E00", VA = "0x186353600")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		protected override bool DKGLHOPEDGM
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x63605B0", Offset = "0x635EDB0", VA = "0x1863605B0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x6360570", Offset = "0x635ED70", VA = "0x186360570", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x6360600", Offset = "0x635EE00", VA = "0x186360600")]
		public void Toggle()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x63605C0", Offset = "0x635EDC0", VA = "0x1863605C0")]
		public void Toggle(bool KDKPNNJOKIF, bool BNNGMJPCOBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x6360190", Offset = "0x635E990", VA = "0x186360190", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x635F550", Offset = "0x635DD50", VA = "0x18635F550")]
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
