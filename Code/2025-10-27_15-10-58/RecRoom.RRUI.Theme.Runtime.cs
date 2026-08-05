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
		[Cpp2IlInjected.Address(RVA = "0x91FBC00", Offset = "0x91FAC00", VA = "0x1891FBC00", Slot = "4")]
		public override void YTBQRMTMKZK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAF86F0", Offset = "0xAF76F0", VA = "0x180AF86F0")]
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
		private sealed class CWRWNJLXLSS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public TMP_FontAsset KALQPUUUJGM;

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public CWRWNJLXLSS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x91F8ED0", Offset = "0x91F7ED0", VA = "0x1891F8ED0")]
			internal bool THMKKHTBYTB(LocalizedFontMapping a)
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
		[Cpp2IlInjected.Address(RVA = "0x91FAB30", Offset = "0x91F9B30", VA = "0x1891FAB30")]
		public bool IsLocalizedFontAsset(TMP_FontAsset font)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x91FA670", Offset = "0x91F9670", VA = "0x1891FA670")]
		public TMP_FontAsset GetLocalizedFontAsset(TMP_FontAsset font)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x91FA430", Offset = "0x91F9430", VA = "0x1891FA430")]
		public TMP_FontAsset GetLocalizedFontAsset(TMP_FontAsset font, Material overrideMaterial, [Out] Material localizedOverrideMaterial)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x91FA7D0", Offset = "0x91F97D0", VA = "0x1891FA7D0")]
		public TMP_FontAsset GetNonLocalizedFontAsset(TMP_FontAsset font)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x91FA930", Offset = "0x91F9930", VA = "0x1891FA930")]
		public TMP_FontAsset GetNonLocalizedFontAsset(TMP_FontAsset font, Material overrideMaterial, [Out] Material nonLocalizedOverrideMaterial)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x91FA380", Offset = "0x91F9380", VA = "0x1891FA380")]
		private static bool ATDNCJZQLYD(TMP_FontAsset a, LocalizedFontMapping b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x91FAC50", Offset = "0x91F9C50", VA = "0x1891FAC50")]
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
		public Palette COLJRLENRVF
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x9204F60", Offset = "0x9203F60", VA = "0x189204F60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9204F00", Offset = "0x9203F00", VA = "0x189204F00")]
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
		[Cpp2IlInjected.Address(RVA = "0x91FAD30", Offset = "0x91F9D30", VA = "0x1891FAD30", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x91FACD0", Offset = "0x91F9CD0", VA = "0x1891FACD0", Slot = "4")]
		public bool Equals(GradientBlock other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x91FAE20", Offset = "0x91F9E20", VA = "0x1891FAE20", Slot = "2")]
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
		public List<Graphic> KUXXNNPIMMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xC4A220", Offset = "0xC49220", VA = "0x180C4A220")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xB3F6A0", Offset = "0xB3E6A0", VA = "0x180B3F6A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public ColorBlock LKPPCXAZNWZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x91FCE80", Offset = "0x91FBE80", VA = "0x1891FCE80")]
			get
			{
				return default(ColorBlock);
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x91FCF00", Offset = "0x91FBF00", VA = "0x1891FCF00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public UIGradient ZJFNYLXJJDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xBFE0E0", Offset = "0xBFD0E0", VA = "0x180BFE0E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xCFF4A0", Offset = "0xCFE4A0", VA = "0x180CFF4A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public GradientBlock QQSVNPOXJTU
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x91FCED0", Offset = "0x91FBED0", VA = "0x1891FCED0")]
			get
			{
				return default(GradientBlock);
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x91FCF50", Offset = "0x91FBF50", VA = "0x1891FCF50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x91FCD00", Offset = "0x91FBD00", VA = "0x1891FCD00", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x91FCD50", Offset = "0x91FBD50", VA = "0x1891FCD50")]
		public void Refresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x91FCAD0", Offset = "0x91FBAD0", VA = "0x1891FCAD0")]
		public void ForceHighlighted(bool instant)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x91FCAF0", Offset = "0x91FBAF0", VA = "0x1891FCAF0")]
		public void ForceNormal(bool instant)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x91FC770", Offset = "0x91FB770", VA = "0x1891FC770", Slot = "28")]
		protected override void DoStateTransition(SelectionState state, bool instant)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x91FCC10", Offset = "0x91FBC10", VA = "0x1891FCC10")]
		private void NGKIGFHTBAB(Graphic a, Color b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x91FCB10", Offset = "0x91FBB10", VA = "0x1891FCB10")]
		private void MPYDWOHLNOY(SelectionState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x91FCD80", Offset = "0x91FBD80", VA = "0x1891FCD80")]
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
				[Cpp2IlInjected.Address(RVA = "0xACD110", Offset = "0xACC110", VA = "0x180ACD110")]
				get
				{
					return default(ButtonAudioPaletteType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public ButtonAudioPaletteAsset ButtonAudioPaletteConfig
			{
				[Cpp2IlInjected.Token(Token = "0x6000027")]
				[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
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
				[Cpp2IlInjected.Address(RVA = "0xACD110", Offset = "0xACC110", VA = "0x180ACD110")]
				get
				{
					return default(ScrollingAudioPaletteType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public ScrollingAudioPaletteAsset ScrollingAudioPaletteConfig
			{
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
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
				[Cpp2IlInjected.Address(RVA = "0xACD110", Offset = "0xACC110", VA = "0x180ACD110")]
				get
				{
					return default(ContentLoadingAudioPaletteType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public ContentLoadingAudioPaletteAsset ContentLoadingAudioPaletteConfig
			{
				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
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
				[Cpp2IlInjected.Address(RVA = "0xACD110", Offset = "0xACC110", VA = "0x180ACD110")]
				get
				{
					return default(RecyclingAudioPaletteType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public RecyclingAudioPaletteAsset RecyclingAudioPaletteConfig
			{
				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public RecyclingAudioPaletteItem()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class MVGSWCHOTEO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public ContentLoadingAudioPaletteType IDWVKTSRJGD;

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public MVGSWCHOTEO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xBBC820", Offset = "0xBBB820", VA = "0x180BBC820")]
			internal bool MCADNEJYKIJ(ContentLoadingAudioPaletteItem a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class IJCSPLUDTQJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public RecyclingAudioPaletteType FTDJPCOOFGE;

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public IJCSPLUDTQJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xBBC820", Offset = "0xBBB820", VA = "0x180BBC820")]
			internal bool IBIPDLJXBLG(RecyclingAudioPaletteItem a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class XTKJJUTWICP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public ButtonAudioPaletteType VPITAEXKPQA;

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public XTKJJUTWICP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xBBC820", Offset = "0xBBB820", VA = "0x180BBC820")]
			internal bool TSDUXZMBRNA(ButtonAudioPaletteItem a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class SCYSNCSTSXC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public ScrollingAudioPaletteType MUDNZKNTNLL;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public SCYSNCSTSXC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xBBC820", Offset = "0xBBB820", VA = "0x180BBC820")]
			internal bool NFMSVVIJVIX(ScrollingAudioPaletteItem a)
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
		[Cpp2IlInjected.Address(RVA = "0x91F6FE0", Offset = "0x91F5FE0", VA = "0x1891F6FE0")]
		public ButtonAudioPaletteAsset GetButtonAudioPalette(ButtonAudioPaletteType buttonAudioPaletteType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x91F7280", Offset = "0x91F6280", VA = "0x1891F7280")]
		public ScrollingAudioPaletteAsset GetScrollingAudioPaletteConfig(ScrollingAudioPaletteType scrollingAudioPaletteType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x91F70C0", Offset = "0x91F60C0", VA = "0x1891F70C0")]
		public ContentLoadingAudioPaletteAsset GetContentLoadingAudioPaletteConfig(ContentLoadingAudioPaletteType contentLoadingAudioPaletteType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x91F71A0", Offset = "0x91F61A0", VA = "0x1891F71A0")]
		public RecyclingAudioPaletteAsset GetRecyclingAudioPaletteConfig(RecyclingAudioPaletteType recyclingAudioPaletteType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xE15560", Offset = "0xE14560", VA = "0x180E15560")]
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
		public float IWZZQSKWGHJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xB24B00", Offset = "0xB23B00", VA = "0x180B24B00")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public float QWQAUJDQIMD
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xB24910", Offset = "0xB23910", VA = "0x180B24910")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x91F73E0", Offset = "0x91F63E0", VA = "0x1891F73E0")]
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
			[Cpp2IlInjected.Address(RVA = "0xF91B80", Offset = "0xF90B80", VA = "0x180F91B80")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public ColorBlock BackgroundTints
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x91F7500", Offset = "0x91F6500", VA = "0x1891F7500")]
			get
			{
				return default(ColorBlock);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public GradientBlock BackgroundGradients
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x1623A30", Offset = "0x1622A30", VA = "0x181623A30")]
			get
			{
				return default(GradientBlock);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Color ForegroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x1379AC0", Offset = "0x1378AC0", VA = "0x181379AC0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public ColorBlock ForegroundTints
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x91F7540", Offset = "0x91F6540", VA = "0x1891F7540")]
			get
			{
				return default(ColorBlock);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool ShowBorder
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xC0C5B0", Offset = "0xC0B5B0", VA = "0x180C0C5B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public TextStylePalette TextPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xBEA6F0", Offset = "0xBE96F0", VA = "0x180BEA6F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public ButtonAudioPaletteType AudioPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x2561520", Offset = "0x2560520", VA = "0x182561520")]
			get
			{
				return default(ButtonAudioPaletteType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x91F7400", Offset = "0x91F6400", VA = "0x1891F7400")]
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
			[Cpp2IlInjected.Address(RVA = "0xE81710", Offset = "0xE80710", VA = "0x180E81710")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
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
			[Cpp2IlInjected.Address(RVA = "0xF91B80", Offset = "0xF90B80", VA = "0x180F91B80")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public TextStylePalette TextPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xAD1AD0", Offset = "0xAD0AD0", VA = "0x180AD1AD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x91F9CC0", Offset = "0x91F8CC0", VA = "0x1891F9CC0")]
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
			[Cpp2IlInjected.Address(RVA = "0xF91B80", Offset = "0xF90B80", VA = "0x180F91B80")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Color ForegroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0xF99640", Offset = "0xF98640", VA = "0x180F99640")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Color PlaceholderColor
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x10374D0", Offset = "0x10364D0", VA = "0x1810374D0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public TextStylePalette TextPalette
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xACFFA0", Offset = "0xACEFA0", VA = "0x180ACFFA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x91FB330", Offset = "0x91FA330", VA = "0x1891FB330")]
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
			[Cpp2IlInjected.Address(RVA = "0xACFDA0", Offset = "0xACEDA0", VA = "0x180ACFDA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x91FC0C0", Offset = "0x91FB0C0", VA = "0x1891FC0C0")]
		public TogglePalette EENBVBIGGCF(Palette a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x91FC0F0", Offset = "0x91FB0F0", VA = "0x1891FC0F0")]
		public ButtonPalette HUDXATFIDAZ(Palette a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
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
				[Cpp2IlInjected.Address(RVA = "0xACD110", Offset = "0xACC110", VA = "0x180ACD110")]
				get
				{
					return default(RawImageColorPaletteType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			public Color Color
			{
				[Cpp2IlInjected.Token(Token = "0x6000068")]
				[Cpp2IlInjected.Address(RVA = "0x1CA7800", Offset = "0x1CA6800", VA = "0x181CA7800")]
				get
				{
					return default(Color);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xB13C80", Offset = "0xB12C80", VA = "0x180B13C80")]
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
				[Cpp2IlInjected.Address(RVA = "0xACD110", Offset = "0xACC110", VA = "0x180ACD110")]
				get
				{
					return default(BackgroundColorPaletteType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			public Color Color
			{
				[Cpp2IlInjected.Token(Token = "0x600006B")]
				[Cpp2IlInjected.Address(RVA = "0x1CA7800", Offset = "0x1CA6800", VA = "0x181CA7800")]
				get
				{
					return default(Color);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			public Gradient Gradient
			{
				[Cpp2IlInjected.Token(Token = "0x600006C")]
				[Cpp2IlInjected.Address(RVA = "0xACFF90", Offset = "0xACEF90", VA = "0x180ACFF90")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			public bool RaycastTarget
			{
				[Cpp2IlInjected.Token(Token = "0x600006D")]
				[Cpp2IlInjected.Address(RVA = "0xB31A30", Offset = "0xB30A30", VA = "0x180B31A30")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x91F7360", Offset = "0x91F6360", VA = "0x1891F7360")]
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
				[Cpp2IlInjected.Address(RVA = "0xACD110", Offset = "0xACC110", VA = "0x180ACD110")]
				get
				{
					return default(ForegroundColorPaletteType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			public Color Color
			{
				[Cpp2IlInjected.Token(Token = "0x6000070")]
				[Cpp2IlInjected.Address(RVA = "0x1CA7800", Offset = "0x1CA6800", VA = "0x181CA7800")]
				get
				{
					return default(Color);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x91FACB0", Offset = "0x91F9CB0", VA = "0x1891FACB0")]
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
				[Cpp2IlInjected.Address(RVA = "0xACD110", Offset = "0xACC110", VA = "0x180ACD110")]
				get
				{
					return default(TilerPaletteType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			public TilerPalette TilerPalette
			{
				[Cpp2IlInjected.Token(Token = "0x6000073")]
				[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
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
				[Cpp2IlInjected.Address(RVA = "0xACD110", Offset = "0xACC110", VA = "0x180ACD110")]
				get
				{
					return default(TextStylePaletteType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			public TextStylePalette TextStylePalette
			{
				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
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
				[Cpp2IlInjected.Address(RVA = "0xACD110", Offset = "0xACC110", VA = "0x180ACD110")]
				get
				{
					return default(TextSizePaletteType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			public int Size
			{
				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0xC5B060", Offset = "0xC5A060", VA = "0x180C5B060")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x16B7240", Offset = "0x16B6240", VA = "0x1816B7240")]
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
				[Cpp2IlInjected.Address(RVA = "0xACD110", Offset = "0xACC110", VA = "0x180ACD110")]
				get
				{
					return default(ButtonPaletteType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			public ButtonPalette ButtonPalette
			{
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
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
				[Cpp2IlInjected.Address(RVA = "0xACD110", Offset = "0xACC110", VA = "0x180ACD110")]
				get
				{
					return default(TogglePaletteType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public TogglePalette TogglePalette
			{
				[Cpp2IlInjected.Token(Token = "0x600007F")]
				[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
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
				[Cpp2IlInjected.Address(RVA = "0xACD110", Offset = "0xACC110", VA = "0x180ACD110")]
				get
				{
					return default(MixedTogglePaletteType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public MixedTogglePalette MixedTogglePalette
			{
				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
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
				[Cpp2IlInjected.Address(RVA = "0xACD110", Offset = "0xACC110", VA = "0x180ACD110")]
				get
				{
					return default(MakerPenToolPaletteType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public MakerPenToolPalette MakerPenToolPalette
			{
				[Cpp2IlInjected.Token(Token = "0x6000085")]
				[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
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
				[Cpp2IlInjected.Address(RVA = "0xACD110", Offset = "0xACC110", VA = "0x180ACD110")]
				get
				{
					return default(InputFieldPaletteType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public InputFieldPalette InputFieldPalette
			{
				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
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
				[Cpp2IlInjected.Address(RVA = "0xACD110", Offset = "0xACC110", VA = "0x180ACD110")]
				get
				{
					return default(DropdownPaletteType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public DropdownPalette DropdownPalette
			{
				[Cpp2IlInjected.Token(Token = "0x600008B")]
				[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
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
				[Cpp2IlInjected.Address(RVA = "0xACD110", Offset = "0xACC110", VA = "0x180ACD110")]
				get
				{
					return default(SliderPaletteType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public SliderPalette SliderPalette
			{
				[Cpp2IlInjected.Token(Token = "0x600008E")]
				[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
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
				[Cpp2IlInjected.Address(RVA = "0xACD110", Offset = "0xACC110", VA = "0x180ACD110")]
				get
				{
					return default(DepthPaletteType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public DepthPalette DepthPalette
			{
				[Cpp2IlInjected.Token(Token = "0x6000091")]
				[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public DepthPaletteItem()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private sealed class IJCSPLUDTQJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public TilerPaletteType DCVVHWLTKKV;

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public IJCSPLUDTQJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xBBC820", Offset = "0xBBB820", VA = "0x180BBC820")]
			internal bool LFPIQJEHYFI(TilerPaletteItem a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class WLNPPNEKMUG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public TextStylePaletteType VEPQVWZRZRY;

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public WLNPPNEKMUG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xBBC820", Offset = "0xBBB820", VA = "0x180BBC820")]
			internal bool COEYONKDVVG(TextStylePaletteItem a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class BEUHJFMKNBR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public TextSizePaletteType MLJXHCTXMNI;

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public BEUHJFMKNBR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xBBC820", Offset = "0xBBB820", VA = "0x180BBC820")]
			internal bool OTKUNJTMEAP(TextSizePaletteItem a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[CompilerGenerated]
		private sealed class SPETXCBTZKB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public ButtonPaletteType BJWBVNNRAMI;

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public SPETXCBTZKB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0xBBC820", Offset = "0xBBB820", VA = "0x180BBC820")]
			internal bool JDSMNIPPOZA(ButtonPaletteItem a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		[CompilerGenerated]
		private sealed class NVSXQXKFTLK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public TogglePaletteType XMFGLXHFVFW;

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public NVSXQXKFTLK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xBBC820", Offset = "0xBBB820", VA = "0x180BBC820")]
			internal bool WTRMEHRXWQW(TogglePaletteItem a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class SLQLDOEMMAL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public MixedTogglePaletteType WFLRMMQVEEX;

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public SLQLDOEMMAL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xBBC820", Offset = "0xBBB820", VA = "0x180BBC820")]
			internal bool IIRJLEMCVAP(MixedTogglePaletteItem a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class DCEYDDAQGHA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public MakerPenToolPaletteType XCGLKHKCAQH;

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public DCEYDDAQGHA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xBBC820", Offset = "0xBBB820", VA = "0x180BBC820")]
			internal bool RSESDCSPMMT(MakerPenToolPaletteItem a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000035")]
		[CompilerGenerated]
		private sealed class XDIBTWVITXT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public RawImageColorPaletteType KAOXXQICAMD;

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public XDIBTWVITXT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0xBBC820", Offset = "0xBBB820", VA = "0x180BBC820")]
			internal bool RSBUVAJENIR(RawImageColorPaletteItem a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000036")]
		[CompilerGenerated]
		private sealed class ULCVYJVRYIC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public InputFieldPaletteType XRCYHJGBOKY;

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public ULCVYJVRYIC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0xBBC820", Offset = "0xBBB820", VA = "0x180BBC820")]
			internal bool HUEYHVJTRYC(InputFieldPaletteItem a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[CompilerGenerated]
		private sealed class ALKDSLXHLFB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public DropdownPaletteType EWCUEKFKAUT;

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public ALKDSLXHLFB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xBBC820", Offset = "0xBBB820", VA = "0x180BBC820")]
			internal bool LYXITMDXMUX(DropdownPaletteItem a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		[CompilerGenerated]
		private sealed class CIWTBPPSAUA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public SliderPaletteType RDWCDCRARJZ;

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public CIWTBPPSAUA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xBBC820", Offset = "0xBBB820", VA = "0x180BBC820")]
			internal bool DFBIHYKWTZN(SliderPaletteItem a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000039")]
		[CompilerGenerated]
		private sealed class TIYHKCWYTBQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public DepthPaletteType KIZGKULQUXT;

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public TIYHKCWYTBQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xBBC820", Offset = "0xBBB820", VA = "0x180BBC820")]
			internal bool VIZOUJAKRMA(DepthPaletteItem a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		[CompilerGenerated]
		private sealed class DABAUKZQTLC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public BackgroundColorPaletteType KAOXXQICAMD;

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public DABAUKZQTLC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xBBC820", Offset = "0xBBB820", VA = "0x180BBC820")]
			internal bool AHRXBYKQHHM(BackgroundColorPaletteItem a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		[CompilerGenerated]
		private sealed class XTKJJUTWICP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public ForegroundColorPaletteType YFICWFTGNQW;

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public XTKJJUTWICP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xBBC820", Offset = "0xBBB820", VA = "0x180BBC820")]
			internal bool HHACDZSNVDN(ForegroundColorPaletteItem a)
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
		public IEnumerable<DepthPaletteItem> YSHEARWFPOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xAD6ED0", Offset = "0xAD5ED0", VA = "0x180AD6ED0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public ButtonAnimationPalette CYQKGCLDWWM
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xAD6870", Offset = "0xAD5870", VA = "0x180AD6870")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public AudioPalette UBGINCKQEUI
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xAFD970", Offset = "0xAFC970", VA = "0x180AFD970")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x91FF700", Offset = "0x91FE700", VA = "0x1891FF700")]
		public Color GetRawImageColor(RawImageColorPaletteType backgroundColorPaletteType)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x91FEF20", Offset = "0x91FDF20", VA = "0x1891FEF20")]
		public void GetBackgroundPaletteData(BackgroundColorPaletteType backgroundColorPaletteType, [Out] Color color, [Out] Gradient gradient, [Out] bool raycastTarget)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x91FF370", Offset = "0x91FE370", VA = "0x1891FF370")]
		public Color GetForegroundColor(ForegroundColorPaletteType foregroundColorPaletteType)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x91FFA90", Offset = "0x91FEA90", VA = "0x1891FFA90")]
		public TilerPalette GetTilerPalette(TilerPaletteType type)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x91FF9B0", Offset = "0x91FE9B0", VA = "0x1891FF9B0")]
		public TextStylePalette GetTextStylePalette(TextStylePaletteType textStylePaletteType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x91FF8D0", Offset = "0x91FE8D0", VA = "0x1891FF8D0")]
		public int GetTextSize(TextSizePaletteType textSizePaletteType)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x91FF090", Offset = "0x91FE090", VA = "0x1891FF090")]
		public ButtonPalette GetButtonPalette(ButtonPaletteType buttonPaletteType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x91FFB70", Offset = "0x91FEB70", VA = "0x1891FFB70")]
		public TogglePalette GetTogglePalette(TogglePaletteType togglePaletteType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x91FF620", Offset = "0x91FE620", VA = "0x1891FF620")]
		public MixedTogglePalette GetMixedTogglePalette(MixedTogglePaletteType mixedTogglePaletteType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x91FF540", Offset = "0x91FE540", VA = "0x1891FF540")]
		public MakerPenToolPalette GetMakerPenToolPalette(MakerPenToolPaletteType makerPenToolPaletteType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x91FF460", Offset = "0x91FE460", VA = "0x1891FF460")]
		public InputFieldPalette GetInputFieldPalette(InputFieldPaletteType inputFieldPaletteType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x91FF290", Offset = "0x91FE290", VA = "0x1891FF290")]
		public DropdownPalette GetDropdownPalette(DropdownPaletteType dropdownPaletteType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x91FF7F0", Offset = "0x91FE7F0", VA = "0x1891FF7F0")]
		public SliderPalette GetSliderPalette(SliderPaletteType sliderPaletteType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x91FF170", Offset = "0x91FE170", VA = "0x1891FF170")]
		public float? GetDepth(DepthPaletteType depthPaletteType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xE15560", Offset = "0xE14560", VA = "0x180E15560")]
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
			[Cpp2IlInjected.Address(RVA = "0xF91B80", Offset = "0xF90B80", VA = "0x180F91B80")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public Color FillColor
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xF99640", Offset = "0xF98640", VA = "0x180F99640")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public Color HandleColor
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x10374D0", Offset = "0x10364D0", VA = "0x1810374D0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public ColorBlock ColorBlock
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x9203FC0", Offset = "0x9202FC0", VA = "0x189203FC0")]
			get
			{
				return default(ColorBlock);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x9203F00", Offset = "0x9202F00", VA = "0x189203F00")]
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
		[Cpp2IlInjected.Address(RVA = "0x9204A00", Offset = "0x9203A00", VA = "0x189204A00")]
		public void Apply(TextMeshProUGUI textMeshProUGUI, bool isInputTextField = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
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
			[Cpp2IlInjected.Address(RVA = "0xACFDA0", Offset = "0xACEDA0", VA = "0x180ACFDA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public Color TintColor
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xCD6080", Offset = "0xCD5080", VA = "0x180CD6080")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public Color BackgroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x1505210", Offset = "0x1504210", VA = "0x181505210")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public float Rows
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xE50F40", Offset = "0xE4FF40", VA = "0x180E50F40")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public Vector2 Spacing
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x9204FE0", Offset = "0x9203FE0", VA = "0x189204FE0")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public float Offset
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0xB1E810", Offset = "0xB1D810", VA = "0x180B1E810")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public Vector2 Velocity
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0xFCDAB0", Offset = "0xFCCAB0", VA = "0x180FCDAB0")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public float Angle
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0xB1D170", Offset = "0xB1C170", VA = "0x180B1D170")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public UITiler.AnimationType AnimationDirection
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x1401550", Offset = "0x1400550", VA = "0x181401550")]
			get
			{
				return default(UITiler.AnimationType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public float PrimaryAnimationSpeed
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x1379B00", Offset = "0x1378B00", VA = "0x181379B00")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public float AltAnimationSpeed
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x1379B30", Offset = "0x1378B30", VA = "0x181379B30")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x9204F90", Offset = "0x9203F90", VA = "0x189204F90")]
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
			[Cpp2IlInjected.Address(RVA = "0xACFDA0", Offset = "0xACEDA0", VA = "0x180ACFDA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public ButtonPalette ActiveButtonPalette
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
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
		RRPlus,
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		TrickOrTreatCard,
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		TrickOrTreatBG
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public enum RawImageColorPaletteType
	{
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		A
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public enum ForegroundColorPaletteType
	{
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		MainPrimary,
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		MainSecondary,
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		InversePrimary,
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		NotUse,
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		WhitePrimary,
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		WhiteSecondary,
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		CardPrimary,
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		CardSecondary,
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		Error,
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		Modified,
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		Orange
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public enum TilerPaletteType
	{
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		WatchBackground,
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		HomePage,
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		DialogPage,
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		Card,
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		ProfileBG,
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		WinterWonderlandHome,
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		MerryMidway
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public enum TextStylePaletteType
	{
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		JostMedium,
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		JostMediumCap,
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		JostBoldCap,
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		RobotoReg,
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		RobotoBold,
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		RobotoBoldOutlineDropshadow,
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		RobotoBoldOutline,
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		RobotoBoldOutlineDropshadowGradient,
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		RobotoBoldOutlineGradient
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public enum TextSizePaletteType
	{
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		XXXS = -1,
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		XXS = 0,
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		XS = 1,
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		S = 2,
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		M = 3,
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		L = 4,
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		XL = 5,
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		XXL = 8,
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		XXXL = 6,
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		XXXXL = 7
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public enum ButtonPaletteType
	{
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		Primary,
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		Secondary,
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		FlatPrimary,
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		FlatButtonForWarningBanner,
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		Negative,
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		Chips,
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		CarouselArrowDark,
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		FlatWhite,
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		MagicDoor,
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		Tertiary_DupeWith2NDHeader_NeedReplace,
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		CarouselArrowLight,
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		HomePageMainButton,
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		DropDown,
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		SecondaryHeaderSection,
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		ChatButton,
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		FeedButton,
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		NameTag,
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		RoomCurrency,
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		ChipsWhite,
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		UGCBaseButton,
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		UGCBaseButton_Subtle_NoDisabledState,
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		RevenuePurchaseGreen,
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		RecRoomPlus,
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		SearchBar
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public enum TogglePaletteType
	{
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		FlatOrange,
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		FlatWhite,
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		InputToggle,
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		Chips,
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		Switch,
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		WhitePagingBlob,
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		RSVPToggleHeaderSection,
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		CardSelectableToggle,
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		ChipsDark,
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		MainNavToggle,
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		ListItem,
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		NotiUnread,
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		FlatPrimary,
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		CharadePen,
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		ShareCam,
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		CardSelectableToggleWithBacking,
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		SecondaryHeaderSectionToggle,
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		PrimaryToSecondaryHeader,
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		NegativeToSecondaryHeader,
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		LimitedEventPrimary,
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		LimitedEventSecondary,
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		RoomCardWithLimitedEvent,
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		MainNavVrDetach,
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		HomeMainNav,
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		FlatOrangeSecondary,
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		ChipsPurple,
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		ShareCamTab
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public enum MixedTogglePaletteType
	{
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		Checkbox
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public enum MakerPenToolPaletteType
	{
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		Create,
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		Select,
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		Wire,
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		Configure,
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		Transform,
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		Move,
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		Rotate,
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		Scale,
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		CloneFlip,
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		Recolor,
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		Freeze,
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		MakeInvention,
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		Manipulate,
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		Delete,
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		SelectConnect,
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		ResetMakerAI,
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		NewMove
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public enum InputFieldPaletteType
	{
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		LightFlat,
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		DarkFlat,
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		Modified
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public enum DropdownPaletteType
	{
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		LightFlat,
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		DarkFlat
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public enum SliderPaletteType
	{
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		MirroUIPopUp
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public enum DepthPaletteType
	{
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		Base,
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		Button,
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		Navigation,
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		Overlay,
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		Dialog,
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		Toast
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public class ApproximationMaskDepthTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		[SerializeField]
		private RectTransform content;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private Vector3? DIIFMRPFOMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private Vector3? BNKOXNTTQPS;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x91F6EB0", Offset = "0x91F5EB0", VA = "0x1891F6EB0")]
		private void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x91F6AF0", Offset = "0x91F5AF0", VA = "0x1891F6AF0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x91F6F90", Offset = "0x91F5F90", VA = "0x1891F6F90")]
		public ApproximationMaskDepthTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public class ButtonTheme : ButtonThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		[Header("Button Visual")]
		[SerializeField]
		private ButtonPaletteType buttonType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x154")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		[Header("Button Audio")]
		[SerializeField]
		[Tooltip("Override the audio palette defined by the button's visual with a custom palette")]
		private bool overrideButtonAudioPalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		[SerializeField]
		[ConditionalField("overrideButtonAudioPalette")]
		[Tooltip("Specify a custom config to use for button audio")]
		private ButtonAudioPaletteAsset customButtonAudioConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		[SerializeField]
		[Tooltip("Layer a 2D SFX on top of base button sounds")]
		private bool useFlavorSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		[SerializeField]
		[ConditionalField("useFlavorSFX")]
		[Tooltip("Flavor SFX is picked randomly from this pool config")]
		private RecRoomAudioClipPoolConfig flavorSFXClipPoolConfig;

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public ButtonPaletteType ZOBIBECNXVK
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x190F6A0", Offset = "0x190E6A0", VA = "0x18190F6A0")]
			get
			{
				return default(ButtonPaletteType);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x91F8EB0", Offset = "0x91F7EB0", VA = "0x1891F8EB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x91F8C50", Offset = "0x91F7C50", VA = "0x1891F8C50", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2514280", Offset = "0x2513280", VA = "0x182514280")]
		public void SetAnimationEnabled(bool enabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x91F8EA0", Offset = "0x91F7EA0", VA = "0x1891F8EA0")]
		public ButtonTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public abstract class ButtonThemeBase : SelectableThemeBase
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		protected class PJKSGUYIVCY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000178")]
			public ButtonAudioPaletteAsset SXMHVOFACBZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000179")]
			public RecRoomAudioClipPoolConfig WRNXNRJRCLM;

			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public PJKSGUYIVCY()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		[Header("Button Theme Base")]
		[SerializeField]
		[AutofillOptional(AutofillType.Self, false, false, false)]
		private MultiGraphicButton multiGraphicButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		[SerializeField]
		[AutofillOptional(AutofillType.Self, false, true, false)]
		private Image surface;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		[SerializeField]
		private bool useSurfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		[SerializeField]
		[ConditionalField("useSurfaceOverride")]
		private Image surfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		[SerializeField]
		private bool controlSurfaceColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		[SerializeField]
		[ReadOnlyField]
		private List<Graphic> graphics;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		[SerializeField]
		private bool useGraphicsOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		[SerializeField]
		[ConditionalField("useGraphicsOverride")]
		private List<Graphic> graphicsOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		[SerializeField]
		[ConditionalFieldExcept("useGraphicsOverride", new object[] { })]
		private bool graphicsIgnoreTextFields;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD1")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		[SerializeField]
		private bool controlGraphicColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		[SerializeField]
		[AutofillOptional(AutofillType.Self, false, true, false)]
		private UIGradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		[SerializeField]
		private bool useGradientOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		[SerializeField]
		[ConditionalField("useGradientOverride")]
		private UIGradient gradientOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		[SerializeField]
		[AutofillOptional(AutofillType.Children, true, true, false)]
		private TextMeshProUGUI textMeshProUGUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		[SerializeField]
		private bool useTextMeshProUGUIOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		[SerializeField]
		[ConditionalField("useTextMeshProUGUIOverride")]
		private TextMeshProUGUI textMeshProUGUIOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		[SerializeField]
		private TextSizePaletteType textSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		[SerializeField]
		protected Hideable borderHideable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		[SerializeField]
		protected bool isAnimationEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x119")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		[SerializeField]
		[ConditionalField("isAnimationEnabled")]
		protected bool overrideAnimationTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		[SerializeField]
		[ConditionalField("overrideAnimationTarget")]
		protected GameObject animationTargetOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private bool HTXKISATTFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private Vector3 PQHWVXUUJNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private Vector3 QQGIEEGHJLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private QLMCBPGELJU XDLINFGCMFK;

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public Image TKQZMJELSQY
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x91F8BF0", Offset = "0x91F7BF0", VA = "0x1891F8BF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public List<Graphic> KQICECDLGYM
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x91F8BD0", Offset = "0x91F7BD0", VA = "0x1891F8BD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public UIGradient XUZZPFARCVH
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x91F8BB0", Offset = "0x91F7BB0", VA = "0x1891F8BB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public TextMeshProUGUI QVMJBFSEJPG
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x91F8C10", Offset = "0x91F7C10", VA = "0x1891F8C10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public TextSizePaletteType YBBDREJXMJA
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x1981270", Offset = "0x1980270", VA = "0x181981270")]
			get
			{
				return default(TextSizePaletteType);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x91F8C30", Offset = "0x91F7C30", VA = "0x1891F8C30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		protected Transform QYYKXEVFSGA
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x91F7590", Offset = "0x91F6590", VA = "0x1891F7590")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public Button SZFSZIKRHDD
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x91F8B30", Offset = "0x91F7B30", VA = "0x1891F8B30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x91F7680", Offset = "0x91F6680", VA = "0x1891F7680")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x91F75E0", Offset = "0x91F65E0", VA = "0x1891F75E0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x91F8890", Offset = "0x91F7890", VA = "0x1891F8890")]
		protected void YDDQFFGRHTQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x91F7DF0", Offset = "0x91F6DF0", VA = "0x1891F7DF0")]
		protected void VAZDSFIQBVY(ButtonPalette a, [Optional] PJKSGUYIVCY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x91F7720", Offset = "0x91F6720", VA = "0x1891F7720", Slot = "12")]
		public override void OnPointerDown(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x91F7AD0", Offset = "0x91F6AD0", VA = "0x1891F7AD0", Slot = "13")]
		public override void OnPointerUp(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x91F7700", Offset = "0x91F6700", VA = "0x1891F7700", Slot = "14")]
		public override void OnPointerClick(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x91F7DD0", Offset = "0x91F6DD0", VA = "0x1891F7DD0")]
		private Vector3 SXEGISBNTSL(float a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x91F8A50", Offset = "0x91F7A50", VA = "0x1891F8A50")]
		protected ButtonThemeBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x1A1D720", Offset = "0x1A1C720", VA = "0x181A1D720")]
		[CompilerGenerated]
		private void MHRWROLEVUN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x1A1D720", Offset = "0x1A1C720", VA = "0x181A1D720")]
		[CompilerGenerated]
		private void ITPCQTJUSXH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public class DepthTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		[SerializeField]
		private DepthPaletteType depth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		[SerializeField]
		private bool animateOnEnable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		[SerializeField]
		[ConditionalField("animateOnEnable")]
		private float animationTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private Vector3? DIIFMRPFOMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private Vector2 MPSGCDMDRSG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private Vector2 YMCWQPCOPDS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private Vector2 WTFRNRZNEHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private Vector2 HYTJEVHCBFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private Vector2 JWMXTYTSEOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private Vector2 VPXUDGKHJUS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private readonly bool? LLSSJHFZZRA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private QOJRPAWOBVO CGIUBSQLMSQ;

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		private RectTransform KZAAKKZHGOJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x91F9A80", Offset = "0x91F8A80", VA = "0x1891F9A80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public DepthPaletteType NVROYQILIWN
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0xAD13C0", Offset = "0xAD03C0", VA = "0x180AD13C0")]
			get
			{
				return default(DepthPaletteType);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x91F9CA0", Offset = "0x91F8CA0", VA = "0x1891F9CA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		private QOJRPAWOBVO KDBXOEIKMUV
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x91F98D0", Offset = "0x91F88D0", VA = "0x1891F98D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		private bool BWOKQDBIZBI
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x91F9140", Offset = "0x91F8140", VA = "0x1891F9140")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x91F9A10", Offset = "0x91F8A10", VA = "0x1891F9A10")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x91F9960", Offset = "0x91F8960", VA = "0x1891F9960")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x91F8F50", Offset = "0x91F7F50", VA = "0x1891F8F50", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x91F95B0", Offset = "0x91F85B0", VA = "0x1891F95B0")]
		private void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x91F9230", Offset = "0x91F8230", VA = "0x1891F9230")]
		private Vector3 IPFXENNLPFM()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x91F9AE0", Offset = "0x91F8AE0", VA = "0x1891F9AE0")]
		public DepthTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public class DropdownTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private Dropdown dropdown;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		[SerializeField]
		[AutofillOptional(AutofillType.Self, false, true, false)]
		private Image surface;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		[SerializeField]
		private bool useSurfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		[SerializeField]
		[ConditionalField("useSurfaceOverride")]
		private Image surfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		[SerializeField]
		private DropdownPaletteType dropdownType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		[SerializeField]
		private TextSizePaletteType textSize;

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public Image TKQZMJELSQY
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x91FA330", Offset = "0x91F9330", VA = "0x1891FA330")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public DropdownPaletteType XIKEAJZUQGX
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0xBE8B90", Offset = "0xBE7B90", VA = "0x180BE8B90")]
			get
			{
				return default(DropdownPaletteType);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x91FA340", Offset = "0x91F9340", VA = "0x1891FA340")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public TextSizePaletteType YBBDREJXMJA
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x15CA4C0", Offset = "0x15C94C0", VA = "0x1815CA4C0")]
			get
			{
				return default(TextSizePaletteType);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x91FA360", Offset = "0x91F9360", VA = "0x1891FA360")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x91F9CE0", Offset = "0x91F8CE0", VA = "0x1891F9CE0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x91FA2E0", Offset = "0x91F92E0", VA = "0x1891FA2E0")]
		public DropdownTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public class GraphicTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private Graphic graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		[SerializeField]
		private bool useGraphicOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		[SerializeField]
		[ConditionalField("useGraphicOverride")]
		private Graphic graphicOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		[SerializeField]
		private ForegroundColorPaletteType color;

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public Graphic TCZHOWPJVNJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x91FB300", Offset = "0x91FA300", VA = "0x1891FB300")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public ForegroundColorPaletteType TPZAQBXWZVE
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0xAEC5E0", Offset = "0xAEB5E0", VA = "0x180AEC5E0")]
			get
			{
				return default(ForegroundColorPaletteType);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x91FB310", Offset = "0x91FA310", VA = "0x1891FB310")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public bool KQTVTSUUQUW
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x1AAD3A0", Offset = "0x1AAC3A0", VA = "0x181AAD3A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x1AAD3B0", Offset = "0x1AAC3B0", VA = "0x181AAD3B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public Color? LDHSWRATPZY
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x91FB0E0", Offset = "0x91FA0E0", VA = "0x1891FB0E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x91FAE90", Offset = "0x91F9E90", VA = "0x1891FAE90", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x91FB090", Offset = "0x91FA090", VA = "0x1891FB090")]
		public GraphicTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public class InputFieldTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private TMP_InputField inputField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		[SerializeField]
		[AutofillOptional(AutofillType.Self, false, false, false)]
		private Image surface;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		[SerializeField]
		private bool useSurfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		[SerializeField]
		[ConditionalField("useSurfaceOverride")]
		private Image surfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		[SerializeField]
		private InputFieldPaletteType inputFieldType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		[SerializeField]
		private TextSizePaletteType textSize;

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public Image TKQZMJELSQY
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x91FA330", Offset = "0x91F9330", VA = "0x1891FA330")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public InputFieldPaletteType MMBLMTTRQUU
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0xBE8B90", Offset = "0xBE7B90", VA = "0x180BE8B90")]
			get
			{
				return default(InputFieldPaletteType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x91FA340", Offset = "0x91F9340", VA = "0x1891FA340")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public TextSizePaletteType YBBDREJXMJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x15CA4C0", Offset = "0x15C94C0", VA = "0x1815CA4C0")]
			get
			{
				return default(TextSizePaletteType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x91FA360", Offset = "0x91F9360", VA = "0x1891FA360")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x91FB360", Offset = "0x91FA360", VA = "0x1891FB360", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x91FB830", Offset = "0x91FA830", VA = "0x1891FB830")]
		public InputFieldTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public class LabelTheme : GraphicTheme
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private TextMeshProUGUI textMeshProUGUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		[SerializeField]
		private TextStylePaletteType textType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		[SerializeField]
		private TextSizePaletteType textSize;

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public TextStylePaletteType KFORFJJCNKV
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0xF8B490", Offset = "0xF8A490", VA = "0x180F8B490")]
			get
			{
				return default(TextStylePaletteType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x91FBBE0", Offset = "0x91FABE0", VA = "0x1891FBBE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public TextSizePaletteType YBBDREJXMJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x1401550", Offset = "0x1400550", VA = "0x181401550")]
			get
			{
				return default(TextSizePaletteType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x91FBBC0", Offset = "0x91FABC0", VA = "0x1891FBBC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x91FB880", Offset = "0x91FA880", VA = "0x1891FB880", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x91FBB70", Offset = "0x91FAB70", VA = "0x1891FBB70")]
		public LabelTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public class MakerPenToolTheme : ButtonThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		[Header("Maker Pen Tool")]
		[SerializeField]
		private MakerPenToolPaletteType makerPenToolPaletteType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		[SerializeField]
		[Tooltip("A list of objects to show while the maker pen tool is active.")]
		private List<Hideable> hideWhenNotActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		[SerializeField]
		[Tooltip("A list of objects to show while the maker pen tool is inactive")]
		private List<Hideable> hideWhenActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		[SerializeField]
		private bool editorIsActiveOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x169")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		protected bool ZNTQYXGKDKW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x16A")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private bool PWELXRYZKBZ;

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public MakerPenToolPaletteType CUXOQUQTTGX
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x190F6A0", Offset = "0x190E6A0", VA = "0x18190F6A0")]
			get
			{
				return default(MakerPenToolPaletteType);
			}
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x91F8EB0", Offset = "0x91F7EB0", VA = "0x1891F8EB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public bool OMLXMZQWLXR
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x2462680", Offset = "0x2461680", VA = "0x182462680")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x91FC0A0", Offset = "0x91FB0A0", VA = "0x1891FC0A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x91FC060", Offset = "0x91FB060", VA = "0x1891FC060", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x91FBC80", Offset = "0x91FAC80", VA = "0x1891FBC80", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x91F8EA0", Offset = "0x91F7EA0", VA = "0x1891F8EA0")]
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
			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			Inactive,
			[Cpp2IlInjected.Token(Token = "0x40001A8")]
			Mixed,
			[Cpp2IlInjected.Token(Token = "0x40001A9")]
			Active
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		[SerializeField]
		private MixedTogglePaletteType toggleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		[SerializeField]
		[Tooltip("A list of objects to hide while the toggle is inactive.")]
		private List<Hideable> hideWhenInactive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		[SerializeField]
		[Tooltip("A list of objects to hide while the toggle is mixed.")]
		private List<Hideable> hideWhenMixed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		[SerializeField]
		[Tooltip("A list of objects to hide while the toggle is active")]
		private List<Hideable> hideWhenActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		[SerializeField]
		private ToggleState editorIsActiveOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x174")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private ToggleState PWELXRYZKBZ;

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public ToggleState OMLXMZQWLXR
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x91FC760", Offset = "0x91FB760", VA = "0x1891FC760")]
			get
			{
				return default(ToggleState);
			}
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x91FC740", Offset = "0x91FB740", VA = "0x1891FC740")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x91FC710", Offset = "0x91FB710", VA = "0x1891FC710")]
		public void Toggle()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x91FC740", Offset = "0x91FB740", VA = "0x1891FC740")]
		public void Toggle(ToggleState isActive, bool isInstant)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x91FC160", Offset = "0x91FB160", VA = "0x1891FC160", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x91F8EA0", Offset = "0x91F7EA0", VA = "0x1891F8EA0")]
		public MixedToggleTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class PaletteTheme : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		[SerializeField]
		private bool usePaletteOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		[SerializeField]
		[ConditionalField("usePaletteOverride")]
		private Palette paletteOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public JICXVMFHZKR PaletteChangeEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		[SerializeField]
		private bool useDepth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private NSVFBUEKZEH HLDOQRQFSYU;

		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private const string MBZFTOMJPGV = "watch_layer";

		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private const string CMBQAMWJGVX = "depth_multiplier";

		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private const float DNZYMFBNODJ = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private float? MHTXOCJJGMR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private float? PRBGXUMODJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private float? AEYIHUHKOEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private float KNNJMALZBCS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private float JPXKAFLDCHT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private float HQURLYXSJAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private float ERQKCVTPYPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private readonly VOFSXJFIEEZ IYLQTXKKFGQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private SFXAudioSource SXXLVYFMFVR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		private SFXAudioSource QCTHZOBNQQP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		private ContentLoadingAudioPaletteAsset WZPJGGGOEUP;

		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private const float KBGMRKRYOKC = 0.001f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		private NAWQBAKWVIF CMWLVNMKLOE;

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public Palette TZFPLFLERDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x91FEE40", Offset = "0x91FDE40", VA = "0x1891FEE40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public bool LYTPPTJWEKZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0xAFB5D0", Offset = "0xAFA5D0", VA = "0x180AFB5D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public float JPOFCCYFHEN
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x91FEBC0", Offset = "0x91FDBC0", VA = "0x1891FEBC0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		private bool BKLQQDTYHOA
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x91FDE10", Offset = "0x91FCE10", VA = "0x1891FDE10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		private bool WWXSGDVZLRX
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x91FE480", Offset = "0x91FD480", VA = "0x1891FE480")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x91FDC70", Offset = "0x91FCC70", VA = "0x1891FDC70")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x91FE320", Offset = "0x91FD320", VA = "0x1891FE320")]
		private void ONOCRVTSWYP(YYPINFGCIFQ.ThemeOptions a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x91FE360", Offset = "0x91FD360", VA = "0x1891FE360")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x91FE830", Offset = "0x91FD830", VA = "0x1891FE830")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x91FDF80", Offset = "0x91FCF80", VA = "0x1891FDF80")]
		private void FWGGWNXMEEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x91FDB50", Offset = "0x91FCB50", VA = "0x1891FDB50")]
		public void AddLoadingSFXRequest(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x91FE710", Offset = "0x91FD710", VA = "0x1891FE710")]
		public void RemoveLoadingSFXRequest(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x91FE830", Offset = "0x91FD830", VA = "0x1891FE830")]
		private void UMZRFMWNGFQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x91FD960", Offset = "0x91FC960", VA = "0x1891FD960")]
		private void AYXKZQINVFV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x91FE9A0", Offset = "0x91FD9A0", VA = "0x1891FE9A0")]
		private void VVOGHZITYKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x91FE140", Offset = "0x91FD140", VA = "0x1891FE140")]
		private void HGIZCIYVBVZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x91FD6F0", Offset = "0x91FC6F0", VA = "0x1891FD6F0")]
		private void AJQLMJRCABC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x91FDE90", Offset = "0x91FCE90", VA = "0x1891FDE90")]
		private void FCSQACPBQIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x91FE350", Offset = "0x91FD350", VA = "0x1891FE350")]
		private void OOTXZOURTFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x91FE230", Offset = "0x91FD230", VA = "0x1891FE230")]
		private void MXJBYXNFMLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x91FE6D0", Offset = "0x91FD6D0", VA = "0x1891FE6D0")]
		private void QHRSEZKBAEQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x91FE500", Offset = "0x91FD500", VA = "0x1891FE500")]
		public void Play2DUIFlavorSFX(RecRoomAudioClip[] flavorSFXPool)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x91FEB10", Offset = "0x91FDB10", VA = "0x1891FEB10")]
		public PaletteTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public abstract class PaletteThemeReference : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		protected static readonly Log BMHSVNOOAKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		[SerializeField]
		[AutofillOptional(AutofillType.SelfAndParent, true, false, false)]
		private PaletteTheme paletteTheme;

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		protected PaletteTheme UKMDZOIMSSN
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0xAD0670", Offset = "0xACF670", VA = "0x180AD0670")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		protected Palette TZFPLFLERDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x91FD2F0", Offset = "0x91FC2F0", VA = "0x1891FD2F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		protected bool BEAKKSSDOVO
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x91FD600", Offset = "0x91FC600", VA = "0x1891FD600")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		protected Transform NSCFUXAEHZT
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x91FD580", Offset = "0x91FC580", VA = "0x1891FD580")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x91FCFB0", Offset = "0x91FBFB0", VA = "0x1891FCFB0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x91FD3D0", Offset = "0x91FC3D0", VA = "0x1891FD3D0", Slot = "5")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void Apply();

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x91FD130", Offset = "0x91FC130", VA = "0x1891FD130")]
		public Color? GetColorFromPalette(ForegroundColorPaletteType paletteType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x91FD4B0", Offset = "0x91FC4B0", VA = "0x1891FD4B0")]
		private void SFEOHWGAQQO(bool a = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0xACE140", Offset = "0xACD140", VA = "0x180ACE140")]
		protected PaletteThemeReference()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public class RangeSliderTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private RangeSlider slider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		[SerializeField]
		private SliderPaletteType sliderType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		[SerializeField]
		private Image sliderImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		[SerializeField]
		private Image fillImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		[SerializeField]
		private Image lowHandleImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		[SerializeField]
		private Image highHandleImage;

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public SliderPaletteType PZNZNMRTEEP
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0xACFF50", Offset = "0xACEF50", VA = "0x180ACFF50")]
			get
			{
				return default(SliderPaletteType);
			}
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x91FFFA0", Offset = "0x91FEFA0", VA = "0x1891FFFA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public Image KQPJXWTZZRX
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0xACFF60", Offset = "0xACEF60", VA = "0x180ACFF60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public Image MPOIAXGEUUB
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0xACFFA0", Offset = "0xACEFA0", VA = "0x180ACFFA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public Image FBIPQBKKJCI
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0xAD6750", Offset = "0xAD5750", VA = "0x180AD6750")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public Image LDZQXTICEFS
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0xACEE90", Offset = "0xACDE90", VA = "0x180ACEE90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public bool QTVDTFJXATR
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x7A75D40", Offset = "0x7A74D40", VA = "0x187A75D40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x7A75A80", Offset = "0x7A74A80", VA = "0x187A75A80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x91FFC50", Offset = "0x91FEC50", VA = "0x1891FFC50", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x91FFF50", Offset = "0x91FEF50", VA = "0x1891FFF50")]
		public RangeSliderTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class RawImageTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private RawImage image;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		[SerializeField]
		private RawImageColorPaletteType color;

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public RawImageColorPaletteType WYNTFXVUSFW
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0xACFF50", Offset = "0xACEF50", VA = "0x180ACFF50")]
			get
			{
				return default(RawImageColorPaletteType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x91FFFA0", Offset = "0x91FEFA0", VA = "0x1891FFFA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x91FFFC0", Offset = "0x91FEFC0", VA = "0x1891FFFC0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x92000F0", Offset = "0x91FF0F0", VA = "0x1892000F0")]
		public RawImageTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public class RecyclingGridTheme : RecyclingThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private GKSYEYRKGGW recyclingGrid;

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x9200140", Offset = "0x91FF140", VA = "0x189200140", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x9200320", Offset = "0x91FF320", VA = "0x189200320", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x9200500", Offset = "0x91FF500", VA = "0x189200500")]
		private void XGIZWUWQNVI(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x9200570", Offset = "0x91FF570", VA = "0x189200570")]
		public RecyclingGridTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public class RecyclingListTheme : RecyclingThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private GKSYEYRKGGW recyclingList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		private bool KHZLTSQQGLX;

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x92005C0", Offset = "0x91FF5C0", VA = "0x1892005C0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x92007E0", Offset = "0x91FF7E0", VA = "0x1892007E0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x92009C0", Offset = "0x91FF9C0", VA = "0x1892009C0")]
		private void YYSRJNYDNHE(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x9200570", Offset = "0x91FF570", VA = "0x189200570")]
		public RecyclingListTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public abstract class RecyclingThemeBase : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		[Header("Audio")]
		[SerializeField]
		private RecyclingAudioPaletteType recyclingAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		protected RecyclingAudioPaletteAsset QEDPLMPGMGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		[SerializeField]
		private ScrollingAudioPaletteType scrollingAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private ScrollingAudioPaletteAsset JGVRBEVSBCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private NAWQBAKWVIF PWPLXYWECGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private float EDZHVRJAHAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private float EVLUGDOKNPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		private float TQETXYSOLNT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private float DPNLBWTZSEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private bool JLWAKRJHOGL;

		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private const float VDULYJGBKOL = 0.01f;

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		private NAWQBAKWVIF CMWLVNMKLOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x9200C10", Offset = "0x91FFC10", VA = "0x189200C10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x9200A30", Offset = "0x91FFA30", VA = "0x189200A30", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x9200CA0", Offset = "0x91FFCA0", VA = "0x189200CA0")]
		protected void JAVQHJFJZQV(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x9200F60", Offset = "0x91FFF60", VA = "0x189200F60")]
		protected void KCTLWKNRULF(GameObject a, int b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x9201790", Offset = "0x9200790", VA = "0x189201790")]
		protected void YNZIARWTBUR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x92010F0", Offset = "0x92000F0", VA = "0x1892010F0")]
		protected void LKURZHTWWVU(float a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x9201460", Offset = "0x9200460", VA = "0x189201460")]
		private void NFKSPVJBHMC(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x9201650", Offset = "0x9200650", VA = "0x189201650")]
		private void UERXLVLIYWO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x9200570", Offset = "0x91FF570", VA = "0x189200570")]
		protected RecyclingThemeBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public class ScrollBarTheme : SelectableThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		[Header("Scroll Bar Audio")]
		[SerializeField]
		private ButtonAudioPaletteType buttonAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		[SerializeField]
		[Tooltip("Layer a 2D SFX on top of base button sounds")]
		private bool useFlavorSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		[SerializeField]
		[ConditionalField("useFlavorSFX")]
		[Tooltip("Flavor SFX is picked randomly from this pool config")]
		private RecRoomAudioClipPoolConfig flavorSFXClipPoolConfig;

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x9201920", Offset = "0x9200920", VA = "0x189201920", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x9201A60", Offset = "0x9200A60", VA = "0x189201A60")]
		public ScrollBarTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public class ScrollRectTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		private const string VGHHNXAKVWZ = "RRUI.PlayHittingEndsSFX";

		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		private const int YGXKRNHYOAP = 5;

		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		private const int CXLSLJHOKBT = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		private DateTimeOffset TWKXYWRZXMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		private int CQEVNQRSOBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private bool SBKJGAXRQZF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private ScrollRect scrollRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		[Header("Audio")]
		[SerializeField]
		private ScrollingAudioPaletteType scrollAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private ScrollingAudioPaletteAsset QEDPLMPGMGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private NAWQBAKWVIF PWPLXYWECGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		private BJTZTZWMPIP UJRTRUGHFCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private float EVLUGDOKNPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		private float TQETXYSOLNT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		private float DPNLBWTZSEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private bool JLWAKRJHOGL;

		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private const float VDULYJGBKOL = 0.01f;

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		private NAWQBAKWVIF CMWLVNMKLOE
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x9202120", Offset = "0x9201120", VA = "0x189202120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		private BJTZTZWMPIP RXGIKDEIOIK
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x92025B0", Offset = "0x92015B0", VA = "0x1892025B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x9201B50", Offset = "0x9200B50", VA = "0x189201B50", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x92024C0", Offset = "0x92014C0", VA = "0x1892024C0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x9201A70", Offset = "0x9200A70", VA = "0x189201A70", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x9201CE0", Offset = "0x9200CE0", VA = "0x189201CE0")]
		private void BNUURFHBEMY(Vector2 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x92022D0", Offset = "0x92012D0", VA = "0x1892022D0")]
		private void NFKSPVJBHMC(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x9202640", Offset = "0x9201640", VA = "0x189202640")]
		private void UERXLVLIYWO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x92021B0", Offset = "0x92011B0", VA = "0x1892021B0")]
		private static string MHOWUBTVGOZ(GameObject a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x9202EE0", Offset = "0x9201EE0", VA = "0x189202EE0")]
		public ScrollRectTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public abstract class SelectableThemeBase : PaletteThemeReference, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IPointerClickHandler, IPointerEnterHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		[Header("Selectable Theme Base")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		[FormerlySerializedAs("button")]
		private Selectable selectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		[Header("Legacy Audio Override")]
		[SerializeField]
		[FormerlySerializedAs("overrideAudio")]
		[Tooltip("Override base selectable audio with a single SFX that plays only on click.")]
		protected bool overrideWithSingleAudio;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		[SerializeField]
		[ConditionalField("overrideWithSingleAudio")]
		[Tooltip("The legacy override audio will be randomly picked from this pool")]
		protected RecRoomAudioClip[] randomAudioOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		protected bool CNMVFZTWDUP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private ButtonAudioPaletteAsset QEDPLMPGMGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private RecRoomAudioClipPoolConfig KBNMKLEIDLZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		private VOFSXJFIEEZ DVWAWWMMMZF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		private VOFSXJFIEEZ ZBLIJIDZBUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		private VOFSXJFIEEZ JZHKGNAINTD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		private VOFSXJFIEEZ HHVQUFYJIDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private NAWQBAKWVIF PWPLXYWECGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private FRDKGRNIRPF XKTEQUANAVD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		private OLNQEWVYKXU SZQXIJEBYVS;

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		protected Selectable GIDDJOKWPEV
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0xACFF90", Offset = "0xACEF90", VA = "0x180ACFF90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		protected virtual bool VLCBTZKAUYB
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0xAE9210", Offset = "0xAE8210", VA = "0x180AE9210", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public bool QTVDTFJXATR
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x7A75D40", Offset = "0x7A74D40", VA = "0x187A75D40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x7A75A80", Offset = "0x7A74A80", VA = "0x187A75A80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		private NAWQBAKWVIF CMWLVNMKLOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x9202F70", Offset = "0x9201F70", VA = "0x189202F70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		protected FRDKGRNIRPF NGCJZOKARSE
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x9203D50", Offset = "0x9202D50", VA = "0x189203D50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		private OLNQEWVYKXU KGJNRQHYROJ
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x92030C0", Offset = "0x92020C0", VA = "0x1892030C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x9203590", Offset = "0x9202590", VA = "0x189203590")]
		protected void MAGBBGKIXSS(ButtonAudioPaletteAsset a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xACEBC0", Offset = "0xACDBC0", VA = "0x180ACEBC0")]
		protected void YMNWPHAWQGZ(RecRoomAudioClipPoolConfig a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x9203A00", Offset = "0x9202A00", VA = "0x189203A00", Slot = "12")]
		public virtual void OnPointerDown(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x9203BB0", Offset = "0x9202BB0", VA = "0x189203BB0", Slot = "13")]
		public virtual void OnPointerUp(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x9203690", Offset = "0x9202690", VA = "0x189203690", Slot = "14")]
		public virtual void OnPointerClick(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x9203AE0", Offset = "0x9202AE0", VA = "0x189203AE0", Slot = "15")]
		public virtual void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x9203000", Offset = "0x9202000", VA = "0x189203000")]
		private void HPUDTCTFZPT(RecRoomAudioClip[] a, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x9203160", Offset = "0x9202160", VA = "0x189203160")]
		private void KHIDQHYPXVP(RecRoomAudioClip a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x9203CC0", Offset = "0x9202CC0", VA = "0x189203CC0")]
		public void SetOnPointerDownSoundEffectDisabled(object token, bool disabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x9203D20", Offset = "0x9202D20", VA = "0x189203D20")]
		public void SetOnPointerUpSoundEffectDisabled(object token, bool disabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x9203C90", Offset = "0x9202C90", VA = "0x189203C90")]
		public void SetOnPointerClickSoundEffectDisabled(object token, bool disabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x9203CF0", Offset = "0x9202CF0", VA = "0x189203CF0")]
		public void SetOnPointerEnterSoundEffectDisabled(object token, bool disabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x9203080", Offset = "0x9202080", VA = "0x189203080")]
		private void JAFZZOFMRGJ(VOFSXJFIEEZ a, object b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x9203DF0", Offset = "0x9202DF0", VA = "0x189203DF0")]
		protected SelectableThemeBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class SliderTheme : SelectableThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		[Header("Slider Visual")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private Slider slider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		[SerializeField]
		private SliderPaletteType sliderType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		[Header("Slider Audio")]
		[SerializeField]
		private ButtonAudioPaletteType buttonAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		[SerializeField]
		[Tooltip("Layer a 2D SFX on top of base button sounds")]
		private bool useFlavorSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		[SerializeField]
		[ConditionalField("useFlavorSFX")]
		[Tooltip("Flavor SFX is picked randomly from this pool config")]
		private RecRoomAudioClipPoolConfig flavorSFXClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		[SerializeField]
		private Image sliderImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		[SerializeField]
		private Image fillImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		[SerializeField]
		private Image handleImage;

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public SliderPaletteType PZNZNMRTEEP
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x16EDB20", Offset = "0x16ECB20", VA = "0x1816EDB20")]
			get
			{
				return default(SliderPaletteType);
			}
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x92043F0", Offset = "0x92033F0", VA = "0x1892043F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public Image KQPJXWTZZRX
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0xC1E5E0", Offset = "0xC1D5E0", VA = "0x180C1E5E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public Image MPOIAXGEUUB
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0xFBF1D0", Offset = "0xFBE1D0", VA = "0x180FBF1D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public Image KHSBIWVWIYE
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0xC1E630", Offset = "0xC1D630", VA = "0x180C1E630")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x9204000", Offset = "0x9203000", VA = "0x189204000", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x92043D0", Offset = "0x92033D0", VA = "0x1892043D0")]
		public SliderTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public class SurfaceTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private Image image;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		[SerializeField]
		[AutofillOptional(AutofillType.Self, false, false, false)]
		private UIGradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		[SerializeField]
		private BackgroundColorPaletteType color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		[SerializeField]
		[ConditionalField("gradient")]
		private bool ignoreGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		[SerializeField]
		[Tooltip("The surface theme determines if this Image is a RaycastTarget or not. There are times when you might want to ignore that setting of the palette theme and just respect whatever is the default state on the Image.")]
		private bool ignoreSettingRaycastTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private BackgroundColorPaletteType? IBACHBPJIZH;

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public BackgroundColorPaletteType NPXUWNOEZUH
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x9204710", Offset = "0x9203710", VA = "0x189204710")]
			get
			{
				return default(BackgroundColorPaletteType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x9204770", Offset = "0x9203770", VA = "0x189204770")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x9204410", Offset = "0x9203410", VA = "0x189204410", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x92046A0", Offset = "0x92036A0", VA = "0x1892046A0", Slot = "7")]
		public virtual void OverrideBackgroundColorPaletteAtRuntime(BackgroundColorPaletteType? backgroundPalette)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x92046C0", Offset = "0x92036C0", VA = "0x1892046C0")]
		public SurfaceTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public class SwitchTheme : ToggleTheme
	{
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private const float IXSACMBAVCC = 0.33f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		[Header("Switch")]
		[SerializeField]
		private GameObject indicator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		[SerializeField]
		private GameObject indicatorOffPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		[SerializeField]
		private GameObject indicatorOnPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		private QLMCBPGELJU XDLINFGCMFK;

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x9204790", Offset = "0x9203790", VA = "0x189204790", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x92049F0", Offset = "0x92039F0", VA = "0x1892049F0")]
		public SwitchTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class TilerTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private UITiler tiler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		[SerializeField]
		private TilerPaletteType type;

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x9205000", Offset = "0x9204000", VA = "0x189205000", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x9205290", Offset = "0x9204290", VA = "0x189205290")]
		public TilerTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public class ToggleTheme : ButtonThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		[Header("Toggle Visual")]
		[SerializeField]
		private TogglePaletteType toggleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		[SerializeField]
		[Tooltip("A list of objects to show while the toggle is active.")]
		private List<Hideable> hideWhenNotActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		[SerializeField]
		[Tooltip("A list of objects to show while the toggle is inactive")]
		private List<Hideable> hideWhenActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		[SerializeField]
		private bool editorIsActiveOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x169")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		[Header("Toggle Audio")]
		[SerializeField]
		[Tooltip("Override the audio palette when active defined by the toggle's visual with a custom palette")]
		private bool overrideAudioPaletteWhenActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		[SerializeField]
		[ConditionalField("overrideAudioPaletteWhenActive")]
		[Tooltip("Specify a custom config to use for toggle button audio when active")]
		private ButtonAudioPaletteAsset customButtonAudioConfigWhenActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		[SerializeField]
		[Tooltip("Override the audio palette when inactive defined by the toggle's visual with a custom palette")]
		private bool overrideAudioPaletteWhenInactive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		[SerializeField]
		[ConditionalField("overrideAudioPaletteWhenInactive")]
		[Tooltip("Specify a custom config to use for toggle button audio when inactive")]
		private ButtonAudioPaletteAsset customButtonAudioConfigWhenInactive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		[SerializeField]
		[Tooltip("Layer a 2D SFX on top of base button sounds. Flavor SFX only plays when toggling from inactive to active")]
		private bool useFlavorSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		[SerializeField]
		[ConditionalField("useFlavorSFX")]
		[Tooltip("Flavor SFX is picked randomly from this pool config")]
		private RecRoomAudioClipPoolConfig flavorSFXClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		protected bool ZNTQYXGKDKW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x199")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private bool WMSDDFNXGIX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19A")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		private bool PWELXRYZKBZ;

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public bool OMLXMZQWLXR
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x92057A0", Offset = "0x92047A0", VA = "0x1892057A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x92057B0", Offset = "0x92047B0", VA = "0x1892057B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public TogglePaletteType WCYNKWNQSPO
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x190F6A0", Offset = "0x190E6A0", VA = "0x18190F6A0")]
			get
			{
				return default(TogglePaletteType);
			}
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x91F8EB0", Offset = "0x91F7EB0", VA = "0x1891F8EB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		protected override bool VLCBTZKAUYB
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x92052E0", Offset = "0x92042E0", VA = "0x1892052E0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x92056E0", Offset = "0x92046E0", VA = "0x1892056E0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x9205760", Offset = "0x9204760", VA = "0x189205760")]
		public void Toggle()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x9205720", Offset = "0x9204720", VA = "0x189205720")]
		public void Toggle(bool isActive, bool isInstant)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x92052F0", Offset = "0x92042F0", VA = "0x1892052F0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x92049F0", Offset = "0x92039F0", VA = "0x1892049F0")]
		public ToggleTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public class ActiveEventThemeSwapper : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		[SerializeField]
		private string eventActiveGameConfigKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		[SerializeField]
		private bool swapSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		[ConditionalField("swapSprite")]
		[SerializeField]
		private Image targetImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		[ConditionalField("swapSprite")]
		[SerializeField]
		private Sprite targetSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		[SerializeField]
		private bool swapSurfaceTheme;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		[ConditionalField("swapSurfaceTheme")]
		[SerializeField]
		private SurfaceTheme targetSurfaceTheme;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		[ConditionalField("swapSurfaceTheme")]
		[SerializeField]
		private BackgroundColorPaletteType targetPalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		[SerializeField]
		private bool changeGradientDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		[ConditionalField("changeGradientDirection")]
		[SerializeField]
		private UIGradient targetGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		[ConditionalField("changeGradientDirection")]
		[SerializeField]
		private UIGradient.GradientType targetGradientType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		private TCTADUFTGKI HTGCNFGBCXM;

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x91F6710", Offset = "0x91F5710", VA = "0x1891F6710")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x91F6670", Offset = "0x91F5670", VA = "0x1891F6670")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x91F6860", Offset = "0x91F5860", VA = "0x1891F6860")]
		private void UPLMOQFWEKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x91F6520", Offset = "0x91F5520", VA = "0x1891F6520")]
		private void GCHVIURSHTI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x91F6AB0", Offset = "0x91F5AB0", VA = "0x1891F6AB0")]
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
