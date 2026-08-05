using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RRUI.Theme;
using RecNet;
using RecRoom;
using RecRoom.Analytics.Statsig;
using RecRoom.AssetBundles;
using RecRoom.Attributes;
using RecRoom.Audio;
using RecRoom.Core;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using RecRoom.NoEngine.DataStructures.Tokens;
using RecRoom.Tweening;
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
	[Obfuscation(ApplyToMembers = false)]
	[Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x9510100", Offset = "0x950ED00", VA = "0x189510100", Slot = "4")]
		public override void Register()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
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
		private sealed class QBWFFRHGRMS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public TMP_FontAsset ZJRMRKZSMWU;

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public QBWFFRHGRMS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x9514230", Offset = "0x9512E30", VA = "0x189514230")]
			internal bool GPCHYODMUID(LocalizedFontMapping a)
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
		[Cpp2IlInjected.Address(RVA = "0x950EF80", Offset = "0x950DB80", VA = "0x18950EF80")]
		public bool IsLocalizedFontAsset(TMP_FontAsset font)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x950EAC0", Offset = "0x950D6C0", VA = "0x18950EAC0")]
		public TMP_FontAsset GetLocalizedFontAsset(TMP_FontAsset font)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x950E880", Offset = "0x950D480", VA = "0x18950E880")]
		public TMP_FontAsset GetLocalizedFontAsset(TMP_FontAsset font, Material overrideMaterial, [Out] Material localizedOverrideMaterial)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x950EC20", Offset = "0x950D820", VA = "0x18950EC20")]
		public TMP_FontAsset GetNonLocalizedFontAsset(TMP_FontAsset font)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x950ED80", Offset = "0x950D980", VA = "0x18950ED80")]
		public TMP_FontAsset GetNonLocalizedFontAsset(TMP_FontAsset font, Material overrideMaterial, [Out] Material nonLocalizedOverrideMaterial)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x950F0A0", Offset = "0x950DCA0", VA = "0x18950F0A0")]
		private static bool LKNEQEFLKOH(TMP_FontAsset a, LocalizedFontMapping b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x950F150", Offset = "0x950DD50", VA = "0x18950F150")]
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
		public Palette AMANALQVWEX
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x95195C0", Offset = "0x95181C0", VA = "0x1895195C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9519560", Offset = "0x9518160", VA = "0x189519560")]
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
		[Cpp2IlInjected.Address(RVA = "0x950F230", Offset = "0x950DE30", VA = "0x18950F230", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x950F1D0", Offset = "0x950DDD0", VA = "0x18950F1D0", Slot = "4")]
		public bool Equals(GradientBlock other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x950F320", Offset = "0x950DF20", VA = "0x18950F320", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class MultiGraphicButton : Button
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[SerializeField]
		private List<Graphic> additionalGraphics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[SerializeField]
		private ColorBlock additionalGraphicsColors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[SerializeField]
		private UIGradient backgroundGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[SerializeField]
		private GradientBlock backgroundGradients;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public List<Graphic> ETBYJZQBOZH
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xC08550", Offset = "0xC07150", VA = "0x180C08550")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xE01930", Offset = "0xE00530", VA = "0x180E01930")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public ColorBlock QKCUUPVKRGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x9511370", Offset = "0x950FF70", VA = "0x189511370")]
			get
			{
				return default(ColorBlock);
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x95113F0", Offset = "0x950FFF0", VA = "0x1895113F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public UIGradient OJJECHSSZKV
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xBB93B0", Offset = "0xBB7FB0", VA = "0x180BB93B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xC88360", Offset = "0xC86F60", VA = "0x180C88360")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public GradientBlock AVWJYVDFXGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x95113C0", Offset = "0x950FFC0", VA = "0x1895113C0")]
			get
			{
				return default(GradientBlock);
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x9511440", Offset = "0x9510040", VA = "0x189511440")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x95110F0", Offset = "0x950FCF0", VA = "0x1895110F0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9511140", Offset = "0x950FD40", VA = "0x189511140")]
		public void Refresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x95110B0", Offset = "0x950FCB0", VA = "0x1895110B0")]
		public void ForceHighlighted(bool instant)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x95110D0", Offset = "0x950FCD0", VA = "0x1895110D0")]
		public void ForceNormal(bool instant)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9510D50", Offset = "0x950F950", VA = "0x189510D50", Slot = "27")]
		protected override void DoStateTransition(SelectionState state, bool instant)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9510C60", Offset = "0x950F860", VA = "0x189510C60")]
		private void DLJQJGEDUZX(Graphic a, Color b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9511170", Offset = "0x950FD70", VA = "0x189511170")]
		private void SCTMAWGZBNO(SelectionState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9511270", Offset = "0x950FE70", VA = "0x189511270")]
		public MultiGraphicButton()
		{
		}
	}
}
namespace RRUI.Theme
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum ButtonAudioPaletteType
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
	public enum ScrollingAudioPaletteType
	{
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		Default
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public enum ContentLoadingAudioPaletteType
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		Default
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public enum RecyclingAudioPaletteType
	{
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		Default
	}
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
			private ButtonAudioPaletteType buttonAudioPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			[SerializeField]
			private ButtonAudioPaletteAsset buttonAudioPaletteConfig;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public ButtonAudioPaletteType ButtonAudioPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000026")]
				[Cpp2IlInjected.Address(RVA = "0xB13110", Offset = "0xB11D10", VA = "0x180B13110")]
				get
				{
					return default(ButtonAudioPaletteType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public ButtonAudioPaletteAsset ButtonAudioPaletteConfig
			{
				[Cpp2IlInjected.Token(Token = "0x6000027")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
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
			private ScrollingAudioPaletteType scrollingAudioPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			[SerializeField]
			private ScrollingAudioPaletteAsset scrollingAudioPaletteConfig;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public ScrollingAudioPaletteType ScrollingAudioPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0xB13110", Offset = "0xB11D10", VA = "0x180B13110")]
				get
				{
					return default(ScrollingAudioPaletteType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public ScrollingAudioPaletteAsset ScrollingAudioPaletteConfig
			{
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
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
			private ContentLoadingAudioPaletteType contentLoadingAudioPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			[SerializeField]
			private ContentLoadingAudioPaletteAsset contentLoadingAudioPaletteConfig;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public ContentLoadingAudioPaletteType ContentLoadingAudioPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0xB13110", Offset = "0xB11D10", VA = "0x180B13110")]
				get
				{
					return default(ContentLoadingAudioPaletteType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public ContentLoadingAudioPaletteAsset ContentLoadingAudioPaletteConfig
			{
				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
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
			private RecyclingAudioPaletteType recyclingAudioPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			[SerializeField]
			private RecyclingAudioPaletteAsset recyclingAudioPaletteConfig;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public RecyclingAudioPaletteType RecyclingAudioPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0xB13110", Offset = "0xB11D10", VA = "0x180B13110")]
				get
				{
					return default(RecyclingAudioPaletteType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public RecyclingAudioPaletteAsset RecyclingAudioPaletteConfig
			{
				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public RecyclingAudioPaletteItem()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class HCFOWLTMZUC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public ContentLoadingAudioPaletteType GYYHCAHRFED;

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public HCFOWLTMZUC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xBF2BA0", Offset = "0xBF17A0", VA = "0x180BF2BA0")]
			internal bool UHSBFEDUYZT(ContentLoadingAudioPaletteItem a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class CITSQHBYTVL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public RecyclingAudioPaletteType BIFHVVYPSGU;

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public CITSQHBYTVL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xBF2BA0", Offset = "0xBF17A0", VA = "0x180BF2BA0")]
			internal bool AKHVZYFYERC(RecyclingAudioPaletteItem a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class TMFRKOCFRTN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public ButtonAudioPaletteType MDKIKLHBYRW;

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public TMFRKOCFRTN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xBF2BA0", Offset = "0xBF17A0", VA = "0x180BF2BA0")]
			internal bool SZIXXOTDMFA(ButtonAudioPaletteItem a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class XYJRREPQRHS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public ScrollingAudioPaletteType UPOJPGFMMLL;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public XYJRREPQRHS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xBF2BA0", Offset = "0xBF17A0", VA = "0x180BF2BA0")]
			internal bool SJCNHWGAEAH(ScrollingAudioPaletteItem a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[SerializeField]
		[ArrayElementName("ButtonAudioPaletteType")]
		private ButtonAudioPaletteItem[] buttonAudioPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[SerializeField]
		[ArrayElementName("ScrollingAudioPaletteType")]
		private ScrollingAudioPaletteItem[] scrollingAudioPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[SerializeField]
		[ArrayElementName("ContentLoadingAudioPaletteType")]
		private ContentLoadingAudioPaletteItem[] contentLoadingAudioPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[SerializeField]
		[ArrayElementName("RecyclingAudioPaletteType")]
		private RecyclingAudioPaletteItem[] recyclingAudioPalettes;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x950B540", Offset = "0x950A140", VA = "0x18950B540")]
		public ButtonAudioPaletteAsset GetButtonAudioPalette(ButtonAudioPaletteType buttonAudioPaletteType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x950B7E0", Offset = "0x950A3E0", VA = "0x18950B7E0")]
		public ScrollingAudioPaletteAsset GetScrollingAudioPaletteConfig(ScrollingAudioPaletteType scrollingAudioPaletteType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x950B620", Offset = "0x950A220", VA = "0x18950B620")]
		public ContentLoadingAudioPaletteAsset GetContentLoadingAudioPaletteConfig(ContentLoadingAudioPaletteType contentLoadingAudioPaletteType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x950B700", Offset = "0x950A300", VA = "0x18950B700")]
		public RecyclingAudioPaletteAsset GetRecyclingAudioPaletteConfig(RecyclingAudioPaletteType recyclingAudioPaletteType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xDB83A0", Offset = "0xDB6FA0", VA = "0x180DB83A0")]
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
		public float XCLFGKOTECH
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xB77D20", Offset = "0xB76920", VA = "0x180B77D20")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public float BJQACMAGZGH
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xB77A50", Offset = "0xB76650", VA = "0x180B77A50")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x950B940", Offset = "0x950A540", VA = "0x18950B940")]
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
		private ButtonAudioPaletteType audioPalette;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Color BackgroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xF21280", Offset = "0xF1FE80", VA = "0x180F21280")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public ColorBlock BackgroundTints
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x950BA60", Offset = "0x950A660", VA = "0x18950BA60")]
			get
			{
				return default(ColorBlock);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public GradientBlock BackgroundGradients
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x1607530", Offset = "0x1606130", VA = "0x181607530")]
			get
			{
				return default(GradientBlock);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Color ForegroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x1371C90", Offset = "0x1370890", VA = "0x181371C90")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public ColorBlock ForegroundTints
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x950BAA0", Offset = "0x950A6A0", VA = "0x18950BAA0")]
			get
			{
				return default(ColorBlock);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool ShowBorder
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xBC8250", Offset = "0xBC6E50", VA = "0x180BC8250")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public TextStylePalette TextPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xBA5E90", Offset = "0xBA4A90", VA = "0x180BA5E90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public ButtonAudioPaletteType AudioPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x2759460", Offset = "0x2758060", VA = "0x182759460")]
			get
			{
				return default(ButtonAudioPaletteType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x950B960", Offset = "0x950A560", VA = "0x18950B960")]
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
			[Cpp2IlInjected.Address(RVA = "0xDF1180", Offset = "0xDEFD80", VA = "0x180DF1180")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
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
			[Cpp2IlInjected.Address(RVA = "0xF21280", Offset = "0xF1FE80", VA = "0x180F21280")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public TextStylePalette TextPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xB13140", Offset = "0xB11D40", VA = "0x180B13140")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x950E1B0", Offset = "0x950CDB0", VA = "0x18950E1B0")]
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
			[Cpp2IlInjected.Address(RVA = "0xF21280", Offset = "0xF1FE80", VA = "0x180F21280")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Color ForegroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0xF343E0", Offset = "0xF32FE0", VA = "0x180F343E0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Color PlaceholderColor
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xFE1360", Offset = "0xFDFF60", VA = "0x180FE1360")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public TextStylePalette TextPalette
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xB13240", Offset = "0xB11E40", VA = "0x180B13240")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x950F830", Offset = "0x950E430", VA = "0x18950F830")]
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
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public MakerPenToolPalette()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class MixedTogglePalette
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		private enum MixedButtonPaletteType
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
		private TogglePaletteType baseTogglePalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[SerializeField]
		private MixedButtonPaletteType mixedPaletteType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[SerializeField]
		[ConditionalField("mixedPaletteType", MixedButtonPaletteType.UseCustom)]
		private ButtonPalette mixedButtonPalette;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9510630", Offset = "0x950F230", VA = "0x189510630")]
		public TogglePalette FPDBTRHATJH(Palette a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x95105C0", Offset = "0x950F1C0", VA = "0x1895105C0")]
		public ButtonPalette DSFRINKBSQB(Palette a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
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
			private RawImageColorPaletteType paletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			[SerializeField]
			private Color color;

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			public RawImageColorPaletteType RawImageColorPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000067")]
				[Cpp2IlInjected.Address(RVA = "0xB13110", Offset = "0xB11D10", VA = "0x180B13110")]
				get
				{
					return default(RawImageColorPaletteType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			public Color Color
			{
				[Cpp2IlInjected.Token(Token = "0x6000068")]
				[Cpp2IlInjected.Address(RVA = "0x1EFC2A0", Offset = "0x1EFAEA0", VA = "0x181EFC2A0")]
				get
				{
					return default(Color);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xB5A330", Offset = "0xB58F30", VA = "0x180B5A330")]
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
			private BackgroundColorPaletteType backgroundColorPaletteType;

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
			public BackgroundColorPaletteType BackgroundColorPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600006A")]
				[Cpp2IlInjected.Address(RVA = "0xB13110", Offset = "0xB11D10", VA = "0x180B13110")]
				get
				{
					return default(BackgroundColorPaletteType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			public Color Color
			{
				[Cpp2IlInjected.Token(Token = "0x600006B")]
				[Cpp2IlInjected.Address(RVA = "0x1EFC2A0", Offset = "0x1EFAEA0", VA = "0x181EFC2A0")]
				get
				{
					return default(Color);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			public Gradient Gradient
			{
				[Cpp2IlInjected.Token(Token = "0x600006C")]
				[Cpp2IlInjected.Address(RVA = "0xB131D0", Offset = "0xB11DD0", VA = "0x180B131D0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			public bool RaycastTarget
			{
				[Cpp2IlInjected.Token(Token = "0x600006D")]
				[Cpp2IlInjected.Address(RVA = "0xC66AC0", Offset = "0xC656C0", VA = "0x180C66AC0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x950B8C0", Offset = "0x950A4C0", VA = "0x18950B8C0")]
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
			private ForegroundColorPaletteType foregroundColorPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			[SerializeField]
			private Color color;

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public ForegroundColorPaletteType ForegroundColorPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600006F")]
				[Cpp2IlInjected.Address(RVA = "0xB13110", Offset = "0xB11D10", VA = "0x180B13110")]
				get
				{
					return default(ForegroundColorPaletteType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			public Color Color
			{
				[Cpp2IlInjected.Token(Token = "0x6000070")]
				[Cpp2IlInjected.Address(RVA = "0x1EFC2A0", Offset = "0x1EFAEA0", VA = "0x181EFC2A0")]
				get
				{
					return default(Color);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x950F1B0", Offset = "0x950DDB0", VA = "0x18950F1B0")]
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
			private TilerPaletteType tilerPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			[SerializeField]
			private TilerPalette tilerPalette;

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			public TilerPaletteType TilerPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000072")]
				[Cpp2IlInjected.Address(RVA = "0xB13110", Offset = "0xB11D10", VA = "0x180B13110")]
				get
				{
					return default(TilerPaletteType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			public TilerPalette TilerPalette
			{
				[Cpp2IlInjected.Token(Token = "0x6000073")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
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
			private TextStylePaletteType textStylePaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			[SerializeField]
			private TextStylePalette textStylePalette;

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			public TextStylePaletteType TextStylePaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000075")]
				[Cpp2IlInjected.Address(RVA = "0xB13110", Offset = "0xB11D10", VA = "0x180B13110")]
				get
				{
					return default(TextStylePaletteType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			public TextStylePalette TextStylePalette
			{
				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
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
			private TextSizePaletteType textSizePaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			[SerializeField]
			private int size;

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			public TextSizePaletteType TextSizePaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0xB13110", Offset = "0xB11D10", VA = "0x180B13110")]
				get
				{
					return default(TextSizePaletteType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			public int Size
			{
				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0xB69740", Offset = "0xB68340", VA = "0x180B69740")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x16D6990", Offset = "0x16D5590", VA = "0x1816D6990")]
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
			private ButtonPaletteType buttonPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			[SerializeField]
			private ButtonPalette buttonPalette;

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			public ButtonPaletteType ButtonPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(RVA = "0xB13110", Offset = "0xB11D10", VA = "0x180B13110")]
				get
				{
					return default(ButtonPaletteType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			public ButtonPalette ButtonPalette
			{
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
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
			private TogglePaletteType togglePaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			[SerializeField]
			private TogglePalette togglePalette;

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public TogglePaletteType TogglePaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600007E")]
				[Cpp2IlInjected.Address(RVA = "0xB13110", Offset = "0xB11D10", VA = "0x180B13110")]
				get
				{
					return default(TogglePaletteType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public TogglePalette TogglePalette
			{
				[Cpp2IlInjected.Token(Token = "0x600007F")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
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
			private MixedTogglePaletteType mixedTogglePaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			[SerializeField]
			private MixedTogglePalette mixedTogglePalette;

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public MixedTogglePaletteType MixedTogglePaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000081")]
				[Cpp2IlInjected.Address(RVA = "0xB13110", Offset = "0xB11D10", VA = "0x180B13110")]
				get
				{
					return default(MixedTogglePaletteType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public MixedTogglePalette MixedTogglePalette
			{
				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
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
			private MakerPenToolPaletteType makerPenToolPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			[SerializeField]
			private MakerPenToolPalette makerPenToolPalette;

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public MakerPenToolPaletteType MakerPenToolPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0xB13110", Offset = "0xB11D10", VA = "0x180B13110")]
				get
				{
					return default(MakerPenToolPaletteType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public MakerPenToolPalette MakerPenToolPalette
			{
				[Cpp2IlInjected.Token(Token = "0x6000085")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
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
			private InputFieldPaletteType inputFieldPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			[SerializeField]
			private InputFieldPalette inputFieldPalette;

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public InputFieldPaletteType InputFieldPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0xB13110", Offset = "0xB11D10", VA = "0x180B13110")]
				get
				{
					return default(InputFieldPaletteType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public InputFieldPalette InputFieldPalette
			{
				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
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
			private DropdownPaletteType dropdownPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			[SerializeField]
			private DropdownPalette dropdownPalette;

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public DropdownPaletteType DropdownPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600008A")]
				[Cpp2IlInjected.Address(RVA = "0xB13110", Offset = "0xB11D10", VA = "0x180B13110")]
				get
				{
					return default(DropdownPaletteType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public DropdownPalette DropdownPalette
			{
				[Cpp2IlInjected.Token(Token = "0x600008B")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
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
			private SliderPaletteType sliderPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			[SerializeField]
			private SliderPalette sliderPalette;

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public SliderPaletteType SliderPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0xB13110", Offset = "0xB11D10", VA = "0x180B13110")]
				get
				{
					return default(SliderPaletteType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public SliderPalette SliderPalette
			{
				[Cpp2IlInjected.Token(Token = "0x600008E")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
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
			private DepthPaletteType depthPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			[SerializeField]
			private DepthPalette depthPalette;

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			public DepthPaletteType DepthPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000090")]
				[Cpp2IlInjected.Address(RVA = "0xB13110", Offset = "0xB11D10", VA = "0x180B13110")]
				get
				{
					return default(DepthPaletteType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public DepthPalette DepthPalette
			{
				[Cpp2IlInjected.Token(Token = "0x6000091")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public DepthPaletteItem()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private sealed class CITSQHBYTVL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public TilerPaletteType XWCGKVRHPNH;

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public CITSQHBYTVL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xBF2BA0", Offset = "0xBF17A0", VA = "0x180BF2BA0")]
			internal bool QNBZLYWGKGS(TilerPaletteItem a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class XLYSDAWRGEK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public TextStylePaletteType LOPNSHDDIOW;

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public XLYSDAWRGEK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xBF2BA0", Offset = "0xBF17A0", VA = "0x180BF2BA0")]
			internal bool JPLUCISGUTS(TextStylePaletteItem a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class LOJPDCGXZIH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public TextSizePaletteType IAHSYZBWWDQ;

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public LOJPDCGXZIH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xBF2BA0", Offset = "0xBF17A0", VA = "0x180BF2BA0")]
			internal bool SHQATDUNVPR(TextSizePaletteItem a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[CompilerGenerated]
		private sealed class TCPIQNKCSSB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public ButtonPaletteType JHFSJKCHWIE;

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public TCPIQNKCSSB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0xBF2BA0", Offset = "0xBF17A0", VA = "0x180BF2BA0")]
			internal bool POAVRLKCCYO(ButtonPaletteItem a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		[CompilerGenerated]
		private sealed class OJDMKISOMTK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public TogglePaletteType KOBFZJCLCCE;

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public OJDMKISOMTK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xBF2BA0", Offset = "0xBF17A0", VA = "0x180BF2BA0")]
			internal bool GBTBVLWUPJE(TogglePaletteItem a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class TFYMXOXWAKL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public MixedTogglePaletteType PCMVILZJELV;

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public TFYMXOXWAKL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xBF2BA0", Offset = "0xBF17A0", VA = "0x180BF2BA0")]
			internal bool XZOVUFWRGQX(MixedTogglePaletteItem a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class WFWDIIKMSFQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public MakerPenToolPaletteType NUAXXIUXYRZ;

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public WFWDIIKMSFQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xBF2BA0", Offset = "0xBF17A0", VA = "0x180BF2BA0")]
			internal bool WGWUOLIPFVZ(MakerPenToolPaletteItem a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000035")]
		[CompilerGenerated]
		private sealed class LIKIZMPSLOB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public RawImageColorPaletteType TQLIHEWPVKX;

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public LIKIZMPSLOB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0xBF2BA0", Offset = "0xBF17A0", VA = "0x180BF2BA0")]
			internal bool SJEDUPYJKCV(RawImageColorPaletteItem a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000036")]
		[CompilerGenerated]
		private sealed class UOSTIWCRFXU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public InputFieldPaletteType GXPYPJCBIFO;

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public UOSTIWCRFXU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0xBF2BA0", Offset = "0xBF17A0", VA = "0x180BF2BA0")]
			internal bool BRRIWCTQOSO(InputFieldPaletteItem a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[CompilerGenerated]
		private sealed class HPUDPQOSLZV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public DropdownPaletteType ZLZNHYYDEAX;

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public HPUDPQOSLZV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xBF2BA0", Offset = "0xBF17A0", VA = "0x180BF2BA0")]
			internal bool ATLKBRUWINJ(DropdownPaletteItem a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		[CompilerGenerated]
		private sealed class EQBRRJLPZVW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public SliderPaletteType XBGKOHAMZMH;

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public EQBRRJLPZVW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xBF2BA0", Offset = "0xBF17A0", VA = "0x180BF2BA0")]
			internal bool TYJCSNOHTAL(SliderPaletteItem a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000039")]
		[CompilerGenerated]
		private sealed class JPGOKMFXYHM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public DepthPaletteType VQTJUMNKVZP;

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public JPGOKMFXYHM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xBF2BA0", Offset = "0xBF17A0", VA = "0x180BF2BA0")]
			internal bool FMZKPGQQJMU(DepthPaletteItem a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		[CompilerGenerated]
		private sealed class PYHWMDJZEDC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public BackgroundColorPaletteType TQLIHEWPVKX;

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public PYHWMDJZEDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xBF2BA0", Offset = "0xBF17A0", VA = "0x180BF2BA0")]
			internal bool JBLZIMPZLTY(BackgroundColorPaletteItem a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		[CompilerGenerated]
		private sealed class TMFRKOCFRTN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public ForegroundColorPaletteType XXFTLCHSQPY;

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public TMFRKOCFRTN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xBF2BA0", Offset = "0xBF17A0", VA = "0x180BF2BA0")]
			internal bool PDWJNRRUDWT(ForegroundColorPaletteItem a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[Header("Visual")]
		[SerializeField]
		[ArrayElementName("RawImageColorPaletteType")]
		private RawImageColorPaletteItem[] rawImageColorPaletteItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[SerializeField]
		[ArrayElementName("BackgroundColorPaletteType")]
		private BackgroundColorPaletteItem[] backgroundColorPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[SerializeField]
		[ArrayElementName("ForegroundColorPaletteType")]
		private ForegroundColorPaletteItem[] foregroundColorPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[SerializeField]
		[ArrayElementName("TilerPaletteType")]
		private TilerPaletteItem[] tilerPaletteItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[SerializeField]
		[ArrayElementName("TextStylePaletteType")]
		private TextStylePaletteItem[] textStylePalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[SerializeField]
		[ArrayElementName("TextSizePaletteType")]
		private TextSizePaletteItem[] textSizePalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[SerializeField]
		[ArrayElementName("ButtonPaletteType")]
		private ButtonPaletteItem[] buttonPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[SerializeField]
		[ArrayElementName("TogglePaletteType")]
		private TogglePaletteItem[] togglePalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[SerializeField]
		[ArrayElementName("MixedTogglePaletteType")]
		private MixedTogglePaletteItem[] mixedTogglePalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[SerializeField]
		[ArrayElementName("MakerPenToolPaletteType")]
		private MakerPenToolPaletteItem[] makerPenToolPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[SerializeField]
		[ArrayElementName("InputFieldPaletteType")]
		private InputFieldPaletteItem[] inputFieldPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[SerializeField]
		[ArrayElementName("DropdownPaletteType")]
		private DropdownPaletteItem[] dropdownPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[SerializeField]
		[ArrayElementName("SliderPaletteType")]
		private SliderPaletteItem[] sliderPalettes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[SerializeField]
		[ArrayElementName("DepthPaletteType")]
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
		public IEnumerable<DepthPaletteItem> UMLAXNQQHHQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xB1D6B0", Offset = "0xB1C2B0", VA = "0x180B1D6B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public ButtonAnimationPalette LEROTGZRKJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xB1D750", Offset = "0xB1C350", VA = "0x180B1D750")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public AudioPalette JNNKEPZSODO
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xB44440", Offset = "0xB43040", VA = "0x180B44440")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9513CE0", Offset = "0x95128E0", VA = "0x189513CE0")]
		public Color GetRawImageColor(RawImageColorPaletteType backgroundColorPaletteType)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x9513500", Offset = "0x9512100", VA = "0x189513500")]
		public void GetBackgroundPaletteData(BackgroundColorPaletteType backgroundColorPaletteType, [Out] Color color, [Out] Gradient gradient, [Out] bool raycastTarget)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x9513950", Offset = "0x9512550", VA = "0x189513950")]
		public Color GetForegroundColor(ForegroundColorPaletteType foregroundColorPaletteType)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x9514070", Offset = "0x9512C70", VA = "0x189514070")]
		public TilerPalette GetTilerPalette(TilerPaletteType type)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x9513F90", Offset = "0x9512B90", VA = "0x189513F90")]
		public TextStylePalette GetTextStylePalette(TextStylePaletteType textStylePaletteType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x9513EB0", Offset = "0x9512AB0", VA = "0x189513EB0")]
		public int GetTextSize(TextSizePaletteType textSizePaletteType)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x9513670", Offset = "0x9512270", VA = "0x189513670")]
		public ButtonPalette GetButtonPalette(ButtonPaletteType buttonPaletteType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x9514150", Offset = "0x9512D50", VA = "0x189514150")]
		public TogglePalette GetTogglePalette(TogglePaletteType togglePaletteType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x9513C00", Offset = "0x9512800", VA = "0x189513C00")]
		public MixedTogglePalette GetMixedTogglePalette(MixedTogglePaletteType mixedTogglePaletteType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9513B20", Offset = "0x9512720", VA = "0x189513B20")]
		public MakerPenToolPalette GetMakerPenToolPalette(MakerPenToolPaletteType makerPenToolPaletteType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9513A40", Offset = "0x9512640", VA = "0x189513A40")]
		public InputFieldPalette GetInputFieldPalette(InputFieldPaletteType inputFieldPaletteType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x9513870", Offset = "0x9512470", VA = "0x189513870")]
		public DropdownPalette GetDropdownPalette(DropdownPaletteType dropdownPaletteType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9513DD0", Offset = "0x95129D0", VA = "0x189513DD0")]
		public SliderPalette GetSliderPalette(SliderPaletteType sliderPaletteType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x9513750", Offset = "0x9512350", VA = "0x189513750")]
		public float? GetDepth(DepthPaletteType depthPaletteType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xDB83A0", Offset = "0xDB6FA0", VA = "0x180DB83A0")]
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
			[Cpp2IlInjected.Address(RVA = "0xF21280", Offset = "0xF1FE80", VA = "0x180F21280")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public Color FillColor
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xF343E0", Offset = "0xF32FE0", VA = "0x180F343E0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public Color HandleColor
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xFE1360", Offset = "0xFDFF60", VA = "0x180FE1360")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public ColorBlock ColorBlock
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x9518620", Offset = "0x9517220", VA = "0x189518620")]
			get
			{
				return default(ColorBlock);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x9518560", Offset = "0x9517160", VA = "0x189518560")]
		public SliderPalette()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public class TextStylePalette
	{
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		public enum Transformations
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
		private Transformations transformation;

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x9519060", Offset = "0x9517C60", VA = "0x189519060")]
		public void Apply(TextMeshProUGUI textMeshProUGUI, bool isInputTextField = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
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
		private UITiler.AnimationType animationDirection;

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
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public Color TintColor
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xDF45B0", Offset = "0xDF31B0", VA = "0x180DF45B0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public Color BackgroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x1511E90", Offset = "0x1510A90", VA = "0x181511E90")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public float Rows
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xDC9D30", Offset = "0xDC8930", VA = "0x180DC9D30")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public Vector2 Spacing
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x9519640", Offset = "0x9518240", VA = "0x189519640")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public float Offset
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0xB64FF0", Offset = "0xB63BF0", VA = "0x180B64FF0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public Vector2 Velocity
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x946C690", Offset = "0x946B290", VA = "0x18946C690")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public float Angle
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x1371CE0", Offset = "0x13708E0", VA = "0x181371CE0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public UITiler.AnimationType AnimationDirection
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x139CC70", Offset = "0x139B870", VA = "0x18139CC70")]
			get
			{
				return default(UITiler.AnimationType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public float PrimaryAnimationSpeed
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x1371CD0", Offset = "0x13708D0", VA = "0x181371CD0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public float AltAnimationSpeed
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x1371D10", Offset = "0x1370910", VA = "0x181371D10")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x95195F0", Offset = "0x95181F0", VA = "0x1895195F0")]
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
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public ButtonPalette ActiveButtonPalette
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public TogglePalette()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public enum BackgroundColorPaletteType
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
	public enum RawImageColorPaletteType
	{
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		A
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public enum ForegroundColorPaletteType
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
	public enum TilerPaletteType
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
	public enum TextStylePaletteType
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
	public enum TextSizePaletteType
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
	public enum ButtonPaletteType
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
	public enum TogglePaletteType
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
	public enum MixedTogglePaletteType
	{
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		Checkbox
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public enum MakerPenToolPaletteType
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
	public enum InputFieldPaletteType
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
	public enum DropdownPaletteType
	{
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		LightFlat,
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		DarkFlat
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public enum SliderPaletteType
	{
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		MirroUIPopUp
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public enum DepthPaletteType
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
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public class ApproximationMaskDepthTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		[SerializeField]
		private RectTransform content;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private Vector3? ICQMSLYGVER;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private Vector3? RWIFMHIYMMU;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x950B410", Offset = "0x950A010", VA = "0x18950B410")]
		private void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x950B050", Offset = "0x9509C50", VA = "0x18950B050", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x950B4F0", Offset = "0x950A0F0", VA = "0x18950B4F0")]
		public ApproximationMaskDepthTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public class ButtonTheme : ButtonThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		[Header("Button Visual")]
		[SerializeField]
		private ButtonPaletteType buttonType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x154")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		[Header("Button Audio")]
		[SerializeField]
		[Tooltip("Override the audio palette defined by the button's visual with a custom palette")]
		private bool overrideButtonAudioPalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		[SerializeField]
		[ConditionalField("overrideButtonAudioPalette")]
		[Tooltip("Specify a custom config to use for button audio")]
		private ButtonAudioPaletteAsset customButtonAudioConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		[SerializeField]
		[Tooltip("Layer a 2D SFX on top of base button sounds")]
		private bool useFlavorSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		[SerializeField]
		[ConditionalField("useFlavorSFX")]
		[Tooltip("Flavor SFX is picked randomly from this pool config")]
		private RecRoomAudioClipPoolConfig flavorSFXClipPoolConfig;

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public ButtonPaletteType EJQUDKGRJXK
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x1131C80", Offset = "0x1130880", VA = "0x181131C80")]
			get
			{
				return default(ButtonPaletteType);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x950D420", Offset = "0x950C020", VA = "0x18950D420")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x950D1C0", Offset = "0x950BDC0", VA = "0x18950D1C0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x28D9630", Offset = "0x28D8230", VA = "0x1828D9630")]
		public void SetAnimationEnabled(bool enabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x950D410", Offset = "0x950C010", VA = "0x18950D410")]
		public ButtonTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public abstract class ButtonThemeBase : SelectableThemeBase
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		protected class HJILEGLGSYE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000174")]
			public ButtonAudioPaletteAsset JXCRFAVVFAD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000175")]
			public RecRoomAudioClipPoolConfig THWKTTTUIFM;

			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public HJILEGLGSYE()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		[Header("Button Theme Base")]
		[SerializeField]
		[AutofillOptional(AutofillType.Self, false, false, false)]
		private MultiGraphicButton multiGraphicButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		[SerializeField]
		[AutofillOptional(AutofillType.Self, false, true, false)]
		private Image surface;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		[SerializeField]
		private bool useSurfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		[SerializeField]
		[ConditionalField("useSurfaceOverride")]
		private Image surfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		[SerializeField]
		private bool controlSurfaceColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		[SerializeField]
		[ReadOnlyField]
		private List<Graphic> graphics;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		[SerializeField]
		private bool useGraphicsOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		[SerializeField]
		[ConditionalField("useGraphicsOverride")]
		private List<Graphic> graphicsOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		[SerializeField]
		[ConditionalFieldExcept("useGraphicsOverride", new object[] { })]
		private bool graphicsIgnoreTextFields;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD1")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		[SerializeField]
		private bool controlGraphicColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		[SerializeField]
		[AutofillOptional(AutofillType.Self, false, true, false)]
		private UIGradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		[SerializeField]
		private bool useGradientOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		[SerializeField]
		[ConditionalField("useGradientOverride")]
		private UIGradient gradientOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		[SerializeField]
		[AutofillOptional(AutofillType.Children, true, true, false)]
		private TextMeshProUGUI textMeshProUGUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		[SerializeField]
		private bool useTextMeshProUGUIOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		[SerializeField]
		[ConditionalField("useTextMeshProUGUIOverride")]
		private TextMeshProUGUI textMeshProUGUIOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		[SerializeField]
		private TextSizePaletteType textSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		[SerializeField]
		protected Hideable borderHideable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		[SerializeField]
		protected bool isAnimationEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x119")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		[SerializeField]
		[ConditionalField("isAnimationEnabled")]
		protected bool overrideAnimationTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		[SerializeField]
		[ConditionalField("overrideAnimationTarget")]
		protected GameObject animationTargetOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private bool ANMWLIZVANI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private Vector3 WIQJNKILQWW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private Vector3 SFVKQYRNMJY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private PSWYBKIWRHU YRUWYIEBQIQ;

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public Image TNJKPXRAMAM
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x950D160", Offset = "0x950BD60", VA = "0x18950D160")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public List<Graphic> ULXJFWNNUYA
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x950D140", Offset = "0x950BD40", VA = "0x18950D140")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public UIGradient LOEALNGZAWR
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x950D120", Offset = "0x950BD20", VA = "0x18950D120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public TextMeshProUGUI MAGJLAAWHJO
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x950D180", Offset = "0x950BD80", VA = "0x18950D180")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public TextSizePaletteType XHUZGGWCYDI
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x198D3D0", Offset = "0x198BFD0", VA = "0x18198D3D0")]
			get
			{
				return default(TextSizePaletteType);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x950D1A0", Offset = "0x950BDA0", VA = "0x18950D1A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		protected Transform YQCPVVAYZGQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x950CF60", Offset = "0x950BB60", VA = "0x18950CF60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public Button IASTKVIYDND
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x950D090", Offset = "0x950BC90", VA = "0x18950D090")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x950C810", Offset = "0x950B410", VA = "0x18950C810")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x950C770", Offset = "0x950B370", VA = "0x18950C770")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x950C5B0", Offset = "0x950B1B0", VA = "0x18950C5B0")]
		protected void NIZJGPKQBEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x950BB10", Offset = "0x950A710", VA = "0x18950BB10")]
		protected void HKZAIFLYZYO(ButtonPalette a, [Optional] HJILEGLGSYE b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x950C8B0", Offset = "0x950B4B0", VA = "0x18950C8B0", Slot = "12")]
		public override void OnPointerDown(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x950CC60", Offset = "0x950B860", VA = "0x18950CC60", Slot = "13")]
		public override void OnPointerUp(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x950C890", Offset = "0x950B490", VA = "0x18950C890", Slot = "14")]
		public override void OnPointerClick(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x950BAF0", Offset = "0x950A6F0", VA = "0x18950BAF0")]
		private Vector3 CGHMFFAUGYH(float a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x950CFB0", Offset = "0x950BBB0", VA = "0x18950CFB0")]
		protected ButtonThemeBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x1A2F900", Offset = "0x1A2E500", VA = "0x181A2F900")]
		[CompilerGenerated]
		private void GWHWNAFPLIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x1A2F900", Offset = "0x1A2E500", VA = "0x181A2F900")]
		[CompilerGenerated]
		private void YCLWMEQDQBX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public class DepthTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		[SerializeField]
		private DepthPaletteType depth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		[SerializeField]
		private bool animateOnEnable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		[SerializeField]
		[ConditionalField("animateOnEnable")]
		private float animationTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private Vector3? ICQMSLYGVER;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private Vector2 CTTBFEQRVNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private Vector2 XOBTCUJGMLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private Vector2 ZOGMLBAQZAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private Vector2 YTDGUVIBRXM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private Vector2 WUOQQQTWCVC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private Vector2 QAKVBVQBJUG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private readonly bool? DMFYLFCTIQC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private HHOQZBKHOKE ZFTRRERJWOM;

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		private RectTransform OAYETOLHLRL
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x950D9B0", Offset = "0x950C5B0", VA = "0x18950D9B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public DepthPaletteType HJXGKLKDWZL
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0xB1FB30", Offset = "0xB1E730", VA = "0x180B1FB30")]
			get
			{
				return default(DepthPaletteType);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x950E190", Offset = "0x950CD90", VA = "0x18950E190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		private HHOQZBKHOKE HJUCPFXLABX
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x950DE20", Offset = "0x950CA20", VA = "0x18950DE20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		private bool VQTKKSBLOMK
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x950DD30", Offset = "0x950C930", VA = "0x18950DD30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x950DF60", Offset = "0x950CB60", VA = "0x18950DF60")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x950DEB0", Offset = "0x950CAB0", VA = "0x18950DEB0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x950D440", Offset = "0x950C040", VA = "0x18950D440", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x950DA10", Offset = "0x950C610", VA = "0x18950DA10")]
		private void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x950D630", Offset = "0x950C230", VA = "0x18950D630")]
		private Vector3 FKQGXWBDHJY()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x950DFD0", Offset = "0x950CBD0", VA = "0x18950DFD0")]
		public DepthTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public class DropdownTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private Dropdown dropdown;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		[SerializeField]
		[AutofillOptional(AutofillType.Self, false, true, false)]
		private Image surface;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		[SerializeField]
		private bool useSurfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		[SerializeField]
		[ConditionalField("useSurfaceOverride")]
		private Image surfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		[SerializeField]
		private DropdownPaletteType dropdownType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		[SerializeField]
		private TextSizePaletteType textSize;

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public Image TNJKPXRAMAM
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x950E830", Offset = "0x950D430", VA = "0x18950E830")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public DropdownPaletteType XHYYOMHYRJJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0xBB3D40", Offset = "0xBB2940", VA = "0x180BB3D40")]
			get
			{
				return default(DropdownPaletteType);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x950E840", Offset = "0x950D440", VA = "0x18950E840")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public TextSizePaletteType XHUZGGWCYDI
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x15B9430", Offset = "0x15B8030", VA = "0x1815B9430")]
			get
			{
				return default(TextSizePaletteType);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x950E860", Offset = "0x950D460", VA = "0x18950E860")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x950E1D0", Offset = "0x950CDD0", VA = "0x18950E1D0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x950E7E0", Offset = "0x950D3E0", VA = "0x18950E7E0")]
		public DropdownTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public class GraphicTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private Graphic graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		[SerializeField]
		private bool useGraphicOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		[SerializeField]
		[ConditionalField("useGraphicOverride")]
		private Graphic graphicOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		[SerializeField]
		private ForegroundColorPaletteType color;

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public Graphic BWYFZUKRHYH
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x950F800", Offset = "0x950E400", VA = "0x18950F800")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public ForegroundColorPaletteType PZPRLKEVPJQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0xB31CA0", Offset = "0xB308A0", VA = "0x180B31CA0")]
			get
			{
				return default(ForegroundColorPaletteType);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x950F810", Offset = "0x950E410", VA = "0x18950F810")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public bool NSJLWUVOKRQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0xE1C0E0", Offset = "0xE1ACE0", VA = "0x180E1C0E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0xE1C140", Offset = "0xE1AD40", VA = "0x180E1C140")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public Color? KCOQPXASVAW
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x950F5E0", Offset = "0x950E1E0", VA = "0x18950F5E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x950F390", Offset = "0x950DF90", VA = "0x18950F390", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x950F590", Offset = "0x950E190", VA = "0x18950F590")]
		public GraphicTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public class InputFieldTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private TMP_InputField inputField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		[SerializeField]
		[AutofillOptional(AutofillType.Self, false, false, false)]
		private Image surface;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		[SerializeField]
		private bool useSurfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		[SerializeField]
		[ConditionalField("useSurfaceOverride")]
		private Image surfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		[SerializeField]
		private InputFieldPaletteType inputFieldType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		[SerializeField]
		private TextSizePaletteType textSize;

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public Image TNJKPXRAMAM
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x950E830", Offset = "0x950D430", VA = "0x18950E830")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public InputFieldPaletteType WXWRLXFJAVW
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0xBB3D40", Offset = "0xBB2940", VA = "0x180BB3D40")]
			get
			{
				return default(InputFieldPaletteType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x950E840", Offset = "0x950D440", VA = "0x18950E840")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public TextSizePaletteType XHUZGGWCYDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x15B9430", Offset = "0x15B8030", VA = "0x1815B9430")]
			get
			{
				return default(TextSizePaletteType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x950E860", Offset = "0x950D460", VA = "0x18950E860")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x950F860", Offset = "0x950E460", VA = "0x18950F860", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x950FD30", Offset = "0x950E930", VA = "0x18950FD30")]
		public InputFieldTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public class LabelTheme : GraphicTheme
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private TextMeshProUGUI textMeshProUGUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		[SerializeField]
		private TextStylePaletteType textType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		[SerializeField]
		private TextSizePaletteType textSize;

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public TextStylePaletteType BAQOWVLBNWB
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0xF31B10", Offset = "0xF30710", VA = "0x180F31B10")]
			get
			{
				return default(TextStylePaletteType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x95100E0", Offset = "0x950ECE0", VA = "0x1895100E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public TextSizePaletteType XHUZGGWCYDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x139CC70", Offset = "0x139B870", VA = "0x18139CC70")]
			get
			{
				return default(TextSizePaletteType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x95100C0", Offset = "0x950ECC0", VA = "0x1895100C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x950FD80", Offset = "0x950E980", VA = "0x18950FD80", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x9510070", Offset = "0x950EC70", VA = "0x189510070")]
		public LabelTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public class MakerPenToolTheme : ButtonThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		[Header("Maker Pen Tool")]
		[SerializeField]
		private MakerPenToolPaletteType makerPenToolPaletteType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		[SerializeField]
		[Tooltip("A list of objects to show while the maker pen tool is active.")]
		private List<Hideable> hideWhenNotActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		[SerializeField]
		[Tooltip("A list of objects to show while the maker pen tool is inactive")]
		private List<Hideable> hideWhenActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		[SerializeField]
		private bool editorIsActiveOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x169")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		protected bool UHFMBXRTKQC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x16A")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private bool OQTWSGHCMLB;

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public MakerPenToolPaletteType BJDPXMEBKDN
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x1131C80", Offset = "0x1130880", VA = "0x181131C80")]
			get
			{
				return default(MakerPenToolPaletteType);
			}
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x950D420", Offset = "0x950C020", VA = "0x18950D420")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public bool SGZBYYBIKJN
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x94DBFD0", Offset = "0x94DABD0", VA = "0x1894DBFD0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x95105A0", Offset = "0x950F1A0", VA = "0x1895105A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x9510560", Offset = "0x950F160", VA = "0x189510560", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x9510180", Offset = "0x950ED80", VA = "0x189510180", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x950D410", Offset = "0x950C010", VA = "0x18950D410")]
		public MakerPenToolTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public class MixedToggleTheme : ButtonThemeBase
	{
		[Cpp2IlInjected.Token(Token = "0x200005B")]
		public enum ToggleState
		{
			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			Inactive,
			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			Mixed,
			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			Active
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		[SerializeField]
		private MixedTogglePaletteType toggleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		[SerializeField]
		[Tooltip("A list of objects to hide while the toggle is inactive.")]
		private List<Hideable> hideWhenInactive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		[SerializeField]
		[Tooltip("A list of objects to hide while the toggle is mixed.")]
		private List<Hideable> hideWhenMixed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		[SerializeField]
		[Tooltip("A list of objects to hide while the toggle is active")]
		private List<Hideable> hideWhenActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		[SerializeField]
		private ToggleState editorIsActiveOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x174")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private ToggleState OQTWSGHCMLB;

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public ToggleState SGZBYYBIKJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0xC98AA0", Offset = "0xC976A0", VA = "0x180C98AA0")]
			get
			{
				return default(ToggleState);
			}
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x9510C40", Offset = "0x950F840", VA = "0x189510C40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x9510C10", Offset = "0x950F810", VA = "0x189510C10")]
		public void Toggle()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x9510C40", Offset = "0x950F840", VA = "0x189510C40")]
		public void Toggle(ToggleState isActive, bool isInstant)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x9510660", Offset = "0x950F260", VA = "0x189510660", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x950D410", Offset = "0x950C010", VA = "0x18950D410")]
		public MixedToggleTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class PaletteTheme : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		[SerializeField]
		private bool usePaletteOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		[SerializeField]
		[ConditionalField("usePaletteOverride")]
		private Palette paletteOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public AQWXMNIFQIV PaletteChangeEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		[SerializeField]
		private bool useDepth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private NADKVDSFRLV ODWNDRWWAAI;

		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private const string TMMGWTKWTBT = "watch_layer";

		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private const string JSAPWMWGXDL = "depth_multiplier";

		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private const float VCKBDWMOUVZ = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private float? GLOGDGPLSQN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private float? MNXFLTYKWWL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private float? QSTNYXRZGMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private float SGWNMKZVITQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private float AUPDDFJHVWF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private float KWOZGFMGTTE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private float SKTZTUNLABT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private readonly SVJYJIPYDON GFWXIUVCJIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private SFXAudioSource LQNHWVBDPNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private SFXAudioSource LGHJDXUKUPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private ContentLoadingAudioPaletteAsset JPMBHGGBTMP;

		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private const float KPMNPALTBBE = 0.001f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private ZODQAHISQFL NJSMZZDXDQU;

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public Palette MVHQNJOCVPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x9513420", Offset = "0x9512020", VA = "0x189513420")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public bool TLOXWKSWPMV
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0xB41D60", Offset = "0xB40960", VA = "0x180B41D60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public float VQRJQTOCVQZ
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x95131A0", Offset = "0x9511DA0", VA = "0x1895131A0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		private bool EETQPQGGSIU
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x9512C70", Offset = "0x9511870", VA = "0x189512C70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		private bool VLGRFNXFWBP
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x9512530", Offset = "0x9511130", VA = "0x189512530")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x9511DF0", Offset = "0x95109F0", VA = "0x189511DF0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x9512E10", Offset = "0x9511A10", VA = "0x189512E10")]
		private void VMHGHCEONZN(EZSRMSLADIK.ThemeOptions a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x95127A0", Offset = "0x95113A0", VA = "0x1895127A0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x95122D0", Offset = "0x9510ED0", VA = "0x1895122D0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x9512110", Offset = "0x9510D10", VA = "0x189512110")]
		private void CVZEWHTYNNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x9511CD0", Offset = "0x95108D0", VA = "0x189511CD0")]
		public void AddLoadingSFXRequest(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x9512CF0", Offset = "0x95118F0", VA = "0x189512CF0")]
		public void RemoveLoadingSFXRequest(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x95122D0", Offset = "0x9510ED0", VA = "0x1895122D0")]
		private void CZBBTNVDEPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x95125B0", Offset = "0x95111B0", VA = "0x1895125B0")]
		private void NCSVKNXBKXJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x9511FA0", Offset = "0x9510BA0", VA = "0x189511FA0")]
		private void CCBLPHKEWHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x9512B80", Offset = "0x9511780", VA = "0x189512B80")]
		private void RAQVEBOORLZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x9512E40", Offset = "0x9511A40", VA = "0x189512E40")]
		private void WTNKZWFQLKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x9512440", Offset = "0x9511040", VA = "0x189512440")]
		private void EPWKBBFQVCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x9511F90", Offset = "0x9510B90", VA = "0x189511F90")]
		private void BATCLMFMORA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x9512A90", Offset = "0x9511690", VA = "0x189512A90")]
		private void QDWJJDNNTBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x95130B0", Offset = "0x9511CB0", VA = "0x1895130B0")]
		private void YLPPSOHJOCQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x95128C0", Offset = "0x95114C0", VA = "0x1895128C0")]
		public void Play2DUIFlavorSFX(RecRoomAudioClip[] flavorSFXPool)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x95130F0", Offset = "0x9511CF0", VA = "0x1895130F0")]
		public PaletteTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public abstract class PaletteThemeReference : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		protected static readonly Log DNBXSEXRPWR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		[SerializeField]
		[AutofillOptional(AutofillType.SelfAndParent, true, false, false)]
		private PaletteTheme paletteTheme;

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		protected PaletteTheme QHUQAHAIVZX
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		protected Palette MVHQNJOCVPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x9511B80", Offset = "0x9510780", VA = "0x189511B80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		protected bool QVFBFEXBDFW
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x9511B00", Offset = "0x9510700", VA = "0x189511B00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		protected Transform HNFSMRFQCOZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x95119A0", Offset = "0x95105A0", VA = "0x1895119A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x95114A0", Offset = "0x95100A0", VA = "0x1895114A0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x9511A20", Offset = "0x9510620", VA = "0x189511A20", Slot = "5")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void Apply();

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x95115A0", Offset = "0x95101A0", VA = "0x1895115A0")]
		public Color? GetColorFromPalette(ForegroundColorPaletteType paletteType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x9511760", Offset = "0x9510360", VA = "0x189511760")]
		private void HGOHVYTPLMW(bool a = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0xB167E0", Offset = "0xB153E0", VA = "0x180B167E0")]
		protected PaletteThemeReference()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public class RangeSliderTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private RangeSlider slider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		[SerializeField]
		private SliderPaletteType sliderType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		[SerializeField]
		private Image sliderImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		[SerializeField]
		private Image fillImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		[SerializeField]
		private Image lowHandleImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		[SerializeField]
		private Image highHandleImage;

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public SliderPaletteType UVJBKTQYCBZ
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0xB18830", Offset = "0xB17430", VA = "0x180B18830")]
			get
			{
				return default(SliderPaletteType);
			}
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x9514600", Offset = "0x9513200", VA = "0x189514600")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public Image EOROLRDNHEN
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0xB13A50", Offset = "0xB12650", VA = "0x180B13A50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public Image AFDNDVMLWZL
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0xB13240", Offset = "0xB11E40", VA = "0x180B13240")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public Image ISESILZELEA
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0xB13230", Offset = "0xB11E30", VA = "0x180B13230")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public Image XYPTDMPFSPK
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0xB13B30", Offset = "0xB12730", VA = "0x180B13B30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public bool KAQYLZQIQZB
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x7D97E60", Offset = "0x7D96A60", VA = "0x187D97E60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x7D977B0", Offset = "0x7D963B0", VA = "0x187D977B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x95142B0", Offset = "0x9512EB0", VA = "0x1895142B0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x95145B0", Offset = "0x95131B0", VA = "0x1895145B0")]
		public RangeSliderTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class RawImageTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private RawImage image;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		[SerializeField]
		private RawImageColorPaletteType color;

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public RawImageColorPaletteType JXIARVIZGXO
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0xB18830", Offset = "0xB17430", VA = "0x180B18830")]
			get
			{
				return default(RawImageColorPaletteType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x9514600", Offset = "0x9513200", VA = "0x189514600")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x9514620", Offset = "0x9513220", VA = "0x189514620", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x9514750", Offset = "0x9513350", VA = "0x189514750")]
		public RawImageTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public class RecyclingGridTheme : RecyclingThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private AQPIWFVZNUS recyclingGrid;

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x95147A0", Offset = "0x95133A0", VA = "0x1895147A0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x9514980", Offset = "0x9513580", VA = "0x189514980", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x9514B60", Offset = "0x9513760", VA = "0x189514B60")]
		private void XWFNTCYNBDI(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x9514BD0", Offset = "0x95137D0", VA = "0x189514BD0")]
		public RecyclingGridTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public class RecyclingListTheme : RecyclingThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private AQPIWFVZNUS recyclingList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		private bool MFHMTFTZJSB;

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x9514C20", Offset = "0x9513820", VA = "0x189514C20", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x9514E40", Offset = "0x9513A40", VA = "0x189514E40", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x9515020", Offset = "0x9513C20", VA = "0x189515020")]
		private void ZZIFGIGGFBM(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x9514BD0", Offset = "0x95137D0", VA = "0x189514BD0")]
		public RecyclingListTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public abstract class RecyclingThemeBase : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		[Header("Audio")]
		[SerializeField]
		private RecyclingAudioPaletteType recyclingAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		protected RecyclingAudioPaletteAsset ZQXMJVZJEWZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		[SerializeField]
		private ScrollingAudioPaletteType scrollingAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		private ScrollingAudioPaletteAsset GIBESAPJNGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private ZODQAHISQFL IKNNDLVMRXN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private float OGAXEWEKEZE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private float ETMCRHEAXJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private float UAQMTXOGJGV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private float BRAEFWCTQHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private bool KGKDIQLCZZV;

		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private const float XIIJNBPPAQT = 0.01f;

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		private ZODQAHISQFL NJSMZZDXDQU
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x9515730", Offset = "0x9514330", VA = "0x189515730")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x9515090", Offset = "0x9513C90", VA = "0x189515090", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x95157C0", Offset = "0x95143C0", VA = "0x1895157C0")]
		protected void JCRLXTZHKMN(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x9515A80", Offset = "0x9514680", VA = "0x189515A80")]
		protected void JTQITITLCKD(GameObject a, int b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x95155A0", Offset = "0x95141A0", VA = "0x1895155A0")]
		protected void DSNKOXEAJPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x9515C10", Offset = "0x9514810", VA = "0x189515C10")]
		protected void RSTYFLQBYBQ(float a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x9515270", Offset = "0x9513E70", VA = "0x189515270")]
		private void BWIIOMVACJA(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x9515460", Offset = "0x9514060", VA = "0x189515460")]
		private void DBNHYPVXDQK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x9514BD0", Offset = "0x95137D0", VA = "0x189514BD0")]
		protected RecyclingThemeBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public class ScrollBarTheme : SelectableThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		[Header("Scroll Bar Audio")]
		[SerializeField]
		private ButtonAudioPaletteType buttonAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		[SerializeField]
		[Tooltip("Layer a 2D SFX on top of base button sounds")]
		private bool useFlavorSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		[SerializeField]
		[ConditionalField("useFlavorSFX")]
		[Tooltip("Flavor SFX is picked randomly from this pool config")]
		private RecRoomAudioClipPoolConfig flavorSFXClipPoolConfig;

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x9515F80", Offset = "0x9514B80", VA = "0x189515F80", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x95160C0", Offset = "0x9514CC0", VA = "0x1895160C0")]
		public ScrollBarTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public class ScrollRectTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private const string EUUAQHFEZIZ = "RRUI.PlayHittingEndsSFX";

		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private const int VKGHUMXWOYT = 5;

		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private const int EEOGXFIJEAJ = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		private DateTimeOffset EHFMTYSMQDX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		private int AMYKLUZVAGU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		private bool GTKFRZEFCSP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private ScrollRect scrollRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		[Header("Audio")]
		[SerializeField]
		private ScrollingAudioPaletteType scrollAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		private ScrollingAudioPaletteAsset ZQXMJVZJEWZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private ZODQAHISQFL IKNNDLVMRXN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private ASVHLEOBLHF KBJNEFUJZUV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private float ETMCRHEAXJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private float UAQMTXOGJGV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private float BRAEFWCTQHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		private bool KGKDIQLCZZV;

		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private const float XIIJNBPPAQT = 0.01f;

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		private ZODQAHISQFL NJSMZZDXDQU
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x9516F80", Offset = "0x9515B80", VA = "0x189516F80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		private ASVHLEOBLHF BZXEPCYGBRA
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x9516EF0", Offset = "0x9515AF0", VA = "0x189516EF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x95161B0", Offset = "0x9514DB0", VA = "0x1895161B0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x9517010", Offset = "0x9515C10", VA = "0x189517010", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x95160D0", Offset = "0x9514CD0", VA = "0x1895160D0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x9517100", Offset = "0x9515D00", VA = "0x189517100")]
		private void RAUWRNKBCZK(Vector2 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x9516340", Offset = "0x9514F40", VA = "0x189516340")]
		private void BWIIOMVACJA(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x9516530", Offset = "0x9515130", VA = "0x189516530")]
		private void DBNHYPVXDQK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x9516DD0", Offset = "0x95159D0", VA = "0x189516DD0")]
		private static string EFOXWZOCGNH(GameObject a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x9517540", Offset = "0x9516140", VA = "0x189517540")]
		public ScrollRectTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public abstract class SelectableThemeBase : PaletteThemeReference, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IPointerClickHandler, IPointerEnterHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		[Header("Selectable Theme Base")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		[FormerlySerializedAs("button")]
		private Selectable selectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		[Header("Legacy Audio Override")]
		[SerializeField]
		[FormerlySerializedAs("overrideAudio")]
		[Tooltip("Override base selectable audio with a single SFX that plays only on click.")]
		protected bool overrideWithSingleAudio;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		[SerializeField]
		[ConditionalField("overrideWithSingleAudio")]
		[Tooltip("The legacy override audio will be randomly picked from this pool")]
		protected RecRoomAudioClip[] randomAudioOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		protected bool SGFAEXTEEEX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private ButtonAudioPaletteAsset ZQXMJVZJEWZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private RecRoomAudioClipPoolConfig OPJDWFORYWL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private SVJYJIPYDON WSNGNJZFXPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private SVJYJIPYDON YAQDVKJCAZO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private SVJYJIPYDON FMRVTOLEMVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private SVJYJIPYDON BLDRGCODZXB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		private ZODQAHISQFL IKNNDLVMRXN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		private SQLLGURPDAX PZOCGDCNCSN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		private XGIVEQTISWK CXYEWUZLPIM;

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		protected Selectable OKKECTEZDVH
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0xB131D0", Offset = "0xB11DD0", VA = "0x180B131D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		protected virtual bool OSELQVVJCLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0xB2EAD0", Offset = "0xB2D6D0", VA = "0x180B2EAD0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public bool KAQYLZQIQZB
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x7D97E60", Offset = "0x7D96A60", VA = "0x187D97E60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x7D977B0", Offset = "0x7D963B0", VA = "0x187D977B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		private ZODQAHISQFL NJSMZZDXDQU
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x9517B20", Offset = "0x9516720", VA = "0x189517B20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		protected SQLLGURPDAX EIQBGSHLMTK
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x9517650", Offset = "0x9516250", VA = "0x189517650")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		private XGIVEQTISWK OZKNDPQMBVH
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x9517BF0", Offset = "0x95167F0", VA = "0x189517BF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x9518350", Offset = "0x9516F50", VA = "0x189518350")]
		protected void XMHCMCCZKLQ(ButtonAudioPaletteAsset a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xB13B40", Offset = "0xB12740", VA = "0x180B13B40")]
		protected void VSHZXOCDGYJ(RecRoomAudioClipPoolConfig a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x9518000", Offset = "0x9516C00", VA = "0x189518000", Slot = "12")]
		public virtual void OnPointerDown(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x95181B0", Offset = "0x9516DB0", VA = "0x1895181B0", Slot = "13")]
		public virtual void OnPointerUp(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x9517C90", Offset = "0x9516890", VA = "0x189517C90", Slot = "14")]
		public virtual void OnPointerClick(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x95180E0", Offset = "0x9516CE0", VA = "0x1895180E0", Slot = "15")]
		public virtual void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x95175D0", Offset = "0x95161D0", VA = "0x1895175D0")]
		private void BJKSDKYVRND(RecRoomAudioClip[] a, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x95176F0", Offset = "0x95162F0", VA = "0x1895176F0")]
		private void HBAJUAWAATL(RecRoomAudioClip a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x95182C0", Offset = "0x9516EC0", VA = "0x1895182C0")]
		public void SetOnPointerDownSoundEffectDisabled(object token, bool disabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x9518320", Offset = "0x9516F20", VA = "0x189518320")]
		public void SetOnPointerUpSoundEffectDisabled(object token, bool disabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x9518290", Offset = "0x9516E90", VA = "0x189518290")]
		public void SetOnPointerClickSoundEffectDisabled(object token, bool disabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x95182F0", Offset = "0x9516EF0", VA = "0x1895182F0")]
		public void SetOnPointerEnterSoundEffectDisabled(object token, bool disabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x9517BB0", Offset = "0x95167B0", VA = "0x189517BB0")]
		private void JUDNMXYAKAV(SVJYJIPYDON a, object b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x9518450", Offset = "0x9517050", VA = "0x189518450")]
		protected SelectableThemeBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class SliderTheme : SelectableThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		[Header("Slider Visual")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private Slider slider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		[SerializeField]
		private SliderPaletteType sliderType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		[Header("Slider Audio")]
		[SerializeField]
		private ButtonAudioPaletteType buttonAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		[SerializeField]
		[Tooltip("Layer a 2D SFX on top of base button sounds")]
		private bool useFlavorSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		[SerializeField]
		[ConditionalField("useFlavorSFX")]
		[Tooltip("Flavor SFX is picked randomly from this pool config")]
		private RecRoomAudioClipPoolConfig flavorSFXClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		[SerializeField]
		private Image sliderImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		[SerializeField]
		private Image fillImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		[SerializeField]
		private Image handleImage;

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public SliderPaletteType UVJBKTQYCBZ
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x105A8E0", Offset = "0x10594E0", VA = "0x18105A8E0")]
			get
			{
				return default(SliderPaletteType);
			}
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x9518A50", Offset = "0x9517650", VA = "0x189518A50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public Image EOROLRDNHEN
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0xB74D40", Offset = "0xB73940", VA = "0x180B74D40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public Image AFDNDVMLWZL
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0xF48A30", Offset = "0xF47630", VA = "0x180F48A30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public Image STZYNDFNXVC
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0xBD41A0", Offset = "0xBD2DA0", VA = "0x180BD41A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x9518660", Offset = "0x9517260", VA = "0x189518660", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x9518A30", Offset = "0x9517630", VA = "0x189518A30")]
		public SliderTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public class SurfaceTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private Image image;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		[SerializeField]
		[AutofillOptional(AutofillType.Self, false, false, false)]
		private UIGradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		[SerializeField]
		private BackgroundColorPaletteType color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		[SerializeField]
		[ConditionalField("gradient")]
		private bool ignoreGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		[SerializeField]
		[Tooltip("The surface theme determines if this Image is a RaycastTarget or not. There are times when you might want to ignore that setting of the palette theme and just respect whatever is the default state on the Image.")]
		private bool ignoreSettingRaycastTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		private BackgroundColorPaletteType? EFFRNLELLHL;

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public BackgroundColorPaletteType LHVUWKMUXXN
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x9518D70", Offset = "0x9517970", VA = "0x189518D70")]
			get
			{
				return default(BackgroundColorPaletteType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x9518DD0", Offset = "0x95179D0", VA = "0x189518DD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x9518A70", Offset = "0x9517670", VA = "0x189518A70", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x9518D00", Offset = "0x9517900", VA = "0x189518D00", Slot = "7")]
		public virtual void OverrideBackgroundColorPaletteAtRuntime(BackgroundColorPaletteType? backgroundPalette)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x9518D20", Offset = "0x9517920", VA = "0x189518D20")]
		public SurfaceTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public class SwitchTheme : ToggleTheme
	{
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private const float MQIZKHMNZXM = 0.33f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		[Header("Switch")]
		[SerializeField]
		private GameObject indicator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		[SerializeField]
		private GameObject indicatorOffPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		[SerializeField]
		private GameObject indicatorOnPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private PSWYBKIWRHU YRUWYIEBQIQ;

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x9518DF0", Offset = "0x95179F0", VA = "0x189518DF0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x9519050", Offset = "0x9517C50", VA = "0x189519050")]
		public SwitchTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class TilerTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private UITiler tiler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		[SerializeField]
		private TilerPaletteType type;

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x9519660", Offset = "0x9518260", VA = "0x189519660", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x95198F0", Offset = "0x95184F0", VA = "0x1895198F0")]
		public TilerTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public class ToggleTheme : ButtonThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		[Header("Toggle Visual")]
		[SerializeField]
		private TogglePaletteType toggleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		[SerializeField]
		[Tooltip("A list of objects to show while the toggle is active.")]
		private List<Hideable> hideWhenNotActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		[SerializeField]
		[Tooltip("A list of objects to show while the toggle is inactive")]
		private List<Hideable> hideWhenActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		[SerializeField]
		private bool editorIsActiveOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x169")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		[Header("Toggle Audio")]
		[SerializeField]
		[Tooltip("Override the audio palette when active defined by the toggle's visual with a custom palette")]
		private bool overrideAudioPaletteWhenActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		[SerializeField]
		[ConditionalField("overrideAudioPaletteWhenActive")]
		[Tooltip("Specify a custom config to use for toggle button audio when active")]
		private ButtonAudioPaletteAsset customButtonAudioConfigWhenActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		[SerializeField]
		[Tooltip("Override the audio palette when inactive defined by the toggle's visual with a custom palette")]
		private bool overrideAudioPaletteWhenInactive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		[SerializeField]
		[ConditionalField("overrideAudioPaletteWhenInactive")]
		[Tooltip("Specify a custom config to use for toggle button audio when inactive")]
		private ButtonAudioPaletteAsset customButtonAudioConfigWhenInactive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		[SerializeField]
		[Tooltip("Layer a 2D SFX on top of base button sounds. Flavor SFX only plays when toggling from inactive to active")]
		private bool useFlavorSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		[SerializeField]
		[ConditionalField("useFlavorSFX")]
		[Tooltip("Flavor SFX is picked randomly from this pool config")]
		private RecRoomAudioClipPoolConfig flavorSFXClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		protected bool UHFMBXRTKQC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x199")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		private bool WTLFTALELMX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19A")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		private bool OQTWSGHCMLB;

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public bool SGZBYYBIKJN
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x94C38B0", Offset = "0x94C24B0", VA = "0x1894C38B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x9519E00", Offset = "0x9518A00", VA = "0x189519E00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public TogglePaletteType PVCSSNPQPWI
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x1131C80", Offset = "0x1130880", VA = "0x181131C80")]
			get
			{
				return default(TogglePaletteType);
			}
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x950D420", Offset = "0x950C020", VA = "0x18950D420")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		protected override bool OSELQVVJCLP
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x9519940", Offset = "0x9518540", VA = "0x189519940", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x9519D40", Offset = "0x9518940", VA = "0x189519D40", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x9519DC0", Offset = "0x95189C0", VA = "0x189519DC0")]
		public void Toggle()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x9519D80", Offset = "0x9518980", VA = "0x189519D80")]
		public void Toggle(bool isActive, bool isInstant)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x9519950", Offset = "0x9518550", VA = "0x189519950", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x9519050", Offset = "0x9517C50", VA = "0x189519050")]
		public ToggleTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public class ActiveEventThemeSwapper : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		[SerializeField]
		private string eventActiveGameConfigKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		[SerializeField]
		private bool swapSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		[ConditionalField("swapSprite")]
		[SerializeField]
		private Image targetImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		[ConditionalField("swapSprite")]
		[SerializeField]
		private Sprite targetSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		[SerializeField]
		private bool swapSurfaceTheme;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		[ConditionalField("swapSurfaceTheme")]
		[SerializeField]
		private SurfaceTheme targetSurfaceTheme;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		[ConditionalField("swapSurfaceTheme")]
		[SerializeField]
		private BackgroundColorPaletteType targetPalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		[SerializeField]
		private bool changeGradientDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		[ConditionalField("changeGradientDirection")]
		[SerializeField]
		private UIGradient targetGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		[ConditionalField("changeGradientDirection")]
		[SerializeField]
		private UIGradient.GradientType targetGradientType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		private EDFELDUZHLG SQUOLSGCEMO;

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x950AD70", Offset = "0x9509970", VA = "0x18950AD70")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x950ACD0", Offset = "0x95098D0", VA = "0x18950ACD0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x950AA80", Offset = "0x9509680", VA = "0x18950AA80")]
		private void DDKCDBERZBZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x950AEC0", Offset = "0x9509AC0", VA = "0x18950AEC0")]
		private void XBBDIOGKKMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x950B010", Offset = "0x9509C10", VA = "0x18950B010")]
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
