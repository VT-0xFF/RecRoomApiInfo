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
using RecRoom.Logging.Attributes;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_RRUI_Theme_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Preserve]
	public class LogRegistrationIndex : FIPEGIMCDPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8DEB620", Offset = "0x8DEAA20", VA = "0x188DEB620", Slot = "4")]
		public override void AAGBOPIEMBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RRUI
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class FontsConfig : SingletonAddressableScriptableObject<FontsConfig>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000004")]
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
		[Cpp2IlInjected.Token(Token = "0x2000005")]
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

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class DJEBBPNPEFC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public TMP_FontAsset font;

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
			public DJEBBPNPEFC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x8DE88E0", Offset = "0x8DE7CE0", VA = "0x188DE88E0")]
			internal bool LGBNMNIDKON(LocalizedFontMapping x)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		[Tooltip("Mapping of non-localized font assets to their localized counterparts. By default text fields will forcibly revert to non-localized fonts unless the `AllowsNonLatinCharacters` component is present.")]
		private LocalizedFontMapping[] localizedFontMappings;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8DEA190", Offset = "0x8DE9590", VA = "0x188DEA190")]
		public bool LBCPKADAAIM(TMP_FontAsset HOMKIHIOIMK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8DEA2C0", Offset = "0x8DE96C0", VA = "0x188DEA2C0")]
		public TMP_FontAsset OCMMGJBIGJO(TMP_FontAsset HOMKIHIOIMK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8DEA420", Offset = "0x8DE9820", VA = "0x188DEA420")]
		public TMP_FontAsset OCMMGJBIGJO(TMP_FontAsset HOMKIHIOIMK, Material HIIKDGDPLHG, [Out] Material OGOGPCDFNGH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8DE9E30", Offset = "0x8DE9230", VA = "0x188DE9E30")]
		public TMP_FontAsset GHJPPJLFKNO(TMP_FontAsset HOMKIHIOIMK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8DE9F90", Offset = "0x8DE9390", VA = "0x188DE9F90")]
		public TMP_FontAsset GHJPPJLFKNO(TMP_FontAsset HOMKIHIOIMK, Material HIIKDGDPLHG, [Out] Material IBHKMDILHFA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8DE9D80", Offset = "0x8DE9180", VA = "0x188DE9D80")]
		private static bool GBOBGCJJLCL(TMP_FontAsset HOMKIHIOIMK, LocalizedFontMapping DBAPAFOAABM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8DEA660", Offset = "0x8DE9A60", VA = "0x188DEA660")]
		public FontsConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
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
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x8DF4E60", Offset = "0x8DF4260", VA = "0x188DF4E60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8DF4E00", Offset = "0x8DF4200", VA = "0x188DF4E00")]
		public ThemesConfig()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
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

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8DEA740", Offset = "0x8DE9B40", VA = "0x188DEA740", Slot = "0")]
		public override bool Equals(object DEJGDIIDCDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8DEA6E0", Offset = "0x8DE9AE0", VA = "0x188DEA6E0", Slot = "4")]
		public bool Equals(GradientBlock LHDOHAKINKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8DEA830", Offset = "0x8DE9C30", VA = "0x188DEA830", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class MultiGraphicButton : Button
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[SerializeField]
		private List<Graphic> additionalGraphics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[SerializeField]
		private ColorBlock additionalGraphicsColors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[SerializeField]
		private UIGradient backgroundGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[SerializeField]
		private GradientBlock backgroundGradients;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public List<Graphic> DDOCKHPIAPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xB4BEA0", Offset = "0xB4B2A0", VA = "0x180B4BEA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xBD09D0", Offset = "0xBCFDD0", VA = "0x180BD09D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public ColorBlock PHBBJKEMODL
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8DEC8D0", Offset = "0x8DEBCD0", VA = "0x188DEC8D0")]
			get
			{
				return default(ColorBlock);
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8DEC950", Offset = "0x8DEBD50", VA = "0x188DEC950")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public UIGradient NGPOBEJDDHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xAF7FE0", Offset = "0xAF73E0", VA = "0x180AF7FE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xBD9F50", Offset = "0xBD9350", VA = "0x180BD9F50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public GradientBlock OEJCBOPCOPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8DEC920", Offset = "0x8DEBD20", VA = "0x188DEC920")]
			get
			{
				return default(GradientBlock);
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8DEC9A0", Offset = "0x8DEBDA0", VA = "0x188DEC9A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8DEC740", Offset = "0x8DEBB40", VA = "0x188DEC740", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8DEC790", Offset = "0x8DEBB90", VA = "0x188DEC790")]
		public void Refresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8DEC600", Offset = "0x8DEBA00", VA = "0x188DEC600")]
		public void ForceHighlighted(bool JCACAKEAHKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8DEC620", Offset = "0x8DEBA20", VA = "0x188DEC620")]
		public void ForceNormal(bool JCACAKEAHKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8DEC2A0", Offset = "0x8DEB6A0", VA = "0x188DEC2A0", Slot = "28")]
		protected override void DoStateTransition(SelectionState JPDKKKJJNLC, bool JCACAKEAHKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8DEC1B0", Offset = "0x8DEB5B0", VA = "0x188DEC1B0")]
		private void CINJDJPAHIM(Graphic ONCOPMEIKFJ, Color MMGBDOOBHGE, bool JCACAKEAHKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8DEC640", Offset = "0x8DEBA40", VA = "0x188DEC640")]
		private void KHJEFMPIONO(SelectionState JPDKKKJJNLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8DEC7C0", Offset = "0x8DEBBC0", VA = "0x188DEC7C0")]
		public MultiGraphicButton()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum IFBABLCDPMI
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	Negative = 1,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	SelectPrimary = 2,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	SelectSidebar = 12,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	SelectCardToggle = 14,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	SelectSidebarInactive = 17,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	ToggleOnSwitch = 18,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	ToggleOffSwitch = 19,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	ToggleChip = 20,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	SliderDefault = 21
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public enum DKCOLEJNOLO
{
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	Default
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum FJDICKFHAAC
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	Default
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum FKJMKKCPNAC
{
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Default
}
namespace RRUI.Theme
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class AudioPalette : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public class ButtonAudioPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			[SerializeField]
			private IFBABLCDPMI buttonAudioPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			[SerializeField]
			private ButtonAudioPaletteAsset buttonAudioPaletteConfig;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public IFBABLCDPMI ButtonAudioPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000026")]
				[Cpp2IlInjected.Address(RVA = "0xA6D110", Offset = "0xA6C510", VA = "0x180A6D110")]
				get
				{
					return default(IFBABLCDPMI);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public ButtonAudioPaletteAsset ButtonAudioPaletteConfig
			{
				[Cpp2IlInjected.Token(Token = "0x6000027")]
				[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
			public ButtonAudioPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public class ScrollingAudioPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			[SerializeField]
			private DKCOLEJNOLO scrollingAudioPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			[SerializeField]
			private ScrollingAudioPaletteAsset scrollingAudioPaletteConfig;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public DKCOLEJNOLO ScrollingAudioPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0xA6D110", Offset = "0xA6C510", VA = "0x180A6D110")]
				get
				{
					return default(DKCOLEJNOLO);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public ScrollingAudioPaletteAsset ScrollingAudioPaletteConfig
			{
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
			public ScrollingAudioPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public class ContentLoadingAudioPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			[SerializeField]
			private FJDICKFHAAC contentLoadingAudioPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			[SerializeField]
			private ContentLoadingAudioPaletteAsset contentLoadingAudioPaletteConfig;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public FJDICKFHAAC ContentLoadingAudioPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0xA6D110", Offset = "0xA6C510", VA = "0x180A6D110")]
				get
				{
					return default(FJDICKFHAAC);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public ContentLoadingAudioPaletteAsset ContentLoadingAudioPaletteConfig
			{
				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
			public ContentLoadingAudioPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public class RecyclingAudioPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			[SerializeField]
			private FKJMKKCPNAC recyclingAudioPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			[SerializeField]
			private RecyclingAudioPaletteAsset recyclingAudioPaletteConfig;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public FKJMKKCPNAC RecyclingAudioPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0xA6D110", Offset = "0xA6C510", VA = "0x180A6D110")]
				get
				{
					return default(FKJMKKCPNAC);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public RecyclingAudioPaletteAsset RecyclingAudioPaletteConfig
			{
				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
			public RecyclingAudioPaletteItem()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class OIFOCINGOKA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public IFBABLCDPMI buttonAudioPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
			public OIFOCINGOKA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xB31700", Offset = "0xB30B00", VA = "0x180B31700")]
			internal bool FNPINEGDOAB(ButtonAudioPaletteItem buttonAudioPalette)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class AFIHMPEPILF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public DKCOLEJNOLO scrollingAudioPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
			public AFIHMPEPILF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xB31700", Offset = "0xB30B00", VA = "0x180B31700")]
			internal bool JIIFMIFDCPE(ScrollingAudioPaletteItem scrollingAudioPalette)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class GEEHEMDLFBB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public FJDICKFHAAC contentLoadingAudioPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
			public GEEHEMDLFBB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xB31700", Offset = "0xB30B00", VA = "0x180B31700")]
			internal bool EFPCBPLFLPO(ContentLoadingAudioPaletteItem contentLoadingAudioPalette)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class BNMMHMLGENP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public FKJMKKCPNAC recyclingAudioPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
			public BNMMHMLGENP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xB31700", Offset = "0xB30B00", VA = "0x180B31700")]
			internal bool ILOLHHHCHJF(RecyclingAudioPaletteItem recyclingAudioPalette)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[SerializeField]
		[AEDBLLJFHLF("ButtonAudioPaletteType")]
		private ButtonAudioPaletteItem[] buttonAudioPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[SerializeField]
		[AEDBLLJFHLF("ScrollingAudioPaletteType")]
		private ScrollingAudioPaletteItem[] scrollingAudioPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[SerializeField]
		[AEDBLLJFHLF("ContentLoadingAudioPaletteType")]
		private ContentLoadingAudioPaletteItem[] contentLoadingAudioPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[SerializeField]
		[AEDBLLJFHLF("RecyclingAudioPaletteType")]
		private RecyclingAudioPaletteItem[] recyclingAudioPalettes;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8DE6A80", Offset = "0x8DE5E80", VA = "0x188DE6A80")]
		public ButtonAudioPaletteAsset JJFGOLCBAJN(IFBABLCDPMI ONNNPOKKFOO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8DE6990", Offset = "0x8DE5D90", VA = "0x188DE6990")]
		public ScrollingAudioPaletteAsset EMFAHCKNMBI(DKCOLEJNOLO LOHPICNCONK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8DE6C60", Offset = "0x8DE6060", VA = "0x188DE6C60")]
		public ContentLoadingAudioPaletteAsset POHFIMHINDB(FJDICKFHAAC IGIKPKHAFBI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8DE6B70", Offset = "0x8DE5F70", VA = "0x188DE6B70")]
		public RecyclingAudioPaletteAsset PANPPFILMHK(FKJMKKCPNAC ECGHAOIHHMN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xCFA860", Offset = "0xCF9C60", VA = "0x180CFA860")]
		public AudioPalette()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ButtonAnimationPalette : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[SerializeField]
		private float clickAnimationDuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[SerializeField]
		private float clickAnimationScale;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float ClickAnimationDuration
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xABFF30", Offset = "0xABF330", VA = "0x180ABFF30")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public float ClickAnimationScale
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xABFF40", Offset = "0xABF340", VA = "0x180ABFF40")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8DE6DE0", Offset = "0x8DE61E0", VA = "0x188DE6DE0")]
		public ButtonAnimationPalette()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class ButtonPalette
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[Header("Background")]
		[SerializeField]
		private Color backgroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[SerializeField]
		[FormerlySerializedAs("colorBlock")]
		private ColorBlock backgroundTints;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[SerializeField]
		private GradientBlock backgroundGradients;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[Header("Foreground")]
		[SerializeField]
		private Color foregroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private ColorBlock foregroundTints;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[Header("Border")]
		[SerializeField]
		private bool showBorder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[Header("Text")]
		[SerializeField]
		private TextStylePalette textPalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[Header("Audio")]
		[SerializeField]
		private IFBABLCDPMI audioPalette;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Color BackgroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xE6E090", Offset = "0xE6D490", VA = "0x180E6E090")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public ColorBlock BackgroundTints
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x8DE6F00", Offset = "0x8DE6300", VA = "0x188DE6F00")]
			get
			{
				return default(ColorBlock);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public GradientBlock BackgroundGradients
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x14EDF30", Offset = "0x14ED330", VA = "0x1814EDF30")]
			get
			{
				return default(GradientBlock);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Color ForegroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x1246800", Offset = "0x1245C00", VA = "0x181246800")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public ColorBlock ForegroundTints
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x8DE6F40", Offset = "0x8DE6340", VA = "0x188DE6F40")]
			get
			{
				return default(ColorBlock);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool ShowBorder
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xAE4AC0", Offset = "0xAE3EC0", VA = "0x180AE4AC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public TextStylePalette TextPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xAE66C0", Offset = "0xAE5AC0", VA = "0x180AE66C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public IFBABLCDPMI AudioPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xBD5510", Offset = "0xBD4910", VA = "0x180BD5510")]
			get
			{
				return default(IFBABLCDPMI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8DE6E00", Offset = "0x8DE6200", VA = "0x188DE6E00")]
		public ButtonPalette()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class DepthPalette
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		private float depth;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float Depth
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xD43CC0", Offset = "0xD430C0", VA = "0x180D43CC0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public DepthPalette()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class DropdownPalette
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		private Color backgroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[SerializeField]
		private Color foregroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[SerializeField]
		private TextStylePalette textPalette;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Color BackgroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xE6E090", Offset = "0xE6D490", VA = "0x180E6E090")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public TextStylePalette TextPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xA70370", Offset = "0xA6F770", VA = "0x180A70370")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8DE96B0", Offset = "0x8DE8AB0", VA = "0x188DE96B0")]
		public DropdownPalette()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class InputFieldPalette
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[SerializeField]
		private Color backgroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[SerializeField]
		private Color foregroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[SerializeField]
		private Color placeholderColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		private TextStylePalette textPalette;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Color BackgroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xE6E090", Offset = "0xE6D490", VA = "0x180E6E090")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Color ForegroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0xE6C740", Offset = "0xE6BB40", VA = "0x180E6C740")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Color PlaceholderColor
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xF1DE10", Offset = "0xF1D210", VA = "0x180F1DE10")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public TextStylePalette TextPalette
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xA70260", Offset = "0xA6F660", VA = "0x180A70260")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8DEAD40", Offset = "0x8DEA140", VA = "0x188DEAD40")]
		public InputFieldPalette()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class MakerPenToolPalette
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		private ButtonPalette buttonPalette;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public ButtonPalette ButtonPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public MakerPenToolPalette()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class MixedTogglePalette
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		private enum DPJEJEMKLOM
		{
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			UseBaseInactive,
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			UseBaseActive,
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			UseCustom
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[SerializeField]
		private OHIKMFJGKEO baseTogglePalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[SerializeField]
		private DPJEJEMKLOM mixedPaletteType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[SerializeField]
		[GKAGFGDDNKD("mixedPaletteType", DPJEJEMKLOM.UseCustom)]
		private ButtonPalette mixedButtonPalette;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8DEBB70", Offset = "0x8DEAF70", VA = "0x188DEBB70")]
		public TogglePalette PBEEBGFECBL(Palette MGPDCGEAKAB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8DEBB00", Offset = "0x8DEAF00", VA = "0x188DEBB00")]
		public ButtonPalette GLPKDCCFCGB(Palette MGPDCGEAKAB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public MixedTogglePalette()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class Palette : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public class RawImageColorPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			[SerializeField]
			private KFLNBKKPKAL paletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			[SerializeField]
			private Color color;

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			public KFLNBKKPKAL RawImageColorPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000067")]
				[Cpp2IlInjected.Address(RVA = "0xA6D110", Offset = "0xA6C510", VA = "0x180A6D110")]
				get
				{
					return default(KFLNBKKPKAL);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			public Color Color
			{
				[Cpp2IlInjected.Token(Token = "0x6000068")]
				[Cpp2IlInjected.Address(RVA = "0x1B6E390", Offset = "0x1B6D790", VA = "0x181B6E390")]
				get
				{
					return default(Color);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xAB52F0", Offset = "0xAB46F0", VA = "0x180AB52F0")]
			public RawImageColorPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public class BackgroundColorPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			[SerializeField]
			private IDODGDMJMIC backgroundColorPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			[SerializeField]
			private Color color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			[SerializeField]
			private Gradient gradient;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			[SerializeField]
			private bool raycastTarget;

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			public IDODGDMJMIC BackgroundColorPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600006A")]
				[Cpp2IlInjected.Address(RVA = "0xA6D110", Offset = "0xA6C510", VA = "0x180A6D110")]
				get
				{
					return default(IDODGDMJMIC);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			public Color Color
			{
				[Cpp2IlInjected.Token(Token = "0x600006B")]
				[Cpp2IlInjected.Address(RVA = "0x1B6E390", Offset = "0x1B6D790", VA = "0x181B6E390")]
				get
				{
					return default(Color);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			public Gradient Gradient
			{
				[Cpp2IlInjected.Token(Token = "0x600006C")]
				[Cpp2IlInjected.Address(RVA = "0xA703F0", Offset = "0xA6F7F0", VA = "0x180A703F0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			public bool RaycastTarget
			{
				[Cpp2IlInjected.Token(Token = "0x600006D")]
				[Cpp2IlInjected.Address(RVA = "0xA9C690", Offset = "0xA9BA90", VA = "0x180A9C690")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x8DE6D50", Offset = "0x8DE6150", VA = "0x188DE6D50")]
			public BackgroundColorPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		public class ForegroundColorPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			[SerializeField]
			private JMLAGGJHLCC foregroundColorPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			[SerializeField]
			private Color color;

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public JMLAGGJHLCC ForegroundColorPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600006F")]
				[Cpp2IlInjected.Address(RVA = "0xA6D110", Offset = "0xA6C510", VA = "0x180A6D110")]
				get
				{
					return default(JMLAGGJHLCC);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			public Color Color
			{
				[Cpp2IlInjected.Token(Token = "0x6000070")]
				[Cpp2IlInjected.Address(RVA = "0x1B6E390", Offset = "0x1B6D790", VA = "0x181B6E390")]
				get
				{
					return default(Color);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x8DEA6C0", Offset = "0x8DE9AC0", VA = "0x188DEA6C0")]
			public ForegroundColorPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public class TilerPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			[SerializeField]
			private GGDKLJKKHIH tilerPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			[SerializeField]
			private TilerPalette tilerPalette;

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			public GGDKLJKKHIH TilerPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000072")]
				[Cpp2IlInjected.Address(RVA = "0xA6D110", Offset = "0xA6C510", VA = "0x180A6D110")]
				get
				{
					return default(GGDKLJKKHIH);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			public TilerPalette TilerPalette
			{
				[Cpp2IlInjected.Token(Token = "0x6000073")]
				[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
			public TilerPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public class TextStylePaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			[SerializeField]
			private HNMCLHCAEOG textStylePaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			[SerializeField]
			private TextStylePalette textStylePalette;

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			public HNMCLHCAEOG TextStylePaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000075")]
				[Cpp2IlInjected.Address(RVA = "0xA6D110", Offset = "0xA6C510", VA = "0x180A6D110")]
				get
				{
					return default(HNMCLHCAEOG);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			public TextStylePalette TextStylePalette
			{
				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
			public TextStylePaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public class TextSizePaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			[SerializeField]
			private MHDMNPBIDPA textSizePaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			[SerializeField]
			private int size;

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			public MHDMNPBIDPA TextSizePaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0xA6D110", Offset = "0xA6C510", VA = "0x180A6D110")]
				get
				{
					return default(MHDMNPBIDPA);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			public int Size
			{
				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0xAC6FB0", Offset = "0xAC63B0", VA = "0x180AC6FB0")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x1560340", Offset = "0x155F740", VA = "0x181560340")]
			public TextSizePaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public class ButtonPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			[SerializeField]
			private GEFGJILNCNL buttonPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			[SerializeField]
			private ButtonPalette buttonPalette;

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			public GEFGJILNCNL ButtonPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(RVA = "0xA6D110", Offset = "0xA6C510", VA = "0x180A6D110")]
				get
				{
					return default(GEFGJILNCNL);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			public ButtonPalette ButtonPalette
			{
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
			public ButtonPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public class TogglePaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			[SerializeField]
			private OHIKMFJGKEO togglePaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			[SerializeField]
			private TogglePalette togglePalette;

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public OHIKMFJGKEO TogglePaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600007E")]
				[Cpp2IlInjected.Address(RVA = "0xA6D110", Offset = "0xA6C510", VA = "0x180A6D110")]
				get
				{
					return default(OHIKMFJGKEO);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public TogglePalette TogglePalette
			{
				[Cpp2IlInjected.Token(Token = "0x600007F")]
				[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
			public TogglePaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public class MixedTogglePaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			[SerializeField]
			private LFFLKEINPJL mixedTogglePaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			[SerializeField]
			private MixedTogglePalette mixedTogglePalette;

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public LFFLKEINPJL MixedTogglePaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000081")]
				[Cpp2IlInjected.Address(RVA = "0xA6D110", Offset = "0xA6C510", VA = "0x180A6D110")]
				get
				{
					return default(LFFLKEINPJL);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public MixedTogglePalette MixedTogglePalette
			{
				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
			public MixedTogglePaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public class MakerPenToolPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			[SerializeField]
			private PDDIKKOFLFP makerPenToolPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			[SerializeField]
			private MakerPenToolPalette makerPenToolPalette;

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public PDDIKKOFLFP MakerPenToolPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0xA6D110", Offset = "0xA6C510", VA = "0x180A6D110")]
				get
				{
					return default(PDDIKKOFLFP);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public MakerPenToolPalette MakerPenToolPalette
			{
				[Cpp2IlInjected.Token(Token = "0x6000085")]
				[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
			public MakerPenToolPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public class InputFieldPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			[SerializeField]
			private APFKIEIMIPK inputFieldPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			[SerializeField]
			private InputFieldPalette inputFieldPalette;

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public APFKIEIMIPK InputFieldPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0xA6D110", Offset = "0xA6C510", VA = "0x180A6D110")]
				get
				{
					return default(APFKIEIMIPK);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public InputFieldPalette InputFieldPalette
			{
				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
			public InputFieldPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public class DropdownPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			[SerializeField]
			private NMLKOGOHMGM dropdownPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			[SerializeField]
			private DropdownPalette dropdownPalette;

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public NMLKOGOHMGM DropdownPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600008A")]
				[Cpp2IlInjected.Address(RVA = "0xA6D110", Offset = "0xA6C510", VA = "0x180A6D110")]
				get
				{
					return default(NMLKOGOHMGM);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public DropdownPalette DropdownPalette
			{
				[Cpp2IlInjected.Token(Token = "0x600008B")]
				[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
			public DropdownPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public class SliderPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			[SerializeField]
			private NCBJGEOAHFA sliderPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			[SerializeField]
			private SliderPalette sliderPalette;

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public NCBJGEOAHFA SliderPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0xA6D110", Offset = "0xA6C510", VA = "0x180A6D110")]
				get
				{
					return default(NCBJGEOAHFA);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public SliderPalette SliderPalette
			{
				[Cpp2IlInjected.Token(Token = "0x600008E")]
				[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
			public SliderPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public class DepthPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			[SerializeField]
			private DMEHCIOJJAC depthPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			[SerializeField]
			private DepthPalette depthPalette;

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			public DMEHCIOJJAC DepthPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000090")]
				[Cpp2IlInjected.Address(RVA = "0xA6D110", Offset = "0xA6C510", VA = "0x180A6D110")]
				get
				{
					return default(DMEHCIOJJAC);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public DepthPalette DepthPalette
			{
				[Cpp2IlInjected.Token(Token = "0x6000091")]
				[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
			public DepthPaletteItem()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private sealed class NGEAHNELKFN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public KFLNBKKPKAL backgroundColorPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
			public NGEAHNELKFN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xB31700", Offset = "0xB30B00", VA = "0x180B31700")]
			internal bool EHJFMJMECPG(RawImageColorPaletteItem pi)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class MOAKNDOADIP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public IDODGDMJMIC backgroundColorPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
			public MOAKNDOADIP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xB31700", Offset = "0xB30B00", VA = "0x180B31700")]
			internal bool LNGHMDINILP(BackgroundColorPaletteItem backgroundColorPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class HNEJAEBIMGK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public JMLAGGJHLCC foregroundColorPaletteType;

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
			public HNEJAEBIMGK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xB31700", Offset = "0xB30B00", VA = "0x180B31700")]
			internal bool NPALMJCBGDL(ForegroundColorPaletteItem colorPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[CompilerGenerated]
		private sealed class HCPEMMBLBGM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public GGDKLJKKHIH type;

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
			public HCPEMMBLBGM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0xB31700", Offset = "0xB30B00", VA = "0x180B31700")]
			internal bool JMFPMHICOCH(TilerPaletteItem tilerPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		[CompilerGenerated]
		private sealed class KFOMJJMFOFG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public HNMCLHCAEOG textStylePaletteType;

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
			public KFOMJJMFOFG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xB31700", Offset = "0xB30B00", VA = "0x180B31700")]
			internal bool MEONMDFBAJE(TextStylePaletteItem textStylePaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class MIFCJKCAGNJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public MHDMNPBIDPA textSizePaletteType;

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
			public MIFCJKCAGNJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xB31700", Offset = "0xB30B00", VA = "0x180B31700")]
			internal bool FCGONMINKFP(TextSizePaletteItem textSizePaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class OFBPJFCKFBN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public GEFGJILNCNL buttonPaletteType;

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
			public OFBPJFCKFBN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xB31700", Offset = "0xB30B00", VA = "0x180B31700")]
			internal bool NFHBMICGGEK(ButtonPaletteItem buttonPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000035")]
		[CompilerGenerated]
		private sealed class BIMIPLJLKJK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public OHIKMFJGKEO togglePaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
			public BIMIPLJLKJK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0xB31700", Offset = "0xB30B00", VA = "0x180B31700")]
			internal bool EGKHAHMIPCF(TogglePaletteItem togglePaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000036")]
		[CompilerGenerated]
		private sealed class KAEACGHAPPC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public LFFLKEINPJL mixedTogglePaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
			public KAEACGHAPPC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0xB31700", Offset = "0xB30B00", VA = "0x180B31700")]
			internal bool DPHJONDDGPO(MixedTogglePaletteItem mixedTogglePaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[CompilerGenerated]
		private sealed class JAKOHKIBMJO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public PDDIKKOFLFP makerPenToolPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
			public JAKOHKIBMJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xB31700", Offset = "0xB30B00", VA = "0x180B31700")]
			internal bool ILDOOKINGFA(MakerPenToolPaletteItem makerPenToolPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		[CompilerGenerated]
		private sealed class GBHIJBAMHNL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public APFKIEIMIPK inputFieldPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
			public GBHIJBAMHNL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xB31700", Offset = "0xB30B00", VA = "0x180B31700")]
			internal bool GBNMAEIAKCL(InputFieldPaletteItem inputFieldPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000039")]
		[CompilerGenerated]
		private sealed class LJDGGDEAGPO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public NMLKOGOHMGM dropdownPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
			public LJDGGDEAGPO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xB31700", Offset = "0xB30B00", VA = "0x180B31700")]
			internal bool AHDEJBAEDFJ(DropdownPaletteItem dropdownPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		[CompilerGenerated]
		private sealed class IPOFFOHBLJB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public NCBJGEOAHFA sliderPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
			public IPOFFOHBLJB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xB31700", Offset = "0xB30B00", VA = "0x180B31700")]
			internal bool KFKHMODCBBP(SliderPaletteItem sliderPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		[CompilerGenerated]
		private sealed class MMAMINLJNLN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public DMEHCIOJJAC depthPaletteType;

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
			public MMAMINLJNLN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xB31700", Offset = "0xB30B00", VA = "0x180B31700")]
			internal bool PEPCKJMCLEG(DepthPaletteItem depthPaletteItem)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[Header("Visual")]
		[SerializeField]
		[AEDBLLJFHLF("RawImageColorPaletteType")]
		private RawImageColorPaletteItem[] rawImageColorPaletteItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[SerializeField]
		[AEDBLLJFHLF("BackgroundColorPaletteType")]
		private BackgroundColorPaletteItem[] backgroundColorPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[SerializeField]
		[AEDBLLJFHLF("ForegroundColorPaletteType")]
		private ForegroundColorPaletteItem[] foregroundColorPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[SerializeField]
		[AEDBLLJFHLF("TilerPaletteType")]
		private TilerPaletteItem[] tilerPaletteItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[SerializeField]
		[AEDBLLJFHLF("TextStylePaletteType")]
		private TextStylePaletteItem[] textStylePalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[SerializeField]
		[AEDBLLJFHLF("TextSizePaletteType")]
		private TextSizePaletteItem[] textSizePalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[SerializeField]
		[AEDBLLJFHLF("ButtonPaletteType")]
		private ButtonPaletteItem[] buttonPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[SerializeField]
		[AEDBLLJFHLF("TogglePaletteType")]
		private TogglePaletteItem[] togglePalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[SerializeField]
		[AEDBLLJFHLF("MixedTogglePaletteType")]
		private MixedTogglePaletteItem[] mixedTogglePalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[SerializeField]
		[AEDBLLJFHLF("MakerPenToolPaletteType")]
		private MakerPenToolPaletteItem[] makerPenToolPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[SerializeField]
		[AEDBLLJFHLF("InputFieldPaletteType")]
		private InputFieldPaletteItem[] inputFieldPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[SerializeField]
		[AEDBLLJFHLF("DropdownPaletteType")]
		private DropdownPaletteItem[] dropdownPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[SerializeField]
		[AEDBLLJFHLF("SliderPaletteType")]
		private SliderPaletteItem[] sliderPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[SerializeField]
		[AEDBLLJFHLF("DepthPaletteType")]
		private DepthPaletteItem[] depthPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[SerializeField]
		private ButtonAnimationPalette buttonAnimationPalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[Header("Audio")]
		[SerializeField]
		[FormerlySerializedAs("audioPaletteConfig")]
		private AudioPalette audioPalette;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public IEnumerable<DepthPaletteItem> DepthPalettes
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xA7C870", Offset = "0xA7BC70", VA = "0x180A7C870")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public ButtonAnimationPalette ButtonAnimationPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xA7C960", Offset = "0xA7BD60", VA = "0x180A7C960")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public AudioPalette AudioPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xAD90C0", Offset = "0xAD84C0", VA = "0x180AD90C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8DEF180", Offset = "0x8DEE580", VA = "0x188DEF180")]
		public Color JIHMMODDAFJ(KFLNBKKPKAL GGMFICPDGAM)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8DEE980", Offset = "0x8DEDD80", VA = "0x188DEE980")]
		public void CKAOPPEPPJD(IDODGDMJMIC GGMFICPDGAM, [Out] Color IFBOGFLAOGG, [Out] Gradient DMCNKEGAHEG, [Out] bool PNCOHKOFLMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8DEF590", Offset = "0x8DEE990", VA = "0x188DEF590")]
		public Color OMNFJMJMFKA(JMLAGGJHLCC ANCOHOCJCFN)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8DEEBE0", Offset = "0x8DEDFE0", VA = "0x188DEEBE0")]
		public TilerPalette DKGGKAACKJH(GGDKLJKKHIH IIHAKBEOLJD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8DEEEB0", Offset = "0x8DEE2B0", VA = "0x188DEEEB0")]
		public TextStylePalette HLAJBAJFEFK(HNMCLHCAEOG HGGIADAFJBE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8DEF090", Offset = "0x8DEE490", VA = "0x188DEF090")]
		public int IPINKALLKKC(MHDMNPBIDPA NFPBBMGNIOJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8DEECD0", Offset = "0x8DEE0D0", VA = "0x188DEECD0")]
		public ButtonPalette DMMLLBABNGI(GEFGJILNCNL OAFIAIMEAEP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8DEEDC0", Offset = "0x8DEE1C0", VA = "0x188DEEDC0")]
		public TogglePalette GNGIHLGDAKC(OHIKMFJGKEO GFKEAOHJBAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8DEF4A0", Offset = "0x8DEE8A0", VA = "0x188DEF4A0")]
		public MixedTogglePalette NPIIDCPBPIC(LFFLKEINPJL DOCFLHMNEJI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8DEEAF0", Offset = "0x8DEDEF0", VA = "0x188DEEAF0")]
		public MakerPenToolPalette DILPOOLALAL(PDDIKKOFLFP JOHOOLIBAAB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8DEF690", Offset = "0x8DEEA90", VA = "0x188DEF690")]
		public InputFieldPalette PFPLPNCEKBL(APFKIEIMIPK JHIFGJHNJCK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8DEF3B0", Offset = "0x8DEE7B0", VA = "0x188DEF3B0")]
		public DropdownPalette MFCJNGFDANP(NMLKOGOHMGM DCJKJHKPJDL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8DEEFA0", Offset = "0x8DEE3A0", VA = "0x188DEEFA0")]
		public SliderPalette IAIOLAONMHD(NCBJGEOAHFA KJPGFNJMHEM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8DEF280", Offset = "0x8DEE680", VA = "0x188DEF280")]
		public float? LOHLDJHENCP(DMEHCIOJJAC CKNDCHPOMDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xCFA860", Offset = "0xCF9C60", VA = "0x180CFA860")]
		public Palette()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public class SliderPalette
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[SerializeField]
		private Color sliderColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[SerializeField]
		private Color fillColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[SerializeField]
		private Color handleColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[SerializeField]
		private TextStylePalette textPalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[SerializeField]
		private Color textColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[SerializeField]
		private ColorBlock colorBlock;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public Color SliderColor
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xE6E090", Offset = "0xE6D490", VA = "0x180E6E090")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public Color FillColor
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xE6C740", Offset = "0xE6BB40", VA = "0x180E6C740")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public Color HandleColor
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xF1DE10", Offset = "0xF1D210", VA = "0x180F1DE10")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public ColorBlock ColorBlock
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x8DF3ED0", Offset = "0x8DF32D0", VA = "0x188DF3ED0")]
			get
			{
				return default(ColorBlock);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8DF3E10", Offset = "0x8DF3210", VA = "0x188DF3E10")]
		public SliderPalette()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public class TextStylePalette
	{
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		public enum JCHDAMLCAMJ
		{
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			LowerCase,
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			UpperCase,
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			SmallCaps
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[SerializeField]
		private TMP_FontAsset font;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[SerializeField]
		private Material fontOverrideMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[SerializeField]
		private float kerning;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		[SerializeField]
		private float leading;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[SerializeField]
		private bool isBold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[SerializeField]
		private bool isItalic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[SerializeField]
		private JCHDAMLCAMJ transformation;

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8DF4900", Offset = "0x8DF3D00", VA = "0x188DF4900")]
		public void JHGGCFPJCOG(TextMeshProUGUI MPJEMCEIOIF, bool INAGPJAEBNE = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public TextStylePalette()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public class TilerPalette
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		[SerializeField]
		private Sprite sprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[SerializeField]
		private Color tintColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[SerializeField]
		private Color backgroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[SerializeField]
		private float rows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[SerializeField]
		private Vector2 spacing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[SerializeField]
		private float offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[SerializeField]
		private Vector2 velocity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		[SerializeField]
		[Range(0f, 360f)]
		private float angle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		[SerializeField]
		private UITiler.GKMEMIHLENM animationDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		[SerializeField]
		private float primaryAnimationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		[SerializeField]
		private float altAnimationSpeed;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public Sprite Sprite
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public Color TintColor
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xD45140", Offset = "0xD44540", VA = "0x180D45140")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public Color BackgroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x13E0010", Offset = "0x13DF410", VA = "0x1813E0010")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public float Rows
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xAC27C0", Offset = "0xAC1BC0", VA = "0x180AC27C0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public Vector2 Spacing
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x1035030", Offset = "0x1034430", VA = "0x181035030")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public float Offset
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0xE32DB0", Offset = "0xE321B0", VA = "0x180E32DB0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public Vector2 Velocity
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x8DF4EE0", Offset = "0x8DF42E0", VA = "0x188DF4EE0")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public float Angle
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x1246850", Offset = "0x1245C50", VA = "0x181246850")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public UITiler.GKMEMIHLENM AnimationDirection
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x12C9B60", Offset = "0x12C8F60", VA = "0x1812C9B60")]
			get
			{
				return default(UITiler.GKMEMIHLENM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public float PrimaryAnimationSpeed
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x1246840", Offset = "0x1245C40", VA = "0x181246840")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public float AltAnimationSpeed
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x1246880", Offset = "0x1245C80", VA = "0x181246880")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8DF4E90", Offset = "0x8DF4290", VA = "0x188DF4E90")]
		public TilerPalette()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public class TogglePalette
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		[SerializeField]
		private ButtonPalette inactiveButtonPalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		[SerializeField]
		private ButtonPalette activeButtonPalette;

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public ButtonPalette InactiveButtonPalette
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public ButtonPalette ActiveButtonPalette
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public TogglePalette()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public enum IDODGDMJMIC
{
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	PrimarySolid,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	SecondarySolid,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	HighlightSolid,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	HighlightGradient,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	BannerBG,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	InputField,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	LineColor,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	CardImageBase,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	DarkGradient,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	Shadow,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	Error,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	Warning,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	NotiBase,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	BackgroundAccent,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	SideBarBG,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	Modified,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	LoadingScreen,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	LoadingBarGradient,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	HomeButtonBase,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	TitleRoot,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	HighlightedAccent,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	LoadingCard,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	ChipBase,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	LimitedEventCard,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	LimitedEventBgSolid,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	DateChip,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	WinterWonderlandBG,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	RuntimeAddedTag,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	RuntimeDeletedTag,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	MakerAI,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	RRPlus
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public enum KFLNBKKPKAL
{
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	A
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public enum JMLAGGJHLCC
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
[Cpp2IlInjected.Token(Token = "0x2000044")]
public enum GGDKLJKKHIH
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
[Cpp2IlInjected.Token(Token = "0x2000045")]
public enum HNMCLHCAEOG
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
[Cpp2IlInjected.Token(Token = "0x2000046")]
public enum MHDMNPBIDPA
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
[Cpp2IlInjected.Token(Token = "0x2000047")]
public enum GEFGJILNCNL
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
	RevenuePurchaseGreen,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	RecRoomPlus,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	SearchBar
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public enum OHIKMFJGKEO
{
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	FlatOrange,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	FlatWhite,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	InputToggle,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	Chips,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	Switch,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	WhitePagingBlob,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	RSVPToggleHeaderSection,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	CardSelectableToggle,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	ChipsDark,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	MainNavToggle,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	ListItem,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	NotiUnread,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	FlatPrimary,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	CharadePen,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	ShareCam,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	CardSelectableToggleWithBacking,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	SecondaryHeaderSectionToggle,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	PrimaryToSecondaryHeader,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	NegativeToSecondaryHeader,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	LimitedEventPrimary,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	LimitedEventSecondary,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	RoomCardWithLimitedEvent,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	MainNavVrDetach,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	HomeMainNav,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	FlatOrangeSecondary,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	ChipsPurple,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	ShareCamTab
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public enum LFFLKEINPJL
{
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	Checkbox
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public enum PDDIKKOFLFP
{
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	Create,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	Select,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	Wire,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	Configure,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	Transform,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	Move,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	Rotate,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	Scale,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	CloneFlip,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	Recolor,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	Freeze,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	MakeInvention,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	Manipulate,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	Delete,
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	SelectConnect,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	ResetMakerAI
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public enum APFKIEIMIPK
{
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	LightFlat,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	DarkFlat,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	Modified
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public enum NMLKOGOHMGM
{
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	LightFlat,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	DarkFlat
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public enum NCBJGEOAHFA
{
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	MirroUIPopUp
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public enum DMEHCIOJJAC
{
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	Base,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	Button,
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	Navigation,
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	Overlay,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	Dialog,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	Toast
}
namespace RRUI.Theme
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public class ApproximationMaskDepthTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		[SerializeField]
		private RectTransform content;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private Vector3? PLNBGAGBAPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private Vector3? NEADOAAEHEM;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x8DE6860", Offset = "0x8DE5C60", VA = "0x188DE6860")]
		private void PJOFCLDPLJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x8DE64B0", Offset = "0x8DE58B0", VA = "0x188DE64B0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8DE6940", Offset = "0x8DE5D40", VA = "0x188DE6940")]
		public ApproximationMaskDepthTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public class ButtonTheme : ButtonThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		[Header("Button Visual")]
		[SerializeField]
		private GEFGJILNCNL buttonType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14C")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		[Header("Button Audio")]
		[SerializeField]
		[Tooltip("Override the audio palette defined by the button's visual with a custom palette")]
		private bool overrideButtonAudioPalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		[GKAGFGDDNKD("overrideButtonAudioPalette")]
		[Tooltip("Specify a custom config to use for button audio")]
		[SerializeField]
		private ButtonAudioPaletteAsset customButtonAudioConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		[SerializeField]
		[Tooltip("Layer a 2D SFX on top of base button sounds")]
		private bool useFlavorSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		[SerializeField]
		[GKAGFGDDNKD("useFlavorSFX")]
		[Tooltip("Flavor SFX is picked randomly from this pool config")]
		private RecRoomAudioClipPoolConfig flavorSFXClipPoolConfig;

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public GEFGJILNCNL AIGMDKLLCHD
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x25B6760", Offset = "0x25B5B60", VA = "0x1825B6760")]
			get
			{
				return default(GEFGJILNCNL);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x8DE88C0", Offset = "0x8DE7CC0", VA = "0x188DE88C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8DE8650", Offset = "0x8DE7A50", VA = "0x188DE8650", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0xC329F0", Offset = "0xC31DF0", VA = "0x180C329F0")]
		public void SetAnimationEnabled(bool DGKJCLCLLMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x8DE88B0", Offset = "0x8DE7CB0", VA = "0x188DE88B0")]
		public ButtonTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public abstract class ButtonThemeBase : SelectableThemeBase
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		protected class NGINLHPKLKC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000174")]
			public ButtonAudioPaletteAsset ECJANJFBPOL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000175")]
			public RecRoomAudioClipPoolConfig MILGFBDPDEP;

			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
			public NGINLHPKLKC()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		[OCPKILIHCKA(FIPBCJPBODB.Self, false, false, false)]
		[Header("Button Theme Base")]
		[SerializeField]
		private MultiGraphicButton multiGraphicButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		[SerializeField]
		[OCPKILIHCKA(FIPBCJPBODB.Self, false, true, false)]
		private Image surface;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		[SerializeField]
		private bool useSurfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		[SerializeField]
		[GKAGFGDDNKD("useSurfaceOverride")]
		private Image surfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		[SerializeField]
		private bool controlSurfaceColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		[SerializeField]
		[ReadOnlyField]
		private List<Graphic> graphics;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		[SerializeField]
		private bool useGraphicsOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		[SerializeField]
		[GKAGFGDDNKD("useGraphicsOverride")]
		private List<Graphic> graphicsOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		[SerializeField]
		[JFNCDFAMKJP("useGraphicsOverride", new object[] { })]
		private bool graphicsIgnoreTextFields;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		[SerializeField]
		private bool controlGraphicColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		[SerializeField]
		[OCPKILIHCKA(FIPBCJPBODB.Self, false, true, false)]
		private UIGradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		[SerializeField]
		private bool useGradientOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		[SerializeField]
		[GKAGFGDDNKD("useGradientOverride")]
		private UIGradient gradientOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		[SerializeField]
		[OCPKILIHCKA(FIPBCJPBODB.Children, true, true, false)]
		private TextMeshProUGUI textMeshProUGUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		[SerializeField]
		private bool useTextMeshProUGUIOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		[SerializeField]
		[GKAGFGDDNKD("useTextMeshProUGUIOverride")]
		private TextMeshProUGUI textMeshProUGUIOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		[SerializeField]
		private MHDMNPBIDPA textSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		[SerializeField]
		protected Hideable borderHideable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		[SerializeField]
		protected bool isAnimationEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x111")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		[SerializeField]
		[GKAGFGDDNKD("isAnimationEnabled")]
		protected bool overrideAnimationTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		[SerializeField]
		[GKAGFGDDNKD("overrideAnimationTarget")]
		protected GameObject animationTargetOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private bool IFAKPGPOBKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private Vector3 BHKKMBNNLJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private Vector3 NFAMPLKBPML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private KJHDAMJDAEL BAFCMCLLLMB;

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public Image KPDAAGLFEFN
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x8DE85F0", Offset = "0x8DE79F0", VA = "0x188DE85F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public List<Graphic> FLALOMIHBCL
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x8DE85D0", Offset = "0x8DE79D0", VA = "0x188DE85D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public UIGradient KKEMKGOKBKJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x8DE85B0", Offset = "0x8DE79B0", VA = "0x188DE85B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public TextMeshProUGUI NFGMCBMDDHB
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x8DE8610", Offset = "0x8DE7A10", VA = "0x188DE8610")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public MHDMNPBIDPA GLBIPLFAGLL
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x1815700", Offset = "0x1814B00", VA = "0x181815700")]
			get
			{
				return default(MHDMNPBIDPA);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x8DE8630", Offset = "0x8DE7A30", VA = "0x188DE8630")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		protected Transform JAMAKFGNEII
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x8DE7BF0", Offset = "0x8DE6FF0", VA = "0x188DE7BF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public Button GOPEKDCKMCL
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x8DE8520", Offset = "0x8DE7920", VA = "0x188DE8520")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x8DE7CE0", Offset = "0x8DE70E0", VA = "0x188DE7CE0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x8DE7C40", Offset = "0x8DE7040", VA = "0x188DE7C40")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x8DE7A30", Offset = "0x8DE6E30", VA = "0x188DE7A30")]
		protected void GAOLCPBNBAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8DE6F90", Offset = "0x8DE6390", VA = "0x188DE6F90")]
		protected void BPJKMPCHAPF(ButtonPalette ABMLMMJKNBI, [Optional] NGINLHPKLKC DENEHJMOEMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8DE7D80", Offset = "0x8DE7180", VA = "0x188DE7D80", Slot = "12")]
		public override void OnPointerDown(PointerEventData FCGKHKJBFED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x8DE8130", Offset = "0x8DE7530", VA = "0x188DE8130", Slot = "13")]
		public override void OnPointerUp(PointerEventData FCGKHKJBFED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x8DE7D60", Offset = "0x8DE7160", VA = "0x188DE7D60", Slot = "14")]
		public override void OnPointerClick(PointerEventData FCGKHKJBFED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8DE79F0", Offset = "0x8DE6DF0", VA = "0x188DE79F0")]
		private Vector3 FCIDCKCJFEB(float MJHAIBCGLLD)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x8DE8430", Offset = "0x8DE7830", VA = "0x188DE8430")]
		protected ButtonThemeBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x8DE7A10", Offset = "0x8DE6E10", VA = "0x188DE7A10")]
		[CompilerGenerated]
		private void FJOMDFFNEHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x8DE7A10", Offset = "0x8DE6E10", VA = "0x188DE7A10")]
		[CompilerGenerated]
		private void LOOJJBIJPML()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public class DepthTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		[SerializeField]
		private DMEHCIOJJAC depth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		[SerializeField]
		private bool animateOnEnable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		[SerializeField]
		[GKAGFGDDNKD("animateOnEnable")]
		private float animationTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private Vector3? PLNBGAGBAPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private Vector2 CECHPDFGGPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private Vector2 LMKNHOMEJAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private Vector2 NDGODINAIAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private Vector2 HADKPKENJMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private Vector2 COIBIFJDIAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private Vector2 CCCCHIBCGJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private readonly bool? CFPIONNGDAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private PDEFAKFFIDE DHJMMMNOOFK;

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		private RectTransform ONLMABJJDPC
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x8DE8F40", Offset = "0x8DE8340", VA = "0x188DE8F40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public DMEHCIOJJAC OJIIFKIJOHI
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0xACA830", Offset = "0xAC9C30", VA = "0x180ACA830")]
			get
			{
				return default(DMEHCIOJJAC);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x8DE9690", Offset = "0x8DE8A90", VA = "0x188DE9690")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		private PDEFAKFFIDE IOKOPJDBKJC
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x8DE8EB0", Offset = "0x8DE82B0", VA = "0x188DE8EB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		private bool POFNFNDNCFN
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x8DE8FA0", Offset = "0x8DE83A0", VA = "0x188DE8FA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8DE9140", Offset = "0x8DE8540", VA = "0x188DE9140")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x8DE9090", Offset = "0x8DE8490", VA = "0x188DE9090")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x8DE8CF0", Offset = "0x8DE80F0", VA = "0x188DE8CF0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x8DE91B0", Offset = "0x8DE85B0", VA = "0x188DE91B0")]
		private void PJOFCLDPLJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x8DE8960", Offset = "0x8DE7D60", VA = "0x188DE8960")]
		private Vector3 AFPEKIFIAMG()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x8DE94D0", Offset = "0x8DE88D0", VA = "0x188DE94D0")]
		public DepthTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public class DropdownTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		[SerializeField]
		[BNCHLJBJHLJ(FIPBCJPBODB.Self, false, false, false)]
		private Dropdown dropdown;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		[SerializeField]
		[OCPKILIHCKA(FIPBCJPBODB.Self, false, true, false)]
		private Image surface;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		[SerializeField]
		private bool useSurfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		[SerializeField]
		[GKAGFGDDNKD("useSurfaceOverride")]
		private Image surfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		[SerializeField]
		private NMLKOGOHMGM dropdownType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		[SerializeField]
		private MHDMNPBIDPA textSize;

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public Image KPDAAGLFEFN
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x8DE9D30", Offset = "0x8DE9130", VA = "0x188DE9D30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public NMLKOGOHMGM ONLJHOOEAKN
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0xAD8D80", Offset = "0xAD8180", VA = "0x180AD8D80")]
			get
			{
				return default(NMLKOGOHMGM);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x8DE9D40", Offset = "0x8DE9140", VA = "0x188DE9D40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public MHDMNPBIDPA GLBIPLFAGLL
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xE6C750", Offset = "0xE6BB50", VA = "0x180E6C750")]
			get
			{
				return default(MHDMNPBIDPA);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x8DE9D60", Offset = "0x8DE9160", VA = "0x188DE9D60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8DE96D0", Offset = "0x8DE8AD0", VA = "0x188DE96D0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x8DE9CE0", Offset = "0x8DE90E0", VA = "0x188DE9CE0")]
		public DropdownTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public class GraphicTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		[SerializeField]
		[BNCHLJBJHLJ(FIPBCJPBODB.Self, false, false, false)]
		private Graphic graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		[SerializeField]
		private bool useGraphicOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		[SerializeField]
		[GKAGFGDDNKD("useGraphicOverride")]
		private Graphic graphicOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		[SerializeField]
		private JMLAGGJHLCC color;

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public Graphic MPOHKCMGKMK
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x8DEAD10", Offset = "0x8DEA110", VA = "0x188DEAD10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public JMLAGGJHLCC GHJBKALBCHH
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0xA8CC50", Offset = "0xA8C050", VA = "0x180A8CC50")]
			get
			{
				return default(JMLAGGJHLCC);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x8DEAD20", Offset = "0x8DEA120", VA = "0x188DEAD20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public bool PHKLGDCMDEG
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0xF79120", Offset = "0xF78520", VA = "0x180F79120")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0xF78A80", Offset = "0xF77E80", VA = "0x180F78A80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public Color? EJBCNOEAJCI
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x8DEAAF0", Offset = "0x8DE9EF0", VA = "0x188DEAAF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x8DEA8A0", Offset = "0x8DE9CA0", VA = "0x188DEA8A0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x8DEAAA0", Offset = "0x8DE9EA0", VA = "0x188DEAAA0")]
		public GraphicTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public class InputFieldTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		[SerializeField]
		[BNCHLJBJHLJ(FIPBCJPBODB.Self, false, false, false)]
		private TMP_InputField inputField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		[SerializeField]
		[OCPKILIHCKA(FIPBCJPBODB.Self, false, false, false)]
		private Image surface;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		[SerializeField]
		private bool useSurfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		[SerializeField]
		[GKAGFGDDNKD("useSurfaceOverride")]
		private Image surfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		[SerializeField]
		private APFKIEIMIPK inputFieldType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		[SerializeField]
		private MHDMNPBIDPA textSize;

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public Image KPDAAGLFEFN
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x8DE9D30", Offset = "0x8DE9130", VA = "0x188DE9D30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public APFKIEIMIPK AECKDLCBDLN
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0xAD8D80", Offset = "0xAD8180", VA = "0x180AD8D80")]
			get
			{
				return default(APFKIEIMIPK);
			}
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x8DE9D40", Offset = "0x8DE9140", VA = "0x188DE9D40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public MHDMNPBIDPA GLBIPLFAGLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0xE6C750", Offset = "0xE6BB50", VA = "0x180E6C750")]
			get
			{
				return default(MHDMNPBIDPA);
			}
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x8DE9D60", Offset = "0x8DE9160", VA = "0x188DE9D60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x8DEAD70", Offset = "0x8DEA170", VA = "0x188DEAD70", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x8DEB240", Offset = "0x8DEA640", VA = "0x188DEB240")]
		public InputFieldTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public class LabelTheme : GraphicTheme
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		[SerializeField]
		[BNCHLJBJHLJ(FIPBCJPBODB.Self, false, false, false)]
		private TextMeshProUGUI textMeshProUGUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		[SerializeField]
		private HNMCLHCAEOG textType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		[SerializeField]
		private MHDMNPBIDPA textSize;

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public HNMCLHCAEOG CBBBOJIIMNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0xAD90A0", Offset = "0xAD84A0", VA = "0x180AD90A0")]
			get
			{
				return default(HNMCLHCAEOG);
			}
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x8DEB600", Offset = "0x8DEAA00", VA = "0x188DEB600")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public MHDMNPBIDPA GLBIPLFAGLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x146C6F0", Offset = "0x146BAF0", VA = "0x18146C6F0")]
			get
			{
				return default(MHDMNPBIDPA);
			}
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x8DEB5E0", Offset = "0x8DEA9E0", VA = "0x188DEB5E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x8DEB290", Offset = "0x8DEA690", VA = "0x188DEB290", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x8DEB590", Offset = "0x8DEA990", VA = "0x188DEB590")]
		public LabelTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public class MakerPenToolTheme : ButtonThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		[Header("Maker Pen Tool")]
		[SerializeField]
		private PDDIKKOFLFP makerPenToolPaletteType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		[SerializeField]
		[Tooltip("A list of objects to show while the maker pen tool is active.")]
		private List<Hideable> hideWhenNotActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		[SerializeField]
		[Tooltip("A list of objects to show while the maker pen tool is inactive")]
		private List<Hideable> hideWhenActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		[SerializeField]
		private bool editorIsActiveOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x161")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		protected bool PHNGOLFFIIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x162")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private bool PCGHAIMEGOE;

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public PDDIKKOFLFP PPNGILKMFFE
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x25B6760", Offset = "0x25B5B60", VA = "0x1825B6760")]
			get
			{
				return default(PDDIKKOFLFP);
			}
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x8DE88C0", Offset = "0x8DE7CC0", VA = "0x188DE88C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public bool IABJMOAGIIK
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x8DB7A80", Offset = "0x8DB6E80", VA = "0x188DB7A80")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x8DEBAE0", Offset = "0x8DEAEE0", VA = "0x188DEBAE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x8DEBAA0", Offset = "0x8DEAEA0", VA = "0x188DEBAA0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x8DEB6B0", Offset = "0x8DEAAB0", VA = "0x188DEB6B0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x8DE88B0", Offset = "0x8DE7CB0", VA = "0x188DE88B0")]
		public MakerPenToolTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public class MixedToggleTheme : ButtonThemeBase
	{
		[Cpp2IlInjected.Token(Token = "0x200005B")]
		public enum MNOAMBNOOJL
		{
			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			Inactive,
			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			Mixed,
			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			Active
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		[SerializeField]
		private LFFLKEINPJL toggleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		[SerializeField]
		[Tooltip("A list of objects to hide while the toggle is inactive.")]
		private List<Hideable> hideWhenInactive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		[SerializeField]
		[Tooltip("A list of objects to hide while the toggle is mixed.")]
		private List<Hideable> hideWhenMixed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		[SerializeField]
		[Tooltip("A list of objects to hide while the toggle is active")]
		private List<Hideable> hideWhenActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		[SerializeField]
		private MNOAMBNOOJL editorIsActiveOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private MNOAMBNOOJL PCGHAIMEGOE;

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public MNOAMBNOOJL IABJMOAGIIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x8DEC1A0", Offset = "0x8DEB5A0", VA = "0x188DEC1A0")]
			get
			{
				return default(MNOAMBNOOJL);
			}
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x8DEC180", Offset = "0x8DEB580", VA = "0x188DEC180")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8DEC150", Offset = "0x8DEB550", VA = "0x188DEC150")]
		public void Toggle()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x8DEC180", Offset = "0x8DEB580", VA = "0x188DEC180")]
		public void Toggle(MNOAMBNOOJL PCGHAIMEGOE, bool PHNGOLFFIIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x8DEBBA0", Offset = "0x8DEAFA0", VA = "0x188DEBBA0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8DE88B0", Offset = "0x8DE7CB0", VA = "0x188DE88B0")]
		public MixedToggleTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class PaletteTheme : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		[SerializeField]
		private bool usePaletteOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		[SerializeField]
		[GKAGFGDDNKD("usePaletteOverride")]
		private Palette paletteOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public OFFOKCJIMNI PaletteChangeEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		[SerializeField]
		private bool useDepth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private FEGLFIFLMGC JNHBEKDBGJG;

		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private const string JHKOKNLAGFG = "watch_layer";

		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private const string FFBJKPHMFNN = "depth_multiplier";

		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private const float PNNMPKGDICH = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private float? OBLDJNHANDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private float? BFGMOBCIHOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private float? BDLKGGCAMEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private float JAONDLFCHPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private float NLEBCNFJKFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private float LOHGDINPOFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private float AOIDJEIDHIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private readonly CKBPAEHADCP DJPLGJAOBKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private SFXAudioSource BOGNCHKDOOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private SFXAudioSource KJBFPGFHKON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private ContentLoadingAudioPaletteAsset NFAPKELDIHA;

		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private const float ECKAOMNCNEL = 0.001f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private AKNDJBKAOGM MHNBAAABAJA;

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public Palette HMENLNMPGDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x8DEE8B0", Offset = "0x8DEDCB0", VA = "0x188DEE8B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public bool BIMNDMDPBPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0xA9C690", Offset = "0xA9BA90", VA = "0x180A9C690")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public float HLOHDFEIDOL
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x8DEE630", Offset = "0x8DEDA30", VA = "0x188DEE630")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		private bool KJBCEONLLFF
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x8DED6B0", Offset = "0x8DECAB0", VA = "0x188DED6B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		private bool GHLMDMKLFGP
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x8DEDF10", Offset = "0x8DED310", VA = "0x188DEDF10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x8DED390", Offset = "0x8DEC790", VA = "0x188DED390")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x8DEDEE0", Offset = "0x8DED2E0", VA = "0x188DEDEE0")]
		private void NBDKNDMAAMO(NBIDIGCPFIO.HPHEPHPABPG GLNDBHNHACA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x8DEDF90", Offset = "0x8DED390", VA = "0x188DEDF90")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x8DED540", Offset = "0x8DEC940", VA = "0x188DED540")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x8DEE0C0", Offset = "0x8DED4C0", VA = "0x188DEE0C0")]
		private void PHBENBIJEOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x8DED270", Offset = "0x8DEC670", VA = "0x188DED270")]
		public void AddLoadingSFXRequest(object MONGIMOHLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x8DEE450", Offset = "0x8DED850", VA = "0x188DEE450")]
		public void RemoveLoadingSFXRequest(object MONGIMOHLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x8DED540", Offset = "0x8DEC940", VA = "0x188DED540")]
		private void GKHMDKGDEAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x8DEDCF0", Offset = "0x8DED0F0", VA = "0x188DEDCF0")]
		private void NADFHABKFIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x8DED820", Offset = "0x8DECC20", VA = "0x188DED820")]
		private void GOGKIFLJBIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x8DED990", Offset = "0x8DECD90", VA = "0x188DED990")]
		private void IEDAEFOJFKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x8DEDA80", Offset = "0x8DECE80", VA = "0x188DEDA80")]
		private void JFAMNOPEICD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x8DED730", Offset = "0x8DECB30", VA = "0x188DED730")]
		private void GKJLGHAIPMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x83D2C10", Offset = "0x83D2010", VA = "0x1883D2C10")]
		private void ADMNHAHGLAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x8DED140", Offset = "0x8DEC540", VA = "0x188DED140")]
		private void AAILFPJAAHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x8DED230", Offset = "0x8DEC630", VA = "0x188DED230")]
		private void AHNMGIOLKHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x8DEE280", Offset = "0x8DED680", VA = "0x188DEE280")]
		public void Play2DUIFlavorSFX(RecRoomAudioClip[] KDDPCEGIAMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x8DEE570", Offset = "0x8DED970", VA = "0x188DEE570")]
		public PaletteTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public abstract class PaletteThemeReference : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		protected static readonly AKNCNLDICPO CCLJCJDJCOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		[SerializeField]
		[OCPKILIHCKA(FIPBCJPBODB.SelfAndParent, true, false, false)]
		private PaletteTheme paletteTheme;

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		protected PaletteTheme PHOBKBDKAFA
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		protected Palette HMENLNMPGDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x8DECC10", Offset = "0x8DEC010", VA = "0x188DECC10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		protected bool GHBEOIOGMKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x8DECA00", Offset = "0x8DEBE00", VA = "0x188DECA00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		protected Transform LPAPDNDLJFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x8DECF70", Offset = "0x8DEC370", VA = "0x188DECF70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x8DECA80", Offset = "0x8DEBE80", VA = "0x188DECA80", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x8DECFF0", Offset = "0x8DEC3F0", VA = "0x188DECFF0", Slot = "5")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void Apply();

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x8DECCF0", Offset = "0x8DEC0F0", VA = "0x188DECCF0")]
		public Color? GetColorFromPalette(JMLAGGJHLCC PFKLOMKJELF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x8DECEA0", Offset = "0x8DEC2A0", VA = "0x188DECEA0")]
		private void LDAGPKAALNA(bool INOBNMHLMMD = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED60", Offset = "0xA6E160", VA = "0x180A6ED60")]
		protected PaletteThemeReference()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public class RangeSliderTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		[SerializeField]
		[BNCHLJBJHLJ(FIPBCJPBODB.Self, false, false, false)]
		private RangeSlider slider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		[SerializeField]
		private NCBJGEOAHFA sliderType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		[SerializeField]
		private Image sliderImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		[SerializeField]
		private Image fillImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		[SerializeField]
		private Image lowHandleImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		[SerializeField]
		private Image highHandleImage;

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public NCBJGEOAHFA KHMKAJHKLML
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0xA6D130", Offset = "0xA6C530", VA = "0x180A6D130")]
			get
			{
				return default(NCBJGEOAHFA);
			}
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x8DEFAD0", Offset = "0x8DEEED0", VA = "0x188DEFAD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public Image MIBGALOBNAA
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0xA70370", Offset = "0xA6F770", VA = "0x180A70370")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public Image LJFPCLCMDDL
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0xA70410", Offset = "0xA6F810", VA = "0x180A70410")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public Image IADHCDFGJMO
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0xA70260", Offset = "0xA6F660", VA = "0x180A70260")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public Image IAKIMOBEOJM
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0xA70420", Offset = "0xA6F820", VA = "0x180A70420")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public bool FKIOLGLOGGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x75F3AB0", Offset = "0x75F2EB0", VA = "0x1875F3AB0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x75F37F0", Offset = "0x75F2BF0", VA = "0x1875F37F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x8DEF780", Offset = "0x8DEEB80", VA = "0x188DEF780", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x8DEFA80", Offset = "0x8DEEE80", VA = "0x188DEFA80")]
		public RangeSliderTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class RawImageTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		[SerializeField]
		[BNCHLJBJHLJ(FIPBCJPBODB.Self, false, false, false)]
		private RawImage image;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		[SerializeField]
		private KFLNBKKPKAL color;

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public KFLNBKKPKAL EMJLCJMKNBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0xA6D130", Offset = "0xA6C530", VA = "0x180A6D130")]
			get
			{
				return default(KFLNBKKPKAL);
			}
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x8DEFAD0", Offset = "0x8DEEED0", VA = "0x188DEFAD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x8DEFAF0", Offset = "0x8DEEEF0", VA = "0x188DEFAF0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x8DEFC20", Offset = "0x8DEF020", VA = "0x188DEFC20")]
		public RawImageTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public class RecyclingGridTheme : RecyclingThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		[SerializeField]
		[BNCHLJBJHLJ(FIPBCJPBODB.Self, false, false, false)]
		private CIGMFNMKLOC recyclingGrid;

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x8DEFC70", Offset = "0x8DEF070", VA = "0x188DEFC70", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x8DEFEE0", Offset = "0x8DEF2E0", VA = "0x188DEFEE0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x8DEFE70", Offset = "0x8DEF270", VA = "0x188DEFE70")]
		private void NLKGOJFGGPO(float EFDNECMHDMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x8DF00D0", Offset = "0x8DEF4D0", VA = "0x188DF00D0")]
		public RecyclingGridTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public class RecyclingListTheme : RecyclingThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		[SerializeField]
		[BNCHLJBJHLJ(FIPBCJPBODB.Self, false, false, false)]
		private CIGMFNMKLOC recyclingList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		private bool HDAMIEJKNMN;

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x8DF0120", Offset = "0x8DEF520", VA = "0x188DF0120", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x8DF03D0", Offset = "0x8DEF7D0", VA = "0x188DF03D0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x8DF0360", Offset = "0x8DEF760", VA = "0x188DF0360")]
		private void LIJKFDIODHO(float EFDNECMHDMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x8DF00D0", Offset = "0x8DEF4D0", VA = "0x188DF00D0")]
		public RecyclingListTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public abstract class RecyclingThemeBase : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		[Header("Audio")]
		[SerializeField]
		private FKJMKKCPNAC recyclingAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		protected RecyclingAudioPaletteAsset BDLLKOMHPEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		[SerializeField]
		private DKCOLEJNOLO scrollingAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		private ScrollingAudioPaletteAsset OAJMJBJBDDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private AKNDJBKAOGM NNKCEJNCBFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private float IBCKHOFCKKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private float CDKJMHACEBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private float FPEFGCKHBLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private float DDNGDLAEGEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private bool BNCOBCLBGJF;

		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private const float NDACICBCGHC = 0.01f;

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		private AKNDJBKAOGM MHNBAAABAJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x8DF07C0", Offset = "0x8DEFBC0", VA = "0x188DF07C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x8DF05D0", Offset = "0x8DEF9D0", VA = "0x188DF05D0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x8DF0D00", Offset = "0x8DF0100", VA = "0x188DF0D00")]
		protected void GEGGAANKMMA(bool OCNOPKDLIGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x8DF0FC0", Offset = "0x8DF03C0", VA = "0x188DF0FC0")]
		protected void IALNOMINPGK(GameObject GBDPBDHPLOA, int JFNJGBMBJJH, bool KAFMGFJHOPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x8DF1340", Offset = "0x8DF0740", VA = "0x188DF1340")]
		protected void NPGHHHKOBPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x8DF0850", Offset = "0x8DEFC50", VA = "0x188DF0850")]
		protected void FGDJHHLCKMD(float EFDNECMHDMA, float GCLEIOCIIHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x8DF1150", Offset = "0x8DF0550", VA = "0x188DF1150")]
		private void IBNLLOKJNKE(float CDPAEIACBIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8DF0BC0", Offset = "0x8DEFFC0", VA = "0x188DF0BC0")]
		private void FHPFAPBIHKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8DF00D0", Offset = "0x8DEF4D0", VA = "0x188DF00D0")]
		protected RecyclingThemeBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public class ScrollBarTheme : SelectableThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		[Header("Scroll Bar Audio")]
		[SerializeField]
		private IFBABLCDPMI buttonAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		[SerializeField]
		[Tooltip("Layer a 2D SFX on top of base button sounds")]
		private bool useFlavorSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		[SerializeField]
		[GKAGFGDDNKD("useFlavorSFX")]
		[Tooltip("Flavor SFX is picked randomly from this pool config")]
		private RecRoomAudioClipPoolConfig flavorSFXClipPoolConfig;

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8DF14D0", Offset = "0x8DF08D0", VA = "0x188DF14D0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8DF15F0", Offset = "0x8DF09F0", VA = "0x188DF15F0")]
		public ScrollBarTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public class ScrollRectTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private const string OOHPJKLIINC = "RRUI.PlayHittingEndsSFX";

		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private const int MEFPIKDFNNI = 5;

		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private const int HOKOPNFALOL = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		private DateTimeOffset PCFGLEODJPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		private int LJODDEDMMIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		private bool APLMFLJKGEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		[SerializeField]
		[BNCHLJBJHLJ(FIPBCJPBODB.Self, false, false, false)]
		private ScrollRect scrollRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		[Header("Audio")]
		[SerializeField]
		private DKCOLEJNOLO scrollAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		private ScrollingAudioPaletteAsset BDLLKOMHPEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private AKNDJBKAOGM NNKCEJNCBFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private APCKAFFCJDF NKJNCHELPGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private float CDKJMHACEBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private float FPEFGCKHBLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private float DDNGDLAEGEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		private bool BNCOBCLBGJF;

		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private const float NDACICBCGHC = 0.01f;

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		private AKNDJBKAOGM MHNBAAABAJA
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x8DF1870", Offset = "0x8DF0C70", VA = "0x188DF1870")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		private APCKAFFCJDF NKBKOKPKBNH
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x8DF2CB0", Offset = "0x8DF20B0", VA = "0x188DF2CB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x8DF16E0", Offset = "0x8DF0AE0", VA = "0x188DF16E0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8DF2D40", Offset = "0x8DF2140", VA = "0x188DF2D40", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8DF1600", Offset = "0x8DF0A00", VA = "0x188DF1600", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x8DF2830", Offset = "0x8DF1C30", VA = "0x188DF2830")]
		private void KALGEDPBJCL(Vector2 LBCFHLNAPLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x8DF2640", Offset = "0x8DF1A40", VA = "0x188DF2640")]
		private void IBNLLOKJNKE(float CDPAEIACBIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x8DF1900", Offset = "0x8DF0D00", VA = "0x188DF1900")]
		private void FHPFAPBIHKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x8DF2520", Offset = "0x8DF1920", VA = "0x188DF2520")]
		private static string FLKAJIAPJNM(GameObject DEJGDIIDCDN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x8DF2E30", Offset = "0x8DF2230", VA = "0x188DF2E30")]
		public ScrollRectTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public abstract class SelectableThemeBase : PaletteThemeReference, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IPointerClickHandler, IPointerEnterHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		[Header("Selectable Theme Base")]
		[SerializeField]
		[BNCHLJBJHLJ(FIPBCJPBODB.Self, false, false, false)]
		[FormerlySerializedAs("button")]
		private Selectable selectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		[Header("Legacy Audio Override")]
		[SerializeField]
		[FormerlySerializedAs("overrideAudio")]
		[Tooltip("Override base selectable audio with a single SFX that plays only on click.")]
		protected bool overrideWithSingleAudio;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		[SerializeField]
		[GKAGFGDDNKD("overrideWithSingleAudio")]
		[Tooltip("The legacy override audio will be randomly picked from this pool")]
		protected RecRoomAudioClip[] randomAudioOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		protected bool NDCCFKBBCCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private ButtonAudioPaletteAsset BDLLKOMHPEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private RecRoomAudioClipPoolConfig FALIDCHHKKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private CKBPAEHADCP GEJFFHOJBBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private CKBPAEHADCP HIEMCJJFOLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private CKBPAEHADCP MKCJANKLPBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private CKBPAEHADCP JDDLHLAALHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		private AKNDJBKAOGM NNKCEJNCBFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		private LNANLCMJBOJ FEHAJHNBKJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		private OBCFCHOGKEJ DBHGFNFKBJP;

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		protected Selectable BAEEACHJBPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		protected virtual bool LBBBDALBADL
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0xA89690", Offset = "0xA88A90", VA = "0x180A89690", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public bool FKIOLGLOGGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x75F3AB0", Offset = "0x75F2EB0", VA = "0x1875F3AB0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x75F37F0", Offset = "0x75F2BF0", VA = "0x1875F37F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		private AKNDJBKAOGM MHNBAAABAJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x8DF2F80", Offset = "0x8DF2380", VA = "0x188DF2F80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		protected LNANLCMJBOJ DKEDELMJAPD
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x8DF35A0", Offset = "0x8DF29A0", VA = "0x188DF35A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		private OBCFCHOGKEJ FCJNEEDMOCI
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x8DF3110", Offset = "0x8DF2510", VA = "0x188DF3110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x8DF3010", Offset = "0x8DF2410", VA = "0x188DF3010")]
		protected void EHPMKECNGMB(ButtonAudioPaletteAsset MLMMEDINKMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xA70430", Offset = "0xA6F830", VA = "0x180A70430")]
		protected void OBOOICEOPGC(RecRoomAudioClipPoolConfig IMFOJCIALHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x8DF3990", Offset = "0x8DF2D90", VA = "0x188DF3990", Slot = "12")]
		public virtual void OnPointerDown(PointerEventData FCGKHKJBFED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x8DF3B40", Offset = "0x8DF2F40", VA = "0x188DF3B40", Slot = "13")]
		public virtual void OnPointerUp(PointerEventData FCGKHKJBFED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x8DF3630", Offset = "0x8DF2A30", VA = "0x188DF3630", Slot = "14")]
		public virtual void OnPointerClick(PointerEventData FCGKHKJBFED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x8DF3A70", Offset = "0x8DF2E70", VA = "0x188DF3A70", Slot = "15")]
		public virtual void OnPointerEnter(PointerEventData FCGKHKJBFED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x8DF2EC0", Offset = "0x8DF22C0", VA = "0x188DF2EC0")]
		private void AAPJBHPJFPB(RecRoomAudioClip[] OBKBGBAHCIM, bool CHNJGDIEODE = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x8DF31B0", Offset = "0x8DF25B0", VA = "0x188DF31B0")]
		private void FLJCDFBEDOK(RecRoomAudioClip HGPHBECCKOO, bool CHNJGDIEODE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8DF3C50", Offset = "0x8DF3050", VA = "0x188DF3C50")]
		public void SetOnPointerDownSoundEffectDisabled(object MONGIMOHLAO, bool CJEKOEINAME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x8DF3CB0", Offset = "0x8DF30B0", VA = "0x188DF3CB0")]
		public void SetOnPointerUpSoundEffectDisabled(object MONGIMOHLAO, bool CJEKOEINAME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x8DF3C20", Offset = "0x8DF3020", VA = "0x188DF3C20")]
		public void SetOnPointerClickSoundEffectDisabled(object MONGIMOHLAO, bool CJEKOEINAME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x8DF3C80", Offset = "0x8DF3080", VA = "0x188DF3C80")]
		public void SetOnPointerEnterSoundEffectDisabled(object MONGIMOHLAO, bool CJEKOEINAME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8DF2F40", Offset = "0x8DF2340", VA = "0x188DF2F40")]
		private void BAMLKJJEHBB(CKBPAEHADCP HMHEELDKLNE, object MONGIMOHLAO, bool CJEKOEINAME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x8DF3CE0", Offset = "0x8DF30E0", VA = "0x188DF3CE0")]
		protected SelectableThemeBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class SliderTheme : SelectableThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		[Header("Slider Visual")]
		[SerializeField]
		[BNCHLJBJHLJ(FIPBCJPBODB.Self, false, false, false)]
		private Slider slider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		[SerializeField]
		private NCBJGEOAHFA sliderType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		[Header("Slider Audio")]
		[SerializeField]
		private IFBABLCDPMI buttonAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		[SerializeField]
		[Tooltip("Layer a 2D SFX on top of base button sounds")]
		private bool useFlavorSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		[SerializeField]
		[GKAGFGDDNKD("useFlavorSFX")]
		[Tooltip("Flavor SFX is picked randomly from this pool config")]
		private RecRoomAudioClipPoolConfig flavorSFXClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		[SerializeField]
		private Image sliderImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		[SerializeField]
		private Image fillImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		[SerializeField]
		private Image handleImage;

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public NCBJGEOAHFA KHMKAJHKLML
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0xA7C990", Offset = "0xA7BD90", VA = "0x180A7C990")]
			get
			{
				return default(NCBJGEOAHFA);
			}
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x8DF42E0", Offset = "0x8DF36E0", VA = "0x188DF42E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public Image MIBGALOBNAA
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0xA76C50", Offset = "0xA76050", VA = "0x180A76C50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public Image LJFPCLCMDDL
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0xB1ED30", Offset = "0xB1E130", VA = "0x180B1ED30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public Image CMMNMNPJDEL
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0xE7BEF0", Offset = "0xE7B2F0", VA = "0x180E7BEF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x8DF3F10", Offset = "0x8DF3310", VA = "0x188DF3F10", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x8DF42C0", Offset = "0x8DF36C0", VA = "0x188DF42C0")]
		public SliderTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public class SurfaceTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		[SerializeField]
		[BNCHLJBJHLJ(FIPBCJPBODB.Self, false, false, false)]
		private Image image;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		[SerializeField]
		[OCPKILIHCKA(FIPBCJPBODB.Self, false, false, false)]
		private UIGradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		[SerializeField]
		private IDODGDMJMIC color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		[SerializeField]
		[GKAGFGDDNKD("gradient")]
		private bool ignoreGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		[SerializeField]
		[Tooltip("The surface theme determines if this Image is a RaycastTarget or not. There are times when you might want to ignore that setting of the palette theme and just respect whatever is the default state on the Image.")]
		private bool ignoreSettingRaycastTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		private IDODGDMJMIC? FNCLCANGEKO;

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public IDODGDMJMIC NMHDHPKCLKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x8DF4610", Offset = "0x8DF3A10", VA = "0x188DF4610")]
			get
			{
				return default(IDODGDMJMIC);
			}
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x8DF4670", Offset = "0x8DF3A70", VA = "0x188DF4670")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x8DF4300", Offset = "0x8DF3700", VA = "0x188DF4300", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x8DF45A0", Offset = "0x8DF39A0", VA = "0x188DF45A0", Slot = "7")]
		public virtual void OverrideBackgroundColorPaletteAtRuntime(IDODGDMJMIC? OEIIIPDIALC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x8DF45C0", Offset = "0x8DF39C0", VA = "0x188DF45C0")]
		public SurfaceTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public class SwitchTheme : ToggleTheme
	{
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private const float IHGDPPJHPIF = 0.33f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		[Header("Switch")]
		[SerializeField]
		private GameObject indicator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		[SerializeField]
		private GameObject indicatorOffPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		[SerializeField]
		private GameObject indicatorOnPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private KJHDAMJDAEL BAFCMCLLLMB;

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x8DF4690", Offset = "0x8DF3A90", VA = "0x188DF4690", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x8DF48F0", Offset = "0x8DF3CF0", VA = "0x188DF48F0")]
		public SwitchTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class TilerTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		[SerializeField]
		[BNCHLJBJHLJ(FIPBCJPBODB.Self, false, false, false)]
		private UITiler tiler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		[SerializeField]
		private GGDKLJKKHIH type;

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x8DF4F00", Offset = "0x8DF4300", VA = "0x188DF4F00", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x8DF5190", Offset = "0x8DF4590", VA = "0x188DF5190")]
		public TilerTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public class ToggleTheme : ButtonThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		[Header("Toggle Visual")]
		[SerializeField]
		private OHIKMFJGKEO toggleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		[SerializeField]
		[Tooltip("A list of objects to show while the toggle is active.")]
		private List<Hideable> hideWhenNotActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		[SerializeField]
		[Tooltip("A list of objects to show while the toggle is inactive")]
		private List<Hideable> hideWhenActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		[SerializeField]
		private bool editorIsActiveOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x161")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		[Header("Toggle Audio")]
		[SerializeField]
		[Tooltip("Override the audio palette when active defined by the toggle's visual with a custom palette")]
		private bool overrideAudioPaletteWhenActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		[SerializeField]
		[GKAGFGDDNKD("overrideAudioPaletteWhenActive")]
		[Tooltip("Specify a custom config to use for toggle button audio when active")]
		private ButtonAudioPaletteAsset customButtonAudioConfigWhenActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		[SerializeField]
		[Tooltip("Override the audio palette when inactive defined by the toggle's visual with a custom palette")]
		private bool overrideAudioPaletteWhenInactive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		[GKAGFGDDNKD("overrideAudioPaletteWhenInactive")]
		[Tooltip("Specify a custom config to use for toggle button audio when inactive")]
		[SerializeField]
		private ButtonAudioPaletteAsset customButtonAudioConfigWhenInactive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		[SerializeField]
		[Tooltip("Layer a 2D SFX on top of base button sounds. Flavor SFX only plays when toggling from inactive to active")]
		private bool useFlavorSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		[SerializeField]
		[GKAGFGDDNKD("useFlavorSFX")]
		[Tooltip("Flavor SFX is picked randomly from this pool config")]
		private RecRoomAudioClipPoolConfig flavorSFXClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		protected bool PHNGOLFFIIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x191")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		private bool GCGIKGLMKCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x192")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		private bool PCGHAIMEGOE;

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public bool IABJMOAGIIK
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x8DF5690", Offset = "0x8DF4A90", VA = "0x188DF5690")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x8DF56A0", Offset = "0x8DF4AA0", VA = "0x188DF56A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public OHIKMFJGKEO IKHEGAJEMCP
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x25B6760", Offset = "0x25B5B60", VA = "0x1825B6760")]
			get
			{
				return default(OHIKMFJGKEO);
			}
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x8DE88C0", Offset = "0x8DE7CC0", VA = "0x188DE88C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		protected override bool LBBBDALBADL
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x8DF5600", Offset = "0x8DF4A00", VA = "0x188DF5600", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x8DF55C0", Offset = "0x8DF49C0", VA = "0x188DF55C0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x8DF5650", Offset = "0x8DF4A50", VA = "0x188DF5650")]
		public void Toggle()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x8DF5610", Offset = "0x8DF4A10", VA = "0x188DF5610")]
		public void Toggle(bool PCGHAIMEGOE, bool PHNGOLFFIIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x8DF51E0", Offset = "0x8DF45E0", VA = "0x188DF51E0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x8DF48F0", Offset = "0x8DF3CF0", VA = "0x188DF48F0")]
		public ToggleTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public class ActiveEventThemeSwapper : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		[SerializeField]
		private string eventActiveGameConfigKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		[SerializeField]
		private bool swapSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		[GKAGFGDDNKD("swapSprite")]
		[SerializeField]
		private Image targetImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		[GKAGFGDDNKD("swapSprite")]
		[SerializeField]
		private Sprite targetSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		[SerializeField]
		private bool swapSurfaceTheme;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		[GKAGFGDDNKD("swapSurfaceTheme")]
		[SerializeField]
		private SurfaceTheme targetSurfaceTheme;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		[GKAGFGDDNKD("swapSurfaceTheme")]
		[SerializeField]
		private IDODGDMJMIC targetPalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		[SerializeField]
		private bool changeGradientDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		[GKAGFGDDNKD("changeGradientDirection")]
		[SerializeField]
		private UIGradient targetGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		[GKAGFGDDNKD("changeGradientDirection")]
		[SerializeField]
		private UIGradient.CGAKAKAJICJ targetGradientType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		private LFMDEIGOMOD NMDOIGIOOFN;

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x8DE6300", Offset = "0x8DE5700", VA = "0x188DE6300")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x8DE6250", Offset = "0x8DE5650", VA = "0x188DE6250")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x8DE6010", Offset = "0x8DE5410", VA = "0x188DE6010")]
		private void JAABFDKPJHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x8DE5EC0", Offset = "0x8DE52C0", VA = "0x188DE5EC0")]
		private void BBJMIAGEOAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x8DE6450", Offset = "0x8DE5850", VA = "0x188DE6450")]
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
